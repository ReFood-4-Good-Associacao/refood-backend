
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
    public partial class EquipmentViewModel
    {
        public EquipmentViewModel() { }

        public EquipmentViewModel(EquipmentDTO t)
        {
            EquipmentId = t.EquipmentId;
            Name = t.Name;
            Description = t.Description;
            Category = t.Category;
            Photo = t.Photo;
            QuantityInStock = t.QuantityInStock;
            MinimumQuantityNeeded = t.MinimumQuantityNeeded;
            PricePerUnit = t.PricePerUnit;
            StorageLocation = t.StorageLocation;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public EquipmentViewModel(EquipmentDTO t, string editUrl)
        {
            EquipmentId = t.EquipmentId;
            Name = t.Name;
            Description = t.Description;
            Category = t.Category;
            Photo = t.Photo;
            QuantityInStock = t.QuantityInStock;
            MinimumQuantityNeeded = t.MinimumQuantityNeeded;
            PricePerUnit = t.PricePerUnit;
            StorageLocation = t.StorageLocation;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public EquipmentDTO UpdateDTO(EquipmentDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.EquipmentId = this.EquipmentId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Category = this.Category;
                dto.Photo = this.Photo;
                dto.QuantityInStock = this.QuantityInStock;
                dto.MinimumQuantityNeeded = this.MinimumQuantityNeeded;
                dto.PricePerUnit = this.PricePerUnit;
                dto.StorageLocation = this.StorageLocation;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("equipmentId")]
        public int EquipmentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("photo")]
        public int? Photo { get; set; }

        [JsonProperty("quantityInStock")]
        public double? QuantityInStock { get; set; }

        [JsonProperty("minimumQuantityNeeded")]
        public double? MinimumQuantityNeeded { get; set; }

        [JsonProperty("pricePerUnit")]
        public double? PricePerUnit { get; set; }

        [JsonProperty("storageLocation")]
        public string StorageLocation { get; set; }

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
        public static string FormatEquipmentViewModel(EquipmentViewModel equipmentViewModel)
        {
            if (equipmentViewModel == null)
            {
                // null
                return "equipmentViewModel: null";
            }
            else
            {
                // output values
                return "equipmentViewModel: \n"
                    + "{ \n"
 
                    + "    EquipmentId: " +  "'" + equipmentViewModel.EquipmentId + "'"  + ", \n" 
                    + "    Name: " + (equipmentViewModel.Name != null ? "'" + equipmentViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (equipmentViewModel.Description != null ? "'" + equipmentViewModel.Description + "'" : "null") + ", \n" 
                    + "    Category: " + (equipmentViewModel.Category != null ? "'" + equipmentViewModel.Category + "'" : "null") + ", \n" 
                    + "    Photo: " + (equipmentViewModel.Photo != null ? "'" + equipmentViewModel.Photo + "'" : "null") + ", \n" 
                    + "    QuantityInStock: " + (equipmentViewModel.QuantityInStock != null ? "'" + equipmentViewModel.QuantityInStock + "'" : "null") + ", \n" 
                    + "    MinimumQuantityNeeded: " + (equipmentViewModel.MinimumQuantityNeeded != null ? "'" + equipmentViewModel.MinimumQuantityNeeded + "'" : "null") + ", \n" 
                    + "    PricePerUnit: " + (equipmentViewModel.PricePerUnit != null ? "'" + equipmentViewModel.PricePerUnit + "'" : "null") + ", \n" 
                    + "    StorageLocation: " + (equipmentViewModel.StorageLocation != null ? "'" + equipmentViewModel.StorageLocation + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + equipmentViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + equipmentViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (equipmentViewModel.CreateBy != null ? "'" + equipmentViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (equipmentViewModel.CreateOn != null ? "'" + equipmentViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (equipmentViewModel.UpdateBy != null ? "'" + equipmentViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (equipmentViewModel.UpdateOn != null ? "'" + equipmentViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    