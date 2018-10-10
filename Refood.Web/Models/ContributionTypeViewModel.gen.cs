
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
    public partial class ContributionTypeViewModel
    {
        public ContributionTypeViewModel() { }

        public ContributionTypeViewModel(ContributionTypeDTO t)
        {
            ContributionTypeId = t.ContributionTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ContributionTypeViewModel(ContributionTypeDTO t, string editUrl)
        {
            ContributionTypeId = t.ContributionTypeId;
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

        public ContributionTypeDTO UpdateDTO(ContributionTypeDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ContributionTypeId = this.ContributionTypeId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("contributionTypeId")]
        public int ContributionTypeId { get; set; }

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
        public static string FormatContributionTypeViewModel(ContributionTypeViewModel contributionTypeViewModel)
        {
            if (contributionTypeViewModel == null)
            {
                // null
                return "contributionTypeViewModel: null";
            }
            else
            {
                // output values
                return "contributionTypeViewModel: \n"
                    + "{ \n"
 
                    + "    ContributionTypeId: " +  "'" + contributionTypeViewModel.ContributionTypeId + "'"  + ", \n" 
                    + "    Name: " + (contributionTypeViewModel.Name != null ? "'" + contributionTypeViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (contributionTypeViewModel.Description != null ? "'" + contributionTypeViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + contributionTypeViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionTypeViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionTypeViewModel.CreateBy != null ? "'" + contributionTypeViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionTypeViewModel.CreateOn != null ? "'" + contributionTypeViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionTypeViewModel.UpdateBy != null ? "'" + contributionTypeViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionTypeViewModel.UpdateOn != null ? "'" + contributionTypeViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    