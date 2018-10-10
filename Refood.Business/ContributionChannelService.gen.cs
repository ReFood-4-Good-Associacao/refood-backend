
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
    public partial class ContributionChannelService :  IContributionChannelService
    {
        public static IContributionChannelRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContributionChannelService()
        {
            if (Repository == null)
            {
                Repository = new ContributionChannelRepository();
            }
        }

        public int AddContributionChannel(ContributionChannelDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ContributionChannelDTO.FormatContributionChannelDTO(dto)); 

                R_ContributionChannel t = ContributionChannelDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddContributionChannel(t);
                dto.ContributionChannelId = id;

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

        public void DeleteContributionChannel(ContributionChannelDTO dto)
        {
            try
            {
                log.Debug(ContributionChannelDTO.FormatContributionChannelDTO(dto)); 
            
                R_ContributionChannel t = ContributionChannelDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteContributionChannel(t);
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

        public void DeleteContributionChannel(int contributionChannelId)
        {
            try
            {
                log.Debug("contributionChannelId: " + contributionChannelId + " "); 

                // delete
                Repository.DeleteContributionChannel(contributionChannelId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ContributionChannelDTO GetContributionChannel(int contributionChannelId)
        {
            try
            {
                //Requires.NotNegative("contributionChannelId", contributionChannelId);
                
                log.Debug("contributionChannelId: " + contributionChannelId + " "); 

                // get
                R_ContributionChannel t = Repository.GetContributionChannel(contributionChannelId);

                ContributionChannelDTO dto = new ContributionChannelDTO(t);

                log.Debug(ContributionChannelDTO.FormatContributionChannelDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ContributionChannelDTO> GetContributionChannels()
        {
            try
            {
                
                log.Debug("GetContributionChannels"); 

                // get
                IEnumerable<R_ContributionChannel> results = Repository.GetContributionChannels();

                IEnumerable<ContributionChannelDTO> resultsDTO = results.Select(e => new ContributionChannelDTO(e));

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

        public IList<ContributionChannelDTO> GetContributionChannels(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_ContributionChannel> results = Repository.GetContributionChannels(searchTerm, pageIndex, pageSize);
            
                IList<ContributionChannelDTO> resultsDTO = results.Select(e => new ContributionChannelDTO(e)).ToList();

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

        public IEnumerable<ContributionChannelDTO> GetContributionChannelListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetContributionChannelListAdvancedSearch"); 

                IEnumerable<R_ContributionChannel> results = Repository.GetContributionChannelListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<ContributionChannelDTO> resultsDTO = results.Select(e => new ContributionChannelDTO(e));

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

        public void UpdateContributionChannel(ContributionChannelDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ContributionChannelId");

                log.Debug(ContributionChannelDTO.FormatContributionChannelDTO(dto)); 

                R_ContributionChannel t = ContributionChannelDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateContributionChannel(t);

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

    