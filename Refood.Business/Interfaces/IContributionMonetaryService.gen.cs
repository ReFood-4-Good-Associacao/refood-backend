
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IContributionMonetaryService
    {
        int AddContributionMonetary(ContributionMonetaryDTO dto);

        void DeleteContributionMonetary(int contributionMonetaryId);

        void DeleteContributionMonetary(ContributionMonetaryDTO dto);

        ContributionMonetaryDTO GetContributionMonetary(int contributionMonetaryId);

        IEnumerable<ContributionMonetaryDTO> GetContributionMonetarys();

        IList<ContributionMonetaryDTO> GetContributionMonetarys(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ContributionMonetaryDTO> GetContributionMonetaryListAdvancedSearch(
            int? nucleoId 
            ,int? responsiblePersonId 
            ,int? documentId 
            ,int? partnerId 
            ,System.DateTime? contributionDateFrom 
            ,System.DateTime? contributionDateTo 
            ,double? amount 
            ,string contactPerson 
            ,string ibanOrigin 
            ,string bicSwiftOrigin 
            ,string ibanDestination 
            ,string bicSwiftDestination 
            ,string fiscalNumber 
            ,int? contributionChannelId 
        );

        void UpdateContributionMonetary(ContributionMonetaryDTO dto);

    }
}
    