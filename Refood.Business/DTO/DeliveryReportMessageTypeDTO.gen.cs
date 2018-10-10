
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class DeliveryReportMessageTypeDTO
    {
        public int DeliveryReportMessageTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public DeliveryReportMessageTypeDTO()
        {
        
        }

        public DeliveryReportMessageTypeDTO(R_DeliveryReportMessageType deliveryReportMessageType)
        {
            DeliveryReportMessageTypeId = deliveryReportMessageType.DeliveryReportMessageTypeId;
            Name = deliveryReportMessageType.Name;
            Description = deliveryReportMessageType.Description;
            Active = deliveryReportMessageType.Active;
            IsDeleted = deliveryReportMessageType.IsDeleted;
            CreateBy = deliveryReportMessageType.CreateBy;
            CreateOn = deliveryReportMessageType.CreateOn;
            UpdateBy = deliveryReportMessageType.UpdateBy;
            UpdateOn = deliveryReportMessageType.UpdateOn;
        }

        public static R_DeliveryReportMessageType ConvertDTOtoEntity(DeliveryReportMessageTypeDTO dto)
        {
            R_DeliveryReportMessageType deliveryReportMessageType = new R_DeliveryReportMessageType();

            deliveryReportMessageType.DeliveryReportMessageTypeId = dto.DeliveryReportMessageTypeId;
            deliveryReportMessageType.Name = dto.Name;
            deliveryReportMessageType.Description = dto.Description;
            deliveryReportMessageType.Active = dto.Active;
            deliveryReportMessageType.IsDeleted = dto.IsDeleted;
            deliveryReportMessageType.CreateBy = dto.CreateBy;
            deliveryReportMessageType.CreateOn = dto.CreateOn;
            deliveryReportMessageType.UpdateBy = dto.UpdateBy;
            deliveryReportMessageType.UpdateOn = dto.UpdateOn;

            return deliveryReportMessageType;
        }

        // logging helper
        public static string FormatDeliveryReportMessageTypeDTO(DeliveryReportMessageTypeDTO deliveryReportMessageTypeDTO)
        {
            if(deliveryReportMessageTypeDTO == null)
            {
                // null
                return "deliveryReportMessageTypeDTO: null";
            }
            else
            {
                // output values
                return "deliveryReportMessageTypeDTO: \n"
                    + "{ \n"
 
                    + "    DeliveryReportMessageTypeId: " +  "'" + deliveryReportMessageTypeDTO.DeliveryReportMessageTypeId + "'"  + ", \n" 
                    + "    Name: " + (deliveryReportMessageTypeDTO.Name != null ? "'" + deliveryReportMessageTypeDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (deliveryReportMessageTypeDTO.Description != null ? "'" + deliveryReportMessageTypeDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + deliveryReportMessageTypeDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + deliveryReportMessageTypeDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (deliveryReportMessageTypeDTO.CreateBy != null ? "'" + deliveryReportMessageTypeDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (deliveryReportMessageTypeDTO.CreateOn != null ? "'" + deliveryReportMessageTypeDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (deliveryReportMessageTypeDTO.UpdateBy != null ? "'" + deliveryReportMessageTypeDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (deliveryReportMessageTypeDTO.UpdateOn != null ? "'" + deliveryReportMessageTypeDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    