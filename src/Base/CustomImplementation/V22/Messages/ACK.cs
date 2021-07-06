// Type: NHapi.Model.V23.Message.ACK
// Assembly: NHapi.Model.V23, Version=2.4.0.0, Culture=neutral, PublicKeyToken=d0d8ea960a3440eb
// MVID: C7C4DA77-585C-442A-A512-1978F0E9C9C6
// Assembly location: C:\Source\NHapiTools\References\NHapi.Model.V23.dll

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V22.Segment;
using System;

namespace NHapiTools.Base.CustomImplementation.V22.Messages
{
    /// <summary>
    /// Represents a ACK message structure (see chapter ). This structure contains the
    ///              following elements:
    ///             <ol><li>0: MSH (Message header segment) </li><li>1: MSA (Message acknowledgement segment) </li><li>2: ERR (Error segment) optional </li></ol>
    /// </summary>
    [Serializable]
    public class ACK : AbstractMessage
    {
        /// <summary>
        /// Version
        /// </summary>
        public override string Version
        {
            get
            {
                return "2.2";
            }
        }

        /// <summary>
        /// Returns MSH (Message header segment) - creates it if necessary
        /// 
        /// </summary>
        public MSH MSH
        {
            get
            {
                try
                {
                    return (MSH)this.GetStructure("MSH");
                }
                catch (HL7Exception ex)
                {
                    HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected error accessing data - this is probably a bug in the source code generator.", (Exception)ex);
                    throw new Exception("An unexpected error ocurred", (Exception)ex);
                }
            }
        }

        /// <summary>
        /// Returns MSA (Message acknowledgement segment) - creates it if necessary
        /// 
        /// </summary>
        public MSA MSA
        {
            get
            {
                try
                {
                    return (MSA)this.GetStructure("MSA");
                }
                catch (HL7Exception ex)
                {
                    HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected error accessing data - this is probably a bug in the source code generator.", (Exception)ex);
                    throw new Exception("An unexpected error ocurred", (Exception)ex);
                }
            }
        }

        /// <summary>
        /// Returns ERR (Error segment) - creates it if necessary
        /// 
        /// </summary>
        public ERR ERR
        {
            get
            {
                try
                {
                    return (ERR)this.GetStructure("ERR");
                }
                catch (HL7Exception ex)
                {
                    HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected error accessing data - this is probably a bug in the source code generator.", (Exception)ex);
                    throw new Exception("An unexpected error ocurred", (Exception)ex);
                }
            }
        }

        /// <summary>
        /// Creates a new ACK Group with custom IModelClassFactory.
        /// 
        /// </summary>
        public ACK(IModelClassFactory factory)
            : base(factory)
        {
            this.init(factory);
        }

        /// <summary>
        /// Creates a new ACK Group with DefaultModelClassFactory.
        /// 
        /// </summary>
        public ACK()
            : base((IModelClassFactory)new DefaultModelClassFactory())
        {
            this.init((IModelClassFactory)new DefaultModelClassFactory());
        }

        /// <summary>
        /// initalize method for ACK.  This does the segment setup for the message.
        /// 
        /// </summary>
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.Add(typeof(MSH), true, false);
                this.Add(typeof(MSA), true, false);
                this.Add(typeof(ERR), false, false);
            }
            catch (HL7Exception ex)
            {
                HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected error creating ACK - this is probably a bug in the source code generator.", (Exception)ex);
            }
        }
    }
}
