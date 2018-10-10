
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
    [RoutePrefix("api/ParishApi")]
    public partial class ParishApiController : ApiController
    {
        private readonly IParishService _parishService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParishApiController(IParishService parishService)
        {
            this._parishService = parishService;
        }

        public ParishApiController() : this(new ParishService()) { }

        /// <summary>
        /// Delete Parish by id
        /// </summary>
        /// <param name="id">Parish id</param>
        /// <returns>true if the Parish is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_parishService.DeleteParish - parishId: " + id + " "); 

                _parishService.DeleteParish(id);

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
        /// Get Parish by id
        /// </summary>
        /// <param name="id">Parish id</param>
        /// <returns>Parish json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_parishService.GetParish - parishId: " + id + " "); 

                var parish = new ParishViewModel(_parishService.GetParish(id));

                log.Debug("_parishService.GetParish - " + ParishViewModel.FormatParishViewModel(parish)); 

                log.Debug("result: 'success'"); 

                //return Json(parish, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(parish), "application/json");
                //return parish;
                //return JsonConvert.SerializeObject(parish);
                return Ok(parish);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Parishs
        /// </summary>
        /// <returns>json list of Parish view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ParishViewModel> parishs;

                log.Debug("_parishService.GetParishs"); 

                // add edit url
                parishs = _parishService.GetParishs()
                        .Select(parish => new ParishViewModel(parish, GetEditUrl(parish.ParishId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (parishs != null ? parishs.Count().ToString() : "null")); 

                //return Json(parishs, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(parishs), "application/json");
                //return JsonConvert.SerializeObject(parishs);
                return Ok(parishs);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Parishs
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Parishs</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ParishViewModel> parishs;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_parishService.GetParishs - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                parishs = _parishService.GetParishs(searchTerm, pageIndex, pageSize)
                        .Select(parish => new ParishViewModel(parish, GetEditUrl(parish.ParishId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (parishs != null ? parishs.Count().ToString() : "null")); 

                //return Json(parishs, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(parishs);
                return Ok(parishs);
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
            , int? countyId = null 
            , int? districtId = null 
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

                log.Debug("GetParishListAdvancedSearch"); 

                IEnumerable<ParishDTO> resultsDTO = _parishService.GetParishListAdvancedSearch(
                     countyId 
                    , districtId 
                    , countryId 
                    , name 
                    , code 
                    , latitude 
                    , longitude 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<ParishViewModel> parishList = resultsDTO.Select(parish => new ParishViewModel(parish, GetEditUrl(parish.ParishId))).ToList();

                log.Debug("result: 'success', count: " + (parishList != null ? parishList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(parishList), "application/json");
                //return JsonConvert.SerializeObject(parishList);
                return Ok(parishList);
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
            string editUrl = Url.Content("~/Parish/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Parish, or creates a new Parish if the Id is 0
        /// </summary>
        /// <param name="viewModel">Parish data</param>
        /// <returns>Parish id</returns>
        public IHttpActionResult Upsert(ParishViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ParishId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ParishId);
                return Ok(t.ParishId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ParishId);
                //return JsonConvert.SerializeObject(t.ParishId);
                return Ok(t.ParishId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Parish
        /// </summary>
        /// <param name="viewModels">Parish view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ParishViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ParishViewModel viewModel in viewModels)
                    {
                        log.Debug(ParishViewModel.FormatParishViewModel(viewModel)); 

                        if (viewModel.ParishId > 0)
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

        private ParishDTO Create(ParishViewModel viewModel)
        {
            try
            {
                log.Debug(ParishViewModel.FormatParishViewModel(viewModel)); 

                ParishDTO parish = new ParishDTO();

                // copy values
                viewModel.UpdateDTO(parish, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                parish.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                parish.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_parishService.AddParish - " + ParishDTO.FormatParishDTO(parish)); 

                int id = _parishService.AddParish(parish);

                parish.ParishId = id;

                log.Debug("result: 'success', id: " + id); 

                return parish;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ParishDTO Update(ParishViewModel viewModel)
        {
            try
            {
                log.Debug(ParishViewModel.FormatParishViewModel(viewModel)); 

                // get
                log.Debug("_parishService.GetParish - parishId: " + viewModel.ParishId + " "); 

                var existingParish = _parishService.GetParish(viewModel.ParishId);

                log.Debug("_parishService.GetParish - " + ParishDTO.FormatParishDTO(existingParish)); 

                if (existingParish != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingParish, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_parishService.UpdateParish - " + ParishDTO.FormatParishDTO(existingParish)); 

                    _parishService.UpdateParish(existingParish);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingParish: null, ParishId: " + viewModel.ParishId); 
                }

                return existingParish;
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

    