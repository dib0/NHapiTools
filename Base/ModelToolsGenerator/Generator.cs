using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace NHapiTools.Base.ModelToolsGenerator
{
    /// <summary>
    /// Source generation of extension methods on specific Model version assemblies
    /// of NHapi.
    /// </summary>
    public class Generator
    {
        #region Private properties
        string targetAssembly;
        string version;
        string outputDir;
        StringBuilder messagesOutput, segmentOutput, groupOutput;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="targetAssemblyFile">Assembly (NHapi model assembly) to generate source from.</param>
        /// <param name="outDir">Directory to generate source to.</param>
        public Generator(string targetAssemblyFile, string outDir)
        {
            targetAssembly = targetAssemblyFile;
            outputDir = outDir;
            
            messagesOutput = new StringBuilder();
            segmentOutput = new StringBuilder();
            groupOutput = new StringBuilder();
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Start source generation.
        /// </summary>
        public void Generate()
        {
            Assembly assembly = Assembly.LoadFile(targetAssembly);
            version = GetVersion(assembly.FullName);

            ProcessAssembly(assembly);
        }
        #endregion

        #region Private methods
        private string GetVersion(string name)
        {
            int startIndex = name.IndexOf(".V") + 1;

            string result = name.Substring(startIndex, name.IndexOf(',') - startIndex);
            return result;
        }

        private void ProcessAssembly(Assembly assembly)
        {
            ProcessMessages(assembly.GetTypes().Where(t => t.Namespace.EndsWith(".Message")).ToList());
            ProcessSegments(assembly.GetTypes().Where(t => t.Namespace.EndsWith(".Segment")).ToList());
            ProcessGroups(assembly.GetTypes().Where(t => t.Namespace.EndsWith(".Group")).ToList());
        }

        #region Messages
        private void ProcessMessages(List<Type> messageTypes)
        {
            foreach (Type message in messageTypes)
            {
                List<string> names = GetPropertyNames(message.GetProperties());

                // Generate methods
                foreach (string name in names)
                {
                    MethodInfo mInfo = message.GetMethod(string.Format("Get{0}", name), new Type[]{typeof(int)});
                    string returnType = mInfo.ReturnType.Name;

                    GenerateMessageMethods(message.Name, name, returnType);
                }
            }

            AddMessagesFooter();
            SaveMessagesFile();
        }

        private void GenerateMessageMethods(string typeName, string name, string returnType)
        {
            bool exists = messagesOutput.ToString().Contains(string.Format("public static IEnumerable Get{1}Records(this {0} message)", typeName, name));

            if (exists)
                return;

            bool first = (messagesOutput.Length == 0);
            // Add header
            if (first)
                AddMessagesHeader();
            else
                messagesOutput.Append("\n");

            messagesOutput.Append("        /// <summary>\n");
            messagesOutput.Append(string.Format("        /// Get {1} Records from {0}\n", typeName, name));
            messagesOutput.Append("        /// </summary>\n");
            messagesOutput.Append(string.Format("        public static IEnumerable Get{1}Records(this {0} message)\n", typeName, name));
            messagesOutput.Append("        {\n");
            messagesOutput.Append(string.Format("            object[] result = message.GetRecords(\"{0}RepetitionsUsed\", \"Get{0}\");\n", name));
            messagesOutput.Append("\n");
            messagesOutput.Append("            if ((result != null) && (result.Count() > 0))\n");
            messagesOutput.Append("            {\n");
            messagesOutput.Append("                for (int i = 0; i < result.Count(); i++)\n");
            messagesOutput.Append("                    yield return result[i];\n");
            messagesOutput.Append("            }\n");
            messagesOutput.Append("        }\n");
            messagesOutput.Append("\n");
            messagesOutput.Append("        /// <summary>\n");
            messagesOutput.Append(string.Format("        /// Get all {1} Records from {0}\n", typeName, name));
            messagesOutput.Append("        /// </summary>\n");
            messagesOutput.Append(string.Format("        public static List<{0}> GetAll{1}Records(this {2} message)\n", returnType, name, typeName));
            messagesOutput.Append("        {\n");
            messagesOutput.Append(string.Format("            return message.GetAllRecords<{1}>(\"{0}RepetitionsUsed\", \"Get{0}\");\n", name, returnType));
            messagesOutput.Append("        }\n");
            messagesOutput.Append("\n");
            messagesOutput.Append("        /// <summary>\n");
            messagesOutput.Append(string.Format("        /// Add a new {0} to {1}\n", typeName, name));
            messagesOutput.Append("        /// </summary>\n");
            messagesOutput.Append(string.Format("        public static {0} Add{1}(this {2} message)\n", returnType, name, typeName));
            messagesOutput.Append("        {\n");
            messagesOutput.Append(string.Format("            return message.Get{0}(message.{0}RepetitionsUsed);\n", name, returnType));
            messagesOutput.Append("        }\n");
        }

        private void AddMessagesHeader()
        {
            messagesOutput.Append("using System;\n");
            messagesOutput.Append("using System.Collections;\n");
            messagesOutput.Append("using System.Collections.Generic;\n");
            messagesOutput.Append("using System.Linq;\n");
            messagesOutput.Append("using System.Text;\n");
            messagesOutput.Append("using System.Threading.Tasks;\n");
            messagesOutput.Append("using NHapi.Base.Model;\n");
            messagesOutput.Append(string.Format("using NHapi.Model.{0}.Group;\n", version));
            messagesOutput.Append(string.Format("using NHapi.Model.{0}.Message;\n", version));
            messagesOutput.Append(string.Format("using NHapi.Model.{0}.Segment;\n", version));
            messagesOutput.Append("using NHapiTools.Base;\n");
            messagesOutput.Append("\n");
            messagesOutput.Append(string.Format("namespace NHapiTools.Model.{0}.Message\n", version));
            messagesOutput.Append("{\n");
            messagesOutput.Append("    /// <summary>\n");
            messagesOutput.Append("    /// Message extention methods\n");
            messagesOutput.Append("    /// </summary>\n");
            messagesOutput.Append("    public static class MessageExtensions\n");
            messagesOutput.Append("    {\n");
            messagesOutput.Append("        #region Extension methods\n");
        }

        private void AddMessagesFooter()
        {
            if (messagesOutput.Length > 0)
            {
                messagesOutput.Append("        #endregion\n");
                messagesOutput.Append("    }\n");
                messagesOutput.Append("}\n");
            }
        }

        private void SaveMessagesFile()
        {
            string filename = outputDir.EndsWith("\\")?outputDir : outputDir + "\\";
            filename += version + "\\Message";
            if (!Directory.Exists(filename))
                Directory.CreateDirectory(filename);
            filename += "\\MessageExtensions.cs";

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(messagesOutput.ToString());
            }
        }
        #endregion

        #region Segments
        private void ProcessSegments(List<Type> segmentTypes)
        {
            foreach (Type segment in segmentTypes)
            {
                List<string> names = GetPropertyNames(segment.GetProperties());

                // Generate methods
                foreach (string name in names)
                {
                    MethodInfo mInfo = segment.GetMethod(string.Format("Get{0}", name), new Type[] { typeof(int) });
                    string returnType = mInfo.ReturnType.Name;

                    GenerateSegmentMethods(segment.Name, name, returnType);
                }
            }

            AddSegmentsFooter();
            SaveSegmentsFile();
        }

        private void GenerateSegmentMethods(string typeName, string name, string returnType)
        {
            bool exists = segmentOutput.ToString().Contains(string.Format("public static IEnumerable Get{1}Records(this {0} message)", typeName, name));

            if (exists)
                return;

            bool first = (segmentOutput.Length == 0);
            // Add header
            if (first)
                AddSegmentsHeader();
            else
                segmentOutput.Append("\n");

            segmentOutput.Append("        /// <summary>\n");
            segmentOutput.Append(string.Format("        /// Get {1} Records from {0}\n", typeName, name));
            segmentOutput.Append("        /// </summary>\n");
            segmentOutput.Append(string.Format("        public static IEnumerable Get{1}Records(this {0} message)\n", typeName, name));
            segmentOutput.Append("        {\n");
            segmentOutput.Append(string.Format("            object[] result = message.GetRecords(\"{0}RepetitionsUsed\", \"Get{0}\");\n", name));
            segmentOutput.Append("\n");
            segmentOutput.Append("            if ((result != null) && (result.Count() > 0))\n");
            segmentOutput.Append("            {\n");
            segmentOutput.Append("                for (int i = 0; i < result.Count(); i++)\n");
            segmentOutput.Append("                    yield return result[i];\n");
            segmentOutput.Append("            }\n");
            segmentOutput.Append("        }\n");
            segmentOutput.Append("\n");
            segmentOutput.Append("        /// <summary>\n");
            segmentOutput.Append(string.Format("        /// Get all {1} Records from {0}\n", typeName, name));
            segmentOutput.Append("        /// </summary>\n");
            segmentOutput.Append(string.Format("        public static List<{0}> GetAll{1}Records(this {2} message)\n", returnType, name, typeName));
            segmentOutput.Append("        {\n");
            segmentOutput.Append(string.Format("            return message.GetAllRecords<{1}>(\"{0}RepetitionsUsed\", \"Get{0}\");\n", name, returnType));
            segmentOutput.Append("        }\n");
            segmentOutput.Append("\n");
            segmentOutput.Append("        /// <summary>\n");
            segmentOutput.Append(string.Format("        /// Add a new {0} to {1}\n", typeName, name));
            segmentOutput.Append("        /// </summary>\n");
            segmentOutput.Append(string.Format("        public static {0} Add{1}(this {2} message)\n", returnType, name, typeName));
            segmentOutput.Append("        {\n");
            segmentOutput.Append(string.Format("            return message.Get{0}(message.{0}RepetitionsUsed);\n", name, returnType));
            segmentOutput.Append("        }\n");
        }

        private void AddSegmentsHeader()
        {
            segmentOutput.Append("using System;\n");
            segmentOutput.Append("using System.Collections;\n");
            segmentOutput.Append("using System.Collections.Generic;\n");
            segmentOutput.Append("using System.Linq;\n");
            segmentOutput.Append("using System.Text;\n");
            segmentOutput.Append("using System.Threading.Tasks;\n");
            segmentOutput.Append("using NHapi.Base.Model;\n");
            segmentOutput.Append(string.Format("using NHapi.Model.{0}.Group;\n", version));
            segmentOutput.Append(string.Format("using NHapi.Model.{0}.Message;\n", version));
            segmentOutput.Append(string.Format("using NHapi.Model.{0}.Segment;\n", version));
            segmentOutput.Append(string.Format("using NHapi.Model.{0}.Datatype;\n", version));
            segmentOutput.Append("using NHapiTools.Base;\n");
            segmentOutput.Append("\n");
            segmentOutput.Append(string.Format("namespace NHapiTools.Model.{0}.Segment\n", version));
            segmentOutput.Append("{\n");
            segmentOutput.Append("    /// <summary>\n");
            segmentOutput.Append("    /// Extention methods\n");
            segmentOutput.Append("    /// </summary>\n");
            segmentOutput.Append("    public static class SegmentExtensions\n");
            segmentOutput.Append("    {\n");
            segmentOutput.Append("        #region Extension methods\n");
        }

        private void AddSegmentsFooter()
        {
            if (segmentOutput.Length > 0)
            {
                segmentOutput.Append("        #endregion\n");
                segmentOutput.Append("    }\n");
                segmentOutput.Append("}\n");
            }
        }

        private void SaveSegmentsFile()
        {
            string filename = outputDir.EndsWith("\\") ? outputDir : outputDir + "\\";
            filename += version + "\\Segment";
            if (!Directory.Exists(filename))
                Directory.CreateDirectory(filename);
            filename += "\\SegmentExtensions.cs";

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(segmentOutput.ToString());
            }
        }
        #endregion

        #region Groups
        private void ProcessGroups(List<Type> groupTypes)
        {
            foreach (Type group in groupTypes)
            {
                List<string> names = GetPropertyNames(group.GetProperties());

                // Generate methods
                foreach (string name in names)
                {
                    MethodInfo mInfo = group.GetMethod(string.Format("Get{0}", name), new Type[] { typeof(int) });
                    string returnType = mInfo.ReturnType.Name;

                    GenerateGroupMethods(group.Name, name, returnType);
                }
            }

            AddGroupFooter();
            SaveGroupFile();
        }

        private void GenerateGroupMethods(string typeName, string name, string returnType)
        {
            bool exists = groupOutput.ToString().Contains(string.Format("public static IEnumerable Get{1}Records(this {0} message)", typeName, name));

            if (exists)
                return;

            bool first = (groupOutput.Length == 0);
            // Add header
            if (first)
                AddGroupHeader();
            else
                groupOutput.Append("\n");

            groupOutput.Append("        /// <summary>\n");
            groupOutput.Append(string.Format("        /// Get {1} Records from {0}\n", typeName, name));
            groupOutput.Append("        /// </summary>\n");
            groupOutput.Append(string.Format("        public static IEnumerable Get{1}Records(this {0} message)\n", typeName, name));
            groupOutput.Append("        {\n");
            groupOutput.Append(string.Format("            object[] result = message.GetRecords(\"{0}RepetitionsUsed\", \"Get{0}\");\n", name));
            groupOutput.Append("\n");
            groupOutput.Append("            if ((result != null) && (result.Count() > 0))\n");
            groupOutput.Append("            {\n");
            groupOutput.Append("                for (int i = 0; i < result.Count(); i++)\n");
            groupOutput.Append("                    yield return result[i];\n");
            groupOutput.Append("            }\n");
            groupOutput.Append("        }\n");
            groupOutput.Append("\n");
            groupOutput.Append("        /// <summary>\n");
            groupOutput.Append(string.Format("        /// Get all {1} Records from {0}\n", typeName, name));
            groupOutput.Append("        /// </summary>\n");
            groupOutput.Append(string.Format("        public static List<{0}> GetAll{1}Records(this {2} message)\n", returnType, name, typeName));
            groupOutput.Append("        {\n");
            groupOutput.Append(string.Format("            return message.GetAllRecords<{1}>(\"{0}RepetitionsUsed\", \"Get{0}\");\n", name, returnType));
            groupOutput.Append("        }\n");
            groupOutput.Append("\n");
            groupOutput.Append("        /// <summary>\n");
            groupOutput.Append(string.Format("        /// Add a new {0} to {1}\n", typeName, name));
            groupOutput.Append("        /// </summary>\n");
            groupOutput.Append(string.Format("        public static {0} Add{1}(this {2} message)\n", returnType, name, typeName));
            groupOutput.Append("        {\n");
            groupOutput.Append(string.Format("            return message.Get{0}(message.{0}RepetitionsUsed);\n", name, returnType));
            groupOutput.Append("        }\n");
        }

        private void AddGroupHeader()
        {
            groupOutput.Append("using System;\n");
            groupOutput.Append("using System.Collections;\n");
            groupOutput.Append("using System.Collections.Generic;\n");
            groupOutput.Append("using System.Linq;\n");
            groupOutput.Append("using System.Text;\n");
            groupOutput.Append("using System.Threading.Tasks;\n");
            groupOutput.Append("using NHapi.Base.Model;\n");
            groupOutput.Append(string.Format("using NHapi.Model.{0}.Group;\n", version));
            groupOutput.Append(string.Format("using NHapi.Model.{0}.Message;\n", version));
            groupOutput.Append(string.Format("using NHapi.Model.{0}.Segment;\n", version));
            groupOutput.Append(string.Format("using NHapi.Model.{0}.Datatype;\n", version));
            groupOutput.Append("using NHapiTools.Base;\n");
            groupOutput.Append("\n");
            groupOutput.Append(string.Format("namespace NHapiTools.Model.{0}.Group\n", version));
            groupOutput.Append("{\n");
            groupOutput.Append("    /// <summary>\n");
            groupOutput.Append("    /// Extention methods\n");
            groupOutput.Append("    /// </summary>\n");
            groupOutput.Append("    public static class GroupExtensions\n");
            groupOutput.Append("    {\n");
            groupOutput.Append("        #region Extension methods\n");
        }

        private void AddGroupFooter()
        {
            if (groupOutput.Length > 0)
            {
                groupOutput.Append("        #endregion\n");
                groupOutput.Append("    }\n");
                groupOutput.Append("}\n");
            }
        }

        private void SaveGroupFile()
        {
            string filename = outputDir.EndsWith("\\") ? outputDir : outputDir + "\\";
            filename += version + "\\Group";
            if (!Directory.Exists(filename))
                Directory.CreateDirectory(filename);
            filename += "\\GroupExtensions.cs";

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(groupOutput.ToString());
            }
        }
        #endregion

        private List<string> GetPropertyNames(PropertyInfo[] properties)
        {
            List<string> result = new List<string>();

            List<PropertyInfo> props = properties.Where(p => p.Name.EndsWith("RepetitionsUsed")).ToList();
            foreach (PropertyInfo p in props)
                result.Add(p.Name.Remove(p.Name.IndexOf("RepetitionsUsed")));

            return result;
        }
        #endregion
    }
}
