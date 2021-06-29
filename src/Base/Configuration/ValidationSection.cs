using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Validation section
    /// </summary>
    public class ValidationSection : ConfigurationSection
    {
        /// <summary>
        /// Rules
        /// </summary>
        [ConfigurationProperty("EncodingRules", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(RuleElementCollection<EncodingRuleElement>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public RuleElementCollection<EncodingRuleElement> EncodingRules
        {
            get
            {
                return (RuleElementCollection<EncodingRuleElement>)base["EncodingRules"];
            }
        }

        /// <summary>
        /// Rules
        /// </summary>
        [ConfigurationProperty("MessageRules", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(RuleElementCollection<MessageRuleElement>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public RuleElementCollection<MessageRuleElement> MessageRules
        {
            get
            {
                return (RuleElementCollection<MessageRuleElement>)base["MessageRules"];
            }
        }

        /// <summary>
        /// Rules
        /// </summary>
        [ConfigurationProperty("PrimitiveTypeRules", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(RuleElementCollection<PrimitiveRuleElement>),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public RuleElementCollection<PrimitiveRuleElement> PrimitiveTypeRules
        {
            get
            {
                return (RuleElementCollection<PrimitiveRuleElement>)base["PrimitiveTypeRules"];
            }
        }
    }
}
