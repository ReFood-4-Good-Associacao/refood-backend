
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class TaskDTO
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public int? TaskTypeId { get; set; }
        public System.DateTime? TaskDate { get; set; }
        public int? WeekDay { get; set; }
        public System.DateTime? StartTime { get; set; }
        public System.DateTime? EndTime { get; set; }
        public int? EstimatedDuration { get; set; }
        public string Description { get; set; }
        public bool? RequiresCar { get; set; }
        public int? TeamLeaderId { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public TaskDTO()
        {
        
        }

        public TaskDTO(R_Task task)
        {
            TaskId = task.TaskId;
            Name = task.Name;
            TaskTypeId = task.TaskTypeId;
            TaskDate = task.TaskDate;
            WeekDay = task.WeekDay;
            StartTime = task.StartTime;
            EndTime = task.EndTime;
            EstimatedDuration = task.EstimatedDuration;
            Description = task.Description;
            RequiresCar = task.RequiresCar;
            TeamLeaderId = task.TeamLeaderId;
            Active = task.Active;
            IsDeleted = task.IsDeleted;
            CreateBy = task.CreateBy;
            CreateOn = task.CreateOn;
            UpdateBy = task.UpdateBy;
            UpdateOn = task.UpdateOn;
        }

        public static R_Task ConvertDTOtoEntity(TaskDTO dto)
        {
            R_Task task = new R_Task();

            task.TaskId = dto.TaskId;
            task.Name = dto.Name;
            task.TaskTypeId = dto.TaskTypeId;
            task.TaskDate = dto.TaskDate;
            task.WeekDay = dto.WeekDay;
            task.StartTime = dto.StartTime;
            task.EndTime = dto.EndTime;
            task.EstimatedDuration = dto.EstimatedDuration;
            task.Description = dto.Description;
            task.RequiresCar = dto.RequiresCar;
            task.TeamLeaderId = dto.TeamLeaderId;
            task.Active = dto.Active;
            task.IsDeleted = dto.IsDeleted;
            task.CreateBy = dto.CreateBy;
            task.CreateOn = dto.CreateOn;
            task.UpdateBy = dto.UpdateBy;
            task.UpdateOn = dto.UpdateOn;

            return task;
        }

        // logging helper
        public static string FormatTaskDTO(TaskDTO taskDTO)
        {
            if(taskDTO == null)
            {
                // null
                return "taskDTO: null";
            }
            else
            {
                // output values
                return "taskDTO: \n"
                    + "{ \n"
 
                    + "    TaskId: " +  "'" + taskDTO.TaskId + "'"  + ", \n" 
                    + "    Name: " + (taskDTO.Name != null ? "'" + taskDTO.Name + "'" : "null") + ", \n" 
                    + "    TaskTypeId: " + (taskDTO.TaskTypeId != null ? "'" + taskDTO.TaskTypeId + "'" : "null") + ", \n" 
                    + "    TaskDate: " + (taskDTO.TaskDate != null ? "'" + taskDTO.TaskDate + "'" : "null") + ", \n" 
                    + "    WeekDay: " + (taskDTO.WeekDay != null ? "'" + taskDTO.WeekDay + "'" : "null") + ", \n" 
                    + "    StartTime: " + (taskDTO.StartTime != null ? "'" + taskDTO.StartTime + "'" : "null") + ", \n" 
                    + "    EndTime: " + (taskDTO.EndTime != null ? "'" + taskDTO.EndTime + "'" : "null") + ", \n" 
                    + "    EstimatedDuration: " + (taskDTO.EstimatedDuration != null ? "'" + taskDTO.EstimatedDuration + "'" : "null") + ", \n" 
                    + "    Description: " + (taskDTO.Description != null ? "'" + taskDTO.Description + "'" : "null") + ", \n" 
                    + "    RequiresCar: " + (taskDTO.RequiresCar != null ? "'" + taskDTO.RequiresCar + "'" : "null") + ", \n" 
                    + "    TeamLeaderId: " + (taskDTO.TeamLeaderId != null ? "'" + taskDTO.TeamLeaderId + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + taskDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + taskDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (taskDTO.CreateBy != null ? "'" + taskDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (taskDTO.CreateOn != null ? "'" + taskDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (taskDTO.UpdateBy != null ? "'" + taskDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (taskDTO.UpdateOn != null ? "'" + taskDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    