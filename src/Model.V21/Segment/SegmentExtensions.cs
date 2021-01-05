using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V21.Group;
using NHapi.Model.V21.Message;
using NHapi.Model.V21.Segment;
using NHapi.Model.V21.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V21.Segment
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class SegmentExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get ERRORCODEANDLOCATION Records from ERR
        /// </summary>
        public static IEnumerable GetERRORCODEANDLOCATIONRecords(this ERR message)
        {
            object[] result = message.GetRecords("ERRORCODEANDLOCATIONRepetitionsUsed", "GetERRORCODEANDLOCATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERRORCODEANDLOCATION Records from ERR
        /// </summary>
        public static List<ID> GetAllERRORCODEANDLOCATIONRecords(this ERR message)
        {
            return message.GetAllRecords<ID>("ERRORCODEANDLOCATIONRepetitionsUsed", "GetERRORCODEANDLOCATION");
        }

        /// <summary>
        /// Add a new ERRORCODEANDLOCATION to ERR
        /// </summary>
        public static ID AddERRORCODEANDLOCATION(this ERR message)
        {
            return message.GetERRORCODEANDLOCATION(message.ERRORCODEANDLOCATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NEXTOFKINPHONENUMBER Records from NK1
        /// </summary>
        public static IEnumerable GetNEXTOFKINPHONENUMBERRecords(this NK1 message)
        {
            object[] result = message.GetRecords("NEXTOFKINPHONENUMBERRepetitionsUsed", "GetNEXTOFKINPHONENUMBER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NEXTOFKINPHONENUMBER Records from NK1
        /// </summary>
        public static List<TN> GetAllNEXTOFKINPHONENUMBERRecords(this NK1 message)
        {
            return message.GetAllRecords<TN>("NEXTOFKINPHONENUMBERRepetitionsUsed", "GetNEXTOFKINPHONENUMBER");
        }

        /// <summary>
        /// Add a new NEXTOFKINPHONENUMBER to NK1
        /// </summary>
        public static TN AddNEXTOFKINPHONENUMBER(this NK1 message)
        {
            return message.GetNEXTOFKINPHONENUMBER(message.NEXTOFKINPHONENUMBERRepetitionsUsed);
        }

        /// <summary>
        /// Get COMMENT Records from NTE
        /// </summary>
        public static IEnumerable GetCOMMENTRecords(this NTE message)
        {
            object[] result = message.GetRecords("COMMENTRepetitionsUsed", "GetCOMMENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMENT Records from NTE
        /// </summary>
        public static List<TX> GetAllCOMMENTRecords(this NTE message)
        {
            return message.GetAllRecords<TX>("COMMENTRepetitionsUsed", "GetCOMMENT");
        }

        /// <summary>
        /// Add a new COMMENT to NTE
        /// </summary>
        public static TX AddCOMMENT(this NTE message)
        {
            return message.GetCOMMENT(message.COMMENTRepetitionsUsed);
        }

        /// <summary>
        /// Get COLLECTORIDENTIFIER Records from OBR
        /// </summary>
        public static IEnumerable GetCOLLECTORIDENTIFIERRecords(this OBR message)
        {
            object[] result = message.GetRecords("COLLECTORIDENTIFIERRepetitionsUsed", "GetCOLLECTORIDENTIFIER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COLLECTORIDENTIFIER Records from OBR
        /// </summary>
        public static List<CN> GetAllCOLLECTORIDENTIFIERRecords(this OBR message)
        {
            return message.GetAllRecords<CN>("COLLECTORIDENTIFIERRepetitionsUsed", "GetCOLLECTORIDENTIFIER");
        }

        /// <summary>
        /// Add a new COLLECTORIDENTIFIER to OBR
        /// </summary>
        public static CN AddCOLLECTORIDENTIFIER(this OBR message)
        {
            return message.GetCOLLECTORIDENTIFIER(message.COLLECTORIDENTIFIERRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDERINGPROVIDER Records from OBR
        /// </summary>
        public static IEnumerable GetORDERINGPROVIDERRecords(this OBR message)
        {
            object[] result = message.GetRecords("ORDERINGPROVIDERRepetitionsUsed", "GetORDERINGPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDERINGPROVIDER Records from OBR
        /// </summary>
        public static List<CN> GetAllORDERINGPROVIDERRecords(this OBR message)
        {
            return message.GetAllRecords<CN>("ORDERINGPROVIDERRepetitionsUsed", "GetORDERINGPROVIDER");
        }

        /// <summary>
        /// Add a new ORDERINGPROVIDER to OBR
        /// </summary>
        public static CN AddORDERINGPROVIDER(this OBR message)
        {
            return message.GetORDERINGPROVIDER(message.ORDERINGPROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDERCALLBACKPHONENUM Records from OBR
        /// </summary>
        public static IEnumerable GetORDERCALLBACKPHONENUMRecords(this OBR message)
        {
            object[] result = message.GetRecords("ORDERCALLBACKPHONENUMRepetitionsUsed", "GetORDERCALLBACKPHONENUM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDERCALLBACKPHONENUM Records from OBR
        /// </summary>
        public static List<TN> GetAllORDERCALLBACKPHONENUMRecords(this OBR message)
        {
            return message.GetAllRecords<TN>("ORDERCALLBACKPHONENUMRepetitionsUsed", "GetORDERCALLBACKPHONENUM");
        }

        /// <summary>
        /// Add a new ORDERCALLBACKPHONENUM to OBR
        /// </summary>
        public static TN AddORDERCALLBACKPHONENUM(this OBR message)
        {
            return message.GetORDERCALLBACKPHONENUM(message.ORDERCALLBACKPHONENUMRepetitionsUsed);
        }

        /// <summary>
        /// Get QUANTITYTIMING Records from OBR
        /// </summary>
        public static IEnumerable GetQUANTITYTIMINGRecords(this OBR message)
        {
            object[] result = message.GetRecords("QUANTITYTIMINGRepetitionsUsed", "GetQUANTITYTIMING");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUANTITYTIMING Records from OBR
        /// </summary>
        public static List<CM> GetAllQUANTITYTIMINGRecords(this OBR message)
        {
            return message.GetAllRecords<CM>("QUANTITYTIMINGRepetitionsUsed", "GetQUANTITYTIMING");
        }

        /// <summary>
        /// Add a new QUANTITYTIMING to OBR
        /// </summary>
        public static CM AddQUANTITYTIMING(this OBR message)
        {
            return message.GetQUANTITYTIMING(message.QUANTITYTIMINGRepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTCOPIESTO Records from OBR
        /// </summary>
        public static IEnumerable GetRESULTCOPIESTORecords(this OBR message)
        {
            object[] result = message.GetRecords("RESULTCOPIESTORepetitionsUsed", "GetRESULTCOPIESTO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTCOPIESTO Records from OBR
        /// </summary>
        public static List<CN> GetAllRESULTCOPIESTORecords(this OBR message)
        {
            return message.GetAllRecords<CN>("RESULTCOPIESTORepetitionsUsed", "GetRESULTCOPIESTO");
        }

        /// <summary>
        /// Add a new RESULTCOPIESTO to OBR
        /// </summary>
        public static CN AddRESULTCOPIESTO(this OBR message)
        {
            return message.GetRESULTCOPIESTO(message.RESULTCOPIESTORepetitionsUsed);
        }

        /// <summary>
        /// Get REASONFORSTUDY Records from OBR
        /// </summary>
        public static IEnumerable GetREASONFORSTUDYRecords(this OBR message)
        {
            object[] result = message.GetRecords("REASONFORSTUDYRepetitionsUsed", "GetREASONFORSTUDY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REASONFORSTUDY Records from OBR
        /// </summary>
        public static List<CE> GetAllREASONFORSTUDYRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("REASONFORSTUDYRepetitionsUsed", "GetREASONFORSTUDY");
        }

        /// <summary>
        /// Add a new REASONFORSTUDY to OBR
        /// </summary>
        public static CE AddREASONFORSTUDY(this OBR message)
        {
            return message.GetREASONFORSTUDY(message.REASONFORSTUDYRepetitionsUsed);
        }

        /// <summary>
        /// Get ABNORMALFLAGS Records from OBX
        /// </summary>
        public static IEnumerable GetABNORMALFLAGSRecords(this OBX message)
        {
            object[] result = message.GetRecords("ABNORMALFLAGSRepetitionsUsed", "GetABNORMALFLAGS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ABNORMALFLAGS Records from OBX
        /// </summary>
        public static List<ST> GetAllABNORMALFLAGSRecords(this OBX message)
        {
            return message.GetAllRecords<ST>("ABNORMALFLAGSRepetitionsUsed", "GetABNORMALFLAGS");
        }

        /// <summary>
        /// Add a new ABNORMALFLAGS to OBX
        /// </summary>
        public static ST AddABNORMALFLAGS(this OBX message)
        {
            return message.GetABNORMALFLAGS(message.ABNORMALFLAGSRepetitionsUsed);
        }

        /// <summary>
        /// Get CALLBACKPHONENUMBER Records from ORC
        /// </summary>
        public static IEnumerable GetCALLBACKPHONENUMBERRecords(this ORC message)
        {
            object[] result = message.GetRecords("CALLBACKPHONENUMBERRepetitionsUsed", "GetCALLBACKPHONENUMBER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CALLBACKPHONENUMBER Records from ORC
        /// </summary>
        public static List<TN> GetAllCALLBACKPHONENUMBERRecords(this ORC message)
        {
            return message.GetAllRecords<TN>("CALLBACKPHONENUMBERRepetitionsUsed", "GetCALLBACKPHONENUMBER");
        }

        /// <summary>
        /// Add a new CALLBACKPHONENUMBER to ORC
        /// </summary>
        public static TN AddCALLBACKPHONENUMBER(this ORC message)
        {
            return message.GetCALLBACKPHONENUMBER(message.CALLBACKPHONENUMBERRepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTSCOPIESTO Records from ORO
        /// </summary>
        public static IEnumerable GetRESULTSCOPIESTORecords(this ORO message)
        {
            object[] result = message.GetRecords("RESULTSCOPIESTORepetitionsUsed", "GetRESULTSCOPIESTO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTSCOPIESTO Records from ORO
        /// </summary>
        public static List<CN> GetAllRESULTSCOPIESTORecords(this ORO message)
        {
            return message.GetAllRecords<CN>("RESULTSCOPIESTORepetitionsUsed", "GetRESULTSCOPIESTO");
        }

        /// <summary>
        /// Add a new RESULTSCOPIESTO to ORO
        /// </summary>
        public static CN AddRESULTSCOPIESTO(this ORO message)
        {
            return message.GetRESULTSCOPIESTO(message.RESULTSCOPIESTORepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENTALIAS Records from PID
        /// </summary>
        public static IEnumerable GetPATIENTALIASRecords(this PID message)
        {
            object[] result = message.GetRecords("PATIENTALIASRepetitionsUsed", "GetPATIENTALIAS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENTALIAS Records from PID
        /// </summary>
        public static List<PN> GetAllPATIENTALIASRecords(this PID message)
        {
            return message.GetAllRecords<PN>("PATIENTALIASRepetitionsUsed", "GetPATIENTALIAS");
        }

        /// <summary>
        /// Add a new PATIENTALIAS to PID
        /// </summary>
        public static PN AddPATIENTALIAS(this PID message)
        {
            return message.GetPATIENTALIAS(message.PATIENTALIASRepetitionsUsed);
        }

        /// <summary>
        /// Get PHONENUMBERHOME Records from PID
        /// </summary>
        public static IEnumerable GetPHONENUMBERHOMERecords(this PID message)
        {
            object[] result = message.GetRecords("PHONENUMBERHOMERepetitionsUsed", "GetPHONENUMBERHOME");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PHONENUMBERHOME Records from PID
        /// </summary>
        public static List<TN> GetAllPHONENUMBERHOMERecords(this PID message)
        {
            return message.GetAllRecords<TN>("PHONENUMBERHOMERepetitionsUsed", "GetPHONENUMBERHOME");
        }

        /// <summary>
        /// Add a new PHONENUMBERHOME to PID
        /// </summary>
        public static TN AddPHONENUMBERHOME(this PID message)
        {
            return message.GetPHONENUMBERHOME(message.PHONENUMBERHOMERepetitionsUsed);
        }

        /// <summary>
        /// Get PHONENUMBERBUSINESS Records from PID
        /// </summary>
        public static IEnumerable GetPHONENUMBERBUSINESSRecords(this PID message)
        {
            object[] result = message.GetRecords("PHONENUMBERBUSINESSRepetitionsUsed", "GetPHONENUMBERBUSINESS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PHONENUMBERBUSINESS Records from PID
        /// </summary>
        public static List<TN> GetAllPHONENUMBERBUSINESSRecords(this PID message)
        {
            return message.GetAllRecords<TN>("PHONENUMBERBUSINESSRepetitionsUsed", "GetPHONENUMBERBUSINESS");
        }

        /// <summary>
        /// Add a new PHONENUMBERBUSINESS to PID
        /// </summary>
        public static TN AddPHONENUMBERBUSINESS(this PID message)
        {
            return message.GetPHONENUMBERBUSINESS(message.PHONENUMBERBUSINESSRepetitionsUsed);
        }

        /// <summary>
        /// Get SETIDPROCEDURE Records from PR1
        /// </summary>
        public static IEnumerable GetSETIDPROCEDURERecords(this PR1 message)
        {
            object[] result = message.GetRecords("SETIDPROCEDURERepetitionsUsed", "GetSETIDPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SETIDPROCEDURE Records from PR1
        /// </summary>
        public static List<SI> GetAllSETIDPROCEDURERecords(this PR1 message)
        {
            return message.GetAllRecords<SI>("SETIDPROCEDURERepetitionsUsed", "GetSETIDPROCEDURE");
        }

        /// <summary>
        /// Add a new SETIDPROCEDURE to PR1
        /// </summary>
        public static SI AddSETIDPROCEDURE(this PR1 message)
        {
            return message.GetSETIDPROCEDURE(message.SETIDPROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get CONSULTINGDOCTOR Records from PV1
        /// </summary>
        public static IEnumerable GetCONSULTINGDOCTORRecords(this PV1 message)
        {
            object[] result = message.GetRecords("CONSULTINGDOCTORRepetitionsUsed", "GetCONSULTINGDOCTOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONSULTINGDOCTOR Records from PV1
        /// </summary>
        public static List<CN> GetAllCONSULTINGDOCTORRecords(this PV1 message)
        {
            return message.GetAllRecords<CN>("CONSULTINGDOCTORRepetitionsUsed", "GetCONSULTINGDOCTOR");
        }

        /// <summary>
        /// Add a new CONSULTINGDOCTOR to PV1
        /// </summary>
        public static CN AddCONSULTINGDOCTOR(this PV1 message)
        {
            return message.GetCONSULTINGDOCTOR(message.CONSULTINGDOCTORRepetitionsUsed);
        }

        /// <summary>
        /// Get FINANCIALCLASS Records from PV1
        /// </summary>
        public static IEnumerable GetFINANCIALCLASSRecords(this PV1 message)
        {
            object[] result = message.GetRecords("FINANCIALCLASSRepetitionsUsed", "GetFINANCIALCLASS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIALCLASS Records from PV1
        /// </summary>
        public static List<ID> GetAllFINANCIALCLASSRecords(this PV1 message)
        {
            return message.GetAllRecords<ID>("FINANCIALCLASSRepetitionsUsed", "GetFINANCIALCLASS");
        }

        /// <summary>
        /// Add a new FINANCIALCLASS to PV1
        /// </summary>
        public static ID AddFINANCIALCLASS(this PV1 message)
        {
            return message.GetFINANCIALCLASS(message.FINANCIALCLASSRepetitionsUsed);
        }

        /// <summary>
        /// Get CONTRACTCODE Records from PV1
        /// </summary>
        public static IEnumerable GetCONTRACTCODERecords(this PV1 message)
        {
            object[] result = message.GetRecords("CONTRACTCODERepetitionsUsed", "GetCONTRACTCODE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONTRACTCODE Records from PV1
        /// </summary>
        public static List<ID> GetAllCONTRACTCODERecords(this PV1 message)
        {
            return message.GetAllRecords<ID>("CONTRACTCODERepetitionsUsed", "GetCONTRACTCODE");
        }

        /// <summary>
        /// Add a new CONTRACTCODE to PV1
        /// </summary>
        public static ID AddCONTRACTCODE(this PV1 message)
        {
            return message.GetCONTRACTCODE(message.CONTRACTCODERepetitionsUsed);
        }

        /// <summary>
        /// Get CONTRACTEFFECTIVEDATE Records from PV1
        /// </summary>
        public static IEnumerable GetCONTRACTEFFECTIVEDATERecords(this PV1 message)
        {
            object[] result = message.GetRecords("CONTRACTEFFECTIVEDATERepetitionsUsed", "GetCONTRACTEFFECTIVEDATE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONTRACTEFFECTIVEDATE Records from PV1
        /// </summary>
        public static List<DT> GetAllCONTRACTEFFECTIVEDATERecords(this PV1 message)
        {
            return message.GetAllRecords<DT>("CONTRACTEFFECTIVEDATERepetitionsUsed", "GetCONTRACTEFFECTIVEDATE");
        }

        /// <summary>
        /// Add a new CONTRACTEFFECTIVEDATE to PV1
        /// </summary>
        public static DT AddCONTRACTEFFECTIVEDATE(this PV1 message)
        {
            return message.GetCONTRACTEFFECTIVEDATE(message.CONTRACTEFFECTIVEDATERepetitionsUsed);
        }

        /// <summary>
        /// Get CONTRACTAMOUNT Records from PV1
        /// </summary>
        public static IEnumerable GetCONTRACTAMOUNTRecords(this PV1 message)
        {
            object[] result = message.GetRecords("CONTRACTAMOUNTRepetitionsUsed", "GetCONTRACTAMOUNT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONTRACTAMOUNT Records from PV1
        /// </summary>
        public static List<NM> GetAllCONTRACTAMOUNTRecords(this PV1 message)
        {
            return message.GetAllRecords<NM>("CONTRACTAMOUNTRepetitionsUsed", "GetCONTRACTAMOUNT");
        }

        /// <summary>
        /// Add a new CONTRACTAMOUNT to PV1
        /// </summary>
        public static NM AddCONTRACTAMOUNT(this PV1 message)
        {
            return message.GetCONTRACTAMOUNT(message.CONTRACTAMOUNTRepetitionsUsed);
        }

        /// <summary>
        /// Get CONTRACTPERIOD Records from PV1
        /// </summary>
        public static IEnumerable GetCONTRACTPERIODRecords(this PV1 message)
        {
            object[] result = message.GetRecords("CONTRACTPERIODRepetitionsUsed", "GetCONTRACTPERIOD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONTRACTPERIOD Records from PV1
        /// </summary>
        public static List<NM> GetAllCONTRACTPERIODRecords(this PV1 message)
        {
            return message.GetAllRecords<NM>("CONTRACTPERIODRepetitionsUsed", "GetCONTRACTPERIOD");
        }

        /// <summary>
        /// Add a new CONTRACTPERIOD to PV1
        /// </summary>
        public static NM AddCONTRACTPERIOD(this PV1 message)
        {
            return message.GetCONTRACTPERIOD(message.CONTRACTPERIODRepetitionsUsed);
        }

        /// <summary>
        /// Get WHOSUBJECTFILTER Records from QRD
        /// </summary>
        public static IEnumerable GetWHOSUBJECTFILTERRecords(this QRD message)
        {
            object[] result = message.GetRecords("WHOSUBJECTFILTERRepetitionsUsed", "GetWHOSUBJECTFILTER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WHOSUBJECTFILTER Records from QRD
        /// </summary>
        public static List<ST> GetAllWHOSUBJECTFILTERRecords(this QRD message)
        {
            return message.GetAllRecords<ST>("WHOSUBJECTFILTERRepetitionsUsed", "GetWHOSUBJECTFILTER");
        }

        /// <summary>
        /// Add a new WHOSUBJECTFILTER to QRD
        /// </summary>
        public static ST AddWHOSUBJECTFILTER(this QRD message)
        {
            return message.GetWHOSUBJECTFILTER(message.WHOSUBJECTFILTERRepetitionsUsed);
        }

        /// <summary>
        /// Get WHATSUBJECTFILTER Records from QRD
        /// </summary>
        public static IEnumerable GetWHATSUBJECTFILTERRecords(this QRD message)
        {
            object[] result = message.GetRecords("WHATSUBJECTFILTERRepetitionsUsed", "GetWHATSUBJECTFILTER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WHATSUBJECTFILTER Records from QRD
        /// </summary>
        public static List<ID> GetAllWHATSUBJECTFILTERRecords(this QRD message)
        {
            return message.GetAllRecords<ID>("WHATSUBJECTFILTERRepetitionsUsed", "GetWHATSUBJECTFILTER");
        }

        /// <summary>
        /// Add a new WHATSUBJECTFILTER to QRD
        /// </summary>
        public static ID AddWHATSUBJECTFILTER(this QRD message)
        {
            return message.GetWHATSUBJECTFILTER(message.WHATSUBJECTFILTERRepetitionsUsed);
        }

        /// <summary>
        /// Get WHATDEPARTMENTDATACODE Records from QRD
        /// </summary>
        public static IEnumerable GetWHATDEPARTMENTDATACODERecords(this QRD message)
        {
            object[] result = message.GetRecords("WHATDEPARTMENTDATACODERepetitionsUsed", "GetWHATDEPARTMENTDATACODE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WHATDEPARTMENTDATACODE Records from QRD
        /// </summary>
        public static List<ST> GetAllWHATDEPARTMENTDATACODERecords(this QRD message)
        {
            return message.GetAllRecords<ST>("WHATDEPARTMENTDATACODERepetitionsUsed", "GetWHATDEPARTMENTDATACODE");
        }

        /// <summary>
        /// Add a new WHATDEPARTMENTDATACODE to QRD
        /// </summary>
        public static ST AddWHATDEPARTMENTDATACODE(this QRD message)
        {
            return message.GetWHATDEPARTMENTDATACODE(message.WHATDEPARTMENTDATACODERepetitionsUsed);
        }

        /// <summary>
        /// Get WHATDATACODEVALUEQUAL Records from QRD
        /// </summary>
        public static IEnumerable GetWHATDATACODEVALUEQUALRecords(this QRD message)
        {
            object[] result = message.GetRecords("WHATDATACODEVALUEQUALRepetitionsUsed", "GetWHATDATACODEVALUEQUAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WHATDATACODEVALUEQUAL Records from QRD
        /// </summary>
        public static List<ST> GetAllWHATDATACODEVALUEQUALRecords(this QRD message)
        {
            return message.GetAllRecords<ST>("WHATDATACODEVALUEQUALRepetitionsUsed", "GetWHATDATACODEVALUEQUAL");
        }

        /// <summary>
        /// Add a new WHATDATACODEVALUEQUAL to QRD
        /// </summary>
        public static ST AddWHATDATACODEVALUEQUAL(this QRD message)
        {
            return message.GetWHATDATACODEVALUEQUAL(message.WHATDATACODEVALUEQUALRepetitionsUsed);
        }

        /// <summary>
        /// Get WHERESUBJECTFILTER Records from QRF
        /// </summary>
        public static IEnumerable GetWHERESUBJECTFILTERRecords(this QRF message)
        {
            object[] result = message.GetRecords("WHERESUBJECTFILTERRepetitionsUsed", "GetWHERESUBJECTFILTER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WHERESUBJECTFILTER Records from QRF
        /// </summary>
        public static List<ST> GetAllWHERESUBJECTFILTERRecords(this QRF message)
        {
            return message.GetAllRecords<ST>("WHERESUBJECTFILTERRepetitionsUsed", "GetWHERESUBJECTFILTER");
        }

        /// <summary>
        /// Add a new WHERESUBJECTFILTER to QRF
        /// </summary>
        public static ST AddWHERESUBJECTFILTER(this QRF message)
        {
            return message.GetWHERESUBJECTFILTER(message.WHERESUBJECTFILTERRepetitionsUsed);
        }

        /// <summary>
        /// Get WHATUSERQUALIFIER Records from QRF
        /// </summary>
        public static IEnumerable GetWHATUSERQUALIFIERRecords(this QRF message)
        {
            object[] result = message.GetRecords("WHATUSERQUALIFIERRepetitionsUsed", "GetWHATUSERQUALIFIER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WHATUSERQUALIFIER Records from QRF
        /// </summary>
        public static List<ST> GetAllWHATUSERQUALIFIERRecords(this QRF message)
        {
            return message.GetAllRecords<ST>("WHATUSERQUALIFIERRepetitionsUsed", "GetWHATUSERQUALIFIER");
        }

        /// <summary>
        /// Add a new WHATUSERQUALIFIER to QRF
        /// </summary>
        public static ST AddWHATUSERQUALIFIER(this QRF message)
        {
            return message.GetWHATUSERQUALIFIER(message.WHATUSERQUALIFIERRepetitionsUsed);
        }

        /// <summary>
        /// Get OTHERQRYSUBJECTFILTER Records from QRF
        /// </summary>
        public static IEnumerable GetOTHERQRYSUBJECTFILTERRecords(this QRF message)
        {
            object[] result = message.GetRecords("OTHERQRYSUBJECTFILTERRepetitionsUsed", "GetOTHERQRYSUBJECTFILTER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OTHERQRYSUBJECTFILTER Records from QRF
        /// </summary>
        public static List<ST> GetAllOTHERQRYSUBJECTFILTERRecords(this QRF message)
        {
            return message.GetAllRecords<ST>("OTHERQRYSUBJECTFILTERRepetitionsUsed", "GetOTHERQRYSUBJECTFILTER");
        }

        /// <summary>
        /// Add a new OTHERQRYSUBJECTFILTER to QRF
        /// </summary>
        public static ST AddOTHERQRYSUBJECTFILTER(this QRF message)
        {
            return message.GetOTHERQRYSUBJECTFILTER(message.OTHERQRYSUBJECTFILTERRepetitionsUsed);
        }

        /// <summary>
        /// Get COMPONENTDRUGIDS Records from RX1
        /// </summary>
        public static IEnumerable GetCOMPONENTDRUGIDSRecords(this RX1 message)
        {
            object[] result = message.GetRecords("COMPONENTDRUGIDSRepetitionsUsed", "GetCOMPONENTDRUGIDS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMPONENTDRUGIDS Records from RX1
        /// </summary>
        public static List<ID> GetAllCOMPONENTDRUGIDSRecords(this RX1 message)
        {
            return message.GetAllRecords<ID>("COMPONENTDRUGIDSRepetitionsUsed", "GetCOMPONENTDRUGIDS");
        }

        /// <summary>
        /// Add a new COMPONENTDRUGIDS to RX1
        /// </summary>
        public static ID AddCOMPONENTDRUGIDS(this RX1 message)
        {
            return message.GetCOMPONENTDRUGIDS(message.COMPONENTDRUGIDSRepetitionsUsed);
        }

        /// <summary>
        /// Get PHARMACYINSTRUCTIONS Records from RX1
        /// </summary>
        public static IEnumerable GetPHARMACYINSTRUCTIONSRecords(this RX1 message)
        {
            object[] result = message.GetRecords("PHARMACYINSTRUCTIONSRepetitionsUsed", "GetPHARMACYINSTRUCTIONS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PHARMACYINSTRUCTIONS Records from RX1
        /// </summary>
        public static List<TX> GetAllPHARMACYINSTRUCTIONSRecords(this RX1 message)
        {
            return message.GetAllRecords<TX>("PHARMACYINSTRUCTIONSRepetitionsUsed", "GetPHARMACYINSTRUCTIONS");
        }

        /// <summary>
        /// Add a new PHARMACYINSTRUCTIONS to RX1
        /// </summary>
        public static TX AddPHARMACYINSTRUCTIONS(this RX1 message)
        {
            return message.GetPHARMACYINSTRUCTIONS(message.PHARMACYINSTRUCTIONSRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENTINSTRUCTIONS Records from RX1
        /// </summary>
        public static IEnumerable GetPATIENTINSTRUCTIONSRecords(this RX1 message)
        {
            object[] result = message.GetRecords("PATIENTINSTRUCTIONSRepetitionsUsed", "GetPATIENTINSTRUCTIONS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENTINSTRUCTIONS Records from RX1
        /// </summary>
        public static List<TX> GetAllPATIENTINSTRUCTIONSRecords(this RX1 message)
        {
            return message.GetAllRecords<TX>("PATIENTINSTRUCTIONSRepetitionsUsed", "GetPATIENTINSTRUCTIONS");
        }

        /// <summary>
        /// Add a new PATIENTINSTRUCTIONS to RX1
        /// </summary>
        public static TX AddPATIENTINSTRUCTIONS(this RX1 message)
        {
            return message.GetPATIENTINSTRUCTIONS(message.PATIENTINSTRUCTIONSRepetitionsUsed);
        }

        /// <summary>
        /// Get INSTRUCTIONS Records from RX1
        /// </summary>
        public static IEnumerable GetINSTRUCTIONSRecords(this RX1 message)
        {
            object[] result = message.GetRecords("INSTRUCTIONSRepetitionsUsed", "GetINSTRUCTIONS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSTRUCTIONS Records from RX1
        /// </summary>
        public static List<TX> GetAllINSTRUCTIONSRecords(this RX1 message)
        {
            return message.GetAllRecords<TX>("INSTRUCTIONSRepetitionsUsed", "GetINSTRUCTIONS");
        }

        /// <summary>
        /// Add a new INSTRUCTIONS to RX1
        /// </summary>
        public static TX AddINSTRUCTIONS(this RX1 message)
        {
            return message.GetINSTRUCTIONS(message.INSTRUCTIONSRepetitionsUsed);
        }

        /// <summary>
        /// Get CONDITIONCODE Records from UB1
        /// </summary>
        public static IEnumerable GetCONDITIONCODERecords(this UB1 message)
        {
            object[] result = message.GetRecords("CONDITIONCODERepetitionsUsed", "GetCONDITIONCODE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONDITIONCODE Records from UB1
        /// </summary>
        public static List<ID> GetAllCONDITIONCODERecords(this UB1 message)
        {
            return message.GetAllRecords<ID>("CONDITIONCODERepetitionsUsed", "GetCONDITIONCODE");
        }

        /// <summary>
        /// Add a new CONDITIONCODE to UB1
        /// </summary>
        public static ID AddCONDITIONCODE(this UB1 message)
        {
            return message.GetCONDITIONCODE(message.CONDITIONCODERepetitionsUsed);
        }

        /// <summary>
        /// Get VALUEAMOUNTCODE Records from UB1
        /// </summary>
        public static IEnumerable GetVALUEAMOUNTCODERecords(this UB1 message)
        {
            object[] result = message.GetRecords("VALUEAMOUNTCODERepetitionsUsed", "GetVALUEAMOUNTCODE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VALUEAMOUNTCODE Records from UB1
        /// </summary>
        public static List<CM> GetAllVALUEAMOUNTCODERecords(this UB1 message)
        {
            return message.GetAllRecords<CM>("VALUEAMOUNTCODERepetitionsUsed", "GetVALUEAMOUNTCODE");
        }

        /// <summary>
        /// Add a new VALUEAMOUNTCODE to UB1
        /// </summary>
        public static CM AddVALUEAMOUNTCODE(this UB1 message)
        {
            return message.GetVALUEAMOUNTCODE(message.VALUEAMOUNTCODERepetitionsUsed);
        }

        /// <summary>
        /// Get OCCURRENCE2832 Records from UB1
        /// </summary>
        public static IEnumerable GetOCCURRENCE2832Records(this UB1 message)
        {
            object[] result = message.GetRecords("OCCURRENCE2832RepetitionsUsed", "GetOCCURRENCE2832");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OCCURRENCE2832 Records from UB1
        /// </summary>
        public static List<ID> GetAllOCCURRENCE2832Records(this UB1 message)
        {
            return message.GetAllRecords<ID>("OCCURRENCE2832RepetitionsUsed", "GetOCCURRENCE2832");
        }

        /// <summary>
        /// Add a new OCCURRENCE2832 to UB1
        /// </summary>
        public static ID AddOCCURRENCE2832(this UB1 message)
        {
            return message.GetOCCURRENCE2832(message.OCCURRENCE2832RepetitionsUsed);
        }

        /// <summary>
        /// Get RUWHOSUBJECTDEFINITION Records from URD
        /// </summary>
        public static IEnumerable GetRUWHOSUBJECTDEFINITIONRecords(this URD message)
        {
            object[] result = message.GetRecords("RUWHOSUBJECTDEFINITIONRepetitionsUsed", "GetRUWHOSUBJECTDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWHOSUBJECTDEFINITION Records from URD
        /// </summary>
        public static List<ST> GetAllRUWHOSUBJECTDEFINITIONRecords(this URD message)
        {
            return message.GetAllRecords<ST>("RUWHOSUBJECTDEFINITIONRepetitionsUsed", "GetRUWHOSUBJECTDEFINITION");
        }

        /// <summary>
        /// Add a new RUWHOSUBJECTDEFINITION to URD
        /// </summary>
        public static ST AddRUWHOSUBJECTDEFINITION(this URD message)
        {
            return message.GetRUWHOSUBJECTDEFINITION(message.RUWHOSUBJECTDEFINITIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWHATSUBJECTDEFINITION Records from URD
        /// </summary>
        public static IEnumerable GetRUWHATSUBJECTDEFINITIONRecords(this URD message)
        {
            object[] result = message.GetRecords("RUWHATSUBJECTDEFINITIONRepetitionsUsed", "GetRUWHATSUBJECTDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWHATSUBJECTDEFINITION Records from URD
        /// </summary>
        public static List<ID> GetAllRUWHATSUBJECTDEFINITIONRecords(this URD message)
        {
            return message.GetAllRecords<ID>("RUWHATSUBJECTDEFINITIONRepetitionsUsed", "GetRUWHATSUBJECTDEFINITION");
        }

        /// <summary>
        /// Add a new RUWHATSUBJECTDEFINITION to URD
        /// </summary>
        public static ID AddRUWHATSUBJECTDEFINITION(this URD message)
        {
            return message.GetRUWHATSUBJECTDEFINITION(message.RUWHATSUBJECTDEFINITIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWHATDEPARTMENTCODE Records from URD
        /// </summary>
        public static IEnumerable GetRUWHATDEPARTMENTCODERecords(this URD message)
        {
            object[] result = message.GetRecords("RUWHATDEPARTMENTCODERepetitionsUsed", "GetRUWHATDEPARTMENTCODE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWHATDEPARTMENTCODE Records from URD
        /// </summary>
        public static List<ST> GetAllRUWHATDEPARTMENTCODERecords(this URD message)
        {
            return message.GetAllRecords<ST>("RUWHATDEPARTMENTCODERepetitionsUsed", "GetRUWHATDEPARTMENTCODE");
        }

        /// <summary>
        /// Add a new RUWHATDEPARTMENTCODE to URD
        /// </summary>
        public static ST AddRUWHATDEPARTMENTCODE(this URD message)
        {
            return message.GetRUWHATDEPARTMENTCODE(message.RUWHATDEPARTMENTCODERepetitionsUsed);
        }

        /// <summary>
        /// Get RUDISPLAYPRINTLOCATIONS Records from URD
        /// </summary>
        public static IEnumerable GetRUDISPLAYPRINTLOCATIONSRecords(this URD message)
        {
            object[] result = message.GetRecords("RUDISPLAYPRINTLOCATIONSRepetitionsUsed", "GetRUDISPLAYPRINTLOCATIONS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUDISPLAYPRINTLOCATIONS Records from URD
        /// </summary>
        public static List<ST> GetAllRUDISPLAYPRINTLOCATIONSRecords(this URD message)
        {
            return message.GetAllRecords<ST>("RUDISPLAYPRINTLOCATIONSRepetitionsUsed", "GetRUDISPLAYPRINTLOCATIONS");
        }

        /// <summary>
        /// Add a new RUDISPLAYPRINTLOCATIONS to URD
        /// </summary>
        public static ST AddRUDISPLAYPRINTLOCATIONS(this URD message)
        {
            return message.GetRUDISPLAYPRINTLOCATIONS(message.RUDISPLAYPRINTLOCATIONSRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWHERESUBJECTDEFINITION Records from URS
        /// </summary>
        public static IEnumerable GetRUWHERESUBJECTDEFINITIONRecords(this URS message)
        {
            object[] result = message.GetRecords("RUWHERESUBJECTDEFINITIONRepetitionsUsed", "GetRUWHERESUBJECTDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWHERESUBJECTDEFINITION Records from URS
        /// </summary>
        public static List<ST> GetAllRUWHERESUBJECTDEFINITIONRecords(this URS message)
        {
            return message.GetAllRecords<ST>("RUWHERESUBJECTDEFINITIONRepetitionsUsed", "GetRUWHERESUBJECTDEFINITION");
        }

        /// <summary>
        /// Add a new RUWHERESUBJECTDEFINITION to URS
        /// </summary>
        public static ST AddRUWHERESUBJECTDEFINITION(this URS message)
        {
            return message.GetRUWHERESUBJECTDEFINITION(message.RUWHERESUBJECTDEFINITIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWHATUSERQUALIFIER Records from URS
        /// </summary>
        public static IEnumerable GetRUWHATUSERQUALIFIERRecords(this URS message)
        {
            object[] result = message.GetRecords("RUWHATUSERQUALIFIERRepetitionsUsed", "GetRUWHATUSERQUALIFIER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWHATUSERQUALIFIER Records from URS
        /// </summary>
        public static List<ST> GetAllRUWHATUSERQUALIFIERRecords(this URS message)
        {
            return message.GetAllRecords<ST>("RUWHATUSERQUALIFIERRepetitionsUsed", "GetRUWHATUSERQUALIFIER");
        }

        /// <summary>
        /// Add a new RUWHATUSERQUALIFIER to URS
        /// </summary>
        public static ST AddRUWHATUSERQUALIFIER(this URS message)
        {
            return message.GetRUWHATUSERQUALIFIER(message.RUWHATUSERQUALIFIERRepetitionsUsed);
        }

        /// <summary>
        /// Get RUOTHERRESULTSSUBJECTDEFINI Records from URS
        /// </summary>
        public static IEnumerable GetRUOTHERRESULTSSUBJECTDEFINIRecords(this URS message)
        {
            object[] result = message.GetRecords("RUOTHERRESULTSSUBJECTDEFINIRepetitionsUsed", "GetRUOTHERRESULTSSUBJECTDEFINI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUOTHERRESULTSSUBJECTDEFINI Records from URS
        /// </summary>
        public static List<ST> GetAllRUOTHERRESULTSSUBJECTDEFINIRecords(this URS message)
        {
            return message.GetAllRecords<ST>("RUOTHERRESULTSSUBJECTDEFINIRepetitionsUsed", "GetRUOTHERRESULTSSUBJECTDEFINI");
        }

        /// <summary>
        /// Add a new RUOTHERRESULTSSUBJECTDEFINI to URS
        /// </summary>
        public static ST AddRUOTHERRESULTSSUBJECTDEFINI(this URS message)
        {
            return message.GetRUOTHERRESULTSSUBJECTDEFINI(message.RUOTHERRESULTSSUBJECTDEFINIRepetitionsUsed);
        }
        #endregion
    }
}
