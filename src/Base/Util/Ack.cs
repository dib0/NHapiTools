using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Base.Util;

namespace NHapiTools.Base.Util
{
    /// <summary>
    /// Acknowledgemend types
    /// </summary>
    public enum AckTypes
    {
        /// <summary>
        /// Application Accept. Send if message processing was fine.
        /// </summary>
        AA,
        /// <summary>
        /// Application Error. Send if an error occured while processing.
        /// </summary>
        AE,
        /// <summary>
        /// // Application Reject. Send if the application does not support of accepts the messages.
        /// </summary>
        AR  
    }

    /// <summary>
    /// Provides an easy interface to generate Ack messages based on incoming messages
    /// </summary>
    public class Ack
    {
        #region Private properties
        private string appCommunicationName;
        private string environmentIdentifier;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationCommunicationName">Communication name of the software.</param>
        /// <param name="envIdentifier">Environment identifier.</param>
        public Ack(string applicationCommunicationName, string envIdentifier)
        {
            appCommunicationName = applicationCommunicationName;
            environmentIdentifier = envIdentifier;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Create an Ack message based on a received message
        /// </summary>
        /// <param name="inboundMessage">received message</param>
        /// <returns>Created ACK message</returns>
        public IMessage MakeACK(IMessage inboundMessage)
        {
            return MakeACK(inboundMessage, AckTypes.AA, null);
        }

        /// <summary>
        /// Create an Ack message based on a received message
        /// </summary>
        /// <param name="inboundMessage">received message</param>
        /// <param name="ackResult">Send AA, AE or AR message.</param>
        /// <param name="errorMessage">The reason the message was rejected or an error. If "AA" was supplied as ackCode the errorMessage should be null.</param>
        /// <returns>Created ACK message</returns>
        public IMessage MakeACK(IMessage inboundMessage, AckTypes ackResult, string errorMessage)
        {
            //this should avoid an unhandled null reference exception in "inboundMessage.Version", because people tend to send the inboudMessage without a check
            if (inboundMessage == null)
                throw new ArgumentNullException("Either process the valid message while retreiving the ack or handle invalid message differently");
                
            IMessage ackMessage = null;
            // Get an object from the right ACK class
            string ackClassType = string.Format("NHapi.Model.V{0}.Message.ACK, NHapi.Model.V{0}", inboundMessage.Version.Replace(".", ""));
            Type x = Type.GetType(ackClassType);
            if (x != null)
                ackMessage = (IMessage)Activator.CreateInstance(x);
            else
            {
                // Fix for V2.2 and V2.1 Since tha ACK message class is missing there in NHapi
                if (inboundMessage.Version == "2.1")
                    ackMessage = (IMessage)new NHapiTools.Base.CustomImplementation.V21.Messages.ACK();
                if (inboundMessage.Version == "2.2")
                    ackMessage = (IMessage)new NHapiTools.Base.CustomImplementation.V22.Messages.ACK();
            }

            Terser inboundTerser = new Terser(inboundMessage);
            ISegment inboundHeader = null;
            inboundHeader = inboundTerser.getSegment("MSH");

            // Find the HL7 version of the inbound message:
            string version = null;
            try
            {
                version = Terser.Get(inboundHeader, 12, 0, 1, 1);
            }
            catch (NHapi.Base.HL7Exception)
            {
                // I'm not happy to proceed if we can't identify the inbound
                // message version.
                throw new NHapi.Base.HL7Exception("Failed to get valid HL7 version from inbound MSH-12-1");
            }

            // Create a Terser instance for the outbound message (the ACK).
            Terser terser = new Terser(ackMessage);

            // Populate outbound MSH fields using data from inbound message
            ISegment outHeader = (ISegment)terser.getSegment("MSH");
            DeepCopy.copy(inboundHeader, outHeader);

            // Now set the message type, HL7 version number, acknowledgement code
            // and message control ID fields:
            string sendingApp = terser.Get("/MSH-3");
            string sendingEnv = terser.Get("/MSH-4");
            terser.Set("/MSH-3", appCommunicationName);
            terser.Set("/MSH-4", environmentIdentifier);
            terser.Set("/MSH-5", sendingApp);
            terser.Set("/MSH-6", sendingEnv);
            terser.Set("/MSH-7", DateTime.Now.ToString("yyyyMMddHHmm"));
            terser.Set("/MSH-9", "ACK");
            terser.Set("/MSH-12", version);
            terser.Set("/MSA-1", Enum.GetName(typeof(AckTypes), ackResult));
            terser.Set("/MSA-2", Terser.Get(inboundHeader, 10, 0, 1, 1));

            // Set error message
            if (errorMessage != null)
                terser.Set("/ERR-1-1", errorMessage);

            return ackMessage;
        }
        #endregion
    }
}
