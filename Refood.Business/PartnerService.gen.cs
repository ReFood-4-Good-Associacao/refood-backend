
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
    public partial class PartnerService :  IPartnerService
    {
        public static IPartnerRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PartnerService()
        {
            if (Repository == null)
            {
                Repository = new PartnerRepository();
            }
        }

        public int AddPartner(PartnerDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(PartnerDTO.FormatPartnerDTO(dto)); 

                R_Partner t = PartnerDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddPartner(t);
                dto.PartnerId = id;

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

        public void DeletePartner(PartnerDTO dto)
        {
            try
            {
                log.Debug(PartnerDTO.FormatPartnerDTO(dto)); 
            
                R_Partner t = PartnerDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeletePartner(t);
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

        public void DeletePartner(int partnerId)
        {
            try
            {
                log.Debug("partnerId: " + partnerId + " "); 

                // delete
                Repository.DeletePartner(partnerId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public PartnerDTO GetPartner(int partnerId)
        {
            try
            {
                //Requires.NotNegative("partnerId", partnerId);
                
                log.Debug("partnerId: " + partnerId + " "); 

                // get
                R_Partner t = Repository.GetPartner(partnerId);

                PartnerDTO dto = new PartnerDTO(t);

                log.Debug(PartnerDTO.FormatPartnerDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<PartnerDTO> GetPartners()
        {
            try
            {
                
                log.Debug("GetPartners"); 

                // get
                IEnumerable<R_Partner> results = Repository.GetPartners();

                IEnumerable<PartnerDTO> resultsDTO = results.Select(e => new PartnerDTO(e));

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

        public IList<PartnerDTO> GetPartners(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Partner> results = Repository.GetPartners(searchTerm, pageIndex, pageSize);
            
                IList<PartnerDTO> resultsDTO = results.Select(e => new PartnerDTO(e)).ToList();

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

        public IEnumerable<PartnerDTO> GetPartnerListAdvancedSearch(
             int? nucleoId 
            , string name 
            , bool? enterpriseContributor 
            , bool? privateContributor 
            , int? contributionTypeId 
            , int? partnershipTypeId 
            , string contactPerson 
            , string department 
            , string phone 
            , string email 
            , string iban 
            , string bicSwift 
            , string fiscalNumber 
            , double? latitude 
            , double? longitude 
            , string photoUrl 
            , int? addressId 
            , System.DateTime? partnershipStartDateFrom 
            , System.DateTime? partnershipStartDateTo 
            , System.DateTime? durationCommitmentFrom 
            , System.DateTime? durationCommitmentTo 
            , string refoodAreaInteraction 
            , string reliability 
            , string interactionFrequency 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetPartnerListAdvancedSearch"); 

                IEnumerable<R_Partner> results = Repository.GetPartnerListAdvancedSearch(
                     nucleoId 
                    , name 
                    , enterpriseContributor 
                    , privateContributor 
                    , contributionTypeId 
                    , partnershipTypeId 
                    , contactPerson 
                    , department 
                    , phone 
                    , email 
                    , iban 
                    , bicSwift 
                    , fiscalNumber 
                    , latitude 
                    , longitude 
                    , photoUrl 
                    , addressId 
                    , partnershipStartDateFrom 
                    , partnershipStartDateTo 
                    , durationCommitmentFrom 
                    , durationCommitmentTo 
                    , refoodAreaInteraction 
                    , reliability 
                    , interactionFrequency 
                    , active 
                );
            
                IEnumerable<PartnerDTO> resultsDTO = results.Select(e => new PartnerDTO(e));

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

        public void UpdatePartner(PartnerDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "PartnerId");

                log.Debug(PartnerDTO.FormatPartnerDTO(dto)); 

                R_Partner t = PartnerDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdatePartner(t);

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

    