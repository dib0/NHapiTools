using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V251.Group;
using NHapi.Model.V251.Message;
using NHapi.Model.V251.Segment;
using NHapiTools.Base;

namespace NHapiTools.Model.V251.Message
{
    /// <summary>
    /// Message extention methods
    /// </summary>
    public static class MessageExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get ERR Records from SRR_S01
        /// </summary>
        public static IEnumerable GetERRRecords(this SRR_S01 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from SRR_S01
        /// </summary>
        public static List<ERR> GetAllERRRecords(this SRR_S01 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RTB_K13
        /// </summary>
        public static IEnumerable GetSFTRecords(this RTB_K13 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RTB_K13
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RTB_K13 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from RSP_Z90
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_Z90 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_Z90
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_Z90 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from RSP_Z90
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this RSP_Z90 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from RSP_Z90
        /// </summary>
        public static List<RSP_Z90_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this RSP_Z90 message)
        {
            return message.GetAllRecords<RSP_Z90_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Get SFT Records from RSP_Q11
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_Q11 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_Q11
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_Q11 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from RSP_Q11
        /// </summary>
        public static IEnumerable GetERRRecords(this RSP_Q11 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RSP_Q11
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RSP_Q11 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from QRY_Q02
        /// </summary>
        public static IEnumerable GetSFTRecords(this QRY_Q02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QRY_Q02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QRY_Q02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from PPT_PCL
        /// </summary>
        public static IEnumerable GetSFTRecords(this PPT_PCL message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PPT_PCL
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PPT_PCL message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from PPT_PCL
        /// </summary>
        public static IEnumerable GetERRRecords(this PPT_PCL message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from PPT_PCL
        /// </summary>
        public static List<ERR> GetAllERRRecords(this PPT_PCL message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get PATIENT Records from PPT_PCL
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this PPT_PCL message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from PPT_PCL
        /// </summary>
        public static List<PPT_PCL_PATIENT> GetAllPATIENTRecords(this PPT_PCL message)
        {
            return message.GetAllRecords<PPT_PCL_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from ORU_R01
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORU_R01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORU_R01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORU_R01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT_RESULT Records from ORU_R01
        /// </summary>
        public static IEnumerable GetPATIENT_RESULTRecords(this ORU_R01 message)
        {
            object[] result = message.GetRecords("PATIENT_RESULTRepetitionsUsed", "GetPATIENT_RESULT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_RESULT Records from ORU_R01
        /// </summary>
        public static List<ORU_R01_PATIENT_RESULT> GetAllPATIENT_RESULTRecords(this ORU_R01 message)
        {
            return message.GetAllRecords<ORU_R01_PATIENT_RESULT>("PATIENT_RESULTRepetitionsUsed", "GetPATIENT_RESULT");
        }

        /// <summary>
        /// Get ERR Records from ORL_O22
        /// </summary>
        public static IEnumerable GetERRRecords(this ORL_O22 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORL_O22
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORL_O22 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORL_O22
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORL_O22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORL_O22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORL_O22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORL_O22
        /// </summary>
        public static IEnumerable GetNTERecords(this ORL_O22 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORL_O22
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORL_O22 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OML_O33
        /// </summary>
        public static IEnumerable GetSFTRecords(this OML_O33 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OML_O33
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OML_O33 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OML_O33
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O33 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O33
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O33 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SPECIMEN Records from OML_O33
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this OML_O33 message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from OML_O33
        /// </summary>
        public static List<OML_O33_SPECIMEN> GetAllSPECIMENRecords(this OML_O33 message)
        {
            return message.GetAllRecords<OML_O33_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Get SFT Records from OMD_O03
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMD_O03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMD_O03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMD_O03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMD_O03
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER_DIET Records from OMD_O03
        /// </summary>
        public static IEnumerable GetORDER_DIETRecords(this OMD_O03 message)
        {
            object[] result = message.GetRecords("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_DIET Records from OMD_O03
        /// </summary>
        public static List<OMD_O03_ORDER_DIET> GetAllORDER_DIETRecords(this OMD_O03 message)
        {
            return message.GetAllRecords<OMD_O03_ORDER_DIET>("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");
        }

        /// <summary>
        /// Get SFT Records from DFT_P11
        /// </summary>
        public static IEnumerable GetSFTRecords(this DFT_P11 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from DFT_P11
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this DFT_P11 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from DFT_P11
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL2 Records from DFT_P11
        /// </summary>
        public static IEnumerable GetROL2Records(this DFT_P11 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from DFT_P11
        /// </summary>
        public static List<ROL> GetAllROL2Records(this DFT_P11 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from DFT_P11
        /// </summary>
        public static IEnumerable GetDB1Records(this DFT_P11 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from DFT_P11
        /// </summary>
        public static List<DB1> GetAllDB1Records(this DFT_P11 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get DG1 Records from DFT_P11
        /// </summary>
        public static IEnumerable GetDG1Records(this DFT_P11 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from DFT_P11
        /// </summary>
        public static List<DG1> GetAllDG1Records(this DFT_P11 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from DFT_P11
        /// </summary>
        public static IEnumerable GetGT1Records(this DFT_P11 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from DFT_P11
        /// </summary>
        public static List<GT1> GetAllGT1Records(this DFT_P11 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get FINANCIAL Records from DFT_P11
        /// </summary>
        public static IEnumerable GetFINANCIALRecords(this DFT_P11 message)
        {
            object[] result = message.GetRecords("FINANCIALRepetitionsUsed", "GetFINANCIAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL Records from DFT_P11
        /// </summary>
        public static List<DFT_P11_FINANCIAL> GetAllFINANCIALRecords(this DFT_P11 message)
        {
            return message.GetAllRecords<DFT_P11_FINANCIAL>("FINANCIALRepetitionsUsed", "GetFINANCIAL");
        }

        /// <summary>
        /// Get SFT Records from ADT_A18
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A18 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A18
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A18 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from ACK
        /// </summary>
        public static IEnumerable GetSFTRecords(this ACK message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ACK
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ACK message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from ACK
        /// </summary>
        public static IEnumerable GetERRRecords(this ACK message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ACK
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ACK message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RQA_I08
        /// </summary>
        public static IEnumerable GetSFTRecords(this RQA_I08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RQA_I08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RQA_I08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RQA_I08
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQA_I08 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQA_I08
        /// </summary>
        public static List<RQA_I08_PROVIDER> GetAllPROVIDERRecords(this RQA_I08 message)
        {
            return message.GetAllRecords<RQA_I08_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RQA_I08
        /// </summary>
        public static IEnumerable GetNK1Records(this RQA_I08 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQA_I08
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQA_I08 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get DG1 Records from RQA_I08
        /// </summary>
        public static IEnumerable GetDG1Records(this RQA_I08 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RQA_I08
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RQA_I08 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get DRG Records from RQA_I08
        /// </summary>
        public static IEnumerable GetDRGRecords(this RQA_I08 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RQA_I08
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RQA_I08 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Get AL1 Records from RQA_I08
        /// </summary>
        public static IEnumerable GetAL1Records(this RQA_I08 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RQA_I08
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RQA_I08 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from RQA_I08
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from QRY_Q01
        /// </summary>
        public static IEnumerable GetSFTRecords(this QRY_Q01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QRY_Q01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QRY_Q01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from QCK_Q02
        /// </summary>
        public static IEnumerable GetSFTRecords(this QCK_Q02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QCK_Q02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QCK_Q02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from QBP_Q13
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_Q13 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_Q13
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_Q13 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from PMU_B04
        /// </summary>
        public static IEnumerable GetSFTRecords(this PMU_B04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PMU_B04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PMU_B04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PRA Records from PMU_B04
        /// </summary>
        public static IEnumerable GetPRARecords(this PMU_B04 message)
        {
            object[] result = message.GetRecords("PRARepetitionsUsed", "GetPRA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRA Records from PMU_B04
        /// </summary>
        public static List<PRA> GetAllPRARecords(this PMU_B04 message)
        {
            return message.GetAllRecords<PRA>("PRARepetitionsUsed", "GetPRA");
        }

        /// <summary>
        /// Get ORG Records from PMU_B04
        /// </summary>
        public static IEnumerable GetORGRecords(this PMU_B04 message)
        {
            object[] result = message.GetRecords("ORGRepetitionsUsed", "GetORG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORG Records from PMU_B04
        /// </summary>
        public static List<ORG> GetAllORGRecords(this PMU_B04 message)
        {
            return message.GetAllRecords<ORG>("ORGRepetitionsUsed", "GetORG");
        }

        /// <summary>
        /// Get ERR Records from ORR_O02
        /// </summary>
        public static IEnumerable GetERRRecords(this ORR_O02 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORR_O02
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORR_O02 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get NTE Records from ORR_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ERR Records from ORB_O28
        /// </summary>
        public static IEnumerable GetERRRecords(this ORB_O28 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORB_O28
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORB_O28 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORB_O28
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORB_O28 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORB_O28
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORB_O28 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORB_O28
        /// </summary>
        public static IEnumerable GetNTERecords(this ORB_O28 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORB_O28
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORB_O28 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OML_O21
        /// </summary>
        public static IEnumerable GetSFTRecords(this OML_O21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OML_O21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OML_O21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OML_O21
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OML_O21
        /// </summary>
        public static IEnumerable GetORDERRecords(this OML_O21 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OML_O21
        /// </summary>
        public static List<OML_O21_ORDER> GetAllORDERRecords(this OML_O21 message)
        {
            return message.GetAllRecords<OML_O21_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFR_M01
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFR_M01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFR_M01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFR_M01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from MFR_M01
        /// </summary>
        public static IEnumerable GetERRRecords(this MFR_M01 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from MFR_M01
        /// </summary>
        public static List<ERR> GetAllERRRecords(this MFR_M01 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get MF_QUERY Records from MFR_M01
        /// </summary>
        public static IEnumerable GetMF_QUERYRecords(this MFR_M01 message)
        {
            object[] result = message.GetRecords("MF_QUERYRepetitionsUsed", "GetMF_QUERY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_QUERY Records from MFR_M01
        /// </summary>
        public static List<MFR_M01_MF_QUERY> GetAllMF_QUERYRecords(this MFR_M01 message)
        {
            return message.GetAllRecords<MFR_M01_MF_QUERY>("MF_QUERYRepetitionsUsed", "GetMF_QUERY");
        }

        /// <summary>
        /// Get SFT Records from ADT_A39
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A39 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A39
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A39 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from ADT_A39
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this ADT_A39 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from ADT_A39
        /// </summary>
        public static List<ADT_A39_PATIENT> GetAllPATIENTRecords(this ADT_A39 message)
        {
            return message.GetAllRecords<ADT_A39_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A17
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A17 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A17
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A17 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A17
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A17 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A17
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A17 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A17
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A17 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A17
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A17 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get DB12 Records from ADT_A17
        /// </summary>
        public static IEnumerable GetDB12Records(this ADT_A17 message)
        {
            object[] result = message.GetRecords("DB12RepetitionsUsed", "GetDB12");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB12 Records from ADT_A17
        /// </summary>
        public static List<DB1> GetAllDB12Records(this ADT_A17 message)
        {
            return message.GetAllRecords<DB1>("DB12RepetitionsUsed", "GetDB12");
        }

        /// <summary>
        /// Get OBX2 Records from ADT_A17
        /// </summary>
        public static IEnumerable GetOBX2Records(this ADT_A17 message)
        {
            object[] result = message.GetRecords("OBX2RepetitionsUsed", "GetOBX2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX2 Records from ADT_A17
        /// </summary>
        public static List<OBX> GetAllOBX2Records(this ADT_A17 message)
        {
            return message.GetAllRecords<OBX>("OBX2RepetitionsUsed", "GetOBX2");
        }

        /// <summary>
        /// Get SFT Records from ADT_A06
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A06
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A06 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A06
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A06 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NK1 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A06
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A06 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A06
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A06 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A06
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A06 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A06
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A06 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A06
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A06 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A06
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A06 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A06
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A06 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A06
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A06 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get FACPSHPDCPSHFACPDCNTEED Records from SUR_P09
        /// </summary>
        public static IEnumerable GetFACPSHPDCPSHFACPDCNTEEDRecords(this SUR_P09 message)
        {
            object[] result = message.GetRecords("FACPSHPDCPSHFACPDCNTEEDRepetitionsUsed", "GetFACPSHPDCPSHFACPDCNTEED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FACPSHPDCPSHFACPDCNTEED Records from SUR_P09
        /// </summary>
        public static List<SUR_P09_FACPSHPDCPSHFACPDCNTEED> GetAllFACPSHPDCPSHFACPDCNTEEDRecords(this SUR_P09 message)
        {
            return message.GetAllRecords<SUR_P09_FACPSHPDCPSHFACPDCNTEED>("FACPSHPDCPSHFACPDCNTEEDRepetitionsUsed", "GetFACPSHPDCPSHFACPDCNTEED");
        }

        /// <summary>
        /// Get ERR Records from SQR_S25
        /// </summary>
        public static IEnumerable GetERRRecords(this SQR_S25 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from SQR_S25
        /// </summary>
        public static List<ERR> GetAllERRRecords(this SQR_S25 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RTB_Knn
        /// </summary>
        public static IEnumerable GetSFTRecords(this RTB_Knn message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RTB_Knn
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RTB_Knn message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from RRI_I12
        /// </summary>
        public static IEnumerable GetSFTRecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RRI_I12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RRI_I12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER_CONTACT Records from RRI_I12
        /// </summary>
        public static IEnumerable GetPROVIDER_CONTACTRecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER_CONTACT Records from RRI_I12
        /// </summary>
        public static List<RRI_I12_PROVIDER_CONTACT> GetAllPROVIDER_CONTACTRecords(this RRI_I12 message)
        {
            return message.GetAllRecords<RRI_I12_PROVIDER_CONTACT>("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");
        }

        /// <summary>
        /// Get DG1 Records from RRI_I12
        /// </summary>
        public static IEnumerable GetDG1Records(this RRI_I12 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RRI_I12
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RRI_I12 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get DRG Records from RRI_I12
        /// </summary>
        public static IEnumerable GetDRGRecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RRI_I12
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RRI_I12 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Get AL1 Records from RRI_I12
        /// </summary>
        public static IEnumerable GetAL1Records(this RRI_I12 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RRI_I12
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RRI_I12 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get PROCEDURE Records from RRI_I12
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RRI_I12
        /// </summary>
        public static List<RRI_I12_PROCEDURE> GetAllPROCEDURERecords(this RRI_I12 message)
        {
            return message.GetAllRecords<RRI_I12_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Get OBSERVATION Records from RRI_I12
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RRI_I12
        /// </summary>
        public static List<RRI_I12_OBSERVATION> GetAllOBSERVATIONRecords(this RRI_I12 message)
        {
            return message.GetAllRecords<RRI_I12_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from RRI_I12
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from RDS_O13
        /// </summary>
        public static IEnumerable GetSFTRecords(this RDS_O13 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RDS_O13
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RDS_O13 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RDS_O13
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RDS_O13
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDS_O13 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDS_O13
        /// </summary>
        public static List<RDS_O13_ORDER> GetAllORDERRecords(this RDS_O13 message)
        {
            return message.GetAllRecords<RDS_O13_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from PRR_PC5
        /// </summary>
        public static IEnumerable GetSFTRecords(this PRR_PC5 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PRR_PC5
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PRR_PC5 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from PRR_PC5
        /// </summary>
        public static IEnumerable GetERRRecords(this PRR_PC5 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from PRR_PC5
        /// </summary>
        public static List<ERR> GetAllERRRecords(this PRR_PC5 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get PATIENT Records from PRR_PC5
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this PRR_PC5 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from PRR_PC5
        /// </summary>
        public static List<PRR_PC5_PATIENT> GetAllPATIENTRecords(this PRR_PC5 message)
        {
            return message.GetAllRecords<PRR_PC5_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from PPP_PCB
        /// </summary>
        public static IEnumerable GetSFTRecords(this PPP_PCB message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PPP_PCB
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PPP_PCB message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATHWAY Records from PPP_PCB
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPP_PCB message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPP_PCB
        /// </summary>
        public static List<PPP_PCB_PATHWAY> GetAllPATHWAYRecords(this PPP_PCB message)
        {
            return message.GetAllRecords<PPP_PCB_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Get SFT Records from PMU_B03
        /// </summary>
        public static IEnumerable GetSFTRecords(this PMU_B03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PMU_B03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PMU_B03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from PGL_PC6
        /// </summary>
        public static IEnumerable GetSFTRecords(this PGL_PC6 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PGL_PC6
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PGL_PC6 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get GOAL Records from PGL_PC6
        /// </summary>
        public static IEnumerable GetGOALRecords(this PGL_PC6 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PGL_PC6
        /// </summary>
        public static List<PGL_PC6_GOAL> GetAllGOALRecords(this PGL_PC6 message)
        {
            return message.GetAllRecords<PGL_PC6_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get SFT Records from OUL_R24
        /// </summary>
        public static IEnumerable GetSFTRecords(this OUL_R24 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OUL_R24
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OUL_R24 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ORDER Records from OUL_R24
        /// </summary>
        public static IEnumerable GetORDERRecords(this OUL_R24 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OUL_R24
        /// </summary>
        public static List<OUL_R24_ORDER> GetAllORDERRecords(this OUL_R24 message)
        {
            return message.GetAllRecords<OUL_R24_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from OSQ_Q06
        /// </summary>
        public static IEnumerable GetSFTRecords(this OSQ_Q06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OSQ_Q06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OSQ_Q06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from BRT_O32
        /// </summary>
        public static IEnumerable GetERRRecords(this BRT_O32 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from BRT_O32
        /// </summary>
        public static List<ERR> GetAllERRRecords(this BRT_O32 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from BRT_O32
        /// </summary>
        public static IEnumerable GetSFTRecords(this BRT_O32 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BRT_O32
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BRT_O32 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from BRT_O32
        /// </summary>
        public static IEnumerable GetNTERecords(this BRT_O32 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BRT_O32
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BRT_O32 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from ADT_A38
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A38 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A38
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A38 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A38
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A38 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A38
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A38 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A38
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A38 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A38
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A38 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A38
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A38 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A38
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A38 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get SFT Records from ADT_A16
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A16 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A16
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A16 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A16
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A16 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A16
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A16 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NK1 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A16
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A16 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A16
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A16 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A16
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A16 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A16
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A16 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A16
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A16 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A16
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A16 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A16
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A16 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A16
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A16 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get SFT Records from ADT_A05
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A05
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A05 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A05
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A05 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NK1 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A05
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A05 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A05
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A05 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A05
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A05 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A05
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A05 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A05
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A05 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A05
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A05 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A05
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A05 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A05
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A05 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get SFT Records from VXQ_V01
        /// </summary>
        public static IEnumerable GetSFTRecords(this VXQ_V01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from VXQ_V01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this VXQ_V01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from RSP_K25
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K25 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K25
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K25 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from RSP_K25
        /// </summary>
        public static IEnumerable GetERRRecords(this RSP_K25 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RSP_K25
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RSP_K25 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get STAFF Records from RSP_K25
        /// </summary>
        public static IEnumerable GetSTAFFRecords(this RSP_K25 message)
        {
            object[] result = message.GetRecords("STAFFRepetitionsUsed", "GetSTAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STAFF Records from RSP_K25
        /// </summary>
        public static List<RSP_K25_STAFF> GetAllSTAFFRecords(this RSP_K25 message)
        {
            return message.GetAllRecords<RSP_K25_STAFF>("STAFFRepetitionsUsed", "GetSTAFF");
        }

        /// <summary>
        /// Get SFT Records from QBP_Qnn
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_Qnn message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_Qnn
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_Qnn message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from QBP_Q11
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_Q11 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_Q11
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_Q11 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from OUL_R23
        /// </summary>
        public static IEnumerable GetSFTRecords(this OUL_R23 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OUL_R23
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OUL_R23 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI Records from OUL_R23
        /// </summary>
        public static IEnumerable GetSPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTIRecords(this OUL_R23 message)
        {
            object[] result = message.GetRecords("SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTIRepetitionsUsed", "GetSPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI Records from OUL_R23
        /// </summary>
        public static List<OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI> GetAllSPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTIRecords(this OUL_R23 message)
        {
            return message.GetAllRecords<OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI>("SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTIRepetitionsUsed", "GetSPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI");
        }

        /// <summary>
        /// Get ERR Records from ORS_O06
        /// </summary>
        public static IEnumerable GetERRRecords(this ORS_O06 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORS_O06
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORS_O06 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORS_O06
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORS_O06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORS_O06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORS_O06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORS_O06
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O06 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O06
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O06 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OMB_O27
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMB_O27 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMB_O27
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMB_O27 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMB_O27
        /// </summary>
        public static IEnumerable GetNTERecords(this OMB_O27 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMB_O27
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMB_O27 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OMB_O27
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMB_O27 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMB_O27
        /// </summary>
        public static List<OMB_O27_ORDER> GetAllORDERRecords(this OMB_O27 message)
        {
            return message.GetAllRecords<OMB_O27_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFN_M09
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_TEST_CATEGORICAL Records from MFN_M09
        /// </summary>
        public static IEnumerable GetMF_TEST_CATEGORICALRecords(this MFN_M09 message)
        {
            object[] result = message.GetRecords("MF_TEST_CATEGORICALRepetitionsUsed", "GetMF_TEST_CATEGORICAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_TEST_CATEGORICAL Records from MFN_M09
        /// </summary>
        public static List<MFN_M09_MF_TEST_CATEGORICAL> GetAllMF_TEST_CATEGORICALRecords(this MFN_M09 message)
        {
            return message.GetAllRecords<MFN_M09_MF_TEST_CATEGORICAL>("MF_TEST_CATEGORICALRepetitionsUsed", "GetMF_TEST_CATEGORICAL");
        }

        /// <summary>
        /// Get SFT Records from ADT_A37
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A37 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A37
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A37 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A37
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A37 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A37
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A37 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get DB12 Records from ADT_A37
        /// </summary>
        public static IEnumerable GetDB12Records(this ADT_A37 message)
        {
            object[] result = message.GetRecords("DB12RepetitionsUsed", "GetDB12");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB12 Records from ADT_A37
        /// </summary>
        public static List<DB1> GetAllDB12Records(this ADT_A37 message)
        {
            return message.GetAllRecords<DB1>("DB12RepetitionsUsed", "GetDB12");
        }

        /// <summary>
        /// Get SFT Records from ADT_A15
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A15 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A15
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A15 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A15
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A15 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A15
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A15 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A15
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A15 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A15
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A15 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A15
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A15 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A15
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A15 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A15
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A15 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A15
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A15 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A15
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A15 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A15
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A15 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get SFT Records from TBR_R08
        /// </summary>
        public static IEnumerable GetSFTRecords(this TBR_R08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from TBR_R08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this TBR_R08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get RDT Records from TBR_R08
        /// </summary>
        public static IEnumerable GetRDTRecords(this TBR_R08 message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from TBR_R08
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this TBR_R08 message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Get NTE Records from SRM_S01
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S01
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S01 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S01
        /// </summary>
        public static List<SRM_S01_RESOURCES> GetAllRESOURCESRecords(this SRM_S01 message)
        {
            return message.GetAllRecords<SRM_S01_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Get SFT Records from RQQ_Q09
        /// </summary>
        public static IEnumerable GetSFTRecords(this RQQ_Q09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RQQ_Q09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RQQ_Q09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from RPA_I08
        /// </summary>
        public static IEnumerable GetSFTRecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RPA_I08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RPA_I08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RPA_I08
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPA_I08
        /// </summary>
        public static List<RPA_I08_PROVIDER> GetAllPROVIDERRecords(this RPA_I08 message)
        {
            return message.GetAllRecords<RPA_I08_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RPA_I08
        /// </summary>
        public static IEnumerable GetNK1Records(this RPA_I08 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RPA_I08
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RPA_I08 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get GT1 Records from RPA_I08
        /// </summary>
        public static IEnumerable GetGT1Records(this RPA_I08 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPA_I08
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPA_I08 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get DG1 Records from RPA_I08
        /// </summary>
        public static IEnumerable GetDG1Records(this RPA_I08 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RPA_I08
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RPA_I08 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get DRG Records from RPA_I08
        /// </summary>
        public static IEnumerable GetDRGRecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RPA_I08
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RPA_I08 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Get AL1 Records from RPA_I08
        /// </summary>
        public static IEnumerable GetAL1Records(this RPA_I08 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RPA_I08
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RPA_I08 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get PROCEDURE Records from RPA_I08
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RPA_I08
        /// </summary>
        public static List<RPA_I08_PROCEDURE> GetAllPROCEDURERecords(this RPA_I08 message)
        {
            return message.GetAllRecords<RPA_I08_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Get NTE Records from RPA_I08
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from RDE_O11
        /// </summary>
        public static IEnumerable GetSFTRecords(this RDE_O11 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RDE_O11
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RDE_O11 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RDE_O11
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RDE_O11
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDE_O11 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDE_O11
        /// </summary>
        public static List<RDE_O11_ORDER> GetAllORDERRecords(this RDE_O11 message)
        {
            return message.GetAllRecords<RDE_O11_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from QBP_Q21
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_Q21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_Q21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_Q21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from PMU_B01
        /// </summary>
        public static IEnumerable GetSFTRecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PMU_B01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PMU_B01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PRA Records from PMU_B01
        /// </summary>
        public static IEnumerable GetPRARecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("PRARepetitionsUsed", "GetPRA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRA Records from PMU_B01
        /// </summary>
        public static List<PRA> GetAllPRARecords(this PMU_B01 message)
        {
            return message.GetAllRecords<PRA>("PRARepetitionsUsed", "GetPRA");
        }

        /// <summary>
        /// Get ORG Records from PMU_B01
        /// </summary>
        public static IEnumerable GetORGRecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("ORGRepetitionsUsed", "GetORG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORG Records from PMU_B01
        /// </summary>
        public static List<ORG> GetAllORGRecords(this PMU_B01 message)
        {
            return message.GetAllRecords<ORG>("ORGRepetitionsUsed", "GetORG");
        }

        /// <summary>
        /// Get AFF Records from PMU_B01
        /// </summary>
        public static IEnumerable GetAFFRecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("AFFRepetitionsUsed", "GetAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AFF Records from PMU_B01
        /// </summary>
        public static List<AFF> GetAllAFFRecords(this PMU_B01 message)
        {
            return message.GetAllRecords<AFF>("AFFRepetitionsUsed", "GetAFF");
        }

        /// <summary>
        /// Get LAN Records from PMU_B01
        /// </summary>
        public static IEnumerable GetLANRecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("LANRepetitionsUsed", "GetLAN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LAN Records from PMU_B01
        /// </summary>
        public static List<LAN> GetAllLANRecords(this PMU_B01 message)
        {
            return message.GetAllRecords<LAN>("LANRepetitionsUsed", "GetLAN");
        }

        /// <summary>
        /// Get EDU Records from PMU_B01
        /// </summary>
        public static IEnumerable GetEDURecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("EDURepetitionsUsed", "GetEDU");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EDU Records from PMU_B01
        /// </summary>
        public static List<EDU> GetAllEDURecords(this PMU_B01 message)
        {
            return message.GetAllRecords<EDU>("EDURepetitionsUsed", "GetEDU");
        }

        /// <summary>
        /// Get CER Records from PMU_B01
        /// </summary>
        public static IEnumerable GetCERRecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("CERRepetitionsUsed", "GetCER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CER Records from PMU_B01
        /// </summary>
        public static List<CER> GetAllCERRecords(this PMU_B01 message)
        {
            return message.GetAllRecords<CER>("CERRepetitionsUsed", "GetCER");
        }

        /// <summary>
        /// Get SFT Records from OUL_R22
        /// </summary>
        public static IEnumerable GetSFTRecords(this OUL_R22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OUL_R22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OUL_R22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SPECIMEN Records from OUL_R22
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this OUL_R22 message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from OUL_R22
        /// </summary>
        public static List<OUL_R22_SPECIMEN> GetAllSPECIMENRecords(this OUL_R22 message)
        {
            return message.GetAllRecords<OUL_R22_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Get SFT Records from ORU_R30
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORU_R30 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORU_R30
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORU_R30 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORU_R30
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R30 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R30
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R30 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORU_R30
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORU_R30 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORU_R30
        /// </summary>
        public static List<ORU_R30_OBSERVATION> GetAllOBSERVATIONRecords(this ORU_R30 message)
        {
            return message.GetAllRecords<ORU_R30_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get ERR Records from ORN_O08
        /// </summary>
        public static IEnumerable GetERRRecords(this ORN_O08 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORN_O08
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORN_O08 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORN_O08
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORN_O08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORN_O08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORN_O08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORN_O08
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O08 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O08
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O08 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OMS_O05
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMS_O05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMS_O05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMS_O05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMS_O05
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OMS_O05
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMS_O05 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMS_O05
        /// </summary>
        public static List<OMS_O05_ORDER> GetAllORDERRecords(this OMS_O05 message)
        {
            return message.GetAllRecords<OMS_O05_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFN_M08
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_TEST_NUMERIC Records from MFN_M08
        /// </summary>
        public static IEnumerable GetMF_TEST_NUMERICRecords(this MFN_M08 message)
        {
            object[] result = message.GetRecords("MF_TEST_NUMERICRepetitionsUsed", "GetMF_TEST_NUMERIC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_TEST_NUMERIC Records from MFN_M08
        /// </summary>
        public static List<MFN_M08_MF_TEST_NUMERIC> GetAllMF_TEST_NUMERICRecords(this MFN_M08 message)
        {
            return message.GetAllRecords<MFN_M08_MF_TEST_NUMERIC>("MF_TEST_NUMERICRepetitionsUsed", "GetMF_TEST_NUMERIC");
        }

        /// <summary>
        /// Get SFT Records from MDM_T02
        /// </summary>
        public static IEnumerable GetSFTRecords(this MDM_T02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MDM_T02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MDM_T02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get OBXNTE Records from MDM_T02
        /// </summary>
        public static IEnumerable GetOBXNTERecords(this MDM_T02 message)
        {
            object[] result = message.GetRecords("OBXNTERepetitionsUsed", "GetOBXNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBXNTE Records from MDM_T02
        /// </summary>
        public static List<MDM_T02_OBXNTE> GetAllOBXNTERecords(this MDM_T02 message)
        {
            return message.GetAllRecords<MDM_T02_OBXNTE>("OBXNTERepetitionsUsed", "GetOBXNTE");
        }

        /// <summary>
        /// Get SFT Records from ADT_A03
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A03
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A03 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A03
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A03 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NK1 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A03
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A03 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A03
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A03 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A03
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A03 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get AL1 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A03
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A03 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A03
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A03 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A03
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A03 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A03
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A03 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get GT1 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A03
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A03 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get SFT Records from ADR_A19
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADR_A19 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADR_A19
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADR_A19 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from ADR_A19
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this ADR_A19 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from ADR_A19
        /// </summary>
        public static List<ADR_A19_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this ADR_A19 message)
        {
            return message.GetAllRecords<ADR_A19_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Get SFT Records from RSP_K23
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K23 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K23
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K23 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from RQI_I01
        /// </summary>
        public static IEnumerable GetSFTRecords(this RQI_I01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RQI_I01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RQI_I01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RQI_I01
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQI_I01 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQI_I01
        /// </summary>
        public static List<RQI_I01_PROVIDER> GetAllPROVIDERRecords(this RQI_I01 message)
        {
            return message.GetAllRecords<RQI_I01_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RQI_I01
        /// </summary>
        public static IEnumerable GetNK1Records(this RQI_I01 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQI_I01
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQI_I01 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get NTE Records from RQI_I01
        /// </summary>
        public static IEnumerable GetNTERecords(this RQI_I01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQI_I01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQI_I01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ERR Records from ROR_ROR
        /// </summary>
        public static IEnumerable GetERRRecords(this ROR_ROR message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ROR_ROR
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ROR_ROR message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ROR_ROR
        /// </summary>
        public static IEnumerable GetSFTRecords(this ROR_ROR message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ROR_ROR
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ROR_ROR message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DEFINITION Records from ROR_ROR
        /// </summary>
        public static IEnumerable GetDEFINITIONRecords(this ROR_ROR message)
        {
            object[] result = message.GetRecords("DEFINITIONRepetitionsUsed", "GetDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DEFINITION Records from ROR_ROR
        /// </summary>
        public static List<ROR_ROR_DEFINITION> GetAllDEFINITIONRecords(this ROR_ROR message)
        {
            return message.GetAllRecords<ROR_ROR_DEFINITION>("DEFINITIONRepetitionsUsed", "GetDEFINITION");
        }

        /// <summary>
        /// Get ERR Records from RAR_RAR
        /// </summary>
        public static IEnumerable GetERRRecords(this RAR_RAR message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RAR_RAR
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RAR_RAR message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RAR_RAR
        /// </summary>
        public static IEnumerable GetSFTRecords(this RAR_RAR message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RAR_RAR
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RAR_RAR message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DEFINITION Records from RAR_RAR
        /// </summary>
        public static IEnumerable GetDEFINITIONRecords(this RAR_RAR message)
        {
            object[] result = message.GetRecords("DEFINITIONRepetitionsUsed", "GetDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DEFINITION Records from RAR_RAR
        /// </summary>
        public static List<RAR_RAR_DEFINITION> GetAllDEFINITIONRecords(this RAR_RAR message)
        {
            return message.GetAllRecords<RAR_RAR_DEFINITION>("DEFINITIONRepetitionsUsed", "GetDEFINITION");
        }

        /// <summary>
        /// Get SFT Records from OUL_R21
        /// </summary>
        public static IEnumerable GetSFTRecords(this OUL_R21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OUL_R21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OUL_R21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from OUL_R21
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this OUL_R21 message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from OUL_R21
        /// </summary>
        public static List<OUL_R21_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this OUL_R21 message)
        {
            return message.GetAllRecords<OUL_R21_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from ORM_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORM_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORM_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORM_O01
        /// </summary>
        public static List<ORM_O01_ORDER> GetAllORDERRecords(this ORM_O01 message)
        {
            return message.GetAllRecords<ORM_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFN_M07
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_CLIN_STUDY_SCHED Records from MFN_M07
        /// </summary>
        public static IEnumerable GetMF_CLIN_STUDY_SCHEDRecords(this MFN_M07 message)
        {
            object[] result = message.GetRecords("MF_CLIN_STUDY_SCHEDRepetitionsUsed", "GetMF_CLIN_STUDY_SCHED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_CLIN_STUDY_SCHED Records from MFN_M07
        /// </summary>
        public static List<MFN_M07_MF_CLIN_STUDY_SCHED> GetAllMF_CLIN_STUDY_SCHEDRecords(this MFN_M07 message)
        {
            return message.GetAllRecords<MFN_M07_MF_CLIN_STUDY_SCHED>("MF_CLIN_STUDY_SCHEDRepetitionsUsed", "GetMF_CLIN_STUDY_SCHED");
        }

        /// <summary>
        /// Get SFT Records from MDM_T01
        /// </summary>
        public static IEnumerable GetSFTRecords(this MDM_T01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MDM_T01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MDM_T01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A24
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A24 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A24
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A24 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A24
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A24 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A24
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A24 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get DB12 Records from ADT_A24
        /// </summary>
        public static IEnumerable GetDB12Records(this ADT_A24 message)
        {
            object[] result = message.GetRecords("DB12RepetitionsUsed", "GetDB12");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB12 Records from ADT_A24
        /// </summary>
        public static List<DB1> GetAllDB12Records(this ADT_A24 message)
        {
            return message.GetAllRecords<DB1>("DB12RepetitionsUsed", "GetDB12");
        }

        /// <summary>
        /// Get SFT Records from ADT_A02
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A02
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A02 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A02
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A02 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A02
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A02 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A02
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A02 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A02
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A02 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A02
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A02 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A02
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A02 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A02
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A02 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get SFT Records from RSP_K11
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K11 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K11
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K11 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from RRE_O12
        /// </summary>
        public static IEnumerable GetERRRecords(this RRE_O12 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RRE_O12
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RRE_O12 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RRE_O12
        /// </summary>
        public static IEnumerable GetSFTRecords(this RRE_O12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RRE_O12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RRE_O12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RRE_O12
        /// </summary>
        public static IEnumerable GetNTERecords(this RRE_O12 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRE_O12
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRE_O12 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from RPI_I04
        /// </summary>
        public static IEnumerable GetSFTRecords(this RPI_I04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RPI_I04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RPI_I04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RPI_I04
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPI_I04 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPI_I04
        /// </summary>
        public static List<RPI_I04_PROVIDER> GetAllPROVIDERRecords(this RPI_I04 message)
        {
            return message.GetAllRecords<RPI_I04_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RPI_I04
        /// </summary>
        public static IEnumerable GetNK1Records(this RPI_I04 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RPI_I04
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RPI_I04 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get NTE Records from RPI_I04
        /// </summary>
        public static IEnumerable GetNTERecords(this RPI_I04 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPI_I04
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPI_I04 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from RDY_K15
        /// </summary>
        public static IEnumerable GetSFTRecords(this RDY_K15 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RDY_K15
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RDY_K15 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DSP Records from RDY_K15
        /// </summary>
        public static IEnumerable GetDSPRecords(this RDY_K15 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from RDY_K15
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this RDY_K15 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from PPV_PCA
        /// </summary>
        public static IEnumerable GetSFTRecords(this PPV_PCA message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PPV_PCA
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PPV_PCA message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from PPV_PCA
        /// </summary>
        public static IEnumerable GetERRRecords(this PPV_PCA message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from PPV_PCA
        /// </summary>
        public static List<ERR> GetAllERRRecords(this PPV_PCA message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get PATIENT Records from PPV_PCA
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this PPV_PCA message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from PPV_PCA
        /// </summary>
        public static List<PPV_PCA_PATIENT> GetAllPATIENTRecords(this PPV_PCA message)
        {
            return message.GetAllRecords<PPV_PCA_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get ERR Records from ORG_O20
        /// </summary>
        public static IEnumerable GetERRRecords(this ORG_O20 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORG_O20
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORG_O20 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORG_O20
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORG_O20 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORG_O20
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORG_O20 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORG_O20
        /// </summary>
        public static IEnumerable GetNTERecords(this ORG_O20 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORG_O20
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORG_O20 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OMN_O07
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMN_O07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMN_O07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMN_O07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMN_O07
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OMN_O07
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMN_O07 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMN_O07
        /// </summary>
        public static List<OMN_O07_ORDER> GetAllORDERRecords(this OMN_O07 message)
        {
            return message.GetAllRecords<OMN_O07_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFN_M06
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_CLIN_STUDY Records from MFN_M06
        /// </summary>
        public static IEnumerable GetMF_CLIN_STUDYRecords(this MFN_M06 message)
        {
            object[] result = message.GetRecords("MF_CLIN_STUDYRepetitionsUsed", "GetMF_CLIN_STUDY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_CLIN_STUDY Records from MFN_M06
        /// </summary>
        public static List<MFN_M06_MF_CLIN_STUDY> GetAllMF_CLIN_STUDYRecords(this MFN_M06 message)
        {
            return message.GetAllRecords<MFN_M06_MF_CLIN_STUDY>("MF_CLIN_STUDYRepetitionsUsed", "GetMF_CLIN_STUDY");
        }

        /// <summary>
        /// Get SFT Records from EAN_U09
        /// </summary>
        public static IEnumerable GetSFTRecords(this EAN_U09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EAN_U09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EAN_U09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NOTIFICATION Records from EAN_U09
        /// </summary>
        public static IEnumerable GetNOTIFICATIONRecords(this EAN_U09 message)
        {
            object[] result = message.GetRecords("NOTIFICATIONRepetitionsUsed", "GetNOTIFICATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NOTIFICATION Records from EAN_U09
        /// </summary>
        public static List<EAN_U09_NOTIFICATION> GetAllNOTIFICATIONRecords(this EAN_U09 message)
        {
            return message.GetAllRecords<EAN_U09_NOTIFICATION>("NOTIFICATIONRepetitionsUsed", "GetNOTIFICATION");
        }

        /// <summary>
        /// Get SFT Records from BAR_P06
        /// </summary>
        public static IEnumerable GetSFTRecords(this BAR_P06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BAR_P06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BAR_P06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from BAR_P06
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this BAR_P06 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from BAR_P06
        /// </summary>
        public static List<BAR_P06_PATIENT> GetAllPATIENTRecords(this BAR_P06 message)
        {
            return message.GetAllRecords<BAR_P06_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A45
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A45 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A45
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A45 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MERGE_INFO Records from ADT_A45
        /// </summary>
        public static IEnumerable GetMERGE_INFORecords(this ADT_A45 message)
        {
            object[] result = message.GetRecords("MERGE_INFORepetitionsUsed", "GetMERGE_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MERGE_INFO Records from ADT_A45
        /// </summary>
        public static List<ADT_A45_MERGE_INFO> GetAllMERGE_INFORecords(this ADT_A45 message)
        {
            return message.GetAllRecords<ADT_A45_MERGE_INFO>("MERGE_INFORepetitionsUsed", "GetMERGE_INFO");
        }

        /// <summary>
        /// Get SFT Records from ADT_A12
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A12
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A12 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A12
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A12 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A12
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A12 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A12
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A12 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get SFT Records from ADT_A01
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A01
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A01 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A01
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A01 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NK1 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A01
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A01 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A01
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A01 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A01
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A01 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A01
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A01 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A01
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A01 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A01
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A01 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A01
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A01 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A01
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A01 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get SFT Records from VXU_V04
        /// </summary>
        public static IEnumerable GetSFTRecords(this VXU_V04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from VXU_V04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this VXU_V04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NK1 Records from VXU_V04
        /// </summary>
        public static IEnumerable GetNK1Records(this VXU_V04 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from VXU_V04
        /// </summary>
        public static List<NK1> GetAllNK1Records(this VXU_V04 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get GT1 Records from VXU_V04
        /// </summary>
        public static IEnumerable GetGT1Records(this VXU_V04 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from VXU_V04
        /// </summary>
        public static List<GT1> GetAllGT1Records(this VXU_V04 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get SFT Records from VXR_V03
        /// </summary>
        public static IEnumerable GetSFTRecords(this VXR_V03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from VXR_V03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this VXR_V03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NK1 Records from VXR_V03
        /// </summary>
        public static IEnumerable GetNK1Records(this VXR_V03 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from VXR_V03
        /// </summary>
        public static List<NK1> GetAllNK1Records(this VXR_V03 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get GT1 Records from VXR_V03
        /// </summary>
        public static IEnumerable GetGT1Records(this VXR_V03 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from VXR_V03
        /// </summary>
        public static List<GT1> GetAllGT1Records(this VXR_V03 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get SFT Records from TCU_U10
        /// </summary>
        public static IEnumerable GetSFTRecords(this TCU_U10 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from TCU_U10
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this TCU_U10 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get TEST_CONFIGURATION Records from TCU_U10
        /// </summary>
        public static IEnumerable GetTEST_CONFIGURATIONRecords(this TCU_U10 message)
        {
            object[] result = message.GetRecords("TEST_CONFIGURATIONRepetitionsUsed", "GetTEST_CONFIGURATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TEST_CONFIGURATION Records from TCU_U10
        /// </summary>
        public static List<TCU_U10_TEST_CONFIGURATION> GetAllTEST_CONFIGURATIONRecords(this TCU_U10 message)
        {
            return message.GetAllRecords<TCU_U10_TEST_CONFIGURATION>("TEST_CONFIGURATIONRepetitionsUsed", "GetTEST_CONFIGURATION");
        }

        /// <summary>
        /// Get ERR Records from RTB_Z74
        /// </summary>
        public static IEnumerable GetERRRecords(this RTB_Z74 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RTB_Z74
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RTB_Z74 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RTB_Z74
        /// </summary>
        public static IEnumerable GetSFTRecords(this RTB_Z74 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RTB_Z74
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RTB_Z74 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from RSP_K21
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from RGR_RGR
        /// </summary>
        public static IEnumerable GetERRRecords(this RGR_RGR message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RGR_RGR
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RGR_RGR message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RGR_RGR
        /// </summary>
        public static IEnumerable GetSFTRecords(this RGR_RGR message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RGR_RGR
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RGR_RGR message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DEFINITION Records from RGR_RGR
        /// </summary>
        public static IEnumerable GetDEFINITIONRecords(this RGR_RGR message)
        {
            object[] result = message.GetRecords("DEFINITIONRepetitionsUsed", "GetDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DEFINITION Records from RGR_RGR
        /// </summary>
        public static List<RGR_RGR_DEFINITION> GetAllDEFINITIONRecords(this RGR_RGR message)
        {
            return message.GetAllRecords<RGR_RGR_DEFINITION>("DEFINITIONRepetitionsUsed", "GetDEFINITION");
        }

        /// <summary>
        /// Get SFT Records from QSB_Q16
        /// </summary>
        public static IEnumerable GetSFTRecords(this QSB_Q16 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QSB_Q16
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QSB_Q16 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from MFN_M05
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_LOCATION Records from MFN_M05
        /// </summary>
        public static IEnumerable GetMF_LOCATIONRecords(this MFN_M05 message)
        {
            object[] result = message.GetRecords("MF_LOCATIONRepetitionsUsed", "GetMF_LOCATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_LOCATION Records from MFN_M05
        /// </summary>
        public static List<MFN_M05_MF_LOCATION> GetAllMF_LOCATIONRecords(this MFN_M05 message)
        {
            return message.GetAllRecords<MFN_M05_MF_LOCATION>("MF_LOCATIONRepetitionsUsed", "GetMF_LOCATION");
        }

        /// <summary>
        /// Get SFT Records from DSR_Q03
        /// </summary>
        public static IEnumerable GetSFTRecords(this DSR_Q03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from DSR_Q03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this DSR_Q03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DSP Records from DSR_Q03
        /// </summary>
        public static IEnumerable GetDSPRecords(this DSR_Q03 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from DSR_Q03
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this DSR_Q03 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from BTS_O31
        /// </summary>
        public static IEnumerable GetSFTRecords(this BTS_O31 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BTS_O31
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BTS_O31 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from BTS_O31
        /// </summary>
        public static IEnumerable GetNTERecords(this BTS_O31 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BTS_O31
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BTS_O31 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from BTS_O31
        /// </summary>
        public static IEnumerable GetORDERRecords(this BTS_O31 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from BTS_O31
        /// </summary>
        public static List<BTS_O31_ORDER> GetAllORDERRecords(this BTS_O31 message)
        {
            return message.GetAllRecords<BTS_O31_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from BAR_P05
        /// </summary>
        public static IEnumerable GetSFTRecords(this BAR_P05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BAR_P05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BAR_P05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from BAR_P05
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get VISIT Records from BAR_P05
        /// </summary>
        public static IEnumerable GetVISITRecords(this BAR_P05 message)
        {
            object[] result = message.GetRecords("VISITRepetitionsUsed", "GetVISIT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VISIT Records from BAR_P05
        /// </summary>
        public static List<BAR_P05_VISIT> GetAllVISITRecords(this BAR_P05 message)
        {
            return message.GetAllRecords<BAR_P05_VISIT>("VISITRepetitionsUsed", "GetVISIT");
        }

        /// <summary>
        /// Get SFT Records from RSP_Z88
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_Z88 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_Z88
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_Z88 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from RSP_Z88
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this RSP_Z88 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from RSP_Z88
        /// </summary>
        public static List<RSP_Z88_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this RSP_Z88 message)
        {
            return message.GetAllRecords<RSP_Z88_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Get ERR Records from RSP_K31
        /// </summary>
        public static IEnumerable GetERRRecords(this RSP_K31 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RSP_K31
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RSP_K31 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RSP_K31
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K31 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K31
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K31 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get RESPONSE Records from RSP_K31
        /// </summary>
        public static IEnumerable GetRESPONSERecords(this RSP_K31 message)
        {
            object[] result = message.GetRecords("RESPONSERepetitionsUsed", "GetRESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESPONSE Records from RSP_K31
        /// </summary>
        public static List<RSP_K31_RESPONSE> GetAllRESPONSERecords(this RSP_K31 message)
        {
            return message.GetAllRecords<RSP_K31_RESPONSE>("RESPONSERepetitionsUsed", "GetRESPONSE");
        }

        /// <summary>
        /// Get SFT Records from RGV_O15
        /// </summary>
        public static IEnumerable GetSFTRecords(this RGV_O15 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RGV_O15
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RGV_O15 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RGV_O15
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RGV_O15
        /// </summary>
        public static IEnumerable GetORDERRecords(this RGV_O15 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RGV_O15
        /// </summary>
        public static List<RGV_O15_ORDER> GetAllORDERRecords(this RGV_O15 message)
        {
            return message.GetAllRecords<RGV_O15_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from RAS_O17
        /// </summary>
        public static IEnumerable GetSFTRecords(this RAS_O17 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RAS_O17
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RAS_O17 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RAS_O17
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RAS_O17
        /// </summary>
        public static IEnumerable GetORDERRecords(this RAS_O17 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RAS_O17
        /// </summary>
        public static List<RAS_O17_ORDER> GetAllORDERRecords(this RAS_O17 message)
        {
            return message.GetAllRecords<RAS_O17_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from QVR_Q17
        /// </summary>
        public static IEnumerable GetSFTRecords(this QVR_Q17 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QVR_Q17
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QVR_Q17 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from OSR_Q06
        /// </summary>
        public static IEnumerable GetERRRecords(this OSR_Q06 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from OSR_Q06
        /// </summary>
        public static List<ERR> GetAllERRRecords(this OSR_Q06 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from OSR_Q06
        /// </summary>
        public static IEnumerable GetSFTRecords(this OSR_Q06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OSR_Q06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OSR_Q06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ERR Records from ORP_O10
        /// </summary>
        public static IEnumerable GetERRRecords(this ORP_O10 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORP_O10
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORP_O10 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORP_O10
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORP_O10 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORP_O10
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORP_O10 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORP_O10
        /// </summary>
        public static IEnumerable GetNTERecords(this ORP_O10 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORP_O10
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORP_O10 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from ORF_R04
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORF_R04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORF_R04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORF_R04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI Records from ORF_R04
        /// </summary>
        public static IEnumerable GetPIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTIRecords(this ORF_R04 message)
        {
            object[] result = message.GetRecords("PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTIRepetitionsUsed", "GetPIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI Records from ORF_R04
        /// </summary>
        public static List<ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI> GetAllPIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTIRecords(this ORF_R04 message)
        {
            return message.GetAllRecords<ORF_R04_PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI>("PIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTIRepetitionsUsed", "GetPIDNTEORCOBRNTETQ1TQ2CTDOBXNTECTI");
        }

        /// <summary>
        /// Get ERR Records from ORF_R04
        /// </summary>
        public static IEnumerable GetERRRecords(this ORF_R04 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORF_R04
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORF_R04 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from MFN_M15
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M15 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M15
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M15 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_INV_ITEM Records from MFN_M15
        /// </summary>
        public static IEnumerable GetMF_INV_ITEMRecords(this MFN_M15 message)
        {
            object[] result = message.GetRecords("MF_INV_ITEMRepetitionsUsed", "GetMF_INV_ITEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_INV_ITEM Records from MFN_M15
        /// </summary>
        public static List<MFN_M15_MF_INV_ITEM> GetAllMF_INV_ITEMRecords(this MFN_M15 message)
        {
            return message.GetAllRecords<MFN_M15_MF_INV_ITEM>("MF_INV_ITEMRepetitionsUsed", "GetMF_INV_ITEM");
        }

        /// <summary>
        /// Get SFT Records from MFN_M04
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_CDM Records from MFN_M04
        /// </summary>
        public static IEnumerable GetMF_CDMRecords(this MFN_M04 message)
        {
            object[] result = message.GetRecords("MF_CDMRepetitionsUsed", "GetMF_CDM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_CDM Records from MFN_M04
        /// </summary>
        public static List<MFN_M04_MF_CDM> GetAllMF_CDMRecords(this MFN_M04 message)
        {
            return message.GetAllRecords<MFN_M04_MF_CDM>("MF_CDMRepetitionsUsed", "GetMF_CDM");
        }

        /// <summary>
        /// Get SFT Records from INR_U06
        /// </summary>
        public static IEnumerable GetSFTRecords(this INR_U06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from INR_U06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this INR_U06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get INV Records from INR_U06
        /// </summary>
        public static IEnumerable GetINVRecords(this INR_U06 message)
        {
            object[] result = message.GetRecords("INVRepetitionsUsed", "GetINV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INV Records from INR_U06
        /// </summary>
        public static List<INV> GetAllINVRecords(this INR_U06 message)
        {
            return message.GetAllRecords<INV>("INVRepetitionsUsed", "GetINV");
        }

        /// <summary>
        /// Get SFT Records from EDR_R07
        /// </summary>
        public static IEnumerable GetSFTRecords(this EDR_R07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EDR_R07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EDR_R07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DSP Records from EDR_R07
        /// </summary>
        public static IEnumerable GetDSPRecords(this EDR_R07 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from EDR_R07
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this EDR_R07 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from CRM_C01
        /// </summary>
        public static IEnumerable GetSFTRecords(this CRM_C01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CRM_C01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CRM_C01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C01
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C01 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C01
        /// </summary>
        public static List<CRM_C01_PATIENT> GetAllPATIENTRecords(this CRM_C01 message)
        {
            return message.GetAllRecords<CRM_C01_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A54
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A54 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A54
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A54 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A54
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A54 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A54
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A54 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL2 Records from ADT_A54
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A54 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A54
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A54 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get SFT Records from ADT_A43
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A43 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A43
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A43 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from ADT_A43
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this ADT_A43 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from ADT_A43
        /// </summary>
        public static List<ADT_A43_PATIENT> GetAllPATIENTRecords(this ADT_A43 message)
        {
            return message.GetAllRecords<ADT_A43_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A21
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A21
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A21 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A21
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A21 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A21
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A21 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A21
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A21 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get SFT Records from VQQ_Q07
        /// </summary>
        public static IEnumerable GetSFTRecords(this VQQ_Q07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from VQQ_Q07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this VQQ_Q07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from UDM_Q05
        /// </summary>
        public static IEnumerable GetSFTRecords(this UDM_Q05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from UDM_Q05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this UDM_Q05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DSP Records from UDM_Q05
        /// </summary>
        public static IEnumerable GetDSPRecords(this UDM_Q05 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from UDM_Q05
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this UDM_Q05 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from SSR_U04
        /// </summary>
        public static IEnumerable GetSFTRecords(this SSR_U04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from SSR_U04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this SSR_U04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SPECIMEN_CONTAINER Records from SSR_U04
        /// </summary>
        public static IEnumerable GetSPECIMEN_CONTAINERRecords(this SSR_U04 message)
        {
            object[] result = message.GetRecords("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN_CONTAINER Records from SSR_U04
        /// </summary>
        public static List<SSR_U04_SPECIMEN_CONTAINER> GetAllSPECIMEN_CONTAINERRecords(this SSR_U04 message)
        {
            return message.GetAllRecords<SSR_U04_SPECIMEN_CONTAINER>("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");
        }

        /// <summary>
        /// Get ERR Records from RRA_O18
        /// </summary>
        public static IEnumerable GetERRRecords(this RRA_O18 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RRA_O18
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RRA_O18 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RRA_O18
        /// </summary>
        public static IEnumerable GetSFTRecords(this RRA_O18 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RRA_O18
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RRA_O18 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RRA_O18
        /// </summary>
        public static IEnumerable GetNTERecords(this RRA_O18 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRA_O18
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRA_O18 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from RPL_I02
        /// </summary>
        public static IEnumerable GetSFTRecords(this RPL_I02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RPL_I02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RPL_I02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RPL_I02
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPL_I02 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPL_I02
        /// </summary>
        public static List<RPL_I02_PROVIDER> GetAllPROVIDERRecords(this RPL_I02 message)
        {
            return message.GetAllRecords<RPL_I02_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NTE Records from RPL_I02
        /// </summary>
        public static IEnumerable GetNTERecords(this RPL_I02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPL_I02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPL_I02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get DSP Records from RPL_I02
        /// </summary>
        public static IEnumerable GetDSPRecords(this RPL_I02 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from RPL_I02
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this RPL_I02 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from RPI_I01
        /// </summary>
        public static IEnumerable GetSFTRecords(this RPI_I01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RPI_I01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RPI_I01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RPI_I01
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPI_I01 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPI_I01
        /// </summary>
        public static List<RPI_I01_PROVIDER> GetAllPROVIDERRecords(this RPI_I01 message)
        {
            return message.GetAllRecords<RPI_I01_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RPI_I01
        /// </summary>
        public static IEnumerable GetNK1Records(this RPI_I01 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RPI_I01
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RPI_I01 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get NTE Records from RPI_I01
        /// </summary>
        public static IEnumerable GetNTERecords(this RPI_I01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPI_I01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPI_I01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from NMQ_N01
        /// </summary>
        public static IEnumerable GetSFTRecords(this NMQ_N01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from NMQ_N01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this NMQ_N01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get CLOCK_AND_STATISTICS Records from NMQ_N01
        /// </summary>
        public static IEnumerable GetCLOCK_AND_STATISTICSRecords(this NMQ_N01 message)
        {
            object[] result = message.GetRecords("CLOCK_AND_STATISTICSRepetitionsUsed", "GetCLOCK_AND_STATISTICS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLOCK_AND_STATISTICS Records from NMQ_N01
        /// </summary>
        public static List<NMQ_N01_CLOCK_AND_STATISTICS> GetAllCLOCK_AND_STATISTICSRecords(this NMQ_N01 message)
        {
            return message.GetAllRecords<NMQ_N01_CLOCK_AND_STATISTICS>("CLOCK_AND_STATISTICSRepetitionsUsed", "GetCLOCK_AND_STATISTICS");
        }

        /// <summary>
        /// Get SFT Records from MFN_M03
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_TEST Records from MFN_M03
        /// </summary>
        public static IEnumerable GetMF_TESTRecords(this MFN_M03 message)
        {
            object[] result = message.GetRecords("MF_TESTRepetitionsUsed", "GetMF_TEST");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_TEST Records from MFN_M03
        /// </summary>
        public static List<MFN_M03_MF_TEST> GetAllMF_TESTRecords(this MFN_M03 message)
        {
            return message.GetAllRecords<MFN_M03_MF_TEST>("MF_TESTRepetitionsUsed", "GetMF_TEST");
        }

        /// <summary>
        /// Get SFT Records from ESR_U02
        /// </summary>
        public static IEnumerable GetSFTRecords(this ESR_U02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ESR_U02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ESR_U02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from EAC_U07
        /// </summary>
        public static IEnumerable GetSFTRecords(this EAC_U07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EAC_U07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EAC_U07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get COMMAND Records from EAC_U07
        /// </summary>
        public static IEnumerable GetCOMMANDRecords(this EAC_U07 message)
        {
            object[] result = message.GetRecords("COMMANDRepetitionsUsed", "GetCOMMAND");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMAND Records from EAC_U07
        /// </summary>
        public static List<EAC_U07_COMMAND> GetAllCOMMANDRecords(this EAC_U07 message)
        {
            return message.GetAllRecords<EAC_U07_COMMAND>("COMMANDRepetitionsUsed", "GetCOMMAND");
        }

        /// <summary>
        /// Get SFT Records from DSR_Q01
        /// </summary>
        public static IEnumerable GetSFTRecords(this DSR_Q01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from DSR_Q01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this DSR_Q01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DSP Records from DSR_Q01
        /// </summary>
        public static IEnumerable GetDSPRecords(this DSR_Q01 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from DSR_Q01
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this DSR_Q01 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from ADT_A20
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A20 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A20
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A20 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from VXX_V02
        /// </summary>
        public static IEnumerable GetSFTRecords(this VXX_V02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from VXX_V02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this VXX_V02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from VXX_V02
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this VXX_V02 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from VXX_V02
        /// </summary>
        public static List<VXX_V02_PATIENT> GetAllPATIENTRecords(this VXX_V02 message)
        {
            return message.GetAllRecords<VXX_V02_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from RSP_Z86
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_Z86 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_Z86
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_Z86 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from RSP_Z86
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this RSP_Z86 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from RSP_Z86
        /// </summary>
        public static List<RSP_Z86_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this RSP_Z86 message)
        {
            return message.GetAllRecords<RSP_Z86_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Get SFT Records from RPR_I03
        /// </summary>
        public static IEnumerable GetSFTRecords(this RPR_I03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RPR_I03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RPR_I03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RPR_I03
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPR_I03 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPR_I03
        /// </summary>
        public static List<RPR_I03_PROVIDER> GetAllPROVIDERRecords(this RPR_I03 message)
        {
            return message.GetAllRecords<RPR_I03_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get PID Records from RPR_I03
        /// </summary>
        public static IEnumerable GetPIDRecords(this RPR_I03 message)
        {
            object[] result = message.GetRecords("PIDRepetitionsUsed", "GetPID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PID Records from RPR_I03
        /// </summary>
        public static List<PID> GetAllPIDRecords(this RPR_I03 message)
        {
            return message.GetAllRecords<PID>("PIDRepetitionsUsed", "GetPID");
        }

        /// <summary>
        /// Get NTE Records from RPR_I03
        /// </summary>
        public static IEnumerable GetNTERecords(this RPR_I03 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPR_I03
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPR_I03 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from QRY_A19
        /// </summary>
        public static IEnumerable GetSFTRecords(this QRY_A19 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QRY_A19
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QRY_A19 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from QCN_J01
        /// </summary>
        public static IEnumerable GetSFTRecords(this QCN_J01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QCN_J01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QCN_J01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from MFN_M13
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M13 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M13
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M13 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MFE Records from MFN_M13
        /// </summary>
        public static IEnumerable GetMFERecords(this MFN_M13 message)
        {
            object[] result = message.GetRecords("MFERepetitionsUsed", "GetMFE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFE Records from MFN_M13
        /// </summary>
        public static List<MFE> GetAllMFERecords(this MFN_M13 message)
        {
            return message.GetAllRecords<MFE>("MFERepetitionsUsed", "GetMFE");
        }

        /// <summary>
        /// Get SFT Records from MFN_M02
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_STAFF Records from MFN_M02
        /// </summary>
        public static IEnumerable GetMF_STAFFRecords(this MFN_M02 message)
        {
            object[] result = message.GetRecords("MF_STAFFRepetitionsUsed", "GetMF_STAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_STAFF Records from MFN_M02
        /// </summary>
        public static List<MFN_M02_MF_STAFF> GetAllMF_STAFFRecords(this MFN_M02 message)
        {
            return message.GetAllRecords<MFN_M02_MF_STAFF>("MF_STAFFRepetitionsUsed", "GetMF_STAFF");
        }

        /// <summary>
        /// Get SFT Records from MFK_M01
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFK_M01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFK_M01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFK_M01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from MFK_M01
        /// </summary>
        public static IEnumerable GetERRRecords(this MFK_M01 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from MFK_M01
        /// </summary>
        public static List<ERR> GetAllERRRecords(this MFK_M01 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get MFA Records from MFK_M01
        /// </summary>
        public static IEnumerable GetMFARecords(this MFK_M01 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFK_M01
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFK_M01 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Get SFT Records from BAR_P02
        /// </summary>
        public static IEnumerable GetSFTRecords(this BAR_P02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BAR_P02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BAR_P02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from BAR_P02
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this BAR_P02 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from BAR_P02
        /// </summary>
        public static List<BAR_P02_PATIENT> GetAllPATIENTRecords(this BAR_P02 message)
        {
            return message.GetAllRecords<BAR_P02_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A52
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A52 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A52
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A52 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from ADT_A30
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A30 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A30
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A30 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from SSU_U03
        /// </summary>
        public static IEnumerable GetSFTRecords(this SSU_U03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from SSU_U03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this SSU_U03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SPECIMEN_CONTAINER Records from SSU_U03
        /// </summary>
        public static IEnumerable GetSPECIMEN_CONTAINERRecords(this SSU_U03 message)
        {
            object[] result = message.GetRecords("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN_CONTAINER Records from SSU_U03
        /// </summary>
        public static List<SSU_U03_SPECIMEN_CONTAINER> GetAllSPECIMEN_CONTAINERRecords(this SSU_U03 message)
        {
            return message.GetAllRecords<SSU_U03_SPECIMEN_CONTAINER>("SPECIMEN_CONTAINERRepetitionsUsed", "GetSPECIMEN_CONTAINER");
        }

        /// <summary>
        /// Get SFT Records from RQP_I04
        /// </summary>
        public static IEnumerable GetSFTRecords(this RQP_I04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RQP_I04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RQP_I04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RQP_I04
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQP_I04 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQP_I04
        /// </summary>
        public static List<RQP_I04_PROVIDER> GetAllPROVIDERRecords(this RQP_I04 message)
        {
            return message.GetAllRecords<RQP_I04_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RQP_I04
        /// </summary>
        public static IEnumerable GetNK1Records(this RQP_I04 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQP_I04
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQP_I04 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get GT1 Records from RQP_I04
        /// </summary>
        public static IEnumerable GetGT1Records(this RQP_I04 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQP_I04
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQP_I04 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get NTE Records from RQP_I04
        /// </summary>
        public static IEnumerable GetNTERecords(this RQP_I04 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQP_I04
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQP_I04 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from PPG_PCG
        /// </summary>
        public static IEnumerable GetSFTRecords(this PPG_PCG message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PPG_PCG
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PPG_PCG message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATHWAY Records from PPG_PCG
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPG_PCG message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPG_PCG
        /// </summary>
        public static List<PPG_PCG_PATHWAY> GetAllPATHWAYRecords(this PPG_PCG message)
        {
            return message.GetAllRecords<PPG_PCG_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Get SFT Records from MFN_M12
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_OBS_ATTRIBUTES Records from MFN_M12
        /// </summary>
        public static IEnumerable GetMF_OBS_ATTRIBUTESRecords(this MFN_M12 message)
        {
            object[] result = message.GetRecords("MF_OBS_ATTRIBUTESRepetitionsUsed", "GetMF_OBS_ATTRIBUTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_OBS_ATTRIBUTES Records from MFN_M12
        /// </summary>
        public static List<MFN_M12_MF_OBS_ATTRIBUTES> GetAllMF_OBS_ATTRIBUTESRecords(this MFN_M12 message)
        {
            return message.GetAllRecords<MFN_M12_MF_OBS_ATTRIBUTES>("MF_OBS_ATTRIBUTESRepetitionsUsed", "GetMF_OBS_ATTRIBUTES");
        }

        /// <summary>
        /// Get SFT Records from MFN_M01
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF Records from MFN_M01
        /// </summary>
        public static IEnumerable GetMFRecords(this MFN_M01 message)
        {
            object[] result = message.GetRecords("MFRepetitionsUsed", "GetMF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF Records from MFN_M01
        /// </summary>
        public static List<MFN_M01_MF> GetAllMFRecords(this MFN_M01 message)
        {
            return message.GetAllRecords<MFN_M01_MF>("MFRepetitionsUsed", "GetMF");
        }

        /// <summary>
        /// Get SFT Records from INU_U05
        /// </summary>
        public static IEnumerable GetSFTRecords(this INU_U05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from INU_U05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this INU_U05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get INV Records from INU_U05
        /// </summary>
        public static IEnumerable GetINVRecords(this INU_U05 message)
        {
            object[] result = message.GetRecords("INVRepetitionsUsed", "GetINV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INV Records from INU_U05
        /// </summary>
        public static List<INV> GetAllINVRecords(this INU_U05 message)
        {
            return message.GetAllRecords<INV>("INVRepetitionsUsed", "GetINV");
        }

        /// <summary>
        /// Get SFT Records from ESU_U01
        /// </summary>
        public static IEnumerable GetSFTRecords(this ESU_U01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ESU_U01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ESU_U01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ISD Records from ESU_U01
        /// </summary>
        public static IEnumerable GetISDRecords(this ESU_U01 message)
        {
            object[] result = message.GetRecords("ISDRepetitionsUsed", "GetISD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ISD Records from ESU_U01
        /// </summary>
        public static List<ISD> GetAllISDRecords(this ESU_U01 message)
        {
            return message.GetAllRecords<ISD>("ISDRepetitionsUsed", "GetISD");
        }

        /// <summary>
        /// Get SFT Records from BAR_P12
        /// </summary>
        public static IEnumerable GetSFTRecords(this BAR_P12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BAR_P12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BAR_P12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DG1 Records from BAR_P12
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P12 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P12
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P12 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get SFT Records from BAR_P01
        /// </summary>
        public static IEnumerable GetSFTRecords(this BAR_P01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BAR_P01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BAR_P01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from BAR_P01
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get VISIT Records from BAR_P01
        /// </summary>
        public static IEnumerable GetVISITRecords(this BAR_P01 message)
        {
            object[] result = message.GetRecords("VISITRepetitionsUsed", "GetVISIT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VISIT Records from BAR_P01
        /// </summary>
        public static List<BAR_P01_VISIT> GetAllVISITRecords(this BAR_P01 message)
        {
            return message.GetAllRecords<BAR_P01_VISIT>("VISITRepetitionsUsed", "GetVISIT");
        }

        /// <summary>
        /// Get ERR Records from RER_RER
        /// </summary>
        public static IEnumerable GetERRRecords(this RER_RER message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RER_RER
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RER_RER message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RER_RER
        /// </summary>
        public static IEnumerable GetSFTRecords(this RER_RER message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RER_RER
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RER_RER message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DEFINITION Records from RER_RER
        /// </summary>
        public static IEnumerable GetDEFINITIONRecords(this RER_RER message)
        {
            object[] result = message.GetRecords("DEFINITIONRepetitionsUsed", "GetDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DEFINITION Records from RER_RER
        /// </summary>
        public static List<RER_RER_DEFINITION> GetAllDEFINITIONRecords(this RER_RER message)
        {
            return message.GetAllRecords<RER_RER_DEFINITION>("DEFINITIONRepetitionsUsed", "GetDEFINITION");
        }

        /// <summary>
        /// Get SFT Records from REF_I12
        /// </summary>
        public static IEnumerable GetSFTRecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from REF_I12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this REF_I12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER_CONTACT Records from REF_I12
        /// </summary>
        public static IEnumerable GetPROVIDER_CONTACTRecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER_CONTACT Records from REF_I12
        /// </summary>
        public static List<REF_I12_PROVIDER_CONTACT> GetAllPROVIDER_CONTACTRecords(this REF_I12 message)
        {
            return message.GetAllRecords<REF_I12_PROVIDER_CONTACT>("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");
        }

        /// <summary>
        /// Get NK1 Records from REF_I12
        /// </summary>
        public static IEnumerable GetNK1Records(this REF_I12 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from REF_I12
        /// </summary>
        public static List<NK1> GetAllNK1Records(this REF_I12 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get GT1 Records from REF_I12
        /// </summary>
        public static IEnumerable GetGT1Records(this REF_I12 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from REF_I12
        /// </summary>
        public static List<GT1> GetAllGT1Records(this REF_I12 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from REF_I12
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from REF_I12
        /// </summary>
        public static List<REF_I12_INSURANCE> GetAllINSURANCERecords(this REF_I12 message)
        {
            return message.GetAllRecords<REF_I12_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get DG1 Records from REF_I12
        /// </summary>
        public static IEnumerable GetDG1Records(this REF_I12 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from REF_I12
        /// </summary>
        public static List<DG1> GetAllDG1Records(this REF_I12 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get DRG Records from REF_I12
        /// </summary>
        public static IEnumerable GetDRGRecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from REF_I12
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this REF_I12 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Get AL1 Records from REF_I12
        /// </summary>
        public static IEnumerable GetAL1Records(this REF_I12 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from REF_I12
        /// </summary>
        public static List<AL1> GetAllAL1Records(this REF_I12 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get PROCEDURE Records from REF_I12
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from REF_I12
        /// </summary>
        public static List<REF_I12_PROCEDURE> GetAllPROCEDURERecords(this REF_I12 message)
        {
            return message.GetAllRecords<REF_I12_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Get OBSERVATION Records from REF_I12
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from REF_I12
        /// </summary>
        public static List<REF_I12_OBSERVATION> GetAllOBSERVATIONRecords(this REF_I12 message)
        {
            return message.GetAllRecords<REF_I12_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from REF_I12
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from PPR_PC1
        /// </summary>
        public static IEnumerable GetSFTRecords(this PPR_PC1 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PPR_PC1
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PPR_PC1 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROBLEM Records from PPR_PC1
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPR_PC1 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPR_PC1
        /// </summary>
        public static List<PPR_PC1_PROBLEM> GetAllPROBLEMRecords(this PPR_PC1 message)
        {
            return message.GetAllRecords<PPR_PC1_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get SFT Records from MFR_M07
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFR_M07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFR_M07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFR_M07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from MFR_M07
        /// </summary>
        public static IEnumerable GetERRRecords(this MFR_M07 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from MFR_M07
        /// </summary>
        public static List<ERR> GetAllERRRecords(this MFR_M07 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get MF_QUERY Records from MFR_M07
        /// </summary>
        public static IEnumerable GetMF_QUERYRecords(this MFR_M07 message)
        {
            object[] result = message.GetRecords("MF_QUERYRepetitionsUsed", "GetMF_QUERY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_QUERY Records from MFR_M07
        /// </summary>
        public static List<MFR_M07_MF_QUERY> GetAllMF_QUERYRecords(this MFR_M07 message)
        {
            return message.GetAllRecords<MFR_M07_MF_QUERY>("MF_QUERYRepetitionsUsed", "GetMF_QUERY");
        }

        /// <summary>
        /// Get SFT Records from MFQ_M01
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFQ_M01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFQ_M01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFQ_M01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from MFN_M11
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M11 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M11
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M11 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_TEST_CALCULATED Records from MFN_M11
        /// </summary>
        public static IEnumerable GetMF_TEST_CALCULATEDRecords(this MFN_M11 message)
        {
            object[] result = message.GetRecords("MF_TEST_CALCULATEDRepetitionsUsed", "GetMF_TEST_CALCULATED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_TEST_CALCULATED Records from MFN_M11
        /// </summary>
        public static List<MFN_M11_MF_TEST_CALCULATED> GetAllMF_TEST_CALCULATEDRecords(this MFN_M11 message)
        {
            return message.GetAllRecords<MFN_M11_MF_TEST_CALCULATED>("MF_TEST_CALCULATEDRepetitionsUsed", "GetMF_TEST_CALCULATED");
        }

        /// <summary>
        /// Get SFT Records from LSU_U12
        /// </summary>
        public static IEnumerable GetSFTRecords(this LSU_U12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from LSU_U12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this LSU_U12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get EQP Records from LSU_U12
        /// </summary>
        public static IEnumerable GetEQPRecords(this LSU_U12 message)
        {
            object[] result = message.GetRecords("EQPRepetitionsUsed", "GetEQP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EQP Records from LSU_U12
        /// </summary>
        public static List<EQP> GetAllEQPRecords(this LSU_U12 message)
        {
            return message.GetAllRecords<EQP>("EQPRepetitionsUsed", "GetEQP");
        }

        /// <summary>
        /// Get SFT Records from EQQ_Q04
        /// </summary>
        public static IEnumerable GetSFTRecords(this EQQ_Q04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EQQ_Q04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EQQ_Q04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from CSU_C09
        /// </summary>
        public static IEnumerable GetSFTRecords(this CSU_C09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CSU_C09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CSU_C09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PATIENT Records from CSU_C09
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CSU_C09 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CSU_C09
        /// </summary>
        public static List<CSU_C09_PATIENT> GetAllPATIENTRecords(this CSU_C09 message)
        {
            return message.GetAllRecords<CSU_C09_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from BPS_O29
        /// </summary>
        public static IEnumerable GetSFTRecords(this BPS_O29 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BPS_O29
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BPS_O29 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from BPS_O29
        /// </summary>
        public static IEnumerable GetNTERecords(this BPS_O29 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BPS_O29
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BPS_O29 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from BPS_O29
        /// </summary>
        public static IEnumerable GetORDERRecords(this BPS_O29 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from BPS_O29
        /// </summary>
        public static List<BPS_O29_ORDER> GetAllORDERRecords(this BPS_O29 message)
        {
            return message.GetAllRecords<BPS_O29_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from ADT_A61
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A61 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A61
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A61 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from ADT_A61
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A61 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A61
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A61 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get SFT Records from ADT_A50
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A50 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A50
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A50 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from SPQ_Q08
        /// </summary>
        public static IEnumerable GetSFTRecords(this SPQ_Q08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from SPQ_Q08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this SPQ_Q08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from PEX_P07
        /// </summary>
        public static IEnumerable GetSFTRecords(this PEX_P07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PEX_P07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PEX_P07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from PEX_P07
        /// </summary>
        public static IEnumerable GetNTERecords(this PEX_P07 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PEX_P07
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PEX_P07 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get EXPERIENCE Records from PEX_P07
        /// </summary>
        public static IEnumerable GetEXPERIENCERecords(this PEX_P07 message)
        {
            object[] result = message.GetRecords("EXPERIENCERepetitionsUsed", "GetEXPERIENCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EXPERIENCE Records from PEX_P07
        /// </summary>
        public static List<PEX_P07_EXPERIENCE> GetAllEXPERIENCERecords(this PEX_P07 message)
        {
            return message.GetAllRecords<PEX_P07_EXPERIENCE>("EXPERIENCERepetitionsUsed", "GetEXPERIENCE");
        }

        /// <summary>
        /// Get SFT Records from OMG_O19
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMG_O19 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMG_O19
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMG_O19 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMG_O19
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OMG_O19
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMG_O19 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMG_O19
        /// </summary>
        public static List<OMG_O19_ORDER> GetAllORDERRecords(this OMG_O19 message)
        {
            return message.GetAllRecords<OMG_O19_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFR_M06
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFR_M06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFR_M06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFR_M06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from MFR_M06
        /// </summary>
        public static IEnumerable GetERRRecords(this MFR_M06 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from MFR_M06
        /// </summary>
        public static List<ERR> GetAllERRRecords(this MFR_M06 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get MF_QUERY Records from MFR_M06
        /// </summary>
        public static IEnumerable GetMF_QUERYRecords(this MFR_M06 message)
        {
            object[] result = message.GetRecords("MF_QUERYRepetitionsUsed", "GetMF_QUERY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_QUERY Records from MFR_M06
        /// </summary>
        public static List<MFR_M06_MF_QUERY> GetAllMF_QUERYRecords(this MFR_M06 message)
        {
            return message.GetAllRecords<MFR_M06_MF_QUERY>("MF_QUERYRepetitionsUsed", "GetMF_QUERY");
        }

        /// <summary>
        /// Get SFT Records from MFN_M10
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M10 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M10
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M10 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_TEST_BATTERIES Records from MFN_M10
        /// </summary>
        public static IEnumerable GetMF_TEST_BATTERIESRecords(this MFN_M10 message)
        {
            object[] result = message.GetRecords("MF_TEST_BATTERIESRepetitionsUsed", "GetMF_TEST_BATTERIES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_TEST_BATTERIES Records from MFN_M10
        /// </summary>
        public static List<MFN_M10_MF_TEST_BATTERIES> GetAllMF_TEST_BATTERIESRecords(this MFN_M10 message)
        {
            return message.GetAllRecords<MFN_M10_MF_TEST_BATTERIES>("MF_TEST_BATTERIESRepetitionsUsed", "GetMF_TEST_BATTERIES");
        }

        /// <summary>
        /// Get SFT Records from BAR_P10
        /// </summary>
        public static IEnumerable GetSFTRecords(this BAR_P10 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BAR_P10
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BAR_P10 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DG1 Records from BAR_P10
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P10 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P10
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P10 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get SFT Records from ADT_A60
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A60 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A60
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A60 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get IAM Records from ADT_A60
        /// </summary>
        public static IEnumerable GetIAMRecords(this ADT_A60 message)
        {
            object[] result = message.GetRecords("IAMRepetitionsUsed", "GetIAM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IAM Records from ADT_A60
        /// </summary>
        public static List<IAM> GetAllIAMRecords(this ADT_A60 message)
        {
            return message.GetAllRecords<IAM>("IAMRepetitionsUsed", "GetIAM");
        }

        /// <summary>
        /// Get SFT Records from RSP_Z82
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_Z82 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_Z82
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_Z82 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from RSP_Z82
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this RSP_Z82 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from RSP_Z82
        /// </summary>
        public static List<RSP_Z82_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this RSP_Z82 message)
        {
            return message.GetAllRecords<RSP_Z82_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Get ERR Records from RRG_O16
        /// </summary>
        public static IEnumerable GetERRRecords(this RRG_O16 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RRG_O16
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RRG_O16 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RRG_O16
        /// </summary>
        public static IEnumerable GetSFTRecords(this RRG_O16 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RRG_O16
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RRG_O16 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RRG_O16
        /// </summary>
        public static IEnumerable GetNTERecords(this RRG_O16 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRG_O16
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRG_O16 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ERR Records from RRD_O14
        /// </summary>
        public static IEnumerable GetERRRecords(this RRD_O14 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RRD_O14
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RRD_O14 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from RRD_O14
        /// </summary>
        public static IEnumerable GetSFTRecords(this RRD_O14 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RRD_O14
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RRD_O14 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from RRD_O14
        /// </summary>
        public static IEnumerable GetNTERecords(this RRD_O14 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRD_O14
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRD_O14 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from PTR_PCF
        /// </summary>
        public static IEnumerable GetSFTRecords(this PTR_PCF message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PTR_PCF
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PTR_PCF message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from PTR_PCF
        /// </summary>
        public static IEnumerable GetERRRecords(this PTR_PCF message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from PTR_PCF
        /// </summary>
        public static List<ERR> GetAllERRRecords(this PTR_PCF message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get PATIENT Records from PTR_PCF
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this PTR_PCF message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from PTR_PCF
        /// </summary>
        public static List<PTR_PCF_PATIENT> GetAllPATIENTRecords(this PTR_PCF message)
        {
            return message.GetAllRecords<PTR_PCF_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get SFT Records from PMU_B08
        /// </summary>
        public static IEnumerable GetSFTRecords(this PMU_B08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PMU_B08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PMU_B08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get CER Records from PMU_B08
        /// </summary>
        public static IEnumerable GetCERRecords(this PMU_B08 message)
        {
            object[] result = message.GetRecords("CERRepetitionsUsed", "GetCER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CER Records from PMU_B08
        /// </summary>
        public static List<CER> GetAllCERRecords(this PMU_B08 message)
        {
            return message.GetAllRecords<CER>("CERRepetitionsUsed", "GetCER");
        }

        /// <summary>
        /// Get ERR Records from ORL_O36
        /// </summary>
        public static IEnumerable GetERRRecords(this ORL_O36 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORL_O36
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORL_O36 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORL_O36
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORL_O36 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORL_O36
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORL_O36 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORL_O36
        /// </summary>
        public static IEnumerable GetNTERecords(this ORL_O36 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORL_O36
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORL_O36 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ERR Records from ORI_O24
        /// </summary>
        public static IEnumerable GetERRRecords(this ORI_O24 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORI_O24
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORI_O24 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORI_O24
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORI_O24 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORI_O24
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORI_O24 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORI_O24
        /// </summary>
        public static IEnumerable GetNTERecords(this ORI_O24 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORI_O24
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORI_O24 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from NMD_N02
        /// </summary>
        public static IEnumerable GetSFTRecords(this NMD_N02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from NMD_N02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this NMD_N02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get CLOCK_AND_STATS_WITH_NOTES Records from NMD_N02
        /// </summary>
        public static IEnumerable GetCLOCK_AND_STATS_WITH_NOTESRecords(this NMD_N02 message)
        {
            object[] result = message.GetRecords("CLOCK_AND_STATS_WITH_NOTESRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLOCK_AND_STATS_WITH_NOTES Records from NMD_N02
        /// </summary>
        public static List<NMD_N02_CLOCK_AND_STATS_WITH_NOTES> GetAllCLOCK_AND_STATS_WITH_NOTESRecords(this NMD_N02 message)
        {
            return message.GetAllRecords<NMD_N02_CLOCK_AND_STATS_WITH_NOTES>("CLOCK_AND_STATS_WITH_NOTESRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES");
        }

        /// <summary>
        /// Get SFT Records from MFR_M05
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFR_M05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFR_M05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFR_M05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from MFR_M05
        /// </summary>
        public static IEnumerable GetERRRecords(this MFR_M05 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from MFR_M05
        /// </summary>
        public static List<ERR> GetAllERRRecords(this MFR_M05 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get MF_QUERY Records from MFR_M05
        /// </summary>
        public static IEnumerable GetMF_QUERYRecords(this MFR_M05 message)
        {
            object[] result = message.GetRecords("MF_QUERYRepetitionsUsed", "GetMF_QUERY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_QUERY Records from MFR_M05
        /// </summary>
        public static List<MFR_M05_MF_QUERY> GetAllMF_QUERYRecords(this MFR_M05 message)
        {
            return message.GetAllRecords<MFR_M05_MF_QUERY>("MF_QUERYRepetitionsUsed", "GetMF_QUERY");
        }

        /// <summary>
        /// Get SFT Records from ERP_R09
        /// </summary>
        public static IEnumerable GetSFTRecords(this ERP_R09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ERP_R09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ERP_R09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from EAR_U08
        /// </summary>
        public static IEnumerable GetSFTRecords(this EAR_U08 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EAR_U08
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EAR_U08 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get COMMAND_RESPONSE Records from EAR_U08
        /// </summary>
        public static IEnumerable GetCOMMAND_RESPONSERecords(this EAR_U08 message)
        {
            object[] result = message.GetRecords("COMMAND_RESPONSERepetitionsUsed", "GetCOMMAND_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMAND_RESPONSE Records from EAR_U08
        /// </summary>
        public static List<EAR_U08_COMMAND_RESPONSE> GetAllCOMMAND_RESPONSERecords(this EAR_U08 message)
        {
            return message.GetAllRecords<EAR_U08_COMMAND_RESPONSE>("COMMAND_RESPONSERepetitionsUsed", "GetCOMMAND_RESPONSE");
        }

        /// <summary>
        /// Get RESULT Records from DOC_T12
        /// </summary>
        public static IEnumerable GetRESULTRecords(this DOC_T12 message)
        {
            object[] result = message.GetRecords("RESULTRepetitionsUsed", "GetRESULT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULT Records from DOC_T12
        /// </summary>
        public static List<DOC_T12_RESULT> GetAllRESULTRecords(this DOC_T12 message)
        {
            return message.GetAllRecords<DOC_T12_RESULT>("RESULTRepetitionsUsed", "GetRESULT");
        }

        /// <summary>
        /// Get SFT Records from DFT_P03
        /// </summary>
        public static IEnumerable GetSFTRecords(this DFT_P03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from DFT_P03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this DFT_P03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ROL Records from DFT_P03
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P03 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P03
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P03 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL2 Records from DFT_P03
        /// </summary>
        public static IEnumerable GetROL2Records(this DFT_P03 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from DFT_P03
        /// </summary>
        public static List<ROL> GetAllROL2Records(this DFT_P03 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from DFT_P03
        /// </summary>
        public static IEnumerable GetDB1Records(this DFT_P03 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from DFT_P03
        /// </summary>
        public static List<DB1> GetAllDB1Records(this DFT_P03 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get FINANCIAL Records from DFT_P03
        /// </summary>
        public static IEnumerable GetFINANCIALRecords(this DFT_P03 message)
        {
            object[] result = message.GetRecords("FINANCIALRepetitionsUsed", "GetFINANCIAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL Records from DFT_P03
        /// </summary>
        public static List<DFT_P03_FINANCIAL> GetAllFINANCIALRecords(this DFT_P03 message)
        {
            return message.GetAllRecords<DFT_P03_FINANCIAL>("FINANCIALRepetitionsUsed", "GetFINANCIAL");
        }

        /// <summary>
        /// Get DG1 Records from DFT_P03
        /// </summary>
        public static IEnumerable GetDG1Records(this DFT_P03 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from DFT_P03
        /// </summary>
        public static List<DG1> GetAllDG1Records(this DFT_P03 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from DFT_P03
        /// </summary>
        public static IEnumerable GetGT1Records(this DFT_P03 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from DFT_P03
        /// </summary>
        public static List<GT1> GetAllGT1Records(this DFT_P03 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get ERR Records from BRP_O30
        /// </summary>
        public static IEnumerable GetERRRecords(this BRP_O30 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from BRP_O30
        /// </summary>
        public static List<ERR> GetAllERRRecords(this BRP_O30 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from BRP_O30
        /// </summary>
        public static IEnumerable GetSFTRecords(this BRP_O30 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from BRP_O30
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this BRP_O30 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from BRP_O30
        /// </summary>
        public static IEnumerable GetNTERecords(this BRP_O30 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from BRP_O30
        /// </summary>
        public static List<NTE> GetAllNTERecords(this BRP_O30 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from QBP_Z73
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_Z73 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_Z73
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_Z73 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from PMU_B07
        /// </summary>
        public static IEnumerable GetSFTRecords(this PMU_B07 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from PMU_B07
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this PMU_B07 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get CERTIFICATE Records from PMU_B07
        /// </summary>
        public static IEnumerable GetCERTIFICATERecords(this PMU_B07 message)
        {
            object[] result = message.GetRecords("CERTIFICATERepetitionsUsed", "GetCERTIFICATE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CERTIFICATE Records from PMU_B07
        /// </summary>
        public static List<PMU_B07_CERTIFICATE> GetAllCERTIFICATERecords(this PMU_B07 message)
        {
            return message.GetAllRecords<PMU_B07_CERTIFICATE>("CERTIFICATERepetitionsUsed", "GetCERTIFICATE");
        }

        /// <summary>
        /// Get ERR Records from ORD_O04
        /// </summary>
        public static IEnumerable GetERRRecords(this ORD_O04 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORD_O04
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORD_O04 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORD_O04
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORD_O04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORD_O04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORD_O04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORD_O04
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OML_O35
        /// </summary>
        public static IEnumerable GetSFTRecords(this OML_O35 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OML_O35
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OML_O35 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OML_O35
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O35 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O35
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O35 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SPECIMEN Records from OML_O35
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this OML_O35 message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from OML_O35
        /// </summary>
        public static List<OML_O35_SPECIMEN> GetAllSPECIMENRecords(this OML_O35 message)
        {
            return message.GetAllRecords<OML_O35_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Get SFT Records from OMI_O23
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMI_O23 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMI_O23
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMI_O23 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMI_O23
        /// </summary>
        public static IEnumerable GetNTERecords(this OMI_O23 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMI_O23
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMI_O23 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OMI_O23
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMI_O23 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMI_O23
        /// </summary>
        public static List<OMI_O23_ORDER> GetAllORDERRecords(this OMI_O23 message)
        {
            return message.GetAllRecords<OMI_O23_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from NMR_N01
        /// </summary>
        public static IEnumerable GetSFTRecords(this NMR_N01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from NMR_N01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this NMR_N01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from NMR_N01
        /// </summary>
        public static IEnumerable GetERRRecords(this NMR_N01 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from NMR_N01
        /// </summary>
        public static List<ERR> GetAllERRRecords(this NMR_N01 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get CLOCK_AND_STATS_WITH_NOTES_ALT Records from NMR_N01
        /// </summary>
        public static IEnumerable GetCLOCK_AND_STATS_WITH_NOTES_ALTRecords(this NMR_N01 message)
        {
            object[] result = message.GetRecords("CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES_ALT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLOCK_AND_STATS_WITH_NOTES_ALT Records from NMR_N01
        /// </summary>
        public static List<NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT> GetAllCLOCK_AND_STATS_WITH_NOTES_ALTRecords(this NMR_N01 message)
        {
            return message.GetAllRecords<NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT>("CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES_ALT");
        }

        /// <summary>
        /// Get SFT Records from MFR_M04
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFR_M04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFR_M04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFR_M04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from MFR_M04
        /// </summary>
        public static IEnumerable GetERRRecords(this MFR_M04 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from MFR_M04
        /// </summary>
        public static List<ERR> GetAllERRRecords(this MFR_M04 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get MF_QUERY Records from MFR_M04
        /// </summary>
        public static IEnumerable GetMF_QUERYRecords(this MFR_M04 message)
        {
            object[] result = message.GetRecords("MF_QUERYRepetitionsUsed", "GetMF_QUERY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_QUERY Records from MFR_M04
        /// </summary>
        public static List<MFR_M04_MF_QUERY> GetAllMF_QUERYRecords(this MFR_M04 message)
        {
            return message.GetAllRecords<MFR_M04_MF_QUERY>("MF_QUERYRepetitionsUsed", "GetMF_QUERY");
        }

        /// <summary>
        /// Get SFT Records from ADT_A09
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get DB1 Records from ADT_A09
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A09 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A09
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A09 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADT_A09
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A09 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A09
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A09 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get DG1 Records from ADT_A09
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A09 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A09
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A09 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get TQ1 Records from SIU_S12
        /// </summary>
        public static IEnumerable GetTQ1Records(this SIU_S12 message)
        {
            object[] result = message.GetRecords("TQ1RepetitionsUsed", "GetTQ1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TQ1 Records from SIU_S12
        /// </summary>
        public static List<TQ1> GetAllTQ1Records(this SIU_S12 message)
        {
            return message.GetAllRecords<TQ1>("TQ1RepetitionsUsed", "GetTQ1");
        }

        /// <summary>
        /// Get NTE Records from SIU_S12
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S12
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S12 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S12
        /// </summary>
        public static List<SIU_S12_RESOURCES> GetAllRESOURCESRecords(this SIU_S12 message)
        {
            return message.GetAllRecords<SIU_S12_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Get SFT Records from RQC_I05
        /// </summary>
        public static IEnumerable GetSFTRecords(this RQC_I05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RQC_I05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RQC_I05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RQC_I05
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQC_I05 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQC_I05
        /// </summary>
        public static List<RQC_I05_PROVIDER> GetAllPROVIDERRecords(this RQC_I05 message)
        {
            return message.GetAllRecords<RQC_I05_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get NK1 Records from RQC_I05
        /// </summary>
        public static IEnumerable GetNK1Records(this RQC_I05 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQC_I05
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQC_I05 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get GT1 Records from RQC_I05
        /// </summary>
        public static IEnumerable GetGT1Records(this RQC_I05 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQC_I05
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQC_I05 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get NTE Records from RQC_I05
        /// </summary>
        public static IEnumerable GetNTERecords(this RQC_I05 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQC_I05
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQC_I05 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from RCL_I06
        /// </summary>
        public static IEnumerable GetSFTRecords(this RCL_I06 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RCL_I06
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RCL_I06 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RCL_I06
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RCL_I06 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RCL_I06
        /// </summary>
        public static List<RCL_I06_PROVIDER> GetAllPROVIDERRecords(this RCL_I06 message)
        {
            return message.GetAllRecords<RCL_I06_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get DG1 Records from RCL_I06
        /// </summary>
        public static IEnumerable GetDG1Records(this RCL_I06 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RCL_I06
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RCL_I06 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get DRG Records from RCL_I06
        /// </summary>
        public static IEnumerable GetDRGRecords(this RCL_I06 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RCL_I06
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RCL_I06 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Get AL1 Records from RCL_I06
        /// </summary>
        public static IEnumerable GetAL1Records(this RCL_I06 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RCL_I06
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RCL_I06 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from RCL_I06
        /// </summary>
        public static IEnumerable GetNTERecords(this RCL_I06 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCL_I06
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCL_I06 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get DSP Records from RCL_I06
        /// </summary>
        public static IEnumerable GetDSPRecords(this RCL_I06 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from RCL_I06
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this RCL_I06 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Get SFT Records from RCI_I05
        /// </summary>
        public static IEnumerable GetSFTRecords(this RCI_I05 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RCI_I05
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RCI_I05 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get PROVIDER Records from RCI_I05
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RCI_I05 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RCI_I05
        /// </summary>
        public static List<RCI_I05_PROVIDER> GetAllPROVIDERRecords(this RCI_I05 message)
        {
            return message.GetAllRecords<RCI_I05_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Get DG1 Records from RCI_I05
        /// </summary>
        public static IEnumerable GetDG1Records(this RCI_I05 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RCI_I05
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RCI_I05 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get DRG Records from RCI_I05
        /// </summary>
        public static IEnumerable GetDRGRecords(this RCI_I05 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RCI_I05
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RCI_I05 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Get AL1 Records from RCI_I05
        /// </summary>
        public static IEnumerable GetAL1Records(this RCI_I05 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RCI_I05
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RCI_I05 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get OBSERVATION Records from RCI_I05
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RCI_I05 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RCI_I05
        /// </summary>
        public static List<RCI_I05_OBSERVATION> GetAllOBSERVATIONRecords(this RCI_I05 message)
        {
            return message.GetAllRecords<RCI_I05_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from RCI_I05
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from QRY_R02
        /// </summary>
        public static IEnumerable GetSFTRecords(this QRY_R02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QRY_R02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QRY_R02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from QRY_PC4
        /// </summary>
        public static IEnumerable GetSFTRecords(this QRY_PC4 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QRY_PC4
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QRY_PC4 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get SFT Records from QBP_Q15
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_Q15 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_Q15
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_Q15 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get ERR Records from ORL_O34
        /// </summary>
        public static IEnumerable GetERRRecords(this ORL_O34 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORL_O34
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORL_O34 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Get SFT Records from ORL_O34
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORL_O34 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORL_O34
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORL_O34 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from ORL_O34
        /// </summary>
        public static IEnumerable GetNTERecords(this ORL_O34 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORL_O34
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORL_O34 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SFT Records from OMP_O09
        /// </summary>
        public static IEnumerable GetSFTRecords(this OMP_O09 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OMP_O09
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OMP_O09 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get NTE Records from OMP_O09
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OMP_O09
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMP_O09 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMP_O09
        /// </summary>
        public static List<OMP_O09_ORDER> GetAllORDERRecords(this OMP_O09 message)
        {
            return message.GetAllRecords<OMP_O09_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SFT Records from MFN_Znn
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_Znn message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_Znn
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_Znn message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Get MF_SITE_DEFINED Records from MFN_Znn
        /// </summary>
        public static IEnumerable GetMF_SITE_DEFINEDRecords(this MFN_Znn message)
        {
            object[] result = message.GetRecords("MF_SITE_DEFINEDRepetitionsUsed", "GetMF_SITE_DEFINED");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_SITE_DEFINED Records from MFN_Znn
        /// </summary>
        public static List<MFN_Znn_MF_SITE_DEFINED> GetAllMF_SITE_DEFINEDRecords(this MFN_Znn message)
        {
            return message.GetAllRecords<MFN_Znn_MF_SITE_DEFINED>("MF_SITE_DEFINEDRepetitionsUsed", "GetMF_SITE_DEFINED");
        }
        #endregion
    }
}
