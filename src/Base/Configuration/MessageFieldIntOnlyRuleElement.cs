using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Rule element
    /// </summary>
    public class MessageFieldIntOnlyRuleElement : BaseMessageRuleElement
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
