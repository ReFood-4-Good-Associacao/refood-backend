
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
    public partial class DistrictRepository : IDistrictRepository
    {
        public int AddDistrict(R_District t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteDistrict(R_District t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteDistrict(int districtId)
        {
            var t = GetDistrict(districtId);
            DeleteDistrict(t);
        }

        public R_District GetDistrict(int districtId)
        {
            //Requires.NotNegative("districtId", districtId);
            
            R_District t = R_District.SingleOrDefault(districtId);

            return t;
        }

        public IEnumerable<R_District> GetDistricts()
        {
             
            IEnumerable<R_District> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_District")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_District.Query(sql);

            return results;
        }

        public IList<R_District> GetDistricts(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_District> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_District")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Code like '%" + searchTerm + "%'"
                )
            ;

            results = R_District.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_District> GetDistrictListAdvancedSearch(
            int? countryId 
            , string name 
            , string code 
            , double? latitude 
            , double? longitude 
            , bool? active 
        )
        {
            IEnumerable<R_District> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_District")
                .Where("IsDeleted = 0" 
                    + (countryId != null ? " and CountryId like '%" + countryId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (code != null ? " and Code like '%" + code + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_District.Query(sql);

            return results;
        }

        public void UpdateDistrict(R_District t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "DistrictId");

            t.Update();
        }

    }
}

        