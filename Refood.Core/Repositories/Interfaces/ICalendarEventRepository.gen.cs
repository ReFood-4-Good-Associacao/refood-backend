
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ICalendarEventRepository
    {
        int AddCalendarEvent(R_CalendarEvent t);

        void DeleteCalendarEvent(R_CalendarEvent t);

        void DeleteCalendarEvent(int calendarEventId);

        R_CalendarEvent GetCalendarEvent(int calendarEventId);

        IEnumerable<R_CalendarEvent> GetCalendarEvents();

        IList<R_CalendarEvent> GetCalendarEvents(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_CalendarEvent> GetCalendarEventListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , System.DateTime? startDateFrom 
            , System.DateTime? startDateTo 
            , System.DateTime? endDateFrom 
            , System.DateTime? endDateTo 
            , bool? active 
        );

        void UpdateCalendarEvent(R_CalendarEvent t);

    }
}

    