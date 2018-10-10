
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class CountryService :  ICountryService
    {
        public static ICountryRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CountryService()
        {
            if (Repository == null)
            {
                Repository = new CountryRepository();
            }
        }

        public int AddCountry(CountryDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(CountryDTO.FormatCountryDTO(dto)); 

                R_Country t = CountryDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddCountry(t);
                dto.CountryId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteCountry(CountryDTO dto)
        {
            try
            {
                log.Debug(CountryDTO.FormatCountryDTO(dto)); 
            
                R_Country t = CountryDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteCountry(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteCountry(int countryId)
        {
            try
            {
                log.Debug("countryId: " + countryId + " "); 

                // delete
                Repository.DeleteCountry(countryId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public CountryDTO GetCountry(int countryId)
        {
            try
            {
                //Requires.NotNegative("countryId", countryId);
                
                log.Debug("countryId: " + countryId + " "); 

                // get
                R_Country t = Repository.GetCountry(countryId);

                CountryDTO dto = new CountryDTO(t);

                log.Debug(CountryDTO.FormatCountryDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<CountryDTO> GetCountrys()
        {
            try
            {
                
                log.Debug("GetCountrys"); 

                // get
                IEnumerable<R_Country> results = Repository.GetCountrys();

                IEnumerable<CountryDTO> resultsDTO = results.Select(e => new CountryDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<CountryDTO> GetCountrys(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Country> results = Repository.GetCountrys(searchTerm, pageIndex, pageSize);
            
                IList<CountryDTO> resultsDTO = results.Select(e => new CountryDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<CountryDTO> GetCountryListAdvancedSearch(
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
            try
            {
                log.Debug("GetCountryListAdvancedSearch"); 

                IEnumerable<R_Country> results = Repository.GetCountryListAdvancedSearch(
                     name 
                    , englishName 
                    , isoCode 
                    , capitalCity 
                    , latitude 
                    , longitude 
                    , phonePrefix 
                    , active 
                );
            
                IEnumerable<CountryDTO> resultsDTO = results.Select(e => new CountryDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateCountry(CountryDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "CountryId");

                log.Debug(CountryDTO.FormatCountryDTO(dto)); 

                R_Country t = CountryDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateCountry(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    