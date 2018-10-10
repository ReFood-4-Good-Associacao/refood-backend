
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
    public partial class ContributionTypeRepository : IContributionTypeRepository
    {
        public int AddContributionType(R_ContributionType t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteContributionType(R_ContributionType t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteContributionType(int contributionTypeId)
        {
            var t = GetContributionType(contributionTypeId);
            DeleteContributionType(t);
        }

        public R_ContributionType GetContributionType(int contributionTypeId)
        {
            //Requires.NotNegative("contributionTypeId", contributionTypeId);
            
            R_ContributionType t = R_ContributionType.SingleOrDefault(contributionTypeId);

            return t;
        }

        public IEnumerable<R_ContributionType> GetContributionTypes()
        {
             
            IEnumerable<R_ContributionType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionType")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_ContributionType.Query(sql);

            return results;
        }

        public IList<R_ContributionType> GetContributionTypes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_ContributionType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionType")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_ContributionType.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_ContributionType> GetContributionTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_ContributionType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionType")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_ContributionType.Query(sql);

            return results;
        }

        public void UpdateContributionType(R_ContributionType t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ContributionTypeId");

            t.Update();
        }

    }
}

        