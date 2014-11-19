using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NHapi.Base;
using NHapi.Base.Model;
using NHapi.Base.Parser;

namespace NHapiTools.Base.IO
{
    /// <summary>
    ///  Reads from an InputStream containing a stream of encoded HL7 messages and iterates over those messages. This class is geared towards reading from files,
    ///  and tries to be very lenient about the format of the stream, specifically concerning control characters and line endings. 
    ///  It should be safe to provide a stream containing Windows or Unix line endings (which will be treated as segment delimiters). It is also safe to 
    ///  provide a stream containing MLLP control blocks before and after each message (although these will not be validated! 
    ///  Do not use this class to read MLLP messages from a socket stream!)
    ///  The input stream could, for example, be a FileInputStream reading from a text file containing a number of HL7 messages in plain text format. 
    /// 
    ///  This is a port of the Hl7InputStreamMessageIterator from the HAPI project.
    /// </summary>
    public class HL7InputStreamMessageEnumerator : IEnumerator<IMessage>
    {
        #region Private properties
        private HL7InputStreamMessageStringEnumerator enumerator;
        private PipeParser parser;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inStream">Input stream to read from.</param>
        public HL7InputStreamMessageEnumerator(Stream inStream)
        {
            enumerator = new HL7InputStreamMessageStringEnumerator(inStream);
            parser = new PipeParser();
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Get the current message.
        /// </summary>
        public IMessage Current
        {
            get
            {
                return parser.Parse(enumerator.Current);
            }
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        /// <summary>
        /// Ignore reading comments in the messages
        /// </summary>
        public bool IgnoreComments
        {
            get
            {
                return enumerator.IgnoreComments;
            }
            set
            {
                enumerator.IgnoreComments = value;
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            enumerator.Dispose();
        }

        /// <summary>
        /// Move to the next item.
        /// </summary>
        /// <returns>True if next item available.</returns>
        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }

        /// <summary>
        /// Reset
        /// </summary>
        public void Reset()
        {
            enumerator.Reset();
        }
        #endregion
    }
}
