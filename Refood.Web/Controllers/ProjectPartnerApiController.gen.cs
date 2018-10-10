
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
    [RoutePrefix("api/ProjectPartnerApi")]
    public partial class ProjectPartnerApiController : ApiController
    {
        private readonly IProjectPartnerService _projectPartnerService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProjectPartnerApiController(IProjectPartnerService projectPartnerService)
        {
            this._projectPartnerService = projectPartnerService;
        }

        public ProjectPartnerApiController() : this(new ProjectPartnerService()) { }

        /// <summary>
        /// Delete ProjectPartner by id
        /// </summary>
        /// <param name="id">ProjectPartner id</param>
        /// <returns>true if the ProjectPartner is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_projectPartnerService.DeleteProjectPartner - projectPartnerId: " + id + " "); 

                _projectPartnerService.DeleteProjectPartner(id);

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
        /// Get ProjectPartner by id
        /// </summary>
        /// <param name="id">ProjectPartner id</param>
        /// <returns>ProjectPartner json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_projectPartnerService.GetProjectPartner - projectPartnerId: " + id + " "); 

                var projectPartner = new ProjectPartnerViewModel(_projectPartnerService.GetProjectPartner(id));

                log.Debug("_projectPartnerService.GetProjectPartner - " + ProjectPartnerViewModel.FormatProjectPartnerViewModel(projectPartner)); 

                log.Debug("result: 'success'"); 

                //return Json(projectPartner, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(projectPartner), "application/json");
                //return projectPartner;
                //return JsonConvert.SerializeObject(projectPartner);
                return Ok(projectPartner);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of ProjectPartners
        /// </summary>
        /// <returns>json list of ProjectPartner view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ProjectPartnerViewModel> projectPartners;

                log.Debug("_projectPartnerService.GetProjectPartners"); 

                // add edit url
                projectPartners = _projectPartnerService.GetProjectPartners()
                        .Select(projectPartner => new ProjectPartnerViewModel(projectPartner, GetEditUrl(projectPartner.ProjectPartnerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (projectPartners != null ? projectPartners.Count().ToString() : "null")); 

                //return Json(projectPartners, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(projectPartners), "application/json");
                //return JsonConvert.SerializeObject(projectPartners);
                return Ok(projectPartners);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of ProjectPartners
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of ProjectPartners</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ProjectPartnerViewModel> projectPartners;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_projectPartnerService.GetProjectPartners - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                projectPartners = _projectPartnerService.GetProjectPartners(searchTerm, pageIndex, pageSize)
                        .Select(projectPartner => new ProjectPartnerViewModel(projectPartner, GetEditUrl(projectPartner.ProjectPartnerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (projectPartners != null ? projectPartners.Count().ToString() : "null")); 

                //return Json(projectPartners, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(projectPartners);
                return Ok(projectPartners);
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
            , int? projectId = null 
            , int? partnerId = null 
            , double? grantValue = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetProjectPartnerListAdvancedSearch"); 

                IEnumerable<ProjectPartnerDTO> resultsDTO = _projectPartnerService.GetProjectPartnerListAdvancedSearch(
                     projectId 
                    , partnerId 
                    , grantValue 
                );
            
                // convert to view model list, and add edit url
                List<ProjectPartnerViewModel> projectPartnerList = resultsDTO.Select(projectPartner => new ProjectPartnerViewModel(projectPartner, GetEditUrl(projectPartner.ProjectPartnerId))).ToList();

                log.Debug("result: 'success', count: " + (projectPartnerList != null ? projectPartnerList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(projectPartnerList), "application/json");
                //return JsonConvert.SerializeObject(projectPartnerList);
                return Ok(projectPartnerList);
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
            string editUrl = Url.Content("~/ProjectPartner/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing ProjectPartner, or creates a new ProjectPartner if the Id is 0
        /// </summary>
        /// <param name="viewModel">ProjectPartner data</param>
        /// <returns>ProjectPartner id</returns>
        public IHttpActionResult Upsert(ProjectPartnerViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ProjectPartnerId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ProjectPartnerId);
                return Ok(t.ProjectPartnerId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ProjectPartnerId);
                //return JsonConvert.SerializeObject(t.ProjectPartnerId);
                return Ok(t.ProjectPartnerId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of ProjectPartner
        /// </summary>
        /// <param name="viewModels">ProjectPartner view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ProjectPartnerViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ProjectPartnerViewModel viewModel in viewModels)
                    {
                        log.Debug(ProjectPartnerViewModel.FormatProjectPartnerViewModel(viewModel)); 

                        if (viewModel.ProjectPartnerId > 0)
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

        private ProjectPartnerDTO Create(ProjectPartnerViewModel viewModel)
        {
            try
            {
                log.Debug(ProjectPartnerViewModel.FormatProjectPartnerViewModel(viewModel)); 

                ProjectPartnerDTO projectPartner = new ProjectPartnerDTO();

                // copy values
                viewModel.UpdateDTO(projectPartner, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                projectPartner.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                projectPartner.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_projectPartnerService.AddProjectPartner - " + ProjectPartnerDTO.FormatProjectPartnerDTO(projectPartner)); 

                int id = _projectPartnerService.AddProjectPartner(projectPartner);

                projectPartner.ProjectPartnerId = id;

                log.Debug("result: 'success', id: " + id); 

                return projectPartner;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ProjectPartnerDTO Update(ProjectPartnerViewModel viewModel)
        {
            try
            {
                log.Debug(ProjectPartnerViewModel.FormatProjectPartnerViewModel(viewModel)); 

                // get
                log.Debug("_projectPartnerService.GetProjectPartner - projectPartnerId: " + viewModel.ProjectPartnerId + " "); 

                var existingProjectPartner = _projectPartnerService.GetProjectPartner(viewModel.ProjectPartnerId);

                log.Debug("_projectPartnerService.GetProjectPartner - " + ProjectPartnerDTO.FormatProjectPartnerDTO(existingProjectPartner)); 

                if (existingProjectPartner != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingProjectPartner, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_projectPartnerService.UpdateProjectPartner - " + ProjectPartnerDTO.FormatProjectPartnerDTO(existingProjectPartner)); 

                    _projectPartnerService.UpdateProjectPartner(existingProjectPartner);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingProjectPartner: null, ProjectPartnerId: " + viewModel.ProjectPartnerId); 
                }

                return existingProjectPartner;
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

    