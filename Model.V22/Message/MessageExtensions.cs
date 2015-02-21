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
using NHapiTools.Base;

namespace NHapiTools.Model.V22.Message
{
    /// <summary>
    /// Message extention methods
    /// </summary>
    public static class MessageExtensions
    {
        #region Extension methods
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
        /// Add a new BAR_P01 to VISIT
        /// </summary>
        public static BAR_P01_VISIT AddVISIT(this BAR_P01 message)
        {
            return message.GetVISIT(message.VISITRepetitionsUsed);
        }

        /// <summary>
        /// Get CLOCK_AND_STATS_WITH_NOTES_ALT Records from NMR_N02
        /// </summary>
        public static IEnumerable GetCLOCK_AND_STATS_WITH_NOTES_ALTRecords(this NMR_N02 message)
        {
            object[] result = message.GetRecords("CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES_ALT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLOCK_AND_STATS_WITH_NOTES_ALT Records from NMR_N02
        /// </summary>
        public static List<NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT> GetAllCLOCK_AND_STATS_WITH_NOTES_ALTRecords(this NMR_N02 message)
        {
            return message.GetAllRecords<NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT>("CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES_ALT");
        }

        /// <summary>
        /// Add a new NMR_N02 to CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT AddCLOCK_AND_STATS_WITH_NOTES_ALT(this NMR_N02 message)
        {
            return message.GetCLOCK_AND_STATS_WITH_NOTES_ALT(message.CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_RESULT Records from ORU_R03
        /// </summary>
        public static IEnumerable GetPATIENT_RESULTRecords(this ORU_R03 message)
        {
            object[] result = message.GetRecords("PATIENT_RESULTRepetitionsUsed", "GetPATIENT_RESULT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_RESULT Records from ORU_R03
        /// </summary>
        public static List<ORU_R03_PATIENT_RESULT> GetAllPATIENT_RESULTRecords(this ORU_R03 message)
        {
            return message.GetAllRecords<ORU_R03_PATIENT_RESULT>("PATIENT_RESULTRepetitionsUsed", "GetPATIENT_RESULT");
        }

        /// <summary>
        /// Add a new ORU_R03 to PATIENT_RESULT
        /// </summary>
        public static ORU_R03_PATIENT_RESULT AddPATIENT_RESULT(this ORU_R03 message)
        {
            return message.GetPATIENT_RESULT(message.PATIENT_RESULTRepetitionsUsed);
        }

        /// <summary>
        /// Get CLOCK_AND_STATS_WITH_NOTES Records from NMD_N01
        /// </summary>
        public static IEnumerable GetCLOCK_AND_STATS_WITH_NOTESRecords(this NMD_N01 message)
        {
            object[] result = message.GetRecords("CLOCK_AND_STATS_WITH_NOTESRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLOCK_AND_STATS_WITH_NOTES Records from NMD_N01
        /// </summary>
        public static List<NMD_N01_CLOCK_AND_STATS_WITH_NOTES> GetAllCLOCK_AND_STATS_WITH_NOTESRecords(this NMD_N01 message)
        {
            return message.GetAllRecords<NMD_N01_CLOCK_AND_STATS_WITH_NOTES>("CLOCK_AND_STATS_WITH_NOTESRepetitionsUsed", "GetCLOCK_AND_STATS_WITH_NOTES");
        }

        /// <summary>
        /// Add a new NMD_N01 to CLOCK_AND_STATS_WITH_NOTES
        /// </summary>
        public static NMD_N01_CLOCK_AND_STATS_WITH_NOTES AddCLOCK_AND_STATS_WITH_NOTES(this NMD_N01 message)
        {
            return message.GetCLOCK_AND_STATS_WITH_NOTES(message.CLOCK_AND_STATS_WITH_NOTESRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from DFT_P03
        /// </summary>
        public static IEnumerable GetOBXRecords(this DFT_P03 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from DFT_P03
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this DFT_P03 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new DFT_P03 to OBX
        /// </summary>
        public static OBX AddOBX(this DFT_P03 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get FT1 Records from DFT_P03
        /// </summary>
        public static IEnumerable GetFT1Records(this DFT_P03 message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from DFT_P03
        /// </summary>
        public static List<FT1> GetAllFT1Records(this DFT_P03 message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Add a new DFT_P03 to FT1
        /// </summary>
        public static FT1 AddFT1(this DFT_P03 message)
        {
            return message.GetFT1(message.FT1RepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFD_M03
        /// </summary>
        public static IEnumerable GetMFARecords(this MFD_M03 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFD_M03
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFD_M03 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFD_M03 to MFA
        /// </summary>
        public static MFA AddMFA(this MFD_M03 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
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
        /// Add a new ADT_A09 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A09 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A09 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A09 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new ORU_R01 to PATIENT_RESULT
        /// </summary>
        public static ORU_R01_PATIENT_RESULT AddPATIENT_RESULT(this ORU_R01 message)
        {
            return message.GetPATIENT_RESULT(message.PATIENT_RESULTRepetitionsUsed);
        }

        /// <summary>
        /// Get MF_TEST Records from MFR_M03
        /// </summary>
        public static IEnumerable GetMF_TESTRecords(this MFR_M03 message)
        {
            object[] result = message.GetRecords("MF_TESTRepetitionsUsed", "GetMF_TEST");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_TEST Records from MFR_M03
        /// </summary>
        public static List<MFR_M03_MF_TEST> GetAllMF_TESTRecords(this MFR_M03 message)
        {
            return message.GetAllRecords<MFR_M03_MF_TEST>("MF_TESTRepetitionsUsed", "GetMF_TEST");
        }

        /// <summary>
        /// Add a new MFR_M03 to MF_TEST
        /// </summary>
        public static MFR_M03_MF_TEST AddMF_TEST(this MFR_M03 message)
        {
            return message.GetMF_TEST(message.MF_TESTRepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFD_M02
        /// </summary>
        public static IEnumerable GetMFARecords(this MFD_M02 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFD_M02
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFD_M02 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFD_M02 to MFA
        /// </summary>
        public static MFA AddMFA(this MFD_M02 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A08
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A08 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A08
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A08 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A08 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A08 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A08
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A08 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A08
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A08 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A08 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A08 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A08
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A08 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A08
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A08 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A08 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A08 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A08
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A08 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A08
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A08 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A08 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A08 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A08
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A08 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A08
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A08 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A08 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A08 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A08
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A08 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A08
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A08 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A08 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A08 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A08
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A08 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A08
        /// </summary>
        public static List<ADT_A08_INSURANCE> GetAllINSURANCERecords(this ADT_A08 message)
        {
            return message.GetAllRecords<ADT_A08_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A08 to INSURANCE
        /// </summary>
        public static ADT_A08_INSURANCE AddINSURANCE(this ADT_A08 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new ORR_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get MF_STAFF Records from MFR_M02
        /// </summary>
        public static IEnumerable GetMF_STAFFRecords(this MFR_M02 message)
        {
            object[] result = message.GetRecords("MF_STAFFRepetitionsUsed", "GetMF_STAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_STAFF Records from MFR_M02
        /// </summary>
        public static List<MFR_M02_MF_STAFF> GetAllMF_STAFFRecords(this MFR_M02 message)
        {
            return message.GetAllRecords<MFR_M02_MF_STAFF>("MF_STAFFRepetitionsUsed", "GetMF_STAFF");
        }

        /// <summary>
        /// Add a new MFR_M02 to MF_STAFF
        /// </summary>
        public static MFR_M02_MF_STAFF AddMF_STAFF(this MFR_M02 message)
        {
            return message.GetMF_STAFF(message.MF_STAFFRepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFD_M01
        /// </summary>
        public static IEnumerable GetMFARecords(this MFD_M01 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFD_M01
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFD_M01 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFD_M01 to MFA
        /// </summary>
        public static MFA AddMFA(this MFD_M01 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A29
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A29 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A29
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A29 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A29 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A29 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A07
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A07 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A07
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A07 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A07 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A07 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A07
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A07 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A07
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A07 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A07 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A07 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A07
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A07 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A07
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A07 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A07 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A07 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A07
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A07 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A07
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A07 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A07 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A07 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A07
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A07 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A07
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A07 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A07 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A07 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A07
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A07 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A07
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A07 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A07 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A07 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A07
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A07 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A07
        /// </summary>
        public static List<ADT_A07_INSURANCE> GetAllINSURANCERecords(this ADT_A07 message)
        {
            return message.GetAllRecords<ADT_A07_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A07 to INSURANCE
        /// </summary>
        public static ADT_A07_INSURANCE AddINSURANCE(this ADT_A07 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get MF Records from MFR_M01
        /// </summary>
        public static IEnumerable GetMFRecords(this MFR_M01 message)
        {
            object[] result = message.GetRecords("MFRepetitionsUsed", "GetMF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF Records from MFR_M01
        /// </summary>
        public static List<MFR_M01_MF> GetAllMFRecords(this MFR_M01 message)
        {
            return message.GetAllRecords<MFR_M01_MF>("MFRepetitionsUsed", "GetMF");
        }

        /// <summary>
        /// Add a new MFR_M01 to MF
        /// </summary>
        public static MFR_M01_MF AddMF(this MFR_M01 message)
        {
            return message.GetMF(message.MFRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A28
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A28 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A28
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A28 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A28 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A28 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A28
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A28 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A28
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A28 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A28 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A28 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A28
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A28 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A28
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A28 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A28 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A28 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A28
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A28 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A28
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A28 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A28 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A28 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A28
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A28 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A28
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A28 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A28 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A28 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A28
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A28 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A28
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A28 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A28 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A28 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A28
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A28 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A28
        /// </summary>
        public static List<ADT_A28_INSURANCE> GetAllINSURANCERecords(this ADT_A28 message)
        {
            return message.GetAllRecords<ADT_A28_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A28 to INSURANCE
        /// </summary>
        public static ADT_A28_INSURANCE AddINSURANCE(this ADT_A28 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new ADT_A17 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A17 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A17 to OBX2
        /// </summary>
        public static OBX AddOBX2(this ADT_A17 message)
        {
            return message.GetOBX2(message.OBX2RepetitionsUsed);
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
        /// Add a new ADT_A06 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A06 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new ADT_A06 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A06 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A06 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A06 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new ADT_A06 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A06 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A06
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A06 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A06 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A06 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
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
        /// Add a new ADT_A06 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A06 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A06
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A06 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A06
        /// </summary>
        public static List<ADT_A06_INSURANCE> GetAllINSURANCERecords(this ADT_A06 message)
        {
            return message.GetAllRecords<ADT_A06_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A06 to INSURANCE
        /// </summary>
        public static ADT_A06_INSURANCE AddINSURANCE(this ADT_A06 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A27
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A27 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A27
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A27 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A27 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A27 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A16 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A16 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A16 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A16 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new ADT_A05 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A05 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new ADT_A05 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A05 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A05 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A05 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new ADT_A05 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A05 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A05
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A05 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A05 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A05 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
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
        /// Add a new ADT_A05 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A05 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A05
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A05 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A05
        /// </summary>
        public static List<ADT_A05_INSURANCE> GetAllINSURANCERecords(this ADT_A05 message)
        {
            return message.GetAllRecords<ADT_A05_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A05 to INSURANCE
        /// </summary>
        public static ADT_A05_INSURANCE AddINSURANCE(this ADT_A05 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A26
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A26 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A26
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A26 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A26 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A26 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A15 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A15 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A15 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A15 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A04
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A04 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A04
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A04 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A04 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A04 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A04
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A04 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A04
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A04 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A04 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A04 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A04
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A04 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A04
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A04 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A04 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A04 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A04
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A04 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A04
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A04 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A04 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A04 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A04
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A04 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A04
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A04 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A04 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A04 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A04
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A04 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A04
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A04 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A04 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A04 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A04
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A04 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A04
        /// </summary>
        public static List<ADT_A04_INSURANCE> GetAllINSURANCERecords(this ADT_A04 message)
        {
            return message.GetAllRecords<ADT_A04_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A04 to INSURANCE
        /// </summary>
        public static ADT_A04_INSURANCE AddINSURANCE(this ADT_A04 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A25
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A25 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A25
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A25 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A25 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A25 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A14
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A14 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A14
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A14 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A14 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A14 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A14
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A14 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A14
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A14 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A14 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A14 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A14
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A14 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A14
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A14 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A14 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A14 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A14
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A14 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A14
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A14 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A14 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A14 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A14
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A14 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A14
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A14 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A14 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A14 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A14
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A14 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A14
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A14 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A14 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A14 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A14
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A14 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A14
        /// </summary>
        public static List<ADT_A14_INSURANCE> GetAllINSURANCERecords(this ADT_A14 message)
        {
            return message.GetAllRecords<ADT_A14_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A14 to INSURANCE
        /// </summary>
        public static ADT_A14_INSURANCE AddINSURANCE(this ADT_A14 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new ADT_A03 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A03 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ORM_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORM_O01 to ORDER
        /// </summary>
        public static ORM_O01_ORDER AddORDER(this ORM_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A13
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A13 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A13
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A13 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A13 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A13 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A13
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A13 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A13
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A13 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A13 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A13 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A13
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A13 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A13
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A13 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A13 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A13 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A13
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A13 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A13
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A13 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A13 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A13 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A13
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A13 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A13
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A13 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A13 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A13 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A13
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A13 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A13
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A13 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A13 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A13 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A13
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A13 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A13
        /// </summary>
        public static List<ADT_A13_INSURANCE> GetAllINSURANCERecords(this ADT_A13 message)
        {
            return message.GetAllRecords<ADT_A13_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A13 to INSURANCE
        /// </summary>
        public static ADT_A13_INSURANCE AddINSURANCE(this ADT_A13 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new ADT_A02 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A02 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DSP Records from DSR_R03
        /// </summary>
        public static IEnumerable GetDSPRecords(this DSR_R03 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from DSR_R03
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this DSR_R03 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Add a new DSR_R03 to DSP
        /// </summary>
        public static DSP AddDSP(this DSR_R03 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from ARD_A19
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this ARD_A19 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from ARD_A19
        /// </summary>
        public static List<ARD_A19_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this ARD_A19 message)
        {
            return message.GetAllRecords<ARD_A19_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Add a new ARD_A19 to QUERY_RESPONSE
        /// </summary>
        public static ARD_A19_QUERY_RESPONSE AddQUERY_RESPONSE(this ARD_A19 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A23
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A23 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A23
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A23 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A23 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A23 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A12 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A12 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A12
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A12 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A12
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A12 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A12 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A12 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new ADT_A01 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A01 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new ADT_A01 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A01 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A01 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A01 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new ADT_A01 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A01 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A01
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A01 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A01 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A01 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
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
        /// Add a new ADT_A01 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A01 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A01
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A01 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A01
        /// </summary>
        public static List<ADT_A01_INSURANCE> GetAllINSURANCERecords(this ADT_A01 message)
        {
            return message.GetAllRecords<ADT_A01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A01 to INSURANCE
        /// </summary>
        public static ADT_A01_INSURANCE AddINSURANCE(this ADT_A01 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from ORF_R04
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this ORF_R04 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from ORF_R04
        /// </summary>
        public static List<ORF_R04_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this ORF_R04 message)
        {
            return message.GetAllRecords<ORF_R04_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Add a new ORF_R04 to QUERY_RESPONSE
        /// </summary>
        public static ORF_R04_QUERY_RESPONSE AddQUERY_RESPONSE(this ORF_R04 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORF_R04
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORF_R04 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORF_R04
        /// </summary>
        public static List<ORF_R04_ORDER> GetAllORDERRecords(this ORF_R04 message)
        {
            return message.GetAllRecords<ORF_R04_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORF_R04 to ORDER
        /// </summary>
        public static ORF_R04_ORDER AddORDER(this ORF_R04 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get CLOCK_AND_STATISTICS Records from NMQ_N02
        /// </summary>
        public static IEnumerable GetCLOCK_AND_STATISTICSRecords(this NMQ_N02 message)
        {
            object[] result = message.GetRecords("CLOCK_AND_STATISTICSRepetitionsUsed", "GetCLOCK_AND_STATISTICS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLOCK_AND_STATISTICS Records from NMQ_N02
        /// </summary>
        public static List<NMQ_N02_CLOCK_AND_STATISTICS> GetAllCLOCK_AND_STATISTICSRecords(this NMQ_N02 message)
        {
            return message.GetAllRecords<NMQ_N02_CLOCK_AND_STATISTICS>("CLOCK_AND_STATISTICSRepetitionsUsed", "GetCLOCK_AND_STATISTICS");
        }

        /// <summary>
        /// Add a new NMQ_N02 to CLOCK_AND_STATISTICS
        /// </summary>
        public static NMQ_N02_CLOCK_AND_STATISTICS AddCLOCK_AND_STATISTICS(this NMQ_N02 message)
        {
            return message.GetCLOCK_AND_STATISTICS(message.CLOCK_AND_STATISTICSRepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFK_M03
        /// </summary>
        public static IEnumerable GetMFARecords(this MFK_M03 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFK_M03
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFK_M03 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFK_M03 to MFA
        /// </summary>
        public static MFA AddMFA(this MFK_M03 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
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
        /// Add a new DSR_Q03 to DSP
        /// </summary>
        public static DSP AddDSP(this DSR_Q03 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
        }

        /// <summary>
        /// Get DSP Records from DSR_P04
        /// </summary>
        public static IEnumerable GetDSPRecords(this DSR_P04 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from DSR_P04
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this DSR_P04 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Add a new DSR_P04 to DSP
        /// </summary>
        public static DSP AddDSP(this DSR_P04 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A33
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A33 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A33
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A33 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A33 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A33 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A22
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A22 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A22
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A22 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A22 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A22 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A11
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A11 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A11
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A11 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A11 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A11 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A11
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A11 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A11
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A11 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A11 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A11 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new MFN_M03 to MF_TEST
        /// </summary>
        public static MFN_M03_MF_TEST AddMF_TEST(this MFN_M03 message)
        {
            return message.GetMF_TEST(message.MF_TESTRepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFK_M02
        /// </summary>
        public static IEnumerable GetMFARecords(this MFK_M02 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFK_M02
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFK_M02 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFK_M02 to MFA
        /// </summary>
        public static MFA AddMFA(this MFK_M02 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A32
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A32 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A32
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A32 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A32 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A32 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A21 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A21 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A10
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A10 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A10
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A10 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A10 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A10 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A10
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A10 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A10
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A10 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A10 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A10 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new UDM_Q05 to DSP
        /// </summary>
        public static DSP AddDSP(this UDM_Q05 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
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
        /// Add a new MFN_M02 to MF_STAFF
        /// </summary>
        public static MFN_M02_MF_STAFF AddMF_STAFF(this MFN_M02 message)
        {
            return message.GetMF_STAFF(message.MF_STAFFRepetitionsUsed);
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
        /// Add a new MFK_M01 to MFA
        /// </summary>
        public static MFA AddMFA(this MFK_M01 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
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
        /// Add a new DSR_Q01 to DSP
        /// </summary>
        public static DSP AddDSP(this DSR_Q01 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADT_A31
        /// </summary>
        public static IEnumerable GetNK1Records(this ADT_A31 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADT_A31
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADT_A31 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADT_A31 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A31 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADT_A31
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADT_A31 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADT_A31
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADT_A31 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADT_A31 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A31 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADT_A31
        /// </summary>
        public static IEnumerable GetAL1Records(this ADT_A31 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADT_A31
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADT_A31 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADT_A31 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A31 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADT_A31
        /// </summary>
        public static IEnumerable GetDG1Records(this ADT_A31 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADT_A31
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADT_A31 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADT_A31 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A31 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PR1 Records from ADT_A31
        /// </summary>
        public static IEnumerable GetPR1Records(this ADT_A31 message)
        {
            object[] result = message.GetRecords("PR1RepetitionsUsed", "GetPR1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PR1 Records from ADT_A31
        /// </summary>
        public static List<PR1> GetAllPR1Records(this ADT_A31 message)
        {
            return message.GetAllRecords<PR1>("PR1RepetitionsUsed", "GetPR1");
        }

        /// <summary>
        /// Add a new ADT_A31 to PR1
        /// </summary>
        public static PR1 AddPR1(this ADT_A31 message)
        {
            return message.GetPR1(message.PR1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADT_A31
        /// </summary>
        public static IEnumerable GetGT1Records(this ADT_A31 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADT_A31
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADT_A31 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADT_A31 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A31 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A31
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A31 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A31
        /// </summary>
        public static List<ADT_A31_INSURANCE> GetAllINSURANCERecords(this ADT_A31 message)
        {
            return message.GetAllRecords<ADT_A31_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A31 to INSURANCE
        /// </summary>
        public static ADT_A31_INSURANCE AddINSURANCE(this ADT_A31 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new MFN_M01 to MF
        /// </summary>
        public static MFN_M01_MF AddMF(this MFN_M01 message)
        {
            return message.GetMF(message.MFRepetitionsUsed);
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
        /// Add a new BAR_P02 to PATIENT
        /// </summary>
        public static BAR_P02_PATIENT AddPATIENT(this BAR_P02 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }
        #endregion
    }
}
