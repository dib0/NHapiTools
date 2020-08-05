using System.Collections.Generic;
using System.IO;
using System.Linq;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Model.V23.Message;
using NHapiTools.Base;
using NHapiTools.Base.IO;
using NHapiTools.Model.V23.Segment;
using Xunit;
using Xunit.Abstractions;

namespace NHapiTools.Tests
{
    public class ExtensionsTests
    {
        private ITestOutputHelper Output { get; }

        private IList<IMessage> A08Messages { get; }

        public ExtensionsTests(ITestOutputHelper output)
        {
            Output = output;
            A08Messages =
                GetHl7IMessages()
                    .Where(m => m.Version == "2.3" && m.GetStructureName() == "ADT_A08")
                    .ToList();
        }

        [Fact(DisplayName = "IsEqual can compare equality for IMessage")]
        public void IsEqual_CanCompareEqualityForIMassage()
        {
            Output.WriteLine("\n==============================================\nTesting IMessage IsEqual extension method on ADT_A08 (HL7 V2.3) messages.");

            Output.WriteLine("\nFound {0} A08 messages.\n", A08Messages.Count);

            // Compare messages
            Output.WriteLine("Compare A08 messages.");
            Assert.True(A08Messages[0].IsEqual(A08Messages[0]));
            Assert.False(A08Messages[0].IsEqual(A08Messages[1]));
            Output.WriteLine("A08_1 {0} A08_1.", A08Messages[0].IsEqual(A08Messages[0]) ? "is the same as" : "isn't the same as");
            Output.WriteLine("A08_1 {0} A08_2.", A08Messages[0].IsEqual(A08Messages[1]) ? "is the same as" : "isn't the same as");

            Output.WriteLine("\nDone!");
        }

        [Fact(DisplayName = "IsEqual can compare equality for ISegment")]
        public void IsEqual_CanCompareEqualityForISegments()
        {
            Output.WriteLine("\n==============================================\nTesting ISegment IsEqual extension method on ADT_A08 (HL7 V2.3) messages.");

            Output.WriteLine("\nFound {0} A08 messages.\n", A08Messages.Count);

            // Compare segments
            var s1 = (ISegment)A08Messages[0].GetStructure("PID");
            var s2 = (ISegment)A08Messages[1].GetStructure("PID");

            Output.WriteLine("Compare PID segments.");

            Assert.True(s1.IsEqual(s1));
            Assert.False(s1.IsEqual(s2));

            Output.WriteLine("PID1 {0} PID1.", s1.IsEqual(s1) ? "is the same as" : "isn't the same as");
            Output.WriteLine("PID1 {0} PID2.", s1.IsEqual(s2) ? "is the same as" : "isn't the same as");

            Output.WriteLine("\nDone!");
        }

        [Fact(DisplayName = "GetPatientAddressRecords returns all XAD patient address segments.")]
        public void GetPatientAddressRecords_GetsXADAddressSegments()
        {
            Output.WriteLine("\n==============================================\nTesting GetPatientAddressRecords extension method on ADT_A08 (HL7 V2.3) messages.");

            Assert.NotEmpty(A08Messages);

            foreach (var a08 in A08Messages.Cast<ADT_A08>())
            {
                Output.WriteLine("Getting address from message.");

                var xads = a08.PID.GetPatientAddressRecords().Cast<XAD>().ToList();

                Assert.NotEmpty(xads);

                foreach (var xad in xads)
                {
                    var x = xad.StreetAddress.Value;
                    Output.WriteLine("Found street record '{0}'.", x);
                }
            }

            Output.WriteLine("\nDone!");
        }

        [Fact(DisplayName = "AddPatientAddress adds new XAD segment to patient address.")]
        public void AddPatientAddress_AddsXADAddressSegments()
        {
            Output.WriteLine("\n==============================================\nTesting AddPatientAddress extension method on ADT_A08 (HL7 V2.3) messages.");

            var a08 = A08Messages.Last() as ADT_A08;
            var expectedDifference = 1;

            Output.WriteLine("Testing Add method.");
            var initialAddressRepetitionsCount = a08.PID.PatientAddressRepetitionsUsed;
            Output.WriteLine("Message has {0} PatientAddress record(s).", initialAddressRepetitionsCount);

            Output.WriteLine("Adding record.");
            a08.PID.AddPatientAddress();
            Output.WriteLine("Message has {0} PatientAddress record(s): ", a08.PID.PatientAddressRepetitionsUsed);

            var actualDifference = a08.PID.PatientAddressRepetitionsUsed - initialAddressRepetitionsCount;

            Assert.Equal(expectedDifference, actualDifference);

            Output.WriteLine(actualDifference == expectedDifference ? "OK!" : "Failure!");

            Output.WriteLine("\nDone!");
        }


        private IList<IMessage> GetHl7IMessages()
        {
            var currentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            var testMessageDirectory = Path.Combine(currentDirectory, "TestMessages");

            var directoryInfo = new DirectoryInfo(testMessageDirectory);
            var multipleFilesStream = new MultipleFilesStream(directoryInfo);
            multipleFilesStream.FileEndMarker = '\n';

            var messages = new List<IMessage>();

            using (var enumerator = new HL7InputStreamMessageEnumerator(multipleFilesStream))
            {
                while (enumerator.MoveNext())
                {
                    var message = enumerator.Current;
                    if (message != null)
                    {
                        messages.Add(message);
                    }
                }
            }

            return messages;
        }
    }
}
