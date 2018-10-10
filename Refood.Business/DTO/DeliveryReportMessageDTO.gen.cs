
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class DeliveryReportMessageDTO
    {
        public int DeliveryReportMessageId { get; set; }
        public int DeliveryReportMessageTypeId { get; set; }
        public string Message { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public DeliveryReportMessageDTO()
        {
        
        }

        public DeliveryReportMessageDTO(R_DeliveryReportMessage deliveryReportMessage)
        {
            DeliveryReportMessageId = deliveryReportMessage.DeliveryReportMessageId;
            DeliveryReportMessageTypeId = deliveryReportMessage.DeliveryReportMessageTypeId;
            Message = deliveryReportMessage.Message;
            IsDeleted = deliveryReportMessage.IsDeleted;
            CreateBy = deliveryReportMessage.CreateBy;
            CreateOn = deliveryReportMessage.CreateOn;
            UpdateBy = deliveryReportMessage.UpdateBy;
            UpdateOn = deliveryReportMessage.UpdateOn;
        }

        public static R_DeliveryReportMessage ConvertDTOtoEntity(DeliveryReportMessageDTO dto)
        {
            R_DeliveryReportMessage deliveryReportMessage = new R_DeliveryReportMessage();

            deliveryReportMessage.DeliveryReportMessageId = dto.DeliveryReportMessageId;
            deliveryReportMessage.DeliveryReportMessageTypeId = dto.DeliveryReportMessageTypeId;
            deliveryReportMessage.Message = dto.Message;
            deliveryReportMessage.IsDeleted = dto.IsDeleted;
            deliveryReportMessage.CreateBy = dto.CreateBy;
            deliveryReportMessage.CreateOn = dto.CreateOn;
            deliveryReportMessage.UpdateBy = dto.UpdateBy;
            deliveryReportMessage.UpdateOn = dto.UpdateOn;

            return deliveryReportMessage;
        }

        // logging helper
        public static string FormatDeliveryReportMessageDTO(DeliveryReportMessageDTO deliveryReportMessageDTO)
        {
            if(deliveryReportMessageDTO == null)
            {
                // null
                return "deliveryReportMessageDTO: null";
            }
            else
            {
                // output values
                return "deliveryReportMessageDTO: \n"
                    + "{ \n"
 
                    + "    DeliveryReportMessageId: " +  "'" + deliveryReportMessageDTO.DeliveryReportMessageId + "'"  + ", \n" 
                    + "    DeliveryReportMessageTypeId: " +  "'" + deliveryReportMessageDTO.DeliveryReportMessageTypeId + "'"  + ", \n" 
                    + "    Message: " + (deliveryReportMessageDTO.Message != null ? "'" + deliveryReportMessageDTO.Message + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + deliveryReportMessageDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (deliveryReportMessageDTO.CreateBy != null ? "'" + deliveryReportMessageDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (deliveryReportMessageDTO.CreateOn != null ? "'" + deliveryReportMessageDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (deliveryReportMessageDTO.UpdateBy != null ? "'" + deliveryReportMessageDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (deliveryReportMessageDTO.UpdateOn != null ? "'" + deliveryReportMessageDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    