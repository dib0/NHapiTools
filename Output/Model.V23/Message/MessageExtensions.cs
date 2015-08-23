using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V23.Group;
using NHapi.Model.V23.Message;
using NHapi.Model.V23.Segment;
using NHapiTools.Base;

namespace NHapiTools.Model.V23.Message
{
    /// <summary>
    /// Message extention methods
    /// </summary>
    public static class MessageExtensions
    {
        #region Extension methods
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
        /// Add a new ADT_A01 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A01 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A01
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A01 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A01
        /// </summary>
        public static List<ADT_A01_PROCEDURE> GetAllPROCEDURERecords(this ADT_A01 message)
        {
            return message.GetAllRecords<ADT_A01_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A01 to PROCEDURE
        /// </summary>
        public static ADT_A01_PROCEDURE AddPROCEDURE(this ADT_A01 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new ADT_A02 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A02 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A03 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A03 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A03 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A03 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from ADT_A03
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A03 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A03
        /// </summary>
        public static List<ADT_A03_PROCEDURE> GetAllPROCEDURERecords(this ADT_A03 message)
        {
            return message.GetAllRecords<ADT_A03_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A03 to PROCEDURE
        /// </summary>
        public static ADT_A03_PROCEDURE AddPROCEDURE(this ADT_A03 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Get DB1 Records from ADT_A04
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A04 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A04
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A04 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A04 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A04 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A04
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A04 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A04
        /// </summary>
        public static List<ADT_A04_PROCEDURE> GetAllPROCEDURERecords(this ADT_A04 message)
        {
            return message.GetAllRecords<ADT_A04_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A04 to PROCEDURE
        /// </summary>
        public static ADT_A04_PROCEDURE AddPROCEDURE(this ADT_A04 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new ADT_A05 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A05 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A05
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A05 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A05
        /// </summary>
        public static List<ADT_A05_PROCEDURE> GetAllPROCEDURERecords(this ADT_A05 message)
        {
            return message.GetAllRecords<ADT_A05_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A05 to PROCEDURE
        /// </summary>
        public static ADT_A05_PROCEDURE AddPROCEDURE(this ADT_A05 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new ADT_A06 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A06 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A06
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A06 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A06
        /// </summary>
        public static List<ADT_A06_PROCEDURE> GetAllPROCEDURERecords(this ADT_A06 message)
        {
            return message.GetAllRecords<ADT_A06_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A06 to PROCEDURE
        /// </summary>
        public static ADT_A06_PROCEDURE AddPROCEDURE(this ADT_A06 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Get DB1 Records from ADT_A07
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A07 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A07
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A07 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A07 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A07 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A07
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A07 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A07
        /// </summary>
        public static List<ADT_A07_PROCEDURE> GetAllPROCEDURERecords(this ADT_A07 message)
        {
            return message.GetAllRecords<ADT_A07_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A07 to PROCEDURE
        /// </summary>
        public static ADT_A07_PROCEDURE AddPROCEDURE(this ADT_A07 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Get DB1 Records from ADT_A08
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A08 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A08
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A08 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A08 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A08 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A08
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A08 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A08
        /// </summary>
        public static List<ADT_A08_PROCEDURE> GetAllPROCEDURERecords(this ADT_A08 message)
        {
            return message.GetAllRecords<ADT_A08_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A08 to PROCEDURE
        /// </summary>
        public static ADT_A08_PROCEDURE AddPROCEDURE(this ADT_A08 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new ADT_A09 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A09 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A10
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A10 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A10
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A10 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A10 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A10 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A11
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A11 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A11
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A11 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A11 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A11 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A12 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A12 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A13
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A13 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A13
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A13 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A13 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A13 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A13
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A13 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A13
        /// </summary>
        public static List<ADT_A13_PROCEDURE> GetAllPROCEDURERecords(this ADT_A13 message)
        {
            return message.GetAllRecords<ADT_A13_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A13 to PROCEDURE
        /// </summary>
        public static ADT_A13_PROCEDURE AddPROCEDURE(this ADT_A13 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Get DB1 Records from ADT_A14
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A14 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A14
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A14 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A14 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A14 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A14
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A14 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A14
        /// </summary>
        public static List<ADT_A14_PROCEDURE> GetAllPROCEDURERecords(this ADT_A14 message)
        {
            return message.GetAllRecords<ADT_A14_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A14 to PROCEDURE
        /// </summary>
        public static ADT_A14_PROCEDURE AddPROCEDURE(this ADT_A14 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new ADT_A15 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A15 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A16 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A16 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A17 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A17 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A17 to DB12
        /// </summary>
        public static DB1 AddDB12(this ADT_A17 message)
        {
            return message.GetDB12(message.DB12RepetitionsUsed);
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
        /// Add a new ADT_A21 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A21 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A22
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A22 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A22
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A22 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A22 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A22 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A23
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A23 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A23
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A23 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A23 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A23 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A24 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A24 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A24 to DB12
        /// </summary>
        public static DB1 AddDB12(this ADT_A24 message)
        {
            return message.GetDB12(message.DB12RepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from ADT_A25
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A25 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A25
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A25 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A25 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A25 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A26
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A26 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A26
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A26 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A26 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A26 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A27
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A27 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A27
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A27 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A27 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A27 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A28
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A28 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A28
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A28 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A28 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A28 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A28
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A28 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A28
        /// </summary>
        public static List<ADT_A28_PROCEDURE> GetAllPROCEDURERecords(this ADT_A28 message)
        {
            return message.GetAllRecords<ADT_A28_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A28 to PROCEDURE
        /// </summary>
        public static ADT_A28_PROCEDURE AddPROCEDURE(this ADT_A28 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Get DB1 Records from ADT_A29
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A29 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A29
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A29 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A29 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A29 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A31
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A31 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A31
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A31 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A31 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A31 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A31
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A31 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A31
        /// </summary>
        public static List<ADT_A31_PROCEDURE> GetAllPROCEDURERecords(this ADT_A31 message)
        {
            return message.GetAllRecords<ADT_A31_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A31 to PROCEDURE
        /// </summary>
        public static ADT_A31_PROCEDURE AddPROCEDURE(this ADT_A31 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Get DB1 Records from ADT_A32
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A32 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A32
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A32 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A32 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A32 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Get DB1 Records from ADT_A33
        /// </summary>
        public static IEnumerable GetDB1Records(this ADT_A33 message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADT_A33
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADT_A33 message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADT_A33 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A33 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A37 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A37 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A37 to DB12
        /// </summary>
        public static DB1 AddDB12(this ADT_A37 message)
        {
            return message.GetDB12(message.DB12RepetitionsUsed);
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
        /// Add a new ADT_A38 to DB1
        /// </summary>
        public static DB1 AddDB1(this ADT_A38 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new ADT_A38 to OBX
        /// </summary>
        public static OBX AddOBX(this ADT_A38 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Add a new ADT_A38 to DG1
        /// </summary>
        public static DG1 AddDG1(this ADT_A38 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new ADT_A39 to PATIENT
        /// </summary>
        public static ADT_A39_PATIENT AddPATIENT(this ADT_A39 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from ADT_A40
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this ADT_A40 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from ADT_A40
        /// </summary>
        public static List<ADT_A40_PATIENT> GetAllPATIENTRecords(this ADT_A40 message)
        {
            return message.GetAllRecords<ADT_A40_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new ADT_A40 to PATIENT
        /// </summary>
        public static ADT_A40_PATIENT AddPATIENT(this ADT_A40 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from ADT_A41
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this ADT_A41 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from ADT_A41
        /// </summary>
        public static List<ADT_A41_PATIENT> GetAllPATIENTRecords(this ADT_A41 message)
        {
            return message.GetAllRecords<ADT_A41_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new ADT_A41 to PATIENT
        /// </summary>
        public static ADT_A41_PATIENT AddPATIENT(this ADT_A41 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from ADT_A42
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this ADT_A42 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from ADT_A42
        /// </summary>
        public static List<ADT_A42_PATIENT> GetAllPATIENTRecords(this ADT_A42 message)
        {
            return message.GetAllRecords<ADT_A42_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new ADT_A42 to PATIENT
        /// </summary>
        public static ADT_A42_PATIENT AddPATIENT(this ADT_A42 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new ADT_A43 to PATIENT
        /// </summary>
        public static ADT_A43_PATIENT AddPATIENT(this ADT_A43 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from ADT_A44
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this ADT_A44 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from ADT_A44
        /// </summary>
        public static List<ADT_A44_PATIENT> GetAllPATIENTRecords(this ADT_A44 message)
        {
            return message.GetAllRecords<ADT_A44_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new ADT_A44 to PATIENT
        /// </summary>
        public static ADT_A44_PATIENT AddPATIENT(this ADT_A44 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new ADT_A45 to MERGE_INFO
        /// </summary>
        public static ADT_A45_MERGE_INFO AddMERGE_INFO(this ADT_A45 message)
        {
            return message.GetMERGE_INFO(message.MERGE_INFORepetitionsUsed);
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
        /// Add a new BAR_P05 to VISIT
        /// </summary>
        public static BAR_P05_VISIT AddVISIT(this BAR_P05 message)
        {
            return message.GetVISIT(message.VISITRepetitionsUsed);
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
        /// Add a new BAR_P06 to PATIENT
        /// </summary>
        public static BAR_P06_PATIENT AddPATIENT(this BAR_P06 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new CRM_C01 to PATIENT
        /// </summary>
        public static CRM_C01_PATIENT AddPATIENT(this CRM_C01 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C02
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C02 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C02
        /// </summary>
        public static List<CRM_C02_PATIENT> GetAllPATIENTRecords(this CRM_C02 message)
        {
            return message.GetAllRecords<CRM_C02_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C02 to PATIENT
        /// </summary>
        public static CRM_C02_PATIENT AddPATIENT(this CRM_C02 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C03
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C03 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C03
        /// </summary>
        public static List<CRM_C03_PATIENT> GetAllPATIENTRecords(this CRM_C03 message)
        {
            return message.GetAllRecords<CRM_C03_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C03 to PATIENT
        /// </summary>
        public static CRM_C03_PATIENT AddPATIENT(this CRM_C03 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C04
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C04 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C04
        /// </summary>
        public static List<CRM_C04_PATIENT> GetAllPATIENTRecords(this CRM_C04 message)
        {
            return message.GetAllRecords<CRM_C04_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C04 to PATIENT
        /// </summary>
        public static CRM_C04_PATIENT AddPATIENT(this CRM_C04 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C05
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C05 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C05
        /// </summary>
        public static List<CRM_C05_PATIENT> GetAllPATIENTRecords(this CRM_C05 message)
        {
            return message.GetAllRecords<CRM_C05_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C05 to PATIENT
        /// </summary>
        public static CRM_C05_PATIENT AddPATIENT(this CRM_C05 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C06
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C06 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C06
        /// </summary>
        public static List<CRM_C06_PATIENT> GetAllPATIENTRecords(this CRM_C06 message)
        {
            return message.GetAllRecords<CRM_C06_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C06 to PATIENT
        /// </summary>
        public static CRM_C06_PATIENT AddPATIENT(this CRM_C06 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C07
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C07 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C07
        /// </summary>
        public static List<CRM_C07_PATIENT> GetAllPATIENTRecords(this CRM_C07 message)
        {
            return message.GetAllRecords<CRM_C07_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C07 to PATIENT
        /// </summary>
        public static CRM_C07_PATIENT AddPATIENT(this CRM_C07 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CRM_C08
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CRM_C08 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CRM_C08
        /// </summary>
        public static List<CRM_C08_PATIENT> GetAllPATIENTRecords(this CRM_C08 message)
        {
            return message.GetAllRecords<CRM_C08_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CRM_C08 to PATIENT
        /// </summary>
        public static CRM_C08_PATIENT AddPATIENT(this CRM_C08 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new CSU_C09 to PATIENT
        /// </summary>
        public static CSU_C09_PATIENT AddPATIENT(this CSU_C09 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CSU_C10
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CSU_C10 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CSU_C10
        /// </summary>
        public static List<CSU_C10_PATIENT> GetAllPATIENTRecords(this CSU_C10 message)
        {
            return message.GetAllRecords<CSU_C10_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CSU_C10 to PATIENT
        /// </summary>
        public static CSU_C10_PATIENT AddPATIENT(this CSU_C10 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CSU_C11
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CSU_C11 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CSU_C11
        /// </summary>
        public static List<CSU_C11_PATIENT> GetAllPATIENTRecords(this CSU_C11 message)
        {
            return message.GetAllRecords<CSU_C11_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CSU_C11 to PATIENT
        /// </summary>
        public static CSU_C11_PATIENT AddPATIENT(this CSU_C11 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CSU_C12
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CSU_C12 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CSU_C12
        /// </summary>
        public static List<CSU_C12_PATIENT> GetAllPATIENTRecords(this CSU_C12 message)
        {
            return message.GetAllRecords<CSU_C12_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CSU_C12 to PATIENT
        /// </summary>
        public static CSU_C12_PATIENT AddPATIENT(this CSU_C12 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new DFT_P03 to DB1
        /// </summary>
        public static DB1 AddDB1(this DFT_P03 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
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
        /// Add a new DFT_P03 to FINANCIAL
        /// </summary>
        public static DFT_P03_FINANCIAL AddFINANCIAL(this DFT_P03 message)
        {
            return message.GetFINANCIAL(message.FINANCIALRepetitionsUsed);
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
        /// Add a new DFT_P03 to DG1
        /// </summary>
        public static DG1 AddDG1(this DFT_P03 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new DFT_P03 to GT1
        /// </summary>
        public static GT1 AddGT1(this DFT_P03 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from DFT_P03
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this DFT_P03 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from DFT_P03
        /// </summary>
        public static List<DFT_P03_INSURANCE> GetAllINSURANCERecords(this DFT_P03 message)
        {
            return message.GetAllRecords<DFT_P03_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new DFT_P03 to INSURANCE
        /// </summary>
        public static DFT_P03_INSURANCE AddINSURANCE(this DFT_P03 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new DOC_T12 to RESULT
        /// </summary>
        public static DOC_T12_RESULT AddRESULT(this DOC_T12 message)
        {
            return message.GetRESULT(message.RESULTRepetitionsUsed);
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
        /// Get DSP Records from EDR_Q01
        /// </summary>
        public static IEnumerable GetDSPRecords(this EDR_Q01 message)
        {
            object[] result = message.GetRecords("DSPRepetitionsUsed", "GetDSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DSP Records from EDR_Q01
        /// </summary>
        public static List<DSP> GetAllDSPRecords(this EDR_Q01 message)
        {
            return message.GetAllRecords<DSP>("DSPRepetitionsUsed", "GetDSP");
        }

        /// <summary>
        /// Add a new EDR_Q01 to DSP
        /// </summary>
        public static DSP AddDSP(this EDR_Q01 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from MDM_T02
        /// </summary>
        public static IEnumerable GetOBXRecords(this MDM_T02 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from MDM_T02
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this MDM_T02 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new MDM_T02 to OBX
        /// </summary>
        public static OBX AddOBX(this MDM_T02 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from MDM_T04
        /// </summary>
        public static IEnumerable GetOBXRecords(this MDM_T04 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from MDM_T04
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this MDM_T04 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new MDM_T04 to OBX
        /// </summary>
        public static OBX AddOBX(this MDM_T04 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from MDM_T06
        /// </summary>
        public static IEnumerable GetOBXRecords(this MDM_T06 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from MDM_T06
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this MDM_T06 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new MDM_T06 to OBX
        /// </summary>
        public static OBX AddOBX(this MDM_T06 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from MDM_T08
        /// </summary>
        public static IEnumerable GetOBXRecords(this MDM_T08 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from MDM_T08
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this MDM_T08 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new MDM_T08 to OBX
        /// </summary>
        public static OBX AddOBX(this MDM_T08 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from MDM_T10
        /// </summary>
        public static IEnumerable GetOBXRecords(this MDM_T10 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from MDM_T10
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this MDM_T10 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new MDM_T10 to OBX
        /// </summary>
        public static OBX AddOBX(this MDM_T10 message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
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
        /// Get MF Records from MFK_M01
        /// </summary>
        public static IEnumerable GetMFRecords(this MFK_M01 message)
        {
            object[] result = message.GetRecords("MFRepetitionsUsed", "GetMF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF Records from MFK_M01
        /// </summary>
        public static List<MFK_M01_MF> GetAllMFRecords(this MFK_M01 message)
        {
            return message.GetAllRecords<MFK_M01_MF>("MFRepetitionsUsed", "GetMF");
        }

        /// <summary>
        /// Add a new MFK_M01 to MF
        /// </summary>
        public static MFK_M01_MF AddMF(this MFK_M01 message)
        {
            return message.GetMF(message.MFRepetitionsUsed);
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
        /// Get MFA Records from MFK_M04
        /// </summary>
        public static IEnumerable GetMFARecords(this MFK_M04 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFK_M04
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFK_M04 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFK_M04 to MFA
        /// </summary>
        public static MFA AddMFA(this MFK_M04 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFK_M05
        /// </summary>
        public static IEnumerable GetMFARecords(this MFK_M05 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFK_M05
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFK_M05 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFK_M05 to MFA
        /// </summary>
        public static MFA AddMFA(this MFK_M05 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
        }

        /// <summary>
        /// Get MFA Records from MFK_M07
        /// </summary>
        public static IEnumerable GetMFARecords(this MFK_M07 message)
        {
            object[] result = message.GetRecords("MFARepetitionsUsed", "GetMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MFA Records from MFK_M07
        /// </summary>
        public static List<MFA> GetAllMFARecords(this MFK_M07 message)
        {
            return message.GetAllRecords<MFA>("MFARepetitionsUsed", "GetMFA");
        }

        /// <summary>
        /// Add a new MFK_M07 to MFA
        /// </summary>
        public static MFA AddMFA(this MFK_M07 message)
        {
            return message.GetMFA(message.MFARepetitionsUsed);
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
        /// Add a new MFN_M04 to MF_CDM
        /// </summary>
        public static MFN_M04_MF_CDM AddMF_CDM(this MFN_M04 message)
        {
            return message.GetMF_CDM(message.MF_CDMRepetitionsUsed);
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
        /// Add a new MFN_M05 to MF_LOCATION
        /// </summary>
        public static MFN_M05_MF_LOCATION AddMF_LOCATION(this MFN_M05 message)
        {
            return message.GetMF_LOCATION(message.MF_LOCATIONRepetitionsUsed);
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
        /// Add a new MFN_M06 to MF_CLIN_STUDY
        /// </summary>
        public static MFN_M06_MF_CLIN_STUDY AddMF_CLIN_STUDY(this MFN_M06 message)
        {
            return message.GetMF_CLIN_STUDY(message.MF_CLIN_STUDYRepetitionsUsed);
        }

        /// <summary>
        /// Get MF_CLIN_STUDY Records from MFN_M07
        /// </summary>
        public static IEnumerable GetMF_CLIN_STUDYRecords(this MFN_M07 message)
        {
            object[] result = message.GetRecords("MF_CLIN_STUDYRepetitionsUsed", "GetMF_CLIN_STUDY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_CLIN_STUDY Records from MFN_M07
        /// </summary>
        public static List<MFN_M07_MF_CLIN_STUDY> GetAllMF_CLIN_STUDYRecords(this MFN_M07 message)
        {
            return message.GetAllRecords<MFN_M07_MF_CLIN_STUDY>("MF_CLIN_STUDYRepetitionsUsed", "GetMF_CLIN_STUDY");
        }

        /// <summary>
        /// Add a new MFN_M07 to MF_CLIN_STUDY
        /// </summary>
        public static MFN_M07_MF_CLIN_STUDY AddMF_CLIN_STUDY(this MFN_M07 message)
        {
            return message.GetMF_CLIN_STUDY(message.MF_CLIN_STUDYRepetitionsUsed);
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
        /// Add a new MFN_M08 to MF_TEST_NUMERIC
        /// </summary>
        public static MFN_M08_MF_TEST_NUMERIC AddMF_TEST_NUMERIC(this MFN_M08 message)
        {
            return message.GetMF_TEST_NUMERIC(message.MF_TEST_NUMERICRepetitionsUsed);
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
        /// Add a new MFN_M09 to MF_TEST_CATEGORICAL
        /// </summary>
        public static MFN_M09_MF_TEST_CATEGORICAL AddMF_TEST_CATEGORICAL(this MFN_M09 message)
        {
            return message.GetMF_TEST_CATEGORICAL(message.MF_TEST_CATEGORICALRepetitionsUsed);
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
        /// Add a new MFN_M10 to MF_TEST_BATTERIES
        /// </summary>
        public static MFN_M10_MF_TEST_BATTERIES AddMF_TEST_BATTERIES(this MFN_M10 message)
        {
            return message.GetMF_TEST_BATTERIES(message.MF_TEST_BATTERIESRepetitionsUsed);
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
        /// Add a new MFN_M11 to MF_TEST_CALCULATED
        /// </summary>
        public static MFN_M11_MF_TEST_CALCULATED AddMF_TEST_CALCULATED(this MFN_M11 message)
        {
            return message.GetMF_TEST_CALCULATED(message.MF_TEST_CALCULATEDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_DIET Records from OMD_O01
        /// </summary>
        public static IEnumerable GetORDER_DIETRecords(this OMD_O01 message)
        {
            object[] result = message.GetRecords("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_DIET Records from OMD_O01
        /// </summary>
        public static List<OMD_O01_ORDER_DIET> GetAllORDER_DIETRecords(this OMD_O01 message)
        {
            return message.GetAllRecords<OMD_O01_ORDER_DIET>("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");
        }

        /// <summary>
        /// Add a new OMD_O01 to ORDER_DIET
        /// </summary>
        public static OMD_O01_ORDER_DIET AddORDER_DIET(this OMD_O01 message)
        {
            return message.GetORDER_DIET(message.ORDER_DIETRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_TRAY Records from OMD_O01
        /// </summary>
        public static IEnumerable GetORDER_TRAYRecords(this OMD_O01 message)
        {
            object[] result = message.GetRecords("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_TRAY Records from OMD_O01
        /// </summary>
        public static List<OMD_O01_ORDER_TRAY> GetAllORDER_TRAYRecords(this OMD_O01 message)
        {
            return message.GetAllRecords<OMD_O01_ORDER_TRAY>("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");
        }

        /// <summary>
        /// Add a new OMD_O01 to ORDER_TRAY
        /// </summary>
        public static OMD_O01_ORDER_TRAY AddORDER_TRAY(this OMD_O01 message)
        {
            return message.GetORDER_TRAY(message.ORDER_TRAYRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OMN_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMN_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMN_O01
        /// </summary>
        public static List<OMN_O01_ORDER> GetAllORDERRecords(this OMN_O01 message)
        {
            return message.GetAllRecords<OMN_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OMN_O01 to ORDER
        /// </summary>
        public static OMN_O01_ORDER AddORDER(this OMN_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OMS_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this OMS_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OMS_O01
        /// </summary>
        public static List<OMS_O01_ORDER> GetAllORDERRecords(this OMS_O01 message)
        {
            return message.GetAllRecords<OMS_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OMS_O01 to ORDER
        /// </summary>
        public static OMS_O01_ORDER AddORDER(this OMS_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from ORF_R02
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this ORF_R02 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from ORF_R02
        /// </summary>
        public static List<ORF_R02_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this ORF_R02 message)
        {
            return message.GetAllRecords<ORF_R02_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Add a new ORF_R02 to QUERY_RESPONSE
        /// </summary>
        public static ORF_R02_QUERY_RESPONSE AddQUERY_RESPONSE(this ORF_R02 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Get NTE Records from ORN_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORN_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this ORN_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Get RESPONSE Records from ORU_R01
        /// </summary>
        public static IEnumerable GetRESPONSERecords(this ORU_R01 message)
        {
            object[] result = message.GetRecords("RESPONSERepetitionsUsed", "GetRESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESPONSE Records from ORU_R01
        /// </summary>
        public static List<ORU_R01_RESPONSE> GetAllRESPONSERecords(this ORU_R01 message)
        {
            return message.GetAllRecords<ORU_R01_RESPONSE>("RESPONSERepetitionsUsed", "GetRESPONSE");
        }

        /// <summary>
        /// Add a new ORU_R01 to RESPONSE
        /// </summary>
        public static ORU_R01_RESPONSE AddRESPONSE(this ORU_R01 message)
        {
            return message.GetRESPONSE(message.RESPONSERepetitionsUsed);
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
        /// Add a new OSR_Q06 to NTE
        /// </summary>
        public static NTE AddNTE(this OSR_Q06 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new PEX_P07 to NTE
        /// </summary>
        public static NTE AddNTE(this PEX_P07 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new PEX_P07 to EXPERIENCE
        /// </summary>
        public static PEX_P07_EXPERIENCE AddEXPERIENCE(this PEX_P07 message)
        {
            return message.GetEXPERIENCE(message.EXPERIENCERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PEX_P08
        /// </summary>
        public static IEnumerable GetNTERecords(this PEX_P08 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PEX_P08
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PEX_P08 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PEX_P08 to NTE
        /// </summary>
        public static NTE AddNTE(this PEX_P08 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get EXPERIENCE Records from PEX_P08
        /// </summary>
        public static IEnumerable GetEXPERIENCERecords(this PEX_P08 message)
        {
            object[] result = message.GetRecords("EXPERIENCERepetitionsUsed", "GetEXPERIENCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EXPERIENCE Records from PEX_P08
        /// </summary>
        public static List<PEX_P08_EXPERIENCE> GetAllEXPERIENCERecords(this PEX_P08 message)
        {
            return message.GetAllRecords<PEX_P08_EXPERIENCE>("EXPERIENCERepetitionsUsed", "GetEXPERIENCE");
        }

        /// <summary>
        /// Add a new PEX_P08 to EXPERIENCE
        /// </summary>
        public static PEX_P08_EXPERIENCE AddEXPERIENCE(this PEX_P08 message)
        {
            return message.GetEXPERIENCE(message.EXPERIENCERepetitionsUsed);
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
        /// Add a new PGL_PC6 to GOAL
        /// </summary>
        public static PGL_PC6_GOAL AddGOAL(this PGL_PC6 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PGL_PC7
        /// </summary>
        public static IEnumerable GetGOALRecords(this PGL_PC7 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PGL_PC7
        /// </summary>
        public static List<PGL_PC7_GOAL> GetAllGOALRecords(this PGL_PC7 message)
        {
            return message.GetAllRecords<PGL_PC7_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PGL_PC7 to GOAL
        /// </summary>
        public static PGL_PC7_GOAL AddGOAL(this PGL_PC7 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PGL_PC8
        /// </summary>
        public static IEnumerable GetGOALRecords(this PGL_PC8 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PGL_PC8
        /// </summary>
        public static List<PGL_PC8_GOAL> GetAllGOALRecords(this PGL_PC8 message)
        {
            return message.GetAllRecords<PGL_PC8_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PGL_PC8 to GOAL
        /// </summary>
        public static PGL_PC8_GOAL AddGOAL(this PGL_PC8 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from PIN_I07
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this PIN_I07 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from PIN_I07
        /// </summary>
        public static List<PIN_I07_PROVIDER> GetAllPROVIDERRecords(this PIN_I07 message)
        {
            return message.GetAllRecords<PIN_I07_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new PIN_I07 to PROVIDER
        /// </summary>
        public static PIN_I07_PROVIDER AddPROVIDER(this PIN_I07 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from PIN_I07
        /// </summary>
        public static IEnumerable GetNK1Records(this PIN_I07 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from PIN_I07
        /// </summary>
        public static List<NK1> GetAllNK1Records(this PIN_I07 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new PIN_I07 to NK1
        /// </summary>
        public static NK1 AddNK1(this PIN_I07 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PIN_I07
        /// </summary>
        public static IEnumerable GetNTERecords(this PIN_I07 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PIN_I07
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PIN_I07 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PIN_I07 to NTE
        /// </summary>
        public static NTE AddNTE(this PIN_I07 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new PPG_PCG to PATHWAY
        /// </summary>
        public static PPG_PCG_PATHWAY AddPATHWAY(this PPG_PCG message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPG_PCH
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPG_PCH message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPG_PCH
        /// </summary>
        public static List<PPG_PCH_PATHWAY> GetAllPATHWAYRecords(this PPG_PCH message)
        {
            return message.GetAllRecords<PPG_PCH_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPG_PCH to PATHWAY
        /// </summary>
        public static PPG_PCH_PATHWAY AddPATHWAY(this PPG_PCH message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPG_PCJ
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPG_PCJ message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPG_PCJ
        /// </summary>
        public static List<PPG_PCJ_PATHWAY> GetAllPATHWAYRecords(this PPG_PCJ message)
        {
            return message.GetAllRecords<PPG_PCJ_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPG_PCJ to PATHWAY
        /// </summary>
        public static PPG_PCJ_PATHWAY AddPATHWAY(this PPG_PCJ message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
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
        /// Add a new PPP_PCB to PATHWAY
        /// </summary>
        public static PPP_PCB_PATHWAY AddPATHWAY(this PPP_PCB message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPP_PCC
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPP_PCC message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPP_PCC
        /// </summary>
        public static List<PPP_PCC_PATHWAY> GetAllPATHWAYRecords(this PPP_PCC message)
        {
            return message.GetAllRecords<PPP_PCC_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPP_PCC to PATHWAY
        /// </summary>
        public static PPP_PCC_PATHWAY AddPATHWAY(this PPP_PCC message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPP_PCD
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPP_PCD message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPP_PCD
        /// </summary>
        public static List<PPP_PCD_PATHWAY> GetAllPATHWAYRecords(this PPP_PCD message)
        {
            return message.GetAllRecords<PPP_PCD_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPP_PCD to PATHWAY
        /// </summary>
        public static PPP_PCD_PATHWAY AddPATHWAY(this PPP_PCD message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
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
        /// Add a new PPR_PC1 to PROBLEM
        /// </summary>
        public static PPR_PC1_PROBLEM AddPROBLEM(this PPR_PC1 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PPR_PC2
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPR_PC2 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPR_PC2
        /// </summary>
        public static List<PPR_PC2_PROBLEM> GetAllPROBLEMRecords(this PPR_PC2 message)
        {
            return message.GetAllRecords<PPR_PC2_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PPR_PC2 to PROBLEM
        /// </summary>
        public static PPR_PC2_PROBLEM AddPROBLEM(this PPR_PC2 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PPR_PC3
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPR_PC3 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPR_PC3
        /// </summary>
        public static List<PPR_PC3_PROBLEM> GetAllPROBLEMRecords(this PPR_PC3 message)
        {
            return message.GetAllRecords<PPR_PC3_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PPR_PC3 to PROBLEM
        /// </summary>
        public static PPR_PC3_PROBLEM AddPROBLEM(this PPR_PC3 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
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
        /// Add a new PPT_PCL to PATIENT
        /// </summary>
        public static PPT_PCL_PATIENT AddPATIENT(this PPT_PCL message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new PPV_PCA to PATIENT
        /// </summary>
        public static PPV_PCA_PATIENT AddPATIENT(this PPV_PCA message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new PRR_PC5 to PATIENT
        /// </summary>
        public static PRR_PC5_PATIENT AddPATIENT(this PRR_PC5 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new PTR_PCF to PATIENT
        /// </summary>
        public static PTR_PCF_PATIENT AddPATIENT(this PTR_PCF message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new RAR_RAR to DEFINITION
        /// </summary>
        public static RAR_RAR_DEFINITION AddDEFINITION(this RAR_RAR message)
        {
            return message.GetDEFINITION(message.DEFINITIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RAS_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this RAS_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RAS_O01
        /// </summary>
        public static List<RAS_O01_ORDER> GetAllORDERRecords(this RAS_O01 message)
        {
            return message.GetAllRecords<RAS_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RAS_O01 to ORDER
        /// </summary>
        public static RAS_O01_ORDER AddORDER(this RAS_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RCI_I05 to PROVIDER
        /// </summary>
        public static RCI_I05_PROVIDER AddPROVIDER(this RCI_I05 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RCI_I05 to DG1
        /// </summary>
        public static DG1 AddDG1(this RCI_I05 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new RCI_I05 to DRG
        /// </summary>
        public static DRG AddDRG(this RCI_I05 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
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
        /// Add a new RCI_I05 to AL1
        /// </summary>
        public static AL1 AddAL1(this RCI_I05 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new RCI_I05 to OBSERVATION
        /// </summary>
        public static RCI_I05_OBSERVATION AddOBSERVATION(this RCI_I05 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new RCI_I05 to NTE
        /// </summary>
        public static NTE AddNTE(this RCI_I05 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RCL_I06 to PROVIDER
        /// </summary>
        public static RCL_I06_PROVIDER AddPROVIDER(this RCL_I06 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RCL_I06 to DG1
        /// </summary>
        public static DG1 AddDG1(this RCL_I06 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new RCL_I06 to DRG
        /// </summary>
        public static DRG AddDRG(this RCL_I06 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
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
        /// Add a new RCL_I06 to AL1
        /// </summary>
        public static AL1 AddAL1(this RCL_I06 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new RCL_I06 to NTE
        /// </summary>
        public static NTE AddNTE(this RCL_I06 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RCL_I06 to DSP
        /// </summary>
        public static DSP AddDSP(this RCL_I06 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RDE_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDE_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDE_O01
        /// </summary>
        public static List<RDE_O01_ORDER> GetAllORDERRecords(this RDE_O01 message)
        {
            return message.GetAllRecords<RDE_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RDE_O01 to ORDER
        /// </summary>
        public static RDE_O01_ORDER AddORDER(this RDE_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDO_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this RDO_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDO_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDO_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDO_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this RDO_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RDO_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDO_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDO_O01
        /// </summary>
        public static List<RDO_O01_ORDER> GetAllORDERRecords(this RDO_O01 message)
        {
            return message.GetAllRecords<RDO_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RDO_O01 to ORDER
        /// </summary>
        public static RDO_O01_ORDER AddORDER(this RDO_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get DEFINITION Records from RDR_RDR
        /// </summary>
        public static IEnumerable GetDEFINITIONRecords(this RDR_RDR message)
        {
            object[] result = message.GetRecords("DEFINITIONRepetitionsUsed", "GetDEFINITION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DEFINITION Records from RDR_RDR
        /// </summary>
        public static List<RDR_RDR_DEFINITION> GetAllDEFINITIONRecords(this RDR_RDR message)
        {
            return message.GetAllRecords<RDR_RDR_DEFINITION>("DEFINITIONRepetitionsUsed", "GetDEFINITION");
        }

        /// <summary>
        /// Add a new RDR_RDR to DEFINITION
        /// </summary>
        public static RDR_RDR_DEFINITION AddDEFINITION(this RDR_RDR message)
        {
            return message.GetDEFINITION(message.DEFINITIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RDS_O01
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDS_O01 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDS_O01
        /// </summary>
        public static List<RDS_O01_ORDER> GetAllORDERRecords(this RDS_O01 message)
        {
            return message.GetAllRecords<RDS_O01_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RDS_O01 to ORDER
        /// </summary>
        public static RDS_O01_ORDER AddORDER(this RDS_O01 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from REF_I12
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from REF_I12
        /// </summary>
        public static List<REF_I12_PROVIDER> GetAllPROVIDERRecords(this REF_I12 message)
        {
            return message.GetAllRecords<REF_I12_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new REF_I12 to PROVIDER
        /// </summary>
        public static REF_I12_PROVIDER AddPROVIDER(this REF_I12 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new REF_I12 to NK1
        /// </summary>
        public static NK1 AddNK1(this REF_I12 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new REF_I12 to GT1
        /// </summary>
        public static GT1 AddGT1(this REF_I12 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
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
        /// Add a new REF_I12 to INSURANCE
        /// </summary>
        public static REF_I12_INSURANCE AddINSURANCE(this REF_I12 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new REF_I12 to DG1
        /// </summary>
        public static DG1 AddDG1(this REF_I12 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new REF_I12 to DRG
        /// </summary>
        public static DRG AddDRG(this REF_I12 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
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
        /// Add a new REF_I12 to AL1
        /// </summary>
        public static AL1 AddAL1(this REF_I12 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new REF_I12 to PROCEDURE
        /// </summary>
        public static REF_I12_PROCEDURE AddPROCEDURE(this REF_I12 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from REF_I12
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this REF_I12 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from REF_I12
        /// </summary>
        public static List<REF_I12_RESULTS> GetAllRESULTSRecords(this REF_I12 message)
        {
            return message.GetAllRecords<REF_I12_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new REF_I12 to RESULTS
        /// </summary>
        public static REF_I12_RESULTS AddRESULTS(this REF_I12 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
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
        /// Add a new REF_I12 to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I12 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from REF_I13
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this REF_I13 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from REF_I13
        /// </summary>
        public static List<REF_I13_PROVIDER> GetAllPROVIDERRecords(this REF_I13 message)
        {
            return message.GetAllRecords<REF_I13_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new REF_I13 to PROVIDER
        /// </summary>
        public static REF_I13_PROVIDER AddPROVIDER(this REF_I13 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from REF_I13
        /// </summary>
        public static IEnumerable GetNK1Records(this REF_I13 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from REF_I13
        /// </summary>
        public static List<NK1> GetAllNK1Records(this REF_I13 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new REF_I13 to NK1
        /// </summary>
        public static NK1 AddNK1(this REF_I13 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from REF_I13
        /// </summary>
        public static IEnumerable GetGT1Records(this REF_I13 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from REF_I13
        /// </summary>
        public static List<GT1> GetAllGT1Records(this REF_I13 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new REF_I13 to GT1
        /// </summary>
        public static GT1 AddGT1(this REF_I13 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from REF_I13
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this REF_I13 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from REF_I13
        /// </summary>
        public static List<REF_I13_INSURANCE> GetAllINSURANCERecords(this REF_I13 message)
        {
            return message.GetAllRecords<REF_I13_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new REF_I13 to INSURANCE
        /// </summary>
        public static REF_I13_INSURANCE AddINSURANCE(this REF_I13 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from REF_I13
        /// </summary>
        public static IEnumerable GetDG1Records(this REF_I13 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from REF_I13
        /// </summary>
        public static List<DG1> GetAllDG1Records(this REF_I13 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new REF_I13 to DG1
        /// </summary>
        public static DG1 AddDG1(this REF_I13 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from REF_I13
        /// </summary>
        public static IEnumerable GetDRGRecords(this REF_I13 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from REF_I13
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this REF_I13 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new REF_I13 to DRG
        /// </summary>
        public static DRG AddDRG(this REF_I13 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from REF_I13
        /// </summary>
        public static IEnumerable GetAL1Records(this REF_I13 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from REF_I13
        /// </summary>
        public static List<AL1> GetAllAL1Records(this REF_I13 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new REF_I13 to AL1
        /// </summary>
        public static AL1 AddAL1(this REF_I13 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from REF_I13
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this REF_I13 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from REF_I13
        /// </summary>
        public static List<REF_I13_PROCEDURE> GetAllPROCEDURERecords(this REF_I13 message)
        {
            return message.GetAllRecords<REF_I13_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new REF_I13 to PROCEDURE
        /// </summary>
        public static REF_I13_PROCEDURE AddPROCEDURE(this REF_I13 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from REF_I13
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this REF_I13 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from REF_I13
        /// </summary>
        public static List<REF_I13_RESULTS> GetAllRESULTSRecords(this REF_I13 message)
        {
            return message.GetAllRecords<REF_I13_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new REF_I13 to RESULTS
        /// </summary>
        public static REF_I13_RESULTS AddRESULTS(this REF_I13 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I13
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I13 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I13
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I13 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I13 to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I13 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from REF_I14
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this REF_I14 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from REF_I14
        /// </summary>
        public static List<REF_I14_PROVIDER> GetAllPROVIDERRecords(this REF_I14 message)
        {
            return message.GetAllRecords<REF_I14_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new REF_I14 to PROVIDER
        /// </summary>
        public static REF_I14_PROVIDER AddPROVIDER(this REF_I14 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from REF_I14
        /// </summary>
        public static IEnumerable GetNK1Records(this REF_I14 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from REF_I14
        /// </summary>
        public static List<NK1> GetAllNK1Records(this REF_I14 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new REF_I14 to NK1
        /// </summary>
        public static NK1 AddNK1(this REF_I14 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from REF_I14
        /// </summary>
        public static IEnumerable GetGT1Records(this REF_I14 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from REF_I14
        /// </summary>
        public static List<GT1> GetAllGT1Records(this REF_I14 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new REF_I14 to GT1
        /// </summary>
        public static GT1 AddGT1(this REF_I14 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from REF_I14
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this REF_I14 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from REF_I14
        /// </summary>
        public static List<REF_I14_INSURANCE> GetAllINSURANCERecords(this REF_I14 message)
        {
            return message.GetAllRecords<REF_I14_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new REF_I14 to INSURANCE
        /// </summary>
        public static REF_I14_INSURANCE AddINSURANCE(this REF_I14 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from REF_I14
        /// </summary>
        public static IEnumerable GetDG1Records(this REF_I14 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from REF_I14
        /// </summary>
        public static List<DG1> GetAllDG1Records(this REF_I14 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new REF_I14 to DG1
        /// </summary>
        public static DG1 AddDG1(this REF_I14 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from REF_I14
        /// </summary>
        public static IEnumerable GetDRGRecords(this REF_I14 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from REF_I14
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this REF_I14 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new REF_I14 to DRG
        /// </summary>
        public static DRG AddDRG(this REF_I14 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from REF_I14
        /// </summary>
        public static IEnumerable GetAL1Records(this REF_I14 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from REF_I14
        /// </summary>
        public static List<AL1> GetAllAL1Records(this REF_I14 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new REF_I14 to AL1
        /// </summary>
        public static AL1 AddAL1(this REF_I14 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from REF_I14
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this REF_I14 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from REF_I14
        /// </summary>
        public static List<REF_I14_PROCEDURE> GetAllPROCEDURERecords(this REF_I14 message)
        {
            return message.GetAllRecords<REF_I14_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new REF_I14 to PROCEDURE
        /// </summary>
        public static REF_I14_PROCEDURE AddPROCEDURE(this REF_I14 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from REF_I14
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this REF_I14 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from REF_I14
        /// </summary>
        public static List<REF_I14_RESULTS> GetAllRESULTSRecords(this REF_I14 message)
        {
            return message.GetAllRecords<REF_I14_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new REF_I14 to RESULTS
        /// </summary>
        public static REF_I14_RESULTS AddRESULTS(this REF_I14 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I14
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I14 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I14
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I14 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I14 to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I14 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from REF_I15
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this REF_I15 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from REF_I15
        /// </summary>
        public static List<REF_I15_PROVIDER> GetAllPROVIDERRecords(this REF_I15 message)
        {
            return message.GetAllRecords<REF_I15_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new REF_I15 to PROVIDER
        /// </summary>
        public static REF_I15_PROVIDER AddPROVIDER(this REF_I15 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from REF_I15
        /// </summary>
        public static IEnumerable GetNK1Records(this REF_I15 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from REF_I15
        /// </summary>
        public static List<NK1> GetAllNK1Records(this REF_I15 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new REF_I15 to NK1
        /// </summary>
        public static NK1 AddNK1(this REF_I15 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from REF_I15
        /// </summary>
        public static IEnumerable GetGT1Records(this REF_I15 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from REF_I15
        /// </summary>
        public static List<GT1> GetAllGT1Records(this REF_I15 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new REF_I15 to GT1
        /// </summary>
        public static GT1 AddGT1(this REF_I15 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from REF_I15
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this REF_I15 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from REF_I15
        /// </summary>
        public static List<REF_I15_INSURANCE> GetAllINSURANCERecords(this REF_I15 message)
        {
            return message.GetAllRecords<REF_I15_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new REF_I15 to INSURANCE
        /// </summary>
        public static REF_I15_INSURANCE AddINSURANCE(this REF_I15 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from REF_I15
        /// </summary>
        public static IEnumerable GetDG1Records(this REF_I15 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from REF_I15
        /// </summary>
        public static List<DG1> GetAllDG1Records(this REF_I15 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new REF_I15 to DG1
        /// </summary>
        public static DG1 AddDG1(this REF_I15 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from REF_I15
        /// </summary>
        public static IEnumerable GetDRGRecords(this REF_I15 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from REF_I15
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this REF_I15 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new REF_I15 to DRG
        /// </summary>
        public static DRG AddDRG(this REF_I15 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from REF_I15
        /// </summary>
        public static IEnumerable GetAL1Records(this REF_I15 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from REF_I15
        /// </summary>
        public static List<AL1> GetAllAL1Records(this REF_I15 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new REF_I15 to AL1
        /// </summary>
        public static AL1 AddAL1(this REF_I15 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from REF_I15
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this REF_I15 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from REF_I15
        /// </summary>
        public static List<REF_I15_PROCEDURE> GetAllPROCEDURERecords(this REF_I15 message)
        {
            return message.GetAllRecords<REF_I15_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new REF_I15 to PROCEDURE
        /// </summary>
        public static REF_I15_PROCEDURE AddPROCEDURE(this REF_I15 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from REF_I15
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this REF_I15 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from REF_I15
        /// </summary>
        public static List<REF_I15_RESULTS> GetAllRESULTSRecords(this REF_I15 message)
        {
            return message.GetAllRecords<REF_I15_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new REF_I15 to RESULTS
        /// </summary>
        public static REF_I15_RESULTS AddRESULTS(this REF_I15 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I15
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I15 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I15
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I15 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I15 to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I15 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RER_RER to DEFINITION
        /// </summary>
        public static RER_RER_DEFINITION AddDEFINITION(this RER_RER message)
        {
            return message.GetDEFINITION(message.DEFINITIONRepetitionsUsed);
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
        /// Add a new RGR_RGR to DEFINITION
        /// </summary>
        public static RGR_RGR_DEFINITION AddDEFINITION(this RGR_RGR message)
        {
            return message.GetDEFINITION(message.DEFINITIONRepetitionsUsed);
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
        /// Add a new ROR_ROR to DEFINITION
        /// </summary>
        public static ROR_ROR_DEFINITION AddDEFINITION(this ROR_ROR message)
        {
            return message.GetDEFINITION(message.DEFINITIONRepetitionsUsed);
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
        /// Add a new RPA_I08 to PROVIDER
        /// </summary>
        public static RPA_I08_PROVIDER AddPROVIDER(this RPA_I08 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RPA_I08 to NK1
        /// </summary>
        public static NK1 AddNK1(this RPA_I08 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RPA_I08 to GT1
        /// </summary>
        public static GT1 AddGT1(this RPA_I08 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPA_I08
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPA_I08
        /// </summary>
        public static List<RPA_I08_INSURANCE> GetAllINSURANCERecords(this RPA_I08 message)
        {
            return message.GetAllRecords<RPA_I08_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPA_I08 to INSURANCE
        /// </summary>
        public static RPA_I08_INSURANCE AddINSURANCE(this RPA_I08 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new RPA_I08 to DG1
        /// </summary>
        public static DG1 AddDG1(this RPA_I08 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new RPA_I08 to DRG
        /// </summary>
        public static DRG AddDRG(this RPA_I08 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
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
        /// Add a new RPA_I08 to AL1
        /// </summary>
        public static AL1 AddAL1(this RPA_I08 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new RPA_I08 to PROCEDURE
        /// </summary>
        public static RPA_I08_PROCEDURE AddPROCEDURE(this RPA_I08 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RPA_I08
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RPA_I08 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RPA_I08
        /// </summary>
        public static List<RPA_I08_OBSERVATION> GetAllOBSERVATIONRecords(this RPA_I08 message)
        {
            return message.GetAllRecords<RPA_I08_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RPA_I08 to OBSERVATION
        /// </summary>
        public static RPA_I08_OBSERVATION AddOBSERVATION(this RPA_I08 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RPA_I09
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPA_I09 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPA_I09
        /// </summary>
        public static List<RPA_I09_PROVIDER> GetAllPROVIDERRecords(this RPA_I09 message)
        {
            return message.GetAllRecords<RPA_I09_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RPA_I09 to PROVIDER
        /// </summary>
        public static RPA_I09_PROVIDER AddPROVIDER(this RPA_I09 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RPA_I09
        /// </summary>
        public static IEnumerable GetNK1Records(this RPA_I09 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RPA_I09
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RPA_I09 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RPA_I09 to NK1
        /// </summary>
        public static NK1 AddNK1(this RPA_I09 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPA_I09
        /// </summary>
        public static IEnumerable GetGT1Records(this RPA_I09 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPA_I09
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPA_I09 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPA_I09 to GT1
        /// </summary>
        public static GT1 AddGT1(this RPA_I09 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPA_I09
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPA_I09 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPA_I09
        /// </summary>
        public static List<RPA_I09_INSURANCE> GetAllINSURANCERecords(this RPA_I09 message)
        {
            return message.GetAllRecords<RPA_I09_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPA_I09 to INSURANCE
        /// </summary>
        public static RPA_I09_INSURANCE AddINSURANCE(this RPA_I09 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RPA_I09
        /// </summary>
        public static IEnumerable GetDG1Records(this RPA_I09 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RPA_I09
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RPA_I09 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RPA_I09 to DG1
        /// </summary>
        public static DG1 AddDG1(this RPA_I09 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RPA_I09
        /// </summary>
        public static IEnumerable GetDRGRecords(this RPA_I09 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RPA_I09
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RPA_I09 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RPA_I09 to DRG
        /// </summary>
        public static DRG AddDRG(this RPA_I09 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RPA_I09
        /// </summary>
        public static IEnumerable GetAL1Records(this RPA_I09 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RPA_I09
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RPA_I09 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RPA_I09 to AL1
        /// </summary>
        public static AL1 AddAL1(this RPA_I09 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RPA_I09
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RPA_I09 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RPA_I09
        /// </summary>
        public static List<RPA_I09_PROCEDURE> GetAllPROCEDURERecords(this RPA_I09 message)
        {
            return message.GetAllRecords<RPA_I09_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RPA_I09 to PROCEDURE
        /// </summary>
        public static RPA_I09_PROCEDURE AddPROCEDURE(this RPA_I09 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RPA_I09
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RPA_I09 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RPA_I09
        /// </summary>
        public static List<RPA_I09_RESULTS> GetAllRESULTSRecords(this RPA_I09 message)
        {
            return message.GetAllRecords<RPA_I09_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RPA_I09 to RESULTS
        /// </summary>
        public static RPA_I09_RESULTS AddRESULTS(this RPA_I09 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RPA_I10
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPA_I10 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPA_I10
        /// </summary>
        public static List<RPA_I10_PROVIDER> GetAllPROVIDERRecords(this RPA_I10 message)
        {
            return message.GetAllRecords<RPA_I10_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RPA_I10 to PROVIDER
        /// </summary>
        public static RPA_I10_PROVIDER AddPROVIDER(this RPA_I10 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RPA_I10
        /// </summary>
        public static IEnumerable GetNK1Records(this RPA_I10 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RPA_I10
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RPA_I10 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RPA_I10 to NK1
        /// </summary>
        public static NK1 AddNK1(this RPA_I10 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPA_I10
        /// </summary>
        public static IEnumerable GetGT1Records(this RPA_I10 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPA_I10
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPA_I10 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPA_I10 to GT1
        /// </summary>
        public static GT1 AddGT1(this RPA_I10 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPA_I10
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPA_I10 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPA_I10
        /// </summary>
        public static List<RPA_I10_INSURANCE> GetAllINSURANCERecords(this RPA_I10 message)
        {
            return message.GetAllRecords<RPA_I10_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPA_I10 to INSURANCE
        /// </summary>
        public static RPA_I10_INSURANCE AddINSURANCE(this RPA_I10 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RPA_I10
        /// </summary>
        public static IEnumerable GetDG1Records(this RPA_I10 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RPA_I10
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RPA_I10 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RPA_I10 to DG1
        /// </summary>
        public static DG1 AddDG1(this RPA_I10 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RPA_I10
        /// </summary>
        public static IEnumerable GetDRGRecords(this RPA_I10 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RPA_I10
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RPA_I10 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RPA_I10 to DRG
        /// </summary>
        public static DRG AddDRG(this RPA_I10 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RPA_I10
        /// </summary>
        public static IEnumerable GetAL1Records(this RPA_I10 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RPA_I10
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RPA_I10 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RPA_I10 to AL1
        /// </summary>
        public static AL1 AddAL1(this RPA_I10 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RPA_I10
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RPA_I10 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RPA_I10
        /// </summary>
        public static List<RPA_I10_PROCEDURE> GetAllPROCEDURERecords(this RPA_I10 message)
        {
            return message.GetAllRecords<RPA_I10_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RPA_I10 to PROCEDURE
        /// </summary>
        public static RPA_I10_PROCEDURE AddPROCEDURE(this RPA_I10 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RPA_I10
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RPA_I10 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RPA_I10
        /// </summary>
        public static List<RPA_I10_RESULTS> GetAllRESULTSRecords(this RPA_I10 message)
        {
            return message.GetAllRecords<RPA_I10_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RPA_I10 to RESULTS
        /// </summary>
        public static RPA_I10_RESULTS AddRESULTS(this RPA_I10 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RPA_I11
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RPA_I11 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RPA_I11
        /// </summary>
        public static List<RPA_I11_PROVIDER> GetAllPROVIDERRecords(this RPA_I11 message)
        {
            return message.GetAllRecords<RPA_I11_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RPA_I11 to PROVIDER
        /// </summary>
        public static RPA_I11_PROVIDER AddPROVIDER(this RPA_I11 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RPA_I11
        /// </summary>
        public static IEnumerable GetNK1Records(this RPA_I11 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RPA_I11
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RPA_I11 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RPA_I11 to NK1
        /// </summary>
        public static NK1 AddNK1(this RPA_I11 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPA_I11
        /// </summary>
        public static IEnumerable GetGT1Records(this RPA_I11 message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPA_I11
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPA_I11 message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPA_I11 to GT1
        /// </summary>
        public static GT1 AddGT1(this RPA_I11 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPA_I11
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPA_I11 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPA_I11
        /// </summary>
        public static List<RPA_I11_INSURANCE> GetAllINSURANCERecords(this RPA_I11 message)
        {
            return message.GetAllRecords<RPA_I11_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPA_I11 to INSURANCE
        /// </summary>
        public static RPA_I11_INSURANCE AddINSURANCE(this RPA_I11 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RPA_I11
        /// </summary>
        public static IEnumerable GetDG1Records(this RPA_I11 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RPA_I11
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RPA_I11 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RPA_I11 to DG1
        /// </summary>
        public static DG1 AddDG1(this RPA_I11 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RPA_I11
        /// </summary>
        public static IEnumerable GetDRGRecords(this RPA_I11 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RPA_I11
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RPA_I11 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RPA_I11 to DRG
        /// </summary>
        public static DRG AddDRG(this RPA_I11 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RPA_I11
        /// </summary>
        public static IEnumerable GetAL1Records(this RPA_I11 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RPA_I11
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RPA_I11 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RPA_I11 to AL1
        /// </summary>
        public static AL1 AddAL1(this RPA_I11 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RPA_I11
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RPA_I11 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RPA_I11
        /// </summary>
        public static List<RPA_I11_PROCEDURE> GetAllPROCEDURERecords(this RPA_I11 message)
        {
            return message.GetAllRecords<RPA_I11_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RPA_I11 to PROCEDURE
        /// </summary>
        public static RPA_I11_PROCEDURE AddPROCEDURE(this RPA_I11 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RPA_I11
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RPA_I11 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RPA_I11
        /// </summary>
        public static List<RPA_I11_RESULTS> GetAllRESULTSRecords(this RPA_I11 message)
        {
            return message.GetAllRecords<RPA_I11_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RPA_I11 to RESULTS
        /// </summary>
        public static RPA_I11_RESULTS AddRESULTS(this RPA_I11 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
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
        /// Add a new RPI_I01 to PROVIDER
        /// </summary>
        public static RPI_I01_PROVIDER AddPROVIDER(this RPI_I01 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RPI_I01 to NK1
        /// </summary>
        public static NK1 AddNK1(this RPI_I01 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RPI_I01 to NTE
        /// </summary>
        public static NTE AddNTE(this RPI_I01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RPI_I04 to PROVIDER
        /// </summary>
        public static RPI_I04_PROVIDER AddPROVIDER(this RPI_I04 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RPI_I04 to NK1
        /// </summary>
        public static NK1 AddNK1(this RPI_I04 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RPI_I04 to NTE
        /// </summary>
        public static NTE AddNTE(this RPI_I04 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RPL_I02 to PROVIDER
        /// </summary>
        public static RPL_I02_PROVIDER AddPROVIDER(this RPL_I02 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RPL_I02 to NTE
        /// </summary>
        public static NTE AddNTE(this RPL_I02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RPL_I02 to DSP
        /// </summary>
        public static DSP AddDSP(this RPL_I02 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
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
        /// Add a new RPR_I03 to PROVIDER
        /// </summary>
        public static RPR_I03_PROVIDER AddPROVIDER(this RPR_I03 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RPR_I03 to PID
        /// </summary>
        public static PID AddPID(this RPR_I03 message)
        {
            return message.GetPID(message.PIDRepetitionsUsed);
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
        /// Add a new RPR_I03 to NTE
        /// </summary>
        public static NTE AddNTE(this RPR_I03 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RQA_I08 to PROVIDER
        /// </summary>
        public static RQA_I08_PROVIDER AddPROVIDER(this RQA_I08 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RQA_I08 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQA_I08 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RQA_I08 to DG1
        /// </summary>
        public static DG1 AddDG1(this RQA_I08 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new RQA_I08 to DRG
        /// </summary>
        public static DRG AddDRG(this RQA_I08 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
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
        /// Add a new RQA_I08 to AL1
        /// </summary>
        public static AL1 AddAL1(this RQA_I08 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RQA_I08
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RQA_I08 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RQA_I08
        /// </summary>
        public static List<RQA_I08_PROCEDURE> GetAllPROCEDURERecords(this RQA_I08 message)
        {
            return message.GetAllRecords<RQA_I08_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RQA_I08 to PROCEDURE
        /// </summary>
        public static RQA_I08_PROCEDURE AddPROCEDURE(this RQA_I08 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RQA_I08
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RQA_I08 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RQA_I08
        /// </summary>
        public static List<RQA_I08_OBSERVATION> GetAllOBSERVATIONRecords(this RQA_I08 message)
        {
            return message.GetAllRecords<RQA_I08_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RQA_I08 to OBSERVATION
        /// </summary>
        public static RQA_I08_OBSERVATION AddOBSERVATION(this RQA_I08 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new RQA_I08 to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I08 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RQA_I09
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQA_I09 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQA_I09
        /// </summary>
        public static List<RQA_I09_PROVIDER> GetAllPROVIDERRecords(this RQA_I09 message)
        {
            return message.GetAllRecords<RQA_I09_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RQA_I09 to PROVIDER
        /// </summary>
        public static RQA_I09_PROVIDER AddPROVIDER(this RQA_I09 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RQA_I09
        /// </summary>
        public static IEnumerable GetNK1Records(this RQA_I09 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQA_I09
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQA_I09 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RQA_I09 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQA_I09 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RQA_I09
        /// </summary>
        public static IEnumerable GetDG1Records(this RQA_I09 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RQA_I09
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RQA_I09 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RQA_I09 to DG1
        /// </summary>
        public static DG1 AddDG1(this RQA_I09 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RQA_I09
        /// </summary>
        public static IEnumerable GetDRGRecords(this RQA_I09 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RQA_I09
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RQA_I09 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RQA_I09 to DRG
        /// </summary>
        public static DRG AddDRG(this RQA_I09 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RQA_I09
        /// </summary>
        public static IEnumerable GetAL1Records(this RQA_I09 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RQA_I09
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RQA_I09 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RQA_I09 to AL1
        /// </summary>
        public static AL1 AddAL1(this RQA_I09 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RQA_I09
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RQA_I09 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RQA_I09
        /// </summary>
        public static List<RQA_I09_PROCEDURE> GetAllPROCEDURERecords(this RQA_I09 message)
        {
            return message.GetAllRecords<RQA_I09_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RQA_I09 to PROCEDURE
        /// </summary>
        public static RQA_I09_PROCEDURE AddPROCEDURE(this RQA_I09 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RQA_I09
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RQA_I09 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RQA_I09
        /// </summary>
        public static List<RQA_I09_RESULTS> GetAllRESULTSRecords(this RQA_I09 message)
        {
            return message.GetAllRecords<RQA_I09_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RQA_I09 to RESULTS
        /// </summary>
        public static RQA_I09_RESULTS AddRESULTS(this RQA_I09 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I09
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I09 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I09
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I09 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I09 to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I09 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RQA_I10
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQA_I10 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQA_I10
        /// </summary>
        public static List<RQA_I10_PROVIDER> GetAllPROVIDERRecords(this RQA_I10 message)
        {
            return message.GetAllRecords<RQA_I10_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RQA_I10 to PROVIDER
        /// </summary>
        public static RQA_I10_PROVIDER AddPROVIDER(this RQA_I10 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RQA_I10
        /// </summary>
        public static IEnumerable GetNK1Records(this RQA_I10 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQA_I10
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQA_I10 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RQA_I10 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQA_I10 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RQA_I10
        /// </summary>
        public static IEnumerable GetDG1Records(this RQA_I10 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RQA_I10
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RQA_I10 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RQA_I10 to DG1
        /// </summary>
        public static DG1 AddDG1(this RQA_I10 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RQA_I10
        /// </summary>
        public static IEnumerable GetDRGRecords(this RQA_I10 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RQA_I10
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RQA_I10 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RQA_I10 to DRG
        /// </summary>
        public static DRG AddDRG(this RQA_I10 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RQA_I10
        /// </summary>
        public static IEnumerable GetAL1Records(this RQA_I10 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RQA_I10
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RQA_I10 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RQA_I10 to AL1
        /// </summary>
        public static AL1 AddAL1(this RQA_I10 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RQA_I10
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RQA_I10 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RQA_I10
        /// </summary>
        public static List<RQA_I10_PROCEDURE> GetAllPROCEDURERecords(this RQA_I10 message)
        {
            return message.GetAllRecords<RQA_I10_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RQA_I10 to PROCEDURE
        /// </summary>
        public static RQA_I10_PROCEDURE AddPROCEDURE(this RQA_I10 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RQA_I10
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RQA_I10 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RQA_I10
        /// </summary>
        public static List<RQA_I10_RESULTS> GetAllRESULTSRecords(this RQA_I10 message)
        {
            return message.GetAllRecords<RQA_I10_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RQA_I10 to RESULTS
        /// </summary>
        public static RQA_I10_RESULTS AddRESULTS(this RQA_I10 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I10
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I10 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I10
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I10 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I10 to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I10 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RQA_I11
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQA_I11 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQA_I11
        /// </summary>
        public static List<RQA_I11_PROVIDER> GetAllPROVIDERRecords(this RQA_I11 message)
        {
            return message.GetAllRecords<RQA_I11_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RQA_I11 to PROVIDER
        /// </summary>
        public static RQA_I11_PROVIDER AddPROVIDER(this RQA_I11 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RQA_I11
        /// </summary>
        public static IEnumerable GetNK1Records(this RQA_I11 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQA_I11
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQA_I11 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RQA_I11 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQA_I11 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RQA_I11
        /// </summary>
        public static IEnumerable GetDG1Records(this RQA_I11 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RQA_I11
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RQA_I11 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RQA_I11 to DG1
        /// </summary>
        public static DG1 AddDG1(this RQA_I11 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RQA_I11
        /// </summary>
        public static IEnumerable GetDRGRecords(this RQA_I11 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RQA_I11
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RQA_I11 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RQA_I11 to DRG
        /// </summary>
        public static DRG AddDRG(this RQA_I11 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RQA_I11
        /// </summary>
        public static IEnumerable GetAL1Records(this RQA_I11 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RQA_I11
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RQA_I11 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RQA_I11 to AL1
        /// </summary>
        public static AL1 AddAL1(this RQA_I11 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RQA_I11
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RQA_I11 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RQA_I11
        /// </summary>
        public static List<RQA_I11_PROCEDURE> GetAllPROCEDURERecords(this RQA_I11 message)
        {
            return message.GetAllRecords<RQA_I11_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RQA_I11 to PROCEDURE
        /// </summary>
        public static RQA_I11_PROCEDURE AddPROCEDURE(this RQA_I11 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RQA_I11
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RQA_I11 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RQA_I11
        /// </summary>
        public static List<RQA_I11_RESULTS> GetAllRESULTSRecords(this RQA_I11 message)
        {
            return message.GetAllRecords<RQA_I11_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RQA_I11 to RESULTS
        /// </summary>
        public static RQA_I11_RESULTS AddRESULTS(this RQA_I11 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I11
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I11 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I11
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I11 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I11 to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I11 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RQC_I05 to PROVIDER
        /// </summary>
        public static RQC_I05_PROVIDER AddPROVIDER(this RQC_I05 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RQC_I05 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQC_I05 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RQC_I05 to GT1
        /// </summary>
        public static GT1 AddGT1(this RQC_I05 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
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
        /// Add a new RQC_I05 to NTE
        /// </summary>
        public static NTE AddNTE(this RQC_I05 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RQC_I06
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQC_I06 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQC_I06
        /// </summary>
        public static List<RQC_I06_PROVIDER> GetAllPROVIDERRecords(this RQC_I06 message)
        {
            return message.GetAllRecords<RQC_I06_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RQC_I06 to PROVIDER
        /// </summary>
        public static RQC_I06_PROVIDER AddPROVIDER(this RQC_I06 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RQC_I06
        /// </summary>
        public static IEnumerable GetNK1Records(this RQC_I06 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQC_I06
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQC_I06 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RQC_I06 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQC_I06 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQC_I06
        /// </summary>
        public static IEnumerable GetNTERecords(this RQC_I06 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQC_I06
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQC_I06 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQC_I06 to NTE
        /// </summary>
        public static NTE AddNTE(this RQC_I06 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PRDCTD Records from RQI_I01
        /// </summary>
        public static IEnumerable GetPRDCTDRecords(this RQI_I01 message)
        {
            object[] result = message.GetRecords("PRDCTDRepetitionsUsed", "GetPRDCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRDCTD Records from RQI_I01
        /// </summary>
        public static List<RQI_I01_PRDCTD> GetAllPRDCTDRecords(this RQI_I01 message)
        {
            return message.GetAllRecords<RQI_I01_PRDCTD>("PRDCTDRepetitionsUsed", "GetPRDCTD");
        }

        /// <summary>
        /// Add a new RQI_I01 to PRDCTD
        /// </summary>
        public static RQI_I01_PRDCTD AddPRDCTD(this RQI_I01 message)
        {
            return message.GetPRDCTD(message.PRDCTDRepetitionsUsed);
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
        /// Add a new RQI_I01 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQI_I01 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RQI_I01 to NTE
        /// </summary>
        public static NTE AddNTE(this RQI_I01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RQI_I02
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQI_I02 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQI_I02
        /// </summary>
        public static List<RQI_I02_PROVIDER> GetAllPROVIDERRecords(this RQI_I02 message)
        {
            return message.GetAllRecords<RQI_I02_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RQI_I02 to PROVIDER
        /// </summary>
        public static RQI_I02_PROVIDER AddPROVIDER(this RQI_I02 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RQI_I02
        /// </summary>
        public static IEnumerable GetNK1Records(this RQI_I02 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQI_I02
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQI_I02 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RQI_I02 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQI_I02 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQI_I02
        /// </summary>
        public static IEnumerable GetNTERecords(this RQI_I02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQI_I02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQI_I02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQI_I02 to NTE
        /// </summary>
        public static NTE AddNTE(this RQI_I02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RQI_I03
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RQI_I03 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RQI_I03
        /// </summary>
        public static List<RQI_I03_PROVIDER> GetAllPROVIDERRecords(this RQI_I03 message)
        {
            return message.GetAllRecords<RQI_I03_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RQI_I03 to PROVIDER
        /// </summary>
        public static RQI_I03_PROVIDER AddPROVIDER(this RQI_I03 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from RQI_I03
        /// </summary>
        public static IEnumerable GetNK1Records(this RQI_I03 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RQI_I03
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RQI_I03 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new RQI_I03 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQI_I03 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQI_I03
        /// </summary>
        public static IEnumerable GetNTERecords(this RQI_I03 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQI_I03
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQI_I03 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQI_I03 to NTE
        /// </summary>
        public static NTE AddNTE(this RQI_I03 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RQP_I04 to PROVIDER
        /// </summary>
        public static RQP_I04_PROVIDER AddPROVIDER(this RQP_I04 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RQP_I04 to NK1
        /// </summary>
        public static NK1 AddNK1(this RQP_I04 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new RQP_I04 to GT1
        /// </summary>
        public static GT1 AddGT1(this RQP_I04 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
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
        /// Add a new RQP_I04 to NTE
        /// </summary>
        public static NTE AddNTE(this RQP_I04 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRA_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this RRA_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRA_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRA_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRA_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this RRA_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRD_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this RRD_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRD_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRD_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRD_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this RRD_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRE_O01
        /// </summary>
        public static IEnumerable GetNTERecords(this RRE_O01 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRE_O01
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRE_O01 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRE_O01 to NTE
        /// </summary>
        public static NTE AddNTE(this RRE_O01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRG_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this RRG_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRG_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRG_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRG_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this RRG_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RRI_I12
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RRI_I12
        /// </summary>
        public static List<RRI_I12_PROVIDER> GetAllPROVIDERRecords(this RRI_I12 message)
        {
            return message.GetAllRecords<RRI_I12_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RRI_I12 to PROVIDER
        /// </summary>
        public static RRI_I12_PROVIDER AddPROVIDER(this RRI_I12 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RRI_I12 to DG1
        /// </summary>
        public static DG1 AddDG1(this RRI_I12 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new RRI_I12 to DRG
        /// </summary>
        public static DRG AddDRG(this RRI_I12 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
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
        /// Add a new RRI_I12 to AL1
        /// </summary>
        public static AL1 AddAL1(this RRI_I12 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new RRI_I12 to PROCEDURE
        /// </summary>
        public static RRI_I12_PROCEDURE AddPROCEDURE(this RRI_I12 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RRI_I12
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RRI_I12 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RRI_I12
        /// </summary>
        public static List<RRI_I12_RESULTS> GetAllRESULTSRecords(this RRI_I12 message)
        {
            return message.GetAllRecords<RRI_I12_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RRI_I12 to RESULTS
        /// </summary>
        public static RRI_I12_RESULTS AddRESULTS(this RRI_I12 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
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
        /// Add a new RRI_I12 to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I12 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RRI_I13
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RRI_I13 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RRI_I13
        /// </summary>
        public static List<RRI_I13_PROVIDER> GetAllPROVIDERRecords(this RRI_I13 message)
        {
            return message.GetAllRecords<RRI_I13_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RRI_I13 to PROVIDER
        /// </summary>
        public static RRI_I13_PROVIDER AddPROVIDER(this RRI_I13 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RRI_I13
        /// </summary>
        public static IEnumerable GetDG1Records(this RRI_I13 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RRI_I13
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RRI_I13 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RRI_I13 to DG1
        /// </summary>
        public static DG1 AddDG1(this RRI_I13 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RRI_I13
        /// </summary>
        public static IEnumerable GetDRGRecords(this RRI_I13 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RRI_I13
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RRI_I13 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RRI_I13 to DRG
        /// </summary>
        public static DRG AddDRG(this RRI_I13 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RRI_I13
        /// </summary>
        public static IEnumerable GetAL1Records(this RRI_I13 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RRI_I13
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RRI_I13 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RRI_I13 to AL1
        /// </summary>
        public static AL1 AddAL1(this RRI_I13 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RRI_I13
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RRI_I13 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RRI_I13
        /// </summary>
        public static List<RRI_I13_PROCEDURE> GetAllPROCEDURERecords(this RRI_I13 message)
        {
            return message.GetAllRecords<RRI_I13_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RRI_I13 to PROCEDURE
        /// </summary>
        public static RRI_I13_PROCEDURE AddPROCEDURE(this RRI_I13 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RRI_I13
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RRI_I13 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RRI_I13
        /// </summary>
        public static List<RRI_I13_RESULTS> GetAllRESULTSRecords(this RRI_I13 message)
        {
            return message.GetAllRecords<RRI_I13_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RRI_I13 to RESULTS
        /// </summary>
        public static RRI_I13_RESULTS AddRESULTS(this RRI_I13 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I13
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I13 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I13
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I13 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I13 to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I13 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RRI_I14
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RRI_I14 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RRI_I14
        /// </summary>
        public static List<RRI_I14_PROVIDER> GetAllPROVIDERRecords(this RRI_I14 message)
        {
            return message.GetAllRecords<RRI_I14_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RRI_I14 to PROVIDER
        /// </summary>
        public static RRI_I14_PROVIDER AddPROVIDER(this RRI_I14 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RRI_I14
        /// </summary>
        public static IEnumerable GetDG1Records(this RRI_I14 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RRI_I14
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RRI_I14 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RRI_I14 to DG1
        /// </summary>
        public static DG1 AddDG1(this RRI_I14 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RRI_I14
        /// </summary>
        public static IEnumerable GetDRGRecords(this RRI_I14 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RRI_I14
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RRI_I14 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RRI_I14 to DRG
        /// </summary>
        public static DRG AddDRG(this RRI_I14 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RRI_I14
        /// </summary>
        public static IEnumerable GetAL1Records(this RRI_I14 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RRI_I14
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RRI_I14 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RRI_I14 to AL1
        /// </summary>
        public static AL1 AddAL1(this RRI_I14 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RRI_I14
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RRI_I14 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RRI_I14
        /// </summary>
        public static List<RRI_I14_PROCEDURE> GetAllPROCEDURERecords(this RRI_I14 message)
        {
            return message.GetAllRecords<RRI_I14_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RRI_I14 to PROCEDURE
        /// </summary>
        public static RRI_I14_PROCEDURE AddPROCEDURE(this RRI_I14 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RRI_I14
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RRI_I14 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RRI_I14
        /// </summary>
        public static List<RRI_I14_RESULTS> GetAllRESULTSRecords(this RRI_I14 message)
        {
            return message.GetAllRecords<RRI_I14_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RRI_I14 to RESULTS
        /// </summary>
        public static RRI_I14_RESULTS AddRESULTS(this RRI_I14 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I14
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I14 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I14
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I14 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I14 to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I14 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER Records from RRI_I15
        /// </summary>
        public static IEnumerable GetPROVIDERRecords(this RRI_I15 message)
        {
            object[] result = message.GetRecords("PROVIDERRepetitionsUsed", "GetPROVIDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER Records from RRI_I15
        /// </summary>
        public static List<RRI_I15_PROVIDER> GetAllPROVIDERRecords(this RRI_I15 message)
        {
            return message.GetAllRecords<RRI_I15_PROVIDER>("PROVIDERRepetitionsUsed", "GetPROVIDER");
        }

        /// <summary>
        /// Add a new RRI_I15 to PROVIDER
        /// </summary>
        public static RRI_I15_PROVIDER AddPROVIDER(this RRI_I15 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from RRI_I15
        /// </summary>
        public static IEnumerable GetDG1Records(this RRI_I15 message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from RRI_I15
        /// </summary>
        public static List<DG1> GetAllDG1Records(this RRI_I15 message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new RRI_I15 to DG1
        /// </summary>
        public static DG1 AddDG1(this RRI_I15 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get DRG Records from RRI_I15
        /// </summary>
        public static IEnumerable GetDRGRecords(this RRI_I15 message)
        {
            object[] result = message.GetRecords("DRGRepetitionsUsed", "GetDRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DRG Records from RRI_I15
        /// </summary>
        public static List<DRG> GetAllDRGRecords(this RRI_I15 message)
        {
            return message.GetAllRecords<DRG>("DRGRepetitionsUsed", "GetDRG");
        }

        /// <summary>
        /// Add a new RRI_I15 to DRG
        /// </summary>
        public static DRG AddDRG(this RRI_I15 message)
        {
            return message.GetDRG(message.DRGRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RRI_I15
        /// </summary>
        public static IEnumerable GetAL1Records(this RRI_I15 message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RRI_I15
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RRI_I15 message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RRI_I15 to AL1
        /// </summary>
        public static AL1 AddAL1(this RRI_I15 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from RRI_I15
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this RRI_I15 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from RRI_I15
        /// </summary>
        public static List<RRI_I15_PROCEDURE> GetAllPROCEDURERecords(this RRI_I15 message)
        {
            return message.GetAllRecords<RRI_I15_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new RRI_I15 to PROCEDURE
        /// </summary>
        public static RRI_I15_PROCEDURE AddPROCEDURE(this RRI_I15 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RRI_I15
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RRI_I15 message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RRI_I15
        /// </summary>
        public static List<RRI_I15_RESULTS> GetAllRESULTSRecords(this RRI_I15 message)
        {
            return message.GetAllRecords<RRI_I15_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RRI_I15 to RESULTS
        /// </summary>
        public static RRI_I15_RESULTS AddRESULTS(this RRI_I15 message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I15
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I15 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I15
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I15 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I15 to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I15 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRO_O02
        /// </summary>
        public static IEnumerable GetNTERecords(this RRO_O02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRO_O02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRO_O02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRO_O02 to NTE
        /// </summary>
        public static NTE AddNTE(this RRO_O02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new SIU_S12 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S12
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S12 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S12
        /// </summary>
        public static List<SIU_S12_PATIENT> GetAllPATIENTRecords(this SIU_S12 message)
        {
            return message.GetAllRecords<SIU_S12_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S12 to PATIENT
        /// </summary>
        public static SIU_S12_PATIENT AddPATIENT(this SIU_S12 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new SIU_S12 to RESOURCES
        /// </summary>
        public static SIU_S12_RESOURCES AddRESOURCES(this SIU_S12 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S13
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S13 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S13
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S13 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S13 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S13 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S13
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S13 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S13
        /// </summary>
        public static List<SIU_S13_PATIENT> GetAllPATIENTRecords(this SIU_S13 message)
        {
            return message.GetAllRecords<SIU_S13_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S13 to PATIENT
        /// </summary>
        public static SIU_S13_PATIENT AddPATIENT(this SIU_S13 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S13
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S13 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S13
        /// </summary>
        public static List<SIU_S13_RESOURCES> GetAllRESOURCESRecords(this SIU_S13 message)
        {
            return message.GetAllRecords<SIU_S13_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S13 to RESOURCES
        /// </summary>
        public static SIU_S13_RESOURCES AddRESOURCES(this SIU_S13 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S14
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S14 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S14
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S14 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S14 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S14 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S14
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S14 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S14
        /// </summary>
        public static List<SIU_S14_PATIENT> GetAllPATIENTRecords(this SIU_S14 message)
        {
            return message.GetAllRecords<SIU_S14_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S14 to PATIENT
        /// </summary>
        public static SIU_S14_PATIENT AddPATIENT(this SIU_S14 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S14
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S14 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S14
        /// </summary>
        public static List<SIU_S14_RESOURCES> GetAllRESOURCESRecords(this SIU_S14 message)
        {
            return message.GetAllRecords<SIU_S14_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S14 to RESOURCES
        /// </summary>
        public static SIU_S14_RESOURCES AddRESOURCES(this SIU_S14 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S15
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S15 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S15
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S15 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S15 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S15 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S15
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S15 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S15
        /// </summary>
        public static List<SIU_S15_PATIENT> GetAllPATIENTRecords(this SIU_S15 message)
        {
            return message.GetAllRecords<SIU_S15_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S15 to PATIENT
        /// </summary>
        public static SIU_S15_PATIENT AddPATIENT(this SIU_S15 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S15
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S15 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S15
        /// </summary>
        public static List<SIU_S15_RESOURCES> GetAllRESOURCESRecords(this SIU_S15 message)
        {
            return message.GetAllRecords<SIU_S15_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S15 to RESOURCES
        /// </summary>
        public static SIU_S15_RESOURCES AddRESOURCES(this SIU_S15 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S16
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S16 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S16
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S16 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S16 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S16 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S16
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S16 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S16
        /// </summary>
        public static List<SIU_S16_PATIENT> GetAllPATIENTRecords(this SIU_S16 message)
        {
            return message.GetAllRecords<SIU_S16_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S16 to PATIENT
        /// </summary>
        public static SIU_S16_PATIENT AddPATIENT(this SIU_S16 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S16
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S16 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S16
        /// </summary>
        public static List<SIU_S16_RESOURCES> GetAllRESOURCESRecords(this SIU_S16 message)
        {
            return message.GetAllRecords<SIU_S16_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S16 to RESOURCES
        /// </summary>
        public static SIU_S16_RESOURCES AddRESOURCES(this SIU_S16 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S17
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S17 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S17
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S17 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S17 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S17 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S17
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S17 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S17
        /// </summary>
        public static List<SIU_S17_PATIENT> GetAllPATIENTRecords(this SIU_S17 message)
        {
            return message.GetAllRecords<SIU_S17_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S17 to PATIENT
        /// </summary>
        public static SIU_S17_PATIENT AddPATIENT(this SIU_S17 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S17
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S17 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S17
        /// </summary>
        public static List<SIU_S17_RESOURCES> GetAllRESOURCESRecords(this SIU_S17 message)
        {
            return message.GetAllRecords<SIU_S17_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S17 to RESOURCES
        /// </summary>
        public static SIU_S17_RESOURCES AddRESOURCES(this SIU_S17 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S18
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S18 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S18
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S18 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S18 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S18 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S18
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S18 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S18
        /// </summary>
        public static List<SIU_S18_PATIENT> GetAllPATIENTRecords(this SIU_S18 message)
        {
            return message.GetAllRecords<SIU_S18_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S18 to PATIENT
        /// </summary>
        public static SIU_S18_PATIENT AddPATIENT(this SIU_S18 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S18
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S18 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S18
        /// </summary>
        public static List<SIU_S18_RESOURCES> GetAllRESOURCESRecords(this SIU_S18 message)
        {
            return message.GetAllRecords<SIU_S18_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S18 to RESOURCES
        /// </summary>
        public static SIU_S18_RESOURCES AddRESOURCES(this SIU_S18 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S19
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S19 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S19
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S19 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S19 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S19 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S19
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S19 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S19
        /// </summary>
        public static List<SIU_S19_PATIENT> GetAllPATIENTRecords(this SIU_S19 message)
        {
            return message.GetAllRecords<SIU_S19_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S19 to PATIENT
        /// </summary>
        public static SIU_S19_PATIENT AddPATIENT(this SIU_S19 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S19
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S19 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S19
        /// </summary>
        public static List<SIU_S19_RESOURCES> GetAllRESOURCESRecords(this SIU_S19 message)
        {
            return message.GetAllRecords<SIU_S19_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S19 to RESOURCES
        /// </summary>
        public static SIU_S19_RESOURCES AddRESOURCES(this SIU_S19 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S20
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S20 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S20
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S20 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S20 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S20 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S20
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S20 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S20
        /// </summary>
        public static List<SIU_S20_PATIENT> GetAllPATIENTRecords(this SIU_S20 message)
        {
            return message.GetAllRecords<SIU_S20_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S20 to PATIENT
        /// </summary>
        public static SIU_S20_PATIENT AddPATIENT(this SIU_S20 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S20
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S20 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S20
        /// </summary>
        public static List<SIU_S20_RESOURCES> GetAllRESOURCESRecords(this SIU_S20 message)
        {
            return message.GetAllRecords<SIU_S20_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S20 to RESOURCES
        /// </summary>
        public static SIU_S20_RESOURCES AddRESOURCES(this SIU_S20 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S21
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S21 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S21
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S21 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S21 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S21 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S21
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S21 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S21
        /// </summary>
        public static List<SIU_S21_PATIENT> GetAllPATIENTRecords(this SIU_S21 message)
        {
            return message.GetAllRecords<SIU_S21_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S21 to PATIENT
        /// </summary>
        public static SIU_S21_PATIENT AddPATIENT(this SIU_S21 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S21
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S21 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S21
        /// </summary>
        public static List<SIU_S21_RESOURCES> GetAllRESOURCESRecords(this SIU_S21 message)
        {
            return message.GetAllRecords<SIU_S21_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S21 to RESOURCES
        /// </summary>
        public static SIU_S21_RESOURCES AddRESOURCES(this SIU_S21 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S22
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S22 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S22
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S22 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S22 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S22 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S22
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S22 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S22
        /// </summary>
        public static List<SIU_S22_PATIENT> GetAllPATIENTRecords(this SIU_S22 message)
        {
            return message.GetAllRecords<SIU_S22_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S22 to PATIENT
        /// </summary>
        public static SIU_S22_PATIENT AddPATIENT(this SIU_S22 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S22
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S22 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S22
        /// </summary>
        public static List<SIU_S22_RESOURCES> GetAllRESOURCESRecords(this SIU_S22 message)
        {
            return message.GetAllRecords<SIU_S22_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S22 to RESOURCES
        /// </summary>
        public static SIU_S22_RESOURCES AddRESOURCES(this SIU_S22 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S23
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S23 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S23
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S23 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S23 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S23 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S23
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S23 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S23
        /// </summary>
        public static List<SIU_S23_PATIENT> GetAllPATIENTRecords(this SIU_S23 message)
        {
            return message.GetAllRecords<SIU_S23_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S23 to PATIENT
        /// </summary>
        public static SIU_S23_PATIENT AddPATIENT(this SIU_S23 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S23
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S23 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S23
        /// </summary>
        public static List<SIU_S23_RESOURCES> GetAllRESOURCESRecords(this SIU_S23 message)
        {
            return message.GetAllRecords<SIU_S23_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S23 to RESOURCES
        /// </summary>
        public static SIU_S23_RESOURCES AddRESOURCES(this SIU_S23 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S24
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S24 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S24
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S24 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S24 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S24 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S24
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S24 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S24
        /// </summary>
        public static List<SIU_S24_PATIENT> GetAllPATIENTRecords(this SIU_S24 message)
        {
            return message.GetAllRecords<SIU_S24_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S24 to PATIENT
        /// </summary>
        public static SIU_S24_PATIENT AddPATIENT(this SIU_S24 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S24
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S24 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S24
        /// </summary>
        public static List<SIU_S24_RESOURCES> GetAllRESOURCESRecords(this SIU_S24 message)
        {
            return message.GetAllRecords<SIU_S24_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S24 to RESOURCES
        /// </summary>
        public static SIU_S24_RESOURCES AddRESOURCES(this SIU_S24 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S26
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S26 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S26
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S26 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S26 to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S26 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SIU_S26
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SIU_S26 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SIU_S26
        /// </summary>
        public static List<SIU_S26_PATIENT> GetAllPATIENTRecords(this SIU_S26 message)
        {
            return message.GetAllRecords<SIU_S26_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SIU_S26 to PATIENT
        /// </summary>
        public static SIU_S26_PATIENT AddPATIENT(this SIU_S26 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SIU_S26
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SIU_S26 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SIU_S26
        /// </summary>
        public static List<SIU_S26_RESOURCES> GetAllRESOURCESRecords(this SIU_S26 message)
        {
            return message.GetAllRecords<SIU_S26_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SIU_S26 to RESOURCES
        /// </summary>
        public static SIU_S26_RESOURCES AddRESOURCES(this SIU_S26 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get SCHEDULE Records from SQR_S25
        /// </summary>
        public static IEnumerable GetSCHEDULERecords(this SQR_S25 message)
        {
            object[] result = message.GetRecords("SCHEDULERepetitionsUsed", "GetSCHEDULE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SCHEDULE Records from SQR_S25
        /// </summary>
        public static List<SQR_S25_SCHEDULE> GetAllSCHEDULERecords(this SQR_S25 message)
        {
            return message.GetAllRecords<SQR_S25_SCHEDULE>("SCHEDULERepetitionsUsed", "GetSCHEDULE");
        }

        /// <summary>
        /// Add a new SQR_S25 to SCHEDULE
        /// </summary>
        public static SQR_S25_SCHEDULE AddSCHEDULE(this SQR_S25 message)
        {
            return message.GetSCHEDULE(message.SCHEDULERepetitionsUsed);
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
        /// Add a new SRM_S01 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S01
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S01 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S01
        /// </summary>
        public static List<SRM_S01_PATIENT> GetAllPATIENTRecords(this SRM_S01 message)
        {
            return message.GetAllRecords<SRM_S01_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S01 to PATIENT
        /// </summary>
        public static SRM_S01_PATIENT AddPATIENT(this SRM_S01 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
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
        /// Add a new SRM_S01 to RESOURCES
        /// </summary>
        public static SRM_S01_RESOURCES AddRESOURCES(this SRM_S01 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S02
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S02 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S02
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S02 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S02
        /// </summary>
        public static List<SRM_S02_PATIENT> GetAllPATIENTRecords(this SRM_S02 message)
        {
            return message.GetAllRecords<SRM_S02_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S02 to PATIENT
        /// </summary>
        public static SRM_S02_PATIENT AddPATIENT(this SRM_S02 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S02
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S02 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S02
        /// </summary>
        public static List<SRM_S02_RESOURCES> GetAllRESOURCESRecords(this SRM_S02 message)
        {
            return message.GetAllRecords<SRM_S02_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S02 to RESOURCES
        /// </summary>
        public static SRM_S02_RESOURCES AddRESOURCES(this SRM_S02 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S03
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S03 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S03
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S03 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S03 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S03 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S03
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S03 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S03
        /// </summary>
        public static List<SRM_S03_PATIENT> GetAllPATIENTRecords(this SRM_S03 message)
        {
            return message.GetAllRecords<SRM_S03_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S03 to PATIENT
        /// </summary>
        public static SRM_S03_PATIENT AddPATIENT(this SRM_S03 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S03
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S03 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S03
        /// </summary>
        public static List<SRM_S03_RESOURCES> GetAllRESOURCESRecords(this SRM_S03 message)
        {
            return message.GetAllRecords<SRM_S03_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S03 to RESOURCES
        /// </summary>
        public static SRM_S03_RESOURCES AddRESOURCES(this SRM_S03 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S04
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S04 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S04
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S04 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S04 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S04 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S04
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S04 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S04
        /// </summary>
        public static List<SRM_S04_PATIENT> GetAllPATIENTRecords(this SRM_S04 message)
        {
            return message.GetAllRecords<SRM_S04_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S04 to PATIENT
        /// </summary>
        public static SRM_S04_PATIENT AddPATIENT(this SRM_S04 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S04
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S04 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S04
        /// </summary>
        public static List<SRM_S04_RESOURCES> GetAllRESOURCESRecords(this SRM_S04 message)
        {
            return message.GetAllRecords<SRM_S04_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S04 to RESOURCES
        /// </summary>
        public static SRM_S04_RESOURCES AddRESOURCES(this SRM_S04 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S05
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S05 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S05
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S05 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S05 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S05 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S05
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S05 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S05
        /// </summary>
        public static List<SRM_S05_PATIENT> GetAllPATIENTRecords(this SRM_S05 message)
        {
            return message.GetAllRecords<SRM_S05_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S05 to PATIENT
        /// </summary>
        public static SRM_S05_PATIENT AddPATIENT(this SRM_S05 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S05
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S05 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S05
        /// </summary>
        public static List<SRM_S05_RESOURCES> GetAllRESOURCESRecords(this SRM_S05 message)
        {
            return message.GetAllRecords<SRM_S05_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S05 to RESOURCES
        /// </summary>
        public static SRM_S05_RESOURCES AddRESOURCES(this SRM_S05 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S06
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S06 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S06
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S06 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S06 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S06 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S06
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S06 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S06
        /// </summary>
        public static List<SRM_S06_PATIENT> GetAllPATIENTRecords(this SRM_S06 message)
        {
            return message.GetAllRecords<SRM_S06_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S06 to PATIENT
        /// </summary>
        public static SRM_S06_PATIENT AddPATIENT(this SRM_S06 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S06
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S06 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S06
        /// </summary>
        public static List<SRM_S06_RESOURCES> GetAllRESOURCESRecords(this SRM_S06 message)
        {
            return message.GetAllRecords<SRM_S06_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S06 to RESOURCES
        /// </summary>
        public static SRM_S06_RESOURCES AddRESOURCES(this SRM_S06 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S07
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S07 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S07
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S07 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S07 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S07 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S07
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S07 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S07
        /// </summary>
        public static List<SRM_S07_PATIENT> GetAllPATIENTRecords(this SRM_S07 message)
        {
            return message.GetAllRecords<SRM_S07_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S07 to PATIENT
        /// </summary>
        public static SRM_S07_PATIENT AddPATIENT(this SRM_S07 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S07
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S07 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S07
        /// </summary>
        public static List<SRM_S07_RESOURCES> GetAllRESOURCESRecords(this SRM_S07 message)
        {
            return message.GetAllRecords<SRM_S07_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S07 to RESOURCES
        /// </summary>
        public static SRM_S07_RESOURCES AddRESOURCES(this SRM_S07 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S08
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S08 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S08
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S08 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S08 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S08 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S08
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S08 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S08
        /// </summary>
        public static List<SRM_S08_PATIENT> GetAllPATIENTRecords(this SRM_S08 message)
        {
            return message.GetAllRecords<SRM_S08_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S08 to PATIENT
        /// </summary>
        public static SRM_S08_PATIENT AddPATIENT(this SRM_S08 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S08
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S08 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S08
        /// </summary>
        public static List<SRM_S08_RESOURCES> GetAllRESOURCESRecords(this SRM_S08 message)
        {
            return message.GetAllRecords<SRM_S08_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S08 to RESOURCES
        /// </summary>
        public static SRM_S08_RESOURCES AddRESOURCES(this SRM_S08 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S09
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S09 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S09
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S09 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S09 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S09 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S09
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S09 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S09
        /// </summary>
        public static List<SRM_S09_PATIENT> GetAllPATIENTRecords(this SRM_S09 message)
        {
            return message.GetAllRecords<SRM_S09_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S09 to PATIENT
        /// </summary>
        public static SRM_S09_PATIENT AddPATIENT(this SRM_S09 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S09
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S09 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S09
        /// </summary>
        public static List<SRM_S09_RESOURCES> GetAllRESOURCESRecords(this SRM_S09 message)
        {
            return message.GetAllRecords<SRM_S09_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S09 to RESOURCES
        /// </summary>
        public static SRM_S09_RESOURCES AddRESOURCES(this SRM_S09 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S10
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S10 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S10
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S10 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S10 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S10 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S10
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S10 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S10
        /// </summary>
        public static List<SRM_S10_PATIENT> GetAllPATIENTRecords(this SRM_S10 message)
        {
            return message.GetAllRecords<SRM_S10_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S10 to PATIENT
        /// </summary>
        public static SRM_S10_PATIENT AddPATIENT(this SRM_S10 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S10
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S10 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S10
        /// </summary>
        public static List<SRM_S10_RESOURCES> GetAllRESOURCESRecords(this SRM_S10 message)
        {
            return message.GetAllRecords<SRM_S10_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S10 to RESOURCES
        /// </summary>
        public static SRM_S10_RESOURCES AddRESOURCES(this SRM_S10 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S11
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S11 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S11
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S11 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S11 to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S11 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRM_S11
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRM_S11 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRM_S11
        /// </summary>
        public static List<SRM_S11_PATIENT> GetAllPATIENTRecords(this SRM_S11 message)
        {
            return message.GetAllRecords<SRM_S11_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRM_S11 to PATIENT
        /// </summary>
        public static SRM_S11_PATIENT AddPATIENT(this SRM_S11 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRM_S11
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRM_S11 message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRM_S11
        /// </summary>
        public static List<SRM_S11_RESOURCES> GetAllRESOURCESRecords(this SRM_S11 message)
        {
            return message.GetAllRecords<SRM_S11_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRM_S11 to RESOURCES
        /// </summary>
        public static SRM_S11_RESOURCES AddRESOURCES(this SRM_S11 message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get FACILITY Records from SUR_P09
        /// </summary>
        public static IEnumerable GetFACILITYRecords(this SUR_P09 message)
        {
            object[] result = message.GetRecords("FACILITYRepetitionsUsed", "GetFACILITY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FACILITY Records from SUR_P09
        /// </summary>
        public static List<SUR_P09_FACILITY> GetAllFACILITYRecords(this SUR_P09 message)
        {
            return message.GetAllRecords<SUR_P09_FACILITY>("FACILITYRepetitionsUsed", "GetFACILITY");
        }

        /// <summary>
        /// Add a new SUR_P09 to FACILITY
        /// </summary>
        public static SUR_P09_FACILITY AddFACILITY(this SUR_P09 message)
        {
            return message.GetFACILITY(message.FACILITYRepetitionsUsed);
        }

        /// <summary>
        /// Get RDT Records from TBR_Q01
        /// </summary>
        public static IEnumerable GetRDTRecords(this TBR_Q01 message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from TBR_Q01
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this TBR_Q01 message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Add a new TBR_Q01 to RDT
        /// </summary>
        public static RDT AddRDT(this TBR_Q01 message)
        {
            return message.GetRDT(message.RDTRepetitionsUsed);
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
        /// Add a new VXR_V03 to NK1
        /// </summary>
        public static NK1 AddNK1(this VXR_V03 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from VXR_V03
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this VXR_V03 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from VXR_V03
        /// </summary>
        public static List<VXR_V03_INSURANCE> GetAllINSURANCERecords(this VXR_V03 message)
        {
            return message.GetAllRecords<VXR_V03_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new VXR_V03 to INSURANCE
        /// </summary>
        public static VXR_V03_INSURANCE AddINSURANCE(this VXR_V03 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from VXR_V03
        /// </summary>
        public static IEnumerable GetORDERRecords(this VXR_V03 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from VXR_V03
        /// </summary>
        public static List<VXR_V03_ORDER> GetAllORDERRecords(this VXR_V03 message)
        {
            return message.GetAllRecords<VXR_V03_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new VXR_V03 to ORDER
        /// </summary>
        public static VXR_V03_ORDER AddORDER(this VXR_V03 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new VXU_V04 to NK1
        /// </summary>
        public static NK1 AddNK1(this VXU_V04 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from VXU_V04
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this VXU_V04 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from VXU_V04
        /// </summary>
        public static List<VXU_V04_INSURANCE> GetAllINSURANCERecords(this VXU_V04 message)
        {
            return message.GetAllRecords<VXU_V04_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new VXU_V04 to INSURANCE
        /// </summary>
        public static VXU_V04_INSURANCE AddINSURANCE(this VXU_V04 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from VXU_V04
        /// </summary>
        public static IEnumerable GetORDERRecords(this VXU_V04 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from VXU_V04
        /// </summary>
        public static List<VXU_V04_ORDER> GetAllORDERRecords(this VXU_V04 message)
        {
            return message.GetAllRecords<VXU_V04_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new VXU_V04 to ORDER
        /// </summary>
        public static VXU_V04_ORDER AddORDER(this VXU_V04 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new VXX_V02 to PATIENT
        /// </summary>
        public static VXX_V02_PATIENT AddPATIENT(this VXX_V02 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }
        #endregion
    }
}
