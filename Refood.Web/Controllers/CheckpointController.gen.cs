
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
using System.Web.Mvc;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    public partial class CheckpointController : System.Web.Mvc.Controller 
    {
        private readonly ICheckpointService _checkpointService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CheckpointController(ICheckpointService checkpointService)
        {
            this._checkpointService = checkpointService;
        }

        public CheckpointController() : this(new CheckpointService()) { }


        public ActionResult Index()
        {
            return View("View");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

        public JsonResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_checkpointService.DeleteCheckpoint - checkpointId: " + id + " "); 

                _checkpointService.DeleteCheckpoint(id);

                log.Debug("result: 'success'"); 

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_checkpointService.GetCheckpoint - checkpointId: " + id + " "); 

                var checkpoint = new CheckpointViewModel(_checkpointService.GetCheckpoint(id));

                log.Debug("_checkpointService.GetCheckpoint - " + CheckpointViewModel.FormatCheckpointViewModel(checkpoint)); 

                log.Debug("result: 'success'"); 

                //return Json(checkpoint, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(checkpoint), "application/json");
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult GetList()
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
                return Content(JsonConvert.SerializeObject(checkpoints), "application/json");
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public JsonResult GetPage(int itemId = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
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

                return Json(checkpoints, JsonRequestBehavior.AllowGet);
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
        public JsonResult Upsert(CheckpointViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.CheckpointId > 0)
            {
                var t = Update(viewModel);
                return Json(true);
            }
            else
            {
                var t = Create(viewModel);
                return Json(t.CheckpointId);
            }
        }

        //[ValidateAntiForgeryToken]
        public JsonResult SaveList(CheckpointViewModel[] viewModels, int? itemId)
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

                return Json(true);
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
                checkpoint.CheckpointId = viewModel.CheckpointId;
                checkpoint.Name = viewModel.Name;
                checkpoint.Latitude = viewModel.Latitude;
                checkpoint.Longitude = viewModel.Longitude;
                checkpoint.AddressId = viewModel.AddressId;
                checkpoint.EstimatedTimeArrival = viewModel.EstimatedTimeArrival;
                checkpoint.MinimumTime = viewModel.MinimumTime;
                checkpoint.MaximumTime = viewModel.MaximumTime;
                checkpoint.Active = viewModel.Active;
                checkpoint.IsDeleted = viewModel.IsDeleted;

                
                // audit
                //checkpoint.CreateBy = UserInfo.UserID;
                //checkpoint.UpdateBy = UserInfo.UserID;
                checkpoint.CreateOn = DateTime.UtcNow;
                checkpoint.UpdateOn = DateTime.UtcNow;

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
                    existingCheckpoint.Name = viewModel.Name;
                    existingCheckpoint.Latitude = viewModel.Latitude;
                    existingCheckpoint.Longitude = viewModel.Longitude;
                    existingCheckpoint.AddressId = viewModel.AddressId;
                    existingCheckpoint.EstimatedTimeArrival = viewModel.EstimatedTimeArrival;
                    existingCheckpoint.MinimumTime = viewModel.MinimumTime;
                    existingCheckpoint.MaximumTime = viewModel.MaximumTime;
                    existingCheckpoint.Active = viewModel.Active;
                    existingCheckpoint.IsDeleted = viewModel.IsDeleted;

                    // audit
                    //existingCheckpoint.UpdateBy = UserInfo.UserID;
                    existingCheckpoint.UpdateOn = DateTime.UtcNow;

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
    