
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
    public partial class ContributionChannelRepository : IContributionChannelRepository
    {
        public int AddContributionChannel(R_ContributionChannel t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteContributionChannel(R_ContributionChannel t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteContributionChannel(int contributionChannelId)
        {
            var t = GetContributionChannel(contributionChannelId);
            DeleteContributionChannel(t);
        }

        public R_ContributionChannel GetContributionChannel(int contributionChannelId)
        {
            //Requires.NotNegative("contributionChannelId", contributionChannelId);
            
            R_ContributionChannel t = R_ContributionChannel.SingleOrDefault(contributionChannelId);

            return t;
        }

        public IEnumerable<R_ContributionChannel> GetContributionChannels()
        {
             
            IEnumerable<R_ContributionChannel> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionChannel")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_ContributionChannel.Query(sql);

            return results;
        }

        public IList<R_ContributionChannel> GetContributionChannels(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_ContributionChannel> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionChannel")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_ContributionChannel.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_ContributionChannel> GetContributionChannelListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_ContributionChannel> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ContributionChannel")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_ContributionChannel.Query(sql);

            return results;
        }

        public void UpdateContributionChannel(R_ContributionChannel t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ContributionChannelId");

            t.Update();
        }

    }
}

        