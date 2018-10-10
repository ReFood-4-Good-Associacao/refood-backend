
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
    public partial class DeliveryReportViewModel
    {
        public DeliveryReportViewModel() { }

        public DeliveryReportViewModel(DeliveryReportDTO t)
        {
            DeliveryReportId = t.DeliveryReportId;
            Name = t.Name;
            Description = t.Description;
            ReportDate = t.ReportDate;
            WeekDay = t.WeekDay;
            Submitted = t.Submitted;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public DeliveryReportViewModel(DeliveryReportDTO t, string editUrl)
        {
            DeliveryReportId = t.DeliveryReportId;
            Name = t.Name;
            Description = t.Description;
            ReportDate = t.ReportDate;
            WeekDay = t.WeekDay;
            Submitted = t.Submitted;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public DeliveryReportDTO UpdateDTO(DeliveryReportDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.DeliveryReportId = this.DeliveryReportId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.ReportDate = this.ReportDate;
                dto.WeekDay = this.WeekDay;
                dto.Submitted = this.Submitted;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("deliveryReportId")]
        public int DeliveryReportId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("reportDate")]
        public System.DateTime? ReportDate { get; set; }

        [JsonProperty("weekDay")]
        public string WeekDay { get; set; }

        [JsonProperty("submitted")]
        public bool Submitted { get; set; }

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
        public static string FormatDeliveryReportViewModel(DeliveryReportViewModel deliveryReportViewModel)
        {
            if (deliveryReportViewModel == null)
            {
                // null
                return "deliveryReportViewModel: null";
            }
            else
            {
                // output values
                return "deliveryReportViewModel: \n"
                    + "{ \n"
 
                    + "    DeliveryReportId: " +  "'" + deliveryReportViewModel.DeliveryReportId + "'"  + ", \n" 
                    + "    Name: " + (deliveryReportViewModel.Name != null ? "'" + deliveryReportViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (deliveryReportViewModel.Description != null ? "'" + deliveryReportViewModel.Description + "'" : "null") + ", \n" 
                    + "    ReportDate: " + (deliveryReportViewModel.ReportDate != null ? "'" + deliveryReportViewModel.ReportDate + "'" : "null") + ", \n" 
                    + "    WeekDay: " + (deliveryReportViewModel.WeekDay != null ? "'" + deliveryReportViewModel.WeekDay + "'" : "null") + ", \n" 
                    + "    Submitted: " +  "'" + deliveryReportViewModel.Submitted + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + deliveryReportViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (deliveryReportViewModel.CreateBy != null ? "'" + deliveryReportViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (deliveryReportViewModel.CreateOn != null ? "'" + deliveryReportViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (deliveryReportViewModel.UpdateBy != null ? "'" + deliveryReportViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (deliveryReportViewModel.UpdateOn != null ? "'" + deliveryReportViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    