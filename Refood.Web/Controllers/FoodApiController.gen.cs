
// ################################################################
//                      Code generated with T4
// ################################################################

using Refood.Web.Services.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    //[Authorize]
    [RoutePrefix("api/FoodApi")]
    public partial class FoodApiController : ApiController
    {
        private readonly IFoodService _foodService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FoodApiController(IFoodService foodService)
        {
            this._foodService = foodService;
        }

        public FoodApiController() : this(new FoodService()) { }

        /// <summary>
        /// Delete Food by id
        /// </summary>
        /// <param name="id">Food id</param>
        /// <returns>true if the Food is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_foodService.DeleteFood - foodId: " + id + " "); 

                _foodService.DeleteFood(id);

                log.Debug("result: 'success'"); 

                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get Food by id
        /// </summary>
        /// <param name="id">Food id</param>
        /// <returns>Food json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_foodService.GetFood - foodId: " + id + " "); 

                var food = new FoodViewModel(_foodService.GetFood(id));

                log.Debug("_foodService.GetFood - " + FoodViewModel.FormatFoodViewModel(food)); 

                log.Debug("result: 'success'"); 

                //return Json(food, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(food), "application/json");
                //return food;
                //return JsonConvert.SerializeObject(food);
                return Ok(food);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Foods
        /// </summary>
        /// <returns>json list of Food view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<FoodViewModel> foods;

                log.Debug("_foodService.GetFoods"); 

                // add edit url
                foods = _foodService.GetFoods()
                        .Select(food => new FoodViewModel(food, GetEditUrl(food.FoodId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (foods != null ? foods.Count().ToString() : "null")); 

                //return Json(foods, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(foods), "application/json");
                //return JsonConvert.SerializeObject(foods);
                return Ok(foods);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Foods
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Foods</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<FoodViewModel> foods;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_foodService.GetFoods - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                foods = _foodService.GetFoods(searchTerm, pageIndex, pageSize)
                        .Select(food => new FoodViewModel(food, GetEditUrl(food.FoodId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (foods != null ? foods.Count().ToString() : "null")); 

                //return Json(foods, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(foods);
                return Ok(foods);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetListAdvancedSearch(
            int id = 0 
            , string name = null 
            , double? quantity = null 
            , int? foodTemplateId = null 
            , string specificObservations = null 
            , string location = null 
            , int? progress = null 
            , bool? expired = null 
            , bool? liquid = null 
            , int? rating = null 
            , string feedbackFromBeneficiary = null 
            , int? deliveredBy = null 
            , int? deliveredTo = null 
            , System.DateTime? orderDateTimeFrom = null 
            , System.DateTime? orderDateTimeTo = null 
            , System.DateTime? cookedDateTimeFrom = null 
            , System.DateTime? cookedDateTimeTo = null 
            , System.DateTime? pickupDateTimeFrom = null 
            , System.DateTime? pickupDateTimeTo = null 
            , System.DateTime? storageDateTimeFrom = null 
            , System.DateTime? storageDateTimeTo = null 
            , System.DateTime? deliveryDateTimeFrom = null 
            , System.DateTime? deliveryDateTimeTo = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetFoodListAdvancedSearch"); 

                IEnumerable<FoodDTO> resultsDTO = _foodService.GetFoodListAdvancedSearch(
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
            
                // convert to view model list, and add edit url
                List<FoodViewModel> foodList = resultsDTO.Select(food => new FoodViewModel(food, GetEditUrl(food.FoodId))).ToList();

                log.Debug("result: 'success', count: " + (foodList != null ? foodList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(foodList), "application/json");
                //return JsonConvert.SerializeObject(foodList);
                return Ok(foodList);
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/Food/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Food, or creates a new Food if the Id is 0
        /// </summary>
        /// <param name="viewModel">Food data</param>
        /// <returns>Food id</returns>
        public IHttpActionResult Upsert(FoodViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.FoodId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.FoodId);
                return Ok(t.FoodId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.FoodId);
                //return JsonConvert.SerializeObject(t.FoodId);
                return Ok(t.FoodId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Food
        /// </summary>
        /// <param name="viewModels">Food view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(FoodViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(FoodViewModel viewModel in viewModels)
                    {
                        log.Debug(FoodViewModel.FormatFoodViewModel(viewModel)); 

                        if (viewModel.FoodId > 0)
                        {
                            var t = Update(viewModel);
                        }
                        else
                        {
                            var t = Create(viewModel);
                        }

                    }
                }
                else
                {
                    log.Error("viewModels: null"); 
                }

                //return Json(true);
                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private FoodDTO Create(FoodViewModel viewModel)
        {
            try
            {
                log.Debug(FoodViewModel.FormatFoodViewModel(viewModel)); 

                FoodDTO food = new FoodDTO();

                // copy values
                viewModel.UpdateDTO(food, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                food.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                food.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_foodService.AddFood - " + FoodDTO.FormatFoodDTO(food)); 

                int id = _foodService.AddFood(food);

                food.FoodId = id;

                log.Debug("result: 'success', id: " + id); 

                return food;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private FoodDTO Update(FoodViewModel viewModel)
        {
            try
            {
                log.Debug(FoodViewModel.FormatFoodViewModel(viewModel)); 

                // get
                log.Debug("_foodService.GetFood - foodId: " + viewModel.FoodId + " "); 

                var existingFood = _foodService.GetFood(viewModel.FoodId);

                log.Debug("_foodService.GetFood - " + FoodDTO.FormatFoodDTO(existingFood)); 

                if (existingFood != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingFood, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_foodService.UpdateFood - " + FoodDTO.FormatFoodDTO(existingFood)); 

                    _foodService.UpdateFood(existingFood);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingFood: null, FoodId: " + viewModel.FoodId); 
                }

                return existingFood;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    