
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
    public partial class CalendarEventService :  ICalendarEventService
    {
        public static ICalendarEventRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalendarEventService()
        {
            if (Repository == null)
            {
                Repository = new CalendarEventRepository();
            }
        }

        public int AddCalendarEvent(CalendarEventDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(CalendarEventDTO.FormatCalendarEventDTO(dto)); 

                R_CalendarEvent t = CalendarEventDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddCalendarEvent(t);
                dto.CalendarEventId = id;

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

        public void DeleteCalendarEvent(CalendarEventDTO dto)
        {
            try
            {
                log.Debug(CalendarEventDTO.FormatCalendarEventDTO(dto)); 
            
                R_CalendarEvent t = CalendarEventDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteCalendarEvent(t);
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

        public void DeleteCalendarEvent(int calendarEventId)
        {
            try
            {
                log.Debug("calendarEventId: " + calendarEventId + " "); 

                // delete
                Repository.DeleteCalendarEvent(calendarEventId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public CalendarEventDTO GetCalendarEvent(int calendarEventId)
        {
            try
            {
                //Requires.NotNegative("calendarEventId", calendarEventId);
                
                log.Debug("calendarEventId: " + calendarEventId + " "); 

                // get
                R_CalendarEvent t = Repository.GetCalendarEvent(calendarEventId);

                CalendarEventDTO dto = new CalendarEventDTO(t);

                log.Debug(CalendarEventDTO.FormatCalendarEventDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<CalendarEventDTO> GetCalendarEvents()
        {
            try
            {
                
                log.Debug("GetCalendarEvents"); 

                // get
                IEnumerable<R_CalendarEvent> results = Repository.GetCalendarEvents();

                IEnumerable<CalendarEventDTO> resultsDTO = results.Select(e => new CalendarEventDTO(e));

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

        public IList<CalendarEventDTO> GetCalendarEvents(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_CalendarEvent> results = Repository.GetCalendarEvents(searchTerm, pageIndex, pageSize);
            
                IList<CalendarEventDTO> resultsDTO = results.Select(e => new CalendarEventDTO(e)).ToList();

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

        public IEnumerable<CalendarEventDTO> GetCalendarEventListAdvancedSearch(
             int? nucleoId 
            , string name 
            , string description 
            , System.DateTime? startDateFrom 
            , System.DateTime? startDateTo 
            , System.DateTime? endDateFrom 
            , System.DateTime? endDateTo 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetCalendarEventListAdvancedSearch"); 

                IEnumerable<R_CalendarEvent> results = Repository.GetCalendarEventListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , startDateFrom 
                    , startDateTo 
                    , endDateFrom 
                    , endDateTo 
                    , active 
                );
            
                IEnumerable<CalendarEventDTO> resultsDTO = results.Select(e => new CalendarEventDTO(e));

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

        public void UpdateCalendarEvent(CalendarEventDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "CalendarEventId");

                log.Debug(CalendarEventDTO.FormatCalendarEventDTO(dto)); 

                R_CalendarEvent t = CalendarEventDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateCalendarEvent(t);

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

    