using NHapiTools.Base.Validation;

namespace NHapiTools.Tests.CustomRules
{
    /// <inheritdoc />
    public class PrimitiveRule1 : ISpecificPrimitiveTypeRule
    {
        public string[] GetVersions()
        {
            return new string[] { "2.4" };
        }

        public string[] GetTypeNames()
        {
            return new string[] { "ST" };
        }

        /// <summary>
        /// Optionally performs an automatic correction on given data to make it
        /// conform (eg trims leading whitespace). This is to be called prior to
        /// test(). If no corrections are performed, the original value is returned.
        /// </summary>
        /// <param name="originalValue">An original value to be corrected.</param>
        /// <returns>A corrected version of the given value.</returns>
        public string correct(string originalValue)
        {
            return Correct(originalValue);
        }

        /// <summary>
        /// Optionally performs an automatic correction on given data to make it
        /// conform (eg trims leading whitespace). This is to be called prior to
        /// test(). If no corrections are performed, the original value is returned.
        /// </summary>
        /// <param name="originalValue">An original value to be corrected.</param>
        /// <returns>A corrected version of the given value.</returns>
        public string Correct(string originalValue)
        {
            return originalValue;
        }

        /// <summary>
        /// Tests the given string against the criteria defined by this
        /// rule -- returns true if it passes the test, false otherwise.
        /// </summary>
        public bool test(string testValu)
        {
            return Test(testValu);
        }

        /// <summary>
        /// Tests the given string against the criteria defined by this
        /// rule -- returns true if it passes the test, false otherwise.
        /// </summary>
        public bool Test(string testValu)
        {
            return true;
        }

        public string Description
        {
            get { return string.Empty; }
        }

        public string SectionReference
        {
            get { return string.Empty; }
        }
    }
}
