
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IParishRepository
    {
        int AddParish(R_Parish t);

        void DeleteParish(R_Parish t);

        void DeleteParish(int parishId);

        R_Parish GetParish(int parishId);

        IEnumerable<R_Parish> GetParishs();

        IList<R_Parish> GetParishs(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Parish> GetParishListAdvancedSearch(
            int? countyId 
            , int? districtId 
            , int? countryId 
            , string name 
            , string code 
            , double? latitude 
            , double? longitude 
            , bool? active 
        );

        void UpdateParish(R_Parish t);

    }
}

    