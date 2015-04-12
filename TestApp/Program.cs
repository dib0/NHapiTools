using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Message;
using NHapi.Model.V23.Segment;
using NHapi.Model.V23.Datatype;
using NHapi.Base.validation;
using NHapiTools.Base;
using NHapiTools.Base.ModelToolsGenerator;
using NHapiTools.Base.IO;
using NHapiTools.Base.Parser;
using NHapiTools.Base.Validation;
using NHapiTools.Model.V23.Segment;
using NHapiTools.Base.Model;
using NHapiTools.Base.Util;

namespace TestApp
{
    /// <summary>
    /// Multiple tests for the NHapi Tools
    /// </summary>
    class Program
    {
        #region Private static properties
        private static string basePath;
        private static List<string> messages;
        private static List<IMessage> parsedMessages;
        #endregion

        #region Static methods
        static void Main(string[] args)
        {
            basePath = AppDomain.CurrentDomain.BaseDirectory;
            basePath = basePath.Remove(basePath.IndexOf("\\TestApp"));
            messages = new List<string>();
            parsedMessages = new List<IMessage>();

            TestSourceGenerator();
            TestHL7FileStream();
            TestHL7FileMessageStream();
            TestParserAutomatedContext();
            TestParserConfigurableContext();
            TestGenericMessageWrapper();
            TestAckGeneration();
            TestExtensionMethods();
            TestBase64Attachments();

            Console.WriteLine("\n==============================================\nAll tests done!. Press <enter> to exit.");
            Console.ReadLine();
        }

        private static void TestSourceGenerator()
        {
            Console.WriteLine("\n==============================================\nTesting source generation.");
            Console.WriteLine("Generating source for V21.");
            Generator gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V21.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);

            Console.WriteLine("Generating source for V22.");
            gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V22.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);

            Console.WriteLine("Generating source for V23.");
            gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V23.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);

            Console.WriteLine("Generating source for V231.");
            gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V231.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);

            Console.WriteLine("Generating source for V24.");
            gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V24.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);

            Console.WriteLine("Generating source for V25.");
            gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V25.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);

            Console.WriteLine("Generating source for V251.");
            gen = new Generator(basePath + "\\TestApp\\bin\\Debug\\NHapi.Model.V251.dll", basePath + "\\Output");
            SpinnerWhileWaiting(gen.Generate);
        }

        private static void TestHL7FileStream()
        {
            Console.WriteLine("\n==============================================\nTesting filestreams.");
            string path = basePath + "\\TestApp\\TestMessages";

            DirectoryInfo di = new DirectoryInfo(path);
            Console.WriteLine("{0} files found.", di.GetFiles().Count());

            MultipleFilesStream mfs = new MultipleFilesStream(di);
            mfs.FileEndMarker = '\n';
            mfs.FileCompleted += mfs_FileCompleted;

            using (HL7InputStreamMessageStringEnumerator stream = new HL7InputStreamMessageStringEnumerator(mfs))
            {
                int x = 0;
                Console.WriteLine("\nReading files from: '{0}'.", path);        
                while (stream.MoveNext())
                {
                    string message = stream.Current;
                    if (message != null)
                    {
                        messages.Add(message);
                        Console.WriteLine("Message read.");
                        x++;
                    }
                    else
                        Console.WriteLine("Message not read.");
                    
                    stream.MoveNext();
                }
                Console.WriteLine("{0} files read.\n", x);

                List<String> allFiles = Directory.GetFiles(path + "\\Done").ToList();
                Console.WriteLine("Moving {0} files back.\n", allFiles.Count());
                foreach (string file in allFiles)
                {
                    FileInfo mFile = new FileInfo(file);
                    mFile.MoveTo(path + "\\" + mFile.Name);
                }
            }
        }

        private static void TestHL7FileMessageStream()
        {
            Console.WriteLine("\n==============================================\nTesting message stream.");
            string path = basePath + "\\TestApp\\TestMessages";

            DirectoryInfo di = new DirectoryInfo(path);
            Console.WriteLine("{0} files found.", di.GetFiles().Count());

            MultipleFilesStream mfs = new MultipleFilesStream(di);
            mfs.FileEndMarker = '\n';
            mfs.FileCompleted += mfs_FileCompleted;

            using (HL7InputStreamMessageEnumerator stream = new HL7InputStreamMessageEnumerator(mfs))
            {
                int x = 0;
                Console.WriteLine("\nReading files from: '{0}'.", path);
                while (stream.MoveNext())
                {
                    IMessage message = stream.Current;
                    if (message != null)
                    {
                        Console.WriteLine("Message read.");
                        x++;
                    }
                    else
                        Console.WriteLine("Message not read.");

                    stream.MoveNext();
                }
                Console.WriteLine("{0} files read.\n", x);

                List<String> allFiles = Directory.GetFiles(path + "\\Done").ToList();
                Console.WriteLine("Moving {0} files back.\n", allFiles.Count());
                foreach (string file in allFiles)
                {
                    FileInfo mFile = new FileInfo(file);
                    mFile.MoveTo(path + "\\" + mFile.Name);
                }
            }
        }

        private static void TestParserAutomatedContext()
        {
            if (messages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting parsing with automated context.");
                PipeParser parser = new PipeParser();
                AutomatedContext context = new AutomatedContext(parser.ValidationContext);
                parser.ValidationContext = context;

                Console.WriteLine("Encodingrules added:\t  {0}", context.EncodingRuleCount);
                Console.WriteLine("Messagerules added:\t  {0}", context.MessageRuleCount);
                Console.WriteLine("PrimitiveTyperules added: {0}", context.PrimitiveRuleCount);
                Console.WriteLine();

                int count = 0;
                foreach (string m in messages)
                {
                    IMessage im = parser.Parse(m);

                    string structure = im.GetStructureName();
                    Console.WriteLine("Parsed {0}, V{1}.", structure, im.Version);

                    count++;
                }
                Console.WriteLine("\nDone! (Parsed {0})", count);
            }
        }

        private static void TestParserConfigurableContext()
        {
            if (messages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting parsing with configurable context.");
                PipeParser parser = new PipeParser();
                ConfigurableContext context = new ConfigurableContext(parser.ValidationContext);
                parser.ValidationContext = context;

                Console.WriteLine("Encodingrules added:\t  {0}", context.EncodingRuleCount);
                Console.WriteLine("Messagerules added:\t  {0}", context.MessageRuleCount);
                Console.WriteLine("PrimitiveTyperules added: {0}", context.PrimitiveRuleCount);
                Console.WriteLine();

                int count = 0;
                foreach (string m in messages)
                {
                    IMessage im = parser.Parse(m);
                    parsedMessages.Add(im);
                    
                    string structure = im.GetStructureName();
                    Console.WriteLine("Parsed {0}, V{1}.", structure, im.Version);
                    count++;
                }
                Console.WriteLine("\nDone! (Parsed {0})", count);
            }
        }

        private static void TestGenericMessageWrapper()
        {
            Console.WriteLine("\n==============================================\nTesting parsing to GenericMessageWrapper with different PID implementation (Repeating Alternate Patient ID).");
            string txtMessage = "MSH|^~\\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A01^ADT_A01|1817457|D|2.3|\rPID|0493575^^^2^ID 1|0493575^^^2^ID 1|454721|0493575^^^2^ID 1~0584484^^^3^ID 2~0584484^^^4^ID 4~0584484^^^5^ID 5|DOE^JOHN^^^^|DOE^JOHN^^^^|19480203|M||B|254 MYSTREET AVE^^MYTOWN^OH^44123^USA||(216)123-4567|||M|NON|400003403~1129086|\rNK1||ROE^MARIE^^^^|SPO||(216)123-4567||EC|||||||||||||||||||||||||||\rPV1||O|168~219^^^^^^^^^||||277^ALLEN MYLASTNAME^BONNIE^^^^|||||||||| ||2688684|||||||||||||||||||||||||199912271408||||||002376853";

            EnhancedModelClassFactory emch = new EnhancedModelClassFactory();
            PipeParser parser = new PipeParser(emch);
            emch.ValidationContext = parser.ValidationContext;
            IMessage im=parser.Parse(txtMessage);

            GenericMessageWrapper gcw = im as GenericMessageWrapper;
            if (gcw != null)
            {
                IMessage originalMessage = gcw.Unwrap();

                bool segmentOverridden = false;
                ISegment pid = gcw.GetSegment<ISegment>("PID");
                if (pid is TestApp.CustomImplementation.V23.Segment.PID)
                    segmentOverridden = true;

                string structure = originalMessage.GetStructureName();
                if (segmentOverridden)
                {
                    Console.WriteLine("Parsed {0} (V{1}). Custom PID implementation: {2}. Alternate Patient ID has {3} repetitions.", structure, originalMessage.Version, segmentOverridden, ((TestApp.CustomImplementation.V23.Segment.PID)pid).AlternatePatientIDRepetitionsUsed);

                    PID pid1 = ((ADT_A01)originalMessage).PID;
                    TestApp.CustomImplementation.V23.Segment.PID pid2 = (TestApp.CustomImplementation.V23.Segment.PID)pid;
                    
                    Console.WriteLine("");
                    Console.WriteLine("Compare PID segments.");
                    Console.WriteLine("PID from original message {0} custom PID.", pid1.IsEqual(pid2) ? "is the same as" : "isn't the same as");
                }
                else
                    Console.WriteLine("Parsed {0} (V{1}). Custom PID implementation: {2}.", structure, originalMessage.Version, segmentOverridden);
            }
            Console.WriteLine("\nDone!");
        }

        private static void TestAckGeneration()
        {
            if (parsedMessages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting Ack generation.");

                Ack ack = new Ack("TestApplication", "Development");
                foreach (IMessage msg in parsedMessages)
                {
                    IMessage ackMessage = ack.MakeACK(msg);
                    Console.WriteLine("{0} message for V{1}.", ackMessage.GetStructureName(), ackMessage.Version);
                }
            }
        }

        private static void TestExtensionMethods()
        {
            if (parsedMessages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting extension methods on ADT_A08 (HL7 V2.3) messages.");

                List<IMessage> a08 = parsedMessages.Where(im => (im.Version == "2.3") && (im.GetStructureName() == "ADT_A08")).ToList();
                Console.WriteLine("\nFound {0} A08 messages.", a08.Count());

                // Compare messages
                Console.WriteLine("");
                Console.WriteLine("Compare A08 messages.");
                Console.WriteLine("A08_1 {0} A08_1.", a08[0].IsEqual(a08[0]) ? "is the same as": "isn't the same as");
                Console.WriteLine("A08_1 {0} A08_2.", a08[0].IsEqual(a08[1]) ? "is the same as": "isn't the same as");

                // Compare segments
                ISegment s1 = (ISegment)a08[0].GetStructure("PID");
                ISegment s2 = (ISegment)a08[1].GetStructure("PID");
                Console.WriteLine("");
                Console.WriteLine("Compare PID segments.");
                Console.WriteLine("PID1 {0} PID1.", s1.IsEqual(s1) ? "is the same as": "isn't the same as");
                Console.WriteLine("PID1 {0} PID2.", s1.IsEqual(s2) ? "is the same as": "isn't the same as");
                Console.WriteLine("");

                ADT_A08 a08msg = null;
                foreach (IMessage msg in a08)
                {
                    a08msg = (ADT_A08)msg;
                    Console.WriteLine("Getting address from message.");

                    foreach (XAD xad in a08msg.PID.GetPatientAddressRecords())
                    {
                        string x = xad.StreetAddress.Value;
                        Console.WriteLine("Found street record '{0}'.", x);
                    }
                }

                if (a08msg != null)
                {
                    Console.WriteLine("Testing Add method.");
                    int x = a08msg.PID.PatientAddressRepetitionsUsed;
                    Console.WriteLine("Message has {0} PatientAddress record(s).", x);

                    Console.WriteLine("Adding record.");
                    a08msg.PID.AddPatientAddress();
                    Console.Write("Message has {0} PatientAddress record(s): ", a08msg.PID.PatientAddressRepetitionsUsed);
                    if ((a08msg.PID.PatientAddressRepetitionsUsed - x) == 1)
                        Console.WriteLine("OK!");
                    else
                        Console.WriteLine("Failure!");
                }

                Console.WriteLine("\nDone!");
            }
        }

        private static void TestBase64Attachments()
        {
            Console.WriteLine("\n==============================================\nTesting Base64 filter stream.\n");
            string path = basePath + "\\TestApp\\TestMessages\\Base64\\";

            FileStream file = File.Open(path + "ORU_01.txt", FileMode.Open);
            TestBase64Stream(file);

            Console.WriteLine();
            Console.WriteLine();
            file = File.Open(path + "ORU_01_2.txt", FileMode.Open);
            TestBase64Stream(file);

            Console.WriteLine();
            Console.WriteLine();
            file = File.Open(path + "ORU_01_3.txt", FileMode.Open);
            TestBase64Stream(file);

            Console.WriteLine("\nDone!");
        }

        private static void TestBase64Stream(FileStream fs)
        {
            using (HL7FilterBase64AttachmentsStream filterStream = new HL7FilterBase64AttachmentsStream(fs))
            {
                string result = filterStream.ReadToEnd();
                Console.WriteLine("Message: {0}", result);

                if (filterStream.HasAttachments)
                {
                    foreach (KeyValuePair<string, MemoryStream> item in filterStream.Attachments)
                    {
                        item.Value.Position = 0;

                        using (StreamReader sr = new StreamReader(item.Value))
                        {
                            result = sr.ReadToEnd();
                            Console.WriteLine("Attachment '{0}': {1}", item.Key, result);
                        }
                    }
                }
                else
                    Console.WriteLine("No attachments.");
            }
        }

        private static void SpinnerWhileWaiting(Action processingMethod)
        {
            char[] spinner = new char[] { '|', '/', '-', '\\' };

            Console.Write("\r\nProcessing     ");
            bool oldCursorVisibility = Console.CursorVisible;
            Console.CursorVisible = false;

            ParameterizedThreadStart pts = new ParameterizedThreadStart(obj => processingMethod());
            Thread t = new Thread(pts);
            t.Start();

            int spinnerCount = 0;
            int dotCount = 0;
            int dotPause = 0;
            while (t.IsAlive)
            {
                string spinnerText = string.Empty;
                spinnerText = spinnerText.PadRight(dotCount, '.');
                spinnerText = spinnerText.PadRight(4, ' ');
                spinnerText += spinner[spinnerCount];

                int x = Console.CursorLeft;
                int y = Console.CursorTop;

                Console.SetCursorPosition(x - 5, y);
                Console.Write(spinnerText);

                if (++spinnerCount > 3)
                    spinnerCount = 0;

                if (++dotPause == 20)
                {
                    dotPause = 0;
                    if (++dotCount == 4)
                        dotCount = 0;
                }

                Thread.Sleep(10);
            }

            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
            Console.CursorVisible = oldCursorVisibility;
            Console.WriteLine("... Done!");
        }
        #endregion

        #region Events
        static void mfs_FileCompleted(object sender, FileCompletedEventArgs e)
        {
            string path = basePath + "\\TestApp\\TestMessages\\Done";

            FileInfo fi = new FileInfo(e.FileName);
            fi.MoveTo(path + "\\" + fi.Name);
            Console.WriteLine("File '{0}' moved.", fi.Name);
        }
        #endregion
    }
}
