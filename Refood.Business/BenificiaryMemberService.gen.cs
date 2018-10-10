
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
    public partial class BenificiaryMemberService :  IBenificiaryMemberService
    {
        public static IBenificiaryMemberRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BenificiaryMemberService()
        {
            if (Repository == null)
            {
                Repository = new BenificiaryMemberRepository();
            }
        }

        public int AddBenificiaryMember(BenificiaryMemberDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(BenificiaryMemberDTO.FormatBenificiaryMemberDTO(dto)); 

                R_BenificiaryMember t = BenificiaryMemberDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddBenificiaryMember(t);

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

        public void DeleteBenificiaryMember(BenificiaryMemberDTO dto)
        {
            try
            {
                log.Debug(BenificiaryMemberDTO.FormatBenificiaryMemberDTO(dto)); 
            
                R_BenificiaryMember t = BenificiaryMemberDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteBenificiaryMember(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteBenificiaryMember(int benificiaryMemberId)
        {
            try
            {
                log.Debug("benificiaryMemberId: " + benificiaryMemberId + " "); 

                // delete
                Repository.DeleteBenificiaryMember(benificiaryMemberId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public BenificiaryMemberDTO GetBenificiaryMember(int benificiaryMemberId)
        {
            try
            {
                //Requires.NotNegative("benificiaryMemberId", benificiaryMemberId);
                
                log.Debug("benificiaryMemberId: " + benificiaryMemberId + " "); 

                // get
                R_BenificiaryMember t = Repository.GetBenificiaryMember(benificiaryMemberId);

                BenificiaryMemberDTO dto = new BenificiaryMemberDTO(t);

                log.Debug(BenificiaryMemberDTO.FormatBenificiaryMemberDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<BenificiaryMemberDTO> GetBenificiaryMembers()
        {
            try
            {
                
                log.Debug("GetBenificiaryMembers"); 

                // get
                IEnumerable<R_BenificiaryMember> results = Repository.GetBenificiaryMembers();

                IEnumerable<BenificiaryMemberDTO> resultsDTO = results.Select(e => new BenificiaryMemberDTO(e));

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

        public IList<BenificiaryMemberDTO> GetBenificiaryMembers(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_BenificiaryMember> results = Repository.GetBenificiaryMembers(searchTerm, pageIndex, pageSize);
            
                IList<BenificiaryMemberDTO> resultsDTO = results.Select(e => new BenificiaryMemberDTO(e)).ToList();

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

        public void UpdateBenificiaryMember(BenificiaryMemberDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "BenificiaryMemberId");

                log.Debug(BenificiaryMemberDTO.FormatBenificiaryMemberDTO(dto)); 

                R_BenificiaryMember t = BenificiaryMemberDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateBenificiaryMember(t);

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

    