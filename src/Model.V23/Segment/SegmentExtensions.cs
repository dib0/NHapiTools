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
using NHapi.Model.V23.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V23.Segment
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
        /// Remove an ResourceGroup record from AIG
        /// </summary>
        public static void RemoveResourceGroup(this AIG message, CE item)
        {
            int fieldNum = message.FindField("ResourceGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ResourceGroup record from AIG
        /// </summary>
        public static void RemoveResourceGroup(this AIG message, int itemIndex)
        {
            int fieldNum = message.FindField("ResourceGroup");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ResourceGroup Records from AIP
        /// </summary>
        public static IEnumerable GetResourceGroupRecords(this AIP message)
        {
            object[] result = message.GetRecords("ResourceGroupRepetitionsUsed", "GetResourceGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ResourceGroup Records from AIP
        /// </summary>
        public static List<CE> GetAllResourceGroupRecords(this AIP message)
        {
            return message.GetAllRecords<CE>("ResourceGroupRepetitionsUsed", "GetResourceGroup");
        }

        /// <summary>
        /// Add a new ResourceGroup to AIP
        /// </summary>
        public static CE AddResourceGroup(this AIP message)
        {
            return message.GetResourceGroup(message.ResourceGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ResourceGroup record from AIP
        /// </summary>
        public static void RemoveResourceGroup(this AIP message, CE item)
        {
            int fieldNum = message.FindField("ResourceGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ResourceGroup record from AIP
        /// </summary>
        public static void RemoveResourceGroup(this AIP message, int itemIndex)
        {
            int fieldNum = message.FindField("ResourceGroup");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an TimeSelectionCriteria record from APR
        /// </summary>
        public static void RemoveTimeSelectionCriteria(this APR message, SCV item)
        {
            int fieldNum = message.FindField("TimeSelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TimeSelectionCriteria record from APR
        /// </summary>
        public static void RemoveTimeSelectionCriteria(this APR message, int itemIndex)
        {
            int fieldNum = message.FindField("TimeSelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ResourceSelectionCriteria record from APR
        /// </summary>
        public static void RemoveResourceSelectionCriteria(this APR message, SCV item)
        {
            int fieldNum = message.FindField("ResourceSelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ResourceSelectionCriteria record from APR
        /// </summary>
        public static void RemoveResourceSelectionCriteria(this APR message, int itemIndex)
        {
            int fieldNum = message.FindField("ResourceSelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LocationSelectionCriteria record from APR
        /// </summary>
        public static void RemoveLocationSelectionCriteria(this APR message, SCV item)
        {
            int fieldNum = message.FindField("LocationSelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationSelectionCriteria record from APR
        /// </summary>
        public static void RemoveLocationSelectionCriteria(this APR message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationSelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an FillerOverrideCriteria record from APR
        /// </summary>
        public static void RemoveFillerOverrideCriteria(this APR message, SCV item)
        {
            int fieldNum = message.FindField("FillerOverrideCriteria");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerOverrideCriteria record from APR
        /// </summary>
        public static void RemoveFillerOverrideCriteria(this APR message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerOverrideCriteria");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RequestedStartDateTimeRange record from ARQ
        /// </summary>
        public static void RemoveRequestedStartDateTimeRange(this ARQ message, DR item)
        {
            int fieldNum = message.FindField("RequestedStartDateTimeRange");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RequestedStartDateTimeRange record from ARQ
        /// </summary>
        public static void RemoveRequestedStartDateTimeRange(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("RequestedStartDateTimeRange");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EnteredByPhoneNumber record from ARQ
        /// </summary>
        public static void RemoveEnteredByPhoneNumber(this ARQ message, XTN item)
        {
            int fieldNum = message.FindField("EnteredByPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EnteredByPhoneNumber record from ARQ
        /// </summary>
        public static void RemoveEnteredByPhoneNumber(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("EnteredByPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an BatchTotals record from BTS
        /// </summary>
        public static void RemoveBatchTotals(this BTS message, NM item)
        {
            int fieldNum = message.FindField("BatchTotals");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BatchTotals record from BTS
        /// </summary>
        public static void RemoveBatchTotals(this BTS message, int itemIndex)
        {
            int fieldNum = message.FindField("BatchTotals");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ChargeCodeAlias record from CDM
        /// </summary>
        public static void RemoveChargeCodeAlias(this CDM message, CE item)
        {
            int fieldNum = message.FindField("ChargeCodeAlias");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ChargeCodeAlias record from CDM
        /// </summary>
        public static void RemoveChargeCodeAlias(this CDM message, int itemIndex)
        {
            int fieldNum = message.FindField("ChargeCodeAlias");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ExplodingCharges record from CDM
        /// </summary>
        public static void RemoveExplodingCharges(this CDM message, CE item)
        {
            int fieldNum = message.FindField("ExplodingCharges");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ExplodingCharges record from CDM
        /// </summary>
        public static void RemoveExplodingCharges(this CDM message, int itemIndex)
        {
            int fieldNum = message.FindField("ExplodingCharges");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProcedureCode record from CDM
        /// </summary>
        public static void RemoveProcedureCode(this CDM message, CE item)
        {
            int fieldNum = message.FindField("ProcedureCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedureCode record from CDM
        /// </summary>
        public static void RemoveProcedureCode(this CDM message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedureCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InventoryNumber record from CDM
        /// </summary>
        public static void RemoveInventoryNumber(this CDM message, CE item)
        {
            int fieldNum = message.FindField("InventoryNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InventoryNumber record from CDM
        /// </summary>
        public static void RemoveInventoryNumber(this CDM message, int itemIndex)
        {
            int fieldNum = message.FindField("InventoryNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContractNumber record from CDM
        /// </summary>
        public static void RemoveContractNumber(this CDM message, CK item)
        {
            int fieldNum = message.FindField("ContractNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContractNumber record from CDM
        /// </summary>
        public static void RemoveContractNumber(this CDM message, int itemIndex)
        {
            int fieldNum = message.FindField("ContractNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CE> GetAllAlternateStudyIDRecords(this CM0 message)
        {
            return message.GetAllRecords<CE>("AlternateStudyIDRepetitionsUsed", "GetAlternateStudyID");
        }

        /// <summary>
        /// Add a new AlternateStudyID to CM0
        /// </summary>
        public static CE AddAlternateStudyID(this CM0 message)
        {
            return message.GetAlternateStudyID(message.AlternateStudyIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AlternateStudyID record from CM0
        /// </summary>
        public static void RemoveAlternateStudyID(this CM0 message, CE item)
        {
            int fieldNum = message.FindField("AlternateStudyID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AlternateStudyID record from CM0
        /// </summary>
        public static void RemoveAlternateStudyID(this CM0 message, int itemIndex)
        {
            int fieldNum = message.FindField("AlternateStudyID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventsScheduledThisTimePoint record from CM2
        /// </summary>
        public static void RemoveEventsScheduledThisTimePoint(this CM2 message, CE item)
        {
            int fieldNum = message.FindField("EventsScheduledThisTimePoint");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventsScheduledThisTimePoint record from CM2
        /// </summary>
        public static void RemoveEventsScheduledThisTimePoint(this CM2 message, int itemIndex)
        {
            int fieldNum = message.FindField("EventsScheduledThisTimePoint");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StudyRandomizationDateTime record from CSR
        /// </summary>
        public static void RemoveStudyRandomizationDateTime(this CSR message, TS item)
        {
            int fieldNum = message.FindField("StudyRandomizationDateTime");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StudyRandomizationDateTime record from CSR
        /// </summary>
        public static void RemoveStudyRandomizationDateTime(this CSR message, int itemIndex)
        {
            int fieldNum = message.FindField("StudyRandomizationDateTime");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get StudyRandomizedArm Records from CSR
        /// </summary>
        public static IEnumerable GetStudyRandomizedArmRecords(this CSR message)
        {
            object[] result = message.GetRecords("StudyRandomizedArmRepetitionsUsed", "GetStudyRandomizedArm");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all StudyRandomizedArm Records from CSR
        /// </summary>
        public static List<CE> GetAllStudyRandomizedArmRecords(this CSR message)
        {
            return message.GetAllRecords<CE>("StudyRandomizedArmRepetitionsUsed", "GetStudyRandomizedArm");
        }

        /// <summary>
        /// Add a new StudyRandomizedArm to CSR
        /// </summary>
        public static CE AddStudyRandomizedArm(this CSR message)
        {
            return message.GetStudyRandomizedArm(message.StudyRandomizedArmRepetitionsUsed);
        }

        /// <summary>
        /// Remove an StudyRandomizedArm record from CSR
        /// </summary>
        public static void RemoveStudyRandomizedArm(this CSR message, CE item)
        {
            int fieldNum = message.FindField("StudyRandomizedArm");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StudyRandomizedArm record from CSR
        /// </summary>
        public static void RemoveStudyRandomizedArm(this CSR message, int itemIndex)
        {
            int fieldNum = message.FindField("StudyRandomizedArm");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StratumForStudyRandomization record from CSR
        /// </summary>
        public static void RemoveStratumForStudyRandomization(this CSR message, CE item)
        {
            int fieldNum = message.FindField("StratumForStudyRandomization");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StratumForStudyRandomization record from CSR
        /// </summary>
        public static void RemoveStratumForStudyRandomization(this CSR message, int itemIndex)
        {
            int fieldNum = message.FindField("StratumForStudyRandomization");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StudyQualityControlCodes record from CSS
        /// </summary>
        public static void RemoveStudyQualityControlCodes(this CSS message, CE item)
        {
            int fieldNum = message.FindField("StudyQualityControlCodes");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StudyQualityControlCodes record from CSS
        /// </summary>
        public static void RemoveStudyQualityControlCodes(this CSS message, int itemIndex)
        {
            int fieldNum = message.FindField("StudyQualityControlCodes");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactName record from CTD
        /// </summary>
        public static void RemoveContactName(this CTD message, XPN item)
        {
            int fieldNum = message.FindField("ContactName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactName record from CTD
        /// </summary>
        public static void RemoveContactName(this CTD message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactAddress record from CTD
        /// </summary>
        public static void RemoveContactAddress(this CTD message, XAD item)
        {
            int fieldNum = message.FindField("ContactAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactAddress record from CTD
        /// </summary>
        public static void RemoveContactAddress(this CTD message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactCommunicationInformation record from CTD
        /// </summary>
        public static void RemoveContactCommunicationInformation(this CTD message, XTN item)
        {
            int fieldNum = message.FindField("ContactCommunicationInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactCommunicationInformation record from CTD
        /// </summary>
        public static void RemoveContactCommunicationInformation(this CTD message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactCommunicationInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CM_PI> GetAllContactIdentifiersRecords(this CTD message)
        {
            return message.GetAllRecords<CM_PI>("ContactIdentifiersRepetitionsUsed", "GetContactIdentifiers");
        }

        /// <summary>
        /// Add a new ContactIdentifiers to CTD
        /// </summary>
        public static CM_PI AddContactIdentifiers(this CTD message)
        {
            return message.GetContactIdentifiers(message.ContactIdentifiersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ContactIdentifiers record from CTD
        /// </summary>
        public static void RemoveContactIdentifiers(this CTD message, CM_PI item)
        {
            int fieldNum = message.FindField("ContactIdentifiers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactIdentifiers record from CTD
        /// </summary>
        public static void RemoveContactIdentifiers(this CTD message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactIdentifiers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DisabledPersonIdentifier record from DB1
        /// </summary>
        public static void RemoveDisabledPersonIdentifier(this DB1 message, CX item)
        {
            int fieldNum = message.FindField("DisabledPersonIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DisabledPersonIdentifier record from DB1
        /// </summary>
        public static void RemoveDisabledPersonIdentifier(this DB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("DisabledPersonIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DiagnosingClinician record from DG1
        /// </summary>
        public static void RemoveDiagnosingClinician(this DG1 message, XCN item)
        {
            int fieldNum = message.FindField("DiagnosingClinician");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DiagnosingClinician record from DG1
        /// </summary>
        public static void RemoveDiagnosingClinician(this DG1 message, int itemIndex)
        {
            int fieldNum = message.FindField("DiagnosingClinician");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InputParameterList record from ERQ
        /// </summary>
        public static void RemoveInputParameterList(this ERQ message, QIP item)
        {
            int fieldNum = message.FindField("InputParameterList");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InputParameterList record from ERQ
        /// </summary>
        public static void RemoveInputParameterList(this ERQ message, int itemIndex)
        {
            int fieldNum = message.FindField("InputParameterList");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ErrorCodeAndLocation record from ERR
        /// </summary>
        public static void RemoveErrorCodeAndLocation(this ERR message, CM_ELD item)
        {
            int fieldNum = message.FindField("ErrorCodeAndLocation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ErrorCodeAndLocation record from ERR
        /// </summary>
        public static void RemoveErrorCodeAndLocation(this ERR message, int itemIndex)
        {
            int fieldNum = message.FindField("ErrorCodeAndLocation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get FacilityID Records from FAC
        /// </summary>
        public static IEnumerable GetFacilityIDRecords(this FAC message)
        {
            object[] result = message.GetRecords("FacilityIDRepetitionsUsed", "GetFacilityID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FacilityID Records from FAC
        /// </summary>
        public static List<EI> GetAllFacilityIDRecords(this FAC message)
        {
            return message.GetAllRecords<EI>("FacilityIDRepetitionsUsed", "GetFacilityID");
        }

        /// <summary>
        /// Add a new FacilityID to FAC
        /// </summary>
        public static EI AddFacilityID(this FAC message)
        {
            return message.GetFacilityID(message.FacilityIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FacilityID record from FAC
        /// </summary>
        public static void RemoveFacilityID(this FAC message, EI item)
        {
            int fieldNum = message.FindField("FacilityID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FacilityID record from FAC
        /// </summary>
        public static void RemoveFacilityID(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("FacilityID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactPerson record from FAC
        /// </summary>
        public static void RemoveContactPerson(this FAC message, XCN item)
        {
            int fieldNum = message.FindField("ContactPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactPerson record from FAC
        /// </summary>
        public static void RemoveContactPerson(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactPerson");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactTitle record from FAC
        /// </summary>
        public static void RemoveContactTitle(this FAC message, ST item)
        {
            int fieldNum = message.FindField("ContactTitle");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactTitle record from FAC
        /// </summary>
        public static void RemoveContactTitle(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactTitle");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactAddress record from FAC
        /// </summary>
        public static void RemoveContactAddress(this FAC message, XAD item)
        {
            int fieldNum = message.FindField("ContactAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactAddress record from FAC
        /// </summary>
        public static void RemoveContactAddress(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactTelecommunication record from FAC
        /// </summary>
        public static void RemoveContactTelecommunication(this FAC message, XTN item)
        {
            int fieldNum = message.FindField("ContactTelecommunication");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactTelecommunication record from FAC
        /// </summary>
        public static void RemoveContactTelecommunication(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactTelecommunication");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DiagnosisCode record from FT1
        /// </summary>
        public static void RemoveDiagnosisCode(this FT1 message, CE item)
        {
            int fieldNum = message.FindField("DiagnosisCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DiagnosisCode record from FT1
        /// </summary>
        public static void RemoveDiagnosisCode(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("DiagnosisCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GoalEvaluationComment record from GOL
        /// </summary>
        public static void RemoveGoalEvaluationComment(this GOL message, ST item)
        {
            int fieldNum = message.FindField("GoalEvaluationComment");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GoalEvaluationComment record from GOL
        /// </summary>
        public static void RemoveGoalEvaluationComment(this GOL message, int itemIndex)
        {
            int fieldNum = message.FindField("GoalEvaluationComment");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GoalTargetType record from GOL
        /// </summary>
        public static void RemoveGoalTargetType(this GOL message, CE item)
        {
            int fieldNum = message.FindField("GoalTargetType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GoalTargetType record from GOL
        /// </summary>
        public static void RemoveGoalTargetType(this GOL message, int itemIndex)
        {
            int fieldNum = message.FindField("GoalTargetType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GoalTargetName record from GOL
        /// </summary>
        public static void RemoveGoalTargetName(this GOL message, XPN item)
        {
            int fieldNum = message.FindField("GoalTargetName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GoalTargetName record from GOL
        /// </summary>
        public static void RemoveGoalTargetName(this GOL message, int itemIndex)
        {
            int fieldNum = message.FindField("GoalTargetName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorNumber(this GT1 message, CX item)
        {
            int fieldNum = message.FindField("GuarantorNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorNumber(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorName record from GT1
        /// </summary>
        public static void RemoveGuarantorName(this GT1 message, XPN item)
        {
            int fieldNum = message.FindField("GuarantorName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorName record from GT1
        /// </summary>
        public static void RemoveGuarantorName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorSpouseName record from GT1
        /// </summary>
        public static void RemoveGuarantorSpouseName(this GT1 message, XPN item)
        {
            int fieldNum = message.FindField("GuarantorSpouseName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorSpouseName record from GT1
        /// </summary>
        public static void RemoveGuarantorSpouseName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorSpouseName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorAddress record from GT1
        /// </summary>
        public static void RemoveGuarantorAddress(this GT1 message, XAD item)
        {
            int fieldNum = message.FindField("GuarantorAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorAddress record from GT1
        /// </summary>
        public static void RemoveGuarantorAddress(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorPhNumHome record from GT1
        /// </summary>
        public static void RemoveGuarantorPhNumHome(this GT1 message, XTN item)
        {
            int fieldNum = message.FindField("GuarantorPhNumHome");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorPhNumHome record from GT1
        /// </summary>
        public static void RemoveGuarantorPhNumHome(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorPhNumHome");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorPhNumBusiness record from GT1
        /// </summary>
        public static void RemoveGuarantorPhNumBusiness(this GT1 message, XTN item)
        {
            int fieldNum = message.FindField("GuarantorPhNumBusiness");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorPhNumBusiness record from GT1
        /// </summary>
        public static void RemoveGuarantorPhNumBusiness(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorPhNumBusiness");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorEmployerName record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerName(this GT1 message, XPN item)
        {
            int fieldNum = message.FindField("GuarantorEmployerName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployerName record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployerName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorEmployerAddress record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerAddress(this GT1 message, XAD item)
        {
            int fieldNum = message.FindField("GuarantorEmployerAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployerAddress record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerAddress(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployerAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<XTN> GetAllGuarantorEmployPhoneNumberRecords(this GT1 message)
        {
            return message.GetAllRecords<XTN>("GuarantorEmployPhoneNumberRepetitionsUsed", "GetGuarantorEmployPhoneNumber");
        }

        /// <summary>
        /// Add a new GuarantorEmployPhoneNumber to GT1
        /// </summary>
        public static XTN AddGuarantorEmployPhoneNumber(this GT1 message)
        {
            return message.GetGuarantorEmployPhoneNumber(message.GuarantorEmployPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GuarantorEmployPhoneNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployPhoneNumber(this GT1 message, XTN item)
        {
            int fieldNum = message.FindField("GuarantorEmployPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployPhoneNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployPhoneNumber(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorEmployeeIDNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployeeIDNumber(this GT1 message, CX item)
        {
            int fieldNum = message.FindField("GuarantorEmployeeIDNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployeeIDNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployeeIDNumber(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployeeIDNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get GuarantorOrganization Records from GT1
        /// </summary>
        public static IEnumerable GetGuarantorOrganizationRecords(this GT1 message)
        {
            object[] result = message.GetRecords("GuarantorOrganizationRepetitionsUsed", "GetGuarantorOrganization");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GuarantorOrganization Records from GT1
        /// </summary>
        public static List<XON> GetAllGuarantorOrganizationRecords(this GT1 message)
        {
            return message.GetAllRecords<XON>("GuarantorOrganizationRepetitionsUsed", "GetGuarantorOrganization");
        }

        /// <summary>
        /// Add a new GuarantorOrganization to GT1
        /// </summary>
        public static XON AddGuarantorOrganization(this GT1 message)
        {
            return message.GetGuarantorOrganization(message.GuarantorOrganizationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GuarantorOrganization record from GT1
        /// </summary>
        public static void RemoveGuarantorOrganization(this GT1 message, XON item)
        {
            int fieldNum = message.FindField("GuarantorOrganization");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorOrganization record from GT1
        /// </summary>
        public static void RemoveGuarantorOrganization(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorOrganization");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorEmployerIDNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerIDNumber(this GT1 message, CX item)
        {
            int fieldNum = message.FindField("GuarantorEmployerIDNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployerIDNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerIDNumber(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployerIDNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactPersonSName record from GT1
        /// </summary>
        public static void RemoveContactPersonSName(this GT1 message, XPN item)
        {
            int fieldNum = message.FindField("ContactPersonSName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactPersonSName record from GT1
        /// </summary>
        public static void RemoveContactPersonSName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactPersonSName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactPersonSTelephoneNumber record from GT1
        /// </summary>
        public static void RemoveContactPersonSTelephoneNumber(this GT1 message, XTN item)
        {
            int fieldNum = message.FindField("ContactPersonSTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactPersonSTelephoneNumber record from GT1
        /// </summary>
        public static void RemoveContactPersonSTelephoneNumber(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactPersonSTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GuarantorEmployerSOrganizationName record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerSOrganizationName(this GT1 message, XON item)
        {
            int fieldNum = message.FindField("GuarantorEmployerSOrganizationName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployerSOrganizationName record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerSOrganizationName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployerSOrganizationName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuranceCompanyID record from IN1
        /// </summary>
        public static void RemoveInsuranceCompanyID(this IN1 message, CX item)
        {
            int fieldNum = message.FindField("InsuranceCompanyID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCompanyID record from IN1
        /// </summary>
        public static void RemoveInsuranceCompanyID(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCompanyID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuranceCompanyName record from IN1
        /// </summary>
        public static void RemoveInsuranceCompanyName(this IN1 message, XON item)
        {
            int fieldNum = message.FindField("InsuranceCompanyName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCompanyName record from IN1
        /// </summary>
        public static void RemoveInsuranceCompanyName(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCompanyName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuranceCompanyAddress record from IN1
        /// </summary>
        public static void RemoveInsuranceCompanyAddress(this IN1 message, XAD item)
        {
            int fieldNum = message.FindField("InsuranceCompanyAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCompanyAddress record from IN1
        /// </summary>
        public static void RemoveInsuranceCompanyAddress(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCompanyAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuranceCoContactPpers Records from IN1
        /// </summary>
        public static IEnumerable GetInsuranceCoContactPpersRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuranceCoContactPpersRepetitionsUsed", "GetInsuranceCoContactPpers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCoContactPpers Records from IN1
        /// </summary>
        public static List<XPN> GetAllInsuranceCoContactPpersRecords(this IN1 message)
        {
            return message.GetAllRecords<XPN>("InsuranceCoContactPpersRepetitionsUsed", "GetInsuranceCoContactPpers");
        }

        /// <summary>
        /// Add a new InsuranceCoContactPpers to IN1
        /// </summary>
        public static XPN AddInsuranceCoContactPpers(this IN1 message)
        {
            return message.GetInsuranceCoContactPpers(message.InsuranceCoContactPpersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuranceCoContactPpers record from IN1
        /// </summary>
        public static void RemoveInsuranceCoContactPpers(this IN1 message, XPN item)
        {
            int fieldNum = message.FindField("InsuranceCoContactPpers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCoContactPpers record from IN1
        /// </summary>
        public static void RemoveInsuranceCoContactPpers(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCoContactPpers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuranceCoPhoneNumber record from IN1
        /// </summary>
        public static void RemoveInsuranceCoPhoneNumber(this IN1 message, XTN item)
        {
            int fieldNum = message.FindField("InsuranceCoPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCoPhoneNumber record from IN1
        /// </summary>
        public static void RemoveInsuranceCoPhoneNumber(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCoPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an GroupName record from IN1
        /// </summary>
        public static void RemoveGroupName(this IN1 message, XON item)
        {
            int fieldNum = message.FindField("GroupName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GroupName record from IN1
        /// </summary>
        public static void RemoveGroupName(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GroupName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuredSGroupEmployerID Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSGroupEmployerIDRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSGroupEmployerIDRepetitionsUsed", "GetInsuredSGroupEmployerID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSGroupEmployerID Records from IN1
        /// </summary>
        public static List<CX> GetAllInsuredSGroupEmployerIDRecords(this IN1 message)
        {
            return message.GetAllRecords<CX>("InsuredSGroupEmployerIDRepetitionsUsed", "GetInsuredSGroupEmployerID");
        }

        /// <summary>
        /// Add a new InsuredSGroupEmployerID to IN1
        /// </summary>
        public static CX AddInsuredSGroupEmployerID(this IN1 message)
        {
            return message.GetInsuredSGroupEmployerID(message.InsuredSGroupEmployerIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuredSGroupEmployerID record from IN1
        /// </summary>
        public static void RemoveInsuredSGroupEmployerID(this IN1 message, CX item)
        {
            int fieldNum = message.FindField("InsuredSGroupEmployerID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSGroupEmployerID record from IN1
        /// </summary>
        public static void RemoveInsuredSGroupEmployerID(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSGroupEmployerID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSGroupEmpName record from IN1
        /// </summary>
        public static void RemoveInsuredSGroupEmpName(this IN1 message, XON item)
        {
            int fieldNum = message.FindField("InsuredSGroupEmpName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSGroupEmpName record from IN1
        /// </summary>
        public static void RemoveInsuredSGroupEmpName(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSGroupEmpName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an NameOfInsured record from IN1
        /// </summary>
        public static void RemoveNameOfInsured(this IN1 message, XPN item)
        {
            int fieldNum = message.FindField("NameOfInsured");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NameOfInsured record from IN1
        /// </summary>
        public static void RemoveNameOfInsured(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("NameOfInsured");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSAddress record from IN1
        /// </summary>
        public static void RemoveInsuredSAddress(this IN1 message, XAD item)
        {
            int fieldNum = message.FindField("InsuredSAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSAddress record from IN1
        /// </summary>
        public static void RemoveInsuredSAddress(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuredSEmployerAddress Records from IN1
        /// </summary>
        public static IEnumerable GetInsuredSEmployerAddressRecords(this IN1 message)
        {
            object[] result = message.GetRecords("InsuredSEmployerAddressRepetitionsUsed", "GetInsuredSEmployerAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployerAddress Records from IN1
        /// </summary>
        public static List<XAD> GetAllInsuredSEmployerAddressRecords(this IN1 message)
        {
            return message.GetAllRecords<XAD>("InsuredSEmployerAddressRepetitionsUsed", "GetInsuredSEmployerAddress");
        }

        /// <summary>
        /// Add a new InsuredSEmployerAddress to IN1
        /// </summary>
        public static XAD AddInsuredSEmployerAddress(this IN1 message)
        {
            return message.GetInsuredSEmployerAddress(message.InsuredSEmployerAddressRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuredSEmployerAddress record from IN1
        /// </summary>
        public static void RemoveInsuredSEmployerAddress(this IN1 message, XAD item)
        {
            int fieldNum = message.FindField("InsuredSEmployerAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployerAddress record from IN1
        /// </summary>
        public static void RemoveInsuredSEmployerAddress(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployerAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSIDNumber record from IN1
        /// </summary>
        public static void RemoveInsuredSIDNumber(this IN1 message, CX item)
        {
            int fieldNum = message.FindField("InsuredSIDNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSIDNumber record from IN1
        /// </summary>
        public static void RemoveInsuredSIDNumber(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSIDNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSEmployeeID record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployeeID(this IN2 message, CX item)
        {
            int fieldNum = message.FindField("InsuredSEmployeeID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployeeID record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployeeID(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployeeID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuredSEmployerName Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSEmployerNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSEmployerNameRepetitionsUsed", "GetInsuredSEmployerName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployerName Records from IN2
        /// </summary>
        public static List<XCN> GetAllInsuredSEmployerNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XCN>("InsuredSEmployerNameRepetitionsUsed", "GetInsuredSEmployerName");
        }

        /// <summary>
        /// Add a new InsuredSEmployerName to IN2
        /// </summary>
        public static XCN AddInsuredSEmployerName(this IN2 message)
        {
            return message.GetInsuredSEmployerName(message.InsuredSEmployerNameRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuredSEmployerName record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerName(this IN2 message, XCN item)
        {
            int fieldNum = message.FindField("InsuredSEmployerName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployerName record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployerName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an MailClaimParty record from IN2
        /// </summary>
        public static void RemoveMailClaimParty(this IN2 message, IS item)
        {
            int fieldNum = message.FindField("MailClaimParty");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MailClaimParty record from IN2
        /// </summary>
        public static void RemoveMailClaimParty(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("MailClaimParty");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an MedicaidCaseName record from IN2
        /// </summary>
        public static void RemoveMedicaidCaseName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("MedicaidCaseName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MedicaidCaseName record from IN2
        /// </summary>
        public static void RemoveMedicaidCaseName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("MedicaidCaseName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ChampusSponsorName Records from IN2
        /// </summary>
        public static IEnumerable GetChampusSponsorNameRecords(this IN2 message)
        {
            object[] result = message.GetRecords("ChampusSponsorNameRepetitionsUsed", "GetChampusSponsorName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ChampusSponsorName Records from IN2
        /// </summary>
        public static List<XPN> GetAllChampusSponsorNameRecords(this IN2 message)
        {
            return message.GetAllRecords<XPN>("ChampusSponsorNameRepetitionsUsed", "GetChampusSponsorName");
        }

        /// <summary>
        /// Add a new ChampusSponsorName to IN2
        /// </summary>
        public static XPN AddChampusSponsorName(this IN2 message)
        {
            return message.GetChampusSponsorName(message.ChampusSponsorNameRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ChampusSponsorName record from IN2
        /// </summary>
        public static void RemoveChampusSponsorName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("ChampusSponsorName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ChampusSponsorName record from IN2
        /// </summary>
        public static void RemoveChampusSponsorName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ChampusSponsorName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SpecialCoverageApprovalName record from IN2
        /// </summary>
        public static void RemoveSpecialCoverageApprovalName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("SpecialCoverageApprovalName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecialCoverageApprovalName record from IN2
        /// </summary>
        public static void RemoveSpecialCoverageApprovalName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecialCoverageApprovalName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an NonCoveredInsuranceCode record from IN2
        /// </summary>
        public static void RemoveNonCoveredInsuranceCode(this IN2 message, IS item)
        {
            int fieldNum = message.FindField("NonCoveredInsuranceCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NonCoveredInsuranceCode record from IN2
        /// </summary>
        public static void RemoveNonCoveredInsuranceCode(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("NonCoveredInsuranceCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PayorID record from IN2
        /// </summary>
        public static void RemovePayorID(this IN2 message, CX item)
        {
            int fieldNum = message.FindField("PayorID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PayorID record from IN2
        /// </summary>
        public static void RemovePayorID(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("PayorID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PayorSubscriberID record from IN2
        /// </summary>
        public static void RemovePayorSubscriberID(this IN2 message, CX item)
        {
            int fieldNum = message.FindField("PayorSubscriberID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PayorSubscriberID record from IN2
        /// </summary>
        public static void RemovePayorSubscriberID(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("PayorSubscriberID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RoomCoverageTypeAmount record from IN2
        /// </summary>
        public static void RemoveRoomCoverageTypeAmount(this IN2 message, CM_RMC item)
        {
            int fieldNum = message.FindField("RoomCoverageTypeAmount");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RoomCoverageTypeAmount record from IN2
        /// </summary>
        public static void RemoveRoomCoverageTypeAmount(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RoomCoverageTypeAmount");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PolicyTypeAmount record from IN2
        /// </summary>
        public static void RemovePolicyTypeAmount(this IN2 message, CM_PTA item)
        {
            int fieldNum = message.FindField("PolicyTypeAmount");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PolicyTypeAmount record from IN2
        /// </summary>
        public static void RemovePolicyTypeAmount(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("PolicyTypeAmount");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<IS> GetAllMaritalStatusRecords(this IN2 message)
        {
            return message.GetAllRecords<IS>("MaritalStatusRepetitionsUsed", "GetMaritalStatus");
        }

        /// <summary>
        /// Add a new MaritalStatus to IN2
        /// </summary>
        public static IS AddMaritalStatus(this IN2 message)
        {
            return message.GetMaritalStatus(message.MaritalStatusRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MaritalStatus record from IN2
        /// </summary>
        public static void RemoveMaritalStatus(this IN2 message, IS item)
        {
            int fieldNum = message.FindField("MaritalStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MaritalStatus record from IN2
        /// </summary>
        public static void RemoveMaritalStatus(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("MaritalStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EmployerContactPersonName record from IN2
        /// </summary>
        public static void RemoveEmployerContactPersonName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("EmployerContactPersonName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EmployerContactPersonName record from IN2
        /// </summary>
        public static void RemoveEmployerContactPersonName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("EmployerContactPersonName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EmployerContactPersonPhoneNumber record from IN2
        /// </summary>
        public static void RemoveEmployerContactPersonPhoneNumber(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("EmployerContactPersonPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EmployerContactPersonPhoneNumber record from IN2
        /// </summary>
        public static void RemoveEmployerContactPersonPhoneNumber(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("EmployerContactPersonPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSContactPersonSName record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonSName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("InsuredSContactPersonSName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSContactPersonSName record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonSName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSContactPersonSName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuredSContactPersonTelephoneNumber Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSContactPersonTelephoneNumberRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSContactPersonTelephoneNumberRepetitionsUsed", "GetInsuredSContactPersonTelephoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSContactPersonTelephoneNumber Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuredSContactPersonTelephoneNumberRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuredSContactPersonTelephoneNumberRepetitionsUsed", "GetInsuredSContactPersonTelephoneNumber");
        }

        /// <summary>
        /// Add a new InsuredSContactPersonTelephoneNumber to IN2
        /// </summary>
        public static XTN AddInsuredSContactPersonTelephoneNumber(this IN2 message)
        {
            return message.GetInsuredSContactPersonTelephoneNumber(message.InsuredSContactPersonTelephoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuredSContactPersonTelephoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonTelephoneNumber(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuredSContactPersonTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSContactPersonTelephoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonTelephoneNumber(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSContactPersonTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSContactPersonReason record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonReason(this IN2 message, IS item)
        {
            int fieldNum = message.FindField("InsuredSContactPersonReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSContactPersonReason record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonReason(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSContactPersonReason");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RelationshipToThePatientStopDate record from IN2
        /// </summary>
        public static void RemoveRelationshipToThePatientStopDate(this IN2 message, DT item)
        {
            int fieldNum = message.FindField("RelationshipToThePatientStopDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RelationshipToThePatientStopDate record from IN2
        /// </summary>
        public static void RemoveRelationshipToThePatientStopDate(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RelationshipToThePatientStopDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuredSTelephoneNumberHome Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSTelephoneNumberHomeRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSTelephoneNumberHomeRepetitionsUsed", "GetInsuredSTelephoneNumberHome");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSTelephoneNumberHome Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuredSTelephoneNumberHomeRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuredSTelephoneNumberHomeRepetitionsUsed", "GetInsuredSTelephoneNumberHome");
        }

        /// <summary>
        /// Add a new InsuredSTelephoneNumberHome to IN2
        /// </summary>
        public static XTN AddInsuredSTelephoneNumberHome(this IN2 message)
        {
            return message.GetInsuredSTelephoneNumberHome(message.InsuredSTelephoneNumberHomeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuredSTelephoneNumberHome record from IN2
        /// </summary>
        public static void RemoveInsuredSTelephoneNumberHome(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuredSTelephoneNumberHome");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSTelephoneNumberHome record from IN2
        /// </summary>
        public static void RemoveInsuredSTelephoneNumberHome(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSTelephoneNumberHome");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get InsuredSEmployerTelephoneNumber Records from IN2
        /// </summary>
        public static IEnumerable GetInsuredSEmployerTelephoneNumberRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuredSEmployerTelephoneNumberRepetitionsUsed", "GetInsuredSEmployerTelephoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuredSEmployerTelephoneNumber Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuredSEmployerTelephoneNumberRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuredSEmployerTelephoneNumberRepetitionsUsed", "GetInsuredSEmployerTelephoneNumber");
        }

        /// <summary>
        /// Add a new InsuredSEmployerTelephoneNumber to IN2
        /// </summary>
        public static XTN AddInsuredSEmployerTelephoneNumber(this IN2 message)
        {
            return message.GetInsuredSEmployerTelephoneNumber(message.InsuredSEmployerTelephoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuredSEmployerTelephoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerTelephoneNumber(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuredSEmployerTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployerTelephoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerTelephoneNumber(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployerTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredOrganizationNameAndID record from IN2
        /// </summary>
        public static void RemoveInsuredOrganizationNameAndID(this IN2 message, XON item)
        {
            int fieldNum = message.FindField("InsuredOrganizationNameAndID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredOrganizationNameAndID record from IN2
        /// </summary>
        public static void RemoveInsuredOrganizationNameAndID(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredOrganizationNameAndID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredEmployerOrganizationNameAndID record from IN2
        /// </summary>
        public static void RemoveInsuredEmployerOrganizationNameAndID(this IN2 message, XON item)
        {
            int fieldNum = message.FindField("InsuredEmployerOrganizationNameAndID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredEmployerOrganizationNameAndID record from IN2
        /// </summary>
        public static void RemoveInsuredEmployerOrganizationNameAndID(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredEmployerOrganizationNameAndID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CertifiedBy record from IN3
        /// </summary>
        public static void RemoveCertifiedBy(this IN3 message, XCN item)
        {
            int fieldNum = message.FindField("CertifiedBy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CertifiedBy record from IN3
        /// </summary>
        public static void RemoveCertifiedBy(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("CertifiedBy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Operator record from IN3
        /// </summary>
        public static void RemoveOperator(this IN3 message, XCN item)
        {
            int fieldNum = message.FindField("Operator");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Operator record from IN3
        /// </summary>
        public static void RemoveOperator(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("Operator");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PhysicianReviewer record from IN3
        /// </summary>
        public static void RemovePhysicianReviewer(this IN3 message, XCN item)
        {
            int fieldNum = message.FindField("PhysicianReviewer");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PhysicianReviewer record from IN3
        /// </summary>
        public static void RemovePhysicianReviewer(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("PhysicianReviewer");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CertificationContactPhoneNumber record from IN3
        /// </summary>
        public static void RemoveCertificationContactPhoneNumber(this IN3 message, XTN item)
        {
            int fieldNum = message.FindField("CertificationContactPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CertificationContactPhoneNumber record from IN3
        /// </summary>
        public static void RemoveCertificationContactPhoneNumber(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("CertificationContactPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CertificationAgencyPhoneNumber record from IN3
        /// </summary>
        public static void RemoveCertificationAgencyPhoneNumber(this IN3 message, XTN item)
        {
            int fieldNum = message.FindField("CertificationAgencyPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CertificationAgencyPhoneNumber record from IN3
        /// </summary>
        public static void RemoveCertificationAgencyPhoneNumber(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("CertificationAgencyPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PreCertificationRequiredWindow record from IN3
        /// </summary>
        public static void RemovePreCertificationRequiredWindow(this IN3 message, CM_PCF item)
        {
            int fieldNum = message.FindField("PreCertificationRequiredWindow");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PreCertificationRequiredWindow record from IN3
        /// </summary>
        public static void RemovePreCertificationRequiredWindow(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("PreCertificationRequiredWindow");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SecondOpinionDocumentationReceived record from IN3
        /// </summary>
        public static void RemoveSecondOpinionDocumentationReceived(this IN3 message, IS item)
        {
            int fieldNum = message.FindField("SecondOpinionDocumentationReceived");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SecondOpinionDocumentationReceived record from IN3
        /// </summary>
        public static void RemoveSecondOpinionDocumentationReceived(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("SecondOpinionDocumentationReceived");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SecondOpinionPhysician record from IN3
        /// </summary>
        public static void RemoveSecondOpinionPhysician(this IN3 message, XCN item)
        {
            int fieldNum = message.FindField("SecondOpinionPhysician");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SecondOpinionPhysician record from IN3
        /// </summary>
        public static void RemoveSecondOpinionPhysician(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("SecondOpinionPhysician");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AccommodationType record from LCC
        /// </summary>
        public static void RemoveAccommodationType(this LCC message, CE item)
        {
            int fieldNum = message.FindField("AccommodationType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AccommodationType record from LCC
        /// </summary>
        public static void RemoveAccommodationType(this LCC message, int itemIndex)
        {
            int fieldNum = message.FindField("AccommodationType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ChargeCode record from LCC
        /// </summary>
        public static void RemoveChargeCode(this LCC message, CE item)
        {
            int fieldNum = message.FindField("ChargeCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ChargeCode record from LCC
        /// </summary>
        public static void RemoveChargeCode(this LCC message, int itemIndex)
        {
            int fieldNum = message.FindField("ChargeCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LocationService record from LDP
        /// </summary>
        public static void RemoveLocationService(this LDP message, IS item)
        {
            int fieldNum = message.FindField("LocationService");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationService record from LDP
        /// </summary>
        public static void RemoveLocationService(this LDP message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationService");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get SpecialityType Records from LDP
        /// </summary>
        public static IEnumerable GetSpecialityTypeRecords(this LDP message)
        {
            object[] result = message.GetRecords("SpecialityTypeRepetitionsUsed", "GetSpecialityType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialityType Records from LDP
        /// </summary>
        public static List<CE> GetAllSpecialityTypeRecords(this LDP message)
        {
            return message.GetAllRecords<CE>("SpecialityTypeRepetitionsUsed", "GetSpecialityType");
        }

        /// <summary>
        /// Add a new SpecialityType to LDP
        /// </summary>
        public static CE AddSpecialityType(this LDP message)
        {
            return message.GetSpecialityType(message.SpecialityTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecialityType record from LDP
        /// </summary>
        public static void RemoveSpecialityType(this LDP message, CE item)
        {
            int fieldNum = message.FindField("SpecialityType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecialityType record from LDP
        /// </summary>
        public static void RemoveSpecialityType(this LDP message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecialityType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<ID> GetAllValidPatientClassesRecords(this LDP message)
        {
            return message.GetAllRecords<ID>("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");
        }

        /// <summary>
        /// Add a new ValidPatientClasses to LDP
        /// </summary>
        public static ID AddValidPatientClasses(this LDP message)
        {
            return message.GetValidPatientClasses(message.ValidPatientClassesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ValidPatientClasses record from LDP
        /// </summary>
        public static void RemoveValidPatientClasses(this LDP message, ID item)
        {
            int fieldNum = message.FindField("ValidPatientClasses");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ValidPatientClasses record from LDP
        /// </summary>
        public static void RemoveValidPatientClasses(this LDP message, int itemIndex)
        {
            int fieldNum = message.FindField("ValidPatientClasses");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an VisitingHours record from LDP
        /// </summary>
        public static void RemoveVisitingHours(this LDP message, VH item)
        {
            int fieldNum = message.FindField("VisitingHours");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VisitingHours record from LDP
        /// </summary>
        public static void RemoveVisitingHours(this LDP message, int itemIndex)
        {
            int fieldNum = message.FindField("VisitingHours");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get LocationType Records from LOC
        /// </summary>
        public static IEnumerable GetLocationTypeRecords(this LOC message)
        {
            object[] result = message.GetRecords("LocationTypeRepetitionsUsed", "GetLocationType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocationType Records from LOC
        /// </summary>
        public static List<IS> GetAllLocationTypeRecords(this LOC message)
        {
            return message.GetAllRecords<IS>("LocationTypeRepetitionsUsed", "GetLocationType");
        }

        /// <summary>
        /// Add a new LocationType to LOC
        /// </summary>
        public static IS AddLocationType(this LOC message)
        {
            return message.GetLocationType(message.LocationTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an LocationType record from LOC
        /// </summary>
        public static void RemoveLocationType(this LOC message, IS item)
        {
            int fieldNum = message.FindField("LocationType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationType record from LOC
        /// </summary>
        public static void RemoveLocationType(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LocationPhone record from LOC
        /// </summary>
        public static void RemoveLocationPhone(this LOC message, XTN item)
        {
            int fieldNum = message.FindField("LocationPhone");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationPhone record from LOC
        /// </summary>
        public static void RemoveLocationPhone(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationPhone");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LicenseNumber record from LOC
        /// </summary>
        public static void RemoveLicenseNumber(this LOC message, CE item)
        {
            int fieldNum = message.FindField("LicenseNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LicenseNumber record from LOC
        /// </summary>
        public static void RemoveLicenseNumber(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("LicenseNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<ID> GetAllLocationEquipmentRecords(this LOC message)
        {
            return message.GetAllRecords<ID>("LocationEquipmentRepetitionsUsed", "GetLocationEquipment");
        }

        /// <summary>
        /// Add a new LocationEquipment to LOC
        /// </summary>
        public static ID AddLocationEquipment(this LOC message)
        {
            return message.GetLocationEquipment(message.LocationEquipmentRepetitionsUsed);
        }

        /// <summary>
        /// Remove an LocationEquipment record from LOC
        /// </summary>
        public static void RemoveLocationEquipment(this LOC message, ID item)
        {
            int fieldNum = message.FindField("LocationEquipment");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationEquipment record from LOC
        /// </summary>
        public static void RemoveLocationEquipment(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationEquipment");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryKeyValue record from MFA
        /// </summary>
        public static void RemovePrimaryKeyValue(this MFA message, CE item)
        {
            int fieldNum = message.FindField("PrimaryKeyValue");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValue record from MFA
        /// </summary>
        public static void RemovePrimaryKeyValue(this MFA message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValue");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryKeyValue record from MFE
        /// </summary>
        public static void RemovePrimaryKeyValue(this MFE message, CE item)
        {
            int fieldNum = message.FindField("PrimaryKeyValue");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValue record from MFE
        /// </summary>
        public static void RemovePrimaryKeyValue(this MFE message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValue");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get PriorPatientIDInternal Records from MRG
        /// </summary>
        public static IEnumerable GetPriorPatientIDInternalRecords(this MRG message)
        {
            object[] result = message.GetRecords("PriorPatientIDInternalRepetitionsUsed", "GetPriorPatientIDInternal");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PriorPatientIDInternal Records from MRG
        /// </summary>
        public static List<CX> GetAllPriorPatientIDInternalRecords(this MRG message)
        {
            return message.GetAllRecords<CX>("PriorPatientIDInternalRepetitionsUsed", "GetPriorPatientIDInternal");
        }

        /// <summary>
        /// Add a new PriorPatientIDInternal to MRG
        /// </summary>
        public static CX AddPriorPatientIDInternal(this MRG message)
        {
            return message.GetPriorPatientIDInternal(message.PriorPatientIDInternalRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PriorPatientIDInternal record from MRG
        /// </summary>
        public static void RemovePriorPatientIDInternal(this MRG message, CX item)
        {
            int fieldNum = message.FindField("PriorPatientIDInternal");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PriorPatientIDInternal record from MRG
        /// </summary>
        public static void RemovePriorPatientIDInternal(this MRG message, int itemIndex)
        {
            int fieldNum = message.FindField("PriorPatientIDInternal");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PriorAlternatePatientID record from MRG
        /// </summary>
        public static void RemovePriorAlternatePatientID(this MRG message, CX item)
        {
            int fieldNum = message.FindField("PriorAlternatePatientID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PriorAlternatePatientID record from MRG
        /// </summary>
        public static void RemovePriorAlternatePatientID(this MRG message, int itemIndex)
        {
            int fieldNum = message.FindField("PriorAlternatePatientID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Name record from NK1
        /// </summary>
        public static void RemoveName(this NK1 message, XPN item)
        {
            int fieldNum = message.FindField("Name");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Name record from NK1
        /// </summary>
        public static void RemoveName(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Name");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Address record from NK1
        /// </summary>
        public static void RemoveAddress(this NK1 message, XAD item)
        {
            int fieldNum = message.FindField("Address");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Address record from NK1
        /// </summary>
        public static void RemoveAddress(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Address");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PhoneNumber record from NK1
        /// </summary>
        public static void RemovePhoneNumber(this NK1 message, XTN item)
        {
            int fieldNum = message.FindField("PhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PhoneNumber record from NK1
        /// </summary>
        public static void RemovePhoneNumber(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("PhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an BusinessPhoneNumber record from NK1
        /// </summary>
        public static void RemoveBusinessPhoneNumber(this NK1 message, XTN item)
        {
            int fieldNum = message.FindField("BusinessPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BusinessPhoneNumber record from NK1
        /// </summary>
        public static void RemoveBusinessPhoneNumber(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("BusinessPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get OrganizationName Records from NK1
        /// </summary>
        public static IEnumerable GetOrganizationNameRecords(this NK1 message)
        {
            object[] result = message.GetRecords("OrganizationNameRepetitionsUsed", "GetOrganizationName");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrganizationName Records from NK1
        /// </summary>
        public static List<XON> GetAllOrganizationNameRecords(this NK1 message)
        {
            return message.GetAllRecords<XON>("OrganizationNameRepetitionsUsed", "GetOrganizationName");
        }

        /// <summary>
        /// Add a new OrganizationName to NK1
        /// </summary>
        public static XON AddOrganizationName(this NK1 message)
        {
            return message.GetOrganizationName(message.OrganizationNameRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OrganizationName record from NK1
        /// </summary>
        public static void RemoveOrganizationName(this NK1 message, XON item)
        {
            int fieldNum = message.FindField("OrganizationName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrganizationName record from NK1
        /// </summary>
        public static void RemoveOrganizationName(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OrganizationName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get MaritalStatus Records from NK1
        /// </summary>
        public static IEnumerable GetMaritalStatusRecords(this NK1 message)
        {
            object[] result = message.GetRecords("MaritalStatusRepetitionsUsed", "GetMaritalStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MaritalStatus Records from NK1
        /// </summary>
        public static List<IS> GetAllMaritalStatusRecords(this NK1 message)
        {
            return message.GetAllRecords<IS>("MaritalStatusRepetitionsUsed", "GetMaritalStatus");
        }

        /// <summary>
        /// Add a new MaritalStatus to NK1
        /// </summary>
        public static IS AddMaritalStatus(this NK1 message)
        {
            return message.GetMaritalStatus(message.MaritalStatusRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MaritalStatus record from NK1
        /// </summary>
        public static void RemoveMaritalStatus(this NK1 message, IS item)
        {
            int fieldNum = message.FindField("MaritalStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MaritalStatus record from NK1
        /// </summary>
        public static void RemoveMaritalStatus(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("MaritalStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LivingDependency record from NK1
        /// </summary>
        public static void RemoveLivingDependency(this NK1 message, IS item)
        {
            int fieldNum = message.FindField("LivingDependency");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LivingDependency record from NK1
        /// </summary>
        public static void RemoveLivingDependency(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("LivingDependency");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AmbulatoryStatus record from NK1
        /// </summary>
        public static void RemoveAmbulatoryStatus(this NK1 message, IS item)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AmbulatoryStatus record from NK1
        /// </summary>
        public static void RemoveAmbulatoryStatus(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<IS> GetAllCitizenshipRecords(this NK1 message)
        {
            return message.GetAllRecords<IS>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to NK1
        /// </summary>
        public static IS AddCitizenship(this NK1 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from NK1
        /// </summary>
        public static void RemoveCitizenship(this NK1 message, IS item)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Citizenship record from NK1
        /// </summary>
        public static void RemoveCitizenship(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactReason record from NK1
        /// </summary>
        public static void RemoveContactReason(this NK1 message, CE item)
        {
            int fieldNum = message.FindField("ContactReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactReason record from NK1
        /// </summary>
        public static void RemoveContactReason(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactReason");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactPersonSName record from NK1
        /// </summary>
        public static void RemoveContactPersonSName(this NK1 message, XPN item)
        {
            int fieldNum = message.FindField("ContactPersonSName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactPersonSName record from NK1
        /// </summary>
        public static void RemoveContactPersonSName(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactPersonSName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactPersonSTelephoneNumber record from NK1
        /// </summary>
        public static void RemoveContactPersonSTelephoneNumber(this NK1 message, XTN item)
        {
            int fieldNum = message.FindField("ContactPersonSTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactPersonSTelephoneNumber record from NK1
        /// </summary>
        public static void RemoveContactPersonSTelephoneNumber(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactPersonSTelephoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactPersonSAddress record from NK1
        /// </summary>
        public static void RemoveContactPersonSAddress(this NK1 message, XAD item)
        {
            int fieldNum = message.FindField("ContactPersonSAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactPersonSAddress record from NK1
        /// </summary>
        public static void RemoveContactPersonSAddress(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactPersonSAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get AssociatedPartySIdentifiers Records from NK1
        /// </summary>
        public static IEnumerable GetAssociatedPartySIdentifiersRecords(this NK1 message)
        {
            object[] result = message.GetRecords("AssociatedPartySIdentifiersRepetitionsUsed", "GetAssociatedPartySIdentifiers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AssociatedPartySIdentifiers Records from NK1
        /// </summary>
        public static List<CX> GetAllAssociatedPartySIdentifiersRecords(this NK1 message)
        {
            return message.GetAllRecords<CX>("AssociatedPartySIdentifiersRepetitionsUsed", "GetAssociatedPartySIdentifiers");
        }

        /// <summary>
        /// Add a new AssociatedPartySIdentifiers to NK1
        /// </summary>
        public static CX AddAssociatedPartySIdentifiers(this NK1 message)
        {
            return message.GetAssociatedPartySIdentifiers(message.AssociatedPartySIdentifiersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AssociatedPartySIdentifiers record from NK1
        /// </summary>
        public static void RemoveAssociatedPartySIdentifiers(this NK1 message, CX item)
        {
            int fieldNum = message.FindField("AssociatedPartySIdentifiers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AssociatedPartySIdentifiers record from NK1
        /// </summary>
        public static void RemoveAssociatedPartySIdentifiers(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AssociatedPartySIdentifiers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Comment record from NTE
        /// </summary>
        public static void RemoveComment(this NTE message, FT item)
        {
            int fieldNum = message.FindField("Comment");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Comment record from NTE
        /// </summary>
        public static void RemoveComment(this NTE message, int itemIndex)
        {
            int fieldNum = message.FindField("Comment");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CollectorIdentifier record from OBR
        /// </summary>
        public static void RemoveCollectorIdentifier(this OBR message, XCN item)
        {
            int fieldNum = message.FindField("CollectorIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CollectorIdentifier record from OBR
        /// </summary>
        public static void RemoveCollectorIdentifier(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("CollectorIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderingProvider record from OBR
        /// </summary>
        public static void RemoveOrderingProvider(this OBR message, XCN item)
        {
            int fieldNum = message.FindField("OrderingProvider");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingProvider record from OBR
        /// </summary>
        public static void RemoveOrderingProvider(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingProvider");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderCallbackPhoneNumber record from OBR
        /// </summary>
        public static void RemoveOrderCallbackPhoneNumber(this OBR message, XTN item)
        {
            int fieldNum = message.FindField("OrderCallbackPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderCallbackPhoneNumber record from OBR
        /// </summary>
        public static void RemoveOrderCallbackPhoneNumber(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderCallbackPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ResultCopiesTo record from OBR
        /// </summary>
        public static void RemoveResultCopiesTo(this OBR message, XCN item)
        {
            int fieldNum = message.FindField("ResultCopiesTo");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ResultCopiesTo record from OBR
        /// </summary>
        public static void RemoveResultCopiesTo(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("ResultCopiesTo");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ReasonForStudy record from OBR
        /// </summary>
        public static void RemoveReasonForStudy(this OBR message, CE item)
        {
            int fieldNum = message.FindField("ReasonForStudy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReasonForStudy record from OBR
        /// </summary>
        public static void RemoveReasonForStudy(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("ReasonForStudy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AssistantResultInterpreter record from OBR
        /// </summary>
        public static void RemoveAssistantResultInterpreter(this OBR message, CM_NDL item)
        {
            int fieldNum = message.FindField("AssistantResultInterpreter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AssistantResultInterpreter record from OBR
        /// </summary>
        public static void RemoveAssistantResultInterpreter(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("AssistantResultInterpreter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Technician record from OBR
        /// </summary>
        public static void RemoveTechnician(this OBR message, CM_NDL item)
        {
            int fieldNum = message.FindField("Technician");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Technician record from OBR
        /// </summary>
        public static void RemoveTechnician(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("Technician");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Transcriptionist record from OBR
        /// </summary>
        public static void RemoveTranscriptionist(this OBR message, CM_NDL item)
        {
            int fieldNum = message.FindField("Transcriptionist");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Transcriptionist record from OBR
        /// </summary>
        public static void RemoveTranscriptionist(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("Transcriptionist");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an TransportLogisticsOfCollectedSample record from OBR
        /// </summary>
        public static void RemoveTransportLogisticsOfCollectedSample(this OBR message, CE item)
        {
            int fieldNum = message.FindField("TransportLogisticsOfCollectedSample");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TransportLogisticsOfCollectedSample record from OBR
        /// </summary>
        public static void RemoveTransportLogisticsOfCollectedSample(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("TransportLogisticsOfCollectedSample");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CollectorSComment record from OBR
        /// </summary>
        public static void RemoveCollectorSComment(this OBR message, CE item)
        {
            int fieldNum = message.FindField("CollectorSComment");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CollectorSComment record from OBR
        /// </summary>
        public static void RemoveCollectorSComment(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("CollectorSComment");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PlannedPatientTransportComment record from OBR
        /// </summary>
        public static void RemovePlannedPatientTransportComment(this OBR message, CE item)
        {
            int fieldNum = message.FindField("PlannedPatientTransportComment");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlannedPatientTransportComment record from OBR
        /// </summary>
        public static void RemovePlannedPatientTransportComment(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("PlannedPatientTransportComment");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ObservationValue record from OBX
        /// </summary>
        public static void RemoveObservationValue(this OBX message, Varies item)
        {
            int fieldNum = message.FindField("ObservationValue");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ObservationValue record from OBX
        /// </summary>
        public static void RemoveObservationValue(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("ObservationValue");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AbnormalFlags record from OBX
        /// </summary>
        public static void RemoveAbnormalFlags(this OBX message, ID item)
        {
            int fieldNum = message.FindField("AbnormalFlags");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AbnormalFlags record from OBX
        /// </summary>
        public static void RemoveAbnormalFlags(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("AbnormalFlags");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ObservationMethod record from OBX
        /// </summary>
        public static void RemoveObservationMethod(this OBX message, CE item)
        {
            int fieldNum = message.FindField("ObservationMethod");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ObservationMethod record from OBX
        /// </summary>
        public static void RemoveObservationMethod(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("ObservationMethod");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ServicePeriod record from ODS
        /// </summary>
        public static void RemoveServicePeriod(this ODS message, CE item)
        {
            int fieldNum = message.FindField("ServicePeriod");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ServicePeriod record from ODS
        /// </summary>
        public static void RemoveServicePeriod(this ODS message, int itemIndex)
        {
            int fieldNum = message.FindField("ServicePeriod");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DietSupplementOrPreferenceCode record from ODS
        /// </summary>
        public static void RemoveDietSupplementOrPreferenceCode(this ODS message, CE item)
        {
            int fieldNum = message.FindField("DietSupplementOrPreferenceCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DietSupplementOrPreferenceCode record from ODS
        /// </summary>
        public static void RemoveDietSupplementOrPreferenceCode(this ODS message, int itemIndex)
        {
            int fieldNum = message.FindField("DietSupplementOrPreferenceCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ServicePeriod record from ODT
        /// </summary>
        public static void RemoveServicePeriod(this ODT message, CE item)
        {
            int fieldNum = message.FindField("ServicePeriod");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ServicePeriod record from ODT
        /// </summary>
        public static void RemoveServicePeriod(this ODT message, int itemIndex)
        {
            int fieldNum = message.FindField("ServicePeriod");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PermittedDataTypes record from OM1
        /// </summary>
        public static void RemovePermittedDataTypes(this OM1 message, ID item)
        {
            int fieldNum = message.FindField("PermittedDataTypes");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PermittedDataTypes record from OM1
        /// </summary>
        public static void RemovePermittedDataTypes(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("PermittedDataTypes");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OtherNames record from OM1
        /// </summary>
        public static void RemoveOtherNames(this OM1 message, ST item)
        {
            int fieldNum = message.FindField("OtherNames");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OtherNames record from OM1
        /// </summary>
        public static void RemoveOtherNames(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OtherNames");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get IdentityOfInstrumentUsedToPerfromThisStudy Records from OM1
        /// </summary>
        public static IEnumerable GetIdentityOfInstrumentUsedToPerfromThisStudyRecords(this OM1 message)
        {
            object[] result = message.GetRecords("IdentityOfInstrumentUsedToPerfromThisStudyRepetitionsUsed", "GetIdentityOfInstrumentUsedToPerfromThisStudy");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IdentityOfInstrumentUsedToPerfromThisStudy Records from OM1
        /// </summary>
        public static List<CE> GetAllIdentityOfInstrumentUsedToPerfromThisStudyRecords(this OM1 message)
        {
            return message.GetAllRecords<CE>("IdentityOfInstrumentUsedToPerfromThisStudyRepetitionsUsed", "GetIdentityOfInstrumentUsedToPerfromThisStudy");
        }

        /// <summary>
        /// Add a new IdentityOfInstrumentUsedToPerfromThisStudy to OM1
        /// </summary>
        public static CE AddIdentityOfInstrumentUsedToPerfromThisStudy(this OM1 message)
        {
            return message.GetIdentityOfInstrumentUsedToPerfromThisStudy(message.IdentityOfInstrumentUsedToPerfromThisStudyRepetitionsUsed);
        }

        /// <summary>
        /// Remove an IdentityOfInstrumentUsedToPerfromThisStudy record from OM1
        /// </summary>
        public static void RemoveIdentityOfInstrumentUsedToPerfromThisStudy(this OM1 message, CE item)
        {
            int fieldNum = message.FindField("IdentityOfInstrumentUsedToPerfromThisStudy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an IdentityOfInstrumentUsedToPerfromThisStudy record from OM1
        /// </summary>
        public static void RemoveIdentityOfInstrumentUsedToPerfromThisStudy(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("IdentityOfInstrumentUsedToPerfromThisStudy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ObservationProducingDepartmentSection record from OM1
        /// </summary>
        public static void RemoveObservationProducingDepartmentSection(this OM1 message, CE item)
        {
            int fieldNum = message.FindField("ObservationProducingDepartmentSection");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ObservationProducingDepartmentSection record from OM1
        /// </summary>
        public static void RemoveObservationProducingDepartmentSection(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ObservationProducingDepartmentSection");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProcessingPriority record from OM1
        /// </summary>
        public static void RemoveProcessingPriority(this OM1 message, ID item)
        {
            int fieldNum = message.FindField("ProcessingPriority");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcessingPriority record from OM1
        /// </summary>
        public static void RemoveProcessingPriority(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcessingPriority");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OutsideSiteSWhereObservationMayBePerformed record from OM1
        /// </summary>
        public static void RemoveOutsideSiteSWhereObservationMayBePerformed(this OM1 message, CE item)
        {
            int fieldNum = message.FindField("OutsideSiteSWhereObservationMayBePerformed");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OutsideSiteSWhereObservationMayBePerformed record from OM1
        /// </summary>
        public static void RemoveOutsideSiteSWhereObservationMayBePerformed(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OutsideSiteSWhereObservationMayBePerformed");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ReflexTestsObservations record from OM1
        /// </summary>
        public static void RemoveReflexTestsObservations(this OM1 message, CE item)
        {
            int fieldNum = message.FindField("ReflexTestsObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReflexTestsObservations record from OM1
        /// </summary>
        public static void RemoveReflexTestsObservations(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ReflexTestsObservations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an TestObservationPerformanceSchedule record from OM1
        /// </summary>
        public static void RemoveTestObservationPerformanceSchedule(this OM1 message, ST item)
        {
            int fieldNum = message.FindField("TestObservationPerformanceSchedule");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TestObservationPerformanceSchedule record from OM1
        /// </summary>
        public static void RemoveTestObservationPerformanceSchedule(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("TestObservationPerformanceSchedule");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RangeOfDecimalPrecision record from OM2
        /// </summary>
        public static void RemoveRangeOfDecimalPrecision(this OM2 message, NM item)
        {
            int fieldNum = message.FindField("RangeOfDecimalPrecision");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RangeOfDecimalPrecision record from OM2
        /// </summary>
        public static void RemoveRangeOfDecimalPrecision(this OM2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RangeOfDecimalPrecision");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DeltaCheckCriteria record from OM2
        /// </summary>
        public static void RemoveDeltaCheckCriteria(this OM2 message, CM_DLT item)
        {
            int fieldNum = message.FindField("DeltaCheckCriteria");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DeltaCheckCriteria record from OM2
        /// </summary>
        public static void RemoveDeltaCheckCriteria(this OM2 message, int itemIndex)
        {
            int fieldNum = message.FindField("DeltaCheckCriteria");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an NormalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveNormalTextCodesForCategoricalObservations(this OM3 message, CE item)
        {
            int fieldNum = message.FindField("NormalTextCodesForCategoricalObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NormalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveNormalTextCodesForCategoricalObservations(this OM3 message, int itemIndex)
        {
            int fieldNum = message.FindField("NormalTextCodesForCategoricalObservations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get TestObservationsIncludedWAnOrderedTestBattery Records from OM5
        /// </summary>
        public static IEnumerable GetTestObservationsIncludedWAnOrderedTestBatteryRecords(this OM5 message)
        {
            object[] result = message.GetRecords("TestObservationsIncludedWAnOrderedTestBatteryRepetitionsUsed", "GetTestObservationsIncludedWAnOrderedTestBattery");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TestObservationsIncludedWAnOrderedTestBattery Records from OM5
        /// </summary>
        public static List<CE> GetAllTestObservationsIncludedWAnOrderedTestBatteryRecords(this OM5 message)
        {
            return message.GetAllRecords<CE>("TestObservationsIncludedWAnOrderedTestBatteryRepetitionsUsed", "GetTestObservationsIncludedWAnOrderedTestBattery");
        }

        /// <summary>
        /// Add a new TestObservationsIncludedWAnOrderedTestBattery to OM5
        /// </summary>
        public static CE AddTestObservationsIncludedWAnOrderedTestBattery(this OM5 message)
        {
            return message.GetTestObservationsIncludedWAnOrderedTestBattery(message.TestObservationsIncludedWAnOrderedTestBatteryRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TestObservationsIncludedWAnOrderedTestBattery record from OM5
        /// </summary>
        public static void RemoveTestObservationsIncludedWAnOrderedTestBattery(this OM5 message, CE item)
        {
            int fieldNum = message.FindField("TestObservationsIncludedWAnOrderedTestBattery");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TestObservationsIncludedWAnOrderedTestBattery record from OM5
        /// </summary>
        public static void RemoveTestObservationsIncludedWAnOrderedTestBattery(this OM5 message, int itemIndex)
        {
            int fieldNum = message.FindField("TestObservationsIncludedWAnOrderedTestBattery");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get PlacerOrderNumber Records from ORC
        /// </summary>
        public static IEnumerable GetPlacerOrderNumberRecords(this ORC message)
        {
            object[] result = message.GetRecords("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PlacerOrderNumber Records from ORC
        /// </summary>
        public static List<EI> GetAllPlacerOrderNumberRecords(this ORC message)
        {
            return message.GetAllRecords<EI>("PlacerOrderNumberRepetitionsUsed", "GetPlacerOrderNumber");
        }

        /// <summary>
        /// Add a new PlacerOrderNumber to ORC
        /// </summary>
        public static EI AddPlacerOrderNumber(this ORC message)
        {
            return message.GetPlacerOrderNumber(message.PlacerOrderNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from ORC
        /// </summary>
        public static void RemovePlacerOrderNumber(this ORC message, EI item)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from ORC
        /// </summary>
        public static void RemovePlacerOrderNumber(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderingProvider record from ORC
        /// </summary>
        public static void RemoveOrderingProvider(this ORC message, XCN item)
        {
            int fieldNum = message.FindField("OrderingProvider");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingProvider record from ORC
        /// </summary>
        public static void RemoveOrderingProvider(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingProvider");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CallBackPhoneNumber record from ORC
        /// </summary>
        public static void RemoveCallBackPhoneNumber(this ORC message, TN item)
        {
            int fieldNum = message.FindField("CallBackPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CallBackPhoneNumber record from ORC
        /// </summary>
        public static void RemoveCallBackPhoneNumber(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("CallBackPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProductSerialLotNumber record from PCR
        /// </summary>
        public static void RemoveProductSerialLotNumber(this PCR message, ST item)
        {
            int fieldNum = message.FindField("ProductSerialLotNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProductSerialLotNumber record from PCR
        /// </summary>
        public static void RemoveProductSerialLotNumber(this PCR message, int itemIndex)
        {
            int fieldNum = message.FindField("ProductSerialLotNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ActionTakenInResponseToTheEvent record from PCR
        /// </summary>
        public static void RemoveActionTakenInResponseToTheEvent(this PCR message, ID item)
        {
            int fieldNum = message.FindField("ActionTakenInResponseToTheEvent");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ActionTakenInResponseToTheEvent record from PCR
        /// </summary>
        public static void RemoveActionTakenInResponseToTheEvent(this PCR message, int itemIndex)
        {
            int fieldNum = message.FindField("ActionTakenInResponseToTheEvent");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventCausalityObservations record from PCR
        /// </summary>
        public static void RemoveEventCausalityObservations(this PCR message, ID item)
        {
            int fieldNum = message.FindField("EventCausalityObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventCausalityObservations record from PCR
        /// </summary>
        public static void RemoveEventCausalityObservations(this PCR message, int itemIndex)
        {
            int fieldNum = message.FindField("EventCausalityObservations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an IndirectExposureMechanism record from PCR
        /// </summary>
        public static void RemoveIndirectExposureMechanism(this PCR message, ID item)
        {
            int fieldNum = message.FindField("IndirectExposureMechanism");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an IndirectExposureMechanism record from PCR
        /// </summary>
        public static void RemoveIndirectExposureMechanism(this PCR message, int itemIndex)
        {
            int fieldNum = message.FindField("IndirectExposureMechanism");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LivingDependency record from PD1
        /// </summary>
        public static void RemoveLivingDependency(this PD1 message, IS item)
        {
            int fieldNum = message.FindField("LivingDependency");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LivingDependency record from PD1
        /// </summary>
        public static void RemoveLivingDependency(this PD1 message, int itemIndex)
        {
            int fieldNum = message.FindField("LivingDependency");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PatientPrimaryFacility record from PD1
        /// </summary>
        public static void RemovePatientPrimaryFacility(this PD1 message, XON item)
        {
            int fieldNum = message.FindField("PatientPrimaryFacility");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientPrimaryFacility record from PD1
        /// </summary>
        public static void RemovePatientPrimaryFacility(this PD1 message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientPrimaryFacility");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PatientPrimaryCareProviderNameIDNo record from PD1
        /// </summary>
        public static void RemovePatientPrimaryCareProviderNameIDNo(this PD1 message, XCN item)
        {
            int fieldNum = message.FindField("PatientPrimaryCareProviderNameIDNo");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientPrimaryCareProviderNameIDNo record from PD1
        /// </summary>
        public static void RemovePatientPrimaryCareProviderNameIDNo(this PD1 message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientPrimaryCareProviderNameIDNo");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DuplicatePatient record from PD1
        /// </summary>
        public static void RemoveDuplicatePatient(this PD1 message, CX item)
        {
            int fieldNum = message.FindField("DuplicatePatient");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DuplicatePatient record from PD1
        /// </summary>
        public static void RemoveDuplicatePatient(this PD1 message, int itemIndex)
        {
            int fieldNum = message.FindField("DuplicatePatient");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ModelIdentifier record from PDC
        /// </summary>
        public static void RemoveModelIdentifier(this PDC message, ST item)
        {
            int fieldNum = message.FindField("ModelIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ModelIdentifier record from PDC
        /// </summary>
        public static void RemoveModelIdentifier(this PDC message, int itemIndex)
        {
            int fieldNum = message.FindField("ModelIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OtherIdentifier record from PDC
        /// </summary>
        public static void RemoveOtherIdentifier(this PDC message, ST item)
        {
            int fieldNum = message.FindField("OtherIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OtherIdentifier record from PDC
        /// </summary>
        public static void RemoveOtherIdentifier(this PDC message, int itemIndex)
        {
            int fieldNum = message.FindField("OtherIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventIdentifiersUsed record from PEO
        /// </summary>
        public static void RemoveEventIdentifiersUsed(this PEO message, CE item)
        {
            int fieldNum = message.FindField("EventIdentifiersUsed");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventIdentifiersUsed record from PEO
        /// </summary>
        public static void RemoveEventIdentifiersUsed(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventIdentifiersUsed");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventSymptomDiagnosisCode record from PEO
        /// </summary>
        public static void RemoveEventSymptomDiagnosisCode(this PEO message, CE item)
        {
            int fieldNum = message.FindField("EventSymptomDiagnosisCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventSymptomDiagnosisCode record from PEO
        /// </summary>
        public static void RemoveEventSymptomDiagnosisCode(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventSymptomDiagnosisCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventQualification record from PEO
        /// </summary>
        public static void RemoveEventQualification(this PEO message, ID item)
        {
            int fieldNum = message.FindField("EventQualification");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventQualification record from PEO
        /// </summary>
        public static void RemoveEventQualification(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventQualification");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventOutcome record from PEO
        /// </summary>
        public static void RemoveEventOutcome(this PEO message, ID item)
        {
            int fieldNum = message.FindField("EventOutcome");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventOutcome record from PEO
        /// </summary>
        public static void RemoveEventOutcome(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventOutcome");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventDescriptionFromOthers record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromOthers(this PEO message, FT item)
        {
            int fieldNum = message.FindField("EventDescriptionFromOthers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventDescriptionFromOthers record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromOthers(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventDescriptionFromOthers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventFromOriginalReporter record from PEO
        /// </summary>
        public static void RemoveEventFromOriginalReporter(this PEO message, FT item)
        {
            int fieldNum = message.FindField("EventFromOriginalReporter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventFromOriginalReporter record from PEO
        /// </summary>
        public static void RemoveEventFromOriginalReporter(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventFromOriginalReporter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventDescriptionFromPatient record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromPatient(this PEO message, FT item)
        {
            int fieldNum = message.FindField("EventDescriptionFromPatient");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventDescriptionFromPatient record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromPatient(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventDescriptionFromPatient");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventDescriptionFromPractitioner record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromPractitioner(this PEO message, FT item)
        {
            int fieldNum = message.FindField("EventDescriptionFromPractitioner");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventDescriptionFromPractitioner record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromPractitioner(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventDescriptionFromPractitioner");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventDescriptionFromAutopsy record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromAutopsy(this PEO message, FT item)
        {
            int fieldNum = message.FindField("EventDescriptionFromAutopsy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventDescriptionFromAutopsy record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromAutopsy(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventDescriptionFromAutopsy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CauseOfDeath record from PEO
        /// </summary>
        public static void RemoveCauseOfDeath(this PEO message, CE item)
        {
            int fieldNum = message.FindField("CauseOfDeath");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CauseOfDeath record from PEO
        /// </summary>
        public static void RemoveCauseOfDeath(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("CauseOfDeath");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryObserverAddress record from PEO
        /// </summary>
        public static void RemovePrimaryObserverAddress(this PEO message, XAD item)
        {
            int fieldNum = message.FindField("PrimaryObserverAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryObserverAddress record from PEO
        /// </summary>
        public static void RemovePrimaryObserverAddress(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryObserverAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryObserverTelephone record from PEO
        /// </summary>
        public static void RemovePrimaryObserverTelephone(this PEO message, XTN item)
        {
            int fieldNum = message.FindField("PrimaryObserverTelephone");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryObserverTelephone record from PEO
        /// </summary>
        public static void RemovePrimaryObserverTelephone(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryObserverTelephone");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SenderIndividualName record from PES
        /// </summary>
        public static void RemoveSenderIndividualName(this PES message, XCN item)
        {
            int fieldNum = message.FindField("SenderIndividualName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SenderIndividualName record from PES
        /// </summary>
        public static void RemoveSenderIndividualName(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("SenderIndividualName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SenderAddress record from PES
        /// </summary>
        public static void RemoveSenderAddress(this PES message, XAD item)
        {
            int fieldNum = message.FindField("SenderAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SenderAddress record from PES
        /// </summary>
        public static void RemoveSenderAddress(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("SenderAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SenderTelephone record from PES
        /// </summary>
        public static void RemoveSenderTelephone(this PES message, XTN item)
        {
            int fieldNum = message.FindField("SenderTelephone");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SenderTelephone record from PES
        /// </summary>
        public static void RemoveSenderTelephone(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("SenderTelephone");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SenderEventDescription record from PES
        /// </summary>
        public static void RemoveSenderEventDescription(this PES message, FT item)
        {
            int fieldNum = message.FindField("SenderEventDescription");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SenderEventDescription record from PES
        /// </summary>
        public static void RemoveSenderEventDescription(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("SenderEventDescription");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventReportTimingType record from PES
        /// </summary>
        public static void RemoveEventReportTimingType(this PES message, ID item)
        {
            int fieldNum = message.FindField("EventReportTimingType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventReportTimingType record from PES
        /// </summary>
        public static void RemoveEventReportTimingType(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("EventReportTimingType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EventReportedTo record from PES
        /// </summary>
        public static void RemoveEventReportedTo(this PES message, ID item)
        {
            int fieldNum = message.FindField("EventReportedTo");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventReportedTo record from PES
        /// </summary>
        public static void RemoveEventReportedTo(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("EventReportedTo");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CX> GetAllPatientIDInternalIDRecords(this PID message)
        {
            return message.GetAllRecords<CX>("PatientIDInternalIDRepetitionsUsed", "GetPatientIDInternalID");
        }

        /// <summary>
        /// Add a new PatientIDInternalID to PID
        /// </summary>
        public static CX AddPatientIDInternalID(this PID message)
        {
            return message.GetPatientIDInternalID(message.PatientIDInternalIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PatientIDInternalID record from PID
        /// </summary>
        public static void RemovePatientIDInternalID(this PID message, CX item)
        {
            int fieldNum = message.FindField("PatientIDInternalID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientIDInternalID record from PID
        /// </summary>
        public static void RemovePatientIDInternalID(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientIDInternalID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get AlternatePatientID Records from PID
        /// </summary>
        public static IEnumerable GetAlternatePatientIDRecords(this PID message)
        {
            object[] result = message.GetRecords("AlternatePatientIDRepetitionsUsed", "GetAlternatePatientID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AlternatePatientID Records from PID
        /// </summary>
        public static List<CX> GetAllAlternatePatientIDRecords(this PID message)
        {
            return message.GetAllRecords<CX>("AlternatePatientIDRepetitionsUsed", "GetAlternatePatientID");
        }

        /// <summary>
        /// Add a new AlternatePatientID to PID
        /// </summary>
        public static CX AddAlternatePatientID(this PID message)
        {
            return message.GetAlternatePatientID(message.AlternatePatientIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AlternatePatientID record from PID
        /// </summary>
        public static void RemoveAlternatePatientID(this PID message, CX item)
        {
            int fieldNum = message.FindField("AlternatePatientID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AlternatePatientID record from PID
        /// </summary>
        public static void RemoveAlternatePatientID(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("AlternatePatientID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PatientName record from PID
        /// </summary>
        public static void RemovePatientName(this PID message, XPN item)
        {
            int fieldNum = message.FindField("PatientName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientName record from PID
        /// </summary>
        public static void RemovePatientName(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PatientAlias record from PID
        /// </summary>
        public static void RemovePatientAlias(this PID message, XPN item)
        {
            int fieldNum = message.FindField("PatientAlias");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientAlias record from PID
        /// </summary>
        public static void RemovePatientAlias(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientAlias");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PatientAddress record from PID
        /// </summary>
        public static void RemovePatientAddress(this PID message, XAD item)
        {
            int fieldNum = message.FindField("PatientAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientAddress record from PID
        /// </summary>
        public static void RemovePatientAddress(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PhoneNumberHome record from PID
        /// </summary>
        public static void RemovePhoneNumberHome(this PID message, XTN item)
        {
            int fieldNum = message.FindField("PhoneNumberHome");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PhoneNumberHome record from PID
        /// </summary>
        public static void RemovePhoneNumberHome(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PhoneNumberHome");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PhoneNumberBusiness record from PID
        /// </summary>
        public static void RemovePhoneNumberBusiness(this PID message, XTN item)
        {
            int fieldNum = message.FindField("PhoneNumberBusiness");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PhoneNumberBusiness record from PID
        /// </summary>
        public static void RemovePhoneNumberBusiness(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PhoneNumberBusiness");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an MotherSIdentifier record from PID
        /// </summary>
        public static void RemoveMotherSIdentifier(this PID message, CX item)
        {
            int fieldNum = message.FindField("MotherSIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MotherSIdentifier record from PID
        /// </summary>
        public static void RemoveMotherSIdentifier(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("MotherSIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<IS> GetAllCitizenshipRecords(this PID message)
        {
            return message.GetAllRecords<IS>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to PID
        /// </summary>
        public static IS AddCitizenship(this PID message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from PID
        /// </summary>
        public static void RemoveCitizenship(this PID message, IS item)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Citizenship record from PID
        /// </summary>
        public static void RemoveCitizenship(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Anesthesiologist record from PR1
        /// </summary>
        public static void RemoveAnesthesiologist(this PR1 message, XCN item)
        {
            int fieldNum = message.FindField("Anesthesiologist");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Anesthesiologist record from PR1
        /// </summary>
        public static void RemoveAnesthesiologist(this PR1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Anesthesiologist");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Surgeon record from PR1
        /// </summary>
        public static void RemoveSurgeon(this PR1 message, XCN item)
        {
            int fieldNum = message.FindField("Surgeon");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Surgeon record from PR1
        /// </summary>
        public static void RemoveSurgeon(this PR1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Surgeon");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProcedurePractitioner record from PR1
        /// </summary>
        public static void RemoveProcedurePractitioner(this PR1 message, XCN item)
        {
            int fieldNum = message.FindField("ProcedurePractitioner");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedurePractitioner record from PR1
        /// </summary>
        public static void RemoveProcedurePractitioner(this PR1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedurePractitioner");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get PractionerGroup Records from PRA
        /// </summary>
        public static IEnumerable GetPractionerGroupRecords(this PRA message)
        {
            object[] result = message.GetRecords("PractionerGroupRepetitionsUsed", "GetPractionerGroup");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PractionerGroup Records from PRA
        /// </summary>
        public static List<CE> GetAllPractionerGroupRecords(this PRA message)
        {
            return message.GetAllRecords<CE>("PractionerGroupRepetitionsUsed", "GetPractionerGroup");
        }

        /// <summary>
        /// Add a new PractionerGroup to PRA
        /// </summary>
        public static CE AddPractionerGroup(this PRA message)
        {
            return message.GetPractionerGroup(message.PractionerGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PractionerGroup record from PRA
        /// </summary>
        public static void RemovePractionerGroup(this PRA message, CE item)
        {
            int fieldNum = message.FindField("PractionerGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PractionerGroup record from PRA
        /// </summary>
        public static void RemovePractionerGroup(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("PractionerGroup");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get PractionerCategory Records from PRA
        /// </summary>
        public static IEnumerable GetPractionerCategoryRecords(this PRA message)
        {
            object[] result = message.GetRecords("PractionerCategoryRepetitionsUsed", "GetPractionerCategory");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PractionerCategory Records from PRA
        /// </summary>
        public static List<ID> GetAllPractionerCategoryRecords(this PRA message)
        {
            return message.GetAllRecords<ID>("PractionerCategoryRepetitionsUsed", "GetPractionerCategory");
        }

        /// <summary>
        /// Add a new PractionerCategory to PRA
        /// </summary>
        public static ID AddPractionerCategory(this PRA message)
        {
            return message.GetPractionerCategory(message.PractionerCategoryRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PractionerCategory record from PRA
        /// </summary>
        public static void RemovePractionerCategory(this PRA message, ID item)
        {
            int fieldNum = message.FindField("PractionerCategory");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PractionerCategory record from PRA
        /// </summary>
        public static void RemovePractionerCategory(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("PractionerCategory");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Specialty record from PRA
        /// </summary>
        public static void RemoveSpecialty(this PRA message, CM_SPD item)
        {
            int fieldNum = message.FindField("Specialty");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Specialty record from PRA
        /// </summary>
        public static void RemoveSpecialty(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("Specialty");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PractitionerIDNumbers record from PRA
        /// </summary>
        public static void RemovePractitionerIDNumbers(this PRA message, CM_PLN item)
        {
            int fieldNum = message.FindField("PractitionerIDNumbers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PractitionerIDNumbers record from PRA
        /// </summary>
        public static void RemovePractitionerIDNumbers(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("PractitionerIDNumbers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Privileges record from PRA
        /// </summary>
        public static void RemovePrivileges(this PRA message, CM_PIP item)
        {
            int fieldNum = message.FindField("Privileges");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Privileges record from PRA
        /// </summary>
        public static void RemovePrivileges(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("Privileges");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProblemManagementDiscipline record from PRB
        /// </summary>
        public static void RemoveProblemManagementDiscipline(this PRB message, CE item)
        {
            int fieldNum = message.FindField("ProblemManagementDiscipline");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProblemManagementDiscipline record from PRB
        /// </summary>
        public static void RemoveProblemManagementDiscipline(this PRB message, int itemIndex)
        {
            int fieldNum = message.FindField("ProblemManagementDiscipline");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get FacilityID Records from PRC
        /// </summary>
        public static IEnumerable GetFacilityIDRecords(this PRC message)
        {
            object[] result = message.GetRecords("FacilityIDRepetitionsUsed", "GetFacilityID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FacilityID Records from PRC
        /// </summary>
        public static List<EI> GetAllFacilityIDRecords(this PRC message)
        {
            return message.GetAllRecords<EI>("FacilityIDRepetitionsUsed", "GetFacilityID");
        }

        /// <summary>
        /// Add a new FacilityID to PRC
        /// </summary>
        public static EI AddFacilityID(this PRC message)
        {
            return message.GetFacilityID(message.FacilityIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FacilityID record from PRC
        /// </summary>
        public static void RemoveFacilityID(this PRC message, EI item)
        {
            int fieldNum = message.FindField("FacilityID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FacilityID record from PRC
        /// </summary>
        public static void RemoveFacilityID(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("FacilityID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Department record from PRC
        /// </summary>
        public static void RemoveDepartment(this PRC message, CE item)
        {
            int fieldNum = message.FindField("Department");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Department record from PRC
        /// </summary>
        public static void RemoveDepartment(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("Department");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<ID> GetAllValidPatientClassesRecords(this PRC message)
        {
            return message.GetAllRecords<ID>("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");
        }

        /// <summary>
        /// Add a new ValidPatientClasses to PRC
        /// </summary>
        public static ID AddValidPatientClasses(this PRC message)
        {
            return message.GetValidPatientClasses(message.ValidPatientClassesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ValidPatientClasses record from PRC
        /// </summary>
        public static void RemoveValidPatientClasses(this PRC message, ID item)
        {
            int fieldNum = message.FindField("ValidPatientClasses");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ValidPatientClasses record from PRC
        /// </summary>
        public static void RemoveValidPatientClasses(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("ValidPatientClasses");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Price record from PRC
        /// </summary>
        public static void RemovePrice(this PRC message, CP item)
        {
            int fieldNum = message.FindField("Price");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Price record from PRC
        /// </summary>
        public static void RemovePrice(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("Price");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Formula record from PRC
        /// </summary>
        public static void RemoveFormula(this PRC message, ST item)
        {
            int fieldNum = message.FindField("Formula");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Formula record from PRC
        /// </summary>
        public static void RemoveFormula(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("Formula");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an BillingCategory record from PRC
        /// </summary>
        public static void RemoveBillingCategory(this PRC message, CE item)
        {
            int fieldNum = message.FindField("BillingCategory");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BillingCategory record from PRC
        /// </summary>
        public static void RemoveBillingCategory(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("BillingCategory");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get Role Records from PRD
        /// </summary>
        public static IEnumerable GetRoleRecords(this PRD message)
        {
            object[] result = message.GetRecords("RoleRepetitionsUsed", "GetRole");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Role Records from PRD
        /// </summary>
        public static List<CE> GetAllRoleRecords(this PRD message)
        {
            return message.GetAllRecords<CE>("RoleRepetitionsUsed", "GetRole");
        }

        /// <summary>
        /// Add a new Role to PRD
        /// </summary>
        public static CE AddRole(this PRD message)
        {
            return message.GetRole(message.RoleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Role record from PRD
        /// </summary>
        public static void RemoveRole(this PRD message, CE item)
        {
            int fieldNum = message.FindField("Role");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Role record from PRD
        /// </summary>
        public static void RemoveRole(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("Role");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProviderName record from PRD
        /// </summary>
        public static void RemoveProviderName(this PRD message, XPN item)
        {
            int fieldNum = message.FindField("ProviderName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderName record from PRD
        /// </summary>
        public static void RemoveProviderName(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProviderCommunicationInformation record from PRD
        /// </summary>
        public static void RemoveProviderCommunicationInformation(this PRD message, XTN item)
        {
            int fieldNum = message.FindField("ProviderCommunicationInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderCommunicationInformation record from PRD
        /// </summary>
        public static void RemoveProviderCommunicationInformation(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderCommunicationInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CM_PI> GetAllProviderIdentifiersRecords(this PRD message)
        {
            return message.GetAllRecords<CM_PI>("ProviderIdentifiersRepetitionsUsed", "GetProviderIdentifiers");
        }

        /// <summary>
        /// Add a new ProviderIdentifiers to PRD
        /// </summary>
        public static CM_PI AddProviderIdentifiers(this PRD message)
        {
            return message.GetProviderIdentifiers(message.ProviderIdentifiersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderIdentifiers record from PRD
        /// </summary>
        public static void RemoveProviderIdentifiers(this PRD message, CM_PI item)
        {
            int fieldNum = message.FindField("ProviderIdentifiers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderIdentifiers record from PRD
        /// </summary>
        public static void RemoveProviderIdentifiers(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderIdentifiers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an NumberOfProductExperienceReportsFiledByFacility record from PSH
        /// </summary>
        public static void RemoveNumberOfProductExperienceReportsFiledByFacility(this PSH message, NM item)
        {
            int fieldNum = message.FindField("NumberOfProductExperienceReportsFiledByFacility");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NumberOfProductExperienceReportsFiledByFacility record from PSH
        /// </summary>
        public static void RemoveNumberOfProductExperienceReportsFiledByFacility(this PSH message, int itemIndex)
        {
            int fieldNum = message.FindField("NumberOfProductExperienceReportsFiledByFacility");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an NumberOfProductExperienceReportsFiledByDistributor record from PSH
        /// </summary>
        public static void RemoveNumberOfProductExperienceReportsFiledByDistributor(this PSH message, NM item)
        {
            int fieldNum = message.FindField("NumberOfProductExperienceReportsFiledByDistributor");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NumberOfProductExperienceReportsFiledByDistributor record from PSH
        /// </summary>
        public static void RemoveNumberOfProductExperienceReportsFiledByDistributor(this PSH message, int itemIndex)
        {
            int fieldNum = message.FindField("NumberOfProductExperienceReportsFiledByDistributor");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AttendingDoctor record from PV1
        /// </summary>
        public static void RemoveAttendingDoctor(this PV1 message, XCN item)
        {
            int fieldNum = message.FindField("AttendingDoctor");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AttendingDoctor record from PV1
        /// </summary>
        public static void RemoveAttendingDoctor(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AttendingDoctor");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ReferringDoctor record from PV1
        /// </summary>
        public static void RemoveReferringDoctor(this PV1 message, XCN item)
        {
            int fieldNum = message.FindField("ReferringDoctor");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReferringDoctor record from PV1
        /// </summary>
        public static void RemoveReferringDoctor(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ReferringDoctor");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ConsultingDoctor record from PV1
        /// </summary>
        public static void RemoveConsultingDoctor(this PV1 message, XCN item)
        {
            int fieldNum = message.FindField("ConsultingDoctor");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConsultingDoctor record from PV1
        /// </summary>
        public static void RemoveConsultingDoctor(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ConsultingDoctor");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AmbulatoryStatus record from PV1
        /// </summary>
        public static void RemoveAmbulatoryStatus(this PV1 message, IS item)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AmbulatoryStatus record from PV1
        /// </summary>
        public static void RemoveAmbulatoryStatus(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AdmittingDoctor record from PV1
        /// </summary>
        public static void RemoveAdmittingDoctor(this PV1 message, XCN item)
        {
            int fieldNum = message.FindField("AdmittingDoctor");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AdmittingDoctor record from PV1
        /// </summary>
        public static void RemoveAdmittingDoctor(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AdmittingDoctor");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an FinancialClass record from PV1
        /// </summary>
        public static void RemoveFinancialClass(this PV1 message, FC item)
        {
            int fieldNum = message.FindField("FinancialClass");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FinancialClass record from PV1
        /// </summary>
        public static void RemoveFinancialClass(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("FinancialClass");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContractCode record from PV1
        /// </summary>
        public static void RemoveContractCode(this PV1 message, ID item)
        {
            int fieldNum = message.FindField("ContractCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContractCode record from PV1
        /// </summary>
        public static void RemoveContractCode(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContractCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContractEffectiveDate record from PV1
        /// </summary>
        public static void RemoveContractEffectiveDate(this PV1 message, DT item)
        {
            int fieldNum = message.FindField("ContractEffectiveDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContractEffectiveDate record from PV1
        /// </summary>
        public static void RemoveContractEffectiveDate(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContractEffectiveDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContractAmount record from PV1
        /// </summary>
        public static void RemoveContractAmount(this PV1 message, NM item)
        {
            int fieldNum = message.FindField("ContractAmount");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContractAmount record from PV1
        /// </summary>
        public static void RemoveContractAmount(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContractAmount");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContractPeriod record from PV1
        /// </summary>
        public static void RemoveContractPeriod(this PV1 message, NM item)
        {
            int fieldNum = message.FindField("ContractPeriod");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContractPeriod record from PV1
        /// </summary>
        public static void RemoveContractPeriod(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContractPeriod");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OtherHealthcareProvider record from PV1
        /// </summary>
        public static void RemoveOtherHealthcareProvider(this PV1 message, XCN item)
        {
            int fieldNum = message.FindField("OtherHealthcareProvider");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OtherHealthcareProvider record from PV1
        /// </summary>
        public static void RemoveOtherHealthcareProvider(this PV1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OtherHealthcareProvider");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PatientValuables record from PV2
        /// </summary>
        public static void RemovePatientValuables(this PV2 message, ST item)
        {
            int fieldNum = message.FindField("PatientValuables");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientValuables record from PV2
        /// </summary>
        public static void RemovePatientValuables(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientValuables");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ClinicOrganizationName record from PV2
        /// </summary>
        public static void RemoveClinicOrganizationName(this PV2 message, XON item)
        {
            int fieldNum = message.FindField("ClinicOrganizationName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ClinicOrganizationName record from PV2
        /// </summary>
        public static void RemoveClinicOrganizationName(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ClinicOrganizationName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhoSubjectFilter record from QRD
        /// </summary>
        public static void RemoveWhoSubjectFilter(this QRD message, XCN item)
        {
            int fieldNum = message.FindField("WhoSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhoSubjectFilter record from QRD
        /// </summary>
        public static void RemoveWhoSubjectFilter(this QRD message, int itemIndex)
        {
            int fieldNum = message.FindField("WhoSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhatSubjectFilter record from QRD
        /// </summary>
        public static void RemoveWhatSubjectFilter(this QRD message, CE item)
        {
            int fieldNum = message.FindField("WhatSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhatSubjectFilter record from QRD
        /// </summary>
        public static void RemoveWhatSubjectFilter(this QRD message, int itemIndex)
        {
            int fieldNum = message.FindField("WhatSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhatDepartmentDataCode record from QRD
        /// </summary>
        public static void RemoveWhatDepartmentDataCode(this QRD message, CE item)
        {
            int fieldNum = message.FindField("WhatDepartmentDataCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhatDepartmentDataCode record from QRD
        /// </summary>
        public static void RemoveWhatDepartmentDataCode(this QRD message, int itemIndex)
        {
            int fieldNum = message.FindField("WhatDepartmentDataCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhatDataCodeValueQualifier record from QRD
        /// </summary>
        public static void RemoveWhatDataCodeValueQualifier(this QRD message, CM_VR item)
        {
            int fieldNum = message.FindField("WhatDataCodeValueQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhatDataCodeValueQualifier record from QRD
        /// </summary>
        public static void RemoveWhatDataCodeValueQualifier(this QRD message, int itemIndex)
        {
            int fieldNum = message.FindField("WhatDataCodeValueQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhereSubjectFilter record from QRF
        /// </summary>
        public static void RemoveWhereSubjectFilter(this QRF message, ST item)
        {
            int fieldNum = message.FindField("WhereSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhereSubjectFilter record from QRF
        /// </summary>
        public static void RemoveWhereSubjectFilter(this QRF message, int itemIndex)
        {
            int fieldNum = message.FindField("WhereSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhatUserQualifier record from QRF
        /// </summary>
        public static void RemoveWhatUserQualifier(this QRF message, ST item)
        {
            int fieldNum = message.FindField("WhatUserQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhatUserQualifier record from QRF
        /// </summary>
        public static void RemoveWhatUserQualifier(this QRF message, int itemIndex)
        {
            int fieldNum = message.FindField("WhatUserQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OtherQRYSubjectFilter record from QRF
        /// </summary>
        public static void RemoveOtherQRYSubjectFilter(this QRF message, ST item)
        {
            int fieldNum = message.FindField("OtherQRYSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OtherQRYSubjectFilter record from QRF
        /// </summary>
        public static void RemoveOtherQRYSubjectFilter(this QRF message, int itemIndex)
        {
            int fieldNum = message.FindField("OtherQRYSubjectFilter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhichDateTimeQualifier record from QRF
        /// </summary>
        public static void RemoveWhichDateTimeQualifier(this QRF message, ID item)
        {
            int fieldNum = message.FindField("WhichDateTimeQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhichDateTimeQualifier record from QRF
        /// </summary>
        public static void RemoveWhichDateTimeQualifier(this QRF message, int itemIndex)
        {
            int fieldNum = message.FindField("WhichDateTimeQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an WhichDateTimeStatusQualifier record from QRF
        /// </summary>
        public static void RemoveWhichDateTimeStatusQualifier(this QRF message, ID item)
        {
            int fieldNum = message.FindField("WhichDateTimeStatusQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhichDateTimeStatusQualifier record from QRF
        /// </summary>
        public static void RemoveWhichDateTimeStatusQualifier(this QRF message, int itemIndex)
        {
            int fieldNum = message.FindField("WhichDateTimeStatusQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DateTimeSelectionQualifier record from QRF
        /// </summary>
        public static void RemoveDateTimeSelectionQualifier(this QRF message, ID item)
        {
            int fieldNum = message.FindField("DateTimeSelectionQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DateTimeSelectionQualifier record from QRF
        /// </summary>
        public static void RemoveDateTimeSelectionQualifier(this QRF message, int itemIndex)
        {
            int fieldNum = message.FindField("DateTimeSelectionQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ColumnDescription record from RDF
        /// </summary>
        public static void RemoveColumnDescription(this RDF message, RCD item)
        {
            int fieldNum = message.FindField("ColumnDescription");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ColumnDescription record from RDF
        /// </summary>
        public static void RemoveColumnDescription(this RDF message, int itemIndex)
        {
            int fieldNum = message.FindField("ColumnDescription");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ReferralDisposition record from RF1
        /// </summary>
        public static void RemoveReferralDisposition(this RF1 message, CE item)
        {
            int fieldNum = message.FindField("ReferralDisposition");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReferralDisposition record from RF1
        /// </summary>
        public static void RemoveReferralDisposition(this RF1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ReferralDisposition");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ReferralReason record from RF1
        /// </summary>
        public static void RemoveReferralReason(this RF1 message, CE item)
        {
            int fieldNum = message.FindField("ReferralReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReferralReason record from RF1
        /// </summary>
        public static void RemoveReferralReason(this RF1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ReferralReason");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ExternalReferralIdentifier record from RF1
        /// </summary>
        public static void RemoveExternalReferralIdentifier(this RF1 message, EI item)
        {
            int fieldNum = message.FindField("ExternalReferralIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ExternalReferralIdentifier record from RF1
        /// </summary>
        public static void RemoveExternalReferralIdentifier(this RF1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ExternalReferralIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AdministrationNotes record from RXA
        /// </summary>
        public static void RemoveAdministrationNotes(this RXA message, CE item)
        {
            int fieldNum = message.FindField("AdministrationNotes");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AdministrationNotes record from RXA
        /// </summary>
        public static void RemoveAdministrationNotes(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("AdministrationNotes");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceLotNumber record from RXA
        /// </summary>
        public static void RemoveSubstanceLotNumber(this RXA message, ST item)
        {
            int fieldNum = message.FindField("SubstanceLotNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceLotNumber record from RXA
        /// </summary>
        public static void RemoveSubstanceLotNumber(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceLotNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceExpirationDate record from RXA
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXA message, TS item)
        {
            int fieldNum = message.FindField("SubstanceExpirationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceExpirationDate record from RXA
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceExpirationDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceManufacturerName record from RXA
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXA message, CE item)
        {
            int fieldNum = message.FindField("SubstanceManufacturerName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceManufacturerName record from RXA
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceManufacturerName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceRefusalReason record from RXA
        /// </summary>
        public static void RemoveSubstanceRefusalReason(this RXA message, CE item)
        {
            int fieldNum = message.FindField("SubstanceRefusalReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceRefusalReason record from RXA
        /// </summary>
        public static void RemoveSubstanceRefusalReason(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceRefusalReason");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Indication record from RXA
        /// </summary>
        public static void RemoveIndication(this RXA message, CE item)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Indication record from RXA
        /// </summary>
        public static void RemoveIndication(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CE> GetAllDispenseNotesRecords(this RXD message)
        {
            return message.GetAllRecords<CE>("DispenseNotesRepetitionsUsed", "GetDispenseNotes");
        }

        /// <summary>
        /// Add a new DispenseNotes to RXD
        /// </summary>
        public static CE AddDispenseNotes(this RXD message)
        {
            return message.GetDispenseNotes(message.DispenseNotesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an DispenseNotes record from RXD
        /// </summary>
        public static void RemoveDispenseNotes(this RXD message, CE item)
        {
            int fieldNum = message.FindField("DispenseNotes");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DispenseNotes record from RXD
        /// </summary>
        public static void RemoveDispenseNotes(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("DispenseNotes");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PharmacyTreatmentSupplierSSpecialDispensingInstructions record from RXD
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXD message, CE item)
        {
            int fieldNum = message.FindField("PharmacyTreatmentSupplierSSpecialDispensingInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PharmacyTreatmentSupplierSSpecialDispensingInstructions record from RXD
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("PharmacyTreatmentSupplierSSpecialDispensingInstructions");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceLotNumber record from RXD
        /// </summary>
        public static void RemoveSubstanceLotNumber(this RXD message, ST item)
        {
            int fieldNum = message.FindField("SubstanceLotNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceLotNumber record from RXD
        /// </summary>
        public static void RemoveSubstanceLotNumber(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceLotNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceExpirationDate record from RXD
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXD message, TS item)
        {
            int fieldNum = message.FindField("SubstanceExpirationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceExpirationDate record from RXD
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceExpirationDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceManufacturerName record from RXD
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXD message, CE item)
        {
            int fieldNum = message.FindField("SubstanceManufacturerName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceManufacturerName record from RXD
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceManufacturerName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProviderSAdministrationInstructions record from RXE
        /// </summary>
        public static void RemoveProviderSAdministrationInstructions(this RXE message, CE item)
        {
            int fieldNum = message.FindField("ProviderSAdministrationInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderSAdministrationInstructions record from RXE
        /// </summary>
        public static void RemoveProviderSAdministrationInstructions(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderSAdministrationInstructions");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PharmacyTreatmentSupplierSSpecialDispensingInstructions record from RXE
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXE message, CE item)
        {
            int fieldNum = message.FindField("PharmacyTreatmentSupplierSSpecialDispensingInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PharmacyTreatmentSupplierSSpecialDispensingInstructions record from RXE
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("PharmacyTreatmentSupplierSSpecialDispensingInstructions");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AdministrationNotes record from RXG
        /// </summary>
        public static void RemoveAdministrationNotes(this RXG message, CE item)
        {
            int fieldNum = message.FindField("AdministrationNotes");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AdministrationNotes record from RXG
        /// </summary>
        public static void RemoveAdministrationNotes(this RXG message, int itemIndex)
        {
            int fieldNum = message.FindField("AdministrationNotes");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceLotNumber record from RXG
        /// </summary>
        public static void RemoveSubstanceLotNumber(this RXG message, ST item)
        {
            int fieldNum = message.FindField("SubstanceLotNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceLotNumber record from RXG
        /// </summary>
        public static void RemoveSubstanceLotNumber(this RXG message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceLotNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceExpirationDate record from RXG
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXG message, TS item)
        {
            int fieldNum = message.FindField("SubstanceExpirationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceExpirationDate record from RXG
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXG message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceExpirationDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SubstanceManufacturerName record from RXG
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXG message, CE item)
        {
            int fieldNum = message.FindField("SubstanceManufacturerName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceManufacturerName record from RXG
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXG message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceManufacturerName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProviderSPharmacyInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSPharmacyInstructions(this RXO message, CE item)
        {
            int fieldNum = message.FindField("ProviderSPharmacyInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderSPharmacyInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSPharmacyInstructions(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderSPharmacyInstructions");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ProviderSAdministrationInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSAdministrationInstructions(this RXO message, CE item)
        {
            int fieldNum = message.FindField("ProviderSAdministrationInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderSAdministrationInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSAdministrationInstructions(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderSAdministrationInstructions");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AppointmentTimingQuantity record from SCH
        /// </summary>
        public static void RemoveAppointmentTimingQuantity(this SCH message, TQ item)
        {
            int fieldNum = message.FindField("AppointmentTimingQuantity");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AppointmentTimingQuantity record from SCH
        /// </summary>
        public static void RemoveAppointmentTimingQuantity(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("AppointmentTimingQuantity");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EnteredByPhoneNumber record from SCH
        /// </summary>
        public static void RemoveEnteredByPhoneNumber(this SCH message, XTN item)
        {
            int fieldNum = message.FindField("EnteredByPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EnteredByPhoneNumber record from SCH
        /// </summary>
        public static void RemoveEnteredByPhoneNumber(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("EnteredByPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InputParameterList record from SPR
        /// </summary>
        public static void RemoveInputParameterList(this SPR message, QIP item)
        {
            int fieldNum = message.FindField("InputParameterList");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InputParameterList record from SPR
        /// </summary>
        public static void RemoveInputParameterList(this SPR message, int itemIndex)
        {
            int fieldNum = message.FindField("InputParameterList");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StaffIDCode record from STF
        /// </summary>
        public static void RemoveStaffIDCode(this STF message, CE item)
        {
            int fieldNum = message.FindField("StaffIDCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StaffIDCode record from STF
        /// </summary>
        public static void RemoveStaffIDCode(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("StaffIDCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StaffType record from STF
        /// </summary>
        public static void RemoveStaffType(this STF message, ID item)
        {
            int fieldNum = message.FindField("StaffType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StaffType record from STF
        /// </summary>
        public static void RemoveStaffType(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("StaffType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Department record from STF
        /// </summary>
        public static void RemoveDepartment(this STF message, CE item)
        {
            int fieldNum = message.FindField("Department");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Department record from STF
        /// </summary>
        public static void RemoveDepartment(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("Department");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Service record from STF
        /// </summary>
        public static void RemoveService(this STF message, CE item)
        {
            int fieldNum = message.FindField("Service");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Service record from STF
        /// </summary>
        public static void RemoveService(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("Service");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Phone record from STF
        /// </summary>
        public static void RemovePhone(this STF message, TN item)
        {
            int fieldNum = message.FindField("Phone");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Phone record from STF
        /// </summary>
        public static void RemovePhone(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("Phone");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OfficeHomeAddress record from STF
        /// </summary>
        public static void RemoveOfficeHomeAddress(this STF message, AD item)
        {
            int fieldNum = message.FindField("OfficeHomeAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OfficeHomeAddress record from STF
        /// </summary>
        public static void RemoveOfficeHomeAddress(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("OfficeHomeAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ActivationDate record from STF
        /// </summary>
        public static void RemoveActivationDate(this STF message, CM_DIN item)
        {
            int fieldNum = message.FindField("ActivationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ActivationDate record from STF
        /// </summary>
        public static void RemoveActivationDate(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("ActivationDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InactivationDate record from STF
        /// </summary>
        public static void RemoveInactivationDate(this STF message, CM_DIN item)
        {
            int fieldNum = message.FindField("InactivationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InactivationDate record from STF
        /// </summary>
        public static void RemoveInactivationDate(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("InactivationDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an BackupPersonID record from STF
        /// </summary>
        public static void RemoveBackupPersonID(this STF message, CE item)
        {
            int fieldNum = message.FindField("BackupPersonID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BackupPersonID record from STF
        /// </summary>
        public static void RemoveBackupPersonID(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("BackupPersonID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EMailAddress record from STF
        /// </summary>
        public static void RemoveEMailAddress(this STF message, ST item)
        {
            int fieldNum = message.FindField("EMailAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EMailAddress record from STF
        /// </summary>
        public static void RemoveEMailAddress(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("EMailAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get MaritalStatus Records from STF
        /// </summary>
        public static IEnumerable GetMaritalStatusRecords(this STF message)
        {
            object[] result = message.GetRecords("MaritalStatusRepetitionsUsed", "GetMaritalStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MaritalStatus Records from STF
        /// </summary>
        public static List<IS> GetAllMaritalStatusRecords(this STF message)
        {
            return message.GetAllRecords<IS>("MaritalStatusRepetitionsUsed", "GetMaritalStatus");
        }

        /// <summary>
        /// Add a new MaritalStatus to STF
        /// </summary>
        public static IS AddMaritalStatus(this STF message)
        {
            return message.GetMaritalStatus(message.MaritalStatusRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MaritalStatus record from STF
        /// </summary>
        public static void RemoveMaritalStatus(this STF message, IS item)
        {
            int fieldNum = message.FindField("MaritalStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MaritalStatus record from STF
        /// </summary>
        public static void RemoveMaritalStatus(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("MaritalStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EditDateTime record from TXA
        /// </summary>
        public static void RemoveEditDateTime(this TXA message, TS item)
        {
            int fieldNum = message.FindField("EditDateTime");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EditDateTime record from TXA
        /// </summary>
        public static void RemoveEditDateTime(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("EditDateTime");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AssignedDocumentAuthenticator record from TXA
        /// </summary>
        public static void RemoveAssignedDocumentAuthenticator(this TXA message, XCN item)
        {
            int fieldNum = message.FindField("AssignedDocumentAuthenticator");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AssignedDocumentAuthenticator record from TXA
        /// </summary>
        public static void RemoveAssignedDocumentAuthenticator(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("AssignedDocumentAuthenticator");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PlacerOrderNumber record from TXA
        /// </summary>
        public static void RemovePlacerOrderNumber(this TXA message, EI item)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from TXA
        /// </summary>
        public static void RemovePlacerOrderNumber(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get DocumentCompletionStatus Records from TXA
        /// </summary>
        public static IEnumerable GetDocumentCompletionStatusRecords(this TXA message)
        {
            object[] result = message.GetRecords("DocumentCompletionStatusRepetitionsUsed", "GetDocumentCompletionStatus");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DocumentCompletionStatus Records from TXA
        /// </summary>
        public static List<ID> GetAllDocumentCompletionStatusRecords(this TXA message)
        {
            return message.GetAllRecords<ID>("DocumentCompletionStatusRepetitionsUsed", "GetDocumentCompletionStatus");
        }

        /// <summary>
        /// Add a new DocumentCompletionStatus to TXA
        /// </summary>
        public static ID AddDocumentCompletionStatus(this TXA message)
        {
            return message.GetDocumentCompletionStatus(message.DocumentCompletionStatusRepetitionsUsed);
        }

        /// <summary>
        /// Remove an DocumentCompletionStatus record from TXA
        /// </summary>
        public static void RemoveDocumentCompletionStatus(this TXA message, ID item)
        {
            int fieldNum = message.FindField("DocumentCompletionStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DocumentCompletionStatus record from TXA
        /// </summary>
        public static void RemoveDocumentCompletionStatus(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("DocumentCompletionStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AuthenticationPersonTimeStamp record from TXA
        /// </summary>
        public static void RemoveAuthenticationPersonTimeStamp(this TXA message, PPN item)
        {
            int fieldNum = message.FindField("AuthenticationPersonTimeStamp");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AuthenticationPersonTimeStamp record from TXA
        /// </summary>
        public static void RemoveAuthenticationPersonTimeStamp(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("AuthenticationPersonTimeStamp");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DistributedCopiesCodeandNameofRecipients record from TXA
        /// </summary>
        public static void RemoveDistributedCopiesCodeandNameofRecipients(this TXA message, XCN item)
        {
            int fieldNum = message.FindField("DistributedCopiesCodeandNameofRecipients");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DistributedCopiesCodeandNameofRecipients record from TXA
        /// </summary>
        public static void RemoveDistributedCopiesCodeandNameofRecipients(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("DistributedCopiesCodeandNameofRecipients");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ConditionCode3539 record from UB1
        /// </summary>
        public static void RemoveConditionCode3539(this UB1 message, IS item)
        {
            int fieldNum = message.FindField("ConditionCode3539");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConditionCode3539 record from UB1
        /// </summary>
        public static void RemoveConditionCode3539(this UB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ConditionCode3539");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CM_UVC> GetAllValueAmountCode4649Records(this UB1 message)
        {
            return message.GetAllRecords<CM_UVC>("ValueAmountCode4649RepetitionsUsed", "GetValueAmountCode4649");
        }

        /// <summary>
        /// Add a new ValueAmountCode4649 to UB1
        /// </summary>
        public static CM_UVC AddValueAmountCode4649(this UB1 message)
        {
            return message.GetValueAmountCode4649(message.ValueAmountCode4649RepetitionsUsed);
        }

        /// <summary>
        /// Remove an ValueAmountCode4649 record from UB1
        /// </summary>
        public static void RemoveValueAmountCode4649(this UB1 message, CM_UVC item)
        {
            int fieldNum = message.FindField("ValueAmountCode4649");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ValueAmountCode4649 record from UB1
        /// </summary>
        public static void RemoveValueAmountCode4649(this UB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ValueAmountCode4649");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an Occurrence2832 record from UB1
        /// </summary>
        public static void RemoveOccurrence2832(this UB1 message, CM_OCD item)
        {
            int fieldNum = message.FindField("Occurrence2832");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Occurrence2832 record from UB1
        /// </summary>
        public static void RemoveOccurrence2832(this UB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Occurrence2832");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ConditionCode2430 record from UB2
        /// </summary>
        public static void RemoveConditionCode2430(this UB2 message, ID item)
        {
            int fieldNum = message.FindField("ConditionCode2430");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConditionCode2430 record from UB2
        /// </summary>
        public static void RemoveConditionCode2430(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ConditionCode2430");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CM_UVC> GetAllValueAmountCodeRecords(this UB2 message)
        {
            return message.GetAllRecords<CM_UVC>("ValueAmountCodeRepetitionsUsed", "GetValueAmountCode");
        }

        /// <summary>
        /// Add a new ValueAmountCode to UB2
        /// </summary>
        public static CM_UVC AddValueAmountCode(this UB2 message)
        {
            return message.GetValueAmountCode(message.ValueAmountCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ValueAmountCode record from UB2
        /// </summary>
        public static void RemoveValueAmountCode(this UB2 message, CM_UVC item)
        {
            int fieldNum = message.FindField("ValueAmountCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ValueAmountCode record from UB2
        /// </summary>
        public static void RemoveValueAmountCode(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ValueAmountCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CM_OCD> GetAllOccurrenceCodeDate3235Records(this UB2 message)
        {
            return message.GetAllRecords<CM_OCD>("OccurrenceCodeDate3235RepetitionsUsed", "GetOccurrenceCodeDate3235");
        }

        /// <summary>
        /// Add a new OccurrenceCodeDate3235 to UB2
        /// </summary>
        public static CM_OCD AddOccurrenceCodeDate3235(this UB2 message)
        {
            return message.GetOccurrenceCodeDate3235(message.OccurrenceCodeDate3235RepetitionsUsed);
        }

        /// <summary>
        /// Remove an OccurrenceCodeDate3235 record from UB2
        /// </summary>
        public static void RemoveOccurrenceCodeDate3235(this UB2 message, CM_OCD item)
        {
            int fieldNum = message.FindField("OccurrenceCodeDate3235");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OccurrenceCodeDate3235 record from UB2
        /// </summary>
        public static void RemoveOccurrenceCodeDate3235(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("OccurrenceCodeDate3235");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OccurrenceSpanCodeDates record from UB2
        /// </summary>
        public static void RemoveOccurrenceSpanCodeDates(this UB2 message, CM_OSP item)
        {
            int fieldNum = message.FindField("OccurrenceSpanCodeDates");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OccurrenceSpanCodeDates record from UB2
        /// </summary>
        public static void RemoveOccurrenceSpanCodeDates(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("OccurrenceSpanCodeDates");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an UB92Locator2State record from UB2
        /// </summary>
        public static void RemoveUB92Locator2State(this UB2 message, ST item)
        {
            int fieldNum = message.FindField("UB92Locator2State");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an UB92Locator2State record from UB2
        /// </summary>
        public static void RemoveUB92Locator2State(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("UB92Locator2State");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an UB92Locator11State record from UB2
        /// </summary>
        public static void RemoveUB92Locator11State(this UB2 message, ST item)
        {
            int fieldNum = message.FindField("UB92Locator11State");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an UB92Locator11State record from UB2
        /// </summary>
        public static void RemoveUB92Locator11State(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("UB92Locator11State");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an DocumentControlNumber record from UB2
        /// </summary>
        public static void RemoveDocumentControlNumber(this UB2 message, ST item)
        {
            int fieldNum = message.FindField("DocumentControlNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DocumentControlNumber record from UB2
        /// </summary>
        public static void RemoveDocumentControlNumber(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("DocumentControlNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an UB92Locator49National record from UB2
        /// </summary>
        public static void RemoveUB92Locator49National(this UB2 message, ST item)
        {
            int fieldNum = message.FindField("UB92Locator49National");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an UB92Locator49National record from UB2
        /// </summary>
        public static void RemoveUB92Locator49National(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("UB92Locator49National");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an UB92Locator56State record from UB2
        /// </summary>
        public static void RemoveUB92Locator56State(this UB2 message, ST item)
        {
            int fieldNum = message.FindField("UB92Locator56State");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an UB92Locator56State record from UB2
        /// </summary>
        public static void RemoveUB92Locator56State(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("UB92Locator56State");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an UB92Locator78State record from UB2
        /// </summary>
        public static void RemoveUB92Locator78State(this UB2 message, ST item)
        {
            int fieldNum = message.FindField("UB92Locator78State");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an UB92Locator78State record from UB2
        /// </summary>
        public static void RemoveUB92Locator78State(this UB2 message, int itemIndex)
        {
            int fieldNum = message.FindField("UB92Locator78State");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhoSubjectDefinition record from URD
        /// </summary>
        public static void RemoveRUWhoSubjectDefinition(this URD message, XCN item)
        {
            int fieldNum = message.FindField("RUWhoSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhoSubjectDefinition record from URD
        /// </summary>
        public static void RemoveRUWhoSubjectDefinition(this URD message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhoSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhatSubjectDefinition record from URD
        /// </summary>
        public static void RemoveRUWhatSubjectDefinition(this URD message, CE item)
        {
            int fieldNum = message.FindField("RUWhatSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhatSubjectDefinition record from URD
        /// </summary>
        public static void RemoveRUWhatSubjectDefinition(this URD message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhatSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhatDepartmentCode record from URD
        /// </summary>
        public static void RemoveRUWhatDepartmentCode(this URD message, CE item)
        {
            int fieldNum = message.FindField("RUWhatDepartmentCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhatDepartmentCode record from URD
        /// </summary>
        public static void RemoveRUWhatDepartmentCode(this URD message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhatDepartmentCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUDisplayPrintLocations record from URD
        /// </summary>
        public static void RemoveRUDisplayPrintLocations(this URD message, ST item)
        {
            int fieldNum = message.FindField("RUDisplayPrintLocations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUDisplayPrintLocations record from URD
        /// </summary>
        public static void RemoveRUDisplayPrintLocations(this URD message, int itemIndex)
        {
            int fieldNum = message.FindField("RUDisplayPrintLocations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhereSubjectDefinition record from URS
        /// </summary>
        public static void RemoveRUWhereSubjectDefinition(this URS message, ST item)
        {
            int fieldNum = message.FindField("RUWhereSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhereSubjectDefinition record from URS
        /// </summary>
        public static void RemoveRUWhereSubjectDefinition(this URS message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhereSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhatUserQualifier record from URS
        /// </summary>
        public static void RemoveRUWhatUserQualifier(this URS message, ST item)
        {
            int fieldNum = message.FindField("RUWhatUserQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhatUserQualifier record from URS
        /// </summary>
        public static void RemoveRUWhatUserQualifier(this URS message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhatUserQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUOtherResultsSubjectDefinition record from URS
        /// </summary>
        public static void RemoveRUOtherResultsSubjectDefinition(this URS message, ST item)
        {
            int fieldNum = message.FindField("RUOtherResultsSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUOtherResultsSubjectDefinition record from URS
        /// </summary>
        public static void RemoveRUOtherResultsSubjectDefinition(this URS message, int itemIndex)
        {
            int fieldNum = message.FindField("RUOtherResultsSubjectDefinition");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhichDateTimeQualifier record from URS
        /// </summary>
        public static void RemoveRUWhichDateTimeQualifier(this URS message, ID item)
        {
            int fieldNum = message.FindField("RUWhichDateTimeQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhichDateTimeQualifier record from URS
        /// </summary>
        public static void RemoveRUWhichDateTimeQualifier(this URS message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhichDateTimeQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUWhichDateTimeStatusQualifier record from URS
        /// </summary>
        public static void RemoveRUWhichDateTimeStatusQualifier(this URS message, ID item)
        {
            int fieldNum = message.FindField("RUWhichDateTimeStatusQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUWhichDateTimeStatusQualifier record from URS
        /// </summary>
        public static void RemoveRUWhichDateTimeStatusQualifier(this URS message, int itemIndex)
        {
            int fieldNum = message.FindField("RUWhichDateTimeStatusQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an RUDateTimeSelectionQualifier record from URS
        /// </summary>
        public static void RemoveRUDateTimeSelectionQualifier(this URS message, ID item)
        {
            int fieldNum = message.FindField("RUDateTimeSelectionQualifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RUDateTimeSelectionQualifier record from URS
        /// </summary>
        public static void RemoveRUDateTimeSelectionQualifier(this URS message, int itemIndex)
        {
            int fieldNum = message.FindField("RUDateTimeSelectionQualifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an VarianceDescription record from VAR
        /// </summary>
        public static void RemoveVarianceDescription(this VAR message, ST item)
        {
            int fieldNum = message.FindField("VarianceDescription");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VarianceDescription record from VAR
        /// </summary>
        public static void RemoveVarianceDescription(this VAR message, int itemIndex)
        {
            int fieldNum = message.FindField("VarianceDescription");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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

        /// <summary>
        /// Remove an SelectionCriteria record from VTQ
        /// </summary>
        public static void RemoveSelectionCriteria(this VTQ message, QSC item)
        {
            int fieldNum = message.FindField("SelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SelectionCriteria record from VTQ
        /// </summary>
        public static void RemoveSelectionCriteria(this VTQ message, int itemIndex)
        {
            int fieldNum = message.FindField("SelectionCriteria");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }
        #endregion
    }
}
