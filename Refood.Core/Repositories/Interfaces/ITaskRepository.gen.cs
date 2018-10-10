
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ITaskRepository
    {
        int AddTask(R_Task t);

        void DeleteTask(R_Task t);

        void DeleteTask(int taskId);

        R_Task GetTask(int taskId);

        IEnumerable<R_Task> GetTasks();

        IList<R_Task> GetTasks(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Task> GetTaskListAdvancedSearch(
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
        );

        void UpdateTask(R_Task t);

    }
}

    