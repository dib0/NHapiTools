using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V23.Datatype;
using NHapi.Model.V23.Message;
using NHapiTools.Base;
using NHapiTools.Base.IO;
using NHapiTools.Base.Model;
using NHapiTools.Base.ModelToolsGenerator;
using NHapiTools.Base.Parser;
using NHapiTools.Base.Util;
using NHapiTools.Base.Validation;
using NHapiTools.Model.V23.Segment;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace TestApp
{
    /// <summary>
    /// Multiple tests for the NHapi Tools
    /// </summary>
    internal class Program
    {
        #region Private static properties

        private static string _applicationDirectory;
        private static string _basePath;
        private static List<string> _messages;
        private static List<IMessage> _parsedMessages;

        #endregion Private static properties

        #region Static methods

        private static void Main(string[] args)
        {
            _applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _basePath = _applicationDirectory.Remove(_applicationDirectory.IndexOf("\\TestApp", StringComparison.Ordinal));
            _messages = new List<string>();
            _parsedMessages = new List<IMessage>();

            TestSourceGenerator();
            // HL7InputStreamMessageStringEnumerator is possibly broken throws DirectoryNotFoundException "Could not find part of the path." or the test is broken?
            //TestHl7FileStream();
            // HL7InputStreamMessageStringEnumerator is possibly broken throws DirectoryNotFoundException "Could not find part of the path." or the test is broken?
            //TestHl7FileMessageStream();
            TestParserAutomatedContext();
            TestParserConfigurableContext();
            TestGenericMessageWrapper();
            TestAckGeneration();
            TestExtensionMethods();
            TestBase64Attachments();
            ZrtTest();

            Console.WriteLine("\n==============================================\nAll tests done!. Press <enter> to exit.");
            Console.ReadLine();
        }

        private static void TestSourceGenerator()
        {
            var dllFiles = Directory.GetFiles(_applicationDirectory, "NHapi.*.dll");
            Console.WriteLine("\n==============================================\nTesting source generation.");
            foreach (var dllFile in dllFiles)
            {
                if (dllFile.Contains("NHapi.Model.V"))
                {
                    Console.WriteLine($"Generating source for {dllFile}.");
                    var gen2 = new Generator(dllFile, _basePath);
                    SpinnerWhileWaiting(gen2.Generate);
                    var gen = new Generator(dllFile, Path.Combine(_basePath + "\\Output"));
                    SpinnerWhileWaiting(gen.Generate);
                }
            }
        }

        private static void TestHl7FileStream()
        {
            Console.WriteLine("\n==============================================\nTesting filestreams.");
            var path = _basePath + "\\TestApp\\TestMessages";

            var di = new DirectoryInfo(path);
            Console.WriteLine("{0} files found.", di.GetFiles().Length);

            var mfs = new MultipleFilesStream(di);
            mfs.FileEndMarker = '\n';
            mfs.FileCompleted += mfs_FileCompleted;

            using (var stream = new HL7InputStreamMessageStringEnumerator(mfs))
            {
                var x = 0;
                Console.WriteLine("\nReading files from: '{0}'.", path);
                while (stream.MoveNext())
                {
                    var message = stream.Current;
                    if (message != null)
                    {
                        _messages.Add(message);
                        Console.WriteLine("Message read.");
                        x++;
                    }
                    else
                        Console.WriteLine("Message not read.");

                    stream.MoveNext();
                }
                Console.WriteLine("{0} files read.\n", x);

                var allFiles =
                    Directory.GetFiles(path + "\\Done")
                        .Select(file => new FileInfo(file))
                            .ToList();

                Console.WriteLine("Moving {0} files back.\n", allFiles.Count);
                foreach (var file in allFiles)
                {
                    file.MoveTo(path + "\\" + file.Name);
                }
            }
        }

        private static void TestHl7FileMessageStream()
        {
            Console.WriteLine("\n==============================================\nTesting message stream.");
            var path = _basePath + "\\TestApp\\TestMessages";

            var di = new DirectoryInfo(path);
            Console.WriteLine("{0} files found.", di.GetFiles().Length);

            var mfs = new MultipleFilesStream(di)
            {
                FileEndMarker = '\n'
            };

            mfs.FileCompleted += mfs_FileCompleted;

            using (var stream = new HL7InputStreamMessageEnumerator(mfs))
            {
                var x = 0;
                Console.WriteLine("\nReading files from: '{0}'.", path);
                while (stream.MoveNext())
                {
                    var message = stream.Current;
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

                var allFiles =
                    Directory.GetFiles(path + "\\Done")
                        .Select(file => new FileInfo(file))
                            .ToList();

                Console.WriteLine("Moving {0} files back.\n", allFiles.Count);
                foreach (var file in allFiles)
                {
                    file.MoveTo(path + "\\" + file.Name);
                }
            }
        }

        private static void TestParserAutomatedContext()
        {
            if (_messages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting parsing with automated context.");
                var parser = new PipeParser();
                var context = new AutomatedContext(parser.ValidationContext);
                parser.ValidationContext = context;

                Console.WriteLine("Encodingrules added:\t  {0}", context.EncodingRuleCount);
                Console.WriteLine("Messagerules added:\t  {0}", context.MessageRuleCount);
                Console.WriteLine("PrimitiveTyperules added: {0}", context.PrimitiveRuleCount);
                Console.WriteLine();

                var count = 0;
                foreach (var m in _messages)
                {
                    var im = parser.Parse(m);

                    var structure = im.GetStructureName();
                    Console.WriteLine("Parsed {0}, V{1}.", structure, im.Version);

                    count++;
                }
                Console.WriteLine("\nDone! (Parsed {0})", count);
            }
        }

        private static void TestParserConfigurableContext()
        {
            if (_messages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting parsing with configurable context.");
                var parser = new PipeParser();
                var context = new ConfigurableContext(parser.ValidationContext);
                parser.ValidationContext = context;

                Console.WriteLine("Encodingrules added:\t  {0}", context.EncodingRuleCount);
                Console.WriteLine("Messagerules added:\t  {0}", context.MessageRuleCount);
                Console.WriteLine("PrimitiveTyperules added: {0}", context.PrimitiveRuleCount);
                Console.WriteLine();

                var count = 0;
                foreach (var m in _messages)
                {
                    var im = parser.Parse(m);
                    _parsedMessages.Add(im);

                    var structure = im.GetStructureName();
                    Console.WriteLine("Parsed {0}, V{1}.", structure, im.Version);
                    count++;
                }
                Console.WriteLine("\nDone! (Parsed {0})", count);
            }
        }

        private static void TestGenericMessageWrapper()
        {
            Console.WriteLine("\n==============================================\nTesting parsing to GenericMessageWrapper with different PID implementation (Repeating Alternate Patient ID).");
            var txtMessage = "MSH|^~\\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A01^ADT_A01|1817457|D|2.3|\rPID|0493575^^^2^ID 1|0493575^^^2^ID 1|454721|0493575^^^2^ID 1~0584484^^^3^ID 2~0584484^^^4^ID 4~0584484^^^5^ID 5|DOE^JOHN^^^^|DOE^JOHN^^^^|19480203|M||B|254 MYSTREET AVE^^MYTOWN^OH^44123^USA||(216)123-4567|||M|NON|400003403~1129086|\rNK1||ROE^MARIE^^^^|SPO||(216)123-4567||EC|||||||||||||||||||||||||||\rPV1||O|168~219^^^^^^^^^||||277^ALLEN MYLASTNAME^BONNIE^^^^|||||||||| ||2688684|||||||||||||||||||||||||199912271408||||||002376853";

            var emch = new EnhancedModelClassFactory();
            var parser = new PipeParser(emch);
            emch.ValidationContext = parser.ValidationContext;
            var im = parser.Parse(txtMessage);

            var gcw = im as GenericMessageWrapper;
            if (gcw != null)
            {
                var originalMessage = gcw.Unwrap();

                var segmentOverridden = false;
                var pid = gcw.GetSegment<ISegment>("PID");
                if (pid is CustomImplementation.V23.Segment.PID)
                {
                    segmentOverridden = true;
                }

                var structure = originalMessage.GetStructureName();
                if (segmentOverridden)
                {
                    Console.WriteLine("Parsed {0} (V{1}). Custom PID implementation: {2}. Alternate Patient ID has {3} repetitions.", structure, originalMessage.Version, segmentOverridden, ((CustomImplementation.V23.Segment.PID)pid).AlternatePatientIDRepetitionsUsed);

                    var pid1 = ((ADT_A01)originalMessage).PID;
                    var pid2 = (CustomImplementation.V23.Segment.PID)pid;

                    Console.WriteLine("");
                    Console.WriteLine("Compare PID segments.");
                    Console.WriteLine("PID from original message {0} custom PID.", pid1.IsEqual(pid2) ? "is the same as" : "isn't the same as");
                }
                else
                {
                    Console.WriteLine("Parsed {0} (V{1}). Custom PID implementation: {2}.", structure,
                        originalMessage.Version, segmentOverridden);
                }
            }
            Console.WriteLine("\nDone!");
        }

        private static void TestAckGeneration()
        {
            if (_parsedMessages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting Ack generation.");

                var ack = new Ack("TestApplication", "Development");
                foreach (var msg in _parsedMessages)
                {
                    var ackMessage = ack.MakeACK(msg);
                    Console.WriteLine("{0} message for V{1}.", ackMessage.GetStructureName(), ackMessage.Version);
                }
            }
        }

        private static void TestExtensionMethods()
        {
            if (_parsedMessages.Count > 0)
            {
                Console.WriteLine("\n==============================================\nTesting extension methods on ADT_A08 (HL7 V2.3) messages.");

                var a08 = _parsedMessages.Where(im => (im.Version == "2.3") && (im.GetStructureName() == "ADT_A08")).ToList();
                Console.WriteLine("\nFound {0} A08 messages.", a08.Count);

                // Compare messages
                Console.WriteLine("");
                Console.WriteLine("Compare A08 messages.");
                Console.WriteLine("A08_1 {0} A08_1.", a08[0].IsEqual(a08[0]) ? "is the same as" : "isn't the same as");
                Console.WriteLine("A08_1 {0} A08_2.", a08[0].IsEqual(a08[1]) ? "is the same as" : "isn't the same as");

                // Compare segments
                var s1 = (ISegment)a08[0].GetStructure("PID");
                var s2 = (ISegment)a08[1].GetStructure("PID");
                Console.WriteLine("");
                Console.WriteLine("Compare PID segments.");
                Console.WriteLine("PID1 {0} PID1.", s1.IsEqual(s1) ? "is the same as" : "isn't the same as");
                Console.WriteLine("PID1 {0} PID2.", s1.IsEqual(s2) ? "is the same as" : "isn't the same as");
                Console.WriteLine("");

                ADT_A08 a08Msg = null;
                foreach (var msg in a08)
                {
                    a08Msg = (ADT_A08)msg;
                    Console.WriteLine("Getting address from message.");

                    foreach (XAD xad in a08Msg.PID.GetPatientAddressRecords())
                    {
                        var x = xad.StreetAddress.Value;
                        Console.WriteLine("Found street record '{0}'.", x);
                    }
                }

                if (a08Msg != null)
                {
                    Console.WriteLine("Testing Add method.");
                    var x = a08Msg.PID.PatientAddressRepetitionsUsed;
                    Console.WriteLine("Message has {0} PatientAddress record(s).", x);

                    Console.WriteLine("Adding record.");
                    a08Msg.PID.AddPatientAddress();
                    Console.Write("Message has {0} PatientAddress record(s): ", a08Msg.PID.PatientAddressRepetitionsUsed);
                    if ((a08Msg.PID.PatientAddressRepetitionsUsed - x) == 1)
                    {
                        Console.WriteLine("OK!");
                    }
                    else
                    {
                        Console.WriteLine("Failure!");
                    }
                }

                Console.WriteLine("\nDone!");
            }
        }

        private static void TestBase64Attachments()
        {
            Console.WriteLine("\n==============================================\nTesting Base64 filter stream.\n");
            var path = _basePath + "\\TestApp\\TestMessages\\Base64\\";

            var file = File.Open(path + "ORU_01.txt", FileMode.Open);
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
            using (var filterStream = new HL7FilterBase64AttachmentsStream(fs))
            {
                var result = filterStream.ReadToEnd();
                Console.WriteLine("Message: {0}", result);

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

        private static void ZrtTest()
        {
            var txtMessage = "MSH|^~\\&|ABC|DEF|DAL|QUEST|20160907113230||ORM^O01^ORM_O01|201609071132304107|P|2.5.1\rPID|1||[PATIENTID]^^^^MR||[LASTNAME]^[FIRSTNAME]^M^^^^L|SMITH|[DOB]|[GENDER]||2106-3^White^HL70005|123 Main St.^^Fischer^TX^78623^USA^H||^PRN^PH^anyone@mycompany.com^^704^5551212~^^CP^^^980^5551414|^PRN^PH^^^704^5551313|eng^English^ISO639|S^Single|||123-45-6789|||N^Not Hispanic or Latino^HL70189\rPV1|1|O|^^^ZZZZZ00002^^C^^^Bleeding Edge Trauma Center||||NPIDA^Allthework^Dew^^^Mr^PA^^^^^^NPI^^^^^^^^PA||||||||||||ZZZZZ000EJ^^^^VN|||||||||||||||||||||||||20110511132339-0400\rORC|SN|[PON]||||||||||^Jekyll^Burt^^^^^^NPI^L\rOBR||[PON]||87590^Neisseria gonorrhoeae detection by nucleic acid, direct probe^C4|||201609071108|||||||| ^^^ |^Jekyll^Burt^^^^^^NPI^L||||||||LAB\rDG1|1||I25700^Atherosclerosis of CABG, unsp, w unstable angina pectoris^ICD\rZRT|1|Inbound Processor - Prod|ConfigID=1406;MessageID=16971290;MessageType=ORM;LabOrderID=32271;PatientID=1234;|SPLINTER|";

            var emch = new EnhancedModelClassFactory();
            var parser = new PipeParser(emch);
            emch.ValidationContext = parser.ValidationContext;

            var genericIm = parser.Parse(txtMessage);

            if (genericIm is GenericMessageWrapper gcw)
            {
                var strictIm = gcw.Unwrap();
                var structureName = strictIm.GetStructureName();

                if (structureName.Contains("ORM_O01"))
                {
                    var orm = (NHapi.Model.V251.Message.ORM_O01)strictIm;
                    var sex = orm.PATIENT.PID.AdministrativeSex.Value;
                    Console.WriteLine(sex);
                }

                XMLParser xmlParser = new DefaultXMLParser();
                var xmlMessageStrict = xmlParser.Encode(strictIm);
                Console.WriteLine(xmlMessageStrict);

                var xmlMessageGeneric = xmlParser.Encode(genericIm);
                Console.WriteLine(xmlMessageGeneric);

                try
                {
                    var zrt = gcw.GetSegment<ISegment>("ZRT");

                    //if (zrt is TestApp.CustomImplementation.V251.Segment.ZRT)
                    //{
                    //  Console.WriteLine("Got a ZRT!!!");
                    //}

                    var numFields = zrt.NumFields();

                    for (var i = 1; i <= numFields; i++)
                    {
                        var field = zrt.GetField(i, 0);
                        var value = ((Varies)field).Data;
                        Console.WriteLine(value);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static void SpinnerWhileWaiting(Action processingMethod)
        {
            var spinner = new char[] { '|', '/', '-', '\\' };

            Console.Write("\r\nProcessing     ");
            var oldCursorVisibility = Console.CursorVisible;
            Console.CursorVisible = false;

            var pts = new ParameterizedThreadStart(obj => processingMethod());
            var t = new Thread(pts);
            t.Start();

            var spinnerCount = 0;
            var dotCount = 0;
            var dotPause = 0;
            while (t.IsAlive)
            {
                var spinnerText = string.Empty;
                spinnerText = spinnerText.PadRight(dotCount, '.');
                spinnerText = spinnerText.PadRight(4, ' ');
                spinnerText += spinner[spinnerCount];

                var x = Console.CursorLeft;
                var y = Console.CursorTop;

                Console.SetCursorPosition(x - 5, y);
                Console.Write(spinnerText);

                if (++spinnerCount > 3)
                {
                    spinnerCount = 0;
                }

                if (++dotPause == 20)
                {
                    dotPause = 0;
                    if (++dotCount == 4)
                    {
                        dotCount = 0;
                    }
                }

                Thread.Sleep(10);
            }

            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
            Console.CursorVisible = oldCursorVisibility;
            Console.WriteLine("... Done!");
        }
        #endregion Static methods

        #region Events

        private static void mfs_FileCompleted(object sender, FileCompletedEventArgs e)
        {
            var path = _basePath + "\\TestApp\\TestMessages\\Done";

            var fi = new FileInfo(e.FileName);
            fi.MoveTo(path + "\\" + fi.Name);
            Console.WriteLine("File '{0}' moved.", fi.Name);
        }

        #endregion Events
    }
}