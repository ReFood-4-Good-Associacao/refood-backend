
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
    public partial class FoodTemplateViewModel
    {
        public FoodTemplateViewModel() { }

        public FoodTemplateViewModel(FoodTemplateDTO t)
        {
            FoodTemplateId = t.FoodTemplateId;
            Name = t.Name;
            Description = t.Description;
            FoodCategory = t.FoodCategory;
            Calories = t.Calories;
            AverageExpirationTime = t.AverageExpirationTime;
            Liquid = t.Liquid;
            NeedsRefrigeration = t.NeedsRefrigeration;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public FoodTemplateViewModel(FoodTemplateDTO t, string editUrl)
        {
            FoodTemplateId = t.FoodTemplateId;
            Name = t.Name;
            Description = t.Description;
            FoodCategory = t.FoodCategory;
            Calories = t.Calories;
            AverageExpirationTime = t.AverageExpirationTime;
            Liquid = t.Liquid;
            NeedsRefrigeration = t.NeedsRefrigeration;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public FoodTemplateDTO UpdateDTO(FoodTemplateDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.FoodTemplateId = this.FoodTemplateId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.FoodCategory = this.FoodCategory;
                dto.Calories = this.Calories;
                dto.AverageExpirationTime = this.AverageExpirationTime;
                dto.Liquid = this.Liquid;
                dto.NeedsRefrigeration = this.NeedsRefrigeration;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("foodTemplateId")]
        public int FoodTemplateId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foodCategory")]
        public string FoodCategory { get; set; }

        [JsonProperty("calories")]
        public int? Calories { get; set; }

        [JsonProperty("averageExpirationTime")]
        public System.DateTime? AverageExpirationTime { get; set; }

        [JsonProperty("liquid")]
        public bool Liquid { get; set; }

        [JsonProperty("needsRefrigeration")]
        public bool NeedsRefrigeration { get; set; }

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
        public static string FormatFoodTemplateViewModel(FoodTemplateViewModel foodTemplateViewModel)
        {
            if (foodTemplateViewModel == null)
            {
                // null
                return "foodTemplateViewModel: null";
            }
            else
            {
                // output values
                return "foodTemplateViewModel: \n"
                    + "{ \n"
 
                    + "    FoodTemplateId: " +  "'" + foodTemplateViewModel.FoodTemplateId + "'"  + ", \n" 
                    + "    Name: " + (foodTemplateViewModel.Name != null ? "'" + foodTemplateViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (foodTemplateViewModel.Description != null ? "'" + foodTemplateViewModel.Description + "'" : "null") + ", \n" 
                    + "    FoodCategory: " + (foodTemplateViewModel.FoodCategory != null ? "'" + foodTemplateViewModel.FoodCategory + "'" : "null") + ", \n" 
                    + "    Calories: " + (foodTemplateViewModel.Calories != null ? "'" + foodTemplateViewModel.Calories + "'" : "null") + ", \n" 
                    + "    AverageExpirationTime: " + (foodTemplateViewModel.AverageExpirationTime != null ? "'" + foodTemplateViewModel.AverageExpirationTime + "'" : "null") + ", \n" 
                    + "    Liquid: " + "'" + foodTemplateViewModel.Liquid + "'" + ", \n" 
                    + "    NeedsRefrigeration: " + "'" + foodTemplateViewModel.NeedsRefrigeration + "'" + ", \n" 
                    + "    Active: " +  "'" + foodTemplateViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + foodTemplateViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (foodTemplateViewModel.CreateBy != null ? "'" + foodTemplateViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (foodTemplateViewModel.CreateOn != null ? "'" + foodTemplateViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (foodTemplateViewModel.UpdateBy != null ? "'" + foodTemplateViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (foodTemplateViewModel.UpdateOn != null ? "'" + foodTemplateViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    