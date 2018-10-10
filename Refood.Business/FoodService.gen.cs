
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
    public partial class FoodService :  IFoodService
    {
        public static IFoodRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FoodService()
        {
            if (Repository == null)
            {
                Repository = new FoodRepository();
            }
        }

        public int AddFood(FoodDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(FoodDTO.FormatFoodDTO(dto)); 

                R_Food t = FoodDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddFood(t);
                dto.FoodId = id;

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

        public void DeleteFood(FoodDTO dto)
        {
            try
            {
                log.Debug(FoodDTO.FormatFoodDTO(dto)); 
            
                R_Food t = FoodDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteFood(t);
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

        public void DeleteFood(int foodId)
        {
            try
            {
                log.Debug("foodId: " + foodId + " "); 

                // delete
                Repository.DeleteFood(foodId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public FoodDTO GetFood(int foodId)
        {
            try
            {
                //Requires.NotNegative("foodId", foodId);
                
                log.Debug("foodId: " + foodId + " "); 

                // get
                R_Food t = Repository.GetFood(foodId);

                FoodDTO dto = new FoodDTO(t);

                log.Debug(FoodDTO.FormatFoodDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<FoodDTO> GetFoods()
        {
            try
            {
                
                log.Debug("GetFoods"); 

                // get
                IEnumerable<R_Food> results = Repository.GetFoods();

                IEnumerable<FoodDTO> resultsDTO = results.Select(e => new FoodDTO(e));

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

        public IList<FoodDTO> GetFoods(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Food> results = Repository.GetFoods(searchTerm, pageIndex, pageSize);
            
                IList<FoodDTO> resultsDTO = results.Select(e => new FoodDTO(e)).ToList();

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

        public IEnumerable<FoodDTO> GetFoodListAdvancedSearch(
             string name 
            , double? quantity 
            , int? foodTemplateId 
            , string specificObservations 
            , string location 
            , int? progress 
            , bool? expired 
            , bool? liquid 
            , int? rating 
            , string feedbackFromBeneficiary 
            , int? deliveredBy 
            , int? deliveredTo 
            , System.DateTime? orderDateTimeFrom 
            , System.DateTime? orderDateTimeTo 
            , System.DateTime? cookedDateTimeFrom 
            , System.DateTime? cookedDateTimeTo 
            , System.DateTime? pickupDateTimeFrom 
            , System.DateTime? pickupDateTimeTo 
            , System.DateTime? storageDateTimeFrom 
            , System.DateTime? storageDateTimeTo 
            , System.DateTime? deliveryDateTimeFrom 
            , System.DateTime? deliveryDateTimeTo 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetFoodListAdvancedSearch"); 

                IEnumerable<R_Food> results = Repository.GetFoodListAdvancedSearch(
                     name 
                    , quantity 
                    , foodTemplateId 
                    , specificObservations 
                    , location 
                    , progress 
                    , expired 
                    , liquid 
                    , rating 
                    , feedbackFromBeneficiary 
                    , deliveredBy 
                    , deliveredTo 
                    , orderDateTimeFrom 
                    , orderDateTimeTo 
                    , cookedDateTimeFrom 
                    , cookedDateTimeTo 
                    , pickupDateTimeFrom 
                    , pickupDateTimeTo 
                    , storageDateTimeFrom 
                    , storageDateTimeTo 
                    , deliveryDateTimeFrom 
                    , deliveryDateTimeTo 
                    , active 
                );
            
                IEnumerable<FoodDTO> resultsDTO = results.Select(e => new FoodDTO(e));

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

        public void UpdateFood(FoodDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "FoodId");

                log.Debug(FoodDTO.FormatFoodDTO(dto)); 

                R_Food t = FoodDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateFood(t);

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

    