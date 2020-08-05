using System.Collections.Generic;
using System.IO;
using NHapi.Base.Parser;
using NHapiTools.Base.IO;
using NHapiTools.Base.Validation;
using Xunit;
using Xunit.Abstractions;

namespace NHapiTools.Tests
{
    public class AutomatedContextTests
    {
        private ITestOutputHelper Output { get; }

        private string CurrentDirectory { get; }

        private string TestMessageDirectory { get; }

        public AutomatedContextTests(ITestOutputHelper output)
        {
            Output = output;
            CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            TestMessageDirectory = Path.Combine(CurrentDirectory, "TestMessages");
        }


        [Fact(DisplayName = "Parses Hl7 messages using AutomatedContext")]
        public void ParsesAllHl7MessagesWithAutomatedContext()
        {
            Output.WriteLine("\n==============================================\nTesting parsing with automated context.");

            // Arrange
            var expectedEncodingRulesCount = 1;
            var expectedMessageRulesCount = 2;
            var expectedPrimitiveTypeRulesCount = 1;

            var expectedParse = new List<ParseResult>
            {
                new ParseResult("ADT_A01", "2.5"),
                new ParseResult("ADT_A08", "2.3"),
                new ParseResult("ADT_A08", "2.3"),
                new ParseResult("DFT_P03", "2.3"),
                new ParseResult("ORU_R01", "2.4"),
                new ParseResult("SIU_S12", "2.3")
            };

            var messages = GetHl7Strings();

            var parser = new PipeParser();
            var context = new AutomatedContext(parser.ValidationContext);
            parser.ValidationContext = context;

            Output.WriteLine("Encoding Rules added:\t\t{0}", context.EncodingRuleCount);
            Output.WriteLine("Message Rules added:\t\t{0}", context.MessageRuleCount);
            Output.WriteLine("PrimitiveType Rules added:\t{0}\n", context.PrimitiveRuleCount);

            var parsed = new List<ParseResult>();

            foreach (var m in messages)
            {
                var im = parser.Parse(m);

                var structure = im.GetStructureName();
                Output.WriteLine("Parsed {0}, V{1}.", structure, im.Version);
                parsed.Add(new ParseResult(structure, im.Version));
            }

            Assert.Equal(expectedEncodingRulesCount, context.EncodingRuleCount);
            Assert.Equal(expectedMessageRulesCount, context.MessageRuleCount);
            Assert.Equal(expectedPrimitiveTypeRulesCount, context.PrimitiveRuleCount);
            Assert.Equal(expectedParse, parsed);

            Output.WriteLine("\nDone! (Parsed {0})", parsed.Count);
        }

        private IEnumerable<string> GetHl7Strings()
        {
            var directoryInfo = new DirectoryInfo(TestMessageDirectory);
            var multipleFilesStream = new MultipleFilesStream(directoryInfo);
            multipleFilesStream.FileEndMarker = '\n';

            var messages = new List<string>();

            using (var enumerator = new HL7InputStreamMessageStringEnumerator(multipleFilesStream))
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
