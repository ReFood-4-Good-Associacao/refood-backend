
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class DeliveryReportDTO
    {
        public int DeliveryReportId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime? ReportDate { get; set; }
        public string WeekDay { get; set; }
        public bool Submitted { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public DeliveryReportDTO()
        {
        
        }

        public DeliveryReportDTO(R_DeliveryReport deliveryReport)
        {
            DeliveryReportId = deliveryReport.DeliveryReportId;
            Name = deliveryReport.Name;
            Description = deliveryReport.Description;
            ReportDate = deliveryReport.ReportDate;
            WeekDay = deliveryReport.WeekDay;
            Submitted = deliveryReport.Submitted;
            IsDeleted = deliveryReport.IsDeleted;
            CreateBy = deliveryReport.CreateBy;
            CreateOn = deliveryReport.CreateOn;
            UpdateBy = deliveryReport.UpdateBy;
            UpdateOn = deliveryReport.UpdateOn;
        }

        public static R_DeliveryReport ConvertDTOtoEntity(DeliveryReportDTO dto)
        {
            R_DeliveryReport deliveryReport = new R_DeliveryReport();

            deliveryReport.DeliveryReportId = dto.DeliveryReportId;
            deliveryReport.Name = dto.Name;
            deliveryReport.Description = dto.Description;
            deliveryReport.ReportDate = dto.ReportDate;
            deliveryReport.WeekDay = dto.WeekDay;
            deliveryReport.Submitted = dto.Submitted;
            deliveryReport.IsDeleted = dto.IsDeleted;
            deliveryReport.CreateBy = dto.CreateBy;
            deliveryReport.CreateOn = dto.CreateOn;
            deliveryReport.UpdateBy = dto.UpdateBy;
            deliveryReport.UpdateOn = dto.UpdateOn;

            return deliveryReport;
        }

        // logging helper
        public static string FormatDeliveryReportDTO(DeliveryReportDTO deliveryReportDTO)
        {
            if(deliveryReportDTO == null)
            {
                // null
                return "deliveryReportDTO: null";
            }
            else
            {
                // output values
                return "deliveryReportDTO: \n"
                    + "{ \n"
 
                    + "    DeliveryReportId: " +  "'" + deliveryReportDTO.DeliveryReportId + "'"  + ", \n" 
                    + "    Name: " + (deliveryReportDTO.Name != null ? "'" + deliveryReportDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (deliveryReportDTO.Description != null ? "'" + deliveryReportDTO.Description + "'" : "null") + ", \n" 
                    + "    ReportDate: " + (deliveryReportDTO.ReportDate != null ? "'" + deliveryReportDTO.ReportDate + "'" : "null") + ", \n" 
                    + "    WeekDay: " + (deliveryReportDTO.WeekDay != null ? "'" + deliveryReportDTO.WeekDay + "'" : "null") + ", \n" 
                    + "    Submitted: " +  "'" + deliveryReportDTO.Submitted + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + deliveryReportDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (deliveryReportDTO.CreateBy != null ? "'" + deliveryReportDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (deliveryReportDTO.CreateOn != null ? "'" + deliveryReportDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (deliveryReportDTO.UpdateBy != null ? "'" + deliveryReportDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (deliveryReportDTO.UpdateOn != null ? "'" + deliveryReportDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    