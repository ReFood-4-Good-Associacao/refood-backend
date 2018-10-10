
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
    [RoutePrefix("api/ContributionMonetaryReviewerApi")]
    public partial class ContributionMonetaryReviewerApiController : ApiController
    {
        private readonly IContributionMonetaryReviewerService _contributionMonetaryReviewerService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionMonetaryReviewerApiController(IContributionMonetaryReviewerService contributionMonetaryReviewerService)
        {
            this._contributionMonetaryReviewerService = contributionMonetaryReviewerService;
        }

        public ContributionMonetaryReviewerApiController() : this(new ContributionMonetaryReviewerService()) { }

        /// <summary>
        /// Delete ContributionMonetaryReviewer by id
        /// </summary>
        /// <param name="id">ContributionMonetaryReviewer id</param>
        /// <returns>true if the ContributionMonetaryReviewer is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_contributionMonetaryReviewerService.DeleteContributionMonetaryReviewer - contributionMonetaryReviewerId: " + id + " "); 

                _contributionMonetaryReviewerService.DeleteContributionMonetaryReviewer(id);

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
        /// Get ContributionMonetaryReviewer by id
        /// </summary>
        /// <param name="id">ContributionMonetaryReviewer id</param>
        /// <returns>ContributionMonetaryReviewer json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_contributionMonetaryReviewerService.GetContributionMonetaryReviewer - contributionMonetaryReviewerId: " + id + " "); 

                var contributionMonetaryReviewer = new ContributionMonetaryReviewerViewModel(_contributionMonetaryReviewerService.GetContributionMonetaryReviewer(id));

                log.Debug("_contributionMonetaryReviewerService.GetContributionMonetaryReviewer - " + ContributionMonetaryReviewerViewModel.FormatContributionMonetaryReviewerViewModel(contributionMonetaryReviewer)); 

                log.Debug("result: 'success'"); 

                //return Json(contributionMonetaryReviewer, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionMonetaryReviewer), "application/json");
                //return contributionMonetaryReviewer;
                //return JsonConvert.SerializeObject(contributionMonetaryReviewer);
                return Ok(contributionMonetaryReviewer);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of ContributionMonetaryReviewers
        /// </summary>
        /// <returns>json list of ContributionMonetaryReviewer view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ContributionMonetaryReviewerViewModel> contributionMonetaryReviewers;

                log.Debug("_contributionMonetaryReviewerService.GetContributionMonetaryReviewers"); 

                // add edit url
                contributionMonetaryReviewers = _contributionMonetaryReviewerService.GetContributionMonetaryReviewers()
                        .Select(contributionMonetaryReviewer => new ContributionMonetaryReviewerViewModel(contributionMonetaryReviewer, GetEditUrl(contributionMonetaryReviewer.ContributionMonetaryReviewerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionMonetaryReviewers != null ? contributionMonetaryReviewers.Count().ToString() : "null")); 

                //return Json(contributionMonetaryReviewers, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionMonetaryReviewers), "application/json");
                //return JsonConvert.SerializeObject(contributionMonetaryReviewers);
                return Ok(contributionMonetaryReviewers);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of ContributionMonetaryReviewers
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of ContributionMonetaryReviewers</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ContributionMonetaryReviewerViewModel> contributionMonetaryReviewers;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_contributionMonetaryReviewerService.GetContributionMonetaryReviewers - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                contributionMonetaryReviewers = _contributionMonetaryReviewerService.GetContributionMonetaryReviewers(searchTerm, pageIndex, pageSize)
                        .Select(contributionMonetaryReviewer => new ContributionMonetaryReviewerViewModel(contributionMonetaryReviewer, GetEditUrl(contributionMonetaryReviewer.ContributionMonetaryReviewerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionMonetaryReviewers != null ? contributionMonetaryReviewers.Count().ToString() : "null")); 

                //return Json(contributionMonetaryReviewers, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(contributionMonetaryReviewers);
                return Ok(contributionMonetaryReviewers);
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
            , int? volunteerId = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetContributionMonetaryReviewerListAdvancedSearch"); 

                IEnumerable<ContributionMonetaryReviewerDTO> resultsDTO = _contributionMonetaryReviewerService.GetContributionMonetaryReviewerListAdvancedSearch(
                     volunteerId 
                );
            
                // convert to view model list, and add edit url
                List<ContributionMonetaryReviewerViewModel> contributionMonetaryReviewerList = resultsDTO.Select(contributionMonetaryReviewer => new ContributionMonetaryReviewerViewModel(contributionMonetaryReviewer, GetEditUrl(contributionMonetaryReviewer.ContributionMonetaryReviewerId))).ToList();

                log.Debug("result: 'success', count: " + (contributionMonetaryReviewerList != null ? contributionMonetaryReviewerList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(contributionMonetaryReviewerList), "application/json");
                //return JsonConvert.SerializeObject(contributionMonetaryReviewerList);
                return Ok(contributionMonetaryReviewerList);
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
            string editUrl = Url.Content("~/ContributionMonetaryReviewer/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing ContributionMonetaryReviewer, or creates a new ContributionMonetaryReviewer if the Id is 0
        /// </summary>
        /// <param name="viewModel">ContributionMonetaryReviewer data</param>
        /// <returns>ContributionMonetaryReviewer id</returns>
        public IHttpActionResult Upsert(ContributionMonetaryReviewerViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ContributionMonetaryReviewerId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ContributionMonetaryReviewerId);
                return Ok(t.ContributionMonetaryReviewerId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ContributionMonetaryReviewerId);
                //return JsonConvert.SerializeObject(t.ContributionMonetaryReviewerId);
                return Ok(t.ContributionMonetaryReviewerId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of ContributionMonetaryReviewer
        /// </summary>
        /// <param name="viewModels">ContributionMonetaryReviewer view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ContributionMonetaryReviewerViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ContributionMonetaryReviewerViewModel viewModel in viewModels)
                    {
                        log.Debug(ContributionMonetaryReviewerViewModel.FormatContributionMonetaryReviewerViewModel(viewModel)); 

                        if (viewModel.ContributionMonetaryReviewerId > 0)
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

        private ContributionMonetaryReviewerDTO Create(ContributionMonetaryReviewerViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionMonetaryReviewerViewModel.FormatContributionMonetaryReviewerViewModel(viewModel)); 

                ContributionMonetaryReviewerDTO contributionMonetaryReviewer = new ContributionMonetaryReviewerDTO();

                // copy values
                viewModel.UpdateDTO(contributionMonetaryReviewer, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                contributionMonetaryReviewer.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                contributionMonetaryReviewer.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_contributionMonetaryReviewerService.AddContributionMonetaryReviewer - " + ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(contributionMonetaryReviewer)); 

                int id = _contributionMonetaryReviewerService.AddContributionMonetaryReviewer(contributionMonetaryReviewer);

                contributionMonetaryReviewer.ContributionMonetaryReviewerId = id;

                log.Debug("result: 'success', id: " + id); 

                return contributionMonetaryReviewer;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ContributionMonetaryReviewerDTO Update(ContributionMonetaryReviewerViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionMonetaryReviewerViewModel.FormatContributionMonetaryReviewerViewModel(viewModel)); 

                // get
                log.Debug("_contributionMonetaryReviewerService.GetContributionMonetaryReviewer - contributionMonetaryReviewerId: " + viewModel.ContributionMonetaryReviewerId + " "); 

                var existingContributionMonetaryReviewer = _contributionMonetaryReviewerService.GetContributionMonetaryReviewer(viewModel.ContributionMonetaryReviewerId);

                log.Debug("_contributionMonetaryReviewerService.GetContributionMonetaryReviewer - " + ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(existingContributionMonetaryReviewer)); 

                if (existingContributionMonetaryReviewer != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingContributionMonetaryReviewer, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_contributionMonetaryReviewerService.UpdateContributionMonetaryReviewer - " + ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(existingContributionMonetaryReviewer)); 

                    _contributionMonetaryReviewerService.UpdateContributionMonetaryReviewer(existingContributionMonetaryReviewer);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingContributionMonetaryReviewer: null, ContributionMonetaryReviewerId: " + viewModel.ContributionMonetaryReviewerId); 
                }

                return existingContributionMonetaryReviewer;
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

    