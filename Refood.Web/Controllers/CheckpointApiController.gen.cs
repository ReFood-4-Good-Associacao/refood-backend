
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
    [RoutePrefix("api/CheckpointApi")]
    public partial class CheckpointApiController : ApiController
    {
        private readonly ICheckpointService _checkpointService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CheckpointApiController(ICheckpointService checkpointService)
        {
            this._checkpointService = checkpointService;
        }

        public CheckpointApiController() : this(new CheckpointService()) { }

        /// <summary>
        /// Delete Checkpoint by id
        /// </summary>
        /// <param name="id">Checkpoint id</param>
        /// <returns>true if the Checkpoint is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_checkpointService.DeleteCheckpoint - checkpointId: " + id + " "); 

                _checkpointService.DeleteCheckpoint(id);

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
        /// Get Checkpoint by id
        /// </summary>
        /// <param name="id">Checkpoint id</param>
        /// <returns>Checkpoint json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_checkpointService.GetCheckpoint - checkpointId: " + id + " "); 

                var checkpoint = new CheckpointViewModel(_checkpointService.GetCheckpoint(id));

                log.Debug("_checkpointService.GetCheckpoint - " + CheckpointViewModel.FormatCheckpointViewModel(checkpoint)); 

                log.Debug("result: 'success'"); 

                //return Json(checkpoint, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(checkpoint), "application/json");
                //return checkpoint;
                //return JsonConvert.SerializeObject(checkpoint);
                return Ok(checkpoint);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Checkpoints
        /// </summary>
        /// <returns>json list of Checkpoint view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<CheckpointViewModel> checkpoints;

                log.Debug("_checkpointService.GetCheckpoints"); 

                // add edit url
                checkpoints = _checkpointService.GetCheckpoints()
                        .Select(checkpoint => new CheckpointViewModel(checkpoint, GetEditUrl(checkpoint.CheckpointId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (checkpoints != null ? checkpoints.Count().ToString() : "null")); 

                //return Json(checkpoints, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(checkpoints), "application/json");
                //return JsonConvert.SerializeObject(checkpoints);
                return Ok(checkpoints);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Checkpoints
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Checkpoints</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<CheckpointViewModel> checkpoints;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_checkpointService.GetCheckpoints - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                checkpoints = _checkpointService.GetCheckpoints(searchTerm, pageIndex, pageSize)
                        .Select(checkpoint => new CheckpointViewModel(checkpoint, GetEditUrl(checkpoint.CheckpointId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (checkpoints != null ? checkpoints.Count().ToString() : "null")); 

                //return Json(checkpoints, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(checkpoints);
                return Ok(checkpoints);
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
            , int? plannedRouteId = null 
            , string name = null 
            , int? orderNumber = null 
            , double? latitude = null 
            , double? longitude = null 
            , int? addressId = null 
            , int? estimatedTimeArrival = null 
            , System.DateTime? minimumTimeFrom = null 
            , System.DateTime? minimumTimeTo = null 
            , System.DateTime? maximumTimeFrom = null 
            , System.DateTime? maximumTimeTo = null 
            , int? nucleoId = null 
            , int? supplierId = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetCheckpointListAdvancedSearch"); 

                IEnumerable<CheckpointDTO> resultsDTO = _checkpointService.GetCheckpointListAdvancedSearch(
                     plannedRouteId 
                    , name 
                    , orderNumber 
                    , latitude 
                    , longitude 
                    , addressId 
                    , estimatedTimeArrival 
                    , minimumTimeFrom 
                    , minimumTimeTo 
                    , maximumTimeFrom 
                    , maximumTimeTo 
                    , nucleoId 
                    , supplierId 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<CheckpointViewModel> checkpointList = resultsDTO.Select(checkpoint => new CheckpointViewModel(checkpoint, GetEditUrl(checkpoint.CheckpointId))).ToList();

                log.Debug("result: 'success', count: " + (checkpointList != null ? checkpointList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(checkpointList), "application/json");
                //return JsonConvert.SerializeObject(checkpointList);
                return Ok(checkpointList);
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        
        public IHttpActionResult GetCheckpointListByPlannedRouteId(int id)
        {
            try
            {
                log.Debug("_checkpointService.GetCheckpointListByPlannedRouteId - PlannedRouteId: " + id + " "); 

                List<CheckpointViewModel> checkpoints;
            
                checkpoints = _checkpointService.GetCheckpointListByPlannedRouteId(id)
                        .Select(checkpoint => new CheckpointViewModel(checkpoint, ""))
                        .ToList();

                log.Debug("result: 'success'"); 

                //return Json(checkpoints, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(checkpoints), "application/json");
                return Ok(checkpoints);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }
        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/Checkpoint/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Checkpoint, or creates a new Checkpoint if the Id is 0
        /// </summary>
        /// <param name="viewModel">Checkpoint data</param>
        /// <returns>Checkpoint id</returns>
        public IHttpActionResult Upsert(CheckpointViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.CheckpointId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.CheckpointId);
                return Ok(t.CheckpointId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.CheckpointId);
                //return JsonConvert.SerializeObject(t.CheckpointId);
                return Ok(t.CheckpointId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Checkpoint
        /// </summary>
        /// <param name="viewModels">Checkpoint view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(CheckpointViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(CheckpointViewModel viewModel in viewModels)
                    {
                        log.Debug(CheckpointViewModel.FormatCheckpointViewModel(viewModel)); 

                        if (viewModel.CheckpointId > 0)
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

        private CheckpointDTO Create(CheckpointViewModel viewModel)
        {
            try
            {
                log.Debug(CheckpointViewModel.FormatCheckpointViewModel(viewModel)); 

                CheckpointDTO checkpoint = new CheckpointDTO();

                // copy values
                viewModel.UpdateDTO(checkpoint, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                checkpoint.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                checkpoint.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_checkpointService.AddCheckpoint - " + CheckpointDTO.FormatCheckpointDTO(checkpoint)); 

                int id = _checkpointService.AddCheckpoint(checkpoint);

                checkpoint.CheckpointId = id;

                log.Debug("result: 'success', id: " + id); 

                return checkpoint;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private CheckpointDTO Update(CheckpointViewModel viewModel)
        {
            try
            {
                log.Debug(CheckpointViewModel.FormatCheckpointViewModel(viewModel)); 

                // get
                log.Debug("_checkpointService.GetCheckpoint - checkpointId: " + viewModel.CheckpointId + " "); 

                var existingCheckpoint = _checkpointService.GetCheckpoint(viewModel.CheckpointId);

                log.Debug("_checkpointService.GetCheckpoint - " + CheckpointDTO.FormatCheckpointDTO(existingCheckpoint)); 

                if (existingCheckpoint != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingCheckpoint, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_checkpointService.UpdateCheckpoint - " + CheckpointDTO.FormatCheckpointDTO(existingCheckpoint)); 

                    _checkpointService.UpdateCheckpoint(existingCheckpoint);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingCheckpoint: null, CheckpointId: " + viewModel.CheckpointId); 
                }

                return existingCheckpoint;
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

    