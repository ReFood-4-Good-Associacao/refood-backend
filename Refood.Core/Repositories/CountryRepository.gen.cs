
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
    public partial class CountryRepository : ICountryRepository
    {
        public int AddCountry(R_Country t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteCountry(R_Country t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteCountry(int countryId)
        {
            var t = GetCountry(countryId);
            DeleteCountry(t);
        }

        public R_Country GetCountry(int countryId)
        {
            //Requires.NotNegative("countryId", countryId);
            
            R_Country t = R_Country.SingleOrDefault(countryId);

            return t;
        }

        public IEnumerable<R_Country> GetCountrys()
        {
             
            IEnumerable<R_Country> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Country")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Country.Query(sql);

            return results;
        }

        public IList<R_Country> GetCountrys(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Country> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Country")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "EnglishName like '%" + searchTerm + "%'"
                     + " or " + "IsoCode like '%" + searchTerm + "%'"
                     + " or " + "CapitalCity like '%" + searchTerm + "%'"
                )
            ;

            results = R_Country.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Country> GetCountryListAdvancedSearch(
            string name 
            , string englishName 
            , string isoCode 
            , string capitalCity 
            , double? latitude 
            , double? longitude 
            , double? phonePrefix 
            , bool? active 
        )
        {
            IEnumerable<R_Country> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Country")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (englishName != null ? " and EnglishName like '%" + englishName + "%'" : "")
                    + (isoCode != null ? " and IsoCode like '%" + isoCode + "%'" : "")
                    + (capitalCity != null ? " and CapitalCity like '%" + capitalCity + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (phonePrefix != null ? " and PhonePrefix like '%" + phonePrefix + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Country.Query(sql);

            return results;
        }

        public void UpdateCountry(R_Country t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "CountryId");

            t.Update();
        }

    }
}

        