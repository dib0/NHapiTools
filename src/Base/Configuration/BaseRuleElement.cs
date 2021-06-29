using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Configuration element
    /// </summary>
    public class BaseRuleElement : ConfigurationElement
    {
        /// <summary>
        /// Name
        /// </summary>
        [ConfigurationProperty("Name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)this["Name"];
            }
            set
            {
                this["Name"] = value;
            }
        }

        /// <summary>
        /// Assembly
        /// </summary>
        [ConfigurationProperty("Assembly", IsRequired = true)]
        public string Assembly
        {
            get
            {
                return (string)this["Assembly"];
            }
            set
            {
                this["Assembly"] = value;
            }
        }

        /// <summary>
        /// Type
        /// </summary>
        [ConfigurationProperty("Type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["Type"];
            }
            set
            {
                this["Type"] = value;
            }
        }
    }
}
