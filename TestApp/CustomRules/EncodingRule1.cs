using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapiTools.Base;
using NHapiTools.Base.Validation;

namespace TestApp.CustomRules
{
    public class EncodingRule1 : ISpecificEncodingRule
    {
        public string[] GetVersions()
        {
            return new string[] {"2.3", "2.4"};
        }

        public string[] GetEncodings()
        {
            return new string[] {"ER7", "XML"};
        }

        public NHapi.Base.validation.ValidationException[] test(string msg)
        {
            return new NHapi.Base.validation.ValidationException[0];
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public string SectionReference
        {
            get { return string.Empty; }
        }
    }
}
