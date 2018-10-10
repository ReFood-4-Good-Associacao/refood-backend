
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
    public partial class ContributionMonetaryReviewerService :  IContributionMonetaryReviewerService
    {
        public static IContributionMonetaryReviewerRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionMonetaryReviewerService()
        {
            if (Repository == null)
            {
                Repository = new ContributionMonetaryReviewerRepository();
            }
        }

        public int AddContributionMonetaryReviewer(ContributionMonetaryReviewerDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(dto)); 

                R_ContributionMonetaryReviewer t = ContributionMonetaryReviewerDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddContributionMonetaryReviewer(t);
                dto.ContributionMonetaryReviewerId = id;

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

        public void DeleteContributionMonetaryReviewer(ContributionMonetaryReviewerDTO dto)
        {
            try
            {
                log.Debug(ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(dto)); 
            
                R_ContributionMonetaryReviewer t = ContributionMonetaryReviewerDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteContributionMonetaryReviewer(t);
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

        public void DeleteContributionMonetaryReviewer(int contributionMonetaryReviewerId)
        {
            try
            {
                log.Debug("contributionMonetaryReviewerId: " + contributionMonetaryReviewerId + " "); 

                // delete
                Repository.DeleteContributionMonetaryReviewer(contributionMonetaryReviewerId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ContributionMonetaryReviewerDTO GetContributionMonetaryReviewer(int contributionMonetaryReviewerId)
        {
            try
            {
                //Requires.NotNegative("contributionMonetaryReviewerId", contributionMonetaryReviewerId);
                
                log.Debug("contributionMonetaryReviewerId: " + contributionMonetaryReviewerId + " "); 

                // get
                R_ContributionMonetaryReviewer t = Repository.GetContributionMonetaryReviewer(contributionMonetaryReviewerId);

                ContributionMonetaryReviewerDTO dto = new ContributionMonetaryReviewerDTO(t);

                log.Debug(ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ContributionMonetaryReviewerDTO> GetContributionMonetaryReviewers()
        {
            try
            {
                
                log.Debug("GetContributionMonetaryReviewers"); 

                // get
                IEnumerable<R_ContributionMonetaryReviewer> results = Repository.GetContributionMonetaryReviewers();

                IEnumerable<ContributionMonetaryReviewerDTO> resultsDTO = results.Select(e => new ContributionMonetaryReviewerDTO(e));

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

        public IList<ContributionMonetaryReviewerDTO> GetContributionMonetaryReviewers(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_ContributionMonetaryReviewer> results = Repository.GetContributionMonetaryReviewers(searchTerm, pageIndex, pageSize);
            
                IList<ContributionMonetaryReviewerDTO> resultsDTO = results.Select(e => new ContributionMonetaryReviewerDTO(e)).ToList();

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

        public IEnumerable<ContributionMonetaryReviewerDTO> GetContributionMonetaryReviewerListAdvancedSearch(
             int? volunteerId 
        )
        {
            try
            {
                log.Debug("GetContributionMonetaryReviewerListAdvancedSearch"); 

                IEnumerable<R_ContributionMonetaryReviewer> results = Repository.GetContributionMonetaryReviewerListAdvancedSearch(
                     volunteerId 
                );
            
                IEnumerable<ContributionMonetaryReviewerDTO> resultsDTO = results.Select(e => new ContributionMonetaryReviewerDTO(e));

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

        public void UpdateContributionMonetaryReviewer(ContributionMonetaryReviewerDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ContributionMonetaryReviewerId");

                log.Debug(ContributionMonetaryReviewerDTO.FormatContributionMonetaryReviewerDTO(dto)); 

                R_ContributionMonetaryReviewer t = ContributionMonetaryReviewerDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateContributionMonetaryReviewer(t);

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

    