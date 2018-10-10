
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
    public partial class ContributionMonetaryService :  IContributionMonetaryService
    {
        public static IContributionMonetaryRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionMonetaryService()
        {
            if (Repository == null)
            {
                Repository = new ContributionMonetaryRepository();
            }
        }

        public int AddContributionMonetary(ContributionMonetaryDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ContributionMonetaryDTO.FormatContributionMonetaryDTO(dto)); 

                R_ContributionMonetary t = ContributionMonetaryDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddContributionMonetary(t);
                dto.ContributionMonetaryId = id;

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

        public void DeleteContributionMonetary(ContributionMonetaryDTO dto)
        {
            try
            {
                log.Debug(ContributionMonetaryDTO.FormatContributionMonetaryDTO(dto)); 
            
                R_ContributionMonetary t = ContributionMonetaryDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteContributionMonetary(t);
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

        public void DeleteContributionMonetary(int contributionMonetaryId)
        {
            try
            {
                log.Debug("contributionMonetaryId: " + contributionMonetaryId + " "); 

                // delete
                Repository.DeleteContributionMonetary(contributionMonetaryId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ContributionMonetaryDTO GetContributionMonetary(int contributionMonetaryId)
        {
            try
            {
                //Requires.NotNegative("contributionMonetaryId", contributionMonetaryId);
                
                log.Debug("contributionMonetaryId: " + contributionMonetaryId + " "); 

                // get
                R_ContributionMonetary t = Repository.GetContributionMonetary(contributionMonetaryId);

                ContributionMonetaryDTO dto = new ContributionMonetaryDTO(t);

                log.Debug(ContributionMonetaryDTO.FormatContributionMonetaryDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ContributionMonetaryDTO> GetContributionMonetarys()
        {
            try
            {
                
                log.Debug("GetContributionMonetarys"); 

                // get
                IEnumerable<R_ContributionMonetary> results = Repository.GetContributionMonetarys();

                IEnumerable<ContributionMonetaryDTO> resultsDTO = results.Select(e => new ContributionMonetaryDTO(e));

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

        public IList<ContributionMonetaryDTO> GetContributionMonetarys(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_ContributionMonetary> results = Repository.GetContributionMonetarys(searchTerm, pageIndex, pageSize);
            
                IList<ContributionMonetaryDTO> resultsDTO = results.Select(e => new ContributionMonetaryDTO(e)).ToList();

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

        public IEnumerable<ContributionMonetaryDTO> GetContributionMonetaryListAdvancedSearch(
             int? nucleoId 
            , int? responsiblePersonId 
            , int? documentId 
            , int? partnerId 
            , System.DateTime? contributionDateFrom 
            , System.DateTime? contributionDateTo 
            , double? amount 
            , string contactPerson 
            , string ibanOrigin 
            , string bicSwiftOrigin 
            , string ibanDestination 
            , string bicSwiftDestination 
            , string fiscalNumber 
            , int? contributionChannelId 
        )
        {
            try
            {
                log.Debug("GetContributionMonetaryListAdvancedSearch"); 

                IEnumerable<R_ContributionMonetary> results = Repository.GetContributionMonetaryListAdvancedSearch(
                     nucleoId 
                    , responsiblePersonId 
                    , documentId 
                    , partnerId 
                    , contributionDateFrom 
                    , contributionDateTo 
                    , amount 
                    , contactPerson 
                    , ibanOrigin 
                    , bicSwiftOrigin 
                    , ibanDestination 
                    , bicSwiftDestination 
                    , fiscalNumber 
                    , contributionChannelId 
                );
            
                IEnumerable<ContributionMonetaryDTO> resultsDTO = results.Select(e => new ContributionMonetaryDTO(e));

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

        public void UpdateContributionMonetary(ContributionMonetaryDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ContributionMonetaryId");

                log.Debug(ContributionMonetaryDTO.FormatContributionMonetaryDTO(dto)); 

                R_ContributionMonetary t = ContributionMonetaryDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateContributionMonetary(t);

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

    