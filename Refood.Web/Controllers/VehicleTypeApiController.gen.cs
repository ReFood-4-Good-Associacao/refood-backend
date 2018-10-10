
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
    [RoutePrefix("api/VehicleType")]
    public partial class VehicleTypeApiController : ApiController
    {
        private readonly IVehicleTypeService _vehicleTypeService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VehicleTypeApiController(IVehicleTypeService vehicleTypeService)
        {
            this._vehicleTypeService = vehicleTypeService;
        }

        public VehicleTypeApiController() : this(new VehicleTypeService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_vehicleTypeService.DeleteVehicleType - vehicleTypeId: " + id + " "); 

                _vehicleTypeService.DeleteVehicleType(id);

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
                log.Debug("_vehicleTypeService.GetVehicleType - vehicleTypeId: " + id + " "); 

                var vehicleType = new VehicleTypeViewModel(_vehicleTypeService.GetVehicleType(id));

                log.Debug("_vehicleTypeService.GetVehicleType - " + VehicleTypeViewModel.FormatVehicleTypeViewModel(vehicleType)); 

                log.Debug("result: 'success'"); 

                //return Json(vehicleType, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(vehicleType), "application/json");
                //return vehicleType;
                //return JsonConvert.SerializeObject(vehicleType);
                return Ok(vehicleType);
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
                List<VehicleTypeViewModel> vehicleTypes;

                log.Debug("_vehicleTypeService.GetVehicleTypes"); 

                // add edit url
                vehicleTypes = _vehicleTypeService.GetVehicleTypes()
                        .Select(vehicleType => new VehicleTypeViewModel(vehicleType, GetEditUrl(vehicleType.VehicleTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (vehicleTypes != null ? vehicleTypes.Count().ToString() : "null")); 

                //return Json(vehicleTypes, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(vehicleTypes), "application/json");
                //return JsonConvert.SerializeObject(vehicleTypes);
                return Ok(vehicleTypes);
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
                List<VehicleTypeViewModel> vehicleTypes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_vehicleTypeService.GetVehicleTypes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                vehicleTypes = _vehicleTypeService.GetVehicleTypes(searchTerm, pageIndex, pageSize)
                        .Select(vehicleType => new VehicleTypeViewModel(vehicleType, GetEditUrl(vehicleType.VehicleTypeId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (vehicleTypes != null ? vehicleTypes.Count().ToString() : "null")); 

                //return Json(vehicleTypes, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(vehicleTypes);
                return Ok(vehicleTypes);
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

                log.Debug("GetVehicleTypeListAdvancedSearch"); 

                IEnumerable<VehicleTypeDTO> resultsDTO = _vehicleTypeService.GetVehicleTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<VehicleTypeViewModel> vehicleTypeList = resultsDTO.Select(vehicleType => new VehicleTypeViewModel(vehicleType, GetEditUrl(vehicleType.VehicleTypeId))).ToList();

                log.Debug("result: 'success', count: " + (vehicleTypeList != null ? vehicleTypeList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(vehicleTypeList), "application/json");
                //return JsonConvert.SerializeObject(vehicleTypeList);
                return Ok(vehicleTypeList);
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
            string editUrl = Url.Content("~/VehicleType/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(VehicleTypeViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.VehicleTypeId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.VehicleTypeId);
                return Ok(t.VehicleTypeId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.VehicleTypeId);
                //return JsonConvert.SerializeObject(t.VehicleTypeId);
                return Ok(t.VehicleTypeId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(VehicleTypeViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(VehicleTypeViewModel viewModel in viewModels)
                    {
                        log.Debug(VehicleTypeViewModel.FormatVehicleTypeViewModel(viewModel)); 

                        if (viewModel.VehicleTypeId > 0)
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

        private VehicleTypeDTO Create(VehicleTypeViewModel viewModel)
        {
            try
            {
                log.Debug(VehicleTypeViewModel.FormatVehicleTypeViewModel(viewModel)); 

                VehicleTypeDTO vehicleType = new VehicleTypeDTO();

                // copy values
                viewModel.UpdateDTO(vehicleType, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                vehicleType.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                vehicleType.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_vehicleTypeService.AddVehicleType - " + VehicleTypeDTO.FormatVehicleTypeDTO(vehicleType)); 

                int id = _vehicleTypeService.AddVehicleType(vehicleType);

                vehicleType.VehicleTypeId = id;

                log.Debug("result: 'success', id: " + id); 

                return vehicleType;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private VehicleTypeDTO Update(VehicleTypeViewModel viewModel)
        {
            try
            {
                log.Debug(VehicleTypeViewModel.FormatVehicleTypeViewModel(viewModel)); 

                // get
                log.Debug("_vehicleTypeService.GetVehicleType - vehicleTypeId: " + viewModel.VehicleTypeId + " "); 

                var existingVehicleType = _vehicleTypeService.GetVehicleType(viewModel.VehicleTypeId);

                log.Debug("_vehicleTypeService.GetVehicleType - " + VehicleTypeDTO.FormatVehicleTypeDTO(existingVehicleType)); 

                if (existingVehicleType != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingVehicleType, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_vehicleTypeService.UpdateVehicleType - " + VehicleTypeDTO.FormatVehicleTypeDTO(existingVehicleType)); 

                    _vehicleTypeService.UpdateVehicleType(existingVehicleType);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingVehicleType: null, VehicleTypeId: " + viewModel.VehicleTypeId); 
                }

                return existingVehicleType;
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

    