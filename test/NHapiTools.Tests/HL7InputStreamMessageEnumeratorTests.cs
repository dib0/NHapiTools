using System.IO;
using NHapiTools.Base.IO;
using Xunit;
using Xunit.Abstractions;

namespace NHapiTools.Tests
{
    public class HL7InputStreamMessageEnumeratorTests
    {
        private ITestOutputHelper Output { get; }

        private string CurrentDirectory { get; }

        private string TestMessageDirectory { get; }

        public HL7InputStreamMessageEnumeratorTests(ITestOutputHelper output)
        {
            Output = output;
            CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            TestMessageDirectory = Path.Combine(CurrentDirectory, "TestMessages");
        }


        [Fact(DisplayName = "Parses Hl7 messages from all files in directory")]
        public void MoveNext_ParsesAllHl7MessagesFromAllFilesInDirectory()
        {
            Output.WriteLine("\n==============================================\nTesting filestreams.");

            // Arrange
            var directoryInfo = new DirectoryInfo(TestMessageDirectory);
            var expectedFilesRead = directoryInfo.GetFiles().Length;
            var expectedMessageLength = 6;
            var actualFilesRead = 0;

            Output.WriteLine("{0} files found.", expectedFilesRead);

            var multipleFilesStream = new MultipleFilesStream(directoryInfo);
            multipleFilesStream.FileEndMarker = '\n';
            multipleFilesStream.FileCompleted += (o, e) =>
            {
                Output.WriteLine("\nMessages Read from {0}", Path.GetFileName(e.FileName));
                actualFilesRead++;
            };

            var actualMessageCount = 0;

            // Act
            using (var sut = new HL7InputStreamMessageEnumerator(multipleFilesStream))
            {
                Output.WriteLine("\nReading files from: '{0}'.", TestMessageDirectory);
                while (sut.MoveNext())
                {
                    var message = sut.Current;
     
                    if (message != null)
                    {
                        Output.WriteLine("{0} Message read.", message.GetType().Name);
                        actualMessageCount++;
                    }
                    else
                    {
                        Output.WriteLine("Message not read.");
                    }
                }

                Output.WriteLine("\n{0} messages read.", actualMessageCount);
            }

            Output.WriteLine("{0} files read.\n", actualFilesRead);

            // Assert
            Assert.Equal(expectedFilesRead, actualFilesRead);
            Assert.Equal(expectedMessageLength, actualMessageCount);
        }
    }
}
