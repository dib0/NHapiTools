using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Configuration element
    /// </summary>
    public class MessageRegExRuleElement : BaseMessageRuleElement
    {
        /// <summary>
        /// Field indicator
        /// </summary>
        [ConfigurationProperty("FieldIndicator", IsRequired = true)]
        public string FieldIndicator
        {
            get
            {
                return (string)this["FieldIndicator"];
            }
            set
            {
                this["FieldIndicator"] = value;
            }
        }

        /// <summary>
        /// RegEx
        /// </summary>
        [ConfigurationProperty("RegEx", IsRequired = true)]
        public string RegEx
        {
            get
            {
                return (string)this["RegEx"];
            }
            set
            {
                this["RegEx"] = value;
            }
        }

        /// <summary>
        /// Allow null
        /// </summary>
        [ConfigurationProperty("AllowNull", DefaultValue=true, IsRequired = false)]
        public bool AllowNull
        {
            get
            {
                return (bool)this["AllowNull"];
            }
            set
            {
                this["AllowNull"] = value;
            }
        }
    }
}
