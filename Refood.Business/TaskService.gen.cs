
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class TaskService :  ITaskService
    {
        public static ITaskRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TaskService()
        {
            if (Repository == null)
            {
                Repository = new TaskRepository();
            }
        }

        public int AddTask(TaskDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(TaskDTO.FormatTaskDTO(dto)); 

                R_Task t = TaskDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddTask(t);
                dto.TaskId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteTask(TaskDTO dto)
        {
            try
            {
                log.Debug(TaskDTO.FormatTaskDTO(dto)); 
            
                R_Task t = TaskDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteTask(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteTask(int taskId)
        {
            try
            {
                log.Debug("taskId: " + taskId + " "); 

                // delete
                Repository.DeleteTask(taskId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public TaskDTO GetTask(int taskId)
        {
            try
            {
                //Requires.NotNegative("taskId", taskId);
                
                log.Debug("taskId: " + taskId + " "); 

                // get
                R_Task t = Repository.GetTask(taskId);

                TaskDTO dto = new TaskDTO(t);

                log.Debug(TaskDTO.FormatTaskDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<TaskDTO> GetTasks()
        {
            try
            {
                
                log.Debug("GetTasks"); 

                // get
                IEnumerable<R_Task> results = Repository.GetTasks();

                IEnumerable<TaskDTO> resultsDTO = results.Select(e => new TaskDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<TaskDTO> GetTasks(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Task> results = Repository.GetTasks(searchTerm, pageIndex, pageSize);
            
                IList<TaskDTO> resultsDTO = results.Select(e => new TaskDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<TaskDTO> GetTaskListAdvancedSearch(
             string name 
            , int? taskTypeId 
            , System.DateTime? taskDateFrom 
            , System.DateTime? taskDateTo 
            , int? weekDay 
            , System.DateTime? startTimeFrom 
            , System.DateTime? startTimeTo 
            , System.DateTime? endTimeFrom 
            , System.DateTime? endTimeTo 
            , int? estimatedDuration 
            , string description 
            , bool? requiresCar 
            , int? teamLeaderId 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetTaskListAdvancedSearch"); 

                IEnumerable<R_Task> results = Repository.GetTaskListAdvancedSearch(
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
            
                IEnumerable<TaskDTO> resultsDTO = results.Select(e => new TaskDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateTask(TaskDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "TaskId");

                log.Debug(TaskDTO.FormatTaskDTO(dto)); 

                R_Task t = TaskDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateTask(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    