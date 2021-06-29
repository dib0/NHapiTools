using NHapi.Base.Model;
using NHapi.Base.Validation;
using NHapiTools.Base.Validation;

namespace NHapiTools.Tests.CustomRules
{
    /// <inheritdoc />
    public class MessageRule : ISpecificMessageRule
    {
        public string[] GetVersions()
        {
            return new string[] {"2.3"};
        }
        
        public string[] GetMessageTypes()
        {
            return new string[] { "ADT" };
        }

        public string[] GetTriggerEvents()
        {
            return new string[] { "A01", "P03" };
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
        public ValidationException[] test(IMessage msg)
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
        public ValidationException[] Test(IMessage msg)
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
