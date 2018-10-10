
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class ProjectService :  IProjectService
    {
        public static IProjectRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProjectService()
        {
            if (Repository == null)
            {
                Repository = new ProjectRepository();
            }
        }

        public int AddProject(ProjectDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ProjectDTO.FormatProjectDTO(dto)); 

                R_Project t = ProjectDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddProject(t);
                dto.ProjectId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteProject(ProjectDTO dto)
        {
            try
            {
                log.Debug(ProjectDTO.FormatProjectDTO(dto)); 
            
                R_Project t = ProjectDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteProject(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteProject(int projectId)
        {
            try
            {
                log.Debug("projectId: " + projectId + " "); 

                // delete
                Repository.DeleteProject(projectId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ProjectDTO GetProject(int projectId)
        {
            try
            {
                //Requires.NotNegative("projectId", projectId);
                
                log.Debug("projectId: " + projectId + " "); 

                // get
                R_Project t = Repository.GetProject(projectId);

                ProjectDTO dto = new ProjectDTO(t);

                log.Debug(ProjectDTO.FormatProjectDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ProjectDTO> GetProjects()
        {
            try
            {
                
                log.Debug("GetProjects"); 

                // get
                IEnumerable<R_Project> results = Repository.GetProjects();

                IEnumerable<ProjectDTO> resultsDTO = results.Select(e => new ProjectDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<ProjectDTO> GetProjects(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Project> results = Repository.GetProjects(searchTerm, pageIndex, pageSize);
            
                IList<ProjectDTO> resultsDTO = results.Select(e => new ProjectDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ProjectDTO> GetProjectListAdvancedSearch(
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
            try
            {
                log.Debug("GetProjectListAdvancedSearch"); 

                IEnumerable<R_Project> results = Repository.GetProjectListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , deadlineCall 
                    , budget 
                    , funding 
                    , startDateFrom 
                    , startDateTo 
                    , endDateFrom 
                    , endDateTo 
                    , areaOfInterest 
                    , active 
                );
            
                IEnumerable<ProjectDTO> resultsDTO = results.Select(e => new ProjectDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateProject(ProjectDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ProjectId");

                log.Debug(ProjectDTO.FormatProjectDTO(dto)); 

                R_Project t = ProjectDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateProject(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    