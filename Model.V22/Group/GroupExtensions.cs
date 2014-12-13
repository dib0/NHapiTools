using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Message;
using NHapi.Model.V22.Segment;
using NHapi.Model.V22.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V22.Group
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class GroupExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from NMD_N01_APP_STATUS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N01_APP_STATUS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N01_APP_STATUS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N01_APP_STATUS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORR_O02_PATIENT
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORR_O02_PATIENT message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORR_O02_PATIENT
        /// </summary>
        public static List<ORR_O02_ORDER> GetAllORDERRecords(this ORR_O02_PATIENT message)
        {
            return message.GetAllRecords<ORR_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from NMD_N01_APP_STATS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N01_APP_STATS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N01_APP_STATS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N01_APP_STATS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from NMD_N01_CLOCK
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N01_CLOCK message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N01_CLOCK
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N01_CLOCK message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORU_R03_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R03_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R03_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R03_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R01_OBSERVATION> GetAllOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from ORU_R03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORU_R03_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R03_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R03_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R03_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORU_R03_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORU_R03_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORU_R03_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R03_OBSERVATION> GetAllOBSERVATIONRecords(this ORU_R03_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R03_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from ORU_R03_PATIENT_RESULT
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this ORU_R03_PATIENT_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from ORU_R03_PATIENT_RESULT
        /// </summary>
        public static List<ORU_R03_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this ORU_R03_PATIENT_RESULT message)
        {
            return message.GetAllRecords<ORU_R03_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NK1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNK1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get OBX Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetAL1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDG1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get PR1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetPR1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Get GT1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetGT1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ARD_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ARD_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ARD_A19_INSURANCE> GetAllINSURANCERecords(this ARD_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ARD_A19_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static List<ORU_R01_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetAllRecords<ORU_R01_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORF_R04_ORDER
        /// </summary>
        public static List<ORF_R04_OBSERVATION> GetAllOBSERVATIONRecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<ORF_R04_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTERecords(this NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE2 Records from NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE2Records(this NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Get NTE3 Records from NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE3Records(this NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE3RepetitionsUsed", "GetNTE3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE3 Records from NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE3Records(this NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE3RepetitionsUsed", "GetNTE3");
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBX Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetOBXRecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get NTE2 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTE2Records(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_QUERY_RESPONSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBX Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P01_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get PR1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetPR1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<PR1> GetAllPR1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Get GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get INSURANCE Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from BAR_P01_VISIT
        /// </summary>
        public static List<BAR_P01_INSURANCE> GetAllINSURANCERecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<BAR_P01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }
        #endregion
    }
}
