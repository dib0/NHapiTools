using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base.validation;

namespace NHapiTools.Base.Parser
{
    /// <summary>
    /// Different implementation of the DefaultModelClassFactory. The Enhanced Factory provides the 
    /// possibility to wrap parsed messages in a GenericMessageWrapper, providing the possibility
    /// to overwrite segments with a custom implementation.
    /// </summary>
    public class EnhancedModelClassFactory : DefaultModelClassFactory
    {
        #region Private properties
        private static string lastAskedTheName;
        private static string lastAskedTheVersion;
        private static bool lastAskedIsExplicit;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public EnhancedModelClassFactory() : base()
        { }

        #region Public properties
        /// <summary>
        /// Validation context.
        /// </summary>
        public IValidationContext ValidationContext
        {
            get;
            set;
        }
        #endregion

        #region Overridden methods
        /// <summary>
        /// Get Message class
        /// </summary>
        /// <param name="theName"></param>
        /// <param name="theVersion"></param>
        /// <param name="isExplicit"></param>
        /// <returns></returns>
        public override Type GetMessageClass(string theName, string theVersion, bool isExplicit)
        {
            lastAskedTheName = theName;
            lastAskedTheVersion = theVersion;
            lastAskedIsExplicit = isExplicit;

            return typeof(NHapiTools.Base.Model.GenericMessageWrapper);
        }

        /// <summary>
        /// Get type of segment
        /// </summary>
        /// <param name="theName"></param>
        /// <param name="theVersion"></param>
        /// <returns></returns>
        public override Type GetSegmentClass(string theName, string theVersion)
        {
            Type t = base.GetSegmentClass(theName, theVersion);
            return t;
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Get specific message class
        /// </summary>
        /// <returns></returns>
        public Type GetSpecificMessageClass()
        {
            string theName = lastAskedTheName;
            string theVersion = lastAskedTheVersion;
            bool isExplicit = lastAskedIsExplicit;

            return base.GetMessageClass(theName, theVersion, isExplicit);
        }
        #endregion
    }
}