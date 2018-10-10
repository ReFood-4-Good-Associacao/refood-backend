
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
    public partial class TaskRepository : ITaskRepository
    {
        public int AddTask(R_Task t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteTask(R_Task t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteTask(int taskId)
        {
            var t = GetTask(taskId);
            DeleteTask(t);
        }

        public R_Task GetTask(int taskId)
        {
            //Requires.NotNegative("taskId", taskId);
            
            R_Task t = R_Task.SingleOrDefault(taskId);

            return t;
        }

        public IEnumerable<R_Task> GetTasks()
        {
             
            IEnumerable<R_Task> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Task")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Task.Query(sql);

            return results;
        }

        public IList<R_Task> GetTasks(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Task> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Task")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_Task.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Task> GetTaskListAdvancedSearch(
            string name 
            , int? taskTypeId 
            , System.DateTime? taskDateFrom 
            , System.DateTime? taskDateTo 
            , int? weekDay 
            , System.DateTime? startTimeFrom 
            , System.DateTime? startTimeTo 
            , System.DateTime? endTimeFrom 
            , System.DateTime? endTimeTo 
            , int? estimatedDuration 
            , string description 
            , bool? requiresCar 
            , int? teamLeaderId 
            , bool? active 
        )
        {
            IEnumerable<R_Task> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Task")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (taskTypeId != null ? " and TaskTypeId like '%" + taskTypeId + "%'" : "")
                    + (taskDateFrom != null ? " and TaskDate >= '" + taskDateFrom.Value.ToShortDateString() + "'" : "")
                    + (taskDateTo != null ? " and TaskDate <= '" + taskDateTo.Value.ToShortDateString() + "'" : "")
                    + (weekDay != null ? " and WeekDay like '%" + weekDay + "%'" : "")
                    + (startTimeFrom != null ? " and StartTime >= '" + startTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (startTimeTo != null ? " and StartTime <= '" + startTimeTo.Value.ToShortDateString() + "'" : "")
                    + (endTimeFrom != null ? " and EndTime >= '" + endTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (endTimeTo != null ? " and EndTime <= '" + endTimeTo.Value.ToShortDateString() + "'" : "")
                    + (estimatedDuration != null ? " and EstimatedDuration like '%" + estimatedDuration + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (requiresCar != null ? " and RequiresCar like '%" + requiresCar + "%'" : "")
                    + (teamLeaderId != null ? " and TeamLeaderId like '%" + teamLeaderId + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Task.Query(sql);

            return results;
        }

        public void UpdateTask(R_Task t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "TaskId");

            t.Update();
        }

    }
}

        