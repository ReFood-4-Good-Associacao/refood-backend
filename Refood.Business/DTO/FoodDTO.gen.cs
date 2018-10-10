
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class FoodDTO
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public double? Quantity { get; set; }
        public int? FoodTemplateId { get; set; }
        public string SpecificObservations { get; set; }
        public string Location { get; set; }
        public int? Progress { get; set; }
        public bool Expired { get; set; }
        public bool Liquid { get; set; }
        public int? Rating { get; set; }
        public string FeedbackFromBeneficiary { get; set; }
        public int? DeliveredBy { get; set; }
        public int? DeliveredTo { get; set; }
        public System.DateTime? OrderDateTime { get; set; }
        public System.DateTime? CookedDateTime { get; set; }
        public System.DateTime? PickupDateTime { get; set; }
        public System.DateTime? StorageDateTime { get; set; }
        public System.DateTime? DeliveryDateTime { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public FoodDTO()
        {
        
        }

        public FoodDTO(R_Food food)
        {
            FoodId = food.FoodId;
            Name = food.Name;
            Quantity = food.Quantity;
            FoodTemplateId = food.FoodTemplateId;
            SpecificObservations = food.SpecificObservations;
            Location = food.Location;
            Progress = food.Progress;
            Expired = food.Expired;
            Liquid = food.Liquid;
            Rating = food.Rating;
            FeedbackFromBeneficiary = food.FeedbackFromBeneficiary;
            DeliveredBy = food.DeliveredBy;
            DeliveredTo = food.DeliveredTo;
            OrderDateTime = food.OrderDateTime;
            CookedDateTime = food.CookedDateTime;
            PickupDateTime = food.PickupDateTime;
            StorageDateTime = food.StorageDateTime;
            DeliveryDateTime = food.DeliveryDateTime;
            Active = food.Active;
            IsDeleted = food.IsDeleted;
            CreateBy = food.CreateBy;
            CreateOn = food.CreateOn;
            UpdateBy = food.UpdateBy;
            UpdateOn = food.UpdateOn;
        }

        public static R_Food ConvertDTOtoEntity(FoodDTO dto)
        {
            R_Food food = new R_Food();

            food.FoodId = dto.FoodId;
            food.Name = dto.Name;
            food.Quantity = dto.Quantity;
            food.FoodTemplateId = dto.FoodTemplateId;
            food.SpecificObservations = dto.SpecificObservations;
            food.Location = dto.Location;
            food.Progress = dto.Progress;
            food.Expired = dto.Expired;
            food.Liquid = dto.Liquid;
            food.Rating = dto.Rating;
            food.FeedbackFromBeneficiary = dto.FeedbackFromBeneficiary;
            food.DeliveredBy = dto.DeliveredBy;
            food.DeliveredTo = dto.DeliveredTo;
            food.OrderDateTime = dto.OrderDateTime;
            food.CookedDateTime = dto.CookedDateTime;
            food.PickupDateTime = dto.PickupDateTime;
            food.StorageDateTime = dto.StorageDateTime;
            food.DeliveryDateTime = dto.DeliveryDateTime;
            food.Active = dto.Active;
            food.IsDeleted = dto.IsDeleted;
            food.CreateBy = dto.CreateBy;
            food.CreateOn = dto.CreateOn;
            food.UpdateBy = dto.UpdateBy;
            food.UpdateOn = dto.UpdateOn;

            return food;
        }

        // logging helper
        public static string FormatFoodDTO(FoodDTO foodDTO)
        {
            if(foodDTO == null)
            {
                // null
                return "foodDTO: null";
            }
            else
            {
                // output values
                return "foodDTO: \n"
                    + "{ \n"
 
                    + "    FoodId: " +  "'" + foodDTO.FoodId + "'"  + ", \n" 
                    + "    Name: " + (foodDTO.Name != null ? "'" + foodDTO.Name + "'" : "null") + ", \n" 
                    + "    Quantity: " + (foodDTO.Quantity != null ? "'" + foodDTO.Quantity + "'" : "null") + ", \n" 
                    + "    FoodTemplateId: " + (foodDTO.FoodTemplateId != null ? "'" + foodDTO.FoodTemplateId + "'" : "null") + ", \n" 
                    + "    SpecificObservations: " + (foodDTO.SpecificObservations != null ? "'" + foodDTO.SpecificObservations + "'" : "null") + ", \n" 
                    + "    Location: " + (foodDTO.Location != null ? "'" + foodDTO.Location + "'" : "null") + ", \n" 
                    + "    Progress: " + (foodDTO.Progress != null ? "'" + foodDTO.Progress + "'" : "null") + ", \n" 
                    + "    Expired: " +  "'" + foodDTO.Expired + "'"  + ", \n" 
                    + "    Liquid: " +  "'" + foodDTO.Liquid + "'"  + ", \n" 
                    + "    Rating: " + (foodDTO.Rating != null ? "'" + foodDTO.Rating + "'" : "null") + ", \n" 
                    + "    FeedbackFromBeneficiary: " + (foodDTO.FeedbackFromBeneficiary != null ? "'" + foodDTO.FeedbackFromBeneficiary + "'" : "null") + ", \n" 
                    + "    DeliveredBy: " + (foodDTO.DeliveredBy != null ? "'" + foodDTO.DeliveredBy + "'" : "null") + ", \n" 
                    + "    DeliveredTo: " + (foodDTO.DeliveredTo != null ? "'" + foodDTO.DeliveredTo + "'" : "null") + ", \n" 
                    + "    OrderDateTime: " + (foodDTO.OrderDateTime != null ? "'" + foodDTO.OrderDateTime + "'" : "null") + ", \n" 
                    + "    CookedDateTime: " + (foodDTO.CookedDateTime != null ? "'" + foodDTO.CookedDateTime + "'" : "null") + ", \n" 
                    + "    PickupDateTime: " + (foodDTO.PickupDateTime != null ? "'" + foodDTO.PickupDateTime + "'" : "null") + ", \n" 
                    + "    StorageDateTime: " + (foodDTO.StorageDateTime != null ? "'" + foodDTO.StorageDateTime + "'" : "null") + ", \n" 
                    + "    DeliveryDateTime: " + (foodDTO.DeliveryDateTime != null ? "'" + foodDTO.DeliveryDateTime + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + foodDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + foodDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (foodDTO.CreateBy != null ? "'" + foodDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (foodDTO.CreateOn != null ? "'" + foodDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (foodDTO.UpdateBy != null ? "'" + foodDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (foodDTO.UpdateOn != null ? "'" + foodDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    