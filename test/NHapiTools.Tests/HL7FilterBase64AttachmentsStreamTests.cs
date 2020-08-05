using System.IO;
using NHapiTools.Base.IO;
using Xunit;
using Xunit.Abstractions;

namespace NHapiTools.Tests
{
    public class HL7FilterBase64AttachmentsStreamTests
    {
        private ITestOutputHelper Output { get; }

        private string CurrentDirectory { get; }

        private string Base64MessageDirectory { get; }

        public HL7FilterBase64AttachmentsStreamTests(ITestOutputHelper output)
        {
            Output = output;
            CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            Base64MessageDirectory = Path.Combine(CurrentDirectory, "TestMessages", "Base64");
        }


        [Theory(DisplayName = "Locates Hl7 base64 encoded attachments")]
        [InlineData("ORU_01.txt", 1)]
        [InlineData("ORU_01_2.txt", 0)]
        [InlineData("ORU_01_3.txt", 2)]
        public void LocatesHl7Base64EncodedAttachments(string fileName, int expectedAttachmentCount)
        {
            Output.WriteLine("\n==============================================\nTesting Base64 filter stream.\n");

            var file = File.Open(Path.Combine(Base64MessageDirectory, fileName), FileMode.Open, FileAccess.Read, FileShare.Read);
            TestBase64Stream(file, expectedAttachmentCount);

            Output.WriteLine("\nDone!");
        }

        private void TestBase64Stream(FileStream fs, int expectedAttachmentCount)
        {
            using (var filterStream = new HL7FilterBase64AttachmentsStream(fs))
            {
                var result = filterStream.ReadToEnd();
                Output.WriteLine("Message:\n{0}\n", result);

                Assert.Equal(expectedAttachmentCount, filterStream.Attachments.Count);

                if (filterStream.HasAttachments)
                {
                    foreach (var item in filterStream.Attachments)
                    {
                        item.Value.Position = 0;

                        using (var sr = new StreamReader(item.Value))
                        {
                            result = sr.ReadToEnd();
                            Output.WriteLine("Attachment '{0}': {1}", item.Key, result);
                        }
                    }
                }
                else
                {
                    Output.WriteLine("No attachments.");
                }
            }
        }
    }
}
