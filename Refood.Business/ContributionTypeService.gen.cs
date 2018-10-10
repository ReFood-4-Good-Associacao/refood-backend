
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
    public partial class ContributionTypeService :  IContributionTypeService
    {
        public static IContributionTypeRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionTypeService()
        {
            if (Repository == null)
            {
                Repository = new ContributionTypeRepository();
            }
        }

        public int AddContributionType(ContributionTypeDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ContributionTypeDTO.FormatContributionTypeDTO(dto)); 

                R_ContributionType t = ContributionTypeDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddContributionType(t);
                dto.ContributionTypeId = id;

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

        public void DeleteContributionType(ContributionTypeDTO dto)
        {
            try
            {
                log.Debug(ContributionTypeDTO.FormatContributionTypeDTO(dto)); 
            
                R_ContributionType t = ContributionTypeDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteContributionType(t);
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

        public void DeleteContributionType(int contributionTypeId)
        {
            try
            {
                log.Debug("contributionTypeId: " + contributionTypeId + " "); 

                // delete
                Repository.DeleteContributionType(contributionTypeId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ContributionTypeDTO GetContributionType(int contributionTypeId)
        {
            try
            {
                //Requires.NotNegative("contributionTypeId", contributionTypeId);
                
                log.Debug("contributionTypeId: " + contributionTypeId + " "); 

                // get
                R_ContributionType t = Repository.GetContributionType(contributionTypeId);

                ContributionTypeDTO dto = new ContributionTypeDTO(t);

                log.Debug(ContributionTypeDTO.FormatContributionTypeDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ContributionTypeDTO> GetContributionTypes()
        {
            try
            {
                
                log.Debug("GetContributionTypes"); 

                // get
                IEnumerable<R_ContributionType> results = Repository.GetContributionTypes();

                IEnumerable<ContributionTypeDTO> resultsDTO = results.Select(e => new ContributionTypeDTO(e));

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

        public IList<ContributionTypeDTO> GetContributionTypes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_ContributionType> results = Repository.GetContributionTypes(searchTerm, pageIndex, pageSize);
            
                IList<ContributionTypeDTO> resultsDTO = results.Select(e => new ContributionTypeDTO(e)).ToList();

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

        public IEnumerable<ContributionTypeDTO> GetContributionTypeListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetContributionTypeListAdvancedSearch"); 

                IEnumerable<R_ContributionType> results = Repository.GetContributionTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<ContributionTypeDTO> resultsDTO = results.Select(e => new ContributionTypeDTO(e));

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

        public void UpdateContributionType(ContributionTypeDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ContributionTypeId");

                log.Debug(ContributionTypeDTO.FormatContributionTypeDTO(dto)); 

                R_ContributionType t = ContributionTypeDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateContributionType(t);

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

    