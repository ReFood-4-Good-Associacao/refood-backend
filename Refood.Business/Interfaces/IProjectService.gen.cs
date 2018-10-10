
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IProjectService
    {
        int AddProject(ProjectDTO dto);

        void DeleteProject(int projectId);

        void DeleteProject(ProjectDTO dto);

        ProjectDTO GetProject(int projectId);

        IEnumerable<ProjectDTO> GetProjects();

        IList<ProjectDTO> GetProjects(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ProjectDTO> GetProjectListAdvancedSearch(
            int? nucleoId 
            ,string name 
            ,string description 
            ,string deadlineCall 
            ,double? budget 
            ,string funding 
            ,System.DateTime? startDateFrom 
            ,System.DateTime? startDateTo 
            ,System.DateTime? endDateFrom 
            ,System.DateTime? endDateTo 
            ,string areaOfInterest 
            ,bool? active 
        );

        void UpdateProject(ProjectDTO dto);

    }
}
    