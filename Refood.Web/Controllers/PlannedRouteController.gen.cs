
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
using System.Web.Mvc;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    public partial class PlannedRouteController : System.Web.Mvc.Controller 
    {
        private readonly IPlannedRouteService _plannedRouteService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlannedRouteController(IPlannedRouteService plannedRouteService)
        {
            this._plannedRouteService = plannedRouteService;
        }

        public PlannedRouteController() : this(new PlannedRouteService()) { }


        public ActionResult Index()
        {
            return View("View");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

        public JsonResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_plannedRouteService.DeletePlannedRoute - plannedRouteId: " + id + " "); 

                _plannedRouteService.DeletePlannedRoute(id);

                log.Debug("result: 'success'"); 

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_plannedRouteService.GetPlannedRoute - plannedRouteId: " + id + " "); 

                var plannedRoute = new PlannedRouteViewModel(_plannedRouteService.GetPlannedRoute(id));

                log.Debug("_plannedRouteService.GetPlannedRoute - " + PlannedRouteViewModel.FormatPlannedRouteViewModel(plannedRoute)); 

                log.Debug("result: 'success'"); 

                //return Json(plannedRoute, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(plannedRoute), "application/json");
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult GetList()
        {
            try
            {
                // get list
                List<PlannedRouteViewModel> plannedRoutes;

                log.Debug("_plannedRouteService.GetPlannedRoutes"); 

                // add edit url
                plannedRoutes = _plannedRouteService.GetPlannedRoutes()
                        .Select(plannedRoute => new PlannedRouteViewModel(plannedRoute, GetEditUrl(plannedRoute.PlannedRouteId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (plannedRoutes != null ? plannedRoutes.Count().ToString() : "null")); 

                //return Json(plannedRoutes, JsonRequestBehavior.AllowGet);
                return Content(JsonConvert.SerializeObject(plannedRoutes), "application/json");
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public JsonResult GetPage(int itemId = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<PlannedRouteViewModel> plannedRoutes;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_plannedRouteService.GetPlannedRoutes - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                plannedRoutes = _plannedRouteService.GetPlannedRoutes(searchTerm, pageIndex, pageSize)
                        .Select(plannedRoute => new PlannedRouteViewModel(plannedRoute, GetEditUrl(plannedRoute.PlannedRouteId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (plannedRoutes != null ? plannedRoutes.Count().ToString() : "null")); 

                return Json(plannedRoutes, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ActionResult GetListAdvancedSearch(
            int itemId = 0 
            , string name = null 
            , int? routeTypeId = null 
            , int? transportTypeId = null 
            , string description = null 
            , System.DateTime? startHourFrom = null 
            , System.DateTime? startHourTo = null 
            , int? estimatedDuration = null 
            , double? totalDistance = null 
            , string routeDayOfTheWeek = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetPlannedRouteListAdvancedSearch"); 

                IEnumerable<PlannedRouteDTO> resultsDTO = _plannedRouteService.GetPlannedRouteListAdvancedSearch(
                     name 
                    , routeTypeId 
                    , transportTypeId 
                    , description 
                    , startHourFrom 
                    , startHourTo 
                    , estimatedDuration 
                    , totalDistance 
                    , routeDayOfTheWeek 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<PlannedRouteViewModel> plannedRouteList = resultsDTO.Select(plannedRoute => new PlannedRouteViewModel(plannedRoute, GetEditUrl(plannedRoute.PlannedRouteId))).ToList();

                log.Debug("result: 'success', count: " + (plannedRouteList != null ? plannedRouteList.Count().ToString() : "null")); 

                return Content(JsonConvert.SerializeObject(plannedRouteList), "application/json");
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
            string editUrl = Url.Content("~/PlannedRoute/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public JsonResult Upsert(PlannedRouteViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.PlannedRouteId > 0)
            {
                var t = Update(viewModel);
                return Json(true);
            }
            else
            {
                var t = Create(viewModel);
                return Json(t.PlannedRouteId);
            }
        }

        //[ValidateAntiForgeryToken]
        public JsonResult SaveList(PlannedRouteViewModel[] viewModels, int? itemId)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(PlannedRouteViewModel viewModel in viewModels)
                    {
                        log.Debug(PlannedRouteViewModel.FormatPlannedRouteViewModel(viewModel)); 

                        if (viewModel.PlannedRouteId > 0)
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

                return Json(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private PlannedRouteDTO Create(PlannedRouteViewModel viewModel)
        {
            try
            {
                log.Debug(PlannedRouteViewModel.FormatPlannedRouteViewModel(viewModel)); 

                PlannedRouteDTO plannedRoute = new PlannedRouteDTO();

                // copy values
                plannedRoute.PlannedRouteId = viewModel.PlannedRouteId;
                plannedRoute.Name = viewModel.Name;
                plannedRoute.RouteTypeId = viewModel.RouteTypeId;
                plannedRoute.TransportTypeId = viewModel.TransportTypeId;
                plannedRoute.Description = viewModel.Description;
                plannedRoute.StartHour = viewModel.StartHour;
                plannedRoute.EstimatedDuration = viewModel.EstimatedDuration;
                plannedRoute.TotalDistance = viewModel.TotalDistance;
                plannedRoute.RouteDayOfTheWeek = viewModel.RouteDayOfTheWeek;
                plannedRoute.Active = viewModel.Active;
                plannedRoute.IsDeleted = viewModel.IsDeleted;

                
                // audit
                //plannedRoute.CreateBy = UserInfo.UserID;
                //plannedRoute.UpdateBy = UserInfo.UserID;
                plannedRoute.CreateOn = DateTime.UtcNow;
                plannedRoute.UpdateOn = DateTime.UtcNow;

                // add
                log.Debug("_plannedRouteService.AddPlannedRoute - " + PlannedRouteDTO.FormatPlannedRouteDTO(plannedRoute)); 

                int id = _plannedRouteService.AddPlannedRoute(plannedRoute);

                plannedRoute.PlannedRouteId = id;

                log.Debug("result: 'success', id: " + id); 

                return plannedRoute;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private PlannedRouteDTO Update(PlannedRouteViewModel viewModel)
        {
            try
            {
                log.Debug(PlannedRouteViewModel.FormatPlannedRouteViewModel(viewModel)); 

                // get
                log.Debug("_plannedRouteService.GetPlannedRoute - plannedRouteId: " + viewModel.PlannedRouteId + " "); 

                var existingPlannedRoute = _plannedRouteService.GetPlannedRoute(viewModel.PlannedRouteId);

                log.Debug("_plannedRouteService.GetPlannedRoute - " + PlannedRouteDTO.FormatPlannedRouteDTO(existingPlannedRoute)); 

                if (existingPlannedRoute != null)
                {
                    // copy values
                    existingPlannedRoute.Name = viewModel.Name;
                    existingPlannedRoute.RouteTypeId = viewModel.RouteTypeId;
                    existingPlannedRoute.TransportTypeId = viewModel.TransportTypeId;
                    existingPlannedRoute.Description = viewModel.Description;
                    existingPlannedRoute.StartHour = viewModel.StartHour;
                    existingPlannedRoute.EstimatedDuration = viewModel.EstimatedDuration;
                    existingPlannedRoute.TotalDistance = viewModel.TotalDistance;
                    existingPlannedRoute.RouteDayOfTheWeek = viewModel.RouteDayOfTheWeek;
                    existingPlannedRoute.Active = viewModel.Active;
                    existingPlannedRoute.IsDeleted = viewModel.IsDeleted;

                    // audit
                    //existingPlannedRoute.UpdateBy = UserInfo.UserID;
                    existingPlannedRoute.UpdateOn = DateTime.UtcNow;

                    // update
                    log.Debug("_plannedRouteService.UpdatePlannedRoute - " + PlannedRouteDTO.FormatPlannedRouteDTO(existingPlannedRoute)); 

                    _plannedRouteService.UpdatePlannedRoute(existingPlannedRoute);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingPlannedRoute: null, PlannedRouteId: " + viewModel.PlannedRouteId); 
                }

                return existingPlannedRoute;
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
    