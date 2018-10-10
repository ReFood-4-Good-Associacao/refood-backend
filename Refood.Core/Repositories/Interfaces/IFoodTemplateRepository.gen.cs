
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IFoodTemplateRepository
    {
        int AddFoodTemplate(R_FoodTemplate t);

        void DeleteFoodTemplate(R_FoodTemplate t);

        void DeleteFoodTemplate(int foodTemplateId);

        R_FoodTemplate GetFoodTemplate(int foodTemplateId);

        IEnumerable<R_FoodTemplate> GetFoodTemplates();

        IList<R_FoodTemplate> GetFoodTemplates(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_FoodTemplate> GetFoodTemplateListAdvancedSearch(
            string name 
            , string description 
            , string foodCategory 
            , int? calories 
            , System.DateTime? averageExpirationTimeFrom 
            , System.DateTime? averageExpirationTimeTo 
            , bool? liquid 
            , bool? needsRefrigeration 
            , bool? active 
        );

        void UpdateFoodTemplate(R_FoodTemplate t);

    }
}

    