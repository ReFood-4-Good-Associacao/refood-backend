
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
    public partial class DeliveryReportMessageTypeService :  IDeliveryReportMessageTypeService
    {
        public static IDeliveryReportMessageTypeRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeliveryReportMessageTypeService()
        {
            if (Repository == null)
            {
                Repository = new DeliveryReportMessageTypeRepository();
            }
        }

        public int AddDeliveryReportMessageType(DeliveryReportMessageTypeDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(dto)); 

                R_DeliveryReportMessageType t = DeliveryReportMessageTypeDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddDeliveryReportMessageType(t);
                dto.DeliveryReportMessageTypeId = id;

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

        public void DeleteDeliveryReportMessageType(DeliveryReportMessageTypeDTO dto)
        {
            try
            {
                log.Debug(DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(dto)); 
            
                R_DeliveryReportMessageType t = DeliveryReportMessageTypeDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteDeliveryReportMessageType(t);
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

        public void DeleteDeliveryReportMessageType(int deliveryReportMessageTypeId)
        {
            try
            {
                log.Debug("deliveryReportMessageTypeId: " + deliveryReportMessageTypeId + " "); 

                // delete
                Repository.DeleteDeliveryReportMessageType(deliveryReportMessageTypeId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public DeliveryReportMessageTypeDTO GetDeliveryReportMessageType(int deliveryReportMessageTypeId)
        {
            try
            {
                //Requires.NotNegative("deliveryReportMessageTypeId", deliveryReportMessageTypeId);
                
                log.Debug("deliveryReportMessageTypeId: " + deliveryReportMessageTypeId + " "); 

                // get
                R_DeliveryReportMessageType t = Repository.GetDeliveryReportMessageType(deliveryReportMessageTypeId);

                DeliveryReportMessageTypeDTO dto = new DeliveryReportMessageTypeDTO(t);

                log.Debug(DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<DeliveryReportMessageTypeDTO> GetDeliveryReportMessageTypes()
        {
            try
            {
                
                log.Debug("GetDeliveryReportMessageTypes"); 

                // get
                IEnumerable<R_DeliveryReportMessageType> results = Repository.GetDeliveryReportMessageTypes();

                IEnumerable<DeliveryReportMessageTypeDTO> resultsDTO = results.Select(e => new DeliveryReportMessageTypeDTO(e));

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

        public IList<DeliveryReportMessageTypeDTO> GetDeliveryReportMessageTypes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_DeliveryReportMessageType> results = Repository.GetDeliveryReportMessageTypes(searchTerm, pageIndex, pageSize);
            
                IList<DeliveryReportMessageTypeDTO> resultsDTO = results.Select(e => new DeliveryReportMessageTypeDTO(e)).ToList();

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

        public IEnumerable<DeliveryReportMessageTypeDTO> GetDeliveryReportMessageTypeListAdvancedSearch(
             string name 
            , string description 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetDeliveryReportMessageTypeListAdvancedSearch"); 

                IEnumerable<R_DeliveryReportMessageType> results = Repository.GetDeliveryReportMessageTypeListAdvancedSearch(
                     name 
                    , description 
                    , active 
                );
            
                IEnumerable<DeliveryReportMessageTypeDTO> resultsDTO = results.Select(e => new DeliveryReportMessageTypeDTO(e));

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

        public void UpdateDeliveryReportMessageType(DeliveryReportMessageTypeDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "DeliveryReportMessageTypeId");

                log.Debug(DeliveryReportMessageTypeDTO.FormatDeliveryReportMessageTypeDTO(dto)); 

                R_DeliveryReportMessageType t = DeliveryReportMessageTypeDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateDeliveryReportMessageType(t);

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

    