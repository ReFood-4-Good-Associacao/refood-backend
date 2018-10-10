
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
    [RoutePrefix("api/VehicleApi")]
    public partial class VehicleApiController : ApiController
    {
        private readonly IVehicleService _vehicleService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VehicleApiController(IVehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }

        public VehicleApiController() : this(new VehicleService()) { }

        /// <summary>
        /// Delete Vehicle by id
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns>true if the Vehicle is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_vehicleService.DeleteVehicle - vehicleId: " + id + " "); 

                _vehicleService.DeleteVehicle(id);

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
        /// Get Vehicle by id
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns>Vehicle json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_vehicleService.GetVehicle - vehicleId: " + id + " "); 

                var vehicle = new VehicleViewModel(_vehicleService.GetVehicle(id));

                log.Debug("_vehicleService.GetVehicle - " + VehicleViewModel.FormatVehicleViewModel(vehicle)); 

                log.Debug("result: 'success'"); 

                //return Json(vehicle, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(vehicle), "application/json");
                //return vehicle;
                //return JsonConvert.SerializeObject(vehicle);
                return Ok(vehicle);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Vehicles
        /// </summary>
        /// <returns>json list of Vehicle view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<VehicleViewModel> vehicles;

                log.Debug("_vehicleService.GetVehicles"); 

                // add edit url
                vehicles = _vehicleService.GetVehicles()
                        .Select(vehicle => new VehicleViewModel(vehicle, GetEditUrl(vehicle.VehicleId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (vehicles != null ? vehicles.Count().ToString() : "null")); 

                //return Json(vehicles, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(vehicles), "application/json");
                //return JsonConvert.SerializeObject(vehicles);
                return Ok(vehicles);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Vehicles
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Vehicles</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<VehicleViewModel> vehicles;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_vehicleService.GetVehicles - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                vehicles = _vehicleService.GetVehicles(searchTerm, pageIndex, pageSize)
                        .Select(vehicle => new VehicleViewModel(vehicle, GetEditUrl(vehicle.VehicleId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (vehicles != null ? vehicles.Count().ToString() : "null")); 

                //return Json(vehicles, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(vehicles);
                return Ok(vehicles);
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
            , string make = null 
            , string model = null 
            , string owner = null 
            , int? ownerId = null 
            , int? nucleoId = null 
            , int? vehicleTypeId = null 
            , int? energySourceId = null 
            , int? averageSpeed = null 
            , int? horsePower = null 
            , double? fuelConsumption = null 
            , double? fuelAutonomyDistance = null 
            , int? rechargeTime = null 
            , string licensePlate = null 
            , string color = null 
            , int? numberSeats = null 
            , int? cargoVolumeCapacity = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetVehicleListAdvancedSearch"); 

                IEnumerable<VehicleDTO> resultsDTO = _vehicleService.GetVehicleListAdvancedSearch(
                     make 
                    , model 
                    , owner 
                    , ownerId 
                    , nucleoId 
                    , vehicleTypeId 
                    , energySourceId 
                    , averageSpeed 
                    , horsePower 
                    , fuelConsumption 
                    , fuelAutonomyDistance 
                    , rechargeTime 
                    , licensePlate 
                    , color 
                    , numberSeats 
                    , cargoVolumeCapacity 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<VehicleViewModel> vehicleList = resultsDTO.Select(vehicle => new VehicleViewModel(vehicle, GetEditUrl(vehicle.VehicleId))).ToList();

                log.Debug("result: 'success', count: " + (vehicleList != null ? vehicleList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(vehicleList), "application/json");
                //return JsonConvert.SerializeObject(vehicleList);
                return Ok(vehicleList);
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
            string editUrl = Url.Content("~/Vehicle/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Vehicle, or creates a new Vehicle if the Id is 0
        /// </summary>
        /// <param name="viewModel">Vehicle data</param>
        /// <returns>Vehicle id</returns>
        public IHttpActionResult Upsert(VehicleViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.VehicleId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.VehicleId);
                return Ok(t.VehicleId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.VehicleId);
                //return JsonConvert.SerializeObject(t.VehicleId);
                return Ok(t.VehicleId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Vehicle
        /// </summary>
        /// <param name="viewModels">Vehicle view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(VehicleViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(VehicleViewModel viewModel in viewModels)
                    {
                        log.Debug(VehicleViewModel.FormatVehicleViewModel(viewModel)); 

                        if (viewModel.VehicleId > 0)
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

        private VehicleDTO Create(VehicleViewModel viewModel)
        {
            try
            {
                log.Debug(VehicleViewModel.FormatVehicleViewModel(viewModel)); 

                VehicleDTO vehicle = new VehicleDTO();

                // copy values
                viewModel.UpdateDTO(vehicle, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                vehicle.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                vehicle.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_vehicleService.AddVehicle - " + VehicleDTO.FormatVehicleDTO(vehicle)); 

                int id = _vehicleService.AddVehicle(vehicle);

                vehicle.VehicleId = id;

                log.Debug("result: 'success', id: " + id); 

                return vehicle;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private VehicleDTO Update(VehicleViewModel viewModel)
        {
            try
            {
                log.Debug(VehicleViewModel.FormatVehicleViewModel(viewModel)); 

                // get
                log.Debug("_vehicleService.GetVehicle - vehicleId: " + viewModel.VehicleId + " "); 

                var existingVehicle = _vehicleService.GetVehicle(viewModel.VehicleId);

                log.Debug("_vehicleService.GetVehicle - " + VehicleDTO.FormatVehicleDTO(existingVehicle)); 

                if (existingVehicle != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingVehicle, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_vehicleService.UpdateVehicle - " + VehicleDTO.FormatVehicleDTO(existingVehicle)); 

                    _vehicleService.UpdateVehicle(existingVehicle);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingVehicle: null, VehicleId: " + viewModel.VehicleId); 
                }

                return existingVehicle;
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

    