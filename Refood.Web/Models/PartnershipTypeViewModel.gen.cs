
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
    public partial class PartnershipTypeViewModel
    {
        public PartnershipTypeViewModel() { }

        public PartnershipTypeViewModel(PartnershipTypeDTO t)
        {
            PartnershipTypeId = t.PartnershipTypeId;
            Name = t.Name;
            Description = t.Description;
            ActivityType = t.ActivityType;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public PartnershipTypeViewModel(PartnershipTypeDTO t, string editUrl)
        {
            PartnershipTypeId = t.PartnershipTypeId;
            Name = t.Name;
            Description = t.Description;
            ActivityType = t.ActivityType;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public PartnershipTypeDTO UpdateDTO(PartnershipTypeDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.PartnershipTypeId = this.PartnershipTypeId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.ActivityType = this.ActivityType;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("partnershipTypeId")]
        public int PartnershipTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("activityType")]
        public string ActivityType { get; set; }

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
        public static string FormatPartnershipTypeViewModel(PartnershipTypeViewModel partnershipTypeViewModel)
        {
            if (partnershipTypeViewModel == null)
            {
                // null
                return "partnershipTypeViewModel: null";
            }
            else
            {
                // output values
                return "partnershipTypeViewModel: \n"
                    + "{ \n"
 
                    + "    PartnershipTypeId: " +  "'" + partnershipTypeViewModel.PartnershipTypeId + "'"  + ", \n" 
                    + "    Name: " + (partnershipTypeViewModel.Name != null ? "'" + partnershipTypeViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (partnershipTypeViewModel.Description != null ? "'" + partnershipTypeViewModel.Description + "'" : "null") + ", \n" 
                    + "    ActivityType: " + (partnershipTypeViewModel.ActivityType != null ? "'" + partnershipTypeViewModel.ActivityType + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + partnershipTypeViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + partnershipTypeViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (partnershipTypeViewModel.CreateBy != null ? "'" + partnershipTypeViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (partnershipTypeViewModel.CreateOn != null ? "'" + partnershipTypeViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (partnershipTypeViewModel.UpdateBy != null ? "'" + partnershipTypeViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (partnershipTypeViewModel.UpdateOn != null ? "'" + partnershipTypeViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    