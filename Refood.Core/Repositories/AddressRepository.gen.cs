
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class AddressRepository : IAddressRepository
    {
        public int AddAddress(R_Address t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteAddress(R_Address t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteAddress(int addressId)
        {
            var t = GetAddress(addressId);
            DeleteAddress(t);
        }

        public R_Address GetAddress(int addressId)
        {
            //Requires.NotNegative("addressId", addressId);
            
            R_Address t = R_Address.SingleOrDefault(addressId);

            return t;
        }

        public IEnumerable<R_Address> GetAddresss()
        {
             
            IEnumerable<R_Address> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Address")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Address.Query(sql);

            return results;
        }

        public IList<R_Address> GetAddresss(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Address> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Address")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "AddressFirstLine like '%" + searchTerm + "%'"
                     + " or " + "AddressSecondLine like '%" + searchTerm + "%'"
                     + " or " + "ZipCode like '%" + searchTerm + "%'"
                )
            ;

            results = R_Address.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Address> GetAddressListAdvancedSearch(
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
        )
        {
            IEnumerable<R_Address> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Address")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (addressFirstLine != null ? " and AddressFirstLine like '%" + addressFirstLine + "%'" : "")
                    + (addressSecondLine != null ? " and AddressSecondLine like '%" + addressSecondLine + "%'" : "")
                    + (countryId != null ? " and CountryId like '%" + countryId + "%'" : "")
                    + (districtId != null ? " and DistrictId like '%" + districtId + "%'" : "")
                    + (countyId != null ? " and CountyId like '%" + countyId + "%'" : "")
                    + (parishId != null ? " and ParishId like '%" + parishId + "%'" : "")
                    + (zipCode != null ? " and ZipCode like '%" + zipCode + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Address.Query(sql);

            return results;
        }

        public void UpdateAddress(R_Address t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "AddressId");

            t.Update();
        }

    }
}

        