
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IFoodTemplateService
    {
        int AddFoodTemplate(FoodTemplateDTO dto);

        void DeleteFoodTemplate(int foodTemplateId);

        void DeleteFoodTemplate(FoodTemplateDTO dto);

        FoodTemplateDTO GetFoodTemplate(int foodTemplateId);

        IEnumerable<FoodTemplateDTO> GetFoodTemplates();

        IList<FoodTemplateDTO> GetFoodTemplates(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<FoodTemplateDTO> GetFoodTemplateListAdvancedSearch(
            string name 
            ,string description 
            ,string foodCategory 
            ,int? calories 
            ,System.DateTime? averageExpirationTimeFrom 
            ,System.DateTime? averageExpirationTimeTo 
            ,bool? liquid 
            ,bool? needsRefrigeration 
            ,bool? active 
        );

        void UpdateFoodTemplate(FoodTemplateDTO dto);

    }
}
    