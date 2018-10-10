
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
    public partial class DeliveryReportMessageService :  IDeliveryReportMessageService
    {
        public static IDeliveryReportMessageRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeliveryReportMessageService()
        {
            if (Repository == null)
            {
                Repository = new DeliveryReportMessageRepository();
            }
        }

        public int AddDeliveryReportMessage(DeliveryReportMessageDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(dto)); 

                R_DeliveryReportMessage t = DeliveryReportMessageDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddDeliveryReportMessage(t);
                dto.DeliveryReportMessageId = id;

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

        public void DeleteDeliveryReportMessage(DeliveryReportMessageDTO dto)
        {
            try
            {
                log.Debug(DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(dto)); 
            
                R_DeliveryReportMessage t = DeliveryReportMessageDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteDeliveryReportMessage(t);
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

        public void DeleteDeliveryReportMessage(int deliveryReportMessageId)
        {
            try
            {
                log.Debug("deliveryReportMessageId: " + deliveryReportMessageId + " "); 

                // delete
                Repository.DeleteDeliveryReportMessage(deliveryReportMessageId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public DeliveryReportMessageDTO GetDeliveryReportMessage(int deliveryReportMessageId)
        {
            try
            {
                //Requires.NotNegative("deliveryReportMessageId", deliveryReportMessageId);
                
                log.Debug("deliveryReportMessageId: " + deliveryReportMessageId + " "); 

                // get
                R_DeliveryReportMessage t = Repository.GetDeliveryReportMessage(deliveryReportMessageId);

                DeliveryReportMessageDTO dto = new DeliveryReportMessageDTO(t);

                log.Debug(DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<DeliveryReportMessageDTO> GetDeliveryReportMessages()
        {
            try
            {
                
                log.Debug("GetDeliveryReportMessages"); 

                // get
                IEnumerable<R_DeliveryReportMessage> results = Repository.GetDeliveryReportMessages();

                IEnumerable<DeliveryReportMessageDTO> resultsDTO = results.Select(e => new DeliveryReportMessageDTO(e));

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

        public IList<DeliveryReportMessageDTO> GetDeliveryReportMessages(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_DeliveryReportMessage> results = Repository.GetDeliveryReportMessages(searchTerm, pageIndex, pageSize);
            
                IList<DeliveryReportMessageDTO> resultsDTO = results.Select(e => new DeliveryReportMessageDTO(e)).ToList();

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

        public IEnumerable<DeliveryReportMessageDTO> GetDeliveryReportMessageListAdvancedSearch(
             int? deliveryReportMessageTypeId 
            , string message 
        )
        {
            try
            {
                log.Debug("GetDeliveryReportMessageListAdvancedSearch"); 

                IEnumerable<R_DeliveryReportMessage> results = Repository.GetDeliveryReportMessageListAdvancedSearch(
                     deliveryReportMessageTypeId 
                    , message 
                );
            
                IEnumerable<DeliveryReportMessageDTO> resultsDTO = results.Select(e => new DeliveryReportMessageDTO(e));

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

        public void UpdateDeliveryReportMessage(DeliveryReportMessageDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "DeliveryReportMessageId");

                log.Debug(DeliveryReportMessageDTO.FormatDeliveryReportMessageDTO(dto)); 

                R_DeliveryReportMessage t = DeliveryReportMessageDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateDeliveryReportMessage(t);

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

    