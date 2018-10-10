
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
    public partial class ContributionMonetaryReviewerViewModel
    {
        public ContributionMonetaryReviewerViewModel() { }

        public ContributionMonetaryReviewerViewModel(ContributionMonetaryReviewerDTO t)
        {
            ContributionMonetaryReviewerId = t.ContributionMonetaryReviewerId;
            VolunteerId = t.VolunteerId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ContributionMonetaryReviewerViewModel(ContributionMonetaryReviewerDTO t, string editUrl)
        {
            ContributionMonetaryReviewerId = t.ContributionMonetaryReviewerId;
            VolunteerId = t.VolunteerId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public ContributionMonetaryReviewerDTO UpdateDTO(ContributionMonetaryReviewerDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ContributionMonetaryReviewerId = this.ContributionMonetaryReviewerId;
                dto.VolunteerId = this.VolunteerId;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("contributionMonetaryReviewerId")]
        public int ContributionMonetaryReviewerId { get; set; }

        [JsonProperty("volunteerId")]
        public int? VolunteerId { get; set; }

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
        public static string FormatContributionMonetaryReviewerViewModel(ContributionMonetaryReviewerViewModel contributionMonetaryReviewerViewModel)
        {
            if (contributionMonetaryReviewerViewModel == null)
            {
                // null
                return "contributionMonetaryReviewerViewModel: null";
            }
            else
            {
                // output values
                return "contributionMonetaryReviewerViewModel: \n"
                    + "{ \n"
 
                    + "    ContributionMonetaryReviewerId: " +  "'" + contributionMonetaryReviewerViewModel.ContributionMonetaryReviewerId + "'"  + ", \n" 
                    + "    VolunteerId: " + (contributionMonetaryReviewerViewModel.VolunteerId != null ? "'" + contributionMonetaryReviewerViewModel.VolunteerId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionMonetaryReviewerViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionMonetaryReviewerViewModel.CreateBy != null ? "'" + contributionMonetaryReviewerViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionMonetaryReviewerViewModel.CreateOn != null ? "'" + contributionMonetaryReviewerViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionMonetaryReviewerViewModel.UpdateBy != null ? "'" + contributionMonetaryReviewerViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionMonetaryReviewerViewModel.UpdateOn != null ? "'" + contributionMonetaryReviewerViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    