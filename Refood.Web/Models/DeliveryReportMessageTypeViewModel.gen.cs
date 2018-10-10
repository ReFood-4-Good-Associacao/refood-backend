
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
    public partial class DeliveryReportMessageTypeViewModel
    {
        public DeliveryReportMessageTypeViewModel() { }

        public DeliveryReportMessageTypeViewModel(DeliveryReportMessageTypeDTO t)
        {
            DeliveryReportMessageTypeId = t.DeliveryReportMessageTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public DeliveryReportMessageTypeViewModel(DeliveryReportMessageTypeDTO t, string editUrl)
        {
            DeliveryReportMessageTypeId = t.DeliveryReportMessageTypeId;
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

        public DeliveryReportMessageTypeDTO UpdateDTO(DeliveryReportMessageTypeDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.DeliveryReportMessageTypeId = this.DeliveryReportMessageTypeId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("deliveryReportMessageTypeId")]
        public int DeliveryReportMessageTypeId { get; set; }

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
        public static string FormatDeliveryReportMessageTypeViewModel(DeliveryReportMessageTypeViewModel deliveryReportMessageTypeViewModel)
        {
            if (deliveryReportMessageTypeViewModel == null)
            {
                // null
                return "deliveryReportMessageTypeViewModel: null";
            }
            else
            {
                // output values
                return "deliveryReportMessageTypeViewModel: \n"
                    + "{ \n"
 
                    + "    DeliveryReportMessageTypeId: " +  "'" + deliveryReportMessageTypeViewModel.DeliveryReportMessageTypeId + "'"  + ", \n" 
                    + "    Name: " + (deliveryReportMessageTypeViewModel.Name != null ? "'" + deliveryReportMessageTypeViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (deliveryReportMessageTypeViewModel.Description != null ? "'" + deliveryReportMessageTypeViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + deliveryReportMessageTypeViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + deliveryReportMessageTypeViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (deliveryReportMessageTypeViewModel.CreateBy != null ? "'" + deliveryReportMessageTypeViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (deliveryReportMessageTypeViewModel.CreateOn != null ? "'" + deliveryReportMessageTypeViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (deliveryReportMessageTypeViewModel.UpdateBy != null ? "'" + deliveryReportMessageTypeViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (deliveryReportMessageTypeViewModel.UpdateOn != null ? "'" + deliveryReportMessageTypeViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    