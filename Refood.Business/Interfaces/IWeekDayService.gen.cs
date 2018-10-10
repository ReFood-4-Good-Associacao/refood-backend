
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IWeekDayService
    {
        int AddWeekDay(WeekDayDTO dto);

        void DeleteWeekDay(int weekDayId);

        void DeleteWeekDay(WeekDayDTO dto);

        WeekDayDTO GetWeekDay(int weekDayId);

        IEnumerable<WeekDayDTO> GetWeekDays();

        IList<WeekDayDTO> GetWeekDays(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<WeekDayDTO> GetWeekDayListAdvancedSearch(
            int? nucleoId 
            ,string name 
            ,string description 
            ,int? responsiblePersonId 
            ,bool? active 
        );

        void UpdateWeekDay(WeekDayDTO dto);

    }
}
    