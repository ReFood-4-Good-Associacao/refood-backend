
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
    public partial class TaskTypeViewModel
    {
        public TaskTypeViewModel() { }

        public TaskTypeViewModel(TaskTypeDTO t)
        {
            TaskTypeId = t.TaskTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public TaskTypeViewModel(TaskTypeDTO t, string editUrl)
        {
            TaskTypeId = t.TaskTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public TaskTypeDTO UpdateDTO(TaskTypeDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.TaskTypeId = this.TaskTypeId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("taskTypeId")]
        public int TaskTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

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
        public static string FormatTaskTypeViewModel(TaskTypeViewModel taskTypeViewModel)
        {
            if (taskTypeViewModel == null)
            {
                // null
                return "taskTypeViewModel: null";
            }
            else
            {
                // output values
                return "taskTypeViewModel: \n"
                    + "{ \n"
 
                    + "    TaskTypeId: " +  "'" + taskTypeViewModel.TaskTypeId + "'"  + ", \n" 
                    + "    Name: " + (taskTypeViewModel.Name != null ? "'" + taskTypeViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (taskTypeViewModel.Description != null ? "'" + taskTypeViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + taskTypeViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + taskTypeViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (taskTypeViewModel.CreateBy != null ? "'" + taskTypeViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (taskTypeViewModel.CreateOn != null ? "'" + taskTypeViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (taskTypeViewModel.UpdateBy != null ? "'" + taskTypeViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (taskTypeViewModel.UpdateOn != null ? "'" + taskTypeViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    