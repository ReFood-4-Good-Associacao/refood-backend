
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
    [RoutePrefix("api/ContributionChannelApi")]
    public partial class ContributionChannelApiController : ApiController
    {
        private readonly IContributionChannelService _contributionChannelService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionChannelApiController(IContributionChannelService contributionChannelService)
        {
            this._contributionChannelService = contributionChannelService;
        }

        public ContributionChannelApiController() : this(new ContributionChannelService()) { }

        /// <summary>
        /// Delete ContributionChannel by id
        /// </summary>
        /// <param name="id">ContributionChannel id</param>
        /// <returns>true if the ContributionChannel is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_contributionChannelService.DeleteContributionChannel - contributionChannelId: " + id + " "); 

                _contributionChannelService.DeleteContributionChannel(id);

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
        /// Get ContributionChannel by id
        /// </summary>
        /// <param name="id">ContributionChannel id</param>
        /// <returns>ContributionChannel json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_contributionChannelService.GetContributionChannel - contributionChannelId: " + id + " "); 

                var contributionChannel = new ContributionChannelViewModel(_contributionChannelService.GetContributionChannel(id));

                log.Debug("_contributionChannelService.GetContributionChannel - " + ContributionChannelViewModel.FormatContributionChannelViewModel(contributionChannel)); 

                log.Debug("result: 'success'"); 

                //return Json(contributionChannel, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionChannel), "application/json");
                //return contributionChannel;
                //return JsonConvert.SerializeObject(contributionChannel);
                return Ok(contributionChannel);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of ContributionChannels
        /// </summary>
        /// <returns>json list of ContributionChannel view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ContributionChannelViewModel> contributionChannels;

                log.Debug("_contributionChannelService.GetContributionChannels"); 

                // add edit url
                contributionChannels = _contributionChannelService.GetContributionChannels()
                        .Select(contributionChannel => new ContributionChannelViewModel(contributionChannel, GetEditUrl(contributionChannel.ContributionChannelId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionChannels != null ? contributionChannels.Count().ToString() : "null")); 

                //return Json(contributionChannels, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionChannels), "application/json");
                //return JsonConvert.SerializeObject(contributionChannels);
                return Ok(contributionChannels);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of ContributionChannels
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of ContributionChannels</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ContributionChannelViewModel> contributionChannels;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_contributionChannelService.GetContributionChannels - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                contributionChannels = _contributionChannelService.GetContributionChannels(searchTerm, pageIndex, pageSize)
                        .Select(contributionChannel => new ContributionChannelViewModel(contributionChannel, GetEditUrl(contributionChannel.ContributionChannelId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionChannels != null ? contributionChannels.Count().ToString() : "null")); 

                //return Json(contributionChannels, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(contributionChannels);
                return Ok(contributionChannels);
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
            , string name = null 
            , string description = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetContributionChannelListAdvancedSearch"); 

                IEnumerable<ContributionChannelDTO> resultsDTO = _contributionChannelService.GetContributionChannelListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<ContributionChannelViewModel> contributionChannelList = resultsDTO.Select(contributionChannel => new ContributionChannelViewModel(contributionChannel, GetEditUrl(contributionChannel.ContributionChannelId))).ToList();

                log.Debug("result: 'success', count: " + (contributionChannelList != null ? contributionChannelList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(contributionChannelList), "application/json");
                //return JsonConvert.SerializeObject(contributionChannelList);
                return Ok(contributionChannelList);
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
            string editUrl = Url.Content("~/ContributionChannel/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing ContributionChannel, or creates a new ContributionChannel if the Id is 0
        /// </summary>
        /// <param name="viewModel">ContributionChannel data</param>
        /// <returns>ContributionChannel id</returns>
        public IHttpActionResult Upsert(ContributionChannelViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ContributionChannelId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ContributionChannelId);
                return Ok(t.ContributionChannelId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ContributionChannelId);
                //return JsonConvert.SerializeObject(t.ContributionChannelId);
                return Ok(t.ContributionChannelId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of ContributionChannel
        /// </summary>
        /// <param name="viewModels">ContributionChannel view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ContributionChannelViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ContributionChannelViewModel viewModel in viewModels)
                    {
                        log.Debug(ContributionChannelViewModel.FormatContributionChannelViewModel(viewModel)); 

                        if (viewModel.ContributionChannelId > 0)
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

        private ContributionChannelDTO Create(ContributionChannelViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionChannelViewModel.FormatContributionChannelViewModel(viewModel)); 

                ContributionChannelDTO contributionChannel = new ContributionChannelDTO();

                // copy values
                viewModel.UpdateDTO(contributionChannel, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                contributionChannel.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                contributionChannel.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_contributionChannelService.AddContributionChannel - " + ContributionChannelDTO.FormatContributionChannelDTO(contributionChannel)); 

                int id = _contributionChannelService.AddContributionChannel(contributionChannel);

                contributionChannel.ContributionChannelId = id;

                log.Debug("result: 'success', id: " + id); 

                return contributionChannel;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ContributionChannelDTO Update(ContributionChannelViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionChannelViewModel.FormatContributionChannelViewModel(viewModel)); 

                // get
                log.Debug("_contributionChannelService.GetContributionChannel - contributionChannelId: " + viewModel.ContributionChannelId + " "); 

                var existingContributionChannel = _contributionChannelService.GetContributionChannel(viewModel.ContributionChannelId);

                log.Debug("_contributionChannelService.GetContributionChannel - " + ContributionChannelDTO.FormatContributionChannelDTO(existingContributionChannel)); 

                if (existingContributionChannel != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingContributionChannel, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_contributionChannelService.UpdateContributionChannel - " + ContributionChannelDTO.FormatContributionChannelDTO(existingContributionChannel)); 

                    _contributionChannelService.UpdateContributionChannel(existingContributionChannel);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingContributionChannel: null, ContributionChannelId: " + viewModel.ContributionChannelId); 
                }

                return existingContributionChannel;
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

    