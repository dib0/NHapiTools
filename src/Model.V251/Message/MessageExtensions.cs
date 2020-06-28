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
        /// Add a new ACK to SFT
        /// </summary>
        public static SFT AddSFT(this ACK message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ACK to ERR
        /// </summary>
        public static ERR AddERR(this ACK message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ADR_A19 to SFT
        /// </summary>
        public static SFT AddSFT(this ADR_A19 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADR_A19 to QUERY_RESPONSE
        /// </summary>
        public static ADR_A19_QUERY_RESPONSE AddQUERY_RESPONSE(this ADR_A19 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Add a new ADT_A01 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A01 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A01 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A01 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A01 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A02 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A02 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A02 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A02 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A02 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A03 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A03 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A03 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A03 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A03 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new ADT_A03 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A03 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A03 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A03 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Add a new ADT_A03 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A03 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A03
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A03 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A03
        /// </summary>
        public static List<ADT_A03_INSURANCE> GetAllINSURANCERecords(this ADT_A03 message)
        {
            return message.GetAllRecords<ADT_A03_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A03 to INSURANCE
        /// </summary>
        public static ADT_A03_INSURANCE AddINSURANCE(this ADT_A03 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new ADT_A05 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A05 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A05 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A05 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A05 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A06 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A06 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A06 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A06 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A06 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A09 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A12 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A15 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A15 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A15 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A15 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A15 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A15 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A16 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A16 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A16 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A16 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A16 to NK1
        /// </summary>
        public static NK1 AddNK1(this ADT_A16 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Add a new ADT_A16 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A16 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A16 to AL1
        /// </summary>
        public static AL1 AddAL1(this ADT_A16 message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
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
        /// Get PROCEDURE Records from ADT_A16
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADT_A16 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADT_A16
        /// </summary>
        public static List<ADT_A16_PROCEDURE> GetAllPROCEDURERecords(this ADT_A16 message)
        {
            return message.GetAllRecords<ADT_A16_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADT_A16 to PROCEDURE
        /// </summary>
        public static ADT_A16_PROCEDURE AddPROCEDURE(this ADT_A16 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new ADT_A16 to GT1
        /// </summary>
        public static GT1 AddGT1(this ADT_A16 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADT_A16
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADT_A16 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADT_A16
        /// </summary>
        public static List<ADT_A16_INSURANCE> GetAllINSURANCERecords(this ADT_A16 message)
        {
            return message.GetAllRecords<ADT_A16_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADT_A16 to INSURANCE
        /// </summary>
        public static ADT_A16_INSURANCE AddINSURANCE(this ADT_A16 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new ADT_A17 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A17 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A18 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A18 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A20 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A20 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A21 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A24 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A24 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A30 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A30 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A37 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A37 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A38 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A38 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A39 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A39 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A43 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A43 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A45 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A45 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A50 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A50 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A52 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A52 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A54 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A54 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A54 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A54 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new ADT_A54 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A54 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new ADT_A60 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A60 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A60 to IAM
        /// </summary>
        public static IAM AddIAM(this ADT_A60 message)
        {
            return message.GetIAM(message.IAMRepetitionsUsed);
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
        /// Add a new ADT_A61 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A61 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ADT_A61 to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A61 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new BAR_P01 to SFT
        /// </summary>
        public static SFT AddSFT(this BAR_P01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BAR_P01 to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P01 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new BAR_P02 to SFT
        /// </summary>
        public static SFT AddSFT(this BAR_P02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BAR_P05 to SFT
        /// </summary>
        public static SFT AddSFT(this BAR_P05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BAR_P05 to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P05 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new BAR_P06 to SFT
        /// </summary>
        public static SFT AddSFT(this BAR_P06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BAR_P10 to SFT
        /// </summary>
        public static SFT AddSFT(this BAR_P10 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BAR_P10 to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P10 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from BAR_P10
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this BAR_P10 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from BAR_P10
        /// </summary>
        public static List<BAR_P10_PROCEDURE> GetAllPROCEDURERecords(this BAR_P10 message)
        {
            return message.GetAllRecords<BAR_P10_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new BAR_P10 to PROCEDURE
        /// </summary>
        public static BAR_P10_PROCEDURE AddPROCEDURE(this BAR_P10 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new BAR_P12 to SFT
        /// </summary>
        public static SFT AddSFT(this BAR_P12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BAR_P12 to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P12 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from BAR_P12
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this BAR_P12 message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from BAR_P12
        /// </summary>
        public static List<BAR_P12_PROCEDURE> GetAllPROCEDURERecords(this BAR_P12 message)
        {
            return message.GetAllRecords<BAR_P12_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new BAR_P12 to PROCEDURE
        /// </summary>
        public static BAR_P12_PROCEDURE AddPROCEDURE(this BAR_P12 message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
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
        /// Add a new BPS_O29 to SFT
        /// </summary>
        public static SFT AddSFT(this BPS_O29 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BPS_O29 to NTE
        /// </summary>
        public static NTE AddNTE(this BPS_O29 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new BPS_O29 to ORDER
        /// </summary>
        public static BPS_O29_ORDER AddORDER(this BPS_O29 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new BRP_O30 to ERR
        /// </summary>
        public static ERR AddERR(this BRP_O30 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new BRP_O30 to SFT
        /// </summary>
        public static SFT AddSFT(this BRP_O30 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BRP_O30 to NTE
        /// </summary>
        public static NTE AddNTE(this BRP_O30 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new BRT_O32 to ERR
        /// </summary>
        public static ERR AddERR(this BRT_O32 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new BRT_O32 to SFT
        /// </summary>
        public static SFT AddSFT(this BRT_O32 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BRT_O32 to NTE
        /// </summary>
        public static NTE AddNTE(this BRT_O32 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new BTS_O31 to SFT
        /// </summary>
        public static SFT AddSFT(this BTS_O31 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new BTS_O31 to NTE
        /// </summary>
        public static NTE AddNTE(this BTS_O31 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new BTS_O31 to ORDER
        /// </summary>
        public static BTS_O31_ORDER AddORDER(this BTS_O31 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new CRM_C01 to SFT
        /// </summary>
        public static SFT AddSFT(this CRM_C01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new CSU_C09 to SFT
        /// </summary>
        public static SFT AddSFT(this CSU_C09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new DFT_P03 to SFT
        /// </summary>
        public static SFT AddSFT(this DFT_P03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new DFT_P03 to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P03 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new DFT_P03 to ROL2
        /// </summary>
        public static ROL AddROL2(this DFT_P03 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Get COMMON_ORDER Records from DFT_P03
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this DFT_P03 message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from DFT_P03
        /// </summary>
        public static List<DFT_P03_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this DFT_P03 message)
        {
            return message.GetAllRecords<DFT_P03_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new DFT_P03 to COMMON_ORDER
        /// </summary>
        public static DFT_P03_COMMON_ORDER AddCOMMON_ORDER(this DFT_P03 message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
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
        /// Add a new DFT_P11 to SFT
        /// </summary>
        public static SFT AddSFT(this DFT_P11 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new DFT_P11 to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P11 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Add a new DFT_P11 to ROL2
        /// </summary>
        public static ROL AddROL2(this DFT_P11 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Add a new DFT_P11 to DB1
        /// </summary>
        public static DB1 AddDB1(this DFT_P11 message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from DFT_P11
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this DFT_P11 message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from DFT_P11
        /// </summary>
        public static List<DFT_P11_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this DFT_P11 message)
        {
            return message.GetAllRecords<DFT_P11_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new DFT_P11 to COMMON_ORDER
        /// </summary>
        public static DFT_P11_COMMON_ORDER AddCOMMON_ORDER(this DFT_P11 message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
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
        /// Add a new DFT_P11 to DG1
        /// </summary>
        public static DG1 AddDG1(this DFT_P11 message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
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
        /// Add a new DFT_P11 to GT1
        /// </summary>
        public static GT1 AddGT1(this DFT_P11 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from DFT_P11
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this DFT_P11 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from DFT_P11
        /// </summary>
        public static List<DFT_P11_INSURANCE> GetAllINSURANCERecords(this DFT_P11 message)
        {
            return message.GetAllRecords<DFT_P11_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new DFT_P11 to INSURANCE
        /// </summary>
        public static DFT_P11_INSURANCE AddINSURANCE(this DFT_P11 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
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
        /// Add a new DFT_P11 to FINANCIAL
        /// </summary>
        public static DFT_P11_FINANCIAL AddFINANCIAL(this DFT_P11 message)
        {
            return message.GetFINANCIAL(message.FINANCIALRepetitionsUsed);
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
        /// Add a new DSR_Q01 to SFT
        /// </summary>
        public static SFT AddSFT(this DSR_Q01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new DSR_Q03 to SFT
        /// </summary>
        public static SFT AddSFT(this DSR_Q03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new EAC_U07 to SFT
        /// </summary>
        public static SFT AddSFT(this EAC_U07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new EAC_U07 to COMMAND
        /// </summary>
        public static EAC_U07_COMMAND AddCOMMAND(this EAC_U07 message)
        {
            return message.GetCOMMAND(message.COMMANDRepetitionsUsed);
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
        /// Add a new EAN_U09 to SFT
        /// </summary>
        public static SFT AddSFT(this EAN_U09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new EAN_U09 to NOTIFICATION
        /// </summary>
        public static EAN_U09_NOTIFICATION AddNOTIFICATION(this EAN_U09 message)
        {
            return message.GetNOTIFICATION(message.NOTIFICATIONRepetitionsUsed);
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
        /// Add a new EAR_U08 to SFT
        /// </summary>
        public static SFT AddSFT(this EAR_U08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new EAR_U08 to COMMAND_RESPONSE
        /// </summary>
        public static EAR_U08_COMMAND_RESPONSE AddCOMMAND_RESPONSE(this EAR_U08 message)
        {
            return message.GetCOMMAND_RESPONSE(message.COMMAND_RESPONSERepetitionsUsed);
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
        /// Add a new EDR_R07 to SFT
        /// </summary>
        public static SFT AddSFT(this EDR_R07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new EDR_R07 to DSP
        /// </summary>
        public static DSP AddDSP(this EDR_R07 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
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
        /// Add a new EQQ_Q04 to SFT
        /// </summary>
        public static SFT AddSFT(this EQQ_Q04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ERP_R09 to SFT
        /// </summary>
        public static SFT AddSFT(this ERP_R09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ESR_U02 to SFT
        /// </summary>
        public static SFT AddSFT(this ESR_U02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ESU_U01 to SFT
        /// </summary>
        public static SFT AddSFT(this ESU_U01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ESU_U01 to ISD
        /// </summary>
        public static ISD AddISD(this ESU_U01 message)
        {
            return message.GetISD(message.ISDRepetitionsUsed);
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
        /// Add a new INR_U06 to SFT
        /// </summary>
        public static SFT AddSFT(this INR_U06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new INR_U06 to INV
        /// </summary>
        public static INV AddINV(this INR_U06 message)
        {
            return message.GetINV(message.INVRepetitionsUsed);
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
        /// Add a new INU_U05 to SFT
        /// </summary>
        public static SFT AddSFT(this INU_U05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new INU_U05 to INV
        /// </summary>
        public static INV AddINV(this INU_U05 message)
        {
            return message.GetINV(message.INVRepetitionsUsed);
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
        /// Add a new LSU_U12 to SFT
        /// </summary>
        public static SFT AddSFT(this LSU_U12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new LSU_U12 to EQP
        /// </summary>
        public static EQP AddEQP(this LSU_U12 message)
        {
            return message.GetEQP(message.EQPRepetitionsUsed);
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
        /// Add a new MDM_T01 to SFT
        /// </summary>
        public static SFT AddSFT(this MDM_T01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from MDM_T01
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this MDM_T01 message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from MDM_T01
        /// </summary>
        public static List<MDM_T01_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this MDM_T01 message)
        {
            return message.GetAllRecords<MDM_T01_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new MDM_T01 to COMMON_ORDER
        /// </summary>
        public static MDM_T01_COMMON_ORDER AddCOMMON_ORDER(this MDM_T01 message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
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
        /// Add a new MDM_T02 to SFT
        /// </summary>
        public static SFT AddSFT(this MDM_T02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get COMMON_ORDER Records from MDM_T02
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this MDM_T02 message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from MDM_T02
        /// </summary>
        public static List<MDM_T02_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this MDM_T02 message)
        {
            return message.GetAllRecords<MDM_T02_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Add a new MDM_T02 to COMMON_ORDER
        /// </summary>
        public static MDM_T02_COMMON_ORDER AddCOMMON_ORDER(this MDM_T02 message)
        {
            return message.GetCOMMON_ORDER(message.COMMON_ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from MDM_T02
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this MDM_T02 message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from MDM_T02
        /// </summary>
        public static List<MDM_T02_OBSERVATION> GetAllOBSERVATIONRecords(this MDM_T02 message)
        {
            return message.GetAllRecords<MDM_T02_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new MDM_T02 to OBSERVATION
        /// </summary>
        public static MDM_T02_OBSERVATION AddOBSERVATION(this MDM_T02 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new MFK_M01 to SFT
        /// </summary>
        public static SFT AddSFT(this MFK_M01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFK_M01 to ERR
        /// </summary>
        public static ERR AddERR(this MFK_M01 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new MFN_M01 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M02 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M03 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M04 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M05 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M06 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M07 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M07 to MF_CLIN_STUDY_SCHED
        /// </summary>
        public static MFN_M07_MF_CLIN_STUDY_SCHED AddMF_CLIN_STUDY_SCHED(this MFN_M07 message)
        {
            return message.GetMF_CLIN_STUDY_SCHED(message.MF_CLIN_STUDY_SCHEDRepetitionsUsed);
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
        /// Add a new MFN_M08 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M09 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M10 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M10 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M11 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M11 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M12 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M12 to MF_OBS_ATTRIBUTES
        /// </summary>
        public static MFN_M12_MF_OBS_ATTRIBUTES AddMF_OBS_ATTRIBUTES(this MFN_M12 message)
        {
            return message.GetMF_OBS_ATTRIBUTES(message.MF_OBS_ATTRIBUTESRepetitionsUsed);
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
        /// Add a new MFN_M13 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M13 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M13 to MFE
        /// </summary>
        public static MFE AddMFE(this MFN_M13 message)
        {
            return message.GetMFE(message.MFERepetitionsUsed);
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
        /// Add a new MFN_M15 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M15 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFN_M15 to MF_INV_ITEM
        /// </summary>
        public static MFN_M15_MF_INV_ITEM AddMF_INV_ITEM(this MFN_M15 message)
        {
            return message.GetMF_INV_ITEM(message.MF_INV_ITEMRepetitionsUsed);
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
        /// Add a new MFN_Znn to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_Znn message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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

        /// <summary>
        /// Add a new MFN_Znn to MF_SITE_DEFINED
        /// </summary>
        public static MFN_Znn_MF_SITE_DEFINED AddMF_SITE_DEFINED(this MFN_Znn message)
        {
            return message.GetMF_SITE_DEFINED(message.MF_SITE_DEFINEDRepetitionsUsed);
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
        /// Add a new MFQ_M01 to SFT
        /// </summary>
        public static SFT AddSFT(this MFQ_M01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFR_M01 to SFT
        /// </summary>
        public static SFT AddSFT(this MFR_M01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFR_M01 to ERR
        /// </summary>
        public static ERR AddERR(this MFR_M01 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new MFR_M01 to MF_QUERY
        /// </summary>
        public static MFR_M01_MF_QUERY AddMF_QUERY(this MFR_M01 message)
        {
            return message.GetMF_QUERY(message.MF_QUERYRepetitionsUsed);
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
        /// Add a new MFR_M04 to SFT
        /// </summary>
        public static SFT AddSFT(this MFR_M04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFR_M04 to ERR
        /// </summary>
        public static ERR AddERR(this MFR_M04 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new MFR_M04 to MF_QUERY
        /// </summary>
        public static MFR_M04_MF_QUERY AddMF_QUERY(this MFR_M04 message)
        {
            return message.GetMF_QUERY(message.MF_QUERYRepetitionsUsed);
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
        /// Add a new MFR_M05 to SFT
        /// </summary>
        public static SFT AddSFT(this MFR_M05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFR_M05 to ERR
        /// </summary>
        public static ERR AddERR(this MFR_M05 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new MFR_M05 to MF_QUERY
        /// </summary>
        public static MFR_M05_MF_QUERY AddMF_QUERY(this MFR_M05 message)
        {
            return message.GetMF_QUERY(message.MF_QUERYRepetitionsUsed);
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
        /// Add a new MFR_M06 to SFT
        /// </summary>
        public static SFT AddSFT(this MFR_M06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFR_M06 to ERR
        /// </summary>
        public static ERR AddERR(this MFR_M06 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new MFR_M06 to MF_QUERY
        /// </summary>
        public static MFR_M06_MF_QUERY AddMF_QUERY(this MFR_M06 message)
        {
            return message.GetMF_QUERY(message.MF_QUERYRepetitionsUsed);
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
        /// Add a new MFR_M07 to SFT
        /// </summary>
        public static SFT AddSFT(this MFR_M07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new MFR_M07 to ERR
        /// </summary>
        public static ERR AddERR(this MFR_M07 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new MFR_M07 to MF_QUERY
        /// </summary>
        public static MFR_M07_MF_QUERY AddMF_QUERY(this MFR_M07 message)
        {
            return message.GetMF_QUERY(message.MF_QUERYRepetitionsUsed);
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
        /// Add a new NMD_N02 to SFT
        /// </summary>
        public static SFT AddSFT(this NMD_N02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new NMD_N02 to CLOCK_AND_STATS_WITH_NOTES
        /// </summary>
        public static NMD_N02_CLOCK_AND_STATS_WITH_NOTES AddCLOCK_AND_STATS_WITH_NOTES(this NMD_N02 message)
        {
            return message.GetCLOCK_AND_STATS_WITH_NOTES(message.CLOCK_AND_STATS_WITH_NOTESRepetitionsUsed);
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
        /// Add a new NMQ_N01 to SFT
        /// </summary>
        public static SFT AddSFT(this NMQ_N01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new NMQ_N01 to CLOCK_AND_STATISTICS
        /// </summary>
        public static NMQ_N01_CLOCK_AND_STATISTICS AddCLOCK_AND_STATISTICS(this NMQ_N01 message)
        {
            return message.GetCLOCK_AND_STATISTICS(message.CLOCK_AND_STATISTICSRepetitionsUsed);
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
        /// Add a new NMR_N01 to SFT
        /// </summary>
        public static SFT AddSFT(this NMR_N01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new NMR_N01 to ERR
        /// </summary>
        public static ERR AddERR(this NMR_N01 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new NMR_N01 to CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT AddCLOCK_AND_STATS_WITH_NOTES_ALT(this NMR_N01 message)
        {
            return message.GetCLOCK_AND_STATS_WITH_NOTES_ALT(message.CLOCK_AND_STATS_WITH_NOTES_ALTRepetitionsUsed);
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
        /// Add a new OMB_O27 to SFT
        /// </summary>
        public static SFT AddSFT(this OMB_O27 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMB_O27 to NTE
        /// </summary>
        public static NTE AddNTE(this OMB_O27 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMB_O27 to ORDER
        /// </summary>
        public static OMB_O27_ORDER AddORDER(this OMB_O27 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new OMD_O03 to SFT
        /// </summary>
        public static SFT AddSFT(this OMD_O03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMD_O03 to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O03 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMD_O03 to ORDER_DIET
        /// </summary>
        public static OMD_O03_ORDER_DIET AddORDER_DIET(this OMD_O03 message)
        {
            return message.GetORDER_DIET(message.ORDER_DIETRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_TRAY Records from OMD_O03
        /// </summary>
        public static IEnumerable GetORDER_TRAYRecords(this OMD_O03 message)
        {
            object[] result = message.GetRecords("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_TRAY Records from OMD_O03
        /// </summary>
        public static List<OMD_O03_ORDER_TRAY> GetAllORDER_TRAYRecords(this OMD_O03 message)
        {
            return message.GetAllRecords<OMD_O03_ORDER_TRAY>("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");
        }

        /// <summary>
        /// Add a new OMD_O03 to ORDER_TRAY
        /// </summary>
        public static OMD_O03_ORDER_TRAY AddORDER_TRAY(this OMD_O03 message)
        {
            return message.GetORDER_TRAY(message.ORDER_TRAYRepetitionsUsed);
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
        /// Add a new OMG_O19 to SFT
        /// </summary>
        public static SFT AddSFT(this OMG_O19 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMG_O19 to NTE
        /// </summary>
        public static NTE AddNTE(this OMG_O19 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMG_O19 to ORDER
        /// </summary>
        public static OMG_O19_ORDER AddORDER(this OMG_O19 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new OMI_O23 to SFT
        /// </summary>
        public static SFT AddSFT(this OMI_O23 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMI_O23 to NTE
        /// </summary>
        public static NTE AddNTE(this OMI_O23 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMI_O23 to ORDER
        /// </summary>
        public static OMI_O23_ORDER AddORDER(this OMI_O23 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new OML_O21 to SFT
        /// </summary>
        public static SFT AddSFT(this OML_O21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OML_O21 to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O21 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OML_O21 to ORDER
        /// </summary>
        public static OML_O21_ORDER AddORDER(this OML_O21 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new OML_O33 to SFT
        /// </summary>
        public static SFT AddSFT(this OML_O33 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OML_O33 to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O33 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OML_O33 to SPECIMEN
        /// </summary>
        public static OML_O33_SPECIMEN AddSPECIMEN(this OML_O33 message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
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
        /// Add a new OML_O35 to SFT
        /// </summary>
        public static SFT AddSFT(this OML_O35 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OML_O35 to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O35 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OML_O35 to SPECIMEN
        /// </summary>
        public static OML_O35_SPECIMEN AddSPECIMEN(this OML_O35 message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
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
        /// Add a new OMN_O07 to SFT
        /// </summary>
        public static SFT AddSFT(this OMN_O07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMN_O07 to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O07 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMN_O07 to ORDER
        /// </summary>
        public static OMN_O07_ORDER AddORDER(this OMN_O07 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new OMP_O09 to SFT
        /// </summary>
        public static SFT AddSFT(this OMP_O09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMP_O09 to NTE
        /// </summary>
        public static NTE AddNTE(this OMP_O09 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMP_O09 to ORDER
        /// </summary>
        public static OMP_O09_ORDER AddORDER(this OMP_O09 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new OMS_O05 to SFT
        /// </summary>
        public static SFT AddSFT(this OMS_O05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OMS_O05 to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O05 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new OMS_O05 to ORDER
        /// </summary>
        public static OMS_O05_ORDER AddORDER(this OMS_O05 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new ORB_O28 to ERR
        /// </summary>
        public static ERR AddERR(this ORB_O28 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORB_O28 to SFT
        /// </summary>
        public static SFT AddSFT(this ORB_O28 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORB_O28 to NTE
        /// </summary>
        public static NTE AddNTE(this ORB_O28 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORD_O04 to ERR
        /// </summary>
        public static ERR AddERR(this ORD_O04 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORD_O04 to SFT
        /// </summary>
        public static SFT AddSFT(this ORD_O04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORD_O04 to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O04 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORF_R04 to SFT
        /// </summary>
        public static SFT AddSFT(this ORF_R04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORF_R04 to ERR
        /// </summary>
        public static ERR AddERR(this ORF_R04 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORG_O20 to ERR
        /// </summary>
        public static ERR AddERR(this ORG_O20 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORG_O20 to SFT
        /// </summary>
        public static SFT AddSFT(this ORG_O20 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORG_O20 to NTE
        /// </summary>
        public static NTE AddNTE(this ORG_O20 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORI_O24 to ERR
        /// </summary>
        public static ERR AddERR(this ORI_O24 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORI_O24 to SFT
        /// </summary>
        public static SFT AddSFT(this ORI_O24 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORI_O24 to NTE
        /// </summary>
        public static NTE AddNTE(this ORI_O24 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORL_O22 to ERR
        /// </summary>
        public static ERR AddERR(this ORL_O22 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORL_O22 to SFT
        /// </summary>
        public static SFT AddSFT(this ORL_O22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORL_O22 to NTE
        /// </summary>
        public static NTE AddNTE(this ORL_O22 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORL_O34 to ERR
        /// </summary>
        public static ERR AddERR(this ORL_O34 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORL_O34 to SFT
        /// </summary>
        public static SFT AddSFT(this ORL_O34 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORL_O34 to NTE
        /// </summary>
        public static NTE AddNTE(this ORL_O34 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORL_O36 to ERR
        /// </summary>
        public static ERR AddERR(this ORL_O36 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORL_O36 to SFT
        /// </summary>
        public static SFT AddSFT(this ORL_O36 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORL_O36 to NTE
        /// </summary>
        public static NTE AddNTE(this ORL_O36 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORN_O08 to ERR
        /// </summary>
        public static ERR AddERR(this ORN_O08 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORN_O08 to SFT
        /// </summary>
        public static SFT AddSFT(this ORN_O08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORN_O08 to NTE
        /// </summary>
        public static NTE AddNTE(this ORN_O08 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORP_O10 to ERR
        /// </summary>
        public static ERR AddERR(this ORP_O10 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORP_O10 to SFT
        /// </summary>
        public static SFT AddSFT(this ORP_O10 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORP_O10 to NTE
        /// </summary>
        public static NTE AddNTE(this ORP_O10 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORR_O02 to ERR
        /// </summary>
        public static ERR AddERR(this ORR_O02 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORS_O06 to ERR
        /// </summary>
        public static ERR AddERR(this ORS_O06 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ORS_O06 to SFT
        /// </summary>
        public static SFT AddSFT(this ORS_O06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORS_O06 to NTE
        /// </summary>
        public static NTE AddNTE(this ORS_O06 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new ORU_R01 to SFT
        /// </summary>
        public static SFT AddSFT(this ORU_R01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORU_R30 to SFT
        /// </summary>
        public static SFT AddSFT(this ORU_R30 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new ORU_R30 to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R30 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get TIMING_QTY Records from ORU_R30
        /// </summary>
        public static IEnumerable GetTIMING_QTYRecords(this ORU_R30 message)
        {
            object[] result = message.GetRecords("TIMING_QTYRepetitionsUsed", "GetTIMING_QTY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TIMING_QTY Records from ORU_R30
        /// </summary>
        public static List<ORU_R30_TIMING_QTY> GetAllTIMING_QTYRecords(this ORU_R30 message)
        {
            return message.GetAllRecords<ORU_R30_TIMING_QTY>("TIMING_QTYRepetitionsUsed", "GetTIMING_QTY");
        }

        /// <summary>
        /// Add a new ORU_R30 to TIMING_QTY
        /// </summary>
        public static ORU_R30_TIMING_QTY AddTIMING_QTY(this ORU_R30 message)
        {
            return message.GetTIMING_QTY(message.TIMING_QTYRepetitionsUsed);
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
        /// Add a new ORU_R30 to OBSERVATION
        /// </summary>
        public static ORU_R30_OBSERVATION AddOBSERVATION(this ORU_R30 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new OSQ_Q06 to SFT
        /// </summary>
        public static SFT AddSFT(this OSQ_Q06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OSR_Q06 to ERR
        /// </summary>
        public static ERR AddERR(this OSR_Q06 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new OSR_Q06 to SFT
        /// </summary>
        public static SFT AddSFT(this OSR_Q06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OUL_R21 to SFT
        /// </summary>
        public static SFT AddSFT(this OUL_R21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OUL_R21 to ORDER_OBSERVATION
        /// </summary>
        public static OUL_R21_ORDER_OBSERVATION AddORDER_OBSERVATION(this OUL_R21 message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
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
        /// Add a new OUL_R22 to SFT
        /// </summary>
        public static SFT AddSFT(this OUL_R22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OUL_R22 to SPECIMEN
        /// </summary>
        public static OUL_R22_SPECIMEN AddSPECIMEN(this OUL_R22 message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
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
        /// Add a new OUL_R23 to SFT
        /// </summary>
        public static SFT AddSFT(this OUL_R23 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SPECIMEN Records from OUL_R23
        /// </summary>
        public static IEnumerable GetSPECIMENRecords(this OUL_R23 message)
        {
            object[] result = message.GetRecords("SPECIMENRepetitionsUsed", "GetSPECIMEN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SPECIMEN Records from OUL_R23
        /// </summary>
        public static List<OUL_R23_SPECIMEN> GetAllSPECIMENRecords(this OUL_R23 message)
        {
            return message.GetAllRecords<OUL_R23_SPECIMEN>("SPECIMENRepetitionsUsed", "GetSPECIMEN");
        }

        /// <summary>
        /// Add a new OUL_R23 to SPECIMEN
        /// </summary>
        public static OUL_R23_SPECIMEN AddSPECIMEN(this OUL_R23 message)
        {
            return message.GetSPECIMEN(message.SPECIMENRepetitionsUsed);
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
        /// Add a new OUL_R24 to SFT
        /// </summary>
        public static SFT AddSFT(this OUL_R24 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new OUL_R24 to ORDER
        /// </summary>
        public static OUL_R24_ORDER AddORDER(this OUL_R24 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new PEX_P07 to SFT
        /// </summary>
        public static SFT AddSFT(this PEX_P07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PGL_PC6 to SFT
        /// </summary>
        public static SFT AddSFT(this PGL_PC6 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PMU_B01 to SFT
        /// </summary>
        public static SFT AddSFT(this PMU_B01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PMU_B01 to PRA
        /// </summary>
        public static PRA AddPRA(this PMU_B01 message)
        {
            return message.GetPRA(message.PRARepetitionsUsed);
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
        /// Add a new PMU_B01 to ORG
        /// </summary>
        public static ORG AddORG(this PMU_B01 message)
        {
            return message.GetORG(message.ORGRepetitionsUsed);
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
        /// Add a new PMU_B01 to AFF
        /// </summary>
        public static AFF AddAFF(this PMU_B01 message)
        {
            return message.GetAFF(message.AFFRepetitionsUsed);
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
        /// Add a new PMU_B01 to LAN
        /// </summary>
        public static LAN AddLAN(this PMU_B01 message)
        {
            return message.GetLAN(message.LANRepetitionsUsed);
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
        /// Add a new PMU_B01 to EDU
        /// </summary>
        public static EDU AddEDU(this PMU_B01 message)
        {
            return message.GetEDU(message.EDURepetitionsUsed);
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
        /// Add a new PMU_B01 to CER
        /// </summary>
        public static CER AddCER(this PMU_B01 message)
        {
            return message.GetCER(message.CERRepetitionsUsed);
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
        /// Add a new PMU_B03 to SFT
        /// </summary>
        public static SFT AddSFT(this PMU_B03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PMU_B04 to SFT
        /// </summary>
        public static SFT AddSFT(this PMU_B04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PMU_B04 to PRA
        /// </summary>
        public static PRA AddPRA(this PMU_B04 message)
        {
            return message.GetPRA(message.PRARepetitionsUsed);
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
        /// Add a new PMU_B04 to ORG
        /// </summary>
        public static ORG AddORG(this PMU_B04 message)
        {
            return message.GetORG(message.ORGRepetitionsUsed);
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
        /// Add a new PMU_B07 to SFT
        /// </summary>
        public static SFT AddSFT(this PMU_B07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PMU_B07 to CERTIFICATE
        /// </summary>
        public static PMU_B07_CERTIFICATE AddCERTIFICATE(this PMU_B07 message)
        {
            return message.GetCERTIFICATE(message.CERTIFICATERepetitionsUsed);
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
        /// Add a new PMU_B08 to SFT
        /// </summary>
        public static SFT AddSFT(this PMU_B08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PMU_B08 to CER
        /// </summary>
        public static CER AddCER(this PMU_B08 message)
        {
            return message.GetCER(message.CERRepetitionsUsed);
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
        /// Add a new PPG_PCG to SFT
        /// </summary>
        public static SFT AddSFT(this PPG_PCG message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PPP_PCB to SFT
        /// </summary>
        public static SFT AddSFT(this PPP_PCB message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PPR_PC1 to SFT
        /// </summary>
        public static SFT AddSFT(this PPR_PC1 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PPT_PCL to SFT
        /// </summary>
        public static SFT AddSFT(this PPT_PCL message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PPT_PCL to ERR
        /// </summary>
        public static ERR AddERR(this PPT_PCL message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new PPV_PCA to SFT
        /// </summary>
        public static SFT AddSFT(this PPV_PCA message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PPV_PCA to ERR
        /// </summary>
        public static ERR AddERR(this PPV_PCA message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new PRR_PC5 to SFT
        /// </summary>
        public static SFT AddSFT(this PRR_PC5 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PRR_PC5 to ERR
        /// </summary>
        public static ERR AddERR(this PRR_PC5 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new PTR_PCF to SFT
        /// </summary>
        public static SFT AddSFT(this PTR_PCF message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new PTR_PCF to ERR
        /// </summary>
        public static ERR AddERR(this PTR_PCF message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new QBP_Q11 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_Q11 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QBP_Q13 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_Q13 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QBP_Q15 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_Q15 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QBP_Q21 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_Q21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QBP_Qnn to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_Qnn message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QBP_Z73 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_Z73 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QCK_Q02 to SFT
        /// </summary>
        public static SFT AddSFT(this QCK_Q02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QCN_J01 to SFT
        /// </summary>
        public static SFT AddSFT(this QCN_J01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QRY_A19 to SFT
        /// </summary>
        public static SFT AddSFT(this QRY_A19 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QRY_PC4 to SFT
        /// </summary>
        public static SFT AddSFT(this QRY_PC4 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QRY_Q01 to SFT
        /// </summary>
        public static SFT AddSFT(this QRY_Q01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QRY_Q02 to SFT
        /// </summary>
        public static SFT AddSFT(this QRY_Q02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QRY_R02 to SFT
        /// </summary>
        public static SFT AddSFT(this QRY_R02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QSB_Q16 to SFT
        /// </summary>
        public static SFT AddSFT(this QSB_Q16 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new QVR_Q17 to SFT
        /// </summary>
        public static SFT AddSFT(this QVR_Q17 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RAR_RAR to ERR
        /// </summary>
        public static ERR AddERR(this RAR_RAR message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RAR_RAR to SFT
        /// </summary>
        public static SFT AddSFT(this RAR_RAR message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RAS_O17 to SFT
        /// </summary>
        public static SFT AddSFT(this RAS_O17 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RAS_O17 to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O17 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RAS_O17 to ORDER
        /// </summary>
        public static RAS_O17_ORDER AddORDER(this RAS_O17 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new RCI_I05 to SFT
        /// </summary>
        public static SFT AddSFT(this RCI_I05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RCL_I06 to SFT
        /// </summary>
        public static SFT AddSFT(this RCL_I06 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RDE_O11 to SFT
        /// </summary>
        public static SFT AddSFT(this RDE_O11 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RDE_O11 to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O11 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RDE_O11 to ORDER
        /// </summary>
        public static RDE_O11_ORDER AddORDER(this RDE_O11 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new RDS_O13 to SFT
        /// </summary>
        public static SFT AddSFT(this RDS_O13 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RDS_O13 to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O13 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RDS_O13 to ORDER
        /// </summary>
        public static RDS_O13_ORDER AddORDER(this RDS_O13 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new RDY_K15 to SFT
        /// </summary>
        public static SFT AddSFT(this RDY_K15 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RDY_K15 to DSP
        /// </summary>
        public static DSP AddDSP(this RDY_K15 message)
        {
            return message.GetDSP(message.DSPRepetitionsUsed);
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
        /// Add a new REF_I12 to SFT
        /// </summary>
        public static SFT AddSFT(this REF_I12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new REF_I12 to PROVIDER_CONTACT
        /// </summary>
        public static REF_I12_PROVIDER_CONTACT AddPROVIDER_CONTACT(this REF_I12 message)
        {
            return message.GetPROVIDER_CONTACT(message.PROVIDER_CONTACTRepetitionsUsed);
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
        /// Add a new REF_I12 to OBSERVATION
        /// </summary>
        public static REF_I12_OBSERVATION AddOBSERVATION(this REF_I12 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new RER_RER to ERR
        /// </summary>
        public static ERR AddERR(this RER_RER message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RER_RER to SFT
        /// </summary>
        public static SFT AddSFT(this RER_RER message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RGR_RGR to ERR
        /// </summary>
        public static ERR AddERR(this RGR_RGR message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RGR_RGR to SFT
        /// </summary>
        public static SFT AddSFT(this RGR_RGR message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RGV_O15 to SFT
        /// </summary>
        public static SFT AddSFT(this RGV_O15 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RGV_O15 to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O15 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RGV_O15 to ORDER
        /// </summary>
        public static RGV_O15_ORDER AddORDER(this RGV_O15 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Add a new ROR_ROR to ERR
        /// </summary>
        public static ERR AddERR(this ROR_ROR message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new ROR_ROR to SFT
        /// </summary>
        public static SFT AddSFT(this ROR_ROR message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RPA_I08 to SFT
        /// </summary>
        public static SFT AddSFT(this RPA_I08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RPA_I08 to NTE
        /// </summary>
        public static NTE AddNTE(this RPA_I08 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RPI_I01 to SFT
        /// </summary>
        public static SFT AddSFT(this RPI_I01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RPI_I04 to SFT
        /// </summary>
        public static SFT AddSFT(this RPI_I04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RPL_I02 to SFT
        /// </summary>
        public static SFT AddSFT(this RPL_I02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RPR_I03 to SFT
        /// </summary>
        public static SFT AddSFT(this RPR_I03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RQA_I08 to SFT
        /// </summary>
        public static SFT AddSFT(this RQA_I08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RQC_I05 to SFT
        /// </summary>
        public static SFT AddSFT(this RQC_I05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RQI_I01 to SFT
        /// </summary>
        public static SFT AddSFT(this RQI_I01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RQI_I01 to PROVIDER
        /// </summary>
        public static RQI_I01_PROVIDER AddPROVIDER(this RQI_I01 message)
        {
            return message.GetPROVIDER(message.PROVIDERRepetitionsUsed);
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
        /// Add a new RQP_I04 to SFT
        /// </summary>
        public static SFT AddSFT(this RQP_I04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RQQ_Q09 to SFT
        /// </summary>
        public static SFT AddSFT(this RQQ_Q09 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RRA_O18 to ERR
        /// </summary>
        public static ERR AddERR(this RRA_O18 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RRA_O18 to SFT
        /// </summary>
        public static SFT AddSFT(this RRA_O18 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RRA_O18 to NTE
        /// </summary>
        public static NTE AddNTE(this RRA_O18 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RRD_O14 to ERR
        /// </summary>
        public static ERR AddERR(this RRD_O14 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RRD_O14 to SFT
        /// </summary>
        public static SFT AddSFT(this RRD_O14 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RRD_O14 to NTE
        /// </summary>
        public static NTE AddNTE(this RRD_O14 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RRE_O12 to ERR
        /// </summary>
        public static ERR AddERR(this RRE_O12 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RRE_O12 to SFT
        /// </summary>
        public static SFT AddSFT(this RRE_O12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RRE_O12 to NTE
        /// </summary>
        public static NTE AddNTE(this RRE_O12 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RRG_O16 to ERR
        /// </summary>
        public static ERR AddERR(this RRG_O16 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RRG_O16 to SFT
        /// </summary>
        public static SFT AddSFT(this RRG_O16 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RRG_O16 to NTE
        /// </summary>
        public static NTE AddNTE(this RRG_O16 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Add a new RRI_I12 to SFT
        /// </summary>
        public static SFT AddSFT(this RRI_I12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RRI_I12 to PROVIDER_CONTACT
        /// </summary>
        public static RRI_I12_PROVIDER_CONTACT AddPROVIDER_CONTACT(this RRI_I12 message)
        {
            return message.GetPROVIDER_CONTACT(message.PROVIDER_CONTACTRepetitionsUsed);
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
        /// Add a new RRI_I12 to OBSERVATION
        /// </summary>
        public static RRI_I12_OBSERVATION AddOBSERVATION(this RRI_I12 message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
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
        /// Add a new RSP_K11 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K11 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_K21 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_K23 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K23 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_K25 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K25 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_K25 to ERR
        /// </summary>
        public static ERR AddERR(this RSP_K25 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RSP_K25 to STAFF
        /// </summary>
        public static RSP_K25_STAFF AddSTAFF(this RSP_K25 message)
        {
            return message.GetSTAFF(message.STAFFRepetitionsUsed);
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
        /// Add a new RSP_K31 to ERR
        /// </summary>
        public static ERR AddERR(this RSP_K31 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RSP_K31 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K31 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_K31 to RESPONSE
        /// </summary>
        public static RSP_K31_RESPONSE AddRESPONSE(this RSP_K31 message)
        {
            return message.GetRESPONSE(message.RESPONSERepetitionsUsed);
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
        /// Add a new RSP_Q11 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_Q11 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_Q11 to ERR
        /// </summary>
        public static ERR AddERR(this RSP_Q11 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RSP_Z82 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_Z82 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_Z82 to QUERY_RESPONSE
        /// </summary>
        public static RSP_Z82_QUERY_RESPONSE AddQUERY_RESPONSE(this RSP_Z82 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Add a new RSP_Z86 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_Z86 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_Z86 to QUERY_RESPONSE
        /// </summary>
        public static RSP_Z86_QUERY_RESPONSE AddQUERY_RESPONSE(this RSP_Z86 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Add a new RSP_Z88 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_Z88 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_Z88 to QUERY_RESPONSE
        /// </summary>
        public static RSP_Z88_QUERY_RESPONSE AddQUERY_RESPONSE(this RSP_Z88 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Add a new RSP_Z90 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_Z90 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RSP_Z90 to QUERY_RESPONSE
        /// </summary>
        public static RSP_Z90_QUERY_RESPONSE AddQUERY_RESPONSE(this RSP_Z90 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Add a new RTB_K13 to SFT
        /// </summary>
        public static SFT AddSFT(this RTB_K13 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RTB_Knn to SFT
        /// </summary>
        public static SFT AddSFT(this RTB_Knn message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new RTB_Z74 to ERR
        /// </summary>
        public static ERR AddERR(this RTB_Z74 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new RTB_Z74 to SFT
        /// </summary>
        public static SFT AddSFT(this RTB_Z74 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new SIU_S12 to TQ1
        /// </summary>
        public static TQ1 AddTQ1(this SIU_S12 message)
        {
            return message.GetTQ1(message.TQ1RepetitionsUsed);
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
        /// Add a new SPQ_Q08 to SFT
        /// </summary>
        public static SFT AddSFT(this SPQ_Q08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new SQR_S25 to ERR
        /// </summary>
        public static ERR AddERR(this SQR_S25 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new SRR_S01 to ERR
        /// </summary>
        public static ERR AddERR(this SRR_S01 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Add a new SSR_U04 to SFT
        /// </summary>
        public static SFT AddSFT(this SSR_U04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new SSR_U04 to SPECIMEN_CONTAINER
        /// </summary>
        public static SSR_U04_SPECIMEN_CONTAINER AddSPECIMEN_CONTAINER(this SSR_U04 message)
        {
            return message.GetSPECIMEN_CONTAINER(message.SPECIMEN_CONTAINERRepetitionsUsed);
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
        /// Add a new SSU_U03 to SFT
        /// </summary>
        public static SFT AddSFT(this SSU_U03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new SSU_U03 to SPECIMEN_CONTAINER
        /// </summary>
        public static SSU_U03_SPECIMEN_CONTAINER AddSPECIMEN_CONTAINER(this SSU_U03 message)
        {
            return message.GetSPECIMEN_CONTAINER(message.SPECIMEN_CONTAINERRepetitionsUsed);
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
        /// Add a new TBR_R08 to SFT
        /// </summary>
        public static SFT AddSFT(this TBR_R08 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new TBR_R08 to RDT
        /// </summary>
        public static RDT AddRDT(this TBR_R08 message)
        {
            return message.GetRDT(message.RDTRepetitionsUsed);
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
        /// Add a new TCU_U10 to SFT
        /// </summary>
        public static SFT AddSFT(this TCU_U10 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new TCU_U10 to TEST_CONFIGURATION
        /// </summary>
        public static TCU_U10_TEST_CONFIGURATION AddTEST_CONFIGURATION(this TCU_U10 message)
        {
            return message.GetTEST_CONFIGURATION(message.TEST_CONFIGURATIONRepetitionsUsed);
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
        /// Add a new UDM_Q05 to SFT
        /// </summary>
        public static SFT AddSFT(this UDM_Q05 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new VQQ_Q07 to SFT
        /// </summary>
        public static SFT AddSFT(this VQQ_Q07 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new VXQ_V01 to SFT
        /// </summary>
        public static SFT AddSFT(this VXQ_V01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new VXR_V03 to SFT
        /// </summary>
        public static SFT AddSFT(this VXR_V03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new VXR_V03 to GT1
        /// </summary>
        public static GT1 AddGT1(this VXR_V03 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
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
        /// Add a new VXU_V04 to SFT
        /// </summary>
        public static SFT AddSFT(this VXU_V04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Add a new VXU_V04 to GT1
        /// </summary>
        public static GT1 AddGT1(this VXU_V04 message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
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
        /// Add a new VXX_V02 to SFT
        /// </summary>
        public static SFT AddSFT(this VXX_V02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
