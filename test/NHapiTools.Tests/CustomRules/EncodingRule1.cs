using NHapiTools.Base.Validation;
using NHapi.Base.Validation;

namespace NHapiTools.Tests.CustomRules
{
    /// <inheritdoc />
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

        /// <summary>
        /// Tests the given encoded message text against the criteria
        /// defined by this rule class.
        /// </summary>
        /// <returns>
        /// A list of exceptions indicating points at which the given
        /// message failed to validate (empty if validation succeeds; may
        /// not be a complete list as testing may be aborted after failure).
        /// </returns>
        public ValidationException[] test(string msg)
        {
            return Test(msg);
        }

        /// <summary>
        /// Tests the given encoded message text against the criteria
        /// defined by this rule class.
        /// </summary>
        /// <returns>
        /// A list of exceptions indicating points at which the given
        /// message failed to validate (empty if validation succeeds; may
        /// not be a complete list as testing may be aborted after failure).
        /// </returns>
        public ValidationException[] Test(string msg)
        {
            return new ValidationException[0];
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
