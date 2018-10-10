
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
    public partial class RefoodUserService :  IRefoodUserService
    {
        public static IRefoodUserRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RefoodUserService()
        {
            if (Repository == null)
            {
                Repository = new RefoodUserRepository();
            }
        }

        public int AddRefoodUser(RefoodUserDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(RefoodUserDTO.FormatRefoodUserDTO(dto)); 

                R_RefoodUser t = RefoodUserDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddRefoodUser(t);
                dto.RefoodUserId = id;

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

        public void DeleteRefoodUser(RefoodUserDTO dto)
        {
            try
            {
                log.Debug(RefoodUserDTO.FormatRefoodUserDTO(dto)); 
            
                R_RefoodUser t = RefoodUserDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteRefoodUser(t);
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

        public void DeleteRefoodUser(int refoodUserId)
        {
            try
            {
                log.Debug("refoodUserId: " + refoodUserId + " "); 

                // delete
                Repository.DeleteRefoodUser(refoodUserId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public RefoodUserDTO GetRefoodUser(int refoodUserId)
        {
            try
            {
                //Requires.NotNegative("refoodUserId", refoodUserId);
                
                log.Debug("refoodUserId: " + refoodUserId + " "); 

                // get
                R_RefoodUser t = Repository.GetRefoodUser(refoodUserId);

                RefoodUserDTO dto = new RefoodUserDTO(t);

                log.Debug(RefoodUserDTO.FormatRefoodUserDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<RefoodUserDTO> GetRefoodUsers()
        {
            try
            {
                
                log.Debug("GetRefoodUsers"); 

                // get
                IEnumerable<R_RefoodUser> results = Repository.GetRefoodUsers();

                IEnumerable<RefoodUserDTO> resultsDTO = results.Select(e => new RefoodUserDTO(e));

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

        public IList<RefoodUserDTO> GetRefoodUsers(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_RefoodUser> results = Repository.GetRefoodUsers(searchTerm, pageIndex, pageSize);
            
                IList<RefoodUserDTO> resultsDTO = results.Select(e => new RefoodUserDTO(e)).ToList();

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

        public IEnumerable<RefoodUserDTO> GetRefoodUserListAdvancedSearch(
             string username 
            , string fullname 
            , string email 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetRefoodUserListAdvancedSearch"); 

                IEnumerable<R_RefoodUser> results = Repository.GetRefoodUserListAdvancedSearch(
                     username 
                    , fullname 
                    , email 
                    , active 
                );
            
                IEnumerable<RefoodUserDTO> resultsDTO = results.Select(e => new RefoodUserDTO(e));

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

        public void UpdateRefoodUser(RefoodUserDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "RefoodUserId");

                log.Debug(RefoodUserDTO.FormatRefoodUserDTO(dto)); 

                R_RefoodUser t = RefoodUserDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateRefoodUser(t);

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

    