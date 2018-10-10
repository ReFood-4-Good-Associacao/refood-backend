
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
    [RoutePrefix("api/ExperimentalPhaseLogApi")]
    public partial class ExperimentalPhaseLogApiController : ApiController
    {
        private readonly IExperimentalPhaseLogService _experimentalPhaseLogService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExperimentalPhaseLogApiController(IExperimentalPhaseLogService experimentalPhaseLogService)
        {
            this._experimentalPhaseLogService = experimentalPhaseLogService;
        }

        public ExperimentalPhaseLogApiController() : this(new ExperimentalPhaseLogService()) { }

        /// <summary>
        /// Delete ExperimentalPhaseLog by id
        /// </summary>
        /// <param name="id">ExperimentalPhaseLog id</param>
        /// <returns>true if the ExperimentalPhaseLog is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_experimentalPhaseLogService.DeleteExperimentalPhaseLog - experimentalPhaseLogId: " + id + " "); 

                _experimentalPhaseLogService.DeleteExperimentalPhaseLog(id);

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
        /// Get ExperimentalPhaseLog by id
        /// </summary>
        /// <param name="id">ExperimentalPhaseLog id</param>
        /// <returns>ExperimentalPhaseLog json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_experimentalPhaseLogService.GetExperimentalPhaseLog - experimentalPhaseLogId: " + id + " "); 

                var experimentalPhaseLog = new ExperimentalPhaseLogViewModel(_experimentalPhaseLogService.GetExperimentalPhaseLog(id));

                log.Debug("_experimentalPhaseLogService.GetExperimentalPhaseLog - " + ExperimentalPhaseLogViewModel.FormatExperimentalPhaseLogViewModel(experimentalPhaseLog)); 

                log.Debug("result: 'success'"); 

                //return Json(experimentalPhaseLog, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(experimentalPhaseLog), "application/json");
                //return experimentalPhaseLog;
                //return JsonConvert.SerializeObject(experimentalPhaseLog);
                return Ok(experimentalPhaseLog);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of ExperimentalPhaseLogs
        /// </summary>
        /// <returns>json list of ExperimentalPhaseLog view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ExperimentalPhaseLogViewModel> experimentalPhaseLogs;

                log.Debug("_experimentalPhaseLogService.GetExperimentalPhaseLogs"); 

                // add edit url
                experimentalPhaseLogs = _experimentalPhaseLogService.GetExperimentalPhaseLogs()
                        .Select(experimentalPhaseLog => new ExperimentalPhaseLogViewModel(experimentalPhaseLog, GetEditUrl(experimentalPhaseLog.ExperimentalPhaseLogId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (experimentalPhaseLogs != null ? experimentalPhaseLogs.Count().ToString() : "null")); 

                //return Json(experimentalPhaseLogs, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(experimentalPhaseLogs), "application/json");
                //return JsonConvert.SerializeObject(experimentalPhaseLogs);
                return Ok(experimentalPhaseLogs);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of ExperimentalPhaseLogs
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of ExperimentalPhaseLogs</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ExperimentalPhaseLogViewModel> experimentalPhaseLogs;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_experimentalPhaseLogService.GetExperimentalPhaseLogs - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                experimentalPhaseLogs = _experimentalPhaseLogService.GetExperimentalPhaseLogs(searchTerm, pageIndex, pageSize)
                        .Select(experimentalPhaseLog => new ExperimentalPhaseLogViewModel(experimentalPhaseLog, GetEditUrl(experimentalPhaseLog.ExperimentalPhaseLogId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (experimentalPhaseLogs != null ? experimentalPhaseLogs.Count().ToString() : "null")); 

                //return Json(experimentalPhaseLogs, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(experimentalPhaseLogs);
                return Ok(experimentalPhaseLogs);
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
            , System.DateTime? logDateFrom = null 
            , System.DateTime? logDateTo = null 
            , string task = null 
            , string activityDescription = null 
            , string managerName = null 
            , string volunteerName = null 
            , bool? volunteerConfirmation = null 
            , int? documentId = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetExperimentalPhaseLogListAdvancedSearch"); 

                IEnumerable<ExperimentalPhaseLogDTO> resultsDTO = _experimentalPhaseLogService.GetExperimentalPhaseLogListAdvancedSearch(
                     nucleoId 
                    , logDateFrom 
                    , logDateTo 
                    , task 
                    , activityDescription 
                    , managerName 
                    , volunteerName 
                    , volunteerConfirmation 
                    , documentId 
                );
            
                // convert to view model list, and add edit url
                List<ExperimentalPhaseLogViewModel> experimentalPhaseLogList = resultsDTO.Select(experimentalPhaseLog => new ExperimentalPhaseLogViewModel(experimentalPhaseLog, GetEditUrl(experimentalPhaseLog.ExperimentalPhaseLogId))).ToList();

                log.Debug("result: 'success', count: " + (experimentalPhaseLogList != null ? experimentalPhaseLogList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(experimentalPhaseLogList), "application/json");
                //return JsonConvert.SerializeObject(experimentalPhaseLogList);
                return Ok(experimentalPhaseLogList);
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
            string editUrl = Url.Content("~/ExperimentalPhaseLog/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing ExperimentalPhaseLog, or creates a new ExperimentalPhaseLog if the Id is 0
        /// </summary>
        /// <param name="viewModel">ExperimentalPhaseLog data</param>
        /// <returns>ExperimentalPhaseLog id</returns>
        public IHttpActionResult Upsert(ExperimentalPhaseLogViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ExperimentalPhaseLogId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ExperimentalPhaseLogId);
                return Ok(t.ExperimentalPhaseLogId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ExperimentalPhaseLogId);
                //return JsonConvert.SerializeObject(t.ExperimentalPhaseLogId);
                return Ok(t.ExperimentalPhaseLogId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of ExperimentalPhaseLog
        /// </summary>
        /// <param name="viewModels">ExperimentalPhaseLog view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ExperimentalPhaseLogViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ExperimentalPhaseLogViewModel viewModel in viewModels)
                    {
                        log.Debug(ExperimentalPhaseLogViewModel.FormatExperimentalPhaseLogViewModel(viewModel)); 

                        if (viewModel.ExperimentalPhaseLogId > 0)
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

        private ExperimentalPhaseLogDTO Create(ExperimentalPhaseLogViewModel viewModel)
        {
            try
            {
                log.Debug(ExperimentalPhaseLogViewModel.FormatExperimentalPhaseLogViewModel(viewModel)); 

                ExperimentalPhaseLogDTO experimentalPhaseLog = new ExperimentalPhaseLogDTO();

                // copy values
                viewModel.UpdateDTO(experimentalPhaseLog, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                experimentalPhaseLog.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                experimentalPhaseLog.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_experimentalPhaseLogService.AddExperimentalPhaseLog - " + ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(experimentalPhaseLog)); 

                int id = _experimentalPhaseLogService.AddExperimentalPhaseLog(experimentalPhaseLog);

                experimentalPhaseLog.ExperimentalPhaseLogId = id;

                log.Debug("result: 'success', id: " + id); 

                return experimentalPhaseLog;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ExperimentalPhaseLogDTO Update(ExperimentalPhaseLogViewModel viewModel)
        {
            try
            {
                log.Debug(ExperimentalPhaseLogViewModel.FormatExperimentalPhaseLogViewModel(viewModel)); 

                // get
                log.Debug("_experimentalPhaseLogService.GetExperimentalPhaseLog - experimentalPhaseLogId: " + viewModel.ExperimentalPhaseLogId + " "); 

                var existingExperimentalPhaseLog = _experimentalPhaseLogService.GetExperimentalPhaseLog(viewModel.ExperimentalPhaseLogId);

                log.Debug("_experimentalPhaseLogService.GetExperimentalPhaseLog - " + ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(existingExperimentalPhaseLog)); 

                if (existingExperimentalPhaseLog != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingExperimentalPhaseLog, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_experimentalPhaseLogService.UpdateExperimentalPhaseLog - " + ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(existingExperimentalPhaseLog)); 

                    _experimentalPhaseLogService.UpdateExperimentalPhaseLog(existingExperimentalPhaseLog);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingExperimentalPhaseLog: null, ExperimentalPhaseLogId: " + viewModel.ExperimentalPhaseLogId); 
                }

                return existingExperimentalPhaseLog;
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

    