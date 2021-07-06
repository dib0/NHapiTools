using NHapi.Base.Validation;

namespace NHapiTools.Base.Validation
{
    /// <summary>
    /// This provides a more specific interface thant the original IMessageRule. Implementations
    /// of this interface are to be used with the AutomatedContext or ConfigurableContext
    /// </summary>
    public interface ISpecificMessageRule : IMessageRule
    {
        #region Properties
        /// <summary>
        /// Get the versions the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with versions</returns>
        string[] GetVersions();

        /// <summary>
        /// Get the message type the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with message types</returns>
        string[] GetMessageTypes();

        /// <summary>
        /// Get the trigger events the rule applies to
        /// Use the wildcard '*' to apply to all versions (use with care)
        /// </summary>
        /// <returns>List with trigger events.</returns>
        string[] GetTriggerEvents();
        #endregion
    }
}
