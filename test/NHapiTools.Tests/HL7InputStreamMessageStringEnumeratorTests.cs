using System;
using System.IO;
using NHapiTools.Base.IO;
using NUnit.Framework;

namespace NHapiTools.Tests
{
    [TestFixture]
    public class HL7InputStreamMessageStringEnumeratorTests
    {
        private string CurrentDirectory { get; }

        private string TestMessageDirectory { get; }

        public HL7InputStreamMessageStringEnumeratorTests()
        {
            CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            TestMessageDirectory = Path.Combine(CurrentDirectory, "TestMessages");
        }


        [Test(Description = "Reads Hl7 messages from all files in directory")]
        public void MoveNext_EnumeratesAllMessagesFromFilesInDirectory()
        {
            Console.WriteLine("\n==============================================\nTesting filestreams.");

            // Arrange
            var directoryInfo = new DirectoryInfo(TestMessageDirectory);
            var expectedFilesRead = directoryInfo.GetFiles().Length;
            var expectedMessageLength = 6;
            var actualFilesRead = 0;

            Console.WriteLine("{0} files found.", expectedFilesRead);

            var multipleFilesStream = new MultipleFilesStream(directoryInfo);
            multipleFilesStream.FileEndMarker = '\n';
            multipleFilesStream.FileCompleted += (o, e) =>
            {
                Console.WriteLine("\nMessages Read from {0}", Path.GetFileName(e.FileName));
                actualFilesRead++;
            };

            var actualMessageCount = 0;

            // Act
            using (var sut = new HL7InputStreamMessageStringEnumerator(multipleFilesStream))
            {
                Console.WriteLine("\nReading files from: '{0}'.", TestMessageDirectory);
                while (sut.MoveNext())
                {
                    var message = sut.Current;
     
                    if (message != null)
                    {
                        Console.WriteLine("Message read.");
                        actualMessageCount++;
                    }
                    else
                    {
                        Console.WriteLine("Message not read.");
                    }
                }

                Console.WriteLine("\n{0} messages read.", actualMessageCount);
            }

            Console.WriteLine("{0} files read.\n", actualFilesRead);

            // Assert
            Assert.AreEqual(expectedFilesRead, actualFilesRead);
            Assert.AreEqual(expectedMessageLength, actualMessageCount);
        }
    }

//    internal class ExpectedMessageStrings
//    {
//        public IList<string> ExpectedData { get; } = new List<string>
//        {
//            @"MSH|^~\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A04^ADT_A01|1817457|D|2.5|
//PID||0493575^^^2^ID 1|454721||DOE^JOHN^^^^|DOE^JOHN^^^^|19480203|M||B|254 MYSTREET AVE^^MYTOWN^OH^44123^USA||(216)123-4567|||M|NON|400003403~1129086|
//NK1||ROE^MARIE^^^^|SPO||(216)123-4567||EC|||||||||||||||||||||||||||
//PV1||O|168~219^^^^^^^^^||||277^ALLEN MYLASTNAME^BONNIE^^^^|||||||||| ||2688684|||||||||||||||||||||||||199912271408||||||002376853"
//            ,
//            @"MSH|^~\&|AnotherSoftwareSystem|EmpireMedicalAssociates|pMDsoft|123456|20080717120312||ADT^A08^ADT_A08|12320080717120312|P|2.3|||NE|NE
//            EVN|A08|20080717120312
//            PID|1|987654||A123456|Smith^John^Q||19600411000000|M|||123 Main St.^^New York^NY^11101~456 Main St.^^Dallas^TX^11102||(123)456-7890^^^^^123^4567890|(321)654-0987X3000^^^^^321^6540987^3000|||||888776666
//            PV1|1|R|^^^00123||||97^Jones^Mary^Q^MD|12^Baker^Joseph^Q^DO||||||||||||||||||||||||||||||||||||20080715|20080717"
//            ,
//            @"MSH|^~\&|COL|ABC|FWS|ABC|201310250715||ADT^A08^ADT_A08|000710428|P|2.3|||||NE||NE
//            EVN||201310250715||O|911123^TEST^T.E.S.T.|201306171001
//            PID||0110051528|1234567^^^^PI||&&test23^i^i^^^^D||19800314|F|||Teststreet 5^^A City^^1||
//            ROL|||PP^Doktor^HL11111|1111^Test,^^^^^^^aaaa|||||||Teststreet 5^^A City^^1|01234567890^WPN^PH
//            PV1|1|I|1111^^^B||||1111^TEST^A.A.^^^^^^SI|||||||||||Q|011115373911123||6||||||||||||||||||B|||||201310250700||||||||^CHIRURGIE "
//            ,
//            @"MSH|^~\&|^pMDsoft|321|^AnotherSoftwareSystem||20091014145837||DFT^P03|6583558|P|2.3||||AL|
//EVN|P03|20091014145837|
//PID||987654|987654||Smith^John^Q||19600411|M|||123 Main St.^^New York^NY^11101^USA||(123)456-7890||||||888776666|
//PV1||I|^^^00123||||^Jones^Mary^Q^^^^^^&1356421622&NPI|^Baker^Joseph^Q^^^^^&1861436503&NPI|||||||||||1222222222||||||||||||||||||||00123|||^^^00123||20091004|
//FT1||||20091007000000|20091014|CG||||1|||||||||780.4^Dizziness/Giddiness~785.2^Heart Murmur~272.0^Hypercholesterolemia Pure~458.9^Hypotension Nos||||||99261^Consult F/U Inp 61 Low|12~25
//FT1||||20091007000000|20091007|CG||||1|||||||||780.4^Dizziness/Giddiness~785.2^Heart Murmur~272.0^Hypercholesterolemia Pure~458.9^Hypotension Nos||||||93742^Defib-Analy Sngl w/Prog|
//FT1||||20091007000000|20091007|CG||||1|||||||||780.4^Dizziness/Giddiness~785.2^Heart Murmur~272.0^Hypercholesterolemia Pure~458.9^Hypotension Nos||||||93621^EP-EPS w/ CS or LA|
//IN1|1||999|Some Carrier||||643232498|||||||||Self|||||||||||||||||||11111111111|
//IN1|2||3333|Another Carrier||||6884213665||||||||Doe^Jane|Spouse|19570304||||||||||||||||||555555555|"
//            ,
//            @""
//        };
//    }
}
