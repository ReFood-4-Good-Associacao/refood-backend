
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
    public partial class ParishRepository : IParishRepository
    {
        public int AddParish(R_Parish t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteParish(R_Parish t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteParish(int parishId)
        {
            var t = GetParish(parishId);
            DeleteParish(t);
        }

        public R_Parish GetParish(int parishId)
        {
            //Requires.NotNegative("parishId", parishId);
            
            R_Parish t = R_Parish.SingleOrDefault(parishId);

            return t;
        }

        public IEnumerable<R_Parish> GetParishs()
        {
             
            IEnumerable<R_Parish> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Parish")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Parish.Query(sql);

            return results;
        }

        public IList<R_Parish> GetParishs(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Parish> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Parish")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Code like '%" + searchTerm + "%'"
                )
            ;

            results = R_Parish.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Parish> GetParishListAdvancedSearch(
            int? countyId 
            , int? districtId 
            , int? countryId 
            , string name 
            , string code 
            , double? latitude 
            , double? longitude 
            , bool? active 
        )
        {
            IEnumerable<R_Parish> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Parish")
                .Where("IsDeleted = 0" 
                    + (countyId != null ? " and CountyId like '%" + countyId + "%'" : "")
                    + (districtId != null ? " and DistrictId like '%" + districtId + "%'" : "")
                    + (countryId != null ? " and CountryId like '%" + countryId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (code != null ? " and Code like '%" + code + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Parish.Query(sql);

            return results;
        }

        public void UpdateParish(R_Parish t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ParishId");

            t.Update();
        }

    }
}

        