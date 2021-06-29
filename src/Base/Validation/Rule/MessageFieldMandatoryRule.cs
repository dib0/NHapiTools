using System.Configuration;
using NHapi.Base.Util;
using NHapi.Base.Validation;
using NHapiTools.Base.Configuration;

namespace NHapiTools.Base.Validation.Rule
{
    /// <summary>
    /// Implementation of a message rule that checks one or more configurable fields. These field must
    /// have a value (cannot be "" or null).
    /// </summary>
    public class MessageFieldMandatoryRule : BaseMessageRule
    {
        #region Private properties
        private MessageRuleElementCollection<MessageFieldMandatoryRuleElement> mandatoryRules;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public MessageFieldMandatoryRule()
        {
            MessageRulesSection section = (MessageRulesSection)ConfigurationManager.GetSection("SpecificRulesGroup/SpecificRules");
            mandatoryRules = section.MessageFieldMandatoryRule;

            foreach (MessageFieldMandatoryRuleElement rule in mandatoryRules)
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

            foreach (MessageFieldMandatoryRuleElement rule in mandatoryRules)
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
                    if (string.IsNullOrEmpty(value))
                    {
                        result = new ValidationException[1] { new ValidationException(string.Format("Field '{1}' is mandatory.", value, rule.FieldIndicator)) };
                    }
                }

                if (result.Length > 0)
                    break;
            }

            return result;
        }
        #endregion
    }
}
