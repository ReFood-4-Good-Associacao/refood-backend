
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IDistrictService
    {
        int AddDistrict(DistrictDTO dto);

        void DeleteDistrict(int districtId);

        void DeleteDistrict(DistrictDTO dto);

        DistrictDTO GetDistrict(int districtId);

        IEnumerable<DistrictDTO> GetDistricts();

        IList<DistrictDTO> GetDistricts(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<DistrictDTO> GetDistrictListAdvancedSearch(
            int? countryId 
            ,string name 
            ,string code 
            ,double? latitude 
            ,double? longitude 
            ,bool? active 
        );

        void UpdateDistrict(DistrictDTO dto);

    }
}
    