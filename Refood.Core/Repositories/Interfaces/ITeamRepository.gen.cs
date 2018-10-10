
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ITeamRepository
    {
        int AddTeam(R_Team t);

        void DeleteTeam(R_Team t);

        void DeleteTeam(int teamId);

        R_Team GetTeam(int teamId);

        IEnumerable<R_Team> GetTeams();

        IList<R_Team> GetTeams(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Team> GetTeamListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , bool? active 
        );

        void UpdateTeam(R_Team t);

    }
}

    