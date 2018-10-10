
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
    public partial class ContributionChannelViewModel
    {
        public ContributionChannelViewModel() { }

        public ContributionChannelViewModel(ContributionChannelDTO t)
        {
            ContributionChannelId = t.ContributionChannelId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ContributionChannelViewModel(ContributionChannelDTO t, string editUrl)
        {
            ContributionChannelId = t.ContributionChannelId;
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

        public ContributionChannelDTO UpdateDTO(ContributionChannelDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ContributionChannelId = this.ContributionChannelId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("contributionChannelId")]
        public int ContributionChannelId { get; set; }

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
        public static string FormatContributionChannelViewModel(ContributionChannelViewModel contributionChannelViewModel)
        {
            if (contributionChannelViewModel == null)
            {
                // null
                return "contributionChannelViewModel: null";
            }
            else
            {
                // output values
                return "contributionChannelViewModel: \n"
                    + "{ \n"
 
                    + "    ContributionChannelId: " +  "'" + contributionChannelViewModel.ContributionChannelId + "'"  + ", \n" 
                    + "    Name: " + (contributionChannelViewModel.Name != null ? "'" + contributionChannelViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (contributionChannelViewModel.Description != null ? "'" + contributionChannelViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + contributionChannelViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionChannelViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionChannelViewModel.CreateBy != null ? "'" + contributionChannelViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionChannelViewModel.CreateOn != null ? "'" + contributionChannelViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionChannelViewModel.UpdateBy != null ? "'" + contributionChannelViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionChannelViewModel.UpdateOn != null ? "'" + contributionChannelViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    