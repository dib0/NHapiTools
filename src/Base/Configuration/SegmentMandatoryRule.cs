using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Configuration element
    /// </summary>
    public class SegmentMandatoryRule : BaseMessageRuleElement
    {
        /// <summary>
        /// Mandatory segment
        /// </summary>
        [ConfigurationProperty("MadatorySegment", IsRequired = true)]
        public string MadatorySegment
        {
            get
            {
                return (string)this["MadatorySegment"];
            }
            set
            {
                this["MadatorySegment"] = value;
            }
        }
    }
}
