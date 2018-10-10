
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
    public partial class TutorialViewModel
    {
        public TutorialViewModel() { }

        public TutorialViewModel(TutorialDTO t)
        {
            TutorialId = t.TutorialId;
            Name = t.Name;
            Description = t.Description;
            Location = t.Location;
            IsOnlineTutorial = t.IsOnlineTutorial;
            Language = t.Language;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public TutorialViewModel(TutorialDTO t, string editUrl)
        {
            TutorialId = t.TutorialId;
            Name = t.Name;
            Description = t.Description;
            Location = t.Location;
            IsOnlineTutorial = t.IsOnlineTutorial;
            Language = t.Language;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public TutorialDTO UpdateDTO(TutorialDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.TutorialId = this.TutorialId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Location = this.Location;
                dto.IsOnlineTutorial = this.IsOnlineTutorial;
                dto.Language = this.Language;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("tutorialId")]
        public int TutorialId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("isOnlineTutorial")]
        public bool IsOnlineTutorial { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

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
        public static string FormatTutorialViewModel(TutorialViewModel tutorialViewModel)
        {
            if (tutorialViewModel == null)
            {
                // null
                return "tutorialViewModel: null";
            }
            else
            {
                // output values
                return "tutorialViewModel: \n"
                    + "{ \n"
 
                    + "    TutorialId: " +  "'" + tutorialViewModel.TutorialId + "'"  + ", \n" 
                    + "    Name: " + (tutorialViewModel.Name != null ? "'" + tutorialViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (tutorialViewModel.Description != null ? "'" + tutorialViewModel.Description + "'" : "null") + ", \n" 
                    + "    Location: " + (tutorialViewModel.Location != null ? "'" + tutorialViewModel.Location + "'" : "null") + ", \n" 
                    + "    IsOnlineTutorial: " +  "'" + tutorialViewModel.IsOnlineTutorial + "'"  + ", \n" 
                    + "    Language: " + (tutorialViewModel.Language != null ? "'" + tutorialViewModel.Language + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + tutorialViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + tutorialViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (tutorialViewModel.CreateBy != null ? "'" + tutorialViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (tutorialViewModel.CreateOn != null ? "'" + tutorialViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (tutorialViewModel.UpdateBy != null ? "'" + tutorialViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (tutorialViewModel.UpdateOn != null ? "'" + tutorialViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    