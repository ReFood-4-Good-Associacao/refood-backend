
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class FoodTemplateDTO
    {
        public int FoodTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FoodCategory { get; set; }
        public int? Calories { get; set; }
        public System.DateTime? AverageExpirationTime { get; set; }
        public bool Liquid { get; set; }
        public bool NeedsRefrigeration { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public FoodTemplateDTO()
        {
        
        }

        public FoodTemplateDTO(R_FoodTemplate foodTemplate)
        {
            FoodTemplateId = foodTemplate.FoodTemplateId;
            Name = foodTemplate.Name;
            Description = foodTemplate.Description;
            FoodCategory = foodTemplate.FoodCategory;
            Calories = foodTemplate.Calories;
            AverageExpirationTime = foodTemplate.AverageExpirationTime;
            Liquid = foodTemplate.Liquid;
            NeedsRefrigeration = foodTemplate.NeedsRefrigeration;
            Active = foodTemplate.Active;
            IsDeleted = foodTemplate.IsDeleted;
            CreateBy = foodTemplate.CreateBy;
            CreateOn = foodTemplate.CreateOn;
            UpdateBy = foodTemplate.UpdateBy;
            UpdateOn = foodTemplate.UpdateOn;
        }

        public static R_FoodTemplate ConvertDTOtoEntity(FoodTemplateDTO dto)
        {
            R_FoodTemplate foodTemplate = new R_FoodTemplate();

            foodTemplate.FoodTemplateId = dto.FoodTemplateId;
            foodTemplate.Name = dto.Name;
            foodTemplate.Description = dto.Description;
            foodTemplate.FoodCategory = dto.FoodCategory;
            foodTemplate.Calories = dto.Calories;
            foodTemplate.AverageExpirationTime = dto.AverageExpirationTime;
            foodTemplate.Liquid = dto.Liquid;
            foodTemplate.NeedsRefrigeration = dto.NeedsRefrigeration;
            foodTemplate.Active = dto.Active;
            foodTemplate.IsDeleted = dto.IsDeleted;
            foodTemplate.CreateBy = dto.CreateBy;
            foodTemplate.CreateOn = dto.CreateOn;
            foodTemplate.UpdateBy = dto.UpdateBy;
            foodTemplate.UpdateOn = dto.UpdateOn;

            return foodTemplate;
        }

        // logging helper
        public static string FormatFoodTemplateDTO(FoodTemplateDTO foodTemplateDTO)
        {
            if(foodTemplateDTO == null)
            {
                // null
                return "foodTemplateDTO: null";
            }
            else
            {
                // output values
                return "foodTemplateDTO: \n"
                    + "{ \n"
 
                    + "    FoodTemplateId: " +  "'" + foodTemplateDTO.FoodTemplateId + "'"  + ", \n" 
                    + "    Name: " + (foodTemplateDTO.Name != null ? "'" + foodTemplateDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (foodTemplateDTO.Description != null ? "'" + foodTemplateDTO.Description + "'" : "null") + ", \n" 
                    + "    FoodCategory: " + (foodTemplateDTO.FoodCategory != null ? "'" + foodTemplateDTO.FoodCategory + "'" : "null") + ", \n" 
                    + "    Calories: " + (foodTemplateDTO.Calories != null ? "'" + foodTemplateDTO.Calories + "'" : "null") + ", \n" 
                    + "    AverageExpirationTime: " + (foodTemplateDTO.AverageExpirationTime != null ? "'" + foodTemplateDTO.AverageExpirationTime + "'" : "null") + ", \n" 
                    + "    Liquid: " + "'" + foodTemplateDTO.Liquid + "'" + ", \n" 
                    + "    NeedsRefrigeration: " + "'" + foodTemplateDTO.NeedsRefrigeration + "'" + ", \n" 
                    + "    Active: " +  "'" + foodTemplateDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + foodTemplateDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (foodTemplateDTO.CreateBy != null ? "'" + foodTemplateDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (foodTemplateDTO.CreateOn != null ? "'" + foodTemplateDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (foodTemplateDTO.UpdateBy != null ? "'" + foodTemplateDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (foodTemplateDTO.UpdateOn != null ? "'" + foodTemplateDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    