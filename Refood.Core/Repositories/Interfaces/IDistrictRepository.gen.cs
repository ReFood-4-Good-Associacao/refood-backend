
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IDistrictRepository
    {
        int AddDistrict(R_District t);

        void DeleteDistrict(R_District t);

        void DeleteDistrict(int districtId);

        R_District GetDistrict(int districtId);

        IEnumerable<R_District> GetDistricts();

        IList<R_District> GetDistricts(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_District> GetDistrictListAdvancedSearch(
            int? countryId 
            , string name 
            , string code 
            , double? latitude 
            , double? longitude 
            , bool? active 
        );

        void UpdateDistrict(R_District t);

    }
}

    