
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class PartnershipTypeDTO
    {
        public int PartnershipTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ActivityType { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public PartnershipTypeDTO()
        {
        
        }

        public PartnershipTypeDTO(R_PartnershipType partnershipType)
        {
            PartnershipTypeId = partnershipType.PartnershipTypeId;
            Name = partnershipType.Name;
            Description = partnershipType.Description;
            ActivityType = partnershipType.ActivityType;
            Active = partnershipType.Active;
            IsDeleted = partnershipType.IsDeleted;
            CreateBy = partnershipType.CreateBy;
            CreateOn = partnershipType.CreateOn;
            UpdateBy = partnershipType.UpdateBy;
            UpdateOn = partnershipType.UpdateOn;
        }

        public static R_PartnershipType ConvertDTOtoEntity(PartnershipTypeDTO dto)
        {
            R_PartnershipType partnershipType = new R_PartnershipType();

            partnershipType.PartnershipTypeId = dto.PartnershipTypeId;
            partnershipType.Name = dto.Name;
            partnershipType.Description = dto.Description;
            partnershipType.ActivityType = dto.ActivityType;
            partnershipType.Active = dto.Active;
            partnershipType.IsDeleted = dto.IsDeleted;
            partnershipType.CreateBy = dto.CreateBy;
            partnershipType.CreateOn = dto.CreateOn;
            partnershipType.UpdateBy = dto.UpdateBy;
            partnershipType.UpdateOn = dto.UpdateOn;

            return partnershipType;
        }

        // logging helper
        public static string FormatPartnershipTypeDTO(PartnershipTypeDTO partnershipTypeDTO)
        {
            if(partnershipTypeDTO == null)
            {
                // null
                return "partnershipTypeDTO: null";
            }
            else
            {
                // output values
                return "partnershipTypeDTO: \n"
                    + "{ \n"
 
                    + "    PartnershipTypeId: " +  "'" + partnershipTypeDTO.PartnershipTypeId + "'"  + ", \n" 
                    + "    Name: " + (partnershipTypeDTO.Name != null ? "'" + partnershipTypeDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (partnershipTypeDTO.Description != null ? "'" + partnershipTypeDTO.Description + "'" : "null") + ", \n" 
                    + "    ActivityType: " + (partnershipTypeDTO.ActivityType != null ? "'" + partnershipTypeDTO.ActivityType + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + partnershipTypeDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + partnershipTypeDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (partnershipTypeDTO.CreateBy != null ? "'" + partnershipTypeDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (partnershipTypeDTO.CreateOn != null ? "'" + partnershipTypeDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (partnershipTypeDTO.UpdateBy != null ? "'" + partnershipTypeDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (partnershipTypeDTO.UpdateOn != null ? "'" + partnershipTypeDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    