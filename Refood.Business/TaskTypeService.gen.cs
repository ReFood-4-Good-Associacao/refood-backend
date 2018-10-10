
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
    public partial class TaskTypeService :  ITaskTypeService
    {
        public static ITaskTypeRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TaskTypeService()
        {
            if (Repository == null)
            {
                Repository = new TaskTypeRepository();
            }
        }

        public int AddTaskType(TaskTypeDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(TaskTypeDTO.FormatTaskTypeDTO(dto)); 

                R_TaskType t = TaskTypeDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddTaskType(t);
                dto.TaskTypeId = id;

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

        public void DeleteTaskType(TaskTypeDTO dto)
        {
            try
            {
                log.Debug(TaskTypeDTO.FormatTaskTypeDTO(dto)); 
            
                R_TaskType t = TaskTypeDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteTaskType(t);
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

        public void DeleteTaskType(int taskTypeId)
        {
            try
            {
                log.Debug("taskTypeId: " + taskTypeId + " "); 

                // delete
                Repository.DeleteTaskType(taskTypeId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public TaskTypeDTO GetTaskType(int taskTypeId)
        {
            try
            {
                //Requires.NotNegative("taskTypeId", taskTypeId);
                
                log.Debug("taskTypeId: " + taskTypeId + " "); 

                // get
                R_TaskType t = Repository.GetTaskType(taskTypeId);

                TaskTypeDTO dto = new TaskTypeDTO(t);

                log.Debug(TaskTypeDTO.FormatTaskTypeDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<TaskTypeDTO> GetTaskTypes()
        {
            try
            {
                
                log.Debug("GetTaskTypes"); 

                // get
                IEnumerable<R_TaskType> results = Repository.GetTaskTypes();

                IEnumerable<TaskTypeDTO> resultsDTO = results.Select(e => new TaskTypeDTO(e));

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

        public IList<TaskTypeDTO> GetTaskTypes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_TaskType> results = Repository.GetTaskTypes(searchTerm, pageIndex, pageSize);
            
                IList<TaskTypeDTO> resultsDTO = results.Select(e => new TaskTypeDTO(e)).ToList();

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

        public IEnumerable<TaskTypeDTO> GetTaskTypeListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetTaskTypeListAdvancedSearch"); 

                IEnumerable<R_TaskType> results = Repository.GetTaskTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<TaskTypeDTO> resultsDTO = results.Select(e => new TaskTypeDTO(e));

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

        public void UpdateTaskType(TaskTypeDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "TaskTypeId");

                log.Debug(TaskTypeDTO.FormatTaskTypeDTO(dto)); 

                R_TaskType t = TaskTypeDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateTaskType(t);

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

    