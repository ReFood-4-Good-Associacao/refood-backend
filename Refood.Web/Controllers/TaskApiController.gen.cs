
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
    [RoutePrefix("api/TaskApi")]
    public partial class TaskApiController : ApiController
    {
        private readonly ITaskService _taskService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TaskApiController(ITaskService taskService)
        {
            this._taskService = taskService;
        }

        public TaskApiController() : this(new TaskService()) { }

        /// <summary>
        /// Delete Task by id
        /// </summary>
        /// <param name="id">Task id</param>
        /// <returns>true if the Task is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_taskService.DeleteTask - taskId: " + id + " "); 

                _taskService.DeleteTask(id);

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
        /// Get Task by id
        /// </summary>
        /// <param name="id">Task id</param>
        /// <returns>Task json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_taskService.GetTask - taskId: " + id + " "); 

                var task = new TaskViewModel(_taskService.GetTask(id));

                log.Debug("_taskService.GetTask - " + TaskViewModel.FormatTaskViewModel(task)); 

                log.Debug("result: 'success'"); 

                //return Json(task, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(task), "application/json");
                //return task;
                //return JsonConvert.SerializeObject(task);
                return Ok(task);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Tasks
        /// </summary>
        /// <returns>json list of Task view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<TaskViewModel> tasks;

                log.Debug("_taskService.GetTasks"); 

                // add edit url
                tasks = _taskService.GetTasks()
                        .Select(task => new TaskViewModel(task, GetEditUrl(task.TaskId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (tasks != null ? tasks.Count().ToString() : "null")); 

                //return Json(tasks, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(tasks), "application/json");
                //return JsonConvert.SerializeObject(tasks);
                return Ok(tasks);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Tasks
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Tasks</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<TaskViewModel> tasks;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_taskService.GetTasks - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                tasks = _taskService.GetTasks(searchTerm, pageIndex, pageSize)
                        .Select(task => new TaskViewModel(task, GetEditUrl(task.TaskId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (tasks != null ? tasks.Count().ToString() : "null")); 

                //return Json(tasks, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(tasks);
                return Ok(tasks);
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
            , int? taskTypeId = null 
            , System.DateTime? taskDateFrom = null 
            , System.DateTime? taskDateTo = null 
            , int? weekDay = null 
            , System.DateTime? startTimeFrom = null 
            , System.DateTime? startTimeTo = null 
            , System.DateTime? endTimeFrom = null 
            , System.DateTime? endTimeTo = null 
            , int? estimatedDuration = null 
            , string description = null 
            , bool? requiresCar = null 
            , int? teamLeaderId = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetTaskListAdvancedSearch"); 

                IEnumerable<TaskDTO> resultsDTO = _taskService.GetTaskListAdvancedSearch(
                     name 
                    , taskTypeId 
                    , taskDateFrom 
                    , taskDateTo 
                    , weekDay 
                    , startTimeFrom 
                    , startTimeTo 
                    , endTimeFrom 
                    , endTimeTo 
                    , estimatedDuration 
                    , description 
                    , requiresCar 
                    , teamLeaderId 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<TaskViewModel> taskList = resultsDTO.Select(task => new TaskViewModel(task, GetEditUrl(task.TaskId))).ToList();

                log.Debug("result: 'success', count: " + (taskList != null ? taskList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(taskList), "application/json");
                //return JsonConvert.SerializeObject(taskList);
                return Ok(taskList);
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
            string editUrl = Url.Content("~/Task/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Task, or creates a new Task if the Id is 0
        /// </summary>
        /// <param name="viewModel">Task data</param>
        /// <returns>Task id</returns>
        public IHttpActionResult Upsert(TaskViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.TaskId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.TaskId);
                return Ok(t.TaskId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.TaskId);
                //return JsonConvert.SerializeObject(t.TaskId);
                return Ok(t.TaskId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Task
        /// </summary>
        /// <param name="viewModels">Task view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(TaskViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(TaskViewModel viewModel in viewModels)
                    {
                        log.Debug(TaskViewModel.FormatTaskViewModel(viewModel)); 

                        if (viewModel.TaskId > 0)
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

        private TaskDTO Create(TaskViewModel viewModel)
        {
            try
            {
                log.Debug(TaskViewModel.FormatTaskViewModel(viewModel)); 

                TaskDTO task = new TaskDTO();

                // copy values
                viewModel.UpdateDTO(task, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                task.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                task.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_taskService.AddTask - " + TaskDTO.FormatTaskDTO(task)); 

                int id = _taskService.AddTask(task);

                task.TaskId = id;

                log.Debug("result: 'success', id: " + id); 

                return task;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private TaskDTO Update(TaskViewModel viewModel)
        {
            try
            {
                log.Debug(TaskViewModel.FormatTaskViewModel(viewModel)); 

                // get
                log.Debug("_taskService.GetTask - taskId: " + viewModel.TaskId + " "); 

                var existingTask = _taskService.GetTask(viewModel.TaskId);

                log.Debug("_taskService.GetTask - " + TaskDTO.FormatTaskDTO(existingTask)); 

                if (existingTask != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingTask, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_taskService.UpdateTask - " + TaskDTO.FormatTaskDTO(existingTask)); 

                    _taskService.UpdateTask(existingTask);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingTask: null, TaskId: " + viewModel.TaskId); 
                }

                return existingTask;
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

    