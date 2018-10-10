
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
    [RoutePrefix("api/DeliveryReportMessageApi")]
    public partial class DeliveryReportMessageApiController : ApiController
    {
        private readonly IDeliveryReportMessageService _deliveryReportMessageService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeliveryReportMessageApiController(IDeliveryReportMessageService deliveryReportMessageService)
        {
            this._deliveryReportMessageService = deliveryReportMessageService;
        }

        public DeliveryReportMessageApiController() : this(new DeliveryReportMessageService()) { }

        /// <summary>
        /// Delete DeliveryReportMessage by id
        /// </summary>
        /// <param name="id">DeliveryReportMessage id</param>
        /// <returns>true if the DeliveryReportMessage is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_deliveryReportMessageService.DeleteDeliveryReportMessage - deliveryReportMessageId: " + id + " "); 

                _deliveryReportMessageService.DeleteDeliveryReportMessage(id);

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
        /// Get DeliveryReportMessage by id
        /// </summary>
        /// <param name="id">DeliveryReportMessage id</param>
        /// <returns>DeliveryReportMessage json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_deliveryReportMessageService.GetDeliveryReportMessage - deliveryReportMessageId: " + id + " "); 

                var deliveryReportMessage = new DeliveryReportMessageViewModel(_deliveryReportMessageService.GetDeliveryReportMessage(id));

                log.Debug("_deliveryReportMessageService.GetDeliveryReportMessage - " + DeliveryReportMessageViewModel.FormatDeliveryReportMessageViewModel(deliveryReportMessage)); 

                log.Debug("result: 'success'"); 

                //return Json(deliveryReportMessage, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(deliveryReportMessage), "application/json");
                //return deliveryReportMessage;
                //return JsonConvert.SerializeObject(deliveryReportMessage);
                return Ok(deliveryReportMessage);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of DeliveryReportMessages
        /// </summary>
        /// <returns>json list of DeliveryReportMessage view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<DeliveryReportMessageViewModel> deliveryReportMessages;

                log.Debug("_deliveryReportMessageService.GetDeliveryReportMessages"); 

                // add edit url
                deliveryReportMessages = _deliveryReportMessageService.GetDeliveryReportMessages()
                        .Select(deliveryReportMessage => new DeliveryReportMessageViewModel(deliveryReportMessage, GetEditUrl(deliveryReportMessage.DeliveryReportMessageId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (deliveryReportMessages != null ? deliveryReportMessages.Count().ToString() : "null")); 

                //return Json(deliveryReportMessages, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(deliveryReportMessages), "application/json");
                //return JsonConvert.SerializeObject(deliveryReportMessages);
                return Ok(deliveryReportMessages);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of DeliveryReportMessages
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of DeliveryReportMessages</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<DeliveryReportMessageViewModel> deliveryReportMessages;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_deliveryReportMessageService.GetDeliveryReportMessages - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                deliveryReportMessages = _deliveryReportMessageService.GetDeliveryReportMessages(searchTerm, pageIndex, pageSize)
                        .Select(deliveryReportMessage => new DeliveryReportMessageViewModel(deliveryReportMessage, GetEditUrl(deliveryReportMessage.DeliveryReportMessageId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (deliveryReportMessages != null ? deliveryReportMessages.Count().ToString() : "null")); 

                //return Json(deliveryReportMessages, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(deliveryReportMessages);
                return Ok(deliveryReportMessages);
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
            , int? deliveryReportMessageTypeId = null 
            , string message = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetDeliveryReportMessageListAdvancedSearch"); 

                IEnumerable<DeliveryReportMessageDTO> resultsDTO = _deliveryReportMessageService.GetDeliveryReportMessageListAdvancedSearch(
                     deliveryReportMessageTypeId 
                    , message 
                );
            
                // convert to view model list, and add edit url
                List<DeliveryReportMessageViewModel> deliveryReportMessageList = resultsDTO.Select(deliveryReportMessage => new DeliveryReportMessageViewModel(deliveryReportMessage, GetEditUrl(deliveryReportMessage.DeliveryReportMessageId))).ToList();

                log.Debug("result: 'success', count: " + (deliveryReportMessageList != null ? deliveryReportMessageList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(deliveryReportMessageList), "application/json");
                //return JsonConvert.SerializeObject(deliveryReportMessageList);
                return Ok(deliveryReportMessageList);
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
            string editUrl = Url.Content("~/DeliveryReportMessage/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing DeliveryReportMessage, or creates a new DeliveryReportMessage if the Id is 0
        /// </summary>
        /// <param name="viewModel">DeliveryReportMessage data</param>
        /// <returns>DeliveryReportMessage id</returns>
        public IHttpActionResult Upsert(DeliveryReportMessageViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.DeliveryReportMessageId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.DeliveryReportMessageId);
                return Ok(t.DeliveryReportMessageId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.DeliveryReportMessageId);
                //return JsonConvert.SerializeObject(t.DeliveryReportMessageId);
                return Ok(t.DeliveryReportMessageId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of DeliveryReportMessage
        /// </summary>
        /// <param name="viewModels">DeliveryReportMessage view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(DeliveryReportMessageViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(DeliveryReportMessageViewModel viewModel in viewModels)
                    {
                        log.Debug(DeliveryReportMessageViewModel.FormatDeliveryReportMessageViewModel(viewModel)); 

                        if (viewModel.DeliveryReportMessageId > 0)
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

        private DeliveryReportMessageDTO Create(DeliveryReportMessageViewModel viewModel)
        {
            try
            {
                log.Debug(DeliveryReportMessageViewModel.FormatDeliveryReportMessageViewModel(viewModel)); 

                DeliveryReportMessageDTO deliveryReportMessage = new DeliveryReportMessageDTO();

                // copy values
                viewModel.UpdateDTO(deliveryReportMessage, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                deliveryReportMessage.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                deliveryReportMessage.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_deliveryReportMessageService.AddDeliveryReportMessage - " + DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(deliveryReportMessage)); 

                int id = _deliveryReportMessageService.AddDeliveryReportMessage(deliveryReportMessage);

                deliveryReportMessage.DeliveryReportMessageId = id;

                log.Debug("result: 'success', id: " + id); 

                return deliveryReportMessage;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private DeliveryReportMessageDTO Update(DeliveryReportMessageViewModel viewModel)
        {
            try
            {
                log.Debug(DeliveryReportMessageViewModel.FormatDeliveryReportMessageViewModel(viewModel)); 

                // get
                log.Debug("_deliveryReportMessageService.GetDeliveryReportMessage - deliveryReportMessageId: " + viewModel.DeliveryReportMessageId + " "); 

                var existingDeliveryReportMessage = _deliveryReportMessageService.GetDeliveryReportMessage(viewModel.DeliveryReportMessageId);

                log.Debug("_deliveryReportMessageService.GetDeliveryReportMessage - " + DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(existingDeliveryReportMessage)); 

                if (existingDeliveryReportMessage != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingDeliveryReportMessage, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_deliveryReportMessageService.UpdateDeliveryReportMessage - " + DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(existingDeliveryReportMessage)); 

                    _deliveryReportMessageService.UpdateDeliveryReportMessage(existingDeliveryReportMessage);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingDeliveryReportMessage: null, DeliveryReportMessageId: " + viewModel.DeliveryReportMessageId); 
                }

                return existingDeliveryReportMessage;
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

    