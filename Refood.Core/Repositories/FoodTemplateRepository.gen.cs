
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
    public partial class FoodTemplateRepository : IFoodTemplateRepository
    {
        public int AddFoodTemplate(R_FoodTemplate t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteFoodTemplate(R_FoodTemplate t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteFoodTemplate(int foodTemplateId)
        {
            var t = GetFoodTemplate(foodTemplateId);
            DeleteFoodTemplate(t);
        }

        public R_FoodTemplate GetFoodTemplate(int foodTemplateId)
        {
            //Requires.NotNegative("foodTemplateId", foodTemplateId);
            
            R_FoodTemplate t = R_FoodTemplate.SingleOrDefault(foodTemplateId);

            return t;
        }

        public IEnumerable<R_FoodTemplate> GetFoodTemplates()
        {
             
            IEnumerable<R_FoodTemplate> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_FoodTemplate")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_FoodTemplate.Query(sql);

            return results;
        }

        public IList<R_FoodTemplate> GetFoodTemplates(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_FoodTemplate> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_FoodTemplate")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "FoodCategory like '%" + searchTerm + "%'"
                )
            ;

            results = R_FoodTemplate.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_FoodTemplate> GetFoodTemplateListAdvancedSearch(
            string name 
            , string description 
            , string foodCategory 
            , int? calories 
            , System.DateTime? averageExpirationTimeFrom 
            , System.DateTime? averageExpirationTimeTo 
            , bool? liquid 
            , bool? needsRefrigeration 
            , bool? active 
        )
        {
            IEnumerable<R_FoodTemplate> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_FoodTemplate")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (foodCategory != null ? " and FoodCategory like '%" + foodCategory + "%'" : "")
                    + (calories != null ? " and Calories like '%" + calories + "%'" : "")
                    + (averageExpirationTimeFrom != null ? " and AverageExpirationTime >= '" + averageExpirationTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (averageExpirationTimeTo != null ? " and AverageExpirationTime <= '" + averageExpirationTimeTo.Value.ToShortDateString() + "'" : "")
                    + (liquid != null ? " and Liquid = " + (liquid == true ? "1" : "0") : "")
                    + (needsRefrigeration != null ? " and NeedsRefrigeration = " + (needsRefrigeration == true ? "1" : "0") : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_FoodTemplate.Query(sql);

            return results;
        }

        public void UpdateFoodTemplate(R_FoodTemplate t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "FoodTemplateId");

            t.Update();
        }

    }
}

        