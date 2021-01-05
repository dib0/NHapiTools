namespace NHapiTools.Tests
{
    internal class ParseResult
    {
        public ParseResult(string structure, string version)
        {
            Structure = structure;
            Version = version;
        }

        public string Structure { get; }

        public string Version { get; }

        public override bool Equals(object obj)
        {
            var other = obj as ParseResult;
            if (other == null)
            {
                return base.Equals(obj);
            }
            return Structure == other.Structure && Version == other.Version;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}