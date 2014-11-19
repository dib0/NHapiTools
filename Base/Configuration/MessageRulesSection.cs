using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Section
    /// </summary>
    public class MessageRulesSection : ConfigurationSection
    {
        /// <summary>
        /// Rule collection
        /// </summary>
        [ConfigurationProperty("SegmentMandatoryRule", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(MessageRuleElementCollection<SegmentMandatoryRule>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public MessageRuleElementCollection<SegmentMandatoryRule> SegmentMandatoryRule
        {
            get
            {
                return (MessageRuleElementCollection<SegmentMandatoryRule>)base["SegmentMandatoryRule"];
            }
        }

        /// <summary>
        /// Rule collection
        /// </summary>
        [ConfigurationProperty("MessageRegExRule", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(MessageRuleElementCollection<MessageRegExRuleElement>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public MessageRuleElementCollection<MessageRegExRuleElement> MessageRegExRules
        {
            get
            {
                return (MessageRuleElementCollection<MessageRegExRuleElement>)base["MessageRegExRule"];
            }
        }

        /// <summary>
        /// Rule collection
        /// </summary>
        [ConfigurationProperty("MessageFieldIntOnlyRule", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(MessageRuleElementCollection<MessageFieldIntOnlyRuleElement>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public MessageRuleElementCollection<MessageFieldIntOnlyRuleElement> MessageFieldIntOnlyRules
        {
            get
            {
                return (MessageRuleElementCollection<MessageFieldIntOnlyRuleElement>)base["MessageFieldIntOnlyRule"];
            }
        }

        /// <summary>
        /// Rule collection
        /// </summary>
        [ConfigurationProperty("MessageFieldMandatoryRule", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(MessageRuleElementCollection<MessageFieldMandatoryRuleElement>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public MessageRuleElementCollection<MessageFieldMandatoryRuleElement> MessageFieldMandatoryRule
        {
            get
            {
                return (MessageRuleElementCollection<MessageFieldMandatoryRuleElement>)base["MessageFieldMandatoryRule"];
            }
        }
    }
}
