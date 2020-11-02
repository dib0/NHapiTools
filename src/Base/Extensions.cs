using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapiTools.Base.Util;
using NHapi.Base.Util;

namespace NHapiTools.Base
{
    /// <summary>
    /// Provides multiple extension methods on the NHapi Base classes.
    /// </summary>
    public static class Extensions
    {
        #region Extention methods
        /// <summary>
        /// Get an array of objects from the HL7 message following the NHapi generated structure xxyyRepetitionsUsed and Getxxyy(int rep).
        /// Use with caution: only use when these properties are available.
        /// </summary>
        /// <param name="container">Containter object (inherited from IMessage, ISegment of IGroup</param>
        /// <param name="property">Name of the property. E.g. xxyyRepetitionsUsed</param>
        /// <param name="method">Name of the Get method. E.g. Getxxyy</param>
        /// <returns>Array of objects. Null if none existed.</returns>
        public static object[] GetRecords(this object container, string property, string method)
        {
            object[] result = null;

            Type type = container.GetType();
            PropertyInfo pi = type.GetProperty(property);
            MethodInfo mi = type.GetMethod(method, new Type[] { typeof(int) });

            if ((pi != null) && (mi != null))
            {
                int repUsed = (int)pi.GetValue(container, null);

                if (repUsed > 0)
                {
                    result = new object[repUsed];

                    for (int i = 0; i < repUsed; i++)
                    {
                        result[i] = mi.Invoke(container, new object[] { i });
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Get a generic list from the HL7 message following the NHapi generated structure xxyyRepetitionsUsed and Getxxyy(int rep).
        /// Use with caution: only use when these properties are available.
        /// </summary>
        /// <typeparam name="T">Type of objects that are returned.</typeparam>
        /// <param name="container">Containter object (inherited from IMessage, ISegment of IGroup</param>
        /// <param name="property">Name of the property. E.g. xxyyRepetitionsUsed</param>
        /// <param name="method">Name of the Get method. E.g. Getxxyy</param>
        /// <returns>Generic list with results</returns>
        public static List<T> GetAllRecords<T>(this object container, string property, string method)
        {
            object[] list = GetRecords(container, property, method);

            List<T> result = new List<T>();
            if (list != null)
            {
                foreach (object o in list)
                    result.Add((T)o);
            }

            return result;
        }

        /// <summary>
        /// Check if a segment existed in the original message.
        /// </summary>
        /// <param name="parser">Parser base class</param>
        /// <param name="message">Message to be checked</param>
        /// <param name="segment">Segment name to check</param>
        /// <returns>True if segment was found in the original message</returns>
        public static bool SegmentExists(this PipeParser parser, IMessage message, string segment)
        {
            // Parse the message to a string and test for the segment name
            return parser.Encode(message).Contains(segment + "|");
        }

        /// <summary>
        /// Generate an Ack message based on current message.
        /// </summary>
        /// <param name="message">Current message object</param>
        /// <param name="ackType">Ack response type</param>
        /// <param name="appCommName">Application communication name</param>
        /// <param name="envName">Environment name</param>
        /// <returns>Ack message based on the current message</returns>
        public static IMessage GenerateAck(this IMessage message, AckTypes ackType, string appCommName, string envName)
        {
            return GenerateAck(message, ackType, appCommName, envName, null);
        }

        /// <summary>
        /// Generate an Ack message based on current message.
        /// </summary>
        /// <param name="message">Current message object</param>
        /// <param name="ackType">Ack response type</param>
        /// <param name="appCommName">Application communication name</param>
        /// <param name="envName">Environment name</param>
        /// <param name="errorMessage">Error message to include in Ack (in case op AE or AR)</param>
        /// <returns>Ack message based on the current message</returns>
        public static IMessage GenerateAck(this IMessage message, AckTypes ackType, string appCommName, string envName, string errorMessage)
        {
            Ack ack = new Ack(appCommName, envName);
            return ack.MakeACK(message, ackType, errorMessage);
        }

        /// <summary>
        /// Adds a method to check equality between to segment objects
        /// </summary>
        /// <param name="a">First segment</param>
        /// <param name="b">Second segment</param>
        /// <returns>True if the segments are equal</returns>
        public static bool IsEqual(this ISegment a, ISegment b)
        {
            bool result = true;

            string structName = a.GetStructureName();
            if (structName != b.GetStructureName())
                result = false;
            else
            {
                PipeParser p = new PipeParser();
                string aMessage = p.Encode(a.Message);
                string bMessage = p.Encode(b.Message);

                int aIndex = aMessage.IndexOf(structName);
                int bIndex = bMessage.IndexOf(structName);

                if (aIndex == -1 || bIndex == -1)
                    result = false;

                if (result)
                {
                    string aStruct = aMessage.Substring(aIndex, aMessage.IndexOf("\r", aIndex) - aIndex);
                    string bStruct = bMessage.Substring(bIndex, bMessage.IndexOf("\r", bIndex) - bIndex);

                    result = (string.Compare(aStruct, bStruct) == 0);
                }
            }
               
            return result;
        }

        /// <summary>
        /// Adds a method to check equality between to message objects
        /// </summary>
        /// <param name="a">First message</param>
        /// <param name="b">Second message</param>
        /// <returns>True if the messages are equal</returns>
        public static bool IsEqual(this IMessage a, IMessage b)
        {
            return a.IsEqual(b, false);
        }

        /// <summary>
        /// Adds a method to check equality between to message objects
        /// </summary>
        /// <param name="a">First message</param>
        /// <param name="b">Second message</param>
        /// <param name="completeCompare">Besides checking the structure name, version, event type and message ID, if this is true the complete textual version of the two messages will be compared.</param>
        /// <returns>True if the messages are equal</returns>
        public static bool IsEqual(this IMessage a, IMessage b, bool completeCompare)
        {
            bool result = true;

            if (a.GetStructureName() != b.GetStructureName())
                result = false;

            if (result && (a.Version != b.Version))
                result = false;

            if (result)
            {
                Terser terserA = new Terser(a);
                Terser terserB = new Terser(b);

                string eventTypeA = terserA.Get("MSH-9-2");
                string eventTypeB = terserB.Get("MSH-9-2");
                result = (eventTypeA == eventTypeB);

                if (result)
                {
                    string messageIdA = terserA.Get("MSH-10-1");
                    string messageIdB = terserB.Get("MSH-10-1");
                    result = (messageIdA == messageIdB);
                }
            }

            if (result && completeCompare)
            {
                PipeParser p = new PipeParser();
                string msgA = p.Encode(a);
                string msgB = p.Encode(b);

                result = (string.Compare(msgA, msgB) == 0);
            }

            return result;
        }
        #endregion
    }
}
