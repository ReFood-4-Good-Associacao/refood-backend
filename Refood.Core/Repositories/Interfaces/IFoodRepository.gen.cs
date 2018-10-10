
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IFoodRepository
    {
        int AddFood(R_Food t);

        void DeleteFood(R_Food t);

        void DeleteFood(int foodId);

        R_Food GetFood(int foodId);

        IEnumerable<R_Food> GetFoods();

        IList<R_Food> GetFoods(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Food> GetFoodListAdvancedSearch(
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
        );

        void UpdateFood(R_Food t);

    }
}

    