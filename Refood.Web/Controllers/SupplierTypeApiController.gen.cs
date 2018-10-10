
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
    [RoutePrefix("api/SupplierTypeApi")]
    public partial class SupplierTypeApiController : ApiController
    {
        private readonly ISupplierTypeService _supplierTypeService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SupplierTypeApiController(ISupplierTypeService supplierTypeService)
        {
            this._supplierTypeService = supplierTypeService;
        }

        public SupplierTypeApiController() : this(new SupplierTypeService()) { }

        /// <summary>
        /// Delete SupplierType by id
        /// </summary>
        /// <param name="id">SupplierType id</param>
        /// <returns>true if the SupplierType is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_supplierTypeService.DeleteSupplierType - supplierTypeId: " + id + " "); 

                _supplierTypeService.DeleteSupplierType(id);

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
        /// Get SupplierType by id
        /// </summary>
        /// <param name="id">SupplierType id</param>
        /// <returns>SupplierType json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_supplierTypeService.GetSupplierType - supplierTypeId: " + id + " "); 

                var supplierType = new SupplierTypeViewModel(_supplierTypeService.GetSupplierType(id));

                log.Debug("_supplierTypeService.GetSupplierType - " + SupplierTypeViewModel.FormatSupplierTypeViewModel(supplierType)); 

                log.Debug("result: 'success'"); 

                //return Json(supplierType, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(supplierType), "application/json");
                //return supplierType;
                //return JsonConvert.SerializeObject(supplierType);
                return Ok(supplierType);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of SupplierTypes
        /// </summary>
        /// <returns>json list of SupplierType view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<SupplierTypeViewModel> supplierTypes;

                log.Debug("_supplierTypeService.GetSupplierTypes"); 

                // add edit url
                supplierTypes = _supplierTypeService.GetSupplierTypes()
                        .Select(supplierType => new SupplierTypeViewModel(supplierType, GetEditUrl(supplierType.SupplierTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (supplierTypes != null ? supplierTypes.Count().ToString() : "null")); 

                //return Json(supplierTypes, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(supplierTypes), "application/json");
                //return JsonConvert.SerializeObject(supplierTypes);
                return Ok(supplierTypes);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of SupplierTypes
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of SupplierTypes</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<SupplierTypeViewModel> supplierTypes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_supplierTypeService.GetSupplierTypes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                supplierTypes = _supplierTypeService.GetSupplierTypes(searchTerm, pageIndex, pageSize)
                        .Select(supplierType => new SupplierTypeViewModel(supplierType, GetEditUrl(supplierType.SupplierTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (supplierTypes != null ? supplierTypes.Count().ToString() : "null")); 

                //return Json(supplierTypes, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(supplierTypes);
                return Ok(supplierTypes);
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
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetSupplierTypeListAdvancedSearch"); 

                IEnumerable<SupplierTypeDTO> resultsDTO = _supplierTypeService.GetSupplierTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<SupplierTypeViewModel> supplierTypeList = resultsDTO.Select(supplierType => new SupplierTypeViewModel(supplierType, GetEditUrl(supplierType.SupplierTypeId))).ToList();

                log.Debug("result: 'success', count: " + (supplierTypeList != null ? supplierTypeList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(supplierTypeList), "application/json");
                //return JsonConvert.SerializeObject(supplierTypeList);
                return Ok(supplierTypeList);
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
            string editUrl = Url.Content("~/SupplierType/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing SupplierType, or creates a new SupplierType if the Id is 0
        /// </summary>
        /// <param name="viewModel">SupplierType data</param>
        /// <returns>SupplierType id</returns>
        public IHttpActionResult Upsert(SupplierTypeViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.SupplierTypeId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.SupplierTypeId);
                return Ok(t.SupplierTypeId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.SupplierTypeId);
                //return JsonConvert.SerializeObject(t.SupplierTypeId);
                return Ok(t.SupplierTypeId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of SupplierType
        /// </summary>
        /// <param name="viewModels">SupplierType view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(SupplierTypeViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(SupplierTypeViewModel viewModel in viewModels)
                    {
                        log.Debug(SupplierTypeViewModel.FormatSupplierTypeViewModel(viewModel)); 

                        if (viewModel.SupplierTypeId > 0)
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

        private SupplierTypeDTO Create(SupplierTypeViewModel viewModel)
        {
            try
            {
                log.Debug(SupplierTypeViewModel.FormatSupplierTypeViewModel(viewModel)); 

                SupplierTypeDTO supplierType = new SupplierTypeDTO();

                // copy values
                viewModel.UpdateDTO(supplierType, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                supplierType.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                supplierType.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_supplierTypeService.AddSupplierType - " + SupplierTypeDTO.FormatSupplierTypeDTO(supplierType)); 

                int id = _supplierTypeService.AddSupplierType(supplierType);

                supplierType.SupplierTypeId = id;

                log.Debug("result: 'success', id: " + id); 

                return supplierType;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private SupplierTypeDTO Update(SupplierTypeViewModel viewModel)
        {
            try
            {
                log.Debug(SupplierTypeViewModel.FormatSupplierTypeViewModel(viewModel)); 

                // get
                log.Debug("_supplierTypeService.GetSupplierType - supplierTypeId: " + viewModel.SupplierTypeId + " "); 

                var existingSupplierType = _supplierTypeService.GetSupplierType(viewModel.SupplierTypeId);

                log.Debug("_supplierTypeService.GetSupplierType - " + SupplierTypeDTO.FormatSupplierTypeDTO(existingSupplierType)); 

                if (existingSupplierType != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingSupplierType, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_supplierTypeService.UpdateSupplierType - " + SupplierTypeDTO.FormatSupplierTypeDTO(existingSupplierType)); 

                    _supplierTypeService.UpdateSupplierType(existingSupplierType);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingSupplierType: null, SupplierTypeId: " + viewModel.SupplierTypeId); 
                }

                return existingSupplierType;
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

    