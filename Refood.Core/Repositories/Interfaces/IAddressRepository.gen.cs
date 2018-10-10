
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IAddressRepository
    {
        int AddAddress(R_Address t);

        void DeleteAddress(R_Address t);

        void DeleteAddress(int addressId);

        R_Address GetAddress(int addressId);

        IEnumerable<R_Address> GetAddresss();

        IList<R_Address> GetAddresss(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Address> GetAddressListAdvancedSearch(
            string name 
            , string addressFirstLine 
            , string addressSecondLine 
            , int? countryId 
            , int? districtId 
            , int? countyId 
            , int? parishId 
            , string zipCode 
            , double? latitude 
            , double? longitude 
            , bool? active 
        );

        void UpdateAddress(R_Address t);

    }
}

    