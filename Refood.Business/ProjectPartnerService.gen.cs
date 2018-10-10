
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
    public partial class ProjectPartnerService :  IProjectPartnerService
    {
        public static IProjectPartnerRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProjectPartnerService()
        {
            if (Repository == null)
            {
                Repository = new ProjectPartnerRepository();
            }
        }

        public int AddProjectPartner(ProjectPartnerDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ProjectPartnerDTO.FormatProjectPartnerDTO(dto)); 

                R_ProjectPartner t = ProjectPartnerDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddProjectPartner(t);
                dto.ProjectPartnerId = id;

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

        public void DeleteProjectPartner(ProjectPartnerDTO dto)
        {
            try
            {
                log.Debug(ProjectPartnerDTO.FormatProjectPartnerDTO(dto)); 
            
                R_ProjectPartner t = ProjectPartnerDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteProjectPartner(t);
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

        public void DeleteProjectPartner(int projectPartnerId)
        {
            try
            {
                log.Debug("projectPartnerId: " + projectPartnerId + " "); 

                // delete
                Repository.DeleteProjectPartner(projectPartnerId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ProjectPartnerDTO GetProjectPartner(int projectPartnerId)
        {
            try
            {
                //Requires.NotNegative("projectPartnerId", projectPartnerId);
                
                log.Debug("projectPartnerId: " + projectPartnerId + " "); 

                // get
                R_ProjectPartner t = Repository.GetProjectPartner(projectPartnerId);

                ProjectPartnerDTO dto = new ProjectPartnerDTO(t);

                log.Debug(ProjectPartnerDTO.FormatProjectPartnerDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ProjectPartnerDTO> GetProjectPartners()
        {
            try
            {
                
                log.Debug("GetProjectPartners"); 

                // get
                IEnumerable<R_ProjectPartner> results = Repository.GetProjectPartners();

                IEnumerable<ProjectPartnerDTO> resultsDTO = results.Select(e => new ProjectPartnerDTO(e));

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

        public IList<ProjectPartnerDTO> GetProjectPartners(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_ProjectPartner> results = Repository.GetProjectPartners(searchTerm, pageIndex, pageSize);
            
                IList<ProjectPartnerDTO> resultsDTO = results.Select(e => new ProjectPartnerDTO(e)).ToList();

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

        public IEnumerable<ProjectPartnerDTO> GetProjectPartnerListAdvancedSearch(
             int? projectId 
            , int? partnerId 
            , double? grantValue 
        )
        {
            try
            {
                log.Debug("GetProjectPartnerListAdvancedSearch"); 

                IEnumerable<R_ProjectPartner> results = Repository.GetProjectPartnerListAdvancedSearch(
                     projectId 
                    , partnerId 
                    , grantValue 
                );
            
                IEnumerable<ProjectPartnerDTO> resultsDTO = results.Select(e => new ProjectPartnerDTO(e));

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

        public void UpdateProjectPartner(ProjectPartnerDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ProjectPartnerId");

                log.Debug(ProjectPartnerDTO.FormatProjectPartnerDTO(dto)); 

                R_ProjectPartner t = ProjectPartnerDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateProjectPartner(t);

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

    