
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
    public partial class TeamViewModel
    {
        public TeamViewModel() { }

        public TeamViewModel(TeamDTO t)
        {
            TeamId = t.TeamId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public TeamViewModel(TeamDTO t, string editUrl)
        {
            TeamId = t.TeamId;
            NucleoId = t.NucleoId;
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

        public TeamDTO UpdateDTO(TeamDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.TeamId = this.TeamId;
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

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
        public static string FormatTeamViewModel(TeamViewModel teamViewModel)
        {
            if (teamViewModel == null)
            {
                // null
                return "teamViewModel: null";
            }
            else
            {
                // output values
                return "teamViewModel: \n"
                    + "{ \n"
 
                    + "    TeamId: " +  "'" + teamViewModel.TeamId + "'"  + ", \n" 
                    + "    NucleoId: " + (teamViewModel.NucleoId != null ? "'" + teamViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (teamViewModel.Name != null ? "'" + teamViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (teamViewModel.Description != null ? "'" + teamViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + teamViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + teamViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (teamViewModel.CreateBy != null ? "'" + teamViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (teamViewModel.CreateOn != null ? "'" + teamViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (teamViewModel.UpdateBy != null ? "'" + teamViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (teamViewModel.UpdateOn != null ? "'" + teamViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    