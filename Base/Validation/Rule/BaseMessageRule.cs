using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapiTools.Base.Configuration;
using NHapi.Base.validation;
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
        /// Get versions
        /// </summary>
        /// <returns></returns>
        public string[] GetVersions()
        {
            List<string> result = new List<string>();

            foreach (BaseMessageRuleElement rule in messageRules)
                result.Add(rule.Version);

            return result.ToArray();            
        }

        /// <summary>
        /// Get message types
        /// </summary>
        /// <returns></returns>
        public string[] GetMessageTypes()
        {
            List<string> result = new List<string>();

            foreach (BaseMessageRuleElement rule in messageRules)
                result.Add(rule.MessageType);

            return result.ToArray();
        }

        /// <summary>
        /// Get events
        /// </summary>
        /// <returns></returns>
        public string[] GetTriggerEvents()
        {
            List<string> result = new List<string>();

            foreach (BaseMessageRuleElement rule in messageRules)
                result.Add(rule.TriggerEvent);

            return result.ToArray();
        }

        /// <summary>
        /// Test
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public virtual ValidationException[] test(IMessage msg)
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
