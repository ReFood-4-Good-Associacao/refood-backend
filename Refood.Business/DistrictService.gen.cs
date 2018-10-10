
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
    public partial class DistrictService :  IDistrictService
    {
        public static IDistrictRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DistrictService()
        {
            if (Repository == null)
            {
                Repository = new DistrictRepository();
            }
        }

        public int AddDistrict(DistrictDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(DistrictDTO.FormatDistrictDTO(dto)); 

                R_District t = DistrictDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddDistrict(t);
                dto.DistrictId = id;

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

        public void DeleteDistrict(DistrictDTO dto)
        {
            try
            {
                log.Debug(DistrictDTO.FormatDistrictDTO(dto)); 
            
                R_District t = DistrictDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteDistrict(t);
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

        public void DeleteDistrict(int districtId)
        {
            try
            {
                log.Debug("districtId: " + districtId + " "); 

                // delete
                Repository.DeleteDistrict(districtId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public DistrictDTO GetDistrict(int districtId)
        {
            try
            {
                //Requires.NotNegative("districtId", districtId);
                
                log.Debug("districtId: " + districtId + " "); 

                // get
                R_District t = Repository.GetDistrict(districtId);

                DistrictDTO dto = new DistrictDTO(t);

                log.Debug(DistrictDTO.FormatDistrictDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<DistrictDTO> GetDistricts()
        {
            try
            {
                
                log.Debug("GetDistricts"); 

                // get
                IEnumerable<R_District> results = Repository.GetDistricts();

                IEnumerable<DistrictDTO> resultsDTO = results.Select(e => new DistrictDTO(e));

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

        public IList<DistrictDTO> GetDistricts(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_District> results = Repository.GetDistricts(searchTerm, pageIndex, pageSize);
            
                IList<DistrictDTO> resultsDTO = results.Select(e => new DistrictDTO(e)).ToList();

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

        public IEnumerable<DistrictDTO> GetDistrictListAdvancedSearch(
             int? countryId 
            , string name 
            , string code 
            , double? latitude 
            , double? longitude 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetDistrictListAdvancedSearch"); 

                IEnumerable<R_District> results = Repository.GetDistrictListAdvancedSearch(
                     countryId 
                    , name 
                    , code 
                    , latitude 
                    , longitude 
                    , active 
                );
            
                IEnumerable<DistrictDTO> resultsDTO = results.Select(e => new DistrictDTO(e));

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

        public void UpdateDistrict(DistrictDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "DistrictId");

                log.Debug(DistrictDTO.FormatDistrictDTO(dto)); 

                R_District t = DistrictDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateDistrict(t);

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

    