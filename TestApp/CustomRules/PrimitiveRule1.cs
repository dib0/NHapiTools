using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapiTools.Base;
using NHapiTools.Base.Validation;

namespace TestApp.CustomRules
{
    public class PrimitiveRule1 : ISpecificPrimitiveTypeRule
    {
        public string[] GetVersions()
        {
            return new string[] { "2.4" };
        }

        public string[] GetTypeNames()
        {
            return new string[] { "ST" };
        }

        public string correct(string originalValue)
        {
            return originalValue;
        }

        public bool test(string testValu)
        {
            return true;
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
