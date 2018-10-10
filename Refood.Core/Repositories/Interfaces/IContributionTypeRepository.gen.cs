
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IContributionTypeRepository
    {
        int AddContributionType(R_ContributionType t);

        void DeleteContributionType(R_ContributionType t);

        void DeleteContributionType(int contributionTypeId);

        R_ContributionType GetContributionType(int contributionTypeId);

        IEnumerable<R_ContributionType> GetContributionTypes();

        IList<R_ContributionType> GetContributionTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_ContributionType> GetContributionTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateContributionType(R_ContributionType t);

    }
}

    