
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IPartnerService
    {
        int AddPartner(PartnerDTO dto);

        void DeletePartner(int partnerId);

        void DeletePartner(PartnerDTO dto);

        PartnerDTO GetPartner(int partnerId);

        IEnumerable<PartnerDTO> GetPartners();

        IList<PartnerDTO> GetPartners(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<PartnerDTO> GetPartnerListAdvancedSearch(
            int? nucleoId 
            ,string name 
            ,bool? enterpriseContributor 
            ,bool? privateContributor 
            ,int? contributionTypeId 
            ,int? partnershipTypeId 
            ,string contactPerson 
            ,string department 
            ,string phone 
            ,string email 
            ,string iban 
            ,string bicSwift 
            ,string fiscalNumber 
            ,double? latitude 
            ,double? longitude 
            ,string photoUrl 
            ,int? addressId 
            ,System.DateTime? partnershipStartDateFrom 
            ,System.DateTime? partnershipStartDateTo 
            ,System.DateTime? durationCommitmentFrom 
            ,System.DateTime? durationCommitmentTo 
            ,string refoodAreaInteraction 
            ,string reliability 
            ,string interactionFrequency 
            ,bool? active 
        );

        void UpdatePartner(PartnerDTO dto);

    }
}
    