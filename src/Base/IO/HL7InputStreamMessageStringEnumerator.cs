using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NHapiTools.Base.IO
{
    /// <summary>
    /// Reads from an InputStream containing a stream of encoded HL7 messages and iterates over those messages. This class is geared towards reading from files, 
    /// and tries to be very lenient about the format of the stream, specifically concerning control characters and line endings. 
    /// It should be safe to provide a stream containing Windows or Unix line endings (which will be treated as segment delimiters). 
    /// It is also safe to provide a stream containing MLLP control blocks before and after each message (although these will not be validated! 
    /// Do not use this class to read MLLP messages from a socket stream!)
    /// 
    /// This is a port of the Hl7InputStreamMessageStringIterator from the HAPI project.
    /// </summary>
    public class HL7InputStreamMessageStringEnumerator : IEnumerator<string>
    {
        #region Private properties
        private Stream inputStream;
        private bool myIgnoreComments;
        private bool myHasNext;
        private string myNext;
        private StringBuilder myBuffer;
        private bool myFoundMessageInBuffer = false;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inStream">Input stream to read from.</param>
        public HL7InputStreamMessageStringEnumerator(Stream inStream)
        {
            inputStream = inStream;
            myBuffer = new StringBuilder();
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Get the current message.
        /// </summary>
        public string Current
        {
            get
            {
                string result = myNext;
                myNext = null;

                return result;
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
                return myIgnoreComments;
            }
            set
            {
                myIgnoreComments = value;
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            inputStream.Dispose();
        }

        /// <summary>
        /// Move to the next item.
        /// </summary>
        /// <returns>True if next item available.</returns>
        public bool MoveNext()
        {
            if (myNext == null)
            {
                int next;
                int prev = -1;
                int endOfBuffer = -1;
                bool inComment = false;

                while (true)
                {
                    try
                    {
                        next = inputStream.ReadByte();
                    }
                    catch (IOException e)
                    {
                        throw new Exception("IOException reading from input", e);
                    }

                    if (next == -1)
                    {
                        break;
                    }

                    char nextChar = (char)next;
                    if (nextChar == '#' && myIgnoreComments && (prev == -1 || prev == '\n' || prev == '\r'))
                    {
                        inComment = true;
                        continue;
                    }

                    // Convert '\n' or "\r\n" to '\r'
                    if (nextChar == 10)
                    {
                        if (myBuffer.Length > 0)
                        {
                            if (myBuffer[myBuffer.Length - 1] == 13)
                            {
                                // don't append
                            }
                            else
                            {
                                myBuffer.Append((char)13);
                            }
                        }
                    }
                    else if (inComment)
                    {
                        if (nextChar == 10 || nextChar == 13)
                        {
                            inComment = false;
                        }
                    }
                    else
                    {
                        myBuffer.Append(nextChar);
                    }

                    prev = next;

                    int bLength = myBuffer.Length;
                    if (nextChar == 'H' && bLength >= 3)
                    {
                        if (myBuffer[bLength - 2] == 'S')
                        {
                            if (myBuffer[bLength - 3] == 'M')
                            {
                                if (myFoundMessageInBuffer)
                                {
                                    if (myBuffer[bLength - 4] < 32)
                                    {
                                        endOfBuffer = bLength - 3;
                                        break;
                                    }
                                }
                                else
                                {
                                    // Delete any whitespace or other stuff before
                                    // the first message
                                    myBuffer.Remove(0, bLength - 3);
                                    myFoundMessageInBuffer = true;
                                }
                            }
                        }
                    }

                } // while(true)

                if (!myFoundMessageInBuffer)
                {
                    myHasNext = false;
                    return myHasNext;
                }

                String msgString;
                if (endOfBuffer > -1)
                {
                    msgString = myBuffer.ToString().Substring(0, endOfBuffer);
                    myBuffer.Remove(0, endOfBuffer);
                }
                else
                {
                    msgString = myBuffer.ToString();
                    myBuffer.Clear();
                }

                if (!msgString.StartsWith("MSH"))
                {
                    myHasNext = false;
                    return myHasNext;
                }

                myNext = msgString;
                myHasNext = true;
            }

            return myHasNext;
        }

        /// <summary>
        /// Reset
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
