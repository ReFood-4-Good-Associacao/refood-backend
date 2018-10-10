
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ITaskService
    {
        int AddTask(TaskDTO dto);

        void DeleteTask(int taskId);

        void DeleteTask(TaskDTO dto);

        TaskDTO GetTask(int taskId);

        IEnumerable<TaskDTO> GetTasks();

        IList<TaskDTO> GetTasks(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<TaskDTO> GetTaskListAdvancedSearch(
            string name 
            ,int? taskTypeId 
            ,System.DateTime? taskDateFrom 
            ,System.DateTime? taskDateTo 
            ,int? weekDay 
            ,System.DateTime? startTimeFrom 
            ,System.DateTime? startTimeTo 
            ,System.DateTime? endTimeFrom 
            ,System.DateTime? endTimeTo 
            ,int? estimatedDuration 
            ,string description 
            ,bool? requiresCar 
            ,int? teamLeaderId 
            ,bool? active 
        );

        void UpdateTask(TaskDTO dto);

    }
}
    