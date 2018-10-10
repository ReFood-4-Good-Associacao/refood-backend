
// ################################################################
//                      Code generated with T4
// ################################################################

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Refood.Business.DTOs;

namespace Refood.Web.Services.ViewModels
{

    [JsonObject(MemberSerialization.OptIn)]
    public partial class TaskViewModel
    {
        public TaskViewModel() { }

        public TaskViewModel(TaskDTO t)
        {
            TaskId = t.TaskId;
            Name = t.Name;
            TaskTypeId = t.TaskTypeId;
            TaskDate = t.TaskDate;
            WeekDay = t.WeekDay;
            StartTime = t.StartTime;
            EndTime = t.EndTime;
            EstimatedDuration = t.EstimatedDuration;
            Description = t.Description;
            RequiresCar = t.RequiresCar;
            TeamLeaderId = t.TeamLeaderId;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public TaskViewModel(TaskDTO t, string editUrl)
        {
            TaskId = t.TaskId;
            Name = t.Name;
            TaskTypeId = t.TaskTypeId;
            TaskDate = t.TaskDate;
            WeekDay = t.WeekDay;
            StartTime = t.StartTime;
            EndTime = t.EndTime;
            EstimatedDuration = t.EstimatedDuration;
            Description = t.Description;
            RequiresCar = t.RequiresCar;
            TeamLeaderId = t.TeamLeaderId;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public TaskDTO UpdateDTO(TaskDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.TaskId = this.TaskId;
                dto.Name = this.Name;
                dto.TaskTypeId = this.TaskTypeId;
                dto.TaskDate = this.TaskDate;
                dto.WeekDay = this.WeekDay;
                dto.StartTime = this.StartTime;
                dto.EndTime = this.EndTime;
                dto.EstimatedDuration = this.EstimatedDuration;
                dto.Description = this.Description;
                dto.RequiresCar = this.RequiresCar;
                dto.TeamLeaderId = this.TeamLeaderId;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("taskTypeId")]
        public int? TaskTypeId { get; set; }

        [JsonProperty("taskDate")]
        public System.DateTime? TaskDate { get; set; }

        [JsonProperty("weekDay")]
        public int? WeekDay { get; set; }

        [JsonProperty("startTime")]
        public System.DateTime? StartTime { get; set; }

        [JsonProperty("endTime")]
        public System.DateTime? EndTime { get; set; }

        [JsonProperty("estimatedDuration")]
        public int? EstimatedDuration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requiresCar")]
        public bool? RequiresCar { get; set; }

        [JsonProperty("teamLeaderId")]
        public int? TeamLeaderId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("createBy")]
        public int? CreateBy { get; set; }

        [JsonProperty("createOn")]
        public System.DateTime? CreateOn { get; set; }

        [JsonProperty("updateBy")]
        public int? UpdateBy { get; set; }

        [JsonProperty("updateOn")]
        public System.DateTime? UpdateOn { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; }



        // logging helper
        public static string FormatTaskViewModel(TaskViewModel taskViewModel)
        {
            if (taskViewModel == null)
            {
                // null
                return "taskViewModel: null";
            }
            else
            {
                // output values
                return "taskViewModel: \n"
                    + "{ \n"
 
                    + "    TaskId: " +  "'" + taskViewModel.TaskId + "'"  + ", \n" 
                    + "    Name: " + (taskViewModel.Name != null ? "'" + taskViewModel.Name + "'" : "null") + ", \n" 
                    + "    TaskTypeId: " + (taskViewModel.TaskTypeId != null ? "'" + taskViewModel.TaskTypeId + "'" : "null") + ", \n" 
                    + "    TaskDate: " + (taskViewModel.TaskDate != null ? "'" + taskViewModel.TaskDate + "'" : "null") + ", \n" 
                    + "    WeekDay: " + (taskViewModel.WeekDay != null ? "'" + taskViewModel.WeekDay + "'" : "null") + ", \n" 
                    + "    StartTime: " + (taskViewModel.StartTime != null ? "'" + taskViewModel.StartTime + "'" : "null") + ", \n" 
                    + "    EndTime: " + (taskViewModel.EndTime != null ? "'" + taskViewModel.EndTime + "'" : "null") + ", \n" 
                    + "    EstimatedDuration: " + (taskViewModel.EstimatedDuration != null ? "'" + taskViewModel.EstimatedDuration + "'" : "null") + ", \n" 
                    + "    Description: " + (taskViewModel.Description != null ? "'" + taskViewModel.Description + "'" : "null") + ", \n" 
                    + "    RequiresCar: " + (taskViewModel.RequiresCar != null ? "'" + taskViewModel.RequiresCar + "'" : "null") + ", \n" 
                    + "    TeamLeaderId: " + (taskViewModel.TeamLeaderId != null ? "'" + taskViewModel.TeamLeaderId + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + taskViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + taskViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (taskViewModel.CreateBy != null ? "'" + taskViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (taskViewModel.CreateOn != null ? "'" + taskViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (taskViewModel.UpdateBy != null ? "'" + taskViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (taskViewModel.UpdateOn != null ? "'" + taskViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    