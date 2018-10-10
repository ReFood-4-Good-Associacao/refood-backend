
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
    [RoutePrefix("api/Partner")]
    public partial class PartnerApiController : ApiController
    {
        private readonly IPartnerService _partnerService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PartnerApiController(IPartnerService partnerService)
        {
            this._partnerService = partnerService;
        }

        public PartnerApiController() : this(new PartnerService()) { }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_partnerService.DeletePartner - partnerId: " + id + " "); 

                _partnerService.DeletePartner(id);

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
                log.Debug("_partnerService.GetPartner - partnerId: " + id + " "); 

                var partner = new PartnerViewModel(_partnerService.GetPartner(id));

                log.Debug("_partnerService.GetPartner - " + PartnerViewModel.FormatPartnerViewModel(partner)); 

                log.Debug("result: 'success'"); 

                //return Json(partner, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(partner), "application/json");
                //return partner;
                //return JsonConvert.SerializeObject(partner);
                return Ok(partner);
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
                List<PartnerViewModel> partners;

                log.Debug("_partnerService.GetPartners"); 

                // add edit url
                partners = _partnerService.GetPartners()
                        .Select(partner => new PartnerViewModel(partner, GetEditUrl(partner.PartnerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (partners != null ? partners.Count().ToString() : "null")); 

                //return Json(partners, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(partners), "application/json");
                //return JsonConvert.SerializeObject(partners);
                return Ok(partners);
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
                List<PartnerViewModel> partners;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_partnerService.GetPartners - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                partners = _partnerService.GetPartners(searchTerm, pageIndex, pageSize)
                        .Select(partner => new PartnerViewModel(partner, GetEditUrl(partner.PartnerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (partners != null ? partners.Count().ToString() : "null")); 

                //return Json(partners, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(partners);
                return Ok(partners);
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
            , int? nucleoId = null 
            , string name = null 
            , bool? enterpriseContributor = null 
            , bool? privateContributor = null 
            , int? contributionTypeId = null 
            , int? partnershipTypeId = null 
            , string contactPerson = null 
            , string department = null 
            , string phone = null 
            , string email = null 
            , string iban = null 
            , string bicSwift = null 
            , string fiscalNumber = null 
            , double? latitude = null 
            , double? longitude = null 
            , string photoUrl = null 
            , int? addressId = null 
            , System.DateTime? partnershipStartDateFrom = null 
            , System.DateTime? partnershipStartDateTo = null 
            , System.DateTime? durationCommitmentFrom = null 
            , System.DateTime? durationCommitmentTo = null 
            , string refoodAreaInteraction = null 
            , string reliability = null 
            , string interactionFrequency = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetPartnerListAdvancedSearch"); 

                IEnumerable<PartnerDTO> resultsDTO = _partnerService.GetPartnerListAdvancedSearch(
                     nucleoId 
                    , name 
                    , enterpriseContributor 
                    , privateContributor 
                    , contributionTypeId 
                    , partnershipTypeId 
                    , contactPerson 
                    , department 
                    , phone 
                    , email 
                    , iban 
                    , bicSwift 
                    , fiscalNumber 
                    , latitude 
                    , longitude 
                    , photoUrl 
                    , addressId 
                    , partnershipStartDateFrom 
                    , partnershipStartDateTo 
                    , durationCommitmentFrom 
                    , durationCommitmentTo 
                    , refoodAreaInteraction 
                    , reliability 
                    , interactionFrequency 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<PartnerViewModel> partnerList = resultsDTO.Select(partner => new PartnerViewModel(partner, GetEditUrl(partner.PartnerId))).ToList();

                log.Debug("result: 'success', count: " + (partnerList != null ? partnerList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(partnerList), "application/json");
                //return JsonConvert.SerializeObject(partnerList);
                return Ok(partnerList);
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
            string editUrl = Url.Content("~/Partner/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult Upsert(PartnerViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.PartnerId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.PartnerId);
                return Ok(t.PartnerId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.PartnerId);
                //return JsonConvert.SerializeObject(t.PartnerId);
                return Ok(t.PartnerId);
            }
        }

        //[ValidateAntiForgeryToken]
        public IHttpActionResult SaveList(PartnerViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(PartnerViewModel viewModel in viewModels)
                    {
                        log.Debug(PartnerViewModel.FormatPartnerViewModel(viewModel)); 

                        if (viewModel.PartnerId > 0)
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

        private PartnerDTO Create(PartnerViewModel viewModel)
        {
            try
            {
                log.Debug(PartnerViewModel.FormatPartnerViewModel(viewModel)); 

                PartnerDTO partner = new PartnerDTO();

                // copy values
                viewModel.UpdateDTO(partner, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                partner.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                partner.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_partnerService.AddPartner - " + PartnerDTO.FormatPartnerDTO(partner)); 

                int id = _partnerService.AddPartner(partner);

                partner.PartnerId = id;

                log.Debug("result: 'success', id: " + id); 

                return partner;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private PartnerDTO Update(PartnerViewModel viewModel)
        {
            try
            {
                log.Debug(PartnerViewModel.FormatPartnerViewModel(viewModel)); 

                // get
                log.Debug("_partnerService.GetPartner - partnerId: " + viewModel.PartnerId + " "); 

                var existingPartner = _partnerService.GetPartner(viewModel.PartnerId);

                log.Debug("_partnerService.GetPartner - " + PartnerDTO.FormatPartnerDTO(existingPartner)); 

                if (existingPartner != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingPartner, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_partnerService.UpdatePartner - " + PartnerDTO.FormatPartnerDTO(existingPartner)); 

                    _partnerService.UpdatePartner(existingPartner);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingPartner: null, PartnerId: " + viewModel.PartnerId); 
                }

                return existingPartner;
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

    