
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class VehicleTypeDTO
    {
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public VehicleTypeDTO()
        {
        
        }

        public VehicleTypeDTO(R_VehicleType vehicleType)
        {
            VehicleTypeId = vehicleType.VehicleTypeId;
            Name = vehicleType.Name;
            Description = vehicleType.Description;
            Active = vehicleType.Active;
            IsDeleted = vehicleType.IsDeleted;
            CreateBy = vehicleType.CreateBy;
            CreateOn = vehicleType.CreateOn;
            UpdateBy = vehicleType.UpdateBy;
            UpdateOn = vehicleType.UpdateOn;
        }

        public static R_VehicleType ConvertDTOtoEntity(VehicleTypeDTO dto)
        {
            R_VehicleType vehicleType = new R_VehicleType();

            vehicleType.VehicleTypeId = dto.VehicleTypeId;
            vehicleType.Name = dto.Name;
            vehicleType.Description = dto.Description;
            vehicleType.Active = dto.Active;
            vehicleType.IsDeleted = dto.IsDeleted;
            vehicleType.CreateBy = dto.CreateBy;
            vehicleType.CreateOn = dto.CreateOn;
            vehicleType.UpdateBy = dto.UpdateBy;
            vehicleType.UpdateOn = dto.UpdateOn;

            return vehicleType;
        }

        // logging helper
        public static string FormatVehicleTypeDTO(VehicleTypeDTO vehicleTypeDTO)
        {
            if(vehicleTypeDTO == null)
            {
                // null
                return "vehicleTypeDTO: null";
            }
            else
            {
                // output values
                return "vehicleTypeDTO: \n"
                    + "{ \n"
 
                    + "    VehicleTypeId: " +  "'" + vehicleTypeDTO.VehicleTypeId + "'"  + ", \n" 
                    + "    Name: " + (vehicleTypeDTO.Name != null ? "'" + vehicleTypeDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (vehicleTypeDTO.Description != null ? "'" + vehicleTypeDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + vehicleTypeDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + vehicleTypeDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (vehicleTypeDTO.CreateBy != null ? "'" + vehicleTypeDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (vehicleTypeDTO.CreateOn != null ? "'" + vehicleTypeDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (vehicleTypeDTO.UpdateBy != null ? "'" + vehicleTypeDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (vehicleTypeDTO.UpdateOn != null ? "'" + vehicleTypeDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    