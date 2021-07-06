using System;
using System.Collections.Generic;
using System.IO;
using NHapi.Base.Model;
using NHapiTools.Base.IO;
using NHapiTools.Base.Util;
using NUnit.Framework;

namespace NHapiTools.Tests
{
    [TestFixture]
    public class AckTests
    {
        private IDictionary<string, Type> AckTypes { get; } = new Dictionary<string, Type>
        {
            {"2.3", typeof(NHapi.Model.V23.Message.ACK) },
            {"2.4", typeof(NHapi.Model.V24.Message.ACK) },
            {"2.5", typeof(NHapi.Model.V25.Message.ACK) }
        };

        [Test(Description = "Ack can be generated")]
        public void GenericMessageWrapper_AllowsOverridingSegments()
        {
            Console.WriteLine("\n==============================================\nTesting Ack generation.");

            var ack = new Ack("TestApplication", "Development");

            foreach (var message in GetHl7IMessages())
            {
                var ackMessage = ack.MakeACK(message);
                var expectedAckType = AckTypes[message.Version];

                Assert.IsInstanceOf(expectedAckType, ackMessage);
                Assert.AreEqual(message.Version, ackMessage.Version);

                Console.WriteLine("{0} message for V{1}.", ackMessage.GetStructureName(), ackMessage.Version);
            }
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
