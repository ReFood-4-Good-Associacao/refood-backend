
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
    [RoutePrefix("api/Nucleo")]
    public partial class NucleoApiController : ApiController
    {
        private readonly INucleoService _nucleoService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NucleoApiController(INucleoService nucleoService)
        {
            this._nucleoService = nucleoService;
        }

        public NucleoApiController() : this(new NucleoService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_nucleoService.DeleteNucleo - nucleoId: " + id + " "); 

                _nucleoService.DeleteNucleo(id);

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
                log.Debug("_nucleoService.GetNucleo - nucleoId: " + id + " "); 

                var nucleo = new NucleoViewModel(_nucleoService.GetNucleo(id));

                log.Debug("_nucleoService.GetNucleo - " + NucleoViewModel.FormatNucleoViewModel(nucleo)); 

                log.Debug("result: 'success'"); 

                //return Json(nucleo, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(nucleo), "application/json");
                //return nucleo;
                //return JsonConvert.SerializeObject(nucleo);
                return Ok(nucleo);
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
                List<NucleoViewModel> nucleos;

                log.Debug("_nucleoService.GetNucleos"); 

                // add edit url
                nucleos = _nucleoService.GetNucleos()
                        .Select(nucleo => new NucleoViewModel(nucleo, GetEditUrl(nucleo.NucleoId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (nucleos != null ? nucleos.Count().ToString() : "null")); 

                //return Json(nucleos, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(nucleos), "application/json");
                //return JsonConvert.SerializeObject(nucleos);
                return Ok(nucleos);
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
                List<NucleoViewModel> nucleos;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_nucleoService.GetNucleos - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                nucleos = _nucleoService.GetNucleos(searchTerm, pageIndex, pageSize)
                        .Select(nucleo => new NucleoViewModel(nucleo, GetEditUrl(nucleo.NucleoId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (nucleos != null ? nucleos.Count().ToString() : "null")); 

                //return Json(nucleos, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(nucleos);
                return Ok(nucleos);
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
            , string personResponsible = null 
            , int? photo = null 
            , int? addressId = null 
            , System.DateTime? openingDateFrom = null 
            , System.DateTime? openingDateTo = null 
            , string primaryPhoneNumber = null 
            , string primaryEmail = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetNucleoListAdvancedSearch"); 

                IEnumerable<NucleoDTO> resultsDTO = _nucleoService.GetNucleoListAdvancedSearch(
                     name 
                    , personResponsible 
                    , photo 
                    , addressId 
                    , openingDateFrom 
                    , openingDateTo 
                    , primaryPhoneNumber 
                    , primaryEmail 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<NucleoViewModel> nucleoList = resultsDTO.Select(nucleo => new NucleoViewModel(nucleo, GetEditUrl(nucleo.NucleoId))).ToList();

                log.Debug("result: 'success', count: " + (nucleoList != null ? nucleoList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(nucleoList), "application/json");
                //return JsonConvert.SerializeObject(nucleoList);
                return Ok(nucleoList);
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
            string editUrl = Url.Content("~/Nucleo/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(NucleoViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.NucleoId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.NucleoId);
                return Ok(t.NucleoId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.NucleoId);
                //return JsonConvert.SerializeObject(t.NucleoId);
                return Ok(t.NucleoId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(NucleoViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(NucleoViewModel viewModel in viewModels)
                    {
                        log.Debug(NucleoViewModel.FormatNucleoViewModel(viewModel)); 

                        if (viewModel.NucleoId > 0)
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

        private NucleoDTO Create(NucleoViewModel viewModel)
        {
            try
            {
                log.Debug(NucleoViewModel.FormatNucleoViewModel(viewModel)); 

                NucleoDTO nucleo = new NucleoDTO();

                // copy values
                viewModel.UpdateDTO(nucleo, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                nucleo.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                nucleo.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_nucleoService.AddNucleo - " + NucleoDTO.FormatNucleoDTO(nucleo)); 

                int id = _nucleoService.AddNucleo(nucleo);

                nucleo.NucleoId = id;

                log.Debug("result: 'success', id: " + id); 

                return nucleo;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private NucleoDTO Update(NucleoViewModel viewModel)
        {
            try
            {
                log.Debug(NucleoViewModel.FormatNucleoViewModel(viewModel)); 

                // get
                log.Debug("_nucleoService.GetNucleo - nucleoId: " + viewModel.NucleoId + " "); 

                var existingNucleo = _nucleoService.GetNucleo(viewModel.NucleoId);

                log.Debug("_nucleoService.GetNucleo - " + NucleoDTO.FormatNucleoDTO(existingNucleo)); 

                if (existingNucleo != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingNucleo, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_nucleoService.UpdateNucleo - " + NucleoDTO.FormatNucleoDTO(existingNucleo)); 

                    _nucleoService.UpdateNucleo(existingNucleo);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingNucleo: null, NucleoId: " + viewModel.NucleoId); 
                }

                return existingNucleo;
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

    