
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ITeamService
    {
        int AddTeam(TeamDTO dto);

        void DeleteTeam(int teamId);

        void DeleteTeam(TeamDTO dto);

        TeamDTO GetTeam(int teamId);

        IEnumerable<TeamDTO> GetTeams();

        IList<TeamDTO> GetTeams(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<TeamDTO> GetTeamListAdvancedSearch(
            int? nucleoId 
            ,string name 
            ,string description 
            ,bool? active 
        );

        void UpdateTeam(TeamDTO dto);

    }
}
    