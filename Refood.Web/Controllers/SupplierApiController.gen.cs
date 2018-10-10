
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
    [RoutePrefix("api/Supplier")]
    public partial class SupplierApiController : ApiController
    {
        private readonly ISupplierService _supplierService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SupplierApiController(ISupplierService supplierService)
        {
            this._supplierService = supplierService;
        }

        public SupplierApiController() : this(new SupplierService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_supplierService.DeleteSupplier - supplierId: " + id + " "); 

                _supplierService.DeleteSupplier(id);

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
                log.Debug("_supplierService.GetSupplier - supplierId: " + id + " "); 

                var supplier = new SupplierViewModel(_supplierService.GetSupplier(id));

                log.Debug("_supplierService.GetSupplier - " + SupplierViewModel.FormatSupplierViewModel(supplier)); 

                log.Debug("result: 'success'"); 

                //return Json(supplier, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(supplier), "application/json");
                //return supplier;
                //return JsonConvert.SerializeObject(supplier);
                return Ok(supplier);
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
                List<SupplierViewModel> suppliers;

                log.Debug("_supplierService.GetSuppliers"); 

                // add edit url
                suppliers = _supplierService.GetSuppliers()
                        .Select(supplier => new SupplierViewModel(supplier, GetEditUrl(supplier.SupplierId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (suppliers != null ? suppliers.Count().ToString() : "null")); 

                //return Json(suppliers, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(suppliers), "application/json");
                //return JsonConvert.SerializeObject(suppliers);
                return Ok(suppliers);
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
                List<SupplierViewModel> suppliers;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_supplierService.GetSuppliers - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                suppliers = _supplierService.GetSuppliers(searchTerm, pageIndex, pageSize)
                        .Select(supplier => new SupplierViewModel(supplier, GetEditUrl(supplier.SupplierId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (suppliers != null ? suppliers.Count().ToString() : "null")); 

                //return Json(suppliers, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(suppliers);
                return Ok(suppliers);
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
            , int? supplierTypeId = null 
            , string phone = null 
            , string email = null 
            , double? latitude = null 
            , double? longitude = null 
            , string description = null 
            , string website = null 
            , int? addressId = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetSupplierListAdvancedSearch"); 

                IEnumerable<SupplierDTO> resultsDTO = _supplierService.GetSupplierListAdvancedSearch(
                     name 
                    , supplierTypeId 
                    , phone 
                    , email 
                    , latitude 
                    , longitude 
                    , description 
                    , website 
                    , addressId 
                );
            
                // convert to view model list, and add edit url
                List<SupplierViewModel> supplierList = resultsDTO.Select(supplier => new SupplierViewModel(supplier, GetEditUrl(supplier.SupplierId))).ToList();

                log.Debug("result: 'success', count: " + (supplierList != null ? supplierList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(supplierList), "application/json");
                //return JsonConvert.SerializeObject(supplierList);
                return Ok(supplierList);
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
            string editUrl = Url.Content("~/Supplier/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(SupplierViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.SupplierId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.SupplierId);
                return Ok(t.SupplierId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.SupplierId);
                //return JsonConvert.SerializeObject(t.SupplierId);
                return Ok(t.SupplierId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(SupplierViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(SupplierViewModel viewModel in viewModels)
                    {
                        log.Debug(SupplierViewModel.FormatSupplierViewModel(viewModel)); 

                        if (viewModel.SupplierId > 0)
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

        private SupplierDTO Create(SupplierViewModel viewModel)
        {
            try
            {
                log.Debug(SupplierViewModel.FormatSupplierViewModel(viewModel)); 

                SupplierDTO supplier = new SupplierDTO();

                // copy values
                viewModel.UpdateDTO(supplier, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                supplier.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                supplier.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_supplierService.AddSupplier - " + SupplierDTO.FormatSupplierDTO(supplier)); 

                int id = _supplierService.AddSupplier(supplier);

                supplier.SupplierId = id;

                log.Debug("result: 'success', id: " + id); 

                return supplier;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private SupplierDTO Update(SupplierViewModel viewModel)
        {
            try
            {
                log.Debug(SupplierViewModel.FormatSupplierViewModel(viewModel)); 

                // get
                log.Debug("_supplierService.GetSupplier - supplierId: " + viewModel.SupplierId + " "); 

                var existingSupplier = _supplierService.GetSupplier(viewModel.SupplierId);

                log.Debug("_supplierService.GetSupplier - " + SupplierDTO.FormatSupplierDTO(existingSupplier)); 

                if (existingSupplier != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingSupplier, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_supplierService.UpdateSupplier - " + SupplierDTO.FormatSupplierDTO(existingSupplier)); 

                    _supplierService.UpdateSupplier(existingSupplier);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingSupplier: null, SupplierId: " + viewModel.SupplierId); 
                }

                return existingSupplier;
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

    