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
    /// Implementation of a message rule that checks one or more configurable fields. These field must
    /// contain numbers that can be parsed to an int.
    /// </summary>
    public class MessageFieldIntOnlyRule : BaseMessageRule
    {
        #region Private properties
        private MessageRuleElementCollection<MessageFieldIntOnlyRuleElement> regexRules;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public MessageFieldIntOnlyRule()
        {
            MessageRulesSection section = (MessageRulesSection)ConfigurationManager.GetSection("SpecificRulesGroup/SpecificRules");
            regexRules = section.MessageFieldIntOnlyRules;

            foreach (MessageFieldIntOnlyRuleElement rule in regexRules)
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

            foreach (MessageFieldIntOnlyRuleElement rule in regexRules)
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
                    int x = 0;
                    if ((value == null) && !rule.AllowNull)
                    {
                        result = new ValidationException[1] { new ValidationException(string.Format("Value in '{0}' may not be null.", value)) };
                    }
                    else if ((value != null) && !int.TryParse(value, out x))
                    {
                        result = new ValidationException[1] { new ValidationException(string.Format("Value '{0}' in '{1}' isn't an Int32.", value, rule.FieldIndicator)) };
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
