
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
    [RoutePrefix("api/ProjectApi")]
    public partial class ProjectApiController : ApiController
    {
        private readonly IProjectService _projectService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProjectApiController(IProjectService projectService)
        {
            this._projectService = projectService;
        }

        public ProjectApiController() : this(new ProjectService()) { }

        /// <summary>
        /// Delete Project by id
        /// </summary>
        /// <param name="id">Project id</param>
        /// <returns>true if the Project is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_projectService.DeleteProject - projectId: " + id + " "); 

                _projectService.DeleteProject(id);

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
        /// Get Project by id
        /// </summary>
        /// <param name="id">Project id</param>
        /// <returns>Project json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_projectService.GetProject - projectId: " + id + " "); 

                var project = new ProjectViewModel(_projectService.GetProject(id));

                log.Debug("_projectService.GetProject - " + ProjectViewModel.FormatProjectViewModel(project)); 

                log.Debug("result: 'success'"); 

                //return Json(project, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(project), "application/json");
                //return project;
                //return JsonConvert.SerializeObject(project);
                return Ok(project);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Projects
        /// </summary>
        /// <returns>json list of Project view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ProjectViewModel> projects;

                log.Debug("_projectService.GetProjects"); 

                // add edit url
                projects = _projectService.GetProjects()
                        .Select(project => new ProjectViewModel(project, GetEditUrl(project.ProjectId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (projects != null ? projects.Count().ToString() : "null")); 

                //return Json(projects, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(projects), "application/json");
                //return JsonConvert.SerializeObject(projects);
                return Ok(projects);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Projects
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Projects</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ProjectViewModel> projects;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_projectService.GetProjects - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                projects = _projectService.GetProjects(searchTerm, pageIndex, pageSize)
                        .Select(project => new ProjectViewModel(project, GetEditUrl(project.ProjectId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (projects != null ? projects.Count().ToString() : "null")); 

                //return Json(projects, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(projects);
                return Ok(projects);
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
            , string deadlineCall = null 
            , double? budget = null 
            , string funding = null 
            , System.DateTime? startDateFrom = null 
            , System.DateTime? startDateTo = null 
            , System.DateTime? endDateFrom = null 
            , System.DateTime? endDateTo = null 
            , string areaOfInterest = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetProjectListAdvancedSearch"); 

                IEnumerable<ProjectDTO> resultsDTO = _projectService.GetProjectListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , deadlineCall 
                    , budget 
                    , funding 
                    , startDateFrom 
                    , startDateTo 
                    , endDateFrom 
                    , endDateTo 
                    , areaOfInterest 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<ProjectViewModel> projectList = resultsDTO.Select(project => new ProjectViewModel(project, GetEditUrl(project.ProjectId))).ToList();

                log.Debug("result: 'success', count: " + (projectList != null ? projectList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(projectList), "application/json");
                //return JsonConvert.SerializeObject(projectList);
                return Ok(projectList);
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
            string editUrl = Url.Content("~/Project/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Project, or creates a new Project if the Id is 0
        /// </summary>
        /// <param name="viewModel">Project data</param>
        /// <returns>Project id</returns>
        public IHttpActionResult Upsert(ProjectViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ProjectId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ProjectId);
                return Ok(t.ProjectId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ProjectId);
                //return JsonConvert.SerializeObject(t.ProjectId);
                return Ok(t.ProjectId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Project
        /// </summary>
        /// <param name="viewModels">Project view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ProjectViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ProjectViewModel viewModel in viewModels)
                    {
                        log.Debug(ProjectViewModel.FormatProjectViewModel(viewModel)); 

                        if (viewModel.ProjectId > 0)
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

        private ProjectDTO Create(ProjectViewModel viewModel)
        {
            try
            {
                log.Debug(ProjectViewModel.FormatProjectViewModel(viewModel)); 

                ProjectDTO project = new ProjectDTO();

                // copy values
                viewModel.UpdateDTO(project, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                project.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                project.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_projectService.AddProject - " + ProjectDTO.FormatProjectDTO(project)); 

                int id = _projectService.AddProject(project);

                project.ProjectId = id;

                log.Debug("result: 'success', id: " + id); 

                return project;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ProjectDTO Update(ProjectViewModel viewModel)
        {
            try
            {
                log.Debug(ProjectViewModel.FormatProjectViewModel(viewModel)); 

                // get
                log.Debug("_projectService.GetProject - projectId: " + viewModel.ProjectId + " "); 

                var existingProject = _projectService.GetProject(viewModel.ProjectId);

                log.Debug("_projectService.GetProject - " + ProjectDTO.FormatProjectDTO(existingProject)); 

                if (existingProject != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingProject, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_projectService.UpdateProject - " + ProjectDTO.FormatProjectDTO(existingProject)); 

                    _projectService.UpdateProject(existingProject);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingProject: null, ProjectId: " + viewModel.ProjectId); 
                }

                return existingProject;
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

    