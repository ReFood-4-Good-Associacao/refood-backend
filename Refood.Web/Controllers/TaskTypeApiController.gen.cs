
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
    [RoutePrefix("api/TaskTypeApi")]
    public partial class TaskTypeApiController : ApiController
    {
        private readonly ITaskTypeService _taskTypeService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TaskTypeApiController(ITaskTypeService taskTypeService)
        {
            this._taskTypeService = taskTypeService;
        }

        public TaskTypeApiController() : this(new TaskTypeService()) { }

        /// <summary>
        /// Delete TaskType by id
        /// </summary>
        /// <param name="id">TaskType id</param>
        /// <returns>true if the TaskType is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_taskTypeService.DeleteTaskType - taskTypeId: " + id + " "); 

                _taskTypeService.DeleteTaskType(id);

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
        /// Get TaskType by id
        /// </summary>
        /// <param name="id">TaskType id</param>
        /// <returns>TaskType json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_taskTypeService.GetTaskType - taskTypeId: " + id + " "); 

                var taskType = new TaskTypeViewModel(_taskTypeService.GetTaskType(id));

                log.Debug("_taskTypeService.GetTaskType - " + TaskTypeViewModel.FormatTaskTypeViewModel(taskType)); 

                log.Debug("result: 'success'"); 

                //return Json(taskType, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(taskType), "application/json");
                //return taskType;
                //return JsonConvert.SerializeObject(taskType);
                return Ok(taskType);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of TaskTypes
        /// </summary>
        /// <returns>json list of TaskType view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<TaskTypeViewModel> taskTypes;

                log.Debug("_taskTypeService.GetTaskTypes"); 

                // add edit url
                taskTypes = _taskTypeService.GetTaskTypes()
                        .Select(taskType => new TaskTypeViewModel(taskType, GetEditUrl(taskType.TaskTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (taskTypes != null ? taskTypes.Count().ToString() : "null")); 

                //return Json(taskTypes, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(taskTypes), "application/json");
                //return JsonConvert.SerializeObject(taskTypes);
                return Ok(taskTypes);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of TaskTypes
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of TaskTypes</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<TaskTypeViewModel> taskTypes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_taskTypeService.GetTaskTypes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                taskTypes = _taskTypeService.GetTaskTypes(searchTerm, pageIndex, pageSize)
                        .Select(taskType => new TaskTypeViewModel(taskType, GetEditUrl(taskType.TaskTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (taskTypes != null ? taskTypes.Count().ToString() : "null")); 

                //return Json(taskTypes, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(taskTypes);
                return Ok(taskTypes);
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

                log.Debug("GetTaskTypeListAdvancedSearch"); 

                IEnumerable<TaskTypeDTO> resultsDTO = _taskTypeService.GetTaskTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<TaskTypeViewModel> taskTypeList = resultsDTO.Select(taskType => new TaskTypeViewModel(taskType, GetEditUrl(taskType.TaskTypeId))).ToList();

                log.Debug("result: 'success', count: " + (taskTypeList != null ? taskTypeList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(taskTypeList), "application/json");
                //return JsonConvert.SerializeObject(taskTypeList);
                return Ok(taskTypeList);
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
            string editUrl = Url.Content("~/TaskType/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing TaskType, or creates a new TaskType if the Id is 0
        /// </summary>
        /// <param name="viewModel">TaskType data</param>
        /// <returns>TaskType id</returns>
        public IHttpActionResult Upsert(TaskTypeViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.TaskTypeId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.TaskTypeId);
                return Ok(t.TaskTypeId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.TaskTypeId);
                //return JsonConvert.SerializeObject(t.TaskTypeId);
                return Ok(t.TaskTypeId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of TaskType
        /// </summary>
        /// <param name="viewModels">TaskType view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(TaskTypeViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(TaskTypeViewModel viewModel in viewModels)
                    {
                        log.Debug(TaskTypeViewModel.FormatTaskTypeViewModel(viewModel)); 

                        if (viewModel.TaskTypeId > 0)
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

        private TaskTypeDTO Create(TaskTypeViewModel viewModel)
        {
            try
            {
                log.Debug(TaskTypeViewModel.FormatTaskTypeViewModel(viewModel)); 

                TaskTypeDTO taskType = new TaskTypeDTO();

                // copy values
                viewModel.UpdateDTO(taskType, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                taskType.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                taskType.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_taskTypeService.AddTaskType - " + TaskTypeDTO.FormatTaskTypeDTO(taskType)); 

                int id = _taskTypeService.AddTaskType(taskType);

                taskType.TaskTypeId = id;

                log.Debug("result: 'success', id: " + id); 

                return taskType;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private TaskTypeDTO Update(TaskTypeViewModel viewModel)
        {
            try
            {
                log.Debug(TaskTypeViewModel.FormatTaskTypeViewModel(viewModel)); 

                // get
                log.Debug("_taskTypeService.GetTaskType - taskTypeId: " + viewModel.TaskTypeId + " "); 

                var existingTaskType = _taskTypeService.GetTaskType(viewModel.TaskTypeId);

                log.Debug("_taskTypeService.GetTaskType - " + TaskTypeDTO.FormatTaskTypeDTO(existingTaskType)); 

                if (existingTaskType != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingTaskType, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_taskTypeService.UpdateTaskType - " + TaskTypeDTO.FormatTaskTypeDTO(existingTaskType)); 

                    _taskTypeService.UpdateTaskType(existingTaskType);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingTaskType: null, TaskTypeId: " + viewModel.TaskTypeId); 
                }

                return existingTaskType;
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

    