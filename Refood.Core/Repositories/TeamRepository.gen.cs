
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
    public partial class TeamRepository : ITeamRepository
    {
        public int AddTeam(R_Team t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteTeam(R_Team t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteTeam(int teamId)
        {
            var t = GetTeam(teamId);
            DeleteTeam(t);
        }

        public R_Team GetTeam(int teamId)
        {
            //Requires.NotNegative("teamId", teamId);
            
            R_Team t = R_Team.SingleOrDefault(teamId);

            return t;
        }

        public IEnumerable<R_Team> GetTeams()
        {
             
            IEnumerable<R_Team> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Team")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Team.Query(sql);

            return results;
        }

        public IList<R_Team> GetTeams(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Team> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Team")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_Team.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Team> GetTeamListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_Team> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Team")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Team.Query(sql);

            return results;
        }

        public void UpdateTeam(R_Team t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "TeamId");

            t.Update();
        }

    }
}

        