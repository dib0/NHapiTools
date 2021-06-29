using System;
using System.Linq;
using System.Reflection;
using System.Configuration;
using NHapi.Base.Validation;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// The automated context loads all validation rules in a given namespace. The validation
    /// rules have to implement the specific validation type interfaces to be applied to the right messages.
    /// </summary>
    public class AutomatedContext : BaseContext
    {
        #region Constructor
        /// <summary>
        /// Constructor (without original context)
        /// </summary>
        public AutomatedContext() : base()
        { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="origContext">The original context. Rules from this context will be copied.</param>
        public AutomatedContext(IValidationContext origContext) : base(origContext)
        { }
        #endregion

        #region Private methods
        /// <summary>
        /// Init
        /// </summary>
        protected override void Init()
        {
            base.Init();

            string rulesNamespace = ConfigurationManager.AppSettings["NHapiRulesNamespace"];
            if (!string.IsNullOrEmpty(rulesNamespace))
            {
                Assembly assembly=null;

                try
                {
                    assembly = Assembly.Load(rulesNamespace);
                }
                catch { }

                if (assembly != null)
                    LoadRules(assembly);
            }
        }

        private void LoadRules(Assembly assembly)
        {
            Type[] classes = assembly.GetTypes();
            foreach (Type t in classes)
            {
                Type[] interfaces = t.GetInterfaces();

                if (interfaces.Contains(typeof(ISpecificEncodingRule)))
                {
                    ISpecificEncodingRule o = (ISpecificEncodingRule)Activator.CreateInstance(t);
                    encodingRules.Add(o);
                }
                else if (interfaces.Contains(typeof(ISpecificMessageRule)))
                {
                    ISpecificMessageRule o = (ISpecificMessageRule)Activator.CreateInstance(t);
                    messageRules.Add(o);
                }
                else if (interfaces.Contains(typeof(ISpecificPrimitiveTypeRule)))
                {
                    ISpecificPrimitiveTypeRule o = (ISpecificPrimitiveTypeRule)Activator.CreateInstance(t);
                    primitiveTypeRules.Add(o);
                }
            }
        }
        #endregion
    }
}
