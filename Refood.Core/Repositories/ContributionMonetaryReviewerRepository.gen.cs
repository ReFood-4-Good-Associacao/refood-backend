
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class ContributionMonetaryReviewerRepository : IContributionMonetaryReviewerRepository
    {
        public int AddContributionMonetaryReviewer(R_ContributionMonetaryReviewer t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteContributionMonetaryReviewer(R_ContributionMonetaryReviewer t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteContributionMonetaryReviewer(int contributionMonetaryReviewerId)
        {
            var t = GetContributionMonetaryReviewer(contributionMonetaryReviewerId);
            DeleteContributionMonetaryReviewer(t);
        }

        public R_ContributionMonetaryReviewer GetContributionMonetaryReviewer(int contributionMonetaryReviewerId)
        {
            //Requires.NotNegative("contributionMonetaryReviewerId", contributionMonetaryReviewerId);
            
            R_ContributionMonetaryReviewer t = R_ContributionMonetaryReviewer.SingleOrDefault(contributionMonetaryReviewerId);

            return t;
        }

        public IEnumerable<R_ContributionMonetaryReviewer> GetContributionMonetaryReviewers()
        {
             
            IEnumerable<R_ContributionMonetaryReviewer> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionMonetaryReviewer")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_ContributionMonetaryReviewer.Query(sql);

            return results;
        }

        public IList<R_ContributionMonetaryReviewer> GetContributionMonetaryReviewers(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_ContributionMonetaryReviewer> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionMonetaryReviewer")
                .Where("IsDeleted = 0")
            ;

            results = R_ContributionMonetaryReviewer.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_ContributionMonetaryReviewer> GetContributionMonetaryReviewerListAdvancedSearch(
            int? volunteerId 
        )
        {
            IEnumerable<R_ContributionMonetaryReviewer> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionMonetaryReviewer")
                .Where("IsDeleted = 0" 
                    + (volunteerId != null ? " and VolunteerId like '%" + volunteerId + "%'" : "")
                 )
            ;

            results = R_ContributionMonetaryReviewer.Query(sql);

            return results;
        }

        public void UpdateContributionMonetaryReviewer(R_ContributionMonetaryReviewer t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ContributionMonetaryReviewerId");

            t.Update();
        }

    }
}

        