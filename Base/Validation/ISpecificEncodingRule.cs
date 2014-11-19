using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.validation;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// This provides a more specific interface thant the original IEncodingRule. Implementations
    /// of this interface are to be used with the AutomatedContext or ConfigurableContext
    /// </summary>
    public interface ISpecificEncodingRule : IEncodingRule
    {
        #region Properties
        /// <summary>
        /// Get the versions the rule applies to.
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with versions.</returns>
        string[] GetVersions();

        /// <summary>
        /// Get the encodings the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with encodings.</returns>
        string[] GetEncodings();
        #endregion
    }
}
