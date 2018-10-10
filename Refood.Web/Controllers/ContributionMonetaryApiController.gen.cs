
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
    [RoutePrefix("api/ContributionMonetaryApi")]
    public partial class ContributionMonetaryApiController : ApiController
    {
        private readonly IContributionMonetaryService _contributionMonetaryService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionMonetaryApiController(IContributionMonetaryService contributionMonetaryService)
        {
            this._contributionMonetaryService = contributionMonetaryService;
        }

        public ContributionMonetaryApiController() : this(new ContributionMonetaryService()) { }

        /// <summary>
        /// Delete ContributionMonetary by id
        /// </summary>
        /// <param name="id">ContributionMonetary id</param>
        /// <returns>true if the ContributionMonetary is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_contributionMonetaryService.DeleteContributionMonetary - contributionMonetaryId: " + id + " "); 

                _contributionMonetaryService.DeleteContributionMonetary(id);

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
        /// Get ContributionMonetary by id
        /// </summary>
        /// <param name="id">ContributionMonetary id</param>
        /// <returns>ContributionMonetary json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_contributionMonetaryService.GetContributionMonetary - contributionMonetaryId: " + id + " "); 

                var contributionMonetary = new ContributionMonetaryViewModel(_contributionMonetaryService.GetContributionMonetary(id));

                log.Debug("_contributionMonetaryService.GetContributionMonetary - " + ContributionMonetaryViewModel.FormatContributionMonetaryViewModel(contributionMonetary)); 

                log.Debug("result: 'success'"); 

                //return Json(contributionMonetary, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionMonetary), "application/json");
                //return contributionMonetary;
                //return JsonConvert.SerializeObject(contributionMonetary);
                return Ok(contributionMonetary);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of ContributionMonetarys
        /// </summary>
        /// <returns>json list of ContributionMonetary view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ContributionMonetaryViewModel> contributionMonetarys;

                log.Debug("_contributionMonetaryService.GetContributionMonetarys"); 

                // add edit url
                contributionMonetarys = _contributionMonetaryService.GetContributionMonetarys()
                        .Select(contributionMonetary => new ContributionMonetaryViewModel(contributionMonetary, GetEditUrl(contributionMonetary.ContributionMonetaryId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionMonetarys != null ? contributionMonetarys.Count().ToString() : "null")); 

                //return Json(contributionMonetarys, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionMonetarys), "application/json");
                //return JsonConvert.SerializeObject(contributionMonetarys);
                return Ok(contributionMonetarys);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of ContributionMonetarys
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of ContributionMonetarys</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ContributionMonetaryViewModel> contributionMonetarys;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_contributionMonetaryService.GetContributionMonetarys - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                contributionMonetarys = _contributionMonetaryService.GetContributionMonetarys(searchTerm, pageIndex, pageSize)
                        .Select(contributionMonetary => new ContributionMonetaryViewModel(contributionMonetary, GetEditUrl(contributionMonetary.ContributionMonetaryId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionMonetarys != null ? contributionMonetarys.Count().ToString() : "null")); 

                //return Json(contributionMonetarys, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(contributionMonetarys);
                return Ok(contributionMonetarys);
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
            , int? responsiblePersonId = null 
            , int? documentId = null 
            , int? partnerId = null 
            , System.DateTime? contributionDateFrom = null 
            , System.DateTime? contributionDateTo = null 
            , double? amount = null 
            , string contactPerson = null 
            , string ibanOrigin = null 
            , string bicSwiftOrigin = null 
            , string ibanDestination = null 
            , string bicSwiftDestination = null 
            , string fiscalNumber = null 
            , int? contributionChannelId = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetContributionMonetaryListAdvancedSearch"); 

                IEnumerable<ContributionMonetaryDTO> resultsDTO = _contributionMonetaryService.GetContributionMonetaryListAdvancedSearch(
                     nucleoId 
                    , responsiblePersonId 
                    , documentId 
                    , partnerId 
                    , contributionDateFrom 
                    , contributionDateTo 
                    , amount 
                    , contactPerson 
                    , ibanOrigin 
                    , bicSwiftOrigin 
                    , ibanDestination 
                    , bicSwiftDestination 
                    , fiscalNumber 
                    , contributionChannelId 
                );
            
                // convert to view model list, and add edit url
                List<ContributionMonetaryViewModel> contributionMonetaryList = resultsDTO.Select(contributionMonetary => new ContributionMonetaryViewModel(contributionMonetary, GetEditUrl(contributionMonetary.ContributionMonetaryId))).ToList();

                log.Debug("result: 'success', count: " + (contributionMonetaryList != null ? contributionMonetaryList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(contributionMonetaryList), "application/json");
                //return JsonConvert.SerializeObject(contributionMonetaryList);
                return Ok(contributionMonetaryList);
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
            string editUrl = Url.Content("~/ContributionMonetary/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing ContributionMonetary, or creates a new ContributionMonetary if the Id is 0
        /// </summary>
        /// <param name="viewModel">ContributionMonetary data</param>
        /// <returns>ContributionMonetary id</returns>
        public IHttpActionResult Upsert(ContributionMonetaryViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ContributionMonetaryId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ContributionMonetaryId);
                return Ok(t.ContributionMonetaryId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ContributionMonetaryId);
                //return JsonConvert.SerializeObject(t.ContributionMonetaryId);
                return Ok(t.ContributionMonetaryId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of ContributionMonetary
        /// </summary>
        /// <param name="viewModels">ContributionMonetary view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ContributionMonetaryViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ContributionMonetaryViewModel viewModel in viewModels)
                    {
                        log.Debug(ContributionMonetaryViewModel.FormatContributionMonetaryViewModel(viewModel)); 

                        if (viewModel.ContributionMonetaryId > 0)
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

        private ContributionMonetaryDTO Create(ContributionMonetaryViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionMonetaryViewModel.FormatContributionMonetaryViewModel(viewModel)); 

                ContributionMonetaryDTO contributionMonetary = new ContributionMonetaryDTO();

                // copy values
                viewModel.UpdateDTO(contributionMonetary, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                contributionMonetary.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                contributionMonetary.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_contributionMonetaryService.AddContributionMonetary - " + ContributionMonetaryDTO.FormatContributionMonetaryDTO(contributionMonetary)); 

                int id = _contributionMonetaryService.AddContributionMonetary(contributionMonetary);

                contributionMonetary.ContributionMonetaryId = id;

                log.Debug("result: 'success', id: " + id); 

                return contributionMonetary;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ContributionMonetaryDTO Update(ContributionMonetaryViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionMonetaryViewModel.FormatContributionMonetaryViewModel(viewModel)); 

                // get
                log.Debug("_contributionMonetaryService.GetContributionMonetary - contributionMonetaryId: " + viewModel.ContributionMonetaryId + " "); 

                var existingContributionMonetary = _contributionMonetaryService.GetContributionMonetary(viewModel.ContributionMonetaryId);

                log.Debug("_contributionMonetaryService.GetContributionMonetary - " + ContributionMonetaryDTO.FormatContributionMonetaryDTO(existingContributionMonetary)); 

                if (existingContributionMonetary != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingContributionMonetary, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_contributionMonetaryService.UpdateContributionMonetary - " + ContributionMonetaryDTO.FormatContributionMonetaryDTO(existingContributionMonetary)); 

                    _contributionMonetaryService.UpdateContributionMonetary(existingContributionMonetary);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingContributionMonetary: null, ContributionMonetaryId: " + viewModel.ContributionMonetaryId); 
                }

                return existingContributionMonetary;
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

    