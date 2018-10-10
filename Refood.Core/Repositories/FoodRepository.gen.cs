
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class FoodRepository : IFoodRepository
    {
        public int AddFood(R_Food t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteFood(R_Food t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteFood(int foodId)
        {
            var t = GetFood(foodId);
            DeleteFood(t);
        }

        public R_Food GetFood(int foodId)
        {
            //Requires.NotNegative("foodId", foodId);
            
            R_Food t = R_Food.SingleOrDefault(foodId);

            return t;
        }

        public IEnumerable<R_Food> GetFoods()
        {
             
            IEnumerable<R_Food> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Food")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Food.Query(sql);

            return results;
        }

        public IList<R_Food> GetFoods(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Food> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Food")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "SpecificObservations like '%" + searchTerm + "%'"
                     + " or " + "Location like '%" + searchTerm + "%'"
                     + " or " + "FeedbackFromBeneficiary like '%" + searchTerm + "%'"
                )
            ;

            results = R_Food.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Food> GetFoodListAdvancedSearch(
            string name 
            , double? quantity 
            , int? foodTemplateId 
            , string specificObservations 
            , string location 
            , int? progress 
            , bool? expired 
            , bool? liquid 
            , int? rating 
            , string feedbackFromBeneficiary 
            , int? deliveredBy 
            , int? deliveredTo 
            , System.DateTime? orderDateTimeFrom 
            , System.DateTime? orderDateTimeTo 
            , System.DateTime? cookedDateTimeFrom 
            , System.DateTime? cookedDateTimeTo 
            , System.DateTime? pickupDateTimeFrom 
            , System.DateTime? pickupDateTimeTo 
            , System.DateTime? storageDateTimeFrom 
            , System.DateTime? storageDateTimeTo 
            , System.DateTime? deliveryDateTimeFrom 
            , System.DateTime? deliveryDateTimeTo 
            , bool? active 
        )
        {
            IEnumerable<R_Food> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Food")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (quantity != null ? " and Quantity like '%" + quantity + "%'" : "")
                    + (foodTemplateId != null ? " and FoodTemplateId like '%" + foodTemplateId + "%'" : "")
                    + (specificObservations != null ? " and SpecificObservations like '%" + specificObservations + "%'" : "")
                    + (location != null ? " and Location like '%" + location + "%'" : "")
                    + (progress != null ? " and Progress like '%" + progress + "%'" : "")
                    + (expired != null ? " and Expired = " + (expired == true ? "1" : "0") : "")
                    + (liquid != null ? " and Liquid = " + (liquid == true ? "1" : "0") : "")
                    + (rating != null ? " and Rating like '%" + rating + "%'" : "")
                    + (feedbackFromBeneficiary != null ? " and FeedbackFromBeneficiary like '%" + feedbackFromBeneficiary + "%'" : "")
                    + (deliveredBy != null ? " and DeliveredBy like '%" + deliveredBy + "%'" : "")
                    + (deliveredTo != null ? " and DeliveredTo like '%" + deliveredTo + "%'" : "")
                    + (orderDateTimeFrom != null ? " and OrderDateTime >= '" + orderDateTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (orderDateTimeTo != null ? " and OrderDateTime <= '" + orderDateTimeTo.Value.ToShortDateString() + "'" : "")
                    + (cookedDateTimeFrom != null ? " and CookedDateTime >= '" + cookedDateTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (cookedDateTimeTo != null ? " and CookedDateTime <= '" + cookedDateTimeTo.Value.ToShortDateString() + "'" : "")
                    + (pickupDateTimeFrom != null ? " and PickupDateTime >= '" + pickupDateTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (pickupDateTimeTo != null ? " and PickupDateTime <= '" + pickupDateTimeTo.Value.ToShortDateString() + "'" : "")
                    + (storageDateTimeFrom != null ? " and StorageDateTime >= '" + storageDateTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (storageDateTimeTo != null ? " and StorageDateTime <= '" + storageDateTimeTo.Value.ToShortDateString() + "'" : "")
                    + (deliveryDateTimeFrom != null ? " and DeliveryDateTime >= '" + deliveryDateTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (deliveryDateTimeTo != null ? " and DeliveryDateTime <= '" + deliveryDateTimeTo.Value.ToShortDateString() + "'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Food.Query(sql);

            return results;
        }

        public void UpdateFood(R_Food t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "FoodId");

            t.Update();
        }

    }
}

        