
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class TeamService :  ITeamService
    {
        public static ITeamRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TeamService()
        {
            if (Repository == null)
            {
                Repository = new TeamRepository();
            }
        }

        public int AddTeam(TeamDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(TeamDTO.FormatTeamDTO(dto)); 

                R_Team t = TeamDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddTeam(t);
                dto.TeamId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteTeam(TeamDTO dto)
        {
            try
            {
                log.Debug(TeamDTO.FormatTeamDTO(dto)); 
            
                R_Team t = TeamDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteTeam(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteTeam(int teamId)
        {
            try
            {
                log.Debug("teamId: " + teamId + " "); 

                // delete
                Repository.DeleteTeam(teamId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public TeamDTO GetTeam(int teamId)
        {
            try
            {
                //Requires.NotNegative("teamId", teamId);
                
                log.Debug("teamId: " + teamId + " "); 

                // get
                R_Team t = Repository.GetTeam(teamId);

                TeamDTO dto = new TeamDTO(t);

                log.Debug(TeamDTO.FormatTeamDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<TeamDTO> GetTeams()
        {
            try
            {
                
                log.Debug("GetTeams"); 

                // get
                IEnumerable<R_Team> results = Repository.GetTeams();

                IEnumerable<TeamDTO> resultsDTO = results.Select(e => new TeamDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<TeamDTO> GetTeams(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Team> results = Repository.GetTeams(searchTerm, pageIndex, pageSize);
            
                IList<TeamDTO> resultsDTO = results.Select(e => new TeamDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<TeamDTO> GetTeamListAdvancedSearch(
             int? nucleoId 
            , string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetTeamListAdvancedSearch"); 

                IEnumerable<R_Team> results = Repository.GetTeamListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , active 
                );
            
                IEnumerable<TeamDTO> resultsDTO = results.Select(e => new TeamDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateTeam(TeamDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "TeamId");

                log.Debug(TeamDTO.FormatTeamDTO(dto)); 

                R_Team t = TeamDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateTeam(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    