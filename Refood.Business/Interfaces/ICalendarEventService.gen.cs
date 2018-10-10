
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ICalendarEventService
    {
        int AddCalendarEvent(CalendarEventDTO dto);

        void DeleteCalendarEvent(int calendarEventId);

        void DeleteCalendarEvent(CalendarEventDTO dto);

        CalendarEventDTO GetCalendarEvent(int calendarEventId);

        IEnumerable<CalendarEventDTO> GetCalendarEvents();

        IList<CalendarEventDTO> GetCalendarEvents(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<CalendarEventDTO> GetCalendarEventListAdvancedSearch(
            int? nucleoId 
            ,string name 
            ,string description 
            ,System.DateTime? startDateFrom 
            ,System.DateTime? startDateTo 
            ,System.DateTime? endDateFrom 
            ,System.DateTime? endDateTo 
            ,bool? active 
        );

        void UpdateCalendarEvent(CalendarEventDTO dto);

    }
}
    