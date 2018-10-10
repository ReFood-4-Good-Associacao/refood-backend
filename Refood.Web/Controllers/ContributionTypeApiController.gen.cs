
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
    [RoutePrefix("api/ContributionType")]
    public partial class ContributionTypeApiController : ApiController
    {
        private readonly IContributionTypeService _contributionTypeService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionTypeApiController(IContributionTypeService contributionTypeService)
        {
            this._contributionTypeService = contributionTypeService;
        }

        public ContributionTypeApiController() : this(new ContributionTypeService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_contributionTypeService.DeleteContributionType - contributionTypeId: " + id + " "); 

                _contributionTypeService.DeleteContributionType(id);

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

        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_contributionTypeService.GetContributionType - contributionTypeId: " + id + " "); 

                var contributionType = new ContributionTypeViewModel(_contributionTypeService.GetContributionType(id));

                log.Debug("_contributionTypeService.GetContributionType - " + ContributionTypeViewModel.FormatContributionTypeViewModel(contributionType)); 

                log.Debug("result: 'success'"); 

                //return Json(contributionType, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionType), "application/json");
                //return contributionType;
                //return JsonConvert.SerializeObject(contributionType);
                return Ok(contributionType);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ContributionTypeViewModel> contributionTypes;

                log.Debug("_contributionTypeService.GetContributionTypes"); 

                // add edit url
                contributionTypes = _contributionTypeService.GetContributionTypes()
                        .Select(contributionType => new ContributionTypeViewModel(contributionType, GetEditUrl(contributionType.ContributionTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionTypes != null ? contributionTypes.Count().ToString() : "null")); 

                //return Json(contributionTypes, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(contributionTypes), "application/json");
                //return JsonConvert.SerializeObject(contributionTypes);
                return Ok(contributionTypes);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ContributionTypeViewModel> contributionTypes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_contributionTypeService.GetContributionTypes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                contributionTypes = _contributionTypeService.GetContributionTypes(searchTerm, pageIndex, pageSize)
                        .Select(contributionType => new ContributionTypeViewModel(contributionType, GetEditUrl(contributionType.ContributionTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (contributionTypes != null ? contributionTypes.Count().ToString() : "null")); 

                //return Json(contributionTypes, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(contributionTypes);
                return Ok(contributionTypes);
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

                log.Debug("GetContributionTypeListAdvancedSearch"); 

                IEnumerable<ContributionTypeDTO> resultsDTO = _contributionTypeService.GetContributionTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<ContributionTypeViewModel> contributionTypeList = resultsDTO.Select(contributionType => new ContributionTypeViewModel(contributionType, GetEditUrl(contributionType.ContributionTypeId))).ToList();

                log.Debug("result: 'success', count: " + (contributionTypeList != null ? contributionTypeList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(contributionTypeList), "application/json");
                //return JsonConvert.SerializeObject(contributionTypeList);
                return Ok(contributionTypeList);
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
            string editUrl = Url.Content("~/ContributionType/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(ContributionTypeViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ContributionTypeId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ContributionTypeId);
                return Ok(t.ContributionTypeId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ContributionTypeId);
                //return JsonConvert.SerializeObject(t.ContributionTypeId);
                return Ok(t.ContributionTypeId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(ContributionTypeViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ContributionTypeViewModel viewModel in viewModels)
                    {
                        log.Debug(ContributionTypeViewModel.FormatContributionTypeViewModel(viewModel)); 

                        if (viewModel.ContributionTypeId > 0)
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

        private ContributionTypeDTO Create(ContributionTypeViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionTypeViewModel.FormatContributionTypeViewModel(viewModel)); 

                ContributionTypeDTO contributionType = new ContributionTypeDTO();

                // copy values
                viewModel.UpdateDTO(contributionType, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                contributionType.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                contributionType.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_contributionTypeService.AddContributionType - " + ContributionTypeDTO.FormatContributionTypeDTO(contributionType)); 

                int id = _contributionTypeService.AddContributionType(contributionType);

                contributionType.ContributionTypeId = id;

                log.Debug("result: 'success', id: " + id); 

                return contributionType;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ContributionTypeDTO Update(ContributionTypeViewModel viewModel)
        {
            try
            {
                log.Debug(ContributionTypeViewModel.FormatContributionTypeViewModel(viewModel)); 

                // get
                log.Debug("_contributionTypeService.GetContributionType - contributionTypeId: " + viewModel.ContributionTypeId + " "); 

                var existingContributionType = _contributionTypeService.GetContributionType(viewModel.ContributionTypeId);

                log.Debug("_contributionTypeService.GetContributionType - " + ContributionTypeDTO.FormatContributionTypeDTO(existingContributionType)); 

                if (existingContributionType != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingContributionType, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_contributionTypeService.UpdateContributionType - " + ContributionTypeDTO.FormatContributionTypeDTO(existingContributionType)); 

                    _contributionTypeService.UpdateContributionType(existingContributionType);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingContributionType: null, ContributionTypeId: " + viewModel.ContributionTypeId); 
                }

                return existingContributionType;
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

    