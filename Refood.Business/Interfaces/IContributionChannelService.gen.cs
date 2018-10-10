
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IContributionChannelService
    {
        int AddContributionChannel(ContributionChannelDTO dto);

        void DeleteContributionChannel(int contributionChannelId);

        void DeleteContributionChannel(ContributionChannelDTO dto);

        ContributionChannelDTO GetContributionChannel(int contributionChannelId);

        IEnumerable<ContributionChannelDTO> GetContributionChannels();

        IList<ContributionChannelDTO> GetContributionChannels(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ContributionChannelDTO> GetContributionChannelListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateContributionChannel(ContributionChannelDTO dto);

    }
}
    