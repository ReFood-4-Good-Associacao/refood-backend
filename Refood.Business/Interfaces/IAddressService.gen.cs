
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IAddressService
    {
        int AddAddress(AddressDTO dto);

        void DeleteAddress(int addressId);

        void DeleteAddress(AddressDTO dto);

        AddressDTO GetAddress(int addressId);

        IEnumerable<AddressDTO> GetAddresss();

        IList<AddressDTO> GetAddresss(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<AddressDTO> GetAddressListAdvancedSearch(
            string name 
            ,string addressFirstLine 
            ,string addressSecondLine 
            ,int? countryId 
            ,int? districtId 
            ,int? countyId 
            ,int? parishId 
            ,string zipCode 
            ,double? latitude 
            ,double? longitude 
            ,bool? active 
        );

        void UpdateAddress(AddressDTO dto);

    }
}
    