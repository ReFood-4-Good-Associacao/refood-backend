
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
    public partial class ExperimentalPhaseLogViewModel
    {
        public ExperimentalPhaseLogViewModel() { }

        public ExperimentalPhaseLogViewModel(ExperimentalPhaseLogDTO t)
        {
            ExperimentalPhaseLogId = t.ExperimentalPhaseLogId;
            NucleoId = t.NucleoId;
            LogDate = t.LogDate;
            Task = t.Task;
            ActivityDescription = t.ActivityDescription;
            ManagerName = t.ManagerName;
            VolunteerName = t.VolunteerName;
            VolunteerConfirmation = t.VolunteerConfirmation;
            DocumentId = t.DocumentId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ExperimentalPhaseLogViewModel(ExperimentalPhaseLogDTO t, string editUrl)
        {
            ExperimentalPhaseLogId = t.ExperimentalPhaseLogId;
            NucleoId = t.NucleoId;
            LogDate = t.LogDate;
            Task = t.Task;
            ActivityDescription = t.ActivityDescription;
            ManagerName = t.ManagerName;
            VolunteerName = t.VolunteerName;
            VolunteerConfirmation = t.VolunteerConfirmation;
            DocumentId = t.DocumentId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public ExperimentalPhaseLogDTO UpdateDTO(ExperimentalPhaseLogDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ExperimentalPhaseLogId = this.ExperimentalPhaseLogId;
                dto.NucleoId = this.NucleoId;
                dto.LogDate = this.LogDate;
                dto.Task = this.Task;
                dto.ActivityDescription = this.ActivityDescription;
                dto.ManagerName = this.ManagerName;
                dto.VolunteerName = this.VolunteerName;
                dto.VolunteerConfirmation = this.VolunteerConfirmation;
                dto.DocumentId = this.DocumentId;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("experimentalPhaseLogId")]
        public int ExperimentalPhaseLogId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("logDate")]
        public System.DateTime LogDate { get; set; }

        [JsonProperty("task")]
        public string Task { get; set; }

        [JsonProperty("activityDescription")]
        public string ActivityDescription { get; set; }

        [JsonProperty("managerName")]
        public string ManagerName { get; set; }

        [JsonProperty("volunteerName")]
        public string VolunteerName { get; set; }

        [JsonProperty("volunteerConfirmation")]
        public bool VolunteerConfirmation { get; set; }

        [JsonProperty("documentId")]
        public int? DocumentId { get; set; }

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
        public static string FormatExperimentalPhaseLogViewModel(ExperimentalPhaseLogViewModel experimentalPhaseLogViewModel)
        {
            if (experimentalPhaseLogViewModel == null)
            {
                // null
                return "experimentalPhaseLogViewModel: null";
            }
            else
            {
                // output values
                return "experimentalPhaseLogViewModel: \n"
                    + "{ \n"
 
                    + "    ExperimentalPhaseLogId: " +  "'" + experimentalPhaseLogViewModel.ExperimentalPhaseLogId + "'"  + ", \n" 
                    + "    NucleoId: " + (experimentalPhaseLogViewModel.NucleoId != null ? "'" + experimentalPhaseLogViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    LogDate: " +  "'" + experimentalPhaseLogViewModel.LogDate + "'"  + ", \n" 
                    + "    Task: " + (experimentalPhaseLogViewModel.Task != null ? "'" + experimentalPhaseLogViewModel.Task + "'" : "null") + ", \n" 
                    + "    ActivityDescription: " + (experimentalPhaseLogViewModel.ActivityDescription != null ? "'" + experimentalPhaseLogViewModel.ActivityDescription + "'" : "null") + ", \n" 
                    + "    ManagerName: " + (experimentalPhaseLogViewModel.ManagerName != null ? "'" + experimentalPhaseLogViewModel.ManagerName + "'" : "null") + ", \n" 
                    + "    VolunteerName: " + (experimentalPhaseLogViewModel.VolunteerName != null ? "'" + experimentalPhaseLogViewModel.VolunteerName + "'" : "null") + ", \n" 
                    + "    VolunteerConfirmation: " +  "'" + experimentalPhaseLogViewModel.VolunteerConfirmation + "'"  + ", \n" 
                    + "    DocumentId: " + (experimentalPhaseLogViewModel.DocumentId != null ? "'" + experimentalPhaseLogViewModel.DocumentId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + experimentalPhaseLogViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (experimentalPhaseLogViewModel.CreateBy != null ? "'" + experimentalPhaseLogViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (experimentalPhaseLogViewModel.CreateOn != null ? "'" + experimentalPhaseLogViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (experimentalPhaseLogViewModel.UpdateBy != null ? "'" + experimentalPhaseLogViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (experimentalPhaseLogViewModel.UpdateOn != null ? "'" + experimentalPhaseLogViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    