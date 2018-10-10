
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
    [RoutePrefix("api/EnergySource")]
    public partial class EnergySourceApiController : ApiController
    {
        private readonly IEnergySourceService _energySourceService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EnergySourceApiController(IEnergySourceService energySourceService)
        {
            this._energySourceService = energySourceService;
        }

        public EnergySourceApiController() : this(new EnergySourceService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_energySourceService.DeleteEnergySource - energySourceId: " + id + " "); 

                _energySourceService.DeleteEnergySource(id);

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
                log.Debug("_energySourceService.GetEnergySource - energySourceId: " + id + " "); 

                var energySource = new EnergySourceViewModel(_energySourceService.GetEnergySource(id));

                log.Debug("_energySourceService.GetEnergySource - " + EnergySourceViewModel.FormatEnergySourceViewModel(energySource)); 

                log.Debug("result: 'success'"); 

                //return Json(energySource, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(energySource), "application/json");
                //return energySource;
                //return JsonConvert.SerializeObject(energySource);
                return Ok(energySource);
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
                List<EnergySourceViewModel> energySources;

                log.Debug("_energySourceService.GetEnergySources"); 

                // add edit url
                energySources = _energySourceService.GetEnergySources()
                        .Select(energySource => new EnergySourceViewModel(energySource, GetEditUrl(energySource.EnergySourceId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (energySources != null ? energySources.Count().ToString() : "null")); 

                //return Json(energySources, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(energySources), "application/json");
                //return JsonConvert.SerializeObject(energySources);
                return Ok(energySources);
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
                List<EnergySourceViewModel> energySources;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_energySourceService.GetEnergySources - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                energySources = _energySourceService.GetEnergySources(searchTerm, pageIndex, pageSize)
                        .Select(energySource => new EnergySourceViewModel(energySource, GetEditUrl(energySource.EnergySourceId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (energySources != null ? energySources.Count().ToString() : "null")); 

                //return Json(energySources, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(energySources);
                return Ok(energySources);
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

                log.Debug("GetEnergySourceListAdvancedSearch"); 

                IEnumerable<EnergySourceDTO> resultsDTO = _energySourceService.GetEnergySourceListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<EnergySourceViewModel> energySourceList = resultsDTO.Select(energySource => new EnergySourceViewModel(energySource, GetEditUrl(energySource.EnergySourceId))).ToList();

                log.Debug("result: 'success', count: " + (energySourceList != null ? energySourceList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(energySourceList), "application/json");
                //return JsonConvert.SerializeObject(energySourceList);
                return Ok(energySourceList);
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
            string editUrl = Url.Content("~/EnergySource/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(EnergySourceViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.EnergySourceId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.EnergySourceId);
                return Ok(t.EnergySourceId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.EnergySourceId);
                //return JsonConvert.SerializeObject(t.EnergySourceId);
                return Ok(t.EnergySourceId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(EnergySourceViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(EnergySourceViewModel viewModel in viewModels)
                    {
                        log.Debug(EnergySourceViewModel.FormatEnergySourceViewModel(viewModel)); 

                        if (viewModel.EnergySourceId > 0)
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

        private EnergySourceDTO Create(EnergySourceViewModel viewModel)
        {
            try
            {
                log.Debug(EnergySourceViewModel.FormatEnergySourceViewModel(viewModel)); 

                EnergySourceDTO energySource = new EnergySourceDTO();

                // copy values
                viewModel.UpdateDTO(energySource, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                energySource.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                energySource.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_energySourceService.AddEnergySource - " + EnergySourceDTO.FormatEnergySourceDTO(energySource)); 

                int id = _energySourceService.AddEnergySource(energySource);

                energySource.EnergySourceId = id;

                log.Debug("result: 'success', id: " + id); 

                return energySource;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private EnergySourceDTO Update(EnergySourceViewModel viewModel)
        {
            try
            {
                log.Debug(EnergySourceViewModel.FormatEnergySourceViewModel(viewModel)); 

                // get
                log.Debug("_energySourceService.GetEnergySource - energySourceId: " + viewModel.EnergySourceId + " "); 

                var existingEnergySource = _energySourceService.GetEnergySource(viewModel.EnergySourceId);

                log.Debug("_energySourceService.GetEnergySource - " + EnergySourceDTO.FormatEnergySourceDTO(existingEnergySource)); 

                if (existingEnergySource != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingEnergySource, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_energySourceService.UpdateEnergySource - " + EnergySourceDTO.FormatEnergySourceDTO(existingEnergySource)); 

                    _energySourceService.UpdateEnergySource(existingEnergySource);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingEnergySource: null, EnergySourceId: " + viewModel.EnergySourceId); 
                }

                return existingEnergySource;
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

    