
// ################################################################
//                      Code generated with T4
// ################################################################

using Refood.Web.Services.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    //[Authorize]
    [RoutePrefix("api/CountryApi")]
    public partial class CountryApiController : ApiController
    {
        private readonly ICountryService _countryService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CountryApiController(ICountryService countryService)
        {
            this._countryService = countryService;
        }

        public CountryApiController() : this(new CountryService()) { }

        /// <summary>
        /// Delete Country by id
        /// </summary>
        /// <param name="id">Country id</param>
        /// <returns>true if the Country is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_countryService.DeleteCountry - countryId: " + id + " "); 

                _countryService.DeleteCountry(id);

                log.Debug("result: 'success'"); 

                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get Country by id
        /// </summary>
        /// <param name="id">Country id</param>
        /// <returns>Country json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_countryService.GetCountry - countryId: " + id + " "); 

                var country = new CountryViewModel(_countryService.GetCountry(id));

                log.Debug("_countryService.GetCountry - " + CountryViewModel.FormatCountryViewModel(country)); 

                log.Debug("result: 'success'"); 

                //return Json(country, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(country), "application/json");
                //return country;
                //return JsonConvert.SerializeObject(country);
                return Ok(country);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Countrys
        /// </summary>
        /// <returns>json list of Country view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<CountryViewModel> countrys;

                log.Debug("_countryService.GetCountrys"); 

                // add edit url
                countrys = _countryService.GetCountrys()
                        .Select(country => new CountryViewModel(country, GetEditUrl(country.CountryId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (countrys != null ? countrys.Count().ToString() : "null")); 

                //return Json(countrys, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(countrys), "application/json");
                //return JsonConvert.SerializeObject(countrys);
                return Ok(countrys);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Countrys
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Countrys</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<CountryViewModel> countrys;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_countryService.GetCountrys - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                countrys = _countryService.GetCountrys(searchTerm, pageIndex, pageSize)
                        .Select(country => new CountryViewModel(country, GetEditUrl(country.CountryId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (countrys != null ? countrys.Count().ToString() : "null")); 

                //return Json(countrys, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(countrys);
                return Ok(countrys);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetListAdvancedSearch(
            int id = 0 
            , string name = null 
            , string englishName = null 
            , string isoCode = null 
            , string capitalCity = null 
            , double? latitude = null 
            , double? longitude = null 
            , double? phonePrefix = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetCountryListAdvancedSearch"); 

                IEnumerable<CountryDTO> resultsDTO = _countryService.GetCountryListAdvancedSearch(
                     name 
                    , englishName 
                    , isoCode 
                    , capitalCity 
                    , latitude 
                    , longitude 
                    , phonePrefix 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<CountryViewModel> countryList = resultsDTO.Select(country => new CountryViewModel(country, GetEditUrl(country.CountryId))).ToList();

                log.Debug("result: 'success', count: " + (countryList != null ? countryList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(countryList), "application/json");
                //return JsonConvert.SerializeObject(countryList);
                return Ok(countryList);
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/Country/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Country, or creates a new Country if the Id is 0
        /// </summary>
        /// <param name="viewModel">Country data</param>
        /// <returns>Country id</returns>
        public IHttpActionResult Upsert(CountryViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.CountryId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.CountryId);
                return Ok(t.CountryId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.CountryId);
                //return JsonConvert.SerializeObject(t.CountryId);
                return Ok(t.CountryId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Country
        /// </summary>
        /// <param name="viewModels">Country view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(CountryViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(CountryViewModel viewModel in viewModels)
                    {
                        log.Debug(CountryViewModel.FormatCountryViewModel(viewModel)); 

                        if (viewModel.CountryId > 0)
                        {
                            var t = Update(viewModel);
                        }
                        else
                        {
                            var t = Create(viewModel);
                        }

                    }
                }
                else
                {
                    log.Error("viewModels: null"); 
                }

                //return Json(true);
                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private CountryDTO Create(CountryViewModel viewModel)
        {
            try
            {
                log.Debug(CountryViewModel.FormatCountryViewModel(viewModel)); 

                CountryDTO country = new CountryDTO();

                // copy values
                viewModel.UpdateDTO(country, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                country.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                country.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_countryService.AddCountry - " + CountryDTO.FormatCountryDTO(country)); 

                int id = _countryService.AddCountry(country);

                country.CountryId = id;

                log.Debug("result: 'success', id: " + id); 

                return country;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private CountryDTO Update(CountryViewModel viewModel)
        {
            try
            {
                log.Debug(CountryViewModel.FormatCountryViewModel(viewModel)); 

                // get
                log.Debug("_countryService.GetCountry - countryId: " + viewModel.CountryId + " "); 

                var existingCountry = _countryService.GetCountry(viewModel.CountryId);

                log.Debug("_countryService.GetCountry - " + CountryDTO.FormatCountryDTO(existingCountry)); 

                if (existingCountry != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingCountry, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_countryService.UpdateCountry - " + CountryDTO.FormatCountryDTO(existingCountry)); 

                    _countryService.UpdateCountry(existingCountry);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingCountry: null, CountryId: " + viewModel.CountryId); 
                }

                return existingCountry;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    