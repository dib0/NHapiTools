using System.Collections.Generic;
using System.IO;

namespace NHapiTools.Base.IO
{
    /// <summary>
    /// This stream filters out Base64 encoded data from HL7 messages that are being read over a stream
    /// The Base64 data is stored in separate memory streams. The data in the message is replaced by the Id
    /// which can be used to get the right memory stream.
    /// </summary>
    public class HL7FilterBase64AttachmentsStream : Stream
    {
        #region Public properties
        /// <summary>
        /// Attachments
        /// </summary>
        public Dictionary<string, MemoryStream> Attachments;

        /// <summary>
        /// Has attachments
        /// </summary>
        public bool HasAttachments
        {
            get
            {
                return Attachments.Count > 0;
            }
        }
        #endregion

        #region Private properties
        private Stream baseStream;
        private int base64Check;
        private const string stringToCheck = "Base64^";
        private bool filterAttachment;
        private int attachmentCount;
        private string currentId;
        private MemoryStream currentAttachment;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="encapsulatedStream">Stream to encapsulate</param>
        public HL7FilterBase64AttachmentsStream(Stream encapsulatedStream)
        {
            baseStream = encapsulatedStream;
            Attachments = new Dictionary<string, MemoryStream>();
        }
        #endregion

        #region Stream implementation
        /// <summary>
        /// Flushes the stream
        /// </summary>
        public override void Flush()
        {
            baseStream.Flush();
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            throw new System.InvalidOperationException("Stream is not seekable.");
        }

        /// <summary>
        /// Set the length of the stream.
        /// </summary>
        /// <param name="value">Length</param>
        public override void SetLength(long value)
        {
            baseStream.SetLength(value);
        }

        /// <summary>
        /// Read the next byte(s) from the stream.
        /// </summary>
        /// <param name="buffer">Buffer to put the result in.</param>
        /// <param name="offset">Location to start reading.</param>
        /// <param name="count">Amount of bytes to read from the stream.</param>
        /// <returns></returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            byte[] subBuffer = new byte[buffer.Length];
            int subResult = baseStream.Read(subBuffer, offset, count);
            int result = 0;

            for (int i = 0; i < subResult; i++)
            {
                // Check if the data contains the text 'Base64^'
                if (!filterAttachment)
                {
                    if (subBuffer[i] == stringToCheck[base64Check])
                        base64Check++;
                    else
                        base64Check = 0;

                    if (base64Check == stringToCheck.Length)
                    {
                        filterAttachment = true;
                        attachmentCount += 1;
                        base64Check = 0;

                        // Start a new filter
                        currentAttachment = new MemoryStream();
                        // Add it, with the current ID to the attachmentlist
                        currentId = string.Format("(attachment_{0})", attachmentCount);
                        Attachments.Add(currentId, currentAttachment);
                    }

                    buffer[result] = subBuffer[i];
                    result++;
                }
                else
                {
                    // Add the characters to the attachement stream
                    if (subBuffer[i] != '|' && subBuffer[i] != '\r' && subBuffer[i] != '\n' && subBuffer[i] != '^' && subBuffer[i] != '~' && subBuffer[i] != '&')
                    {
                        currentAttachment.WriteByte(subBuffer[i]);

                        if (currentId.Length > 0)
                        {
                            buffer[result] = (byte) currentId[0];
                            currentId = currentId.Remove(0, 1);
                            result++;
                        }
                    }
                    else
                    {
                        // Close the current attachment
                        filterAttachment = false;

                        buffer[result] = subBuffer[i];
                        result += 1;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Get the length of the stream.
        /// </summary>
        public override long Length
        {
            get
            {
                return baseStream.Length;
            }
        }

        /// <summary>
        /// Get current posistion in the stream.
        /// </summary>
        public override long Position
        {
            get { return baseStream.Position; }
            set { baseStream.Position = value; }
        }

        /// <summary>
        /// Writing the stream is not implemented.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new System.InvalidOperationException("Stream is not writable");
        }

        /// <summary>
        /// Is the stream readable?
        /// </summary>
        public override bool CanRead
        {
            get { return baseStream.CanRead; }
        }

        /// <summary>
        /// Is the stream searchable?
        /// </summary>
        public override bool CanSeek
        {
            get { return false; }
        }

        /// <summary>
        /// Is the stream writeable?
        /// </summary>
        public override bool CanWrite
        {
            get { return false; }
        }

        /// <summary>
        /// Read to the end of the stream
        /// </summary>
        /// <returns></returns>
        public string ReadToEnd()
        {
            StreamReader sr = new StreamReader(this);
            return sr.ReadToEnd();
        }
        #endregion
    }
}
