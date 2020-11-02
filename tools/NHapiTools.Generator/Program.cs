using System;
using System.IO;

namespace NHapiTools.Generator
{
    class Program
    {
        private static string BaseDirectory { get; } = AppDomain.CurrentDomain.BaseDirectory;

        static void Main(string[] args)
        {
            var nhapiDllDir = args.Length == 0 ? BaseDirectory : args[0];
            var rootDir = BaseDirectory.Remove(BaseDirectory.IndexOf(Path.Combine("tools", typeof(Program).Namespace), StringComparison.Ordinal));
            var outDir = Path.Combine(rootDir, "src");

            if (string.IsNullOrWhiteSpace(nhapiDllDir))
            {
                Console.WriteLine("Please provide a valid path to the nhapi dlls");
            }

            var dllFiles = Directory.GetFiles(nhapiDllDir, "NHapi.Model.V*.dll");

            Console.WriteLine("\n==============================================\nStarting source generation.");

            foreach (var dllFile in dllFiles)
            {
                if (dllFile.Contains("NHapi.Model.V"))
                {
                    Console.WriteLine($"Generating source for {dllFile}.");
                    var generator = new Base.ModelToolsGenerator.Generator(dllFile, outDir);
                    generator.Generate();
                }
            }

            Console.WriteLine("\nDone!.");
        }
    }
}
