
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class EquipmentDTO
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int? Photo { get; set; }
        public double? QuantityInStock { get; set; }
        public double? MinimumQuantityNeeded { get; set; }
        public double? PricePerUnit { get; set; }
        public string StorageLocation { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public EquipmentDTO()
        {
        
        }

        public EquipmentDTO(R_Equipment equipment)
        {
            EquipmentId = equipment.EquipmentId;
            Name = equipment.Name;
            Description = equipment.Description;
            Category = equipment.Category;
            Photo = equipment.Photo;
            QuantityInStock = equipment.QuantityInStock;
            MinimumQuantityNeeded = equipment.MinimumQuantityNeeded;
            PricePerUnit = equipment.PricePerUnit;
            StorageLocation = equipment.StorageLocation;
            Active = equipment.Active;
            IsDeleted = equipment.IsDeleted;
            CreateBy = equipment.CreateBy;
            CreateOn = equipment.CreateOn;
            UpdateBy = equipment.UpdateBy;
            UpdateOn = equipment.UpdateOn;
        }

        public static R_Equipment ConvertDTOtoEntity(EquipmentDTO dto)
        {
            R_Equipment equipment = new R_Equipment();

            equipment.EquipmentId = dto.EquipmentId;
            equipment.Name = dto.Name;
            equipment.Description = dto.Description;
            equipment.Category = dto.Category;
            equipment.Photo = dto.Photo;
            equipment.QuantityInStock = dto.QuantityInStock;
            equipment.MinimumQuantityNeeded = dto.MinimumQuantityNeeded;
            equipment.PricePerUnit = dto.PricePerUnit;
            equipment.StorageLocation = dto.StorageLocation;
            equipment.Active = dto.Active;
            equipment.IsDeleted = dto.IsDeleted;
            equipment.CreateBy = dto.CreateBy;
            equipment.CreateOn = dto.CreateOn;
            equipment.UpdateBy = dto.UpdateBy;
            equipment.UpdateOn = dto.UpdateOn;

            return equipment;
        }

        // logging helper
        public static string FormatEquipmentDTO(EquipmentDTO equipmentDTO)
        {
            if(equipmentDTO == null)
            {
                // null
                return "equipmentDTO: null";
            }
            else
            {
                // output values
                return "equipmentDTO: \n"
                    + "{ \n"
 
                    + "    EquipmentId: " +  "'" + equipmentDTO.EquipmentId + "'"  + ", \n" 
                    + "    Name: " + (equipmentDTO.Name != null ? "'" + equipmentDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (equipmentDTO.Description != null ? "'" + equipmentDTO.Description + "'" : "null") + ", \n" 
                    + "    Category: " + (equipmentDTO.Category != null ? "'" + equipmentDTO.Category + "'" : "null") + ", \n" 
                    + "    Photo: " + (equipmentDTO.Photo != null ? "'" + equipmentDTO.Photo + "'" : "null") + ", \n" 
                    + "    QuantityInStock: " + (equipmentDTO.QuantityInStock != null ? "'" + equipmentDTO.QuantityInStock + "'" : "null") + ", \n" 
                    + "    MinimumQuantityNeeded: " + (equipmentDTO.MinimumQuantityNeeded != null ? "'" + equipmentDTO.MinimumQuantityNeeded + "'" : "null") + ", \n" 
                    + "    PricePerUnit: " + (equipmentDTO.PricePerUnit != null ? "'" + equipmentDTO.PricePerUnit + "'" : "null") + ", \n" 
                    + "    StorageLocation: " + (equipmentDTO.StorageLocation != null ? "'" + equipmentDTO.StorageLocation + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + equipmentDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + equipmentDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (equipmentDTO.CreateBy != null ? "'" + equipmentDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (equipmentDTO.CreateOn != null ? "'" + equipmentDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (equipmentDTO.UpdateBy != null ? "'" + equipmentDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (equipmentDTO.UpdateOn != null ? "'" + equipmentDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    