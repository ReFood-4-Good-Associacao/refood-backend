
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
    public partial class CalendarEventRepository : ICalendarEventRepository
    {
        public int AddCalendarEvent(R_CalendarEvent t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteCalendarEvent(R_CalendarEvent t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteCalendarEvent(int calendarEventId)
        {
            var t = GetCalendarEvent(calendarEventId);
            DeleteCalendarEvent(t);
        }

        public R_CalendarEvent GetCalendarEvent(int calendarEventId)
        {
            //Requires.NotNegative("calendarEventId", calendarEventId);
            
            R_CalendarEvent t = R_CalendarEvent.SingleOrDefault(calendarEventId);

            return t;
        }

        public IEnumerable<R_CalendarEvent> GetCalendarEvents()
        {
             
            IEnumerable<R_CalendarEvent> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_CalendarEvent")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_CalendarEvent.Query(sql);

            return results;
        }

        public IList<R_CalendarEvent> GetCalendarEvents(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_CalendarEvent> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_CalendarEvent")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_CalendarEvent.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_CalendarEvent> GetCalendarEventListAdvancedSearch(
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
            IEnumerable<R_CalendarEvent> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_CalendarEvent")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (startDateFrom != null ? " and StartDate >= '" + startDateFrom.Value.ToShortDateString() + "'" : "")
                    + (startDateTo != null ? " and StartDate <= '" + startDateTo.Value.ToShortDateString() + "'" : "")
                    + (endDateFrom != null ? " and EndDate >= '" + endDateFrom.Value.ToShortDateString() + "'" : "")
                    + (endDateTo != null ? " and EndDate <= '" + endDateTo.Value.ToShortDateString() + "'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_CalendarEvent.Query(sql);

            return results;
        }

        public void UpdateCalendarEvent(R_CalendarEvent t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "CalendarEventId");

            t.Update();
        }

    }
}

        