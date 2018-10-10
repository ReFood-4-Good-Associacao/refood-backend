
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IWeekDayRepository
    {
        int AddWeekDay(R_WeekDay t);

        void DeleteWeekDay(R_WeekDay t);

        void DeleteWeekDay(int weekDayId);

        R_WeekDay GetWeekDay(int weekDayId);

        IEnumerable<R_WeekDay> GetWeekDays();

        IList<R_WeekDay> GetWeekDays(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_WeekDay> GetWeekDayListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , int? responsiblePersonId 
            , bool? active 
        );

        void UpdateWeekDay(R_WeekDay t);

    }
}

    