
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
    [RoutePrefix("api/VolunteerApi")]
    public partial class VolunteerApiController : ApiController
    {
        private readonly IVolunteerService _volunteerService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VolunteerApiController(IVolunteerService volunteerService)
        {
            this._volunteerService = volunteerService;
        }

        public VolunteerApiController() : this(new VolunteerService()) { }

        /// <summary>
        /// Delete Volunteer by id
        /// </summary>
        /// <param name="id">Volunteer id</param>
        /// <returns>true if the Volunteer is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_volunteerService.DeleteVolunteer - volunteerId: " + id + " "); 

                _volunteerService.DeleteVolunteer(id);

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
        /// Get Volunteer by id
        /// </summary>
        /// <param name="id">Volunteer id</param>
        /// <returns>Volunteer json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_volunteerService.GetVolunteer - volunteerId: " + id + " "); 

                var volunteer = new VolunteerViewModel(_volunteerService.GetVolunteer(id));

                log.Debug("_volunteerService.GetVolunteer - " + VolunteerViewModel.FormatVolunteerViewModel(volunteer)); 

                log.Debug("result: 'success'"); 

                //return Json(volunteer, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(volunteer), "application/json");
                //return volunteer;
                //return JsonConvert.SerializeObject(volunteer);
                return Ok(volunteer);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Volunteers
        /// </summary>
        /// <returns>json list of Volunteer view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<VolunteerViewModel> volunteers;

                log.Debug("_volunteerService.GetVolunteers"); 

                // add edit url
                volunteers = _volunteerService.GetVolunteers()
                        .Select(volunteer => new VolunteerViewModel(volunteer, GetEditUrl(volunteer.VolunteerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (volunteers != null ? volunteers.Count().ToString() : "null")); 

                //return Json(volunteers, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(volunteers), "application/json");
                //return JsonConvert.SerializeObject(volunteers);
                return Ok(volunteers);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Volunteers
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Volunteers</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<VolunteerViewModel> volunteers;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_volunteerService.GetVolunteers - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                volunteers = _volunteerService.GetVolunteers(searchTerm, pageIndex, pageSize)
                        .Select(volunteer => new VolunteerViewModel(volunteer, GetEditUrl(volunteer.VolunteerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (volunteers != null ? volunteers.Count().ToString() : "null")); 

                //return Json(volunteers, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(volunteers);
                return Ok(volunteers);
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
            , int? gender = null 
            , System.DateTime? birthDateFrom = null 
            , System.DateTime? birthDateTo = null 
            , string occupation = null 
            , string employer = null 
            , string phone = null 
            , string email = null 
            , string identityCardNumber = null 
            , int? countryId = null 
            , string friendOrFamilyContact = null 
            , int? photo = null 
            , int? addressId = null 
            , bool? hasCar = null 
            , bool? hasDriverLicense = null 
            , bool? hasBike = null 
            , string vehicleMake = null 
            , string vehicleModel = null 
            , bool? active = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetVolunteerListAdvancedSearch"); 

                IEnumerable<VolunteerDTO> resultsDTO = _volunteerService.GetVolunteerListAdvancedSearch(
                     name 
                    , gender 
                    , birthDateFrom 
                    , birthDateTo 
                    , occupation 
                    , employer 
                    , phone 
                    , email 
                    , identityCardNumber 
                    , countryId 
                    , friendOrFamilyContact 
                    , photo 
                    , addressId 
                    , hasCar 
                    , hasDriverLicense 
                    , hasBike 
                    , vehicleMake 
                    , vehicleModel 
                    , active 
                );
            
                // convert to view model list, and add edit url
                List<VolunteerViewModel> volunteerList = resultsDTO.Select(volunteer => new VolunteerViewModel(volunteer, GetEditUrl(volunteer.VolunteerId))).ToList();

                log.Debug("result: 'success', count: " + (volunteerList != null ? volunteerList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(volunteerList), "application/json");
                //return JsonConvert.SerializeObject(volunteerList);
                return Ok(volunteerList);
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
            string editUrl = Url.Content("~/Volunteer/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Volunteer, or creates a new Volunteer if the Id is 0
        /// </summary>
        /// <param name="viewModel">Volunteer data</param>
        /// <returns>Volunteer id</returns>
        public IHttpActionResult Upsert(VolunteerViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.VolunteerId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.VolunteerId);
                return Ok(t.VolunteerId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.VolunteerId);
                //return JsonConvert.SerializeObject(t.VolunteerId);
                return Ok(t.VolunteerId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Volunteer
        /// </summary>
        /// <param name="viewModels">Volunteer view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(VolunteerViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(VolunteerViewModel viewModel in viewModels)
                    {
                        log.Debug(VolunteerViewModel.FormatVolunteerViewModel(viewModel)); 

                        if (viewModel.VolunteerId > 0)
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

        private VolunteerDTO Create(VolunteerViewModel viewModel)
        {
            try
            {
                log.Debug(VolunteerViewModel.FormatVolunteerViewModel(viewModel)); 

                VolunteerDTO volunteer = new VolunteerDTO();

                // copy values
                viewModel.UpdateDTO(volunteer, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                volunteer.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                volunteer.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_volunteerService.AddVolunteer - " + VolunteerDTO.FormatVolunteerDTO(volunteer)); 

                int id = _volunteerService.AddVolunteer(volunteer);

                volunteer.VolunteerId = id;

                log.Debug("result: 'success', id: " + id); 

                return volunteer;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private VolunteerDTO Update(VolunteerViewModel viewModel)
        {
            try
            {
                log.Debug(VolunteerViewModel.FormatVolunteerViewModel(viewModel)); 

                // get
                log.Debug("_volunteerService.GetVolunteer - volunteerId: " + viewModel.VolunteerId + " "); 

                var existingVolunteer = _volunteerService.GetVolunteer(viewModel.VolunteerId);

                log.Debug("_volunteerService.GetVolunteer - " + VolunteerDTO.FormatVolunteerDTO(existingVolunteer)); 

                if (existingVolunteer != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingVolunteer, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_volunteerService.UpdateVolunteer - " + VolunteerDTO.FormatVolunteerDTO(existingVolunteer)); 

                    _volunteerService.UpdateVolunteer(existingVolunteer);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingVolunteer: null, VolunteerId: " + viewModel.VolunteerId); 
                }

                return existingVolunteer;
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

    