
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
    public partial class FoodTemplateService :  IFoodTemplateService
    {
        public static IFoodTemplateRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FoodTemplateService()
        {
            if (Repository == null)
            {
                Repository = new FoodTemplateRepository();
            }
        }

        public int AddFoodTemplate(FoodTemplateDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(FoodTemplateDTO.FormatFoodTemplateDTO(dto)); 

                R_FoodTemplate t = FoodTemplateDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddFoodTemplate(t);
                dto.FoodTemplateId = id;

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

        public void DeleteFoodTemplate(FoodTemplateDTO dto)
        {
            try
            {
                log.Debug(FoodTemplateDTO.FormatFoodTemplateDTO(dto)); 
            
                R_FoodTemplate t = FoodTemplateDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteFoodTemplate(t);
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

        public void DeleteFoodTemplate(int foodTemplateId)
        {
            try
            {
                log.Debug("foodTemplateId: " + foodTemplateId + " "); 

                // delete
                Repository.DeleteFoodTemplate(foodTemplateId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public FoodTemplateDTO GetFoodTemplate(int foodTemplateId)
        {
            try
            {
                //Requires.NotNegative("foodTemplateId", foodTemplateId);
                
                log.Debug("foodTemplateId: " + foodTemplateId + " "); 

                // get
                R_FoodTemplate t = Repository.GetFoodTemplate(foodTemplateId);

                FoodTemplateDTO dto = new FoodTemplateDTO(t);

                log.Debug(FoodTemplateDTO.FormatFoodTemplateDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<FoodTemplateDTO> GetFoodTemplates()
        {
            try
            {
                
                log.Debug("GetFoodTemplates"); 

                // get
                IEnumerable<R_FoodTemplate> results = Repository.GetFoodTemplates();

                IEnumerable<FoodTemplateDTO> resultsDTO = results.Select(e => new FoodTemplateDTO(e));

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

        public IList<FoodTemplateDTO> GetFoodTemplates(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_FoodTemplate> results = Repository.GetFoodTemplates(searchTerm, pageIndex, pageSize);
            
                IList<FoodTemplateDTO> resultsDTO = results.Select(e => new FoodTemplateDTO(e)).ToList();

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

        public IEnumerable<FoodTemplateDTO> GetFoodTemplateListAdvancedSearch(
             string name 
            , string description 
            , string foodCategory 
            , int? calories 
            , System.DateTime? averageExpirationTimeFrom 
            , System.DateTime? averageExpirationTimeTo 
            , bool? liquid 
            , bool? needsRefrigeration 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetFoodTemplateListAdvancedSearch"); 

                IEnumerable<R_FoodTemplate> results = Repository.GetFoodTemplateListAdvancedSearch(
                     name 
                    , description 
                    , foodCategory 
                    , calories 
                    , averageExpirationTimeFrom 
                    , averageExpirationTimeTo 
                    , liquid 
                    , needsRefrigeration 
                    , active 
                );
            
                IEnumerable<FoodTemplateDTO> resultsDTO = results.Select(e => new FoodTemplateDTO(e));

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

        public void UpdateFoodTemplate(FoodTemplateDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "FoodTemplateId");

                log.Debug(FoodTemplateDTO.FormatFoodTemplateDTO(dto)); 

                R_FoodTemplate t = FoodTemplateDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateFoodTemplate(t);

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

    