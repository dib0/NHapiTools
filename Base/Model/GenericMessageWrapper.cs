using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base.Util;
using NHapiTools.Base.Parser;

namespace NHapiTools.Base.Model
{
    /// <summary>
    /// Generic Abstract message implementation. This implementation is similar to the Generic+V2x implementation
    /// of NHapi with two differences:
    /// 1. This Generic message is version indifferent.
    /// 2. This Generic message wraps the original message.
    /// 
    /// This Generic message wrapper is used to be able to overwrite (default) segments, that will otherwise not be possible 
    /// using NHapi. By wrapping the message and copying the content segments can be overwritten.
    /// 
    /// This Message wrapper is to be used with the EnhancedModelClassFactory.
    /// </summary>
    public class GenericMessageWrapper : AbstractMessage
    {
        #region Private properties
        private IMessage wrappedMessage;
        private Type wrappedMessageType;
        #endregion

        /// <summary>
        /// Get the HL7 version of the message
        /// </summary>
        #region Public properties
        public override string Version
        {
            get
            {
                return wrappedMessage.Version;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="factory">Model Class Factory</param>
        public GenericMessageWrapper(IModelClassFactory factory)
            : base(factory)
        {
            this.init(factory);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public GenericMessageWrapper()
            : base((IModelClassFactory) new DefaultModelClassFactory())
        {
            this.init((IModelClassFactory) new DefaultModelClassFactory());
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Unwraps the originally parsed message and tries to copy any information
        /// to it.
        /// </summary>
        /// <returns>Unwrapped message</returns>
        public IMessage Unwrap()
        {
            return wrappedMessage;
        }

        /// <summary>
        /// Get a specific segment from the message. If any segment was overwritten and could not fully be
        /// copied to the wrapped message, it can be retreived using this method.
        /// </summary>
        /// <typeparam name="T">Segment type.</typeparam>
        /// <param name="segmentName">Segment name to retreive.</param>
        /// <returns></returns>
        public T GetSegment<T>(string segmentName) where T: class, ISegment
        {
            T result = GetStructure(segmentName) as T;
            return result;
        }
        #endregion

        #region Private methods
        private void init(IModelClassFactory factory)
        {
            EnhancedModelClassFactory fact = factory as EnhancedModelClassFactory;
            if (fact == null)
                throw new ArgumentNullException("The GenericMessageWrapper only works with the EnhancedModelClassFactory");

            wrappedMessage = InstantiateMessage(fact);
            this.addNonstandardSegment("MSH");
        }

        private IMessage InstantiateMessage(EnhancedModelClassFactory factory)
        {
            wrappedMessageType = factory.GetSpecificMessageClass();
            IMessage message = (IMessage)wrappedMessageType.GetConstructor(new Type[1] { typeof(IModelClassFactory) }).Invoke(new object[1] { (object)factory });

            message.ValidationContext = factory.ValidationContext;
            return message;
        }
        #endregion
    }
}
