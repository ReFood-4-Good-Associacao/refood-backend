
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
    public partial class ProjectPartnerViewModel
    {
        public ProjectPartnerViewModel() { }

        public ProjectPartnerViewModel(ProjectPartnerDTO t)
        {
            ProjectPartnerId = t.ProjectPartnerId;
            ProjectId = t.ProjectId;
            PartnerId = t.PartnerId;
            GrantValue = t.GrantValue;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ProjectPartnerViewModel(ProjectPartnerDTO t, string editUrl)
        {
            ProjectPartnerId = t.ProjectPartnerId;
            ProjectId = t.ProjectId;
            PartnerId = t.PartnerId;
            GrantValue = t.GrantValue;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public ProjectPartnerDTO UpdateDTO(ProjectPartnerDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ProjectPartnerId = this.ProjectPartnerId;
                dto.ProjectId = this.ProjectId;
                dto.PartnerId = this.PartnerId;
                dto.GrantValue = this.GrantValue;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("projectPartnerId")]
        public int ProjectPartnerId { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("partnerId")]
        public int PartnerId { get; set; }

        [JsonProperty("grantValue")]
        public double? GrantValue { get; set; }

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
        public static string FormatProjectPartnerViewModel(ProjectPartnerViewModel projectPartnerViewModel)
        {
            if (projectPartnerViewModel == null)
            {
                // null
                return "projectPartnerViewModel: null";
            }
            else
            {
                // output values
                return "projectPartnerViewModel: \n"
                    + "{ \n"
 
                    + "    ProjectPartnerId: " +  "'" + projectPartnerViewModel.ProjectPartnerId + "'"  + ", \n" 
                    + "    ProjectId: " +  "'" + projectPartnerViewModel.ProjectId + "'"  + ", \n" 
                    + "    PartnerId: " +  "'" + projectPartnerViewModel.PartnerId + "'"  + ", \n" 
                    + "    GrantValue: " + (projectPartnerViewModel.GrantValue != null ? "'" + projectPartnerViewModel.GrantValue + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + projectPartnerViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (projectPartnerViewModel.CreateBy != null ? "'" + projectPartnerViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (projectPartnerViewModel.CreateOn != null ? "'" + projectPartnerViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (projectPartnerViewModel.UpdateBy != null ? "'" + projectPartnerViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (projectPartnerViewModel.UpdateOn != null ? "'" + projectPartnerViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    