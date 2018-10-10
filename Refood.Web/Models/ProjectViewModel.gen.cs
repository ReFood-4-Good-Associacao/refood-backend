
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
    public partial class ProjectViewModel
    {
        public ProjectViewModel() { }

        public ProjectViewModel(ProjectDTO t)
        {
            ProjectId = t.ProjectId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            DeadlineCall = t.DeadlineCall;
            Budget = t.Budget;
            Funding = t.Funding;
            StartDate = t.StartDate;
            EndDate = t.EndDate;
            AreaOfInterest = t.AreaOfInterest;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ProjectViewModel(ProjectDTO t, string editUrl)
        {
            ProjectId = t.ProjectId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            DeadlineCall = t.DeadlineCall;
            Budget = t.Budget;
            Funding = t.Funding;
            StartDate = t.StartDate;
            EndDate = t.EndDate;
            AreaOfInterest = t.AreaOfInterest;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public ProjectDTO UpdateDTO(ProjectDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ProjectId = this.ProjectId;
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.DeadlineCall = this.DeadlineCall;
                dto.Budget = this.Budget;
                dto.Funding = this.Funding;
                dto.StartDate = this.StartDate;
                dto.EndDate = this.EndDate;
                dto.AreaOfInterest = this.AreaOfInterest;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("deadlineCall")]
        public string DeadlineCall { get; set; }

        [JsonProperty("budget")]
        public double? Budget { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("startDate")]
        public System.DateTime? StartDate { get; set; }

        [JsonProperty("endDate")]
        public System.DateTime? EndDate { get; set; }

        [JsonProperty("areaOfInterest")]
        public string AreaOfInterest { get; set; }

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
        public static string FormatProjectViewModel(ProjectViewModel projectViewModel)
        {
            if (projectViewModel == null)
            {
                // null
                return "projectViewModel: null";
            }
            else
            {
                // output values
                return "projectViewModel: \n"
                    + "{ \n"
 
                    + "    ProjectId: " +  "'" + projectViewModel.ProjectId + "'"  + ", \n" 
                    + "    NucleoId: " + (projectViewModel.NucleoId != null ? "'" + projectViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (projectViewModel.Name != null ? "'" + projectViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (projectViewModel.Description != null ? "'" + projectViewModel.Description + "'" : "null") + ", \n" 
                    + "    DeadlineCall: " + (projectViewModel.DeadlineCall != null ? "'" + projectViewModel.DeadlineCall + "'" : "null") + ", \n" 
                    + "    Budget: " + (projectViewModel.Budget != null ? "'" + projectViewModel.Budget + "'" : "null") + ", \n" 
                    + "    Funding: " + (projectViewModel.Funding != null ? "'" + projectViewModel.Funding + "'" : "null") + ", \n" 
                    + "    StartDate: " + (projectViewModel.StartDate != null ? "'" + projectViewModel.StartDate + "'" : "null") + ", \n" 
                    + "    EndDate: " + (projectViewModel.EndDate != null ? "'" + projectViewModel.EndDate + "'" : "null") + ", \n" 
                    + "    AreaOfInterest: " + (projectViewModel.AreaOfInterest != null ? "'" + projectViewModel.AreaOfInterest + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + projectViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + projectViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (projectViewModel.CreateBy != null ? "'" + projectViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (projectViewModel.CreateOn != null ? "'" + projectViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (projectViewModel.UpdateBy != null ? "'" + projectViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (projectViewModel.UpdateOn != null ? "'" + projectViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    