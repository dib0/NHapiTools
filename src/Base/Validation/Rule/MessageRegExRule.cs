using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NHapi.Base.Util;
using NHapi.Base.validation;
using NHapiTools.Base.Configuration;

namespace NHapiTools.Base.Validation.Rule
{
    /// <summary>
    /// Implementation of a message rule that checks one or more configurable fields. In the configuration
    /// a regular expression must be given to be applied to these fields. The value in the fields must match the
    /// regular expressions.
    /// </summary>
    public class MessageRegExRule : BaseMessageRule
    {
        #region Private properties
        private MessageRuleElementCollection<MessageRegExRuleElement> regexRules;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public MessageRegExRule()
        {
            MessageRulesSection section = (MessageRulesSection)ConfigurationManager.GetSection("SpecificRulesGroup/SpecificRules");
            regexRules = section.MessageRegExRules;

            foreach (MessageRegExRuleElement rule in regexRules)
                messageRules.Add(rule);
        }
        #endregion

        #region Interface implementation
        /// <summary>
        /// Test
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public override ValidationException[] test(NHapi.Base.Model.IMessage msg)
        {
            ValidationException[] result = new ValidationException[0];

            foreach (MessageRegExRuleElement rule in regexRules)
            {
                bool flag1 = (rule.Version == "*") || (msg.Version == rule.Version);

                string structureName = msg.GetStructureName();
                string[] sNames = structureName.Split('_');
                bool flag2 = (rule.MessageType == "*") || (sNames[0] == rule.MessageType);
                bool flag3 = (rule.TriggerEvent == "*") || (sNames[1] == rule.TriggerEvent);

                if (flag1 && flag2 && flag3)
                {
                    Terser terser = new Terser(msg);
                    string value = terser.Get(rule.FieldIndicator);

                    if ((value == null) && !rule.AllowNull)
                    {
                        result = new ValidationException[1] { new ValidationException(string.Format("Value in '{0}' may not be null.", value)) };
                    }
                    else if ((value != null) && !Regex.IsMatch(value, rule.RegEx))
                    {
                        result = new ValidationException[1] { new ValidationException(string.Format("Value '{0}' in '{1}' doesn't match regex '{2}'.", value, rule.FieldIndicator, rule.RegEx)) };
                    }
                }

                if (result.Count() > 0)
                    break;
            }

            return result;
        }
        #endregion
    }
}
