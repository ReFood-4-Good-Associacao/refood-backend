
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
    [RoutePrefix("api/Beneficiary")]
    public partial class BeneficiaryApiController : ApiController
    {
        private readonly IBeneficiaryService _beneficiaryService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BeneficiaryApiController(IBeneficiaryService beneficiaryService)
        {
            this._beneficiaryService = beneficiaryService;
        }

        public BeneficiaryApiController() : this(new BeneficiaryService()) { }

        /// <summary>
        /// Delete Beneficiary by id
        /// </summary>
        /// <param name="id">Beneficiary id</param>
        /// <returns>true if the Beneficiary is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_beneficiaryService.DeleteBeneficiary - beneficiaryId: " + id + " "); 

                _beneficiaryService.DeleteBeneficiary(id);

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
        /// Get Beneficiary by id
        /// </summary>
        /// <param name="id">Beneficiary id</param>
        /// <returns>Beneficiary json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_beneficiaryService.GetBeneficiary - beneficiaryId: " + id + " "); 

                var beneficiary = new BeneficiaryViewModel(_beneficiaryService.GetBeneficiary(id));

                log.Debug("_beneficiaryService.GetBeneficiary - " + BeneficiaryViewModel.FormatBeneficiaryViewModel(beneficiary)); 

                log.Debug("result: 'success'"); 

                //return Json(beneficiary, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(beneficiary), "application/json");
                //return beneficiary;
                //return JsonConvert.SerializeObject(beneficiary);
                return Ok(beneficiary);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Beneficiarys
        /// </summary>
        /// <returns>json list of Beneficiary view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<BeneficiaryViewModel> beneficiarys;

                log.Debug("_beneficiaryService.GetBeneficiarys"); 

                // add edit url
                beneficiarys = _beneficiaryService.GetBeneficiarys()
                        .Select(beneficiary => new BeneficiaryViewModel(beneficiary, GetEditUrl(beneficiary.BeneficiaryId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (beneficiarys != null ? beneficiarys.Count().ToString() : "null")); 

                //return Json(beneficiarys, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(beneficiarys), "application/json");
                //return JsonConvert.SerializeObject(beneficiarys);
                return Ok(beneficiarys);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Beneficiarys
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Beneficiarys</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<BeneficiaryViewModel> beneficiarys;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_beneficiaryService.GetBeneficiarys - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                beneficiarys = _beneficiaryService.GetBeneficiarys(searchTerm, pageIndex, pageSize)
                        .Select(beneficiary => new BeneficiaryViewModel(beneficiary, GetEditUrl(beneficiary.BeneficiaryId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (beneficiarys != null ? beneficiarys.Count().ToString() : "null")); 

                //return Json(beneficiarys, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(beneficiarys);
                return Ok(beneficiarys);
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
            , int? number = null 
            , int? addressId = null 
            , int? numberOfAdults = null 
            , int? numberOfChildren = null 
            , int? numberOfTupperware = null 
            , int? numberOfSoups = null 
            , string description = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetBeneficiaryListAdvancedSearch"); 

                IEnumerable<BeneficiaryDTO> resultsDTO = _beneficiaryService.GetBeneficiaryListAdvancedSearch(
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
            
                // convert to view model list, and add edit url
                List<BeneficiaryViewModel> beneficiaryList = resultsDTO.Select(beneficiary => new BeneficiaryViewModel(beneficiary, GetEditUrl(beneficiary.BeneficiaryId))).ToList();

                log.Debug("result: 'success', count: " + (beneficiaryList != null ? beneficiaryList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(beneficiaryList), "application/json");
                //return JsonConvert.SerializeObject(beneficiaryList);
                return Ok(beneficiaryList);
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
            string editUrl = Url.Content("~/Beneficiary/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Beneficiary, or creates a new Beneficiary if the Id is 0
        /// </summary>
        /// <param name="viewModel">Beneficiary data</param>
        /// <returns>Beneficiary id</returns>
        public IHttpActionResult Upsert(BeneficiaryViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.BeneficiaryId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.BeneficiaryId);
                return Ok(t.BeneficiaryId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.BeneficiaryId);
                //return JsonConvert.SerializeObject(t.BeneficiaryId);
                return Ok(t.BeneficiaryId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Beneficiary
        /// </summary>
        /// <param name="viewModels">Beneficiary view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(BeneficiaryViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(BeneficiaryViewModel viewModel in viewModels)
                    {
                        log.Debug(BeneficiaryViewModel.FormatBeneficiaryViewModel(viewModel)); 

                        if (viewModel.BeneficiaryId > 0)
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

        private BeneficiaryDTO Create(BeneficiaryViewModel viewModel)
        {
            try
            {
                log.Debug(BeneficiaryViewModel.FormatBeneficiaryViewModel(viewModel)); 

                BeneficiaryDTO beneficiary = new BeneficiaryDTO();

                // copy values
                viewModel.UpdateDTO(beneficiary, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                beneficiary.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                beneficiary.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_beneficiaryService.AddBeneficiary - " + BeneficiaryDTO.FormatBeneficiaryDTO(beneficiary)); 

                int id = _beneficiaryService.AddBeneficiary(beneficiary);

                beneficiary.BeneficiaryId = id;

                log.Debug("result: 'success', id: " + id); 

                return beneficiary;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private BeneficiaryDTO Update(BeneficiaryViewModel viewModel)
        {
            try
            {
                log.Debug(BeneficiaryViewModel.FormatBeneficiaryViewModel(viewModel)); 

                // get
                log.Debug("_beneficiaryService.GetBeneficiary - beneficiaryId: " + viewModel.BeneficiaryId + " "); 

                var existingBeneficiary = _beneficiaryService.GetBeneficiary(viewModel.BeneficiaryId);

                log.Debug("_beneficiaryService.GetBeneficiary - " + BeneficiaryDTO.FormatBeneficiaryDTO(existingBeneficiary)); 

                if (existingBeneficiary != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingBeneficiary, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_beneficiaryService.UpdateBeneficiary - " + BeneficiaryDTO.FormatBeneficiaryDTO(existingBeneficiary)); 

                    _beneficiaryService.UpdateBeneficiary(existingBeneficiary);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingBeneficiary: null, BeneficiaryId: " + viewModel.BeneficiaryId); 
                }

                return existingBeneficiary;
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

    