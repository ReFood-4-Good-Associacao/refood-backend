
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IContributionMonetaryReviewerService
    {
        int AddContributionMonetaryReviewer(ContributionMonetaryReviewerDTO dto);

        void DeleteContributionMonetaryReviewer(int contributionMonetaryReviewerId);

        void DeleteContributionMonetaryReviewer(ContributionMonetaryReviewerDTO dto);

        ContributionMonetaryReviewerDTO GetContributionMonetaryReviewer(int contributionMonetaryReviewerId);

        IEnumerable<ContributionMonetaryReviewerDTO> GetContributionMonetaryReviewers();

        IList<ContributionMonetaryReviewerDTO> GetContributionMonetaryReviewers(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ContributionMonetaryReviewerDTO> GetContributionMonetaryReviewerListAdvancedSearch(
            int? volunteerId 
        );

        void UpdateContributionMonetaryReviewer(ContributionMonetaryReviewerDTO dto);

    }
}
    