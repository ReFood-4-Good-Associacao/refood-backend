
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ITaskTypeService
    {
        int AddTaskType(TaskTypeDTO dto);

        void DeleteTaskType(int taskTypeId);

        void DeleteTaskType(TaskTypeDTO dto);

        TaskTypeDTO GetTaskType(int taskTypeId);

        IEnumerable<TaskTypeDTO> GetTaskTypes();

        IList<TaskTypeDTO> GetTaskTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<TaskTypeDTO> GetTaskTypeListAdvancedSearch(
            string name 
            ,string description 
            ,bool? active 
        );

        void UpdateTaskType(TaskTypeDTO dto);

    }
}
    