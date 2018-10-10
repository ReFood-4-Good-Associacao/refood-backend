
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
    public partial class WeekDayRepository : IWeekDayRepository
    {
        public int AddWeekDay(R_WeekDay t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteWeekDay(R_WeekDay t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteWeekDay(int weekDayId)
        {
            var t = GetWeekDay(weekDayId);
            DeleteWeekDay(t);
        }

        public R_WeekDay GetWeekDay(int weekDayId)
        {
            //Requires.NotNegative("weekDayId", weekDayId);
            
            R_WeekDay t = R_WeekDay.SingleOrDefault(weekDayId);

            return t;
        }

        public IEnumerable<R_WeekDay> GetWeekDays()
        {
             
            IEnumerable<R_WeekDay> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_WeekDay")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_WeekDay.Query(sql);

            return results;
        }

        public IList<R_WeekDay> GetWeekDays(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_WeekDay> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_WeekDay")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_WeekDay.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_WeekDay> GetWeekDayListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , int? responsiblePersonId 
            , bool? active 
        )
        {
            IEnumerable<R_WeekDay> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_WeekDay")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (responsiblePersonId != null ? " and ResponsiblePersonId like '%" + responsiblePersonId + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_WeekDay.Query(sql);

            return results;
        }

        public void UpdateWeekDay(R_WeekDay t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "WeekDayId");

            t.Update();
        }

    }
}

        