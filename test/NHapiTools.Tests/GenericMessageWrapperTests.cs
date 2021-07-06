using System;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V23.Message;
using NHapiTools.Base;
using NHapiTools.Base.Model;
using NHapiTools.Base.Parser;
using NUnit.Framework;
using CustomPID = NHapiTools.Tests.CustomImplementation.V23.Segment.PID;

namespace NHapiTools.Tests
{
    [TestFixture]
    public class GenericMessageWrapperTests
    {

        [Test(Description = "Segments can be overridden")]
        public void CanOverrideSegments()
        {
            Console.WriteLine("\n==============================================\nTesting parsing to GenericMessageWrapper with different PID implementation (Repeating Alternate Patient ID).");

            // Arrange
            var messageString = "MSH|^~\\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A01^ADT_A01|1817457|D|2.3|\rPID|0493575^^^2^ID 1|0493575^^^2^ID 1|454721|0493575^^^2^ID 1~0584484^^^3^ID 2~0584484^^^4^ID 4~0584484^^^5^ID 5|DOE^JOHN^^^^|DOE^JOHN^^^^|19480203|M||B|254 MYSTREET AVE^^MYTOWN^OH^44123^USA||(216)123-4567|||M|NON|400003403~1129086|\rNK1||ROE^MARIE^^^^|SPO||(216)123-4567||EC|||||||||||||||||||||||||||\rPV1||O|168~219^^^^^^^^^||||277^ALLEN MYLASTNAME^BONNIE^^^^|||||||||| ||2688684|||||||||||||||||||||||||199912271408||||||002376853";
            var expectedRepetitions = 4;
            var classFactory = new EnhancedModelClassFactory();
            var parser = new PipeParser(classFactory);
            classFactory.ValidationContext = parser.ValidationContext;

            var message = parser.Parse(messageString);

            // Act
            var messageWrapper = message as GenericMessageWrapper;

            Assert.NotNull(messageWrapper);

            var originalMessage = messageWrapper.Unwrap();

            var pid = messageWrapper.GetSegment<ISegment>("PID");

            var overriddenPid = pid as CustomPID;
            var segmentOverridden = pid is CustomPID;

            Assert.IsInstanceOf<CustomPID>(pid);

            var structure = originalMessage.GetStructureName();

            Console.WriteLine(
                "Parsed {0} (V{1}). Custom PID implementation: {2}. Alternate Patient ID has {3} repetitions.\n",
                structure, originalMessage.Version, segmentOverridden,
                overriddenPid?.AlternatePatientIDRepetitionsUsed);

            Assert.AreEqual(expectedRepetitions, overriddenPid?.AlternatePatientIDRepetitionsUsed);

            var pid1 = ((ADT_A01)originalMessage).PID;
            var pid2 = overriddenPid;

            var comparer = new SegmentEqualityComparer();
            Assert.True(comparer.Equals(pid1, pid2));

            Console.WriteLine("Compare PID segments.");
            Console.WriteLine("PID from original message {0} custom PID.", pid1.IsEqual(pid2) ? "is the same as" : "isn't the same as");

            Console.WriteLine("\nDone!");
        }

        [Test(Description = "Custom ZSegments can be parsed")]
        public void CanParseCustomSegments()
        {
            Console.WriteLine("\n==============================================\nTesting parsing to GenericMessageWrapper with message which contains custom Z segment ZRT\n");

            // Arrange
            var messageString = "MSH|^~\\&|ABC|DEF|DAL|QUEST|20160907113230||ORM^O01^ORM_O01|201609071132304107|P|2.5.1\rPID|1||[PATIENTID]^^^^MR||[LASTNAME]^[FIRSTNAME]^M^^^^L|SMITH|[DOB]|[GENDER]||2106-3^White^HL70005|123 Main St.^^Fischer^TX^78623^USA^H||^PRN^PH^anyone@mycompany.com^^704^5551212~^^CP^^^980^5551414|^PRN^PH^^^704^5551313|eng^English^ISO639|S^Single|||123-45-6789|||N^Not Hispanic or Latino^HL70189\rPV1|1|O|^^^ZZZZZ00002^^C^^^Bleeding Edge Trauma Center||||NPIDA^Allthework^Dew^^^Mr^PA^^^^^^NPI^^^^^^^^PA||||||||||||ZZZZZ000EJ^^^^VN|||||||||||||||||||||||||20110511132339-0400\rORC|SN|[PON]||||||||||^Jekyll^Burt^^^^^^NPI^L\rOBR||[PON]||87590^Neisseria gonorrhoeae detection by nucleic acid, direct probe^C4|||201609071108|||||||| ^^^ |^Jekyll^Burt^^^^^^NPI^L||||||||LAB\rDG1|1||I25700^Atherosclerosis of CABG, unsp, w unstable angina pectoris^ICD\rZRT|1|Inbound Processor - Prod|ConfigID=1406;MessageID=16971290;MessageType=ORM;LabOrderID=32271;PatientID=1234;|SPLINTER|";
            var expectedZrt = new []
            {
                "1",
                "Inbound Processor - Prod",
                "ConfigID=1406;MessageID=16971290;MessageType=ORM;LabOrderID=32271;PatientID=1234;",
                "SPLINTER"
            };

            var classFactory = new EnhancedModelClassFactory();
            var parser = new PipeParser(classFactory);
            classFactory.ValidationContext = parser.ValidationContext;

            var message = parser.Parse(messageString);
            var messageWrapper = message as GenericMessageWrapper;

            Assert.NotNull(messageWrapper);

            var originalMessage = messageWrapper.Unwrap();

            XMLParser xmlParser = new DefaultXMLParser();
            var xmlMessageStrict = xmlParser.Encode(originalMessage);
            var xmlMessageGeneric = xmlParser.Encode(message);

            Assert.That(xmlMessageStrict, Does.Match(@"^\<ORM_O01.*\<\/ORM_O01\>$"));
            Assert.That(xmlMessageGeneric, Does.Match(@"^\<GenericMessageWrapper.*\<\/GenericMessageWrapper\>$"));

            var zrt = messageWrapper.GetSegment<ISegment>("ZRT");

            var fieldCount = zrt.NumFields();

            for (var i = 1; i <= fieldCount; i++)
            {
                var field = zrt.GetField(i, 0);
                var value = ((Varies)field).Data;
                Assert.AreEqual(expectedZrt[i-1], value.ToString());
                Console.WriteLine("{0}", value);
            }
        }
    }
}
