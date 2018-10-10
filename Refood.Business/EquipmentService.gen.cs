
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
    public partial class EquipmentService :  IEquipmentService
    {
        public static IEquipmentRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EquipmentService()
        {
            if (Repository == null)
            {
                Repository = new EquipmentRepository();
            }
        }

        public int AddEquipment(EquipmentDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(EquipmentDTO.FormatEquipmentDTO(dto)); 

                R_Equipment t = EquipmentDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddEquipment(t);
                dto.EquipmentId = id;

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

        public void DeleteEquipment(EquipmentDTO dto)
        {
            try
            {
                log.Debug(EquipmentDTO.FormatEquipmentDTO(dto)); 
            
                R_Equipment t = EquipmentDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteEquipment(t);
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

        public void DeleteEquipment(int equipmentId)
        {
            try
            {
                log.Debug("equipmentId: " + equipmentId + " "); 

                // delete
                Repository.DeleteEquipment(equipmentId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public EquipmentDTO GetEquipment(int equipmentId)
        {
            try
            {
                //Requires.NotNegative("equipmentId", equipmentId);
                
                log.Debug("equipmentId: " + equipmentId + " "); 

                // get
                R_Equipment t = Repository.GetEquipment(equipmentId);

                EquipmentDTO dto = new EquipmentDTO(t);

                log.Debug(EquipmentDTO.FormatEquipmentDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<EquipmentDTO> GetEquipments()
        {
            try
            {
                
                log.Debug("GetEquipments"); 

                // get
                IEnumerable<R_Equipment> results = Repository.GetEquipments();

                IEnumerable<EquipmentDTO> resultsDTO = results.Select(e => new EquipmentDTO(e));

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

        public IList<EquipmentDTO> GetEquipments(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Equipment> results = Repository.GetEquipments(searchTerm, pageIndex, pageSize);
            
                IList<EquipmentDTO> resultsDTO = results.Select(e => new EquipmentDTO(e)).ToList();

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

        public IEnumerable<EquipmentDTO> GetEquipmentListAdvancedSearch(
             string name 
            , string description 
            , string category 
            , int? photo 
            , double? quantityInStock 
            , double? minimumQuantityNeeded 
            , double? pricePerUnit 
            , string storageLocation 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetEquipmentListAdvancedSearch"); 

                IEnumerable<R_Equipment> results = Repository.GetEquipmentListAdvancedSearch(
                     name 
                    , description 
                    , category 
                    , photo 
                    , quantityInStock 
                    , minimumQuantityNeeded 
                    , pricePerUnit 
                    , storageLocation 
                    , active 
                );
            
                IEnumerable<EquipmentDTO> resultsDTO = results.Select(e => new EquipmentDTO(e));

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

        public void UpdateEquipment(EquipmentDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "EquipmentId");

                log.Debug(EquipmentDTO.FormatEquipmentDTO(dto)); 

                R_Equipment t = EquipmentDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateEquipment(t);

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

    