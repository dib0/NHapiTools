using System.Collections.Generic;
using NHapiTools.Base.Configuration;
using NHapi.Base.Validation;
using NHapi.Base.Model;

namespace NHapiTools.Base.Validation.Rule
{
    /// <summary>
    /// Base class for the implementation of message rules to be used
    /// with the AutomatedContext or the Configurable context.
    /// 
    /// Adds functionality on the IMessageRule to add versions, types and events
    /// that the rule applies to.
    /// </summary>
    public class BaseMessageRule : ISpecificMessageRule
    {
        #region Protected properties
        /// <summary>
        /// Message rules
        /// </summary>
        protected MessageRuleElementCollection<BaseMessageRuleElement> messageRules = new MessageRuleElementCollection<BaseMessageRuleElement>();
        #endregion

        #region Interface implementation
        /// <summary>
        /// Get the versions the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with versions</returns>
        public string[] GetVersions()
        {
            List<string> result = new List<string>();

            foreach (BaseMessageRuleElement rule in messageRules)
                result.Add(rule.Version);

            return result.ToArray();            
        }

        /// <summary>
        /// Get the message type the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with message types</returns>
        public string[] GetMessageTypes()
        {
            List<string> result = new List<string>();

            foreach (BaseMessageRuleElement rule in messageRules)
                result.Add(rule.MessageType);

            return result.ToArray();
        }

        /// <summary>
        /// Get the trigger events the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with trigger events.</returns>
        public string[] GetTriggerEvents()
        {
            List<string> result = new List<string>();

            foreach (BaseMessageRuleElement rule in messageRules)
                result.Add(rule.TriggerEvent);

            return result.ToArray();
        }

        /// <summary>
        /// Tests the given (fully populated) message against the criteria
        /// defined by this rule class.
        /// </summary>
        /// <returns>
        /// A list of exceptions indicating points at which the given
        /// message failed to validate (empty if validation succeeds; may
        /// not be a complete list as testing may be aborted after failure).
        /// The list should be empty if this rule is evaluated against a type
        /// of message to which it doesn't apply.
        /// </returns>
        public virtual ValidationException[] test(IMessage msg)
        {
            return Test(msg);
        }

        /// <summary>
        /// Tests the given (fully populated) message against the criteria
        /// defined by this rule class.
        /// </summary>
        /// <returns>
        /// A list of exceptions indicating points at which the given
        /// message failed to validate (empty if validation succeeds; may
        /// not be a complete list as testing may be aborted after failure).
        /// The list should be empty if this rule is evaluated against a type
        /// of message to which it doesn't apply.
        /// </returns>
        public ValidationException[] Test(IMessage msg)
        {
            return new ValidationException[0];
        }

        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Section reference
        /// </summary>
        public string SectionReference
        {
            get { return string.Empty; }
        }
        #endregion
    }
}
