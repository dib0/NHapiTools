using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// configuration elements
    /// </summary>
    public class BaseMessageRuleElement : ConfigurationElement
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
        /// Version
        /// </summary>
        [ConfigurationProperty("Version", IsRequired = true)]
        public string Version
        {
            get
            {
                return (string)this["Version"];
            }
            set
            {
                this["Version"] = value;
            }
        }

        /// <summary>
        /// Message type
        /// </summary>
        [ConfigurationProperty("MessageType", IsRequired = true)]
        public string MessageType
        {
            get
            {
                return (string)this["MessageType"];
            }
            set
            {
                this["MessageType"] = value;
            }
        }

        /// <summary>
        /// Trigger event
        /// </summary>
        [ConfigurationProperty("TriggerEvent", IsRequired = true)]
        public string TriggerEvent
        {
            get
            {
                return (string)this["TriggerEvent"];
            }
            set
            {
                this["TriggerEvent"] = value;
            }
        }
    }
}
