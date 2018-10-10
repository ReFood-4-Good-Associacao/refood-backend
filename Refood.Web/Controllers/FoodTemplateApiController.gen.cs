
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
    [RoutePrefix("api/FoodTemplate")]
    public partial class FoodTemplateApiController : ApiController
    {
        private readonly IFoodTemplateService _foodTemplateService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FoodTemplateApiController(IFoodTemplateService foodTemplateService)
        {
            this._foodTemplateService = foodTemplateService;
        }

        public FoodTemplateApiController() : this(new FoodTemplateService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_foodTemplateService.DeleteFoodTemplate - foodTemplateId: " + id + " "); 

                _foodTemplateService.DeleteFoodTemplate(id);

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

        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_foodTemplateService.GetFoodTemplate - foodTemplateId: " + id + " "); 

                var foodTemplate = new FoodTemplateViewModel(_foodTemplateService.GetFoodTemplate(id));

                log.Debug("_foodTemplateService.GetFoodTemplate - " + FoodTemplateViewModel.FormatFoodTemplateViewModel(foodTemplate)); 

                log.Debug("result: 'success'"); 

                //return Json(foodTemplate, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(foodTemplate), "application/json");
                //return foodTemplate;
                //return JsonConvert.SerializeObject(foodTemplate);
                return Ok(foodTemplate);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<FoodTemplateViewModel> foodTemplates;

                log.Debug("_foodTemplateService.GetFoodTemplates"); 

                // add edit url
                foodTemplates = _foodTemplateService.GetFoodTemplates()
                        .Select(foodTemplate => new FoodTemplateViewModel(foodTemplate, GetEditUrl(foodTemplate.FoodTemplateId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (foodTemplates != null ? foodTemplates.Count().ToString() : "null")); 

                //return Json(foodTemplates, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(foodTemplates), "application/json");
                //return JsonConvert.SerializeObject(foodTemplates);
                return Ok(foodTemplates);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<FoodTemplateViewModel> foodTemplates;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_foodTemplateService.GetFoodTemplates - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                foodTemplates = _foodTemplateService.GetFoodTemplates(searchTerm, pageIndex, pageSize)
                        .Select(foodTemplate => new FoodTemplateViewModel(foodTemplate, GetEditUrl(foodTemplate.FoodTemplateId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (foodTemplates != null ? foodTemplates.Count().ToString() : "null")); 

                //return Json(foodTemplates, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(foodTemplates);
                return Ok(foodTemplates);
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
            , string description = null 
            , string foodCategory = null 
            , int? calories = null 
            , System.DateTime? averageExpirationTimeFrom = null 
            , System.DateTime? averageExpirationTimeTo = null 
            , bool? liquid = null 
            , bool? needsRefrigeration = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetFoodTemplateListAdvancedSearch"); 

                IEnumerable<FoodTemplateDTO> resultsDTO = _foodTemplateService.GetFoodTemplateListAdvancedSearch(
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
            
                // convert to view model list, and add edit url
                List<FoodTemplateViewModel> foodTemplateList = resultsDTO.Select(foodTemplate => new FoodTemplateViewModel(foodTemplate, GetEditUrl(foodTemplate.FoodTemplateId))).ToList();

                log.Debug("result: 'success', count: " + (foodTemplateList != null ? foodTemplateList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(foodTemplateList), "application/json");
                //return JsonConvert.SerializeObject(foodTemplateList);
                return Ok(foodTemplateList);
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
            string editUrl = Url.Content("~/FoodTemplate/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(FoodTemplateViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.FoodTemplateId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.FoodTemplateId);
                return Ok(t.FoodTemplateId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.FoodTemplateId);
                //return JsonConvert.SerializeObject(t.FoodTemplateId);
                return Ok(t.FoodTemplateId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(FoodTemplateViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(FoodTemplateViewModel viewModel in viewModels)
                    {
                        log.Debug(FoodTemplateViewModel.FormatFoodTemplateViewModel(viewModel)); 

                        if (viewModel.FoodTemplateId > 0)
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

        private FoodTemplateDTO Create(FoodTemplateViewModel viewModel)
        {
            try
            {
                log.Debug(FoodTemplateViewModel.FormatFoodTemplateViewModel(viewModel)); 

                FoodTemplateDTO foodTemplate = new FoodTemplateDTO();

                // copy values
                viewModel.UpdateDTO(foodTemplate, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                foodTemplate.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                foodTemplate.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_foodTemplateService.AddFoodTemplate - " + FoodTemplateDTO.FormatFoodTemplateDTO(foodTemplate)); 

                int id = _foodTemplateService.AddFoodTemplate(foodTemplate);

                foodTemplate.FoodTemplateId = id;

                log.Debug("result: 'success', id: " + id); 

                return foodTemplate;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private FoodTemplateDTO Update(FoodTemplateViewModel viewModel)
        {
            try
            {
                log.Debug(FoodTemplateViewModel.FormatFoodTemplateViewModel(viewModel)); 

                // get
                log.Debug("_foodTemplateService.GetFoodTemplate - foodTemplateId: " + viewModel.FoodTemplateId + " "); 

                var existingFoodTemplate = _foodTemplateService.GetFoodTemplate(viewModel.FoodTemplateId);

                log.Debug("_foodTemplateService.GetFoodTemplate - " + FoodTemplateDTO.FormatFoodTemplateDTO(existingFoodTemplate)); 

                if (existingFoodTemplate != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingFoodTemplate, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_foodTemplateService.UpdateFoodTemplate - " + FoodTemplateDTO.FormatFoodTemplateDTO(existingFoodTemplate)); 

                    _foodTemplateService.UpdateFoodTemplate(existingFoodTemplate);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingFoodTemplate: null, FoodTemplateId: " + viewModel.FoodTemplateId); 
                }

                return existingFoodTemplate;
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

    