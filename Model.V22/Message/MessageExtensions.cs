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
        #endregion
    }
}
