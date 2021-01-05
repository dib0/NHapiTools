using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Message;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V231.Segment
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class SegmentExtensions
    {
        #region Extension methods
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
        /// Add a new ResourceGroup to AIG
        /// </summary>
        public static CE AddResourceGroup(this AIG message)
        {
            return message.GetResourceGroup(message.ResourceGroupRepetitionsUsed);
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
        /// Add a new PersonnelResourceID to AIP
        /// </summary>
        public static XCN AddPersonnelResourceID(this AIP message)
        {
            return message.GetPersonnelResourceID(message.PersonnelResourceIDRepetitionsUsed);
        }

        /// <summary>
        /// Get AllergyReaction Records from AL1
        /// </summary>
        public static IEnumerable GetAllergyReactionRecords(this AL1 message)
        {
            object[] result = message.GetRecords("AllergyReactionRepetitionsUsed", "GetAllergyReaction");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AllergyReaction Records from AL1
        /// </summary>
        public static List<ST> GetAllAllergyReactionRecords(this AL1 message)
        {
            return message.GetAllRecords<ST>("AllergyReactionRepetitionsUsed", "GetAllergyReaction");
        }

        /// <summary>
        /// Add a new AllergyReaction to AL1
        /// </summary>
        public static ST AddAllergyReaction(this AL1 message)
        {
            return message.GetAllergyReaction(message.AllergyReactionRepetitionsUsed);
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
        /// Add a new TimeSelectionCriteria to APR
        /// </summary>
        public static SCV AddTimeSelectionCriteria(this APR message)
        {
            return message.GetTimeSelectionCriteria(message.TimeSelectionCriteriaRepetitionsUsed);
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
        /// Add a new ResourceSelectionCriteria to APR
        /// </summary>
        public static SCV AddResourceSelectionCriteria(this APR message)
        {
            return message.GetResourceSelectionCriteria(message.ResourceSelectionCriteriaRepetitionsUsed);
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
        /// Add a new LocationSelectionCriteria to APR
        /// </summary>
        public static SCV AddLocationSelectionCriteria(this APR message)
        {
            return message.GetLocationSelectionCriteria(message.LocationSelectionCriteriaRepetitionsUsed);
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
        /// Add a new FillerOverrideCriteria to APR
        /// </summary>
        public static SCV AddFillerOverrideCriteria(this APR message)
        {
            return message.GetFillerOverrideCriteria(message.FillerOverrideCriteriaRepetitionsUsed);
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
        /// Add a new RequestedStartDateTimeRange to ARQ
        /// </summary>
        public static DR AddRequestedStartDateTimeRange(this ARQ message)
        {
            return message.GetRequestedStartDateTimeRange(message.RequestedStartDateTimeRangeRepetitionsUsed);
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
        /// Add a new PlacerContactPerson to ARQ
        /// </summary>
        public static XCN AddPlacerContactPerson(this ARQ message)
        {
            return message.GetPlacerContactPerson(message.PlacerContactPersonRepetitionsUsed);
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
        /// Add a new PlacerContactPhoneNumber to ARQ
        /// </summary>
        public static XTN AddPlacerContactPhoneNumber(this ARQ message)
        {
            return message.GetPlacerContactPhoneNumber(message.PlacerContactPhoneNumberRepetitionsUsed);
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
        /// Add a new PlacerContactAddress to ARQ
        /// </summary>
        public static XAD AddPlacerContactAddress(this ARQ message)
        {
            return message.GetPlacerContactAddress(message.PlacerContactAddressRepetitionsUsed);
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
        /// Add a new EnteredByPerson to ARQ
        /// </summary>
        public static XCN AddEnteredByPerson(this ARQ message)
        {
            return message.GetEnteredByPerson(message.EnteredByPersonRepetitionsUsed);
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
        /// Add a new EnteredByPhoneNumber to ARQ
        /// </summary>
        public static XTN AddEnteredByPhoneNumber(this ARQ message)
        {
            return message.GetEnteredByPhoneNumber(message.EnteredByPhoneNumberRepetitionsUsed);
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
        /// Add a new BatchTotals to BTS
        /// </summary>
        public static NM AddBatchTotals(this BTS message)
        {
            return message.GetBatchTotals(message.BatchTotalsRepetitionsUsed);
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
        /// Add a new ChargeCodeAlias to CDM
        /// </summary>
        public static CE AddChargeCodeAlias(this CDM message)
        {
            return message.GetChargeCodeAlias(message.ChargeCodeAliasRepetitionsUsed);
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
        /// Add a new ExplodingCharges to CDM
        /// </summary>
        public static CE AddExplodingCharges(this CDM message)
        {
            return message.GetExplodingCharges(message.ExplodingChargesRepetitionsUsed);
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
        /// Add a new ProcedureCode to CDM
        /// </summary>
        public static CE AddProcedureCode(this CDM message)
        {
            return message.GetProcedureCode(message.ProcedureCodeRepetitionsUsed);
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
        /// Add a new InventoryNumber to CDM
        /// </summary>
        public static CE AddInventoryNumber(this CDM message)
        {
            return message.GetInventoryNumber(message.InventoryNumberRepetitionsUsed);
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
        public static List<CK> GetAllContractNumberRecords(this CDM message)
        {
            return message.GetAllRecords<CK>("ContractNumberRepetitionsUsed", "GetContractNumber");
        }

        /// <summary>
        /// Add a new ContractNumber to CDM
        /// </summary>
        public static CK AddContractNumber(this CDM message)
        {
            return message.GetContractNumber(message.ContractNumberRepetitionsUsed);
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
        /// Add a new ContractOrganization to CDM
        /// </summary>
        public static XON AddContractOrganization(this CDM message)
        {
            return message.GetContractOrganization(message.ContractOrganizationRepetitionsUsed);
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
        /// Add a new AlternateStudyID to CM0
        /// </summary>
        public static EI AddAlternateStudyID(this CM0 message)
        {
            return message.GetAlternateStudyID(message.AlternateStudyIDRepetitionsUsed);
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
        /// Add a new ChairmanOfStudy to CM0
        /// </summary>
        public static XCN AddChairmanOfStudy(this CM0 message)
        {
            return message.GetChairmanOfStudy(message.ChairmanOfStudyRepetitionsUsed);
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
        /// Add a new ContactForStudy to CM0
        /// </summary>
        public static XCN AddContactForStudy(this CM0 message)
        {
            return message.GetContactForStudy(message.ContactForStudyRepetitionsUsed);
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
        /// Add a new ContactSAddress to CM0
        /// </summary>
        public static XAD AddContactSAddress(this CM0 message)
        {
            return message.GetContactSAddress(message.ContactSAddressRepetitionsUsed);
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
        /// Add a new EventsScheduledThisTimePoint to CM2
        /// </summary>
        public static CE AddEventsScheduledThisTimePoint(this CM2 message)
        {
            return message.GetEventsScheduledThisTimePoint(message.EventsScheduledThisTimePointRepetitionsUsed);
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
        /// Add a new PersonPerformingStudyRegistration to CSR
        /// </summary>
        public static XCN AddPersonPerformingStudyRegistration(this CSR message)
        {
            return message.GetPersonPerformingStudyRegistration(message.PersonPerformingStudyRegistrationRepetitionsUsed);
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
        /// Add a new StudyAuthorizingProvider to CSR
        /// </summary>
        public static XCN AddStudyAuthorizingProvider(this CSR message)
        {
            return message.GetStudyAuthorizingProvider(message.StudyAuthorizingProviderRepetitionsUsed);
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
        /// Add a new StudyRandomizationDateTime to CSR
        /// </summary>
        public static TS AddStudyRandomizationDateTime(this CSR message)
        {
            return message.GetStudyRandomizationDateTime(message.StudyRandomizationDateTimeRepetitionsUsed);
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
        /// Add a new RandomizedStudyArm to CSR
        /// </summary>
        public static CE AddRandomizedStudyArm(this CSR message)
        {
            return message.GetRandomizedStudyArm(message.RandomizedStudyArmRepetitionsUsed);
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
        /// Add a new StratumForStudyRandomization to CSR
        /// </summary>
        public static CE AddStratumForStudyRandomization(this CSR message)
        {
            return message.GetStratumForStudyRandomization(message.StratumForStudyRandomizationRepetitionsUsed);
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
        /// Add a new StudyQualityControlCodes to CSS
        /// </summary>
        public static CE AddStudyQualityControlCodes(this CSS message)
        {
            return message.GetStudyQualityControlCodes(message.StudyQualityControlCodesRepetitionsUsed);
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
        /// Add a new ContactRole to CTD
        /// </summary>
        public static CE AddContactRole(this CTD message)
        {
            return message.GetContactRole(message.ContactRoleRepetitionsUsed);
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
        /// Add a new ContactName to CTD
        /// </summary>
        public static XPN AddContactName(this CTD message)
        {
            return message.GetContactName(message.ContactNameRepetitionsUsed);
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
        /// Add a new ContactAddress to CTD
        /// </summary>
        public static XAD AddContactAddress(this CTD message)
        {
            return message.GetContactAddress(message.ContactAddressRepetitionsUsed);
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
        /// Add a new ContactCommunicationInformation to CTD
        /// </summary>
        public static XTN AddContactCommunicationInformation(this CTD message)
        {
            return message.GetContactCommunicationInformation(message.ContactCommunicationInformationRepetitionsUsed);
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
        public static List<PI> GetAllContactIdentifiersRecords(this CTD message)
        {
            return message.GetAllRecords<PI>("ContactIdentifiersRepetitionsUsed", "GetContactIdentifiers");
        }

        /// <summary>
        /// Add a new ContactIdentifiers to CTD
        /// </summary>
        public static PI AddContactIdentifiers(this CTD message)
        {
            return message.GetContactIdentifiers(message.ContactIdentifiersRepetitionsUsed);
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
        /// Add a new DisabledPersonIdentifier to DB1
        /// </summary>
        public static CX AddDisabledPersonIdentifier(this DB1 message)
        {
            return message.GetDisabledPersonIdentifier(message.DisabledPersonIdentifierRepetitionsUsed);
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
        /// Add a new DiagnosingClinician to DG1
        /// </summary>
        public static XCN AddDiagnosingClinician(this DG1 message)
        {
            return message.GetDiagnosingClinician(message.DiagnosingClinicianRepetitionsUsed);
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
        /// Add a new InputParameterList to ERQ
        /// </summary>
        public static QIP AddInputParameterList(this ERQ message)
        {
            return message.GetInputParameterList(message.InputParameterListRepetitionsUsed);
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
        /// Add a new ErrorCodeAndLocation to ERR
        /// </summary>
        public static ELD AddErrorCodeAndLocation(this ERR message)
        {
            return message.GetErrorCodeAndLocation(message.ErrorCodeAndLocationRepetitionsUsed);
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
        /// Add a new OperatorID to EVN
        /// </summary>
        public static XCN AddOperatorID(this EVN message)
        {
            return message.GetOperatorID(message.OperatorIDRepetitionsUsed);
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
        /// Add a new FacilityAddress to FAC
        /// </summary>
        public static XAD AddFacilityAddress(this FAC message)
        {
            return message.GetFacilityAddress(message.FacilityAddressRepetitionsUsed);
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
        /// Add a new ContactPerson to FAC
        /// </summary>
        public static XCN AddContactPerson(this FAC message)
        {
            return message.GetContactPerson(message.ContactPersonRepetitionsUsed);
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
        /// Add a new ContactTitle to FAC
        /// </summary>
        public static ST AddContactTitle(this FAC message)
        {
            return message.GetContactTitle(message.ContactTitleRepetitionsUsed);
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
        /// Add a new ContactAddress to FAC
        /// </summary>
        public static XAD AddContactAddress(this FAC message)
        {
            return message.GetContactAddress(message.ContactAddressRepetitionsUsed);
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
        /// Add a new ContactTelecommunication to FAC
        /// </summary>
        public static XTN AddContactTelecommunication(this FAC message)
        {
            return message.GetContactTelecommunication(message.ContactTelecommunicationRepetitionsUsed);
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
        /// Add a new SignatureAuthority to FAC
        /// </summary>
        public static XCN AddSignatureAuthority(this FAC message)
        {
            return message.GetSignatureAuthority(message.SignatureAuthorityRepetitionsUsed);
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
        /// Add a new SignatureAuthorityAddress to FAC
        /// </summary>
        public static XAD AddSignatureAuthorityAddress(this FAC message)
        {
            return message.GetSignatureAuthorityAddress(message.SignatureAuthorityAddressRepetitionsUsed);
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
        /// Add a new DiagnosisCodeFT1 to FT1
        /// </summary>
        public static CE AddDiagnosisCodeFT1(this FT1 message)
        {
            return message.GetDiagnosisCodeFT1(message.DiagnosisCodeFT1RepetitionsUsed);
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
        /// Add a new PerformedByCode to FT1
        /// </summary>
        public static XCN AddPerformedByCode(this FT1 message)
        {
            return message.GetPerformedByCode(message.PerformedByCodeRepetitionsUsed);
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
        /// Add a new OrderedByCode to FT1
        /// </summary>
        public static XCN AddOrderedByCode(this FT1 message)
        {
            return message.GetOrderedByCode(message.OrderedByCodeRepetitionsUsed);
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
        /// Add a new EnteredByCode to FT1
        /// </summary>
        public static XCN AddEnteredByCode(this FT1 message)
        {
            return message.GetEnteredByCode(message.EnteredByCodeRepetitionsUsed);
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
        /// Add a new ProcedureCodeModifier to FT1
        /// </summary>
        public static CE AddProcedureCodeModifier(this FT1 message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
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
        /// Add a new GoalEvaluationComment to GOL
        /// </summary>
        public static ST AddGoalEvaluationComment(this GOL message)
        {
            return message.GetGoalEvaluationComment(message.GoalEvaluationCommentRepetitionsUsed);
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
        /// Add a new GoalTargetType to GOL
        /// </summary>
        public static CE AddGoalTargetType(this GOL message)
        {
            return message.GetGoalTargetType(message.GoalTargetTypeRepetitionsUsed);
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
        /// Add a new GoalTargetName to GOL
        /// </summary>
        public static XPN AddGoalTargetName(this GOL message)
        {
            return message.GetGoalTargetName(message.GoalTargetNameRepetitionsUsed);
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
        /// Add a new GuarantorNumber to GT1
        /// </summary>
        public static CX AddGuarantorNumber(this GT1 message)
        {
            return message.GetGuarantorNumber(message.GuarantorNumberRepetitionsUsed);
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
        /// Add a new GuarantorName to GT1
        /// </summary>
        public static XPN AddGuarantorName(this GT1 message)
        {
            return message.GetGuarantorName(message.GuarantorNameRepetitionsUsed);
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
        /// Add a new GuarantorSpouseName to GT1
        /// </summary>
        public static XPN AddGuarantorSpouseName(this GT1 message)
        {
            return message.GetGuarantorSpouseName(message.GuarantorSpouseNameRepetitionsUsed);
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
        /// Add a new GuarantorAddress to GT1
        /// </summary>
        public static XAD AddGuarantorAddress(this GT1 message)
        {
            return message.GetGuarantorAddress(message.GuarantorAddressRepetitionsUsed);
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
        /// Add a new GuarantorPhNumHome to GT1
        /// </summary>
        public static XTN AddGuarantorPhNumHome(this GT1 message)
        {
            return message.GetGuarantorPhNumHome(message.GuarantorPhNumHomeRepetitionsUsed);
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
        /// Add a new GuarantorPhNumBusiness to GT1
        /// </summary>
        public static XTN AddGuarantorPhNumBusiness(this GT1 message)
        {
            return message.GetGuarantorPhNumBusiness(message.GuarantorPhNumBusinessRepetitionsUsed);
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
        /// Add a new GuarantorEmployerName to GT1
        /// </summary>
        public static XPN AddGuarantorEmployerName(this GT1 message)
        {
            return message.GetGuarantorEmployerName(message.GuarantorEmployerNameRepetitionsUsed);
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
        /// Add a new GuarantorEmployerAddress to GT1
        /// </summary>
        public static XAD AddGuarantorEmployerAddress(this GT1 message)
        {
            return message.GetGuarantorEmployerAddress(message.GuarantorEmployerAddressRepetitionsUsed);
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
        /// Add a new GuarantorEmployerPhoneNumber to GT1
        /// </summary>
        public static XTN AddGuarantorEmployerPhoneNumber(this GT1 message)
        {
            return message.GetGuarantorEmployerPhoneNumber(message.GuarantorEmployerPhoneNumberRepetitionsUsed);
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
        /// Add a new GuarantorEmployeeIDNumber to GT1
        /// </summary>
        public static CX AddGuarantorEmployeeIDNumber(this GT1 message)
        {
            return message.GetGuarantorEmployeeIDNumber(message.GuarantorEmployeeIDNumberRepetitionsUsed);
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
        /// Add a new GuarantorOrganizationName to GT1
        /// </summary>
        public static XON AddGuarantorOrganizationName(this GT1 message)
        {
            return message.GetGuarantorOrganizationName(message.GuarantorOrganizationNameRepetitionsUsed);
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
        /// Add a new GuarantorEmployerIDNumber to GT1
        /// </summary>
        public static CX AddGuarantorEmployerIDNumber(this GT1 message)
        {
            return message.GetGuarantorEmployerIDNumber(message.GuarantorEmployerIDNumberRepetitionsUsed);
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
        /// Add a new AmbulatoryStatus to GT1
        /// </summary>
        public static IS AddAmbulatoryStatus(this GT1 message)
        {
            return message.GetAmbulatoryStatus(message.AmbulatoryStatusRepetitionsUsed);
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
        /// Add a new Citizenship to GT1
        /// </summary>
        public static CE AddCitizenship(this GT1 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
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
        /// Add a new MotherSMaidenName to GT1
        /// </summary>
        public static XPN AddMotherSMaidenName(this GT1 message)
        {
            return message.GetMotherSMaidenName(message.MotherSMaidenNameRepetitionsUsed);
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
        /// Add a new EthnicGroup to GT1
        /// </summary>
        public static CE AddEthnicGroup(this GT1 message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
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
        /// Add a new ContactPersonSName to GT1
        /// </summary>
        public static XPN AddContactPersonSName(this GT1 message)
        {
            return message.GetContactPersonSName(message.ContactPersonSNameRepetitionsUsed);
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
        /// Add a new ContactPersonSTelephoneNumber to GT1
        /// </summary>
        public static XTN AddContactPersonSTelephoneNumber(this GT1 message)
        {
            return message.GetContactPersonSTelephoneNumber(message.ContactPersonSTelephoneNumberRepetitionsUsed);
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
        /// Add a new GuarantorEmployerSOrganizationName to GT1
        /// </summary>
        public static XON AddGuarantorEmployerSOrganizationName(this GT1 message)
        {
            return message.GetGuarantorEmployerSOrganizationName(message.GuarantorEmployerSOrganizationNameRepetitionsUsed);
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
        /// Add a new GuarantorRace to GT1
        /// </summary>
        public static CE AddGuarantorRace(this GT1 message)
        {
            return message.GetGuarantorRace(message.GuarantorRaceRepetitionsUsed);
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
        /// Add a new InsuranceCompanyID to IN1
        /// </summary>
        public static CX AddInsuranceCompanyID(this IN1 message)
        {
            return message.GetInsuranceCompanyID(message.InsuranceCompanyIDRepetitionsUsed);
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
        /// Add a new InsuranceCompanyName to IN1
        /// </summary>
        public static XON AddInsuranceCompanyName(this IN1 message)
        {
            return message.GetInsuranceCompanyName(message.InsuranceCompanyNameRepetitionsUsed);
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
        /// Add a new InsuranceCompanyAddress to IN1
        /// </summary>
        public static XAD AddInsuranceCompanyAddress(this IN1 message)
        {
            return message.GetInsuranceCompanyAddress(message.InsuranceCompanyAddressRepetitionsUsed);
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
        /// Add a new InsuranceCoContactPerson to IN1
        /// </summary>
        public static XPN AddInsuranceCoContactPerson(this IN1 message)
        {
            return message.GetInsuranceCoContactPerson(message.InsuranceCoContactPersonRepetitionsUsed);
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
        /// Add a new InsuranceCoPhoneNumber to IN1
        /// </summary>
        public static XTN AddInsuranceCoPhoneNumber(this IN1 message)
        {
            return message.GetInsuranceCoPhoneNumber(message.InsuranceCoPhoneNumberRepetitionsUsed);
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
        /// Add a new GroupName to IN1
        /// </summary>
        public static XON AddGroupName(this IN1 message)
        {
            return message.GetGroupName(message.GroupNameRepetitionsUsed);
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
        /// Add a new InsuredSGroupEmpID to IN1
        /// </summary>
        public static CX AddInsuredSGroupEmpID(this IN1 message)
        {
            return message.GetInsuredSGroupEmpID(message.InsuredSGroupEmpIDRepetitionsUsed);
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
        /// Add a new InsuredSGroupEmpName to IN1
        /// </summary>
        public static XON AddInsuredSGroupEmpName(this IN1 message)
        {
            return message.GetInsuredSGroupEmpName(message.InsuredSGroupEmpNameRepetitionsUsed);
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
        /// Add a new NameOfInsured to IN1
        /// </summary>
        public static XPN AddNameOfInsured(this IN1 message)
        {
            return message.GetNameOfInsured(message.NameOfInsuredRepetitionsUsed);
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
        /// Add a new InsuredSAddress to IN1
        /// </summary>
        public static XAD AddInsuredSAddress(this IN1 message)
        {
            return message.GetInsuredSAddress(message.InsuredSAddressRepetitionsUsed);
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
        /// Add a new VerificationBy to IN1
        /// </summary>
        public static XCN AddVerificationBy(this IN1 message)
        {
            return message.GetVerificationBy(message.VerificationByRepetitionsUsed);
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
        /// Add a new InsuredSEmployerSAddress to IN1
        /// </summary>
        public static XAD AddInsuredSEmployerSAddress(this IN1 message)
        {
            return message.GetInsuredSEmployerSAddress(message.InsuredSEmployerSAddressRepetitionsUsed);
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
        /// Add a new InsuredSIDNumber to IN1
        /// </summary>
        public static CX AddInsuredSIDNumber(this IN1 message)
        {
            return message.GetInsuredSIDNumber(message.InsuredSIDNumberRepetitionsUsed);
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
        /// Add a new InsuredSEmployeeID to IN2
        /// </summary>
        public static CX AddInsuredSEmployeeID(this IN2 message)
        {
            return message.GetInsuredSEmployeeID(message.InsuredSEmployeeIDRepetitionsUsed);
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
        /// Add a new InsuredSEmployerSNameAndID to IN2
        /// </summary>
        public static XCN AddInsuredSEmployerSNameAndID(this IN2 message)
        {
            return message.GetInsuredSEmployerSNameAndID(message.InsuredSEmployerSNameAndIDRepetitionsUsed);
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
        /// Add a new MailClaimParty to IN2
        /// </summary>
        public static IS AddMailClaimParty(this IN2 message)
        {
            return message.GetMailClaimParty(message.MailClaimPartyRepetitionsUsed);
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
        /// Add a new MedicaidCaseName to IN2
        /// </summary>
        public static XPN AddMedicaidCaseName(this IN2 message)
        {
            return message.GetMedicaidCaseName(message.MedicaidCaseNameRepetitionsUsed);
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
        /// Add a new MilitarySponsorName to IN2
        /// </summary>
        public static XPN AddMilitarySponsorName(this IN2 message)
        {
            return message.GetMilitarySponsorName(message.MilitarySponsorNameRepetitionsUsed);
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
        /// Add a new SpecialCoverageApprovalName to IN2
        /// </summary>
        public static XPN AddSpecialCoverageApprovalName(this IN2 message)
        {
            return message.GetSpecialCoverageApprovalName(message.SpecialCoverageApprovalNameRepetitionsUsed);
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
        /// Add a new NonCoveredInsuranceCode to IN2
        /// </summary>
        public static IS AddNonCoveredInsuranceCode(this IN2 message)
        {
            return message.GetNonCoveredInsuranceCode(message.NonCoveredInsuranceCodeRepetitionsUsed);
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
        /// Add a new PayorID to IN2
        /// </summary>
        public static CX AddPayorID(this IN2 message)
        {
            return message.GetPayorID(message.PayorIDRepetitionsUsed);
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
        /// Add a new PayorSubscriberID to IN2
        /// </summary>
        public static CX AddPayorSubscriberID(this IN2 message)
        {
            return message.GetPayorSubscriberID(message.PayorSubscriberIDRepetitionsUsed);
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
        /// Add a new RoomCoverageTypeAmount to IN2
        /// </summary>
        public static RMC AddRoomCoverageTypeAmount(this IN2 message)
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
        public static List<PTA> GetAllPolicyTypeAmountRecords(this IN2 message)
        {
            return message.GetAllRecords<PTA>("PolicyTypeAmountRepetitionsUsed", "GetPolicyTypeAmount");
        }

        /// <summary>
        /// Add a new PolicyTypeAmount to IN2
        /// </summary>
        public static PTA AddPolicyTypeAmount(this IN2 message)
        {
            return message.GetPolicyTypeAmount(message.PolicyTypeAmountRepetitionsUsed);
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
        /// Add a new AmbulatoryStatus to IN2
        /// </summary>
        public static IS AddAmbulatoryStatus(this IN2 message)
        {
            return message.GetAmbulatoryStatus(message.AmbulatoryStatusRepetitionsUsed);
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
        /// Add a new Citizenship to IN2
        /// </summary>
        public static CE AddCitizenship(this IN2 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
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
        /// Add a new MotherSMaidenName to IN2
        /// </summary>
        public static XPN AddMotherSMaidenName(this IN2 message)
        {
            return message.GetMotherSMaidenName(message.MotherSMaidenNameRepetitionsUsed);
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
        /// Add a new EthnicGroup to IN2
        /// </summary>
        public static CE AddEthnicGroup(this IN2 message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
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
        /// Add a new MaritalStatus to IN2
        /// </summary>
        public static CE AddMaritalStatus(this IN2 message)
        {
            return message.GetMaritalStatus(message.MaritalStatusRepetitionsUsed);
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
        /// Add a new EmployerContactPersonName to IN2
        /// </summary>
        public static XPN AddEmployerContactPersonName(this IN2 message)
        {
            return message.GetEmployerContactPersonName(message.EmployerContactPersonNameRepetitionsUsed);
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
        /// Add a new EmployerContactPersonPhoneNumber to IN2
        /// </summary>
        public static XTN AddEmployerContactPersonPhoneNumber(this IN2 message)
        {
            return message.GetEmployerContactPersonPhoneNumber(message.EmployerContactPersonPhoneNumberRepetitionsUsed);
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
        /// Add a new InsuredSContactPersonSName to IN2
        /// </summary>
        public static XPN AddInsuredSContactPersonSName(this IN2 message)
        {
            return message.GetInsuredSContactPersonSName(message.InsuredSContactPersonSNameRepetitionsUsed);
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
        /// Add a new InsuredSContactPersonPhoneNumber to IN2
        /// </summary>
        public static XTN AddInsuredSContactPersonPhoneNumber(this IN2 message)
        {
            return message.GetInsuredSContactPersonPhoneNumber(message.InsuredSContactPersonPhoneNumberRepetitionsUsed);
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
        /// Add a new InsuredSContactPersonReason to IN2
        /// </summary>
        public static IS AddInsuredSContactPersonReason(this IN2 message)
        {
            return message.GetInsuredSContactPersonReason(message.InsuredSContactPersonReasonRepetitionsUsed);
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
        /// Add a new RelationshipToThePatientStopDate to IN2
        /// </summary>
        public static DT AddRelationshipToThePatientStopDate(this IN2 message)
        {
            return message.GetRelationshipToThePatientStopDate(message.RelationshipToThePatientStopDateRepetitionsUsed);
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
        /// Add a new InsuredSPhoneNumberHome to IN2
        /// </summary>
        public static XTN AddInsuredSPhoneNumberHome(this IN2 message)
        {
            return message.GetInsuredSPhoneNumberHome(message.InsuredSPhoneNumberHomeRepetitionsUsed);
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
        /// Add a new InsuredSEmployerPhoneNumber to IN2
        /// </summary>
        public static XTN AddInsuredSEmployerPhoneNumber(this IN2 message)
        {
            return message.GetInsuredSEmployerPhoneNumber(message.InsuredSEmployerPhoneNumberRepetitionsUsed);
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
        /// Add a new InsuredOrganizationNameAndID to IN2
        /// </summary>
        public static XON AddInsuredOrganizationNameAndID(this IN2 message)
        {
            return message.GetInsuredOrganizationNameAndID(message.InsuredOrganizationNameAndIDRepetitionsUsed);
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
        /// Add a new InsuredEmployerOrganizationNameAndID to IN2
        /// </summary>
        public static XON AddInsuredEmployerOrganizationNameAndID(this IN2 message)
        {
            return message.GetInsuredEmployerOrganizationNameAndID(message.InsuredEmployerOrganizationNameAndIDRepetitionsUsed);
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
        /// Add a new Race to IN2
        /// </summary>
        public static CE AddRace(this IN2 message)
        {
            return message.GetRace(message.RaceRepetitionsUsed);
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
        /// Add a new CertifiedBy to IN3
        /// </summary>
        public static XCN AddCertifiedBy(this IN3 message)
        {
            return message.GetCertifiedBy(message.CertifiedByRepetitionsUsed);
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
        /// Add a new Operator to IN3
        /// </summary>
        public static XCN AddOperator(this IN3 message)
        {
            return message.GetOperator(message.OperatorRepetitionsUsed);
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
        /// Add a new PhysicianReviewer to IN3
        /// </summary>
        public static XCN AddPhysicianReviewer(this IN3 message)
        {
            return message.GetPhysicianReviewer(message.PhysicianReviewerRepetitionsUsed);
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
        /// Add a new CertificationContactPhoneNumber to IN3
        /// </summary>
        public static XTN AddCertificationContactPhoneNumber(this IN3 message)
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
        public static List<XTN> GetAllCertificationAgencyPhoneNumberRecords(this IN3 message)
        {
            return message.GetAllRecords<XTN>("CertificationAgencyPhoneNumberRepetitionsUsed", "GetCertificationAgencyPhoneNumber");
        }

        /// <summary>
        /// Add a new CertificationAgencyPhoneNumber to IN3
        /// </summary>
        public static XTN AddCertificationAgencyPhoneNumber(this IN3 message)
        {
            return message.GetCertificationAgencyPhoneNumber(message.CertificationAgencyPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get PreCertificationReqWindow Records from IN3
        /// </summary>
        public static IEnumerable GetPreCertificationReqWindowRecords(this IN3 message)
        {
            object[] result = message.GetRecords("PreCertificationReqWindowRepetitionsUsed", "GetPreCertificationReqWindow");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PreCertificationReqWindow Records from IN3
        /// </summary>
        public static List<PCF> GetAllPreCertificationReqWindowRecords(this IN3 message)
        {
            return message.GetAllRecords<PCF>("PreCertificationReqWindowRepetitionsUsed", "GetPreCertificationReqWindow");
        }

        /// <summary>
        /// Add a new PreCertificationReqWindow to IN3
        /// </summary>
        public static PCF AddPreCertificationReqWindow(this IN3 message)
        {
            return message.GetPreCertificationReqWindow(message.PreCertificationReqWindowRepetitionsUsed);
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
        /// Add a new SecondOpinionDocumentationReceived to IN3
        /// </summary>
        public static IS AddSecondOpinionDocumentationReceived(this IN3 message)
        {
            return message.GetSecondOpinionDocumentationReceived(message.SecondOpinionDocumentationReceivedRepetitionsUsed);
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
        /// Add a new SecondOpinionPhysician to IN3
        /// </summary>
        public static XCN AddSecondOpinionPhysician(this IN3 message)
        {
            return message.GetSecondOpinionPhysician(message.SecondOpinionPhysicianRepetitionsUsed);
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
        /// Add a new AccommodationType to LCC
        /// </summary>
        public static CE AddAccommodationType(this LCC message)
        {
            return message.GetAccommodationType(message.AccommodationTypeRepetitionsUsed);
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
        /// Add a new ChargeCode to LCC
        /// </summary>
        public static CE AddChargeCode(this LCC message)
        {
            return message.GetChargeCode(message.ChargeCodeRepetitionsUsed);
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
        /// Add a new LocationService to LDP
        /// </summary>
        public static IS AddLocationService(this LDP message)
        {
            return message.GetLocationService(message.LocationServiceRepetitionsUsed);
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
        /// Add a new SpecialtyType to LDP
        /// </summary>
        public static CE AddSpecialtyType(this LDP message)
        {
            return message.GetSpecialtyType(message.SpecialtyTypeRepetitionsUsed);
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
        /// Add a new ValidPatientClasses to LDP
        /// </summary>
        public static IS AddValidPatientClasses(this LDP message)
        {
            return message.GetValidPatientClasses(message.ValidPatientClassesRepetitionsUsed);
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
        /// Add a new VisitingHours to LDP
        /// </summary>
        public static VH AddVisitingHours(this LDP message)
        {
            return message.GetVisitingHours(message.VisitingHoursRepetitionsUsed);
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
        /// Add a new LocationTypeLOC to LOC
        /// </summary>
        public static IS AddLocationTypeLOC(this LOC message)
        {
            return message.GetLocationTypeLOC(message.LocationTypeLOCRepetitionsUsed);
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
        /// Add a new OrganizationNameLOC to LOC
        /// </summary>
        public static XON AddOrganizationNameLOC(this LOC message)
        {
            return message.GetOrganizationNameLOC(message.OrganizationNameLOCRepetitionsUsed);
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
        /// Add a new LocationAddress to LOC
        /// </summary>
        public static XAD AddLocationAddress(this LOC message)
        {
            return message.GetLocationAddress(message.LocationAddressRepetitionsUsed);
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
        /// Add a new LocationPhone to LOC
        /// </summary>
        public static XTN AddLocationPhone(this LOC message)
        {
            return message.GetLocationPhone(message.LocationPhoneRepetitionsUsed);
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
        /// Add a new LicenseNumber to LOC
        /// </summary>
        public static CE AddLicenseNumber(this LOC message)
        {
            return message.GetLicenseNumber(message.LicenseNumberRepetitionsUsed);
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
        /// Add a new LocationEquipment to LOC
        /// </summary>
        public static IS AddLocationEquipment(this LOC message)
        {
            return message.GetLocationEquipment(message.LocationEquipmentRepetitionsUsed);
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
        /// Add a new OrganizationalLocationRelationshipValue to LRL
        /// </summary>
        public static XON AddOrganizationalLocationRelationshipValue(this LRL message)
        {
            return message.GetOrganizationalLocationRelationshipValue(message.OrganizationalLocationRelationshipValueRepetitionsUsed);
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
        public static List<CE> GetAllPrimaryKeyValueMFARecords(this MFA message)
        {
            return message.GetAllRecords<CE>("PrimaryKeyValueMFARepetitionsUsed", "GetPrimaryKeyValueMFA");
        }

        /// <summary>
        /// Add a new PrimaryKeyValueMFA to MFA
        /// </summary>
        public static CE AddPrimaryKeyValueMFA(this MFA message)
        {
            return message.GetPrimaryKeyValueMFA(message.PrimaryKeyValueMFARepetitionsUsed);
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
        /// Add a new PrimaryKeyValueTypeMFA to MFA
        /// </summary>
        public static ID AddPrimaryKeyValueTypeMFA(this MFA message)
        {
            return message.GetPrimaryKeyValueTypeMFA(message.PrimaryKeyValueTypeMFARepetitionsUsed);
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
        /// Add a new PrimaryKeyValueMFE to MFE
        /// </summary>
        public static Varies AddPrimaryKeyValueMFE(this MFE message)
        {
            return message.GetPrimaryKeyValueMFE(message.PrimaryKeyValueMFERepetitionsUsed);
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
        /// Add a new PrimaryKeyValueType to MFE
        /// </summary>
        public static ID AddPrimaryKeyValueType(this MFE message)
        {
            return message.GetPrimaryKeyValueType(message.PrimaryKeyValueTypeRepetitionsUsed);
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
        /// Add a new PriorPatientIdentifierList to MRG
        /// </summary>
        public static CX AddPriorPatientIdentifierList(this MRG message)
        {
            return message.GetPriorPatientIdentifierList(message.PriorPatientIdentifierListRepetitionsUsed);
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
        /// Add a new PriorAlternatePatientID to MRG
        /// </summary>
        public static CX AddPriorAlternatePatientID(this MRG message)
        {
            return message.GetPriorAlternatePatientID(message.PriorAlternatePatientIDRepetitionsUsed);
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
        /// Add a new PriorPatientName to MRG
        /// </summary>
        public static XPN AddPriorPatientName(this MRG message)
        {
            return message.GetPriorPatientName(message.PriorPatientNameRepetitionsUsed);
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
        /// Add a new CharacterSet to MSH
        /// </summary>
        public static ID AddCharacterSet(this MSH message)
        {
            return message.GetCharacterSet(message.CharacterSetRepetitionsUsed);
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
        /// Add a new Name to NK1
        /// </summary>
        public static XPN AddName(this NK1 message)
        {
            return message.GetName(message.NameRepetitionsUsed);
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
        /// Add a new Address to NK1
        /// </summary>
        public static XAD AddAddress(this NK1 message)
        {
            return message.GetAddress(message.AddressRepetitionsUsed);
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
        /// Add a new PhoneNumber to NK1
        /// </summary>
        public static XTN AddPhoneNumber(this NK1 message)
        {
            return message.GetPhoneNumber(message.PhoneNumberRepetitionsUsed);
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
        /// Add a new BusinessPhoneNumber to NK1
        /// </summary>
        public static XTN AddBusinessPhoneNumber(this NK1 message)
        {
            return message.GetBusinessPhoneNumber(message.BusinessPhoneNumberRepetitionsUsed);
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
        /// Add a new OrganizationNameNK1 to NK1
        /// </summary>
        public static XON AddOrganizationNameNK1(this NK1 message)
        {
            return message.GetOrganizationNameNK1(message.OrganizationNameNK1RepetitionsUsed);
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
        /// Add a new LivingDependency to NK1
        /// </summary>
        public static IS AddLivingDependency(this NK1 message)
        {
            return message.GetLivingDependency(message.LivingDependencyRepetitionsUsed);
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
        /// Add a new AmbulatoryStatus to NK1
        /// </summary>
        public static IS AddAmbulatoryStatus(this NK1 message)
        {
            return message.GetAmbulatoryStatus(message.AmbulatoryStatusRepetitionsUsed);
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
        /// Add a new Citizenship to NK1
        /// </summary>
        public static CE AddCitizenship(this NK1 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
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
        /// Add a new MotherSMaidenName to NK1
        /// </summary>
        public static XPN AddMotherSMaidenName(this NK1 message)
        {
            return message.GetMotherSMaidenName(message.MotherSMaidenNameRepetitionsUsed);
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
        /// Add a new EthnicGroup to NK1
        /// </summary>
        public static CE AddEthnicGroup(this NK1 message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
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
        /// Add a new ContactReason to NK1
        /// </summary>
        public static CE AddContactReason(this NK1 message)
        {
            return message.GetContactReason(message.ContactReasonRepetitionsUsed);
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
        /// Add a new ContactPersonSName to NK1
        /// </summary>
        public static XPN AddContactPersonSName(this NK1 message)
        {
            return message.GetContactPersonSName(message.ContactPersonSNameRepetitionsUsed);
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
        /// Add a new ContactPersonSTelephoneNumber to NK1
        /// </summary>
        public static XTN AddContactPersonSTelephoneNumber(this NK1 message)
        {
            return message.GetContactPersonSTelephoneNumber(message.ContactPersonSTelephoneNumberRepetitionsUsed);
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
        /// Add a new ContactPersonSAddress to NK1
        /// </summary>
        public static XAD AddContactPersonSAddress(this NK1 message)
        {
            return message.GetContactPersonSAddress(message.ContactPersonSAddressRepetitionsUsed);
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
        /// Add a new NextOfKinAssociatedPartySIdentifiers to NK1
        /// </summary>
        public static CX AddNextOfKinAssociatedPartySIdentifiers(this NK1 message)
        {
            return message.GetNextOfKinAssociatedPartySIdentifiers(message.NextOfKinAssociatedPartySIdentifiersRepetitionsUsed);
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
        /// Add a new Race to NK1
        /// </summary>
        public static CE AddRace(this NK1 message)
        {
            return message.GetRace(message.RaceRepetitionsUsed);
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
        public static List<XCN> GetAllCollectorIdentifierRecords(this OBR message)
        {
            return message.GetAllRecords<XCN>("CollectorIdentifierRepetitionsUsed", "GetCollectorIdentifier");
        }

        /// <summary>
        /// Add a new CollectorIdentifier to OBR
        /// </summary>
        public static XCN AddCollectorIdentifier(this OBR message)
        {
            return message.GetCollectorIdentifier(message.CollectorIdentifierRepetitionsUsed);
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
        /// Add a new OrderingProvider to OBR
        /// </summary>
        public static XCN AddOrderingProvider(this OBR message)
        {
            return message.GetOrderingProvider(message.OrderingProviderRepetitionsUsed);
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
        /// Add a new OrderCallbackPhoneNumber to OBR
        /// </summary>
        public static XTN AddOrderCallbackPhoneNumber(this OBR message)
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
        public static List<XCN> GetAllResultCopiesToRecords(this OBR message)
        {
            return message.GetAllRecords<XCN>("ResultCopiesToRepetitionsUsed", "GetResultCopiesTo");
        }

        /// <summary>
        /// Add a new ResultCopiesTo to OBR
        /// </summary>
        public static XCN AddResultCopiesTo(this OBR message)
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
        public static List<NDL> GetAllAssistantResultInterpreterRecords(this OBR message)
        {
            return message.GetAllRecords<NDL>("AssistantResultInterpreterRepetitionsUsed", "GetAssistantResultInterpreter");
        }

        /// <summary>
        /// Add a new AssistantResultInterpreter to OBR
        /// </summary>
        public static NDL AddAssistantResultInterpreter(this OBR message)
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
        public static List<NDL> GetAllTechnicianRecords(this OBR message)
        {
            return message.GetAllRecords<NDL>("TechnicianRepetitionsUsed", "GetTechnician");
        }

        /// <summary>
        /// Add a new Technician to OBR
        /// </summary>
        public static NDL AddTechnician(this OBR message)
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
        public static List<NDL> GetAllTranscriptionistRecords(this OBR message)
        {
            return message.GetAllRecords<NDL>("TranscriptionistRepetitionsUsed", "GetTranscriptionist");
        }

        /// <summary>
        /// Add a new Transcriptionist to OBR
        /// </summary>
        public static NDL AddTranscriptionist(this OBR message)
        {
            return message.GetTranscriptionist(message.TranscriptionistRepetitionsUsed);
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
        /// Add a new TransportLogisticsOfCollectedSample to OBR
        /// </summary>
        public static CE AddTransportLogisticsOfCollectedSample(this OBR message)
        {
            return message.GetTransportLogisticsOfCollectedSample(message.TransportLogisticsOfCollectedSampleRepetitionsUsed);
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
        /// Add a new CollectorSComment to OBR
        /// </summary>
        public static CE AddCollectorSComment(this OBR message)
        {
            return message.GetCollectorSComment(message.CollectorSCommentRepetitionsUsed);
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
        /// Add a new PlannedPatientTransportComment to OBR
        /// </summary>
        public static CE AddPlannedPatientTransportComment(this OBR message)
        {
            return message.GetPlannedPatientTransportComment(message.PlannedPatientTransportCommentRepetitionsUsed);
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
        /// Add a new ProcedureCodeModifier to OBR
        /// </summary>
        public static CE AddProcedureCodeModifier(this OBR message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
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
        /// Add a new ObservationValue to OBX
        /// </summary>
        public static Varies AddObservationValue(this OBX message)
        {
            return message.GetObservationValue(message.ObservationValueRepetitionsUsed);
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
        /// Get Probability Records from OBX
        /// </summary>
        public static IEnumerable GetProbabilityRecords(this OBX message)
        {
            object[] result = message.GetRecords("ProbabilityRepetitionsUsed", "GetProbability");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Probability Records from OBX
        /// </summary>
        public static List<NM> GetAllProbabilityRecords(this OBX message)
        {
            return message.GetAllRecords<NM>("ProbabilityRepetitionsUsed", "GetProbability");
        }

        /// <summary>
        /// Add a new Probability to OBX
        /// </summary>
        public static NM AddProbability(this OBX message)
        {
            return message.GetProbability(message.ProbabilityRepetitionsUsed);
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
        /// Add a new ResponsibleObserver to OBX
        /// </summary>
        public static XCN AddResponsibleObserver(this OBX message)
        {
            return message.GetResponsibleObserver(message.ResponsibleObserverRepetitionsUsed);
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
        /// Add a new ObservationMethod to OBX
        /// </summary>
        public static CE AddObservationMethod(this OBX message)
        {
            return message.GetObservationMethod(message.ObservationMethodRepetitionsUsed);
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
        public static List<CE> GetAllObservationProducingDepartmentSectionRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("ObservationProducingDepartmentSectionRepetitionsUsed", "GetObservationProducingDepartmentSection");
        }

        /// <summary>
        /// Add a new ObservationProducingDepartmentSection to OM1
        /// </summary>
        public static CE AddObservationProducingDepartmentSection(this OM1 message)
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
        public static List<XAD> GetAllAddressOfOutsideSiteSRecords(this OM1 message)
        {
            return message.GetAllRecords<XAD>("AddressOfOutsideSiteSRepetitionsUsed", "GetAddressOfOutsideSiteS");
        }

        /// <summary>
        /// Add a new AddressOfOutsideSiteS to OM1
        /// </summary>
        public static XAD AddAddressOfOutsideSiteS(this OM1 message)
        {
            return message.GetAddressOfOutsideSiteS(message.AddressOfOutsideSiteSRepetitionsUsed);
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
        /// Add a new RangeOfDecimalPrecision to OM2
        /// </summary>
        public static NM AddRangeOfDecimalPrecision(this OM2 message)
        {
            return message.GetRangeOfDecimalPrecision(message.RangeOfDecimalPrecisionRepetitionsUsed);
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
        /// Add a new DeltaCheckCriteria to OM2
        /// </summary>
        public static DLT AddDeltaCheckCriteria(this OM2 message)
        {
            return message.GetDeltaCheckCriteria(message.DeltaCheckCriteriaRepetitionsUsed);
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
        /// Add a new NormalTextCodesForCategoricalObservations to OM3
        /// </summary>
        public static CE AddNormalTextCodesForCategoricalObservations(this OM3 message)
        {
            return message.GetNormalTextCodesForCategoricalObservations(message.NormalTextCodesForCategoricalObservationsRepetitionsUsed);
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
        /// Add a new TestObservationsIncludedWithinAnOrderedTestBattery to OM5
        /// </summary>
        public static CE AddTestObservationsIncludedWithinAnOrderedTestBattery(this OM5 message)
        {
            return message.GetTestObservationsIncludedWithinAnOrderedTestBattery(message.TestObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed);
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
        /// Add a new EnteredBy to ORC
        /// </summary>
        public static XCN AddEnteredBy(this ORC message)
        {
            return message.GetEnteredBy(message.EnteredByRepetitionsUsed);
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
        /// Add a new VerifiedBy to ORC
        /// </summary>
        public static XCN AddVerifiedBy(this ORC message)
        {
            return message.GetVerifiedBy(message.VerifiedByRepetitionsUsed);
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
        /// Add a new OrderingProvider to ORC
        /// </summary>
        public static XCN AddOrderingProvider(this ORC message)
        {
            return message.GetOrderingProvider(message.OrderingProviderRepetitionsUsed);
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
        /// Add a new CallBackPhoneNumber to ORC
        /// </summary>
        public static XTN AddCallBackPhoneNumber(this ORC message)
        {
            return message.GetCallBackPhoneNumber(message.CallBackPhoneNumberRepetitionsUsed);
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
        /// Add a new ActionBy to ORC
        /// </summary>
        public static XCN AddActionBy(this ORC message)
        {
            return message.GetActionBy(message.ActionByRepetitionsUsed);
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
        /// Add a new OrderingFacilityName to ORC
        /// </summary>
        public static XON AddOrderingFacilityName(this ORC message)
        {
            return message.GetOrderingFacilityName(message.OrderingFacilityNameRepetitionsUsed);
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
        /// Add a new OrderingFacilityAddress to ORC
        /// </summary>
        public static XAD AddOrderingFacilityAddress(this ORC message)
        {
            return message.GetOrderingFacilityAddress(message.OrderingFacilityAddressRepetitionsUsed);
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
        /// Add a new OrderingFacilityPhoneNumber to ORC
        /// </summary>
        public static XTN AddOrderingFacilityPhoneNumber(this ORC message)
        {
            return message.GetOrderingFacilityPhoneNumber(message.OrderingFacilityPhoneNumberRepetitionsUsed);
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
        /// Add a new OrderingProviderAddress to ORC
        /// </summary>
        public static XAD AddOrderingProviderAddress(this ORC message)
        {
            return message.GetOrderingProviderAddress(message.OrderingProviderAddressRepetitionsUsed);
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
        /// Add a new ProductSerialLotNumber to PCR
        /// </summary>
        public static ST AddProductSerialLotNumber(this PCR message)
        {
            return message.GetProductSerialLotNumber(message.ProductSerialLotNumberRepetitionsUsed);
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
        /// Add a new ActionTakenInResponseToTheEvent to PCR
        /// </summary>
        public static ID AddActionTakenInResponseToTheEvent(this PCR message)
        {
            return message.GetActionTakenInResponseToTheEvent(message.ActionTakenInResponseToTheEventRepetitionsUsed);
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
        /// Add a new EventCausalityObservations to PCR
        /// </summary>
        public static ID AddEventCausalityObservations(this PCR message)
        {
            return message.GetEventCausalityObservations(message.EventCausalityObservationsRepetitionsUsed);
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
        /// Add a new IndirectExposureMechanism to PCR
        /// </summary>
        public static ID AddIndirectExposureMechanism(this PCR message)
        {
            return message.GetIndirectExposureMechanism(message.IndirectExposureMechanismRepetitionsUsed);
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
        /// Add a new LivingDependency to PD1
        /// </summary>
        public static IS AddLivingDependency(this PD1 message)
        {
            return message.GetLivingDependency(message.LivingDependencyRepetitionsUsed);
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
        /// Add a new PatientPrimaryFacility to PD1
        /// </summary>
        public static XON AddPatientPrimaryFacility(this PD1 message)
        {
            return message.GetPatientPrimaryFacility(message.PatientPrimaryFacilityRepetitionsUsed);
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
        /// Add a new PatientPrimaryCareProviderNameIDNo to PD1
        /// </summary>
        public static XCN AddPatientPrimaryCareProviderNameIDNo(this PD1 message)
        {
            return message.GetPatientPrimaryCareProviderNameIDNo(message.PatientPrimaryCareProviderNameIDNoRepetitionsUsed);
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
        /// Add a new DuplicatePatient to PD1
        /// </summary>
        public static CX AddDuplicatePatient(this PD1 message)
        {
            return message.GetDuplicatePatient(message.DuplicatePatientRepetitionsUsed);
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
        /// Add a new ManufacturerDistributor to PDC
        /// </summary>
        public static XON AddManufacturerDistributor(this PDC message)
        {
            return message.GetManufacturerDistributor(message.ManufacturerDistributorRepetitionsUsed);
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
        /// Add a new ModelIdentifier to PDC
        /// </summary>
        public static ST AddModelIdentifier(this PDC message)
        {
            return message.GetModelIdentifier(message.ModelIdentifierRepetitionsUsed);
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
        /// Add a new OtherIdentifier to PDC
        /// </summary>
        public static ST AddOtherIdentifier(this PDC message)
        {
            return message.GetOtherIdentifier(message.OtherIdentifierRepetitionsUsed);
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
        /// Add a new EventIdentifiersUsed to PEO
        /// </summary>
        public static CE AddEventIdentifiersUsed(this PEO message)
        {
            return message.GetEventIdentifiersUsed(message.EventIdentifiersUsedRepetitionsUsed);
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
        /// Add a new EventSymptomDiagnosisCode to PEO
        /// </summary>
        public static CE AddEventSymptomDiagnosisCode(this PEO message)
        {
            return message.GetEventSymptomDiagnosisCode(message.EventSymptomDiagnosisCodeRepetitionsUsed);
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
        /// Add a new EventLocationOccurredAddress to PEO
        /// </summary>
        public static XAD AddEventLocationOccurredAddress(this PEO message)
        {
            return message.GetEventLocationOccurredAddress(message.EventLocationOccurredAddressRepetitionsUsed);
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
        /// Add a new EventQualification to PEO
        /// </summary>
        public static ID AddEventQualification(this PEO message)
        {
            return message.GetEventQualification(message.EventQualificationRepetitionsUsed);
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
        /// Add a new EventOutcome to PEO
        /// </summary>
        public static ID AddEventOutcome(this PEO message)
        {
            return message.GetEventOutcome(message.EventOutcomeRepetitionsUsed);
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
        /// Add a new EventDescriptionFromOthers to PEO
        /// </summary>
        public static FT AddEventDescriptionFromOthers(this PEO message)
        {
            return message.GetEventDescriptionFromOthers(message.EventDescriptionFromOthersRepetitionsUsed);
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
        /// Add a new EventFromOriginalReporter to PEO
        /// </summary>
        public static FT AddEventFromOriginalReporter(this PEO message)
        {
            return message.GetEventFromOriginalReporter(message.EventFromOriginalReporterRepetitionsUsed);
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
        /// Add a new EventDescriptionFromPatient to PEO
        /// </summary>
        public static FT AddEventDescriptionFromPatient(this PEO message)
        {
            return message.GetEventDescriptionFromPatient(message.EventDescriptionFromPatientRepetitionsUsed);
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
        /// Add a new EventDescriptionFromPractitioner to PEO
        /// </summary>
        public static FT AddEventDescriptionFromPractitioner(this PEO message)
        {
            return message.GetEventDescriptionFromPractitioner(message.EventDescriptionFromPractitionerRepetitionsUsed);
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
        /// Add a new EventDescriptionFromAutopsy to PEO
        /// </summary>
        public static FT AddEventDescriptionFromAutopsy(this PEO message)
        {
            return message.GetEventDescriptionFromAutopsy(message.EventDescriptionFromAutopsyRepetitionsUsed);
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
        /// Add a new CauseOfDeath to PEO
        /// </summary>
        public static CE AddCauseOfDeath(this PEO message)
        {
            return message.GetCauseOfDeath(message.CauseOfDeathRepetitionsUsed);
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
        /// Add a new PrimaryObserverName to PEO
        /// </summary>
        public static XPN AddPrimaryObserverName(this PEO message)
        {
            return message.GetPrimaryObserverName(message.PrimaryObserverNameRepetitionsUsed);
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
        /// Add a new PrimaryObserverAddress to PEO
        /// </summary>
        public static XAD AddPrimaryObserverAddress(this PEO message)
        {
            return message.GetPrimaryObserverAddress(message.PrimaryObserverAddressRepetitionsUsed);
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
        /// Add a new PrimaryObserverTelephone to PEO
        /// </summary>
        public static XTN AddPrimaryObserverTelephone(this PEO message)
        {
            return message.GetPrimaryObserverTelephone(message.PrimaryObserverTelephoneRepetitionsUsed);
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
        /// Add a new SenderOrganizationName to PES
        /// </summary>
        public static XON AddSenderOrganizationName(this PES message)
        {
            return message.GetSenderOrganizationName(message.SenderOrganizationNameRepetitionsUsed);
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
        /// Add a new SenderIndividualName to PES
        /// </summary>
        public static XCN AddSenderIndividualName(this PES message)
        {
            return message.GetSenderIndividualName(message.SenderIndividualNameRepetitionsUsed);
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
        /// Add a new SenderAddress to PES
        /// </summary>
        public static XAD AddSenderAddress(this PES message)
        {
            return message.GetSenderAddress(message.SenderAddressRepetitionsUsed);
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
        /// Add a new SenderTelephone to PES
        /// </summary>
        public static XTN AddSenderTelephone(this PES message)
        {
            return message.GetSenderTelephone(message.SenderTelephoneRepetitionsUsed);
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
        /// Add a new SenderEventDescription to PES
        /// </summary>
        public static FT AddSenderEventDescription(this PES message)
        {
            return message.GetSenderEventDescription(message.SenderEventDescriptionRepetitionsUsed);
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
        /// Add a new EventReportTimingType to PES
        /// </summary>
        public static ID AddEventReportTimingType(this PES message)
        {
            return message.GetEventReportTimingType(message.EventReportTimingTypeRepetitionsUsed);
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
        /// Add a new EventReportedTo to PES
        /// </summary>
        public static ID AddEventReportedTo(this PES message)
        {
            return message.GetEventReportedTo(message.EventReportedToRepetitionsUsed);
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
        /// Add a new PatientIdentifierList to PID
        /// </summary>
        public static CX AddPatientIdentifierList(this PID message)
        {
            return message.GetPatientIdentifierList(message.PatientIdentifierListRepetitionsUsed);
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
        /// Add a new AlternatePatientIDPID to PID
        /// </summary>
        public static CX AddAlternatePatientIDPID(this PID message)
        {
            return message.GetAlternatePatientIDPID(message.AlternatePatientIDPIDRepetitionsUsed);
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
        /// Add a new PatientName to PID
        /// </summary>
        public static XPN AddPatientName(this PID message)
        {
            return message.GetPatientName(message.PatientNameRepetitionsUsed);
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
        /// Add a new MotherSMaidenName to PID
        /// </summary>
        public static XPN AddMotherSMaidenName(this PID message)
        {
            return message.GetMotherSMaidenName(message.MotherSMaidenNameRepetitionsUsed);
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
        /// Add a new PatientAlias to PID
        /// </summary>
        public static XPN AddPatientAlias(this PID message)
        {
            return message.GetPatientAlias(message.PatientAliasRepetitionsUsed);
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
        /// Add a new Race to PID
        /// </summary>
        public static CE AddRace(this PID message)
        {
            return message.GetRace(message.RaceRepetitionsUsed);
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
        /// Add a new PatientAddress to PID
        /// </summary>
        public static XAD AddPatientAddress(this PID message)
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
        public static List<XTN> GetAllPhoneNumberHomeRecords(this PID message)
        {
            return message.GetAllRecords<XTN>("PhoneNumberHomeRepetitionsUsed", "GetPhoneNumberHome");
        }

        /// <summary>
        /// Add a new PhoneNumberHome to PID
        /// </summary>
        public static XTN AddPhoneNumberHome(this PID message)
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
        public static List<XTN> GetAllPhoneNumberBusinessRecords(this PID message)
        {
            return message.GetAllRecords<XTN>("PhoneNumberBusinessRepetitionsUsed", "GetPhoneNumberBusiness");
        }

        /// <summary>
        /// Add a new PhoneNumberBusiness to PID
        /// </summary>
        public static XTN AddPhoneNumberBusiness(this PID message)
        {
            return message.GetPhoneNumberBusiness(message.PhoneNumberBusinessRepetitionsUsed);
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
        /// Add a new MotherSIdentifier to PID
        /// </summary>
        public static CX AddMotherSIdentifier(this PID message)
        {
            return message.GetMotherSIdentifier(message.MotherSIdentifierRepetitionsUsed);
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
        /// Add a new EthnicGroup to PID
        /// </summary>
        public static CE AddEthnicGroup(this PID message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
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
        /// Add a new Citizenship to PID
        /// </summary>
        public static CE AddCitizenship(this PID message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
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
        /// Add a new Anesthesiologist to PR1
        /// </summary>
        public static XCN AddAnesthesiologist(this PR1 message)
        {
            return message.GetAnesthesiologist(message.AnesthesiologistRepetitionsUsed);
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
        /// Add a new Surgeon to PR1
        /// </summary>
        public static XCN AddSurgeon(this PR1 message)
        {
            return message.GetSurgeon(message.SurgeonRepetitionsUsed);
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
        /// Add a new ProcedurePractitioner to PR1
        /// </summary>
        public static XCN AddProcedurePractitioner(this PR1 message)
        {
            return message.GetProcedurePractitioner(message.ProcedurePractitionerRepetitionsUsed);
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
        /// Add a new ProcedureCodeModifier to PR1
        /// </summary>
        public static CE AddProcedureCodeModifier(this PR1 message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
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
        public static List<IS> GetAllPractitionerCategoryRecords(this PRA message)
        {
            return message.GetAllRecords<IS>("PractitionerCategoryRepetitionsUsed", "GetPractitionerCategory");
        }

        /// <summary>
        /// Add a new PractitionerCategory to PRA
        /// </summary>
        public static IS AddPractitionerCategory(this PRA message)
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
        public static List<SPD> GetAllSpecialtyRecords(this PRA message)
        {
            return message.GetAllRecords<SPD>("SpecialtyRepetitionsUsed", "GetSpecialty");
        }

        /// <summary>
        /// Add a new Specialty to PRA
        /// </summary>
        public static SPD AddSpecialty(this PRA message)
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
        public static List<PLN> GetAllPractitionerIDNumbersRecords(this PRA message)
        {
            return message.GetAllRecords<PLN>("PractitionerIDNumbersRepetitionsUsed", "GetPractitionerIDNumbers");
        }

        /// <summary>
        /// Add a new PractitionerIDNumbers to PRA
        /// </summary>
        public static PLN AddPractitionerIDNumbers(this PRA message)
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
        public static List<PIP> GetAllPrivilegesRecords(this PRA message)
        {
            return message.GetAllRecords<PIP>("PrivilegesRepetitionsUsed", "GetPrivileges");
        }

        /// <summary>
        /// Add a new Privileges to PRA
        /// </summary>
        public static PIP AddPrivileges(this PRA message)
        {
            return message.GetPrivileges(message.PrivilegesRepetitionsUsed);
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
        /// Add a new ProblemManagementDiscipline to PRB
        /// </summary>
        public static CE AddProblemManagementDiscipline(this PRB message)
        {
            return message.GetProblemManagementDiscipline(message.ProblemManagementDisciplineRepetitionsUsed);
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
        /// Add a new FacilityIDPRC to PRC
        /// </summary>
        public static CE AddFacilityIDPRC(this PRC message)
        {
            return message.GetFacilityIDPRC(message.FacilityIDPRCRepetitionsUsed);
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
        /// Add a new Department to PRC
        /// </summary>
        public static CE AddDepartment(this PRC message)
        {
            return message.GetDepartment(message.DepartmentRepetitionsUsed);
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
        /// Add a new ValidPatientClasses to PRC
        /// </summary>
        public static IS AddValidPatientClasses(this PRC message)
        {
            return message.GetValidPatientClasses(message.ValidPatientClassesRepetitionsUsed);
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
        /// Add a new Price to PRC
        /// </summary>
        public static CP AddPrice(this PRC message)
        {
            return message.GetPrice(message.PriceRepetitionsUsed);
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
        /// Add a new Formula to PRC
        /// </summary>
        public static ST AddFormula(this PRC message)
        {
            return message.GetFormula(message.FormulaRepetitionsUsed);
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
        /// Add a new BillingCategory to PRC
        /// </summary>
        public static CE AddBillingCategory(this PRC message)
        {
            return message.GetBillingCategory(message.BillingCategoryRepetitionsUsed);
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
        /// Add a new ProviderRole to PRD
        /// </summary>
        public static CE AddProviderRole(this PRD message)
        {
            return message.GetProviderRole(message.ProviderRoleRepetitionsUsed);
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
        /// Add a new ProviderName to PRD
        /// </summary>
        public static XPN AddProviderName(this PRD message)
        {
            return message.GetProviderName(message.ProviderNameRepetitionsUsed);
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
        /// Add a new ProviderAddress to PRD
        /// </summary>
        public static XAD AddProviderAddress(this PRD message)
        {
            return message.GetProviderAddress(message.ProviderAddressRepetitionsUsed);
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
        /// Add a new ProviderCommunicationInformation to PRD
        /// </summary>
        public static XTN AddProviderCommunicationInformation(this PRD message)
        {
            return message.GetProviderCommunicationInformation(message.ProviderCommunicationInformationRepetitionsUsed);
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
        public static List<PI> GetAllProviderIdentifiersRecords(this PRD message)
        {
            return message.GetAllRecords<PI>("ProviderIdentifiersRepetitionsUsed", "GetProviderIdentifiers");
        }

        /// <summary>
        /// Add a new ProviderIdentifiers to PRD
        /// </summary>
        public static PI AddProviderIdentifiers(this PRD message)
        {
            return message.GetProviderIdentifiers(message.ProviderIdentifiersRepetitionsUsed);
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
        /// Add a new NumberOfProductExperienceReportsFiledByFacility to PSH
        /// </summary>
        public static NM AddNumberOfProductExperienceReportsFiledByFacility(this PSH message)
        {
            return message.GetNumberOfProductExperienceReportsFiledByFacility(message.NumberOfProductExperienceReportsFiledByFacilityRepetitionsUsed);
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
        /// Add a new NumberOfProductExperienceReportsFiledByDistributor to PSH
        /// </summary>
        public static NM AddNumberOfProductExperienceReportsFiledByDistributor(this PSH message)
        {
            return message.GetNumberOfProductExperienceReportsFiledByDistributor(message.NumberOfProductExperienceReportsFiledByDistributorRepetitionsUsed);
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
        /// Add a new AttendingDoctor to PV1
        /// </summary>
        public static XCN AddAttendingDoctor(this PV1 message)
        {
            return message.GetAttendingDoctor(message.AttendingDoctorRepetitionsUsed);
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
        /// Add a new ReferringDoctor to PV1
        /// </summary>
        public static XCN AddReferringDoctor(this PV1 message)
        {
            return message.GetReferringDoctor(message.ReferringDoctorRepetitionsUsed);
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
        /// Add a new ConsultingDoctor to PV1
        /// </summary>
        public static XCN AddConsultingDoctor(this PV1 message)
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
        public static List<IS> GetAllAmbulatoryStatusRecords(this PV1 message)
        {
            return message.GetAllRecords<IS>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Add a new AmbulatoryStatus to PV1
        /// </summary>
        public static IS AddAmbulatoryStatus(this PV1 message)
        {
            return message.GetAmbulatoryStatus(message.AmbulatoryStatusRepetitionsUsed);
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
        /// Add a new AdmittingDoctor to PV1
        /// </summary>
        public static XCN AddAdmittingDoctor(this PV1 message)
        {
            return message.GetAdmittingDoctor(message.AdmittingDoctorRepetitionsUsed);
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
        /// Add a new FinancialClass to PV1
        /// </summary>
        public static FC AddFinancialClass(this PV1 message)
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
        public static List<IS> GetAllContractCodeRecords(this PV1 message)
        {
            return message.GetAllRecords<IS>("ContractCodeRepetitionsUsed", "GetContractCode");
        }

        /// <summary>
        /// Add a new ContractCode to PV1
        /// </summary>
        public static IS AddContractCode(this PV1 message)
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
        /// Add a new OtherHealthcareProvider to PV1
        /// </summary>
        public static XCN AddOtherHealthcareProvider(this PV1 message)
        {
            return message.GetOtherHealthcareProvider(message.OtherHealthcareProviderRepetitionsUsed);
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
        /// Add a new ReferralSourceCode to PV2
        /// </summary>
        public static XCN AddReferralSourceCode(this PV2 message)
        {
            return message.GetReferralSourceCode(message.ReferralSourceCodeRepetitionsUsed);
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
        /// Add a new ClinicOrganizationName to PV2
        /// </summary>
        public static XON AddClinicOrganizationName(this PV2 message)
        {
            return message.GetClinicOrganizationName(message.ClinicOrganizationNameRepetitionsUsed);
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
        /// Add a new WhoSubjectFilter to QRD
        /// </summary>
        public static XCN AddWhoSubjectFilter(this QRD message)
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
        public static List<CE> GetAllWhatSubjectFilterRecords(this QRD message)
        {
            return message.GetAllRecords<CE>("WhatSubjectFilterRepetitionsUsed", "GetWhatSubjectFilter");
        }

        /// <summary>
        /// Add a new WhatSubjectFilter to QRD
        /// </summary>
        public static CE AddWhatSubjectFilter(this QRD message)
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
        public static List<CE> GetAllWhatDepartmentDataCodeRecords(this QRD message)
        {
            return message.GetAllRecords<CE>("WhatDepartmentDataCodeRepetitionsUsed", "GetWhatDepartmentDataCode");
        }

        /// <summary>
        /// Add a new WhatDepartmentDataCode to QRD
        /// </summary>
        public static CE AddWhatDepartmentDataCode(this QRD message)
        {
            return message.GetWhatDepartmentDataCode(message.WhatDepartmentDataCodeRepetitionsUsed);
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
        /// Add a new WhatDataCodeValueQual to QRD
        /// </summary>
        public static VR AddWhatDataCodeValueQual(this QRD message)
        {
            return message.GetWhatDataCodeValueQual(message.WhatDataCodeValueQualRepetitionsUsed);
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
        /// Add a new ColumnDescription to RDF
        /// </summary>
        public static RCD AddColumnDescription(this RDF message)
        {
            return message.GetColumnDescription(message.ColumnDescriptionRepetitionsUsed);
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
        /// Add a new ReferralDisposition to RF1
        /// </summary>
        public static CE AddReferralDisposition(this RF1 message)
        {
            return message.GetReferralDisposition(message.ReferralDispositionRepetitionsUsed);
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
        /// Add a new ReferralReason to RF1
        /// </summary>
        public static CE AddReferralReason(this RF1 message)
        {
            return message.GetReferralReason(message.ReferralReasonRepetitionsUsed);
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
        /// Add a new ExternalReferralIdentifier to RF1
        /// </summary>
        public static EI AddExternalReferralIdentifier(this RF1 message)
        {
            return message.GetExternalReferralIdentifier(message.ExternalReferralIdentifierRepetitionsUsed);
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
        /// Add a new RolePerson to ROL
        /// </summary>
        public static XCN AddRolePerson(this ROL message)
        {
            return message.GetRolePerson(message.RolePersonRepetitionsUsed);
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
        /// Add a new AdministrationNotes to RXA
        /// </summary>
        public static CE AddAdministrationNotes(this RXA message)
        {
            return message.GetAdministrationNotes(message.AdministrationNotesRepetitionsUsed);
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
        /// Add a new AdministeringProvider to RXA
        /// </summary>
        public static XCN AddAdministeringProvider(this RXA message)
        {
            return message.GetAdministeringProvider(message.AdministeringProviderRepetitionsUsed);
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
        /// Add a new SubstanceLotNumber to RXA
        /// </summary>
        public static ST AddSubstanceLotNumber(this RXA message)
        {
            return message.GetSubstanceLotNumber(message.SubstanceLotNumberRepetitionsUsed);
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
        /// Add a new SubstanceExpirationDate to RXA
        /// </summary>
        public static TS AddSubstanceExpirationDate(this RXA message)
        {
            return message.GetSubstanceExpirationDate(message.SubstanceExpirationDateRepetitionsUsed);
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
        /// Add a new SubstanceManufacturerName to RXA
        /// </summary>
        public static CE AddSubstanceManufacturerName(this RXA message)
        {
            return message.GetSubstanceManufacturerName(message.SubstanceManufacturerNameRepetitionsUsed);
        }

        /// <summary>
        /// Get SubstanceRefusalReason Records from RXA
        /// </summary>
        public static IEnumerable GetSubstanceRefusalReasonRecords(this RXA message)
        {
            object[] result = message.GetRecords("SubstanceRefusalReasonRepetitionsUsed", "GetSubstanceRefusalReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstanceRefusalReason Records from RXA
        /// </summary>
        public static List<CE> GetAllSubstanceRefusalReasonRecords(this RXA message)
        {
            return message.GetAllRecords<CE>("SubstanceRefusalReasonRepetitionsUsed", "GetSubstanceRefusalReason");
        }

        /// <summary>
        /// Add a new SubstanceRefusalReason to RXA
        /// </summary>
        public static CE AddSubstanceRefusalReason(this RXA message)
        {
            return message.GetSubstanceRefusalReason(message.SubstanceRefusalReasonRepetitionsUsed);
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
        /// Add a new Indication to RXA
        /// </summary>
        public static CE AddIndication(this RXA message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
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
        /// Add a new DispensingProvider to RXD
        /// </summary>
        public static XCN AddDispensingProvider(this RXD message)
        {
            return message.GetDispensingProvider(message.DispensingProviderRepetitionsUsed);
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
        /// Add a new PharmacyTreatmentSupplierSSpecialDispensingInstructions to RXD
        /// </summary>
        public static CE AddPharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXD message)
        {
            return message.GetPharmacyTreatmentSupplierSSpecialDispensingInstructions(message.PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed);
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
        /// Add a new SubstanceLotNumber to RXD
        /// </summary>
        public static ST AddSubstanceLotNumber(this RXD message)
        {
            return message.GetSubstanceLotNumber(message.SubstanceLotNumberRepetitionsUsed);
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
        /// Add a new SubstanceExpirationDate to RXD
        /// </summary>
        public static TS AddSubstanceExpirationDate(this RXD message)
        {
            return message.GetSubstanceExpirationDate(message.SubstanceExpirationDateRepetitionsUsed);
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
        /// Add a new SubstanceManufacturerName to RXD
        /// </summary>
        public static CE AddSubstanceManufacturerName(this RXD message)
        {
            return message.GetSubstanceManufacturerName(message.SubstanceManufacturerNameRepetitionsUsed);
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
        /// Add a new Indication to RXD
        /// </summary>
        public static CE AddIndication(this RXD message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
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
        /// Add a new OrderingProviderSDEANumber to RXE
        /// </summary>
        public static XCN AddOrderingProviderSDEANumber(this RXE message)
        {
            return message.GetOrderingProviderSDEANumber(message.OrderingProviderSDEANumberRepetitionsUsed);
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
        /// Add a new PharmacistTreatmentSupplierSVerifierID to RXE
        /// </summary>
        public static XCN AddPharmacistTreatmentSupplierSVerifierID(this RXE message)
        {
            return message.GetPharmacistTreatmentSupplierSVerifierID(message.PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed);
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
        /// Add a new PharmacyTreatmentSupplierSSpecialDispensingInstructions to RXE
        /// </summary>
        public static CE AddPharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXE message)
        {
            return message.GetPharmacyTreatmentSupplierSSpecialDispensingInstructions(message.PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed);
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
        /// Add a new GiveIndication to RXE
        /// </summary>
        public static CE AddGiveIndication(this RXE message)
        {
            return message.GetGiveIndication(message.GiveIndicationRepetitionsUsed);
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
        /// Add a new AdministrationNotes to RXG
        /// </summary>
        public static CE AddAdministrationNotes(this RXG message)
        {
            return message.GetAdministrationNotes(message.AdministrationNotesRepetitionsUsed);
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
        /// Add a new PharmacyTreatmentSupplierSSpecialAdministrationInstructions to RXG
        /// </summary>
        public static CE AddPharmacyTreatmentSupplierSSpecialAdministrationInstructions(this RXG message)
        {
            return message.GetPharmacyTreatmentSupplierSSpecialAdministrationInstructions(message.PharmacyTreatmentSupplierSSpecialAdministrationInstructionsRepetitionsUsed);
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
        /// Add a new SubstanceLotNumber to RXG
        /// </summary>
        public static ST AddSubstanceLotNumber(this RXG message)
        {
            return message.GetSubstanceLotNumber(message.SubstanceLotNumberRepetitionsUsed);
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
        /// Add a new SubstanceExpirationDate to RXG
        /// </summary>
        public static TS AddSubstanceExpirationDate(this RXG message)
        {
            return message.GetSubstanceExpirationDate(message.SubstanceExpirationDateRepetitionsUsed);
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
        /// Add a new SubstanceManufacturerName to RXG
        /// </summary>
        public static CE AddSubstanceManufacturerName(this RXG message)
        {
            return message.GetSubstanceManufacturerName(message.SubstanceManufacturerNameRepetitionsUsed);
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
        /// Add a new Indication to RXG
        /// </summary>
        public static CE AddIndication(this RXG message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
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
        /// Add a new ProviderSPharmacyTreatmentInstructions to RXO
        /// </summary>
        public static CE AddProviderSPharmacyTreatmentInstructions(this RXO message)
        {
            return message.GetProviderSPharmacyTreatmentInstructions(message.ProviderSPharmacyTreatmentInstructionsRepetitionsUsed);
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
        /// Add a new OrderingProviderSDEANumber to RXO
        /// </summary>
        public static XCN AddOrderingProviderSDEANumber(this RXO message)
        {
            return message.GetOrderingProviderSDEANumber(message.OrderingProviderSDEANumberRepetitionsUsed);
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
        /// Add a new PharmacistTreatmentSupplierSVerifierID to RXO
        /// </summary>
        public static XCN AddPharmacistTreatmentSupplierSVerifierID(this RXO message)
        {
            return message.GetPharmacistTreatmentSupplierSVerifierID(message.PharmacistTreatmentSupplierSVerifierIDRepetitionsUsed);
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
        /// Add a new Indication to RXO
        /// </summary>
        public static CE AddIndication(this RXO message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
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
        /// Add a new AppointmentTimingQuantity to SCH
        /// </summary>
        public static TQ AddAppointmentTimingQuantity(this SCH message)
        {
            return message.GetAppointmentTimingQuantity(message.AppointmentTimingQuantityRepetitionsUsed);
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
        /// Add a new PlacerContactPerson to SCH
        /// </summary>
        public static XCN AddPlacerContactPerson(this SCH message)
        {
            return message.GetPlacerContactPerson(message.PlacerContactPersonRepetitionsUsed);
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
        /// Add a new PlacerContactAddress to SCH
        /// </summary>
        public static XAD AddPlacerContactAddress(this SCH message)
        {
            return message.GetPlacerContactAddress(message.PlacerContactAddressRepetitionsUsed);
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
        /// Add a new FillerContactPerson to SCH
        /// </summary>
        public static XCN AddFillerContactPerson(this SCH message)
        {
            return message.GetFillerContactPerson(message.FillerContactPersonRepetitionsUsed);
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
        /// Add a new FillerContactAddress to SCH
        /// </summary>
        public static XAD AddFillerContactAddress(this SCH message)
        {
            return message.GetFillerContactAddress(message.FillerContactAddressRepetitionsUsed);
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
        /// Add a new EnteredByPerson to SCH
        /// </summary>
        public static XCN AddEnteredByPerson(this SCH message)
        {
            return message.GetEnteredByPerson(message.EnteredByPersonRepetitionsUsed);
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
        /// Add a new EnteredByPhoneNumber to SCH
        /// </summary>
        public static XTN AddEnteredByPhoneNumber(this SCH message)
        {
            return message.GetEnteredByPhoneNumber(message.EnteredByPhoneNumberRepetitionsUsed);
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
        /// Add a new InputParameterList to SPR
        /// </summary>
        public static QIP AddInputParameterList(this SPR message)
        {
            return message.GetInputParameterList(message.InputParameterListRepetitionsUsed);
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
        public static List<CX> GetAllStaffIDCodeRecords(this STF message)
        {
            return message.GetAllRecords<CX>("StaffIDCodeRepetitionsUsed", "GetStaffIDCode");
        }

        /// <summary>
        /// Add a new StaffIDCode to STF
        /// </summary>
        public static CX AddStaffIDCode(this STF message)
        {
            return message.GetStaffIDCode(message.StaffIDCodeRepetitionsUsed);
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
        /// Add a new StaffName to STF
        /// </summary>
        public static XPN AddStaffName(this STF message)
        {
            return message.GetStaffName(message.StaffNameRepetitionsUsed);
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
        /// Add a new StaffType to STF
        /// </summary>
        public static IS AddStaffType(this STF message)
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
        /// Get HospitalService Records from STF
        /// </summary>
        public static IEnumerable GetHospitalServiceRecords(this STF message)
        {
            object[] result = message.GetRecords("HospitalServiceRepetitionsUsed", "GetHospitalService");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all HospitalService Records from STF
        /// </summary>
        public static List<CE> GetAllHospitalServiceRecords(this STF message)
        {
            return message.GetAllRecords<CE>("HospitalServiceRepetitionsUsed", "GetHospitalService");
        }

        /// <summary>
        /// Add a new HospitalService to STF
        /// </summary>
        public static CE AddHospitalService(this STF message)
        {
            return message.GetHospitalService(message.HospitalServiceRepetitionsUsed);
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
        /// Add a new Phone to STF
        /// </summary>
        public static XTN AddPhone(this STF message)
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
        public static List<XAD> GetAllOfficeHomeAddressRecords(this STF message)
        {
            return message.GetAllRecords<XAD>("OfficeHomeAddressRepetitionsUsed", "GetOfficeHomeAddress");
        }

        /// <summary>
        /// Add a new OfficeHomeAddress to STF
        /// </summary>
        public static XAD AddOfficeHomeAddress(this STF message)
        {
            return message.GetOfficeHomeAddress(message.OfficeHomeAddressRepetitionsUsed);
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
        /// Add a new InstitutionActivationDate to STF
        /// </summary>
        public static DIN AddInstitutionActivationDate(this STF message)
        {
            return message.GetInstitutionActivationDate(message.InstitutionActivationDateRepetitionsUsed);
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
        /// Add a new InstitutionInactivationDate to STF
        /// </summary>
        public static DIN AddInstitutionInactivationDate(this STF message)
        {
            return message.GetInstitutionInactivationDate(message.InstitutionInactivationDateRepetitionsUsed);
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
        /// Add a new PrimaryActivityProviderCodeName to TXA
        /// </summary>
        public static XCN AddPrimaryActivityProviderCodeName(this TXA message)
        {
            return message.GetPrimaryActivityProviderCodeName(message.PrimaryActivityProviderCodeNameRepetitionsUsed);
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
        /// Add a new EditDateTime to TXA
        /// </summary>
        public static TS AddEditDateTime(this TXA message)
        {
            return message.GetEditDateTime(message.EditDateTimeRepetitionsUsed);
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
        /// Add a new OriginatorCodeName to TXA
        /// </summary>
        public static XCN AddOriginatorCodeName(this TXA message)
        {
            return message.GetOriginatorCodeName(message.OriginatorCodeNameRepetitionsUsed);
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
        /// Add a new AssignedDocumentAuthenticator to TXA
        /// </summary>
        public static XCN AddAssignedDocumentAuthenticator(this TXA message)
        {
            return message.GetAssignedDocumentAuthenticator(message.AssignedDocumentAuthenticatorRepetitionsUsed);
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
        /// Add a new TranscriptionistCodeName to TXA
        /// </summary>
        public static XCN AddTranscriptionistCodeName(this TXA message)
        {
            return message.GetTranscriptionistCodeName(message.TranscriptionistCodeNameRepetitionsUsed);
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
        /// Add a new PlacerOrderNumber to TXA
        /// </summary>
        public static EI AddPlacerOrderNumber(this TXA message)
        {
            return message.GetPlacerOrderNumber(message.PlacerOrderNumberRepetitionsUsed);
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
        /// Add a new AuthenticationPersonTimeStamp to TXA
        /// </summary>
        public static PPN AddAuthenticationPersonTimeStamp(this TXA message)
        {
            return message.GetAuthenticationPersonTimeStamp(message.AuthenticationPersonTimeStampRepetitionsUsed);
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
        /// Add a new DistributedCopiesCodeandNameofRecipients to TXA
        /// </summary>
        public static XCN AddDistributedCopiesCodeandNameofRecipients(this TXA message)
        {
            return message.GetDistributedCopiesCodeandNameofRecipients(message.DistributedCopiesCodeandNameofRecipientsRepetitionsUsed);
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
        /// Add a new ConditionCode3539 to UB1
        /// </summary>
        public static IS AddConditionCode3539(this UB1 message)
        {
            return message.GetConditionCode3539(message.ConditionCode3539RepetitionsUsed);
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
        /// Add a new ValueAmountCode4649 to UB1
        /// </summary>
        public static UVC AddValueAmountCode4649(this UB1 message)
        {
            return message.GetValueAmountCode4649(message.ValueAmountCode4649RepetitionsUsed);
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
        /// Add a new Occurrence2832 to UB1
        /// </summary>
        public static OCD AddOccurrence2832(this UB1 message)
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
        public static List<IS> GetAllConditionCode2430Records(this UB2 message)
        {
            return message.GetAllRecords<IS>("ConditionCode2430RepetitionsUsed", "GetConditionCode2430");
        }

        /// <summary>
        /// Add a new ConditionCode2430 to UB2
        /// </summary>
        public static IS AddConditionCode2430(this UB2 message)
        {
            return message.GetConditionCode2430(message.ConditionCode2430RepetitionsUsed);
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
        /// Add a new ValueAmountCode to UB2
        /// </summary>
        public static UVC AddValueAmountCode(this UB2 message)
        {
            return message.GetValueAmountCode(message.ValueAmountCodeRepetitionsUsed);
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
        /// Add a new OccurrenceCodeDate3235 to UB2
        /// </summary>
        public static OCD AddOccurrenceCodeDate3235(this UB2 message)
        {
            return message.GetOccurrenceCodeDate3235(message.OccurrenceCodeDate3235RepetitionsUsed);
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
        /// Add a new OccurrenceSpanCodeDates to UB2
        /// </summary>
        public static OSP AddOccurrenceSpanCodeDates(this UB2 message)
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
        public static List<XCN> GetAllRUWhoSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<XCN>("RUWhoSubjectDefinitionRepetitionsUsed", "GetRUWhoSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUWhoSubjectDefinition to URD
        /// </summary>
        public static XCN AddRUWhoSubjectDefinition(this URD message)
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
        public static List<CE> GetAllRUWhatSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<CE>("RUWhatSubjectDefinitionRepetitionsUsed", "GetRUWhatSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUWhatSubjectDefinition to URD
        /// </summary>
        public static CE AddRUWhatSubjectDefinition(this URD message)
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
        public static List<CE> GetAllRUWhatDepartmentCodeRecords(this URD message)
        {
            return message.GetAllRecords<CE>("RUWhatDepartmentCodeRepetitionsUsed", "GetRUWhatDepartmentCode");
        }

        /// <summary>
        /// Add a new RUWhatDepartmentCode to URD
        /// </summary>
        public static CE AddRUWhatDepartmentCode(this URD message)
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
        /// Add a new VarianceOriginator to VAR
        /// </summary>
        public static XCN AddVarianceOriginator(this VAR message)
        {
            return message.GetVarianceOriginator(message.VarianceOriginatorRepetitionsUsed);
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
        /// Add a new VarianceDescription to VAR
        /// </summary>
        public static ST AddVarianceDescription(this VAR message)
        {
            return message.GetVarianceDescription(message.VarianceDescriptionRepetitionsUsed);
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
        /// Add a new SelectionCriteria to VTQ
        /// </summary>
        public static QSC AddSelectionCriteria(this VTQ message)
        {
            return message.GetSelectionCriteria(message.SelectionCriteriaRepetitionsUsed);
        }
        #endregion
    }
}
