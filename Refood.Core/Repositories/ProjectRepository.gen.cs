
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
    public partial class ProjectRepository : IProjectRepository
    {
        public int AddProject(R_Project t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteProject(R_Project t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteProject(int projectId)
        {
            var t = GetProject(projectId);
            DeleteProject(t);
        }

        public R_Project GetProject(int projectId)
        {
            //Requires.NotNegative("projectId", projectId);
            
            R_Project t = R_Project.SingleOrDefault(projectId);

            return t;
        }

        public IEnumerable<R_Project> GetProjects()
        {
             
            IEnumerable<R_Project> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Project")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Project.Query(sql);

            return results;
        }

        public IList<R_Project> GetProjects(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Project> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Project")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "DeadlineCall like '%" + searchTerm + "%'"
                     + " or " + "Funding like '%" + searchTerm + "%'"
                     + " or " + "AreaOfInterest like '%" + searchTerm + "%'"
                )
            ;

            results = R_Project.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Project> GetProjectListAdvancedSearch(
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
        )
        {
            IEnumerable<R_Project> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Project")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (deadlineCall != null ? " and DeadlineCall like '%" + deadlineCall + "%'" : "")
                    + (budget != null ? " and Budget like '%" + budget + "%'" : "")
                    + (funding != null ? " and Funding like '%" + funding + "%'" : "")
                    + (startDateFrom != null ? " and StartDate >= '" + startDateFrom.Value.ToShortDateString() + "'" : "")
                    + (startDateTo != null ? " and StartDate <= '" + startDateTo.Value.ToShortDateString() + "'" : "")
                    + (endDateFrom != null ? " and EndDate >= '" + endDateFrom.Value.ToShortDateString() + "'" : "")
                    + (endDateTo != null ? " and EndDate <= '" + endDateTo.Value.ToShortDateString() + "'" : "")
                    + (areaOfInterest != null ? " and AreaOfInterest like '%" + areaOfInterest + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Project.Query(sql);

            return results;
        }

        public void UpdateProject(R_Project t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ProjectId");

            t.Update();
        }

    }
}

        