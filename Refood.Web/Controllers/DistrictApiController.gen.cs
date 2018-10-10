
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
    [RoutePrefix("api/DistrictApi")]
    public partial class DistrictApiController : ApiController
    {
        private readonly IDistrictService _districtService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DistrictApiController(IDistrictService districtService)
        {
            this._districtService = districtService;
        }

        public DistrictApiController() : this(new DistrictService()) { }

        /// <summary>
        /// Delete District by id
        /// </summary>
        /// <param name="id">District id</param>
        /// <returns>true if the District is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_districtService.DeleteDistrict - districtId: " + id + " "); 

                _districtService.DeleteDistrict(id);

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
        /// Get District by id
        /// </summary>
        /// <param name="id">District id</param>
        /// <returns>District json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_districtService.GetDistrict - districtId: " + id + " "); 

                var district = new DistrictViewModel(_districtService.GetDistrict(id));

                log.Debug("_districtService.GetDistrict - " + DistrictViewModel.FormatDistrictViewModel(district)); 

                log.Debug("result: 'success'"); 

                //return Json(district, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(district), "application/json");
                //return district;
                //return JsonConvert.SerializeObject(district);
                return Ok(district);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Districts
        /// </summary>
        /// <returns>json list of District view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<DistrictViewModel> districts;

                log.Debug("_districtService.GetDistricts"); 

                // add edit url
                districts = _districtService.GetDistricts()
                        .Select(district => new DistrictViewModel(district, GetEditUrl(district.DistrictId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (districts != null ? districts.Count().ToString() : "null")); 

                //return Json(districts, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(districts), "application/json");
                //return JsonConvert.SerializeObject(districts);
                return Ok(districts);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Districts
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Districts</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<DistrictViewModel> districts;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_districtService.GetDistricts - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                districts = _districtService.GetDistricts(searchTerm, pageIndex, pageSize)
                        .Select(district => new DistrictViewModel(district, GetEditUrl(district.DistrictId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (districts != null ? districts.Count().ToString() : "null")); 

                //return Json(districts, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(districts);
                return Ok(districts);
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
            , int? countryId = null 
            , string name = null 
            , string code = null 
            , double? latitude = null 
            , double? longitude = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetDistrictListAdvancedSearch"); 

                IEnumerable<DistrictDTO> resultsDTO = _districtService.GetDistrictListAdvancedSearch(
                     countryId 
                    , name 
                    , code 
                    , latitude 
                    , longitude 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<DistrictViewModel> districtList = resultsDTO.Select(district => new DistrictViewModel(district, GetEditUrl(district.DistrictId))).ToList();

                log.Debug("result: 'success', count: " + (districtList != null ? districtList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(districtList), "application/json");
                //return JsonConvert.SerializeObject(districtList);
                return Ok(districtList);
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
            string editUrl = Url.Content("~/District/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing District, or creates a new District if the Id is 0
        /// </summary>
        /// <param name="viewModel">District data</param>
        /// <returns>District id</returns>
        public IHttpActionResult Upsert(DistrictViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.DistrictId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.DistrictId);
                return Ok(t.DistrictId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.DistrictId);
                //return JsonConvert.SerializeObject(t.DistrictId);
                return Ok(t.DistrictId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of District
        /// </summary>
        /// <param name="viewModels">District view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(DistrictViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(DistrictViewModel viewModel in viewModels)
                    {
                        log.Debug(DistrictViewModel.FormatDistrictViewModel(viewModel)); 

                        if (viewModel.DistrictId > 0)
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

        private DistrictDTO Create(DistrictViewModel viewModel)
        {
            try
            {
                log.Debug(DistrictViewModel.FormatDistrictViewModel(viewModel)); 

                DistrictDTO district = new DistrictDTO();

                // copy values
                viewModel.UpdateDTO(district, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                district.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                district.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_districtService.AddDistrict - " + DistrictDTO.FormatDistrictDTO(district)); 

                int id = _districtService.AddDistrict(district);

                district.DistrictId = id;

                log.Debug("result: 'success', id: " + id); 

                return district;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private DistrictDTO Update(DistrictViewModel viewModel)
        {
            try
            {
                log.Debug(DistrictViewModel.FormatDistrictViewModel(viewModel)); 

                // get
                log.Debug("_districtService.GetDistrict - districtId: " + viewModel.DistrictId + " "); 

                var existingDistrict = _districtService.GetDistrict(viewModel.DistrictId);

                log.Debug("_districtService.GetDistrict - " + DistrictDTO.FormatDistrictDTO(existingDistrict)); 

                if (existingDistrict != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingDistrict, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_districtService.UpdateDistrict - " + DistrictDTO.FormatDistrictDTO(existingDistrict)); 

                    _districtService.UpdateDistrict(existingDistrict);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingDistrict: null, DistrictId: " + viewModel.DistrictId); 
                }

                return existingDistrict;
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

    