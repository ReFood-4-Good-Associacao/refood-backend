
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IContributionTypeService
    {
        int AddContributionType(ContributionTypeDTO dto);

        void DeleteContributionType(int contributionTypeId);

        void DeleteContributionType(ContributionTypeDTO dto);

        ContributionTypeDTO GetContributionType(int contributionTypeId);

        IEnumerable<ContributionTypeDTO> GetContributionTypes();

        IList<ContributionTypeDTO> GetContributionTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ContributionTypeDTO> GetContributionTypeListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateContributionType(ContributionTypeDTO dto);

    }
}
    