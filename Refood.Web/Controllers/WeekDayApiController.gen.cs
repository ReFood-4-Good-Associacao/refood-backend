
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
    [RoutePrefix("api/WeekDayApi")]
    public partial class WeekDayApiController : ApiController
    {
        private readonly IWeekDayService _weekDayService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WeekDayApiController(IWeekDayService weekDayService)
        {
            this._weekDayService = weekDayService;
        }

        public WeekDayApiController() : this(new WeekDayService()) { }

        /// <summary>
        /// Delete WeekDay by id
        /// </summary>
        /// <param name="id">WeekDay id</param>
        /// <returns>true if the WeekDay is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_weekDayService.DeleteWeekDay - weekDayId: " + id + " "); 

                _weekDayService.DeleteWeekDay(id);

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
        /// Get WeekDay by id
        /// </summary>
        /// <param name="id">WeekDay id</param>
        /// <returns>WeekDay json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_weekDayService.GetWeekDay - weekDayId: " + id + " "); 

                var weekDay = new WeekDayViewModel(_weekDayService.GetWeekDay(id));

                log.Debug("_weekDayService.GetWeekDay - " + WeekDayViewModel.FormatWeekDayViewModel(weekDay)); 

                log.Debug("result: 'success'"); 

                //return Json(weekDay, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(weekDay), "application/json");
                //return weekDay;
                //return JsonConvert.SerializeObject(weekDay);
                return Ok(weekDay);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of WeekDays
        /// </summary>
        /// <returns>json list of WeekDay view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<WeekDayViewModel> weekDays;

                log.Debug("_weekDayService.GetWeekDays"); 

                // add edit url
                weekDays = _weekDayService.GetWeekDays()
                        .Select(weekDay => new WeekDayViewModel(weekDay, GetEditUrl(weekDay.WeekDayId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (weekDays != null ? weekDays.Count().ToString() : "null")); 

                //return Json(weekDays, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(weekDays), "application/json");
                //return JsonConvert.SerializeObject(weekDays);
                return Ok(weekDays);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of WeekDays
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of WeekDays</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<WeekDayViewModel> weekDays;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_weekDayService.GetWeekDays - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                weekDays = _weekDayService.GetWeekDays(searchTerm, pageIndex, pageSize)
                        .Select(weekDay => new WeekDayViewModel(weekDay, GetEditUrl(weekDay.WeekDayId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (weekDays != null ? weekDays.Count().ToString() : "null")); 

                //return Json(weekDays, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(weekDays);
                return Ok(weekDays);
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
            , int? nucleoId = null 
            , string name = null 
            , string description = null 
            , int? responsiblePersonId = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetWeekDayListAdvancedSearch"); 

                IEnumerable<WeekDayDTO> resultsDTO = _weekDayService.GetWeekDayListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , responsiblePersonId 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<WeekDayViewModel> weekDayList = resultsDTO.Select(weekDay => new WeekDayViewModel(weekDay, GetEditUrl(weekDay.WeekDayId))).ToList();

                log.Debug("result: 'success', count: " + (weekDayList != null ? weekDayList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(weekDayList), "application/json");
                //return JsonConvert.SerializeObject(weekDayList);
                return Ok(weekDayList);
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
            string editUrl = Url.Content("~/WeekDay/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing WeekDay, or creates a new WeekDay if the Id is 0
        /// </summary>
        /// <param name="viewModel">WeekDay data</param>
        /// <returns>WeekDay id</returns>
        public IHttpActionResult Upsert(WeekDayViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.WeekDayId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.WeekDayId);
                return Ok(t.WeekDayId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.WeekDayId);
                //return JsonConvert.SerializeObject(t.WeekDayId);
                return Ok(t.WeekDayId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of WeekDay
        /// </summary>
        /// <param name="viewModels">WeekDay view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(WeekDayViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(WeekDayViewModel viewModel in viewModels)
                    {
                        log.Debug(WeekDayViewModel.FormatWeekDayViewModel(viewModel)); 

                        if (viewModel.WeekDayId > 0)
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

        private WeekDayDTO Create(WeekDayViewModel viewModel)
        {
            try
            {
                log.Debug(WeekDayViewModel.FormatWeekDayViewModel(viewModel)); 

                WeekDayDTO weekDay = new WeekDayDTO();

                // copy values
                viewModel.UpdateDTO(weekDay, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                weekDay.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                weekDay.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_weekDayService.AddWeekDay - " + WeekDayDTO.FormatWeekDayDTO(weekDay)); 

                int id = _weekDayService.AddWeekDay(weekDay);

                weekDay.WeekDayId = id;

                log.Debug("result: 'success', id: " + id); 

                return weekDay;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private WeekDayDTO Update(WeekDayViewModel viewModel)
        {
            try
            {
                log.Debug(WeekDayViewModel.FormatWeekDayViewModel(viewModel)); 

                // get
                log.Debug("_weekDayService.GetWeekDay - weekDayId: " + viewModel.WeekDayId + " "); 

                var existingWeekDay = _weekDayService.GetWeekDay(viewModel.WeekDayId);

                log.Debug("_weekDayService.GetWeekDay - " + WeekDayDTO.FormatWeekDayDTO(existingWeekDay)); 

                if (existingWeekDay != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingWeekDay, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_weekDayService.UpdateWeekDay - " + WeekDayDTO.FormatWeekDayDTO(existingWeekDay)); 

                    _weekDayService.UpdateWeekDay(existingWeekDay);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingWeekDay: null, WeekDayId: " + viewModel.WeekDayId); 
                }

                return existingWeekDay;
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

    