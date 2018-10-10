
// ################################################################
//                      Code generated with T4
// ################################################################

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
using Refood.WebServices.VolunteerWS.DataContracts;

namespace Refood.WebServices.VolunteerWS
{
    //[Authorize]
    [RoutePrefix("api/VolunteerApi")]
    public partial class VolunteerWebService : IVolunteerWebService
    {
        private readonly IVolunteerService _volunteerService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VolunteerWebService(IVolunteerService volunteerService)
        {
            this._volunteerService = volunteerService;
        }

        public VolunteerWebService() : this(new VolunteerService()) { }

        /// <summary>
        /// Delete Volunteer by id
        /// </summary>
        /// <param name="id">Volunteer id</param>
        /// <returns>true if the Volunteer is deleted successfully</returns>
        public bool Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_volunteerService.DeleteVolunteer - volunteerId: " + id + " "); 

                _volunteerService.DeleteVolunteer(id);

                log.Debug("result: 'success'"); 

                return true;
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
        /// <returns>Volunteer</returns>
        public VolunteerDataContract Get(int id)
        {
            try
            {
                // get
                log.Debug("_volunteerService.GetVolunteer - volunteerId: " + id + " "); 

                var volunteer = new VolunteerDataContract(_volunteerService.GetVolunteer(id));

                log.Debug("_volunteerService.GetVolunteer - " + VolunteerDataContract.FormatVolunteerDataContract(volunteer)); 

                log.Debug("result: 'success'"); 

                return volunteer;
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
        /// <returns>list of Volunteers</returns>
        public VolunteerDataContract[] GetList()
        {
            try
            {
                // get list
                List<VolunteerDataContract> volunteers;

                log.Debug("_volunteerService.GetVolunteers"); 

                // add edit url
                volunteers = _volunteerService.GetVolunteers()
                        .Select(volunteer => new VolunteerDataContract(volunteer, GetEditUrl(volunteer.VolunteerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (volunteers != null ? volunteers.Count().ToString() : "null")); 

                return volunteers.ToArray();
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
        public VolunteerDataContract[] GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<VolunteerDataContract> volunteers;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_volunteerService.GetVolunteers - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                volunteers = _volunteerService.GetVolunteers(searchTerm, pageIndex, pageSize)
                        .Select(volunteer => new VolunteerDataContract(volunteer, GetEditUrl(volunteer.VolunteerId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (volunteers != null ? volunteers.Count().ToString() : "null")); 

                return volunteers.ToArray();
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public VolunteerDataContract[] GetListAdvancedSearch(
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
            
                // convert to dataContract list, and add edit url
                List<VolunteerDataContract> volunteerList = resultsDTO.Select(volunteer => new VolunteerDataContract(volunteer, GetEditUrl(volunteer.VolunteerId))).ToList();

                log.Debug("result: 'success', count: " + (volunteerList != null ? volunteerList.Count().ToString() : "null")); 

                return volunteerList.ToArray();
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

        /// <summary>
        /// Updates data for an existing Volunteer, or creates a new Volunteer if the Id is 0
        /// </summary>
        /// <param name="dataContract">Volunteer data</param>
        /// <returns>Volunteer id</returns>
        public int Upsert(VolunteerDataContract dataContract)
        {
            log.Debug("Upsert"); 

            if (dataContract.VolunteerId > 0)
            {
                var t = Update(dataContract);
                return t.VolunteerId;
            }
            else
            {
                var t = Create(dataContract);
                return t.VolunteerId;
            }
        }

        /// <summary>
        /// Save a list of Volunteer
        /// </summary>
        /// <param name="dataContracts">Volunteers</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public bool SaveList(VolunteerDataContract[] dataContracts, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(dataContracts != null)
                {
                    // save list
                    foreach(VolunteerDataContract dataContract in dataContracts)
                    {
                        log.Debug(VolunteerDataContract.FormatVolunteerDataContract(dataContract)); 

                        if (dataContract.VolunteerId > 0)
                        {
                            var t = Update(dataContract);
                        }
                        else
                        {
                            var t = Create(dataContract);
                        }

                    }
                }
                else
                {
                    log.Error("dataContracts: null"); 
                }

                return true;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private VolunteerDTO Create(VolunteerDataContract dataContract)
        {
            try
            {
                log.Debug(VolunteerDataContract.FormatVolunteerDataContract(dataContract)); 

                VolunteerDTO volunteer = new VolunteerDTO();

                // copy values
                dataContract.UpdateDTO(volunteer, null); //RequestContext.Principal.Identity.GetUserId());
                
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

        private VolunteerDTO Update(VolunteerDataContract dataContract)
        {
            try
            {
                log.Debug(VolunteerDataContract.FormatVolunteerDataContract(dataContract)); 

                // get
                log.Debug("_volunteerService.GetVolunteer - volunteerId: " + dataContract.VolunteerId + " "); 

                var existingVolunteer = _volunteerService.GetVolunteer(dataContract.VolunteerId);

                log.Debug("_volunteerService.GetVolunteer - " + VolunteerDTO.FormatVolunteerDTO(existingVolunteer)); 

                if (existingVolunteer != null)
                {
                    // copy values
                    dataContract.UpdateDTO(existingVolunteer, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_volunteerService.UpdateVolunteer - " + VolunteerDTO.FormatVolunteerDTO(existingVolunteer)); 

                    _volunteerService.UpdateVolunteer(existingVolunteer);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingVolunteer: null, VolunteerId: " + dataContract.VolunteerId); 
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

    