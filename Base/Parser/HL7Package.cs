using System;

namespace NHapiTools.Base.Parser
{
    internal class Hl7Package
    {
        private string _version;
        private string _packageName;

        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        public string PackageName
        {
            get
            {
                return this._packageName;
            }
        }

        public string EventMappingResourceName
        {
            get
            {
                return this._packageName + ".EventMapping.EventMap.properties";
            }
        }

        public Hl7Package(string packageName, string version)
        {
            this._version = version;
            this._packageName = packageName;
        }
    }
}
