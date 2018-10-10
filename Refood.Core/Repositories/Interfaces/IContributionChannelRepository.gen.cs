
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IContributionChannelRepository
    {
        int AddContributionChannel(R_ContributionChannel t);

        void DeleteContributionChannel(R_ContributionChannel t);

        void DeleteContributionChannel(int contributionChannelId);

        R_ContributionChannel GetContributionChannel(int contributionChannelId);

        IEnumerable<R_ContributionChannel> GetContributionChannels();

        IList<R_ContributionChannel> GetContributionChannels(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_ContributionChannel> GetContributionChannelListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateContributionChannel(R_ContributionChannel t);

    }
}

    