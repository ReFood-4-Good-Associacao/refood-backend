
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IContributionMonetaryReviewerRepository
    {
        int AddContributionMonetaryReviewer(R_ContributionMonetaryReviewer t);

        void DeleteContributionMonetaryReviewer(R_ContributionMonetaryReviewer t);

        void DeleteContributionMonetaryReviewer(int contributionMonetaryReviewerId);

        R_ContributionMonetaryReviewer GetContributionMonetaryReviewer(int contributionMonetaryReviewerId);

        IEnumerable<R_ContributionMonetaryReviewer> GetContributionMonetaryReviewers();

        IList<R_ContributionMonetaryReviewer> GetContributionMonetaryReviewers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_ContributionMonetaryReviewer> GetContributionMonetaryReviewerListAdvancedSearch(
            int? volunteerId 
        );

        void UpdateContributionMonetaryReviewer(R_ContributionMonetaryReviewer t);

    }
}

    