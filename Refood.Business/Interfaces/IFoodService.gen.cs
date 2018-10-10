
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IFoodService
    {
        int AddFood(FoodDTO dto);

        void DeleteFood(int foodId);

        void DeleteFood(FoodDTO dto);

        FoodDTO GetFood(int foodId);

        IEnumerable<FoodDTO> GetFoods();

        IList<FoodDTO> GetFoods(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<FoodDTO> GetFoodListAdvancedSearch(
            string name 
            ,double? quantity 
            ,int? foodTemplateId 
            ,string specificObservations 
            ,string location 
            ,int? progress 
            ,bool? expired 
            ,bool? liquid 
            ,int? rating 
            ,string feedbackFromBeneficiary 
            ,int? deliveredBy 
            ,int? deliveredTo 
            ,System.DateTime? orderDateTimeFrom 
            ,System.DateTime? orderDateTimeTo 
            ,System.DateTime? cookedDateTimeFrom 
            ,System.DateTime? cookedDateTimeTo 
            ,System.DateTime? pickupDateTimeFrom 
            ,System.DateTime? pickupDateTimeTo 
            ,System.DateTime? storageDateTimeFrom 
            ,System.DateTime? storageDateTimeTo 
            ,System.DateTime? deliveryDateTimeFrom 
            ,System.DateTime? deliveryDateTimeTo 
            ,bool? active 
        );

        void UpdateFood(FoodDTO dto);

    }
}
    