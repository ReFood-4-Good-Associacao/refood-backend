
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
    public partial class BeneficiaryService :  IBeneficiaryService
    {
        public static IBeneficiaryRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BeneficiaryService()
        {
            if (Repository == null)
            {
                Repository = new BeneficiaryRepository();
            }
        }

        public int AddBeneficiary(BeneficiaryDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(BeneficiaryDTO.FormatBeneficiaryDTO(dto)); 

                R_Beneficiary t = BeneficiaryDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddBeneficiary(t);
                dto.BeneficiaryId = id;

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

        public void DeleteBeneficiary(BeneficiaryDTO dto)
        {
            try
            {
                log.Debug(BeneficiaryDTO.FormatBeneficiaryDTO(dto)); 
            
                R_Beneficiary t = BeneficiaryDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteBeneficiary(t);
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

        public void DeleteBeneficiary(int beneficiaryId)
        {
            try
            {
                log.Debug("beneficiaryId: " + beneficiaryId + " "); 

                // delete
                Repository.DeleteBeneficiary(beneficiaryId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public BeneficiaryDTO GetBeneficiary(int beneficiaryId)
        {
            try
            {
                //Requires.NotNegative("beneficiaryId", beneficiaryId);
                
                log.Debug("beneficiaryId: " + beneficiaryId + " "); 

                // get
                R_Beneficiary t = Repository.GetBeneficiary(beneficiaryId);

                BeneficiaryDTO dto = new BeneficiaryDTO(t);

                log.Debug(BeneficiaryDTO.FormatBeneficiaryDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<BeneficiaryDTO> GetBeneficiarys()
        {
            try
            {
                
                log.Debug("GetBeneficiarys"); 

                // get
                IEnumerable<R_Beneficiary> results = Repository.GetBeneficiarys();

                IEnumerable<BeneficiaryDTO> resultsDTO = results.Select(e => new BeneficiaryDTO(e));

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

        public IList<BeneficiaryDTO> GetBeneficiarys(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Beneficiary> results = Repository.GetBeneficiarys(searchTerm, pageIndex, pageSize);
            
                IList<BeneficiaryDTO> resultsDTO = results.Select(e => new BeneficiaryDTO(e)).ToList();

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

        public IEnumerable<BeneficiaryDTO> GetBeneficiaryListAdvancedSearch(
             string name 
            , int? number 
            , int? addressId 
            , int? numberOfAdults 
            , int? numberOfChildren 
            , int? numberOfTupperware 
            , int? numberOfSoups 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetBeneficiaryListAdvancedSearch"); 

                IEnumerable<R_Beneficiary> results = Repository.GetBeneficiaryListAdvancedSearch(
                     name 
                    , number 
                    , addressId 
                    , numberOfAdults 
                    , numberOfChildren 
                    , numberOfTupperware 
                    , numberOfSoups 
                    , description 
                    , active 
                );
            
                IEnumerable<BeneficiaryDTO> resultsDTO = results.Select(e => new BeneficiaryDTO(e));

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

        public void UpdateBeneficiary(BeneficiaryDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "BeneficiaryId");

                log.Debug(BeneficiaryDTO.FormatBeneficiaryDTO(dto)); 

                R_Beneficiary t = BeneficiaryDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateBeneficiary(t);

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

    