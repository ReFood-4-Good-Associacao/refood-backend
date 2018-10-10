
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
    public partial class VehicleService :  IVehicleService
    {
        public static IVehicleRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VehicleService()
        {
            if (Repository == null)
            {
                Repository = new VehicleRepository();
            }
        }

        public int AddVehicle(VehicleDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(VehicleDTO.FormatVehicleDTO(dto)); 

                R_Vehicle t = VehicleDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddVehicle(t);
                dto.VehicleId = id;

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

        public void DeleteVehicle(VehicleDTO dto)
        {
            try
            {
                log.Debug(VehicleDTO.FormatVehicleDTO(dto)); 
            
                R_Vehicle t = VehicleDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteVehicle(t);
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

        public void DeleteVehicle(int vehicleId)
        {
            try
            {
                log.Debug("vehicleId: " + vehicleId + " "); 

                // delete
                Repository.DeleteVehicle(vehicleId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public VehicleDTO GetVehicle(int vehicleId)
        {
            try
            {
                //Requires.NotNegative("vehicleId", vehicleId);
                
                log.Debug("vehicleId: " + vehicleId + " "); 

                // get
                R_Vehicle t = Repository.GetVehicle(vehicleId);

                VehicleDTO dto = new VehicleDTO(t);

                log.Debug(VehicleDTO.FormatVehicleDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<VehicleDTO> GetVehicles()
        {
            try
            {
                
                log.Debug("GetVehicles"); 

                // get
                IEnumerable<R_Vehicle> results = Repository.GetVehicles();

                IEnumerable<VehicleDTO> resultsDTO = results.Select(e => new VehicleDTO(e));

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

        public IList<VehicleDTO> GetVehicles(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Vehicle> results = Repository.GetVehicles(searchTerm, pageIndex, pageSize);
            
                IList<VehicleDTO> resultsDTO = results.Select(e => new VehicleDTO(e)).ToList();

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

        public IEnumerable<VehicleDTO> GetVehicleListAdvancedSearch(
             string make 
            , string model 
            , string owner 
            , int? ownerId 
            , int? nucleoId 
            , int? vehicleTypeId 
            , int? energySourceId 
            , int? averageSpeed 
            , int? horsePower 
            , double? fuelConsumption 
            , double? fuelAutonomyDistance 
            , int? rechargeTime 
            , string licensePlate 
            , string color 
            , int? numberSeats 
            , int? cargoVolumeCapacity 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetVehicleListAdvancedSearch"); 

                IEnumerable<R_Vehicle> results = Repository.GetVehicleListAdvancedSearch(
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
            
                IEnumerable<VehicleDTO> resultsDTO = results.Select(e => new VehicleDTO(e));

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

        public void UpdateVehicle(VehicleDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "VehicleId");

                log.Debug(VehicleDTO.FormatVehicleDTO(dto)); 

                R_Vehicle t = VehicleDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateVehicle(t);

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

    