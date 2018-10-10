
// ################################################################
//                      Code generated with T4
// ################################################################

using Refood.Web.Services.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    //[Authorize]
    [RoutePrefix("api/TeamApi")]
    public partial class TeamApiController : ApiController
    {
        private readonly ITeamService _teamService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TeamApiController(ITeamService teamService)
        {
            this._teamService = teamService;
        }

        public TeamApiController() : this(new TeamService()) { }

        /// <summary>
        /// Delete Team by id
        /// </summary>
        /// <param name="id">Team id</param>
        /// <returns>true if the Team is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_teamService.DeleteTeam - teamId: " + id + " "); 

                _teamService.DeleteTeam(id);

                log.Debug("result: 'success'"); 

                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get Team by id
        /// </summary>
        /// <param name="id">Team id</param>
        /// <returns>Team json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_teamService.GetTeam - teamId: " + id + " "); 

                var team = new TeamViewModel(_teamService.GetTeam(id));

                log.Debug("_teamService.GetTeam - " + TeamViewModel.FormatTeamViewModel(team)); 

                log.Debug("result: 'success'"); 

                //return Json(team, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(team), "application/json");
                //return team;
                //return JsonConvert.SerializeObject(team);
                return Ok(team);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Teams
        /// </summary>
        /// <returns>json list of Team view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<TeamViewModel> teams;

                log.Debug("_teamService.GetTeams"); 

                // add edit url
                teams = _teamService.GetTeams()
                        .Select(team => new TeamViewModel(team, GetEditUrl(team.TeamId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (teams != null ? teams.Count().ToString() : "null")); 

                //return Json(teams, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(teams), "application/json");
                //return JsonConvert.SerializeObject(teams);
                return Ok(teams);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Teams
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Teams</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<TeamViewModel> teams;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_teamService.GetTeams - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                teams = _teamService.GetTeams(searchTerm, pageIndex, pageSize)
                        .Select(team => new TeamViewModel(team, GetEditUrl(team.TeamId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (teams != null ? teams.Count().ToString() : "null")); 

                //return Json(teams, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(teams);
                return Ok(teams);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetListAdvancedSearch(
            int id = 0 
            , int? nucleoId = null 
            , string name = null 
            , string description = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetTeamListAdvancedSearch"); 

                IEnumerable<TeamDTO> resultsDTO = _teamService.GetTeamListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<TeamViewModel> teamList = resultsDTO.Select(team => new TeamViewModel(team, GetEditUrl(team.TeamId))).ToList();

                log.Debug("result: 'success', count: " + (teamList != null ? teamList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(teamList), "application/json");
                //return JsonConvert.SerializeObject(teamList);
                return Ok(teamList);
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/Team/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Team, or creates a new Team if the Id is 0
        /// </summary>
        /// <param name="viewModel">Team data</param>
        /// <returns>Team id</returns>
        public IHttpActionResult Upsert(TeamViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.TeamId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.TeamId);
                return Ok(t.TeamId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.TeamId);
                //return JsonConvert.SerializeObject(t.TeamId);
                return Ok(t.TeamId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Team
        /// </summary>
        /// <param name="viewModels">Team view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(TeamViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(TeamViewModel viewModel in viewModels)
                    {
                        log.Debug(TeamViewModel.FormatTeamViewModel(viewModel)); 

                        if (viewModel.TeamId > 0)
                        {
                            var t = Update(viewModel);
                        }
                        else
                        {
                            var t = Create(viewModel);
                        }

                    }
                }
                else
                {
                    log.Error("viewModels: null"); 
                }

                //return Json(true);
                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private TeamDTO Create(TeamViewModel viewModel)
        {
            try
            {
                log.Debug(TeamViewModel.FormatTeamViewModel(viewModel)); 

                TeamDTO team = new TeamDTO();

                // copy values
                viewModel.UpdateDTO(team, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                team.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                team.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_teamService.AddTeam - " + TeamDTO.FormatTeamDTO(team)); 

                int id = _teamService.AddTeam(team);

                team.TeamId = id;

                log.Debug("result: 'success', id: " + id); 

                return team;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private TeamDTO Update(TeamViewModel viewModel)
        {
            try
            {
                log.Debug(TeamViewModel.FormatTeamViewModel(viewModel)); 

                // get
                log.Debug("_teamService.GetTeam - teamId: " + viewModel.TeamId + " "); 

                var existingTeam = _teamService.GetTeam(viewModel.TeamId);

                log.Debug("_teamService.GetTeam - " + TeamDTO.FormatTeamDTO(existingTeam)); 

                if (existingTeam != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingTeam, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_teamService.UpdateTeam - " + TeamDTO.FormatTeamDTO(existingTeam)); 

                    _teamService.UpdateTeam(existingTeam);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingTeam: null, TeamId: " + viewModel.TeamId); 
                }

                return existingTeam;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    