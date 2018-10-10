
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
    [RoutePrefix("api/DeliveryReportMessageTypeApi")]
    public partial class DeliveryReportMessageTypeApiController : ApiController
    {
        private readonly IDeliveryReportMessageTypeService _deliveryReportMessageTypeService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeliveryReportMessageTypeApiController(IDeliveryReportMessageTypeService deliveryReportMessageTypeService)
        {
            this._deliveryReportMessageTypeService = deliveryReportMessageTypeService;
        }

        public DeliveryReportMessageTypeApiController() : this(new DeliveryReportMessageTypeService()) { }

        /// <summary>
        /// Delete DeliveryReportMessageType by id
        /// </summary>
        /// <param name="id">DeliveryReportMessageType id</param>
        /// <returns>true if the DeliveryReportMessageType is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_deliveryReportMessageTypeService.DeleteDeliveryReportMessageType - deliveryReportMessageTypeId: " + id + " "); 

                _deliveryReportMessageTypeService.DeleteDeliveryReportMessageType(id);

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
        /// Get DeliveryReportMessageType by id
        /// </summary>
        /// <param name="id">DeliveryReportMessageType id</param>
        /// <returns>DeliveryReportMessageType json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_deliveryReportMessageTypeService.GetDeliveryReportMessageType - deliveryReportMessageTypeId: " + id + " "); 

                var deliveryReportMessageType = new DeliveryReportMessageTypeViewModel(_deliveryReportMessageTypeService.GetDeliveryReportMessageType(id));

                log.Debug("_deliveryReportMessageTypeService.GetDeliveryReportMessageType - " + DeliveryReportMessageTypeViewModel.FormatDeliveryReportMessageTypeViewModel(deliveryReportMessageType)); 

                log.Debug("result: 'success'"); 

                //return Json(deliveryReportMessageType, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(deliveryReportMessageType), "application/json");
                //return deliveryReportMessageType;
                //return JsonConvert.SerializeObject(deliveryReportMessageType);
                return Ok(deliveryReportMessageType);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of DeliveryReportMessageTypes
        /// </summary>
        /// <returns>json list of DeliveryReportMessageType view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<DeliveryReportMessageTypeViewModel> deliveryReportMessageTypes;

                log.Debug("_deliveryReportMessageTypeService.GetDeliveryReportMessageTypes"); 

                // add edit url
                deliveryReportMessageTypes = _deliveryReportMessageTypeService.GetDeliveryReportMessageTypes()
                        .Select(deliveryReportMessageType => new DeliveryReportMessageTypeViewModel(deliveryReportMessageType, GetEditUrl(deliveryReportMessageType.DeliveryReportMessageTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (deliveryReportMessageTypes != null ? deliveryReportMessageTypes.Count().ToString() : "null")); 

                //return Json(deliveryReportMessageTypes, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(deliveryReportMessageTypes), "application/json");
                //return JsonConvert.SerializeObject(deliveryReportMessageTypes);
                return Ok(deliveryReportMessageTypes);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of DeliveryReportMessageTypes
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of DeliveryReportMessageTypes</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<DeliveryReportMessageTypeViewModel> deliveryReportMessageTypes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_deliveryReportMessageTypeService.GetDeliveryReportMessageTypes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                deliveryReportMessageTypes = _deliveryReportMessageTypeService.GetDeliveryReportMessageTypes(searchTerm, pageIndex, pageSize)
                        .Select(deliveryReportMessageType => new DeliveryReportMessageTypeViewModel(deliveryReportMessageType, GetEditUrl(deliveryReportMessageType.DeliveryReportMessageTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (deliveryReportMessageTypes != null ? deliveryReportMessageTypes.Count().ToString() : "null")); 

                //return Json(deliveryReportMessageTypes, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(deliveryReportMessageTypes);
                return Ok(deliveryReportMessageTypes);
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

                log.Debug("GetDeliveryReportMessageTypeListAdvancedSearch"); 

                IEnumerable<DeliveryReportMessageTypeDTO> resultsDTO = _deliveryReportMessageTypeService.GetDeliveryReportMessageTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<DeliveryReportMessageTypeViewModel> deliveryReportMessageTypeList = resultsDTO.Select(deliveryReportMessageType => new DeliveryReportMessageTypeViewModel(deliveryReportMessageType, GetEditUrl(deliveryReportMessageType.DeliveryReportMessageTypeId))).ToList();

                log.Debug("result: 'success', count: " + (deliveryReportMessageTypeList != null ? deliveryReportMessageTypeList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(deliveryReportMessageTypeList), "application/json");
                //return JsonConvert.SerializeObject(deliveryReportMessageTypeList);
                return Ok(deliveryReportMessageTypeList);
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
            string editUrl = Url.Content("~/DeliveryReportMessageType/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing DeliveryReportMessageType, or creates a new DeliveryReportMessageType if the Id is 0
        /// </summary>
        /// <param name="viewModel">DeliveryReportMessageType data</param>
        /// <returns>DeliveryReportMessageType id</returns>
        public IHttpActionResult Upsert(DeliveryReportMessageTypeViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.DeliveryReportMessageTypeId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.DeliveryReportMessageTypeId);
                return Ok(t.DeliveryReportMessageTypeId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.DeliveryReportMessageTypeId);
                //return JsonConvert.SerializeObject(t.DeliveryReportMessageTypeId);
                return Ok(t.DeliveryReportMessageTypeId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of DeliveryReportMessageType
        /// </summary>
        /// <param name="viewModels">DeliveryReportMessageType view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(DeliveryReportMessageTypeViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(DeliveryReportMessageTypeViewModel viewModel in viewModels)
                    {
                        log.Debug(DeliveryReportMessageTypeViewModel.FormatDeliveryReportMessageTypeViewModel(viewModel)); 

                        if (viewModel.DeliveryReportMessageTypeId > 0)
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

        private DeliveryReportMessageTypeDTO Create(DeliveryReportMessageTypeViewModel viewModel)
        {
            try
            {
                log.Debug(DeliveryReportMessageTypeViewModel.FormatDeliveryReportMessageTypeViewModel(viewModel)); 

                DeliveryReportMessageTypeDTO deliveryReportMessageType = new DeliveryReportMessageTypeDTO();

                // copy values
                viewModel.UpdateDTO(deliveryReportMessageType, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                deliveryReportMessageType.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                deliveryReportMessageType.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_deliveryReportMessageTypeService.AddDeliveryReportMessageType - " + DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(deliveryReportMessageType)); 

                int id = _deliveryReportMessageTypeService.AddDeliveryReportMessageType(deliveryReportMessageType);

                deliveryReportMessageType.DeliveryReportMessageTypeId = id;

                log.Debug("result: 'success', id: " + id); 

                return deliveryReportMessageType;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private DeliveryReportMessageTypeDTO Update(DeliveryReportMessageTypeViewModel viewModel)
        {
            try
            {
                log.Debug(DeliveryReportMessageTypeViewModel.FormatDeliveryReportMessageTypeViewModel(viewModel)); 

                // get
                log.Debug("_deliveryReportMessageTypeService.GetDeliveryReportMessageType - deliveryReportMessageTypeId: " + viewModel.DeliveryReportMessageTypeId + " "); 

                var existingDeliveryReportMessageType = _deliveryReportMessageTypeService.GetDeliveryReportMessageType(viewModel.DeliveryReportMessageTypeId);

                log.Debug("_deliveryReportMessageTypeService.GetDeliveryReportMessageType - " + DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(existingDeliveryReportMessageType)); 

                if (existingDeliveryReportMessageType != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingDeliveryReportMessageType, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_deliveryReportMessageTypeService.UpdateDeliveryReportMessageType - " + DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(existingDeliveryReportMessageType)); 

                    _deliveryReportMessageTypeService.UpdateDeliveryReportMessageType(existingDeliveryReportMessageType);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingDeliveryReportMessageType: null, DeliveryReportMessageTypeId: " + viewModel.DeliveryReportMessageTypeId); 
                }

                return existingDeliveryReportMessageType;
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

    