using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NHapi.Base.Parser;
using NHapi.Base.validation;
using NHapi.Base.Model;
using NHapiTools.Base.Configuration;

namespace NHapiTools.Base.Validation.Rule
{
    /// <summary>
    /// Implementation of a message rule that checks one or more configurable segments. The segments must
    /// exist in the received message.
    /// </summary>
    public class MessageSegmentMandatoryRule : BaseMessageRule
    {
        #region Private properties
        private MessageRuleElementCollection<SegmentMandatoryRule> segmentRules;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public MessageSegmentMandatoryRule()
        {
            MessageRulesSection section = (MessageRulesSection)ConfigurationManager.GetSection("SpecificRulesGroup/SpecificRules");
            segmentRules = section.SegmentMandatoryRule;

            foreach (SegmentMandatoryRule rule in segmentRules)
                messageRules.Add(rule);
        }
        #endregion

        #region Interface implementation
        /// <summary>
        /// Test
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public override ValidationException[] test(IMessage msg)
        {
            ValidationException[] result = new ValidationException[0];

            foreach (SegmentMandatoryRule rule in segmentRules)
            {
                bool flag1 = (rule.Version == "*") || (msg.Version == rule.Version);
                
                string structureName = msg.GetStructureName();
                string[] sNames = structureName.Split('_');
                bool flag2 = (rule.MessageType == "*") || (sNames[0] == rule.MessageType);
                bool flag3 = (rule.TriggerEvent == "*") || (sNames[1] == rule.TriggerEvent);

                if (flag1 && flag2 && flag3)
                {
                    PipeParser parser = new PipeParser();
                    if (!parser.SegmentExists(msg, rule.MadatorySegment))
                    {
                        result = new ValidationException[1] { new ValidationException(string.Format("Segment {0} not available in message", rule.MadatorySegment)) };
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
