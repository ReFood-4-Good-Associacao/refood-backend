
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class VolunteerService :  IVolunteerService
    {
        public static IVolunteerRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VolunteerService()
        {
            if (Repository == null)
            {
                Repository = new VolunteerRepository();
            }
        }

        public int AddVolunteer(VolunteerDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(VolunteerDTO.FormatVolunteerDTO(dto)); 

                R_Volunteer t = VolunteerDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddVolunteer(t);
                dto.VolunteerId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteVolunteer(VolunteerDTO dto)
        {
            try
            {
                log.Debug(VolunteerDTO.FormatVolunteerDTO(dto)); 
            
                R_Volunteer t = VolunteerDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteVolunteer(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteVolunteer(int volunteerId)
        {
            try
            {
                log.Debug("volunteerId: " + volunteerId + " "); 

                // delete
                Repository.DeleteVolunteer(volunteerId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public VolunteerDTO GetVolunteer(int volunteerId)
        {
            try
            {
                //Requires.NotNegative("volunteerId", volunteerId);
                
                log.Debug("volunteerId: " + volunteerId + " "); 

                // get
                R_Volunteer t = Repository.GetVolunteer(volunteerId);

                VolunteerDTO dto = new VolunteerDTO(t);

                log.Debug(VolunteerDTO.FormatVolunteerDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<VolunteerDTO> GetVolunteers()
        {
            try
            {
                
                log.Debug("GetVolunteers"); 

                // get
                IEnumerable<R_Volunteer> results = Repository.GetVolunteers();

                IEnumerable<VolunteerDTO> resultsDTO = results.Select(e => new VolunteerDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<VolunteerDTO> GetVolunteers(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Volunteer> results = Repository.GetVolunteers(searchTerm, pageIndex, pageSize);
            
                IList<VolunteerDTO> resultsDTO = results.Select(e => new VolunteerDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<VolunteerDTO> GetVolunteerListAdvancedSearch(
             string name 
            , int? gender 
            , System.DateTime? birthDateFrom 
            , System.DateTime? birthDateTo 
            , string occupation 
            , string employer 
            , string phone 
            , string email 
            , string identityCardNumber 
            , int? countryId 
            , string friendOrFamilyContact 
            , int? photo 
            , int? addressId 
            , bool? hasCar 
            , bool? hasDriverLicense 
            , bool? hasBike 
            , string vehicleMake 
            , string vehicleModel 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetVolunteerListAdvancedSearch"); 

                IEnumerable<R_Volunteer> results = Repository.GetVolunteerListAdvancedSearch(
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
            
                IEnumerable<VolunteerDTO> resultsDTO = results.Select(e => new VolunteerDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateVolunteer(VolunteerDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "VolunteerId");

                log.Debug(VolunteerDTO.FormatVolunteerDTO(dto)); 

                R_Volunteer t = VolunteerDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateVolunteer(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    