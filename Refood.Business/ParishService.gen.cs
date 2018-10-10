
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
    public partial class ParishService :  IParishService
    {
        public static IParishRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParishService()
        {
            if (Repository == null)
            {
                Repository = new ParishRepository();
            }
        }

        public int AddParish(ParishDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ParishDTO.FormatParishDTO(dto)); 

                R_Parish t = ParishDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddParish(t);
                dto.ParishId = id;

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

        public void DeleteParish(ParishDTO dto)
        {
            try
            {
                log.Debug(ParishDTO.FormatParishDTO(dto)); 
            
                R_Parish t = ParishDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteParish(t);
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

        public void DeleteParish(int parishId)
        {
            try
            {
                log.Debug("parishId: " + parishId + " "); 

                // delete
                Repository.DeleteParish(parishId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ParishDTO GetParish(int parishId)
        {
            try
            {
                //Requires.NotNegative("parishId", parishId);
                
                log.Debug("parishId: " + parishId + " "); 

                // get
                R_Parish t = Repository.GetParish(parishId);

                ParishDTO dto = new ParishDTO(t);

                log.Debug(ParishDTO.FormatParishDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ParishDTO> GetParishs()
        {
            try
            {
                
                log.Debug("GetParishs"); 

                // get
                IEnumerable<R_Parish> results = Repository.GetParishs();

                IEnumerable<ParishDTO> resultsDTO = results.Select(e => new ParishDTO(e));

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

        public IList<ParishDTO> GetParishs(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Parish> results = Repository.GetParishs(searchTerm, pageIndex, pageSize);
            
                IList<ParishDTO> resultsDTO = results.Select(e => new ParishDTO(e)).ToList();

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

        public IEnumerable<ParishDTO> GetParishListAdvancedSearch(
             int? countyId 
            , int? districtId 
            , int? countryId 
            , string name 
            , string code 
            , double? latitude 
            , double? longitude 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetParishListAdvancedSearch"); 

                IEnumerable<R_Parish> results = Repository.GetParishListAdvancedSearch(
                     countyId 
                    , districtId 
                    , countryId 
                    , name 
                    , code 
                    , latitude 
                    , longitude 
                    , active 
                );
            
                IEnumerable<ParishDTO> resultsDTO = results.Select(e => new ParishDTO(e));

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

        public void UpdateParish(ParishDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ParishId");

                log.Debug(ParishDTO.FormatParishDTO(dto)); 

                R_Parish t = ParishDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateParish(t);

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

    