
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
    public partial class DeliveryReportMessageViewModel
    {
        public DeliveryReportMessageViewModel() { }

        public DeliveryReportMessageViewModel(DeliveryReportMessageDTO t)
        {
            DeliveryReportMessageId = t.DeliveryReportMessageId;
            DeliveryReportMessageTypeId = t.DeliveryReportMessageTypeId;
            Message = t.Message;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public DeliveryReportMessageViewModel(DeliveryReportMessageDTO t, string editUrl)
        {
            DeliveryReportMessageId = t.DeliveryReportMessageId;
            DeliveryReportMessageTypeId = t.DeliveryReportMessageTypeId;
            Message = t.Message;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public DeliveryReportMessageDTO UpdateDTO(DeliveryReportMessageDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.DeliveryReportMessageId = this.DeliveryReportMessageId;
                dto.DeliveryReportMessageTypeId = this.DeliveryReportMessageTypeId;
                dto.Message = this.Message;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("deliveryReportMessageId")]
        public int DeliveryReportMessageId { get; set; }

        [JsonProperty("deliveryReportMessageTypeId")]
        public int DeliveryReportMessageTypeId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

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
        public static string FormatDeliveryReportMessageViewModel(DeliveryReportMessageViewModel deliveryReportMessageViewModel)
        {
            if (deliveryReportMessageViewModel == null)
            {
                // null
                return "deliveryReportMessageViewModel: null";
            }
            else
            {
                // output values
                return "deliveryReportMessageViewModel: \n"
                    + "{ \n"
 
                    + "    DeliveryReportMessageId: " +  "'" + deliveryReportMessageViewModel.DeliveryReportMessageId + "'"  + ", \n" 
                    + "    DeliveryReportMessageTypeId: " +  "'" + deliveryReportMessageViewModel.DeliveryReportMessageTypeId + "'"  + ", \n" 
                    + "    Message: " + (deliveryReportMessageViewModel.Message != null ? "'" + deliveryReportMessageViewModel.Message + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + deliveryReportMessageViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (deliveryReportMessageViewModel.CreateBy != null ? "'" + deliveryReportMessageViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (deliveryReportMessageViewModel.CreateOn != null ? "'" + deliveryReportMessageViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (deliveryReportMessageViewModel.UpdateBy != null ? "'" + deliveryReportMessageViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (deliveryReportMessageViewModel.UpdateOn != null ? "'" + deliveryReportMessageViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    