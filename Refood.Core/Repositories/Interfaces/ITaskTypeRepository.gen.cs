
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ITaskTypeRepository
    {
        int AddTaskType(R_TaskType t);

        void DeleteTaskType(R_TaskType t);

        void DeleteTaskType(int taskTypeId);

        R_TaskType GetTaskType(int taskTypeId);

        IEnumerable<R_TaskType> GetTaskTypes();

        IList<R_TaskType> GetTaskTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_TaskType> GetTaskTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateTaskType(R_TaskType t);

    }
}

    