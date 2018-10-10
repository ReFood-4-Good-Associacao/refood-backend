
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IParishService
    {
        int AddParish(ParishDTO dto);

        void DeleteParish(int parishId);

        void DeleteParish(ParishDTO dto);

        ParishDTO GetParish(int parishId);

        IEnumerable<ParishDTO> GetParishs();

        IList<ParishDTO> GetParishs(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ParishDTO> GetParishListAdvancedSearch(
            int? countyId 
            ,int? districtId 
            ,int? countryId 
            ,string name 
            ,string code 
            ,double? latitude 
            ,double? longitude 
            ,bool? active 
        );

        void UpdateParish(ParishDTO dto);

    }
}
    