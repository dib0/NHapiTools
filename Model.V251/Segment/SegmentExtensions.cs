using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V251;
using NHapi.Model.V251.Group;
using NHapi.Model.V251.Message;
using NHapi.Model.V251.Segment;
using NHapi.Model.V251.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V251.Segment
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class SegmentExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get RelatedPlacerNumber Records from TQ2
        /// </summary>
        public static IEnumerable GetRelatedPlacerNumberRecords(this TQ2 message)
        {
            object[] result = message.GetRecords("RelatedPlacerNumberRepetitionsUsed", "GetRelatedPlacerNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelatedPlacerNumber Records from TQ2
        /// </summary>
        public static List<EI> GetAllRelatedPlacerNumberRecords(this TQ2 message)
        {
            return message.GetAllRecords<EI>("RelatedPlacerNumberRepetitionsUsed", "GetRelatedPlacerNumber");
        }

        /// <summary>
        /// Get RelatedFillerNumber Records from TQ2
        /// </summary>
        public static IEnumerable GetRelatedFillerNumberRecords(this TQ2 message)
        {
            object[] result = message.GetRecords("RelatedFillerNumberRepetitionsUsed", "GetRelatedFillerNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelatedFillerNumber Records from TQ2
        /// </summary>
        public static List<EI> GetAllRelatedFillerNumberRecords(this TQ2 message)
        {
            return message.GetAllRecords<EI>("RelatedFillerNumberRepetitionsUsed", "GetRelatedFillerNumber");
        }

        /// <summary>
        /// Get RelatedPlacerGroupNumber Records from TQ2
        /// </summary>
        public static IEnumerable GetRelatedPlacerGroupNumberRecords(this TQ2 message)
        {
            object[] result = message.GetRecords("RelatedPlacerGroupNumberRepetitionsUsed", "GetRelatedPlacerGroupNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelatedPlacerGroupNumber Records from TQ2
        /// </summary>
        public static List<EI> GetAllRelatedPlacerGroupNumberRecords(this TQ2 message)
        {
            return message.GetAllRecords<EI>("RelatedPlacerGroupNumberRepetitionsUsed", "GetRelatedPlacerGroupNumber");
        }

        /// <summary>
        /// Get MatchReasonCode Records from QRI
        /// </summary>
        public static IEnumerable GetMatchReasonCodeRecords(this QRI message)
        {
            object[] result = message.GetRecords("MatchReasonCodeRepetitionsUsed", "GetMatchReasonCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MatchReasonCode Records from QRI
        /// </summary>
        public static List<IS> GetAllMatchReasonCodeRecords(this QRI message)
        {
            return message.GetAllRecords<IS>("MatchReasonCodeRepetitionsUsed", "GetMatchReasonCode");
        }

        /// <summary>
        /// Get NormalTextCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static IEnumerable GetNormalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            object[] result = message.GetRecords("NormalTextCodesForCategoricalObservationsRepetitionsUsed", "GetNormalTextCodesForCategoricalObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NormalTextCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static List<CE> GetAllNormalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CE>("NormalTextCodesForCategoricalObservationsRepetitionsUsed", "GetNormalTextCodesForCategoricalObservations");
        }

        /// <summary>
        /// Get AbnormalTextCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static IEnumerable GetAbnormalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            object[] result = message.GetRecords("AbnormalTextCodesForCategoricalObservationsRepetitionsUsed", "GetAbnormalTextCodesForCategoricalObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AbnormalTextCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static List<CE> GetAllAbnormalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CE>("AbnormalTextCodesForCategoricalObservationsRepetitionsUsed", "GetAbnormalTextCodesForCategoricalObservations");
        }

        /// <summary>
        /// Get CriticalTextCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static IEnumerable GetCriticalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            object[] result = message.GetRecords("CriticalTextCodesForCategoricalObservationsRepetitionsUsed", "GetCriticalTextCodesForCategoricalObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CriticalTextCodesForCategoricalObservations Records from OM3
        /// </summary>
        public static List<CE> GetAllCriticalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CE>("CriticalTextCodesForCategoricalObservationsRepetitionsUsed", "GetCriticalTextCodesForCategoricalObservations");
        }

        /// <summary>
        /// Get PrimaryKeyValueMFA Records from MFA
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueMFARecords(this MFA message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueMFARepetitionsUsed", "GetPrimaryKeyValueMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValueMFA Records from MFA
        /// </summary>
        public static List<Varies> GetAllPrimaryKeyValueMFARecords(this MFA message)
        {
            return message.GetAllRecords<Varies>("PrimaryKeyValueMFARepetitionsUsed", "GetPrimaryKeyValueMFA");
        }

        /// <summary>
        /// Get PrimaryKeyValueTypeMFA Records from MFA
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueTypeMFARecords(this MFA message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueTypeMFARepetitionsUsed", "GetPrimaryKeyValueTypeMFA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValueTypeMFA Records from MFA
        /// </summary>
        public static List<ID> GetAllPrimaryKeyValueTypeMFARecords(this MFA message)
        {
            return message.GetAllRecords<ID>("PrimaryKeyValueTypeMFARepetitionsUsed", "GetPrimaryKeyValueTypeMFA");
        }

        /// <summary>
        /// Get LanguageAbilityCode Records from LAN
        /// </summary>
        public static IEnumerable GetLanguageAbilityCodeRecords(this LAN message)
        {
            object[] result = message.GetRecords("LanguageAbilityCodeRepetitionsUsed", "GetLanguageAbilityCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LanguageAbilityCode Records from LAN
        /// </summary>
        public static List<CE> GetAllLanguageAbilityCodeRecords(this LAN message)
        {
            return message.GetAllRecords<CE>("LanguageAbilityCodeRepetitionsUsed", "GetLanguageAbilityCode");
        }

        /// <summary>
        /// Get GuarantorNumber Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorNumberRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorNumberRepetitionsUsed", "GetGuarantorNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorNumber Records from GT1
        /// </summary>
        public static List<CX> GetAllGuarantorNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<CX>("GuarantorNumberRepetitionsUsed", "GetGuarantorNumber");
        }

        /// <summary>
        /// Get GuarantorName Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorNameRepetitionsUsed", "GetGuarantorName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorName Records from GT1
        /// </summary>
        public static List<XPN> GetAllGuarantorNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XPN>("GuarantorNameRepetitionsUsed", "GetGuarantorName");
        }

        /// <summary>
        /// Get GuarantorSpouseName Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorSpouseNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorSpouseNameRepetitionsUsed", "GetGuarantorSpouseName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorSpouseName Records from GT1
        /// </summary>
        public static List<XPN> GetAllGuarantorSpouseNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XPN>("GuarantorSpouseNameRepetitionsUsed", "GetGuarantorSpouseName");
        }

        /// <summary>
        /// Get GuarantorAddress Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorAddressRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorAddressRepetitionsUsed", "GetGuarantorAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorAddress Records from GT1
        /// </summary>
        public static List<XAD> GetAllGuarantorAddressRecords(this GT1 message)
        {
            return message.GetAllRecords<XAD>("GuarantorAddressRepetitionsUsed", "GetGuarantorAddress");
        }

        /// <summary>
        /// Get GuarantorPhNumHome Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorPhNumHomeRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorPhNumHomeRepetitionsUsed", "GetGuarantorPhNumHome");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorPhNumHome Records from GT1
        /// </summary>
        public static List<XTN> GetAllGuarantorPhNumHomeRecords(this GT1 message)
        {
            return message.GetAllRecords<XTN>("GuarantorPhNumHomeRepetitionsUsed", "GetGuarantorPhNumHome");
        }

        /// <summary>
        /// Get GuarantorPhNumBusiness Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorPhNumBusinessRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorPhNumBusinessRepetitionsUsed", "GetGuarantorPhNumBusiness");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorPhNumBusiness Records from GT1
        /// </summary>
        public static List<XTN> GetAllGuarantorPhNumBusinessRecords(this GT1 message)
        {
            return message.GetAllRecords<XTN>("GuarantorPhNumBusinessRepetitionsUsed", "GetGuarantorPhNumBusiness");
        }

        /// <summary>
        /// Get GuarantorEmployerName Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployerNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployerNameRepetitionsUsed", "GetGuarantorEmployerName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployerName Records from GT1
        /// </summary>
        public static List<XPN> GetAllGuarantorEmployerNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XPN>("GuarantorEmployerNameRepetitionsUsed", "GetGuarantorEmployerName");
        }

        /// <summary>
        /// Get GuarantorEmployerAddress Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployerAddressRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployerAddressRepetitionsUsed", "GetGuarantorEmployerAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployerAddress Records from GT1
        /// </summary>
        public static List<XAD> GetAllGuarantorEmployerAddressRecords(this GT1 message)
        {
            return message.GetAllRecords<XAD>("GuarantorEmployerAddressRepetitionsUsed", "GetGuarantorEmployerAddress");
        }

        /// <summary>
        /// Get GuarantorEmployerPhoneNumber Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployerPhoneNumberRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployerPhoneNumberRepetitionsUsed", "GetGuarantorEmployerPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployerPhoneNumber Records from GT1
        /// </summary>
        public static List<XTN> GetAllGuarantorEmployerPhoneNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<XTN>("GuarantorEmployerPhoneNumberRepetitionsUsed", "GetGuarantorEmployerPhoneNumber");
        }

        /// <summary>
        /// Get GuarantorEmployeeIDNumber Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployeeIDNumberRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployeeIDNumberRepetitionsUsed", "GetGuarantorEmployeeIDNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployeeIDNumber Records from GT1
        /// </summary>
        public static List<CX> GetAllGuarantorEmployeeIDNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<CX>("GuarantorEmployeeIDNumberRepetitionsUsed", "GetGuarantorEmployeeIDNumber");
        }

        /// <summary>
        /// Get GuarantorOrganizationName Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorOrganizationNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorOrganizationNameRepetitionsUsed", "GetGuarantorOrganizationName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorOrganizationName Records from GT1
        /// </summary>
        public static List<XON> GetAllGuarantorOrganizationNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XON>("GuarantorOrganizationNameRepetitionsUsed", "GetGuarantorOrganizationName");
        }

        /// <summary>
        /// Get GuarantorEmployerIDNumber Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployerIDNumberRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployerIDNumberRepetitionsUsed", "GetGuarantorEmployerIDNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployerIDNumber Records from GT1
        /// </summary>
        public static List<CX> GetAllGuarantorEmployerIDNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<CX>("GuarantorEmployerIDNumberRepetitionsUsed", "GetGuarantorEmployerIDNumber");
        }

        /// <summary>
        /// Get AmbulatoryStatus Records from GT1
        /// </summary>
        public static IEnumerable GetAmbulatoryStatusRecords(this GT1 message)
        {
            object[] result = message.GetRecords("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AmbulatoryStatus Records from GT1
        /// </summary>
        public static List<IS> GetAllAmbulatoryStatusRecords(this GT1 message)
        {
            return message.GetAllRecords<IS>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Get Citizenship Records from GT1
        /// </summary>
        public static IEnumerable GetCitizenshipRecords(this GT1 message)
        {
            object[] result = message.GetRecords("CitizenshipRepetitionsUsed", "GetCitizenship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Citizenship Records from GT1
        /// </summary>
        public static List<CE> GetAllCitizenshipRecords(this GT1 message)
        {
            return message.GetAllRecords<CE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Get MotherSMaidenName Records from GT1
        /// </summary>
        public static IEnumerable GetMotherSMaidenNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MotherSMaidenName Records from GT1
        /// </summary>
        public static List<XPN> GetAllMotherSMaidenNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XPN>("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");
        }

        /// <summary>
        /// Get EthnicGroup Records from GT1
        /// </summary>
        public static IEnumerable GetEthnicGroupRecords(this GT1 message)
        {
            object[] result = message.GetRecords("EthnicGroupRepetitionsUsed", "GetEthnicGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EthnicGroup Records from GT1
        /// </summary>
        public static List<CE> GetAllEthnicGroupRecords(this GT1 message)
        {
            return message.GetAllRecords<CE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Get ContactPersonSName Records from GT1
        /// </summary>
        public static IEnumerable GetContactPersonSNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("ContactPersonSNameRepetitionsUsed", "GetContactPersonSName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactPersonSName Records from GT1
        /// </summary>
        public static List<XPN> GetAllContactPersonSNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XPN>("ContactPersonSNameRepetitionsUsed", "GetContactPersonSName");
        }

        /// <summary>
        /// Get ContactPersonSTelephoneNumber Records from GT1
        /// </summary>
        public static IEnumerable GetContactPersonSTelephoneNumberRecords(this GT1 message)
        {
            object[] result = message.GetRecords("ContactPersonSTelephoneNumberRepetitionsUsed", "GetContactPersonSTelephoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactPersonSTelephoneNumber Records from GT1
        /// </summary>
        public static List<XTN> GetAllContactPersonSTelephoneNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<XTN>("ContactPersonSTelephoneNumberRepetitionsUsed", "GetContactPersonSTelephoneNumber");
        }

        /// <summary>
        /// Get GuarantorEmployerSOrganizationName Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorEmployerSOrganizationNameRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorEmployerSOrganizationNameRepetitionsUsed", "GetGuarantorEmployerSOrganizationName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorEmployerSOrganizationName Records from GT1
        /// </summary>
        public static List<XON> GetAllGuarantorEmployerSOrganizationNameRecords(this GT1 message)
        {
            return message.GetAllRecords<XON>("GuarantorEmployerSOrganizationNameRepetitionsUsed", "GetGuarantorEmployerSOrganizationName");
        }

        /// <summary>
        /// Get GuarantorRace Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorRaceRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorRaceRepetitionsUsed", "GetGuarantorRace");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorRace Records from GT1
        /// </summary>
        public static List<CE> GetAllGuarantorRaceRecords(this GT1 message)
        {
            return message.GetAllRecords<CE>("GuarantorRaceRepetitionsUsed", "GetGuarantorRace");
        }

        /// <summary>
        /// Get FacilityAddress Records from FAC
        /// </summary>
        public static IEnumerable GetFacilityAddressRecords(this FAC message)
        {
            object[] result = message.GetRecords("FacilityAddressRepetitionsUsed", "GetFacilityAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FacilityAddress Records from FAC
        /// </summary>
        public static List<XAD> GetAllFacilityAddressRecords(this FAC message)
        {
            return message.GetAllRecords<XAD>("FacilityAddressRepetitionsUsed", "GetFacilityAddress");
        }

        /// <summary>
        /// Get ContactPerson Records from FAC
        /// </summary>
        public static IEnumerable GetContactPersonRecords(this FAC message)
        {
            object[] result = message.GetRecords("ContactPersonRepetitionsUsed", "GetContactPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactPerson Records from FAC
        /// </summary>
        public static List<XCN> GetAllContactPersonRecords(this FAC message)
        {
            return message.GetAllRecords<XCN>("ContactPersonRepetitionsUsed", "GetContactPerson");
        }

        /// <summary>
        /// Get ContactTitle Records from FAC
        /// </summary>
        public static IEnumerable GetContactTitleRecords(this FAC message)
        {
            object[] result = message.GetRecords("ContactTitleRepetitionsUsed", "GetContactTitle");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactTitle Records from FAC
        /// </summary>
        public static List<ST> GetAllContactTitleRecords(this FAC message)
        {
            return message.GetAllRecords<ST>("ContactTitleRepetitionsUsed", "GetContactTitle");
        }

        /// <summary>
        /// Get ContactAddress Records from FAC
        /// </summary>
        public static IEnumerable GetContactAddressRecords(this FAC message)
        {
            object[] result = message.GetRecords("ContactAddressRepetitionsUsed", "GetContactAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactAddress Records from FAC
        /// </summary>
        public static List<XAD> GetAllContactAddressRecords(this FAC message)
        {
            return message.GetAllRecords<XAD>("ContactAddressRepetitionsUsed", "GetContactAddress");
        }

        /// <summary>
        /// Get ContactTelecommunication Records from FAC
        /// </summary>
        public static IEnumerable GetContactTelecommunicationRecords(this FAC message)
        {
            object[] result = message.GetRecords("ContactTelecommunicationRepetitionsUsed", "GetContactTelecommunication");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactTelecommunication Records from FAC
        /// </summary>
        public static List<XTN> GetAllContactTelecommunicationRecords(this FAC message)
        {
            return message.GetAllRecords<XTN>("ContactTelecommunicationRepetitionsUsed", "GetContactTelecommunication");
        }

        /// <summary>
        /// Get SignatureAuthority Records from FAC
        /// </summary>
        public static IEnumerable GetSignatureAuthorityRecords(this FAC message)
        {
            object[] result = message.GetRecords("SignatureAuthorityRepetitionsUsed", "GetSignatureAuthority");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SignatureAuthority Records from FAC
        /// </summary>
        public static List<XCN> GetAllSignatureAuthorityRecords(this FAC message)
        {
            return message.GetAllRecords<XCN>("SignatureAuthorityRepetitionsUsed", "GetSignatureAuthority");
        }

        /// <summary>
        /// Get SignatureAuthorityAddress Records from FAC
        /// </summary>
        public static IEnumerable GetSignatureAuthorityAddressRecords(this FAC message)
        {
            object[] result = message.GetRecords("SignatureAuthorityAddressRepetitionsUsed", "GetSignatureAuthorityAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SignatureAuthorityAddress Records from FAC
        /// </summary>
        public static List<XAD> GetAllSignatureAuthorityAddressRecords(this FAC message)
        {
            return message.GetAllRecords<XAD>("SignatureAuthorityAddressRepetitionsUsed", "GetSignatureAuthorityAddress");
        }

        /// <summary>
        /// Get PersonnelResourceID Records from AIP
        /// </summary>
        public static IEnumerable GetPersonnelResourceIDRecords(this AIP message)
        {
            object[] result = message.GetRecords("PersonnelResourceIDRepetitionsUsed", "GetPersonnelResourceID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PersonnelResourceID Records from AIP
        /// </summary>
        public static List<XCN> GetAllPersonnelResourceIDRecords(this AIP message)
        {
            return message.GetAllRecords<XCN>("PersonnelResourceIDRepetitionsUsed", "GetPersonnelResourceID");
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
        public static List<XCN> GetAllRUWhoSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<XCN>("RUWhoSubjectDefinitionRepetitionsUsed", "GetRUWhoSubjectDefinition");
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
        public static List<CE> GetAllRUWhatSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<CE>("RUWhatSubjectDefinitionRepetitionsUsed", "GetRUWhatSubjectDefinition");
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
        public static List<CE> GetAllRUWhatDepartmentCodeRecords(this URD message)
        {
            return message.GetAllRecords<CE>("RUWhatDepartmentCodeRepetitionsUsed", "GetRUWhatDepartmentCode");
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
        public static List<IS> GetAllConditionCode2430Records(this UB2 message)
        {
            return message.GetAllRecords<IS>("ConditionCode2430RepetitionsUsed", "GetConditionCode2430");
        }

        /// <summary>
        /// Get ValueAmountCode Records from UB2
        /// </summary>
        public static IEnumerable GetValueAmountCodeRecords(this UB2 message)
        {
            object[] result = message.GetRecords("ValueAmountCodeRepetitionsUsed", "GetValueAmountCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValueAmountCode Records from UB2
        /// </summary>
        public static List<UVC> GetAllValueAmountCodeRecords(this UB2 message)
        {
            return message.GetAllRecords<UVC>("ValueAmountCodeRepetitionsUsed", "GetValueAmountCode");
        }

        /// <summary>
        /// Get OccurrenceCodeDate3235 Records from UB2
        /// </summary>
        public static IEnumerable GetOccurrenceCodeDate3235Records(this UB2 message)
        {
            object[] result = message.GetRecords("OccurrenceCodeDate3235RepetitionsUsed", "GetOccurrenceCodeDate3235");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OccurrenceCodeDate3235 Records from UB2
        /// </summary>
        public static List<OCD> GetAllOccurrenceCodeDate3235Records(this UB2 message)
        {
            return message.GetAllRecords<OCD>("OccurrenceCodeDate3235RepetitionsUsed", "GetOccurrenceCodeDate3235");
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
        public static List<OSP> GetAllOccurrenceSpanCodeDatesRecords(this UB2 message)
        {
            return message.GetAllRecords<OSP>("OccurrenceSpanCodeDatesRepetitionsUsed", "GetOccurrenceSpanCodeDates");
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
        /// Get RepeatPattern Records from TQ1
        /// </summary>
        public static IEnumerable GetRepeatPatternRecords(this TQ1 message)
        {
            object[] result = message.GetRecords("RepeatPatternRepetitionsUsed", "GetRepeatPattern");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RepeatPattern Records from TQ1
        /// </summary>
        public static List<RPT> GetAllRepeatPatternRecords(this TQ1 message)
        {
            return message.GetAllRecords<RPT>("RepeatPatternRepetitionsUsed", "GetRepeatPattern");
        }

        /// <summary>
        /// Get ExplicitTime Records from TQ1
        /// </summary>
        public static IEnumerable GetExplicitTimeRecords(this TQ1 message)
        {
            object[] result = message.GetRecords("ExplicitTimeRepetitionsUsed", "GetExplicitTime");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ExplicitTime Records from TQ1
        /// </summary>
        public static List<TM> GetAllExplicitTimeRecords(this TQ1 message)
        {
            return message.GetAllRecords<TM>("ExplicitTimeRepetitionsUsed", "GetExplicitTime");
        }

        /// <summary>
        /// Get RelativeTimeAndUnits Records from TQ1
        /// </summary>
        public static IEnumerable GetRelativeTimeAndUnitsRecords(this TQ1 message)
        {
            object[] result = message.GetRecords("RelativeTimeAndUnitsRepetitionsUsed", "GetRelativeTimeAndUnits");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelativeTimeAndUnits Records from TQ1
        /// </summary>
        public static List<CQ> GetAllRelativeTimeAndUnitsRecords(this TQ1 message)
        {
            return message.GetAllRecords<CQ>("RelativeTimeAndUnitsRepetitionsUsed", "GetRelativeTimeAndUnits");
        }

        /// <summary>
        /// Get Priority Records from TQ1
        /// </summary>
        public static IEnumerable GetPriorityRecords(this TQ1 message)
        {
            object[] result = message.GetRecords("PriorityRepetitionsUsed", "GetPriority");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Priority Records from TQ1
        /// </summary>
        public static List<CWE> GetAllPriorityRecords(this TQ1 message)
        {
            return message.GetAllRecords<CWE>("PriorityRepetitionsUsed", "GetPriority");
        }

        /// <summary>
        /// Get AppointmentTimingQuantity Records from SCH
        /// </summary>
        public static IEnumerable GetAppointmentTimingQuantityRecords(this SCH message)
        {
            object[] result = message.GetRecords("AppointmentTimingQuantityRepetitionsUsed", "GetAppointmentTimingQuantity");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AppointmentTimingQuantity Records from SCH
        /// </summary>
        public static List<TQ> GetAllAppointmentTimingQuantityRecords(this SCH message)
        {
            return message.GetAllRecords<TQ>("AppointmentTimingQuantityRepetitionsUsed", "GetAppointmentTimingQuantity");
        }

        /// <summary>
        /// Get PlacerContactPerson Records from SCH
        /// </summary>
        public static IEnumerable GetPlacerContactPersonRecords(this SCH message)
        {
            object[] result = message.GetRecords("PlacerContactPersonRepetitionsUsed", "GetPlacerContactPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerContactPerson Records from SCH
        /// </summary>
        public static List<XCN> GetAllPlacerContactPersonRecords(this SCH message)
        {
            return message.GetAllRecords<XCN>("PlacerContactPersonRepetitionsUsed", "GetPlacerContactPerson");
        }

        /// <summary>
        /// Get PlacerContactAddress Records from SCH
        /// </summary>
        public static IEnumerable GetPlacerContactAddressRecords(this SCH message)
        {
            object[] result = message.GetRecords("PlacerContactAddressRepetitionsUsed", "GetPlacerContactAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerContactAddress Records from SCH
        /// </summary>
        public static List<XAD> GetAllPlacerContactAddressRecords(this SCH message)
        {
            return message.GetAllRecords<XAD>("PlacerContactAddressRepetitionsUsed", "GetPlacerContactAddress");
        }

        /// <summary>
        /// Get FillerContactPerson Records from SCH
        /// </summary>
        public static IEnumerable GetFillerContactPersonRecords(this SCH message)
        {
            object[] result = message.GetRecords("FillerContactPersonRepetitionsUsed", "GetFillerContactPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerContactPerson Records from SCH
        /// </summary>
        public static List<XCN> GetAllFillerContactPersonRecords(this SCH message)
        {
            return message.GetAllRecords<XCN>("FillerContactPersonRepetitionsUsed", "GetFillerContactPerson");
        }

        /// <summary>
        /// Get FillerContactAddress Records from SCH
        /// </summary>
        public static IEnumerable GetFillerContactAddressRecords(this SCH message)
        {
            object[] result = message.GetRecords("FillerContactAddressRepetitionsUsed", "GetFillerContactAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerContactAddress Records from SCH
        /// </summary>
        public static List<XAD> GetAllFillerContactAddressRecords(this SCH message)
        {
            return message.GetAllRecords<XAD>("FillerContactAddressRepetitionsUsed", "GetFillerContactAddress");
        }

        /// <summary>
        /// Get EnteredByPerson Records from SCH
        /// </summary>
        public static IEnumerable GetEnteredByPersonRecords(this SCH message)
        {
            object[] result = message.GetRecords("EnteredByPersonRepetitionsUsed", "GetEnteredByPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EnteredByPerson Records from SCH
        /// </summary>
        public static List<XCN> GetAllEnteredByPersonRecords(this SCH message)
        {
            return message.GetAllRecords<XCN>("EnteredByPersonRepetitionsUsed", "GetEnteredByPerson");
        }

        /// <summary>
        /// Get EnteredByPhoneNumber Records from SCH
        /// </summary>
        public static IEnumerable GetEnteredByPhoneNumberRecords(this SCH message)
        {
            object[] result = message.GetRecords("EnteredByPhoneNumberRepetitionsUsed", "GetEnteredByPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EnteredByPhoneNumber Records from SCH
        /// </summary>
        public static List<XTN> GetAllEnteredByPhoneNumberRecords(this SCH message)
        {
            return message.GetAllRecords<XTN>("EnteredByPhoneNumberRepetitionsUsed", "GetEnteredByPhoneNumber");
        }

        /// <summary>
        /// Get PlacerOrderNumber Records from SCH
        /// </summary>
        public static IEnumerable GetPlacerOrderNumberRecords(this SCH message)
        {
            object[] result = message.GetRecords("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerOrderNumber Records from SCH
        /// </summary>
        public static List<EI> GetAllPlacerOrderNumberRecords(this SCH message)
        {
            return message.GetAllRecords<EI>("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");
        }

        /// <summary>
        /// Get FillerOrderNumber Records from SCH
        /// </summary>
        public static IEnumerable GetFillerOrderNumberRecords(this SCH message)
        {
            object[] result = message.GetRecords("FillerOrderNumberRepetitionsUsed", "GetFillerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerOrderNumber Records from SCH
        /// </summary>
        public static List<EI> GetAllFillerOrderNumberRecords(this SCH message)
        {
            return message.GetAllRecords<EI>("FillerOrderNumberRepetitionsUsed", "GetFillerOrderNumber");
        }

        /// <summary>
        /// Get RangeOfDecimalPrecision Records from OM2
        /// </summary>
        public static IEnumerable GetRangeOfDecimalPrecisionRecords(this OM2 message)
        {
            object[] result = message.GetRecords("RangeOfDecimalPrecisionRepetitionsUsed", "GetRangeOfDecimalPrecision");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RangeOfDecimalPrecision Records from OM2
        /// </summary>
        public static List<NM> GetAllRangeOfDecimalPrecisionRecords(this OM2 message)
        {
            return message.GetAllRecords<NM>("RangeOfDecimalPrecisionRepetitionsUsed", "GetRangeOfDecimalPrecision");
        }

        /// <summary>
        /// Get ReferenceNormalRangeOrdinalAndContinuousObservations Records from OM2
        /// </summary>
        public static IEnumerable GetReferenceNormalRangeOrdinalAndContinuousObservationsRecords(this OM2 message)
        {
            object[] result = message.GetRecords("ReferenceNormalRangeOrdinalAndContinuousObservationsRepetitionsUsed", "GetReferenceNormalRangeOrdinalAndContinuousObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferenceNormalRangeOrdinalAndContinuousObservations Records from OM2
        /// </summary>
        public static List<RFR> GetAllReferenceNormalRangeOrdinalAndContinuousObservationsRecords(this OM2 message)
        {
            return message.GetAllRecords<RFR>("ReferenceNormalRangeOrdinalAndContinuousObservationsRepetitionsUsed", "GetReferenceNormalRangeOrdinalAndContinuousObservations");
        }

        /// <summary>
        /// Get CriticalRangeForOrdinalAndContinuousObservations Records from OM2
        /// </summary>
        public static IEnumerable GetCriticalRangeForOrdinalAndContinuousObservationsRecords(this OM2 message)
        {
            object[] result = message.GetRecords("CriticalRangeForOrdinalAndContinuousObservationsRepetitionsUsed", "GetCriticalRangeForOrdinalAndContinuousObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CriticalRangeForOrdinalAndContinuousObservations Records from OM2
        /// </summary>
        public static List<RFR> GetAllCriticalRangeForOrdinalAndContinuousObservationsRecords(this OM2 message)
        {
            return message.GetAllRecords<RFR>("CriticalRangeForOrdinalAndContinuousObservationsRepetitionsUsed", "GetCriticalRangeForOrdinalAndContinuousObservations");
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
        public static List<DLT> GetAllDeltaCheckCriteriaRecords(this OM2 message)
        {
            return message.GetAllRecords<DLT>("DeltaCheckCriteriaRepetitionsUsed", "GetDeltaCheckCriteria");
        }

        /// <summary>
        /// Get Name Records from NK1
        /// </summary>
        public static IEnumerable GetNameRecords(this NK1 message)
        {
            object[] result = message.GetRecords("NameRepetitionsUsed", "GetName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Name Records from NK1
        /// </summary>
        public static List<XPN> GetAllNameRecords(this NK1 message)
        {
            return message.GetAllRecords<XPN>("NameRepetitionsUsed", "GetName");
        }

        /// <summary>
        /// Get Address Records from NK1
        /// </summary>
        public static IEnumerable GetAddressRecords(this NK1 message)
        {
            object[] result = message.GetRecords("AddressRepetitionsUsed", "GetAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Address Records from NK1
        /// </summary>
        public static List<XAD> GetAllAddressRecords(this NK1 message)
        {
            return message.GetAllRecords<XAD>("AddressRepetitionsUsed", "GetAddress");
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
        public static List<XTN> GetAllPhoneNumberRecords(this NK1 message)
        {
            return message.GetAllRecords<XTN>("PhoneNumberRepetitionsUsed", "GetPhoneNumber");
        }

        /// <summary>
        /// Get BusinessPhoneNumber Records from NK1
        /// </summary>
        public static IEnumerable GetBusinessPhoneNumberRecords(this NK1 message)
        {
            object[] result = message.GetRecords("BusinessPhoneNumberRepetitionsUsed", "GetBusinessPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BusinessPhoneNumber Records from NK1
        /// </summary>
        public static List<XTN> GetAllBusinessPhoneNumberRecords(this NK1 message)
        {
            return message.GetAllRecords<XTN>("BusinessPhoneNumberRepetitionsUsed", "GetBusinessPhoneNumber");
        }

        /// <summary>
        /// Get OrganizationNameNK1 Records from NK1
        /// </summary>
        public static IEnumerable GetOrganizationNameNK1Records(this NK1 message)
        {
            object[] result = message.GetRecords("OrganizationNameNK1RepetitionsUsed", "GetOrganizationNameNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrganizationNameNK1 Records from NK1
        /// </summary>
        public static List<XON> GetAllOrganizationNameNK1Records(this NK1 message)
        {
            return message.GetAllRecords<XON>("OrganizationNameNK1RepetitionsUsed", "GetOrganizationNameNK1");
        }

        /// <summary>
        /// Get LivingDependency Records from NK1
        /// </summary>
        public static IEnumerable GetLivingDependencyRecords(this NK1 message)
        {
            object[] result = message.GetRecords("LivingDependencyRepetitionsUsed", "GetLivingDependency");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LivingDependency Records from NK1
        /// </summary>
        public static List<IS> GetAllLivingDependencyRecords(this NK1 message)
        {
            return message.GetAllRecords<IS>("LivingDependencyRepetitionsUsed", "GetLivingDependency");
        }

        /// <summary>
        /// Get AmbulatoryStatus Records from NK1
        /// </summary>
        public static IEnumerable GetAmbulatoryStatusRecords(this NK1 message)
        {
            object[] result = message.GetRecords("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AmbulatoryStatus Records from NK1
        /// </summary>
        public static List<IS> GetAllAmbulatoryStatusRecords(this NK1 message)
        {
            return message.GetAllRecords<IS>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Get Citizenship Records from NK1
        /// </summary>
        public static IEnumerable GetCitizenshipRecords(this NK1 message)
        {
            object[] result = message.GetRecords("CitizenshipRepetitionsUsed", "GetCitizenship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Citizenship Records from NK1
        /// </summary>
        public static List<CE> GetAllCitizenshipRecords(this NK1 message)
        {
            return message.GetAllRecords<CE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Get MotherSMaidenName Records from NK1
        /// </summary>
        public static IEnumerable GetMotherSMaidenNameRecords(this NK1 message)
        {
            object[] result = message.GetRecords("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MotherSMaidenName Records from NK1
        /// </summary>
        public static List<XPN> GetAllMotherSMaidenNameRecords(this NK1 message)
        {
            return message.GetAllRecords<XPN>("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");
        }

        /// <summary>
        /// Get EthnicGroup Records from NK1
        /// </summary>
        public static IEnumerable GetEthnicGroupRecords(this NK1 message)
        {
            object[] result = message.GetRecords("EthnicGroupRepetitionsUsed", "GetEthnicGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EthnicGroup Records from NK1
        /// </summary>
        public static List<CE> GetAllEthnicGroupRecords(this NK1 message)
        {
            return message.GetAllRecords<CE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Get ContactReason Records from NK1
        /// </summary>
        public static IEnumerable GetContactReasonRecords(this NK1 message)
        {
            object[] result = message.GetRecords("ContactReasonRepetitionsUsed", "GetContactReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactReason Records from NK1
        /// </summary>
        public static List<CE> GetAllContactReasonRecords(this NK1 message)
        {
            return message.GetAllRecords<CE>("ContactReasonRepetitionsUsed", "GetContactReason");
        }

        /// <summary>
        /// Get ContactPersonSName Records from NK1
        /// </summary>
        public static IEnumerable GetContactPersonSNameRecords(this NK1 message)
        {
            object[] result = message.GetRecords("ContactPersonSNameRepetitionsUsed", "GetContactPersonSName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactPersonSName Records from NK1
        /// </summary>
        public static List<XPN> GetAllContactPersonSNameRecords(this NK1 message)
        {
            return message.GetAllRecords<XPN>("ContactPersonSNameRepetitionsUsed", "GetContactPersonSName");
        }

        /// <summary>
        /// Get ContactPersonSTelephoneNumber Records from NK1
        /// </summary>
        public static IEnumerable GetContactPersonSTelephoneNumberRecords(this NK1 message)
        {
            object[] result = message.GetRecords("ContactPersonSTelephoneNumberRepetitionsUsed", "GetContactPersonSTelephoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactPersonSTelephoneNumber Records from NK1
        /// </summary>
        public static List<XTN> GetAllContactPersonSTelephoneNumberRecords(this NK1 message)
        {
            return message.GetAllRecords<XTN>("ContactPersonSTelephoneNumberRepetitionsUsed", "GetContactPersonSTelephoneNumber");
        }

        /// <summary>
        /// Get ContactPersonSAddress Records from NK1
        /// </summary>
        public static IEnumerable GetContactPersonSAddressRecords(this NK1 message)
        {
            object[] result = message.GetRecords("ContactPersonSAddressRepetitionsUsed", "GetContactPersonSAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactPersonSAddress Records from NK1
        /// </summary>
        public static List<XAD> GetAllContactPersonSAddressRecords(this NK1 message)
        {
            return message.GetAllRecords<XAD>("ContactPersonSAddressRepetitionsUsed", "GetContactPersonSAddress");
        }

        /// <summary>
        /// Get NextOfKinAssociatedPartySIdentifiers Records from NK1
        /// </summary>
        public static IEnumerable GetNextOfKinAssociatedPartySIdentifiersRecords(this NK1 message)
        {
            object[] result = message.GetRecords("NextOfKinAssociatedPartySIdentifiersRepetitionsUsed", "GetNextOfKinAssociatedPartySIdentifiers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NextOfKinAssociatedPartySIdentifiers Records from NK1
        /// </summary>
        public static List<CX> GetAllNextOfKinAssociatedPartySIdentifiersRecords(this NK1 message)
        {
            return message.GetAllRecords<CX>("NextOfKinAssociatedPartySIdentifiersRepetitionsUsed", "GetNextOfKinAssociatedPartySIdentifiers");
        }

        /// <summary>
        /// Get Race Records from NK1
        /// </summary>
        public static IEnumerable GetRaceRecords(this NK1 message)
        {
            object[] result = message.GetRecords("RaceRepetitionsUsed", "GetRace");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Race Records from NK1
        /// </summary>
        public static List<CE> GetAllRaceRecords(this NK1 message)
        {
            return message.GetAllRecords<CE>("RaceRepetitionsUsed", "GetRace");
        }

        /// <summary>
        /// Get LocationService Records from LDP
        /// </summary>
        public static IEnumerable GetLocationServiceRecords(this LDP message)
        {
            object[] result = message.GetRecords("LocationServiceRepetitionsUsed", "GetLocationService");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationService Records from LDP
        /// </summary>
        public static List<IS> GetAllLocationServiceRecords(this LDP message)
        {
            return message.GetAllRecords<IS>("LocationServiceRepetitionsUsed", "GetLocationService");
        }

        /// <summary>
        /// Get SpecialtyType Records from LDP
        /// </summary>
        public static IEnumerable GetSpecialtyTypeRecords(this LDP message)
        {
            object[] result = message.GetRecords("SpecialtyTypeRepetitionsUsed", "GetSpecialtyType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialtyType Records from LDP
        /// </summary>
        public static List<CE> GetAllSpecialtyTypeRecords(this LDP message)
        {
            return message.GetAllRecords<CE>("SpecialtyTypeRepetitionsUsed", "GetSpecialtyType");
        }

        /// <summary>
        /// Get ValidPatientClasses Records from LDP
        /// </summary>
        public static IEnumerable GetValidPatientClassesRecords(this LDP message)
        {
            object[] result = message.GetRecords("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValidPatientClasses Records from LDP
        /// </summary>
        public static List<IS> GetAllValidPatientClassesRecords(this LDP message)
        {
            return message.GetAllRecords<IS>("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");
        }

        /// <summary>
        /// Get VisitingHours Records from LDP
        /// </summary>
        public static IEnumerable GetVisitingHoursRecords(this LDP message)
        {
            object[] result = message.GetRecords("VisitingHoursRepetitionsUsed", "GetVisitingHours");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VisitingHours Records from LDP
        /// </summary>
        public static List<VH> GetAllVisitingHoursRecords(this LDP message)
        {
            return message.GetAllRecords<VH>("VisitingHoursRepetitionsUsed", "GetVisitingHours");
        }

        /// <summary>
        /// Get DiagnosisCodeFT1 Records from FT1
        /// </summary>
        public static IEnumerable GetDiagnosisCodeFT1Records(this FT1 message)
        {
            object[] result = message.GetRecords("DiagnosisCodeFT1RepetitionsUsed", "GetDiagnosisCodeFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DiagnosisCodeFT1 Records from FT1
        /// </summary>
        public static List<CE> GetAllDiagnosisCodeFT1Records(this FT1 message)
        {
            return message.GetAllRecords<CE>("DiagnosisCodeFT1RepetitionsUsed", "GetDiagnosisCodeFT1");
        }

        /// <summary>
        /// Get PerformedByCode Records from FT1
        /// </summary>
        public static IEnumerable GetPerformedByCodeRecords(this FT1 message)
        {
            object[] result = message.GetRecords("PerformedByCodeRepetitionsUsed", "GetPerformedByCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PerformedByCode Records from FT1
        /// </summary>
        public static List<XCN> GetAllPerformedByCodeRecords(this FT1 message)
        {
            return message.GetAllRecords<XCN>("PerformedByCodeRepetitionsUsed", "GetPerformedByCode");
        }

        /// <summary>
        /// Get OrderedByCode Records from FT1
        /// </summary>
        public static IEnumerable GetOrderedByCodeRecords(this FT1 message)
        {
            object[] result = message.GetRecords("OrderedByCodeRepetitionsUsed", "GetOrderedByCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderedByCode Records from FT1
        /// </summary>
        public static List<XCN> GetAllOrderedByCodeRecords(this FT1 message)
        {
            return message.GetAllRecords<XCN>("OrderedByCodeRepetitionsUsed", "GetOrderedByCode");
        }

        /// <summary>
        /// Get EnteredByCode Records from FT1
        /// </summary>
        public static IEnumerable GetEnteredByCodeRecords(this FT1 message)
        {
            object[] result = message.GetRecords("EnteredByCodeRepetitionsUsed", "GetEnteredByCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EnteredByCode Records from FT1
        /// </summary>
        public static List<XCN> GetAllEnteredByCodeRecords(this FT1 message)
        {
            return message.GetAllRecords<XCN>("EnteredByCodeRepetitionsUsed", "GetEnteredByCode");
        }

        /// <summary>
        /// Get ProcedureCodeModifier Records from FT1
        /// </summary>
        public static IEnumerable GetProcedureCodeModifierRecords(this FT1 message)
        {
            object[] result = message.GetRecords("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCodeModifier Records from FT1
        /// </summary>
        public static List<CE> GetAllProcedureCodeModifierRecords(this FT1 message)
        {
            return message.GetAllRecords<CE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Get TransactionReferenceKey Records from FT1
        /// </summary>
        public static IEnumerable GetTransactionReferenceKeyRecords(this FT1 message)
        {
            object[] result = message.GetRecords("TransactionReferenceKeyRepetitionsUsed", "GetTransactionReferenceKey");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TransactionReferenceKey Records from FT1
        /// </summary>
        public static List<SI> GetAllTransactionReferenceKeyRecords(this FT1 message)
        {
            return message.GetAllRecords<SI>("TransactionReferenceKeyRepetitionsUsed", "GetTransactionReferenceKey");
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
        public static List<IS> GetAllConditionCode3539Records(this UB1 message)
        {
            return message.GetAllRecords<IS>("ConditionCode3539RepetitionsUsed", "GetConditionCode3539");
        }

        /// <summary>
        /// Get ValueAmountCode4649 Records from UB1
        /// </summary>
        public static IEnumerable GetValueAmountCode4649Records(this UB1 message)
        {
            object[] result = message.GetRecords("ValueAmountCode4649RepetitionsUsed", "GetValueAmountCode4649");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValueAmountCode4649 Records from UB1
        /// </summary>
        public static List<UVC> GetAllValueAmountCode4649Records(this UB1 message)
        {
            return message.GetAllRecords<UVC>("ValueAmountCode4649RepetitionsUsed", "GetValueAmountCode4649");
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
        public static List<OCD> GetAllOccurrence2832Records(this UB1 message)
        {
            return message.GetAllRecords<OCD>("Occurrence2832RepetitionsUsed", "GetOccurrence2832");
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
        public static List<CE> GetAllObservationProducingDepartmentSectionRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("ObservationProducingDepartmentSectionRepetitionsUsed", "GetObservationProducingDepartmentSection");
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
        public static List<XAD> GetAllAddressOfOutsideSiteSRecords(this OM1 message)
        {
            return message.GetAllRecords<XAD>("AddressOfOutsideSiteSRepetitionsUsed", "GetAddressOfOutsideSiteS");
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
        /// Get ServiceTestObservationPerformanceSchedule Records from OM1
        /// </summary>
        public static IEnumerable GetServiceTestObservationPerformanceScheduleRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ServiceTestObservationPerformanceScheduleRepetitionsUsed", "GetServiceTestObservationPerformanceSchedule");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ServiceTestObservationPerformanceSchedule Records from OM1
        /// </summary>
        public static List<ST> GetAllServiceTestObservationPerformanceScheduleRecords(this OM1 message)
        {
            return message.GetAllRecords<ST>("ServiceTestObservationPerformanceScheduleRepetitionsUsed", "GetServiceTestObservationPerformanceSchedule");
        }

        /// <summary>
        /// Get OrganizationalLocationRelationshipValue Records from LRL
        /// </summary>
        public static IEnumerable GetOrganizationalLocationRelationshipValueRecords(this LRL message)
        {
            object[] result = message.GetRecords("OrganizationalLocationRelationshipValueRepetitionsUsed", "GetOrganizationalLocationRelationshipValue");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrganizationalLocationRelationshipValue Records from LRL
        /// </summary>
        public static List<XON> GetAllOrganizationalLocationRelationshipValueRecords(this LRL message)
        {
            return message.GetAllRecords<XON>("OrganizationalLocationRelationshipValueRepetitionsUsed", "GetOrganizationalLocationRelationshipValue");
        }

        /// <summary>
        /// Get Parameters Records from ECD
        /// </summary>
        public static IEnumerable GetParametersRecords(this ECD message)
        {
            object[] result = message.GetRecords("ParametersRepetitionsUsed", "GetParameters");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Parameters Records from ECD
        /// </summary>
        public static List<TX> GetAllParametersRecords(this ECD message)
        {
            return message.GetAllRecords<TX>("ParametersRepetitionsUsed", "GetParameters");
        }

        /// <summary>
        /// Get DisabledPersonIdentifier Records from DB1
        /// </summary>
        public static IEnumerable GetDisabledPersonIdentifierRecords(this DB1 message)
        {
            object[] result = message.GetRecords("DisabledPersonIdentifierRepetitionsUsed", "GetDisabledPersonIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DisabledPersonIdentifier Records from DB1
        /// </summary>
        public static List<CX> GetAllDisabledPersonIdentifierRecords(this DB1 message)
        {
            return message.GetAllRecords<CX>("DisabledPersonIdentifierRepetitionsUsed", "GetDisabledPersonIdentifier");
        }

        /// <summary>
        /// Get BPAdverseReactionType Records from BTX
        /// </summary>
        public static IEnumerable GetBPAdverseReactionTypeRecords(this BTX message)
        {
            object[] result = message.GetRecords("BPAdverseReactionTypeRepetitionsUsed", "GetBPAdverseReactionType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BPAdverseReactionType Records from BTX
        /// </summary>
        public static List<CWE> GetAllBPAdverseReactionTypeRecords(this BTX message)
        {
            return message.GetAllRecords<CWE>("BPAdverseReactionTypeRepetitionsUsed", "GetBPAdverseReactionType");
        }

        /// <summary>
        /// Get VarianceOriginator Records from VAR
        /// </summary>
        public static IEnumerable GetVarianceOriginatorRecords(this VAR message)
        {
            object[] result = message.GetRecords("VarianceOriginatorRepetitionsUsed", "GetVarianceOriginator");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VarianceOriginator Records from VAR
        /// </summary>
        public static List<XCN> GetAllVarianceOriginatorRecords(this VAR message)
        {
            return message.GetAllRecords<XCN>("VarianceOriginatorRepetitionsUsed", "GetVarianceOriginator");
        }

        /// <summary>
        /// Get VarianceDescription Records from VAR
        /// </summary>
        public static IEnumerable GetVarianceDescriptionRecords(this VAR message)
        {
            object[] result = message.GetRecords("VarianceDescriptionRepetitionsUsed", "GetVarianceDescription");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VarianceDescription Records from VAR
        /// </summary>
        public static List<ST> GetAllVarianceDescriptionRecords(this VAR message)
        {
            return message.GetAllRecords<ST>("VarianceDescriptionRepetitionsUsed", "GetVarianceDescription");
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
        /// Get StaffIdentifierList Records from STF
        /// </summary>
        public static IEnumerable GetStaffIdentifierListRecords(this STF message)
        {
            object[] result = message.GetRecords("StaffIdentifierListRepetitionsUsed", "GetStaffIdentifierList");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StaffIdentifierList Records from STF
        /// </summary>
        public static List<CX> GetAllStaffIdentifierListRecords(this STF message)
        {
            return message.GetAllRecords<CX>("StaffIdentifierListRepetitionsUsed", "GetStaffIdentifierList");
        }

        /// <summary>
        /// Get StaffName Records from STF
        /// </summary>
        public static IEnumerable GetStaffNameRecords(this STF message)
        {
            object[] result = message.GetRecords("StaffNameRepetitionsUsed", "GetStaffName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StaffName Records from STF
        /// </summary>
        public static List<XPN> GetAllStaffNameRecords(this STF message)
        {
            return message.GetAllRecords<XPN>("StaffNameRepetitionsUsed", "GetStaffName");
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
        public static List<IS> GetAllStaffTypeRecords(this STF message)
        {
            return message.GetAllRecords<IS>("StaffTypeRepetitionsUsed", "GetStaffType");
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
        /// Get HospitalServiceSTF Records from STF
        /// </summary>
        public static IEnumerable GetHospitalServiceSTFRecords(this STF message)
        {
            object[] result = message.GetRecords("HospitalServiceSTFRepetitionsUsed", "GetHospitalServiceSTF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all HospitalServiceSTF Records from STF
        /// </summary>
        public static List<CE> GetAllHospitalServiceSTFRecords(this STF message)
        {
            return message.GetAllRecords<CE>("HospitalServiceSTFRepetitionsUsed", "GetHospitalServiceSTF");
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
        public static List<XTN> GetAllPhoneRecords(this STF message)
        {
            return message.GetAllRecords<XTN>("PhoneRepetitionsUsed", "GetPhone");
        }

        /// <summary>
        /// Get OfficeHomeAddressBirthplace Records from STF
        /// </summary>
        public static IEnumerable GetOfficeHomeAddressBirthplaceRecords(this STF message)
        {
            object[] result = message.GetRecords("OfficeHomeAddressBirthplaceRepetitionsUsed", "GetOfficeHomeAddressBirthplace");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OfficeHomeAddressBirthplace Records from STF
        /// </summary>
        public static List<XAD> GetAllOfficeHomeAddressBirthplaceRecords(this STF message)
        {
            return message.GetAllRecords<XAD>("OfficeHomeAddressBirthplaceRepetitionsUsed", "GetOfficeHomeAddressBirthplace");
        }

        /// <summary>
        /// Get InstitutionActivationDate Records from STF
        /// </summary>
        public static IEnumerable GetInstitutionActivationDateRecords(this STF message)
        {
            object[] result = message.GetRecords("InstitutionActivationDateRepetitionsUsed", "GetInstitutionActivationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InstitutionActivationDate Records from STF
        /// </summary>
        public static List<DIN> GetAllInstitutionActivationDateRecords(this STF message)
        {
            return message.GetAllRecords<DIN>("InstitutionActivationDateRepetitionsUsed", "GetInstitutionActivationDate");
        }

        /// <summary>
        /// Get InstitutionInactivationDate Records from STF
        /// </summary>
        public static IEnumerable GetInstitutionInactivationDateRecords(this STF message)
        {
            object[] result = message.GetRecords("InstitutionInactivationDateRepetitionsUsed", "GetInstitutionInactivationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InstitutionInactivationDate Records from STF
        /// </summary>
        public static List<DIN> GetAllInstitutionInactivationDateRecords(this STF message)
        {
            return message.GetAllRecords<DIN>("InstitutionInactivationDateRepetitionsUsed", "GetInstitutionInactivationDate");
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
        /// Get Citizenship Records from STF
        /// </summary>
        public static IEnumerable GetCitizenshipRecords(this STF message)
        {
            object[] result = message.GetRecords("CitizenshipRepetitionsUsed", "GetCitizenship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Citizenship Records from STF
        /// </summary>
        public static List<CE> GetAllCitizenshipRecords(this STF message)
        {
            return message.GetAllRecords<CE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Get CostCenterCode Records from STF
        /// </summary>
        public static IEnumerable GetCostCenterCodeRecords(this STF message)
        {
            object[] result = message.GetRecords("CostCenterCodeRepetitionsUsed", "GetCostCenterCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CostCenterCode Records from STF
        /// </summary>
        public static List<CWE> GetAllCostCenterCodeRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("CostCenterCodeRepetitionsUsed", "GetCostCenterCode");
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
        /// Get NumberOfProductExperienceReportsFiledByFacility Records from PSH
        /// </summary>
        public static IEnumerable GetNumberOfProductExperienceReportsFiledByFacilityRecords(this PSH message)
        {
            object[] result = message.GetRecords("NumberOfProductExperienceReportsFiledByFacilityRepetitionsUsed", "GetNumberOfProductExperienceReportsFiledByFacility");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NumberOfProductExperienceReportsFiledByFacility Records from PSH
        /// </summary>
        public static List<NM> GetAllNumberOfProductExperienceReportsFiledByFacilityRecords(this PSH message)
        {
            return message.GetAllRecords<NM>("NumberOfProductExperienceReportsFiledByFacilityRepetitionsUsed", "GetNumberOfProductExperienceReportsFiledByFacility");
        }

        /// <summary>
        /// Get NumberOfProductExperienceReportsFiledByDistributor Records from PSH
        /// </summary>
        public static IEnumerable GetNumberOfProductExperienceReportsFiledByDistributorRecords(this PSH message)
        {
            object[] result = message.GetRecords("NumberOfProductExperienceReportsFiledByDistributorRepetitionsUsed", "GetNumberOfProductExperienceReportsFiledByDistributor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NumberOfProductExperienceReportsFiledByDistributor Records from PSH
        /// </summary>
        public static List<NM> GetAllNumberOfProductExperienceReportsFiledByDistributorRecords(this PSH message)
        {
            return message.GetAllRecords<NM>("NumberOfProductExperienceReportsFiledByDistributorRepetitionsUsed", "GetNumberOfProductExperienceReportsFiledByDistributor");
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
        public static List<ELD> GetAllErrorCodeAndLocationRecords(this ERR message)
        {
            return message.GetAllRecords<ELD>("ErrorCodeAndLocationRepetitionsUsed", "GetErrorCodeAndLocation");
        }

        /// <summary>
        /// Get ErrorLocation Records from ERR
        /// </summary>
        public static IEnumerable GetErrorLocationRecords(this ERR message)
        {
            object[] result = message.GetRecords("ErrorLocationRepetitionsUsed", "GetErrorLocation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ErrorLocation Records from ERR
        /// </summary>
        public static List<ERL> GetAllErrorLocationRecords(this ERR message)
        {
            return message.GetAllRecords<ERL>("ErrorLocationRepetitionsUsed", "GetErrorLocation");
        }

        /// <summary>
        /// Get ApplicationErrorParameter Records from ERR
        /// </summary>
        public static IEnumerable GetApplicationErrorParameterRecords(this ERR message)
        {
            object[] result = message.GetRecords("ApplicationErrorParameterRepetitionsUsed", "GetApplicationErrorParameter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ApplicationErrorParameter Records from ERR
        /// </summary>
        public static List<ST> GetAllApplicationErrorParameterRecords(this ERR message)
        {
            return message.GetAllRecords<ST>("ApplicationErrorParameterRepetitionsUsed", "GetApplicationErrorParameter");
        }

        /// <summary>
        /// Get InformPersonIndicator Records from ERR
        /// </summary>
        public static IEnumerable GetInformPersonIndicatorRecords(this ERR message)
        {
            object[] result = message.GetRecords("InformPersonIndicatorRepetitionsUsed", "GetInformPersonIndicator");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InformPersonIndicator Records from ERR
        /// </summary>
        public static List<IS> GetAllInformPersonIndicatorRecords(this ERR message)
        {
            return message.GetAllRecords<IS>("InformPersonIndicatorRepetitionsUsed", "GetInformPersonIndicator");
        }

        /// <summary>
        /// Get OverrideReasonCode Records from ERR
        /// </summary>
        public static IEnumerable GetOverrideReasonCodeRecords(this ERR message)
        {
            object[] result = message.GetRecords("OverrideReasonCodeRepetitionsUsed", "GetOverrideReasonCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OverrideReasonCode Records from ERR
        /// </summary>
        public static List<CWE> GetAllOverrideReasonCodeRecords(this ERR message)
        {
            return message.GetAllRecords<CWE>("OverrideReasonCodeRepetitionsUsed", "GetOverrideReasonCode");
        }

        /// <summary>
        /// Get HelpDeskContactPoint Records from ERR
        /// </summary>
        public static IEnumerable GetHelpDeskContactPointRecords(this ERR message)
        {
            object[] result = message.GetRecords("HelpDeskContactPointRepetitionsUsed", "GetHelpDeskContactPoint");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all HelpDeskContactPoint Records from ERR
        /// </summary>
        public static List<XTN> GetAllHelpDeskContactPointRecords(this ERR message)
        {
            return message.GetAllRecords<XTN>("HelpDeskContactPointRepetitionsUsed", "GetHelpDeskContactPoint");
        }

        /// <summary>
        /// Get MajorFieldOfStudy Records from EDU
        /// </summary>
        public static IEnumerable GetMajorFieldOfStudyRecords(this EDU message)
        {
            object[] result = message.GetRecords("MajorFieldOfStudyRepetitionsUsed", "GetMajorFieldOfStudy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MajorFieldOfStudy Records from EDU
        /// </summary>
        public static List<CWE> GetAllMajorFieldOfStudyRecords(this EDU message)
        {
            return message.GetAllRecords<CWE>("MajorFieldOfStudyRepetitionsUsed", "GetMajorFieldOfStudy");
        }

        /// <summary>
        /// Get InputParameterList Records from SPR
        /// </summary>
        public static IEnumerable GetInputParameterListRecords(this SPR message)
        {
            object[] result = message.GetRecords("InputParameterListRepetitionsUsed", "GetInputParameterList");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InputParameterList Records from SPR
        /// </summary>
        public static List<QIP> GetAllInputParameterListRecords(this SPR message)
        {
            return message.GetAllRecords<QIP>("InputParameterListRepetitionsUsed", "GetInputParameterList");
        }

        /// <summary>
        /// Get Location Records from SAC
        /// </summary>
        public static IEnumerable GetLocationRecords(this SAC message)
        {
            object[] result = message.GetRecords("LocationRepetitionsUsed", "GetLocation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Location Records from SAC
        /// </summary>
        public static List<CE> GetAllLocationRecords(this SAC message)
        {
            return message.GetAllRecords<CE>("LocationRepetitionsUsed", "GetLocation");
        }

        /// <summary>
        /// Get Additive Records from SAC
        /// </summary>
        public static IEnumerable GetAdditiveRecords(this SAC message)
        {
            object[] result = message.GetRecords("AdditiveRepetitionsUsed", "GetAdditive");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Additive Records from SAC
        /// </summary>
        public static List<CWE> GetAllAdditiveRecords(this SAC message)
        {
            return message.GetAllRecords<CWE>("AdditiveRepetitionsUsed", "GetAdditive");
        }

        /// <summary>
        /// Get SystemInducedContaminants Records from SAC
        /// </summary>
        public static IEnumerable GetSystemInducedContaminantsRecords(this SAC message)
        {
            object[] result = message.GetRecords("SystemInducedContaminantsRepetitionsUsed", "GetSystemInducedContaminants");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SystemInducedContaminants Records from SAC
        /// </summary>
        public static List<CE> GetAllSystemInducedContaminantsRecords(this SAC message)
        {
            return message.GetAllRecords<CE>("SystemInducedContaminantsRepetitionsUsed", "GetSystemInducedContaminants");
        }

        /// <summary>
        /// Get DrugInterference Records from SAC
        /// </summary>
        public static IEnumerable GetDrugInterferenceRecords(this SAC message)
        {
            object[] result = message.GetRecords("DrugInterferenceRepetitionsUsed", "GetDrugInterference");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DrugInterference Records from SAC
        /// </summary>
        public static List<CE> GetAllDrugInterferenceRecords(this SAC message)
        {
            return message.GetAllRecords<CE>("DrugInterferenceRepetitionsUsed", "GetDrugInterference");
        }

        /// <summary>
        /// Get SpecialHandlingCode Records from SAC
        /// </summary>
        public static IEnumerable GetSpecialHandlingCodeRecords(this SAC message)
        {
            object[] result = message.GetRecords("SpecialHandlingCodeRepetitionsUsed", "GetSpecialHandlingCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialHandlingCode Records from SAC
        /// </summary>
        public static List<CWE> GetAllSpecialHandlingCodeRecords(this SAC message)
        {
            return message.GetAllRecords<CWE>("SpecialHandlingCodeRepetitionsUsed", "GetSpecialHandlingCode");
        }

        /// <summary>
        /// Get OtherEnvironmentalFactors Records from SAC
        /// </summary>
        public static IEnumerable GetOtherEnvironmentalFactorsRecords(this SAC message)
        {
            object[] result = message.GetRecords("OtherEnvironmentalFactorsRepetitionsUsed", "GetOtherEnvironmentalFactors");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherEnvironmentalFactors Records from SAC
        /// </summary>
        public static List<CE> GetAllOtherEnvironmentalFactorsRecords(this SAC message)
        {
            return message.GetAllRecords<CE>("OtherEnvironmentalFactorsRepetitionsUsed", "GetOtherEnvironmentalFactors");
        }

        /// <summary>
        /// Get AllergyReactionCode Records from IAM
        /// </summary>
        public static IEnumerable GetAllergyReactionCodeRecords(this IAM message)
        {
            object[] result = message.GetRecords("AllergyReactionCodeRepetitionsUsed", "GetAllergyReactionCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AllergyReactionCode Records from IAM
        /// </summary>
        public static List<ST> GetAllAllergyReactionCodeRecords(this IAM message)
        {
            return message.GetAllRecords<ST>("AllergyReactionCodeRepetitionsUsed", "GetAllergyReactionCode");
        }

        /// <summary>
        /// Get GoalEvaluationComment Records from GOL
        /// </summary>
        public static IEnumerable GetGoalEvaluationCommentRecords(this GOL message)
        {
            object[] result = message.GetRecords("GoalEvaluationCommentRepetitionsUsed", "GetGoalEvaluationComment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GoalEvaluationComment Records from GOL
        /// </summary>
        public static List<ST> GetAllGoalEvaluationCommentRecords(this GOL message)
        {
            return message.GetAllRecords<ST>("GoalEvaluationCommentRepetitionsUsed", "GetGoalEvaluationComment");
        }

        /// <summary>
        /// Get GoalTargetType Records from GOL
        /// </summary>
        public static IEnumerable GetGoalTargetTypeRecords(this GOL message)
        {
            object[] result = message.GetRecords("GoalTargetTypeRepetitionsUsed", "GetGoalTargetType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GoalTargetType Records from GOL
        /// </summary>
        public static List<CE> GetAllGoalTargetTypeRecords(this GOL message)
        {
            return message.GetAllRecords<CE>("GoalTargetTypeRepetitionsUsed", "GetGoalTargetType");
        }

        /// <summary>
        /// Get GoalTargetName Records from GOL
        /// </summary>
        public static IEnumerable GetGoalTargetNameRecords(this GOL message)
        {
            object[] result = message.GetRecords("GoalTargetNameRepetitionsUsed", "GetGoalTargetName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GoalTargetName Records from GOL
        /// </summary>
        public static List<XPN> GetAllGoalTargetNameRecords(this GOL message)
        {
            return message.GetAllRecords<XPN>("GoalTargetNameRepetitionsUsed", "GetGoalTargetName");
        }

        /// <summary>
        /// Get InputParameterList Records from ERQ
        /// </summary>
        public static IEnumerable GetInputParameterListRecords(this ERQ message)
        {
            object[] result = message.GetRecords("InputParameterListRepetitionsUsed", "GetInputParameterList");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InputParameterList Records from ERQ
        /// </summary>
        public static List<QIP> GetAllInputParameterListRecords(this ERQ message)
        {
            return message.GetAllRecords<QIP>("InputParameterListRepetitionsUsed", "GetInputParameterList");
        }

        /// <summary>
        /// Get ContactRole Records from CTD
        /// </summary>
        public static IEnumerable GetContactRoleRecords(this CTD message)
        {
            object[] result = message.GetRecords("ContactRoleRepetitionsUsed", "GetContactRole");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactRole Records from CTD
        /// </summary>
        public static List<CE> GetAllContactRoleRecords(this CTD message)
        {
            return message.GetAllRecords<CE>("ContactRoleRepetitionsUsed", "GetContactRole");
        }

        /// <summary>
        /// Get ContactName Records from CTD
        /// </summary>
        public static IEnumerable GetContactNameRecords(this CTD message)
        {
            object[] result = message.GetRecords("ContactNameRepetitionsUsed", "GetContactName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactName Records from CTD
        /// </summary>
        public static List<XPN> GetAllContactNameRecords(this CTD message)
        {
            return message.GetAllRecords<XPN>("ContactNameRepetitionsUsed", "GetContactName");
        }

        /// <summary>
        /// Get ContactAddress Records from CTD
        /// </summary>
        public static IEnumerable GetContactAddressRecords(this CTD message)
        {
            object[] result = message.GetRecords("ContactAddressRepetitionsUsed", "GetContactAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactAddress Records from CTD
        /// </summary>
        public static List<XAD> GetAllContactAddressRecords(this CTD message)
        {
            return message.GetAllRecords<XAD>("ContactAddressRepetitionsUsed", "GetContactAddress");
        }

        /// <summary>
        /// Get ContactCommunicationInformation Records from CTD
        /// </summary>
        public static IEnumerable GetContactCommunicationInformationRecords(this CTD message)
        {
            object[] result = message.GetRecords("ContactCommunicationInformationRepetitionsUsed", "GetContactCommunicationInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactCommunicationInformation Records from CTD
        /// </summary>
        public static List<XTN> GetAllContactCommunicationInformationRecords(this CTD message)
        {
            return message.GetAllRecords<XTN>("ContactCommunicationInformationRepetitionsUsed", "GetContactCommunicationInformation");
        }

        /// <summary>
        /// Get ContactIdentifiers Records from CTD
        /// </summary>
        public static IEnumerable GetContactIdentifiersRecords(this CTD message)
        {
            object[] result = message.GetRecords("ContactIdentifiersRepetitionsUsed", "GetContactIdentifiers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactIdentifiers Records from CTD
        /// </summary>
        public static List<PLN> GetAllContactIdentifiersRecords(this CTD message)
        {
            return message.GetAllRecords<PLN>("ContactIdentifiersRepetitionsUsed", "GetContactIdentifiers");
        }

        /// <summary>
        /// Get LocationResourceID Records from AIL
        /// </summary>
        public static IEnumerable GetLocationResourceIDRecords(this AIL message)
        {
            object[] result = message.GetRecords("LocationResourceIDRepetitionsUsed", "GetLocationResourceID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationResourceID Records from AIL
        /// </summary>
        public static List<PL> GetAllLocationResourceIDRecords(this AIL message)
        {
            return message.GetAllRecords<PL>("LocationResourceIDRepetitionsUsed", "GetLocationResourceID");
        }

        /// <summary>
        /// Get ColumnDescription Records from RDF
        /// </summary>
        public static IEnumerable GetColumnDescriptionRecords(this RDF message)
        {
            object[] result = message.GetRecords("ColumnDescriptionRepetitionsUsed", "GetColumnDescription");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ColumnDescription Records from RDF
        /// </summary>
        public static List<RCD> GetAllColumnDescriptionRecords(this RDF message)
        {
            return message.GetAllRecords<RCD>("ColumnDescriptionRepetitionsUsed", "GetColumnDescription");
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
        public static List<XCN> GetAllWhoSubjectFilterRecords(this QRD message)
        {
            return message.GetAllRecords<XCN>("WhoSubjectFilterRepetitionsUsed", "GetWhoSubjectFilter");
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
        public static List<CE> GetAllWhatSubjectFilterRecords(this QRD message)
        {
            return message.GetAllRecords<CE>("WhatSubjectFilterRepetitionsUsed", "GetWhatSubjectFilter");
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
        public static List<CE> GetAllWhatDepartmentDataCodeRecords(this QRD message)
        {
            return message.GetAllRecords<CE>("WhatDepartmentDataCodeRepetitionsUsed", "GetWhatDepartmentDataCode");
        }

        /// <summary>
        /// Get WhatDataCodeValueQual Records from QRD
        /// </summary>
        public static IEnumerable GetWhatDataCodeValueQualRecords(this QRD message)
        {
            object[] result = message.GetRecords("WhatDataCodeValueQualRepetitionsUsed", "GetWhatDataCodeValueQual");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all WhatDataCodeValueQual Records from QRD
        /// </summary>
        public static List<VR> GetAllWhatDataCodeValueQualRecords(this QRD message)
        {
            return message.GetAllRecords<VR>("WhatDataCodeValueQualRepetitionsUsed", "GetWhatDataCodeValueQual");
        }

        /// <summary>
        /// Get ObservationValue Records from OBX
        /// </summary>
        public static IEnumerable GetObservationValueRecords(this OBX message)
        {
            object[] result = message.GetRecords("ObservationValueRepetitionsUsed", "GetObservationValue");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ObservationValue Records from OBX
        /// </summary>
        public static List<Varies> GetAllObservationValueRecords(this OBX message)
        {
            return message.GetAllRecords<Varies>("ObservationValueRepetitionsUsed", "GetObservationValue");
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
        public static List<IS> GetAllAbnormalFlagsRecords(this OBX message)
        {
            return message.GetAllRecords<IS>("AbnormalFlagsRepetitionsUsed", "GetAbnormalFlags");
        }

        /// <summary>
        /// Get NatureOfAbnormalTest Records from OBX
        /// </summary>
        public static IEnumerable GetNatureOfAbnormalTestRecords(this OBX message)
        {
            object[] result = message.GetRecords("NatureOfAbnormalTestRepetitionsUsed", "GetNatureOfAbnormalTest");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NatureOfAbnormalTest Records from OBX
        /// </summary>
        public static List<ID> GetAllNatureOfAbnormalTestRecords(this OBX message)
        {
            return message.GetAllRecords<ID>("NatureOfAbnormalTestRepetitionsUsed", "GetNatureOfAbnormalTest");
        }

        /// <summary>
        /// Get ResponsibleObserver Records from OBX
        /// </summary>
        public static IEnumerable GetResponsibleObserverRecords(this OBX message)
        {
            object[] result = message.GetRecords("ResponsibleObserverRepetitionsUsed", "GetResponsibleObserver");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ResponsibleObserver Records from OBX
        /// </summary>
        public static List<XCN> GetAllResponsibleObserverRecords(this OBX message)
        {
            return message.GetAllRecords<XCN>("ResponsibleObserverRepetitionsUsed", "GetResponsibleObserver");
        }

        /// <summary>
        /// Get ObservationMethod Records from OBX
        /// </summary>
        public static IEnumerable GetObservationMethodRecords(this OBX message)
        {
            object[] result = message.GetRecords("ObservationMethodRepetitionsUsed", "GetObservationMethod");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ObservationMethod Records from OBX
        /// </summary>
        public static List<CE> GetAllObservationMethodRecords(this OBX message)
        {
            return message.GetAllRecords<CE>("ObservationMethodRepetitionsUsed", "GetObservationMethod");
        }

        /// <summary>
        /// Get EquipmentInstanceIdentifier Records from OBX
        /// </summary>
        public static IEnumerable GetEquipmentInstanceIdentifierRecords(this OBX message)
        {
            object[] result = message.GetRecords("EquipmentInstanceIdentifierRepetitionsUsed", "GetEquipmentInstanceIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EquipmentInstanceIdentifier Records from OBX
        /// </summary>
        public static List<EI> GetAllEquipmentInstanceIdentifierRecords(this OBX message)
        {
            return message.GetAllRecords<EI>("EquipmentInstanceIdentifierRepetitionsUsed", "GetEquipmentInstanceIdentifier");
        }

        /// <summary>
        /// Get CommandResponseParameters Records from ECR
        /// </summary>
        public static IEnumerable GetCommandResponseParametersRecords(this ECR message)
        {
            object[] result = message.GetRecords("CommandResponseParametersRepetitionsUsed", "GetCommandResponseParameters");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CommandResponseParameters Records from ECR
        /// </summary>
        public static List<TX> GetAllCommandResponseParametersRecords(this ECR message)
        {
            return message.GetAllRecords<TX>("CommandResponseParametersRepetitionsUsed", "GetCommandResponseParameters");
        }

        /// <summary>
        /// Get StudyQualityControlCodes Records from CSS
        /// </summary>
        public static IEnumerable GetStudyQualityControlCodesRecords(this CSS message)
        {
            object[] result = message.GetRecords("StudyQualityControlCodesRepetitionsUsed", "GetStudyQualityControlCodes");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StudyQualityControlCodes Records from CSS
        /// </summary>
        public static List<CE> GetAllStudyQualityControlCodesRecords(this CSS message)
        {
            return message.GetAllRecords<CE>("StudyQualityControlCodesRepetitionsUsed", "GetStudyQualityControlCodes");
        }

        /// <summary>
        /// Get TimeSelectionCriteria Records from APR
        /// </summary>
        public static IEnumerable GetTimeSelectionCriteriaRecords(this APR message)
        {
            object[] result = message.GetRecords("TimeSelectionCriteriaRepetitionsUsed", "GetTimeSelectionCriteria");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TimeSelectionCriteria Records from APR
        /// </summary>
        public static List<SCV> GetAllTimeSelectionCriteriaRecords(this APR message)
        {
            return message.GetAllRecords<SCV>("TimeSelectionCriteriaRepetitionsUsed", "GetTimeSelectionCriteria");
        }

        /// <summary>
        /// Get ResourceSelectionCriteria Records from APR
        /// </summary>
        public static IEnumerable GetResourceSelectionCriteriaRecords(this APR message)
        {
            object[] result = message.GetRecords("ResourceSelectionCriteriaRepetitionsUsed", "GetResourceSelectionCriteria");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ResourceSelectionCriteria Records from APR
        /// </summary>
        public static List<SCV> GetAllResourceSelectionCriteriaRecords(this APR message)
        {
            return message.GetAllRecords<SCV>("ResourceSelectionCriteriaRepetitionsUsed", "GetResourceSelectionCriteria");
        }

        /// <summary>
        /// Get LocationSelectionCriteria Records from APR
        /// </summary>
        public static IEnumerable GetLocationSelectionCriteriaRecords(this APR message)
        {
            object[] result = message.GetRecords("LocationSelectionCriteriaRepetitionsUsed", "GetLocationSelectionCriteria");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationSelectionCriteria Records from APR
        /// </summary>
        public static List<SCV> GetAllLocationSelectionCriteriaRecords(this APR message)
        {
            return message.GetAllRecords<SCV>("LocationSelectionCriteriaRepetitionsUsed", "GetLocationSelectionCriteria");
        }

        /// <summary>
        /// Get FillerOverrideCriteria Records from APR
        /// </summary>
        public static IEnumerable GetFillerOverrideCriteriaRecords(this APR message)
        {
            object[] result = message.GetRecords("FillerOverrideCriteriaRepetitionsUsed", "GetFillerOverrideCriteria");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerOverrideCriteria Records from APR
        /// </summary>
        public static List<SCV> GetAllFillerOverrideCriteriaRecords(this APR message)
        {
            return message.GetAllRecords<SCV>("FillerOverrideCriteriaRepetitionsUsed", "GetFillerOverrideCriteria");
        }

        /// <summary>
        /// Get SelectionCriteria Records from VTQ
        /// </summary>
        public static IEnumerable GetSelectionCriteriaRecords(this VTQ message)
        {
            object[] result = message.GetRecords("SelectionCriteriaRepetitionsUsed", "GetSelectionCriteria");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SelectionCriteria Records from VTQ
        /// </summary>
        public static List<QSC> GetAllSelectionCriteriaRecords(this VTQ message)
        {
            return message.GetAllRecords<QSC>("SelectionCriteriaRepetitionsUsed", "GetSelectionCriteria");
        }

        /// <summary>
        /// Get ProviderRole Records from PRD
        /// </summary>
        public static IEnumerable GetProviderRoleRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderRoleRepetitionsUsed", "GetProviderRole");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderRole Records from PRD
        /// </summary>
        public static List<CE> GetAllProviderRoleRecords(this PRD message)
        {
            return message.GetAllRecords<CE>("ProviderRoleRepetitionsUsed", "GetProviderRole");
        }

        /// <summary>
        /// Get ProviderName Records from PRD
        /// </summary>
        public static IEnumerable GetProviderNameRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderNameRepetitionsUsed", "GetProviderName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderName Records from PRD
        /// </summary>
        public static List<XPN> GetAllProviderNameRecords(this PRD message)
        {
            return message.GetAllRecords<XPN>("ProviderNameRepetitionsUsed", "GetProviderName");
        }

        /// <summary>
        /// Get ProviderAddress Records from PRD
        /// </summary>
        public static IEnumerable GetProviderAddressRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderAddressRepetitionsUsed", "GetProviderAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderAddress Records from PRD
        /// </summary>
        public static List<XAD> GetAllProviderAddressRecords(this PRD message)
        {
            return message.GetAllRecords<XAD>("ProviderAddressRepetitionsUsed", "GetProviderAddress");
        }

        /// <summary>
        /// Get ProviderCommunicationInformation Records from PRD
        /// </summary>
        public static IEnumerable GetProviderCommunicationInformationRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderCommunicationInformationRepetitionsUsed", "GetProviderCommunicationInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderCommunicationInformation Records from PRD
        /// </summary>
        public static List<XTN> GetAllProviderCommunicationInformationRecords(this PRD message)
        {
            return message.GetAllRecords<XTN>("ProviderCommunicationInformationRepetitionsUsed", "GetProviderCommunicationInformation");
        }

        /// <summary>
        /// Get ProviderIdentifiers Records from PRD
        /// </summary>
        public static IEnumerable GetProviderIdentifiersRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderIdentifiersRepetitionsUsed", "GetProviderIdentifiers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderIdentifiers Records from PRD
        /// </summary>
        public static List<PLN> GetAllProviderIdentifiersRecords(this PRD message)
        {
            return message.GetAllRecords<PLN>("ProviderIdentifiersRepetitionsUsed", "GetProviderIdentifiers");
        }

        /// <summary>
        /// Get Anesthesiologist Records from PR1
        /// </summary>
        public static IEnumerable GetAnesthesiologistRecords(this PR1 message)
        {
            object[] result = message.GetRecords("AnesthesiologistRepetitionsUsed", "GetAnesthesiologist");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Anesthesiologist Records from PR1
        /// </summary>
        public static List<XCN> GetAllAnesthesiologistRecords(this PR1 message)
        {
            return message.GetAllRecords<XCN>("AnesthesiologistRepetitionsUsed", "GetAnesthesiologist");
        }

        /// <summary>
        /// Get Surgeon Records from PR1
        /// </summary>
        public static IEnumerable GetSurgeonRecords(this PR1 message)
        {
            object[] result = message.GetRecords("SurgeonRepetitionsUsed", "GetSurgeon");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Surgeon Records from PR1
        /// </summary>
        public static List<XCN> GetAllSurgeonRecords(this PR1 message)
        {
            return message.GetAllRecords<XCN>("SurgeonRepetitionsUsed", "GetSurgeon");
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
        public static List<XCN> GetAllProcedurePractitionerRecords(this PR1 message)
        {
            return message.GetAllRecords<XCN>("ProcedurePractitionerRepetitionsUsed", "GetProcedurePractitioner");
        }

        /// <summary>
        /// Get ProcedureCodeModifier Records from PR1
        /// </summary>
        public static IEnumerable GetProcedureCodeModifierRecords(this PR1 message)
        {
            object[] result = message.GetRecords("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCodeModifier Records from PR1
        /// </summary>
        public static List<CE> GetAllProcedureCodeModifierRecords(this PR1 message)
        {
            return message.GetAllRecords<CE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Get TissueTypeCode Records from PR1
        /// </summary>
        public static IEnumerable GetTissueTypeCodeRecords(this PR1 message)
        {
            object[] result = message.GetRecords("TissueTypeCodeRepetitionsUsed", "GetTissueTypeCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TissueTypeCode Records from PR1
        /// </summary>
        public static List<CE> GetAllTissueTypeCodeRecords(this PR1 message)
        {
            return message.GetAllRecords<CE>("TissueTypeCodeRepetitionsUsed", "GetTissueTypeCode");
        }

        /// <summary>
        /// Get CharacterSet Records from MSH
        /// </summary>
        public static IEnumerable GetCharacterSetRecords(this MSH message)
        {
            object[] result = message.GetRecords("CharacterSetRepetitionsUsed", "GetCharacterSet");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CharacterSet Records from MSH
        /// </summary>
        public static List<ID> GetAllCharacterSetRecords(this MSH message)
        {
            return message.GetAllRecords<ID>("CharacterSetRepetitionsUsed", "GetCharacterSet");
        }

        /// <summary>
        /// Get MessageProfileIdentifier Records from MSH
        /// </summary>
        public static IEnumerable GetMessageProfileIdentifierRecords(this MSH message)
        {
            object[] result = message.GetRecords("MessageProfileIdentifierRepetitionsUsed", "GetMessageProfileIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MessageProfileIdentifier Records from MSH
        /// </summary>
        public static List<EI> GetAllMessageProfileIdentifierRecords(this MSH message)
        {
            return message.GetAllRecords<EI>("MessageProfileIdentifierRepetitionsUsed", "GetMessageProfileIdentifier");
        }

        /// <summary>
        /// Get PriorPatientIdentifierList Records from MRG
        /// </summary>
        public static IEnumerable GetPriorPatientIdentifierListRecords(this MRG message)
        {
            object[] result = message.GetRecords("PriorPatientIdentifierListRepetitionsUsed", "GetPriorPatientIdentifierList");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PriorPatientIdentifierList Records from MRG
        /// </summary>
        public static List<CX> GetAllPriorPatientIdentifierListRecords(this MRG message)
        {
            return message.GetAllRecords<CX>("PriorPatientIdentifierListRepetitionsUsed", "GetPriorPatientIdentifierList");
        }

        /// <summary>
        /// Get PriorAlternatePatientID Records from MRG
        /// </summary>
        public static IEnumerable GetPriorAlternatePatientIDRecords(this MRG message)
        {
            object[] result = message.GetRecords("PriorAlternatePatientIDRepetitionsUsed", "GetPriorAlternatePatientID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PriorAlternatePatientID Records from MRG
        /// </summary>
        public static List<CX> GetAllPriorAlternatePatientIDRecords(this MRG message)
        {
            return message.GetAllRecords<CX>("PriorAlternatePatientIDRepetitionsUsed", "GetPriorAlternatePatientID");
        }

        /// <summary>
        /// Get PriorPatientName Records from MRG
        /// </summary>
        public static IEnumerable GetPriorPatientNameRecords(this MRG message)
        {
            object[] result = message.GetRecords("PriorPatientNameRepetitionsUsed", "GetPriorPatientName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PriorPatientName Records from MRG
        /// </summary>
        public static List<XPN> GetAllPriorPatientNameRecords(this MRG message)
        {
            return message.GetAllRecords<XPN>("PriorPatientNameRepetitionsUsed", "GetPriorPatientName");
        }

        /// <summary>
        /// Get PersonPerformingStudyRegistration Records from CSR
        /// </summary>
        public static IEnumerable GetPersonPerformingStudyRegistrationRecords(this CSR message)
        {
            object[] result = message.GetRecords("PersonPerformingStudyRegistrationRepetitionsUsed", "GetPersonPerformingStudyRegistration");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PersonPerformingStudyRegistration Records from CSR
        /// </summary>
        public static List<XCN> GetAllPersonPerformingStudyRegistrationRecords(this CSR message)
        {
            return message.GetAllRecords<XCN>("PersonPerformingStudyRegistrationRepetitionsUsed", "GetPersonPerformingStudyRegistration");
        }

        /// <summary>
        /// Get StudyAuthorizingProvider Records from CSR
        /// </summary>
        public static IEnumerable GetStudyAuthorizingProviderRecords(this CSR message)
        {
            object[] result = message.GetRecords("StudyAuthorizingProviderRepetitionsUsed", "GetStudyAuthorizingProvider");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StudyAuthorizingProvider Records from CSR
        /// </summary>
        public static List<XCN> GetAllStudyAuthorizingProviderRecords(this CSR message)
        {
            return message.GetAllRecords<XCN>("StudyAuthorizingProviderRepetitionsUsed", "GetStudyAuthorizingProvider");
        }

        /// <summary>
        /// Get StudyRandomizationDateTime Records from CSR
        /// </summary>
        public static IEnumerable GetStudyRandomizationDateTimeRecords(this CSR message)
        {
            object[] result = message.GetRecords("StudyRandomizationDateTimeRepetitionsUsed", "GetStudyRandomizationDateTime");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StudyRandomizationDateTime Records from CSR
        /// </summary>
        public static List<TS> GetAllStudyRandomizationDateTimeRecords(this CSR message)
        {
            return message.GetAllRecords<TS>("StudyRandomizationDateTimeRepetitionsUsed", "GetStudyRandomizationDateTime");
        }

        /// <summary>
        /// Get RandomizedStudyArm Records from CSR
        /// </summary>
        public static IEnumerable GetRandomizedStudyArmRecords(this CSR message)
        {
            object[] result = message.GetRecords("RandomizedStudyArmRepetitionsUsed", "GetRandomizedStudyArm");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RandomizedStudyArm Records from CSR
        /// </summary>
        public static List<CE> GetAllRandomizedStudyArmRecords(this CSR message)
        {
            return message.GetAllRecords<CE>("RandomizedStudyArmRepetitionsUsed", "GetRandomizedStudyArm");
        }

        /// <summary>
        /// Get StratumForStudyRandomization Records from CSR
        /// </summary>
        public static IEnumerable GetStratumForStudyRandomizationRecords(this CSR message)
        {
            object[] result = message.GetRecords("StratumForStudyRandomizationRepetitionsUsed", "GetStratumForStudyRandomization");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StratumForStudyRandomization Records from CSR
        /// </summary>
        public static List<CE> GetAllStratumForStudyRandomizationRecords(this CSR message)
        {
            return message.GetAllRecords<CE>("StratumForStudyRandomizationRepetitionsUsed", "GetStratumForStudyRandomization");
        }

        /// <summary>
        /// Get AdministrationNotes Records from RXG
        /// </summary>
        public static IEnumerable GetAdministrationNotesRecords(this RXG message)
        {
            object[] result = message.GetRecords("AdministrationNotesRepetitionsUsed", "GetAdministrationNotes");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdministrationNotes Records from RXG
        /// </summary>
        public static List<CE> GetAllAdministrationNotesRecords(this RXG message)
        {
            return message.GetAllRecords<CE>("AdministrationNotesRepetitionsUsed", "GetAdministrationNotes");
        }

        /// <summary>
        /// Get PharmacyTreatmentSupplierSSpecialAdministrationInstructions Records from RXG
        /// </summary>
        public static IEnumerable GetPharmacyTreatmentSupplierSSpecialAdministrationInstructionsRecords(this RXG message)
        {
            object[] result = message.GetRecords("PharmacyTreatmentSupplierSSpecialAdministrationInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialAdministrationInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacyTreatmentSupplierSSpecialAdministrationInstructions Records from RXG
        /// </summary>
        public static List<CE> GetAllPharmacyTreatmentSupplierSSpecialAdministrationInstructionsRecords(this RXG message)
        {
            return message.GetAllRecords<CE>("PharmacyTreatmentSupplierSSpecialAdministrationInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialAdministrationInstructions");
        }

        /// <summary>
        /// Get SubstanceLotNumber Records from RXG
        /// </summary>
        public static IEnumerable GetSubstanceLotNumberRecords(this RXG message)
        {
            object[] result = message.GetRecords("SubstanceLotNumberRepetitionsUsed", "GetSubstanceLotNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceLotNumber Records from RXG
        /// </summary>
        public static List<ST> GetAllSubstanceLotNumberRecords(this RXG message)
        {
            return message.GetAllRecords<ST>("SubstanceLotNumberRepetitionsUsed", "GetSubstanceLotNumber");
        }

        /// <summary>
        /// Get SubstanceExpirationDate Records from RXG
        /// </summary>
        public static IEnumerable GetSubstanceExpirationDateRecords(this RXG message)
        {
            object[] result = message.GetRecords("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceExpirationDate Records from RXG
        /// </summary>
        public static List<TS> GetAllSubstanceExpirationDateRecords(this RXG message)
        {
            return message.GetAllRecords<TS>("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");
        }

        /// <summary>
        /// Get SubstanceManufacturerName Records from RXG
        /// </summary>
        public static IEnumerable GetSubstanceManufacturerNameRecords(this RXG message)
        {
            object[] result = message.GetRecords("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceManufacturerName Records from RXG
        /// </summary>
        public static List<CE> GetAllSubstanceManufacturerNameRecords(this RXG message)
        {
            return message.GetAllRecords<CE>("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");
        }

        /// <summary>
        /// Get Indication Records from RXG
        /// </summary>
        public static IEnumerable GetIndicationRecords(this RXG message)
        {
            object[] result = message.GetRecords("IndicationRepetitionsUsed", "GetIndication");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Indication Records from RXG
        /// </summary>
        public static List<CE> GetAllIndicationRecords(this RXG message)
        {
            return message.GetAllRecords<CE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Get FacilityIDPRC Records from PRC
        /// </summary>
        public static IEnumerable GetFacilityIDPRCRecords(this PRC message)
        {
            object[] result = message.GetRecords("FacilityIDPRCRepetitionsUsed", "GetFacilityIDPRC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FacilityIDPRC Records from PRC
        /// </summary>
        public static List<CE> GetAllFacilityIDPRCRecords(this PRC message)
        {
            return message.GetAllRecords<CE>("FacilityIDPRCRepetitionsUsed", "GetFacilityIDPRC");
        }

        /// <summary>
        /// Get Department Records from PRC
        /// </summary>
        public static IEnumerable GetDepartmentRecords(this PRC message)
        {
            object[] result = message.GetRecords("DepartmentRepetitionsUsed", "GetDepartment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Department Records from PRC
        /// </summary>
        public static List<CE> GetAllDepartmentRecords(this PRC message)
        {
            return message.GetAllRecords<CE>("DepartmentRepetitionsUsed", "GetDepartment");
        }

        /// <summary>
        /// Get ValidPatientClasses Records from PRC
        /// </summary>
        public static IEnumerable GetValidPatientClassesRecords(this PRC message)
        {
            object[] result = message.GetRecords("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValidPatientClasses Records from PRC
        /// </summary>
        public static List<IS> GetAllValidPatientClassesRecords(this PRC message)
        {
            return message.GetAllRecords<IS>("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");
        }

        /// <summary>
        /// Get Price Records from PRC
        /// </summary>
        public static IEnumerable GetPriceRecords(this PRC message)
        {
            object[] result = message.GetRecords("PriceRepetitionsUsed", "GetPrice");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Price Records from PRC
        /// </summary>
        public static List<CP> GetAllPriceRecords(this PRC message)
        {
            return message.GetAllRecords<CP>("PriceRepetitionsUsed", "GetPrice");
        }

        /// <summary>
        /// Get Formula Records from PRC
        /// </summary>
        public static IEnumerable GetFormulaRecords(this PRC message)
        {
            object[] result = message.GetRecords("FormulaRepetitionsUsed", "GetFormula");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Formula Records from PRC
        /// </summary>
        public static List<ST> GetAllFormulaRecords(this PRC message)
        {
            return message.GetAllRecords<ST>("FormulaRepetitionsUsed", "GetFormula");
        }

        /// <summary>
        /// Get BillingCategory Records from PRC
        /// </summary>
        public static IEnumerable GetBillingCategoryRecords(this PRC message)
        {
            object[] result = message.GetRecords("BillingCategoryRepetitionsUsed", "GetBillingCategory");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BillingCategory Records from PRC
        /// </summary>
        public static List<CE> GetAllBillingCategoryRecords(this PRC message)
        {
            return message.GetAllRecords<CE>("BillingCategoryRepetitionsUsed", "GetBillingCategory");
        }

        /// <summary>
        /// Get CertifiedBy Records from IN3
        /// </summary>
        public static IEnumerable GetCertifiedByRecords(this IN3 message)
        {
            object[] result = message.GetRecords("CertifiedByRepetitionsUsed", "GetCertifiedBy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CertifiedBy Records from IN3
        /// </summary>
        public static List<XCN> GetAllCertifiedByRecords(this IN3 message)
        {
            return message.GetAllRecords<XCN>("CertifiedByRepetitionsUsed", "GetCertifiedBy");
        }

        /// <summary>
        /// Get Operator Records from IN3
        /// </summary>
        public static IEnumerable GetOperatorRecords(this IN3 message)
        {
            object[] result = message.GetRecords("OperatorRepetitionsUsed", "GetOperator");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Operator Records from IN3
        /// </summary>
        public static List<XCN> GetAllOperatorRecords(this IN3 message)
        {
            return message.GetAllRecords<XCN>("OperatorRepetitionsUsed", "GetOperator");
        }

        /// <summary>
        /// Get PhysicianReviewer Records from IN3
        /// </summary>
        public static IEnumerable GetPhysicianReviewerRecords(this IN3 message)
        {
            object[] result = message.GetRecords("PhysicianReviewerRepetitionsUsed", "GetPhysicianReviewer");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PhysicianReviewer Records from IN3
        /// </summary>
        public static List<XCN> GetAllPhysicianReviewerRecords(this IN3 message)
        {
            return message.GetAllRecords<XCN>("PhysicianReviewerRepetitionsUsed", "GetPhysicianReviewer");
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
        public static List<XTN> GetAllCertificationContactPhoneNumberRecords(this IN3 message)
        {
            return message.GetAllRecords<XTN>("CertificationContactPhoneNumberRepetitionsUsed", "GetCertificationContactPhoneNumber");
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
        public static List<XTN> GetAllCertificationAgencyPhoneNumberRecords(this IN3 message)
        {
            return message.GetAllRecords<XTN>("CertificationAgencyPhoneNumberRepetitionsUsed", "GetCertificationAgencyPhoneNumber");
        }

        /// <summary>
        /// Get PreCertificationRequirement Records from IN3
        /// </summary>
        public static IEnumerable GetPreCertificationRequirementRecords(this IN3 message)
        {
            object[] result = message.GetRecords("PreCertificationRequirementRepetitionsUsed", "GetPreCertificationRequirement");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PreCertificationRequirement Records from IN3
        /// </summary>
        public static List<ICD> GetAllPreCertificationRequirementRecords(this IN3 message)
        {
            return message.GetAllRecords<ICD>("PreCertificationRequirementRepetitionsUsed", "GetPreCertificationRequirement");
        }

        /// <summary>
        /// Get SecondOpinionDocumentationReceived Records from IN3
        /// </summary>
        public static IEnumerable GetSecondOpinionDocumentationReceivedRecords(this IN3 message)
        {
            object[] result = message.GetRecords("SecondOpinionDocumentationReceivedRepetitionsUsed", "GetSecondOpinionDocumentationReceived");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SecondOpinionDocumentationReceived Records from IN3
        /// </summary>
        public static List<IS> GetAllSecondOpinionDocumentationReceivedRecords(this IN3 message)
        {
            return message.GetAllRecords<IS>("SecondOpinionDocumentationReceivedRepetitionsUsed", "GetSecondOpinionDocumentationReceived");
        }

        /// <summary>
        /// Get SecondOpinionPhysician Records from IN3
        /// </summary>
        public static IEnumerable GetSecondOpinionPhysicianRecords(this IN3 message)
        {
            object[] result = message.GetRecords("SecondOpinionPhysicianRepetitionsUsed", "GetSecondOpinionPhysician");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SecondOpinionPhysician Records from IN3
        /// </summary>
        public static List<XCN> GetAllSecondOpinionPhysicianRecords(this IN3 message)
        {
            return message.GetAllRecords<XCN>("SecondOpinionPhysicianRepetitionsUsed", "GetSecondOpinionPhysician");
        }

        /// <summary>
        /// Get DiagnosingClinician Records from DG1
        /// </summary>
        public static IEnumerable GetDiagnosingClinicianRecords(this DG1 message)
        {
            object[] result = message.GetRecords("DiagnosingClinicianRepetitionsUsed", "GetDiagnosingClinician");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DiagnosingClinician Records from DG1
        /// </summary>
        public static List<XCN> GetAllDiagnosingClinicianRecords(this DG1 message)
        {
            return message.GetAllRecords<XCN>("DiagnosingClinicianRepetitionsUsed", "GetDiagnosingClinician");
        }

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
        public static List<NM> GetAllBatchTotalsRecords(this BTS message)
        {
            return message.GetAllRecords<NM>("BatchTotalsRepetitionsUsed", "GetBatchTotals");
        }

        /// <summary>
        /// Get BPProcessingRequirements Records from BPO
        /// </summary>
        public static IEnumerable GetBPProcessingRequirementsRecords(this BPO message)
        {
            object[] result = message.GetRecords("BPProcessingRequirementsRepetitionsUsed", "GetBPProcessingRequirements");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BPProcessingRequirements Records from BPO
        /// </summary>
        public static List<CWE> GetAllBPProcessingRequirementsRecords(this BPO message)
        {
            return message.GetAllRecords<CWE>("BPProcessingRequirementsRepetitionsUsed", "GetBPProcessingRequirements");
        }

        /// <summary>
        /// Get BPIndicationForUse Records from BPO
        /// </summary>
        public static IEnumerable GetBPIndicationForUseRecords(this BPO message)
        {
            object[] result = message.GetRecords("BPIndicationForUseRepetitionsUsed", "GetBPIndicationForUse");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BPIndicationForUse Records from BPO
        /// </summary>
        public static List<CWE> GetAllBPIndicationForUseRecords(this BPO message)
        {
            return message.GetAllRecords<CWE>("BPIndicationForUseRepetitionsUsed", "GetBPIndicationForUse");
        }

        /// <summary>
        /// Get ProfessionalOrganizationAffiliationDateRange Records from AFF
        /// </summary>
        public static IEnumerable GetProfessionalOrganizationAffiliationDateRangeRecords(this AFF message)
        {
            object[] result = message.GetRecords("ProfessionalOrganizationAffiliationDateRangeRepetitionsUsed", "GetProfessionalOrganizationAffiliationDateRange");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProfessionalOrganizationAffiliationDateRange Records from AFF
        /// </summary>
        public static List<DR> GetAllProfessionalOrganizationAffiliationDateRangeRecords(this AFF message)
        {
            return message.GetAllRecords<DR>("ProfessionalOrganizationAffiliationDateRangeRepetitionsUsed", "GetProfessionalOrganizationAffiliationDateRange");
        }

        /// <summary>
        /// Get ProblemManagementDiscipline Records from PRB
        /// </summary>
        public static IEnumerable GetProblemManagementDisciplineRecords(this PRB message)
        {
            object[] result = message.GetRecords("ProblemManagementDisciplineRepetitionsUsed", "GetProblemManagementDiscipline");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProblemManagementDiscipline Records from PRB
        /// </summary>
        public static List<CE> GetAllProblemManagementDisciplineRecords(this PRB message)
        {
            return message.GetAllRecords<CE>("ProblemManagementDisciplineRepetitionsUsed", "GetProblemManagementDiscipline");
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
        /// Get EnteredBy Records from ORC
        /// </summary>
        public static IEnumerable GetEnteredByRecords(this ORC message)
        {
            object[] result = message.GetRecords("EnteredByRepetitionsUsed", "GetEnteredBy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EnteredBy Records from ORC
        /// </summary>
        public static List<XCN> GetAllEnteredByRecords(this ORC message)
        {
            return message.GetAllRecords<XCN>("EnteredByRepetitionsUsed", "GetEnteredBy");
        }

        /// <summary>
        /// Get VerifiedBy Records from ORC
        /// </summary>
        public static IEnumerable GetVerifiedByRecords(this ORC message)
        {
            object[] result = message.GetRecords("VerifiedByRepetitionsUsed", "GetVerifiedBy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VerifiedBy Records from ORC
        /// </summary>
        public static List<XCN> GetAllVerifiedByRecords(this ORC message)
        {
            return message.GetAllRecords<XCN>("VerifiedByRepetitionsUsed", "GetVerifiedBy");
        }

        /// <summary>
        /// Get OrderingProvider Records from ORC
        /// </summary>
        public static IEnumerable GetOrderingProviderRecords(this ORC message)
        {
            object[] result = message.GetRecords("OrderingProviderRepetitionsUsed", "GetOrderingProvider");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingProvider Records from ORC
        /// </summary>
        public static List<XCN> GetAllOrderingProviderRecords(this ORC message)
        {
            return message.GetAllRecords<XCN>("OrderingProviderRepetitionsUsed", "GetOrderingProvider");
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
        public static List<XTN> GetAllCallBackPhoneNumberRecords(this ORC message)
        {
            return message.GetAllRecords<XTN>("CallBackPhoneNumberRepetitionsUsed", "GetCallBackPhoneNumber");
        }

        /// <summary>
        /// Get ActionBy Records from ORC
        /// </summary>
        public static IEnumerable GetActionByRecords(this ORC message)
        {
            object[] result = message.GetRecords("ActionByRepetitionsUsed", "GetActionBy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ActionBy Records from ORC
        /// </summary>
        public static List<XCN> GetAllActionByRecords(this ORC message)
        {
            return message.GetAllRecords<XCN>("ActionByRepetitionsUsed", "GetActionBy");
        }

        /// <summary>
        /// Get OrderingFacilityName Records from ORC
        /// </summary>
        public static IEnumerable GetOrderingFacilityNameRecords(this ORC message)
        {
            object[] result = message.GetRecords("OrderingFacilityNameRepetitionsUsed", "GetOrderingFacilityName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingFacilityName Records from ORC
        /// </summary>
        public static List<XON> GetAllOrderingFacilityNameRecords(this ORC message)
        {
            return message.GetAllRecords<XON>("OrderingFacilityNameRepetitionsUsed", "GetOrderingFacilityName");
        }

        /// <summary>
        /// Get OrderingFacilityAddress Records from ORC
        /// </summary>
        public static IEnumerable GetOrderingFacilityAddressRecords(this ORC message)
        {
            object[] result = message.GetRecords("OrderingFacilityAddressRepetitionsUsed", "GetOrderingFacilityAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingFacilityAddress Records from ORC
        /// </summary>
        public static List<XAD> GetAllOrderingFacilityAddressRecords(this ORC message)
        {
            return message.GetAllRecords<XAD>("OrderingFacilityAddressRepetitionsUsed", "GetOrderingFacilityAddress");
        }

        /// <summary>
        /// Get OrderingFacilityPhoneNumber Records from ORC
        /// </summary>
        public static IEnumerable GetOrderingFacilityPhoneNumberRecords(this ORC message)
        {
            object[] result = message.GetRecords("OrderingFacilityPhoneNumberRepetitionsUsed", "GetOrderingFacilityPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingFacilityPhoneNumber Records from ORC
        /// </summary>
        public static List<XTN> GetAllOrderingFacilityPhoneNumberRecords(this ORC message)
        {
            return message.GetAllRecords<XTN>("OrderingFacilityPhoneNumberRepetitionsUsed", "GetOrderingFacilityPhoneNumber");
        }

        /// <summary>
        /// Get OrderingProviderAddress Records from ORC
        /// </summary>
        public static IEnumerable GetOrderingProviderAddressRecords(this ORC message)
        {
            object[] result = message.GetRecords("OrderingProviderAddressRepetitionsUsed", "GetOrderingProviderAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingProviderAddress Records from ORC
        /// </summary>
        public static List<XAD> GetAllOrderingProviderAddressRecords(this ORC message)
        {
            return message.GetAllRecords<XAD>("OrderingProviderAddressRepetitionsUsed", "GetOrderingProviderAddress");
        }

        /// <summary>
        /// Get LocationTypeLOC Records from LOC
        /// </summary>
        public static IEnumerable GetLocationTypeLOCRecords(this LOC message)
        {
            object[] result = message.GetRecords("LocationTypeLOCRepetitionsUsed", "GetLocationTypeLOC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationTypeLOC Records from LOC
        /// </summary>
        public static List<IS> GetAllLocationTypeLOCRecords(this LOC message)
        {
            return message.GetAllRecords<IS>("LocationTypeLOCRepetitionsUsed", "GetLocationTypeLOC");
        }

        /// <summary>
        /// Get OrganizationNameLOC Records from LOC
        /// </summary>
        public static IEnumerable GetOrganizationNameLOCRecords(this LOC message)
        {
            object[] result = message.GetRecords("OrganizationNameLOCRepetitionsUsed", "GetOrganizationNameLOC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrganizationNameLOC Records from LOC
        /// </summary>
        public static List<XON> GetAllOrganizationNameLOCRecords(this LOC message)
        {
            return message.GetAllRecords<XON>("OrganizationNameLOCRepetitionsUsed", "GetOrganizationNameLOC");
        }

        /// <summary>
        /// Get LocationAddress Records from LOC
        /// </summary>
        public static IEnumerable GetLocationAddressRecords(this LOC message)
        {
            object[] result = message.GetRecords("LocationAddressRepetitionsUsed", "GetLocationAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationAddress Records from LOC
        /// </summary>
        public static List<XAD> GetAllLocationAddressRecords(this LOC message)
        {
            return message.GetAllRecords<XAD>("LocationAddressRepetitionsUsed", "GetLocationAddress");
        }

        /// <summary>
        /// Get LocationPhone Records from LOC
        /// </summary>
        public static IEnumerable GetLocationPhoneRecords(this LOC message)
        {
            object[] result = message.GetRecords("LocationPhoneRepetitionsUsed", "GetLocationPhone");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationPhone Records from LOC
        /// </summary>
        public static List<XTN> GetAllLocationPhoneRecords(this LOC message)
        {
            return message.GetAllRecords<XTN>("LocationPhoneRepetitionsUsed", "GetLocationPhone");
        }

        /// <summary>
        /// Get LicenseNumber Records from LOC
        /// </summary>
        public static IEnumerable GetLicenseNumberRecords(this LOC message)
        {
            object[] result = message.GetRecords("LicenseNumberRepetitionsUsed", "GetLicenseNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LicenseNumber Records from LOC
        /// </summary>
        public static List<CE> GetAllLicenseNumberRecords(this LOC message)
        {
            return message.GetAllRecords<CE>("LicenseNumberRepetitionsUsed", "GetLicenseNumber");
        }

        /// <summary>
        /// Get LocationEquipment Records from LOC
        /// </summary>
        public static IEnumerable GetLocationEquipmentRecords(this LOC message)
        {
            object[] result = message.GetRecords("LocationEquipmentRepetitionsUsed", "GetLocationEquipment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationEquipment Records from LOC
        /// </summary>
        public static List<IS> GetAllLocationEquipmentRecords(this LOC message)
        {
            return message.GetAllRecords<IS>("LocationEquipmentRepetitionsUsed", "GetLocationEquipment");
        }

        /// <summary>
        /// Get SubstanceStatus Records from INV
        /// </summary>
        public static IEnumerable GetSubstanceStatusRecords(this INV message)
        {
            object[] result = message.GetRecords("SubstanceStatusRepetitionsUsed", "GetSubstanceStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceStatus Records from INV
        /// </summary>
        public static List<CE> GetAllSubstanceStatusRecords(this INV message)
        {
            return message.GetAllRecords<CE>("SubstanceStatusRepetitionsUsed", "GetSubstanceStatus");
        }

        /// <summary>
        /// Get TestFluidIdentifierS Records from INV
        /// </summary>
        public static IEnumerable GetTestFluidIdentifierSRecords(this INV message)
        {
            object[] result = message.GetRecords("TestFluidIdentifierSRepetitionsUsed", "GetTestFluidIdentifierS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TestFluidIdentifierS Records from INV
        /// </summary>
        public static List<CE> GetAllTestFluidIdentifierSRecords(this INV message)
        {
            return message.GetAllRecords<CE>("TestFluidIdentifierSRepetitionsUsed", "GetTestFluidIdentifierS");
        }

        /// <summary>
        /// Get InsuredSEmployeeID Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSEmployeeIDRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSEmployeeIDRepetitionsUsed", "GetInsuredSEmployeeID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployeeID Records from IN2
        /// </summary>
        public static List<CX> GetAllInsuredSEmployeeIDRecords(this IN2 message)
        {
            return message.GetAllRecords<CX>("InsuredSEmployeeIDRepetitionsUsed", "GetInsuredSEmployeeID");
        }

        /// <summary>
        /// Get InsuredSEmployerSNameAndID Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSEmployerSNameAndIDRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSEmployerSNameAndIDRepetitionsUsed", "GetInsuredSEmployerSNameAndID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployerSNameAndID Records from IN2
        /// </summary>
        public static List<XCN> GetAllInsuredSEmployerSNameAndIDRecords(this IN2 message)
        {
            return message.GetAllRecords<XCN>("InsuredSEmployerSNameAndIDRepetitionsUsed", "GetInsuredSEmployerSNameAndID");
        }

        /// <summary>
        /// Get MailClaimParty Records from IN2
        /// </summary>
        public static IEnumerable GetMailClaimPartyRecords(this IN2 message)
        {
            object[] result = message.GetRecords("MailClaimPartyRepetitionsUsed", "GetMailClaimParty");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MailClaimParty Records from IN2
        /// </summary>
        public static List<IS> GetAllMailClaimPartyRecords(this IN2 message)
        {
            return message.GetAllRecords<IS>("MailClaimPartyRepetitionsUsed", "GetMailClaimParty");
        }

        /// <summary>
        /// Get MedicaidCaseName Records from IN2
        /// </summary>
        public static IEnumerable GetMedicaidCaseNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("MedicaidCaseNameRepetitionsUsed", "GetMedicaidCaseName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MedicaidCaseName Records from IN2
        /// </summary>
        public static List<XPN> GetAllMedicaidCaseNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("MedicaidCaseNameRepetitionsUsed", "GetMedicaidCaseName");
        }

        /// <summary>
        /// Get MilitarySponsorName Records from IN2
        /// </summary>
        public static IEnumerable GetMilitarySponsorNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("MilitarySponsorNameRepetitionsUsed", "GetMilitarySponsorName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MilitarySponsorName Records from IN2
        /// </summary>
        public static List<XPN> GetAllMilitarySponsorNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("MilitarySponsorNameRepetitionsUsed", "GetMilitarySponsorName");
        }

        /// <summary>
        /// Get SpecialCoverageApprovalName Records from IN2
        /// </summary>
        public static IEnumerable GetSpecialCoverageApprovalNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("SpecialCoverageApprovalNameRepetitionsUsed", "GetSpecialCoverageApprovalName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialCoverageApprovalName Records from IN2
        /// </summary>
        public static List<XPN> GetAllSpecialCoverageApprovalNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("SpecialCoverageApprovalNameRepetitionsUsed", "GetSpecialCoverageApprovalName");
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
        public static List<IS> GetAllNonCoveredInsuranceCodeRecords(this IN2 message)
        {
            return message.GetAllRecords<IS>("NonCoveredInsuranceCodeRepetitionsUsed", "GetNonCoveredInsuranceCode");
        }

        /// <summary>
        /// Get PayorID Records from IN2
        /// </summary>
        public static IEnumerable GetPayorIDRecords(this IN2 message)
        {
            object[] result = message.GetRecords("PayorIDRepetitionsUsed", "GetPayorID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PayorID Records from IN2
        /// </summary>
        public static List<CX> GetAllPayorIDRecords(this IN2 message)
        {
            return message.GetAllRecords<CX>("PayorIDRepetitionsUsed", "GetPayorID");
        }

        /// <summary>
        /// Get PayorSubscriberID Records from IN2
        /// </summary>
        public static IEnumerable GetPayorSubscriberIDRecords(this IN2 message)
        {
            object[] result = message.GetRecords("PayorSubscriberIDRepetitionsUsed", "GetPayorSubscriberID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PayorSubscriberID Records from IN2
        /// </summary>
        public static List<CX> GetAllPayorSubscriberIDRecords(this IN2 message)
        {
            return message.GetAllRecords<CX>("PayorSubscriberIDRepetitionsUsed", "GetPayorSubscriberID");
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
        public static List<RMC> GetAllRoomCoverageTypeAmountRecords(this IN2 message)
        {
            return message.GetAllRecords<RMC>("RoomCoverageTypeAmountRepetitionsUsed", "GetRoomCoverageTypeAmount");
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
        public static List<PTA> GetAllPolicyTypeAmountRecords(this IN2 message)
        {
            return message.GetAllRecords<PTA>("PolicyTypeAmountRepetitionsUsed", "GetPolicyTypeAmount");
        }

        /// <summary>
        /// Get AmbulatoryStatus Records from IN2
        /// </summary>
        public static IEnumerable GetAmbulatoryStatusRecords(this IN2 message)
        {
            object[] result = message.GetRecords("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AmbulatoryStatus Records from IN2
        /// </summary>
        public static List<IS> GetAllAmbulatoryStatusRecords(this IN2 message)
        {
            return message.GetAllRecords<IS>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Get Citizenship Records from IN2
        /// </summary>
        public static IEnumerable GetCitizenshipRecords(this IN2 message)
        {
            object[] result = message.GetRecords("CitizenshipRepetitionsUsed", "GetCitizenship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Citizenship Records from IN2
        /// </summary>
        public static List<CE> GetAllCitizenshipRecords(this IN2 message)
        {
            return message.GetAllRecords<CE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Get MotherSMaidenName Records from IN2
        /// </summary>
        public static IEnumerable GetMotherSMaidenNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MotherSMaidenName Records from IN2
        /// </summary>
        public static List<XPN> GetAllMotherSMaidenNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");
        }

        /// <summary>
        /// Get EthnicGroup Records from IN2
        /// </summary>
        public static IEnumerable GetEthnicGroupRecords(this IN2 message)
        {
            object[] result = message.GetRecords("EthnicGroupRepetitionsUsed", "GetEthnicGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EthnicGroup Records from IN2
        /// </summary>
        public static List<CE> GetAllEthnicGroupRecords(this IN2 message)
        {
            return message.GetAllRecords<CE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Get MaritalStatus Records from IN2
        /// </summary>
        public static IEnumerable GetMaritalStatusRecords(this IN2 message)
        {
            object[] result = message.GetRecords("MaritalStatusRepetitionsUsed", "GetMaritalStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MaritalStatus Records from IN2
        /// </summary>
        public static List<CE> GetAllMaritalStatusRecords(this IN2 message)
        {
            return message.GetAllRecords<CE>("MaritalStatusRepetitionsUsed", "GetMaritalStatus");
        }

        /// <summary>
        /// Get EmployerContactPersonName Records from IN2
        /// </summary>
        public static IEnumerable GetEmployerContactPersonNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("EmployerContactPersonNameRepetitionsUsed", "GetEmployerContactPersonName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EmployerContactPersonName Records from IN2
        /// </summary>
        public static List<XPN> GetAllEmployerContactPersonNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("EmployerContactPersonNameRepetitionsUsed", "GetEmployerContactPersonName");
        }

        /// <summary>
        /// Get EmployerContactPersonPhoneNumber Records from IN2
        /// </summary>
        public static IEnumerable GetEmployerContactPersonPhoneNumberRecords(this IN2 message)
        {
            object[] result = message.GetRecords("EmployerContactPersonPhoneNumberRepetitionsUsed", "GetEmployerContactPersonPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EmployerContactPersonPhoneNumber Records from IN2
        /// </summary>
        public static List<XTN> GetAllEmployerContactPersonPhoneNumberRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("EmployerContactPersonPhoneNumberRepetitionsUsed", "GetEmployerContactPersonPhoneNumber");
        }

        /// <summary>
        /// Get InsuredSContactPersonSName Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSContactPersonSNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSContactPersonSNameRepetitionsUsed", "GetInsuredSContactPersonSName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSContactPersonSName Records from IN2
        /// </summary>
        public static List<XPN> GetAllInsuredSContactPersonSNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("InsuredSContactPersonSNameRepetitionsUsed", "GetInsuredSContactPersonSName");
        }

        /// <summary>
        /// Get InsuredSContactPersonPhoneNumber Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSContactPersonPhoneNumberRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSContactPersonPhoneNumberRepetitionsUsed", "GetInsuredSContactPersonPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSContactPersonPhoneNumber Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuredSContactPersonPhoneNumberRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuredSContactPersonPhoneNumberRepetitionsUsed", "GetInsuredSContactPersonPhoneNumber");
        }

        /// <summary>
        /// Get InsuredSContactPersonReason Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSContactPersonReasonRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSContactPersonReasonRepetitionsUsed", "GetInsuredSContactPersonReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSContactPersonReason Records from IN2
        /// </summary>
        public static List<IS> GetAllInsuredSContactPersonReasonRecords(this IN2 message)
        {
            return message.GetAllRecords<IS>("InsuredSContactPersonReasonRepetitionsUsed", "GetInsuredSContactPersonReason");
        }

        /// <summary>
        /// Get RelationshipToThePatientStopDate Records from IN2
        /// </summary>
        public static IEnumerable GetRelationshipToThePatientStopDateRecords(this IN2 message)
        {
            object[] result = message.GetRecords("RelationshipToThePatientStopDateRepetitionsUsed", "GetRelationshipToThePatientStopDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelationshipToThePatientStopDate Records from IN2
        /// </summary>
        public static List<DT> GetAllRelationshipToThePatientStopDateRecords(this IN2 message)
        {
            return message.GetAllRecords<DT>("RelationshipToThePatientStopDateRepetitionsUsed", "GetRelationshipToThePatientStopDate");
        }

        /// <summary>
        /// Get InsuredSPhoneNumberHome Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSPhoneNumberHomeRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSPhoneNumberHomeRepetitionsUsed", "GetInsuredSPhoneNumberHome");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSPhoneNumberHome Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuredSPhoneNumberHomeRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuredSPhoneNumberHomeRepetitionsUsed", "GetInsuredSPhoneNumberHome");
        }

        /// <summary>
        /// Get InsuredSEmployerPhoneNumber Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSEmployerPhoneNumberRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSEmployerPhoneNumberRepetitionsUsed", "GetInsuredSEmployerPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployerPhoneNumber Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuredSEmployerPhoneNumberRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuredSEmployerPhoneNumberRepetitionsUsed", "GetInsuredSEmployerPhoneNumber");
        }

        /// <summary>
        /// Get InsuredOrganizationNameAndID Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredOrganizationNameAndIDRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredOrganizationNameAndIDRepetitionsUsed", "GetInsuredOrganizationNameAndID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredOrganizationNameAndID Records from IN2
        /// </summary>
        public static List<XON> GetAllInsuredOrganizationNameAndIDRecords(this IN2 message)
        {
            return message.GetAllRecords<XON>("InsuredOrganizationNameAndIDRepetitionsUsed", "GetInsuredOrganizationNameAndID");
        }

        /// <summary>
        /// Get InsuredEmployerOrganizationNameAndID Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredEmployerOrganizationNameAndIDRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredEmployerOrganizationNameAndIDRepetitionsUsed", "GetInsuredEmployerOrganizationNameAndID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredEmployerOrganizationNameAndID Records from IN2
        /// </summary>
        public static List<XON> GetAllInsuredEmployerOrganizationNameAndIDRecords(this IN2 message)
        {
            return message.GetAllRecords<XON>("InsuredEmployerOrganizationNameAndIDRepetitionsUsed", "GetInsuredEmployerOrganizationNameAndID");
        }

        /// <summary>
        /// Get Race Records from IN2
        /// </summary>
        public static IEnumerable GetRaceRecords(this IN2 message)
        {
            object[] result = message.GetRecords("RaceRepetitionsUsed", "GetRace");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Race Records from IN2
        /// </summary>
        public static List<CE> GetAllRaceRecords(this IN2 message)
        {
            return message.GetAllRecords<CE>("RaceRepetitionsUsed", "GetRace");
        }

        /// <summary>
        /// Get RequestedStartDateTimeRange Records from ARQ
        /// </summary>
        public static IEnumerable GetRequestedStartDateTimeRangeRecords(this ARQ message)
        {
            object[] result = message.GetRecords("RequestedStartDateTimeRangeRepetitionsUsed", "GetRequestedStartDateTimeRange");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RequestedStartDateTimeRange Records from ARQ
        /// </summary>
        public static List<DR> GetAllRequestedStartDateTimeRangeRecords(this ARQ message)
        {
            return message.GetAllRecords<DR>("RequestedStartDateTimeRangeRepetitionsUsed", "GetRequestedStartDateTimeRange");
        }

        /// <summary>
        /// Get PlacerContactPerson Records from ARQ
        /// </summary>
        public static IEnumerable GetPlacerContactPersonRecords(this ARQ message)
        {
            object[] result = message.GetRecords("PlacerContactPersonRepetitionsUsed", "GetPlacerContactPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerContactPerson Records from ARQ
        /// </summary>
        public static List<XCN> GetAllPlacerContactPersonRecords(this ARQ message)
        {
            return message.GetAllRecords<XCN>("PlacerContactPersonRepetitionsUsed", "GetPlacerContactPerson");
        }

        /// <summary>
        /// Get PlacerContactPhoneNumber Records from ARQ
        /// </summary>
        public static IEnumerable GetPlacerContactPhoneNumberRecords(this ARQ message)
        {
            object[] result = message.GetRecords("PlacerContactPhoneNumberRepetitionsUsed", "GetPlacerContactPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerContactPhoneNumber Records from ARQ
        /// </summary>
        public static List<XTN> GetAllPlacerContactPhoneNumberRecords(this ARQ message)
        {
            return message.GetAllRecords<XTN>("PlacerContactPhoneNumberRepetitionsUsed", "GetPlacerContactPhoneNumber");
        }

        /// <summary>
        /// Get PlacerContactAddress Records from ARQ
        /// </summary>
        public static IEnumerable GetPlacerContactAddressRecords(this ARQ message)
        {
            object[] result = message.GetRecords("PlacerContactAddressRepetitionsUsed", "GetPlacerContactAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerContactAddress Records from ARQ
        /// </summary>
        public static List<XAD> GetAllPlacerContactAddressRecords(this ARQ message)
        {
            return message.GetAllRecords<XAD>("PlacerContactAddressRepetitionsUsed", "GetPlacerContactAddress");
        }

        /// <summary>
        /// Get EnteredByPerson Records from ARQ
        /// </summary>
        public static IEnumerable GetEnteredByPersonRecords(this ARQ message)
        {
            object[] result = message.GetRecords("EnteredByPersonRepetitionsUsed", "GetEnteredByPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EnteredByPerson Records from ARQ
        /// </summary>
        public static List<XCN> GetAllEnteredByPersonRecords(this ARQ message)
        {
            return message.GetAllRecords<XCN>("EnteredByPersonRepetitionsUsed", "GetEnteredByPerson");
        }

        /// <summary>
        /// Get EnteredByPhoneNumber Records from ARQ
        /// </summary>
        public static IEnumerable GetEnteredByPhoneNumberRecords(this ARQ message)
        {
            object[] result = message.GetRecords("EnteredByPhoneNumberRepetitionsUsed", "GetEnteredByPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EnteredByPhoneNumber Records from ARQ
        /// </summary>
        public static List<XTN> GetAllEnteredByPhoneNumberRecords(this ARQ message)
        {
            return message.GetAllRecords<XTN>("EnteredByPhoneNumberRepetitionsUsed", "GetEnteredByPhoneNumber");
        }

        /// <summary>
        /// Get PlacerOrderNumber Records from ARQ
        /// </summary>
        public static IEnumerable GetPlacerOrderNumberRecords(this ARQ message)
        {
            object[] result = message.GetRecords("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerOrderNumber Records from ARQ
        /// </summary>
        public static List<EI> GetAllPlacerOrderNumberRecords(this ARQ message)
        {
            return message.GetAllRecords<EI>("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");
        }

        /// <summary>
        /// Get FillerOrderNumber Records from ARQ
        /// </summary>
        public static IEnumerable GetFillerOrderNumberRecords(this ARQ message)
        {
            object[] result = message.GetRecords("FillerOrderNumberRepetitionsUsed", "GetFillerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerOrderNumber Records from ARQ
        /// </summary>
        public static List<EI> GetAllFillerOrderNumberRecords(this ARQ message)
        {
            return message.GetAllRecords<EI>("FillerOrderNumberRepetitionsUsed", "GetFillerOrderNumber");
        }

        /// <summary>
        /// Get SpecimenParentIDs Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenParentIDsRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenParentIDsRepetitionsUsed", "GetSpecimenParentIDs");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenParentIDs Records from SPM
        /// </summary>
        public static List<EIP> GetAllSpecimenParentIDsRecords(this SPM message)
        {
            return message.GetAllRecords<EIP>("SpecimenParentIDsRepetitionsUsed", "GetSpecimenParentIDs");
        }

        /// <summary>
        /// Get SpecimenTypeModifier Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenTypeModifierRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenTypeModifierRepetitionsUsed", "GetSpecimenTypeModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenTypeModifier Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenTypeModifierRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenTypeModifierRepetitionsUsed", "GetSpecimenTypeModifier");
        }

        /// <summary>
        /// Get SpecimenAdditives Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenAdditivesRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenAdditivesRepetitionsUsed", "GetSpecimenAdditives");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenAdditives Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenAdditivesRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenAdditivesRepetitionsUsed", "GetSpecimenAdditives");
        }

        /// <summary>
        /// Get SpecimenSourceSiteModifier Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenSourceSiteModifierRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenSourceSiteModifierRepetitionsUsed", "GetSpecimenSourceSiteModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenSourceSiteModifier Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenSourceSiteModifierRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenSourceSiteModifierRepetitionsUsed", "GetSpecimenSourceSiteModifier");
        }

        /// <summary>
        /// Get SpecimenRole Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenRoleRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenRoleRepetitionsUsed", "GetSpecimenRole");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenRole Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenRoleRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenRoleRepetitionsUsed", "GetSpecimenRole");
        }

        /// <summary>
        /// Get SpecimenDescription Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenDescriptionRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenDescriptionRepetitionsUsed", "GetSpecimenDescription");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenDescription Records from SPM
        /// </summary>
        public static List<ST> GetAllSpecimenDescriptionRecords(this SPM message)
        {
            return message.GetAllRecords<ST>("SpecimenDescriptionRepetitionsUsed", "GetSpecimenDescription");
        }

        /// <summary>
        /// Get SpecimenHandlingCode Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenHandlingCodeRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenHandlingCodeRepetitionsUsed", "GetSpecimenHandlingCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenHandlingCode Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenHandlingCodeRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenHandlingCodeRepetitionsUsed", "GetSpecimenHandlingCode");
        }

        /// <summary>
        /// Get SpecimenRiskCode Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenRiskCodeRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenRiskCodeRepetitionsUsed", "GetSpecimenRiskCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenRiskCode Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenRiskCodeRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenRiskCodeRepetitionsUsed", "GetSpecimenRiskCode");
        }

        /// <summary>
        /// Get SpecimenRejectReason Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenRejectReasonRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenRejectReasonRepetitionsUsed", "GetSpecimenRejectReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenRejectReason Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenRejectReasonRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenRejectReasonRepetitionsUsed", "GetSpecimenRejectReason");
        }

        /// <summary>
        /// Get SpecimenCondition Records from SPM
        /// </summary>
        public static IEnumerable GetSpecimenConditionRecords(this SPM message)
        {
            object[] result = message.GetRecords("SpecimenConditionRepetitionsUsed", "GetSpecimenCondition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenCondition Records from SPM
        /// </summary>
        public static List<CWE> GetAllSpecimenConditionRecords(this SPM message)
        {
            return message.GetAllRecords<CWE>("SpecimenConditionRepetitionsUsed", "GetSpecimenCondition");
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
        /// Get OrderingProviderSDEANumber Records from RXE
        /// </summary>
        public static IEnumerable GetOrderingProviderSDEANumberRecords(this RXE message)
        {
            object[] result = message.GetRecords("OrderingProviderSDEANumberRepetitionsUsed", "GetOrderingProviderSDEANumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingProviderSDEANumber Records from RXE
        /// </summary>
        public static List<XCN> GetAllOrderingProviderSDEANumberRecords(this RXE message)
        {
            return message.GetAllRecords<XCN>("OrderingProviderSDEANumberRepetitionsUsed", "GetOrderingProviderSDEANumber");
        }

        /// <summary>
        /// Get PharmacistTreatmentSupplierSVerifierID Records from RXE
        /// </summary>
        public static IEnumerable GetPharmacistTreatmentSupplierSVerifierIDRecords(this RXE message)
        {
            object[] result = message.GetRecords("PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed", "GetPharmacistTreatmentSupplierSVerifierID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacistTreatmentSupplierSVerifierID Records from RXE
        /// </summary>
        public static List<XCN> GetAllPharmacistTreatmentSupplierSVerifierIDRecords(this RXE message)
        {
            return message.GetAllRecords<XCN>("PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed", "GetPharmacistTreatmentSupplierSVerifierID");
        }

        /// <summary>
        /// Get PharmacyTreatmentSupplierSSpecialDispensingInstructions Records from RXE
        /// </summary>
        public static IEnumerable GetPharmacyTreatmentSupplierSSpecialDispensingInstructionsRecords(this RXE message)
        {
            object[] result = message.GetRecords("PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialDispensingInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacyTreatmentSupplierSSpecialDispensingInstructions Records from RXE
        /// </summary>
        public static List<CE> GetAllPharmacyTreatmentSupplierSSpecialDispensingInstructionsRecords(this RXE message)
        {
            return message.GetAllRecords<CE>("PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialDispensingInstructions");
        }

        /// <summary>
        /// Get GiveIndication Records from RXE
        /// </summary>
        public static IEnumerable GetGiveIndicationRecords(this RXE message)
        {
            object[] result = message.GetRecords("GiveIndicationRepetitionsUsed", "GetGiveIndication");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GiveIndication Records from RXE
        /// </summary>
        public static List<CE> GetAllGiveIndicationRecords(this RXE message)
        {
            return message.GetAllRecords<CE>("GiveIndicationRepetitionsUsed", "GetGiveIndication");
        }

        /// <summary>
        /// Get SupplementaryCode Records from RXE
        /// </summary>
        public static IEnumerable GetSupplementaryCodeRecords(this RXE message)
        {
            object[] result = message.GetRecords("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SupplementaryCode Records from RXE
        /// </summary>
        public static List<CE> GetAllSupplementaryCodeRecords(this RXE message)
        {
            return message.GetAllRecords<CE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Get PharmaceuticalSubstanceAlternative Records from RXE
        /// </summary>
        public static IEnumerable GetPharmaceuticalSubstanceAlternativeRecords(this RXE message)
        {
            object[] result = message.GetRecords("PharmaceuticalSubstanceAlternativeRepetitionsUsed", "GetPharmaceuticalSubstanceAlternative");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmaceuticalSubstanceAlternative Records from RXE
        /// </summary>
        public static List<CWE> GetAllPharmaceuticalSubstanceAlternativeRecords(this RXE message)
        {
            return message.GetAllRecords<CWE>("PharmaceuticalSubstanceAlternativeRepetitionsUsed", "GetPharmaceuticalSubstanceAlternative");
        }

        /// <summary>
        /// Get ReferralDisposition Records from RF1
        /// </summary>
        public static IEnumerable GetReferralDispositionRecords(this RF1 message)
        {
            object[] result = message.GetRecords("ReferralDispositionRepetitionsUsed", "GetReferralDisposition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferralDisposition Records from RF1
        /// </summary>
        public static List<CE> GetAllReferralDispositionRecords(this RF1 message)
        {
            return message.GetAllRecords<CE>("ReferralDispositionRepetitionsUsed", "GetReferralDisposition");
        }

        /// <summary>
        /// Get ReferralReason Records from RF1
        /// </summary>
        public static IEnumerable GetReferralReasonRecords(this RF1 message)
        {
            object[] result = message.GetRecords("ReferralReasonRepetitionsUsed", "GetReferralReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferralReason Records from RF1
        /// </summary>
        public static List<CE> GetAllReferralReasonRecords(this RF1 message)
        {
            return message.GetAllRecords<CE>("ReferralReasonRepetitionsUsed", "GetReferralReason");
        }

        /// <summary>
        /// Get ExternalReferralIdentifier Records from RF1
        /// </summary>
        public static IEnumerable GetExternalReferralIdentifierRecords(this RF1 message)
        {
            object[] result = message.GetRecords("ExternalReferralIdentifierRepetitionsUsed", "GetExternalReferralIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ExternalReferralIdentifier Records from RF1
        /// </summary>
        public static List<EI> GetAllExternalReferralIdentifierRecords(this RF1 message)
        {
            return message.GetAllRecords<EI>("ExternalReferralIdentifierRepetitionsUsed", "GetExternalReferralIdentifier");
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
        /// Get VisitUserCode Records from PV2
        /// </summary>
        public static IEnumerable GetVisitUserCodeRecords(this PV2 message)
        {
            object[] result = message.GetRecords("VisitUserCodeRepetitionsUsed", "GetVisitUserCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VisitUserCode Records from PV2
        /// </summary>
        public static List<IS> GetAllVisitUserCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<IS>("VisitUserCodeRepetitionsUsed", "GetVisitUserCode");
        }

        /// <summary>
        /// Get ReferralSourceCode Records from PV2
        /// </summary>
        public static IEnumerable GetReferralSourceCodeRecords(this PV2 message)
        {
            object[] result = message.GetRecords("ReferralSourceCodeRepetitionsUsed", "GetReferralSourceCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferralSourceCode Records from PV2
        /// </summary>
        public static List<XCN> GetAllReferralSourceCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<XCN>("ReferralSourceCodeRepetitionsUsed", "GetReferralSourceCode");
        }

        /// <summary>
        /// Get ClinicOrganizationName Records from PV2
        /// </summary>
        public static IEnumerable GetClinicOrganizationNameRecords(this PV2 message)
        {
            object[] result = message.GetRecords("ClinicOrganizationNameRepetitionsUsed", "GetClinicOrganizationName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ClinicOrganizationName Records from PV2
        /// </summary>
        public static List<XON> GetAllClinicOrganizationNameRecords(this PV2 message)
        {
            return message.GetAllRecords<XON>("ClinicOrganizationNameRepetitionsUsed", "GetClinicOrganizationName");
        }

        /// <summary>
        /// Get RecreationalDrugUseCode Records from PV2
        /// </summary>
        public static IEnumerable GetRecreationalDrugUseCodeRecords(this PV2 message)
        {
            object[] result = message.GetRecords("RecreationalDrugUseCodeRepetitionsUsed", "GetRecreationalDrugUseCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RecreationalDrugUseCode Records from PV2
        /// </summary>
        public static List<CE> GetAllRecreationalDrugUseCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CE>("RecreationalDrugUseCodeRepetitionsUsed", "GetRecreationalDrugUseCode");
        }

        /// <summary>
        /// Get PrecautionCode Records from PV2
        /// </summary>
        public static IEnumerable GetPrecautionCodeRecords(this PV2 message)
        {
            object[] result = message.GetRecords("PrecautionCodeRepetitionsUsed", "GetPrecautionCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrecautionCode Records from PV2
        /// </summary>
        public static List<CE> GetAllPrecautionCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CE>("PrecautionCodeRepetitionsUsed", "GetPrecautionCode");
        }

        /// <summary>
        /// Get AdvanceDirectiveCode Records from PV2
        /// </summary>
        public static IEnumerable GetAdvanceDirectiveCodeRecords(this PV2 message)
        {
            object[] result = message.GetRecords("AdvanceDirectiveCodeRepetitionsUsed", "GetAdvanceDirectiveCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdvanceDirectiveCode Records from PV2
        /// </summary>
        public static List<CE> GetAllAdvanceDirectiveCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CE>("AdvanceDirectiveCodeRepetitionsUsed", "GetAdvanceDirectiveCode");
        }

        /// <summary>
        /// Get NotifyClergyCode Records from PV2
        /// </summary>
        public static IEnumerable GetNotifyClergyCodeRecords(this PV2 message)
        {
            object[] result = message.GetRecords("NotifyClergyCodeRepetitionsUsed", "GetNotifyClergyCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NotifyClergyCode Records from PV2
        /// </summary>
        public static List<IS> GetAllNotifyClergyCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<IS>("NotifyClergyCodeRepetitionsUsed", "GetNotifyClergyCode");
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
        public static List<IS> GetAllPractitionerCategoryRecords(this PRA message)
        {
            return message.GetAllRecords<IS>("PractitionerCategoryRepetitionsUsed", "GetPractitionerCategory");
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
        public static List<SPD> GetAllSpecialtyRecords(this PRA message)
        {
            return message.GetAllRecords<SPD>("SpecialtyRepetitionsUsed", "GetSpecialty");
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
        public static List<PLN> GetAllPractitionerIDNumbersRecords(this PRA message)
        {
            return message.GetAllRecords<PLN>("PractitionerIDNumbersRepetitionsUsed", "GetPractitionerIDNumbers");
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
        public static List<PIP> GetAllPrivilegesRecords(this PRA message)
        {
            return message.GetAllRecords<PIP>("PrivilegesRepetitionsUsed", "GetPrivileges");
        }

        /// <summary>
        /// Get GovernmentReimbursementBillingEligibility Records from PRA
        /// </summary>
        public static IEnumerable GetGovernmentReimbursementBillingEligibilityRecords(this PRA message)
        {
            object[] result = message.GetRecords("GovernmentReimbursementBillingEligibilityRepetitionsUsed", "GetGovernmentReimbursementBillingEligibility");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GovernmentReimbursementBillingEligibility Records from PRA
        /// </summary>
        public static List<CE> GetAllGovernmentReimbursementBillingEligibilityRecords(this PRA message)
        {
            return message.GetAllRecords<CE>("GovernmentReimbursementBillingEligibilityRepetitionsUsed", "GetGovernmentReimbursementBillingEligibility");
        }

        /// <summary>
        /// Get LivingDependency Records from PD1
        /// </summary>
        public static IEnumerable GetLivingDependencyRecords(this PD1 message)
        {
            object[] result = message.GetRecords("LivingDependencyRepetitionsUsed", "GetLivingDependency");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LivingDependency Records from PD1
        /// </summary>
        public static List<IS> GetAllLivingDependencyRecords(this PD1 message)
        {
            return message.GetAllRecords<IS>("LivingDependencyRepetitionsUsed", "GetLivingDependency");
        }

        /// <summary>
        /// Get PatientPrimaryFacility Records from PD1
        /// </summary>
        public static IEnumerable GetPatientPrimaryFacilityRecords(this PD1 message)
        {
            object[] result = message.GetRecords("PatientPrimaryFacilityRepetitionsUsed", "GetPatientPrimaryFacility");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientPrimaryFacility Records from PD1
        /// </summary>
        public static List<XON> GetAllPatientPrimaryFacilityRecords(this PD1 message)
        {
            return message.GetAllRecords<XON>("PatientPrimaryFacilityRepetitionsUsed", "GetPatientPrimaryFacility");
        }

        /// <summary>
        /// Get PatientPrimaryCareProviderNameIDNo Records from PD1
        /// </summary>
        public static IEnumerable GetPatientPrimaryCareProviderNameIDNoRecords(this PD1 message)
        {
            object[] result = message.GetRecords("PatientPrimaryCareProviderNameIDNoRepetitionsUsed", "GetPatientPrimaryCareProviderNameIDNo");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientPrimaryCareProviderNameIDNo Records from PD1
        /// </summary>
        public static List<XCN> GetAllPatientPrimaryCareProviderNameIDNoRecords(this PD1 message)
        {
            return message.GetAllRecords<XCN>("PatientPrimaryCareProviderNameIDNoRepetitionsUsed", "GetPatientPrimaryCareProviderNameIDNo");
        }

        /// <summary>
        /// Get DuplicatePatient Records from PD1
        /// </summary>
        public static IEnumerable GetDuplicatePatientRecords(this PD1 message)
        {
            object[] result = message.GetRecords("DuplicatePatientRepetitionsUsed", "GetDuplicatePatient");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DuplicatePatient Records from PD1
        /// </summary>
        public static List<CX> GetAllDuplicatePatientRecords(this PD1 message)
        {
            return message.GetAllRecords<CX>("DuplicatePatientRepetitionsUsed", "GetDuplicatePatient");
        }

        /// <summary>
        /// Get PlaceOfWorship Records from PD1
        /// </summary>
        public static IEnumerable GetPlaceOfWorshipRecords(this PD1 message)
        {
            object[] result = message.GetRecords("PlaceOfWorshipRepetitionsUsed", "GetPlaceOfWorship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlaceOfWorship Records from PD1
        /// </summary>
        public static List<XON> GetAllPlaceOfWorshipRecords(this PD1 message)
        {
            return message.GetAllRecords<XON>("PlaceOfWorshipRepetitionsUsed", "GetPlaceOfWorship");
        }

        /// <summary>
        /// Get AdvanceDirectiveCode Records from PD1
        /// </summary>
        public static IEnumerable GetAdvanceDirectiveCodeRecords(this PD1 message)
        {
            object[] result = message.GetRecords("AdvanceDirectiveCodeRepetitionsUsed", "GetAdvanceDirectiveCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdvanceDirectiveCode Records from PD1
        /// </summary>
        public static List<CE> GetAllAdvanceDirectiveCodeRecords(this PD1 message)
        {
            return message.GetAllRecords<CE>("AdvanceDirectiveCodeRepetitionsUsed", "GetAdvanceDirectiveCode");
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
        /// Get InsuranceCompanyID Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCompanyIDRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCompanyIDRepetitionsUsed", "GetInsuranceCompanyID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCompanyID Records from IN1
        /// </summary>
        public static List<CX> GetAllInsuranceCompanyIDRecords(this IN1 message)
        {
            return message.GetAllRecords<CX>("InsuranceCompanyIDRepetitionsUsed", "GetInsuranceCompanyID");
        }

        /// <summary>
        /// Get InsuranceCompanyName Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCompanyNameRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCompanyNameRepetitionsUsed", "GetInsuranceCompanyName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCompanyName Records from IN1
        /// </summary>
        public static List<XON> GetAllInsuranceCompanyNameRecords(this IN1 message)
        {
            return message.GetAllRecords<XON>("InsuranceCompanyNameRepetitionsUsed", "GetInsuranceCompanyName");
        }

        /// <summary>
        /// Get InsuranceCompanyAddress Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCompanyAddressRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCompanyAddressRepetitionsUsed", "GetInsuranceCompanyAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCompanyAddress Records from IN1
        /// </summary>
        public static List<XAD> GetAllInsuranceCompanyAddressRecords(this IN1 message)
        {
            return message.GetAllRecords<XAD>("InsuranceCompanyAddressRepetitionsUsed", "GetInsuranceCompanyAddress");
        }

        /// <summary>
        /// Get InsuranceCoContactPerson Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCoContactPersonRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCoContactPersonRepetitionsUsed", "GetInsuranceCoContactPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCoContactPerson Records from IN1
        /// </summary>
        public static List<XPN> GetAllInsuranceCoContactPersonRecords(this IN1 message)
        {
            return message.GetAllRecords<XPN>("InsuranceCoContactPersonRepetitionsUsed", "GetInsuranceCoContactPerson");
        }

        /// <summary>
        /// Get InsuranceCoPhoneNumber Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCoPhoneNumberRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCoPhoneNumberRepetitionsUsed", "GetInsuranceCoPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCoPhoneNumber Records from IN1
        /// </summary>
        public static List<XTN> GetAllInsuranceCoPhoneNumberRecords(this IN1 message)
        {
            return message.GetAllRecords<XTN>("InsuranceCoPhoneNumberRepetitionsUsed", "GetInsuranceCoPhoneNumber");
        }

        /// <summary>
        /// Get GroupName Records from IN1
        /// </summary>
        public static IEnumerable GetGroupNameRecords(this IN1 message)
        {
            object[] result = message.GetRecords("GroupNameRepetitionsUsed", "GetGroupName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GroupName Records from IN1
        /// </summary>
        public static List<XON> GetAllGroupNameRecords(this IN1 message)
        {
            return message.GetAllRecords<XON>("GroupNameRepetitionsUsed", "GetGroupName");
        }

        /// <summary>
        /// Get InsuredSGroupEmpID Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSGroupEmpIDRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSGroupEmpIDRepetitionsUsed", "GetInsuredSGroupEmpID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSGroupEmpID Records from IN1
        /// </summary>
        public static List<CX> GetAllInsuredSGroupEmpIDRecords(this IN1 message)
        {
            return message.GetAllRecords<CX>("InsuredSGroupEmpIDRepetitionsUsed", "GetInsuredSGroupEmpID");
        }

        /// <summary>
        /// Get InsuredSGroupEmpName Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSGroupEmpNameRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSGroupEmpNameRepetitionsUsed", "GetInsuredSGroupEmpName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSGroupEmpName Records from IN1
        /// </summary>
        public static List<XON> GetAllInsuredSGroupEmpNameRecords(this IN1 message)
        {
            return message.GetAllRecords<XON>("InsuredSGroupEmpNameRepetitionsUsed", "GetInsuredSGroupEmpName");
        }

        /// <summary>
        /// Get NameOfInsured Records from IN1
        /// </summary>
        public static IEnumerable GetNameOfInsuredRecords(this IN1 message)
        {
            object[] result = message.GetRecords("NameOfInsuredRepetitionsUsed", "GetNameOfInsured");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NameOfInsured Records from IN1
        /// </summary>
        public static List<XPN> GetAllNameOfInsuredRecords(this IN1 message)
        {
            return message.GetAllRecords<XPN>("NameOfInsuredRepetitionsUsed", "GetNameOfInsured");
        }

        /// <summary>
        /// Get InsuredSAddress Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSAddressRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSAddressRepetitionsUsed", "GetInsuredSAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSAddress Records from IN1
        /// </summary>
        public static List<XAD> GetAllInsuredSAddressRecords(this IN1 message)
        {
            return message.GetAllRecords<XAD>("InsuredSAddressRepetitionsUsed", "GetInsuredSAddress");
        }

        /// <summary>
        /// Get VerificationBy Records from IN1
        /// </summary>
        public static IEnumerable GetVerificationByRecords(this IN1 message)
        {
            object[] result = message.GetRecords("VerificationByRepetitionsUsed", "GetVerificationBy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VerificationBy Records from IN1
        /// </summary>
        public static List<XCN> GetAllVerificationByRecords(this IN1 message)
        {
            return message.GetAllRecords<XCN>("VerificationByRepetitionsUsed", "GetVerificationBy");
        }

        /// <summary>
        /// Get InsuredSEmployerSAddress Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSEmployerSAddressRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSEmployerSAddressRepetitionsUsed", "GetInsuredSEmployerSAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployerSAddress Records from IN1
        /// </summary>
        public static List<XAD> GetAllInsuredSEmployerSAddressRecords(this IN1 message)
        {
            return message.GetAllRecords<XAD>("InsuredSEmployerSAddressRepetitionsUsed", "GetInsuredSEmployerSAddress");
        }

        /// <summary>
        /// Get InsuredSIDNumber Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSIDNumberRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSIDNumberRepetitionsUsed", "GetInsuredSIDNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSIDNumber Records from IN1
        /// </summary>
        public static List<CX> GetAllInsuredSIDNumberRecords(this IN1 message)
        {
            return message.GetAllRecords<CX>("InsuredSIDNumberRepetitionsUsed", "GetInsuredSIDNumber");
        }

        /// <summary>
        /// Get SubjectDirectoryAttributeExtensionHealthProfessionalData Records from CER
        /// </summary>
        public static IEnumerable GetSubjectDirectoryAttributeExtensionHealthProfessionalDataRecords(this CER message)
        {
            object[] result = message.GetRecords("SubjectDirectoryAttributeExtensionHealthProfessionalDataRepetitionsUsed", "GetSubjectDirectoryAttributeExtensionHealthProfessionalData");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubjectDirectoryAttributeExtensionHealthProfessionalData Records from CER
        /// </summary>
        public static List<CWE> GetAllSubjectDirectoryAttributeExtensionHealthProfessionalDataRecords(this CER message)
        {
            return message.GetAllRecords<CWE>("SubjectDirectoryAttributeExtensionHealthProfessionalDataRepetitionsUsed", "GetSubjectDirectoryAttributeExtensionHealthProfessionalData");
        }

        /// <summary>
        /// Get CRLDistributionPoint Records from CER
        /// </summary>
        public static IEnumerable GetCRLDistributionPointRecords(this CER message)
        {
            object[] result = message.GetRecords("CRLDistributionPointRepetitionsUsed", "GetCRLDistributionPoint");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CRLDistributionPoint Records from CER
        /// </summary>
        public static List<CWE> GetAllCRLDistributionPointRecords(this CER message)
        {
            return message.GetAllRecords<CWE>("CRLDistributionPointRepetitionsUsed", "GetCRLDistributionPoint");
        }

        /// <summary>
        /// Get JurisdictionBreadth Records from CER
        /// </summary>
        public static IEnumerable GetJurisdictionBreadthRecords(this CER message)
        {
            object[] result = message.GetRecords("JurisdictionBreadthRepetitionsUsed", "GetJurisdictionBreadth");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all JurisdictionBreadth Records from CER
        /// </summary>
        public static List<CWE> GetAllJurisdictionBreadthRecords(this CER message)
        {
            return message.GetAllRecords<CWE>("JurisdictionBreadthRepetitionsUsed", "GetJurisdictionBreadth");
        }

        /// <summary>
        /// Get ResourceGroup Records from AIG
        /// </summary>
        public static IEnumerable GetResourceGroupRecords(this AIG message)
        {
            object[] result = message.GetRecords("ResourceGroupRepetitionsUsed", "GetResourceGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ResourceGroup Records from AIG
        /// </summary>
        public static List<CE> GetAllResourceGroupRecords(this AIG message)
        {
            return message.GetAllRecords<CE>("ResourceGroupRepetitionsUsed", "GetResourceGroup");
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
        /// Get DispensingProvider Records from RXD
        /// </summary>
        public static IEnumerable GetDispensingProviderRecords(this RXD message)
        {
            object[] result = message.GetRecords("DispensingProviderRepetitionsUsed", "GetDispensingProvider");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DispensingProvider Records from RXD
        /// </summary>
        public static List<XCN> GetAllDispensingProviderRecords(this RXD message)
        {
            return message.GetAllRecords<XCN>("DispensingProviderRepetitionsUsed", "GetDispensingProvider");
        }

        /// <summary>
        /// Get PharmacyTreatmentSupplierSSpecialDispensingInstructions Records from RXD
        /// </summary>
        public static IEnumerable GetPharmacyTreatmentSupplierSSpecialDispensingInstructionsRecords(this RXD message)
        {
            object[] result = message.GetRecords("PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialDispensingInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacyTreatmentSupplierSSpecialDispensingInstructions Records from RXD
        /// </summary>
        public static List<CE> GetAllPharmacyTreatmentSupplierSSpecialDispensingInstructionsRecords(this RXD message)
        {
            return message.GetAllRecords<CE>("PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialDispensingInstructions");
        }

        /// <summary>
        /// Get SubstanceLotNumber Records from RXD
        /// </summary>
        public static IEnumerable GetSubstanceLotNumberRecords(this RXD message)
        {
            object[] result = message.GetRecords("SubstanceLotNumberRepetitionsUsed", "GetSubstanceLotNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceLotNumber Records from RXD
        /// </summary>
        public static List<ST> GetAllSubstanceLotNumberRecords(this RXD message)
        {
            return message.GetAllRecords<ST>("SubstanceLotNumberRepetitionsUsed", "GetSubstanceLotNumber");
        }

        /// <summary>
        /// Get SubstanceExpirationDate Records from RXD
        /// </summary>
        public static IEnumerable GetSubstanceExpirationDateRecords(this RXD message)
        {
            object[] result = message.GetRecords("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceExpirationDate Records from RXD
        /// </summary>
        public static List<TS> GetAllSubstanceExpirationDateRecords(this RXD message)
        {
            return message.GetAllRecords<TS>("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");
        }

        /// <summary>
        /// Get SubstanceManufacturerName Records from RXD
        /// </summary>
        public static IEnumerable GetSubstanceManufacturerNameRecords(this RXD message)
        {
            object[] result = message.GetRecords("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceManufacturerName Records from RXD
        /// </summary>
        public static List<CE> GetAllSubstanceManufacturerNameRecords(this RXD message)
        {
            return message.GetAllRecords<CE>("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");
        }

        /// <summary>
        /// Get Indication Records from RXD
        /// </summary>
        public static IEnumerable GetIndicationRecords(this RXD message)
        {
            object[] result = message.GetRecords("IndicationRepetitionsUsed", "GetIndication");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Indication Records from RXD
        /// </summary>
        public static List<CE> GetAllIndicationRecords(this RXD message)
        {
            return message.GetAllRecords<CE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Get SupplementaryCode Records from RXD
        /// </summary>
        public static IEnumerable GetSupplementaryCodeRecords(this RXD message)
        {
            object[] result = message.GetRecords("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SupplementaryCode Records from RXD
        /// </summary>
        public static List<CE> GetAllSupplementaryCodeRecords(this RXD message)
        {
            return message.GetAllRecords<CE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Get RolePerson Records from ROL
        /// </summary>
        public static IEnumerable GetRolePersonRecords(this ROL message)
        {
            object[] result = message.GetRecords("RolePersonRepetitionsUsed", "GetRolePerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RolePerson Records from ROL
        /// </summary>
        public static List<XCN> GetAllRolePersonRecords(this ROL message)
        {
            return message.GetAllRecords<XCN>("RolePersonRepetitionsUsed", "GetRolePerson");
        }

        /// <summary>
        /// Get ProviderType Records from ROL
        /// </summary>
        public static IEnumerable GetProviderTypeRecords(this ROL message)
        {
            object[] result = message.GetRecords("ProviderTypeRepetitionsUsed", "GetProviderType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderType Records from ROL
        /// </summary>
        public static List<CE> GetAllProviderTypeRecords(this ROL message)
        {
            return message.GetAllRecords<CE>("ProviderTypeRepetitionsUsed", "GetProviderType");
        }

        /// <summary>
        /// Get OfficeHomeAddressBirthplace Records from ROL
        /// </summary>
        public static IEnumerable GetOfficeHomeAddressBirthplaceRecords(this ROL message)
        {
            object[] result = message.GetRecords("OfficeHomeAddressBirthplaceRepetitionsUsed", "GetOfficeHomeAddressBirthplace");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OfficeHomeAddressBirthplace Records from ROL
        /// </summary>
        public static List<XAD> GetAllOfficeHomeAddressBirthplaceRecords(this ROL message)
        {
            return message.GetAllRecords<XAD>("OfficeHomeAddressBirthplaceRepetitionsUsed", "GetOfficeHomeAddressBirthplace");
        }

        /// <summary>
        /// Get Phone Records from ROL
        /// </summary>
        public static IEnumerable GetPhoneRecords(this ROL message)
        {
            object[] result = message.GetRecords("PhoneRepetitionsUsed", "GetPhone");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Phone Records from ROL
        /// </summary>
        public static List<XTN> GetAllPhoneRecords(this ROL message)
        {
            return message.GetAllRecords<XTN>("PhoneRepetitionsUsed", "GetPhone");
        }

        /// <summary>
        /// Get AttendingDoctor Records from PV1
        /// </summary>
        public static IEnumerable GetAttendingDoctorRecords(this PV1 message)
        {
            object[] result = message.GetRecords("AttendingDoctorRepetitionsUsed", "GetAttendingDoctor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AttendingDoctor Records from PV1
        /// </summary>
        public static List<XCN> GetAllAttendingDoctorRecords(this PV1 message)
        {
            return message.GetAllRecords<XCN>("AttendingDoctorRepetitionsUsed", "GetAttendingDoctor");
        }

        /// <summary>
        /// Get ReferringDoctor Records from PV1
        /// </summary>
        public static IEnumerable GetReferringDoctorRecords(this PV1 message)
        {
            object[] result = message.GetRecords("ReferringDoctorRepetitionsUsed", "GetReferringDoctor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferringDoctor Records from PV1
        /// </summary>
        public static List<XCN> GetAllReferringDoctorRecords(this PV1 message)
        {
            return message.GetAllRecords<XCN>("ReferringDoctorRepetitionsUsed", "GetReferringDoctor");
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
        public static List<XCN> GetAllConsultingDoctorRecords(this PV1 message)
        {
            return message.GetAllRecords<XCN>("ConsultingDoctorRepetitionsUsed", "GetConsultingDoctor");
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
        public static List<IS> GetAllAmbulatoryStatusRecords(this PV1 message)
        {
            return message.GetAllRecords<IS>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Get AdmittingDoctor Records from PV1
        /// </summary>
        public static IEnumerable GetAdmittingDoctorRecords(this PV1 message)
        {
            object[] result = message.GetRecords("AdmittingDoctorRepetitionsUsed", "GetAdmittingDoctor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdmittingDoctor Records from PV1
        /// </summary>
        public static List<XCN> GetAllAdmittingDoctorRecords(this PV1 message)
        {
            return message.GetAllRecords<XCN>("AdmittingDoctorRepetitionsUsed", "GetAdmittingDoctor");
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
        public static List<FC> GetAllFinancialClassRecords(this PV1 message)
        {
            return message.GetAllRecords<FC>("FinancialClassRepetitionsUsed", "GetFinancialClass");
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
        public static List<IS> GetAllContractCodeRecords(this PV1 message)
        {
            return message.GetAllRecords<IS>("ContractCodeRepetitionsUsed", "GetContractCode");
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
        /// Get DischargeDateTime Records from PV1
        /// </summary>
        public static IEnumerable GetDischargeDateTimeRecords(this PV1 message)
        {
            object[] result = message.GetRecords("DischargeDateTimeRepetitionsUsed", "GetDischargeDateTime");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DischargeDateTime Records from PV1
        /// </summary>
        public static List<TS> GetAllDischargeDateTimeRecords(this PV1 message)
        {
            return message.GetAllRecords<TS>("DischargeDateTimeRepetitionsUsed", "GetDischargeDateTime");
        }

        /// <summary>
        /// Get OtherHealthcareProvider Records from PV1
        /// </summary>
        public static IEnumerable GetOtherHealthcareProviderRecords(this PV1 message)
        {
            object[] result = message.GetRecords("OtherHealthcareProviderRepetitionsUsed", "GetOtherHealthcareProvider");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherHealthcareProvider Records from PV1
        /// </summary>
        public static List<XCN> GetAllOtherHealthcareProviderRecords(this PV1 message)
        {
            return message.GetAllRecords<XCN>("OtherHealthcareProviderRepetitionsUsed", "GetOtherHealthcareProvider");
        }

        /// <summary>
        /// Get ManufacturerDistributor Records from PDC
        /// </summary>
        public static IEnumerable GetManufacturerDistributorRecords(this PDC message)
        {
            object[] result = message.GetRecords("ManufacturerDistributorRepetitionsUsed", "GetManufacturerDistributor");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ManufacturerDistributor Records from PDC
        /// </summary>
        public static List<XON> GetAllManufacturerDistributorRecords(this PDC message)
        {
            return message.GetAllRecords<XON>("ManufacturerDistributorRepetitionsUsed", "GetManufacturerDistributor");
        }

        /// <summary>
        /// Get ModelIdentifier Records from PDC
        /// </summary>
        public static IEnumerable GetModelIdentifierRecords(this PDC message)
        {
            object[] result = message.GetRecords("ModelIdentifierRepetitionsUsed", "GetModelIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ModelIdentifier Records from PDC
        /// </summary>
        public static List<ST> GetAllModelIdentifierRecords(this PDC message)
        {
            return message.GetAllRecords<ST>("ModelIdentifierRepetitionsUsed", "GetModelIdentifier");
        }

        /// <summary>
        /// Get OtherIdentifier Records from PDC
        /// </summary>
        public static IEnumerable GetOtherIdentifierRecords(this PDC message)
        {
            object[] result = message.GetRecords("OtherIdentifierRepetitionsUsed", "GetOtherIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherIdentifier Records from PDC
        /// </summary>
        public static List<ST> GetAllOtherIdentifierRecords(this PDC message)
        {
            return message.GetAllRecords<ST>("OtherIdentifierRepetitionsUsed", "GetOtherIdentifier");
        }

        /// <summary>
        /// Get PrimaryActivityProviderCodeName Records from TXA
        /// </summary>
        public static IEnumerable GetPrimaryActivityProviderCodeNameRecords(this TXA message)
        {
            object[] result = message.GetRecords("PrimaryActivityProviderCodeNameRepetitionsUsed", "GetPrimaryActivityProviderCodeName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryActivityProviderCodeName Records from TXA
        /// </summary>
        public static List<XCN> GetAllPrimaryActivityProviderCodeNameRecords(this TXA message)
        {
            return message.GetAllRecords<XCN>("PrimaryActivityProviderCodeNameRepetitionsUsed", "GetPrimaryActivityProviderCodeName");
        }

        /// <summary>
        /// Get EditDateTime Records from TXA
        /// </summary>
        public static IEnumerable GetEditDateTimeRecords(this TXA message)
        {
            object[] result = message.GetRecords("EditDateTimeRepetitionsUsed", "GetEditDateTime");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EditDateTime Records from TXA
        /// </summary>
        public static List<TS> GetAllEditDateTimeRecords(this TXA message)
        {
            return message.GetAllRecords<TS>("EditDateTimeRepetitionsUsed", "GetEditDateTime");
        }

        /// <summary>
        /// Get OriginatorCodeName Records from TXA
        /// </summary>
        public static IEnumerable GetOriginatorCodeNameRecords(this TXA message)
        {
            object[] result = message.GetRecords("OriginatorCodeNameRepetitionsUsed", "GetOriginatorCodeName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OriginatorCodeName Records from TXA
        /// </summary>
        public static List<XCN> GetAllOriginatorCodeNameRecords(this TXA message)
        {
            return message.GetAllRecords<XCN>("OriginatorCodeNameRepetitionsUsed", "GetOriginatorCodeName");
        }

        /// <summary>
        /// Get AssignedDocumentAuthenticator Records from TXA
        /// </summary>
        public static IEnumerable GetAssignedDocumentAuthenticatorRecords(this TXA message)
        {
            object[] result = message.GetRecords("AssignedDocumentAuthenticatorRepetitionsUsed", "GetAssignedDocumentAuthenticator");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AssignedDocumentAuthenticator Records from TXA
        /// </summary>
        public static List<XCN> GetAllAssignedDocumentAuthenticatorRecords(this TXA message)
        {
            return message.GetAllRecords<XCN>("AssignedDocumentAuthenticatorRepetitionsUsed", "GetAssignedDocumentAuthenticator");
        }

        /// <summary>
        /// Get TranscriptionistCodeName Records from TXA
        /// </summary>
        public static IEnumerable GetTranscriptionistCodeNameRecords(this TXA message)
        {
            object[] result = message.GetRecords("TranscriptionistCodeNameRepetitionsUsed", "GetTranscriptionistCodeName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TranscriptionistCodeName Records from TXA
        /// </summary>
        public static List<XCN> GetAllTranscriptionistCodeNameRecords(this TXA message)
        {
            return message.GetAllRecords<XCN>("TranscriptionistCodeNameRepetitionsUsed", "GetTranscriptionistCodeName");
        }

        /// <summary>
        /// Get PlacerOrderNumber Records from TXA
        /// </summary>
        public static IEnumerable GetPlacerOrderNumberRecords(this TXA message)
        {
            object[] result = message.GetRecords("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerOrderNumber Records from TXA
        /// </summary>
        public static List<EI> GetAllPlacerOrderNumberRecords(this TXA message)
        {
            return message.GetAllRecords<EI>("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");
        }

        /// <summary>
        /// Get AuthenticationPersonTimeStamp Records from TXA
        /// </summary>
        public static IEnumerable GetAuthenticationPersonTimeStampRecords(this TXA message)
        {
            object[] result = message.GetRecords("AuthenticationPersonTimeStampRepetitionsUsed", "GetAuthenticationPersonTimeStamp");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AuthenticationPersonTimeStamp Records from TXA
        /// </summary>
        public static List<PPN> GetAllAuthenticationPersonTimeStampRecords(this TXA message)
        {
            return message.GetAllRecords<PPN>("AuthenticationPersonTimeStampRepetitionsUsed", "GetAuthenticationPersonTimeStamp");
        }

        /// <summary>
        /// Get DistributedCopiesCodeandNameofRecipients Records from TXA
        /// </summary>
        public static IEnumerable GetDistributedCopiesCodeandNameofRecipientsRecords(this TXA message)
        {
            object[] result = message.GetRecords("DistributedCopiesCodeandNameofRecipientsRepetitionsUsed", "GetDistributedCopiesCodeandNameofRecipients");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DistributedCopiesCodeandNameofRecipients Records from TXA
        /// </summary>
        public static List<XCN> GetAllDistributedCopiesCodeandNameofRecipientsRecords(this TXA message)
        {
            return message.GetAllRecords<XCN>("DistributedCopiesCodeandNameofRecipientsRepetitionsUsed", "GetDistributedCopiesCodeandNameofRecipients");
        }

        /// <summary>
        /// Get SupplementaryCode Records from RXC
        /// </summary>
        public static IEnumerable GetSupplementaryCodeRecords(this RXC message)
        {
            object[] result = message.GetRecords("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SupplementaryCode Records from RXC
        /// </summary>
        public static List<CE> GetAllSupplementaryCodeRecords(this RXC message)
        {
            return message.GetAllRecords<CE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Get SortByField Records from RCP
        /// </summary>
        public static IEnumerable GetSortByFieldRecords(this RCP message)
        {
            object[] result = message.GetRecords("SortByFieldRepetitionsUsed", "GetSortByField");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SortByField Records from RCP
        /// </summary>
        public static List<SRT> GetAllSortByFieldRecords(this RCP message)
        {
            return message.GetAllRecords<SRT>("SortByFieldRepetitionsUsed", "GetSortByField");
        }

        /// <summary>
        /// Get SegmentGroupInclusion Records from RCP
        /// </summary>
        public static IEnumerable GetSegmentGroupInclusionRecords(this RCP message)
        {
            object[] result = message.GetRecords("SegmentGroupInclusionRepetitionsUsed", "GetSegmentGroupInclusion");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SegmentGroupInclusion Records from RCP
        /// </summary>
        public static List<ID> GetAllSegmentGroupInclusionRecords(this RCP message)
        {
            return message.GetAllRecords<ID>("SegmentGroupInclusionRepetitionsUsed", "GetSegmentGroupInclusion");
        }

        /// <summary>
        /// Get ProductSerialLotNumber Records from PCR
        /// </summary>
        public static IEnumerable GetProductSerialLotNumberRecords(this PCR message)
        {
            object[] result = message.GetRecords("ProductSerialLotNumberRepetitionsUsed", "GetProductSerialLotNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProductSerialLotNumber Records from PCR
        /// </summary>
        public static List<ST> GetAllProductSerialLotNumberRecords(this PCR message)
        {
            return message.GetAllRecords<ST>("ProductSerialLotNumberRepetitionsUsed", "GetProductSerialLotNumber");
        }

        /// <summary>
        /// Get ActionTakenInResponseToTheEvent Records from PCR
        /// </summary>
        public static IEnumerable GetActionTakenInResponseToTheEventRecords(this PCR message)
        {
            object[] result = message.GetRecords("ActionTakenInResponseToTheEventRepetitionsUsed", "GetActionTakenInResponseToTheEvent");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ActionTakenInResponseToTheEvent Records from PCR
        /// </summary>
        public static List<ID> GetAllActionTakenInResponseToTheEventRecords(this PCR message)
        {
            return message.GetAllRecords<ID>("ActionTakenInResponseToTheEventRepetitionsUsed", "GetActionTakenInResponseToTheEvent");
        }

        /// <summary>
        /// Get EventCausalityObservations Records from PCR
        /// </summary>
        public static IEnumerable GetEventCausalityObservationsRecords(this PCR message)
        {
            object[] result = message.GetRecords("EventCausalityObservationsRepetitionsUsed", "GetEventCausalityObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventCausalityObservations Records from PCR
        /// </summary>
        public static List<ID> GetAllEventCausalityObservationsRecords(this PCR message)
        {
            return message.GetAllRecords<ID>("EventCausalityObservationsRepetitionsUsed", "GetEventCausalityObservations");
        }

        /// <summary>
        /// Get IndirectExposureMechanism Records from PCR
        /// </summary>
        public static IEnumerable GetIndirectExposureMechanismRecords(this PCR message)
        {
            object[] result = message.GetRecords("IndirectExposureMechanismRepetitionsUsed", "GetIndirectExposureMechanism");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IndirectExposureMechanism Records from PCR
        /// </summary>
        public static List<ID> GetAllIndirectExposureMechanismRecords(this PCR message)
        {
            return message.GetAllRecords<ID>("IndirectExposureMechanismRepetitionsUsed", "GetIndirectExposureMechanism");
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
        public static List<XCN> GetAllCollectorIdentifierRecords(this OBR message)
        {
            return message.GetAllRecords<XCN>("CollectorIdentifierRepetitionsUsed", "GetCollectorIdentifier");
        }

        /// <summary>
        /// Get OrderingProvider Records from OBR
        /// </summary>
        public static IEnumerable GetOrderingProviderRecords(this OBR message)
        {
            object[] result = message.GetRecords("OrderingProviderRepetitionsUsed", "GetOrderingProvider");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingProvider Records from OBR
        /// </summary>
        public static List<XCN> GetAllOrderingProviderRecords(this OBR message)
        {
            return message.GetAllRecords<XCN>("OrderingProviderRepetitionsUsed", "GetOrderingProvider");
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
        public static List<XTN> GetAllOrderCallbackPhoneNumberRecords(this OBR message)
        {
            return message.GetAllRecords<XTN>("OrderCallbackPhoneNumberRepetitionsUsed", "GetOrderCallbackPhoneNumber");
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
        public static List<XCN> GetAllResultCopiesToRecords(this OBR message)
        {
            return message.GetAllRecords<XCN>("ResultCopiesToRepetitionsUsed", "GetResultCopiesTo");
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
        public static List<NDL> GetAllAssistantResultInterpreterRecords(this OBR message)
        {
            return message.GetAllRecords<NDL>("AssistantResultInterpreterRepetitionsUsed", "GetAssistantResultInterpreter");
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
        public static List<NDL> GetAllTechnicianRecords(this OBR message)
        {
            return message.GetAllRecords<NDL>("TechnicianRepetitionsUsed", "GetTechnician");
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
        public static List<NDL> GetAllTranscriptionistRecords(this OBR message)
        {
            return message.GetAllRecords<NDL>("TranscriptionistRepetitionsUsed", "GetTranscriptionist");
        }

        /// <summary>
        /// Get TransportLogisticsOfCollectedSample Records from OBR
        /// </summary>
        public static IEnumerable GetTransportLogisticsOfCollectedSampleRecords(this OBR message)
        {
            object[] result = message.GetRecords("TransportLogisticsOfCollectedSampleRepetitionsUsed", "GetTransportLogisticsOfCollectedSample");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TransportLogisticsOfCollectedSample Records from OBR
        /// </summary>
        public static List<CE> GetAllTransportLogisticsOfCollectedSampleRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("TransportLogisticsOfCollectedSampleRepetitionsUsed", "GetTransportLogisticsOfCollectedSample");
        }

        /// <summary>
        /// Get CollectorSComment Records from OBR
        /// </summary>
        public static IEnumerable GetCollectorSCommentRecords(this OBR message)
        {
            object[] result = message.GetRecords("CollectorSCommentRepetitionsUsed", "GetCollectorSComment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CollectorSComment Records from OBR
        /// </summary>
        public static List<CE> GetAllCollectorSCommentRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("CollectorSCommentRepetitionsUsed", "GetCollectorSComment");
        }

        /// <summary>
        /// Get PlannedPatientTransportComment Records from OBR
        /// </summary>
        public static IEnumerable GetPlannedPatientTransportCommentRecords(this OBR message)
        {
            object[] result = message.GetRecords("PlannedPatientTransportCommentRepetitionsUsed", "GetPlannedPatientTransportComment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlannedPatientTransportComment Records from OBR
        /// </summary>
        public static List<CE> GetAllPlannedPatientTransportCommentRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("PlannedPatientTransportCommentRepetitionsUsed", "GetPlannedPatientTransportComment");
        }

        /// <summary>
        /// Get ProcedureCodeModifier Records from OBR
        /// </summary>
        public static IEnumerable GetProcedureCodeModifierRecords(this OBR message)
        {
            object[] result = message.GetRecords("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCodeModifier Records from OBR
        /// </summary>
        public static List<CE> GetAllProcedureCodeModifierRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Get PlacerSupplementalServiceInformation Records from OBR
        /// </summary>
        public static IEnumerable GetPlacerSupplementalServiceInformationRecords(this OBR message)
        {
            object[] result = message.GetRecords("PlacerSupplementalServiceInformationRepetitionsUsed", "GetPlacerSupplementalServiceInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerSupplementalServiceInformation Records from OBR
        /// </summary>
        public static List<CE> GetAllPlacerSupplementalServiceInformationRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("PlacerSupplementalServiceInformationRepetitionsUsed", "GetPlacerSupplementalServiceInformation");
        }

        /// <summary>
        /// Get FillerSupplementalServiceInformation Records from OBR
        /// </summary>
        public static IEnumerable GetFillerSupplementalServiceInformationRecords(this OBR message)
        {
            object[] result = message.GetRecords("FillerSupplementalServiceInformationRepetitionsUsed", "GetFillerSupplementalServiceInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerSupplementalServiceInformation Records from OBR
        /// </summary>
        public static List<CE> GetAllFillerSupplementalServiceInformationRecords(this OBR message)
        {
            return message.GetAllRecords<CE>("FillerSupplementalServiceInformationRepetitionsUsed", "GetFillerSupplementalServiceInformation");
        }

        /// <summary>
        /// Get OperatorID Records from EVN
        /// </summary>
        public static IEnumerable GetOperatorIDRecords(this EVN message)
        {
            object[] result = message.GetRecords("OperatorIDRepetitionsUsed", "GetOperatorID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OperatorID Records from EVN
        /// </summary>
        public static List<XCN> GetAllOperatorIDRecords(this EVN message)
        {
            return message.GetAllRecords<XCN>("OperatorIDRepetitionsUsed", "GetOperatorID");
        }

        /// <summary>
        /// Get SenderOrganizationName Records from PES
        /// </summary>
        public static IEnumerable GetSenderOrganizationNameRecords(this PES message)
        {
            object[] result = message.GetRecords("SenderOrganizationNameRepetitionsUsed", "GetSenderOrganizationName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SenderOrganizationName Records from PES
        /// </summary>
        public static List<XON> GetAllSenderOrganizationNameRecords(this PES message)
        {
            return message.GetAllRecords<XON>("SenderOrganizationNameRepetitionsUsed", "GetSenderOrganizationName");
        }

        /// <summary>
        /// Get SenderIndividualName Records from PES
        /// </summary>
        public static IEnumerable GetSenderIndividualNameRecords(this PES message)
        {
            object[] result = message.GetRecords("SenderIndividualNameRepetitionsUsed", "GetSenderIndividualName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SenderIndividualName Records from PES
        /// </summary>
        public static List<XCN> GetAllSenderIndividualNameRecords(this PES message)
        {
            return message.GetAllRecords<XCN>("SenderIndividualNameRepetitionsUsed", "GetSenderIndividualName");
        }

        /// <summary>
        /// Get SenderAddress Records from PES
        /// </summary>
        public static IEnumerable GetSenderAddressRecords(this PES message)
        {
            object[] result = message.GetRecords("SenderAddressRepetitionsUsed", "GetSenderAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SenderAddress Records from PES
        /// </summary>
        public static List<XAD> GetAllSenderAddressRecords(this PES message)
        {
            return message.GetAllRecords<XAD>("SenderAddressRepetitionsUsed", "GetSenderAddress");
        }

        /// <summary>
        /// Get SenderTelephone Records from PES
        /// </summary>
        public static IEnumerable GetSenderTelephoneRecords(this PES message)
        {
            object[] result = message.GetRecords("SenderTelephoneRepetitionsUsed", "GetSenderTelephone");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SenderTelephone Records from PES
        /// </summary>
        public static List<XTN> GetAllSenderTelephoneRecords(this PES message)
        {
            return message.GetAllRecords<XTN>("SenderTelephoneRepetitionsUsed", "GetSenderTelephone");
        }

        /// <summary>
        /// Get SenderEventDescription Records from PES
        /// </summary>
        public static IEnumerable GetSenderEventDescriptionRecords(this PES message)
        {
            object[] result = message.GetRecords("SenderEventDescriptionRepetitionsUsed", "GetSenderEventDescription");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SenderEventDescription Records from PES
        /// </summary>
        public static List<FT> GetAllSenderEventDescriptionRecords(this PES message)
        {
            return message.GetAllRecords<FT>("SenderEventDescriptionRepetitionsUsed", "GetSenderEventDescription");
        }

        /// <summary>
        /// Get EventReportTimingType Records from PES
        /// </summary>
        public static IEnumerable GetEventReportTimingTypeRecords(this PES message)
        {
            object[] result = message.GetRecords("EventReportTimingTypeRepetitionsUsed", "GetEventReportTimingType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventReportTimingType Records from PES
        /// </summary>
        public static List<ID> GetAllEventReportTimingTypeRecords(this PES message)
        {
            return message.GetAllRecords<ID>("EventReportTimingTypeRepetitionsUsed", "GetEventReportTimingType");
        }

        /// <summary>
        /// Get EventReportedTo Records from PES
        /// </summary>
        public static IEnumerable GetEventReportedToRecords(this PES message)
        {
            object[] result = message.GetRecords("EventReportedToRepetitionsUsed", "GetEventReportedTo");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventReportedTo Records from PES
        /// </summary>
        public static List<ID> GetAllEventReportedToRecords(this PES message)
        {
            return message.GetAllRecords<ID>("EventReportedToRepetitionsUsed", "GetEventReportedTo");
        }

        /// <summary>
        /// Get DeathCauseCode Records from PDA
        /// </summary>
        public static IEnumerable GetDeathCauseCodeRecords(this PDA message)
        {
            object[] result = message.GetRecords("DeathCauseCodeRepetitionsUsed", "GetDeathCauseCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DeathCauseCode Records from PDA
        /// </summary>
        public static List<CE> GetAllDeathCauseCodeRecords(this PDA message)
        {
            return message.GetAllRecords<CE>("DeathCauseCodeRepetitionsUsed", "GetDeathCauseCode");
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
        /// Get ProtocolCode Records from IPC
        /// </summary>
        public static IEnumerable GetProtocolCodeRecords(this IPC message)
        {
            object[] result = message.GetRecords("ProtocolCodeRepetitionsUsed", "GetProtocolCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProtocolCode Records from IPC
        /// </summary>
        public static List<CE> GetAllProtocolCodeRecords(this IPC message)
        {
            return message.GetAllRecords<CE>("ProtocolCodeRepetitionsUsed", "GetProtocolCode");
        }

        /// <summary>
        /// Get ScheduledProcedureStepLocation Records from IPC
        /// </summary>
        public static IEnumerable GetScheduledProcedureStepLocationRecords(this IPC message)
        {
            object[] result = message.GetRecords("ScheduledProcedureStepLocationRepetitionsUsed", "GetScheduledProcedureStepLocation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ScheduledProcedureStepLocation Records from IPC
        /// </summary>
        public static List<CE> GetAllScheduledProcedureStepLocationRecords(this IPC message)
        {
            return message.GetAllRecords<CE>("ScheduledProcedureStepLocationRepetitionsUsed", "GetScheduledProcedureStepLocation");
        }

        /// <summary>
        /// Get ProcedureCodeModifier Records from IIM
        /// </summary>
        public static IEnumerable GetProcedureCodeModifierRecords(this IIM message)
        {
            object[] result = message.GetRecords("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCodeModifier Records from IIM
        /// </summary>
        public static List<CE> GetAllProcedureCodeModifierRecords(this IIM message)
        {
            return message.GetAllRecords<CE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Get OCEEditCode Records from GP2
        /// </summary>
        public static IEnumerable GetOCEEditCodeRecords(this GP2 message)
        {
            object[] result = message.GetRecords("OCEEditCodeRepetitionsUsed", "GetOCEEditCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OCEEditCode Records from GP2
        /// </summary>
        public static List<IS> GetAllOCEEditCodeRecords(this GP2 message)
        {
            return message.GetAllRecords<IS>("OCEEditCodeRepetitionsUsed", "GetOCEEditCode");
        }

        /// <summary>
        /// Get ModifierEditCode Records from GP2
        /// </summary>
        public static IEnumerable GetModifierEditCodeRecords(this GP2 message)
        {
            object[] result = message.GetRecords("ModifierEditCodeRepetitionsUsed", "GetModifierEditCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ModifierEditCode Records from GP2
        /// </summary>
        public static List<IS> GetAllModifierEditCodeRecords(this GP2 message)
        {
            return message.GetAllRecords<IS>("ModifierEditCodeRepetitionsUsed", "GetModifierEditCode");
        }

        /// <summary>
        /// Get AdministrationNotes Records from RXA
        /// </summary>
        public static IEnumerable GetAdministrationNotesRecords(this RXA message)
        {
            object[] result = message.GetRecords("AdministrationNotesRepetitionsUsed", "GetAdministrationNotes");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdministrationNotes Records from RXA
        /// </summary>
        public static List<CE> GetAllAdministrationNotesRecords(this RXA message)
        {
            return message.GetAllRecords<CE>("AdministrationNotesRepetitionsUsed", "GetAdministrationNotes");
        }

        /// <summary>
        /// Get AdministeringProvider Records from RXA
        /// </summary>
        public static IEnumerable GetAdministeringProviderRecords(this RXA message)
        {
            object[] result = message.GetRecords("AdministeringProviderRepetitionsUsed", "GetAdministeringProvider");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdministeringProvider Records from RXA
        /// </summary>
        public static List<XCN> GetAllAdministeringProviderRecords(this RXA message)
        {
            return message.GetAllRecords<XCN>("AdministeringProviderRepetitionsUsed", "GetAdministeringProvider");
        }

        /// <summary>
        /// Get SubstanceLotNumber Records from RXA
        /// </summary>
        public static IEnumerable GetSubstanceLotNumberRecords(this RXA message)
        {
            object[] result = message.GetRecords("SubstanceLotNumberRepetitionsUsed", "GetSubstanceLotNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceLotNumber Records from RXA
        /// </summary>
        public static List<ST> GetAllSubstanceLotNumberRecords(this RXA message)
        {
            return message.GetAllRecords<ST>("SubstanceLotNumberRepetitionsUsed", "GetSubstanceLotNumber");
        }

        /// <summary>
        /// Get SubstanceExpirationDate Records from RXA
        /// </summary>
        public static IEnumerable GetSubstanceExpirationDateRecords(this RXA message)
        {
            object[] result = message.GetRecords("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceExpirationDate Records from RXA
        /// </summary>
        public static List<TS> GetAllSubstanceExpirationDateRecords(this RXA message)
        {
            return message.GetAllRecords<TS>("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");
        }

        /// <summary>
        /// Get SubstanceManufacturerName Records from RXA
        /// </summary>
        public static IEnumerable GetSubstanceManufacturerNameRecords(this RXA message)
        {
            object[] result = message.GetRecords("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceManufacturerName Records from RXA
        /// </summary>
        public static List<CE> GetAllSubstanceManufacturerNameRecords(this RXA message)
        {
            return message.GetAllRecords<CE>("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");
        }

        /// <summary>
        /// Get SubstanceTreatmentRefusalReason Records from RXA
        /// </summary>
        public static IEnumerable GetSubstanceTreatmentRefusalReasonRecords(this RXA message)
        {
            object[] result = message.GetRecords("SubstanceTreatmentRefusalReasonRepetitionsUsed", "GetSubstanceTreatmentRefusalReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceTreatmentRefusalReason Records from RXA
        /// </summary>
        public static List<CE> GetAllSubstanceTreatmentRefusalReasonRecords(this RXA message)
        {
            return message.GetAllRecords<CE>("SubstanceTreatmentRefusalReasonRepetitionsUsed", "GetSubstanceTreatmentRefusalReason");
        }

        /// <summary>
        /// Get Indication Records from RXA
        /// </summary>
        public static IEnumerable GetIndicationRecords(this RXA message)
        {
            object[] result = message.GetRecords("IndicationRepetitionsUsed", "GetIndication");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Indication Records from RXA
        /// </summary>
        public static List<CE> GetAllIndicationRecords(this RXA message)
        {
            return message.GetAllRecords<CE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Get CategoryIdentifier Records from OM7
        /// </summary>
        public static IEnumerable GetCategoryIdentifierRecords(this OM7 message)
        {
            object[] result = message.GetRecords("CategoryIdentifierRepetitionsUsed", "GetCategoryIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CategoryIdentifier Records from OM7
        /// </summary>
        public static List<CE> GetAllCategoryIdentifierRecords(this OM7 message)
        {
            return message.GetAllRecords<CE>("CategoryIdentifierRepetitionsUsed", "GetCategoryIdentifier");
        }

        /// <summary>
        /// Get CategorySynonym Records from OM7
        /// </summary>
        public static IEnumerable GetCategorySynonymRecords(this OM7 message)
        {
            object[] result = message.GetRecords("CategorySynonymRepetitionsUsed", "GetCategorySynonym");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CategorySynonym Records from OM7
        /// </summary>
        public static List<ST> GetAllCategorySynonymRecords(this OM7 message)
        {
            return message.GetAllRecords<ST>("CategorySynonymRepetitionsUsed", "GetCategorySynonym");
        }

        /// <summary>
        /// Get OrderableAtLocation Records from OM7
        /// </summary>
        public static IEnumerable GetOrderableAtLocationRecords(this OM7 message)
        {
            object[] result = message.GetRecords("OrderableAtLocationRepetitionsUsed", "GetOrderableAtLocation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderableAtLocation Records from OM7
        /// </summary>
        public static List<PL> GetAllOrderableAtLocationRecords(this OM7 message)
        {
            return message.GetAllRecords<PL>("OrderableAtLocationRepetitionsUsed", "GetOrderableAtLocation");
        }

        /// <summary>
        /// Get PrimaryKeyValueCDM Records from OM7
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueCDMRecords(this OM7 message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueCDMRepetitionsUsed", "GetPrimaryKeyValueCDM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValueCDM Records from OM7
        /// </summary>
        public static List<CE> GetAllPrimaryKeyValueCDMRecords(this OM7 message)
        {
            return message.GetAllRecords<CE>("PrimaryKeyValueCDMRepetitionsUsed", "GetPrimaryKeyValueCDM");
        }

        /// <summary>
        /// Get PrimaryKeyValueMFE Records from MFE
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueMFERecords(this MFE message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueMFERepetitionsUsed", "GetPrimaryKeyValueMFE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValueMFE Records from MFE
        /// </summary>
        public static List<Varies> GetAllPrimaryKeyValueMFERecords(this MFE message)
        {
            return message.GetAllRecords<Varies>("PrimaryKeyValueMFERepetitionsUsed", "GetPrimaryKeyValueMFE");
        }

        /// <summary>
        /// Get PrimaryKeyValueType Records from MFE
        /// </summary>
        public static IEnumerable GetPrimaryKeyValueTypeRecords(this MFE message)
        {
            object[] result = message.GetRecords("PrimaryKeyValueTypeRepetitionsUsed", "GetPrimaryKeyValueType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryKeyValueType Records from MFE
        /// </summary>
        public static List<ID> GetAllPrimaryKeyValueTypeRecords(this MFE message)
        {
            return message.GetAllRecords<ID>("PrimaryKeyValueTypeRepetitionsUsed", "GetPrimaryKeyValueType");
        }

        /// <summary>
        /// Get AccommodationType Records from LCC
        /// </summary>
        public static IEnumerable GetAccommodationTypeRecords(this LCC message)
        {
            object[] result = message.GetRecords("AccommodationTypeRepetitionsUsed", "GetAccommodationType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AccommodationType Records from LCC
        /// </summary>
        public static List<CE> GetAllAccommodationTypeRecords(this LCC message)
        {
            return message.GetAllRecords<CE>("AccommodationTypeRepetitionsUsed", "GetAccommodationType");
        }

        /// <summary>
        /// Get ChargeCode Records from LCC
        /// </summary>
        public static IEnumerable GetChargeCodeRecords(this LCC message)
        {
            object[] result = message.GetRecords("ChargeCodeRepetitionsUsed", "GetChargeCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ChargeCode Records from LCC
        /// </summary>
        public static List<CE> GetAllChargeCodeRecords(this LCC message)
        {
            return message.GetAllRecords<CE>("ChargeCodeRepetitionsUsed", "GetChargeCode");
        }

        /// <summary>
        /// Get RevenueCode Records from GP1
        /// </summary>
        public static IEnumerable GetRevenueCodeRecords(this GP1 message)
        {
            object[] result = message.GetRecords("RevenueCodeRepetitionsUsed", "GetRevenueCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RevenueCode Records from GP1
        /// </summary>
        public static List<IS> GetAllRevenueCodeRecords(this GP1 message)
        {
            return message.GetAllRecords<IS>("RevenueCodeRepetitionsUsed", "GetRevenueCode");
        }

        /// <summary>
        /// Get OCEEditsPerVisitCode Records from GP1
        /// </summary>
        public static IEnumerable GetOCEEditsPerVisitCodeRecords(this GP1 message)
        {
            object[] result = message.GetRecords("OCEEditsPerVisitCodeRepetitionsUsed", "GetOCEEditsPerVisitCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OCEEditsPerVisitCode Records from GP1
        /// </summary>
        public static List<IS> GetAllOCEEditsPerVisitCodeRecords(this GP1 message)
        {
            return message.GetAllRecords<IS>("OCEEditsPerVisitCodeRepetitionsUsed", "GetOCEEditsPerVisitCode");
        }

        /// <summary>
        /// Get EventsScheduledThisTimePoint Records from CM2
        /// </summary>
        public static IEnumerable GetEventsScheduledThisTimePointRecords(this CM2 message)
        {
            object[] result = message.GetRecords("EventsScheduledThisTimePointRepetitionsUsed", "GetEventsScheduledThisTimePoint");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventsScheduledThisTimePoint Records from CM2
        /// </summary>
        public static List<CE> GetAllEventsScheduledThisTimePointRecords(this CM2 message)
        {
            return message.GetAllRecords<CE>("EventsScheduledThisTimePointRepetitionsUsed", "GetEventsScheduledThisTimePoint");
        }

        /// <summary>
        /// Get ChargeCodeAlias Records from CDM
        /// </summary>
        public static IEnumerable GetChargeCodeAliasRecords(this CDM message)
        {
            object[] result = message.GetRecords("ChargeCodeAliasRepetitionsUsed", "GetChargeCodeAlias");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ChargeCodeAlias Records from CDM
        /// </summary>
        public static List<CE> GetAllChargeCodeAliasRecords(this CDM message)
        {
            return message.GetAllRecords<CE>("ChargeCodeAliasRepetitionsUsed", "GetChargeCodeAlias");
        }

        /// <summary>
        /// Get ExplodingCharges Records from CDM
        /// </summary>
        public static IEnumerable GetExplodingChargesRecords(this CDM message)
        {
            object[] result = message.GetRecords("ExplodingChargesRepetitionsUsed", "GetExplodingCharges");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ExplodingCharges Records from CDM
        /// </summary>
        public static List<CE> GetAllExplodingChargesRecords(this CDM message)
        {
            return message.GetAllRecords<CE>("ExplodingChargesRepetitionsUsed", "GetExplodingCharges");
        }

        /// <summary>
        /// Get ProcedureCode Records from CDM
        /// </summary>
        public static IEnumerable GetProcedureCodeRecords(this CDM message)
        {
            object[] result = message.GetRecords("ProcedureCodeRepetitionsUsed", "GetProcedureCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCode Records from CDM
        /// </summary>
        public static List<CE> GetAllProcedureCodeRecords(this CDM message)
        {
            return message.GetAllRecords<CE>("ProcedureCodeRepetitionsUsed", "GetProcedureCode");
        }

        /// <summary>
        /// Get InventoryNumber Records from CDM
        /// </summary>
        public static IEnumerable GetInventoryNumberRecords(this CDM message)
        {
            object[] result = message.GetRecords("InventoryNumberRepetitionsUsed", "GetInventoryNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InventoryNumber Records from CDM
        /// </summary>
        public static List<CE> GetAllInventoryNumberRecords(this CDM message)
        {
            return message.GetAllRecords<CE>("InventoryNumberRepetitionsUsed", "GetInventoryNumber");
        }

        /// <summary>
        /// Get ContractNumber Records from CDM
        /// </summary>
        public static IEnumerable GetContractNumberRecords(this CDM message)
        {
            object[] result = message.GetRecords("ContractNumberRepetitionsUsed", "GetContractNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContractNumber Records from CDM
        /// </summary>
        public static List<CX> GetAllContractNumberRecords(this CDM message)
        {
            return message.GetAllRecords<CX>("ContractNumberRepetitionsUsed", "GetContractNumber");
        }

        /// <summary>
        /// Get ContractOrganization Records from CDM
        /// </summary>
        public static IEnumerable GetContractOrganizationRecords(this CDM message)
        {
            object[] result = message.GetRecords("ContractOrganizationRepetitionsUsed", "GetContractOrganization");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContractOrganization Records from CDM
        /// </summary>
        public static List<XON> GetAllContractOrganizationRecords(this CDM message)
        {
            return message.GetAllRecords<XON>("ContractOrganizationRepetitionsUsed", "GetContractOrganization");
        }

        /// <summary>
        /// Get PatientIdentifierList Records from PID
        /// </summary>
        public static IEnumerable GetPatientIdentifierListRecords(this PID message)
        {
            object[] result = message.GetRecords("PatientIdentifierListRepetitionsUsed", "GetPatientIdentifierList");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientIdentifierList Records from PID
        /// </summary>
        public static List<CX> GetAllPatientIdentifierListRecords(this PID message)
        {
            return message.GetAllRecords<CX>("PatientIdentifierListRepetitionsUsed", "GetPatientIdentifierList");
        }

        /// <summary>
        /// Get AlternatePatientIDPID Records from PID
        /// </summary>
        public static IEnumerable GetAlternatePatientIDPIDRecords(this PID message)
        {
            object[] result = message.GetRecords("AlternatePatientIDPIDRepetitionsUsed", "GetAlternatePatientIDPID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AlternatePatientIDPID Records from PID
        /// </summary>
        public static List<CX> GetAllAlternatePatientIDPIDRecords(this PID message)
        {
            return message.GetAllRecords<CX>("AlternatePatientIDPIDRepetitionsUsed", "GetAlternatePatientIDPID");
        }

        /// <summary>
        /// Get PatientName Records from PID
        /// </summary>
        public static IEnumerable GetPatientNameRecords(this PID message)
        {
            object[] result = message.GetRecords("PatientNameRepetitionsUsed", "GetPatientName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientName Records from PID
        /// </summary>
        public static List<XPN> GetAllPatientNameRecords(this PID message)
        {
            return message.GetAllRecords<XPN>("PatientNameRepetitionsUsed", "GetPatientName");
        }

        /// <summary>
        /// Get MotherSMaidenName Records from PID
        /// </summary>
        public static IEnumerable GetMotherSMaidenNameRecords(this PID message)
        {
            object[] result = message.GetRecords("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MotherSMaidenName Records from PID
        /// </summary>
        public static List<XPN> GetAllMotherSMaidenNameRecords(this PID message)
        {
            return message.GetAllRecords<XPN>("MotherSMaidenNameRepetitionsUsed", "GetMotherSMaidenName");
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
        public static List<XPN> GetAllPatientAliasRecords(this PID message)
        {
            return message.GetAllRecords<XPN>("PatientAliasRepetitionsUsed", "GetPatientAlias");
        }

        /// <summary>
        /// Get Race Records from PID
        /// </summary>
        public static IEnumerable GetRaceRecords(this PID message)
        {
            object[] result = message.GetRecords("RaceRepetitionsUsed", "GetRace");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Race Records from PID
        /// </summary>
        public static List<CE> GetAllRaceRecords(this PID message)
        {
            return message.GetAllRecords<CE>("RaceRepetitionsUsed", "GetRace");
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
        public static List<XAD> GetAllPatientAddressRecords(this PID message)
        {
            return message.GetAllRecords<XAD>("PatientAddressRepetitionsUsed", "GetPatientAddress");
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
        public static List<XTN> GetAllPhoneNumberHomeRecords(this PID message)
        {
            return message.GetAllRecords<XTN>("PhoneNumberHomeRepetitionsUsed", "GetPhoneNumberHome");
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
        public static List<XTN> GetAllPhoneNumberBusinessRecords(this PID message)
        {
            return message.GetAllRecords<XTN>("PhoneNumberBusinessRepetitionsUsed", "GetPhoneNumberBusiness");
        }

        /// <summary>
        /// Get MotherSIdentifier Records from PID
        /// </summary>
        public static IEnumerable GetMotherSIdentifierRecords(this PID message)
        {
            object[] result = message.GetRecords("MotherSIdentifierRepetitionsUsed", "GetMotherSIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MotherSIdentifier Records from PID
        /// </summary>
        public static List<CX> GetAllMotherSIdentifierRecords(this PID message)
        {
            return message.GetAllRecords<CX>("MotherSIdentifierRepetitionsUsed", "GetMotherSIdentifier");
        }

        /// <summary>
        /// Get EthnicGroup Records from PID
        /// </summary>
        public static IEnumerable GetEthnicGroupRecords(this PID message)
        {
            object[] result = message.GetRecords("EthnicGroupRepetitionsUsed", "GetEthnicGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EthnicGroup Records from PID
        /// </summary>
        public static List<CE> GetAllEthnicGroupRecords(this PID message)
        {
            return message.GetAllRecords<CE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
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
        public static List<CE> GetAllCitizenshipRecords(this PID message)
        {
            return message.GetAllRecords<CE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Get IdentityReliabilityCode Records from PID
        /// </summary>
        public static IEnumerable GetIdentityReliabilityCodeRecords(this PID message)
        {
            object[] result = message.GetRecords("IdentityReliabilityCodeRepetitionsUsed", "GetIdentityReliabilityCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IdentityReliabilityCode Records from PID
        /// </summary>
        public static List<IS> GetAllIdentityReliabilityCodeRecords(this PID message)
        {
            return message.GetAllRecords<IS>("IdentityReliabilityCodeRepetitionsUsed", "GetIdentityReliabilityCode");
        }

        /// <summary>
        /// Get TribalCitizenship Records from PID
        /// </summary>
        public static IEnumerable GetTribalCitizenshipRecords(this PID message)
        {
            object[] result = message.GetRecords("TribalCitizenshipRepetitionsUsed", "GetTribalCitizenship");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TribalCitizenship Records from PID
        /// </summary>
        public static List<CWE> GetAllTribalCitizenshipRecords(this PID message)
        {
            return message.GetAllRecords<CWE>("TribalCitizenshipRepetitionsUsed", "GetTribalCitizenship");
        }

        /// <summary>
        /// Get PlacerSupplementalServiceInformation Records from AIS
        /// </summary>
        public static IEnumerable GetPlacerSupplementalServiceInformationRecords(this AIS message)
        {
            object[] result = message.GetRecords("PlacerSupplementalServiceInformationRepetitionsUsed", "GetPlacerSupplementalServiceInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerSupplementalServiceInformation Records from AIS
        /// </summary>
        public static List<CE> GetAllPlacerSupplementalServiceInformationRecords(this AIS message)
        {
            return message.GetAllRecords<CE>("PlacerSupplementalServiceInformationRepetitionsUsed", "GetPlacerSupplementalServiceInformation");
        }

        /// <summary>
        /// Get FillerSupplementalServiceInformation Records from AIS
        /// </summary>
        public static IEnumerable GetFillerSupplementalServiceInformationRecords(this AIS message)
        {
            object[] result = message.GetRecords("FillerSupplementalServiceInformationRepetitionsUsed", "GetFillerSupplementalServiceInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FillerSupplementalServiceInformation Records from AIS
        /// </summary>
        public static List<CE> GetAllFillerSupplementalServiceInformationRecords(this AIS message)
        {
            return message.GetAllRecords<CE>("FillerSupplementalServiceInformationRepetitionsUsed", "GetFillerSupplementalServiceInformation");
        }

        /// <summary>
        /// Get TestObservationsIncludedWithinAnOrderedTestBattery Records from OM5
        /// </summary>
        public static IEnumerable GetTestObservationsIncludedWithinAnOrderedTestBatteryRecords(this OM5 message)
        {
            object[] result = message.GetRecords("TestObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed", "GetTestObservationsIncludedWithinAnOrderedTestBattery");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TestObservationsIncludedWithinAnOrderedTestBattery Records from OM5
        /// </summary>
        public static List<CE> GetAllTestObservationsIncludedWithinAnOrderedTestBatteryRecords(this OM5 message)
        {
            return message.GetAllRecords<CE>("TestObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed", "GetTestObservationsIncludedWithinAnOrderedTestBattery");
        }

        /// <summary>
        /// Get AlternateStudyID Records from CM0
        /// </summary>
        public static IEnumerable GetAlternateStudyIDRecords(this CM0 message)
        {
            object[] result = message.GetRecords("AlternateStudyIDRepetitionsUsed", "GetAlternateStudyID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AlternateStudyID Records from CM0
        /// </summary>
        public static List<EI> GetAllAlternateStudyIDRecords(this CM0 message)
        {
            return message.GetAllRecords<EI>("AlternateStudyIDRepetitionsUsed", "GetAlternateStudyID");
        }

        /// <summary>
        /// Get ChairmanOfStudy Records from CM0
        /// </summary>
        public static IEnumerable GetChairmanOfStudyRecords(this CM0 message)
        {
            object[] result = message.GetRecords("ChairmanOfStudyRepetitionsUsed", "GetChairmanOfStudy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ChairmanOfStudy Records from CM0
        /// </summary>
        public static List<XCN> GetAllChairmanOfStudyRecords(this CM0 message)
        {
            return message.GetAllRecords<XCN>("ChairmanOfStudyRepetitionsUsed", "GetChairmanOfStudy");
        }

        /// <summary>
        /// Get ContactForStudy Records from CM0
        /// </summary>
        public static IEnumerable GetContactForStudyRecords(this CM0 message)
        {
            object[] result = message.GetRecords("ContactForStudyRepetitionsUsed", "GetContactForStudy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactForStudy Records from CM0
        /// </summary>
        public static List<XCN> GetAllContactForStudyRecords(this CM0 message)
        {
            return message.GetAllRecords<XCN>("ContactForStudyRepetitionsUsed", "GetContactForStudy");
        }

        /// <summary>
        /// Get ContactSAddress Records from CM0
        /// </summary>
        public static IEnumerable GetContactSAddressRecords(this CM0 message)
        {
            object[] result = message.GetRecords("ContactSAddressRepetitionsUsed", "GetContactSAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContactSAddress Records from CM0
        /// </summary>
        public static List<XAD> GetAllContactSAddressRecords(this CM0 message)
        {
            return message.GetAllRecords<XAD>("ContactSAddressRepetitionsUsed", "GetContactSAddress");
        }

        /// <summary>
        /// Get BCSpecialTesting Records from BPX
        /// </summary>
        public static IEnumerable GetBCSpecialTestingRecords(this BPX message)
        {
            object[] result = message.GetRecords("BCSpecialTestingRepetitionsUsed", "GetBCSpecialTesting");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BCSpecialTesting Records from BPX
        /// </summary>
        public static List<CNE> GetAllBCSpecialTestingRecords(this BPX message)
        {
            return message.GetAllRecords<CNE>("BCSpecialTestingRepetitionsUsed", "GetBCSpecialTesting");
        }

        /// <summary>
        /// Get AllergyReactionCode Records from AL1
        /// </summary>
        public static IEnumerable GetAllergyReactionCodeRecords(this AL1 message)
        {
            object[] result = message.GetRecords("AllergyReactionCodeRepetitionsUsed", "GetAllergyReactionCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AllergyReactionCode Records from AL1
        /// </summary>
        public static List<ST> GetAllAllergyReactionCodeRecords(this AL1 message)
        {
            return message.GetAllRecords<ST>("AllergyReactionCodeRepetitionsUsed", "GetAllergyReactionCode");
        }

        /// <summary>
        /// Get ProviderSPharmacyTreatmentInstructions Records from RXO
        /// </summary>
        public static IEnumerable GetProviderSPharmacyTreatmentInstructionsRecords(this RXO message)
        {
            object[] result = message.GetRecords("ProviderSPharmacyTreatmentInstructionsRepetitionsUsed", "GetProviderSPharmacyTreatmentInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderSPharmacyTreatmentInstructions Records from RXO
        /// </summary>
        public static List<CE> GetAllProviderSPharmacyTreatmentInstructionsRecords(this RXO message)
        {
            return message.GetAllRecords<CE>("ProviderSPharmacyTreatmentInstructionsRepetitionsUsed", "GetProviderSPharmacyTreatmentInstructions");
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
        /// Get OrderingProviderSDEANumber Records from RXO
        /// </summary>
        public static IEnumerable GetOrderingProviderSDEANumberRecords(this RXO message)
        {
            object[] result = message.GetRecords("OrderingProviderSDEANumberRepetitionsUsed", "GetOrderingProviderSDEANumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderingProviderSDEANumber Records from RXO
        /// </summary>
        public static List<XCN> GetAllOrderingProviderSDEANumberRecords(this RXO message)
        {
            return message.GetAllRecords<XCN>("OrderingProviderSDEANumberRepetitionsUsed", "GetOrderingProviderSDEANumber");
        }

        /// <summary>
        /// Get PharmacistTreatmentSupplierSVerifierID Records from RXO
        /// </summary>
        public static IEnumerable GetPharmacistTreatmentSupplierSVerifierIDRecords(this RXO message)
        {
            object[] result = message.GetRecords("PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed", "GetPharmacistTreatmentSupplierSVerifierID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacistTreatmentSupplierSVerifierID Records from RXO
        /// </summary>
        public static List<XCN> GetAllPharmacistTreatmentSupplierSVerifierIDRecords(this RXO message)
        {
            return message.GetAllRecords<XCN>("PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed", "GetPharmacistTreatmentSupplierSVerifierID");
        }

        /// <summary>
        /// Get Indication Records from RXO
        /// </summary>
        public static IEnumerable GetIndicationRecords(this RXO message)
        {
            object[] result = message.GetRecords("IndicationRepetitionsUsed", "GetIndication");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Indication Records from RXO
        /// </summary>
        public static List<CE> GetAllIndicationRecords(this RXO message)
        {
            return message.GetAllRecords<CE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Get SupplementaryCode Records from RXO
        /// </summary>
        public static IEnumerable GetSupplementaryCodeRecords(this RXO message)
        {
            object[] result = message.GetRecords("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SupplementaryCode Records from RXO
        /// </summary>
        public static List<CE> GetAllSupplementaryCodeRecords(this RXO message)
        {
            return message.GetAllRecords<CE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Get EventIdentifiersUsed Records from PEO
        /// </summary>
        public static IEnumerable GetEventIdentifiersUsedRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventIdentifiersUsedRepetitionsUsed", "GetEventIdentifiersUsed");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventIdentifiersUsed Records from PEO
        /// </summary>
        public static List<CE> GetAllEventIdentifiersUsedRecords(this PEO message)
        {
            return message.GetAllRecords<CE>("EventIdentifiersUsedRepetitionsUsed", "GetEventIdentifiersUsed");
        }

        /// <summary>
        /// Get EventSymptomDiagnosisCode Records from PEO
        /// </summary>
        public static IEnumerable GetEventSymptomDiagnosisCodeRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventSymptomDiagnosisCodeRepetitionsUsed", "GetEventSymptomDiagnosisCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventSymptomDiagnosisCode Records from PEO
        /// </summary>
        public static List<CE> GetAllEventSymptomDiagnosisCodeRecords(this PEO message)
        {
            return message.GetAllRecords<CE>("EventSymptomDiagnosisCodeRepetitionsUsed", "GetEventSymptomDiagnosisCode");
        }

        /// <summary>
        /// Get EventLocationOccurredAddress Records from PEO
        /// </summary>
        public static IEnumerable GetEventLocationOccurredAddressRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventLocationOccurredAddressRepetitionsUsed", "GetEventLocationOccurredAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventLocationOccurredAddress Records from PEO
        /// </summary>
        public static List<XAD> GetAllEventLocationOccurredAddressRecords(this PEO message)
        {
            return message.GetAllRecords<XAD>("EventLocationOccurredAddressRepetitionsUsed", "GetEventLocationOccurredAddress");
        }

        /// <summary>
        /// Get EventQualification Records from PEO
        /// </summary>
        public static IEnumerable GetEventQualificationRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventQualificationRepetitionsUsed", "GetEventQualification");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventQualification Records from PEO
        /// </summary>
        public static List<ID> GetAllEventQualificationRecords(this PEO message)
        {
            return message.GetAllRecords<ID>("EventQualificationRepetitionsUsed", "GetEventQualification");
        }

        /// <summary>
        /// Get EventOutcome Records from PEO
        /// </summary>
        public static IEnumerable GetEventOutcomeRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventOutcomeRepetitionsUsed", "GetEventOutcome");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventOutcome Records from PEO
        /// </summary>
        public static List<ID> GetAllEventOutcomeRecords(this PEO message)
        {
            return message.GetAllRecords<ID>("EventOutcomeRepetitionsUsed", "GetEventOutcome");
        }

        /// <summary>
        /// Get EventDescriptionFromOthers Records from PEO
        /// </summary>
        public static IEnumerable GetEventDescriptionFromOthersRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventDescriptionFromOthersRepetitionsUsed", "GetEventDescriptionFromOthers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventDescriptionFromOthers Records from PEO
        /// </summary>
        public static List<FT> GetAllEventDescriptionFromOthersRecords(this PEO message)
        {
            return message.GetAllRecords<FT>("EventDescriptionFromOthersRepetitionsUsed", "GetEventDescriptionFromOthers");
        }

        /// <summary>
        /// Get EventFromOriginalReporter Records from PEO
        /// </summary>
        public static IEnumerable GetEventFromOriginalReporterRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventFromOriginalReporterRepetitionsUsed", "GetEventFromOriginalReporter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventFromOriginalReporter Records from PEO
        /// </summary>
        public static List<FT> GetAllEventFromOriginalReporterRecords(this PEO message)
        {
            return message.GetAllRecords<FT>("EventFromOriginalReporterRepetitionsUsed", "GetEventFromOriginalReporter");
        }

        /// <summary>
        /// Get EventDescriptionFromPatient Records from PEO
        /// </summary>
        public static IEnumerable GetEventDescriptionFromPatientRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventDescriptionFromPatientRepetitionsUsed", "GetEventDescriptionFromPatient");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventDescriptionFromPatient Records from PEO
        /// </summary>
        public static List<FT> GetAllEventDescriptionFromPatientRecords(this PEO message)
        {
            return message.GetAllRecords<FT>("EventDescriptionFromPatientRepetitionsUsed", "GetEventDescriptionFromPatient");
        }

        /// <summary>
        /// Get EventDescriptionFromPractitioner Records from PEO
        /// </summary>
        public static IEnumerable GetEventDescriptionFromPractitionerRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventDescriptionFromPractitionerRepetitionsUsed", "GetEventDescriptionFromPractitioner");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventDescriptionFromPractitioner Records from PEO
        /// </summary>
        public static List<FT> GetAllEventDescriptionFromPractitionerRecords(this PEO message)
        {
            return message.GetAllRecords<FT>("EventDescriptionFromPractitionerRepetitionsUsed", "GetEventDescriptionFromPractitioner");
        }

        /// <summary>
        /// Get EventDescriptionFromAutopsy Records from PEO
        /// </summary>
        public static IEnumerable GetEventDescriptionFromAutopsyRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventDescriptionFromAutopsyRepetitionsUsed", "GetEventDescriptionFromAutopsy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventDescriptionFromAutopsy Records from PEO
        /// </summary>
        public static List<FT> GetAllEventDescriptionFromAutopsyRecords(this PEO message)
        {
            return message.GetAllRecords<FT>("EventDescriptionFromAutopsyRepetitionsUsed", "GetEventDescriptionFromAutopsy");
        }

        /// <summary>
        /// Get CauseOfDeath Records from PEO
        /// </summary>
        public static IEnumerable GetCauseOfDeathRecords(this PEO message)
        {
            object[] result = message.GetRecords("CauseOfDeathRepetitionsUsed", "GetCauseOfDeath");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CauseOfDeath Records from PEO
        /// </summary>
        public static List<CE> GetAllCauseOfDeathRecords(this PEO message)
        {
            return message.GetAllRecords<CE>("CauseOfDeathRepetitionsUsed", "GetCauseOfDeath");
        }

        /// <summary>
        /// Get PrimaryObserverName Records from PEO
        /// </summary>
        public static IEnumerable GetPrimaryObserverNameRecords(this PEO message)
        {
            object[] result = message.GetRecords("PrimaryObserverNameRepetitionsUsed", "GetPrimaryObserverName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryObserverName Records from PEO
        /// </summary>
        public static List<XPN> GetAllPrimaryObserverNameRecords(this PEO message)
        {
            return message.GetAllRecords<XPN>("PrimaryObserverNameRepetitionsUsed", "GetPrimaryObserverName");
        }

        /// <summary>
        /// Get PrimaryObserverAddress Records from PEO
        /// </summary>
        public static IEnumerable GetPrimaryObserverAddressRecords(this PEO message)
        {
            object[] result = message.GetRecords("PrimaryObserverAddressRepetitionsUsed", "GetPrimaryObserverAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryObserverAddress Records from PEO
        /// </summary>
        public static List<XAD> GetAllPrimaryObserverAddressRecords(this PEO message)
        {
            return message.GetAllRecords<XAD>("PrimaryObserverAddressRepetitionsUsed", "GetPrimaryObserverAddress");
        }

        /// <summary>
        /// Get PrimaryObserverTelephone Records from PEO
        /// </summary>
        public static IEnumerable GetPrimaryObserverTelephoneRecords(this PEO message)
        {
            object[] result = message.GetRecords("PrimaryObserverTelephoneRepetitionsUsed", "GetPrimaryObserverTelephone");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PrimaryObserverTelephone Records from PEO
        /// </summary>
        public static List<XTN> GetAllPrimaryObserverTelephoneRecords(this PEO message)
        {
            return message.GetAllRecords<XTN>("PrimaryObserverTelephoneRepetitionsUsed", "GetPrimaryObserverTelephone");
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
        #endregion
    }
}
