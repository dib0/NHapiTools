using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHapiTools.Base.IO
{
    /// <summary>
    /// Event args for file completed event
    /// </summary>
    public class FileCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Name of the file
        /// </summary>
        public string FileName;
    }

    /// <summary>
    /// Stream class for reading multiple files from a directory as one stream.
    /// Especially handy when using the HL7InputStreamMessageIterator on a complete directory with messages.
    /// </summary>
    public class MultipleFilesStream : Stream
    {
        #region Private properties
        private List<FileStream> fileStreams;
        private FileStream currentStream;
        private int currentStreamIndex;
        private long length=-1;
        private long position;
        private bool endReached;
        #endregion

        #region Public properties
        /// <summary>
        /// Gets / sets the character used for
        /// marking the end of a file.
        /// </summary>
        public char? FileEndMarker
        {
	        get; set;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="streams">List of streams to read from</param>
        public MultipleFilesStream(List<FileStream> streams)
        {
            Init(streams);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="files">List of files to read as one stream.</param>
        public MultipleFilesStream(List<string> files)
        {
            Init(files.Select(file => File.Open(file, FileMode.Open, FileAccess.Read, FileShare.Read)).ToList());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="directory">Directory containing files to read as one stream.</param>
        public MultipleFilesStream(DirectoryInfo directory) : this(directory, "*.*")
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="directory">Directory containing files to read as one stream.</param>
        /// <param name="searchPattern">Searchpattern / filter for filenames.</param>
        public MultipleFilesStream(DirectoryInfo directory, string searchPattern)
        {
            FileInfo[] files = directory.GetFiles(searchPattern);
            Init(files.Select(file => file.Open(FileMode.Open, FileAccess.Read, FileShare.Read)).ToList());
        }
        #endregion

        #region Private methods
        private void Init(List<FileStream> streams)
        {
            if (streams == null || streams.Count == 0)
                throw new ArgumentNullException("No streams provided.");

            fileStreams = streams;
            currentStreamIndex = 0;
            currentStream = fileStreams[currentStreamIndex];
        }
        #endregion

        #region Stream implementation
        /// <summary>
        /// Flushes the stream
        /// </summary>
        public override void Flush()
        {
            if (currentStream != null)
                currentStream.Flush();
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
            this.length = value;
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
            if (endReached)
            {
                for (int i = offset; i < offset + count; i++)
                    buffer[i] = 0;

                return 0;
            }

            int result = 0;
            int buffPostion = offset;

            while (count > 0)
            {
                int bytesRead = currentStream.Read(buffer, buffPostion, count);
                result += bytesRead;
                buffPostion += bytesRead;
                position += bytesRead;

                if (bytesRead <= count)
                {
                    count -= bytesRead;
                }

                if (count > 0)
                {
                    // Add End marker
                    if (FileEndMarker != null)
                    {
                        buffer[buffPostion] = (byte) FileEndMarker;
                        buffPostion++;
	                    count--;
	                    result++;
                    }

                    if (currentStreamIndex >= fileStreams.Count - 1)
                    {
                        fileStreams[currentStreamIndex].Close();
                        RaiseCompletedEvent(fileStreams[currentStreamIndex].Name);
                        fileStreams[currentStreamIndex] = null;

                        endReached = true;
                        break;
                    }

                    fileStreams[currentStreamIndex].Close();
                    currentStream = fileStreams[++currentStreamIndex];
                    RaiseCompletedEvent(fileStreams[currentStreamIndex - 1].Name);
                    fileStreams[currentStreamIndex - 1] = null;
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
                if (length == -1)
                {
                    length = 0;
                    foreach (var stream in fileStreams)
                    {
                        length += stream.Length;
                    }
                }

                return length;
            }
        }

        /// <summary>
        /// Get current posistion in the stream.
        /// </summary>
        public override long Position
        {
            get { return this.position; }
            set { throw new System.NotImplementedException(); }
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
            get { return true; }
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
        #endregion

        #region Private methods
        private void RaiseCompletedEvent(string path)
        {
            FileCompletedEventArgs args = new FileCompletedEventArgs();
            args.FileName = path;

            OnFileCompleted(args);
        }
        #endregion

        #region CompletedEvent
        /// <summary>
        /// Event will be raised when a file is done reading.
        /// The event args will contain the filename.
        /// </summary>
        /// <param name="e">Event args</param>
        protected virtual void OnFileCompleted(FileCompletedEventArgs e)
        {
            EventHandler<FileCompletedEventArgs> handler = FileCompleted;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Event on file end reached
        /// </summary>
        public event EventHandler<FileCompletedEventArgs> FileCompleted;
        #endregion
    }
}
