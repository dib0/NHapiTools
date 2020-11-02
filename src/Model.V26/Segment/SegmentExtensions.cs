using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V26.Group;
using NHapi.Model.V26.Message;
using NHapi.Model.V26.Segment;
using NHapi.Model.V26.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V26.Segment
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class SegmentExtensions
    {
        #region Extension methods
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
        /// Add a new ProfessionalOrganizationAffiliationDateRange to AFF
        /// </summary>
        public static DR AddProfessionalOrganizationAffiliationDateRange(this AFF message)
        {
            return message.GetProfessionalOrganizationAffiliationDateRange(message.ProfessionalOrganizationAffiliationDateRangeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProfessionalOrganizationAffiliationDateRange record from AFF
        /// </summary>
        public static void RemoveProfessionalOrganizationAffiliationDateRange(this AFF message, DR item)
        {
            int fieldNum = message.FindField("ProfessionalOrganizationAffiliationDateRange");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProfessionalOrganizationAffiliationDateRange record from AFF
        /// </summary>
        public static void RemoveProfessionalOrganizationAffiliationDateRange(this AFF message, int itemIndex)
        {
            int fieldNum = message.FindField("ProfessionalOrganizationAffiliationDateRange");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllResourceGroupRecords(this AIG message)
        {
            return message.GetAllRecords<CWE>("ResourceGroupRepetitionsUsed", "GetResourceGroup");
        }

        /// <summary>
        /// Add a new ResourceGroup to AIG
        /// </summary>
        public static CWE AddResourceGroup(this AIG message)
        {
            return message.GetResourceGroup(message.ResourceGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ResourceGroup record from AIG
        /// </summary>
        public static void RemoveResourceGroup(this AIG message, CWE item)
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
        /// Add a new LocationResourceID to AIL
        /// </summary>
        public static PL AddLocationResourceID(this AIL message)
        {
            return message.GetLocationResourceID(message.LocationResourceIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an LocationResourceID record from AIL
        /// </summary>
        public static void RemoveLocationResourceID(this AIL message, PL item)
        {
            int fieldNum = message.FindField("LocationResourceID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationResourceID record from AIL
        /// </summary>
        public static void RemoveLocationResourceID(this AIL message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationResourceID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PersonnelResourceID record from AIP
        /// </summary>
        public static void RemovePersonnelResourceID(this AIP message, XCN item)
        {
            int fieldNum = message.FindField("PersonnelResourceID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PersonnelResourceID record from AIP
        /// </summary>
        public static void RemovePersonnelResourceID(this AIP message, int itemIndex)
        {
            int fieldNum = message.FindField("PersonnelResourceID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllPlacerSupplementalServiceInformationRecords(this AIS message)
        {
            return message.GetAllRecords<CWE>("PlacerSupplementalServiceInformationRepetitionsUsed", "GetPlacerSupplementalServiceInformation");
        }

        /// <summary>
        /// Add a new PlacerSupplementalServiceInformation to AIS
        /// </summary>
        public static CWE AddPlacerSupplementalServiceInformation(this AIS message)
        {
            return message.GetPlacerSupplementalServiceInformation(message.PlacerSupplementalServiceInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlacerSupplementalServiceInformation record from AIS
        /// </summary>
        public static void RemovePlacerSupplementalServiceInformation(this AIS message, CWE item)
        {
            int fieldNum = message.FindField("PlacerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerSupplementalServiceInformation record from AIS
        /// </summary>
        public static void RemovePlacerSupplementalServiceInformation(this AIS message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllFillerSupplementalServiceInformationRecords(this AIS message)
        {
            return message.GetAllRecords<CWE>("FillerSupplementalServiceInformationRepetitionsUsed", "GetFillerSupplementalServiceInformation");
        }

        /// <summary>
        /// Add a new FillerSupplementalServiceInformation to AIS
        /// </summary>
        public static CWE AddFillerSupplementalServiceInformation(this AIS message)
        {
            return message.GetFillerSupplementalServiceInformation(message.FillerSupplementalServiceInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FillerSupplementalServiceInformation record from AIS
        /// </summary>
        public static void RemoveFillerSupplementalServiceInformation(this AIS message, CWE item)
        {
            int fieldNum = message.FindField("FillerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerSupplementalServiceInformation record from AIS
        /// </summary>
        public static void RemoveFillerSupplementalServiceInformation(this AIS message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new AllergyReactionCode to AL1
        /// </summary>
        public static ST AddAllergyReactionCode(this AL1 message)
        {
            return message.GetAllergyReactionCode(message.AllergyReactionCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AllergyReactionCode record from AL1
        /// </summary>
        public static void RemoveAllergyReactionCode(this AL1 message, ST item)
        {
            int fieldNum = message.FindField("AllergyReactionCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AllergyReactionCode record from AL1
        /// </summary>
        public static void RemoveAllergyReactionCode(this AL1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AllergyReactionCode");
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
        /// Remove an PlacerContactPerson record from ARQ
        /// </summary>
        public static void RemovePlacerContactPerson(this ARQ message, XCN item)
        {
            int fieldNum = message.FindField("PlacerContactPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerContactPerson record from ARQ
        /// </summary>
        public static void RemovePlacerContactPerson(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerContactPerson");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PlacerContactPhoneNumber record from ARQ
        /// </summary>
        public static void RemovePlacerContactPhoneNumber(this ARQ message, XTN item)
        {
            int fieldNum = message.FindField("PlacerContactPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerContactPhoneNumber record from ARQ
        /// </summary>
        public static void RemovePlacerContactPhoneNumber(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerContactPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PlacerContactAddress record from ARQ
        /// </summary>
        public static void RemovePlacerContactAddress(this ARQ message, XAD item)
        {
            int fieldNum = message.FindField("PlacerContactAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerContactAddress record from ARQ
        /// </summary>
        public static void RemovePlacerContactAddress(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerContactAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EnteredByPerson record from ARQ
        /// </summary>
        public static void RemoveEnteredByPerson(this ARQ message, XCN item)
        {
            int fieldNum = message.FindField("EnteredByPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EnteredByPerson record from ARQ
        /// </summary>
        public static void RemoveEnteredByPerson(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("EnteredByPerson");
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
        /// Add a new PlacerOrderNumber to ARQ
        /// </summary>
        public static EI AddPlacerOrderNumber(this ARQ message)
        {
            return message.GetPlacerOrderNumber(message.PlacerOrderNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from ARQ
        /// </summary>
        public static void RemovePlacerOrderNumber(this ARQ message, EI item)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from ARQ
        /// </summary>
        public static void RemovePlacerOrderNumber(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new FillerOrderNumber to ARQ
        /// </summary>
        public static EI AddFillerOrderNumber(this ARQ message)
        {
            return message.GetFillerOrderNumber(message.FillerOrderNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FillerOrderNumber record from ARQ
        /// </summary>
        public static void RemoveFillerOrderNumber(this ARQ message, EI item)
        {
            int fieldNum = message.FindField("FillerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerOrderNumber record from ARQ
        /// </summary>
        public static void RemoveFillerOrderNumber(this ARQ message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get AccessRestrictionReason Records from ARV
        /// </summary>
        public static IEnumerable GetAccessRestrictionReasonRecords(this ARV message)
        {
            object[] result = message.GetRecords("AccessRestrictionReasonRepetitionsUsed", "GetAccessRestrictionReason");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AccessRestrictionReason Records from ARV
        /// </summary>
        public static List<CWE> GetAllAccessRestrictionReasonRecords(this ARV message)
        {
            return message.GetAllRecords<CWE>("AccessRestrictionReasonRepetitionsUsed", "GetAccessRestrictionReason");
        }

        /// <summary>
        /// Add a new AccessRestrictionReason to ARV
        /// </summary>
        public static CWE AddAccessRestrictionReason(this ARV message)
        {
            return message.GetAccessRestrictionReason(message.AccessRestrictionReasonRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AccessRestrictionReason record from ARV
        /// </summary>
        public static void RemoveAccessRestrictionReason(this ARV message, CWE item)
        {
            int fieldNum = message.FindField("AccessRestrictionReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AccessRestrictionReason record from ARV
        /// </summary>
        public static void RemoveAccessRestrictionReason(this ARV message, int itemIndex)
        {
            int fieldNum = message.FindField("AccessRestrictionReason");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get SpecialAccessRestrictionInstructions Records from ARV
        /// </summary>
        public static IEnumerable GetSpecialAccessRestrictionInstructionsRecords(this ARV message)
        {
            object[] result = message.GetRecords("SpecialAccessRestrictionInstructionsRepetitionsUsed", "GetSpecialAccessRestrictionInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialAccessRestrictionInstructions Records from ARV
        /// </summary>
        public static List<ST> GetAllSpecialAccessRestrictionInstructionsRecords(this ARV message)
        {
            return message.GetAllRecords<ST>("SpecialAccessRestrictionInstructionsRepetitionsUsed", "GetSpecialAccessRestrictionInstructions");
        }

        /// <summary>
        /// Add a new SpecialAccessRestrictionInstructions to ARV
        /// </summary>
        public static ST AddSpecialAccessRestrictionInstructions(this ARV message)
        {
            return message.GetSpecialAccessRestrictionInstructions(message.SpecialAccessRestrictionInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecialAccessRestrictionInstructions record from ARV
        /// </summary>
        public static void RemoveSpecialAccessRestrictionInstructions(this ARV message, ST item)
        {
            int fieldNum = message.FindField("SpecialAccessRestrictionInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecialAccessRestrictionInstructions record from ARV
        /// </summary>
        public static void RemoveSpecialAccessRestrictionInstructions(this ARV message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecialAccessRestrictionInstructions");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new BPProcessingRequirements to BPO
        /// </summary>
        public static CWE AddBPProcessingRequirements(this BPO message)
        {
            return message.GetBPProcessingRequirements(message.BPProcessingRequirementsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BPProcessingRequirements record from BPO
        /// </summary>
        public static void RemoveBPProcessingRequirements(this BPO message, CWE item)
        {
            int fieldNum = message.FindField("BPProcessingRequirements");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BPProcessingRequirements record from BPO
        /// </summary>
        public static void RemoveBPProcessingRequirements(this BPO message, int itemIndex)
        {
            int fieldNum = message.FindField("BPProcessingRequirements");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new BPIndicationForUse to BPO
        /// </summary>
        public static CWE AddBPIndicationForUse(this BPO message)
        {
            return message.GetBPIndicationForUse(message.BPIndicationForUseRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BPIndicationForUse record from BPO
        /// </summary>
        public static void RemoveBPIndicationForUse(this BPO message, CWE item)
        {
            int fieldNum = message.FindField("BPIndicationForUse");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BPIndicationForUse record from BPO
        /// </summary>
        public static void RemoveBPIndicationForUse(this BPO message, int itemIndex)
        {
            int fieldNum = message.FindField("BPIndicationForUse");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new BCSpecialTesting to BPX
        /// </summary>
        public static CNE AddBCSpecialTesting(this BPX message)
        {
            return message.GetBCSpecialTesting(message.BCSpecialTestingRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BCSpecialTesting record from BPX
        /// </summary>
        public static void RemoveBCSpecialTesting(this BPX message, CNE item)
        {
            int fieldNum = message.FindField("BCSpecialTesting");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BCSpecialTesting record from BPX
        /// </summary>
        public static void RemoveBCSpecialTesting(this BPX message, int itemIndex)
        {
            int fieldNum = message.FindField("BCSpecialTesting");
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
        /// Add a new BPAdverseReactionType to BTX
        /// </summary>
        public static CWE AddBPAdverseReactionType(this BTX message)
        {
            return message.GetBPAdverseReactionType(message.BPAdverseReactionTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BPAdverseReactionType record from BTX
        /// </summary>
        public static void RemoveBPAdverseReactionType(this BTX message, CWE item)
        {
            int fieldNum = message.FindField("BPAdverseReactionType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BPAdverseReactionType record from BTX
        /// </summary>
        public static void RemoveBPAdverseReactionType(this BTX message, int itemIndex)
        {
            int fieldNum = message.FindField("BPAdverseReactionType");
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
        public static List<CWE> GetAllChargeCodeAliasRecords(this CDM message)
        {
            return message.GetAllRecords<CWE>("ChargeCodeAliasRepetitionsUsed", "GetChargeCodeAlias");
        }

        /// <summary>
        /// Add a new ChargeCodeAlias to CDM
        /// </summary>
        public static CWE AddChargeCodeAlias(this CDM message)
        {
            return message.GetChargeCodeAlias(message.ChargeCodeAliasRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ChargeCodeAlias record from CDM
        /// </summary>
        public static void RemoveChargeCodeAlias(this CDM message, CWE item)
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
        public static List<CWE> GetAllExplodingChargesRecords(this CDM message)
        {
            return message.GetAllRecords<CWE>("ExplodingChargesRepetitionsUsed", "GetExplodingCharges");
        }

        /// <summary>
        /// Add a new ExplodingCharges to CDM
        /// </summary>
        public static CWE AddExplodingCharges(this CDM message)
        {
            return message.GetExplodingCharges(message.ExplodingChargesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ExplodingCharges record from CDM
        /// </summary>
        public static void RemoveExplodingCharges(this CDM message, CWE item)
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
        public static List<CNE> GetAllProcedureCodeRecords(this CDM message)
        {
            return message.GetAllRecords<CNE>("ProcedureCodeRepetitionsUsed", "GetProcedureCode");
        }

        /// <summary>
        /// Add a new ProcedureCode to CDM
        /// </summary>
        public static CNE AddProcedureCode(this CDM message)
        {
            return message.GetProcedureCode(message.ProcedureCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProcedureCode record from CDM
        /// </summary>
        public static void RemoveProcedureCode(this CDM message, CNE item)
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
        public static List<CWE> GetAllInventoryNumberRecords(this CDM message)
        {
            return message.GetAllRecords<CWE>("InventoryNumberRepetitionsUsed", "GetInventoryNumber");
        }

        /// <summary>
        /// Add a new InventoryNumber to CDM
        /// </summary>
        public static CWE AddInventoryNumber(this CDM message)
        {
            return message.GetInventoryNumber(message.InventoryNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InventoryNumber record from CDM
        /// </summary>
        public static void RemoveInventoryNumber(this CDM message, CWE item)
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
        public static List<CX> GetAllContractNumberRecords(this CDM message)
        {
            return message.GetAllRecords<CX>("ContractNumberRepetitionsUsed", "GetContractNumber");
        }

        /// <summary>
        /// Add a new ContractNumber to CDM
        /// </summary>
        public static CX AddContractNumber(this CDM message)
        {
            return message.GetContractNumber(message.ContractNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ContractNumber record from CDM
        /// </summary>
        public static void RemoveContractNumber(this CDM message, CX item)
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
        /// Remove an ContractOrganization record from CDM
        /// </summary>
        public static void RemoveContractOrganization(this CDM message, XON item)
        {
            int fieldNum = message.FindField("ContractOrganization");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContractOrganization record from CDM
        /// </summary>
        public static void RemoveContractOrganization(this CDM message, int itemIndex)
        {
            int fieldNum = message.FindField("ContractOrganization");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get SubjectDirectoryAttributeExtension Records from CER
        /// </summary>
        public static IEnumerable GetSubjectDirectoryAttributeExtensionRecords(this CER message)
        {
            object[] result = message.GetRecords("SubjectDirectoryAttributeExtensionRepetitionsUsed", "GetSubjectDirectoryAttributeExtension");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubjectDirectoryAttributeExtension Records from CER
        /// </summary>
        public static List<CWE> GetAllSubjectDirectoryAttributeExtensionRecords(this CER message)
        {
            return message.GetAllRecords<CWE>("SubjectDirectoryAttributeExtensionRepetitionsUsed", "GetSubjectDirectoryAttributeExtension");
        }

        /// <summary>
        /// Add a new SubjectDirectoryAttributeExtension to CER
        /// </summary>
        public static CWE AddSubjectDirectoryAttributeExtension(this CER message)
        {
            return message.GetSubjectDirectoryAttributeExtension(message.SubjectDirectoryAttributeExtensionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubjectDirectoryAttributeExtension record from CER
        /// </summary>
        public static void RemoveSubjectDirectoryAttributeExtension(this CER message, CWE item)
        {
            int fieldNum = message.FindField("SubjectDirectoryAttributeExtension");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubjectDirectoryAttributeExtension record from CER
        /// </summary>
        public static void RemoveSubjectDirectoryAttributeExtension(this CER message, int itemIndex)
        {
            int fieldNum = message.FindField("SubjectDirectoryAttributeExtension");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new CRLDistributionPoint to CER
        /// </summary>
        public static CWE AddCRLDistributionPoint(this CER message)
        {
            return message.GetCRLDistributionPoint(message.CRLDistributionPointRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CRLDistributionPoint record from CER
        /// </summary>
        public static void RemoveCRLDistributionPoint(this CER message, CWE item)
        {
            int fieldNum = message.FindField("CRLDistributionPoint");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CRLDistributionPoint record from CER
        /// </summary>
        public static void RemoveCRLDistributionPoint(this CER message, int itemIndex)
        {
            int fieldNum = message.FindField("CRLDistributionPoint");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new JurisdictionBreadth to CER
        /// </summary>
        public static CWE AddJurisdictionBreadth(this CER message)
        {
            return message.GetJurisdictionBreadth(message.JurisdictionBreadthRepetitionsUsed);
        }

        /// <summary>
        /// Remove an JurisdictionBreadth record from CER
        /// </summary>
        public static void RemoveJurisdictionBreadth(this CER message, CWE item)
        {
            int fieldNum = message.FindField("JurisdictionBreadth");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an JurisdictionBreadth record from CER
        /// </summary>
        public static void RemoveJurisdictionBreadth(this CER message, int itemIndex)
        {
            int fieldNum = message.FindField("JurisdictionBreadth");
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
        /// Remove an AlternateStudyID record from CM0
        /// </summary>
        public static void RemoveAlternateStudyID(this CM0 message, EI item)
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
        /// Remove an ChairmanOfStudy record from CM0
        /// </summary>
        public static void RemoveChairmanOfStudy(this CM0 message, XCN item)
        {
            int fieldNum = message.FindField("ChairmanOfStudy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ChairmanOfStudy record from CM0
        /// </summary>
        public static void RemoveChairmanOfStudy(this CM0 message, int itemIndex)
        {
            int fieldNum = message.FindField("ChairmanOfStudy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactForStudy record from CM0
        /// </summary>
        public static void RemoveContactForStudy(this CM0 message, XCN item)
        {
            int fieldNum = message.FindField("ContactForStudy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactForStudy record from CM0
        /// </summary>
        public static void RemoveContactForStudy(this CM0 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactForStudy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ContactSAddress record from CM0
        /// </summary>
        public static void RemoveContactSAddress(this CM0 message, XAD item)
        {
            int fieldNum = message.FindField("ContactSAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactSAddress record from CM0
        /// </summary>
        public static void RemoveContactSAddress(this CM0 message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactSAddress");
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
        public static List<CWE> GetAllEventsScheduledThisTimePointRecords(this CM2 message)
        {
            return message.GetAllRecords<CWE>("EventsScheduledThisTimePointRepetitionsUsed", "GetEventsScheduledThisTimePoint");
        }

        /// <summary>
        /// Add a new EventsScheduledThisTimePoint to CM2
        /// </summary>
        public static CWE AddEventsScheduledThisTimePoint(this CM2 message)
        {
            return message.GetEventsScheduledThisTimePoint(message.EventsScheduledThisTimePointRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EventsScheduledThisTimePoint record from CM2
        /// </summary>
        public static void RemoveEventsScheduledThisTimePoint(this CM2 message, CWE item)
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
        /// Get ConsentText Records from CON
        /// </summary>
        public static IEnumerable GetConsentTextRecords(this CON message)
        {
            object[] result = message.GetRecords("ConsentTextRepetitionsUsed", "GetConsentText");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConsentText Records from CON
        /// </summary>
        public static List<FT> GetAllConsentTextRecords(this CON message)
        {
            return message.GetAllRecords<FT>("ConsentTextRepetitionsUsed", "GetConsentText");
        }

        /// <summary>
        /// Add a new ConsentText to CON
        /// </summary>
        public static FT AddConsentText(this CON message)
        {
            return message.GetConsentText(message.ConsentTextRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ConsentText record from CON
        /// </summary>
        public static void RemoveConsentText(this CON message, FT item)
        {
            int fieldNum = message.FindField("ConsentText");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConsentText record from CON
        /// </summary>
        public static void RemoveConsentText(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("ConsentText");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get SubjectSpecificConsentText Records from CON
        /// </summary>
        public static IEnumerable GetSubjectSpecificConsentTextRecords(this CON message)
        {
            object[] result = message.GetRecords("SubjectSpecificConsentTextRepetitionsUsed", "GetSubjectSpecificConsentText");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubjectSpecificConsentText Records from CON
        /// </summary>
        public static List<FT> GetAllSubjectSpecificConsentTextRecords(this CON message)
        {
            return message.GetAllRecords<FT>("SubjectSpecificConsentTextRepetitionsUsed", "GetSubjectSpecificConsentText");
        }

        /// <summary>
        /// Add a new SubjectSpecificConsentText to CON
        /// </summary>
        public static FT AddSubjectSpecificConsentText(this CON message)
        {
            return message.GetSubjectSpecificConsentText(message.SubjectSpecificConsentTextRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubjectSpecificConsentText record from CON
        /// </summary>
        public static void RemoveSubjectSpecificConsentText(this CON message, FT item)
        {
            int fieldNum = message.FindField("SubjectSpecificConsentText");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubjectSpecificConsentText record from CON
        /// </summary>
        public static void RemoveSubjectSpecificConsentText(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("SubjectSpecificConsentText");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ConsentBackgroundInformation Records from CON
        /// </summary>
        public static IEnumerable GetConsentBackgroundInformationRecords(this CON message)
        {
            object[] result = message.GetRecords("ConsentBackgroundInformationRepetitionsUsed", "GetConsentBackgroundInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConsentBackgroundInformation Records from CON
        /// </summary>
        public static List<FT> GetAllConsentBackgroundInformationRecords(this CON message)
        {
            return message.GetAllRecords<FT>("ConsentBackgroundInformationRepetitionsUsed", "GetConsentBackgroundInformation");
        }

        /// <summary>
        /// Add a new ConsentBackgroundInformation to CON
        /// </summary>
        public static FT AddConsentBackgroundInformation(this CON message)
        {
            return message.GetConsentBackgroundInformation(message.ConsentBackgroundInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ConsentBackgroundInformation record from CON
        /// </summary>
        public static void RemoveConsentBackgroundInformation(this CON message, FT item)
        {
            int fieldNum = message.FindField("ConsentBackgroundInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConsentBackgroundInformation record from CON
        /// </summary>
        public static void RemoveConsentBackgroundInformation(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("ConsentBackgroundInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get SubjectSpecificConsentBackgroundText Records from CON
        /// </summary>
        public static IEnumerable GetSubjectSpecificConsentBackgroundTextRecords(this CON message)
        {
            object[] result = message.GetRecords("SubjectSpecificConsentBackgroundTextRepetitionsUsed", "GetSubjectSpecificConsentBackgroundText");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubjectSpecificConsentBackgroundText Records from CON
        /// </summary>
        public static List<FT> GetAllSubjectSpecificConsentBackgroundTextRecords(this CON message)
        {
            return message.GetAllRecords<FT>("SubjectSpecificConsentBackgroundTextRepetitionsUsed", "GetSubjectSpecificConsentBackgroundText");
        }

        /// <summary>
        /// Add a new SubjectSpecificConsentBackgroundText to CON
        /// </summary>
        public static FT AddSubjectSpecificConsentBackgroundText(this CON message)
        {
            return message.GetSubjectSpecificConsentBackgroundText(message.SubjectSpecificConsentBackgroundTextRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubjectSpecificConsentBackgroundText record from CON
        /// </summary>
        public static void RemoveSubjectSpecificConsentBackgroundText(this CON message, FT item)
        {
            int fieldNum = message.FindField("SubjectSpecificConsentBackgroundText");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubjectSpecificConsentBackgroundText record from CON
        /// </summary>
        public static void RemoveSubjectSpecificConsentBackgroundText(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("SubjectSpecificConsentBackgroundText");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ConsenterImposedLimitations Records from CON
        /// </summary>
        public static IEnumerable GetConsenterImposedLimitationsRecords(this CON message)
        {
            object[] result = message.GetRecords("ConsenterImposedLimitationsRepetitionsUsed", "GetConsenterImposedLimitations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConsenterImposedLimitations Records from CON
        /// </summary>
        public static List<FT> GetAllConsenterImposedLimitationsRecords(this CON message)
        {
            return message.GetAllRecords<FT>("ConsenterImposedLimitationsRepetitionsUsed", "GetConsenterImposedLimitations");
        }

        /// <summary>
        /// Add a new ConsenterImposedLimitations to CON
        /// </summary>
        public static FT AddConsenterImposedLimitations(this CON message)
        {
            return message.GetConsenterImposedLimitations(message.ConsenterImposedLimitationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ConsenterImposedLimitations record from CON
        /// </summary>
        public static void RemoveConsenterImposedLimitations(this CON message, FT item)
        {
            int fieldNum = message.FindField("ConsenterImposedLimitations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConsenterImposedLimitations record from CON
        /// </summary>
        public static void RemoveConsenterImposedLimitations(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("ConsenterImposedLimitations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ConsenterID Records from CON
        /// </summary>
        public static IEnumerable GetConsenterIDRecords(this CON message)
        {
            object[] result = message.GetRecords("ConsenterIDRepetitionsUsed", "GetConsenterID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConsenterID Records from CON
        /// </summary>
        public static List<XPN> GetAllConsenterIDRecords(this CON message)
        {
            return message.GetAllRecords<XPN>("ConsenterIDRepetitionsUsed", "GetConsenterID");
        }

        /// <summary>
        /// Add a new ConsenterID to CON
        /// </summary>
        public static XPN AddConsenterID(this CON message)
        {
            return message.GetConsenterID(message.ConsenterIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ConsenterID record from CON
        /// </summary>
        public static void RemoveConsenterID(this CON message, XPN item)
        {
            int fieldNum = message.FindField("ConsenterID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConsenterID record from CON
        /// </summary>
        public static void RemoveConsenterID(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("ConsenterID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get RelationshipToSubject Records from CON
        /// </summary>
        public static IEnumerable GetRelationshipToSubjectRecords(this CON message)
        {
            object[] result = message.GetRecords("RelationshipToSubjectRepetitionsUsed", "GetRelationshipToSubject");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelationshipToSubject Records from CON
        /// </summary>
        public static List<IS> GetAllRelationshipToSubjectRecords(this CON message)
        {
            return message.GetAllRecords<IS>("RelationshipToSubjectRepetitionsUsed", "GetRelationshipToSubject");
        }

        /// <summary>
        /// Add a new RelationshipToSubject to CON
        /// </summary>
        public static IS AddRelationshipToSubject(this CON message)
        {
            return message.GetRelationshipToSubject(message.RelationshipToSubjectRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RelationshipToSubject record from CON
        /// </summary>
        public static void RemoveRelationshipToSubject(this CON message, IS item)
        {
            int fieldNum = message.FindField("RelationshipToSubject");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RelationshipToSubject record from CON
        /// </summary>
        public static void RemoveRelationshipToSubject(this CON message, int itemIndex)
        {
            int fieldNum = message.FindField("RelationshipToSubject");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PersonPerformingStudyRegistration record from CSR
        /// </summary>
        public static void RemovePersonPerformingStudyRegistration(this CSR message, XCN item)
        {
            int fieldNum = message.FindField("PersonPerformingStudyRegistration");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PersonPerformingStudyRegistration record from CSR
        /// </summary>
        public static void RemovePersonPerformingStudyRegistration(this CSR message, int itemIndex)
        {
            int fieldNum = message.FindField("PersonPerformingStudyRegistration");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StudyAuthorizingProvider record from CSR
        /// </summary>
        public static void RemoveStudyAuthorizingProvider(this CSR message, XCN item)
        {
            int fieldNum = message.FindField("StudyAuthorizingProvider");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StudyAuthorizingProvider record from CSR
        /// </summary>
        public static void RemoveStudyAuthorizingProvider(this CSR message, int itemIndex)
        {
            int fieldNum = message.FindField("StudyAuthorizingProvider");
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
        public static List<DTM> GetAllStudyRandomizationDateTimeRecords(this CSR message)
        {
            return message.GetAllRecords<DTM>("StudyRandomizationDateTimeRepetitionsUsed", "GetStudyRandomizationDateTime");
        }

        /// <summary>
        /// Add a new StudyRandomizationDateTime to CSR
        /// </summary>
        public static DTM AddStudyRandomizationDateTime(this CSR message)
        {
            return message.GetStudyRandomizationDateTime(message.StudyRandomizationDateTimeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an StudyRandomizationDateTime record from CSR
        /// </summary>
        public static void RemoveStudyRandomizationDateTime(this CSR message, DTM item)
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
        public static List<CWE> GetAllRandomizedStudyArmRecords(this CSR message)
        {
            return message.GetAllRecords<CWE>("RandomizedStudyArmRepetitionsUsed", "GetRandomizedStudyArm");
        }

        /// <summary>
        /// Add a new RandomizedStudyArm to CSR
        /// </summary>
        public static CWE AddRandomizedStudyArm(this CSR message)
        {
            return message.GetRandomizedStudyArm(message.RandomizedStudyArmRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RandomizedStudyArm record from CSR
        /// </summary>
        public static void RemoveRandomizedStudyArm(this CSR message, CWE item)
        {
            int fieldNum = message.FindField("RandomizedStudyArm");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RandomizedStudyArm record from CSR
        /// </summary>
        public static void RemoveRandomizedStudyArm(this CSR message, int itemIndex)
        {
            int fieldNum = message.FindField("RandomizedStudyArm");
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
        public static List<CWE> GetAllStratumForStudyRandomizationRecords(this CSR message)
        {
            return message.GetAllRecords<CWE>("StratumForStudyRandomizationRepetitionsUsed", "GetStratumForStudyRandomization");
        }

        /// <summary>
        /// Add a new StratumForStudyRandomization to CSR
        /// </summary>
        public static CWE AddStratumForStudyRandomization(this CSR message)
        {
            return message.GetStratumForStudyRandomization(message.StratumForStudyRandomizationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an StratumForStudyRandomization record from CSR
        /// </summary>
        public static void RemoveStratumForStudyRandomization(this CSR message, CWE item)
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
        public static List<CWE> GetAllStudyQualityControlCodesRecords(this CSS message)
        {
            return message.GetAllRecords<CWE>("StudyQualityControlCodesRepetitionsUsed", "GetStudyQualityControlCodes");
        }

        /// <summary>
        /// Add a new StudyQualityControlCodes to CSS
        /// </summary>
        public static CWE AddStudyQualityControlCodes(this CSS message)
        {
            return message.GetStudyQualityControlCodes(message.StudyQualityControlCodesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an StudyQualityControlCodes record from CSS
        /// </summary>
        public static void RemoveStudyQualityControlCodes(this CSS message, CWE item)
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
        public static List<CWE> GetAllContactRoleRecords(this CTD message)
        {
            return message.GetAllRecords<CWE>("ContactRoleRepetitionsUsed", "GetContactRole");
        }

        /// <summary>
        /// Add a new ContactRole to CTD
        /// </summary>
        public static CWE AddContactRole(this CTD message)
        {
            return message.GetContactRole(message.ContactRoleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ContactRole record from CTD
        /// </summary>
        public static void RemoveContactRole(this CTD message, CWE item)
        {
            int fieldNum = message.FindField("ContactRole");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ContactRole record from CTD
        /// </summary>
        public static void RemoveContactRole(this CTD message, int itemIndex)
        {
            int fieldNum = message.FindField("ContactRole");
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
        public static List<PLN> GetAllContactIdentifiersRecords(this CTD message)
        {
            return message.GetAllRecords<PLN>("ContactIdentifiersRepetitionsUsed", "GetContactIdentifiers");
        }

        /// <summary>
        /// Add a new ContactIdentifiers to CTD
        /// </summary>
        public static PLN AddContactIdentifiers(this CTD message)
        {
            return message.GetContactIdentifiers(message.ContactIdentifiersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ContactIdentifiers record from CTD
        /// </summary>
        public static void RemoveContactIdentifiers(this CTD message, PLN item)
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
        /// Add a new Parameters to ECD
        /// </summary>
        public static TX AddParameters(this ECD message)
        {
            return message.GetParameters(message.ParametersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Parameters record from ECD
        /// </summary>
        public static void RemoveParameters(this ECD message, TX item)
        {
            int fieldNum = message.FindField("Parameters");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Parameters record from ECD
        /// </summary>
        public static void RemoveParameters(this ECD message, int itemIndex)
        {
            int fieldNum = message.FindField("Parameters");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new CommandResponseParameters to ECR
        /// </summary>
        public static TX AddCommandResponseParameters(this ECR message)
        {
            return message.GetCommandResponseParameters(message.CommandResponseParametersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CommandResponseParameters record from ECR
        /// </summary>
        public static void RemoveCommandResponseParameters(this ECR message, TX item)
        {
            int fieldNum = message.FindField("CommandResponseParameters");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CommandResponseParameters record from ECR
        /// </summary>
        public static void RemoveCommandResponseParameters(this ECR message, int itemIndex)
        {
            int fieldNum = message.FindField("CommandResponseParameters");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new MajorFieldOfStudy to EDU
        /// </summary>
        public static CWE AddMajorFieldOfStudy(this EDU message)
        {
            return message.GetMajorFieldOfStudy(message.MajorFieldOfStudyRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MajorFieldOfStudy record from EDU
        /// </summary>
        public static void RemoveMajorFieldOfStudy(this EDU message, CWE item)
        {
            int fieldNum = message.FindField("MajorFieldOfStudy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MajorFieldOfStudy record from EDU
        /// </summary>
        public static void RemoveMajorFieldOfStudy(this EDU message, int itemIndex)
        {
            int fieldNum = message.FindField("MajorFieldOfStudy");
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
        /// Remove an ErrorCodeAndLocation record from ERR
        /// </summary>
        public static void RemoveErrorCodeAndLocation(this ERR message, ELD item)
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
        /// Add a new ErrorLocation to ERR
        /// </summary>
        public static ERL AddErrorLocation(this ERR message)
        {
            return message.GetErrorLocation(message.ErrorLocationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ErrorLocation record from ERR
        /// </summary>
        public static void RemoveErrorLocation(this ERR message, ERL item)
        {
            int fieldNum = message.FindField("ErrorLocation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ErrorLocation record from ERR
        /// </summary>
        public static void RemoveErrorLocation(this ERR message, int itemIndex)
        {
            int fieldNum = message.FindField("ErrorLocation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new ApplicationErrorParameter to ERR
        /// </summary>
        public static ST AddApplicationErrorParameter(this ERR message)
        {
            return message.GetApplicationErrorParameter(message.ApplicationErrorParameterRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ApplicationErrorParameter record from ERR
        /// </summary>
        public static void RemoveApplicationErrorParameter(this ERR message, ST item)
        {
            int fieldNum = message.FindField("ApplicationErrorParameter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ApplicationErrorParameter record from ERR
        /// </summary>
        public static void RemoveApplicationErrorParameter(this ERR message, int itemIndex)
        {
            int fieldNum = message.FindField("ApplicationErrorParameter");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new InformPersonIndicator to ERR
        /// </summary>
        public static IS AddInformPersonIndicator(this ERR message)
        {
            return message.GetInformPersonIndicator(message.InformPersonIndicatorRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InformPersonIndicator record from ERR
        /// </summary>
        public static void RemoveInformPersonIndicator(this ERR message, IS item)
        {
            int fieldNum = message.FindField("InformPersonIndicator");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InformPersonIndicator record from ERR
        /// </summary>
        public static void RemoveInformPersonIndicator(this ERR message, int itemIndex)
        {
            int fieldNum = message.FindField("InformPersonIndicator");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new OverrideReasonCode to ERR
        /// </summary>
        public static CWE AddOverrideReasonCode(this ERR message)
        {
            return message.GetOverrideReasonCode(message.OverrideReasonCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OverrideReasonCode record from ERR
        /// </summary>
        public static void RemoveOverrideReasonCode(this ERR message, CWE item)
        {
            int fieldNum = message.FindField("OverrideReasonCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OverrideReasonCode record from ERR
        /// </summary>
        public static void RemoveOverrideReasonCode(this ERR message, int itemIndex)
        {
            int fieldNum = message.FindField("OverrideReasonCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new HelpDeskContactPoint to ERR
        /// </summary>
        public static XTN AddHelpDeskContactPoint(this ERR message)
        {
            return message.GetHelpDeskContactPoint(message.HelpDeskContactPointRepetitionsUsed);
        }

        /// <summary>
        /// Remove an HelpDeskContactPoint record from ERR
        /// </summary>
        public static void RemoveHelpDeskContactPoint(this ERR message, XTN item)
        {
            int fieldNum = message.FindField("HelpDeskContactPoint");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an HelpDeskContactPoint record from ERR
        /// </summary>
        public static void RemoveHelpDeskContactPoint(this ERR message, int itemIndex)
        {
            int fieldNum = message.FindField("HelpDeskContactPoint");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OperatorID record from EVN
        /// </summary>
        public static void RemoveOperatorID(this EVN message, XCN item)
        {
            int fieldNum = message.FindField("OperatorID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OperatorID record from EVN
        /// </summary>
        public static void RemoveOperatorID(this EVN message, int itemIndex)
        {
            int fieldNum = message.FindField("OperatorID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an FacilityAddress record from FAC
        /// </summary>
        public static void RemoveFacilityAddress(this FAC message, XAD item)
        {
            int fieldNum = message.FindField("FacilityAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FacilityAddress record from FAC
        /// </summary>
        public static void RemoveFacilityAddress(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("FacilityAddress");
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
        /// Remove an SignatureAuthority record from FAC
        /// </summary>
        public static void RemoveSignatureAuthority(this FAC message, XCN item)
        {
            int fieldNum = message.FindField("SignatureAuthority");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SignatureAuthority record from FAC
        /// </summary>
        public static void RemoveSignatureAuthority(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("SignatureAuthority");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SignatureAuthorityAddress record from FAC
        /// </summary>
        public static void RemoveSignatureAuthorityAddress(this FAC message, XAD item)
        {
            int fieldNum = message.FindField("SignatureAuthorityAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SignatureAuthorityAddress record from FAC
        /// </summary>
        public static void RemoveSignatureAuthorityAddress(this FAC message, int itemIndex)
        {
            int fieldNum = message.FindField("SignatureAuthorityAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllDiagnosisCodeFT1Records(this FT1 message)
        {
            return message.GetAllRecords<CWE>("DiagnosisCodeFT1RepetitionsUsed", "GetDiagnosisCodeFT1");
        }

        /// <summary>
        /// Add a new DiagnosisCodeFT1 to FT1
        /// </summary>
        public static CWE AddDiagnosisCodeFT1(this FT1 message)
        {
            return message.GetDiagnosisCodeFT1(message.DiagnosisCodeFT1RepetitionsUsed);
        }

        /// <summary>
        /// Remove an DiagnosisCodeFT1 record from FT1
        /// </summary>
        public static void RemoveDiagnosisCodeFT1(this FT1 message, CWE item)
        {
            int fieldNum = message.FindField("DiagnosisCodeFT1");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DiagnosisCodeFT1 record from FT1
        /// </summary>
        public static void RemoveDiagnosisCodeFT1(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("DiagnosisCodeFT1");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PerformedByCode record from FT1
        /// </summary>
        public static void RemovePerformedByCode(this FT1 message, XCN item)
        {
            int fieldNum = message.FindField("PerformedByCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PerformedByCode record from FT1
        /// </summary>
        public static void RemovePerformedByCode(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("PerformedByCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderedByCode record from FT1
        /// </summary>
        public static void RemoveOrderedByCode(this FT1 message, XCN item)
        {
            int fieldNum = message.FindField("OrderedByCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderedByCode record from FT1
        /// </summary>
        public static void RemoveOrderedByCode(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderedByCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EnteredByCode record from FT1
        /// </summary>
        public static void RemoveEnteredByCode(this FT1 message, XCN item)
        {
            int fieldNum = message.FindField("EnteredByCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EnteredByCode record from FT1
        /// </summary>
        public static void RemoveEnteredByCode(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("EnteredByCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CNE> GetAllProcedureCodeModifierRecords(this FT1 message)
        {
            return message.GetAllRecords<CNE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Add a new ProcedureCodeModifier to FT1
        /// </summary>
        public static CNE AddProcedureCodeModifier(this FT1 message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from FT1
        /// </summary>
        public static void RemoveProcedureCodeModifier(this FT1 message, CNE item)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from FT1
        /// </summary>
        public static void RemoveProcedureCodeModifier(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new TransactionReferenceKey to FT1
        /// </summary>
        public static SI AddTransactionReferenceKey(this FT1 message)
        {
            return message.GetTransactionReferenceKey(message.TransactionReferenceKeyRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TransactionReferenceKey record from FT1
        /// </summary>
        public static void RemoveTransactionReferenceKey(this FT1 message, SI item)
        {
            int fieldNum = message.FindField("TransactionReferenceKey");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TransactionReferenceKey record from FT1
        /// </summary>
        public static void RemoveTransactionReferenceKey(this FT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("TransactionReferenceKey");
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
        public static List<CWE> GetAllGoalTargetTypeRecords(this GOL message)
        {
            return message.GetAllRecords<CWE>("GoalTargetTypeRepetitionsUsed", "GetGoalTargetType");
        }

        /// <summary>
        /// Add a new GoalTargetType to GOL
        /// </summary>
        public static CWE AddGoalTargetType(this GOL message)
        {
            return message.GetGoalTargetType(message.GoalTargetTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GoalTargetType record from GOL
        /// </summary>
        public static void RemoveGoalTargetType(this GOL message, CWE item)
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
        /// Add a new RevenueCode to GP1
        /// </summary>
        public static IS AddRevenueCode(this GP1 message)
        {
            return message.GetRevenueCode(message.RevenueCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RevenueCode record from GP1
        /// </summary>
        public static void RemoveRevenueCode(this GP1 message, IS item)
        {
            int fieldNum = message.FindField("RevenueCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RevenueCode record from GP1
        /// </summary>
        public static void RemoveRevenueCode(this GP1 message, int itemIndex)
        {
            int fieldNum = message.FindField("RevenueCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new OCEEditsPerVisitCode to GP1
        /// </summary>
        public static IS AddOCEEditsPerVisitCode(this GP1 message)
        {
            return message.GetOCEEditsPerVisitCode(message.OCEEditsPerVisitCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OCEEditsPerVisitCode record from GP1
        /// </summary>
        public static void RemoveOCEEditsPerVisitCode(this GP1 message, IS item)
        {
            int fieldNum = message.FindField("OCEEditsPerVisitCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OCEEditsPerVisitCode record from GP1
        /// </summary>
        public static void RemoveOCEEditsPerVisitCode(this GP1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OCEEditsPerVisitCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new OCEEditCode to GP2
        /// </summary>
        public static IS AddOCEEditCode(this GP2 message)
        {
            return message.GetOCEEditCode(message.OCEEditCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OCEEditCode record from GP2
        /// </summary>
        public static void RemoveOCEEditCode(this GP2 message, IS item)
        {
            int fieldNum = message.FindField("OCEEditCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OCEEditCode record from GP2
        /// </summary>
        public static void RemoveOCEEditCode(this GP2 message, int itemIndex)
        {
            int fieldNum = message.FindField("OCEEditCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new ModifierEditCode to GP2
        /// </summary>
        public static IS AddModifierEditCode(this GP2 message)
        {
            return message.GetModifierEditCode(message.ModifierEditCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ModifierEditCode record from GP2
        /// </summary>
        public static void RemoveModifierEditCode(this GP2 message, IS item)
        {
            int fieldNum = message.FindField("ModifierEditCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ModifierEditCode record from GP2
        /// </summary>
        public static void RemoveModifierEditCode(this GP2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ModifierEditCode");
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
        /// Remove an GuarantorEmployerPhoneNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerPhoneNumber(this GT1 message, XTN item)
        {
            int fieldNum = message.FindField("GuarantorEmployerPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorEmployerPhoneNumber record from GT1
        /// </summary>
        public static void RemoveGuarantorEmployerPhoneNumber(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorEmployerPhoneNumber");
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
        /// Remove an GuarantorOrganizationName record from GT1
        /// </summary>
        public static void RemoveGuarantorOrganizationName(this GT1 message, XON item)
        {
            int fieldNum = message.FindField("GuarantorOrganizationName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorOrganizationName record from GT1
        /// </summary>
        public static void RemoveGuarantorOrganizationName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorOrganizationName");
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
        /// Remove an AmbulatoryStatus record from GT1
        /// </summary>
        public static void RemoveAmbulatoryStatus(this GT1 message, IS item)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AmbulatoryStatus record from GT1
        /// </summary>
        public static void RemoveAmbulatoryStatus(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllCitizenshipRecords(this GT1 message)
        {
            return message.GetAllRecords<CWE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to GT1
        /// </summary>
        public static CWE AddCitizenship(this GT1 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from GT1
        /// </summary>
        public static void RemoveCitizenship(this GT1 message, CWE item)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Citizenship record from GT1
        /// </summary>
        public static void RemoveCitizenship(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an MotherSMaidenName record from GT1
        /// </summary>
        public static void RemoveMotherSMaidenName(this GT1 message, XPN item)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MotherSMaidenName record from GT1
        /// </summary>
        public static void RemoveMotherSMaidenName(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllEthnicGroupRecords(this GT1 message)
        {
            return message.GetAllRecords<CWE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Add a new EthnicGroup to GT1
        /// </summary>
        public static CWE AddEthnicGroup(this GT1 message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EthnicGroup record from GT1
        /// </summary>
        public static void RemoveEthnicGroup(this GT1 message, CWE item)
        {
            int fieldNum = message.FindField("EthnicGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EthnicGroup record from GT1
        /// </summary>
        public static void RemoveEthnicGroup(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("EthnicGroup");
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
        public static List<CWE> GetAllGuarantorRaceRecords(this GT1 message)
        {
            return message.GetAllRecords<CWE>("GuarantorRaceRepetitionsUsed", "GetGuarantorRace");
        }

        /// <summary>
        /// Add a new GuarantorRace to GT1
        /// </summary>
        public static CWE AddGuarantorRace(this GT1 message)
        {
            return message.GetGuarantorRace(message.GuarantorRaceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GuarantorRace record from GT1
        /// </summary>
        public static void RemoveGuarantorRace(this GT1 message, CWE item)
        {
            int fieldNum = message.FindField("GuarantorRace");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GuarantorRace record from GT1
        /// </summary>
        public static void RemoveGuarantorRace(this GT1 message, int itemIndex)
        {
            int fieldNum = message.FindField("GuarantorRace");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new AllergyReactionCode to IAM
        /// </summary>
        public static ST AddAllergyReactionCode(this IAM message)
        {
            return message.GetAllergyReactionCode(message.AllergyReactionCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AllergyReactionCode record from IAM
        /// </summary>
        public static void RemoveAllergyReactionCode(this IAM message, ST item)
        {
            int fieldNum = message.FindField("AllergyReactionCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AllergyReactionCode record from IAM
        /// </summary>
        public static void RemoveAllergyReactionCode(this IAM message, int itemIndex)
        {
            int fieldNum = message.FindField("AllergyReactionCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CNE> GetAllProcedureCodeModifierRecords(this IIM message)
        {
            return message.GetAllRecords<CNE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Add a new ProcedureCodeModifier to IIM
        /// </summary>
        public static CNE AddProcedureCodeModifier(this IIM message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from IIM
        /// </summary>
        public static void RemoveProcedureCodeModifier(this IIM message, CNE item)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from IIM
        /// </summary>
        public static void RemoveProcedureCodeModifier(this IIM message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
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
        /// Remove an InsuranceCoContactPerson record from IN1
        /// </summary>
        public static void RemoveInsuranceCoContactPerson(this IN1 message, XPN item)
        {
            int fieldNum = message.FindField("InsuranceCoContactPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCoContactPerson record from IN1
        /// </summary>
        public static void RemoveInsuranceCoContactPerson(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCoContactPerson");
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
        /// Remove an InsuredSGroupEmpID record from IN1
        /// </summary>
        public static void RemoveInsuredSGroupEmpID(this IN1 message, CX item)
        {
            int fieldNum = message.FindField("InsuredSGroupEmpID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSGroupEmpID record from IN1
        /// </summary>
        public static void RemoveInsuredSGroupEmpID(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSGroupEmpID");
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
        /// Remove an VerificationBy record from IN1
        /// </summary>
        public static void RemoveVerificationBy(this IN1 message, XCN item)
        {
            int fieldNum = message.FindField("VerificationBy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VerificationBy record from IN1
        /// </summary>
        public static void RemoveVerificationBy(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("VerificationBy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSEmployerSAddress record from IN1
        /// </summary>
        public static void RemoveInsuredSEmployerSAddress(this IN1 message, XAD item)
        {
            int fieldNum = message.FindField("InsuredSEmployerSAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployerSAddress record from IN1
        /// </summary>
        public static void RemoveInsuredSEmployerSAddress(this IN1 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployerSAddress");
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
        /// Remove an InsuredSEmployerSNameAndID record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerSNameAndID(this IN2 message, XCN item)
        {
            int fieldNum = message.FindField("InsuredSEmployerSNameAndID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployerSNameAndID record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerSNameAndID(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployerSNameAndID");
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
        /// Remove an MilitarySponsorName record from IN2
        /// </summary>
        public static void RemoveMilitarySponsorName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("MilitarySponsorName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MilitarySponsorName record from IN2
        /// </summary>
        public static void RemoveMilitarySponsorName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("MilitarySponsorName");
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
        /// Remove an RoomCoverageTypeAmount record from IN2
        /// </summary>
        public static void RemoveRoomCoverageTypeAmount(this IN2 message, RMC item)
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
        /// Remove an PolicyTypeAmount record from IN2
        /// </summary>
        public static void RemovePolicyTypeAmount(this IN2 message, PTA item)
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
        /// Remove an AmbulatoryStatus record from IN2
        /// </summary>
        public static void RemoveAmbulatoryStatus(this IN2 message, IS item)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AmbulatoryStatus record from IN2
        /// </summary>
        public static void RemoveAmbulatoryStatus(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("AmbulatoryStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllCitizenshipRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to IN2
        /// </summary>
        public static CWE AddCitizenship(this IN2 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from IN2
        /// </summary>
        public static void RemoveCitizenship(this IN2 message, CWE item)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Citizenship record from IN2
        /// </summary>
        public static void RemoveCitizenship(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an MotherSMaidenName record from IN2
        /// </summary>
        public static void RemoveMotherSMaidenName(this IN2 message, XPN item)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MotherSMaidenName record from IN2
        /// </summary>
        public static void RemoveMotherSMaidenName(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllEthnicGroupRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Add a new EthnicGroup to IN2
        /// </summary>
        public static CWE AddEthnicGroup(this IN2 message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EthnicGroup record from IN2
        /// </summary>
        public static void RemoveEthnicGroup(this IN2 message, CWE item)
        {
            int fieldNum = message.FindField("EthnicGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EthnicGroup record from IN2
        /// </summary>
        public static void RemoveEthnicGroup(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("EthnicGroup");
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
        public static List<CWE> GetAllMaritalStatusRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("MaritalStatusRepetitionsUsed", "GetMaritalStatus");
        }

        /// <summary>
        /// Add a new MaritalStatus to IN2
        /// </summary>
        public static CWE AddMaritalStatus(this IN2 message)
        {
            return message.GetMaritalStatus(message.MaritalStatusRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MaritalStatus record from IN2
        /// </summary>
        public static void RemoveMaritalStatus(this IN2 message, CWE item)
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
        /// Remove an InsuredSContactPersonPhoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonPhoneNumber(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuredSContactPersonPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSContactPersonPhoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSContactPersonPhoneNumber(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSContactPersonPhoneNumber");
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
        /// Get InsuranceCoContactPhoneNumber Records from IN2
        /// </summary>
        public static IEnumerable GetInsuranceCoContactPhoneNumberRecords(this IN2 message)
        {
            object[] result = message.GetRecords("InsuranceCoContactPhoneNumberRepetitionsUsed", "GetInsuranceCoContactPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InsuranceCoContactPhoneNumber Records from IN2
        /// </summary>
        public static List<XTN> GetAllInsuranceCoContactPhoneNumberRecords(this IN2 message)
        {
            return message.GetAllRecords<XTN>("InsuranceCoContactPhoneNumberRepetitionsUsed", "GetInsuranceCoContactPhoneNumber");
        }

        /// <summary>
        /// Add a new InsuranceCoContactPhoneNumber to IN2
        /// </summary>
        public static XTN AddInsuranceCoContactPhoneNumber(this IN2 message)
        {
            return message.GetInsuranceCoContactPhoneNumber(message.InsuranceCoContactPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an InsuranceCoContactPhoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuranceCoContactPhoneNumber(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuranceCoContactPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuranceCoContactPhoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuranceCoContactPhoneNumber(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuranceCoContactPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSPhoneNumberHome record from IN2
        /// </summary>
        public static void RemoveInsuredSPhoneNumberHome(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuredSPhoneNumberHome");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSPhoneNumberHome record from IN2
        /// </summary>
        public static void RemoveInsuredSPhoneNumberHome(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSPhoneNumberHome");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InsuredSEmployerPhoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerPhoneNumber(this IN2 message, XTN item)
        {
            int fieldNum = message.FindField("InsuredSEmployerPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InsuredSEmployerPhoneNumber record from IN2
        /// </summary>
        public static void RemoveInsuredSEmployerPhoneNumber(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("InsuredSEmployerPhoneNumber");
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
        public static List<CWE> GetAllRaceRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("RaceRepetitionsUsed", "GetRace");
        }

        /// <summary>
        /// Add a new Race to IN2
        /// </summary>
        public static CWE AddRace(this IN2 message)
        {
            return message.GetRace(message.RaceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Race record from IN2
        /// </summary>
        public static void RemoveRace(this IN2 message, CWE item)
        {
            int fieldNum = message.FindField("Race");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Race record from IN2
        /// </summary>
        public static void RemoveRace(this IN2 message, int itemIndex)
        {
            int fieldNum = message.FindField("Race");
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
        /// Add a new PreCertificationRequirement to IN3
        /// </summary>
        public static ICD AddPreCertificationRequirement(this IN3 message)
        {
            return message.GetPreCertificationRequirement(message.PreCertificationRequirementRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PreCertificationRequirement record from IN3
        /// </summary>
        public static void RemovePreCertificationRequirement(this IN3 message, ICD item)
        {
            int fieldNum = message.FindField("PreCertificationRequirement");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PreCertificationRequirement record from IN3
        /// </summary>
        public static void RemovePreCertificationRequirement(this IN3 message, int itemIndex)
        {
            int fieldNum = message.FindField("PreCertificationRequirement");
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
        public static List<CWE> GetAllSubstanceStatusRecords(this INV message)
        {
            return message.GetAllRecords<CWE>("SubstanceStatusRepetitionsUsed", "GetSubstanceStatus");
        }

        /// <summary>
        /// Add a new SubstanceStatus to INV
        /// </summary>
        public static CWE AddSubstanceStatus(this INV message)
        {
            return message.GetSubstanceStatus(message.SubstanceStatusRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceStatus record from INV
        /// </summary>
        public static void RemoveSubstanceStatus(this INV message, CWE item)
        {
            int fieldNum = message.FindField("SubstanceStatus");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceStatus record from INV
        /// </summary>
        public static void RemoveSubstanceStatus(this INV message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceStatus");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllTestFluidIdentifierSRecords(this INV message)
        {
            return message.GetAllRecords<CWE>("TestFluidIdentifierSRepetitionsUsed", "GetTestFluidIdentifierS");
        }

        /// <summary>
        /// Add a new TestFluidIdentifierS to INV
        /// </summary>
        public static CWE AddTestFluidIdentifierS(this INV message)
        {
            return message.GetTestFluidIdentifierS(message.TestFluidIdentifierSRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TestFluidIdentifierS record from INV
        /// </summary>
        public static void RemoveTestFluidIdentifierS(this INV message, CWE item)
        {
            int fieldNum = message.FindField("TestFluidIdentifierS");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TestFluidIdentifierS record from INV
        /// </summary>
        public static void RemoveTestFluidIdentifierS(this INV message, int itemIndex)
        {
            int fieldNum = message.FindField("TestFluidIdentifierS");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllProtocolCodeRecords(this IPC message)
        {
            return message.GetAllRecords<CWE>("ProtocolCodeRepetitionsUsed", "GetProtocolCode");
        }

        /// <summary>
        /// Add a new ProtocolCode to IPC
        /// </summary>
        public static CWE AddProtocolCode(this IPC message)
        {
            return message.GetProtocolCode(message.ProtocolCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProtocolCode record from IPC
        /// </summary>
        public static void RemoveProtocolCode(this IPC message, CWE item)
        {
            int fieldNum = message.FindField("ProtocolCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProtocolCode record from IPC
        /// </summary>
        public static void RemoveProtocolCode(this IPC message, int itemIndex)
        {
            int fieldNum = message.FindField("ProtocolCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllScheduledProcedureStepLocationRecords(this IPC message)
        {
            return message.GetAllRecords<CWE>("ScheduledProcedureStepLocationRepetitionsUsed", "GetScheduledProcedureStepLocation");
        }

        /// <summary>
        /// Add a new ScheduledProcedureStepLocation to IPC
        /// </summary>
        public static CWE AddScheduledProcedureStepLocation(this IPC message)
        {
            return message.GetScheduledProcedureStepLocation(message.ScheduledProcedureStepLocationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ScheduledProcedureStepLocation record from IPC
        /// </summary>
        public static void RemoveScheduledProcedureStepLocation(this IPC message, CWE item)
        {
            int fieldNum = message.FindField("ScheduledProcedureStepLocation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ScheduledProcedureStepLocation record from IPC
        /// </summary>
        public static void RemoveScheduledProcedureStepLocation(this IPC message, int itemIndex)
        {
            int fieldNum = message.FindField("ScheduledProcedureStepLocation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ApprovingRegulatoryAgency Records from ITM
        /// </summary>
        public static IEnumerable GetApprovingRegulatoryAgencyRecords(this ITM message)
        {
            object[] result = message.GetRecords("ApprovingRegulatoryAgencyRepetitionsUsed", "GetApprovingRegulatoryAgency");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ApprovingRegulatoryAgency Records from ITM
        /// </summary>
        public static List<XON> GetAllApprovingRegulatoryAgencyRecords(this ITM message)
        {
            return message.GetAllRecords<XON>("ApprovingRegulatoryAgencyRepetitionsUsed", "GetApprovingRegulatoryAgency");
        }

        /// <summary>
        /// Add a new ApprovingRegulatoryAgency to ITM
        /// </summary>
        public static XON AddApprovingRegulatoryAgency(this ITM message)
        {
            return message.GetApprovingRegulatoryAgency(message.ApprovingRegulatoryAgencyRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ApprovingRegulatoryAgency record from ITM
        /// </summary>
        public static void RemoveApprovingRegulatoryAgency(this ITM message, XON item)
        {
            int fieldNum = message.FindField("ApprovingRegulatoryAgency");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ApprovingRegulatoryAgency record from ITM
        /// </summary>
        public static void RemoveApprovingRegulatoryAgency(this ITM message, int itemIndex)
        {
            int fieldNum = message.FindField("ApprovingRegulatoryAgency");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get RulingAct Records from ITM
        /// </summary>
        public static IEnumerable GetRulingActRecords(this ITM message)
        {
            object[] result = message.GetRecords("RulingActRepetitionsUsed", "GetRulingAct");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RulingAct Records from ITM
        /// </summary>
        public static List<CWE> GetAllRulingActRecords(this ITM message)
        {
            return message.GetAllRecords<CWE>("RulingActRepetitionsUsed", "GetRulingAct");
        }

        /// <summary>
        /// Add a new RulingAct to ITM
        /// </summary>
        public static CWE AddRulingAct(this ITM message)
        {
            return message.GetRulingAct(message.RulingActRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RulingAct record from ITM
        /// </summary>
        public static void RemoveRulingAct(this ITM message, CWE item)
        {
            int fieldNum = message.FindField("RulingAct");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RulingAct record from ITM
        /// </summary>
        public static void RemoveRulingAct(this ITM message, int itemIndex)
        {
            int fieldNum = message.FindField("RulingAct");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ProcedureCodeModifier Records from ITM
        /// </summary>
        public static IEnumerable GetProcedureCodeModifierRecords(this ITM message)
        {
            object[] result = message.GetRecords("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProcedureCodeModifier Records from ITM
        /// </summary>
        public static List<CNE> GetAllProcedureCodeModifierRecords(this ITM message)
        {
            return message.GetAllRecords<CNE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Add a new ProcedureCodeModifier to ITM
        /// </summary>
        public static CNE AddProcedureCodeModifier(this ITM message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from ITM
        /// </summary>
        public static void RemoveProcedureCodeModifier(this ITM message, CNE item)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from ITM
        /// </summary>
        public static void RemoveProcedureCodeModifier(this ITM message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get VATRatesApplied Records from IVC
        /// </summary>
        public static IEnumerable GetVATRatesAppliedRecords(this IVC message)
        {
            object[] result = message.GetRecords("VATRatesAppliedRepetitionsUsed", "GetVATRatesApplied");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VATRatesApplied Records from IVC
        /// </summary>
        public static List<NM> GetAllVATRatesAppliedRecords(this IVC message)
        {
            return message.GetAllRecords<NM>("VATRatesAppliedRepetitionsUsed", "GetVATRatesApplied");
        }

        /// <summary>
        /// Add a new VATRatesApplied to IVC
        /// </summary>
        public static NM AddVATRatesApplied(this IVC message)
        {
            return message.GetVATRatesApplied(message.VATRatesAppliedRepetitionsUsed);
        }

        /// <summary>
        /// Remove an VATRatesApplied record from IVC
        /// </summary>
        public static void RemoveVATRatesApplied(this IVC message, NM item)
        {
            int fieldNum = message.FindField("VATRatesApplied");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VATRatesApplied record from IVC
        /// </summary>
        public static void RemoveVATRatesApplied(this IVC message, int itemIndex)
        {
            int fieldNum = message.FindField("VATRatesApplied");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get BinLocationIdentifier Records from IVT
        /// </summary>
        public static IEnumerable GetBinLocationIdentifierRecords(this IVT message)
        {
            object[] result = message.GetRecords("BinLocationIdentifierRepetitionsUsed", "GetBinLocationIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BinLocationIdentifier Records from IVT
        /// </summary>
        public static List<EI> GetAllBinLocationIdentifierRecords(this IVT message)
        {
            return message.GetAllRecords<EI>("BinLocationIdentifierRepetitionsUsed", "GetBinLocationIdentifier");
        }

        /// <summary>
        /// Add a new BinLocationIdentifier to IVT
        /// </summary>
        public static EI AddBinLocationIdentifier(this IVT message)
        {
            return message.GetBinLocationIdentifier(message.BinLocationIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BinLocationIdentifier record from IVT
        /// </summary>
        public static void RemoveBinLocationIdentifier(this IVT message, EI item)
        {
            int fieldNum = message.FindField("BinLocationIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an BinLocationIdentifier record from IVT
        /// </summary>
        public static void RemoveBinLocationIdentifier(this IVT message, int itemIndex)
        {
            int fieldNum = message.FindField("BinLocationIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get SubstituteItemIdentifier Records from IVT
        /// </summary>
        public static IEnumerable GetSubstituteItemIdentifierRecords(this IVT message)
        {
            object[] result = message.GetRecords("SubstituteItemIdentifierRepetitionsUsed", "GetSubstituteItemIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SubstituteItemIdentifier Records from IVT
        /// </summary>
        public static List<EI> GetAllSubstituteItemIdentifierRecords(this IVT message)
        {
            return message.GetAllRecords<EI>("SubstituteItemIdentifierRepetitionsUsed", "GetSubstituteItemIdentifier");
        }

        /// <summary>
        /// Add a new SubstituteItemIdentifier to IVT
        /// </summary>
        public static EI AddSubstituteItemIdentifier(this IVT message)
        {
            return message.GetSubstituteItemIdentifier(message.SubstituteItemIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstituteItemIdentifier record from IVT
        /// </summary>
        public static void RemoveSubstituteItemIdentifier(this IVT message, EI item)
        {
            int fieldNum = message.FindField("SubstituteItemIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstituteItemIdentifier record from IVT
        /// </summary>
        public static void RemoveSubstituteItemIdentifier(this IVT message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstituteItemIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllLanguageAbilityCodeRecords(this LAN message)
        {
            return message.GetAllRecords<CWE>("LanguageAbilityCodeRepetitionsUsed", "GetLanguageAbilityCode");
        }

        /// <summary>
        /// Add a new LanguageAbilityCode to LAN
        /// </summary>
        public static CWE AddLanguageAbilityCode(this LAN message)
        {
            return message.GetLanguageAbilityCode(message.LanguageAbilityCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an LanguageAbilityCode record from LAN
        /// </summary>
        public static void RemoveLanguageAbilityCode(this LAN message, CWE item)
        {
            int fieldNum = message.FindField("LanguageAbilityCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LanguageAbilityCode record from LAN
        /// </summary>
        public static void RemoveLanguageAbilityCode(this LAN message, int itemIndex)
        {
            int fieldNum = message.FindField("LanguageAbilityCode");
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
        public static List<CWE> GetAllAccommodationTypeRecords(this LCC message)
        {
            return message.GetAllRecords<CWE>("AccommodationTypeRepetitionsUsed", "GetAccommodationType");
        }

        /// <summary>
        /// Add a new AccommodationType to LCC
        /// </summary>
        public static CWE AddAccommodationType(this LCC message)
        {
            return message.GetAccommodationType(message.AccommodationTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AccommodationType record from LCC
        /// </summary>
        public static void RemoveAccommodationType(this LCC message, CWE item)
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
        public static List<CWE> GetAllChargeCodeRecords(this LCC message)
        {
            return message.GetAllRecords<CWE>("ChargeCodeRepetitionsUsed", "GetChargeCode");
        }

        /// <summary>
        /// Add a new ChargeCode to LCC
        /// </summary>
        public static CWE AddChargeCode(this LCC message)
        {
            return message.GetChargeCode(message.ChargeCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ChargeCode record from LCC
        /// </summary>
        public static void RemoveChargeCode(this LCC message, CWE item)
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
        public static List<CWE> GetAllSpecialtyTypeRecords(this LDP message)
        {
            return message.GetAllRecords<CWE>("SpecialtyTypeRepetitionsUsed", "GetSpecialtyType");
        }

        /// <summary>
        /// Add a new SpecialtyType to LDP
        /// </summary>
        public static CWE AddSpecialtyType(this LDP message)
        {
            return message.GetSpecialtyType(message.SpecialtyTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecialtyType record from LDP
        /// </summary>
        public static void RemoveSpecialtyType(this LDP message, CWE item)
        {
            int fieldNum = message.FindField("SpecialtyType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecialtyType record from LDP
        /// </summary>
        public static void RemoveSpecialtyType(this LDP message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecialtyType");
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
        /// Remove an ValidPatientClasses record from LDP
        /// </summary>
        public static void RemoveValidPatientClasses(this LDP message, IS item)
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
        /// Remove an LocationTypeLOC record from LOC
        /// </summary>
        public static void RemoveLocationTypeLOC(this LOC message, IS item)
        {
            int fieldNum = message.FindField("LocationTypeLOC");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationTypeLOC record from LOC
        /// </summary>
        public static void RemoveLocationTypeLOC(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationTypeLOC");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrganizationNameLOC record from LOC
        /// </summary>
        public static void RemoveOrganizationNameLOC(this LOC message, XON item)
        {
            int fieldNum = message.FindField("OrganizationNameLOC");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrganizationNameLOC record from LOC
        /// </summary>
        public static void RemoveOrganizationNameLOC(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("OrganizationNameLOC");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an LocationAddress record from LOC
        /// </summary>
        public static void RemoveLocationAddress(this LOC message, XAD item)
        {
            int fieldNum = message.FindField("LocationAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an LocationAddress record from LOC
        /// </summary>
        public static void RemoveLocationAddress(this LOC message, int itemIndex)
        {
            int fieldNum = message.FindField("LocationAddress");
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
        public static List<CWE> GetAllLicenseNumberRecords(this LOC message)
        {
            return message.GetAllRecords<CWE>("LicenseNumberRepetitionsUsed", "GetLicenseNumber");
        }

        /// <summary>
        /// Add a new LicenseNumber to LOC
        /// </summary>
        public static CWE AddLicenseNumber(this LOC message)
        {
            return message.GetLicenseNumber(message.LicenseNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an LicenseNumber record from LOC
        /// </summary>
        public static void RemoveLicenseNumber(this LOC message, CWE item)
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
        /// Remove an LocationEquipment record from LOC
        /// </summary>
        public static void RemoveLocationEquipment(this LOC message, IS item)
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
        /// Remove an OrganizationalLocationRelationshipValue record from LRL
        /// </summary>
        public static void RemoveOrganizationalLocationRelationshipValue(this LRL message, XON item)
        {
            int fieldNum = message.FindField("OrganizationalLocationRelationshipValue");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrganizationalLocationRelationshipValue record from LRL
        /// </summary>
        public static void RemoveOrganizationalLocationRelationshipValue(this LRL message, int itemIndex)
        {
            int fieldNum = message.FindField("OrganizationalLocationRelationshipValue");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new PrimaryKeyValueMFA to MFA
        /// </summary>
        public static Varies AddPrimaryKeyValueMFA(this MFA message)
        {
            return message.GetPrimaryKeyValueMFA(message.PrimaryKeyValueMFARepetitionsUsed);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueMFA record from MFA
        /// </summary>
        public static void RemovePrimaryKeyValueMFA(this MFA message, Varies item)
        {
            int fieldNum = message.FindField("PrimaryKeyValueMFA");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueMFA record from MFA
        /// </summary>
        public static void RemovePrimaryKeyValueMFA(this MFA message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValueMFA");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryKeyValueTypeMFA record from MFA
        /// </summary>
        public static void RemovePrimaryKeyValueTypeMFA(this MFA message, ID item)
        {
            int fieldNum = message.FindField("PrimaryKeyValueTypeMFA");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueTypeMFA record from MFA
        /// </summary>
        public static void RemovePrimaryKeyValueTypeMFA(this MFA message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValueTypeMFA");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryKeyValueMFE record from MFE
        /// </summary>
        public static void RemovePrimaryKeyValueMFE(this MFE message, Varies item)
        {
            int fieldNum = message.FindField("PrimaryKeyValueMFE");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueMFE record from MFE
        /// </summary>
        public static void RemovePrimaryKeyValueMFE(this MFE message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValueMFE");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryKeyValueType record from MFE
        /// </summary>
        public static void RemovePrimaryKeyValueType(this MFE message, ID item)
        {
            int fieldNum = message.FindField("PrimaryKeyValueType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueType record from MFE
        /// </summary>
        public static void RemovePrimaryKeyValueType(this MFE message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValueType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get MasterFileApplicationIdentifier Records from MFI
        /// </summary>
        public static IEnumerable GetMasterFileApplicationIdentifierRecords(this MFI message)
        {
            object[] result = message.GetRecords("MasterFileApplicationIdentifierRepetitionsUsed", "GetMasterFileApplicationIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MasterFileApplicationIdentifier Records from MFI
        /// </summary>
        public static List<HD> GetAllMasterFileApplicationIdentifierRecords(this MFI message)
        {
            return message.GetAllRecords<HD>("MasterFileApplicationIdentifierRepetitionsUsed", "GetMasterFileApplicationIdentifier");
        }

        /// <summary>
        /// Add a new MasterFileApplicationIdentifier to MFI
        /// </summary>
        public static HD AddMasterFileApplicationIdentifier(this MFI message)
        {
            return message.GetMasterFileApplicationIdentifier(message.MasterFileApplicationIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MasterFileApplicationIdentifier record from MFI
        /// </summary>
        public static void RemoveMasterFileApplicationIdentifier(this MFI message, HD item)
        {
            int fieldNum = message.FindField("MasterFileApplicationIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MasterFileApplicationIdentifier record from MFI
        /// </summary>
        public static void RemoveMasterFileApplicationIdentifier(this MFI message, int itemIndex)
        {
            int fieldNum = message.FindField("MasterFileApplicationIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PriorPatientIdentifierList record from MRG
        /// </summary>
        public static void RemovePriorPatientIdentifierList(this MRG message, CX item)
        {
            int fieldNum = message.FindField("PriorPatientIdentifierList");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PriorPatientIdentifierList record from MRG
        /// </summary>
        public static void RemovePriorPatientIdentifierList(this MRG message, int itemIndex)
        {
            int fieldNum = message.FindField("PriorPatientIdentifierList");
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
        /// Remove an PriorPatientName record from MRG
        /// </summary>
        public static void RemovePriorPatientName(this MRG message, XPN item)
        {
            int fieldNum = message.FindField("PriorPatientName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PriorPatientName record from MRG
        /// </summary>
        public static void RemovePriorPatientName(this MRG message, int itemIndex)
        {
            int fieldNum = message.FindField("PriorPatientName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an CharacterSet record from MSH
        /// </summary>
        public static void RemoveCharacterSet(this MSH message, ID item)
        {
            int fieldNum = message.FindField("CharacterSet");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CharacterSet record from MSH
        /// </summary>
        public static void RemoveCharacterSet(this MSH message, int itemIndex)
        {
            int fieldNum = message.FindField("CharacterSet");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new MessageProfileIdentifier to MSH
        /// </summary>
        public static EI AddMessageProfileIdentifier(this MSH message)
        {
            return message.GetMessageProfileIdentifier(message.MessageProfileIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MessageProfileIdentifier record from MSH
        /// </summary>
        public static void RemoveMessageProfileIdentifier(this MSH message, EI item)
        {
            int fieldNum = message.FindField("MessageProfileIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MessageProfileIdentifier record from MSH
        /// </summary>
        public static void RemoveMessageProfileIdentifier(this MSH message, int itemIndex)
        {
            int fieldNum = message.FindField("MessageProfileIdentifier");
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
        /// Remove an OrganizationNameNK1 record from NK1
        /// </summary>
        public static void RemoveOrganizationNameNK1(this NK1 message, XON item)
        {
            int fieldNum = message.FindField("OrganizationNameNK1");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrganizationNameNK1 record from NK1
        /// </summary>
        public static void RemoveOrganizationNameNK1(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("OrganizationNameNK1");
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
        public static List<CWE> GetAllCitizenshipRecords(this NK1 message)
        {
            return message.GetAllRecords<CWE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to NK1
        /// </summary>
        public static CWE AddCitizenship(this NK1 message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from NK1
        /// </summary>
        public static void RemoveCitizenship(this NK1 message, CWE item)
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
        /// Remove an MotherSMaidenName record from NK1
        /// </summary>
        public static void RemoveMotherSMaidenName(this NK1 message, XPN item)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MotherSMaidenName record from NK1
        /// </summary>
        public static void RemoveMotherSMaidenName(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllEthnicGroupRecords(this NK1 message)
        {
            return message.GetAllRecords<CWE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Add a new EthnicGroup to NK1
        /// </summary>
        public static CWE AddEthnicGroup(this NK1 message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EthnicGroup record from NK1
        /// </summary>
        public static void RemoveEthnicGroup(this NK1 message, CWE item)
        {
            int fieldNum = message.FindField("EthnicGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EthnicGroup record from NK1
        /// </summary>
        public static void RemoveEthnicGroup(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("EthnicGroup");
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
        public static List<CWE> GetAllContactReasonRecords(this NK1 message)
        {
            return message.GetAllRecords<CWE>("ContactReasonRepetitionsUsed", "GetContactReason");
        }

        /// <summary>
        /// Add a new ContactReason to NK1
        /// </summary>
        public static CWE AddContactReason(this NK1 message)
        {
            return message.GetContactReason(message.ContactReasonRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ContactReason record from NK1
        /// </summary>
        public static void RemoveContactReason(this NK1 message, CWE item)
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
        /// Remove an NextOfKinAssociatedPartySIdentifiers record from NK1
        /// </summary>
        public static void RemoveNextOfKinAssociatedPartySIdentifiers(this NK1 message, CX item)
        {
            int fieldNum = message.FindField("NextOfKinAssociatedPartySIdentifiers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NextOfKinAssociatedPartySIdentifiers record from NK1
        /// </summary>
        public static void RemoveNextOfKinAssociatedPartySIdentifiers(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("NextOfKinAssociatedPartySIdentifiers");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllRaceRecords(this NK1 message)
        {
            return message.GetAllRecords<CWE>("RaceRepetitionsUsed", "GetRace");
        }

        /// <summary>
        /// Add a new Race to NK1
        /// </summary>
        public static CWE AddRace(this NK1 message)
        {
            return message.GetRace(message.RaceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Race record from NK1
        /// </summary>
        public static void RemoveRace(this NK1 message, CWE item)
        {
            int fieldNum = message.FindField("Race");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Race record from NK1
        /// </summary>
        public static void RemoveRace(this NK1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Race");
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
        /// Remove an QuantityTiming record from OBR
        /// </summary>
        public static void RemoveQuantityTiming(this OBR message, TQ item)
        {
            int fieldNum = message.FindField("QuantityTiming");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an QuantityTiming record from OBR
        /// </summary>
        public static void RemoveQuantityTiming(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("QuantityTiming");
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
        public static List<CWE> GetAllReasonForStudyRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("ReasonForStudyRepetitionsUsed", "GetReasonForStudy");
        }

        /// <summary>
        /// Add a new ReasonForStudy to OBR
        /// </summary>
        public static CWE AddReasonForStudy(this OBR message)
        {
            return message.GetReasonForStudy(message.ReasonForStudyRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ReasonForStudy record from OBR
        /// </summary>
        public static void RemoveReasonForStudy(this OBR message, CWE item)
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
        /// Remove an AssistantResultInterpreter record from OBR
        /// </summary>
        public static void RemoveAssistantResultInterpreter(this OBR message, NDL item)
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
        /// Remove an Technician record from OBR
        /// </summary>
        public static void RemoveTechnician(this OBR message, NDL item)
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
        /// Remove an Transcriptionist record from OBR
        /// </summary>
        public static void RemoveTranscriptionist(this OBR message, NDL item)
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
        public static List<CWE> GetAllTransportLogisticsOfCollectedSampleRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("TransportLogisticsOfCollectedSampleRepetitionsUsed", "GetTransportLogisticsOfCollectedSample");
        }

        /// <summary>
        /// Add a new TransportLogisticsOfCollectedSample to OBR
        /// </summary>
        public static CWE AddTransportLogisticsOfCollectedSample(this OBR message)
        {
            return message.GetTransportLogisticsOfCollectedSample(message.TransportLogisticsOfCollectedSampleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TransportLogisticsOfCollectedSample record from OBR
        /// </summary>
        public static void RemoveTransportLogisticsOfCollectedSample(this OBR message, CWE item)
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
        public static List<CWE> GetAllCollectorSCommentRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("CollectorSCommentRepetitionsUsed", "GetCollectorSComment");
        }

        /// <summary>
        /// Add a new CollectorSComment to OBR
        /// </summary>
        public static CWE AddCollectorSComment(this OBR message)
        {
            return message.GetCollectorSComment(message.CollectorSCommentRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CollectorSComment record from OBR
        /// </summary>
        public static void RemoveCollectorSComment(this OBR message, CWE item)
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
        public static List<CWE> GetAllPlannedPatientTransportCommentRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("PlannedPatientTransportCommentRepetitionsUsed", "GetPlannedPatientTransportComment");
        }

        /// <summary>
        /// Add a new PlannedPatientTransportComment to OBR
        /// </summary>
        public static CWE AddPlannedPatientTransportComment(this OBR message)
        {
            return message.GetPlannedPatientTransportComment(message.PlannedPatientTransportCommentRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlannedPatientTransportComment record from OBR
        /// </summary>
        public static void RemovePlannedPatientTransportComment(this OBR message, CWE item)
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
        public static List<CNE> GetAllProcedureCodeModifierRecords(this OBR message)
        {
            return message.GetAllRecords<CNE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Add a new ProcedureCodeModifier to OBR
        /// </summary>
        public static CNE AddProcedureCodeModifier(this OBR message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from OBR
        /// </summary>
        public static void RemoveProcedureCodeModifier(this OBR message, CNE item)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from OBR
        /// </summary>
        public static void RemoveProcedureCodeModifier(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllPlacerSupplementalServiceInformationRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("PlacerSupplementalServiceInformationRepetitionsUsed", "GetPlacerSupplementalServiceInformation");
        }

        /// <summary>
        /// Add a new PlacerSupplementalServiceInformation to OBR
        /// </summary>
        public static CWE AddPlacerSupplementalServiceInformation(this OBR message)
        {
            return message.GetPlacerSupplementalServiceInformation(message.PlacerSupplementalServiceInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlacerSupplementalServiceInformation record from OBR
        /// </summary>
        public static void RemovePlacerSupplementalServiceInformation(this OBR message, CWE item)
        {
            int fieldNum = message.FindField("PlacerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerSupplementalServiceInformation record from OBR
        /// </summary>
        public static void RemovePlacerSupplementalServiceInformation(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllFillerSupplementalServiceInformationRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("FillerSupplementalServiceInformationRepetitionsUsed", "GetFillerSupplementalServiceInformation");
        }

        /// <summary>
        /// Add a new FillerSupplementalServiceInformation to OBR
        /// </summary>
        public static CWE AddFillerSupplementalServiceInformation(this OBR message)
        {
            return message.GetFillerSupplementalServiceInformation(message.FillerSupplementalServiceInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FillerSupplementalServiceInformation record from OBR
        /// </summary>
        public static void RemoveFillerSupplementalServiceInformation(this OBR message, CWE item)
        {
            int fieldNum = message.FindField("FillerSupplementalServiceInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerSupplementalServiceInformation record from OBR
        /// </summary>
        public static void RemoveFillerSupplementalServiceInformation(this OBR message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerSupplementalServiceInformation");
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
        public static List<IS> GetAllAbnormalFlagsRecords(this OBX message)
        {
            return message.GetAllRecords<IS>("AbnormalFlagsRepetitionsUsed", "GetAbnormalFlags");
        }

        /// <summary>
        /// Add a new AbnormalFlags to OBX
        /// </summary>
        public static IS AddAbnormalFlags(this OBX message)
        {
            return message.GetAbnormalFlags(message.AbnormalFlagsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AbnormalFlags record from OBX
        /// </summary>
        public static void RemoveAbnormalFlags(this OBX message, IS item)
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
        /// Add a new NatureOfAbnormalTest to OBX
        /// </summary>
        public static ID AddNatureOfAbnormalTest(this OBX message)
        {
            return message.GetNatureOfAbnormalTest(message.NatureOfAbnormalTestRepetitionsUsed);
        }

        /// <summary>
        /// Remove an NatureOfAbnormalTest record from OBX
        /// </summary>
        public static void RemoveNatureOfAbnormalTest(this OBX message, ID item)
        {
            int fieldNum = message.FindField("NatureOfAbnormalTest");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NatureOfAbnormalTest record from OBX
        /// </summary>
        public static void RemoveNatureOfAbnormalTest(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("NatureOfAbnormalTest");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ResponsibleObserver record from OBX
        /// </summary>
        public static void RemoveResponsibleObserver(this OBX message, XCN item)
        {
            int fieldNum = message.FindField("ResponsibleObserver");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ResponsibleObserver record from OBX
        /// </summary>
        public static void RemoveResponsibleObserver(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("ResponsibleObserver");
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
        public static List<CWE> GetAllObservationMethodRecords(this OBX message)
        {
            return message.GetAllRecords<CWE>("ObservationMethodRepetitionsUsed", "GetObservationMethod");
        }

        /// <summary>
        /// Add a new ObservationMethod to OBX
        /// </summary>
        public static CWE AddObservationMethod(this OBX message)
        {
            return message.GetObservationMethod(message.ObservationMethodRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ObservationMethod record from OBX
        /// </summary>
        public static void RemoveObservationMethod(this OBX message, CWE item)
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
        /// Add a new EquipmentInstanceIdentifier to OBX
        /// </summary>
        public static EI AddEquipmentInstanceIdentifier(this OBX message)
        {
            return message.GetEquipmentInstanceIdentifier(message.EquipmentInstanceIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EquipmentInstanceIdentifier record from OBX
        /// </summary>
        public static void RemoveEquipmentInstanceIdentifier(this OBX message, EI item)
        {
            int fieldNum = message.FindField("EquipmentInstanceIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EquipmentInstanceIdentifier record from OBX
        /// </summary>
        public static void RemoveEquipmentInstanceIdentifier(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("EquipmentInstanceIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ObservationSite Records from OBX
        /// </summary>
        public static IEnumerable GetObservationSiteRecords(this OBX message)
        {
            object[] result = message.GetRecords("ObservationSiteRepetitionsUsed", "GetObservationSite");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ObservationSite Records from OBX
        /// </summary>
        public static List<CWE> GetAllObservationSiteRecords(this OBX message)
        {
            return message.GetAllRecords<CWE>("ObservationSiteRepetitionsUsed", "GetObservationSite");
        }

        /// <summary>
        /// Add a new ObservationSite to OBX
        /// </summary>
        public static CWE AddObservationSite(this OBX message)
        {
            return message.GetObservationSite(message.ObservationSiteRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ObservationSite record from OBX
        /// </summary>
        public static void RemoveObservationSite(this OBX message, CWE item)
        {
            int fieldNum = message.FindField("ObservationSite");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ObservationSite record from OBX
        /// </summary>
        public static void RemoveObservationSite(this OBX message, int itemIndex)
        {
            int fieldNum = message.FindField("ObservationSite");
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
        public static List<CWE> GetAllServicePeriodRecords(this ODS message)
        {
            return message.GetAllRecords<CWE>("ServicePeriodRepetitionsUsed", "GetServicePeriod");
        }

        /// <summary>
        /// Add a new ServicePeriod to ODS
        /// </summary>
        public static CWE AddServicePeriod(this ODS message)
        {
            return message.GetServicePeriod(message.ServicePeriodRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ServicePeriod record from ODS
        /// </summary>
        public static void RemoveServicePeriod(this ODS message, CWE item)
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
        public static List<CWE> GetAllDietSupplementOrPreferenceCodeRecords(this ODS message)
        {
            return message.GetAllRecords<CWE>("DietSupplementOrPreferenceCodeRepetitionsUsed", "GetDietSupplementOrPreferenceCode");
        }

        /// <summary>
        /// Add a new DietSupplementOrPreferenceCode to ODS
        /// </summary>
        public static CWE AddDietSupplementOrPreferenceCode(this ODS message)
        {
            return message.GetDietSupplementOrPreferenceCode(message.DietSupplementOrPreferenceCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an DietSupplementOrPreferenceCode record from ODS
        /// </summary>
        public static void RemoveDietSupplementOrPreferenceCode(this ODS message, CWE item)
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
        /// Remove an TextInstruction record from ODS
        /// </summary>
        public static void RemoveTextInstruction(this ODS message, ST item)
        {
            int fieldNum = message.FindField("TextInstruction");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TextInstruction record from ODS
        /// </summary>
        public static void RemoveTextInstruction(this ODS message, int itemIndex)
        {
            int fieldNum = message.FindField("TextInstruction");
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
        public static List<CWE> GetAllServicePeriodRecords(this ODT message)
        {
            return message.GetAllRecords<CWE>("ServicePeriodRepetitionsUsed", "GetServicePeriod");
        }

        /// <summary>
        /// Add a new ServicePeriod to ODT
        /// </summary>
        public static CWE AddServicePeriod(this ODT message)
        {
            return message.GetServicePeriod(message.ServicePeriodRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ServicePeriod record from ODT
        /// </summary>
        public static void RemoveServicePeriod(this ODT message, CWE item)
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
        public static List<CWE> GetAllIdentityOfInstrumentUsedToPerformThisStudyRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("IdentityOfInstrumentUsedToPerformThisStudyRepetitionsUsed", "GetIdentityOfInstrumentUsedToPerformThisStudy");
        }

        /// <summary>
        /// Add a new IdentityOfInstrumentUsedToPerformThisStudy to OM1
        /// </summary>
        public static CWE AddIdentityOfInstrumentUsedToPerformThisStudy(this OM1 message)
        {
            return message.GetIdentityOfInstrumentUsedToPerformThisStudy(message.IdentityOfInstrumentUsedToPerformThisStudyRepetitionsUsed);
        }

        /// <summary>
        /// Remove an IdentityOfInstrumentUsedToPerformThisStudy record from OM1
        /// </summary>
        public static void RemoveIdentityOfInstrumentUsedToPerformThisStudy(this OM1 message, CWE item)
        {
            int fieldNum = message.FindField("IdentityOfInstrumentUsedToPerformThisStudy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an IdentityOfInstrumentUsedToPerformThisStudy record from OM1
        /// </summary>
        public static void RemoveIdentityOfInstrumentUsedToPerformThisStudy(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("IdentityOfInstrumentUsedToPerformThisStudy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllCodedRepresentationOfMethodRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("CodedRepresentationOfMethodRepetitionsUsed", "GetCodedRepresentationOfMethod");
        }

        /// <summary>
        /// Add a new CodedRepresentationOfMethod to OM1
        /// </summary>
        public static CWE AddCodedRepresentationOfMethod(this OM1 message)
        {
            return message.GetCodedRepresentationOfMethod(message.CodedRepresentationOfMethodRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CodedRepresentationOfMethod record from OM1
        /// </summary>
        public static void RemoveCodedRepresentationOfMethod(this OM1 message, CWE item)
        {
            int fieldNum = message.FindField("CodedRepresentationOfMethod");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CodedRepresentationOfMethod record from OM1
        /// </summary>
        public static void RemoveCodedRepresentationOfMethod(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("CodedRepresentationOfMethod");
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
        public static List<CWE> GetAllObservationProducingDepartmentSectionRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("ObservationProducingDepartmentSectionRepetitionsUsed", "GetObservationProducingDepartmentSection");
        }

        /// <summary>
        /// Add a new ObservationProducingDepartmentSection to OM1
        /// </summary>
        public static CWE AddObservationProducingDepartmentSection(this OM1 message)
        {
            return message.GetObservationProducingDepartmentSection(message.ObservationProducingDepartmentSectionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ObservationProducingDepartmentSection record from OM1
        /// </summary>
        public static void RemoveObservationProducingDepartmentSection(this OM1 message, CWE item)
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
        public static List<CWE> GetAllOutsideSiteSWhereObservationMayBePerformedRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("OutsideSiteSWhereObservationMayBePerformedRepetitionsUsed", "GetOutsideSiteSWhereObservationMayBePerformed");
        }

        /// <summary>
        /// Add a new OutsideSiteSWhereObservationMayBePerformed to OM1
        /// </summary>
        public static CWE AddOutsideSiteSWhereObservationMayBePerformed(this OM1 message)
        {
            return message.GetOutsideSiteSWhereObservationMayBePerformed(message.OutsideSiteSWhereObservationMayBePerformedRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OutsideSiteSWhereObservationMayBePerformed record from OM1
        /// </summary>
        public static void RemoveOutsideSiteSWhereObservationMayBePerformed(this OM1 message, CWE item)
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
        /// Remove an AddressOfOutsideSiteS record from OM1
        /// </summary>
        public static void RemoveAddressOfOutsideSiteS(this OM1 message, XAD item)
        {
            int fieldNum = message.FindField("AddressOfOutsideSiteS");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AddressOfOutsideSiteS record from OM1
        /// </summary>
        public static void RemoveAddressOfOutsideSiteS(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AddressOfOutsideSiteS");
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
        public static List<CWE> GetAllReflexTestsObservationsRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("ReflexTestsObservationsRepetitionsUsed", "GetReflexTestsObservations");
        }

        /// <summary>
        /// Add a new ReflexTestsObservations to OM1
        /// </summary>
        public static CWE AddReflexTestsObservations(this OM1 message)
        {
            return message.GetReflexTestsObservations(message.ReflexTestsObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ReflexTestsObservations record from OM1
        /// </summary>
        public static void RemoveReflexTestsObservations(this OM1 message, CWE item)
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
        /// Add a new ServiceTestObservationPerformanceSchedule to OM1
        /// </summary>
        public static ST AddServiceTestObservationPerformanceSchedule(this OM1 message)
        {
            return message.GetServiceTestObservationPerformanceSchedule(message.ServiceTestObservationPerformanceScheduleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ServiceTestObservationPerformanceSchedule record from OM1
        /// </summary>
        public static void RemoveServiceTestObservationPerformanceSchedule(this OM1 message, ST item)
        {
            int fieldNum = message.FindField("ServiceTestObservationPerformanceSchedule");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ServiceTestObservationPerformanceSchedule record from OM1
        /// </summary>
        public static void RemoveServiceTestObservationPerformanceSchedule(this OM1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ServiceTestObservationPerformanceSchedule");
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
        /// Get ReferenceNormalRangeForOrdinalAndContinuousObservations Records from OM2
        /// </summary>
        public static IEnumerable GetReferenceNormalRangeForOrdinalAndContinuousObservationsRecords(this OM2 message)
        {
            object[] result = message.GetRecords("ReferenceNormalRangeForOrdinalAndContinuousObservationsRepetitionsUsed", "GetReferenceNormalRangeForOrdinalAndContinuousObservations");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ReferenceNormalRangeForOrdinalAndContinuousObservations Records from OM2
        /// </summary>
        public static List<RFR> GetAllReferenceNormalRangeForOrdinalAndContinuousObservationsRecords(this OM2 message)
        {
            return message.GetAllRecords<RFR>("ReferenceNormalRangeForOrdinalAndContinuousObservationsRepetitionsUsed", "GetReferenceNormalRangeForOrdinalAndContinuousObservations");
        }

        /// <summary>
        /// Add a new ReferenceNormalRangeForOrdinalAndContinuousObservations to OM2
        /// </summary>
        public static RFR AddReferenceNormalRangeForOrdinalAndContinuousObservations(this OM2 message)
        {
            return message.GetReferenceNormalRangeForOrdinalAndContinuousObservations(message.ReferenceNormalRangeForOrdinalAndContinuousObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ReferenceNormalRangeForOrdinalAndContinuousObservations record from OM2
        /// </summary>
        public static void RemoveReferenceNormalRangeForOrdinalAndContinuousObservations(this OM2 message, RFR item)
        {
            int fieldNum = message.FindField("ReferenceNormalRangeForOrdinalAndContinuousObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReferenceNormalRangeForOrdinalAndContinuousObservations record from OM2
        /// </summary>
        public static void RemoveReferenceNormalRangeForOrdinalAndContinuousObservations(this OM2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ReferenceNormalRangeForOrdinalAndContinuousObservations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new CriticalRangeForOrdinalAndContinuousObservations to OM2
        /// </summary>
        public static RFR AddCriticalRangeForOrdinalAndContinuousObservations(this OM2 message)
        {
            return message.GetCriticalRangeForOrdinalAndContinuousObservations(message.CriticalRangeForOrdinalAndContinuousObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CriticalRangeForOrdinalAndContinuousObservations record from OM2
        /// </summary>
        public static void RemoveCriticalRangeForOrdinalAndContinuousObservations(this OM2 message, RFR item)
        {
            int fieldNum = message.FindField("CriticalRangeForOrdinalAndContinuousObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CriticalRangeForOrdinalAndContinuousObservations record from OM2
        /// </summary>
        public static void RemoveCriticalRangeForOrdinalAndContinuousObservations(this OM2 message, int itemIndex)
        {
            int fieldNum = message.FindField("CriticalRangeForOrdinalAndContinuousObservations");
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
        /// Remove an DeltaCheckCriteria record from OM2
        /// </summary>
        public static void RemoveDeltaCheckCriteria(this OM2 message, DLT item)
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
        public static List<CWE> GetAllValidCodedAnswersRecords(this OM3 message)
        {
            return message.GetAllRecords<CWE>("ValidCodedAnswersRepetitionsUsed", "GetValidCodedAnswers");
        }

        /// <summary>
        /// Add a new ValidCodedAnswers to OM3
        /// </summary>
        public static CWE AddValidCodedAnswers(this OM3 message)
        {
            return message.GetValidCodedAnswers(message.ValidCodedAnswersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ValidCodedAnswers record from OM3
        /// </summary>
        public static void RemoveValidCodedAnswers(this OM3 message, CWE item)
        {
            int fieldNum = message.FindField("ValidCodedAnswers");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ValidCodedAnswers record from OM3
        /// </summary>
        public static void RemoveValidCodedAnswers(this OM3 message, int itemIndex)
        {
            int fieldNum = message.FindField("ValidCodedAnswers");
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
        public static List<CWE> GetAllNormalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CWE>("NormalTextCodesForCategoricalObservationsRepetitionsUsed", "GetNormalTextCodesForCategoricalObservations");
        }

        /// <summary>
        /// Add a new NormalTextCodesForCategoricalObservations to OM3
        /// </summary>
        public static CWE AddNormalTextCodesForCategoricalObservations(this OM3 message)
        {
            return message.GetNormalTextCodesForCategoricalObservations(message.NormalTextCodesForCategoricalObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an NormalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveNormalTextCodesForCategoricalObservations(this OM3 message, CWE item)
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
        public static List<CWE> GetAllAbnormalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CWE>("AbnormalTextCodesForCategoricalObservationsRepetitionsUsed", "GetAbnormalTextCodesForCategoricalObservations");
        }

        /// <summary>
        /// Add a new AbnormalTextCodesForCategoricalObservations to OM3
        /// </summary>
        public static CWE AddAbnormalTextCodesForCategoricalObservations(this OM3 message)
        {
            return message.GetAbnormalTextCodesForCategoricalObservations(message.AbnormalTextCodesForCategoricalObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AbnormalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveAbnormalTextCodesForCategoricalObservations(this OM3 message, CWE item)
        {
            int fieldNum = message.FindField("AbnormalTextCodesForCategoricalObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AbnormalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveAbnormalTextCodesForCategoricalObservations(this OM3 message, int itemIndex)
        {
            int fieldNum = message.FindField("AbnormalTextCodesForCategoricalObservations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllCriticalTextCodesForCategoricalObservationsRecords(this OM3 message)
        {
            return message.GetAllRecords<CWE>("CriticalTextCodesForCategoricalObservationsRepetitionsUsed", "GetCriticalTextCodesForCategoricalObservations");
        }

        /// <summary>
        /// Add a new CriticalTextCodesForCategoricalObservations to OM3
        /// </summary>
        public static CWE AddCriticalTextCodesForCategoricalObservations(this OM3 message)
        {
            return message.GetCriticalTextCodesForCategoricalObservations(message.CriticalTextCodesForCategoricalObservationsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CriticalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveCriticalTextCodesForCategoricalObservations(this OM3 message, CWE item)
        {
            int fieldNum = message.FindField("CriticalTextCodesForCategoricalObservations");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CriticalTextCodesForCategoricalObservations record from OM3
        /// </summary>
        public static void RemoveCriticalTextCodesForCategoricalObservations(this OM3 message, int itemIndex)
        {
            int fieldNum = message.FindField("CriticalTextCodesForCategoricalObservations");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an SpecimenPriorities record from OM4
        /// </summary>
        public static void RemoveSpecimenPriorities(this OM4 message, ID item)
        {
            int fieldNum = message.FindField("SpecimenPriorities");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenPriorities record from OM4
        /// </summary>
        public static void RemoveSpecimenPriorities(this OM4 message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenPriorities");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllTestObservationsIncludedWithinAnOrderedTestBatteryRecords(this OM5 message)
        {
            return message.GetAllRecords<CWE>("TestObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed", "GetTestObservationsIncludedWithinAnOrderedTestBattery");
        }

        /// <summary>
        /// Add a new TestObservationsIncludedWithinAnOrderedTestBattery to OM5
        /// </summary>
        public static CWE AddTestObservationsIncludedWithinAnOrderedTestBattery(this OM5 message)
        {
            return message.GetTestObservationsIncludedWithinAnOrderedTestBattery(message.TestObservationsIncludedWithinAnOrderedTestBatteryRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TestObservationsIncludedWithinAnOrderedTestBattery record from OM5
        /// </summary>
        public static void RemoveTestObservationsIncludedWithinAnOrderedTestBattery(this OM5 message, CWE item)
        {
            int fieldNum = message.FindField("TestObservationsIncludedWithinAnOrderedTestBattery");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TestObservationsIncludedWithinAnOrderedTestBattery record from OM5
        /// </summary>
        public static void RemoveTestObservationsIncludedWithinAnOrderedTestBattery(this OM5 message, int itemIndex)
        {
            int fieldNum = message.FindField("TestObservationsIncludedWithinAnOrderedTestBattery");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllCategoryIdentifierRecords(this OM7 message)
        {
            return message.GetAllRecords<CWE>("CategoryIdentifierRepetitionsUsed", "GetCategoryIdentifier");
        }

        /// <summary>
        /// Add a new CategoryIdentifier to OM7
        /// </summary>
        public static CWE AddCategoryIdentifier(this OM7 message)
        {
            return message.GetCategoryIdentifier(message.CategoryIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CategoryIdentifier record from OM7
        /// </summary>
        public static void RemoveCategoryIdentifier(this OM7 message, CWE item)
        {
            int fieldNum = message.FindField("CategoryIdentifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CategoryIdentifier record from OM7
        /// </summary>
        public static void RemoveCategoryIdentifier(this OM7 message, int itemIndex)
        {
            int fieldNum = message.FindField("CategoryIdentifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new CategorySynonym to OM7
        /// </summary>
        public static ST AddCategorySynonym(this OM7 message)
        {
            return message.GetCategorySynonym(message.CategorySynonymRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CategorySynonym record from OM7
        /// </summary>
        public static void RemoveCategorySynonym(this OM7 message, ST item)
        {
            int fieldNum = message.FindField("CategorySynonym");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CategorySynonym record from OM7
        /// </summary>
        public static void RemoveCategorySynonym(this OM7 message, int itemIndex)
        {
            int fieldNum = message.FindField("CategorySynonym");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new OrderableAtLocation to OM7
        /// </summary>
        public static PL AddOrderableAtLocation(this OM7 message)
        {
            return message.GetOrderableAtLocation(message.OrderableAtLocationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OrderableAtLocation record from OM7
        /// </summary>
        public static void RemoveOrderableAtLocation(this OM7 message, PL item)
        {
            int fieldNum = message.FindField("OrderableAtLocation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderableAtLocation record from OM7
        /// </summary>
        public static void RemoveOrderableAtLocation(this OM7 message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderableAtLocation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllPrimaryKeyValueCDMRecords(this OM7 message)
        {
            return message.GetAllRecords<CWE>("PrimaryKeyValueCDMRepetitionsUsed", "GetPrimaryKeyValueCDM");
        }

        /// <summary>
        /// Add a new PrimaryKeyValueCDM to OM7
        /// </summary>
        public static CWE AddPrimaryKeyValueCDM(this OM7 message)
        {
            return message.GetPrimaryKeyValueCDM(message.PrimaryKeyValueCDMRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueCDM record from OM7
        /// </summary>
        public static void RemovePrimaryKeyValueCDM(this OM7 message, CWE item)
        {
            int fieldNum = message.FindField("PrimaryKeyValueCDM");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryKeyValueCDM record from OM7
        /// </summary>
        public static void RemovePrimaryKeyValueCDM(this OM7 message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryKeyValueCDM");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an QuantityTiming record from ORC
        /// </summary>
        public static void RemoveQuantityTiming(this ORC message, TQ item)
        {
            int fieldNum = message.FindField("QuantityTiming");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an QuantityTiming record from ORC
        /// </summary>
        public static void RemoveQuantityTiming(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("QuantityTiming");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EnteredBy record from ORC
        /// </summary>
        public static void RemoveEnteredBy(this ORC message, XCN item)
        {
            int fieldNum = message.FindField("EnteredBy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EnteredBy record from ORC
        /// </summary>
        public static void RemoveEnteredBy(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("EnteredBy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an VerifiedBy record from ORC
        /// </summary>
        public static void RemoveVerifiedBy(this ORC message, XCN item)
        {
            int fieldNum = message.FindField("VerifiedBy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VerifiedBy record from ORC
        /// </summary>
        public static void RemoveVerifiedBy(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("VerifiedBy");
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
        /// Remove an CallBackPhoneNumber record from ORC
        /// </summary>
        public static void RemoveCallBackPhoneNumber(this ORC message, XTN item)
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
        /// Remove an ActionBy record from ORC
        /// </summary>
        public static void RemoveActionBy(this ORC message, XCN item)
        {
            int fieldNum = message.FindField("ActionBy");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ActionBy record from ORC
        /// </summary>
        public static void RemoveActionBy(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("ActionBy");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderingFacilityName record from ORC
        /// </summary>
        public static void RemoveOrderingFacilityName(this ORC message, XON item)
        {
            int fieldNum = message.FindField("OrderingFacilityName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingFacilityName record from ORC
        /// </summary>
        public static void RemoveOrderingFacilityName(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingFacilityName");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderingFacilityAddress record from ORC
        /// </summary>
        public static void RemoveOrderingFacilityAddress(this ORC message, XAD item)
        {
            int fieldNum = message.FindField("OrderingFacilityAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingFacilityAddress record from ORC
        /// </summary>
        public static void RemoveOrderingFacilityAddress(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingFacilityAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderingFacilityPhoneNumber record from ORC
        /// </summary>
        public static void RemoveOrderingFacilityPhoneNumber(this ORC message, XTN item)
        {
            int fieldNum = message.FindField("OrderingFacilityPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingFacilityPhoneNumber record from ORC
        /// </summary>
        public static void RemoveOrderingFacilityPhoneNumber(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingFacilityPhoneNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an OrderingProviderAddress record from ORC
        /// </summary>
        public static void RemoveOrderingProviderAddress(this ORC message, XAD item)
        {
            int fieldNum = message.FindField("OrderingProviderAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingProviderAddress record from ORC
        /// </summary>
        public static void RemoveOrderingProviderAddress(this ORC message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingProviderAddress");
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
        /// Add a new PlaceOfWorship to PD1
        /// </summary>
        public static XON AddPlaceOfWorship(this PD1 message)
        {
            return message.GetPlaceOfWorship(message.PlaceOfWorshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlaceOfWorship record from PD1
        /// </summary>
        public static void RemovePlaceOfWorship(this PD1 message, XON item)
        {
            int fieldNum = message.FindField("PlaceOfWorship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlaceOfWorship record from PD1
        /// </summary>
        public static void RemovePlaceOfWorship(this PD1 message, int itemIndex)
        {
            int fieldNum = message.FindField("PlaceOfWorship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllAdvanceDirectiveCodeRecords(this PD1 message)
        {
            return message.GetAllRecords<CWE>("AdvanceDirectiveCodeRepetitionsUsed", "GetAdvanceDirectiveCode");
        }

        /// <summary>
        /// Add a new AdvanceDirectiveCode to PD1
        /// </summary>
        public static CWE AddAdvanceDirectiveCode(this PD1 message)
        {
            return message.GetAdvanceDirectiveCode(message.AdvanceDirectiveCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AdvanceDirectiveCode record from PD1
        /// </summary>
        public static void RemoveAdvanceDirectiveCode(this PD1 message, CWE item)
        {
            int fieldNum = message.FindField("AdvanceDirectiveCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AdvanceDirectiveCode record from PD1
        /// </summary>
        public static void RemoveAdvanceDirectiveCode(this PD1 message, int itemIndex)
        {
            int fieldNum = message.FindField("AdvanceDirectiveCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllDeathCauseCodeRecords(this PDA message)
        {
            return message.GetAllRecords<CWE>("DeathCauseCodeRepetitionsUsed", "GetDeathCauseCode");
        }

        /// <summary>
        /// Add a new DeathCauseCode to PDA
        /// </summary>
        public static CWE AddDeathCauseCode(this PDA message)
        {
            return message.GetDeathCauseCode(message.DeathCauseCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an DeathCauseCode record from PDA
        /// </summary>
        public static void RemoveDeathCauseCode(this PDA message, CWE item)
        {
            int fieldNum = message.FindField("DeathCauseCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DeathCauseCode record from PDA
        /// </summary>
        public static void RemoveDeathCauseCode(this PDA message, int itemIndex)
        {
            int fieldNum = message.FindField("DeathCauseCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ManufacturerDistributor record from PDC
        /// </summary>
        public static void RemoveManufacturerDistributor(this PDC message, XON item)
        {
            int fieldNum = message.FindField("ManufacturerDistributor");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ManufacturerDistributor record from PDC
        /// </summary>
        public static void RemoveManufacturerDistributor(this PDC message, int itemIndex)
        {
            int fieldNum = message.FindField("ManufacturerDistributor");
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
        public static List<CWE> GetAllEventIdentifiersUsedRecords(this PEO message)
        {
            return message.GetAllRecords<CWE>("EventIdentifiersUsedRepetitionsUsed", "GetEventIdentifiersUsed");
        }

        /// <summary>
        /// Add a new EventIdentifiersUsed to PEO
        /// </summary>
        public static CWE AddEventIdentifiersUsed(this PEO message)
        {
            return message.GetEventIdentifiersUsed(message.EventIdentifiersUsedRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EventIdentifiersUsed record from PEO
        /// </summary>
        public static void RemoveEventIdentifiersUsed(this PEO message, CWE item)
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
        public static List<CWE> GetAllEventSymptomDiagnosisCodeRecords(this PEO message)
        {
            return message.GetAllRecords<CWE>("EventSymptomDiagnosisCodeRepetitionsUsed", "GetEventSymptomDiagnosisCode");
        }

        /// <summary>
        /// Add a new EventSymptomDiagnosisCode to PEO
        /// </summary>
        public static CWE AddEventSymptomDiagnosisCode(this PEO message)
        {
            return message.GetEventSymptomDiagnosisCode(message.EventSymptomDiagnosisCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EventSymptomDiagnosisCode record from PEO
        /// </summary>
        public static void RemoveEventSymptomDiagnosisCode(this PEO message, CWE item)
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
        /// Remove an EventLocationOccurredAddress record from PEO
        /// </summary>
        public static void RemoveEventLocationOccurredAddress(this PEO message, XAD item)
        {
            int fieldNum = message.FindField("EventLocationOccurredAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventLocationOccurredAddress record from PEO
        /// </summary>
        public static void RemoveEventLocationOccurredAddress(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventLocationOccurredAddress");
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
        /// Get EventDescriptionFromOriginalReporter Records from PEO
        /// </summary>
        public static IEnumerable GetEventDescriptionFromOriginalReporterRecords(this PEO message)
        {
            object[] result = message.GetRecords("EventDescriptionFromOriginalReporterRepetitionsUsed", "GetEventDescriptionFromOriginalReporter");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EventDescriptionFromOriginalReporter Records from PEO
        /// </summary>
        public static List<FT> GetAllEventDescriptionFromOriginalReporterRecords(this PEO message)
        {
            return message.GetAllRecords<FT>("EventDescriptionFromOriginalReporterRepetitionsUsed", "GetEventDescriptionFromOriginalReporter");
        }

        /// <summary>
        /// Add a new EventDescriptionFromOriginalReporter to PEO
        /// </summary>
        public static FT AddEventDescriptionFromOriginalReporter(this PEO message)
        {
            return message.GetEventDescriptionFromOriginalReporter(message.EventDescriptionFromOriginalReporterRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EventDescriptionFromOriginalReporter record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromOriginalReporter(this PEO message, FT item)
        {
            int fieldNum = message.FindField("EventDescriptionFromOriginalReporter");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EventDescriptionFromOriginalReporter record from PEO
        /// </summary>
        public static void RemoveEventDescriptionFromOriginalReporter(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("EventDescriptionFromOriginalReporter");
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
        public static List<CWE> GetAllCauseOfDeathRecords(this PEO message)
        {
            return message.GetAllRecords<CWE>("CauseOfDeathRepetitionsUsed", "GetCauseOfDeath");
        }

        /// <summary>
        /// Add a new CauseOfDeath to PEO
        /// </summary>
        public static CWE AddCauseOfDeath(this PEO message)
        {
            return message.GetCauseOfDeath(message.CauseOfDeathRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CauseOfDeath record from PEO
        /// </summary>
        public static void RemoveCauseOfDeath(this PEO message, CWE item)
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
        /// Remove an PrimaryObserverName record from PEO
        /// </summary>
        public static void RemovePrimaryObserverName(this PEO message, XPN item)
        {
            int fieldNum = message.FindField("PrimaryObserverName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryObserverName record from PEO
        /// </summary>
        public static void RemovePrimaryObserverName(this PEO message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryObserverName");
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
        /// Remove an SenderOrganizationName record from PES
        /// </summary>
        public static void RemoveSenderOrganizationName(this PES message, XON item)
        {
            int fieldNum = message.FindField("SenderOrganizationName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SenderOrganizationName record from PES
        /// </summary>
        public static void RemoveSenderOrganizationName(this PES message, int itemIndex)
        {
            int fieldNum = message.FindField("SenderOrganizationName");
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
        /// Remove an PatientIdentifierList record from PID
        /// </summary>
        public static void RemovePatientIdentifierList(this PID message, CX item)
        {
            int fieldNum = message.FindField("PatientIdentifierList");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientIdentifierList record from PID
        /// </summary>
        public static void RemovePatientIdentifierList(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientIdentifierList");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an AlternatePatientIDPID record from PID
        /// </summary>
        public static void RemoveAlternatePatientIDPID(this PID message, CX item)
        {
            int fieldNum = message.FindField("AlternatePatientIDPID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AlternatePatientIDPID record from PID
        /// </summary>
        public static void RemoveAlternatePatientIDPID(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("AlternatePatientIDPID");
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
        /// Remove an MotherSMaidenName record from PID
        /// </summary>
        public static void RemoveMotherSMaidenName(this PID message, XPN item)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MotherSMaidenName record from PID
        /// </summary>
        public static void RemoveMotherSMaidenName(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("MotherSMaidenName");
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
        public static List<CWE> GetAllRaceRecords(this PID message)
        {
            return message.GetAllRecords<CWE>("RaceRepetitionsUsed", "GetRace");
        }

        /// <summary>
        /// Add a new Race to PID
        /// </summary>
        public static CWE AddRace(this PID message)
        {
            return message.GetRace(message.RaceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Race record from PID
        /// </summary>
        public static void RemoveRace(this PID message, CWE item)
        {
            int fieldNum = message.FindField("Race");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Race record from PID
        /// </summary>
        public static void RemoveRace(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("Race");
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
        public static List<CWE> GetAllEthnicGroupRecords(this PID message)
        {
            return message.GetAllRecords<CWE>("EthnicGroupRepetitionsUsed", "GetEthnicGroup");
        }

        /// <summary>
        /// Add a new EthnicGroup to PID
        /// </summary>
        public static CWE AddEthnicGroup(this PID message)
        {
            return message.GetEthnicGroup(message.EthnicGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EthnicGroup record from PID
        /// </summary>
        public static void RemoveEthnicGroup(this PID message, CWE item)
        {
            int fieldNum = message.FindField("EthnicGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EthnicGroup record from PID
        /// </summary>
        public static void RemoveEthnicGroup(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("EthnicGroup");
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
        public static List<CWE> GetAllCitizenshipRecords(this PID message)
        {
            return message.GetAllRecords<CWE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to PID
        /// </summary>
        public static CWE AddCitizenship(this PID message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from PID
        /// </summary>
        public static void RemoveCitizenship(this PID message, CWE item)
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
        /// Add a new IdentityReliabilityCode to PID
        /// </summary>
        public static IS AddIdentityReliabilityCode(this PID message)
        {
            return message.GetIdentityReliabilityCode(message.IdentityReliabilityCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an IdentityReliabilityCode record from PID
        /// </summary>
        public static void RemoveIdentityReliabilityCode(this PID message, IS item)
        {
            int fieldNum = message.FindField("IdentityReliabilityCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an IdentityReliabilityCode record from PID
        /// </summary>
        public static void RemoveIdentityReliabilityCode(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("IdentityReliabilityCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new TribalCitizenship to PID
        /// </summary>
        public static CWE AddTribalCitizenship(this PID message)
        {
            return message.GetTribalCitizenship(message.TribalCitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TribalCitizenship record from PID
        /// </summary>
        public static void RemoveTribalCitizenship(this PID message, CWE item)
        {
            int fieldNum = message.FindField("TribalCitizenship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TribalCitizenship record from PID
        /// </summary>
        public static void RemoveTribalCitizenship(this PID message, int itemIndex)
        {
            int fieldNum = message.FindField("TribalCitizenship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CNE> GetAllProcedureCodeModifierRecords(this PR1 message)
        {
            return message.GetAllRecords<CNE>("ProcedureCodeModifierRepetitionsUsed", "GetProcedureCodeModifier");
        }

        /// <summary>
        /// Add a new ProcedureCodeModifier to PR1
        /// </summary>
        public static CNE AddProcedureCodeModifier(this PR1 message)
        {
            return message.GetProcedureCodeModifier(message.ProcedureCodeModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from PR1
        /// </summary>
        public static void RemoveProcedureCodeModifier(this PR1 message, CNE item)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProcedureCodeModifier record from PR1
        /// </summary>
        public static void RemoveProcedureCodeModifier(this PR1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ProcedureCodeModifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllTissueTypeCodeRecords(this PR1 message)
        {
            return message.GetAllRecords<CWE>("TissueTypeCodeRepetitionsUsed", "GetTissueTypeCode");
        }

        /// <summary>
        /// Add a new TissueTypeCode to PR1
        /// </summary>
        public static CWE AddTissueTypeCode(this PR1 message)
        {
            return message.GetTissueTypeCode(message.TissueTypeCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an TissueTypeCode record from PR1
        /// </summary>
        public static void RemoveTissueTypeCode(this PR1 message, CWE item)
        {
            int fieldNum = message.FindField("TissueTypeCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TissueTypeCode record from PR1
        /// </summary>
        public static void RemoveTissueTypeCode(this PR1 message, int itemIndex)
        {
            int fieldNum = message.FindField("TissueTypeCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllPractitionerGroupRecords(this PRA message)
        {
            return message.GetAllRecords<CWE>("PractitionerGroupRepetitionsUsed", "GetPractitionerGroup");
        }

        /// <summary>
        /// Add a new PractitionerGroup to PRA
        /// </summary>
        public static CWE AddPractitionerGroup(this PRA message)
        {
            return message.GetPractitionerGroup(message.PractitionerGroupRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PractitionerGroup record from PRA
        /// </summary>
        public static void RemovePractitionerGroup(this PRA message, CWE item)
        {
            int fieldNum = message.FindField("PractitionerGroup");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PractitionerGroup record from PRA
        /// </summary>
        public static void RemovePractitionerGroup(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("PractitionerGroup");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PractitionerCategory record from PRA
        /// </summary>
        public static void RemovePractitionerCategory(this PRA message, IS item)
        {
            int fieldNum = message.FindField("PractitionerCategory");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PractitionerCategory record from PRA
        /// </summary>
        public static void RemovePractitionerCategory(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("PractitionerCategory");
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
        /// Remove an Specialty record from PRA
        /// </summary>
        public static void RemoveSpecialty(this PRA message, SPD item)
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
        /// Remove an PractitionerIDNumbers record from PRA
        /// </summary>
        public static void RemovePractitionerIDNumbers(this PRA message, PLN item)
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
        /// Remove an Privileges record from PRA
        /// </summary>
        public static void RemovePrivileges(this PRA message, PIP item)
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
        public static List<CWE> GetAllGovernmentReimbursementBillingEligibilityRecords(this PRA message)
        {
            return message.GetAllRecords<CWE>("GovernmentReimbursementBillingEligibilityRepetitionsUsed", "GetGovernmentReimbursementBillingEligibility");
        }

        /// <summary>
        /// Add a new GovernmentReimbursementBillingEligibility to PRA
        /// </summary>
        public static CWE AddGovernmentReimbursementBillingEligibility(this PRA message)
        {
            return message.GetGovernmentReimbursementBillingEligibility(message.GovernmentReimbursementBillingEligibilityRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GovernmentReimbursementBillingEligibility record from PRA
        /// </summary>
        public static void RemoveGovernmentReimbursementBillingEligibility(this PRA message, CWE item)
        {
            int fieldNum = message.FindField("GovernmentReimbursementBillingEligibility");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GovernmentReimbursementBillingEligibility record from PRA
        /// </summary>
        public static void RemoveGovernmentReimbursementBillingEligibility(this PRA message, int itemIndex)
        {
            int fieldNum = message.FindField("GovernmentReimbursementBillingEligibility");
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
        public static List<CWE> GetAllProblemManagementDisciplineRecords(this PRB message)
        {
            return message.GetAllRecords<CWE>("ProblemManagementDisciplineRepetitionsUsed", "GetProblemManagementDiscipline");
        }

        /// <summary>
        /// Add a new ProblemManagementDiscipline to PRB
        /// </summary>
        public static CWE AddProblemManagementDiscipline(this PRB message)
        {
            return message.GetProblemManagementDiscipline(message.ProblemManagementDisciplineRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProblemManagementDiscipline record from PRB
        /// </summary>
        public static void RemoveProblemManagementDiscipline(this PRB message, CWE item)
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
        public static List<CWE> GetAllFacilityIDPRCRecords(this PRC message)
        {
            return message.GetAllRecords<CWE>("FacilityIDPRCRepetitionsUsed", "GetFacilityIDPRC");
        }

        /// <summary>
        /// Add a new FacilityIDPRC to PRC
        /// </summary>
        public static CWE AddFacilityIDPRC(this PRC message)
        {
            return message.GetFacilityIDPRC(message.FacilityIDPRCRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FacilityIDPRC record from PRC
        /// </summary>
        public static void RemoveFacilityIDPRC(this PRC message, CWE item)
        {
            int fieldNum = message.FindField("FacilityIDPRC");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FacilityIDPRC record from PRC
        /// </summary>
        public static void RemoveFacilityIDPRC(this PRC message, int itemIndex)
        {
            int fieldNum = message.FindField("FacilityIDPRC");
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
        public static List<CWE> GetAllDepartmentRecords(this PRC message)
        {
            return message.GetAllRecords<CWE>("DepartmentRepetitionsUsed", "GetDepartment");
        }

        /// <summary>
        /// Add a new Department to PRC
        /// </summary>
        public static CWE AddDepartment(this PRC message)
        {
            return message.GetDepartment(message.DepartmentRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Department record from PRC
        /// </summary>
        public static void RemoveDepartment(this PRC message, CWE item)
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
        /// Remove an ValidPatientClasses record from PRC
        /// </summary>
        public static void RemoveValidPatientClasses(this PRC message, IS item)
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
        public static List<CWE> GetAllBillingCategoryRecords(this PRC message)
        {
            return message.GetAllRecords<CWE>("BillingCategoryRepetitionsUsed", "GetBillingCategory");
        }

        /// <summary>
        /// Add a new BillingCategory to PRC
        /// </summary>
        public static CWE AddBillingCategory(this PRC message)
        {
            return message.GetBillingCategory(message.BillingCategoryRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BillingCategory record from PRC
        /// </summary>
        public static void RemoveBillingCategory(this PRC message, CWE item)
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
        public static List<CWE> GetAllProviderRoleRecords(this PRD message)
        {
            return message.GetAllRecords<CWE>("ProviderRoleRepetitionsUsed", "GetProviderRole");
        }

        /// <summary>
        /// Add a new ProviderRole to PRD
        /// </summary>
        public static CWE AddProviderRole(this PRD message)
        {
            return message.GetProviderRole(message.ProviderRoleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderRole record from PRD
        /// </summary>
        public static void RemoveProviderRole(this PRD message, CWE item)
        {
            int fieldNum = message.FindField("ProviderRole");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderRole record from PRD
        /// </summary>
        public static void RemoveProviderRole(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderRole");
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
        /// Remove an ProviderAddress record from PRD
        /// </summary>
        public static void RemoveProviderAddress(this PRD message, XAD item)
        {
            int fieldNum = message.FindField("ProviderAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderAddress record from PRD
        /// </summary>
        public static void RemoveProviderAddress(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderAddress");
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
        public static List<PLN> GetAllProviderIdentifiersRecords(this PRD message)
        {
            return message.GetAllRecords<PLN>("ProviderIdentifiersRepetitionsUsed", "GetProviderIdentifiers");
        }

        /// <summary>
        /// Add a new ProviderIdentifiers to PRD
        /// </summary>
        public static PLN AddProviderIdentifiers(this PRD message)
        {
            return message.GetProviderIdentifiers(message.ProviderIdentifiersRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderIdentifiers record from PRD
        /// </summary>
        public static void RemoveProviderIdentifiers(this PRD message, PLN item)
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
        /// Get EffectiveEndDateOfProviderRole Records from PRD
        /// </summary>
        public static IEnumerable GetEffectiveEndDateOfProviderRoleRecords(this PRD message)
        {
            object[] result = message.GetRecords("EffectiveEndDateOfProviderRoleRepetitionsUsed", "GetEffectiveEndDateOfProviderRole");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EffectiveEndDateOfProviderRole Records from PRD
        /// </summary>
        public static List<DTM> GetAllEffectiveEndDateOfProviderRoleRecords(this PRD message)
        {
            return message.GetAllRecords<DTM>("EffectiveEndDateOfProviderRoleRepetitionsUsed", "GetEffectiveEndDateOfProviderRole");
        }

        /// <summary>
        /// Add a new EffectiveEndDateOfProviderRole to PRD
        /// </summary>
        public static DTM AddEffectiveEndDateOfProviderRole(this PRD message)
        {
            return message.GetEffectiveEndDateOfProviderRole(message.EffectiveEndDateOfProviderRoleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EffectiveEndDateOfProviderRole record from PRD
        /// </summary>
        public static void RemoveEffectiveEndDateOfProviderRole(this PRD message, DTM item)
        {
            int fieldNum = message.FindField("EffectiveEndDateOfProviderRole");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EffectiveEndDateOfProviderRole record from PRD
        /// </summary>
        public static void RemoveEffectiveEndDateOfProviderRole(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("EffectiveEndDateOfProviderRole");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ProviderOrganizationAddress Records from PRD
        /// </summary>
        public static IEnumerable GetProviderOrganizationAddressRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderOrganizationAddressRepetitionsUsed", "GetProviderOrganizationAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderOrganizationAddress Records from PRD
        /// </summary>
        public static List<XAD> GetAllProviderOrganizationAddressRecords(this PRD message)
        {
            return message.GetAllRecords<XAD>("ProviderOrganizationAddressRepetitionsUsed", "GetProviderOrganizationAddress");
        }

        /// <summary>
        /// Add a new ProviderOrganizationAddress to PRD
        /// </summary>
        public static XAD AddProviderOrganizationAddress(this PRD message)
        {
            return message.GetProviderOrganizationAddress(message.ProviderOrganizationAddressRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderOrganizationAddress record from PRD
        /// </summary>
        public static void RemoveProviderOrganizationAddress(this PRD message, XAD item)
        {
            int fieldNum = message.FindField("ProviderOrganizationAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderOrganizationAddress record from PRD
        /// </summary>
        public static void RemoveProviderOrganizationAddress(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderOrganizationAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ProviderOrganizationLocationInformation Records from PRD
        /// </summary>
        public static IEnumerable GetProviderOrganizationLocationInformationRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderOrganizationLocationInformationRepetitionsUsed", "GetProviderOrganizationLocationInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderOrganizationLocationInformation Records from PRD
        /// </summary>
        public static List<PL> GetAllProviderOrganizationLocationInformationRecords(this PRD message)
        {
            return message.GetAllRecords<PL>("ProviderOrganizationLocationInformationRepetitionsUsed", "GetProviderOrganizationLocationInformation");
        }

        /// <summary>
        /// Add a new ProviderOrganizationLocationInformation to PRD
        /// </summary>
        public static PL AddProviderOrganizationLocationInformation(this PRD message)
        {
            return message.GetProviderOrganizationLocationInformation(message.ProviderOrganizationLocationInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderOrganizationLocationInformation record from PRD
        /// </summary>
        public static void RemoveProviderOrganizationLocationInformation(this PRD message, PL item)
        {
            int fieldNum = message.FindField("ProviderOrganizationLocationInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderOrganizationLocationInformation record from PRD
        /// </summary>
        public static void RemoveProviderOrganizationLocationInformation(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderOrganizationLocationInformation");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ProviderOrganizationCommunicationInformation Records from PRD
        /// </summary>
        public static IEnumerable GetProviderOrganizationCommunicationInformationRecords(this PRD message)
        {
            object[] result = message.GetRecords("ProviderOrganizationCommunicationInformationRepetitionsUsed", "GetProviderOrganizationCommunicationInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ProviderOrganizationCommunicationInformation Records from PRD
        /// </summary>
        public static List<XTN> GetAllProviderOrganizationCommunicationInformationRecords(this PRD message)
        {
            return message.GetAllRecords<XTN>("ProviderOrganizationCommunicationInformationRepetitionsUsed", "GetProviderOrganizationCommunicationInformation");
        }

        /// <summary>
        /// Add a new ProviderOrganizationCommunicationInformation to PRD
        /// </summary>
        public static XTN AddProviderOrganizationCommunicationInformation(this PRD message)
        {
            return message.GetProviderOrganizationCommunicationInformation(message.ProviderOrganizationCommunicationInformationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderOrganizationCommunicationInformation record from PRD
        /// </summary>
        public static void RemoveProviderOrganizationCommunicationInformation(this PRD message, XTN item)
        {
            int fieldNum = message.FindField("ProviderOrganizationCommunicationInformation");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderOrganizationCommunicationInformation record from PRD
        /// </summary>
        public static void RemoveProviderOrganizationCommunicationInformation(this PRD message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderOrganizationCommunicationInformation");
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
        /// Remove an ContractCode record from PV1
        /// </summary>
        public static void RemoveContractCode(this PV1 message, IS item)
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
        /// Add a new VisitUserCode to PV2
        /// </summary>
        public static IS AddVisitUserCode(this PV2 message)
        {
            return message.GetVisitUserCode(message.VisitUserCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an VisitUserCode record from PV2
        /// </summary>
        public static void RemoveVisitUserCode(this PV2 message, IS item)
        {
            int fieldNum = message.FindField("VisitUserCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VisitUserCode record from PV2
        /// </summary>
        public static void RemoveVisitUserCode(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("VisitUserCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an ReferralSourceCode record from PV2
        /// </summary>
        public static void RemoveReferralSourceCode(this PV2 message, XCN item)
        {
            int fieldNum = message.FindField("ReferralSourceCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ReferralSourceCode record from PV2
        /// </summary>
        public static void RemoveReferralSourceCode(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("ReferralSourceCode");
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
        public static List<CWE> GetAllRecreationalDrugUseCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CWE>("RecreationalDrugUseCodeRepetitionsUsed", "GetRecreationalDrugUseCode");
        }

        /// <summary>
        /// Add a new RecreationalDrugUseCode to PV2
        /// </summary>
        public static CWE AddRecreationalDrugUseCode(this PV2 message)
        {
            return message.GetRecreationalDrugUseCode(message.RecreationalDrugUseCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RecreationalDrugUseCode record from PV2
        /// </summary>
        public static void RemoveRecreationalDrugUseCode(this PV2 message, CWE item)
        {
            int fieldNum = message.FindField("RecreationalDrugUseCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RecreationalDrugUseCode record from PV2
        /// </summary>
        public static void RemoveRecreationalDrugUseCode(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RecreationalDrugUseCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllPrecautionCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CWE>("PrecautionCodeRepetitionsUsed", "GetPrecautionCode");
        }

        /// <summary>
        /// Add a new PrecautionCode to PV2
        /// </summary>
        public static CWE AddPrecautionCode(this PV2 message)
        {
            return message.GetPrecautionCode(message.PrecautionCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PrecautionCode record from PV2
        /// </summary>
        public static void RemovePrecautionCode(this PV2 message, CWE item)
        {
            int fieldNum = message.FindField("PrecautionCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrecautionCode record from PV2
        /// </summary>
        public static void RemovePrecautionCode(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("PrecautionCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllAdvanceDirectiveCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CWE>("AdvanceDirectiveCodeRepetitionsUsed", "GetAdvanceDirectiveCode");
        }

        /// <summary>
        /// Add a new AdvanceDirectiveCode to PV2
        /// </summary>
        public static CWE AddAdvanceDirectiveCode(this PV2 message)
        {
            return message.GetAdvanceDirectiveCode(message.AdvanceDirectiveCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AdvanceDirectiveCode record from PV2
        /// </summary>
        public static void RemoveAdvanceDirectiveCode(this PV2 message, CWE item)
        {
            int fieldNum = message.FindField("AdvanceDirectiveCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AdvanceDirectiveCode record from PV2
        /// </summary>
        public static void RemoveAdvanceDirectiveCode(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("AdvanceDirectiveCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new NotifyClergyCode to PV2
        /// </summary>
        public static IS AddNotifyClergyCode(this PV2 message)
        {
            return message.GetNotifyClergyCode(message.NotifyClergyCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an NotifyClergyCode record from PV2
        /// </summary>
        public static void RemoveNotifyClergyCode(this PV2 message, IS item)
        {
            int fieldNum = message.FindField("NotifyClergyCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an NotifyClergyCode record from PV2
        /// </summary>
        public static void RemoveNotifyClergyCode(this PV2 message, int itemIndex)
        {
            int fieldNum = message.FindField("NotifyClergyCode");
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
        public static List<CWE> GetAllWhatSubjectFilterRecords(this QRD message)
        {
            return message.GetAllRecords<CWE>("WhatSubjectFilterRepetitionsUsed", "GetWhatSubjectFilter");
        }

        /// <summary>
        /// Add a new WhatSubjectFilter to QRD
        /// </summary>
        public static CWE AddWhatSubjectFilter(this QRD message)
        {
            return message.GetWhatSubjectFilter(message.WhatSubjectFilterRepetitionsUsed);
        }

        /// <summary>
        /// Remove an WhatSubjectFilter record from QRD
        /// </summary>
        public static void RemoveWhatSubjectFilter(this QRD message, CWE item)
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
        public static List<CWE> GetAllWhatDepartmentDataCodeRecords(this QRD message)
        {
            return message.GetAllRecords<CWE>("WhatDepartmentDataCodeRepetitionsUsed", "GetWhatDepartmentDataCode");
        }

        /// <summary>
        /// Add a new WhatDepartmentDataCode to QRD
        /// </summary>
        public static CWE AddWhatDepartmentDataCode(this QRD message)
        {
            return message.GetWhatDepartmentDataCode(message.WhatDepartmentDataCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an WhatDepartmentDataCode record from QRD
        /// </summary>
        public static void RemoveWhatDepartmentDataCode(this QRD message, CWE item)
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
        /// Remove an WhatDataCodeValueQual record from QRD
        /// </summary>
        public static void RemoveWhatDataCodeValueQual(this QRD message, VR item)
        {
            int fieldNum = message.FindField("WhatDataCodeValueQual");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an WhatDataCodeValueQual record from QRD
        /// </summary>
        public static void RemoveWhatDataCodeValueQual(this QRD message, int itemIndex)
        {
            int fieldNum = message.FindField("WhatDataCodeValueQual");
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
        /// Add a new MatchReasonCode to QRI
        /// </summary>
        public static IS AddMatchReasonCode(this QRI message)
        {
            return message.GetMatchReasonCode(message.MatchReasonCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an MatchReasonCode record from QRI
        /// </summary>
        public static void RemoveMatchReasonCode(this QRI message, IS item)
        {
            int fieldNum = message.FindField("MatchReasonCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an MatchReasonCode record from QRI
        /// </summary>
        public static void RemoveMatchReasonCode(this QRI message, int itemIndex)
        {
            int fieldNum = message.FindField("MatchReasonCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SortByField to RCP
        /// </summary>
        public static SRT AddSortByField(this RCP message)
        {
            return message.GetSortByField(message.SortByFieldRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SortByField record from RCP
        /// </summary>
        public static void RemoveSortByField(this RCP message, SRT item)
        {
            int fieldNum = message.FindField("SortByField");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SortByField record from RCP
        /// </summary>
        public static void RemoveSortByField(this RCP message, int itemIndex)
        {
            int fieldNum = message.FindField("SortByField");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SegmentGroupInclusion to RCP
        /// </summary>
        public static ID AddSegmentGroupInclusion(this RCP message)
        {
            return message.GetSegmentGroupInclusion(message.SegmentGroupInclusionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SegmentGroupInclusion record from RCP
        /// </summary>
        public static void RemoveSegmentGroupInclusion(this RCP message, ID item)
        {
            int fieldNum = message.FindField("SegmentGroupInclusion");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SegmentGroupInclusion record from RCP
        /// </summary>
        public static void RemoveSegmentGroupInclusion(this RCP message, int itemIndex)
        {
            int fieldNum = message.FindField("SegmentGroupInclusion");
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
        public static List<CWE> GetAllReferralDispositionRecords(this RF1 message)
        {
            return message.GetAllRecords<CWE>("ReferralDispositionRepetitionsUsed", "GetReferralDisposition");
        }

        /// <summary>
        /// Add a new ReferralDisposition to RF1
        /// </summary>
        public static CWE AddReferralDisposition(this RF1 message)
        {
            return message.GetReferralDisposition(message.ReferralDispositionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ReferralDisposition record from RF1
        /// </summary>
        public static void RemoveReferralDisposition(this RF1 message, CWE item)
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
        public static List<CWE> GetAllReferralReasonRecords(this RF1 message)
        {
            return message.GetAllRecords<CWE>("ReferralReasonRepetitionsUsed", "GetReferralReason");
        }

        /// <summary>
        /// Add a new ReferralReason to RF1
        /// </summary>
        public static CWE AddReferralReason(this RF1 message)
        {
            return message.GetReferralReason(message.ReferralReasonRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ReferralReason record from RF1
        /// </summary>
        public static void RemoveReferralReason(this RF1 message, CWE item)
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
        /// Remove an RolePerson record from ROL
        /// </summary>
        public static void RemoveRolePerson(this ROL message, XCN item)
        {
            int fieldNum = message.FindField("RolePerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RolePerson record from ROL
        /// </summary>
        public static void RemoveRolePerson(this ROL message, int itemIndex)
        {
            int fieldNum = message.FindField("RolePerson");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllProviderTypeRecords(this ROL message)
        {
            return message.GetAllRecords<CWE>("ProviderTypeRepetitionsUsed", "GetProviderType");
        }

        /// <summary>
        /// Add a new ProviderType to ROL
        /// </summary>
        public static CWE AddProviderType(this ROL message)
        {
            return message.GetProviderType(message.ProviderTypeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderType record from ROL
        /// </summary>
        public static void RemoveProviderType(this ROL message, CWE item)
        {
            int fieldNum = message.FindField("ProviderType");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderType record from ROL
        /// </summary>
        public static void RemoveProviderType(this ROL message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderType");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new OfficeHomeAddressBirthplace to ROL
        /// </summary>
        public static XAD AddOfficeHomeAddressBirthplace(this ROL message)
        {
            return message.GetOfficeHomeAddressBirthplace(message.OfficeHomeAddressBirthplaceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OfficeHomeAddressBirthplace record from ROL
        /// </summary>
        public static void RemoveOfficeHomeAddressBirthplace(this ROL message, XAD item)
        {
            int fieldNum = message.FindField("OfficeHomeAddressBirthplace");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OfficeHomeAddressBirthplace record from ROL
        /// </summary>
        public static void RemoveOfficeHomeAddressBirthplace(this ROL message, int itemIndex)
        {
            int fieldNum = message.FindField("OfficeHomeAddressBirthplace");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new Phone to ROL
        /// </summary>
        public static XTN AddPhone(this ROL message)
        {
            return message.GetPhone(message.PhoneRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Phone record from ROL
        /// </summary>
        public static void RemovePhone(this ROL message, XTN item)
        {
            int fieldNum = message.FindField("Phone");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Phone record from ROL
        /// </summary>
        public static void RemovePhone(this ROL message, int itemIndex)
        {
            int fieldNum = message.FindField("Phone");
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
        public static List<CWE> GetAllAdministrationNotesRecords(this RXA message)
        {
            return message.GetAllRecords<CWE>("AdministrationNotesRepetitionsUsed", "GetAdministrationNotes");
        }

        /// <summary>
        /// Add a new AdministrationNotes to RXA
        /// </summary>
        public static CWE AddAdministrationNotes(this RXA message)
        {
            return message.GetAdministrationNotes(message.AdministrationNotesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AdministrationNotes record from RXA
        /// </summary>
        public static void RemoveAdministrationNotes(this RXA message, CWE item)
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
        /// Remove an AdministeringProvider record from RXA
        /// </summary>
        public static void RemoveAdministeringProvider(this RXA message, XCN item)
        {
            int fieldNum = message.FindField("AdministeringProvider");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AdministeringProvider record from RXA
        /// </summary>
        public static void RemoveAdministeringProvider(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("AdministeringProvider");
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
        public static List<DTM> GetAllSubstanceExpirationDateRecords(this RXA message)
        {
            return message.GetAllRecords<DTM>("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");
        }

        /// <summary>
        /// Add a new SubstanceExpirationDate to RXA
        /// </summary>
        public static DTM AddSubstanceExpirationDate(this RXA message)
        {
            return message.GetSubstanceExpirationDate(message.SubstanceExpirationDateRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceExpirationDate record from RXA
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXA message, DTM item)
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
        public static List<CWE> GetAllSubstanceManufacturerNameRecords(this RXA message)
        {
            return message.GetAllRecords<CWE>("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");
        }

        /// <summary>
        /// Add a new SubstanceManufacturerName to RXA
        /// </summary>
        public static CWE AddSubstanceManufacturerName(this RXA message)
        {
            return message.GetSubstanceManufacturerName(message.SubstanceManufacturerNameRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceManufacturerName record from RXA
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXA message, CWE item)
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
        public static List<CWE> GetAllSubstanceTreatmentRefusalReasonRecords(this RXA message)
        {
            return message.GetAllRecords<CWE>("SubstanceTreatmentRefusalReasonRepetitionsUsed", "GetSubstanceTreatmentRefusalReason");
        }

        /// <summary>
        /// Add a new SubstanceTreatmentRefusalReason to RXA
        /// </summary>
        public static CWE AddSubstanceTreatmentRefusalReason(this RXA message)
        {
            return message.GetSubstanceTreatmentRefusalReason(message.SubstanceTreatmentRefusalReasonRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceTreatmentRefusalReason record from RXA
        /// </summary>
        public static void RemoveSubstanceTreatmentRefusalReason(this RXA message, CWE item)
        {
            int fieldNum = message.FindField("SubstanceTreatmentRefusalReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SubstanceTreatmentRefusalReason record from RXA
        /// </summary>
        public static void RemoveSubstanceTreatmentRefusalReason(this RXA message, int itemIndex)
        {
            int fieldNum = message.FindField("SubstanceTreatmentRefusalReason");
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
        public static List<CWE> GetAllIndicationRecords(this RXA message)
        {
            return message.GetAllRecords<CWE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Add a new Indication to RXA
        /// </summary>
        public static CWE AddIndication(this RXA message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Indication record from RXA
        /// </summary>
        public static void RemoveIndication(this RXA message, CWE item)
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
        public static List<CWE> GetAllSupplementaryCodeRecords(this RXC message)
        {
            return message.GetAllRecords<CWE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Add a new SupplementaryCode to RXC
        /// </summary>
        public static CWE AddSupplementaryCode(this RXC message)
        {
            return message.GetSupplementaryCode(message.SupplementaryCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXC
        /// </summary>
        public static void RemoveSupplementaryCode(this RXC message, CWE item)
        {
            int fieldNum = message.FindField("SupplementaryCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXC
        /// </summary>
        public static void RemoveSupplementaryCode(this RXC message, int itemIndex)
        {
            int fieldNum = message.FindField("SupplementaryCode");
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
        /// Remove an DispenseNotes record from RXD
        /// </summary>
        public static void RemoveDispenseNotes(this RXD message, ST item)
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
        /// Remove an DispensingProvider record from RXD
        /// </summary>
        public static void RemoveDispensingProvider(this RXD message, XCN item)
        {
            int fieldNum = message.FindField("DispensingProvider");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DispensingProvider record from RXD
        /// </summary>
        public static void RemoveDispensingProvider(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("DispensingProvider");
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
        public static List<CWE> GetAllPharmacyTreatmentSupplierSSpecialDispensingInstructionsRecords(this RXD message)
        {
            return message.GetAllRecords<CWE>("PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialDispensingInstructions");
        }

        /// <summary>
        /// Add a new PharmacyTreatmentSupplierSSpecialDispensingInstructions to RXD
        /// </summary>
        public static CWE AddPharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXD message)
        {
            return message.GetPharmacyTreatmentSupplierSSpecialDispensingInstructions(message.PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PharmacyTreatmentSupplierSSpecialDispensingInstructions record from RXD
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXD message, CWE item)
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
        public static List<DTM> GetAllSubstanceExpirationDateRecords(this RXD message)
        {
            return message.GetAllRecords<DTM>("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");
        }

        /// <summary>
        /// Add a new SubstanceExpirationDate to RXD
        /// </summary>
        public static DTM AddSubstanceExpirationDate(this RXD message)
        {
            return message.GetSubstanceExpirationDate(message.SubstanceExpirationDateRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceExpirationDate record from RXD
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXD message, DTM item)
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
        public static List<CWE> GetAllSubstanceManufacturerNameRecords(this RXD message)
        {
            return message.GetAllRecords<CWE>("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");
        }

        /// <summary>
        /// Add a new SubstanceManufacturerName to RXD
        /// </summary>
        public static CWE AddSubstanceManufacturerName(this RXD message)
        {
            return message.GetSubstanceManufacturerName(message.SubstanceManufacturerNameRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceManufacturerName record from RXD
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXD message, CWE item)
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
        public static List<CWE> GetAllIndicationRecords(this RXD message)
        {
            return message.GetAllRecords<CWE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Add a new Indication to RXD
        /// </summary>
        public static CWE AddIndication(this RXD message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Indication record from RXD
        /// </summary>
        public static void RemoveIndication(this RXD message, CWE item)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Indication record from RXD
        /// </summary>
        public static void RemoveIndication(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllSupplementaryCodeRecords(this RXD message)
        {
            return message.GetAllRecords<CWE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Add a new SupplementaryCode to RXD
        /// </summary>
        public static CWE AddSupplementaryCode(this RXD message)
        {
            return message.GetSupplementaryCode(message.SupplementaryCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXD
        /// </summary>
        public static void RemoveSupplementaryCode(this RXD message, CWE item)
        {
            int fieldNum = message.FindField("SupplementaryCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXD
        /// </summary>
        public static void RemoveSupplementaryCode(this RXD message, int itemIndex)
        {
            int fieldNum = message.FindField("SupplementaryCode");
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
        public static List<CWE> GetAllProviderSAdministrationInstructionsRecords(this RXE message)
        {
            return message.GetAllRecords<CWE>("ProviderSAdministrationInstructionsRepetitionsUsed", "GetProviderSAdministrationInstructions");
        }

        /// <summary>
        /// Add a new ProviderSAdministrationInstructions to RXE
        /// </summary>
        public static CWE AddProviderSAdministrationInstructions(this RXE message)
        {
            return message.GetProviderSAdministrationInstructions(message.ProviderSAdministrationInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderSAdministrationInstructions record from RXE
        /// </summary>
        public static void RemoveProviderSAdministrationInstructions(this RXE message, CWE item)
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
        /// Remove an OrderingProviderSDEANumber record from RXE
        /// </summary>
        public static void RemoveOrderingProviderSDEANumber(this RXE message, XCN item)
        {
            int fieldNum = message.FindField("OrderingProviderSDEANumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingProviderSDEANumber record from RXE
        /// </summary>
        public static void RemoveOrderingProviderSDEANumber(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingProviderSDEANumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PharmacistTreatmentSupplierSVerifierID record from RXE
        /// </summary>
        public static void RemovePharmacistTreatmentSupplierSVerifierID(this RXE message, XCN item)
        {
            int fieldNum = message.FindField("PharmacistTreatmentSupplierSVerifierID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PharmacistTreatmentSupplierSVerifierID record from RXE
        /// </summary>
        public static void RemovePharmacistTreatmentSupplierSVerifierID(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("PharmacistTreatmentSupplierSVerifierID");
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
        public static List<CWE> GetAllPharmacyTreatmentSupplierSSpecialDispensingInstructionsRecords(this RXE message)
        {
            return message.GetAllRecords<CWE>("PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialDispensingInstructions");
        }

        /// <summary>
        /// Add a new PharmacyTreatmentSupplierSSpecialDispensingInstructions to RXE
        /// </summary>
        public static CWE AddPharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXE message)
        {
            return message.GetPharmacyTreatmentSupplierSSpecialDispensingInstructions(message.PharmacyTreatmentSupplierSSpecialDispensingInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PharmacyTreatmentSupplierSSpecialDispensingInstructions record from RXE
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialDispensingInstructions(this RXE message, CWE item)
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
        public static List<CWE> GetAllGiveIndicationRecords(this RXE message)
        {
            return message.GetAllRecords<CWE>("GiveIndicationRepetitionsUsed", "GetGiveIndication");
        }

        /// <summary>
        /// Add a new GiveIndication to RXE
        /// </summary>
        public static CWE AddGiveIndication(this RXE message)
        {
            return message.GetGiveIndication(message.GiveIndicationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GiveIndication record from RXE
        /// </summary>
        public static void RemoveGiveIndication(this RXE message, CWE item)
        {
            int fieldNum = message.FindField("GiveIndication");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GiveIndication record from RXE
        /// </summary>
        public static void RemoveGiveIndication(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("GiveIndication");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllSupplementaryCodeRecords(this RXE message)
        {
            return message.GetAllRecords<CWE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Add a new SupplementaryCode to RXE
        /// </summary>
        public static CWE AddSupplementaryCode(this RXE message)
        {
            return message.GetSupplementaryCode(message.SupplementaryCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXE
        /// </summary>
        public static void RemoveSupplementaryCode(this RXE message, CWE item)
        {
            int fieldNum = message.FindField("SupplementaryCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXE
        /// </summary>
        public static void RemoveSupplementaryCode(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("SupplementaryCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new PharmaceuticalSubstanceAlternative to RXE
        /// </summary>
        public static CWE AddPharmaceuticalSubstanceAlternative(this RXE message)
        {
            return message.GetPharmaceuticalSubstanceAlternative(message.PharmaceuticalSubstanceAlternativeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PharmaceuticalSubstanceAlternative record from RXE
        /// </summary>
        public static void RemovePharmaceuticalSubstanceAlternative(this RXE message, CWE item)
        {
            int fieldNum = message.FindField("PharmaceuticalSubstanceAlternative");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PharmaceuticalSubstanceAlternative record from RXE
        /// </summary>
        public static void RemovePharmaceuticalSubstanceAlternative(this RXE message, int itemIndex)
        {
            int fieldNum = message.FindField("PharmaceuticalSubstanceAlternative");
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
        public static List<CWE> GetAllAdministrationNotesRecords(this RXG message)
        {
            return message.GetAllRecords<CWE>("AdministrationNotesRepetitionsUsed", "GetAdministrationNotes");
        }

        /// <summary>
        /// Add a new AdministrationNotes to RXG
        /// </summary>
        public static CWE AddAdministrationNotes(this RXG message)
        {
            return message.GetAdministrationNotes(message.AdministrationNotesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AdministrationNotes record from RXG
        /// </summary>
        public static void RemoveAdministrationNotes(this RXG message, CWE item)
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
        public static List<CWE> GetAllPharmacyTreatmentSupplierSSpecialAdministrationInstructionsRecords(this RXG message)
        {
            return message.GetAllRecords<CWE>("PharmacyTreatmentSupplierSSpecialAdministrationInstructionsRepetitionsUsed", "GetPharmacyTreatmentSupplierSSpecialAdministrationInstructions");
        }

        /// <summary>
        /// Add a new PharmacyTreatmentSupplierSSpecialAdministrationInstructions to RXG
        /// </summary>
        public static CWE AddPharmacyTreatmentSupplierSSpecialAdministrationInstructions(this RXG message)
        {
            return message.GetPharmacyTreatmentSupplierSSpecialAdministrationInstructions(message.PharmacyTreatmentSupplierSSpecialAdministrationInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PharmacyTreatmentSupplierSSpecialAdministrationInstructions record from RXG
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialAdministrationInstructions(this RXG message, CWE item)
        {
            int fieldNum = message.FindField("PharmacyTreatmentSupplierSSpecialAdministrationInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PharmacyTreatmentSupplierSSpecialAdministrationInstructions record from RXG
        /// </summary>
        public static void RemovePharmacyTreatmentSupplierSSpecialAdministrationInstructions(this RXG message, int itemIndex)
        {
            int fieldNum = message.FindField("PharmacyTreatmentSupplierSSpecialAdministrationInstructions");
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
        public static List<DTM> GetAllSubstanceExpirationDateRecords(this RXG message)
        {
            return message.GetAllRecords<DTM>("SubstanceExpirationDateRepetitionsUsed", "GetSubstanceExpirationDate");
        }

        /// <summary>
        /// Add a new SubstanceExpirationDate to RXG
        /// </summary>
        public static DTM AddSubstanceExpirationDate(this RXG message)
        {
            return message.GetSubstanceExpirationDate(message.SubstanceExpirationDateRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceExpirationDate record from RXG
        /// </summary>
        public static void RemoveSubstanceExpirationDate(this RXG message, DTM item)
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
        public static List<CWE> GetAllSubstanceManufacturerNameRecords(this RXG message)
        {
            return message.GetAllRecords<CWE>("SubstanceManufacturerNameRepetitionsUsed", "GetSubstanceManufacturerName");
        }

        /// <summary>
        /// Add a new SubstanceManufacturerName to RXG
        /// </summary>
        public static CWE AddSubstanceManufacturerName(this RXG message)
        {
            return message.GetSubstanceManufacturerName(message.SubstanceManufacturerNameRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SubstanceManufacturerName record from RXG
        /// </summary>
        public static void RemoveSubstanceManufacturerName(this RXG message, CWE item)
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
        public static List<CWE> GetAllIndicationRecords(this RXG message)
        {
            return message.GetAllRecords<CWE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Add a new Indication to RXG
        /// </summary>
        public static CWE AddIndication(this RXG message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Indication record from RXG
        /// </summary>
        public static void RemoveIndication(this RXG message, CWE item)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Indication record from RXG
        /// </summary>
        public static void RemoveIndication(this RXG message, int itemIndex)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllProviderSPharmacyTreatmentInstructionsRecords(this RXO message)
        {
            return message.GetAllRecords<CWE>("ProviderSPharmacyTreatmentInstructionsRepetitionsUsed", "GetProviderSPharmacyTreatmentInstructions");
        }

        /// <summary>
        /// Add a new ProviderSPharmacyTreatmentInstructions to RXO
        /// </summary>
        public static CWE AddProviderSPharmacyTreatmentInstructions(this RXO message)
        {
            return message.GetProviderSPharmacyTreatmentInstructions(message.ProviderSPharmacyTreatmentInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderSPharmacyTreatmentInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSPharmacyTreatmentInstructions(this RXO message, CWE item)
        {
            int fieldNum = message.FindField("ProviderSPharmacyTreatmentInstructions");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ProviderSPharmacyTreatmentInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSPharmacyTreatmentInstructions(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("ProviderSPharmacyTreatmentInstructions");
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
        public static List<CWE> GetAllProviderSAdministrationInstructionsRecords(this RXO message)
        {
            return message.GetAllRecords<CWE>("ProviderSAdministrationInstructionsRepetitionsUsed", "GetProviderSAdministrationInstructions");
        }

        /// <summary>
        /// Add a new ProviderSAdministrationInstructions to RXO
        /// </summary>
        public static CWE AddProviderSAdministrationInstructions(this RXO message)
        {
            return message.GetProviderSAdministrationInstructions(message.ProviderSAdministrationInstructionsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ProviderSAdministrationInstructions record from RXO
        /// </summary>
        public static void RemoveProviderSAdministrationInstructions(this RXO message, CWE item)
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
        /// Remove an OrderingProviderSDEANumber record from RXO
        /// </summary>
        public static void RemoveOrderingProviderSDEANumber(this RXO message, XCN item)
        {
            int fieldNum = message.FindField("OrderingProviderSDEANumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OrderingProviderSDEANumber record from RXO
        /// </summary>
        public static void RemoveOrderingProviderSDEANumber(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("OrderingProviderSDEANumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PharmacistTreatmentSupplierSVerifierID record from RXO
        /// </summary>
        public static void RemovePharmacistTreatmentSupplierSVerifierID(this RXO message, XCN item)
        {
            int fieldNum = message.FindField("PharmacistTreatmentSupplierSVerifierID");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PharmacistTreatmentSupplierSVerifierID record from RXO
        /// </summary>
        public static void RemovePharmacistTreatmentSupplierSVerifierID(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("PharmacistTreatmentSupplierSVerifierID");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllIndicationRecords(this RXO message)
        {
            return message.GetAllRecords<CWE>("IndicationRepetitionsUsed", "GetIndication");
        }

        /// <summary>
        /// Add a new Indication to RXO
        /// </summary>
        public static CWE AddIndication(this RXO message)
        {
            return message.GetIndication(message.IndicationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Indication record from RXO
        /// </summary>
        public static void RemoveIndication(this RXO message, CWE item)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Indication record from RXO
        /// </summary>
        public static void RemoveIndication(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("Indication");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllSupplementaryCodeRecords(this RXO message)
        {
            return message.GetAllRecords<CWE>("SupplementaryCodeRepetitionsUsed", "GetSupplementaryCode");
        }

        /// <summary>
        /// Add a new SupplementaryCode to RXO
        /// </summary>
        public static CWE AddSupplementaryCode(this RXO message)
        {
            return message.GetSupplementaryCode(message.SupplementaryCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXO
        /// </summary>
        public static void RemoveSupplementaryCode(this RXO message, CWE item)
        {
            int fieldNum = message.FindField("SupplementaryCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SupplementaryCode record from RXO
        /// </summary>
        public static void RemoveSupplementaryCode(this RXO message, int itemIndex)
        {
            int fieldNum = message.FindField("SupplementaryCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllLocationRecords(this SAC message)
        {
            return message.GetAllRecords<CWE>("LocationRepetitionsUsed", "GetLocation");
        }

        /// <summary>
        /// Add a new Location to SAC
        /// </summary>
        public static CWE AddLocation(this SAC message)
        {
            return message.GetLocation(message.LocationRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Location record from SAC
        /// </summary>
        public static void RemoveLocation(this SAC message, CWE item)
        {
            int fieldNum = message.FindField("Location");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Location record from SAC
        /// </summary>
        public static void RemoveLocation(this SAC message, int itemIndex)
        {
            int fieldNum = message.FindField("Location");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new Additive to SAC
        /// </summary>
        public static CWE AddAdditive(this SAC message)
        {
            return message.GetAdditive(message.AdditiveRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Additive record from SAC
        /// </summary>
        public static void RemoveAdditive(this SAC message, CWE item)
        {
            int fieldNum = message.FindField("Additive");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Additive record from SAC
        /// </summary>
        public static void RemoveAdditive(this SAC message, int itemIndex)
        {
            int fieldNum = message.FindField("Additive");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllSystemInducedContaminantsRecords(this SAC message)
        {
            return message.GetAllRecords<CWE>("SystemInducedContaminantsRepetitionsUsed", "GetSystemInducedContaminants");
        }

        /// <summary>
        /// Add a new SystemInducedContaminants to SAC
        /// </summary>
        public static CWE AddSystemInducedContaminants(this SAC message)
        {
            return message.GetSystemInducedContaminants(message.SystemInducedContaminantsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SystemInducedContaminants record from SAC
        /// </summary>
        public static void RemoveSystemInducedContaminants(this SAC message, CWE item)
        {
            int fieldNum = message.FindField("SystemInducedContaminants");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SystemInducedContaminants record from SAC
        /// </summary>
        public static void RemoveSystemInducedContaminants(this SAC message, int itemIndex)
        {
            int fieldNum = message.FindField("SystemInducedContaminants");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllDrugInterferenceRecords(this SAC message)
        {
            return message.GetAllRecords<CWE>("DrugInterferenceRepetitionsUsed", "GetDrugInterference");
        }

        /// <summary>
        /// Add a new DrugInterference to SAC
        /// </summary>
        public static CWE AddDrugInterference(this SAC message)
        {
            return message.GetDrugInterference(message.DrugInterferenceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an DrugInterference record from SAC
        /// </summary>
        public static void RemoveDrugInterference(this SAC message, CWE item)
        {
            int fieldNum = message.FindField("DrugInterference");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an DrugInterference record from SAC
        /// </summary>
        public static void RemoveDrugInterference(this SAC message, int itemIndex)
        {
            int fieldNum = message.FindField("DrugInterference");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecialHandlingCode to SAC
        /// </summary>
        public static CWE AddSpecialHandlingCode(this SAC message)
        {
            return message.GetSpecialHandlingCode(message.SpecialHandlingCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecialHandlingCode record from SAC
        /// </summary>
        public static void RemoveSpecialHandlingCode(this SAC message, CWE item)
        {
            int fieldNum = message.FindField("SpecialHandlingCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecialHandlingCode record from SAC
        /// </summary>
        public static void RemoveSpecialHandlingCode(this SAC message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecialHandlingCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        public static List<CWE> GetAllOtherEnvironmentalFactorsRecords(this SAC message)
        {
            return message.GetAllRecords<CWE>("OtherEnvironmentalFactorsRepetitionsUsed", "GetOtherEnvironmentalFactors");
        }

        /// <summary>
        /// Add a new OtherEnvironmentalFactors to SAC
        /// </summary>
        public static CWE AddOtherEnvironmentalFactors(this SAC message)
        {
            return message.GetOtherEnvironmentalFactors(message.OtherEnvironmentalFactorsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OtherEnvironmentalFactors record from SAC
        /// </summary>
        public static void RemoveOtherEnvironmentalFactors(this SAC message, CWE item)
        {
            int fieldNum = message.FindField("OtherEnvironmentalFactors");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OtherEnvironmentalFactors record from SAC
        /// </summary>
        public static void RemoveOtherEnvironmentalFactors(this SAC message, int itemIndex)
        {
            int fieldNum = message.FindField("OtherEnvironmentalFactors");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get PatientIdentifierList Records from SCD
        /// </summary>
        public static IEnumerable GetPatientIdentifierListRecords(this SCD message)
        {
            object[] result = message.GetRecords("PatientIdentifierListRepetitionsUsed", "GetPatientIdentifierList");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientIdentifierList Records from SCD
        /// </summary>
        public static List<CX> GetAllPatientIdentifierListRecords(this SCD message)
        {
            return message.GetAllRecords<CX>("PatientIdentifierListRepetitionsUsed", "GetPatientIdentifierList");
        }

        /// <summary>
        /// Add a new PatientIdentifierList to SCD
        /// </summary>
        public static CX AddPatientIdentifierList(this SCD message)
        {
            return message.GetPatientIdentifierList(message.PatientIdentifierListRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PatientIdentifierList record from SCD
        /// </summary>
        public static void RemovePatientIdentifierList(this SCD message, CX item)
        {
            int fieldNum = message.FindField("PatientIdentifierList");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PatientIdentifierList record from SCD
        /// </summary>
        public static void RemovePatientIdentifierList(this SCD message, int itemIndex)
        {
            int fieldNum = message.FindField("PatientIdentifierList");
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
        /// Remove an PlacerContactPerson record from SCH
        /// </summary>
        public static void RemovePlacerContactPerson(this SCH message, XCN item)
        {
            int fieldNum = message.FindField("PlacerContactPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerContactPerson record from SCH
        /// </summary>
        public static void RemovePlacerContactPerson(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerContactPerson");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PlacerContactAddress record from SCH
        /// </summary>
        public static void RemovePlacerContactAddress(this SCH message, XAD item)
        {
            int fieldNum = message.FindField("PlacerContactAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerContactAddress record from SCH
        /// </summary>
        public static void RemovePlacerContactAddress(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerContactAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an FillerContactPerson record from SCH
        /// </summary>
        public static void RemoveFillerContactPerson(this SCH message, XCN item)
        {
            int fieldNum = message.FindField("FillerContactPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerContactPerson record from SCH
        /// </summary>
        public static void RemoveFillerContactPerson(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerContactPerson");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an FillerContactAddress record from SCH
        /// </summary>
        public static void RemoveFillerContactAddress(this SCH message, XAD item)
        {
            int fieldNum = message.FindField("FillerContactAddress");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerContactAddress record from SCH
        /// </summary>
        public static void RemoveFillerContactAddress(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerContactAddress");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an EnteredByPerson record from SCH
        /// </summary>
        public static void RemoveEnteredByPerson(this SCH message, XCN item)
        {
            int fieldNum = message.FindField("EnteredByPerson");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an EnteredByPerson record from SCH
        /// </summary>
        public static void RemoveEnteredByPerson(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("EnteredByPerson");
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
        /// Add a new PlacerOrderNumber to SCH
        /// </summary>
        public static EI AddPlacerOrderNumber(this SCH message)
        {
            return message.GetPlacerOrderNumber(message.PlacerOrderNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from SCH
        /// </summary>
        public static void RemovePlacerOrderNumber(this SCH message, EI item)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PlacerOrderNumber record from SCH
        /// </summary>
        public static void RemovePlacerOrderNumber(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("PlacerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new FillerOrderNumber to SCH
        /// </summary>
        public static EI AddFillerOrderNumber(this SCH message)
        {
            return message.GetFillerOrderNumber(message.FillerOrderNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an FillerOrderNumber record from SCH
        /// </summary>
        public static void RemoveFillerOrderNumber(this SCH message, EI item)
        {
            int fieldNum = message.FindField("FillerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an FillerOrderNumber record from SCH
        /// </summary>
        public static void RemoveFillerOrderNumber(this SCH message, int itemIndex)
        {
            int fieldNum = message.FindField("FillerOrderNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenParentIDs to SPM
        /// </summary>
        public static EIP AddSpecimenParentIDs(this SPM message)
        {
            return message.GetSpecimenParentIDs(message.SpecimenParentIDsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenParentIDs record from SPM
        /// </summary>
        public static void RemoveSpecimenParentIDs(this SPM message, EIP item)
        {
            int fieldNum = message.FindField("SpecimenParentIDs");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenParentIDs record from SPM
        /// </summary>
        public static void RemoveSpecimenParentIDs(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenParentIDs");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenTypeModifier to SPM
        /// </summary>
        public static CWE AddSpecimenTypeModifier(this SPM message)
        {
            return message.GetSpecimenTypeModifier(message.SpecimenTypeModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenTypeModifier record from SPM
        /// </summary>
        public static void RemoveSpecimenTypeModifier(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenTypeModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenTypeModifier record from SPM
        /// </summary>
        public static void RemoveSpecimenTypeModifier(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenTypeModifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenAdditives to SPM
        /// </summary>
        public static CWE AddSpecimenAdditives(this SPM message)
        {
            return message.GetSpecimenAdditives(message.SpecimenAdditivesRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenAdditives record from SPM
        /// </summary>
        public static void RemoveSpecimenAdditives(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenAdditives");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenAdditives record from SPM
        /// </summary>
        public static void RemoveSpecimenAdditives(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenAdditives");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenSourceSiteModifier to SPM
        /// </summary>
        public static CWE AddSpecimenSourceSiteModifier(this SPM message)
        {
            return message.GetSpecimenSourceSiteModifier(message.SpecimenSourceSiteModifierRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenSourceSiteModifier record from SPM
        /// </summary>
        public static void RemoveSpecimenSourceSiteModifier(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenSourceSiteModifier");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenSourceSiteModifier record from SPM
        /// </summary>
        public static void RemoveSpecimenSourceSiteModifier(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenSourceSiteModifier");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenRole to SPM
        /// </summary>
        public static CWE AddSpecimenRole(this SPM message)
        {
            return message.GetSpecimenRole(message.SpecimenRoleRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenRole record from SPM
        /// </summary>
        public static void RemoveSpecimenRole(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenRole");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenRole record from SPM
        /// </summary>
        public static void RemoveSpecimenRole(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenRole");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenDescription to SPM
        /// </summary>
        public static ST AddSpecimenDescription(this SPM message)
        {
            return message.GetSpecimenDescription(message.SpecimenDescriptionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenDescription record from SPM
        /// </summary>
        public static void RemoveSpecimenDescription(this SPM message, ST item)
        {
            int fieldNum = message.FindField("SpecimenDescription");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenDescription record from SPM
        /// </summary>
        public static void RemoveSpecimenDescription(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenDescription");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenHandlingCode to SPM
        /// </summary>
        public static CWE AddSpecimenHandlingCode(this SPM message)
        {
            return message.GetSpecimenHandlingCode(message.SpecimenHandlingCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenHandlingCode record from SPM
        /// </summary>
        public static void RemoveSpecimenHandlingCode(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenHandlingCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenHandlingCode record from SPM
        /// </summary>
        public static void RemoveSpecimenHandlingCode(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenHandlingCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenRiskCode to SPM
        /// </summary>
        public static CWE AddSpecimenRiskCode(this SPM message)
        {
            return message.GetSpecimenRiskCode(message.SpecimenRiskCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenRiskCode record from SPM
        /// </summary>
        public static void RemoveSpecimenRiskCode(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenRiskCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenRiskCode record from SPM
        /// </summary>
        public static void RemoveSpecimenRiskCode(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenRiskCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenRejectReason to SPM
        /// </summary>
        public static CWE AddSpecimenRejectReason(this SPM message)
        {
            return message.GetSpecimenRejectReason(message.SpecimenRejectReasonRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenRejectReason record from SPM
        /// </summary>
        public static void RemoveSpecimenRejectReason(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenRejectReason");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenRejectReason record from SPM
        /// </summary>
        public static void RemoveSpecimenRejectReason(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenRejectReason");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new SpecimenCondition to SPM
        /// </summary>
        public static CWE AddSpecimenCondition(this SPM message)
        {
            return message.GetSpecimenCondition(message.SpecimenConditionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an SpecimenCondition record from SPM
        /// </summary>
        public static void RemoveSpecimenCondition(this SPM message, CWE item)
        {
            int fieldNum = message.FindField("SpecimenCondition");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an SpecimenCondition record from SPM
        /// </summary>
        public static void RemoveSpecimenCondition(this SPM message, int itemIndex)
        {
            int fieldNum = message.FindField("SpecimenCondition");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new StaffIdentifierList to STF
        /// </summary>
        public static CX AddStaffIdentifierList(this STF message)
        {
            return message.GetStaffIdentifierList(message.StaffIdentifierListRepetitionsUsed);
        }

        /// <summary>
        /// Remove an StaffIdentifierList record from STF
        /// </summary>
        public static void RemoveStaffIdentifierList(this STF message, CX item)
        {
            int fieldNum = message.FindField("StaffIdentifierList");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StaffIdentifierList record from STF
        /// </summary>
        public static void RemoveStaffIdentifierList(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("StaffIdentifierList");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an StaffName record from STF
        /// </summary>
        public static void RemoveStaffName(this STF message, XPN item)
        {
            int fieldNum = message.FindField("StaffName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an StaffName record from STF
        /// </summary>
        public static void RemoveStaffName(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("StaffName");
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
        /// Remove an StaffType record from STF
        /// </summary>
        public static void RemoveStaffType(this STF message, IS item)
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
        public static List<CWE> GetAllDepartmentRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("DepartmentRepetitionsUsed", "GetDepartment");
        }

        /// <summary>
        /// Add a new Department to STF
        /// </summary>
        public static CWE AddDepartment(this STF message)
        {
            return message.GetDepartment(message.DepartmentRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Department record from STF
        /// </summary>
        public static void RemoveDepartment(this STF message, CWE item)
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
        public static List<CWE> GetAllHospitalServiceSTFRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("HospitalServiceSTFRepetitionsUsed", "GetHospitalServiceSTF");
        }

        /// <summary>
        /// Add a new HospitalServiceSTF to STF
        /// </summary>
        public static CWE AddHospitalServiceSTF(this STF message)
        {
            return message.GetHospitalServiceSTF(message.HospitalServiceSTFRepetitionsUsed);
        }

        /// <summary>
        /// Remove an HospitalServiceSTF record from STF
        /// </summary>
        public static void RemoveHospitalServiceSTF(this STF message, CWE item)
        {
            int fieldNum = message.FindField("HospitalServiceSTF");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an HospitalServiceSTF record from STF
        /// </summary>
        public static void RemoveHospitalServiceSTF(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("HospitalServiceSTF");
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
        /// Remove an Phone record from STF
        /// </summary>
        public static void RemovePhone(this STF message, XTN item)
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
        /// Add a new OfficeHomeAddressBirthplace to STF
        /// </summary>
        public static XAD AddOfficeHomeAddressBirthplace(this STF message)
        {
            return message.GetOfficeHomeAddressBirthplace(message.OfficeHomeAddressBirthplaceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an OfficeHomeAddressBirthplace record from STF
        /// </summary>
        public static void RemoveOfficeHomeAddressBirthplace(this STF message, XAD item)
        {
            int fieldNum = message.FindField("OfficeHomeAddressBirthplace");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OfficeHomeAddressBirthplace record from STF
        /// </summary>
        public static void RemoveOfficeHomeAddressBirthplace(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("OfficeHomeAddressBirthplace");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InstitutionActivationDate record from STF
        /// </summary>
        public static void RemoveInstitutionActivationDate(this STF message, DIN item)
        {
            int fieldNum = message.FindField("InstitutionActivationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InstitutionActivationDate record from STF
        /// </summary>
        public static void RemoveInstitutionActivationDate(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("InstitutionActivationDate");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an InstitutionInactivationDate record from STF
        /// </summary>
        public static void RemoveInstitutionInactivationDate(this STF message, DIN item)
        {
            int fieldNum = message.FindField("InstitutionInactivationDate");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an InstitutionInactivationDate record from STF
        /// </summary>
        public static void RemoveInstitutionInactivationDate(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("InstitutionInactivationDate");
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
        public static List<CWE> GetAllBackupPersonIDRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("BackupPersonIDRepetitionsUsed", "GetBackupPersonID");
        }

        /// <summary>
        /// Add a new BackupPersonID to STF
        /// </summary>
        public static CWE AddBackupPersonID(this STF message)
        {
            return message.GetBackupPersonID(message.BackupPersonIDRepetitionsUsed);
        }

        /// <summary>
        /// Remove an BackupPersonID record from STF
        /// </summary>
        public static void RemoveBackupPersonID(this STF message, CWE item)
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
        public static List<CWE> GetAllCitizenshipRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("CitizenshipRepetitionsUsed", "GetCitizenship");
        }

        /// <summary>
        /// Add a new Citizenship to STF
        /// </summary>
        public static CWE AddCitizenship(this STF message)
        {
            return message.GetCitizenship(message.CitizenshipRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Citizenship record from STF
        /// </summary>
        public static void RemoveCitizenship(this STF message, CWE item)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Citizenship record from STF
        /// </summary>
        public static void RemoveCitizenship(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("Citizenship");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new CostCenterCode to STF
        /// </summary>
        public static CWE AddCostCenterCode(this STF message)
        {
            return message.GetCostCenterCode(message.CostCenterCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an CostCenterCode record from STF
        /// </summary>
        public static void RemoveCostCenterCode(this STF message, CWE item)
        {
            int fieldNum = message.FindField("CostCenterCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an CostCenterCode record from STF
        /// </summary>
        public static void RemoveCostCenterCode(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("CostCenterCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get GenericResourceTypeOrCategory Records from STF
        /// </summary>
        public static IEnumerable GetGenericResourceTypeOrCategoryRecords(this STF message)
        {
            object[] result = message.GetRecords("GenericResourceTypeOrCategoryRepetitionsUsed", "GetGenericResourceTypeOrCategory");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GenericResourceTypeOrCategory Records from STF
        /// </summary>
        public static List<CWE> GetAllGenericResourceTypeOrCategoryRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("GenericResourceTypeOrCategoryRepetitionsUsed", "GetGenericResourceTypeOrCategory");
        }

        /// <summary>
        /// Add a new GenericResourceTypeOrCategory to STF
        /// </summary>
        public static CWE AddGenericResourceTypeOrCategory(this STF message)
        {
            return message.GetGenericResourceTypeOrCategory(message.GenericResourceTypeOrCategoryRepetitionsUsed);
        }

        /// <summary>
        /// Remove an GenericResourceTypeOrCategory record from STF
        /// </summary>
        public static void RemoveGenericResourceTypeOrCategory(this STF message, CWE item)
        {
            int fieldNum = message.FindField("GenericResourceTypeOrCategory");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an GenericResourceTypeOrCategory record from STF
        /// </summary>
        public static void RemoveGenericResourceTypeOrCategory(this STF message, int itemIndex)
        {
            int fieldNum = message.FindField("GenericResourceTypeOrCategory");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new RepeatPattern to TQ1
        /// </summary>
        public static RPT AddRepeatPattern(this TQ1 message)
        {
            return message.GetRepeatPattern(message.RepeatPatternRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RepeatPattern record from TQ1
        /// </summary>
        public static void RemoveRepeatPattern(this TQ1 message, RPT item)
        {
            int fieldNum = message.FindField("RepeatPattern");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RepeatPattern record from TQ1
        /// </summary>
        public static void RemoveRepeatPattern(this TQ1 message, int itemIndex)
        {
            int fieldNum = message.FindField("RepeatPattern");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new ExplicitTime to TQ1
        /// </summary>
        public static TM AddExplicitTime(this TQ1 message)
        {
            return message.GetExplicitTime(message.ExplicitTimeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ExplicitTime record from TQ1
        /// </summary>
        public static void RemoveExplicitTime(this TQ1 message, TM item)
        {
            int fieldNum = message.FindField("ExplicitTime");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ExplicitTime record from TQ1
        /// </summary>
        public static void RemoveExplicitTime(this TQ1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ExplicitTime");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new RelativeTimeAndUnits to TQ1
        /// </summary>
        public static CQ AddRelativeTimeAndUnits(this TQ1 message)
        {
            return message.GetRelativeTimeAndUnits(message.RelativeTimeAndUnitsRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RelativeTimeAndUnits record from TQ1
        /// </summary>
        public static void RemoveRelativeTimeAndUnits(this TQ1 message, CQ item)
        {
            int fieldNum = message.FindField("RelativeTimeAndUnits");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RelativeTimeAndUnits record from TQ1
        /// </summary>
        public static void RemoveRelativeTimeAndUnits(this TQ1 message, int itemIndex)
        {
            int fieldNum = message.FindField("RelativeTimeAndUnits");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new Priority to TQ1
        /// </summary>
        public static CWE AddPriority(this TQ1 message)
        {
            return message.GetPriority(message.PriorityRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Priority record from TQ1
        /// </summary>
        public static void RemovePriority(this TQ1 message, CWE item)
        {
            int fieldNum = message.FindField("Priority");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Priority record from TQ1
        /// </summary>
        public static void RemovePriority(this TQ1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Priority");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

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
        /// Add a new RelatedPlacerNumber to TQ2
        /// </summary>
        public static EI AddRelatedPlacerNumber(this TQ2 message)
        {
            return message.GetRelatedPlacerNumber(message.RelatedPlacerNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RelatedPlacerNumber record from TQ2
        /// </summary>
        public static void RemoveRelatedPlacerNumber(this TQ2 message, EI item)
        {
            int fieldNum = message.FindField("RelatedPlacerNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RelatedPlacerNumber record from TQ2
        /// </summary>
        public static void RemoveRelatedPlacerNumber(this TQ2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RelatedPlacerNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new RelatedFillerNumber to TQ2
        /// </summary>
        public static EI AddRelatedFillerNumber(this TQ2 message)
        {
            return message.GetRelatedFillerNumber(message.RelatedFillerNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RelatedFillerNumber record from TQ2
        /// </summary>
        public static void RemoveRelatedFillerNumber(this TQ2 message, EI item)
        {
            int fieldNum = message.FindField("RelatedFillerNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RelatedFillerNumber record from TQ2
        /// </summary>
        public static void RemoveRelatedFillerNumber(this TQ2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RelatedFillerNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Add a new RelatedPlacerGroupNumber to TQ2
        /// </summary>
        public static EI AddRelatedPlacerGroupNumber(this TQ2 message)
        {
            return message.GetRelatedPlacerGroupNumber(message.RelatedPlacerGroupNumberRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RelatedPlacerGroupNumber record from TQ2
        /// </summary>
        public static void RemoveRelatedPlacerGroupNumber(this TQ2 message, EI item)
        {
            int fieldNum = message.FindField("RelatedPlacerGroupNumber");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an RelatedPlacerGroupNumber record from TQ2
        /// </summary>
        public static void RemoveRelatedPlacerGroupNumber(this TQ2 message, int itemIndex)
        {
            int fieldNum = message.FindField("RelatedPlacerGroupNumber");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
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
        /// Remove an PrimaryActivityProviderCodeName record from TXA
        /// </summary>
        public static void RemovePrimaryActivityProviderCodeName(this TXA message, XCN item)
        {
            int fieldNum = message.FindField("PrimaryActivityProviderCodeName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an PrimaryActivityProviderCodeName record from TXA
        /// </summary>
        public static void RemovePrimaryActivityProviderCodeName(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("PrimaryActivityProviderCodeName");
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
        public static List<DTM> GetAllEditDateTimeRecords(this TXA message)
        {
            return message.GetAllRecords<DTM>("EditDateTimeRepetitionsUsed", "GetEditDateTime");
        }

        /// <summary>
        /// Add a new EditDateTime to TXA
        /// </summary>
        public static DTM AddEditDateTime(this TXA message)
        {
            return message.GetEditDateTime(message.EditDateTimeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an EditDateTime record from TXA
        /// </summary>
        public static void RemoveEditDateTime(this TXA message, DTM item)
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
        /// Remove an OriginatorCodeName record from TXA
        /// </summary>
        public static void RemoveOriginatorCodeName(this TXA message, XCN item)
        {
            int fieldNum = message.FindField("OriginatorCodeName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an OriginatorCodeName record from TXA
        /// </summary>
        public static void RemoveOriginatorCodeName(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("OriginatorCodeName");
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
        /// Remove an TranscriptionistCodeName record from TXA
        /// </summary>
        public static void RemoveTranscriptionistCodeName(this TXA message, XCN item)
        {
            int fieldNum = message.FindField("TranscriptionistCodeName");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an TranscriptionistCodeName record from TXA
        /// </summary>
        public static void RemoveTranscriptionistCodeName(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("TranscriptionistCodeName");
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
        /// Get AuthenticationPersonTimeStampSet Records from TXA
        /// </summary>
        public static IEnumerable GetAuthenticationPersonTimeStampSetRecords(this TXA message)
        {
            object[] result = message.GetRecords("AuthenticationPersonTimeStampSetRepetitionsUsed", "GetAuthenticationPersonTimeStampSet");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AuthenticationPersonTimeStampSet Records from TXA
        /// </summary>
        public static List<PPN> GetAllAuthenticationPersonTimeStampSetRecords(this TXA message)
        {
            return message.GetAllRecords<PPN>("AuthenticationPersonTimeStampSetRepetitionsUsed", "GetAuthenticationPersonTimeStampSet");
        }

        /// <summary>
        /// Add a new AuthenticationPersonTimeStampSet to TXA
        /// </summary>
        public static PPN AddAuthenticationPersonTimeStampSet(this TXA message)
        {
            return message.GetAuthenticationPersonTimeStampSet(message.AuthenticationPersonTimeStampSetRepetitionsUsed);
        }

        /// <summary>
        /// Remove an AuthenticationPersonTimeStampSet record from TXA
        /// </summary>
        public static void RemoveAuthenticationPersonTimeStampSet(this TXA message, PPN item)
        {
            int fieldNum = message.FindField("AuthenticationPersonTimeStampSet");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an AuthenticationPersonTimeStampSet record from TXA
        /// </summary>
        public static void RemoveAuthenticationPersonTimeStampSet(this TXA message, int itemIndex)
        {
            int fieldNum = message.FindField("AuthenticationPersonTimeStampSet");
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
        /// Get ConditionCode Records from UB1
        /// </summary>
        public static IEnumerable GetConditionCodeRecords(this UB1 message)
        {
            object[] result = message.GetRecords("ConditionCodeRepetitionsUsed", "GetConditionCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ConditionCode Records from UB1
        /// </summary>
        public static List<IS> GetAllConditionCodeRecords(this UB1 message)
        {
            return message.GetAllRecords<IS>("ConditionCodeRepetitionsUsed", "GetConditionCode");
        }

        /// <summary>
        /// Add a new ConditionCode to UB1
        /// </summary>
        public static IS AddConditionCode(this UB1 message)
        {
            return message.GetConditionCode(message.ConditionCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ConditionCode record from UB1
        /// </summary>
        public static void RemoveConditionCode(this UB1 message, IS item)
        {
            int fieldNum = message.FindField("ConditionCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ConditionCode record from UB1
        /// </summary>
        public static void RemoveConditionCode(this UB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ConditionCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get ValueAmountCode Records from UB1
        /// </summary>
        public static IEnumerable GetValueAmountCodeRecords(this UB1 message)
        {
            object[] result = message.GetRecords("ValueAmountCodeRepetitionsUsed", "GetValueAmountCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValueAmountCode Records from UB1
        /// </summary>
        public static List<UVC> GetAllValueAmountCodeRecords(this UB1 message)
        {
            return message.GetAllRecords<UVC>("ValueAmountCodeRepetitionsUsed", "GetValueAmountCode");
        }

        /// <summary>
        /// Add a new ValueAmountCode to UB1
        /// </summary>
        public static UVC AddValueAmountCode(this UB1 message)
        {
            return message.GetValueAmountCode(message.ValueAmountCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an ValueAmountCode record from UB1
        /// </summary>
        public static void RemoveValueAmountCode(this UB1 message, UVC item)
        {
            int fieldNum = message.FindField("ValueAmountCode");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an ValueAmountCode record from UB1
        /// </summary>
        public static void RemoveValueAmountCode(this UB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("ValueAmountCode");
            message.RemoveRepetition(fieldNum + 1, itemIndex);
        }

        /// <summary>
        /// Get Occurrence Records from UB1
        /// </summary>
        public static IEnumerable GetOccurrenceRecords(this UB1 message)
        {
            object[] result = message.GetRecords("OccurrenceRepetitionsUsed", "GetOccurrence");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all Occurrence Records from UB1
        /// </summary>
        public static List<OCD> GetAllOccurrenceRecords(this UB1 message)
        {
            return message.GetAllRecords<OCD>("OccurrenceRepetitionsUsed", "GetOccurrence");
        }

        /// <summary>
        /// Add a new Occurrence to UB1
        /// </summary>
        public static OCD AddOccurrence(this UB1 message)
        {
            return message.GetOccurrence(message.OccurrenceRepetitionsUsed);
        }

        /// <summary>
        /// Remove an Occurrence record from UB1
        /// </summary>
        public static void RemoveOccurrence(this UB1 message, OCD item)
        {
            int fieldNum = message.FindField("Occurrence");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an Occurrence record from UB1
        /// </summary>
        public static void RemoveOccurrence(this UB1 message, int itemIndex)
        {
            int fieldNum = message.FindField("Occurrence");
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
        /// Remove an ConditionCode2430 record from UB2
        /// </summary>
        public static void RemoveConditionCode2430(this UB2 message, IS item)
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
        /// Remove an ValueAmountCode record from UB2
        /// </summary>
        public static void RemoveValueAmountCode(this UB2 message, UVC item)
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
        /// Remove an OccurrenceCodeDate3235 record from UB2
        /// </summary>
        public static void RemoveOccurrenceCodeDate3235(this UB2 message, OCD item)
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
        /// Remove an OccurrenceSpanCodeDates record from UB2
        /// </summary>
        public static void RemoveOccurrenceSpanCodeDates(this UB2 message, OSP item)
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
        public static List<CWE> GetAllRUWhatSubjectDefinitionRecords(this URD message)
        {
            return message.GetAllRecords<CWE>("RUWhatSubjectDefinitionRepetitionsUsed", "GetRUWhatSubjectDefinition");
        }

        /// <summary>
        /// Add a new RUWhatSubjectDefinition to URD
        /// </summary>
        public static CWE AddRUWhatSubjectDefinition(this URD message)
        {
            return message.GetRUWhatSubjectDefinition(message.RUWhatSubjectDefinitionRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RUWhatSubjectDefinition record from URD
        /// </summary>
        public static void RemoveRUWhatSubjectDefinition(this URD message, CWE item)
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
        public static List<CWE> GetAllRUWhatDepartmentCodeRecords(this URD message)
        {
            return message.GetAllRecords<CWE>("RUWhatDepartmentCodeRepetitionsUsed", "GetRUWhatDepartmentCode");
        }

        /// <summary>
        /// Add a new RUWhatDepartmentCode to URD
        /// </summary>
        public static CWE AddRUWhatDepartmentCode(this URD message)
        {
            return message.GetRUWhatDepartmentCode(message.RUWhatDepartmentCodeRepetitionsUsed);
        }

        /// <summary>
        /// Remove an RUWhatDepartmentCode record from URD
        /// </summary>
        public static void RemoveRUWhatDepartmentCode(this URD message, CWE item)
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
        /// Remove an VarianceOriginator record from VAR
        /// </summary>
        public static void RemoveVarianceOriginator(this VAR message, XCN item)
        {
            int fieldNum = message.FindField("VarianceOriginator");
            message.RemoveRepetition(fieldNum + 1, item);
        }

        /// <summary>
        /// Remove an VarianceOriginator record from VAR
        /// </summary>
        public static void RemoveVarianceOriginator(this VAR message, int itemIndex)
        {
            int fieldNum = message.FindField("VarianceOriginator");
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
        #endregion
    }
}
