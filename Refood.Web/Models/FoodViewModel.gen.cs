
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
    public partial class FoodViewModel
    {
        public FoodViewModel() { }

        public FoodViewModel(FoodDTO t)
        {
            FoodId = t.FoodId;
            Name = t.Name;
            Quantity = t.Quantity;
            FoodTemplateId = t.FoodTemplateId;
            SpecificObservations = t.SpecificObservations;
            Location = t.Location;
            Progress = t.Progress;
            Expired = t.Expired;
            Liquid = t.Liquid;
            Rating = t.Rating;
            FeedbackFromBeneficiary = t.FeedbackFromBeneficiary;
            DeliveredBy = t.DeliveredBy;
            DeliveredTo = t.DeliveredTo;
            OrderDateTime = t.OrderDateTime;
            CookedDateTime = t.CookedDateTime;
            PickupDateTime = t.PickupDateTime;
            StorageDateTime = t.StorageDateTime;
            DeliveryDateTime = t.DeliveryDateTime;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public FoodViewModel(FoodDTO t, string editUrl)
        {
            FoodId = t.FoodId;
            Name = t.Name;
            Quantity = t.Quantity;
            FoodTemplateId = t.FoodTemplateId;
            SpecificObservations = t.SpecificObservations;
            Location = t.Location;
            Progress = t.Progress;
            Expired = t.Expired;
            Liquid = t.Liquid;
            Rating = t.Rating;
            FeedbackFromBeneficiary = t.FeedbackFromBeneficiary;
            DeliveredBy = t.DeliveredBy;
            DeliveredTo = t.DeliveredTo;
            OrderDateTime = t.OrderDateTime;
            CookedDateTime = t.CookedDateTime;
            PickupDateTime = t.PickupDateTime;
            StorageDateTime = t.StorageDateTime;
            DeliveryDateTime = t.DeliveryDateTime;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public FoodDTO UpdateDTO(FoodDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.FoodId = this.FoodId;
                dto.Name = this.Name;
                dto.Quantity = this.Quantity;
                dto.FoodTemplateId = this.FoodTemplateId;
                dto.SpecificObservations = this.SpecificObservations;
                dto.Location = this.Location;
                dto.Progress = this.Progress;
                dto.Expired = this.Expired;
                dto.Liquid = this.Liquid;
                dto.Rating = this.Rating;
                dto.FeedbackFromBeneficiary = this.FeedbackFromBeneficiary;
                dto.DeliveredBy = this.DeliveredBy;
                dto.DeliveredTo = this.DeliveredTo;
                dto.OrderDateTime = this.OrderDateTime;
                dto.CookedDateTime = this.CookedDateTime;
                dto.PickupDateTime = this.PickupDateTime;
                dto.StorageDateTime = this.StorageDateTime;
                dto.DeliveryDateTime = this.DeliveryDateTime;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("foodId")]
        public int FoodId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("foodTemplateId")]
        public int? FoodTemplateId { get; set; }

        [JsonProperty("specificObservations")]
        public string SpecificObservations { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("progress")]
        public int? Progress { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("liquid")]
        public bool Liquid { get; set; }

        [JsonProperty("rating")]
        public int? Rating { get; set; }

        [JsonProperty("feedbackFromBeneficiary")]
        public string FeedbackFromBeneficiary { get; set; }

        [JsonProperty("deliveredBy")]
        public int? DeliveredBy { get; set; }

        [JsonProperty("deliveredTo")]
        public int? DeliveredTo { get; set; }

        [JsonProperty("orderDateTime")]
        public System.DateTime? OrderDateTime { get; set; }

        [JsonProperty("cookedDateTime")]
        public System.DateTime? CookedDateTime { get; set; }

        [JsonProperty("pickupDateTime")]
        public System.DateTime? PickupDateTime { get; set; }

        [JsonProperty("storageDateTime")]
        public System.DateTime? StorageDateTime { get; set; }

        [JsonProperty("deliveryDateTime")]
        public System.DateTime? DeliveryDateTime { get; set; }

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
        public static string FormatFoodViewModel(FoodViewModel foodViewModel)
        {
            if (foodViewModel == null)
            {
                // null
                return "foodViewModel: null";
            }
            else
            {
                // output values
                return "foodViewModel: \n"
                    + "{ \n"
 
                    + "    FoodId: " +  "'" + foodViewModel.FoodId + "'"  + ", \n" 
                    + "    Name: " + (foodViewModel.Name != null ? "'" + foodViewModel.Name + "'" : "null") + ", \n" 
                    + "    Quantity: " + (foodViewModel.Quantity != null ? "'" + foodViewModel.Quantity + "'" : "null") + ", \n" 
                    + "    FoodTemplateId: " + (foodViewModel.FoodTemplateId != null ? "'" + foodViewModel.FoodTemplateId + "'" : "null") + ", \n" 
                    + "    SpecificObservations: " + (foodViewModel.SpecificObservations != null ? "'" + foodViewModel.SpecificObservations + "'" : "null") + ", \n" 
                    + "    Location: " + (foodViewModel.Location != null ? "'" + foodViewModel.Location + "'" : "null") + ", \n" 
                    + "    Progress: " + (foodViewModel.Progress != null ? "'" + foodViewModel.Progress + "'" : "null") + ", \n" 
                    + "    Expired: " +  "'" + foodViewModel.Expired + "'"  + ", \n" 
                    + "    Liquid: " +  "'" + foodViewModel.Liquid + "'"  + ", \n" 
                    + "    Rating: " + (foodViewModel.Rating != null ? "'" + foodViewModel.Rating + "'" : "null") + ", \n" 
                    + "    FeedbackFromBeneficiary: " + (foodViewModel.FeedbackFromBeneficiary != null ? "'" + foodViewModel.FeedbackFromBeneficiary + "'" : "null") + ", \n" 
                    + "    DeliveredBy: " + (foodViewModel.DeliveredBy != null ? "'" + foodViewModel.DeliveredBy + "'" : "null") + ", \n" 
                    + "    DeliveredTo: " + (foodViewModel.DeliveredTo != null ? "'" + foodViewModel.DeliveredTo + "'" : "null") + ", \n" 
                    + "    OrderDateTime: " + (foodViewModel.OrderDateTime != null ? "'" + foodViewModel.OrderDateTime + "'" : "null") + ", \n" 
                    + "    CookedDateTime: " + (foodViewModel.CookedDateTime != null ? "'" + foodViewModel.CookedDateTime + "'" : "null") + ", \n" 
                    + "    PickupDateTime: " + (foodViewModel.PickupDateTime != null ? "'" + foodViewModel.PickupDateTime + "'" : "null") + ", \n" 
                    + "    StorageDateTime: " + (foodViewModel.StorageDateTime != null ? "'" + foodViewModel.StorageDateTime + "'" : "null") + ", \n" 
                    + "    DeliveryDateTime: " + (foodViewModel.DeliveryDateTime != null ? "'" + foodViewModel.DeliveryDateTime + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + foodViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + foodViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (foodViewModel.CreateBy != null ? "'" + foodViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (foodViewModel.CreateOn != null ? "'" + foodViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (foodViewModel.UpdateBy != null ? "'" + foodViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (foodViewModel.UpdateOn != null ? "'" + foodViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    