
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ICountryRepository
    {
        int AddCountry(R_Country t);

        void DeleteCountry(R_Country t);

        void DeleteCountry(int countryId);

        R_Country GetCountry(int countryId);

        IEnumerable<R_Country> GetCountrys();

        IList<R_Country> GetCountrys(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Country> GetCountryListAdvancedSearch(
            string name 
            , string englishName 
            , string isoCode 
            , string capitalCity 
            , double? latitude 
            , double? longitude 
            , double? phonePrefix 
            , bool? active 
        );

        void UpdateCountry(R_Country t);

    }
}

    