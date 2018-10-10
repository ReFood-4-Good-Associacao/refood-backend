
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IProjectRepository
    {
        int AddProject(R_Project t);

        void DeleteProject(R_Project t);

        void DeleteProject(int projectId);

        R_Project GetProject(int projectId);

        IEnumerable<R_Project> GetProjects();

        IList<R_Project> GetProjects(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Project> GetProjectListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , string deadlineCall 
            , double? budget 
            , string funding 
            , System.DateTime? startDateFrom 
            , System.DateTime? startDateTo 
            , System.DateTime? endDateFrom 
            , System.DateTime? endDateTo 
            , string areaOfInterest 
            , bool? active 
        );

        void UpdateProject(R_Project t);

    }
}

    