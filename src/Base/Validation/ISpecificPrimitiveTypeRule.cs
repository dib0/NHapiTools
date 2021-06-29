using NHapi.Base.Validation;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// This provides a more specific interface thant the original IPrimitiveTypeRule. Implementations
    /// of this interface are to be used with the AutomatedContext or ConfigurableContext
    /// </summary>
    public interface ISpecificPrimitiveTypeRule : IPrimitiveTypeRule
    {
        #region Properties
        /// <summary>
        /// Get the versions the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with versions.</returns>
        string[] GetVersions();

        /// <summary>
        /// Get the types the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with types.</returns>
        string[] GetTypeNames();
        #endregion
    }
}
