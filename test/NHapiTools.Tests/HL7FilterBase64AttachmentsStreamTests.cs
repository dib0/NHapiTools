using System;
using System.IO;
using NHapiTools.Base.IO;
using NUnit.Framework;

namespace NHapiTools.Tests
{
    [TestFixture]
    public class HL7FilterBase64AttachmentsStreamTests
    {
        private string CurrentDirectory { get; }

        private string Base64MessageDirectory { get; }

        public HL7FilterBase64AttachmentsStreamTests()
        {
            CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            Base64MessageDirectory = Path.Combine(CurrentDirectory, "TestMessages", "Base64");
        }


        [Test(Description = "Locates Hl7 base64 encoded attachments")]
        [TestCase("ORU_01.txt", 1)]
        [TestCase("ORU_01_2.txt", 0)]
        [TestCase("ORU_01_3.txt", 2)]
        public void LocatesHl7Base64EncodedAttachments(string fileName, int expectedAttachmentCount)
        {
            Console.WriteLine("\n==============================================\nTesting Base64 filter stream.\n");

            var file = File.Open(Path.Combine(Base64MessageDirectory, fileName), FileMode.Open, FileAccess.Read, FileShare.Read);
            TestBase64Stream(file, expectedAttachmentCount);

            Console.WriteLine("\nDone!");
        }

        private void TestBase64Stream(FileStream fs, int expectedAttachmentCount)
        {
            using (var filterStream = new HL7FilterBase64AttachmentsStream(fs))
            {
                var result = filterStream.ReadToEnd();
                Console.WriteLine("Message:\n{0}\n", result);

                Assert.AreEqual(expectedAttachmentCount, filterStream.Attachments.Count);

                if (filterStream.HasAttachments)
                {
                    foreach (var item in filterStream.Attachments)
                    {
                        item.Value.Position = 0;

                        using (var sr = new StreamReader(item.Value))
                        {
                            result = sr.ReadToEnd();
                            Console.WriteLine("Attachment '{0}': {1}", item.Key, result);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No attachments.");
                }
            }
        }
    }
}
