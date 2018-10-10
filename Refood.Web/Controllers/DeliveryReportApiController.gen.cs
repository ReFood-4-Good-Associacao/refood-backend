
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
    [RoutePrefix("api/DeliveryReportApi")]
    public partial class DeliveryReportApiController : ApiController
    {
        private readonly IDeliveryReportService _deliveryReportService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeliveryReportApiController(IDeliveryReportService deliveryReportService)
        {
            this._deliveryReportService = deliveryReportService;
        }

        public DeliveryReportApiController() : this(new DeliveryReportService()) { }

        /// <summary>
        /// Delete DeliveryReport by id
        /// </summary>
        /// <param name="id">DeliveryReport id</param>
        /// <returns>true if the DeliveryReport is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_deliveryReportService.DeleteDeliveryReport - deliveryReportId: " + id + " "); 

                _deliveryReportService.DeleteDeliveryReport(id);

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
        /// Get DeliveryReport by id
        /// </summary>
        /// <param name="id">DeliveryReport id</param>
        /// <returns>DeliveryReport json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_deliveryReportService.GetDeliveryReport - deliveryReportId: " + id + " "); 

                var deliveryReport = new DeliveryReportViewModel(_deliveryReportService.GetDeliveryReport(id));

                log.Debug("_deliveryReportService.GetDeliveryReport - " + DeliveryReportViewModel.FormatDeliveryReportViewModel(deliveryReport)); 

                log.Debug("result: 'success'"); 

                //return Json(deliveryReport, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(deliveryReport), "application/json");
                //return deliveryReport;
                //return JsonConvert.SerializeObject(deliveryReport);
                return Ok(deliveryReport);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of DeliveryReports
        /// </summary>
        /// <returns>json list of DeliveryReport view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<DeliveryReportViewModel> deliveryReports;

                log.Debug("_deliveryReportService.GetDeliveryReports"); 

                // add edit url
                deliveryReports = _deliveryReportService.GetDeliveryReports()
                        .Select(deliveryReport => new DeliveryReportViewModel(deliveryReport, GetEditUrl(deliveryReport.DeliveryReportId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (deliveryReports != null ? deliveryReports.Count().ToString() : "null")); 

                //return Json(deliveryReports, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(deliveryReports), "application/json");
                //return JsonConvert.SerializeObject(deliveryReports);
                return Ok(deliveryReports);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of DeliveryReports
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of DeliveryReports</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<DeliveryReportViewModel> deliveryReports;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_deliveryReportService.GetDeliveryReports - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                deliveryReports = _deliveryReportService.GetDeliveryReports(searchTerm, pageIndex, pageSize)
                        .Select(deliveryReport => new DeliveryReportViewModel(deliveryReport, GetEditUrl(deliveryReport.DeliveryReportId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (deliveryReports != null ? deliveryReports.Count().ToString() : "null")); 

                //return Json(deliveryReports, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(deliveryReports);
                return Ok(deliveryReports);
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
            , System.DateTime? reportDateFrom = null 
            , System.DateTime? reportDateTo = null 
            , string weekDay = null 
            , bool? submitted = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetDeliveryReportListAdvancedSearch"); 

                IEnumerable<DeliveryReportDTO> resultsDTO = _deliveryReportService.GetDeliveryReportListAdvancedSearch(
                     name 
                    , description 
                    , reportDateFrom 
                    , reportDateTo 
                    , weekDay 
                    , submitted 
                );
            
                // convert to view model list, and add edit url
                List<DeliveryReportViewModel> deliveryReportList = resultsDTO.Select(deliveryReport => new DeliveryReportViewModel(deliveryReport, GetEditUrl(deliveryReport.DeliveryReportId))).ToList();

                log.Debug("result: 'success', count: " + (deliveryReportList != null ? deliveryReportList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(deliveryReportList), "application/json");
                //return JsonConvert.SerializeObject(deliveryReportList);
                return Ok(deliveryReportList);
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
            string editUrl = Url.Content("~/DeliveryReport/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing DeliveryReport, or creates a new DeliveryReport if the Id is 0
        /// </summary>
        /// <param name="viewModel">DeliveryReport data</param>
        /// <returns>DeliveryReport id</returns>
        public IHttpActionResult Upsert(DeliveryReportViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.DeliveryReportId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.DeliveryReportId);
                return Ok(t.DeliveryReportId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.DeliveryReportId);
                //return JsonConvert.SerializeObject(t.DeliveryReportId);
                return Ok(t.DeliveryReportId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of DeliveryReport
        /// </summary>
        /// <param name="viewModels">DeliveryReport view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(DeliveryReportViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(DeliveryReportViewModel viewModel in viewModels)
                    {
                        log.Debug(DeliveryReportViewModel.FormatDeliveryReportViewModel(viewModel)); 

                        if (viewModel.DeliveryReportId > 0)
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

        private DeliveryReportDTO Create(DeliveryReportViewModel viewModel)
        {
            try
            {
                log.Debug(DeliveryReportViewModel.FormatDeliveryReportViewModel(viewModel)); 

                DeliveryReportDTO deliveryReport = new DeliveryReportDTO();

                // copy values
                viewModel.UpdateDTO(deliveryReport, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                deliveryReport.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                deliveryReport.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_deliveryReportService.AddDeliveryReport - " + DeliveryReportDTO.FormatDeliveryReportDTO(deliveryReport)); 

                int id = _deliveryReportService.AddDeliveryReport(deliveryReport);

                deliveryReport.DeliveryReportId = id;

                log.Debug("result: 'success', id: " + id); 

                return deliveryReport;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private DeliveryReportDTO Update(DeliveryReportViewModel viewModel)
        {
            try
            {
                log.Debug(DeliveryReportViewModel.FormatDeliveryReportViewModel(viewModel)); 

                // get
                log.Debug("_deliveryReportService.GetDeliveryReport - deliveryReportId: " + viewModel.DeliveryReportId + " "); 

                var existingDeliveryReport = _deliveryReportService.GetDeliveryReport(viewModel.DeliveryReportId);

                log.Debug("_deliveryReportService.GetDeliveryReport - " + DeliveryReportDTO.FormatDeliveryReportDTO(existingDeliveryReport)); 

                if (existingDeliveryReport != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingDeliveryReport, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_deliveryReportService.UpdateDeliveryReport - " + DeliveryReportDTO.FormatDeliveryReportDTO(existingDeliveryReport)); 

                    _deliveryReportService.UpdateDeliveryReport(existingDeliveryReport);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingDeliveryReport: null, DeliveryReportId: " + viewModel.DeliveryReportId); 
                }

                return existingDeliveryReport;
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

    