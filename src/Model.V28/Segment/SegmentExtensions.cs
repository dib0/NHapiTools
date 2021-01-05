using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V28.Group;
using NHapi.Model.V28.Message;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V28.Segment
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class SegmentExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get AccidentIdentifier Records from ACC
        /// </summary>
        public static IEnumerable GetAccidentIdentifierRecords(this ACC message)
        {
            object[] result = message.GetRecords("AccidentIdentifierRepetitionsUsed", "GetAccidentIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AccidentIdentifier Records from ACC
        /// </summary>
        public static List<EI> GetAllAccidentIdentifierRecords(this ACC message)
        {
            return message.GetAllRecords<EI>("AccidentIdentifierRepetitionsUsed", "GetAccidentIdentifier");
        }

        /// <summary>
        /// Add a new AccidentIdentifier to ACC
        /// </summary>
        public static EI AddAccidentIdentifier(this ACC message)
        {
            return message.GetAccidentIdentifier(message.AccidentIdentifierRepetitionsUsed);
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
        /// Add a new ProfessionalOrganizationAffiliationDateRange to AFF
        /// </summary>
        public static DR AddProfessionalOrganizationAffiliationDateRange(this AFF message)
        {
            return message.GetProfessionalOrganizationAffiliationDateRange(message.ProfessionalOrganizationAffiliationDateRangeRepetitionsUsed);
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
        /// Get RequestedDisciplineS Records from AUT
        /// </summary>
        public static IEnumerable GetRequestedDisciplineSRecords(this AUT message)
        {
            object[] result = message.GetRecords("RequestedDisciplineSRepetitionsUsed", "GetRequestedDisciplineS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RequestedDisciplineS Records from AUT
        /// </summary>
        public static List<CWE> GetAllRequestedDisciplineSRecords(this AUT message)
        {
            return message.GetAllRecords<CWE>("RequestedDisciplineSRepetitionsUsed", "GetRequestedDisciplineS");
        }

        /// <summary>
        /// Add a new RequestedDisciplineS to AUT
        /// </summary>
        public static CWE AddRequestedDisciplineS(this AUT message)
        {
            return message.GetRequestedDisciplineS(message.RequestedDisciplineSRepetitionsUsed);
        }

        /// <summary>
        /// Get AuthorizedDisciplineS Records from AUT
        /// </summary>
        public static IEnumerable GetAuthorizedDisciplineSRecords(this AUT message)
        {
            object[] result = message.GetRecords("AuthorizedDisciplineSRepetitionsUsed", "GetAuthorizedDisciplineS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AuthorizedDisciplineS Records from AUT
        /// </summary>
        public static List<CWE> GetAllAuthorizedDisciplineSRecords(this AUT message)
        {
            return message.GetAllRecords<CWE>("AuthorizedDisciplineSRepetitionsUsed", "GetAuthorizedDisciplineS");
        }

        /// <summary>
        /// Add a new AuthorizedDisciplineS to AUT
        /// </summary>
        public static CWE AddAuthorizedDisciplineS(this AUT message)
        {
            return message.GetAuthorizedDisciplineS(message.AuthorizedDisciplineSRepetitionsUsed);
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
        public static List<CWE> GetAllRelationshipToSubjectRecords(this CON message)
        {
            return message.GetAllRecords<CWE>("RelationshipToSubjectRepetitionsUsed", "GetRelationshipToSubject");
        }

        /// <summary>
        /// Add a new RelationshipToSubject to CON
        /// </summary>
        public static CWE AddRelationshipToSubject(this CON message)
        {
            return message.GetRelationshipToSubject(message.RelationshipToSubjectRepetitionsUsed);
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
        /// Get IntendedProcedureType Records from DON
        /// </summary>
        public static IEnumerable GetIntendedProcedureTypeRecords(this DON message)
        {
            object[] result = message.GetRecords("IntendedProcedureTypeRepetitionsUsed", "GetIntendedProcedureType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IntendedProcedureType Records from DON
        /// </summary>
        public static List<CNE> GetAllIntendedProcedureTypeRecords(this DON message)
        {
            return message.GetAllRecords<CNE>("IntendedProcedureTypeRepetitionsUsed", "GetIntendedProcedureType");
        }

        /// <summary>
        /// Add a new IntendedProcedureType to DON
        /// </summary>
        public static CNE AddIntendedProcedureType(this DON message)
        {
            return message.GetIntendedProcedureType(message.IntendedProcedureTypeRepetitionsUsed);
        }

        /// <summary>
        /// Get ActualProcedureType Records from DON
        /// </summary>
        public static IEnumerable GetActualProcedureTypeRecords(this DON message)
        {
            object[] result = message.GetRecords("ActualProcedureTypeRepetitionsUsed", "GetActualProcedureType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ActualProcedureType Records from DON
        /// </summary>
        public static List<CNE> GetAllActualProcedureTypeRecords(this DON message)
        {
            return message.GetAllRecords<CNE>("ActualProcedureTypeRepetitionsUsed", "GetActualProcedureType");
        }

        /// <summary>
        /// Add a new ActualProcedureType to DON
        /// </summary>
        public static CNE AddActualProcedureType(this DON message)
        {
            return message.GetActualProcedureType(message.ActualProcedureTypeRepetitionsUsed);
        }

        /// <summary>
        /// Get DonorEligibilityProcedureType Records from DON
        /// </summary>
        public static IEnumerable GetDonorEligibilityProcedureTypeRecords(this DON message)
        {
            object[] result = message.GetRecords("DonorEligibilityProcedureTypeRepetitionsUsed", "GetDonorEligibilityProcedureType");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DonorEligibilityProcedureType Records from DON
        /// </summary>
        public static List<CNE> GetAllDonorEligibilityProcedureTypeRecords(this DON message)
        {
            return message.GetAllRecords<CNE>("DonorEligibilityProcedureTypeRepetitionsUsed", "GetDonorEligibilityProcedureType");
        }

        /// <summary>
        /// Add a new DonorEligibilityProcedureType to DON
        /// </summary>
        public static CNE AddDonorEligibilityProcedureType(this DON message)
        {
            return message.GetDonorEligibilityProcedureType(message.DonorEligibilityProcedureTypeRepetitionsUsed);
        }

        /// <summary>
        /// Get PhlebotomyIssue Records from DON
        /// </summary>
        public static IEnumerable GetPhlebotomyIssueRecords(this DON message)
        {
            object[] result = message.GetRecords("PhlebotomyIssueRepetitionsUsed", "GetPhlebotomyIssue");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PhlebotomyIssue Records from DON
        /// </summary>
        public static List<CNE> GetAllPhlebotomyIssueRecords(this DON message)
        {
            return message.GetAllRecords<CNE>("PhlebotomyIssueRepetitionsUsed", "GetPhlebotomyIssue");
        }

        /// <summary>
        /// Add a new PhlebotomyIssue to DON
        /// </summary>
        public static CNE AddPhlebotomyIssue(this DON message)
        {
            return message.GetPhlebotomyIssue(message.PhlebotomyIssueRepetitionsUsed);
        }

        /// <summary>
        /// Get DonationSampleIdentifier Records from DON
        /// </summary>
        public static IEnumerable GetDonationSampleIdentifierRecords(this DON message)
        {
            object[] result = message.GetRecords("DonationSampleIdentifierRepetitionsUsed", "GetDonationSampleIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DonationSampleIdentifier Records from DON
        /// </summary>
        public static List<EI> GetAllDonationSampleIdentifierRecords(this DON message)
        {
            return message.GetAllRecords<EI>("DonationSampleIdentifierRepetitionsUsed", "GetDonationSampleIdentifier");
        }

        /// <summary>
        /// Add a new DonationSampleIdentifier to DON
        /// </summary>
        public static EI AddDonationSampleIdentifier(this DON message)
        {
            return message.GetDonationSampleIdentifier(message.DonationSampleIdentifierRepetitionsUsed);
        }

        /// <summary>
        /// Get DonationMaterialReviewStaff Records from DON
        /// </summary>
        public static IEnumerable GetDonationMaterialReviewStaffRecords(this DON message)
        {
            object[] result = message.GetRecords("DonationMaterialReviewStaffRepetitionsUsed", "GetDonationMaterialReviewStaff");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DonationMaterialReviewStaff Records from DON
        /// </summary>
        public static List<XCN> GetAllDonationMaterialReviewStaffRecords(this DON message)
        {
            return message.GetAllRecords<XCN>("DonationMaterialReviewStaffRepetitionsUsed", "GetDonationMaterialReviewStaff");
        }

        /// <summary>
        /// Add a new DonationMaterialReviewStaff to DON
        /// </summary>
        public static XCN AddDonationMaterialReviewStaff(this DON message)
        {
            return message.GetDonationMaterialReviewStaff(message.DonationMaterialReviewStaffRepetitionsUsed);
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
        /// Get EquipmentInstanceIdentifier Records from EQU
        /// </summary>
        public static IEnumerable GetEquipmentInstanceIdentifierRecords(this EQU message)
        {
            object[] result = message.GetRecords("EquipmentInstanceIdentifierRepetitionsUsed", "GetEquipmentInstanceIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EquipmentInstanceIdentifier Records from EQU
        /// </summary>
        public static List<EI> GetAllEquipmentInstanceIdentifierRecords(this EQU message)
        {
            return message.GetAllRecords<EI>("EquipmentInstanceIdentifierRepetitionsUsed", "GetEquipmentInstanceIdentifier");
        }

        /// <summary>
        /// Add a new EquipmentInstanceIdentifier to EQU
        /// </summary>
        public static EI AddEquipmentInstanceIdentifier(this EQU message)
        {
            return message.GetEquipmentInstanceIdentifier(message.EquipmentInstanceIdentifierRepetitionsUsed);
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
        public static List<CWE> GetAllInformPersonIndicatorRecords(this ERR message)
        {
            return message.GetAllRecords<CWE>("InformPersonIndicatorRepetitionsUsed", "GetInformPersonIndicator");
        }

        /// <summary>
        /// Add a new InformPersonIndicator to ERR
        /// </summary>
        public static CWE AddInformPersonIndicator(this ERR message)
        {
            return message.GetInformPersonIndicator(message.InformPersonIndicatorRepetitionsUsed);
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
        /// Get PerformingFacility Records from FT1
        /// </summary>
        public static IEnumerable GetPerformingFacilityRecords(this FT1 message)
        {
            object[] result = message.GetRecords("PerformingFacilityRepetitionsUsed", "GetPerformingFacility");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PerformingFacility Records from FT1
        /// </summary>
        public static List<XON> GetAllPerformingFacilityRecords(this FT1 message)
        {
            return message.GetAllRecords<XON>("PerformingFacilityRepetitionsUsed", "GetPerformingFacility");
        }

        /// <summary>
        /// Add a new PerformingFacility to FT1
        /// </summary>
        public static XON AddPerformingFacility(this FT1 message)
        {
            return message.GetPerformingFacility(message.PerformingFacilityRepetitionsUsed);
        }

        /// <summary>
        /// Get SpecialProcessingCode Records from FT1
        /// </summary>
        public static IEnumerable GetSpecialProcessingCodeRecords(this FT1 message)
        {
            object[] result = message.GetRecords("SpecialProcessingCodeRepetitionsUsed", "GetSpecialProcessingCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialProcessingCode Records from FT1
        /// </summary>
        public static List<CWE> GetAllSpecialProcessingCodeRecords(this FT1 message)
        {
            return message.GetAllRecords<CWE>("SpecialProcessingCodeRepetitionsUsed", "GetSpecialProcessingCode");
        }

        /// <summary>
        /// Add a new SpecialProcessingCode to FT1
        /// </summary>
        public static CWE AddSpecialProcessingCode(this FT1 message)
        {
            return message.GetSpecialProcessingCode(message.SpecialProcessingCodeRepetitionsUsed);
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
        public static List<CWE> GetAllRevenueCodeRecords(this GP1 message)
        {
            return message.GetAllRecords<CWE>("RevenueCodeRepetitionsUsed", "GetRevenueCode");
        }

        /// <summary>
        /// Add a new RevenueCode to GP1
        /// </summary>
        public static CWE AddRevenueCode(this GP1 message)
        {
            return message.GetRevenueCode(message.RevenueCodeRepetitionsUsed);
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
        public static List<CWE> GetAllOCEEditsPerVisitCodeRecords(this GP1 message)
        {
            return message.GetAllRecords<CWE>("OCEEditsPerVisitCodeRepetitionsUsed", "GetOCEEditsPerVisitCode");
        }

        /// <summary>
        /// Add a new OCEEditsPerVisitCode to GP1
        /// </summary>
        public static CWE AddOCEEditsPerVisitCode(this GP1 message)
        {
            return message.GetOCEEditsPerVisitCode(message.OCEEditsPerVisitCodeRepetitionsUsed);
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
        public static List<CWE> GetAllOCEEditCodeRecords(this GP2 message)
        {
            return message.GetAllRecords<CWE>("OCEEditCodeRepetitionsUsed", "GetOCEEditCode");
        }

        /// <summary>
        /// Add a new OCEEditCode to GP2
        /// </summary>
        public static CWE AddOCEEditCode(this GP2 message)
        {
            return message.GetOCEEditCode(message.OCEEditCodeRepetitionsUsed);
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
        public static List<CWE> GetAllModifierEditCodeRecords(this GP2 message)
        {
            return message.GetAllRecords<CWE>("ModifierEditCodeRepetitionsUsed", "GetModifierEditCode");
        }

        /// <summary>
        /// Add a new ModifierEditCode to GP2
        /// </summary>
        public static CWE AddModifierEditCode(this GP2 message)
        {
            return message.GetModifierEditCode(message.ModifierEditCodeRepetitionsUsed);
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
        public static List<CWE> GetAllAmbulatoryStatusRecords(this GT1 message)
        {
            return message.GetAllRecords<CWE>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Add a new AmbulatoryStatus to GT1
        /// </summary>
        public static CWE AddAmbulatoryStatus(this GT1 message)
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
        /// Get ExternalHealthPlanIdentifiers Records from IN1
        /// </summary>
        public static IEnumerable GetExternalHealthPlanIdentifiersRecords(this IN1 message)
        {
            object[] result = message.GetRecords("ExternalHealthPlanIdentifiersRepetitionsUsed", "GetExternalHealthPlanIdentifiers");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ExternalHealthPlanIdentifiers Records from IN1
        /// </summary>
        public static List<CX> GetAllExternalHealthPlanIdentifiersRecords(this IN1 message)
        {
            return message.GetAllRecords<CX>("ExternalHealthPlanIdentifiersRepetitionsUsed", "GetExternalHealthPlanIdentifiers");
        }

        /// <summary>
        /// Add a new ExternalHealthPlanIdentifiers to IN1
        /// </summary>
        public static CX AddExternalHealthPlanIdentifiers(this IN1 message)
        {
            return message.GetExternalHealthPlanIdentifiers(message.ExternalHealthPlanIdentifiersRepetitionsUsed);
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
        public static List<CWE> GetAllMailClaimPartyRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("MailClaimPartyRepetitionsUsed", "GetMailClaimParty");
        }

        /// <summary>
        /// Add a new MailClaimParty to IN2
        /// </summary>
        public static CWE AddMailClaimParty(this IN2 message)
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
        public static List<CWE> GetAllNonCoveredInsuranceCodeRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("NonCoveredInsuranceCodeRepetitionsUsed", "GetNonCoveredInsuranceCode");
        }

        /// <summary>
        /// Add a new NonCoveredInsuranceCode to IN2
        /// </summary>
        public static CWE AddNonCoveredInsuranceCode(this IN2 message)
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
        public static List<CWE> GetAllAmbulatoryStatusRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Add a new AmbulatoryStatus to IN2
        /// </summary>
        public static CWE AddAmbulatoryStatus(this IN2 message)
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
        public static List<CWE> GetAllInsuredSContactPersonReasonRecords(this IN2 message)
        {
            return message.GetAllRecords<CWE>("InsuredSContactPersonReasonRepetitionsUsed", "GetInsuredSContactPersonReason");
        }

        /// <summary>
        /// Add a new InsuredSContactPersonReason to IN2
        /// </summary>
        public static CWE AddInsuredSContactPersonReason(this IN2 message)
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
        public static List<CWE> GetAllSecondOpinionDocumentationReceivedRecords(this IN3 message)
        {
            return message.GetAllRecords<CWE>("SecondOpinionDocumentationReceivedRepetitionsUsed", "GetSecondOpinionDocumentationReceived");
        }

        /// <summary>
        /// Add a new SecondOpinionDocumentationReceived to IN3
        /// </summary>
        public static CWE AddSecondOpinionDocumentationReceived(this IN3 message)
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
        public static List<CWE> GetAllLocationServiceRecords(this LDP message)
        {
            return message.GetAllRecords<CWE>("LocationServiceRepetitionsUsed", "GetLocationService");
        }

        /// <summary>
        /// Add a new LocationService to LDP
        /// </summary>
        public static CWE AddLocationService(this LDP message)
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
        public static List<CWE> GetAllValidPatientClassesRecords(this LDP message)
        {
            return message.GetAllRecords<CWE>("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");
        }

        /// <summary>
        /// Add a new ValidPatientClasses to LDP
        /// </summary>
        public static CWE AddValidPatientClasses(this LDP message)
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
        public static List<CWE> GetAllLocationTypeLOCRecords(this LOC message)
        {
            return message.GetAllRecords<CWE>("LocationTypeLOCRepetitionsUsed", "GetLocationTypeLOC");
        }

        /// <summary>
        /// Add a new LocationTypeLOC to LOC
        /// </summary>
        public static CWE AddLocationTypeLOC(this LOC message)
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
        public static List<CWE> GetAllLocationEquipmentRecords(this LOC message)
        {
            return message.GetAllRecords<CWE>("LocationEquipmentRepetitionsUsed", "GetLocationEquipment");
        }

        /// <summary>
        /// Add a new LocationEquipment to LOC
        /// </summary>
        public static CWE AddLocationEquipment(this LOC message)
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
        /// Get PriorAlternateVisitID Records from MRG
        /// </summary>
        public static IEnumerable GetPriorAlternateVisitIDRecords(this MRG message)
        {
            object[] result = message.GetRecords("PriorAlternateVisitIDRepetitionsUsed", "GetPriorAlternateVisitID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PriorAlternateVisitID Records from MRG
        /// </summary>
        public static List<CX> GetAllPriorAlternateVisitIDRecords(this MRG message)
        {
            return message.GetAllRecords<CX>("PriorAlternateVisitIDRepetitionsUsed", "GetPriorAlternateVisitID");
        }

        /// <summary>
        /// Add a new PriorAlternateVisitID to MRG
        /// </summary>
        public static CX AddPriorAlternateVisitID(this MRG message)
        {
            return message.GetPriorAlternateVisitID(message.PriorAlternateVisitIDRepetitionsUsed);
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
        public static List<CWE> GetAllLivingDependencyRecords(this NK1 message)
        {
            return message.GetAllRecords<CWE>("LivingDependencyRepetitionsUsed", "GetLivingDependency");
        }

        /// <summary>
        /// Add a new LivingDependency to NK1
        /// </summary>
        public static CWE AddLivingDependency(this NK1 message)
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
        public static List<CWE> GetAllAmbulatoryStatusRecords(this NK1 message)
        {
            return message.GetAllRecords<CWE>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Add a new AmbulatoryStatus to NK1
        /// </summary>
        public static CWE AddAmbulatoryStatus(this NK1 message)
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
        /// Get RelevantClinicalInformation Records from OBR
        /// </summary>
        public static IEnumerable GetRelevantClinicalInformationRecords(this OBR message)
        {
            object[] result = message.GetRecords("RelevantClinicalInformationRepetitionsUsed", "GetRelevantClinicalInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RelevantClinicalInformation Records from OBR
        /// </summary>
        public static List<CWE> GetAllRelevantClinicalInformationRecords(this OBR message)
        {
            return message.GetAllRecords<CWE>("RelevantClinicalInformationRepetitionsUsed", "GetRelevantClinicalInformation");
        }

        /// <summary>
        /// Add a new RelevantClinicalInformation to OBR
        /// </summary>
        public static CWE AddRelevantClinicalInformation(this OBR message)
        {
            return message.GetRelevantClinicalInformation(message.RelevantClinicalInformationRepetitionsUsed);
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
        public static List<ST> GetAllQuantityTimingRecords(this OBR message)
        {
            return message.GetAllRecords<ST>("QuantityTimingRepetitionsUsed", "GetQuantityTiming");
        }

        /// <summary>
        /// Add a new QuantityTiming to OBR
        /// </summary>
        public static ST AddQuantityTiming(this OBR message)
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
        /// Get AlternatePlacerOrderNumber Records from OBR
        /// </summary>
        public static IEnumerable GetAlternatePlacerOrderNumberRecords(this OBR message)
        {
            object[] result = message.GetRecords("AlternatePlacerOrderNumberRepetitionsUsed", "GetAlternatePlacerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AlternatePlacerOrderNumber Records from OBR
        /// </summary>
        public static List<CX> GetAllAlternatePlacerOrderNumberRecords(this OBR message)
        {
            return message.GetAllRecords<CX>("AlternatePlacerOrderNumberRepetitionsUsed", "GetAlternatePlacerOrderNumber");
        }

        /// <summary>
        /// Add a new AlternatePlacerOrderNumber to OBR
        /// </summary>
        public static CX AddAlternatePlacerOrderNumber(this OBR message)
        {
            return message.GetAlternatePlacerOrderNumber(message.AlternatePlacerOrderNumberRepetitionsUsed);
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
        /// Get InterpretationCodes Records from OBX
        /// </summary>
        public static IEnumerable GetInterpretationCodesRecords(this OBX message)
        {
            object[] result = message.GetRecords("InterpretationCodesRepetitionsUsed", "GetInterpretationCodes");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InterpretationCodes Records from OBX
        /// </summary>
        public static List<CWE> GetAllInterpretationCodesRecords(this OBX message)
        {
            return message.GetAllRecords<CWE>("InterpretationCodesRepetitionsUsed", "GetInterpretationCodes");
        }

        /// <summary>
        /// Add a new InterpretationCodes to OBX
        /// </summary>
        public static CWE AddInterpretationCodes(this OBX message)
        {
            return message.GetInterpretationCodes(message.InterpretationCodesRepetitionsUsed);
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
        /// Get LocalProcessControl Records from OBX
        /// </summary>
        public static IEnumerable GetLocalProcessControlRecords(this OBX message)
        {
            object[] result = message.GetRecords("LocalProcessControlRepetitionsUsed", "GetLocalProcessControl");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LocalProcessControl Records from OBX
        /// </summary>
        public static List<CWE> GetAllLocalProcessControlRecords(this OBX message)
        {
            return message.GetAllRecords<CWE>("LocalProcessControlRepetitionsUsed", "GetLocalProcessControl");
        }

        /// <summary>
        /// Add a new LocalProcessControl to OBX
        /// </summary>
        public static CWE AddLocalProcessControl(this OBX message)
        {
            return message.GetLocalProcessControl(message.LocalProcessControlRepetitionsUsed);
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
        /// Get OtherServiceTestObservationIDsForTheObservation Records from OM1
        /// </summary>
        public static IEnumerable GetOtherServiceTestObservationIDsForTheObservationRecords(this OM1 message)
        {
            object[] result = message.GetRecords("OtherServiceTestObservationIDsForTheObservationRepetitionsUsed", "GetOtherServiceTestObservationIDsForTheObservation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherServiceTestObservationIDsForTheObservation Records from OM1
        /// </summary>
        public static List<CWE> GetAllOtherServiceTestObservationIDsForTheObservationRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("OtherServiceTestObservationIDsForTheObservationRepetitionsUsed", "GetOtherServiceTestObservationIDsForTheObservation");
        }

        /// <summary>
        /// Add a new OtherServiceTestObservationIDsForTheObservation to OM1
        /// </summary>
        public static CWE AddOtherServiceTestObservationIDsForTheObservation(this OM1 message)
        {
            return message.GetOtherServiceTestObservationIDsForTheObservation(message.OtherServiceTestObservationIDsForTheObservationRepetitionsUsed);
        }

        /// <summary>
        /// Get OtherNames_OM18 Records from OM1
        /// </summary>
        public static IEnumerable GetOtherNames_OM18Records(this OM1 message)
        {
            object[] result = message.GetRecords("OtherNames_OM18RepetitionsUsed", "GetOtherNames_OM18");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherNames_OM18 Records from OM1
        /// </summary>
        public static List<ST> GetAllOtherNames_OM18Records(this OM1 message)
        {
            return message.GetAllRecords<ST>("OtherNames_OM18RepetitionsUsed", "GetOtherNames_OM18");
        }

        /// <summary>
        /// Add a new OtherNames_OM18 to OM1
        /// </summary>
        public static ST AddOtherNames_OM18(this OM1 message)
        {
            return message.GetOtherNames_OM18(message.OtherNames_OM18RepetitionsUsed);
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
        /// Get ObservationsRequiredToInterpretThisObservation Records from OM1
        /// </summary>
        public static IEnumerable GetObservationsRequiredToInterpretThisObservationRecords(this OM1 message)
        {
            object[] result = message.GetRecords("ObservationsRequiredToInterpretThisObservationRepetitionsUsed", "GetObservationsRequiredToInterpretThisObservation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ObservationsRequiredToInterpretThisObservation Records from OM1
        /// </summary>
        public static List<CWE> GetAllObservationsRequiredToInterpretThisObservationRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("ObservationsRequiredToInterpretThisObservationRepetitionsUsed", "GetObservationsRequiredToInterpretThisObservation");
        }

        /// <summary>
        /// Add a new ObservationsRequiredToInterpretThisObservation to OM1
        /// </summary>
        public static CWE AddObservationsRequiredToInterpretThisObservation(this OM1 message)
        {
            return message.GetObservationsRequiredToInterpretThisObservation(message.ObservationsRequiredToInterpretThisObservationRepetitionsUsed);
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
        public static List<CWE> GetAllContraindicationsToObservationsRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("ContraindicationsToObservationsRepetitionsUsed", "GetContraindicationsToObservations");
        }

        /// <summary>
        /// Add a new ContraindicationsToObservations to OM1
        /// </summary>
        public static CWE AddContraindicationsToObservations(this OM1 message)
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
        /// Get RulesThatTriggerReflexTesting Records from OM1
        /// </summary>
        public static IEnumerable GetRulesThatTriggerReflexTestingRecords(this OM1 message)
        {
            object[] result = message.GetRecords("RulesThatTriggerReflexTestingRepetitionsUsed", "GetRulesThatTriggerReflexTesting");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RulesThatTriggerReflexTesting Records from OM1
        /// </summary>
        public static List<TX> GetAllRulesThatTriggerReflexTestingRecords(this OM1 message)
        {
            return message.GetAllRecords<TX>("RulesThatTriggerReflexTestingRepetitionsUsed", "GetRulesThatTriggerReflexTesting");
        }

        /// <summary>
        /// Add a new RulesThatTriggerReflexTesting to OM1
        /// </summary>
        public static TX AddRulesThatTriggerReflexTesting(this OM1 message)
        {
            return message.GetRulesThatTriggerReflexTesting(message.RulesThatTriggerReflexTestingRepetitionsUsed);
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
        public static List<CWE> GetAllFixedCannedMessageRecords(this OM1 message)
        {
            return message.GetAllRecords<CWE>("FixedCannedMessageRepetitionsUsed", "GetFixedCannedMessage");
        }

        /// <summary>
        /// Add a new FixedCannedMessage to OM1
        /// </summary>
        public static CWE AddFixedCannedMessage(this OM1 message)
        {
            return message.GetFixedCannedMessage(message.FixedCannedMessageRepetitionsUsed);
        }

        /// <summary>
        /// Get PatientPreparation Records from OM1
        /// </summary>
        public static IEnumerable GetPatientPreparationRecords(this OM1 message)
        {
            object[] result = message.GetRecords("PatientPreparationRepetitionsUsed", "GetPatientPreparation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientPreparation Records from OM1
        /// </summary>
        public static List<TX> GetAllPatientPreparationRecords(this OM1 message)
        {
            return message.GetAllRecords<TX>("PatientPreparationRepetitionsUsed", "GetPatientPreparation");
        }

        /// <summary>
        /// Add a new PatientPreparation to OM1
        /// </summary>
        public static TX AddPatientPreparation(this OM1 message)
        {
            return message.GetPatientPreparation(message.PatientPreparationRepetitionsUsed);
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
        /// Get OtherNames_OM151 Records from OM1
        /// </summary>
        public static IEnumerable GetOtherNames_OM151Records(this OM1 message)
        {
            object[] result = message.GetRecords("OtherNames_OM151RepetitionsUsed", "GetOtherNames_OM151");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherNames_OM151 Records from OM1
        /// </summary>
        public static List<ST> GetAllOtherNames_OM151Records(this OM1 message)
        {
            return message.GetAllRecords<ST>("OtherNames_OM151RepetitionsUsed", "GetOtherNames_OM151");
        }

        /// <summary>
        /// Add a new OtherNames_OM151 to OM1
        /// </summary>
        public static ST AddOtherNames_OM151(this OM1 message)
        {
            return message.GetOtherNames_OM151(message.OtherNames_OM151RepetitionsUsed);
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
        /// Get ContainerDescription Records from OM4
        /// </summary>
        public static IEnumerable GetContainerDescriptionRecords(this OM4 message)
        {
            object[] result = message.GetRecords("ContainerDescriptionRepetitionsUsed", "GetContainerDescription");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContainerDescription Records from OM4
        /// </summary>
        public static List<TX> GetAllContainerDescriptionRecords(this OM4 message)
        {
            return message.GetAllRecords<TX>("ContainerDescriptionRepetitionsUsed", "GetContainerDescription");
        }

        /// <summary>
        /// Add a new ContainerDescription to OM4
        /// </summary>
        public static TX AddContainerDescription(this OM4 message)
        {
            return message.GetContainerDescription(message.ContainerDescriptionRepetitionsUsed);
        }

        /// <summary>
        /// Get ContainerVolume Records from OM4
        /// </summary>
        public static IEnumerable GetContainerVolumeRecords(this OM4 message)
        {
            object[] result = message.GetRecords("ContainerVolumeRepetitionsUsed", "GetContainerVolume");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContainerVolume Records from OM4
        /// </summary>
        public static List<NM> GetAllContainerVolumeRecords(this OM4 message)
        {
            return message.GetAllRecords<NM>("ContainerVolumeRepetitionsUsed", "GetContainerVolume");
        }

        /// <summary>
        /// Add a new ContainerVolume to OM4
        /// </summary>
        public static NM AddContainerVolume(this OM4 message)
        {
            return message.GetContainerVolume(message.ContainerVolumeRepetitionsUsed);
        }

        /// <summary>
        /// Get ContainerUnits Records from OM4
        /// </summary>
        public static IEnumerable GetContainerUnitsRecords(this OM4 message)
        {
            object[] result = message.GetRecords("ContainerUnitsRepetitionsUsed", "GetContainerUnits");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ContainerUnits Records from OM4
        /// </summary>
        public static List<CWE> GetAllContainerUnitsRecords(this OM4 message)
        {
            return message.GetAllRecords<CWE>("ContainerUnitsRepetitionsUsed", "GetContainerUnits");
        }

        /// <summary>
        /// Add a new ContainerUnits to OM4
        /// </summary>
        public static CWE AddContainerUnits(this OM4 message)
        {
            return message.GetContainerUnits(message.ContainerUnitsRepetitionsUsed);
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
        /// Get SpecimenHandlingCode Records from OM4
        /// </summary>
        public static IEnumerable GetSpecimenHandlingCodeRecords(this OM4 message)
        {
            object[] result = message.GetRecords("SpecimenHandlingCodeRepetitionsUsed", "GetSpecimenHandlingCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecimenHandlingCode Records from OM4
        /// </summary>
        public static List<CWE> GetAllSpecimenHandlingCodeRecords(this OM4 message)
        {
            return message.GetAllRecords<CWE>("SpecimenHandlingCodeRepetitionsUsed", "GetSpecimenHandlingCode");
        }

        /// <summary>
        /// Add a new SpecimenHandlingCode to OM4
        /// </summary>
        public static CWE AddSpecimenHandlingCode(this OM4 message)
        {
            return message.GetSpecimenHandlingCode(message.SpecimenHandlingCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get TaxonomicClassificationCode Records from OM4
        /// </summary>
        public static IEnumerable GetTaxonomicClassificationCodeRecords(this OM4 message)
        {
            object[] result = message.GetRecords("TaxonomicClassificationCodeRepetitionsUsed", "GetTaxonomicClassificationCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TaxonomicClassificationCode Records from OM4
        /// </summary>
        public static List<CWE> GetAllTaxonomicClassificationCodeRecords(this OM4 message)
        {
            return message.GetAllRecords<CWE>("TaxonomicClassificationCodeRepetitionsUsed", "GetTaxonomicClassificationCode");
        }

        /// <summary>
        /// Add a new TaxonomicClassificationCode to OM4
        /// </summary>
        public static CWE AddTaxonomicClassificationCode(this OM4 message)
        {
            return message.GetTaxonomicClassificationCode(message.TaxonomicClassificationCodeRepetitionsUsed);
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
        public static List<ST> GetAllQuantityTimingRecords(this ORC message)
        {
            return message.GetAllRecords<ST>("QuantityTimingRepetitionsUsed", "GetQuantityTiming");
        }

        /// <summary>
        /// Add a new QuantityTiming to ORC
        /// </summary>
        public static ST AddQuantityTiming(this ORC message)
        {
            return message.GetQuantityTiming(message.QuantityTimingRepetitionsUsed);
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
        /// Get AlternatePlacerOrderNumber Records from ORC
        /// </summary>
        public static IEnumerable GetAlternatePlacerOrderNumberRecords(this ORC message)
        {
            object[] result = message.GetRecords("AlternatePlacerOrderNumberRepetitionsUsed", "GetAlternatePlacerOrderNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AlternatePlacerOrderNumber Records from ORC
        /// </summary>
        public static List<CX> GetAllAlternatePlacerOrderNumberRecords(this ORC message)
        {
            return message.GetAllRecords<CX>("AlternatePlacerOrderNumberRepetitionsUsed", "GetAlternatePlacerOrderNumber");
        }

        /// <summary>
        /// Add a new AlternatePlacerOrderNumber to ORC
        /// </summary>
        public static CX AddAlternatePlacerOrderNumber(this ORC message)
        {
            return message.GetAlternatePlacerOrderNumber(message.AlternatePlacerOrderNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get OrderWorkflowProfile Records from ORC
        /// </summary>
        public static IEnumerable GetOrderWorkflowProfileRecords(this ORC message)
        {
            object[] result = message.GetRecords("OrderWorkflowProfileRepetitionsUsed", "GetOrderWorkflowProfile");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OrderWorkflowProfile Records from ORC
        /// </summary>
        public static List<CWE> GetAllOrderWorkflowProfileRecords(this ORC message)
        {
            return message.GetAllRecords<CWE>("OrderWorkflowProfileRepetitionsUsed", "GetOrderWorkflowProfile");
        }

        /// <summary>
        /// Add a new OrderWorkflowProfile to ORC
        /// </summary>
        public static CWE AddOrderWorkflowProfile(this ORC message)
        {
            return message.GetOrderWorkflowProfile(message.OrderWorkflowProfileRepetitionsUsed);
        }

        /// <summary>
        /// Get CostCenterCode Records from ORG
        /// </summary>
        public static IEnumerable GetCostCenterCodeRecords(this ORG message)
        {
            object[] result = message.GetRecords("CostCenterCodeRepetitionsUsed", "GetCostCenterCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CostCenterCode Records from ORG
        /// </summary>
        public static List<CWE> GetAllCostCenterCodeRecords(this ORG message)
        {
            return message.GetAllRecords<CWE>("CostCenterCodeRepetitionsUsed", "GetCostCenterCode");
        }

        /// <summary>
        /// Add a new CostCenterCode to ORG
        /// </summary>
        public static CWE AddCostCenterCode(this ORG message)
        {
            return message.GetCostCenterCode(message.CostCenterCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get PackageCondition Records from PAC
        /// </summary>
        public static IEnumerable GetPackageConditionRecords(this PAC message)
        {
            object[] result = message.GetRecords("PackageConditionRepetitionsUsed", "GetPackageCondition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PackageCondition Records from PAC
        /// </summary>
        public static List<CWE> GetAllPackageConditionRecords(this PAC message)
        {
            return message.GetAllRecords<CWE>("PackageConditionRepetitionsUsed", "GetPackageCondition");
        }

        /// <summary>
        /// Add a new PackageCondition to PAC
        /// </summary>
        public static CWE AddPackageCondition(this PAC message)
        {
            return message.GetPackageCondition(message.PackageConditionRepetitionsUsed);
        }

        /// <summary>
        /// Get PackageHandlingCode Records from PAC
        /// </summary>
        public static IEnumerable GetPackageHandlingCodeRecords(this PAC message)
        {
            object[] result = message.GetRecords("PackageHandlingCodeRepetitionsUsed", "GetPackageHandlingCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PackageHandlingCode Records from PAC
        /// </summary>
        public static List<CWE> GetAllPackageHandlingCodeRecords(this PAC message)
        {
            return message.GetAllRecords<CWE>("PackageHandlingCodeRepetitionsUsed", "GetPackageHandlingCode");
        }

        /// <summary>
        /// Add a new PackageHandlingCode to PAC
        /// </summary>
        public static CWE AddPackageHandlingCode(this PAC message)
        {
            return message.GetPackageHandlingCode(message.PackageHandlingCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get PackageRiskCode Records from PAC
        /// </summary>
        public static IEnumerable GetPackageRiskCodeRecords(this PAC message)
        {
            object[] result = message.GetRecords("PackageRiskCodeRepetitionsUsed", "GetPackageRiskCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PackageRiskCode Records from PAC
        /// </summary>
        public static List<CWE> GetAllPackageRiskCodeRecords(this PAC message)
        {
            return message.GetAllRecords<CWE>("PackageRiskCodeRepetitionsUsed", "GetPackageRiskCode");
        }

        /// <summary>
        /// Add a new PackageRiskCode to PAC
        /// </summary>
        public static CWE AddPackageRiskCode(this PAC message)
        {
            return message.GetPackageRiskCode(message.PackageRiskCodeRepetitionsUsed);
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
        public static List<CWE> GetAllLivingDependencyRecords(this PD1 message)
        {
            return message.GetAllRecords<CWE>("LivingDependencyRepetitionsUsed", "GetLivingDependency");
        }

        /// <summary>
        /// Add a new LivingDependency to PD1
        /// </summary>
        public static CWE AddLivingDependency(this PD1 message)
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
        public static List<CWE> GetAllIdentityReliabilityCodeRecords(this PID message)
        {
            return message.GetAllRecords<CWE>("IdentityReliabilityCodeRepetitionsUsed", "GetIdentityReliabilityCode");
        }

        /// <summary>
        /// Add a new IdentityReliabilityCode to PID
        /// </summary>
        public static CWE AddIdentityReliabilityCode(this PID message)
        {
            return message.GetIdentityReliabilityCode(message.IdentityReliabilityCodeRepetitionsUsed);
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
        /// Get PatientTelecommunicationInformation Records from PID
        /// </summary>
        public static IEnumerable GetPatientTelecommunicationInformationRecords(this PID message)
        {
            object[] result = message.GetRecords("PatientTelecommunicationInformationRepetitionsUsed", "GetPatientTelecommunicationInformation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PatientTelecommunicationInformation Records from PID
        /// </summary>
        public static List<XTN> GetAllPatientTelecommunicationInformationRecords(this PID message)
        {
            return message.GetAllRecords<XTN>("PatientTelecommunicationInformationRepetitionsUsed", "GetPatientTelecommunicationInformation");
        }

        /// <summary>
        /// Add a new PatientTelecommunicationInformation to PID
        /// </summary>
        public static XTN AddPatientTelecommunicationInformation(this PID message)
        {
            return message.GetPatientTelecommunicationInformation(message.PatientTelecommunicationInformationRepetitionsUsed);
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
        /// Get TreatingOrganizationalUnit Records from PR1
        /// </summary>
        public static IEnumerable GetTreatingOrganizationalUnitRecords(this PR1 message)
        {
            object[] result = message.GetRecords("TreatingOrganizationalUnitRepetitionsUsed", "GetTreatingOrganizationalUnit");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all TreatingOrganizationalUnit Records from PR1
        /// </summary>
        public static List<PL> GetAllTreatingOrganizationalUnitRecords(this PR1 message)
        {
            return message.GetAllRecords<PL>("TreatingOrganizationalUnitRepetitionsUsed", "GetTreatingOrganizationalUnit");
        }

        /// <summary>
        /// Add a new TreatingOrganizationalUnit to PR1
        /// </summary>
        public static PL AddTreatingOrganizationalUnit(this PR1 message)
        {
            return message.GetTreatingOrganizationalUnit(message.TreatingOrganizationalUnitRepetitionsUsed);
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
        public static List<CWE> GetAllPractitionerCategoryRecords(this PRA message)
        {
            return message.GetAllRecords<CWE>("PractitionerCategoryRepetitionsUsed", "GetPractitionerCategory");
        }

        /// <summary>
        /// Add a new PractitionerCategory to PRA
        /// </summary>
        public static CWE AddPractitionerCategory(this PRA message)
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
        public static List<CWE> GetAllValidPatientClassesRecords(this PRC message)
        {
            return message.GetAllRecords<CWE>("ValidPatientClassesRepetitionsUsed", "GetValidPatientClasses");
        }

        /// <summary>
        /// Add a new ValidPatientClasses to PRC
        /// </summary>
        public static CWE AddValidPatientClasses(this PRC message)
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
        /// Get ParticipationPerson Records from PRT
        /// </summary>
        public static IEnumerable GetParticipationPersonRecords(this PRT message)
        {
            object[] result = message.GetRecords("ParticipationPersonRepetitionsUsed", "GetParticipationPerson");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ParticipationPerson Records from PRT
        /// </summary>
        public static List<XCN> GetAllParticipationPersonRecords(this PRT message)
        {
            return message.GetAllRecords<XCN>("ParticipationPersonRepetitionsUsed", "GetParticipationPerson");
        }

        /// <summary>
        /// Add a new ParticipationPerson to PRT
        /// </summary>
        public static XCN AddParticipationPerson(this PRT message)
        {
            return message.GetParticipationPerson(message.ParticipationPersonRepetitionsUsed);
        }

        /// <summary>
        /// Get ParticipationOrganization Records from PRT
        /// </summary>
        public static IEnumerable GetParticipationOrganizationRecords(this PRT message)
        {
            object[] result = message.GetRecords("ParticipationOrganizationRepetitionsUsed", "GetParticipationOrganization");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ParticipationOrganization Records from PRT
        /// </summary>
        public static List<XON> GetAllParticipationOrganizationRecords(this PRT message)
        {
            return message.GetAllRecords<XON>("ParticipationOrganizationRepetitionsUsed", "GetParticipationOrganization");
        }

        /// <summary>
        /// Add a new ParticipationOrganization to PRT
        /// </summary>
        public static XON AddParticipationOrganization(this PRT message)
        {
            return message.GetParticipationOrganization(message.ParticipationOrganizationRepetitionsUsed);
        }

        /// <summary>
        /// Get ParticipantLocation Records from PRT
        /// </summary>
        public static IEnumerable GetParticipantLocationRecords(this PRT message)
        {
            object[] result = message.GetRecords("ParticipantLocationRepetitionsUsed", "GetParticipantLocation");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ParticipantLocation Records from PRT
        /// </summary>
        public static List<PL> GetAllParticipantLocationRecords(this PRT message)
        {
            return message.GetAllRecords<PL>("ParticipantLocationRepetitionsUsed", "GetParticipantLocation");
        }

        /// <summary>
        /// Add a new ParticipantLocation to PRT
        /// </summary>
        public static PL AddParticipantLocation(this PRT message)
        {
            return message.GetParticipantLocation(message.ParticipantLocationRepetitionsUsed);
        }

        /// <summary>
        /// Get ParticipationDevice Records from PRT
        /// </summary>
        public static IEnumerable GetParticipationDeviceRecords(this PRT message)
        {
            object[] result = message.GetRecords("ParticipationDeviceRepetitionsUsed", "GetParticipationDevice");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ParticipationDevice Records from PRT
        /// </summary>
        public static List<EI> GetAllParticipationDeviceRecords(this PRT message)
        {
            return message.GetAllRecords<EI>("ParticipationDeviceRepetitionsUsed", "GetParticipationDevice");
        }

        /// <summary>
        /// Add a new ParticipationDevice to PRT
        /// </summary>
        public static EI AddParticipationDevice(this PRT message)
        {
            return message.GetParticipationDevice(message.ParticipationDeviceRepetitionsUsed);
        }

        /// <summary>
        /// Get ParticipationAddress Records from PRT
        /// </summary>
        public static IEnumerable GetParticipationAddressRecords(this PRT message)
        {
            object[] result = message.GetRecords("ParticipationAddressRepetitionsUsed", "GetParticipationAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ParticipationAddress Records from PRT
        /// </summary>
        public static List<XAD> GetAllParticipationAddressRecords(this PRT message)
        {
            return message.GetAllRecords<XAD>("ParticipationAddressRepetitionsUsed", "GetParticipationAddress");
        }

        /// <summary>
        /// Add a new ParticipationAddress to PRT
        /// </summary>
        public static XAD AddParticipationAddress(this PRT message)
        {
            return message.GetParticipationAddress(message.ParticipationAddressRepetitionsUsed);
        }

        /// <summary>
        /// Get ParticipantTelecommunicationAddress Records from PRT
        /// </summary>
        public static IEnumerable GetParticipantTelecommunicationAddressRecords(this PRT message)
        {
            object[] result = message.GetRecords("ParticipantTelecommunicationAddressRepetitionsUsed", "GetParticipantTelecommunicationAddress");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ParticipantTelecommunicationAddress Records from PRT
        /// </summary>
        public static List<XTN> GetAllParticipantTelecommunicationAddressRecords(this PRT message)
        {
            return message.GetAllRecords<XTN>("ParticipantTelecommunicationAddressRepetitionsUsed", "GetParticipantTelecommunicationAddress");
        }

        /// <summary>
        /// Add a new ParticipantTelecommunicationAddress to PRT
        /// </summary>
        public static XTN AddParticipantTelecommunicationAddress(this PRT message)
        {
            return message.GetParticipantTelecommunicationAddress(message.ParticipantTelecommunicationAddressRepetitionsUsed);
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
        public static List<CWE> GetAllAmbulatoryStatusRecords(this PV1 message)
        {
            return message.GetAllRecords<CWE>("AmbulatoryStatusRepetitionsUsed", "GetAmbulatoryStatus");
        }

        /// <summary>
        /// Add a new AmbulatoryStatus to PV1
        /// </summary>
        public static CWE AddAmbulatoryStatus(this PV1 message)
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
        public static List<CWE> GetAllContractCodeRecords(this PV1 message)
        {
            return message.GetAllRecords<CWE>("ContractCodeRepetitionsUsed", "GetContractCode");
        }

        /// <summary>
        /// Add a new ContractCode to PV1
        /// </summary>
        public static CWE AddContractCode(this PV1 message)
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
        /// Get AlternateVisitID Records from PV1
        /// </summary>
        public static IEnumerable GetAlternateVisitIDRecords(this PV1 message)
        {
            object[] result = message.GetRecords("AlternateVisitIDRepetitionsUsed", "GetAlternateVisitID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AlternateVisitID Records from PV1
        /// </summary>
        public static List<CX> GetAllAlternateVisitIDRecords(this PV1 message)
        {
            return message.GetAllRecords<CX>("AlternateVisitIDRepetitionsUsed", "GetAlternateVisitID");
        }

        /// <summary>
        /// Add a new AlternateVisitID to PV1
        /// </summary>
        public static CX AddAlternateVisitID(this PV1 message)
        {
            return message.GetAlternateVisitID(message.AlternateVisitIDRepetitionsUsed);
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
        public static List<CWE> GetAllVisitUserCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CWE>("VisitUserCodeRepetitionsUsed", "GetVisitUserCode");
        }

        /// <summary>
        /// Add a new VisitUserCode to PV2
        /// </summary>
        public static CWE AddVisitUserCode(this PV2 message)
        {
            return message.GetVisitUserCode(message.VisitUserCodeRepetitionsUsed);
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
        public static List<CWE> GetAllNotifyClergyCodeRecords(this PV2 message)
        {
            return message.GetAllRecords<CWE>("NotifyClergyCodeRepetitionsUsed", "GetNotifyClergyCode");
        }

        /// <summary>
        /// Add a new NotifyClergyCode to PV2
        /// </summary>
        public static CWE AddNotifyClergyCode(this PV2 message)
        {
            return message.GetNotifyClergyCode(message.NotifyClergyCodeRepetitionsUsed);
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
        public static List<CWE> GetAllMatchReasonCodeRecords(this QRI message)
        {
            return message.GetAllRecords<CWE>("MatchReasonCodeRepetitionsUsed", "GetMatchReasonCode");
        }

        /// <summary>
        /// Add a new MatchReasonCode to QRI
        /// </summary>
        public static CWE AddMatchReasonCode(this QRI message)
        {
            return message.GetMatchReasonCode(message.MatchReasonCodeRepetitionsUsed);
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
        /// Get AdministeredTagIdentifier Records from RXA
        /// </summary>
        public static IEnumerable GetAdministeredTagIdentifierRecords(this RXA message)
        {
            object[] result = message.GetRecords("AdministeredTagIdentifierRepetitionsUsed", "GetAdministeredTagIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AdministeredTagIdentifier Records from RXA
        /// </summary>
        public static List<EI> GetAllAdministeredTagIdentifierRecords(this RXA message)
        {
            return message.GetAllRecords<EI>("AdministeredTagIdentifierRepetitionsUsed", "GetAdministeredTagIdentifier");
        }

        /// <summary>
        /// Add a new AdministeredTagIdentifier to RXA
        /// </summary>
        public static EI AddAdministeredTagIdentifier(this RXA message)
        {
            return message.GetAdministeredTagIdentifier(message.AdministeredTagIdentifierRepetitionsUsed);
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
        /// Get SpecialDispensingInstructions Records from RXD
        /// </summary>
        public static IEnumerable GetSpecialDispensingInstructionsRecords(this RXD message)
        {
            object[] result = message.GetRecords("SpecialDispensingInstructionsRepetitionsUsed", "GetSpecialDispensingInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialDispensingInstructions Records from RXD
        /// </summary>
        public static List<CWE> GetAllSpecialDispensingInstructionsRecords(this RXD message)
        {
            return message.GetAllRecords<CWE>("SpecialDispensingInstructionsRepetitionsUsed", "GetSpecialDispensingInstructions");
        }

        /// <summary>
        /// Add a new SpecialDispensingInstructions to RXD
        /// </summary>
        public static CWE AddSpecialDispensingInstructions(this RXD message)
        {
            return message.GetSpecialDispensingInstructions(message.SpecialDispensingInstructionsRepetitionsUsed);
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
        /// Get PharmacyPhoneNumber Records from RXD
        /// </summary>
        public static IEnumerable GetPharmacyPhoneNumberRecords(this RXD message)
        {
            object[] result = message.GetRecords("PharmacyPhoneNumberRepetitionsUsed", "GetPharmacyPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacyPhoneNumber Records from RXD
        /// </summary>
        public static List<XTN> GetAllPharmacyPhoneNumberRecords(this RXD message)
        {
            return message.GetAllRecords<XTN>("PharmacyPhoneNumberRepetitionsUsed", "GetPharmacyPhoneNumber");
        }

        /// <summary>
        /// Add a new PharmacyPhoneNumber to RXD
        /// </summary>
        public static XTN AddPharmacyPhoneNumber(this RXD message)
        {
            return message.GetPharmacyPhoneNumber(message.PharmacyPhoneNumberRepetitionsUsed);
        }

        /// <summary>
        /// Get DispenseTagIdentifier Records from RXD
        /// </summary>
        public static IEnumerable GetDispenseTagIdentifierRecords(this RXD message)
        {
            object[] result = message.GetRecords("DispenseTagIdentifierRepetitionsUsed", "GetDispenseTagIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DispenseTagIdentifier Records from RXD
        /// </summary>
        public static List<EI> GetAllDispenseTagIdentifierRecords(this RXD message)
        {
            return message.GetAllRecords<EI>("DispenseTagIdentifierRepetitionsUsed", "GetDispenseTagIdentifier");
        }

        /// <summary>
        /// Add a new DispenseTagIdentifier to RXD
        /// </summary>
        public static EI AddDispenseTagIdentifier(this RXD message)
        {
            return message.GetDispenseTagIdentifier(message.DispenseTagIdentifierRepetitionsUsed);
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
        /// Get SpecialDispensingInstructions Records from RXE
        /// </summary>
        public static IEnumerable GetSpecialDispensingInstructionsRecords(this RXE message)
        {
            object[] result = message.GetRecords("SpecialDispensingInstructionsRepetitionsUsed", "GetSpecialDispensingInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialDispensingInstructions Records from RXE
        /// </summary>
        public static List<CWE> GetAllSpecialDispensingInstructionsRecords(this RXE message)
        {
            return message.GetAllRecords<CWE>("SpecialDispensingInstructionsRepetitionsUsed", "GetSpecialDispensingInstructions");
        }

        /// <summary>
        /// Add a new SpecialDispensingInstructions to RXE
        /// </summary>
        public static CWE AddSpecialDispensingInstructions(this RXE message)
        {
            return message.GetSpecialDispensingInstructions(message.SpecialDispensingInstructionsRepetitionsUsed);
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
        /// Get PharmacyPhoneNumber Records from RXE
        /// </summary>
        public static IEnumerable GetPharmacyPhoneNumberRecords(this RXE message)
        {
            object[] result = message.GetRecords("PharmacyPhoneNumberRepetitionsUsed", "GetPharmacyPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacyPhoneNumber Records from RXE
        /// </summary>
        public static List<XTN> GetAllPharmacyPhoneNumberRecords(this RXE message)
        {
            return message.GetAllRecords<XTN>("PharmacyPhoneNumberRepetitionsUsed", "GetPharmacyPhoneNumber");
        }

        /// <summary>
        /// Add a new PharmacyPhoneNumber to RXE
        /// </summary>
        public static XTN AddPharmacyPhoneNumber(this RXE message)
        {
            return message.GetPharmacyPhoneNumber(message.PharmacyPhoneNumberRepetitionsUsed);
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
        /// Get SpecialAdministrationInstructions Records from RXG
        /// </summary>
        public static IEnumerable GetSpecialAdministrationInstructionsRecords(this RXG message)
        {
            object[] result = message.GetRecords("SpecialAdministrationInstructionsRepetitionsUsed", "GetSpecialAdministrationInstructions");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SpecialAdministrationInstructions Records from RXG
        /// </summary>
        public static List<CWE> GetAllSpecialAdministrationInstructionsRecords(this RXG message)
        {
            return message.GetAllRecords<CWE>("SpecialAdministrationInstructionsRepetitionsUsed", "GetSpecialAdministrationInstructions");
        }

        /// <summary>
        /// Add a new SpecialAdministrationInstructions to RXG
        /// </summary>
        public static CWE AddSpecialAdministrationInstructions(this RXG message)
        {
            return message.GetSpecialAdministrationInstructions(message.SpecialAdministrationInstructionsRepetitionsUsed);
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
        /// Get GiveTagIdentifier Records from RXG
        /// </summary>
        public static IEnumerable GetGiveTagIdentifierRecords(this RXG message)
        {
            object[] result = message.GetRecords("GiveTagIdentifierRepetitionsUsed", "GetGiveTagIdentifier");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GiveTagIdentifier Records from RXG
        /// </summary>
        public static List<EI> GetAllGiveTagIdentifierRecords(this RXG message)
        {
            return message.GetAllRecords<EI>("GiveTagIdentifierRepetitionsUsed", "GetGiveTagIdentifier");
        }

        /// <summary>
        /// Add a new GiveTagIdentifier to RXG
        /// </summary>
        public static EI AddGiveTagIdentifier(this RXG message)
        {
            return message.GetGiveTagIdentifier(message.GiveTagIdentifierRepetitionsUsed);
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
        /// Get PharmacyPhoneNumber Records from RXO
        /// </summary>
        public static IEnumerable GetPharmacyPhoneNumberRecords(this RXO message)
        {
            object[] result = message.GetRecords("PharmacyPhoneNumberRepetitionsUsed", "GetPharmacyPhoneNumber");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PharmacyPhoneNumber Records from RXO
        /// </summary>
        public static List<XTN> GetAllPharmacyPhoneNumberRecords(this RXO message)
        {
            return message.GetAllRecords<XTN>("PharmacyPhoneNumberRepetitionsUsed", "GetPharmacyPhoneNumber");
        }

        /// <summary>
        /// Add a new PharmacyPhoneNumber to RXO
        /// </summary>
        public static XTN AddPharmacyPhoneNumber(this RXO message)
        {
            return message.GetPharmacyPhoneNumber(message.PharmacyPhoneNumberRepetitionsUsed);
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
        /// Get InternalShipmentID Records from SHP
        /// </summary>
        public static IEnumerable GetInternalShipmentIDRecords(this SHP message)
        {
            object[] result = message.GetRecords("InternalShipmentIDRepetitionsUsed", "GetInternalShipmentID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all InternalShipmentID Records from SHP
        /// </summary>
        public static List<EI> GetAllInternalShipmentIDRecords(this SHP message)
        {
            return message.GetAllRecords<EI>("InternalShipmentIDRepetitionsUsed", "GetInternalShipmentID");
        }

        /// <summary>
        /// Add a new InternalShipmentID to SHP
        /// </summary>
        public static EI AddInternalShipmentID(this SHP message)
        {
            return message.GetInternalShipmentID(message.InternalShipmentIDRepetitionsUsed);
        }

        /// <summary>
        /// Get ShipmentConfidentiality Records from SHP
        /// </summary>
        public static IEnumerable GetShipmentConfidentialityRecords(this SHP message)
        {
            object[] result = message.GetRecords("ShipmentConfidentialityRepetitionsUsed", "GetShipmentConfidentiality");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ShipmentConfidentiality Records from SHP
        /// </summary>
        public static List<CWE> GetAllShipmentConfidentialityRecords(this SHP message)
        {
            return message.GetAllRecords<CWE>("ShipmentConfidentialityRepetitionsUsed", "GetShipmentConfidentiality");
        }

        /// <summary>
        /// Add a new ShipmentConfidentiality to SHP
        /// </summary>
        public static CWE AddShipmentConfidentiality(this SHP message)
        {
            return message.GetShipmentConfidentiality(message.ShipmentConfidentialityRepetitionsUsed);
        }

        /// <summary>
        /// Get ShipmentCondition Records from SHP
        /// </summary>
        public static IEnumerable GetShipmentConditionRecords(this SHP message)
        {
            object[] result = message.GetRecords("ShipmentConditionRepetitionsUsed", "GetShipmentCondition");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ShipmentCondition Records from SHP
        /// </summary>
        public static List<CWE> GetAllShipmentConditionRecords(this SHP message)
        {
            return message.GetAllRecords<CWE>("ShipmentConditionRepetitionsUsed", "GetShipmentCondition");
        }

        /// <summary>
        /// Add a new ShipmentCondition to SHP
        /// </summary>
        public static CWE AddShipmentCondition(this SHP message)
        {
            return message.GetShipmentCondition(message.ShipmentConditionRepetitionsUsed);
        }

        /// <summary>
        /// Get ShipmentHandlingCode Records from SHP
        /// </summary>
        public static IEnumerable GetShipmentHandlingCodeRecords(this SHP message)
        {
            object[] result = message.GetRecords("ShipmentHandlingCodeRepetitionsUsed", "GetShipmentHandlingCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ShipmentHandlingCode Records from SHP
        /// </summary>
        public static List<CWE> GetAllShipmentHandlingCodeRecords(this SHP message)
        {
            return message.GetAllRecords<CWE>("ShipmentHandlingCodeRepetitionsUsed", "GetShipmentHandlingCode");
        }

        /// <summary>
        /// Add a new ShipmentHandlingCode to SHP
        /// </summary>
        public static CWE AddShipmentHandlingCode(this SHP message)
        {
            return message.GetShipmentHandlingCode(message.ShipmentHandlingCodeRepetitionsUsed);
        }

        /// <summary>
        /// Get ShipmentRiskCode Records from SHP
        /// </summary>
        public static IEnumerable GetShipmentRiskCodeRecords(this SHP message)
        {
            object[] result = message.GetRecords("ShipmentRiskCodeRepetitionsUsed", "GetShipmentRiskCode");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ShipmentRiskCode Records from SHP
        /// </summary>
        public static List<CWE> GetAllShipmentRiskCodeRecords(this SHP message)
        {
            return message.GetAllRecords<CWE>("ShipmentRiskCodeRepetitionsUsed", "GetShipmentRiskCode");
        }

        /// <summary>
        /// Add a new ShipmentRiskCode to SHP
        /// </summary>
        public static CWE AddShipmentRiskCode(this SHP message)
        {
            return message.GetShipmentRiskCode(message.ShipmentRiskCodeRepetitionsUsed);
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
        /// Get AccessionID Records from SPM
        /// </summary>
        public static IEnumerable GetAccessionIDRecords(this SPM message)
        {
            object[] result = message.GetRecords("AccessionIDRepetitionsUsed", "GetAccessionID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AccessionID Records from SPM
        /// </summary>
        public static List<CX> GetAllAccessionIDRecords(this SPM message)
        {
            return message.GetAllRecords<CX>("AccessionIDRepetitionsUsed", "GetAccessionID");
        }

        /// <summary>
        /// Add a new AccessionID to SPM
        /// </summary>
        public static CX AddAccessionID(this SPM message)
        {
            return message.GetAccessionID(message.AccessionIDRepetitionsUsed);
        }

        /// <summary>
        /// Get OtherSpecimenID Records from SPM
        /// </summary>
        public static IEnumerable GetOtherSpecimenIDRecords(this SPM message)
        {
            object[] result = message.GetRecords("OtherSpecimenIDRepetitionsUsed", "GetOtherSpecimenID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OtherSpecimenID Records from SPM
        /// </summary>
        public static List<CX> GetAllOtherSpecimenIDRecords(this SPM message)
        {
            return message.GetAllRecords<CX>("OtherSpecimenIDRepetitionsUsed", "GetOtherSpecimenID");
        }

        /// <summary>
        /// Add a new OtherSpecimenID to SPM
        /// </summary>
        public static CX AddOtherSpecimenID(this SPM message)
        {
            return message.GetOtherSpecimenID(message.OtherSpecimenIDRepetitionsUsed);
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
        public static List<CWE> GetAllStaffTypeRecords(this STF message)
        {
            return message.GetAllRecords<CWE>("StaffTypeRepetitionsUsed", "GetStaffType");
        }

        /// <summary>
        /// Add a new StaffType to STF
        /// </summary>
        public static CWE AddStaffType(this STF message)
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
        /// Get FolderAssignment Records from TXA
        /// </summary>
        public static IEnumerable GetFolderAssignmentRecords(this TXA message)
        {
            object[] result = message.GetRecords("FolderAssignmentRepetitionsUsed", "GetFolderAssignment");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FolderAssignment Records from TXA
        /// </summary>
        public static List<CWE> GetAllFolderAssignmentRecords(this TXA message)
        {
            return message.GetAllRecords<CWE>("FolderAssignmentRepetitionsUsed", "GetFolderAssignment");
        }

        /// <summary>
        /// Add a new FolderAssignment to TXA
        /// </summary>
        public static CWE AddFolderAssignment(this TXA message)
        {
            return message.GetFolderAssignment(message.FolderAssignmentRepetitionsUsed);
        }

        /// <summary>
        /// Get DocumentTitle Records from TXA
        /// </summary>
        public static IEnumerable GetDocumentTitleRecords(this TXA message)
        {
            object[] result = message.GetRecords("DocumentTitleRepetitionsUsed", "GetDocumentTitle");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DocumentTitle Records from TXA
        /// </summary>
        public static List<ST> GetAllDocumentTitleRecords(this TXA message)
        {
            return message.GetAllRecords<ST>("DocumentTitleRepetitionsUsed", "GetDocumentTitle");
        }

        /// <summary>
        /// Add a new DocumentTitle to TXA
        /// </summary>
        public static ST AddDocumentTitle(this TXA message)
        {
            return message.GetDocumentTitle(message.DocumentTitleRepetitionsUsed);
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
        public static List<CWE> GetAllConditionCode2430Records(this UB2 message)
        {
            return message.GetAllRecords<CWE>("ConditionCode2430RepetitionsUsed", "GetConditionCode2430");
        }

        /// <summary>
        /// Add a new ConditionCode2430 to UB2
        /// </summary>
        public static CWE AddConditionCode2430(this UB2 message)
        {
            return message.GetConditionCode2430(message.ConditionCode2430RepetitionsUsed);
        }

        /// <summary>
        /// Get ValueAmountCode3941 Records from UB2
        /// </summary>
        public static IEnumerable GetValueAmountCode3941Records(this UB2 message)
        {
            object[] result = message.GetRecords("ValueAmountCode3941RepetitionsUsed", "GetValueAmountCode3941");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ValueAmountCode3941 Records from UB2
        /// </summary>
        public static List<UVC> GetAllValueAmountCode3941Records(this UB2 message)
        {
            return message.GetAllRecords<UVC>("ValueAmountCode3941RepetitionsUsed", "GetValueAmountCode3941");
        }

        /// <summary>
        /// Add a new ValueAmountCode3941 to UB2
        /// </summary>
        public static UVC AddValueAmountCode3941(this UB2 message)
        {
            return message.GetValueAmountCode3941(message.ValueAmountCode3941RepetitionsUsed);
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
        /// Get UniformBillingLocator2State Records from UB2
        /// </summary>
        public static IEnumerable GetUniformBillingLocator2StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UniformBillingLocator2StateRepetitionsUsed", "GetUniformBillingLocator2State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UniformBillingLocator2State Records from UB2
        /// </summary>
        public static List<ST> GetAllUniformBillingLocator2StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UniformBillingLocator2StateRepetitionsUsed", "GetUniformBillingLocator2State");
        }

        /// <summary>
        /// Add a new UniformBillingLocator2State to UB2
        /// </summary>
        public static ST AddUniformBillingLocator2State(this UB2 message)
        {
            return message.GetUniformBillingLocator2State(message.UniformBillingLocator2StateRepetitionsUsed);
        }

        /// <summary>
        /// Get UniformBillingLocator11State Records from UB2
        /// </summary>
        public static IEnumerable GetUniformBillingLocator11StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UniformBillingLocator11StateRepetitionsUsed", "GetUniformBillingLocator11State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UniformBillingLocator11State Records from UB2
        /// </summary>
        public static List<ST> GetAllUniformBillingLocator11StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UniformBillingLocator11StateRepetitionsUsed", "GetUniformBillingLocator11State");
        }

        /// <summary>
        /// Add a new UniformBillingLocator11State to UB2
        /// </summary>
        public static ST AddUniformBillingLocator11State(this UB2 message)
        {
            return message.GetUniformBillingLocator11State(message.UniformBillingLocator11StateRepetitionsUsed);
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
        /// Get UniformBillingLocator49National Records from UB2
        /// </summary>
        public static IEnumerable GetUniformBillingLocator49NationalRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UniformBillingLocator49NationalRepetitionsUsed", "GetUniformBillingLocator49National");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UniformBillingLocator49National Records from UB2
        /// </summary>
        public static List<ST> GetAllUniformBillingLocator49NationalRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UniformBillingLocator49NationalRepetitionsUsed", "GetUniformBillingLocator49National");
        }

        /// <summary>
        /// Add a new UniformBillingLocator49National to UB2
        /// </summary>
        public static ST AddUniformBillingLocator49National(this UB2 message)
        {
            return message.GetUniformBillingLocator49National(message.UniformBillingLocator49NationalRepetitionsUsed);
        }

        /// <summary>
        /// Get UniformBillingLocator56State Records from UB2
        /// </summary>
        public static IEnumerable GetUniformBillingLocator56StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UniformBillingLocator56StateRepetitionsUsed", "GetUniformBillingLocator56State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UniformBillingLocator56State Records from UB2
        /// </summary>
        public static List<ST> GetAllUniformBillingLocator56StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UniformBillingLocator56StateRepetitionsUsed", "GetUniformBillingLocator56State");
        }

        /// <summary>
        /// Add a new UniformBillingLocator56State to UB2
        /// </summary>
        public static ST AddUniformBillingLocator56State(this UB2 message)
        {
            return message.GetUniformBillingLocator56State(message.UniformBillingLocator56StateRepetitionsUsed);
        }

        /// <summary>
        /// Get UniformBillingLocator78State Records from UB2
        /// </summary>
        public static IEnumerable GetUniformBillingLocator78StateRecords(this UB2 message)
        {
            object[] result = message.GetRecords("UniformBillingLocator78StateRepetitionsUsed", "GetUniformBillingLocator78State");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all UniformBillingLocator78State Records from UB2
        /// </summary>
        public static List<ST> GetAllUniformBillingLocator78StateRecords(this UB2 message)
        {
            return message.GetAllRecords<ST>("UniformBillingLocator78StateRepetitionsUsed", "GetUniformBillingLocator78State");
        }

        /// <summary>
        /// Add a new UniformBillingLocator78State to UB2
        /// </summary>
        public static ST AddUniformBillingLocator78State(this UB2 message)
        {
            return message.GetUniformBillingLocator78State(message.UniformBillingLocator78StateRepetitionsUsed);
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
        #endregion
    }
}
