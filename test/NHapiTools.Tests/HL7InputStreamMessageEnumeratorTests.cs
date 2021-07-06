using System;
using System.IO;
using NHapiTools.Base.IO;
using NUnit.Framework;

namespace NHapiTools.Tests
{
    [TestFixture]
    public class HL7InputStreamMessageEnumeratorTests
    {
        private string CurrentDirectory { get; }

        private string TestMessageDirectory { get; }

        public HL7InputStreamMessageEnumeratorTests()
        {
            CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            TestMessageDirectory = Path.Combine(CurrentDirectory, "TestMessages");
        }


        [Test(Description = "Parses Hl7 messages from all files in directory")]
        public void MoveNext_ParsesAllHl7MessagesFromAllFilesInDirectory()
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
            using (var sut = new HL7InputStreamMessageEnumerator(multipleFilesStream))
            {
                Console.WriteLine("\nReading files from: '{0}'.", TestMessageDirectory);
                while (sut.MoveNext())
                {
                    var message = sut.Current;
     
                    if (message != null)
                    {
                        Console.WriteLine("{0} Message read.", message.GetType().Name);
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
}
