
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class TaskTypeDTO
    {
        public int TaskTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public TaskTypeDTO()
        {
        
        }

        public TaskTypeDTO(R_TaskType taskType)
        {
            TaskTypeId = taskType.TaskTypeId;
            Name = taskType.Name;
            Description = taskType.Description;
            Active = taskType.Active;
            IsDeleted = taskType.IsDeleted;
            CreateBy = taskType.CreateBy;
            CreateOn = taskType.CreateOn;
            UpdateBy = taskType.UpdateBy;
            UpdateOn = taskType.UpdateOn;
        }

        public static R_TaskType ConvertDTOtoEntity(TaskTypeDTO dto)
        {
            R_TaskType taskType = new R_TaskType();

            taskType.TaskTypeId = dto.TaskTypeId;
            taskType.Name = dto.Name;
            taskType.Description = dto.Description;
            taskType.Active = dto.Active;
            taskType.IsDeleted = dto.IsDeleted;
            taskType.CreateBy = dto.CreateBy;
            taskType.CreateOn = dto.CreateOn;
            taskType.UpdateBy = dto.UpdateBy;
            taskType.UpdateOn = dto.UpdateOn;

            return taskType;
        }

        // logging helper
        public static string FormatTaskTypeDTO(TaskTypeDTO taskTypeDTO)
        {
            if(taskTypeDTO == null)
            {
                // null
                return "taskTypeDTO: null";
            }
            else
            {
                // output values
                return "taskTypeDTO: \n"
                    + "{ \n"
 
                    + "    TaskTypeId: " +  "'" + taskTypeDTO.TaskTypeId + "'"  + ", \n" 
                    + "    Name: " + (taskTypeDTO.Name != null ? "'" + taskTypeDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (taskTypeDTO.Description != null ? "'" + taskTypeDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + taskTypeDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + taskTypeDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (taskTypeDTO.CreateBy != null ? "'" + taskTypeDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (taskTypeDTO.CreateOn != null ? "'" + taskTypeDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (taskTypeDTO.UpdateBy != null ? "'" + taskTypeDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (taskTypeDTO.UpdateOn != null ? "'" + taskTypeDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    