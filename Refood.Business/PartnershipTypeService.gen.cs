
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
    public partial class PartnershipTypeService :  IPartnershipTypeService
    {
        public static IPartnershipTypeRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PartnershipTypeService()
        {
            if (Repository == null)
            {
                Repository = new PartnershipTypeRepository();
            }
        }

        public int AddPartnershipType(PartnershipTypeDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(PartnershipTypeDTO.FormatPartnershipTypeDTO(dto)); 

                R_PartnershipType t = PartnershipTypeDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddPartnershipType(t);
                dto.PartnershipTypeId = id;

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

        public void DeletePartnershipType(PartnershipTypeDTO dto)
        {
            try
            {
                log.Debug(PartnershipTypeDTO.FormatPartnershipTypeDTO(dto)); 
            
                R_PartnershipType t = PartnershipTypeDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeletePartnershipType(t);
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

        public void DeletePartnershipType(int partnershipTypeId)
        {
            try
            {
                log.Debug("partnershipTypeId: " + partnershipTypeId + " "); 

                // delete
                Repository.DeletePartnershipType(partnershipTypeId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public PartnershipTypeDTO GetPartnershipType(int partnershipTypeId)
        {
            try
            {
                //Requires.NotNegative("partnershipTypeId", partnershipTypeId);
                
                log.Debug("partnershipTypeId: " + partnershipTypeId + " "); 

                // get
                R_PartnershipType t = Repository.GetPartnershipType(partnershipTypeId);

                PartnershipTypeDTO dto = new PartnershipTypeDTO(t);

                log.Debug(PartnershipTypeDTO.FormatPartnershipTypeDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<PartnershipTypeDTO> GetPartnershipTypes()
        {
            try
            {
                
                log.Debug("GetPartnershipTypes"); 

                // get
                IEnumerable<R_PartnershipType> results = Repository.GetPartnershipTypes();

                IEnumerable<PartnershipTypeDTO> resultsDTO = results.Select(e => new PartnershipTypeDTO(e));

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

        public IList<PartnershipTypeDTO> GetPartnershipTypes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_PartnershipType> results = Repository.GetPartnershipTypes(searchTerm, pageIndex, pageSize);
            
                IList<PartnershipTypeDTO> resultsDTO = results.Select(e => new PartnershipTypeDTO(e)).ToList();

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

        public IEnumerable<PartnershipTypeDTO> GetPartnershipTypeListAdvancedSearch(
             string name 
            , string description 
            , string activityType 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetPartnershipTypeListAdvancedSearch"); 

                IEnumerable<R_PartnershipType> results = Repository.GetPartnershipTypeListAdvancedSearch(
                     name 
                    , description 
                    , activityType 
                    , active 
                );
            
                IEnumerable<PartnershipTypeDTO> resultsDTO = results.Select(e => new PartnershipTypeDTO(e));

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

        public void UpdatePartnershipType(PartnershipTypeDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "PartnershipTypeId");

                log.Debug(PartnershipTypeDTO.FormatPartnershipTypeDTO(dto)); 

                R_PartnershipType t = PartnershipTypeDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdatePartnershipType(t);

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

    