
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
    public partial class VehicleTypeService :  IVehicleTypeService
    {
        public static IVehicleTypeRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VehicleTypeService()
        {
            if (Repository == null)
            {
                Repository = new VehicleTypeRepository();
            }
        }

        public int AddVehicleType(VehicleTypeDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(VehicleTypeDTO.FormatVehicleTypeDTO(dto)); 

                R_VehicleType t = VehicleTypeDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddVehicleType(t);
                dto.VehicleTypeId = id;

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

        public void DeleteVehicleType(VehicleTypeDTO dto)
        {
            try
            {
                log.Debug(VehicleTypeDTO.FormatVehicleTypeDTO(dto)); 
            
                R_VehicleType t = VehicleTypeDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteVehicleType(t);
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

        public void DeleteVehicleType(int vehicleTypeId)
        {
            try
            {
                log.Debug("vehicleTypeId: " + vehicleTypeId + " "); 

                // delete
                Repository.DeleteVehicleType(vehicleTypeId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public VehicleTypeDTO GetVehicleType(int vehicleTypeId)
        {
            try
            {
                //Requires.NotNegative("vehicleTypeId", vehicleTypeId);
                
                log.Debug("vehicleTypeId: " + vehicleTypeId + " "); 

                // get
                R_VehicleType t = Repository.GetVehicleType(vehicleTypeId);

                VehicleTypeDTO dto = new VehicleTypeDTO(t);

                log.Debug(VehicleTypeDTO.FormatVehicleTypeDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<VehicleTypeDTO> GetVehicleTypes()
        {
            try
            {
                
                log.Debug("GetVehicleTypes"); 

                // get
                IEnumerable<R_VehicleType> results = Repository.GetVehicleTypes();

                IEnumerable<VehicleTypeDTO> resultsDTO = results.Select(e => new VehicleTypeDTO(e));

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

        public IList<VehicleTypeDTO> GetVehicleTypes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_VehicleType> results = Repository.GetVehicleTypes(searchTerm, pageIndex, pageSize);
            
                IList<VehicleTypeDTO> resultsDTO = results.Select(e => new VehicleTypeDTO(e)).ToList();

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

        public IEnumerable<VehicleTypeDTO> GetVehicleTypeListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetVehicleTypeListAdvancedSearch"); 

                IEnumerable<R_VehicleType> results = Repository.GetVehicleTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<VehicleTypeDTO> resultsDTO = results.Select(e => new VehicleTypeDTO(e));

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

        public void UpdateVehicleType(VehicleTypeDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "VehicleTypeId");

                log.Debug(VehicleTypeDTO.FormatVehicleTypeDTO(dto)); 

                R_VehicleType t = VehicleTypeDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateVehicleType(t);

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

    