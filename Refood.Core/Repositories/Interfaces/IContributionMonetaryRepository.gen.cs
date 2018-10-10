
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IContributionMonetaryRepository
    {
        int AddContributionMonetary(R_ContributionMonetary t);

        void DeleteContributionMonetary(R_ContributionMonetary t);

        void DeleteContributionMonetary(int contributionMonetaryId);

        R_ContributionMonetary GetContributionMonetary(int contributionMonetaryId);

        IEnumerable<R_ContributionMonetary> GetContributionMonetarys();

        IList<R_ContributionMonetary> GetContributionMonetarys(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_ContributionMonetary> GetContributionMonetaryListAdvancedSearch(
            int? nucleoId 
            , int? responsiblePersonId 
            , int? documentId 
            , int? partnerId 
            , System.DateTime? contributionDateFrom 
            , System.DateTime? contributionDateTo 
            , double? amount 
            , string contactPerson 
            , string ibanOrigin 
            , string bicSwiftOrigin 
            , string ibanDestination 
            , string bicSwiftDestination 
            , string fiscalNumber 
            , int? contributionChannelId 
        );

        void UpdateContributionMonetary(R_ContributionMonetary t);

    }
}

    