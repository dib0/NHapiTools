using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;
using System.Threading.Tasks;
using NHapi.Base.validation;
using NHapiTools.Base.Configuration;
using System.Runtime.Remoting;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// The configurable context loads the validation rules from the configuration file. The validation
    /// rules have to implement the specific validation type interfaces to be applied to the right messages.
    /// </summary>
    public class ConfigurableContext : BaseContext
    {
        #region Constructor
        /// <summary>
        /// Constructor (without original context)
        /// </summary>
        public ConfigurableContext()
            : base()
        { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="origContext">The original context. Rules from this context will be copied.</param>
        public ConfigurableContext(IValidationContext origContext)
            : base(origContext)
        { }
        #endregion

        #region Private methods
        /// <summary>
        /// Init
        /// </summary>
        protected override void Init()
        {
            base.Init();

            ValidationSection section = (ValidationSection)ConfigurationManager.GetSection("hl7ValidationRulesGroup/hl7ValidationRules");
            foreach (MessageRuleElement element in section.MessageRules)
            {
                ISpecificMessageRule rule = ActivateObject<ISpecificMessageRule>(element.Assembly, element.Type);
                if (rule != null)
                    messageRules.Add(rule);
            }

            foreach (PrimitiveRuleElement element in section.PrimitiveTypeRules)
            {
                ISpecificPrimitiveTypeRule rule = ActivateObject<ISpecificPrimitiveTypeRule>(element.Assembly, element.Type);
                if (rule != null)
                    primitiveTypeRules.Add(rule);
            }

            foreach (EncodingRuleElement element in section.EncodingRules)
            {
                ISpecificEncodingRule rule = ActivateObject<ISpecificEncodingRule>(element.Assembly, element.Type);
                if (rule != null)
                    encodingRules.Add(rule);
            }
        }

        private T ActivateObject<T>(string assembly, string classType) where T:class
        {
            ObjectHandle oh = Activator.CreateInstance(assembly, classType);
            return oh.Unwrap() as T;
        }
        #endregion
    }
}
