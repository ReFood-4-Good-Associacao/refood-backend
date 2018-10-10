
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
    [RoutePrefix("api/PartnershipType")]
    public partial class PartnershipTypeApiController : ApiController
    {
        private readonly IPartnershipTypeService _partnershipTypeService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PartnershipTypeApiController(IPartnershipTypeService partnershipTypeService)
        {
            this._partnershipTypeService = partnershipTypeService;
        }

        public PartnershipTypeApiController() : this(new PartnershipTypeService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_partnershipTypeService.DeletePartnershipType - partnershipTypeId: " + id + " "); 

                _partnershipTypeService.DeletePartnershipType(id);

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
                log.Debug("_partnershipTypeService.GetPartnershipType - partnershipTypeId: " + id + " "); 

                var partnershipType = new PartnershipTypeViewModel(_partnershipTypeService.GetPartnershipType(id));

                log.Debug("_partnershipTypeService.GetPartnershipType - " + PartnershipTypeViewModel.FormatPartnershipTypeViewModel(partnershipType)); 

                log.Debug("result: 'success'"); 

                //return Json(partnershipType, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(partnershipType), "application/json");
                //return partnershipType;
                //return JsonConvert.SerializeObject(partnershipType);
                return Ok(partnershipType);
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
                List<PartnershipTypeViewModel> partnershipTypes;

                log.Debug("_partnershipTypeService.GetPartnershipTypes"); 

                // add edit url
                partnershipTypes = _partnershipTypeService.GetPartnershipTypes()
                        .Select(partnershipType => new PartnershipTypeViewModel(partnershipType, GetEditUrl(partnershipType.PartnershipTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (partnershipTypes != null ? partnershipTypes.Count().ToString() : "null")); 

                //return Json(partnershipTypes, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(partnershipTypes), "application/json");
                //return JsonConvert.SerializeObject(partnershipTypes);
                return Ok(partnershipTypes);
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
                List<PartnershipTypeViewModel> partnershipTypes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_partnershipTypeService.GetPartnershipTypes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                partnershipTypes = _partnershipTypeService.GetPartnershipTypes(searchTerm, pageIndex, pageSize)
                        .Select(partnershipType => new PartnershipTypeViewModel(partnershipType, GetEditUrl(partnershipType.PartnershipTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (partnershipTypes != null ? partnershipTypes.Count().ToString() : "null")); 

                //return Json(partnershipTypes, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(partnershipTypes);
                return Ok(partnershipTypes);
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
            , string activityType = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetPartnershipTypeListAdvancedSearch"); 

                IEnumerable<PartnershipTypeDTO> resultsDTO = _partnershipTypeService.GetPartnershipTypeListAdvancedSearch(
                     name 
                    , description 
                    , activityType 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<PartnershipTypeViewModel> partnershipTypeList = resultsDTO.Select(partnershipType => new PartnershipTypeViewModel(partnershipType, GetEditUrl(partnershipType.PartnershipTypeId))).ToList();

                log.Debug("result: 'success', count: " + (partnershipTypeList != null ? partnershipTypeList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(partnershipTypeList), "application/json");
                //return JsonConvert.SerializeObject(partnershipTypeList);
                return Ok(partnershipTypeList);
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
            string editUrl = Url.Content("~/PartnershipType/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(PartnershipTypeViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.PartnershipTypeId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.PartnershipTypeId);
                return Ok(t.PartnershipTypeId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.PartnershipTypeId);
                //return JsonConvert.SerializeObject(t.PartnershipTypeId);
                return Ok(t.PartnershipTypeId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(PartnershipTypeViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(PartnershipTypeViewModel viewModel in viewModels)
                    {
                        log.Debug(PartnershipTypeViewModel.FormatPartnershipTypeViewModel(viewModel)); 

                        if (viewModel.PartnershipTypeId > 0)
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

        private PartnershipTypeDTO Create(PartnershipTypeViewModel viewModel)
        {
            try
            {
                log.Debug(PartnershipTypeViewModel.FormatPartnershipTypeViewModel(viewModel)); 

                PartnershipTypeDTO partnershipType = new PartnershipTypeDTO();

                // copy values
                viewModel.UpdateDTO(partnershipType, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                partnershipType.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                partnershipType.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_partnershipTypeService.AddPartnershipType - " + PartnershipTypeDTO.FormatPartnershipTypeDTO(partnershipType)); 

                int id = _partnershipTypeService.AddPartnershipType(partnershipType);

                partnershipType.PartnershipTypeId = id;

                log.Debug("result: 'success', id: " + id); 

                return partnershipType;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private PartnershipTypeDTO Update(PartnershipTypeViewModel viewModel)
        {
            try
            {
                log.Debug(PartnershipTypeViewModel.FormatPartnershipTypeViewModel(viewModel)); 

                // get
                log.Debug("_partnershipTypeService.GetPartnershipType - partnershipTypeId: " + viewModel.PartnershipTypeId + " "); 

                var existingPartnershipType = _partnershipTypeService.GetPartnershipType(viewModel.PartnershipTypeId);

                log.Debug("_partnershipTypeService.GetPartnershipType - " + PartnershipTypeDTO.FormatPartnershipTypeDTO(existingPartnershipType)); 

                if (existingPartnershipType != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingPartnershipType, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_partnershipTypeService.UpdatePartnershipType - " + PartnershipTypeDTO.FormatPartnershipTypeDTO(existingPartnershipType)); 

                    _partnershipTypeService.UpdatePartnershipType(existingPartnershipType);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingPartnershipType: null, PartnershipTypeId: " + viewModel.PartnershipTypeId); 
                }

                return existingPartnershipType;
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

    