using System.Text;

namespace NHapiTools.Base.Util
{
    /// <summary>
    /// This helper class supports the Minimum Low Layer Protocol
    /// </summary>
    public abstract class MLLP
    {
        #region Private constants
        private const int MLLP_START_CHARACTER = 11; // HEX 0B
        private const int MLLP_FIRST_END_CHARACTER = 28; // HEX 1C
        private const int MLLP_LAST_END_CHARACTER = 13; // HEX 0D
        #endregion

        #region Public static methods
        /// <summary>
        /// Validate MLLP message
        /// </summary>
        /// <param name="sb">Stringbuilder containing the message</param>
        public static void StripMLLPContainer(StringBuilder sb)
        {
            // Strip the message of the MLLP container characters
            sb.Remove(0, 1);
            sb.Remove(sb.Length - 2, 2);
        }

        /// <summary>
        /// Validate the MLLP message containing the HL7 message
        /// </summary>
        /// <param name="sb">Message</param>
        /// <returns>true if valid</returns>
        public static bool ValidateMLLPMessage(StringBuilder sb)
        {
            bool result = false;

            if (sb.Length > 3)
            {
                if (((int)sb[0] == MLLP_START_CHARACTER))
                {
                    if (((int)sb[sb.Length - 2] == MLLP_FIRST_END_CHARACTER) && ((int)sb[sb.Length - 1] == MLLP_LAST_END_CHARACTER))
                        result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Create a MLLP message
        /// </summary>
        /// <param name="p">Original message</param>
        /// <returns>MLLP message</returns>
        public static string CreateMLLPMessage(string p)
        {
            StringBuilder sb = new StringBuilder(p);
            sb.Insert(0, (char)MLLP_START_CHARACTER);
            sb.Append((char)MLLP_FIRST_END_CHARACTER);
            sb.Append((char)MLLP_LAST_END_CHARACTER);

            return sb.ToString();
        }

        /// <summary>
        /// Test if the character equals the start message character
        /// </summary>
        /// <param name="start">Character to test</param>
        /// <returns>True if matches</returns>
        public static bool IsStartCharacter(char start)
        {
            return (start == MLLP_START_CHARACTER);
        }
        #endregion
    }
}
