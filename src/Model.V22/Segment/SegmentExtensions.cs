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

namespace NHapiTools.Model.V22.Segment
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class SegmentExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get BatchTotals Records from BTS
        /// </summary>
        public static IEnumerable GetBatchTotalsRecords(this BTS message)
        {
            object[] result = message.GetRecords("BatchTotalsRepetitionsUsed", "GetBatchTotals");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BatchTotals Records from BTS
        /// </summary>
        public static List<CM_BATCH_TOTAL> GetAllBatchTotalsRecords(this BTS message)
        {
            return message.GetAllRecords<CM_BATCH_TOTAL>("BatchTotalsRepetitionsUsed", "GetBatchTotals");
        }

        /// <summary>
        /// Add a new BatchTotals to BTS
        /// </summary>
        public static CM_BATCH_TOTAL AddBatchTotals(this BTS message)
        {
            return message.GetBatchTotals(message.BatchTotalsRepetitionsUsed);
        }

        /// <summary>
        /// Get ErrorCodeAndLocation Records from ERR
        /// </summary>
        public static IEnumerable GetErrorCodeAndLocationRecords(this ERR message)
        {
            object[] result = message.GetRecords("ErrorCodeAndLocationRepetitionsUsed", "GetErrorCodeAndLocation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ErrorCodeAndLocation Records from ERR
        /// </summary>
        public static List<CM_ELD> GetAllErrorCodeAndLocationRecords(this ERR message)
        {
            return message.GetAllRecords<CM_ELD>("ErrorCodeAndLocationRepetitionsUsed", "GetErrorCodeAndLocation");
        }

        /// <summary>
        /// Add a new ErrorCodeAndLocation to ERR
        /// </summary>
        public static CM_ELD AddErrorCodeAndLocation(this ERR message)
        {
            return message.GetErrorCodeAndLocation(message.ErrorCodeAndLocationRepetitionsUsed);
        }

        /// <summary>
        /// Get DiagnosisCode Records from FT1
        /// </summary>
        public static IEnumerable GetDiagnosisCodeRecords(this FT1 message)
        {
            object[] result = message.GetRecords("DiagnosisCodeRepetitionsUsed", "GetDiagnosisCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DiagnosisCode Records from FT1
        /// </summary>
        public static List<CE> GetAllDiagnosisCodeRecords(this FT1 message)
        {
            return message.GetAllRecords<CE>("DiagnosisCodeRepetitionsUsed", "GetDiagnosisCode");
        }

        /// <summary>
        /// Add a new DiagnosisCode to FT1
        /// </summary>
        public static CE AddDiagnosisCode(this FT1 message)
        {
            return message.GetDiagnosisCode(message.DiagnosisCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get GuarantorPhoneNumberHome Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorPhoneNumberHomeRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorPhoneNumberHomeRepetitionsUsed", "GetGuarantorPhoneNumberHome");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorPhoneNumberHome Records from GT1
        /// </summary>
        public static List<TN> GetAllGuarantorPhoneNumberHomeRecords(this GT1 message)
        {
            return message.GetAllRecords<TN>("GuarantorPhoneNumberHomeRepetitionsUsed", "GetGuarantorPhoneNumberHome");
        }

        /// <summary>
        /// Add a new GuarantorPhoneNumberHome to GT1
        /// </summary>
        public static TN AddGuarantorPhoneNumberHome(this GT1 message)
        {
            return message.GetGuarantorPhoneNumberHome(message.GuarantorPhoneNumberHomeRepetitionsUsed);
        }

        /// <summary>
        /// Get GuarantorPhoneNumberBusiness Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorPhoneNumberBusinessRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorPhoneNumberBusinessRepetitionsUsed", "GetGuarantorPhoneNumberBusiness");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorPhoneNumberBusiness Records from GT1
        /// </summary>
        public static List<TN> GetAllGuarantorPhoneNumberBusinessRecords(this GT1 message)
        {
            return message.GetAllRecords<TN>("GuarantorPhoneNumberBusinessRepetitionsUsed", "GetGuarantorPhoneNumberBusiness");
        }

        /// <summary>
        /// Add a new GuarantorPhoneNumberBusiness to GT1
        /// </summary>
        public static TN AddGuarantorPhoneNumberBusiness(this GT1 message)
        {
            return message.GetGuarantorPhoneNumberBusiness(message.GuarantorPhoneNumberBusinessRepetitionsUsed);
        }

        /// <summary>
        /// Get GuarantorEmployPhoneNumber Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployPhoneNumberRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployPhoneNumberRepetitionsUsed", "GetGuarantorEmployPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployPhoneNumber Records from GT1
        /// </summary>
        public static List<TN> GetAllGuarantorEmployPhoneNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<TN>("GuarantorEmployPhoneNumberRepetitionsUsed", "GetGuarantorEmployPhoneNumber");
        }

        /// <summary>
        /// Add a new GuarantorEmployPhoneNumber to GT1
        /// </summary>
        public static TN AddGuarantorEmployPhoneNumber(this GT1 message)
        {
            return message.GetGuarantorEmployPhoneNumber(message.GuarantorEmployPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get InsuranceCompanyPhoneNumber Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCompanyPhoneNumberRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCompanyPhoneNumberRepetitionsUsed", "GetInsuranceCompanyPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCompanyPhoneNumber Records from IN1
        /// </summary>
        public static List<TN> GetAllInsuranceCompanyPhoneNumberRecords(this IN1 message)
        {
            return message.GetAllRecords<TN>("InsuranceCompanyPhoneNumberRepetitionsUsed", "GetInsuranceCompanyPhoneNumber");
        }

        /// <summary>
        /// Add a new InsuranceCompanyPhoneNumber to IN1
        /// </summary>
        public static TN AddInsuranceCompanyPhoneNumber(this IN1 message)
        {
            return message.GetInsuranceCompanyPhoneNumber(message.InsuranceCompanyPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get NonCoveredInsuranceCode Records from IN2
        /// </summary>
        public static IEnumerable GetNonCoveredInsuranceCodeRecords(this IN2 message)
        {
            object[] result = message.GetRecords("NonCoveredInsuranceCodeRepetitionsUsed", "GetNonCoveredInsuranceCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NonCoveredInsuranceCode Records from IN2
        /// </summary>
        public static List<ID> GetAllNonCoveredInsuranceCodeRecords(this IN2 message)
        {
            return message.GetAllRecords<ID>("NonCoveredInsuranceCodeRepetitionsUsed", "GetNonCoveredInsuranceCode");
        }

        /// <summary>
        /// Add a new NonCoveredInsuranceCode to IN2
        /// </summary>
        public static ID AddNonCoveredInsuranceCode(this IN2 message)
        {
            return message.GetNonCoveredInsuranceCode(message.NonCoveredInsuranceCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get RoomCoverageTypeAmount Records from IN2
        /// </summary>
        public static IEnumerable GetRoomCoverageTypeAmountRecords(this IN2 message)
        {
            object[] result = message.GetRecords("RoomCoverageTypeAmountRepetitionsUsed", "GetRoomCoverageTypeAmount");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RoomCoverageTypeAmount Records from IN2
        /// </summary>
        public static List<CM_RMC> GetAllRoomCoverageTypeAmountRecords(this IN2 message)
        {
            return message.GetAllRecords<CM_RMC>("RoomCoverageTypeAmountRepetitionsUsed", "GetRoomCoverageTypeAmount");
        }

        /// <summary>
        /// Add a new RoomCoverageTypeAmount to IN2
        /// </summary>
        public static CM_RMC AddRoomCoverageTypeAmount(this IN2 message)
        {
            return message.GetRoomCoverageTypeAmount(message.RoomCoverageTypeAmountRepetitionsUsed);
        }

        /// <summary>
        /// Get PolicyTypeAmount Records from IN2
        /// </summary>
        public static IEnumerable GetPolicyTypeAmountRecords(this IN2 message)
        {
            object[] result = message.GetRecords("PolicyTypeAmountRepetitionsUsed", "GetPolicyTypeAmount");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PolicyTypeAmount Records from IN2
        /// </summary>
        public static List<CM_PTA> GetAllPolicyTypeAmountRecords(this IN2 message)
        {
            return message.GetAllRecords<CM_PTA>("PolicyTypeAmountRepetitionsUsed", "GetPolicyTypeAmount");
        }

        /// <summary>
        /// Add a new PolicyTypeAmount to IN2
        /// </summary>
        public static CM_PTA AddPolicyTypeAmount(this IN2 message)
        {
            return message.GetPolicyTypeAmount(message.PolicyTypeAmountRepetitionsUsed);
        }

        /// <summary>
        /// Get CertificationContactPhoneNumber Records from IN3
        /// </summary>
        public static IEnumerable GetCertificationContactPhoneNumberRecords(this IN3 message)
        {
            object[] result = message.GetRecords("CertificationContactPhoneNumberRepetitionsUsed", "GetCertificationContactPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CertificationContactPhoneNumber Records from IN3
        /// </summary>
        public static List<TN> GetAllCertificationContactPhoneNumberRecords(this IN3 message)
        {
            return message.GetAllRecords<TN>("CertificationContactPhoneNumberRepetitionsUsed", "GetCertificationContactPhoneNumber");
        }

        /// <summary>
        /// Add a new CertificationContactPhoneNumber to IN3
        /// </summary>
        public static TN AddCertificationContactPhoneNumber(this IN3 message)
        {
            return message.GetCertificationContactPhoneNumber(message.CertificationContactPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get CertificationAgencyPhoneNumber Records from IN3
        /// </summary>
        public static IEnumerable GetCertificationAgencyPhoneNumberRecords(this IN3 message)
        {
            object[] result = message.GetRecords("CertificationAgencyPhoneNumberRepetitionsUsed", "GetCertificationAgencyPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CertificationAgencyPhoneNumber Records from IN3
        /// </summary>
        public static List<TN> GetAllCertificationAgencyPhoneNumberRecords(this IN3 message)
        {
            return message.GetAllRecords<TN>("CertificationAgencyPhoneNumberRepetitionsUsed", "GetCertificationAgencyPhoneNumber");
        }

        /// <summary>
        /// Add a new CertificationAgencyPhoneNumber to IN3
        /// </summary>
        public static TN AddCertificationAgencyPhoneNumber(this IN3 message)
        {
            return message.GetCertificationAgencyPhoneNumber(message.CertificationAgencyPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get PreCertificationRequiredWindow Records from IN3
        /// </summary>
        public static IEnumerable GetPreCertificationRequiredWindowRecords(this IN3 message)
        {
            object[] result = message.GetRecords("PreCertificationRequiredWindowRepetitionsUsed", "GetPreCertificationRequiredWindow");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PreCertificationRequiredWindow Records from IN3
        /// </summary>
        public static List<CM_PCF> GetAllPreCertificationRequiredWindowRecords(this IN3 message)
        {
            return message.GetAllRecords<CM_PCF>("PreCertificationRequiredWindowRepetitionsUsed", "GetPreCertificationRequiredWindow");
        }

        /// <summary>
        /// Add a new PreCertificationRequiredWindow to IN3
        /// </summary>
        public static CM_PCF AddPreCertificationRequiredWindow(this IN3 message)
        {
            return message.GetPreCertificationRequiredWindow(message.PreCertificationRequiredWindowRepetitionsUsed);
        }

        /// <summary>
        /// Get PrimaryKeyValue Records from MFA
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueRecords(this MFA message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueRepetitionsUsed", "GetPrimaryKeyValue");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValue Records from MFA
        /// </summary>
        public static List<CE> GetAllPrimaryKeyValueRecords(this MFA message)
        {
            return message.GetAllRecords<CE>("PrimaryKeyValueRepetitionsUsed", "GetPrimaryKeyValue");
        }

        /// <summary>
        /// Add a new PrimaryKeyValue to MFA
        /// </summary>
        public static CE AddPrimaryKeyValue(this MFA message)
        {
            return message.GetPrimaryKeyValue(message.PrimaryKeyValueRepetitionsUsed);
        }

        /// <summary>
        /// Get PrimaryKeyValue Records from MFE
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueRecords(this MFE message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueRepetitionsUsed", "GetPrimaryKeyValue");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValue Records from MFE
        /// </summary>
        public static List<CE> GetAllPrimaryKeyValueRecords(this MFE message)
        {
            return message.GetAllRecords<CE>("PrimaryKeyValueRepetitionsUsed", "GetPrimaryKeyValue");
        }

        /// <summary>
        /// Add a new PrimaryKeyValue to MFE
        /// </summary>
        public static CE AddPrimaryKeyValue(this MFE message)
        {
            return message.GetPrimaryKeyValue(message.PrimaryKeyValueRepetitionsUsed);
        }

        /// <summary>
        /// Get PhoneNumber Records from NK1
        /// </summary>
        public static IEnumerable GetPhoneNumberRecords(this NK1 message)
        {
            object[] result = message.GetRecords("PhoneNumberRepetitionsUsed", "GetPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PhoneNumber Records from NK1
        /// </summary>
        public static List<TN> GetAllPhoneNumberRecords(this NK1 message)
        {
            return message.GetAllRecords<TN>("PhoneNumberRepetitionsUsed", "GetPhoneNumber");
        }

        /// <summary>
        /// Add a new PhoneNumber to NK1
        /// </summary>
        public static TN AddPhoneNumber(this NK1 message)
        {
            return message.GetPhoneNumber(message.PhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get Comment Records from NTE
        /// </summary>
        public static IEnumerable GetCommentRecords(this NTE message)
        {
            object[] result = message.GetRecords("CommentRepetitionsUsed", "GetComment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Comment Records from NTE
        /// </summary>
        public static List<FT> GetAllCommentRecords(this NTE message)
        {
            return message.GetAllRecords<FT>("CommentRepetitionsUsed", "GetComment");
        }

        /// <summary>
        /// Add a new Comment to NTE
        /// </summary>
        public static FT AddComment(this NTE message)
        {
            return message.GetComment(message.CommentRepetitionsUsed);
        }

        /// <summary>
        /// Get CollectorIdentifier Records from OBR
        /// </summary>
        public static IEnumerable GetCollectorIdentifierRecords(this OBR message)
        {
            object[] result = message.GetRecords("CollectorIdentifierRepetitionsUsed", "GetCollectorIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CollectorIdentifier Records from OBR
        /// </summary>
        public static List<CN_PERSON> GetAllCollectorIdentifierRecords(this OBR message)
        {
            return message.GetAllRecords<CN_PERSON>("CollectorIdentifierRepetitionsUsed", "GetCollectorIdentifier");
        }

        /// <summary>
        /// Add a new CollectorIdentifier to OBR
        /// </summary>
        public static CN_PERSON AddCollectorIdentifier(this OBR message)
        {
            return message.GetCollectorIdentifier(message.CollectorIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Get OrderCallbackPhoneNumber Records from OBR
        /// </summary>
        public static IEnumerable GetOrderCallbackPhoneNumberRecords(this OBR message)
        {
            object[] result = message.GetRecords("OrderCallbackPhoneNumberRepetitionsUsed", "GetOrderCallbackPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderCallbackPhoneNumber Records from OBR
        /// </summary>
        public static List<TN> GetAllOrderCallbackPhoneNumberRecords(this OBR message)
        {
            return message.GetAllRecords<TN>("OrderCallbackPhoneNumberRepetitionsUsed", "GetOrderCallbackPhoneNumber");
        }

        /// <summary>
        /// Add a new OrderCallbackPhoneNumber to OBR
        /// </summary>
        public static TN AddOrderCallbackPhoneNumber(this OBR message)
        {
            return message.GetOrderCallbackPhoneNumber(message.OrderCallbackPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get QuantityTiming Records from OBR
        /// </summary>
        public static IEnumerable GetQuantityTimingRecords(this OBR message)
        {
            object[] result = message.GetRecords("QuantityTimingRepetitionsUsed", "GetQuantityTiming");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QuantityTiming Records from OBR
        /// </summary>
        public static List<TQ> GetAllQuantityTimingRecords(this OBR message)
        {
            return message.GetAllRecords<TQ>("QuantityTimingRepetitionsUsed", "GetQuantityTiming");
        }

        /// <summary>
        /// Add a new QuantityTiming to OBR
        /// </summary>
        public static TQ AddQuantityTiming(this OBR message)
        {
            return message.GetQuantityTiming(message.QuantityTimingRepetitionsUsed);
        }

        /// <summary>
        /// Get ResultCopiesTo Records from OBR
        /// </summary>
        public static IEnumerable GetResultCopiesToRecords(this OBR message)
        {
            object[] result = message.GetRecords("ResultCopiesToRepetitionsUsed", "GetResultCopiesTo");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ResultCopiesTo Records from OBR
        /// </summary>
        public static List<CN_PERSON> GetAllResultCopiesToRecords(this OBR message)
        {
            return message.GetAllRecords<CN_PERSON>("ResultCopiesToRepetitionsUsed", "GetResultCopiesTo");
        }

        /// <summary>
        /// Add a new ResultCopiesTo to OBR
        /// </summary>
        public static CN_PERSON AddResultCopiesTo(this OBR message)
        {
            return message.GetResultCopiesTo(message.ResultCopiesToRepetitionsUsed);
        }

        /// <summary>
        /// Get ReasonForStudy Records from OBR
        /// </summary>
        public static IEnumerable GetReasonForStudyRecords(this OBR message)
        {
            object[] result = message.GetRecords("ReasonForStudyRepetitionsUsed", "GetReasonForStudy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReasonForStudy Records from OBR
        /// </summary>
        public static List<CE> GetAllReasonForStudyRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("ReasonForStudyRepetitionsUsed", "GetReasonForStudy");
        }

        /// <summary>
        /// Add a new ReasonForStudy to OBR
        /// </summary>
        public static CE AddReasonForStudy(this OBR message)
        {
            return message.GetReasonForStudy(message.ReasonForStudyRepetitionsUsed);
        }

        /// <summary>
        /// Get AssistantResultInterpreter Records from OBR
        /// </summary>
        public static IEnumerable GetAssistantResultInterpreterRecords(this OBR message)
        {
            object[] result = message.GetRecords("AssistantResultInterpreterRepetitionsUsed", "GetAssistantResultInterpreter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AssistantResultInterpreter Records from OBR
        /// </summary>
        public static List<CM_NDL> GetAllAssistantResultInterpreterRecords(this OBR message)
        {
            return message.GetAllRecords<CM_NDL>("AssistantResultInterpreterRepetitionsUsed", "GetAssistantResultInterpreter");
        }

        /// <summary>
        /// Add a new AssistantResultInterpreter to OBR
        /// </summary>
        public static CM_NDL AddAssistantResultInterpreter(this OBR message)
        {
            return message.GetAssistantResultInterpreter(message.AssistantResultInterpreterRepetitionsUsed);
        }

        /// <summary>
        /// Get Technician Records from OBR
        /// </summary>
        public static IEnumerable GetTechnicianRecords(this OBR message)
        {
            object[] result = message.GetRecords("TechnicianRepetitionsUsed", "GetTechnician");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Technician Records from OBR
        /// </summary>
        public static List<CM_NDL> GetAllTechnicianRecords(this OBR message)
        {
            return message.GetAllRecords<CM_NDL>("TechnicianRepetitionsUsed", "GetTechnician");
        }

        /// <summary>
        /// Add a new Technician to OBR
        /// </summary>
        public static CM_NDL AddTechnician(this OBR message)
        {
            return message.GetTechnician(message.TechnicianRepetitionsUsed);
        }

        /// <summary>
        /// Get Transcriptionist Records from OBR
        /// </summary>
        public static IEnumerable GetTranscriptionistRecords(this OBR message)
        {
            object[] result = message.GetRecords("TranscriptionistRepetitionsUsed", "GetTranscriptionist");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Transcriptionist Records from OBR
        /// </summary>
        public static List<CM_NDL> GetAllTranscriptionistRecords(this OBR message)
        {
            return message.GetAllRecords<CM_NDL>("TranscriptionistRepetitionsUsed", "GetTranscriptionist");
        }

        /// <summary>
        /// Add a new Transcriptionist to OBR
        /// </summary>
        public static CM_NDL AddTranscriptionist(this OBR message)
        {
            return message.GetTranscriptionist(message.TranscriptionistRepetitionsUsed);
        }

        /// <summary>
        /// Get AbnormalFlags Records from OBX
        /// </summary>
        public static IEnumerable GetAbnormalFlagsRecords(this OBX message)
        {
            object[] result = message.GetRecords("AbnormalFlagsRepetitionsUsed", "GetAbnormalFlags");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AbnormalFlags Records from OBX
        /// </summary>
        public static List<ID> GetAllAbnormalFlagsRecords(this OBX message)
        {
            return message.GetAllRecords<ID>("AbnormalFlagsRepetitionsUsed", "GetAbnormalFlags");
        }

        /// <summary>
        /// Add a new AbnormalFlags to OBX
        /// </summary>
        public static ID AddAbnormalFlags(this OBX message)
        {
            return message.GetAbnormalFlags(message.AbnormalFlagsRepetitionsUsed);
        }

        /// <summary>
        /// Get ServicePeriod Records from ODS
        /// </summary>
        public static IEnumerable GetServicePeriodRecords(this ODS message)
        {
            object[] result = message.GetRecords("ServicePeriodRepetitionsUsed", "GetServicePeriod");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ServicePeriod Records from ODS
        /// </summary>
        public static List<CE> GetAllServicePeriodRecords(this ODS message)
        {
            return message.GetAllRecords<CE>("ServicePeriodRepetitionsUsed", "GetServicePeriod");
        }

        /// <summary>
        /// Add a new ServicePeriod to ODS
        /// </summary>
        public static CE AddServicePeriod(this ODS message)
        {
            return message.GetServicePeriod(message.ServicePeriodRepetitionsUsed);
        }

        /// <summary>
        /// Get DietSupplementOrPreferenceCode Records from ODS
        /// </summary>
        public static IEnumerable GetDietSupplementOrPreferenceCodeRecords(this ODS message)
        {
            object[] result = message.GetRecords("DietSupplementOrPreferenceCodeRepetitionsUsed", "GetDietSupplementOrPreferenceCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DietSupplementOrPreferenceCode Records from ODS
        /// </summary>
        public static List<CE> GetAllDietSupplementOrPreferenceCodeRecords(this ODS message)
        {
            return message.GetAllRecords<CE>("DietSupplementOrPreferenceCodeRepetitionsUsed", "GetDietSupplementOrPreferenceCode");
        }

        /// <summary>
        /// Add a new DietSupplementOrPreferenceCode to ODS
        /// </summary>
        public static CE AddDietSupplementOrPreferenceCode(this ODS message)
        {
            return message.GetDietSupplementOrPreferenceCode(message.DietSupplementOrPreferenceCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get TextInstruction Records from ODS
        /// </summary>
        public static IEnumerable GetTextInstructionRecords(this ODS message)
        {
            object[] result = message.GetRecords("TextInstructionRepetitionsUsed", "GetTextInstruction");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TextInstruction Records from ODS
        /// </summary>
        public static List<ST> GetAllTextInstructionRecords(this ODS message)
        {
            return message.GetAllRecords<ST>("TextInstructionRepetitionsUsed", "GetTextInstruction");
        }

        /// <summary>
        /// Add a new TextInstruction to ODS
        /// </summary>
        public static ST AddTextInstruction(this ODS message)
        {
            return message.GetTextInstruction(message.TextInstructionRepetitionsUsed);
        }

        /// <summary>
        /// Get ServicePeriod Records from ODT
        /// </summary>
        public static IEnumerable GetServicePeriodRecords(this ODT message)
        {
            object[] result = message.GetRecords("ServicePeriodRepetitionsUsed", "GetServicePeriod");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ServicePeriod Records from ODT
        /// </summary>
        public static List<CE> GetAllServicePeriodRecords(this ODT message)
        {
            return message.GetAllRecords<CE>("ServicePeriodRepetitionsUsed", "GetServicePeriod");
        }

        /// <summary>
        /// Add a new ServicePeriod to ODT
        /// </summary>
        public static CE AddServicePeriod(this ODT message)
        {
            return message.GetServicePeriod(message.ServicePeriodRepetitionsUsed);
        }

        /// <summary>
        /// Get TextInstruction Records from ODT
        /// </summary>
        public static IEnumerable GetTextInstructionRecords(this ODT message)
        {
            object[] result = message.GetRecords("TextInstructionRepetitionsUsed", "GetTextInstruction");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TextInstruction Records from ODT
        /// </summary>
        public static List<ST> GetAllTextInstructionRecords(this ODT message)
        {
            return message.GetAllRecords<ST>("TextInstructionRepetitionsUsed", "GetTextInstruction");
        }

        /// <summary>
        /// Add a new TextInstruction to ODT
        /// </summary>
        public static ST AddTextInstruction(this ODT message)
        {
            return message.GetTextInstruction(message.TextInstructionRepetitionsUsed);
        }

        /// <summary>
        /// Get PermittedDataTypes Records from OM1
        /// </summary>
        public static IEnumerable GetPermittedDataTypesRecords(this OM1 message)
        {
            object[] result = message.GetRecords("PermittedDataTypesRepetitionsUsed", "GetPermittedDataTypes");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PermittedDataTypes Records from OM1
        /// </summary>
        public static List<ID> GetAllPermittedDataTypesRecords(this OM1 message)
        {
            return message.GetAllRecords<ID>("PermittedDataTypesRepetitionsUsed", "GetPermittedDataTypes");
        }

        /// <summary>
        /// Add a new PermittedDataTypes to OM1
        /// </summary>
        public static ID AddPermittedDataTypes(this OM1 message)
        {
            return message.GetPermittedDataTypes(message.PermittedDataTypesRepetitionsUsed);
        }

        /// <summary>
        /// Get OtherNames Records from OM1
        /// </summary>
        public static IEnumerable GetOtherNamesRecords(this OM1 message)
        {
            object[] result = message.GetRecords("OtherNamesRepetitionsUsed", "GetOtherNames");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherNames Records from OM1
        /// </summary>
        public static List<ST> GetAllOtherNamesRecords(this OM1 message)
        {
            return message.GetAllRecords<ST>("OtherNamesRepetitionsUsed", "GetOtherNames");
        }

        /// <summary>
        /// Add a new OtherNames to OM1
        /// </summary>
        public static ST AddOtherNames(this OM1 message)
        {
            return message.GetOtherNames(message.OtherNamesRepetitionsUsed);
        }

        /// <summary>
        /// Get IdentityOfInstrumentUsedToPerformThisStudy Records from OM1
        /// </summary>
        public static IEnumerable GetIdentityOfInstrumentUsedToPerformThisStudyRecords(this OM1 message)
        {
            object[] result = message.GetRecords("IdentityOfInstrumentUsedToPerformThisStudyRepetitionsUsed", "GetIdentityOfInstrumentUsedToPerformThisStudy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IdentityOfInstrumentUsedToPerformThisStudy Records from OM1
        /// </summary>
        public static List<CE> GetAllIdentityOfInstrumentUsedToPerformThisStudyRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("IdentityOfInstrumentUsedToPerformThisStudyRepetitionsUsed", "GetIdentityOfInstrumentUsedToPerformThisStudy");
        }

        /// <summary>
        /// Add a new IdentityOfInstrumentUsedToPerformThisStudy to OM1
        /// </summary>
        public static CE AddIdentityOfInstrumentUsedToPerformThisStudy(this OM1 message)
        {
            return message.GetIdentityOfInstrumentUsedToPerformThisStudy(message.IdentityOfInstrumentUsedToPerformThisStudyRepetitionsUsed);
        }

        /// <summary>
        /// Get CodedRepresentationOfMethod Records from OM1
        /// </summary>
        public static IEnumerable GetCodedRepresentationOfMethodRecords(this OM1 message)
        {
            object[] result = message.GetRecords("CodedRepresentationOfMethodRepetitionsUsed", "GetCodedRepresentationOfMethod");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CodedRepresentationOfMethod Records from OM1
        /// </summary>
        public static List<CE> GetAllCodedRepresentationOfMethodRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("CodedRepresentationOfMethodRepetitionsUsed", "GetCodedRepresentationOfMethod");
        }

        /// <summary>
        /// Add a new CodedRepresentationOfMethod to OM1
        /// </summary>
        public static CE AddCodedRepresentationOfMethod(this OM1 message)
        {
            return message.GetCodedRepresentationOfMethod(message.CodedRepresentationOfMethodRepetitionsUsed);
        }

        /// <summary>
        /// Get ObservationProducingDepartmentSection Records from OM1
        /// </summary>
        public static IEnumerable GetObservationProducingDepartmentSectionRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ObservationProducingDepartmentSectionRepetitionsUsed", "GetObservationProducingDepartmentSection");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ObservationProducingDepartmentSection Records from OM1
        /// </summary>
        public static List<ID> GetAllObservationProducingDepartmentSectionRecords(this OM1 message)
        {
            return message.GetAllRecords<ID>("ObservationProducingDepartmentSectionRepetitionsUsed", "GetObservationProducingDepartmentSection");
        }

        /// <summary>
        /// Add a new ObservationProducingDepartmentSection to OM1
        /// </summary>
        public static ID AddObservationProducingDepartmentSection(this OM1 message)
        {
            return message.GetObservationProducingDepartmentSection(message.ObservationProducingDepartmentSectionRepetitionsUsed);
        }

        /// <summary>
        /// Get ProcessingPriority Records from OM1
        /// </summary>
        public static IEnumerable GetProcessingPriorityRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ProcessingPriorityRepetitionsUsed", "GetProcessingPriority");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcessingPriority Records from OM1
        /// </summary>
        public static List<ID> GetAllProcessingPriorityRecords(this OM1 message)
        {
            return message.GetAllRecords<ID>("ProcessingPriorityRepetitionsUsed", "GetProcessingPriority");
        }

        /// <summary>
        /// Add a new ProcessingPriority to OM1
        /// </summary>
        public static ID AddProcessingPriority(this OM1 message)
        {
            return message.GetProcessingPriority(message.ProcessingPriorityRepetitionsUsed);
        }

        /// <summary>
        /// Get OutsideSiteSWhereObservationMayBePerformed Records from OM1
        /// </summary>
        public static IEnumerable GetOutsideSiteSWhereObservationMayBePerformedRecords(this OM1 message)
        {
            object[] result = message.GetRecords("OutsideSiteSWhereObservationMayBePerformedRepetitionsUsed", "GetOutsideSiteSWhereObservationMayBePerformed");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OutsideSiteSWhereObservationMayBePerformed Records from OM1
        /// </summary>
        public static List<CE> GetAllOutsideSiteSWhereObservationMayBePerformedRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("OutsideSiteSWhereObservationMayBePerformedRepetitionsUsed", "GetOutsideSiteSWhereObservationMayBePerformed");
        }

        /// <summary>
        /// Add a new OutsideSiteSWhereObservationMayBePerformed to OM1
        /// </summary>
        public static CE AddOutsideSiteSWhereObservationMayBePerformed(this OM1 message)
        {
            return message.GetOutsideSiteSWhereObservationMayBePerformed(message.OutsideSiteSWhereObservationMayBePerformedRepetitionsUsed);
        }

        /// <summary>
        /// Get AddressOfOutsideSiteS Records from OM1
        /// </summary>
        public static IEnumerable GetAddressOfOutsideSiteSRecords(this OM1 message)
        {
            object[] result = message.GetRecords("AddressOfOutsideSiteSRepetitionsUsed", "GetAddressOfOutsideSiteS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AddressOfOutsideSiteS Records from OM1
        /// </summary>
        public static List<AD> GetAllAddressOfOutsideSiteSRecords(this OM1 message)
        {
            return message.GetAllRecords<AD>("AddressOfOutsideSiteSRepetitionsUsed", "GetAddressOfOutsideSiteS");
        }

        /// <summary>
        /// Add a new AddressOfOutsideSiteS to OM1
        /// </summary>
        public static AD AddAddressOfOutsideSiteS(this OM1 message)
        {
            return message.GetAddressOfOutsideSiteS(message.AddressOfOutsideSiteSRepetitionsUsed);
        }

        /// <summary>
        /// Get PhoneNumberOfOutsideSite Records from OM1
        /// </summary>
        public static IEnumerable GetPhoneNumberOfOutsideSiteRecords(this OM1 message)
        {
            object[] result = message.GetRecords("PhoneNumberOfOutsideSiteRepetitionsUsed", "GetPhoneNumberOfOutsideSite");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PhoneNumberOfOutsideSite Records from OM1
        /// </summary>
        public static List<TN> GetAllPhoneNumberOfOutsideSiteRecords(this OM1 message)
        {
            return message.GetAllRecords<TN>("PhoneNumberOfOutsideSiteRepetitionsUsed", "GetPhoneNumberOfOutsideSite");
        }

        /// <summary>
        /// Add a new PhoneNumberOfOutsideSite to OM1
        /// </summary>
        public static TN AddPhoneNumberOfOutsideSite(this OM1 message)
        {
            return message.GetPhoneNumberOfOutsideSite(message.PhoneNumberOfOutsideSiteRepetitionsUsed);
        }

        /// <summary>
        /// Get ObservationsRequiredToInterpretTheObservation Records from OM1
        /// </summary>
        public static IEnumerable GetObservationsRequiredToInterpretTheObservationRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ObservationsRequiredToInterpretTheObservationRepetitionsUsed", "GetObservationsRequiredToInterpretTheObservation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ObservationsRequiredToInterpretTheObservation Records from OM1
        /// </summary>
        public static List<CE> GetAllObservationsRequiredToInterpretTheObservationRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("ObservationsRequiredToInterpretTheObservationRepetitionsUsed", "GetObservationsRequiredToInterpretTheObservation");
        }

        /// <summary>
        /// Add a new ObservationsRequiredToInterpretTheObservation to OM1
        /// </summary>
        public static CE AddObservationsRequiredToInterpretTheObservation(this OM1 message)
        {
            return message.GetObservationsRequiredToInterpretTheObservation(message.ObservationsRequiredToInterpretTheObservationRepetitionsUsed);
        }

        /// <summary>
        /// Get ContraindicationsToObservations Records from OM1
        /// </summary>
        public static IEnumerable GetContraindicationsToObservationsRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ContraindicationsToObservationsRepetitionsUsed", "GetContraindicationsToObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContraindicationsToObservations Records from OM1
        /// </summary>
        public static List<CE> GetAllContraindicationsToObservationsRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("ContraindicationsToObservationsRepetitionsUsed", "GetContraindicationsToObservations");
        }

        /// <summary>
        /// Add a new ContraindicationsToObservations to OM1
        /// </summary>
        public static CE AddContraindicationsToObservations(this OM1 message)
        {
            return message.GetContraindicationsToObservations(message.ContraindicationsToObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Get ReflexTestsObservations Records from OM1
        /// </summary>
        public static IEnumerable GetReflexTestsObservationsRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ReflexTestsObservationsRepetitionsUsed", "GetReflexTestsObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReflexTestsObservations Records from OM1
        /// </summary>
        public static List<CE> GetAllReflexTestsObservationsRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("ReflexTestsObservationsRepetitionsUsed", "GetReflexTestsObservations");
        }

        /// <summary>
        /// Add a new ReflexTestsObservations to OM1
        /// </summary>
        public static CE AddReflexTestsObservations(this OM1 message)
        {
            return message.GetReflexTestsObservations(message.ReflexTestsObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Get FixedCannedMessage Records from OM1
        /// </summary>
        public static IEnumerable GetFixedCannedMessageRecords(this OM1 message)
        {
            object[] result = message.GetRecords("FixedCannedMessageRepetitionsUsed", "GetFixedCannedMessage");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FixedCannedMessage Records from OM1
        /// </summary>
        public static List<CE> GetAllFixedCannedMessageRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("FixedCannedMessageRepetitionsUsed", "GetFixedCannedMessage");
        }

        /// <summary>
        /// Add a new FixedCannedMessage to OM1
        /// </summary>
        public static CE AddFixedCannedMessage(this OM1 message)
        {
            return message.GetFixedCannedMessage(message.FixedCannedMessageRepetitionsUsed);
        }

        /// <summary>
        /// Get TestObservationPerformanceSchedule Records from OM1
        /// </summary>
        public static IEnumerable GetTestObservationPerformanceScheduleRecords(this OM1 message)
        {
            object[] result = message.GetRecords("TestObservationPerformanceScheduleRepetitionsUsed", "GetTestObservationPerformanceSchedule");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TestObservationPerformanceSchedule Records from OM1
        /// </summary>
        public static List<ST> GetAllTestObservationPerformanceScheduleRecords(this OM1 message)
        {
            return message.GetAllRecords<ST>("TestObservationPerformanceScheduleRepetitionsUsed", "GetTestObservationPerformanceSchedule");
        }

        /// <summary>
        /// Add a new TestObservationPerformanceSchedule to OM1
        /// </summary>
        public static ST AddTestObservationPerformanceSchedule(this OM1 message)
        {
            return message.GetTestObservationPerformanceSchedule(message.TestObservationPerformanceScheduleRepetitionsUsed);
        }

        /// <summary>
        /// Get SIConversionFactor Records from OM2
        /// </summary>
        public static IEnumerable GetSIConversionFactorRecords(this OM2 message)
        {
            object[] result = message.GetRecords("SIConversionFactorRepetitionsUsed", "GetSIConversionFactor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SIConversionFactor Records from OM2
        /// </summary>
        public static List<TX> GetAllSIConversionFactorRecords(this OM2 message)
        {
            return message.GetAllRecords<TX>("SIConversionFactorRepetitionsUsed", "GetSIConversionFactor");
        }

        /// <summary>
        /// Add a new SIConversionFactor to OM2
        /// </summary>
        public static TX AddSIConversionFactor(this OM2 message)
        {
            return message.GetSIConversionFactor(message.SIConversionFactorRepetitionsUsed);
        }

        /// <summary>
        /// Get ReferenceNormalRangeOrdinalContinuousObservations Records from OM2
        /// </summary>
        public static IEnumerable GetReferenceNormalRangeOrdinalContinuousObservationsRecords(this OM2 message)
        {
            object[] result = message.GetRecords("ReferenceNormalRangeOrdinalContinuousObservationsRepetitionsUsed", "GetReferenceNormalRangeOrdinalContinuousObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferenceNormalRangeOrdinalContinuousObservations Records from OM2
        /// </summary>
        public static List<CM_RFR> GetAllReferenceNormalRangeOrdinalContinuousObservationsRecords(this OM2 message)
        {
            return message.GetAllRecords<CM_RFR>("ReferenceNormalRangeOrdinalContinuousObservationsRepetitionsUsed", "GetReferenceNormalRangeOrdinalContinuousObservations");
        }

        /// <summary>
        /// Add a new ReferenceNormalRangeOrdinalContinuousObservations to OM2
        /// </summary>
        public static CM_RFR AddReferenceNormalRangeOrdinalContinuousObservations(this OM2 message)
        {
            return message.GetReferenceNormalRangeOrdinalContinuousObservations(message.ReferenceNormalRangeOrdinalContinuousObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Get DeltaCheckCriteria Records from OM2
        /// </summary>
        public static IEnumerable GetDeltaCheckCriteriaRecords(this OM2 message)
        {
            object[] result = message.GetRecords("DeltaCheckCriteriaRepetitionsUsed", "GetDeltaCheckCriteria");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DeltaCheckCriteria Records from OM2
        /// </summary>
        public static List<CM_DLT> GetAllDeltaCheckCriteriaRecords(this OM2 message)
        {
            return message.GetAllRecords<CM_DLT>("DeltaCheckCriteriaRepetitionsUsed", "GetDeltaCheckCriteria");
        }

        /// <summary>
        /// Add a new DeltaCheckCriteria to OM2
        /// </summary>
        public static CM_DLT AddDeltaCheckCriteria(this OM2 message)
        {
            return message.GetDeltaCheckCriteria(message.DeltaCheckCriteriaRepetitionsUsed);
        }

        /// <summary>
        /// Get ValidCodedAnswers Records from OM3
        /// </summary>
        public static IEnumerable GetValidCodedAnswersRecords(this OM3 message)
        {
            object[] result = message.GetRecords("ValidCodedAnswersRepetitionsUsed", "GetValidCodedAnswers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValidCodedAnswers Records from OM3
        /// </summary>
        public static List<CE> GetAllValidCodedAnswersRecords(this OM3 message)
        {
            return message.GetAllRecords<CE>("ValidCodedAnswersRepetitionsUsed", "GetValidCodedAnswers");
        }

        /// <summary>
        /// Add a new ValidCodedAnswers to OM3
        /// </summary>
        public static CE AddValidCodedAnswers(this OM3 message)
        {
            return message.GetValidCodedAnswers(message.ValidCodedAnswersRepetitionsUsed);
        }

        /// <summary>
        /// Get NormalTestCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static IEnumerable GetNormalTestCodesForCategoricalObservationsRecords(this OM3 message)
        {
            object[] result = message.GetRecords("NormalTestCodesForCategoricalObservationsRepetitionsUsed", "GetNormalTestCodesForCategoricalObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NormalTestCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static List<CE> GetAllNormalTestCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CE>("NormalTestCodesForCategoricalObservationsRepetitionsUsed", "GetNormalTestCodesForCategoricalObservations");
        }

        /// <summary>
        /// Add a new NormalTestCodesForCategoricalObservations to OM3
        /// </summary>
        public static CE AddNormalTestCodesForCategoricalObservations(this OM3 message)
        {
            return message.GetNormalTestCodesForCategoricalObservations(message.NormalTestCodesForCategoricalObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Get SpecimenPriorities Records from OM4
        /// </summary>
        public static IEnumerable GetSpecimenPrioritiesRecords(this OM4 message)
        {
            object[] result = message.GetRecords("SpecimenPrioritiesRepetitionsUsed", "GetSpecimenPriorities");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenPriorities Records from OM4
        /// </summary>
        public static List<ID> GetAllSpecimenPrioritiesRecords(this OM4 message)
        {
            return message.GetAllRecords<ID>("SpecimenPrioritiesRepetitionsUsed", "GetSpecimenPriorities");
        }

        /// <summary>
        /// Add a new SpecimenPriorities to OM4
        /// </summary>
        public static ID AddSpecimenPriorities(this OM4 message)
        {
            return message.GetSpecimenPriorities(message.SpecimenPrioritiesRepetitionsUsed);
        }

        /// <summary>
        /// Get TestsObservationsIncludedWithinAnOrderedTestBattery Records from OM5
        /// </summary>
        public static IEnumerable GetTestsObservationsIncludedWithinAnOrderedTestBatteryRecords(this OM5 message)
        {
            object[] result = message.GetRecords("TestsObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed", "GetTestsObservationsIncludedWithinAnOrderedTestBattery");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TestsObservationsIncludedWithinAnOrderedTestBattery Records from OM5
        /// </summary>
        public static List<CE> GetAllTestsObservationsIncludedWithinAnOrderedTestBatteryRecords(this OM5 message)
        {
            return message.GetAllRecords<CE>("TestsObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed", "GetTestsObservationsIncludedWithinAnOrderedTestBattery");
        }

        /// <summary>
        /// Add a new TestsObservationsIncludedWithinAnOrderedTestBattery to OM5
        /// </summary>
        public static CE AddTestsObservationsIncludedWithinAnOrderedTestBattery(this OM5 message)
        {
            return message.GetTestsObservationsIncludedWithinAnOrderedTestBattery(message.TestsObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed);
        }

        /// <summary>
        /// Get QuantityTiming Records from ORC
        /// </summary>
        public static IEnumerable GetQuantityTimingRecords(this ORC message)
        {
            object[] result = message.GetRecords("QuantityTimingRepetitionsUsed", "GetQuantityTiming");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QuantityTiming Records from ORC
        /// </summary>
        public static List<TQ> GetAllQuantityTimingRecords(this ORC message)
        {
            return message.GetAllRecords<TQ>("QuantityTimingRepetitionsUsed", "GetQuantityTiming");
        }

        /// <summary>
        /// Add a new QuantityTiming to ORC
        /// </summary>
        public static TQ AddQuantityTiming(this ORC message)
        {
            return message.GetQuantityTiming(message.QuantityTimingRepetitionsUsed);
        }

        /// <summary>
        /// Get CallBackPhoneNumber Records from ORC
        /// </summary>
        public static IEnumerable GetCallBackPhoneNumberRecords(this ORC message)
        {
            object[] result = message.GetRecords("CallBackPhoneNumberRepetitionsUsed", "GetCallBackPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CallBackPhoneNumber Records from ORC
        /// </summary>
        public static List<TN> GetAllCallBackPhoneNumberRecords(this ORC message)
        {
            return message.GetAllRecords<TN>("CallBackPhoneNumberRepetitionsUsed", "GetCallBackPhoneNumber");
        }

        /// <summary>
        /// Add a new CallBackPhoneNumber to ORC
        /// </summary>
        public static TN AddCallBackPhoneNumber(this ORC message)
        {
            return message.GetCallBackPhoneNumber(message.CallBackPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get PatientIDInternalID Records from PID
        /// </summary>
        public static IEnumerable GetPatientIDInternalIDRecords(this PID message)
        {
            object[] result = message.GetRecords("PatientIDInternalIDRepetitionsUsed", "GetPatientIDInternalID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientIDInternalID Records from PID
        /// </summary>
        public static List<CM_PAT_ID> GetAllPatientIDInternalIDRecords(this PID message)
        {
            return message.GetAllRecords<CM_PAT_ID>("PatientIDInternalIDRepetitionsUsed", "GetPatientIDInternalID");
        }

        /// <summary>
        /// Add a new PatientIDInternalID to PID
        /// </summary>
        public static CM_PAT_ID AddPatientIDInternalID(this PID message)
        {
            return message.GetPatientIDInternalID(message.PatientIDInternalIDRepetitionsUsed);
        }

        /// <summary>
        /// Get PatientAlias Records from PID
        /// </summary>
        public static IEnumerable GetPatientAliasRecords(this PID message)
        {
            object[] result = message.GetRecords("PatientAliasRepetitionsUsed", "GetPatientAlias");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientAlias Records from PID
        /// </summary>
        public static List<PN> GetAllPatientAliasRecords(this PID message)
        {
            return message.GetAllRecords<PN>("PatientAliasRepetitionsUsed", "GetPatientAlias");
        }

        /// <summary>
        /// Add a new PatientAlias to PID
        /// </summary>
        public static PN AddPatientAlias(this PID message)
        {
            return message.GetPatientAlias(message.PatientAliasRepetitionsUsed);
        }

        /// <summary>
        /// Get PatientAddress Records from PID
        /// </summary>
        public static IEnumerable GetPatientAddressRecords(this PID message)
        {
            object[] result = message.GetRecords("PatientAddressRepetitionsUsed", "GetPatientAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientAddress Records from PID
        /// </summary>
        public static List<AD> GetAllPatientAddressRecords(this PID message)
        {
            return message.GetAllRecords<AD>("PatientAddressRepetitionsUsed", "GetPatientAddress");
        }

        /// <summary>
        /// Add a new PatientAddress to PID
        /// </summary>
        public static AD AddPatientAddress(this PID message)
        {
            return message.GetPatientAddress(message.PatientAddressRepetitionsUsed);
        }

        /// <summary>
        /// Get PhoneNumberHome Records from PID
        /// </summary>
        public static IEnumerable GetPhoneNumberHomeRecords(this PID message)
        {
            object[] result = message.GetRecords("PhoneNumberHomeRepetitionsUsed", "GetPhoneNumberHome");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PhoneNumberHome Records from PID
        /// </summary>
        public static List<TN> GetAllPhoneNumberHomeRecords(this PID message)
        {
            return message.GetAllRecords<TN>("PhoneNumberHomeRepetitionsUsed", "GetPhoneNumberHome");
        }

        /// <summary>
        /// Add a new PhoneNumberHome to PID
        /// </summary>
        public static TN AddPhoneNumberHome(this PID message)
        {
            return message.GetPhoneNumberHome(message.PhoneNumberHomeRepetitionsUsed);
        }

        /// <summary>
        /// Get PhoneNumberBusiness Records from PID
        /// </summary>
        public static IEnumerable GetPhoneNumberBusinessRecords(this PID message)
        {
            object[] result = message.GetRecords("PhoneNumberBusinessRepetitionsUsed", "GetPhoneNumberBusiness");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PhoneNumberBusiness Records from PID
        /// </summary>
        public static List<TN> GetAllPhoneNumberBusinessRecords(this PID message)
        {
            return message.GetAllRecords<TN>("PhoneNumberBusinessRepetitionsUsed", "GetPhoneNumberBusiness");
        }

        /// <summary>
        /// Add a new PhoneNumberBusiness to PID
        /// </summary>
        public static TN AddPhoneNumberBusiness(this PID message)
        {
            return message.GetPhoneNumberBusiness(message.PhoneNumberBusinessRepetitionsUsed);
        }

        /// <summary>
        /// Get Citizenship Records from PID
        /// </summary>
        public static IEnumerable GetCitizenshipRecords(this PID message)
        {
            object[] result = message.GetRecords("CitizenshipRepetitionsUsed", "GetCitizenship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Citizenship Records from PID
        /// </summary>
        public static List<ID> GetAllCitizenshipRecords(this PID message)
        {
            return message.GetAllRecords<ID>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to PID
        /// </summary>
        public static ID AddCitizenship(this PID message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Get ProcedureCodingMethod Records from PR1
        /// </summary>
        public static IEnumerable GetProcedureCodingMethodRecords(this PR1 message)
        {
            object[] result = message.GetRecords("ProcedureCodingMethodRepetitionsUsed", "GetProcedureCodingMethod");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCodingMethod Records from PR1
        /// </summary>
        public static List<ID> GetAllProcedureCodingMethodRecords(this PR1 message)
        {
            return message.GetAllRecords<ID>("ProcedureCodingMethodRepetitionsUsed", "GetProcedureCodingMethod");
        }

        /// <summary>
        /// Add a new ProcedureCodingMethod to PR1
        /// </summary>
        public static ID AddProcedureCodingMethod(this PR1 message)
        {
            return message.GetProcedureCodingMethod(message.ProcedureCodingMethodRepetitionsUsed);
        }

        /// <summary>
        /// Get ProcedureCode Records from PR1
        /// </summary>
        public static IEnumerable GetProcedureCodeRecords(this PR1 message)
        {
            object[] result = message.GetRecords("ProcedureCodeRepetitionsUsed", "GetProcedureCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCode Records from PR1
        /// </summary>
        public static List<ID> GetAllProcedureCodeRecords(this PR1 message)
        {
            return message.GetAllRecords<ID>("ProcedureCodeRepetitionsUsed", "GetProcedureCode");
        }

        /// <summary>
        /// Add a new ProcedureCode to PR1
        /// </summary>
        public static ID AddProcedureCode(this PR1 message)
        {
            return message.GetProcedureCode(message.ProcedureCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get ProcedureDescription Records from PR1
        /// </summary>
        public static IEnumerable GetProcedureDescriptionRecords(this PR1 message)
        {
            object[] result = message.GetRecords("ProcedureDescriptionRepetitionsUsed", "GetProcedureDescription");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureDescription Records from PR1
        /// </summary>
        public static List<ST> GetAllProcedureDescriptionRecords(this PR1 message)
        {
            return message.GetAllRecords<ST>("ProcedureDescriptionRepetitionsUsed", "GetProcedureDescription");
        }

        /// <summary>
        /// Add a new ProcedureDescription to PR1
        /// </summary>
        public static ST AddProcedureDescription(this PR1 message)
        {
            return message.GetProcedureDescription(message.ProcedureDescriptionRepetitionsUsed);
        }

        /// <summary>
        /// Get ProcedurePractitioner Records from PR1
        /// </summary>
        public static IEnumerable GetProcedurePractitionerRecords(this PR1 message)
        {
            object[] result = message.GetRecords("ProcedurePractitionerRepetitionsUsed", "GetProcedurePractitioner");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedurePractitioner Records from PR1
        /// </summary>
        public static List<CM_PRACTITIONER> GetAllProcedurePractitionerRecords(this PR1 message)
        {
            return message.GetAllRecords<CM_PRACTITIONER>("ProcedurePractitionerRepetitionsUsed", "GetProcedurePractitioner");
        }

        /// <summary>
        /// Add a new ProcedurePractitioner to PR1
        /// </summary>
        public static CM_PRACTITIONER AddProcedurePractitioner(this PR1 message)
        {
            return message.GetProcedurePractitioner(message.ProcedurePractitionerRepetitionsUsed);
        }

        /// <summary>
        /// Get PractitionerGroup Records from PRA
        /// </summary>
        public static IEnumerable GetPractitionerGroupRecords(this PRA message)
        {
            object[] result = message.GetRecords("PractitionerGroupRepetitionsUsed", "GetPractitionerGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PractitionerGroup Records from PRA
        /// </summary>
        public static List<CE> GetAllPractitionerGroupRecords(this PRA message)
        {
            return message.GetAllRecords<CE>("PractitionerGroupRepetitionsUsed", "GetPractitionerGroup");
        }

        /// <summary>
        /// Add a new PractitionerGroup to PRA
        /// </summary>
        public static CE AddPractitionerGroup(this PRA message)
        {
            return message.GetPractitionerGroup(message.PractitionerGroupRepetitionsUsed);
        }

        /// <summary>
        /// Get PractitionerCategory Records from PRA
        /// </summary>
        public static IEnumerable GetPractitionerCategoryRecords(this PRA message)
        {
            object[] result = message.GetRecords("PractitionerCategoryRepetitionsUsed", "GetPractitionerCategory");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PractitionerCategory Records from PRA
        /// </summary>
        public static List<ID> GetAllPractitionerCategoryRecords(this PRA message)
        {
            return message.GetAllRecords<ID>("PractitionerCategoryRepetitionsUsed", "GetPractitionerCategory");
        }

        /// <summary>
        /// Add a new PractitionerCategory to PRA
        /// </summary>
        public static ID AddPractitionerCategory(this PRA message)
        {
            return message.GetPractitionerCategory(message.PractitionerCategoryRepetitionsUsed);
        }

        /// <summary>
        /// Get Specialty Records from PRA
        /// </summary>
        public static IEnumerable GetSpecialtyRecords(this PRA message)
        {
            object[] result = message.GetRecords("SpecialtyRepetitionsUsed", "GetSpecialty");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Specialty Records from PRA
        /// </summary>
        public static List<CM_SPD> GetAllSpecialtyRecords(this PRA message)
        {
            return message.GetAllRecords<CM_SPD>("SpecialtyRepetitionsUsed", "GetSpecialty");
        }

        /// <summary>
        /// Add a new Specialty to PRA
        /// </summary>
        public static CM_SPD AddSpecialty(this PRA message)
        {
            return message.GetSpecialty(message.SpecialtyRepetitionsUsed);
        }

        /// <summary>
        /// Get PractitionerIDNumbers Records from PRA
        /// </summary>
        public static IEnumerable GetPractitionerIDNumbersRecords(this PRA message)
        {
            object[] result = message.GetRecords("PractitionerIDNumbersRepetitionsUsed", "GetPractitionerIDNumbers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PractitionerIDNumbers Records from PRA
        /// </summary>
        public static List<CM_PLN> GetAllPractitionerIDNumbersRecords(this PRA message)
        {
            return message.GetAllRecords<CM_PLN>("PractitionerIDNumbersRepetitionsUsed", "GetPractitionerIDNumbers");
        }

        /// <summary>
        /// Add a new PractitionerIDNumbers to PRA
        /// </summary>
        public static CM_PLN AddPractitionerIDNumbers(this PRA message)
        {
            return message.GetPractitionerIDNumbers(message.PractitionerIDNumbersRepetitionsUsed);
        }

        /// <summary>
        /// Get Privileges Records from PRA
        /// </summary>
        public static IEnumerable GetPrivilegesRecords(this PRA message)
        {
            object[] result = message.GetRecords("PrivilegesRepetitionsUsed", "GetPrivileges");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Privileges Records from PRA
        /// </summary>
        public static List<CM_PIP> GetAllPrivilegesRecords(this PRA message)
        {
            return message.GetAllRecords<CM_PIP>("PrivilegesRepetitionsUsed", "GetPrivileges");
        }

        /// <summary>
        /// Add a new Privileges to PRA
        /// </summary>
        public static CM_PIP AddPrivileges(this PRA message)
        {
            return message.GetPrivileges(message.PrivilegesRepetitionsUsed);
        }

        /// <summary>
        /// Get ConsultingDoctor Records from PV1
        /// </summary>
        public static IEnumerable GetConsultingDoctorRecords(this PV1 message)
        {
            object[] result = message.GetRecords("ConsultingDoctorRepetitionsUsed", "GetConsultingDoctor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConsultingDoctor Records from PV1
        /// </summary>
        public static List<CN_PHYSICIAN> GetAllConsultingDoctorRecords(this PV1 message)
        {
            return message.GetAllRecords<CN_PHYSICIAN>("ConsultingDoctorRepetitionsUsed", "GetConsultingDoctor");
        }

        /// <summary>
        /// Add a new ConsultingDoctor to PV1
        /// </summary>
        public static CN_PHYSICIAN AddConsultingDoctor(this PV1 message)
        {
            return message.GetConsultingDoctor(message.ConsultingDoctorRepetitionsUsed);
        }

        /// <summary>
        /// Get AmbulatoryStatus Records from PV1
        /// </summary>
        public static IEnumerable GetAmbulatoryStatusRecords(this PV1 message)
        {
            object[] result = message.GetRecords("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AmbulatoryStatus Records from PV1
        /// </summary>
        public static List<ID> GetAllAmbulatoryStatusRecords(this PV1 message)
        {
            return message.GetAllRecords<ID>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Add a new AmbulatoryStatus to PV1
        /// </summary>
        public static ID AddAmbulatoryStatus(this PV1 message)
        {
            return message.GetAmbulatoryStatus(message.AmbulatoryStatusRepetitionsUsed);
        }

        /// <summary>
        /// Get FinancialClass Records from PV1
        /// </summary>
        public static IEnumerable GetFinancialClassRecords(this PV1 message)
        {
            object[] result = message.GetRecords("FinancialClassRepetitionsUsed", "GetFinancialClass");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FinancialClass Records from PV1
        /// </summary>
        public static List<CM_FINANCE> GetAllFinancialClassRecords(this PV1 message)
        {
            return message.GetAllRecords<CM_FINANCE>("FinancialClassRepetitionsUsed", "GetFinancialClass");
        }

        /// <summary>
        /// Add a new FinancialClass to PV1
        /// </summary>
        public static CM_FINANCE AddFinancialClass(this PV1 message)
        {
            return message.GetFinancialClass(message.FinancialClassRepetitionsUsed);
        }

        /// <summary>
        /// Get ContractCode Records from PV1
        /// </summary>
        public static IEnumerable GetContractCodeRecords(this PV1 message)
        {
            object[] result = message.GetRecords("ContractCodeRepetitionsUsed", "GetContractCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContractCode Records from PV1
        /// </summary>
        public static List<ID> GetAllContractCodeRecords(this PV1 message)
        {
            return message.GetAllRecords<ID>("ContractCodeRepetitionsUsed", "GetContractCode");
        }

        /// <summary>
        /// Add a new ContractCode to PV1
        /// </summary>
        public static ID AddContractCode(this PV1 message)
        {
            return message.GetContractCode(message.ContractCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get ContractEffectiveDate Records from PV1
        /// </summary>
        public static IEnumerable GetContractEffectiveDateRecords(this PV1 message)
        {
            object[] result = message.GetRecords("ContractEffectiveDateRepetitionsUsed", "GetContractEffectiveDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContractEffectiveDate Records from PV1
        /// </summary>
        public static List<DT> GetAllContractEffectiveDateRecords(this PV1 message)
        {
            return message.GetAllRecords<DT>("ContractEffectiveDateRepetitionsUsed", "GetContractEffectiveDate");
        }

        /// <summary>
        /// Add a new ContractEffectiveDate to PV1
        /// </summary>
        public static DT AddContractEffectiveDate(this PV1 message)
        {
            return message.GetContractEffectiveDate(message.ContractEffectiveDateRepetitionsUsed);
        }

        /// <summary>
        /// Get ContractAmount Records from PV1
        /// </summary>
        public static IEnumerable GetContractAmountRecords(this PV1 message)
        {
            object[] result = message.GetRecords("ContractAmountRepetitionsUsed", "GetContractAmount");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContractAmount Records from PV1
        /// </summary>
        public static List<NM> GetAllContractAmountRecords(this PV1 message)
        {
            return message.GetAllRecords<NM>("ContractAmountRepetitionsUsed", "GetContractAmount");
        }

        /// <summary>
        /// Add a new ContractAmount to PV1
        /// </summary>
        public static NM AddContractAmount(this PV1 message)
        {
            return message.GetContractAmount(message.ContractAmountRepetitionsUsed);
        }

        /// <summary>
        /// Get ContractPeriod Records from PV1
        /// </summary>
        public static IEnumerable GetContractPeriodRecords(this PV1 message)
        {
            object[] result = message.GetRecords("ContractPeriodRepetitionsUsed", "GetContractPeriod");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContractPeriod Records from PV1
        /// </summary>
        public static List<NM> GetAllContractPeriodRecords(this PV1 message)
        {
            return message.GetAllRecords<NM>("ContractPeriodRepetitionsUsed", "GetContractPeriod");
        }

        /// <summary>
        /// Add a new ContractPeriod to PV1
        /// </summary>
        public static NM AddContractPeriod(this PV1 message)
        {
            return message.GetContractPeriod(message.ContractPeriodRepetitionsUsed);
        }

        /// <summary>
        /// Get PatientValuables Records from PV2
        /// </summary>
        public static IEnumerable GetPatientValuablesRecords(this PV2 message)
        {
            object[] result = message.GetRecords("PatientValuablesRepetitionsUsed", "GetPatientValuables");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientValuables Records from PV2
        /// </summary>
        public static List<ST> GetAllPatientValuablesRecords(this PV2 message)
        {
            return message.GetAllRecords<ST>("PatientValuablesRepetitionsUsed", "GetPatientValuables");
        }

        /// <summary>
        /// Add a new PatientValuables to PV2
        /// </summary>
        public static ST AddPatientValuables(this PV2 message)
        {
            return message.GetPatientValuables(message.PatientValuablesRepetitionsUsed);
        }

        /// <summary>
        /// Get WhoSubjectFilter Records from QRD
        /// </summary>
        public static IEnumerable GetWhoSubjectFilterRecords(this QRD message)
        {
            object[] result = message.GetRecords("WhoSubjectFilterRepetitionsUsed", "GetWhoSubjectFilter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhoSubjectFilter Records from QRD
        /// </summary>
        public static List<ST> GetAllWhoSubjectFilterRecords(this QRD message)
        {
            return message.GetAllRecords<ST>("WhoSubjectFilterRepetitionsUsed", "GetWhoSubjectFilter");
        }

        /// <summary>
        /// Add a new WhoSubjectFilter to QRD
        /// </summary>
        public static ST AddWhoSubjectFilter(this QRD message)
        {
            return message.GetWhoSubjectFilter(message.WhoSubjectFilterRepetitionsUsed);
        }

        /// <summary>
        /// Get WhatSubjectFilter Records from QRD
        /// </summary>
        public static IEnumerable GetWhatSubjectFilterRecords(this QRD message)
        {
            object[] result = message.GetRecords("WhatSubjectFilterRepetitionsUsed", "GetWhatSubjectFilter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhatSubjectFilter Records from QRD
        /// </summary>
        public static List<ID> GetAllWhatSubjectFilterRecords(this QRD message)
        {
            return message.GetAllRecords<ID>("WhatSubjectFilterRepetitionsUsed", "GetWhatSubjectFilter");
        }

        /// <summary>
        /// Add a new WhatSubjectFilter to QRD
        /// </summary>
        public static ID AddWhatSubjectFilter(this QRD message)
        {
            return message.GetWhatSubjectFilter(message.WhatSubjectFilterRepetitionsUsed);
        }

        /// <summary>
        /// Get WhatDepartmentDataCode Records from QRD
        /// </summary>
        public static IEnumerable GetWhatDepartmentDataCodeRecords(this QRD message)
        {
            object[] result = message.GetRecords("WhatDepartmentDataCodeRepetitionsUsed", "GetWhatDepartmentDataCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhatDepartmentDataCode Records from QRD
        /// </summary>
        public static List<ST> GetAllWhatDepartmentDataCodeRecords(this QRD message)
        {
            return message.GetAllRecords<ST>("WhatDepartmentDataCodeRepetitionsUsed", "GetWhatDepartmentDataCode");
        }

        /// <summary>
        /// Add a new WhatDepartmentDataCode to QRD
        /// </summary>
        public static ST AddWhatDepartmentDataCode(this QRD message)
        {
            return message.GetWhatDepartmentDataCode(message.WhatDepartmentDataCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get WhatDataCodeValueQualifier Records from QRD
        /// </summary>
        public static IEnumerable GetWhatDataCodeValueQualifierRecords(this QRD message)
        {
            object[] result = message.GetRecords("WhatDataCodeValueQualifierRepetitionsUsed", "GetWhatDataCodeValueQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhatDataCodeValueQualifier Records from QRD
        /// </summary>
        public static List<CM_VR> GetAllWhatDataCodeValueQualifierRecords(this QRD message)
        {
            return message.GetAllRecords<CM_VR>("WhatDataCodeValueQualifierRepetitionsUsed", "GetWhatDataCodeValueQualifier");
        }

        /// <summary>
        /// Add a new WhatDataCodeValueQualifier to QRD
        /// </summary>
        public static CM_VR AddWhatDataCodeValueQualifier(this QRD message)
        {
            return message.GetWhatDataCodeValueQualifier(message.WhatDataCodeValueQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get WhereSubjectFilter Records from QRF
        /// </summary>
        public static IEnumerable GetWhereSubjectFilterRecords(this QRF message)
        {
            object[] result = message.GetRecords("WhereSubjectFilterRepetitionsUsed", "GetWhereSubjectFilter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhereSubjectFilter Records from QRF
        /// </summary>
        public static List<ST> GetAllWhereSubjectFilterRecords(this QRF message)
        {
            return message.GetAllRecords<ST>("WhereSubjectFilterRepetitionsUsed", "GetWhereSubjectFilter");
        }

        /// <summary>
        /// Add a new WhereSubjectFilter to QRF
        /// </summary>
        public static ST AddWhereSubjectFilter(this QRF message)
        {
            return message.GetWhereSubjectFilter(message.WhereSubjectFilterRepetitionsUsed);
        }

        /// <summary>
        /// Get WhatUserQualifier Records from QRF
        /// </summary>
        public static IEnumerable GetWhatUserQualifierRecords(this QRF message)
        {
            object[] result = message.GetRecords("WhatUserQualifierRepetitionsUsed", "GetWhatUserQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhatUserQualifier Records from QRF
        /// </summary>
        public static List<ST> GetAllWhatUserQualifierRecords(this QRF message)
        {
            return message.GetAllRecords<ST>("WhatUserQualifierRepetitionsUsed", "GetWhatUserQualifier");
        }

        /// <summary>
        /// Add a new WhatUserQualifier to QRF
        /// </summary>
        public static ST AddWhatUserQualifier(this QRF message)
        {
            return message.GetWhatUserQualifier(message.WhatUserQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get OtherQRYSubjectFilter Records from QRF
        /// </summary>
        public static IEnumerable GetOtherQRYSubjectFilterRecords(this QRF message)
        {
            object[] result = message.GetRecords("OtherQRYSubjectFilterRepetitionsUsed", "GetOtherQRYSubjectFilter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherQRYSubjectFilter Records from QRF
        /// </summary>
        public static List<ST> GetAllOtherQRYSubjectFilterRecords(this QRF message)
        {
            return message.GetAllRecords<ST>("OtherQRYSubjectFilterRepetitionsUsed", "GetOtherQRYSubjectFilter");
        }

        /// <summary>
        /// Add a new OtherQRYSubjectFilter to QRF
        /// </summary>
        public static ST AddOtherQRYSubjectFilter(this QRF message)
        {
            return message.GetOtherQRYSubjectFilter(message.OtherQRYSubjectFilterRepetitionsUsed);
        }

        /// <summary>
        /// Get WhichDateTimeQualifier Records from QRF
        /// </summary>
        public static IEnumerable GetWhichDateTimeQualifierRecords(this QRF message)
        {
            object[] result = message.GetRecords("WhichDateTimeQualifierRepetitionsUsed", "GetWhichDateTimeQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhichDateTimeQualifier Records from QRF
        /// </summary>
        public static List<ID> GetAllWhichDateTimeQualifierRecords(this QRF message)
        {
            return message.GetAllRecords<ID>("WhichDateTimeQualifierRepetitionsUsed", "GetWhichDateTimeQualifier");
        }

        /// <summary>
        /// Add a new WhichDateTimeQualifier to QRF
        /// </summary>
        public static ID AddWhichDateTimeQualifier(this QRF message)
        {
            return message.GetWhichDateTimeQualifier(message.WhichDateTimeQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get WhichDateTimeStatusQualifier Records from QRF
        /// </summary>
        public static IEnumerable GetWhichDateTimeStatusQualifierRecords(this QRF message)
        {
            object[] result = message.GetRecords("WhichDateTimeStatusQualifierRepetitionsUsed", "GetWhichDateTimeStatusQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhichDateTimeStatusQualifier Records from QRF
        /// </summary>
        public static List<ID> GetAllWhichDateTimeStatusQualifierRecords(this QRF message)
        {
            return message.GetAllRecords<ID>("WhichDateTimeStatusQualifierRepetitionsUsed", "GetWhichDateTimeStatusQualifier");
        }

        /// <summary>
        /// Add a new WhichDateTimeStatusQualifier to QRF
        /// </summary>
        public static ID AddWhichDateTimeStatusQualifier(this QRF message)
        {
            return message.GetWhichDateTimeStatusQualifier(message.WhichDateTimeStatusQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get DateTimeSelectionQualifier Records from QRF
        /// </summary>
        public static IEnumerable GetDateTimeSelectionQualifierRecords(this QRF message)
        {
            object[] result = message.GetRecords("DateTimeSelectionQualifierRepetitionsUsed", "GetDateTimeSelectionQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DateTimeSelectionQualifier Records from QRF
        /// </summary>
        public static List<ID> GetAllDateTimeSelectionQualifierRecords(this QRF message)
        {
            return message.GetAllRecords<ID>("DateTimeSelectionQualifierRepetitionsUsed", "GetDateTimeSelectionQualifier");
        }

        /// <summary>
        /// Add a new DateTimeSelectionQualifier to QRF
        /// </summary>
        public static ID AddDateTimeSelectionQualifier(this QRF message)
        {
            return message.GetDateTimeSelectionQualifier(message.DateTimeSelectionQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get DispenseNotes Records from RXD
        /// </summary>
        public static IEnumerable GetDispenseNotesRecords(this RXD message)
        {
            object[] result = message.GetRecords("DispenseNotesRepetitionsUsed", "GetDispenseNotes");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DispenseNotes Records from RXD
        /// </summary>
        public static List<ST> GetAllDispenseNotesRecords(this RXD message)
        {
            return message.GetAllRecords<ST>("DispenseNotesRepetitionsUsed", "GetDispenseNotes");
        }

        /// <summary>
        /// Add a new DispenseNotes to RXD
        /// </summary>
        public static ST AddDispenseNotes(this RXD message)
        {
            return message.GetDispenseNotes(message.DispenseNotesRepetitionsUsed);
        }

        /// <summary>
        /// Get QuantityTiming Records from RXE
        /// </summary>
        public static IEnumerable GetQuantityTimingRecords(this RXE message)
        {
            object[] result = message.GetRecords("QuantityTimingRepetitionsUsed", "GetQuantityTiming");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QuantityTiming Records from RXE
        /// </summary>
        public static List<TQ> GetAllQuantityTimingRecords(this RXE message)
        {
            return message.GetAllRecords<TQ>("QuantityTimingRepetitionsUsed", "GetQuantityTiming");
        }

        /// <summary>
        /// Add a new QuantityTiming to RXE
        /// </summary>
        public static TQ AddQuantityTiming(this RXE message)
        {
            return message.GetQuantityTiming(message.QuantityTimingRepetitionsUsed);
        }

        /// <summary>
        /// Get ProviderSAdministrationInstructions Records from RXE
        /// </summary>
        public static IEnumerable GetProviderSAdministrationInstructionsRecords(this RXE message)
        {
            object[] result = message.GetRecords("ProviderSAdministrationInstructionsRepetitionsUsed", "GetProviderSAdministrationInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderSAdministrationInstructions Records from RXE
        /// </summary>
        public static List<CE> GetAllProviderSAdministrationInstructionsRecords(this RXE message)
        {
            return message.GetAllRecords<CE>("ProviderSAdministrationInstructionsRepetitionsUsed", "GetProviderSAdministrationInstructions");
        }

        /// <summary>
        /// Add a new ProviderSAdministrationInstructions to RXE
        /// </summary>
        public static CE AddProviderSAdministrationInstructions(this RXE message)
        {
            return message.GetProviderSAdministrationInstructions(message.ProviderSAdministrationInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Get QuantityTiming Records from RXG
        /// </summary>
        public static IEnumerable GetQuantityTimingRecords(this RXG message)
        {
            object[] result = message.GetRecords("QuantityTimingRepetitionsUsed", "GetQuantityTiming");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all QuantityTiming Records from RXG
        /// </summary>
        public static List<TQ> GetAllQuantityTimingRecords(this RXG message)
        {
            return message.GetAllRecords<TQ>("QuantityTimingRepetitionsUsed", "GetQuantityTiming");
        }

        /// <summary>
        /// Add a new QuantityTiming to RXG
        /// </summary>
        public static TQ AddQuantityTiming(this RXG message)
        {
            return message.GetQuantityTiming(message.QuantityTimingRepetitionsUsed);
        }

        /// <summary>
        /// Get PharmacySpecialAdministrationInstructions Records from RXG
        /// </summary>
        public static IEnumerable GetPharmacySpecialAdministrationInstructionsRecords(this RXG message)
        {
            object[] result = message.GetRecords("PharmacySpecialAdministrationInstructionsRepetitionsUsed", "GetPharmacySpecialAdministrationInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacySpecialAdministrationInstructions Records from RXG
        /// </summary>
        public static List<CE> GetAllPharmacySpecialAdministrationInstructionsRecords(this RXG message)
        {
            return message.GetAllRecords<CE>("PharmacySpecialAdministrationInstructionsRepetitionsUsed", "GetPharmacySpecialAdministrationInstructions");
        }

        /// <summary>
        /// Add a new PharmacySpecialAdministrationInstructions to RXG
        /// </summary>
        public static CE AddPharmacySpecialAdministrationInstructions(this RXG message)
        {
            return message.GetPharmacySpecialAdministrationInstructions(message.PharmacySpecialAdministrationInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Get ProviderSPharmacyInstructions Records from RXO
        /// </summary>
        public static IEnumerable GetProviderSPharmacyInstructionsRecords(this RXO message)
        {
            object[] result = message.GetRecords("ProviderSPharmacyInstructionsRepetitionsUsed", "GetProviderSPharmacyInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderSPharmacyInstructions Records from RXO
        /// </summary>
        public static List<CE> GetAllProviderSPharmacyInstructionsRecords(this RXO message)
        {
            return message.GetAllRecords<CE>("ProviderSPharmacyInstructionsRepetitionsUsed", "GetProviderSPharmacyInstructions");
        }

        /// <summary>
        /// Add a new ProviderSPharmacyInstructions to RXO
        /// </summary>
        public static CE AddProviderSPharmacyInstructions(this RXO message)
        {
            return message.GetProviderSPharmacyInstructions(message.ProviderSPharmacyInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Get ProviderSAdministrationInstructions Records from RXO
        /// </summary>
        public static IEnumerable GetProviderSAdministrationInstructionsRecords(this RXO message)
        {
            object[] result = message.GetRecords("ProviderSAdministrationInstructionsRepetitionsUsed", "GetProviderSAdministrationInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderSAdministrationInstructions Records from RXO
        /// </summary>
        public static List<CE> GetAllProviderSAdministrationInstructionsRecords(this RXO message)
        {
            return message.GetAllRecords<CE>("ProviderSAdministrationInstructionsRepetitionsUsed", "GetProviderSAdministrationInstructions");
        }

        /// <summary>
        /// Add a new ProviderSAdministrationInstructions to RXO
        /// </summary>
        public static CE AddProviderSAdministrationInstructions(this RXO message)
        {
            return message.GetProviderSAdministrationInstructions(message.ProviderSAdministrationInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Get StaffIDCode Records from STF
        /// </summary>
        public static IEnumerable GetStaffIDCodeRecords(this STF message)
        {
            object[] result = message.GetRecords("StaffIDCodeRepetitionsUsed", "GetStaffIDCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StaffIDCode Records from STF
        /// </summary>
        public static List<CE> GetAllStaffIDCodeRecords(this STF message)
        {
            return message.GetAllRecords<CE>("StaffIDCodeRepetitionsUsed", "GetStaffIDCode");
        }

        /// <summary>
        /// Add a new StaffIDCode to STF
        /// </summary>
        public static CE AddStaffIDCode(this STF message)
        {
            return message.GetStaffIDCode(message.StaffIDCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get StaffType Records from STF
        /// </summary>
        public static IEnumerable GetStaffTypeRecords(this STF message)
        {
            object[] result = message.GetRecords("StaffTypeRepetitionsUsed", "GetStaffType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StaffType Records from STF
        /// </summary>
        public static List<ID> GetAllStaffTypeRecords(this STF message)
        {
            return message.GetAllRecords<ID>("StaffTypeRepetitionsUsed", "GetStaffType");
        }

        /// <summary>
        /// Add a new StaffType to STF
        /// </summary>
        public static ID AddStaffType(this STF message)
        {
            return message.GetStaffType(message.StaffTypeRepetitionsUsed);
        }

        /// <summary>
        /// Get Department Records from STF
        /// </summary>
        public static IEnumerable GetDepartmentRecords(this STF message)
        {
            object[] result = message.GetRecords("DepartmentRepetitionsUsed", "GetDepartment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Department Records from STF
        /// </summary>
        public static List<CE> GetAllDepartmentRecords(this STF message)
        {
            return message.GetAllRecords<CE>("DepartmentRepetitionsUsed", "GetDepartment");
        }

        /// <summary>
        /// Add a new Department to STF
        /// </summary>
        public static CE AddDepartment(this STF message)
        {
            return message.GetDepartment(message.DepartmentRepetitionsUsed);
        }

        /// <summary>
        /// Get Service Records from STF
        /// </summary>
        public static IEnumerable GetServiceRecords(this STF message)
        {
            object[] result = message.GetRecords("ServiceRepetitionsUsed", "GetService");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Service Records from STF
        /// </summary>
        public static List<CE> GetAllServiceRecords(this STF message)
        {
            return message.GetAllRecords<CE>("ServiceRepetitionsUsed", "GetService");
        }

        /// <summary>
        /// Add a new Service to STF
        /// </summary>
        public static CE AddService(this STF message)
        {
            return message.GetService(message.ServiceRepetitionsUsed);
        }

        /// <summary>
        /// Get Phone Records from STF
        /// </summary>
        public static IEnumerable GetPhoneRecords(this STF message)
        {
            object[] result = message.GetRecords("PhoneRepetitionsUsed", "GetPhone");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Phone Records from STF
        /// </summary>
        public static List<TN> GetAllPhoneRecords(this STF message)
        {
            return message.GetAllRecords<TN>("PhoneRepetitionsUsed", "GetPhone");
        }

        /// <summary>
        /// Add a new Phone to STF
        /// </summary>
        public static TN AddPhone(this STF message)
        {
            return message.GetPhone(message.PhoneRepetitionsUsed);
        }

        /// <summary>
        /// Get OfficeHomeAddress Records from STF
        /// </summary>
        public static IEnumerable GetOfficeHomeAddressRecords(this STF message)
        {
            object[] result = message.GetRecords("OfficeHomeAddressRepetitionsUsed", "GetOfficeHomeAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OfficeHomeAddress Records from STF
        /// </summary>
        public static List<AD> GetAllOfficeHomeAddressRecords(this STF message)
        {
            return message.GetAllRecords<AD>("OfficeHomeAddressRepetitionsUsed", "GetOfficeHomeAddress");
        }

        /// <summary>
        /// Add a new OfficeHomeAddress to STF
        /// </summary>
        public static AD AddOfficeHomeAddress(this STF message)
        {
            return message.GetOfficeHomeAddress(message.OfficeHomeAddressRepetitionsUsed);
        }

        /// <summary>
        /// Get ActivationDate Records from STF
        /// </summary>
        public static IEnumerable GetActivationDateRecords(this STF message)
        {
            object[] result = message.GetRecords("ActivationDateRepetitionsUsed", "GetActivationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ActivationDate Records from STF
        /// </summary>
        public static List<CM_DIN> GetAllActivationDateRecords(this STF message)
        {
            return message.GetAllRecords<CM_DIN>("ActivationDateRepetitionsUsed", "GetActivationDate");
        }

        /// <summary>
        /// Add a new ActivationDate to STF
        /// </summary>
        public static CM_DIN AddActivationDate(this STF message)
        {
            return message.GetActivationDate(message.ActivationDateRepetitionsUsed);
        }

        /// <summary>
        /// Get InactivationDate Records from STF
        /// </summary>
        public static IEnumerable GetInactivationDateRecords(this STF message)
        {
            object[] result = message.GetRecords("InactivationDateRepetitionsUsed", "GetInactivationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InactivationDate Records from STF
        /// </summary>
        public static List<CM_DIN> GetAllInactivationDateRecords(this STF message)
        {
            return message.GetAllRecords<CM_DIN>("InactivationDateRepetitionsUsed", "GetInactivationDate");
        }

        /// <summary>
        /// Add a new InactivationDate to STF
        /// </summary>
        public static CM_DIN AddInactivationDate(this STF message)
        {
            return message.GetInactivationDate(message.InactivationDateRepetitionsUsed);
        }

        /// <summary>
        /// Get BackupPersonID Records from STF
        /// </summary>
        public static IEnumerable GetBackupPersonIDRecords(this STF message)
        {
            object[] result = message.GetRecords("BackupPersonIDRepetitionsUsed", "GetBackupPersonID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BackupPersonID Records from STF
        /// </summary>
        public static List<CE> GetAllBackupPersonIDRecords(this STF message)
        {
            return message.GetAllRecords<CE>("BackupPersonIDRepetitionsUsed", "GetBackupPersonID");
        }

        /// <summary>
        /// Add a new BackupPersonID to STF
        /// </summary>
        public static CE AddBackupPersonID(this STF message)
        {
            return message.GetBackupPersonID(message.BackupPersonIDRepetitionsUsed);
        }

        /// <summary>
        /// Get EMailAddress Records from STF
        /// </summary>
        public static IEnumerable GetEMailAddressRecords(this STF message)
        {
            object[] result = message.GetRecords("EMailAddressRepetitionsUsed", "GetEMailAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EMailAddress Records from STF
        /// </summary>
        public static List<ST> GetAllEMailAddressRecords(this STF message)
        {
            return message.GetAllRecords<ST>("EMailAddressRepetitionsUsed", "GetEMailAddress");
        }

        /// <summary>
        /// Add a new EMailAddress to STF
        /// </summary>
        public static ST AddEMailAddress(this STF message)
        {
            return message.GetEMailAddress(message.EMailAddressRepetitionsUsed);
        }

        /// <summary>
        /// Get ConditionCode3539 Records from UB1
        /// </summary>
        public static IEnumerable GetConditionCode3539Records(this UB1 message)
        {
            object[] result = message.GetRecords("ConditionCode3539RepetitionsUsed", "GetConditionCode3539");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConditionCode3539 Records from UB1
        /// </summary>
        public static List<ID> GetAllConditionCode3539Records(this UB1 message)
        {
            return message.GetAllRecords<ID>("ConditionCode3539RepetitionsUsed", "GetConditionCode3539");
        }

        /// <summary>
        /// Add a new ConditionCode3539 to UB1
        /// </summary>
        public static ID AddConditionCode3539(this UB1 message)
        {
            return message.GetConditionCode3539(message.ConditionCode3539RepetitionsUsed);
        }

        /// <summary>
        /// Get ValueAmountAndCode4649 Records from UB1
        /// </summary>
        public static IEnumerable GetValueAmountAndCode4649Records(this UB1 message)
        {
            object[] result = message.GetRecords("ValueAmountAndCode4649RepetitionsUsed", "GetValueAmountAndCode4649");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValueAmountAndCode4649 Records from UB1
        /// </summary>
        public static List<CM_UVC> GetAllValueAmountAndCode4649Records(this UB1 message)
        {
            return message.GetAllRecords<CM_UVC>("ValueAmountAndCode4649RepetitionsUsed", "GetValueAmountAndCode4649");
        }

        /// <summary>
        /// Add a new ValueAmountAndCode4649 to UB1
        /// </summary>
        public static CM_UVC AddValueAmountAndCode4649(this UB1 message)
        {
            return message.GetValueAmountAndCode4649(message.ValueAmountAndCode4649RepetitionsUsed);
        }

        /// <summary>
        /// Get Occurrence2832 Records from UB1
        /// </summary>
        public static IEnumerable GetOccurrence2832Records(this UB1 message)
        {
            object[] result = message.GetRecords("Occurrence2832RepetitionsUsed", "GetOccurrence2832");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Occurrence2832 Records from UB1
        /// </summary>
        public static List<CM_OCD> GetAllOccurrence2832Records(this UB1 message)
        {
            return message.GetAllRecords<CM_OCD>("Occurrence2832RepetitionsUsed", "GetOccurrence2832");
        }

        /// <summary>
        /// Add a new Occurrence2832 to UB1
        /// </summary>
        public static CM_OCD AddOccurrence2832(this UB1 message)
        {
            return message.GetOccurrence2832(message.Occurrence2832RepetitionsUsed);
        }

        /// <summary>
        /// Get ConditionCode2430 Records from UB2
        /// </summary>
        public static IEnumerable GetConditionCode2430Records(this UB2 message)
        {
            object[] result = message.GetRecords("ConditionCode2430RepetitionsUsed", "GetConditionCode2430");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConditionCode2430 Records from UB2
        /// </summary>
        public static List<ID> GetAllConditionCode2430Records(this UB2 message)
        {
            return message.GetAllRecords<ID>("ConditionCode2430RepetitionsUsed", "GetConditionCode2430");
        }

        /// <summary>
        /// Add a new ConditionCode2430 to UB2
        /// </summary>
        public static ID AddConditionCode2430(this UB2 message)
        {
            return message.GetConditionCode2430(message.ConditionCode2430RepetitionsUsed);
        }

        /// <summary>
        /// Get ValueAmountAndCode3941 Records from UB2
        /// </summary>
        public static IEnumerable GetValueAmountAndCode3941Records(this UB2 message)
        {
            object[] result = message.GetRecords("ValueAmountAndCode3941RepetitionsUsed", "GetValueAmountAndCode3941");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValueAmountAndCode3941 Records from UB2
        /// </summary>
        public static List<CM_UVC> GetAllValueAmountAndCode3941Records(this UB2 message)
        {
            return message.GetAllRecords<CM_UVC>("ValueAmountAndCode3941RepetitionsUsed", "GetValueAmountAndCode3941");
        }

        /// <summary>
        /// Add a new ValueAmountAndCode3941 to UB2
        /// </summary>
        public static CM_UVC AddValueAmountAndCode3941(this UB2 message)
        {
            return message.GetValueAmountAndCode3941(message.ValueAmountAndCode3941RepetitionsUsed);
        }

        /// <summary>
        /// Get OccurrenceCodeAndDate3235 Records from UB2
        /// </summary>
        public static IEnumerable GetOccurrenceCodeAndDate3235Records(this UB2 message)
        {
            object[] result = message.GetRecords("OccurrenceCodeAndDate3235RepetitionsUsed", "GetOccurrenceCodeAndDate3235");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OccurrenceCodeAndDate3235 Records from UB2
        /// </summary>
        public static List<CM_OCD> GetAllOccurrenceCodeAndDate3235Records(this UB2 message)
        {
            return message.GetAllRecords<CM_OCD>("OccurrenceCodeAndDate3235RepetitionsUsed", "GetOccurrenceCodeAndDate3235");
        }

        /// <summary>
        /// Add a new OccurrenceCodeAndDate3235 to UB2
        /// </summary>
        public static CM_OCD AddOccurrenceCodeAndDate3235(this UB2 message)
        {
            return message.GetOccurrenceCodeAndDate3235(message.OccurrenceCodeAndDate3235RepetitionsUsed);
        }

        /// <summary>
        /// Get OccurrenceSpanCodeDates Records from UB2
        /// </summary>
        public static IEnumerable GetOccurrenceSpanCodeDatesRecords(this UB2 message)
        {
            object[] result = message.GetRecords("OccurrenceSpanCodeDatesRepetitionsUsed", "GetOccurrenceSpanCodeDates");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OccurrenceSpanCodeDates Records from UB2
        /// </summary>
        public static List<CM_OSP> GetAllOccurrenceSpanCodeDatesRecords(this UB2 message)
        {
            return message.GetAllRecords<CM_OSP>("OccurrenceSpanCodeDatesRepetitionsUsed", "GetOccurrenceSpanCodeDates");
        }

        /// <summary>
        /// Add a new OccurrenceSpanCodeDates to UB2
        /// </summary>
        public static CM_OSP AddOccurrenceSpanCodeDates(this UB2 message)
        {
            return message.GetOccurrenceSpanCodeDates(message.OccurrenceSpanCodeDatesRepetitionsUsed);
        }

        /// <summary>
        /// Get UB92Locator2State Records from UB2
        /// </summary>
        public static IEnumerable GetUB92Locator2StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UB92Locator2StateRepetitionsUsed", "GetUB92Locator2State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UB92Locator2State Records from UB2
        /// </summary>
        public static List<ST> GetAllUB92Locator2StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UB92Locator2StateRepetitionsUsed", "GetUB92Locator2State");
        }

        /// <summary>
        /// Add a new UB92Locator2State to UB2
        /// </summary>
        public static ST AddUB92Locator2State(this UB2 message)
        {
            return message.GetUB92Locator2State(message.UB92Locator2StateRepetitionsUsed);
        }

        /// <summary>
        /// Get UB92Locator11State Records from UB2
        /// </summary>
        public static IEnumerable GetUB92Locator11StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UB92Locator11StateRepetitionsUsed", "GetUB92Locator11State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UB92Locator11State Records from UB2
        /// </summary>
        public static List<ST> GetAllUB92Locator11StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UB92Locator11StateRepetitionsUsed", "GetUB92Locator11State");
        }

        /// <summary>
        /// Add a new UB92Locator11State to UB2
        /// </summary>
        public static ST AddUB92Locator11State(this UB2 message)
        {
            return message.GetUB92Locator11State(message.UB92Locator11StateRepetitionsUsed);
        }

        /// <summary>
        /// Get DocumentControlNumber Records from UB2
        /// </summary>
        public static IEnumerable GetDocumentControlNumberRecords(this UB2 message)
        {
            object[] result = message.GetRecords("DocumentControlNumberRepetitionsUsed", "GetDocumentControlNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DocumentControlNumber Records from UB2
        /// </summary>
        public static List<ST> GetAllDocumentControlNumberRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("DocumentControlNumberRepetitionsUsed", "GetDocumentControlNumber");
        }

        /// <summary>
        /// Add a new DocumentControlNumber to UB2
        /// </summary>
        public static ST AddDocumentControlNumber(this UB2 message)
        {
            return message.GetDocumentControlNumber(message.DocumentControlNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get UB92Locator49National Records from UB2
        /// </summary>
        public static IEnumerable GetUB92Locator49NationalRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UB92Locator49NationalRepetitionsUsed", "GetUB92Locator49National");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UB92Locator49National Records from UB2
        /// </summary>
        public static List<ST> GetAllUB92Locator49NationalRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UB92Locator49NationalRepetitionsUsed", "GetUB92Locator49National");
        }

        /// <summary>
        /// Add a new UB92Locator49National to UB2
        /// </summary>
        public static ST AddUB92Locator49National(this UB2 message)
        {
            return message.GetUB92Locator49National(message.UB92Locator49NationalRepetitionsUsed);
        }

        /// <summary>
        /// Get UB92Locator56State Records from UB2
        /// </summary>
        public static IEnumerable GetUB92Locator56StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UB92Locator56StateRepetitionsUsed", "GetUB92Locator56State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UB92Locator56State Records from UB2
        /// </summary>
        public static List<ST> GetAllUB92Locator56StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UB92Locator56StateRepetitionsUsed", "GetUB92Locator56State");
        }

        /// <summary>
        /// Add a new UB92Locator56State to UB2
        /// </summary>
        public static ST AddUB92Locator56State(this UB2 message)
        {
            return message.GetUB92Locator56State(message.UB92Locator56StateRepetitionsUsed);
        }

        /// <summary>
        /// Get UB92Locator78State Records from UB2
        /// </summary>
        public static IEnumerable GetUB92Locator78StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UB92Locator78StateRepetitionsUsed", "GetUB92Locator78State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UB92Locator78State Records from UB2
        /// </summary>
        public static List<ST> GetAllUB92Locator78StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UB92Locator78StateRepetitionsUsed", "GetUB92Locator78State");
        }

        /// <summary>
        /// Add a new UB92Locator78State to UB2
        /// </summary>
        public static ST AddUB92Locator78State(this UB2 message)
        {
            return message.GetUB92Locator78State(message.UB92Locator78StateRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhoSubjectDefinition Records from URD
        /// </summary>
        public static IEnumerable GetRUWhoSubjectDefinitionRecords(this URD message)
        {
            object[] result = message.GetRecords("RUWhoSubjectDefinitionRepetitionsUsed", "GetRUWhoSubjectDefinition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhoSubjectDefinition Records from URD
        /// </summary>
        public static List<ST> GetAllRUWhoSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<ST>("RUWhoSubjectDefinitionRepetitionsUsed", "GetRUWhoSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUWhoSubjectDefinition to URD
        /// </summary>
        public static ST AddRUWhoSubjectDefinition(this URD message)
        {
            return message.GetRUWhoSubjectDefinition(message.RUWhoSubjectDefinitionRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhatSubjectDefinition Records from URD
        /// </summary>
        public static IEnumerable GetRUWhatSubjectDefinitionRecords(this URD message)
        {
            object[] result = message.GetRecords("RUWhatSubjectDefinitionRepetitionsUsed", "GetRUWhatSubjectDefinition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhatSubjectDefinition Records from URD
        /// </summary>
        public static List<ID> GetAllRUWhatSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<ID>("RUWhatSubjectDefinitionRepetitionsUsed", "GetRUWhatSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUWhatSubjectDefinition to URD
        /// </summary>
        public static ID AddRUWhatSubjectDefinition(this URD message)
        {
            return message.GetRUWhatSubjectDefinition(message.RUWhatSubjectDefinitionRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhatDepartmentCode Records from URD
        /// </summary>
        public static IEnumerable GetRUWhatDepartmentCodeRecords(this URD message)
        {
            object[] result = message.GetRecords("RUWhatDepartmentCodeRepetitionsUsed", "GetRUWhatDepartmentCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhatDepartmentCode Records from URD
        /// </summary>
        public static List<ST> GetAllRUWhatDepartmentCodeRecords(this URD message)
        {
            return message.GetAllRecords<ST>("RUWhatDepartmentCodeRepetitionsUsed", "GetRUWhatDepartmentCode");
        }

        /// <summary>
        /// Add a new RUWhatDepartmentCode to URD
        /// </summary>
        public static ST AddRUWhatDepartmentCode(this URD message)
        {
            return message.GetRUWhatDepartmentCode(message.RUWhatDepartmentCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get RUDisplayPrintLocations Records from URD
        /// </summary>
        public static IEnumerable GetRUDisplayPrintLocationsRecords(this URD message)
        {
            object[] result = message.GetRecords("RUDisplayPrintLocationsRepetitionsUsed", "GetRUDisplayPrintLocations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUDisplayPrintLocations Records from URD
        /// </summary>
        public static List<ST> GetAllRUDisplayPrintLocationsRecords(this URD message)
        {
            return message.GetAllRecords<ST>("RUDisplayPrintLocationsRepetitionsUsed", "GetRUDisplayPrintLocations");
        }

        /// <summary>
        /// Add a new RUDisplayPrintLocations to URD
        /// </summary>
        public static ST AddRUDisplayPrintLocations(this URD message)
        {
            return message.GetRUDisplayPrintLocations(message.RUDisplayPrintLocationsRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhereSubjectDefinition Records from URS
        /// </summary>
        public static IEnumerable GetRUWhereSubjectDefinitionRecords(this URS message)
        {
            object[] result = message.GetRecords("RUWhereSubjectDefinitionRepetitionsUsed", "GetRUWhereSubjectDefinition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhereSubjectDefinition Records from URS
        /// </summary>
        public static List<ST> GetAllRUWhereSubjectDefinitionRecords(this URS message)
        {
            return message.GetAllRecords<ST>("RUWhereSubjectDefinitionRepetitionsUsed", "GetRUWhereSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUWhereSubjectDefinition to URS
        /// </summary>
        public static ST AddRUWhereSubjectDefinition(this URS message)
        {
            return message.GetRUWhereSubjectDefinition(message.RUWhereSubjectDefinitionRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhatUserQualifier Records from URS
        /// </summary>
        public static IEnumerable GetRUWhatUserQualifierRecords(this URS message)
        {
            object[] result = message.GetRecords("RUWhatUserQualifierRepetitionsUsed", "GetRUWhatUserQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhatUserQualifier Records from URS
        /// </summary>
        public static List<ST> GetAllRUWhatUserQualifierRecords(this URS message)
        {
            return message.GetAllRecords<ST>("RUWhatUserQualifierRepetitionsUsed", "GetRUWhatUserQualifier");
        }

        /// <summary>
        /// Add a new RUWhatUserQualifier to URS
        /// </summary>
        public static ST AddRUWhatUserQualifier(this URS message)
        {
            return message.GetRUWhatUserQualifier(message.RUWhatUserQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get RUOtherResultsSubjectDefinition Records from URS
        /// </summary>
        public static IEnumerable GetRUOtherResultsSubjectDefinitionRecords(this URS message)
        {
            object[] result = message.GetRecords("RUOtherResultsSubjectDefinitionRepetitionsUsed", "GetRUOtherResultsSubjectDefinition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUOtherResultsSubjectDefinition Records from URS
        /// </summary>
        public static List<ST> GetAllRUOtherResultsSubjectDefinitionRecords(this URS message)
        {
            return message.GetAllRecords<ST>("RUOtherResultsSubjectDefinitionRepetitionsUsed", "GetRUOtherResultsSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUOtherResultsSubjectDefinition to URS
        /// </summary>
        public static ST AddRUOtherResultsSubjectDefinition(this URS message)
        {
            return message.GetRUOtherResultsSubjectDefinition(message.RUOtherResultsSubjectDefinitionRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhichDateTimeQualifier Records from URS
        /// </summary>
        public static IEnumerable GetRUWhichDateTimeQualifierRecords(this URS message)
        {
            object[] result = message.GetRecords("RUWhichDateTimeQualifierRepetitionsUsed", "GetRUWhichDateTimeQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhichDateTimeQualifier Records from URS
        /// </summary>
        public static List<ID> GetAllRUWhichDateTimeQualifierRecords(this URS message)
        {
            return message.GetAllRecords<ID>("RUWhichDateTimeQualifierRepetitionsUsed", "GetRUWhichDateTimeQualifier");
        }

        /// <summary>
        /// Add a new RUWhichDateTimeQualifier to URS
        /// </summary>
        public static ID AddRUWhichDateTimeQualifier(this URS message)
        {
            return message.GetRUWhichDateTimeQualifier(message.RUWhichDateTimeQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get RUWhichDateTimeStatusQualifier Records from URS
        /// </summary>
        public static IEnumerable GetRUWhichDateTimeStatusQualifierRecords(this URS message)
        {
            object[] result = message.GetRecords("RUWhichDateTimeStatusQualifierRepetitionsUsed", "GetRUWhichDateTimeStatusQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUWhichDateTimeStatusQualifier Records from URS
        /// </summary>
        public static List<ID> GetAllRUWhichDateTimeStatusQualifierRecords(this URS message)
        {
            return message.GetAllRecords<ID>("RUWhichDateTimeStatusQualifierRepetitionsUsed", "GetRUWhichDateTimeStatusQualifier");
        }

        /// <summary>
        /// Add a new RUWhichDateTimeStatusQualifier to URS
        /// </summary>
        public static ID AddRUWhichDateTimeStatusQualifier(this URS message)
        {
            return message.GetRUWhichDateTimeStatusQualifier(message.RUWhichDateTimeStatusQualifierRepetitionsUsed);
        }

        /// <summary>
        /// Get RUDateTimeSelectionQualifier Records from URS
        /// </summary>
        public static IEnumerable GetRUDateTimeSelectionQualifierRecords(this URS message)
        {
            object[] result = message.GetRecords("RUDateTimeSelectionQualifierRepetitionsUsed", "GetRUDateTimeSelectionQualifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RUDateTimeSelectionQualifier Records from URS
        /// </summary>
        public static List<ID> GetAllRUDateTimeSelectionQualifierRecords(this URS message)
        {
            return message.GetAllRecords<ID>("RUDateTimeSelectionQualifierRepetitionsUsed", "GetRUDateTimeSelectionQualifier");
        }

        /// <summary>
        /// Add a new RUDateTimeSelectionQualifier to URS
        /// </summary>
        public static ID AddRUDateTimeSelectionQualifier(this URS message)
        {
            return message.GetRUDateTimeSelectionQualifier(message.RUDateTimeSelectionQualifierRepetitionsUsed);
        }
        #endregion
    }
}
