
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class SupplierTypeDTO
    {
        public int SupplierTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public SupplierTypeDTO()
        {
        
        }

        public SupplierTypeDTO(R_SupplierType supplierType)
        {
            SupplierTypeId = supplierType.SupplierTypeId;
            Name = supplierType.Name;
            Description = supplierType.Description;
            Active = supplierType.Active;
            IsDeleted = supplierType.IsDeleted;
            CreateBy = supplierType.CreateBy;
            CreateOn = supplierType.CreateOn;
            UpdateBy = supplierType.UpdateBy;
            UpdateOn = supplierType.UpdateOn;
        }

        public static R_SupplierType ConvertDTOtoEntity(SupplierTypeDTO dto)
        {
            R_SupplierType supplierType = new R_SupplierType();

            supplierType.SupplierTypeId = dto.SupplierTypeId;
            supplierType.Name = dto.Name;
            supplierType.Description = dto.Description;
            supplierType.Active = dto.Active;
            supplierType.IsDeleted = dto.IsDeleted;
            supplierType.CreateBy = dto.CreateBy;
            supplierType.CreateOn = dto.CreateOn;
            supplierType.UpdateBy = dto.UpdateBy;
            supplierType.UpdateOn = dto.UpdateOn;

            return supplierType;
        }

        // logging helper
        public static string FormatSupplierTypeDTO(SupplierTypeDTO supplierTypeDTO)
        {
            if(supplierTypeDTO == null)
            {
                // null
                return "supplierTypeDTO: null";
            }
            else
            {
                // output values
                return "supplierTypeDTO: \n"
                    + "{ \n"
 
                    + "    SupplierTypeId: " +  "'" + supplierTypeDTO.SupplierTypeId + "'"  + ", \n" 
                    + "    Name: " + (supplierTypeDTO.Name != null ? "'" + supplierTypeDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (supplierTypeDTO.Description != null ? "'" + supplierTypeDTO.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + supplierTypeDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + supplierTypeDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (supplierTypeDTO.CreateBy != null ? "'" + supplierTypeDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (supplierTypeDTO.CreateOn != null ? "'" + supplierTypeDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (supplierTypeDTO.UpdateBy != null ? "'" + supplierTypeDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (supplierTypeDTO.UpdateOn != null ? "'" + supplierTypeDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    