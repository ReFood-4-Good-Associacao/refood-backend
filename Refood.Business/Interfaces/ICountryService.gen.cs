
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ICountryService
    {
        int AddCountry(CountryDTO dto);

        void DeleteCountry(int countryId);

        void DeleteCountry(CountryDTO dto);

        CountryDTO GetCountry(int countryId);

        IEnumerable<CountryDTO> GetCountrys();

        IList<CountryDTO> GetCountrys(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<CountryDTO> GetCountryListAdvancedSearch(
            string name 
            ,string englishName 
            ,string isoCode 
            ,string capitalCity 
            ,double? latitude 
            ,double? longitude 
            ,double? phonePrefix 
            ,bool? active 
        );

        void UpdateCountry(CountryDTO dto);

    }
}
    