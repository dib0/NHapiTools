using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V271.Group;
using NHapi.Model.V271.Message;
using NHapi.Model.V271.Segment;
using NHapiTools.Base;

namespace NHapiTools.Model.V271.Message
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
        /// Get ARV Records from ADT_A01
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A01 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A01
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A01 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A01 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A01 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A01
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A01 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A01
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A01 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A01 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A01 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get ARV Records from ADT_A02
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A02 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A02
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A02 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A02 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A02 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A02
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A02 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A02
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A02 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A02 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A02 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get ARV Records from ADT_A03
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A03 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A03
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A03 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A03 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A03 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A03
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A03 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A03
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A03 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A03 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A03 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get ARV Records from ADT_A05
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A05 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A05
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A05 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A05 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A05 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A05
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A05 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A05
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A05 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A05 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A05 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get ARV Records from ADT_A06
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A06 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A06
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A06 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A06 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A06 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A06
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A06 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A06
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A06 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A06 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A06 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get ARV Records from ADT_A15
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A15 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A15
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A15 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A15 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A15 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A15
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A15 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A15
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A15 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A15 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A15 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get ARV Records from ADT_A16
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A16 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A16
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A16 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A16 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A16 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
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
        /// Get ARV2 Records from ADT_A16
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A16 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A16
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A16 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A16 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A16 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
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
        /// Get SFT Records from ADT_A44
        /// </summary>
        public static IEnumerable GetSFTRecords(this ADT_A44 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ADT_A44
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ADT_A44 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new ADT_A44 to SFT
        /// </summary>
        public static SFT AddSFT(this ADT_A44 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
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
        /// Get ARV Records from ADT_A60
        /// </summary>
        public static IEnumerable GetARVRecords(this ADT_A60 message)
        {
            object[] result = message.GetRecords("ARVRepetitionsUsed", "GetARV");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV Records from ADT_A60
        /// </summary>
        public static List<ARV> GetAllARVRecords(this ADT_A60 message)
        {
            return message.GetAllRecords<ARV>("ARVRepetitionsUsed", "GetARV");
        }

        /// <summary>
        /// Add a new ADT_A60 to ARV
        /// </summary>
        public static ARV AddARV(this ADT_A60 message)
        {
            return message.GetARV(message.ARVRepetitionsUsed);
        }

        /// <summary>
        /// Get ARV2 Records from ADT_A60
        /// </summary>
        public static IEnumerable GetARV2Records(this ADT_A60 message)
        {
            object[] result = message.GetRecords("ARV2RepetitionsUsed", "GetARV2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ARV2 Records from ADT_A60
        /// </summary>
        public static List<ARV> GetAllARV2Records(this ADT_A60 message)
        {
            return message.GetAllRecords<ARV>("ARV2RepetitionsUsed", "GetARV2");
        }

        /// <summary>
        /// Add a new ADT_A60 to ARV2
        /// </summary>
        public static ARV AddARV2(this ADT_A60 message)
        {
            return message.GetARV2(message.ARV2RepetitionsUsed);
        }

        /// <summary>
        /// Get ADVERSE_REACTION_GROUP Records from ADT_A60
        /// </summary>
        public static IEnumerable GetADVERSE_REACTION_GROUPRecords(this ADT_A60 message)
        {
            object[] result = message.GetRecords("ADVERSE_REACTION_GROUPRepetitionsUsed", "GetADVERSE_REACTION_GROUP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ADVERSE_REACTION_GROUP Records from ADT_A60
        /// </summary>
        public static List<ADT_A60_ADVERSE_REACTION_GROUP> GetAllADVERSE_REACTION_GROUPRecords(this ADT_A60 message)
        {
            return message.GetAllRecords<ADT_A60_ADVERSE_REACTION_GROUP>("ADVERSE_REACTION_GROUPRepetitionsUsed", "GetADVERSE_REACTION_GROUP");
        }

        /// <summary>
        /// Add a new ADT_A60 to ADVERSE_REACTION_GROUP
        /// </summary>
        public static ADT_A60_ADVERSE_REACTION_GROUP AddADVERSE_REACTION_GROUP(this ADT_A60 message)
        {
            return message.GetADVERSE_REACTION_GROUP(message.ADVERSE_REACTION_GROUPRepetitionsUsed);
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
        /// Get ROL2 Records from ADT_A61
        /// </summary>
        public static IEnumerable GetROL2Records(this ADT_A61 message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADT_A61
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADT_A61 message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Add a new ADT_A61 to ROL2
        /// </summary>
        public static ROL AddROL2(this ADT_A61 message)
        {
            return message.GetROL2(message.ROL2RepetitionsUsed);
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
        /// Get SFT Records from CCF_I22
        /// </summary>
        public static IEnumerable GetSFTRecords(this CCF_I22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CCF_I22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CCF_I22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CCF_I22 to SFT
        /// </summary>
        public static SFT AddSFT(this CCF_I22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from CCI_I22
        /// </summary>
        public static IEnumerable GetSFTRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CCI_I22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CCI_I22 to SFT
        /// </summary>
        public static SFT AddSFT(this CCI_I22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from CCI_I22
        /// </summary>
        public static IEnumerable GetERRRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from CCI_I22
        /// </summary>
        public static List<ERR> GetAllERRRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new CCI_I22 to ERR
        /// </summary>
        public static ERR AddERR(this CCI_I22 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from CCI_I22
        /// </summary>
        public static IEnumerable GetNK1Records(this CCI_I22 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from CCI_I22
        /// </summary>
        public static List<NK1> GetAllNK1Records(this CCI_I22 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new CCI_I22 to NK1
        /// </summary>
        public static NK1 AddNK1(this CCI_I22 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from CCI_I22
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_INSURANCE> GetAllINSURANCERecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new CCI_I22 to INSURANCE
        /// </summary>
        public static CCI_I22_INSURANCE AddINSURANCE(this CCI_I22 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get APPOINTMENT_HISTORY Records from CCI_I22
        /// </summary>
        public static IEnumerable GetAPPOINTMENT_HISTORYRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all APPOINTMENT_HISTORY Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_APPOINTMENT_HISTORY> GetAllAPPOINTMENT_HISTORYRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_APPOINTMENT_HISTORY>("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");
        }

        /// <summary>
        /// Add a new CCI_I22 to APPOINTMENT_HISTORY
        /// </summary>
        public static CCI_I22_APPOINTMENT_HISTORY AddAPPOINTMENT_HISTORY(this CCI_I22 message)
        {
            return message.GetAPPOINTMENT_HISTORY(message.APPOINTMENT_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get CLINICAL_HISTORY Records from CCI_I22
        /// </summary>
        public static IEnumerable GetCLINICAL_HISTORYRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLINICAL_HISTORY Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_CLINICAL_HISTORY> GetAllCLINICAL_HISTORYRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_CLINICAL_HISTORY>("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");
        }

        /// <summary>
        /// Add a new CCI_I22 to CLINICAL_HISTORY
        /// </summary>
        public static CCI_I22_CLINICAL_HISTORY AddCLINICAL_HISTORY(this CCI_I22 message)
        {
            return message.GetCLINICAL_HISTORY(message.CLINICAL_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_VISITS Records from CCI_I22
        /// </summary>
        public static IEnumerable GetPATIENT_VISITSRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_VISITS Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_PATIENT_VISITS> GetAllPATIENT_VISITSRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_PATIENT_VISITS>("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");
        }

        /// <summary>
        /// Add a new CCI_I22 to PATIENT_VISITS
        /// </summary>
        public static CCI_I22_PATIENT_VISITS AddPATIENT_VISITS(this CCI_I22 message)
        {
            return message.GetPATIENT_VISITS(message.PATIENT_VISITSRepetitionsUsed);
        }

        /// <summary>
        /// Get MEDICATION_HISTORY Records from CCI_I22
        /// </summary>
        public static IEnumerable GetMEDICATION_HISTORYRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MEDICATION_HISTORY Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_MEDICATION_HISTORY> GetAllMEDICATION_HISTORYRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_MEDICATION_HISTORY>("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");
        }

        /// <summary>
        /// Add a new CCI_I22 to MEDICATION_HISTORY
        /// </summary>
        public static CCI_I22_MEDICATION_HISTORY AddMEDICATION_HISTORY(this CCI_I22 message)
        {
            return message.GetMEDICATION_HISTORY(message.MEDICATION_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from CCI_I22
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_PROBLEM> GetAllPROBLEMRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new CCI_I22 to PROBLEM
        /// </summary>
        public static CCI_I22_PROBLEM AddPROBLEM(this CCI_I22 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from CCI_I22
        /// </summary>
        public static IEnumerable GetGOALRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_GOAL> GetAllGOALRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new CCI_I22 to GOAL
        /// </summary>
        public static CCI_I22_GOAL AddGOAL(this CCI_I22 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from CCI_I22
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from CCI_I22
        /// </summary>
        public static List<CCI_I22_PATHWAY> GetAllPATHWAYRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<CCI_I22_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new CCI_I22 to PATHWAY
        /// </summary>
        public static CCI_I22_PATHWAY AddPATHWAY(this CCI_I22 message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get REL Records from CCI_I22
        /// </summary>
        public static IEnumerable GetRELRecords(this CCI_I22 message)
        {
            object[] result = message.GetRecords("RELRepetitionsUsed", "GetREL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REL Records from CCI_I22
        /// </summary>
        public static List<REL> GetAllRELRecords(this CCI_I22 message)
        {
            return message.GetAllRecords<REL>("RELRepetitionsUsed", "GetREL");
        }

        /// <summary>
        /// Add a new CCI_I22 to REL
        /// </summary>
        public static REL AddREL(this CCI_I22 message)
        {
            return message.GetREL(message.RELRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from CCM_I21
        /// </summary>
        public static IEnumerable GetSFTRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CCM_I21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CCM_I21 to SFT
        /// </summary>
        public static SFT AddSFT(this CCM_I21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from CCM_I21
        /// </summary>
        public static IEnumerable GetNK1Records(this CCM_I21 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from CCM_I21
        /// </summary>
        public static List<NK1> GetAllNK1Records(this CCM_I21 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new CCM_I21 to NK1
        /// </summary>
        public static NK1 AddNK1(this CCM_I21 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from CCM_I21
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_INSURANCE> GetAllINSURANCERecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new CCM_I21 to INSURANCE
        /// </summary>
        public static CCM_I21_INSURANCE AddINSURANCE(this CCM_I21 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get APPOINTMENT_HISTORY Records from CCM_I21
        /// </summary>
        public static IEnumerable GetAPPOINTMENT_HISTORYRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all APPOINTMENT_HISTORY Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_APPOINTMENT_HISTORY> GetAllAPPOINTMENT_HISTORYRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_APPOINTMENT_HISTORY>("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");
        }

        /// <summary>
        /// Add a new CCM_I21 to APPOINTMENT_HISTORY
        /// </summary>
        public static CCM_I21_APPOINTMENT_HISTORY AddAPPOINTMENT_HISTORY(this CCM_I21 message)
        {
            return message.GetAPPOINTMENT_HISTORY(message.APPOINTMENT_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get CLINICAL_HISTORY Records from CCM_I21
        /// </summary>
        public static IEnumerable GetCLINICAL_HISTORYRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLINICAL_HISTORY Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_CLINICAL_HISTORY> GetAllCLINICAL_HISTORYRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_CLINICAL_HISTORY>("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");
        }

        /// <summary>
        /// Add a new CCM_I21 to CLINICAL_HISTORY
        /// </summary>
        public static CCM_I21_CLINICAL_HISTORY AddCLINICAL_HISTORY(this CCM_I21 message)
        {
            return message.GetCLINICAL_HISTORY(message.CLINICAL_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_VISITS Records from CCM_I21
        /// </summary>
        public static IEnumerable GetPATIENT_VISITSRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_VISITS Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_PATIENT_VISITS> GetAllPATIENT_VISITSRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_PATIENT_VISITS>("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");
        }

        /// <summary>
        /// Add a new CCM_I21 to PATIENT_VISITS
        /// </summary>
        public static CCM_I21_PATIENT_VISITS AddPATIENT_VISITS(this CCM_I21 message)
        {
            return message.GetPATIENT_VISITS(message.PATIENT_VISITSRepetitionsUsed);
        }

        /// <summary>
        /// Get MEDICATION_HISTORY Records from CCM_I21
        /// </summary>
        public static IEnumerable GetMEDICATION_HISTORYRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MEDICATION_HISTORY Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_MEDICATION_HISTORY> GetAllMEDICATION_HISTORYRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_MEDICATION_HISTORY>("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");
        }

        /// <summary>
        /// Add a new CCM_I21 to MEDICATION_HISTORY
        /// </summary>
        public static CCM_I21_MEDICATION_HISTORY AddMEDICATION_HISTORY(this CCM_I21 message)
        {
            return message.GetMEDICATION_HISTORY(message.MEDICATION_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from CCM_I21
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_PROBLEM> GetAllPROBLEMRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new CCM_I21 to PROBLEM
        /// </summary>
        public static CCM_I21_PROBLEM AddPROBLEM(this CCM_I21 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from CCM_I21
        /// </summary>
        public static IEnumerable GetGOALRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_GOAL> GetAllGOALRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new CCM_I21 to GOAL
        /// </summary>
        public static CCM_I21_GOAL AddGOAL(this CCM_I21 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from CCM_I21
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from CCM_I21
        /// </summary>
        public static List<CCM_I21_PATHWAY> GetAllPATHWAYRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<CCM_I21_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new CCM_I21 to PATHWAY
        /// </summary>
        public static CCM_I21_PATHWAY AddPATHWAY(this CCM_I21 message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get REL Records from CCM_I21
        /// </summary>
        public static IEnumerable GetRELRecords(this CCM_I21 message)
        {
            object[] result = message.GetRecords("RELRepetitionsUsed", "GetREL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REL Records from CCM_I21
        /// </summary>
        public static List<REL> GetAllRELRecords(this CCM_I21 message)
        {
            return message.GetAllRecords<REL>("RELRepetitionsUsed", "GetREL");
        }

        /// <summary>
        /// Add a new CCM_I21 to REL
        /// </summary>
        public static REL AddREL(this CCM_I21 message)
        {
            return message.GetREL(message.RELRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from CCQ_I19
        /// </summary>
        public static IEnumerable GetSFTRecords(this CCQ_I19 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CCQ_I19
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CCQ_I19 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CCQ_I19 to SFT
        /// </summary>
        public static SFT AddSFT(this CCQ_I19 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER_CONTACT Records from CCQ_I19
        /// </summary>
        public static IEnumerable GetPROVIDER_CONTACTRecords(this CCQ_I19 message)
        {
            object[] result = message.GetRecords("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER_CONTACT Records from CCQ_I19
        /// </summary>
        public static List<CCQ_I19_PROVIDER_CONTACT> GetAllPROVIDER_CONTACTRecords(this CCQ_I19 message)
        {
            return message.GetAllRecords<CCQ_I19_PROVIDER_CONTACT>("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");
        }

        /// <summary>
        /// Add a new CCQ_I19 to PROVIDER_CONTACT
        /// </summary>
        public static CCQ_I19_PROVIDER_CONTACT AddPROVIDER_CONTACT(this CCQ_I19 message)
        {
            return message.GetPROVIDER_CONTACT(message.PROVIDER_CONTACTRepetitionsUsed);
        }

        /// <summary>
        /// Get REL Records from CCQ_I19
        /// </summary>
        public static IEnumerable GetRELRecords(this CCQ_I19 message)
        {
            object[] result = message.GetRecords("RELRepetitionsUsed", "GetREL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REL Records from CCQ_I19
        /// </summary>
        public static List<REL> GetAllRELRecords(this CCQ_I19 message)
        {
            return message.GetAllRecords<REL>("RELRepetitionsUsed", "GetREL");
        }

        /// <summary>
        /// Add a new CCQ_I19 to REL
        /// </summary>
        public static REL AddREL(this CCQ_I19 message)
        {
            return message.GetREL(message.RELRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from CCR_I16
        /// </summary>
        public static IEnumerable GetSFTRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CCR_I16
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CCR_I16 to SFT
        /// </summary>
        public static SFT AddSFT(this CCR_I16 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get RF1 Records from CCR_I16
        /// </summary>
        public static IEnumerable GetRF1Records(this CCR_I16 message)
        {
            object[] result = message.GetRecords("RF1RepetitionsUsed", "GetRF1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RF1 Records from CCR_I16
        /// </summary>
        public static List<RF1> GetAllRF1Records(this CCR_I16 message)
        {
            return message.GetAllRecords<RF1>("RF1RepetitionsUsed", "GetRF1");
        }

        /// <summary>
        /// Add a new CCR_I16 to RF1
        /// </summary>
        public static RF1 AddRF1(this CCR_I16 message)
        {
            return message.GetRF1(message.RF1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER_CONTACT Records from CCR_I16
        /// </summary>
        public static IEnumerable GetPROVIDER_CONTACTRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER_CONTACT Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_PROVIDER_CONTACT> GetAllPROVIDER_CONTACTRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_PROVIDER_CONTACT>("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");
        }

        /// <summary>
        /// Add a new CCR_I16 to PROVIDER_CONTACT
        /// </summary>
        public static CCR_I16_PROVIDER_CONTACT AddPROVIDER_CONTACT(this CCR_I16 message)
        {
            return message.GetPROVIDER_CONTACT(message.PROVIDER_CONTACTRepetitionsUsed);
        }

        /// <summary>
        /// Get CLINICAL_ORDER Records from CCR_I16
        /// </summary>
        public static IEnumerable GetCLINICAL_ORDERRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("CLINICAL_ORDERRepetitionsUsed", "GetCLINICAL_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLINICAL_ORDER Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_CLINICAL_ORDER> GetAllCLINICAL_ORDERRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_CLINICAL_ORDER>("CLINICAL_ORDERRepetitionsUsed", "GetCLINICAL_ORDER");
        }

        /// <summary>
        /// Add a new CCR_I16 to CLINICAL_ORDER
        /// </summary>
        public static CCR_I16_CLINICAL_ORDER AddCLINICAL_ORDER(this CCR_I16 message)
        {
            return message.GetCLINICAL_ORDER(message.CLINICAL_ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CCR_I16
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_PATIENT> GetAllPATIENTRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CCR_I16 to PATIENT
        /// </summary>
        public static CCR_I16_PATIENT AddPATIENT(this CCR_I16 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from CCR_I16
        /// </summary>
        public static IEnumerable GetNK1Records(this CCR_I16 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from CCR_I16
        /// </summary>
        public static List<NK1> GetAllNK1Records(this CCR_I16 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new CCR_I16 to NK1
        /// </summary>
        public static NK1 AddNK1(this CCR_I16 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from CCR_I16
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_INSURANCE> GetAllINSURANCERecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new CCR_I16 to INSURANCE
        /// </summary>
        public static CCR_I16_INSURANCE AddINSURANCE(this CCR_I16 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get APPOINTMENT_HISTORY Records from CCR_I16
        /// </summary>
        public static IEnumerable GetAPPOINTMENT_HISTORYRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all APPOINTMENT_HISTORY Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_APPOINTMENT_HISTORY> GetAllAPPOINTMENT_HISTORYRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_APPOINTMENT_HISTORY>("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");
        }

        /// <summary>
        /// Add a new CCR_I16 to APPOINTMENT_HISTORY
        /// </summary>
        public static CCR_I16_APPOINTMENT_HISTORY AddAPPOINTMENT_HISTORY(this CCR_I16 message)
        {
            return message.GetAPPOINTMENT_HISTORY(message.APPOINTMENT_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get CLINICAL_HISTORY Records from CCR_I16
        /// </summary>
        public static IEnumerable GetCLINICAL_HISTORYRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLINICAL_HISTORY Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_CLINICAL_HISTORY> GetAllCLINICAL_HISTORYRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_CLINICAL_HISTORY>("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");
        }

        /// <summary>
        /// Add a new CCR_I16 to CLINICAL_HISTORY
        /// </summary>
        public static CCR_I16_CLINICAL_HISTORY AddCLINICAL_HISTORY(this CCR_I16 message)
        {
            return message.GetCLINICAL_HISTORY(message.CLINICAL_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_VISITS Records from CCR_I16
        /// </summary>
        public static IEnumerable GetPATIENT_VISITSRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_VISITS Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_PATIENT_VISITS> GetAllPATIENT_VISITSRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_PATIENT_VISITS>("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");
        }

        /// <summary>
        /// Add a new CCR_I16 to PATIENT_VISITS
        /// </summary>
        public static CCR_I16_PATIENT_VISITS AddPATIENT_VISITS(this CCR_I16 message)
        {
            return message.GetPATIENT_VISITS(message.PATIENT_VISITSRepetitionsUsed);
        }

        /// <summary>
        /// Get MEDICATION_HISTORY Records from CCR_I16
        /// </summary>
        public static IEnumerable GetMEDICATION_HISTORYRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MEDICATION_HISTORY Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_MEDICATION_HISTORY> GetAllMEDICATION_HISTORYRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_MEDICATION_HISTORY>("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");
        }

        /// <summary>
        /// Add a new CCR_I16 to MEDICATION_HISTORY
        /// </summary>
        public static CCR_I16_MEDICATION_HISTORY AddMEDICATION_HISTORY(this CCR_I16 message)
        {
            return message.GetMEDICATION_HISTORY(message.MEDICATION_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from CCR_I16
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_PROBLEM> GetAllPROBLEMRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new CCR_I16 to PROBLEM
        /// </summary>
        public static CCR_I16_PROBLEM AddPROBLEM(this CCR_I16 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from CCR_I16
        /// </summary>
        public static IEnumerable GetGOALRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_GOAL> GetAllGOALRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new CCR_I16 to GOAL
        /// </summary>
        public static CCR_I16_GOAL AddGOAL(this CCR_I16 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from CCR_I16
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from CCR_I16
        /// </summary>
        public static List<CCR_I16_PATHWAY> GetAllPATHWAYRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<CCR_I16_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new CCR_I16 to PATHWAY
        /// </summary>
        public static CCR_I16_PATHWAY AddPATHWAY(this CCR_I16 message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get REL Records from CCR_I16
        /// </summary>
        public static IEnumerable GetRELRecords(this CCR_I16 message)
        {
            object[] result = message.GetRecords("RELRepetitionsUsed", "GetREL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REL Records from CCR_I16
        /// </summary>
        public static List<REL> GetAllRELRecords(this CCR_I16 message)
        {
            return message.GetAllRecords<REL>("RELRepetitionsUsed", "GetREL");
        }

        /// <summary>
        /// Add a new CCR_I16 to REL
        /// </summary>
        public static REL AddREL(this CCR_I16 message)
        {
            return message.GetREL(message.RELRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from CCU_I20
        /// </summary>
        public static IEnumerable GetSFTRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CCU_I20
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CCU_I20 to SFT
        /// </summary>
        public static SFT AddSFT(this CCU_I20 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER_CONTACT Records from CCU_I20
        /// </summary>
        public static IEnumerable GetPROVIDER_CONTACTRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER_CONTACT Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_PROVIDER_CONTACT> GetAllPROVIDER_CONTACTRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_PROVIDER_CONTACT>("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");
        }

        /// <summary>
        /// Add a new CCU_I20 to PROVIDER_CONTACT
        /// </summary>
        public static CCU_I20_PROVIDER_CONTACT AddPROVIDER_CONTACT(this CCU_I20 message)
        {
            return message.GetPROVIDER_CONTACT(message.PROVIDER_CONTACTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CCU_I20
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_PATIENT> GetAllPATIENTRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CCU_I20 to PATIENT
        /// </summary>
        public static CCU_I20_PATIENT AddPATIENT(this CCU_I20 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from CCU_I20
        /// </summary>
        public static IEnumerable GetNK1Records(this CCU_I20 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from CCU_I20
        /// </summary>
        public static List<NK1> GetAllNK1Records(this CCU_I20 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new CCU_I20 to NK1
        /// </summary>
        public static NK1 AddNK1(this CCU_I20 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from CCU_I20
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_INSURANCE> GetAllINSURANCERecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new CCU_I20 to INSURANCE
        /// </summary>
        public static CCU_I20_INSURANCE AddINSURANCE(this CCU_I20 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get APPOINTMENT_HISTORY Records from CCU_I20
        /// </summary>
        public static IEnumerable GetAPPOINTMENT_HISTORYRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all APPOINTMENT_HISTORY Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_APPOINTMENT_HISTORY> GetAllAPPOINTMENT_HISTORYRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_APPOINTMENT_HISTORY>("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");
        }

        /// <summary>
        /// Add a new CCU_I20 to APPOINTMENT_HISTORY
        /// </summary>
        public static CCU_I20_APPOINTMENT_HISTORY AddAPPOINTMENT_HISTORY(this CCU_I20 message)
        {
            return message.GetAPPOINTMENT_HISTORY(message.APPOINTMENT_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get CLINICAL_HISTORY Records from CCU_I20
        /// </summary>
        public static IEnumerable GetCLINICAL_HISTORYRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLINICAL_HISTORY Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_CLINICAL_HISTORY> GetAllCLINICAL_HISTORYRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_CLINICAL_HISTORY>("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");
        }

        /// <summary>
        /// Add a new CCU_I20 to CLINICAL_HISTORY
        /// </summary>
        public static CCU_I20_CLINICAL_HISTORY AddCLINICAL_HISTORY(this CCU_I20 message)
        {
            return message.GetCLINICAL_HISTORY(message.CLINICAL_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_VISITS Records from CCU_I20
        /// </summary>
        public static IEnumerable GetPATIENT_VISITSRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_VISITS Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_PATIENT_VISITS> GetAllPATIENT_VISITSRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_PATIENT_VISITS>("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");
        }

        /// <summary>
        /// Add a new CCU_I20 to PATIENT_VISITS
        /// </summary>
        public static CCU_I20_PATIENT_VISITS AddPATIENT_VISITS(this CCU_I20 message)
        {
            return message.GetPATIENT_VISITS(message.PATIENT_VISITSRepetitionsUsed);
        }

        /// <summary>
        /// Get MEDICATION_HISTORY Records from CCU_I20
        /// </summary>
        public static IEnumerable GetMEDICATION_HISTORYRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MEDICATION_HISTORY Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_MEDICATION_HISTORY> GetAllMEDICATION_HISTORYRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_MEDICATION_HISTORY>("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");
        }

        /// <summary>
        /// Add a new CCU_I20 to MEDICATION_HISTORY
        /// </summary>
        public static CCU_I20_MEDICATION_HISTORY AddMEDICATION_HISTORY(this CCU_I20 message)
        {
            return message.GetMEDICATION_HISTORY(message.MEDICATION_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from CCU_I20
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_PROBLEM> GetAllPROBLEMRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new CCU_I20 to PROBLEM
        /// </summary>
        public static CCU_I20_PROBLEM AddPROBLEM(this CCU_I20 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from CCU_I20
        /// </summary>
        public static IEnumerable GetGOALRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_GOAL> GetAllGOALRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new CCU_I20 to GOAL
        /// </summary>
        public static CCU_I20_GOAL AddGOAL(this CCU_I20 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from CCU_I20
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from CCU_I20
        /// </summary>
        public static List<CCU_I20_PATHWAY> GetAllPATHWAYRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<CCU_I20_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new CCU_I20 to PATHWAY
        /// </summary>
        public static CCU_I20_PATHWAY AddPATHWAY(this CCU_I20 message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get REL Records from CCU_I20
        /// </summary>
        public static IEnumerable GetRELRecords(this CCU_I20 message)
        {
            object[] result = message.GetRecords("RELRepetitionsUsed", "GetREL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REL Records from CCU_I20
        /// </summary>
        public static List<REL> GetAllRELRecords(this CCU_I20 message)
        {
            return message.GetAllRecords<REL>("RELRepetitionsUsed", "GetREL");
        }

        /// <summary>
        /// Add a new CCU_I20 to REL
        /// </summary>
        public static REL AddREL(this CCU_I20 message)
        {
            return message.GetREL(message.RELRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from CQU_I19
        /// </summary>
        public static IEnumerable GetSFTRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from CQU_I19
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new CQU_I19 to SFT
        /// </summary>
        public static SFT AddSFT(this CQU_I19 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from CQU_I19
        /// </summary>
        public static IEnumerable GetERRRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from CQU_I19
        /// </summary>
        public static List<ERR> GetAllERRRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new CQU_I19 to ERR
        /// </summary>
        public static ERR AddERR(this CQU_I19 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get PROVIDER_CONTACT Records from CQU_I19
        /// </summary>
        public static IEnumerable GetPROVIDER_CONTACTRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROVIDER_CONTACT Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_PROVIDER_CONTACT> GetAllPROVIDER_CONTACTRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_PROVIDER_CONTACT>("PROVIDER_CONTACTRepetitionsUsed", "GetPROVIDER_CONTACT");
        }

        /// <summary>
        /// Add a new CQU_I19 to PROVIDER_CONTACT
        /// </summary>
        public static CQU_I19_PROVIDER_CONTACT AddPROVIDER_CONTACT(this CQU_I19 message)
        {
            return message.GetPROVIDER_CONTACT(message.PROVIDER_CONTACTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from CQU_I19
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_PATIENT> GetAllPATIENTRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new CQU_I19 to PATIENT
        /// </summary>
        public static CQU_I19_PATIENT AddPATIENT(this CQU_I19 message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from CQU_I19
        /// </summary>
        public static IEnumerable GetNK1Records(this CQU_I19 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from CQU_I19
        /// </summary>
        public static List<NK1> GetAllNK1Records(this CQU_I19 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new CQU_I19 to NK1
        /// </summary>
        public static NK1 AddNK1(this CQU_I19 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from CQU_I19
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_INSURANCE> GetAllINSURANCERecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new CQU_I19 to INSURANCE
        /// </summary>
        public static CQU_I19_INSURANCE AddINSURANCE(this CQU_I19 message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get APPOINTMENT_HISTORY Records from CQU_I19
        /// </summary>
        public static IEnumerable GetAPPOINTMENT_HISTORYRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all APPOINTMENT_HISTORY Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_APPOINTMENT_HISTORY> GetAllAPPOINTMENT_HISTORYRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_APPOINTMENT_HISTORY>("APPOINTMENT_HISTORYRepetitionsUsed", "GetAPPOINTMENT_HISTORY");
        }

        /// <summary>
        /// Add a new CQU_I19 to APPOINTMENT_HISTORY
        /// </summary>
        public static CQU_I19_APPOINTMENT_HISTORY AddAPPOINTMENT_HISTORY(this CQU_I19 message)
        {
            return message.GetAPPOINTMENT_HISTORY(message.APPOINTMENT_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get CLINICAL_HISTORY Records from CQU_I19
        /// </summary>
        public static IEnumerable GetCLINICAL_HISTORYRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CLINICAL_HISTORY Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_CLINICAL_HISTORY> GetAllCLINICAL_HISTORYRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_CLINICAL_HISTORY>("CLINICAL_HISTORYRepetitionsUsed", "GetCLINICAL_HISTORY");
        }

        /// <summary>
        /// Add a new CQU_I19 to CLINICAL_HISTORY
        /// </summary>
        public static CQU_I19_CLINICAL_HISTORY AddCLINICAL_HISTORY(this CQU_I19 message)
        {
            return message.GetCLINICAL_HISTORY(message.CLINICAL_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_VISITS Records from CQU_I19
        /// </summary>
        public static IEnumerable GetPATIENT_VISITSRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_VISITS Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_PATIENT_VISITS> GetAllPATIENT_VISITSRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_PATIENT_VISITS>("PATIENT_VISITSRepetitionsUsed", "GetPATIENT_VISITS");
        }

        /// <summary>
        /// Add a new CQU_I19 to PATIENT_VISITS
        /// </summary>
        public static CQU_I19_PATIENT_VISITS AddPATIENT_VISITS(this CQU_I19 message)
        {
            return message.GetPATIENT_VISITS(message.PATIENT_VISITSRepetitionsUsed);
        }

        /// <summary>
        /// Get MEDICATION_HISTORY Records from CQU_I19
        /// </summary>
        public static IEnumerable GetMEDICATION_HISTORYRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MEDICATION_HISTORY Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_MEDICATION_HISTORY> GetAllMEDICATION_HISTORYRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_MEDICATION_HISTORY>("MEDICATION_HISTORYRepetitionsUsed", "GetMEDICATION_HISTORY");
        }

        /// <summary>
        /// Add a new CQU_I19 to MEDICATION_HISTORY
        /// </summary>
        public static CQU_I19_MEDICATION_HISTORY AddMEDICATION_HISTORY(this CQU_I19 message)
        {
            return message.GetMEDICATION_HISTORY(message.MEDICATION_HISTORYRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from CQU_I19
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_PROBLEM> GetAllPROBLEMRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new CQU_I19 to PROBLEM
        /// </summary>
        public static CQU_I19_PROBLEM AddPROBLEM(this CQU_I19 message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from CQU_I19
        /// </summary>
        public static IEnumerable GetGOALRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_GOAL> GetAllGOALRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new CQU_I19 to GOAL
        /// </summary>
        public static CQU_I19_GOAL AddGOAL(this CQU_I19 message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from CQU_I19
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from CQU_I19
        /// </summary>
        public static List<CQU_I19_PATHWAY> GetAllPATHWAYRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<CQU_I19_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new CQU_I19 to PATHWAY
        /// </summary>
        public static CQU_I19_PATHWAY AddPATHWAY(this CQU_I19 message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get REL Records from CQU_I19
        /// </summary>
        public static IEnumerable GetRELRecords(this CQU_I19 message)
        {
            object[] result = message.GetRecords("RELRepetitionsUsed", "GetREL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REL Records from CQU_I19
        /// </summary>
        public static List<REL> GetAllRELRecords(this CQU_I19 message)
        {
            return message.GetAllRecords<REL>("RELRepetitionsUsed", "GetREL");
        }

        /// <summary>
        /// Add a new CQU_I19 to REL
        /// </summary>
        public static REL AddREL(this CQU_I19 message)
        {
            return message.GetREL(message.RELRepetitionsUsed);
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
        /// Get SFT Records from EHC_E01
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E01 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E01
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E01 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E01 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E01 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E01
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E01 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E01
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E01 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E01 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E01 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from EHC_E01
        /// </summary>
        public static IEnumerable GetCTDRecords(this EHC_E01 message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from EHC_E01
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this EHC_E01 message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new EHC_E01 to CTD
        /// </summary>
        public static CTD AddCTD(this EHC_E01 message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get LOC Records from EHC_E01
        /// </summary>
        public static IEnumerable GetLOCRecords(this EHC_E01 message)
        {
            object[] result = message.GetRecords("LOCRepetitionsUsed", "GetLOC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOC Records from EHC_E01
        /// </summary>
        public static List<LOC> GetAllLOCRecords(this EHC_E01 message)
        {
            return message.GetAllRecords<LOC>("LOCRepetitionsUsed", "GetLOC");
        }

        /// <summary>
        /// Add a new EHC_E01 to LOC
        /// </summary>
        public static LOC AddLOC(this EHC_E01 message)
        {
            return message.GetLOC(message.LOCRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from EHC_E01
        /// </summary>
        public static IEnumerable GetROLRecords(this EHC_E01 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from EHC_E01
        /// </summary>
        public static List<ROL> GetAllROLRecords(this EHC_E01 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new EHC_E01 to ROL
        /// </summary>
        public static ROL AddROL(this EHC_E01 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get PRODUCT_SERVICE_SECTION Records from EHC_E01
        /// </summary>
        public static IEnumerable GetPRODUCT_SERVICE_SECTIONRecords(this EHC_E01 message)
        {
            object[] result = message.GetRecords("PRODUCT_SERVICE_SECTIONRepetitionsUsed", "GetPRODUCT_SERVICE_SECTION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRODUCT_SERVICE_SECTION Records from EHC_E01
        /// </summary>
        public static List<EHC_E01_PRODUCT_SERVICE_SECTION> GetAllPRODUCT_SERVICE_SECTIONRecords(this EHC_E01 message)
        {
            return message.GetAllRecords<EHC_E01_PRODUCT_SERVICE_SECTION>("PRODUCT_SERVICE_SECTIONRepetitionsUsed", "GetPRODUCT_SERVICE_SECTION");
        }

        /// <summary>
        /// Add a new EHC_E01 to PRODUCT_SERVICE_SECTION
        /// </summary>
        public static EHC_E01_PRODUCT_SERVICE_SECTION AddPRODUCT_SERVICE_SECTION(this EHC_E01 message)
        {
            return message.GetPRODUCT_SERVICE_SECTION(message.PRODUCT_SERVICE_SECTIONRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E02
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E02 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E02
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E02 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E02 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E02 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E02
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E02 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E02
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E02 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E02 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E02 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from EHC_E02
        /// </summary>
        public static IEnumerable GetCTDRecords(this EHC_E02 message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from EHC_E02
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this EHC_E02 message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new EHC_E02 to CTD
        /// </summary>
        public static CTD AddCTD(this EHC_E02 message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from EHC_E02
        /// </summary>
        public static IEnumerable GetNTERecords(this EHC_E02 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from EHC_E02
        /// </summary>
        public static List<NTE> GetAllNTERecords(this EHC_E02 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new EHC_E02 to NTE
        /// </summary>
        public static NTE AddNTE(this EHC_E02 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PRODUCT_SERVICE_SECTION Records from EHC_E02
        /// </summary>
        public static IEnumerable GetPRODUCT_SERVICE_SECTIONRecords(this EHC_E02 message)
        {
            object[] result = message.GetRecords("PRODUCT_SERVICE_SECTIONRepetitionsUsed", "GetPRODUCT_SERVICE_SECTION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRODUCT_SERVICE_SECTION Records from EHC_E02
        /// </summary>
        public static List<EHC_E02_PRODUCT_SERVICE_SECTION> GetAllPRODUCT_SERVICE_SECTIONRecords(this EHC_E02 message)
        {
            return message.GetAllRecords<EHC_E02_PRODUCT_SERVICE_SECTION>("PRODUCT_SERVICE_SECTIONRepetitionsUsed", "GetPRODUCT_SERVICE_SECTION");
        }

        /// <summary>
        /// Add a new EHC_E02 to PRODUCT_SERVICE_SECTION
        /// </summary>
        public static EHC_E02_PRODUCT_SERVICE_SECTION AddPRODUCT_SERVICE_SECTION(this EHC_E02 message)
        {
            return message.GetPRODUCT_SERVICE_SECTION(message.PRODUCT_SERVICE_SECTIONRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E04
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E04 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E04
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E04 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E04 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E04 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E04
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E04 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E04
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E04 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E04 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E04 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from EHC_E04
        /// </summary>
        public static IEnumerable GetNTERecords(this EHC_E04 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from EHC_E04
        /// </summary>
        public static List<NTE> GetAllNTERecords(this EHC_E04 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new EHC_E04 to NTE
        /// </summary>
        public static NTE AddNTE(this EHC_E04 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PRODUCT_SERVICE_SECTION Records from EHC_E04
        /// </summary>
        public static IEnumerable GetPRODUCT_SERVICE_SECTIONRecords(this EHC_E04 message)
        {
            object[] result = message.GetRecords("PRODUCT_SERVICE_SECTIONRepetitionsUsed", "GetPRODUCT_SERVICE_SECTION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRODUCT_SERVICE_SECTION Records from EHC_E04
        /// </summary>
        public static List<EHC_E04_PRODUCT_SERVICE_SECTION> GetAllPRODUCT_SERVICE_SECTIONRecords(this EHC_E04 message)
        {
            return message.GetAllRecords<EHC_E04_PRODUCT_SERVICE_SECTION>("PRODUCT_SERVICE_SECTIONRepetitionsUsed", "GetPRODUCT_SERVICE_SECTION");
        }

        /// <summary>
        /// Add a new EHC_E04 to PRODUCT_SERVICE_SECTION
        /// </summary>
        public static EHC_E04_PRODUCT_SERVICE_SECTION AddPRODUCT_SERVICE_SECTION(this EHC_E04 message)
        {
            return message.GetPRODUCT_SERVICE_SECTION(message.PRODUCT_SERVICE_SECTIONRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E10
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E10 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E10
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E10 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E10 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E10 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E10
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E10 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E10
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E10 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E10 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E10 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from EHC_E10
        /// </summary>
        public static IEnumerable GetERRRecords(this EHC_E10 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from EHC_E10
        /// </summary>
        public static List<ERR> GetAllERRRecords(this EHC_E10 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new EHC_E10 to ERR
        /// </summary>
        public static ERR AddERR(this EHC_E10 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get INVOICE_PROCESSING_RESULTS_INFO Records from EHC_E10
        /// </summary>
        public static IEnumerable GetINVOICE_PROCESSING_RESULTS_INFORecords(this EHC_E10 message)
        {
            object[] result = message.GetRecords("INVOICE_PROCESSING_RESULTS_INFORepetitionsUsed", "GetINVOICE_PROCESSING_RESULTS_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INVOICE_PROCESSING_RESULTS_INFO Records from EHC_E10
        /// </summary>
        public static List<EHC_E10_INVOICE_PROCESSING_RESULTS_INFO> GetAllINVOICE_PROCESSING_RESULTS_INFORecords(this EHC_E10 message)
        {
            return message.GetAllRecords<EHC_E10_INVOICE_PROCESSING_RESULTS_INFO>("INVOICE_PROCESSING_RESULTS_INFORepetitionsUsed", "GetINVOICE_PROCESSING_RESULTS_INFO");
        }

        /// <summary>
        /// Add a new EHC_E10 to INVOICE_PROCESSING_RESULTS_INFO
        /// </summary>
        public static EHC_E10_INVOICE_PROCESSING_RESULTS_INFO AddINVOICE_PROCESSING_RESULTS_INFO(this EHC_E10 message)
        {
            return message.GetINVOICE_PROCESSING_RESULTS_INFO(message.INVOICE_PROCESSING_RESULTS_INFORepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E12
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E12 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E12
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E12 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E12 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E12 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E12
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E12 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E12
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E12 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E12 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E12 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from EHC_E12
        /// </summary>
        public static IEnumerable GetCTDRecords(this EHC_E12 message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from EHC_E12
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this EHC_E12 message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new EHC_E12 to CTD
        /// </summary>
        public static CTD AddCTD(this EHC_E12 message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get PSL Records from EHC_E12
        /// </summary>
        public static IEnumerable GetPSLRecords(this EHC_E12 message)
        {
            object[] result = message.GetRecords("PSLRepetitionsUsed", "GetPSL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PSL Records from EHC_E12
        /// </summary>
        public static List<PSL> GetAllPSLRecords(this EHC_E12 message)
        {
            return message.GetAllRecords<PSL>("PSLRepetitionsUsed", "GetPSL");
        }

        /// <summary>
        /// Add a new EHC_E12 to PSL
        /// </summary>
        public static PSL AddPSL(this EHC_E12 message)
        {
            return message.GetPSL(message.PSLRepetitionsUsed);
        }

        /// <summary>
        /// Get REQUEST Records from EHC_E12
        /// </summary>
        public static IEnumerable GetREQUESTRecords(this EHC_E12 message)
        {
            object[] result = message.GetRecords("REQUESTRepetitionsUsed", "GetREQUEST");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REQUEST Records from EHC_E12
        /// </summary>
        public static List<EHC_E12_REQUEST> GetAllREQUESTRecords(this EHC_E12 message)
        {
            return message.GetAllRecords<EHC_E12_REQUEST>("REQUESTRepetitionsUsed", "GetREQUEST");
        }

        /// <summary>
        /// Add a new EHC_E12 to REQUEST
        /// </summary>
        public static EHC_E12_REQUEST AddREQUEST(this EHC_E12 message)
        {
            return message.GetREQUEST(message.REQUESTRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E13
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E13 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E13
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E13 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E13 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E13 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E13
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E13 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E13
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E13 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E13 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E13 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from EHC_E13
        /// </summary>
        public static IEnumerable GetERRRecords(this EHC_E13 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from EHC_E13
        /// </summary>
        public static List<ERR> GetAllERRRecords(this EHC_E13 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new EHC_E13 to ERR
        /// </summary>
        public static ERR AddERR(this EHC_E13 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from EHC_E13
        /// </summary>
        public static IEnumerable GetCTDRecords(this EHC_E13 message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from EHC_E13
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this EHC_E13 message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new EHC_E13 to CTD
        /// </summary>
        public static CTD AddCTD(this EHC_E13 message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get REQUEST Records from EHC_E13
        /// </summary>
        public static IEnumerable GetREQUESTRecords(this EHC_E13 message)
        {
            object[] result = message.GetRecords("REQUESTRepetitionsUsed", "GetREQUEST");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all REQUEST Records from EHC_E13
        /// </summary>
        public static List<EHC_E13_REQUEST> GetAllREQUESTRecords(this EHC_E13 message)
        {
            return message.GetAllRecords<EHC_E13_REQUEST>("REQUESTRepetitionsUsed", "GetREQUEST");
        }

        /// <summary>
        /// Add a new EHC_E13 to REQUEST
        /// </summary>
        public static EHC_E13_REQUEST AddREQUEST(this EHC_E13 message)
        {
            return message.GetREQUEST(message.REQUESTRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E15
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E15 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E15
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E15 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E15 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E15 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E15
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E15 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E15
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E15 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E15 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E15 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get PAYMENT_REMITTANCE_DETAIL_INFO Records from EHC_E15
        /// </summary>
        public static IEnumerable GetPAYMENT_REMITTANCE_DETAIL_INFORecords(this EHC_E15 message)
        {
            object[] result = message.GetRecords("PAYMENT_REMITTANCE_DETAIL_INFORepetitionsUsed", "GetPAYMENT_REMITTANCE_DETAIL_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PAYMENT_REMITTANCE_DETAIL_INFO Records from EHC_E15
        /// </summary>
        public static List<EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO> GetAllPAYMENT_REMITTANCE_DETAIL_INFORecords(this EHC_E15 message)
        {
            return message.GetAllRecords<EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO>("PAYMENT_REMITTANCE_DETAIL_INFORepetitionsUsed", "GetPAYMENT_REMITTANCE_DETAIL_INFO");
        }

        /// <summary>
        /// Add a new EHC_E15 to PAYMENT_REMITTANCE_DETAIL_INFO
        /// </summary>
        public static EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO AddPAYMENT_REMITTANCE_DETAIL_INFO(this EHC_E15 message)
        {
            return message.GetPAYMENT_REMITTANCE_DETAIL_INFO(message.PAYMENT_REMITTANCE_DETAIL_INFORepetitionsUsed);
        }

        /// <summary>
        /// Get ADJUSTMENT_PAYEE Records from EHC_E15
        /// </summary>
        public static IEnumerable GetADJUSTMENT_PAYEERecords(this EHC_E15 message)
        {
            object[] result = message.GetRecords("ADJUSTMENT_PAYEERepetitionsUsed", "GetADJUSTMENT_PAYEE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ADJUSTMENT_PAYEE Records from EHC_E15
        /// </summary>
        public static List<EHC_E15_ADJUSTMENT_PAYEE> GetAllADJUSTMENT_PAYEERecords(this EHC_E15 message)
        {
            return message.GetAllRecords<EHC_E15_ADJUSTMENT_PAYEE>("ADJUSTMENT_PAYEERepetitionsUsed", "GetADJUSTMENT_PAYEE");
        }

        /// <summary>
        /// Add a new EHC_E15 to ADJUSTMENT_PAYEE
        /// </summary>
        public static EHC_E15_ADJUSTMENT_PAYEE AddADJUSTMENT_PAYEE(this EHC_E15 message)
        {
            return message.GetADJUSTMENT_PAYEE(message.ADJUSTMENT_PAYEERepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E20
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E20
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E20 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E20 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E20 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E20
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E20
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E20 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E20 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E20 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from EHC_E20
        /// </summary>
        public static IEnumerable GetCTDRecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from EHC_E20
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this EHC_E20 message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new EHC_E20 to CTD
        /// </summary>
        public static CTD AddCTD(this EHC_E20 message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get LOC Records from EHC_E20
        /// </summary>
        public static IEnumerable GetLOCRecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("LOCRepetitionsUsed", "GetLOC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOC Records from EHC_E20
        /// </summary>
        public static List<LOC> GetAllLOCRecords(this EHC_E20 message)
        {
            return message.GetAllRecords<LOC>("LOCRepetitionsUsed", "GetLOC");
        }

        /// <summary>
        /// Add a new EHC_E20 to LOC
        /// </summary>
        public static LOC AddLOC(this EHC_E20 message)
        {
            return message.GetLOC(message.LOCRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from EHC_E20
        /// </summary>
        public static IEnumerable GetROLRecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from EHC_E20
        /// </summary>
        public static List<ROL> GetAllROLRecords(this EHC_E20 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new EHC_E20 to ROL
        /// </summary>
        public static ROL AddROL(this EHC_E20 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get PAT_INFO Records from EHC_E20
        /// </summary>
        public static IEnumerable GetPAT_INFORecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("PAT_INFORepetitionsUsed", "GetPAT_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PAT_INFO Records from EHC_E20
        /// </summary>
        public static List<EHC_E20_PAT_INFO> GetAllPAT_INFORecords(this EHC_E20 message)
        {
            return message.GetAllRecords<EHC_E20_PAT_INFO>("PAT_INFORepetitionsUsed", "GetPAT_INFO");
        }

        /// <summary>
        /// Add a new EHC_E20 to PAT_INFO
        /// </summary>
        public static EHC_E20_PAT_INFO AddPAT_INFO(this EHC_E20 message)
        {
            return message.GetPAT_INFO(message.PAT_INFORepetitionsUsed);
        }

        /// <summary>
        /// Get PSL_ITEM_INFO Records from EHC_E20
        /// </summary>
        public static IEnumerable GetPSL_ITEM_INFORecords(this EHC_E20 message)
        {
            object[] result = message.GetRecords("PSL_ITEM_INFORepetitionsUsed", "GetPSL_ITEM_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PSL_ITEM_INFO Records from EHC_E20
        /// </summary>
        public static List<EHC_E20_PSL_ITEM_INFO> GetAllPSL_ITEM_INFORecords(this EHC_E20 message)
        {
            return message.GetAllRecords<EHC_E20_PSL_ITEM_INFO>("PSL_ITEM_INFORepetitionsUsed", "GetPSL_ITEM_INFO");
        }

        /// <summary>
        /// Add a new EHC_E20 to PSL_ITEM_INFO
        /// </summary>
        public static EHC_E20_PSL_ITEM_INFO AddPSL_ITEM_INFO(this EHC_E20 message)
        {
            return message.GetPSL_ITEM_INFO(message.PSL_ITEM_INFORepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E21
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E21 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E21
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E21 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E21 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E21 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E21
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E21 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E21
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E21 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E21 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E21 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get PSL_ITEM_INFO Records from EHC_E21
        /// </summary>
        public static IEnumerable GetPSL_ITEM_INFORecords(this EHC_E21 message)
        {
            object[] result = message.GetRecords("PSL_ITEM_INFORepetitionsUsed", "GetPSL_ITEM_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PSL_ITEM_INFO Records from EHC_E21
        /// </summary>
        public static List<EHC_E21_PSL_ITEM_INFO> GetAllPSL_ITEM_INFORecords(this EHC_E21 message)
        {
            return message.GetAllRecords<EHC_E21_PSL_ITEM_INFO>("PSL_ITEM_INFORepetitionsUsed", "GetPSL_ITEM_INFO");
        }

        /// <summary>
        /// Add a new EHC_E21 to PSL_ITEM_INFO
        /// </summary>
        public static EHC_E21_PSL_ITEM_INFO AddPSL_ITEM_INFO(this EHC_E21 message)
        {
            return message.GetPSL_ITEM_INFO(message.PSL_ITEM_INFORepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from EHC_E24
        /// </summary>
        public static IEnumerable GetSFTRecords(this EHC_E24 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from EHC_E24
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this EHC_E24 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new EHC_E24 to SFT
        /// </summary>
        public static SFT AddSFT(this EHC_E24 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from EHC_E24
        /// </summary>
        public static IEnumerable GetUACRecords(this EHC_E24 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from EHC_E24
        /// </summary>
        public static List<UAC> GetAllUACRecords(this EHC_E24 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new EHC_E24 to UAC
        /// </summary>
        public static UAC AddUAC(this EHC_E24 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from EHC_E24
        /// </summary>
        public static IEnumerable GetERRRecords(this EHC_E24 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from EHC_E24
        /// </summary>
        public static List<ERR> GetAllERRRecords(this EHC_E24 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new EHC_E24 to ERR
        /// </summary>
        public static ERR AddERR(this EHC_E24 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get PSL_ITEM_INFO Records from EHC_E24
        /// </summary>
        public static IEnumerable GetPSL_ITEM_INFORecords(this EHC_E24 message)
        {
            object[] result = message.GetRecords("PSL_ITEM_INFORepetitionsUsed", "GetPSL_ITEM_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PSL_ITEM_INFO Records from EHC_E24
        /// </summary>
        public static List<EHC_E24_PSL_ITEM_INFO> GetAllPSL_ITEM_INFORecords(this EHC_E24 message)
        {
            return message.GetAllRecords<EHC_E24_PSL_ITEM_INFO>("PSL_ITEM_INFORepetitionsUsed", "GetPSL_ITEM_INFO");
        }

        /// <summary>
        /// Add a new EHC_E24 to PSL_ITEM_INFO
        /// </summary>
        public static EHC_E24_PSL_ITEM_INFO AddPSL_ITEM_INFO(this EHC_E24 message)
        {
            return message.GetPSL_ITEM_INFO(message.PSL_ITEM_INFORepetitionsUsed);
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
        /// Get CON Records from MDM_T01
        /// </summary>
        public static IEnumerable GetCONRecords(this MDM_T01 message)
        {
            object[] result = message.GetRecords("CONRepetitionsUsed", "GetCON");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CON Records from MDM_T01
        /// </summary>
        public static List<CON> GetAllCONRecords(this MDM_T01 message)
        {
            return message.GetAllRecords<CON>("CONRepetitionsUsed", "GetCON");
        }

        /// <summary>
        /// Add a new MDM_T01 to CON
        /// </summary>
        public static CON AddCON(this MDM_T01 message)
        {
            return message.GetCON(message.CONRepetitionsUsed);
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
        /// Get CON Records from MDM_T02
        /// </summary>
        public static IEnumerable GetCONRecords(this MDM_T02 message)
        {
            object[] result = message.GetRecords("CONRepetitionsUsed", "GetCON");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CON Records from MDM_T02
        /// </summary>
        public static List<CON> GetAllCONRecords(this MDM_T02 message)
        {
            return message.GetAllRecords<CON>("CONRepetitionsUsed", "GetCON");
        }

        /// <summary>
        /// Add a new MDM_T02 to CON
        /// </summary>
        public static CON AddCON(this MDM_T02 message)
        {
            return message.GetCON(message.CONRepetitionsUsed);
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
        /// Get SFT Records from MFN_M16
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M16 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M16
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M16 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new MFN_M16 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M16 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get MATERIAL_ITEM_RECORD Records from MFN_M16
        /// </summary>
        public static IEnumerable GetMATERIAL_ITEM_RECORDRecords(this MFN_M16 message)
        {
            object[] result = message.GetRecords("MATERIAL_ITEM_RECORDRepetitionsUsed", "GetMATERIAL_ITEM_RECORD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MATERIAL_ITEM_RECORD Records from MFN_M16
        /// </summary>
        public static List<MFN_M16_MATERIAL_ITEM_RECORD> GetAllMATERIAL_ITEM_RECORDRecords(this MFN_M16 message)
        {
            return message.GetAllRecords<MFN_M16_MATERIAL_ITEM_RECORD>("MATERIAL_ITEM_RECORDRepetitionsUsed", "GetMATERIAL_ITEM_RECORD");
        }

        /// <summary>
        /// Add a new MFN_M16 to MATERIAL_ITEM_RECORD
        /// </summary>
        public static MFN_M16_MATERIAL_ITEM_RECORD AddMATERIAL_ITEM_RECORD(this MFN_M16 message)
        {
            return message.GetMATERIAL_ITEM_RECORD(message.MATERIAL_ITEM_RECORDRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from MFN_M17
        /// </summary>
        public static IEnumerable GetSFTRecords(this MFN_M17 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from MFN_M17
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this MFN_M17 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new MFN_M17 to SFT
        /// </summary>
        public static SFT AddSFT(this MFN_M17 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get MF_DRG Records from MFN_M17
        /// </summary>
        public static IEnumerable GetMF_DRGRecords(this MFN_M17 message)
        {
            object[] result = message.GetRecords("MF_DRGRepetitionsUsed", "GetMF_DRG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_DRG Records from MFN_M17
        /// </summary>
        public static List<MFN_M17_MF_DRG> GetAllMF_DRGRecords(this MFN_M17 message)
        {
            return message.GetAllRecords<MFN_M17_MF_DRG>("MF_DRGRepetitionsUsed", "GetMF_DRG");
        }

        /// <summary>
        /// Add a new MFN_M17 to MF_DRG
        /// </summary>
        public static MFN_M17_MF_DRG AddMF_DRG(this MFN_M17 message)
        {
            return message.GetMF_DRG(message.MF_DRGRepetitionsUsed);
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
        /// Get SFT Records from OML_O39
        /// </summary>
        public static IEnumerable GetSFTRecords(this OML_O39 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OML_O39
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OML_O39 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new OML_O39 to SFT
        /// </summary>
        public static SFT AddSFT(this OML_O39 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OML_O39
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O39 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O39
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O39 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OML_O39 to NTE
        /// </summary>
        public static NTE AddNTE(this OML_O39 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OML_O39
        /// </summary>
        public static IEnumerable GetORDERRecords(this OML_O39 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OML_O39
        /// </summary>
        public static List<OML_O39_ORDER> GetAllORDERRecords(this OML_O39 message)
        {
            return message.GetAllRecords<OML_O39_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OML_O39 to ORDER
        /// </summary>
        public static OML_O39_ORDER AddORDER(this OML_O39 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
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
        /// Get SFT Records from OPL_O37
        /// </summary>
        public static IEnumerable GetSFTRecords(this OPL_O37 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OPL_O37
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OPL_O37 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new OPL_O37 to SFT
        /// </summary>
        public static SFT AddSFT(this OPL_O37 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OPL_O37
        /// </summary>
        public static IEnumerable GetNTERecords(this OPL_O37 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OPL_O37
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OPL_O37 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OPL_O37 to NTE
        /// </summary>
        public static NTE AddNTE(this OPL_O37 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PRT Records from OPL_O37
        /// </summary>
        public static IEnumerable GetPRTRecords(this OPL_O37 message)
        {
            object[] result = message.GetRecords("PRTRepetitionsUsed", "GetPRT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRT Records from OPL_O37
        /// </summary>
        public static List<PRT> GetAllPRTRecords(this OPL_O37 message)
        {
            return message.GetAllRecords<PRT>("PRTRepetitionsUsed", "GetPRT");
        }

        /// <summary>
        /// Add a new OPL_O37 to PRT
        /// </summary>
        public static PRT AddPRT(this OPL_O37 message)
        {
            return message.GetPRT(message.PRTRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from OPL_O37
        /// </summary>
        public static IEnumerable GetORDERRecords(this OPL_O37 message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OPL_O37
        /// </summary>
        public static List<OPL_O37_ORDER> GetAllORDERRecords(this OPL_O37 message)
        {
            return message.GetAllRecords<OPL_O37_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new OPL_O37 to ORDER
        /// </summary>
        public static OPL_O37_ORDER AddORDER(this OPL_O37 message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from OPR_O38
        /// </summary>
        public static IEnumerable GetERRRecords(this OPR_O38 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from OPR_O38
        /// </summary>
        public static List<ERR> GetAllERRRecords(this OPR_O38 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new OPR_O38 to ERR
        /// </summary>
        public static ERR AddERR(this OPR_O38 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from OPR_O38
        /// </summary>
        public static IEnumerable GetSFTRecords(this OPR_O38 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OPR_O38
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OPR_O38 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new OPR_O38 to SFT
        /// </summary>
        public static SFT AddSFT(this OPR_O38 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OPR_O38
        /// </summary>
        public static IEnumerable GetNTERecords(this OPR_O38 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OPR_O38
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OPR_O38 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OPR_O38 to NTE
        /// </summary>
        public static NTE AddNTE(this OPR_O38 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESPONSE Records from OPR_O38
        /// </summary>
        public static IEnumerable GetRESPONSERecords(this OPR_O38 message)
        {
            object[] result = message.GetRecords("RESPONSERepetitionsUsed", "GetRESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESPONSE Records from OPR_O38
        /// </summary>
        public static List<OPR_O38_RESPONSE> GetAllRESPONSERecords(this OPR_O38 message)
        {
            return message.GetAllRecords<OPR_O38_RESPONSE>("RESPONSERepetitionsUsed", "GetRESPONSE");
        }

        /// <summary>
        /// Add a new OPR_O38 to RESPONSE
        /// </summary>
        public static OPR_O38_RESPONSE AddRESPONSE(this OPR_O38 message)
        {
            return message.GetRESPONSE(message.RESPONSERepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from OPU_R25
        /// </summary>
        public static IEnumerable GetSFTRecords(this OPU_R25 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OPU_R25
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OPU_R25 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new OPU_R25 to SFT
        /// </summary>
        public static SFT AddSFT(this OPU_R25 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get PRT Records from OPU_R25
        /// </summary>
        public static IEnumerable GetPRTRecords(this OPU_R25 message)
        {
            object[] result = message.GetRecords("PRTRepetitionsUsed", "GetPRT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRT Records from OPU_R25
        /// </summary>
        public static List<PRT> GetAllPRTRecords(this OPU_R25 message)
        {
            return message.GetAllRecords<PRT>("PRTRepetitionsUsed", "GetPRT");
        }

        /// <summary>
        /// Add a new OPU_R25 to PRT
        /// </summary>
        public static PRT AddPRT(this OPU_R25 message)
        {
            return message.GetPRT(message.PRTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_VISIT_OBSERVATION Records from OPU_R25
        /// </summary>
        public static IEnumerable GetPATIENT_VISIT_OBSERVATIONRecords(this OPU_R25 message)
        {
            object[] result = message.GetRecords("PATIENT_VISIT_OBSERVATIONRepetitionsUsed", "GetPATIENT_VISIT_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_VISIT_OBSERVATION Records from OPU_R25
        /// </summary>
        public static List<OPU_R25_PATIENT_VISIT_OBSERVATION> GetAllPATIENT_VISIT_OBSERVATIONRecords(this OPU_R25 message)
        {
            return message.GetAllRecords<OPU_R25_PATIENT_VISIT_OBSERVATION>("PATIENT_VISIT_OBSERVATIONRepetitionsUsed", "GetPATIENT_VISIT_OBSERVATION");
        }

        /// <summary>
        /// Add a new OPU_R25 to PATIENT_VISIT_OBSERVATION
        /// </summary>
        public static OPU_R25_PATIENT_VISIT_OBSERVATION AddPATIENT_VISIT_OBSERVATION(this OPU_R25 message)
        {
            return message.GetPATIENT_VISIT_OBSERVATION(message.PATIENT_VISIT_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get ACCESSION_DETAIL Records from OPU_R25
        /// </summary>
        public static IEnumerable GetACCESSION_DETAILRecords(this OPU_R25 message)
        {
            object[] result = message.GetRecords("ACCESSION_DETAILRepetitionsUsed", "GetACCESSION_DETAIL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ACCESSION_DETAIL Records from OPU_R25
        /// </summary>
        public static List<OPU_R25_ACCESSION_DETAIL> GetAllACCESSION_DETAILRecords(this OPU_R25 message)
        {
            return message.GetAllRecords<OPU_R25_ACCESSION_DETAIL>("ACCESSION_DETAILRepetitionsUsed", "GetACCESSION_DETAIL");
        }

        /// <summary>
        /// Add a new OPU_R25 to ACCESSION_DETAIL
        /// </summary>
        public static OPU_R25_ACCESSION_DETAIL AddACCESSION_DETAIL(this OPU_R25 message)
        {
            return message.GetACCESSION_DETAIL(message.ACCESSION_DETAILRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from ORA_R33
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORA_R33 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORA_R33
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORA_R33 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new ORA_R33 to SFT
        /// </summary>
        public static SFT AddSFT(this ORA_R33 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from ORA_R33
        /// </summary>
        public static IEnumerable GetERRRecords(this ORA_R33 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORA_R33
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORA_R33 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new ORA_R33 to ERR
        /// </summary>
        public static ERR AddERR(this ORA_R33 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Get ERR Records from ORL_O40
        /// </summary>
        public static IEnumerable GetERRRecords(this ORL_O40 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from ORL_O40
        /// </summary>
        public static List<ERR> GetAllERRRecords(this ORL_O40 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new ORL_O40 to ERR
        /// </summary>
        public static ERR AddERR(this ORL_O40 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from ORL_O40
        /// </summary>
        public static IEnumerable GetSFTRecords(this ORL_O40 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from ORL_O40
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this ORL_O40 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new ORL_O40 to SFT
        /// </summary>
        public static SFT AddSFT(this ORL_O40 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORL_O40
        /// </summary>
        public static IEnumerable GetNTERecords(this ORL_O40 message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORL_O40
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORL_O40 message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORL_O40 to NTE
        /// </summary>
        public static NTE AddNTE(this ORL_O40 message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
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
        /// Get PRT Records from ORU_R30
        /// </summary>
        public static IEnumerable GetPRTRecords(this ORU_R30 message)
        {
            object[] result = message.GetRecords("PRTRepetitionsUsed", "GetPRT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRT Records from ORU_R30
        /// </summary>
        public static List<PRT> GetAllPRTRecords(this ORU_R30 message)
        {
            return message.GetAllRecords<PRT>("PRTRepetitionsUsed", "GetPRT");
        }

        /// <summary>
        /// Add a new ORU_R30 to PRT
        /// </summary>
        public static PRT AddPRT(this ORU_R30 message)
        {
            return message.GetPRT(message.PRTRepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT_OBSERVATION Records from ORU_R30
        /// </summary>
        public static IEnumerable GetPATIENT_OBSERVATIONRecords(this ORU_R30 message)
        {
            object[] result = message.GetRecords("PATIENT_OBSERVATIONRepetitionsUsed", "GetPATIENT_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT_OBSERVATION Records from ORU_R30
        /// </summary>
        public static List<ORU_R30_PATIENT_OBSERVATION> GetAllPATIENT_OBSERVATIONRecords(this ORU_R30 message)
        {
            return message.GetAllRecords<ORU_R30_PATIENT_OBSERVATION>("PATIENT_OBSERVATIONRepetitionsUsed", "GetPATIENT_OBSERVATION");
        }

        /// <summary>
        /// Add a new ORU_R30 to PATIENT_OBSERVATION
        /// </summary>
        public static ORU_R30_PATIENT_OBSERVATION AddPATIENT_OBSERVATION(this ORU_R30 message)
        {
            return message.GetPATIENT_OBSERVATION(message.PATIENT_OBSERVATIONRepetitionsUsed);
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
        /// Get PRT2 Records from ORU_R30
        /// </summary>
        public static IEnumerable GetPRT2Records(this ORU_R30 message)
        {
            object[] result = message.GetRecords("PRT2RepetitionsUsed", "GetPRT2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRT2 Records from ORU_R30
        /// </summary>
        public static List<PRT> GetAllPRT2Records(this ORU_R30 message)
        {
            return message.GetAllRecords<PRT>("PRT2RepetitionsUsed", "GetPRT2");
        }

        /// <summary>
        /// Add a new ORU_R30 to PRT2
        /// </summary>
        public static PRT AddPRT2(this ORU_R30 message)
        {
            return message.GetPRT2(message.PRT2RepetitionsUsed);
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
        /// Get SFT Records from OSM_R26
        /// </summary>
        public static IEnumerable GetSFTRecords(this OSM_R26 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from OSM_R26
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this OSM_R26 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new OSM_R26 to SFT
        /// </summary>
        public static SFT AddSFT(this OSM_R26 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SHIPMENT Records from OSM_R26
        /// </summary>
        public static IEnumerable GetSHIPMENTRecords(this OSM_R26 message)
        {
            object[] result = message.GetRecords("SHIPMENTRepetitionsUsed", "GetSHIPMENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SHIPMENT Records from OSM_R26
        /// </summary>
        public static List<OSM_R26_SHIPMENT> GetAllSHIPMENTRecords(this OSM_R26 message)
        {
            return message.GetAllRecords<OSM_R26_SHIPMENT>("SHIPMENTRepetitionsUsed", "GetSHIPMENT");
        }

        /// <summary>
        /// Add a new OSM_R26 to SHIPMENT
        /// </summary>
        public static OSM_R26_SHIPMENT AddSHIPMENT(this OSM_R26 message)
        {
            return message.GetSHIPMENT(message.SHIPMENTRepetitionsUsed);
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
        /// Get NK1 Records from OUL_R22
        /// </summary>
        public static IEnumerable GetNK1Records(this OUL_R22 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OUL_R22
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OUL_R22 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OUL_R22 to NK1
        /// </summary>
        public static NK1 AddNK1(this OUL_R22 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Get NK1 Records from OUL_R23
        /// </summary>
        public static IEnumerable GetNK1Records(this OUL_R23 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OUL_R23
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OUL_R23 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OUL_R23 to NK1
        /// </summary>
        public static NK1 AddNK1(this OUL_R23 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Get NK1 Records from OUL_R24
        /// </summary>
        public static IEnumerable GetNK1Records(this OUL_R24 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from OUL_R24
        /// </summary>
        public static List<NK1> GetAllNK1Records(this OUL_R24 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new OUL_R24 to NK1
        /// </summary>
        public static NK1 AddNK1(this OUL_R24 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
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
        /// Get PRT Records from PEX_P07
        /// </summary>
        public static IEnumerable GetPRTRecords(this PEX_P07 message)
        {
            object[] result = message.GetRecords("PRTRepetitionsUsed", "GetPRT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRT Records from PEX_P07
        /// </summary>
        public static List<PRT> GetAllPRTRecords(this PEX_P07 message)
        {
            return message.GetAllRecords<PRT>("PRTRepetitionsUsed", "GetPRT");
        }

        /// <summary>
        /// Add a new PEX_P07 to PRT
        /// </summary>
        public static PRT AddPRT(this PEX_P07 message)
        {
            return message.GetPRT(message.PRTRepetitionsUsed);
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
        /// Get NK1 Records from PMU_B01
        /// </summary>
        public static IEnumerable GetNK1Records(this PMU_B01 message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from PMU_B01
        /// </summary>
        public static List<NK1> GetAllNK1Records(this PMU_B01 message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new PMU_B01 to NK1
        /// </summary>
        public static NK1 AddNK1(this PMU_B01 message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from PMU_B01
        /// </summary>
        public static IEnumerable GetROLRecords(this PMU_B01 message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from PMU_B01
        /// </summary>
        public static List<ROL> GetAllROLRecords(this PMU_B01 message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new PMU_B01 to ROL
        /// </summary>
        public static ROL AddROL(this PMU_B01 message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
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
        /// Get SFT Records from QBP_E03
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_E03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_E03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_E03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new QBP_E03 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_E03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from QBP_E03
        /// </summary>
        public static IEnumerable GetUACRecords(this QBP_E03 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from QBP_E03
        /// </summary>
        public static List<UAC> GetAllUACRecords(this QBP_E03 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new QBP_E03 to UAC
        /// </summary>
        public static UAC AddUAC(this QBP_E03 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from QBP_E22
        /// </summary>
        public static IEnumerable GetSFTRecords(this QBP_E22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from QBP_E22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this QBP_E22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new QBP_E22 to SFT
        /// </summary>
        public static SFT AddSFT(this QBP_E22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from QBP_E22
        /// </summary>
        public static IEnumerable GetUACRecords(this QBP_E22 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from QBP_E22
        /// </summary>
        public static List<UAC> GetAllUACRecords(this QBP_E22 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new QBP_E22 to UAC
        /// </summary>
        public static UAC AddUAC(this QBP_E22 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
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
        /// Get ERR Records from RDR_RDR
        /// </summary>
        public static IEnumerable GetERRRecords(this RDR_RDR message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RDR_RDR
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RDR_RDR message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new RDR_RDR to ERR
        /// </summary>
        public static ERR AddERR(this RDR_RDR message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Get SFT Records from RSP_E03
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_E03 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_E03
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_E03 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new RSP_E03 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_E03 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from RSP_E03
        /// </summary>
        public static IEnumerable GetUACRecords(this RSP_E03 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from RSP_E03
        /// </summary>
        public static List<UAC> GetAllUACRecords(this RSP_E03 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new RSP_E03 to UAC
        /// </summary>
        public static UAC AddUAC(this RSP_E03 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from RSP_E03
        /// </summary>
        public static IEnumerable GetERRRecords(this RSP_E03 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RSP_E03
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RSP_E03 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new RSP_E03 to ERR
        /// </summary>
        public static ERR AddERR(this RSP_E03 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
        }

        /// <summary>
        /// Get INVOICE_PROCESSING_RESULTS_INFO Records from RSP_E03
        /// </summary>
        public static IEnumerable GetINVOICE_PROCESSING_RESULTS_INFORecords(this RSP_E03 message)
        {
            object[] result = message.GetRecords("INVOICE_PROCESSING_RESULTS_INFORepetitionsUsed", "GetINVOICE_PROCESSING_RESULTS_INFO");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INVOICE_PROCESSING_RESULTS_INFO Records from RSP_E03
        /// </summary>
        public static List<RSP_E03_INVOICE_PROCESSING_RESULTS_INFO> GetAllINVOICE_PROCESSING_RESULTS_INFORecords(this RSP_E03 message)
        {
            return message.GetAllRecords<RSP_E03_INVOICE_PROCESSING_RESULTS_INFO>("INVOICE_PROCESSING_RESULTS_INFORepetitionsUsed", "GetINVOICE_PROCESSING_RESULTS_INFO");
        }

        /// <summary>
        /// Add a new RSP_E03 to INVOICE_PROCESSING_RESULTS_INFO
        /// </summary>
        public static RSP_E03_INVOICE_PROCESSING_RESULTS_INFO AddINVOICE_PROCESSING_RESULTS_INFO(this RSP_E03 message)
        {
            return message.GetINVOICE_PROCESSING_RESULTS_INFO(message.INVOICE_PROCESSING_RESULTS_INFORepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from RSP_E22
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_E22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_E22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_E22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new RSP_E22 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_E22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get UAC Records from RSP_E22
        /// </summary>
        public static IEnumerable GetUACRecords(this RSP_E22 message)
        {
            object[] result = message.GetRecords("UACRepetitionsUsed", "GetUAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UAC Records from RSP_E22
        /// </summary>
        public static List<UAC> GetAllUACRecords(this RSP_E22 message)
        {
            return message.GetAllRecords<UAC>("UACRepetitionsUsed", "GetUAC");
        }

        /// <summary>
        /// Add a new RSP_E22 to UAC
        /// </summary>
        public static UAC AddUAC(this RSP_E22 message)
        {
            return message.GetUAC(message.UACRepetitionsUsed);
        }

        /// <summary>
        /// Get ERR Records from RSP_E22
        /// </summary>
        public static IEnumerable GetERRRecords(this RSP_E22 message)
        {
            object[] result = message.GetRecords("ERRRepetitionsUsed", "GetERR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ERR Records from RSP_E22
        /// </summary>
        public static List<ERR> GetAllERRRecords(this RSP_E22 message)
        {
            return message.GetAllRecords<ERR>("ERRRepetitionsUsed", "GetERR");
        }

        /// <summary>
        /// Add a new RSP_E22 to ERR
        /// </summary>
        public static ERR AddERR(this RSP_E22 message)
        {
            return message.GetERR(message.ERRRepetitionsUsed);
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
        /// Get SFT Records from RSP_K22
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K22 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K22
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K22 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new RSP_K22 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K22 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from RSP_K22
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this RSP_K22 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from RSP_K22
        /// </summary>
        public static List<RSP_K22_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this RSP_K22 message)
        {
            return message.GetAllRecords<RSP_K22_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Add a new RSP_K22 to QUERY_RESPONSE
        /// </summary>
        public static RSP_K22_QUERY_RESPONSE AddQUERY_RESPONSE(this RSP_K22 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Get SFT Records from RSP_K32
        /// </summary>
        public static IEnumerable GetSFTRecords(this RSP_K32 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from RSP_K32
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this RSP_K32 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new RSP_K32 to SFT
        /// </summary>
        public static SFT AddSFT(this RSP_K32 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get QUERY_RESPONSE Records from RSP_K32
        /// </summary>
        public static IEnumerable GetQUERY_RESPONSERecords(this RSP_K32 message)
        {
            object[] result = message.GetRecords("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QUERY_RESPONSE Records from RSP_K32
        /// </summary>
        public static List<RSP_K32_QUERY_RESPONSE> GetAllQUERY_RESPONSERecords(this RSP_K32 message)
        {
            return message.GetAllRecords<RSP_K32_QUERY_RESPONSE>("QUERY_RESPONSERepetitionsUsed", "GetQUERY_RESPONSE");
        }

        /// <summary>
        /// Add a new RSP_K32 to QUERY_RESPONSE
        /// </summary>
        public static RSP_K32_QUERY_RESPONSE AddQUERY_RESPONSE(this RSP_K32 message)
        {
            return message.GetQUERY_RESPONSE(message.QUERY_RESPONSERepetitionsUsed);
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
        /// Get SFT Records from SDR_S31
        /// </summary>
        public static IEnumerable GetSFTRecords(this SDR_S31 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from SDR_S31
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this SDR_S31 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new SDR_S31 to SFT
        /// </summary>
        public static SFT AddSFT(this SDR_S31 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SCD Records from SDR_S31
        /// </summary>
        public static IEnumerable GetSCDRecords(this SDR_S31 message)
        {
            object[] result = message.GetRecords("SCDRepetitionsUsed", "GetSCD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SCD Records from SDR_S31
        /// </summary>
        public static List<SCD> GetAllSCDRecords(this SDR_S31 message)
        {
            return message.GetAllRecords<SCD>("SCDRepetitionsUsed", "GetSCD");
        }

        /// <summary>
        /// Add a new SDR_S31 to SCD
        /// </summary>
        public static SCD AddSCD(this SDR_S31 message)
        {
            return message.GetSCD(message.SCDRepetitionsUsed);
        }

        /// <summary>
        /// Get SFT Records from SDR_S32
        /// </summary>
        public static IEnumerable GetSFTRecords(this SDR_S32 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from SDR_S32
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this SDR_S32 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new SDR_S32 to SFT
        /// </summary>
        public static SFT AddSFT(this SDR_S32 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SCD Records from SDR_S32
        /// </summary>
        public static IEnumerable GetSCDRecords(this SDR_S32 message)
        {
            object[] result = message.GetRecords("SCDRepetitionsUsed", "GetSCD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SCD Records from SDR_S32
        /// </summary>
        public static List<SCD> GetAllSCDRecords(this SDR_S32 message)
        {
            return message.GetAllRecords<SCD>("SCDRepetitionsUsed", "GetSCD");
        }

        /// <summary>
        /// Add a new SDR_S32 to SCD
        /// </summary>
        public static SCD AddSCD(this SDR_S32 message)
        {
            return message.GetSCD(message.SCDRepetitionsUsed);
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
        /// Get SFT Records from SLR_S28
        /// </summary>
        public static IEnumerable GetSFTRecords(this SLR_S28 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from SLR_S28
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this SLR_S28 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new SLR_S28 to SFT
        /// </summary>
        public static SFT AddSFT(this SLR_S28 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SLT Records from SLR_S28
        /// </summary>
        public static IEnumerable GetSLTRecords(this SLR_S28 message)
        {
            object[] result = message.GetRecords("SLTRepetitionsUsed", "GetSLT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SLT Records from SLR_S28
        /// </summary>
        public static List<SLT> GetAllSLTRecords(this SLR_S28 message)
        {
            return message.GetAllRecords<SLT>("SLTRepetitionsUsed", "GetSLT");
        }

        /// <summary>
        /// Add a new SLR_S28 to SLT
        /// </summary>
        public static SLT AddSLT(this SLR_S28 message)
        {
            return message.GetSLT(message.SLTRepetitionsUsed);
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
        /// Get SFT Records from STC_S33
        /// </summary>
        public static IEnumerable GetSFTRecords(this STC_S33 message)
        {
            object[] result = message.GetRecords("SFTRepetitionsUsed", "GetSFT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SFT Records from STC_S33
        /// </summary>
        public static List<SFT> GetAllSFTRecords(this STC_S33 message)
        {
            return message.GetAllRecords<SFT>("SFTRepetitionsUsed", "GetSFT");
        }

        /// <summary>
        /// Add a new STC_S33 to SFT
        /// </summary>
        public static SFT AddSFT(this STC_S33 message)
        {
            return message.GetSFT(message.SFTRepetitionsUsed);
        }

        /// <summary>
        /// Get SCP Records from STC_S33
        /// </summary>
        public static IEnumerable GetSCPRecords(this STC_S33 message)
        {
            object[] result = message.GetRecords("SCPRepetitionsUsed", "GetSCP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SCP Records from STC_S33
        /// </summary>
        public static List<SCP> GetAllSCPRecords(this STC_S33 message)
        {
            return message.GetAllRecords<SCP>("SCPRepetitionsUsed", "GetSCP");
        }

        /// <summary>
        /// Add a new STC_S33 to SCP
        /// </summary>
        public static SCP AddSCP(this STC_S33 message)
        {
            return message.GetSCP(message.SCPRepetitionsUsed);
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
        #endregion
    }
}
