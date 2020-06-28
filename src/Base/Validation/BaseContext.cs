using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;
using System.Threading.Tasks;
using NHapi.Base.validation;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// Base class for the different contexts
    /// </summary>
    public abstract class BaseContext : IValidationContext
    {
        #region Private/Protected properties
        private IValidationContext originalContext;
        /// <summary>
        /// Encoding rules
        /// </summary>
        protected List<ISpecificEncodingRule> encodingRules;
        /// <summary>
        /// Message rules
        /// </summary>
        protected List<ISpecificMessageRule> messageRules;
        /// <summary>
        /// Primitive rules
        /// </summary>
        protected List<ISpecificPrimitiveTypeRule> primitiveTypeRules;
        #endregion

        #region Public properties
        /// <summary>
        /// Message rule count
        /// </summary>
        public int MessageRuleCount
        {
            get
            {
                return messageRules.Count();
            }
        }

        /// <summary>
        /// Encoding rule count
        /// </summary>
        public int EncodingRuleCount
        {
            get
            {
                return encodingRules.Count();
            }
        }

        /// <summary>
        /// Primitive rule count
        /// </summary>
        public int PrimitiveRuleCount
        {
            get
            {
                return primitiveTypeRules.Count();
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseContext() : this(null)
        {  }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="origContext"></param>
        public BaseContext(IValidationContext origContext)
        {
            if ((origContext is AutomatedContext) || (origContext is ConfigurableContext))
                throw new ArgumentException("origContext cannot be an AutomatedContext or ConfigurableContext.");

            // Store the original context
            originalContext = origContext;

            Init();
        }
        #endregion

        #region Protected methods
        /// <summary>
        /// Init
        /// </summary>
        protected virtual void Init()
        {
            encodingRules = new List<ISpecificEncodingRule>();
            messageRules = new List<ISpecificMessageRule>();
            primitiveTypeRules = new List<ISpecificPrimitiveTypeRule>();
        }
        #endregion

        #region IValidationContext methods
        /// <summary>
        /// Get enconding rules
        /// </summary>
        /// <param name="theVersion"></param>
        /// <param name="theEncoding"></param>
        /// <returns></returns>
        public IEncodingRule[] getEncodingRules(string theVersion, string theEncoding)
        {
            IEncodingRule[] result = new IEncodingRule[0];
            if (originalContext != null)
                result = originalContext.getEncodingRules(theVersion, theEncoding);

            foreach (ISpecificEncodingRule rule in encodingRules)
            {
                // Add the rule if it applies
                bool flag1 = rule.GetVersions().Contains("*") || rule.GetVersions().Contains(theVersion);
                bool flag2 = rule.GetEncodings().Contains("*") || rule.GetEncodings().Contains(theEncoding);
                if (flag1 && flag2)
                {
                    List<IEncodingRule> rules = new List<IEncodingRule>(result);
                    rules.Add(rule);
                    result = rules.ToArray();
                }

            }

            return result;
        }

        /// <summary>
        /// Get message rules
        /// </summary>
        /// <param name="theVersion"></param>
        /// <param name="theMessageType"></param>
        /// <param name="theTriggerEvent"></param>
        /// <returns></returns>
        public IMessageRule[] getMessageRules(string theVersion, string theMessageType, string theTriggerEvent)
        {
            IMessageRule[] result = new IMessageRule[0];
            if (originalContext != null)
                result = originalContext.getMessageRules(theVersion, theMessageType, theTriggerEvent);

            foreach (ISpecificMessageRule rule in messageRules)
            {
                // Add the rule if it applies
                bool flag1 = rule.GetVersions().Contains("*") || rule.GetVersions().Contains(theVersion);
                bool flag2 = rule.GetMessageTypes().Contains("*") || rule.GetMessageTypes().Contains(theMessageType);
                bool flag3 = rule.GetTriggerEvents().Contains("*") || rule.GetTriggerEvents().Contains(theTriggerEvent);
                if (flag1 && flag2 && flag3)
                {
                    List<IMessageRule> rules = new List<IMessageRule>(result);
                    rules.Add(rule);
                    result = rules.ToArray();
                }
                
            }

            return result;
        }

        /// <summary>
        /// Get primitive rules
        /// </summary>
        /// <param name="theVersion"></param>
        /// <param name="theTypeName"></param>
        /// <param name="theType"></param>
        /// <returns></returns>
        public IPrimitiveTypeRule[] getPrimitiveRules(string theVersion, string theTypeName, NHapi.Base.Model.IPrimitive theType)
        {
            IPrimitiveTypeRule[] result = new IPrimitiveTypeRule[0];
            if (originalContext != null)
                result = originalContext.getPrimitiveRules(theVersion, theTypeName, theType);

            foreach (ISpecificPrimitiveTypeRule rule in primitiveTypeRules)
            {
                // Add the rule if it applies
                bool flag1 = rule.GetVersions().Contains("*") || rule.GetVersions().Contains(theVersion);
                bool flag2 = rule.GetTypeNames().Contains("*") || rule.GetTypeNames().Contains(theTypeName);
                if (flag1 && flag2)
                {
                    List<IPrimitiveTypeRule> rules = new List<IPrimitiveTypeRule>(result);
                    rules.Add(rule);
                    result = rules.ToArray();
                }

            }

            return result;
        }
        #endregion
    }
}
