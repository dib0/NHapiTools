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

namespace NHapiTools.Model.V21.Group
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class GroupExtensions
    {
        #region Extension methods
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
        /// Add a new BAR_P01_VISIT to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P01_VISIT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new BAR_P01_VISIT to PR1
        /// </summary>
        public static PR1 AddPR1(this BAR_P01_VISIT message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
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
        /// Add a new BAR_P01_VISIT to GT1
        /// </summary>
        public static GT1 AddGT1(this BAR_P01_VISIT message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
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
        /// Add a new BAR_P01_VISIT to NK1
        /// </summary>
        public static NK1 AddNK1(this BAR_P01_VISIT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get IN1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetIN1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("IN1RepetitionsUsed", "GetIN1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<IN1> GetAllIN1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<IN1>("IN1RepetitionsUsed", "GetIN1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to IN1
        /// </summary>
        public static IN1 AddIN1(this BAR_P01_VISIT message)
        {
            return message.GetIN1(message.IN1RepetitionsUsed);
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
        /// Add a new ORM_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORM_O01_ORDER_DETAIL to OBX
        /// </summary>
        public static OBX AddOBX(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ORM_O01_ORDER_DETAIL to NTE2
        /// </summary>
        public static NTE AddNTE2(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetNTE2(message.NTE2RepetitionsUsed);
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
        /// Add a new ORM_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORR_O02_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORR_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORR_O02_PATIENT to ORDER
        /// </summary>
        public static ORR_O02_ORDER AddORDER(this ORR_O02_PATIENT message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

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
        /// Add a new ORU_R01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R01_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R01_ORDER_OBSERVATION to OBSERVATION
        /// </summary>
        public static ORU_R01_OBSERVATION AddOBSERVATION(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new ORU_R01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R01_PATIENT_RESULT to ORDER_OBSERVATION
        /// </summary>
        public static ORU_R01_ORDER_OBSERVATION AddORDER_OBSERVATION(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
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
        /// Add a new ORU_R03_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R03_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R03_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R03_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R03_ORDER_OBSERVATION to OBSERVATION
        /// </summary>
        public static ORU_R03_OBSERVATION AddOBSERVATION(this ORU_R03_ORDER_OBSERVATION message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new ORU_R03_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R03_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R03_PATIENT_RESULT to ORDER_OBSERVATION
        /// </summary>
        public static ORU_R03_ORDER_OBSERVATION AddORDER_OBSERVATION(this ORU_R03_PATIENT_RESULT message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }
        #endregion
    }
}
