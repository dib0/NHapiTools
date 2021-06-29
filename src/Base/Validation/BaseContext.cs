using System;
using System.Collections.Generic;
using System.Linq;
using NHapi.Base.Model;
using NHapi.Base.Validation;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// Base class for the different contexts
    /// </summary>
    /// <inheritdoc />
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
        /// Get encoding rules
        /// </summary>
        /// <param name="theVersion">an HL7 version (eg "2.1").</param>
        /// <param name="theEncoding">an encoding name (eg "VB", "XML).</param>
        /// <returns> the active encoding rules that apply to the given version and encoding.</returns>
        public IEncodingRule[] getEncodingRules(string theVersion, string theEncoding)
        {
            return GetEncodingRules(theVersion, theEncoding);
        }

        /// <summary>
        /// Get message rules
        /// </summary>
        /// <param name="theVersion">an HL7 version (eg "2.1").</param>
        /// <param name="theMessageType">a value valid for MSH-9-1.</param>
        /// <param name="theTriggerEvent">a value valid fro MSH-9-2.</param>
        /// <returns>
        /// the active rules that apply to message of the given version, message type,
        /// and trigger event.
        /// </returns>
        public IMessageRule[] getMessageRules(string theVersion, string theMessageType, string theTriggerEvent)
        {
            return GetMessageRules(theVersion, theMessageType, theTriggerEvent);
        }

        /// <summary>
        /// Get primitive rules
        /// </summary>
        /// <param name="theVersion">an HL7 version (eg "2.1").</param>
        /// <param name="theTypeName">a primitive datatype name (eg "ST").</param>
        /// <param name="theType">the Primitive being validated.</param>
        /// <returns>
        /// active rules for checking the given type in the given version.
        /// </returns>
        public IPrimitiveTypeRule[] getPrimitiveRules(string theVersion, string theTypeName, IPrimitive theType)
        {
            return GetPrimitiveRules(theVersion, theTypeName, theType);
        }

        /// <summary>
        /// Get primitive rules
        /// </summary>
        /// <param name="theVersion">an HL7 version (eg "2.1").</param>
        /// <param name="theTypeName">a primitive datatype name (eg "ST").</param>
        /// <param name="theType">the Primitive being validated.</param>
        /// <returns>
        /// active rules for checking the given type in the given version.
        /// </returns>
        public IPrimitiveTypeRule[] GetPrimitiveRules(string theVersion, string theTypeName, IPrimitive theType)
        {
            IPrimitiveTypeRule[] result = new IPrimitiveTypeRule[0];
            if (originalContext != null)
                result = originalContext.GetPrimitiveRules(theVersion, theTypeName, theType);

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

        /// <summary>
        /// Get message rules
        /// </summary>
        /// <param name="theVersion">an HL7 version (eg "2.1").</param>
        /// <param name="theMessageType">a value valid for MSH-9-1.</param>
        /// <param name="theTriggerEvent">a value valid fro MSH-9-2.</param>
        /// <returns>
        /// the active rules that apply to message of the given version, message type,
        /// and trigger event.
        /// </returns>
        public IMessageRule[] GetMessageRules(string theVersion, string theMessageType, string theTriggerEvent)
        {
            IMessageRule[] result = new IMessageRule[0];
            if (originalContext != null)
                result = originalContext.GetMessageRules(theVersion, theMessageType, theTriggerEvent);

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
        /// Get encoding rules
        /// </summary>
        /// <param name="theVersion">an HL7 version (eg "2.1").</param>
        /// <param name="theEncoding">an encoding name (eg "VB", "XML).</param>
        /// <returns>
        /// the active encoding rules that apply to the given version and encoding.
        /// </returns>
        public IEncodingRule[] GetEncodingRules(string theVersion, string theEncoding)
        {
            IEncodingRule[] result = new IEncodingRule[0];
            if (originalContext != null)
                result = originalContext.GetEncodingRules(theVersion, theEncoding);

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

        #endregion
    }
}
