
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
    [RoutePrefix("api/CalendarEventApi")]
    public partial class CalendarEventApiController : ApiController
    {
        private readonly ICalendarEventService _calendarEventService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalendarEventApiController(ICalendarEventService calendarEventService)
        {
            this._calendarEventService = calendarEventService;
        }

        public CalendarEventApiController() : this(new CalendarEventService()) { }

        /// <summary>
        /// Delete CalendarEvent by id
        /// </summary>
        /// <param name="id">CalendarEvent id</param>
        /// <returns>true if the CalendarEvent is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_calendarEventService.DeleteCalendarEvent - calendarEventId: " + id + " "); 

                _calendarEventService.DeleteCalendarEvent(id);

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
        /// Get CalendarEvent by id
        /// </summary>
        /// <param name="id">CalendarEvent id</param>
        /// <returns>CalendarEvent json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_calendarEventService.GetCalendarEvent - calendarEventId: " + id + " "); 

                var calendarEvent = new CalendarEventViewModel(_calendarEventService.GetCalendarEvent(id));

                log.Debug("_calendarEventService.GetCalendarEvent - " + CalendarEventViewModel.FormatCalendarEventViewModel(calendarEvent)); 

                log.Debug("result: 'success'"); 

                //return Json(calendarEvent, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(calendarEvent), "application/json");
                //return calendarEvent;
                //return JsonConvert.SerializeObject(calendarEvent);
                return Ok(calendarEvent);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of CalendarEvents
        /// </summary>
        /// <returns>json list of CalendarEvent view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<CalendarEventViewModel> calendarEvents;

                log.Debug("_calendarEventService.GetCalendarEvents"); 

                // add edit url
                calendarEvents = _calendarEventService.GetCalendarEvents()
                        .Select(calendarEvent => new CalendarEventViewModel(calendarEvent, GetEditUrl(calendarEvent.CalendarEventId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (calendarEvents != null ? calendarEvents.Count().ToString() : "null")); 

                //return Json(calendarEvents, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(calendarEvents), "application/json");
                //return JsonConvert.SerializeObject(calendarEvents);
                return Ok(calendarEvents);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of CalendarEvents
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of CalendarEvents</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<CalendarEventViewModel> calendarEvents;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_calendarEventService.GetCalendarEvents - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                calendarEvents = _calendarEventService.GetCalendarEvents(searchTerm, pageIndex, pageSize)
                        .Select(calendarEvent => new CalendarEventViewModel(calendarEvent, GetEditUrl(calendarEvent.CalendarEventId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (calendarEvents != null ? calendarEvents.Count().ToString() : "null")); 

                //return Json(calendarEvents, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(calendarEvents);
                return Ok(calendarEvents);
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
            , System.DateTime? startDateFrom = null 
            , System.DateTime? startDateTo = null 
            , System.DateTime? endDateFrom = null 
            , System.DateTime? endDateTo = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetCalendarEventListAdvancedSearch"); 

                IEnumerable<CalendarEventDTO> resultsDTO = _calendarEventService.GetCalendarEventListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , startDateFrom 
                    , startDateTo 
                    , endDateFrom 
                    , endDateTo 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<CalendarEventViewModel> calendarEventList = resultsDTO.Select(calendarEvent => new CalendarEventViewModel(calendarEvent, GetEditUrl(calendarEvent.CalendarEventId))).ToList();

                log.Debug("result: 'success', count: " + (calendarEventList != null ? calendarEventList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(calendarEventList), "application/json");
                //return JsonConvert.SerializeObject(calendarEventList);
                return Ok(calendarEventList);
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
            string editUrl = Url.Content("~/CalendarEvent/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing CalendarEvent, or creates a new CalendarEvent if the Id is 0
        /// </summary>
        /// <param name="viewModel">CalendarEvent data</param>
        /// <returns>CalendarEvent id</returns>
        public IHttpActionResult Upsert(CalendarEventViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.CalendarEventId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.CalendarEventId);
                return Ok(t.CalendarEventId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.CalendarEventId);
                //return JsonConvert.SerializeObject(t.CalendarEventId);
                return Ok(t.CalendarEventId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of CalendarEvent
        /// </summary>
        /// <param name="viewModels">CalendarEvent view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(CalendarEventViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(CalendarEventViewModel viewModel in viewModels)
                    {
                        log.Debug(CalendarEventViewModel.FormatCalendarEventViewModel(viewModel)); 

                        if (viewModel.CalendarEventId > 0)
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

        private CalendarEventDTO Create(CalendarEventViewModel viewModel)
        {
            try
            {
                log.Debug(CalendarEventViewModel.FormatCalendarEventViewModel(viewModel)); 

                CalendarEventDTO calendarEvent = new CalendarEventDTO();

                // copy values
                viewModel.UpdateDTO(calendarEvent, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                calendarEvent.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                calendarEvent.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_calendarEventService.AddCalendarEvent - " + CalendarEventDTO.FormatCalendarEventDTO(calendarEvent)); 

                int id = _calendarEventService.AddCalendarEvent(calendarEvent);

                calendarEvent.CalendarEventId = id;

                log.Debug("result: 'success', id: " + id); 

                return calendarEvent;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private CalendarEventDTO Update(CalendarEventViewModel viewModel)
        {
            try
            {
                log.Debug(CalendarEventViewModel.FormatCalendarEventViewModel(viewModel)); 

                // get
                log.Debug("_calendarEventService.GetCalendarEvent - calendarEventId: " + viewModel.CalendarEventId + " "); 

                var existingCalendarEvent = _calendarEventService.GetCalendarEvent(viewModel.CalendarEventId);

                log.Debug("_calendarEventService.GetCalendarEvent - " + CalendarEventDTO.FormatCalendarEventDTO(existingCalendarEvent)); 

                if (existingCalendarEvent != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingCalendarEvent, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_calendarEventService.UpdateCalendarEvent - " + CalendarEventDTO.FormatCalendarEventDTO(existingCalendarEvent)); 

                    _calendarEventService.UpdateCalendarEvent(existingCalendarEvent);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingCalendarEvent: null, CalendarEventId: " + viewModel.CalendarEventId); 
                }

                return existingCalendarEvent;
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

    