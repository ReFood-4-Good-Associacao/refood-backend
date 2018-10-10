
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
    public partial class DeliveryReportService :  IDeliveryReportService
    {
        public static IDeliveryReportRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeliveryReportService()
        {
            if (Repository == null)
            {
                Repository = new DeliveryReportRepository();
            }
        }

        public int AddDeliveryReport(DeliveryReportDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(DeliveryReportDTO.FormatDeliveryReportDTO(dto)); 

                R_DeliveryReport t = DeliveryReportDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddDeliveryReport(t);
                dto.DeliveryReportId = id;

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

        public void DeleteDeliveryReport(DeliveryReportDTO dto)
        {
            try
            {
                log.Debug(DeliveryReportDTO.FormatDeliveryReportDTO(dto)); 
            
                R_DeliveryReport t = DeliveryReportDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteDeliveryReport(t);
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

        public void DeleteDeliveryReport(int deliveryReportId)
        {
            try
            {
                log.Debug("deliveryReportId: " + deliveryReportId + " "); 

                // delete
                Repository.DeleteDeliveryReport(deliveryReportId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public DeliveryReportDTO GetDeliveryReport(int deliveryReportId)
        {
            try
            {
                //Requires.NotNegative("deliveryReportId", deliveryReportId);
                
                log.Debug("deliveryReportId: " + deliveryReportId + " "); 

                // get
                R_DeliveryReport t = Repository.GetDeliveryReport(deliveryReportId);

                DeliveryReportDTO dto = new DeliveryReportDTO(t);

                log.Debug(DeliveryReportDTO.FormatDeliveryReportDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<DeliveryReportDTO> GetDeliveryReports()
        {
            try
            {
                
                log.Debug("GetDeliveryReports"); 

                // get
                IEnumerable<R_DeliveryReport> results = Repository.GetDeliveryReports();

                IEnumerable<DeliveryReportDTO> resultsDTO = results.Select(e => new DeliveryReportDTO(e));

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

        public IList<DeliveryReportDTO> GetDeliveryReports(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_DeliveryReport> results = Repository.GetDeliveryReports(searchTerm, pageIndex, pageSize);
            
                IList<DeliveryReportDTO> resultsDTO = results.Select(e => new DeliveryReportDTO(e)).ToList();

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

        public IEnumerable<DeliveryReportDTO> GetDeliveryReportListAdvancedSearch(
             string name 
            , string description 
            , System.DateTime? reportDateFrom 
            , System.DateTime? reportDateTo 
            , string weekDay 
            , bool? submitted 
        )
        {
            try
            {
                log.Debug("GetDeliveryReportListAdvancedSearch"); 

                IEnumerable<R_DeliveryReport> results = Repository.GetDeliveryReportListAdvancedSearch(
                     name 
                    , description 
                    , reportDateFrom 
                    , reportDateTo 
                    , weekDay 
                    , submitted 
                );
            
                IEnumerable<DeliveryReportDTO> resultsDTO = results.Select(e => new DeliveryReportDTO(e));

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

        public void UpdateDeliveryReport(DeliveryReportDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "DeliveryReportId");

                log.Debug(DeliveryReportDTO.FormatDeliveryReportDTO(dto)); 

                R_DeliveryReport t = DeliveryReportDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateDeliveryReport(t);

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

    