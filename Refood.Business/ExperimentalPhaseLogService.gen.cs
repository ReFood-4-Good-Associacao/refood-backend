
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
    public partial class ExperimentalPhaseLogService :  IExperimentalPhaseLogService
    {
        public static IExperimentalPhaseLogRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExperimentalPhaseLogService()
        {
            if (Repository == null)
            {
                Repository = new ExperimentalPhaseLogRepository();
            }
        }

        public int AddExperimentalPhaseLog(ExperimentalPhaseLogDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(dto)); 

                R_ExperimentalPhaseLog t = ExperimentalPhaseLogDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddExperimentalPhaseLog(t);
                dto.ExperimentalPhaseLogId = id;

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

        public void DeleteExperimentalPhaseLog(ExperimentalPhaseLogDTO dto)
        {
            try
            {
                log.Debug(ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(dto)); 
            
                R_ExperimentalPhaseLog t = ExperimentalPhaseLogDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteExperimentalPhaseLog(t);
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

        public void DeleteExperimentalPhaseLog(int experimentalPhaseLogId)
        {
            try
            {
                log.Debug("experimentalPhaseLogId: " + experimentalPhaseLogId + " "); 

                // delete
                Repository.DeleteExperimentalPhaseLog(experimentalPhaseLogId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ExperimentalPhaseLogDTO GetExperimentalPhaseLog(int experimentalPhaseLogId)
        {
            try
            {
                //Requires.NotNegative("experimentalPhaseLogId", experimentalPhaseLogId);
                
                log.Debug("experimentalPhaseLogId: " + experimentalPhaseLogId + " "); 

                // get
                R_ExperimentalPhaseLog t = Repository.GetExperimentalPhaseLog(experimentalPhaseLogId);

                ExperimentalPhaseLogDTO dto = new ExperimentalPhaseLogDTO(t);

                log.Debug(ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ExperimentalPhaseLogDTO> GetExperimentalPhaseLogs()
        {
            try
            {
                
                log.Debug("GetExperimentalPhaseLogs"); 

                // get
                IEnumerable<R_ExperimentalPhaseLog> results = Repository.GetExperimentalPhaseLogs();

                IEnumerable<ExperimentalPhaseLogDTO> resultsDTO = results.Select(e => new ExperimentalPhaseLogDTO(e));

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

        public IList<ExperimentalPhaseLogDTO> GetExperimentalPhaseLogs(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_ExperimentalPhaseLog> results = Repository.GetExperimentalPhaseLogs(searchTerm, pageIndex, pageSize);
            
                IList<ExperimentalPhaseLogDTO> resultsDTO = results.Select(e => new ExperimentalPhaseLogDTO(e)).ToList();

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

        public IEnumerable<ExperimentalPhaseLogDTO> GetExperimentalPhaseLogListAdvancedSearch(
             int? nucleoId 
            , System.DateTime? logDateFrom 
            , System.DateTime? logDateTo 
            , string task 
            , string activityDescription 
            , string managerName 
            , string volunteerName 
            , bool? volunteerConfirmation 
            , int? documentId 
        )
        {
            try
            {
                log.Debug("GetExperimentalPhaseLogListAdvancedSearch"); 

                IEnumerable<R_ExperimentalPhaseLog> results = Repository.GetExperimentalPhaseLogListAdvancedSearch(
                     nucleoId 
                    , logDateFrom 
                    , logDateTo 
                    , task 
                    , activityDescription 
                    , managerName 
                    , volunteerName 
                    , volunteerConfirmation 
                    , documentId 
                );
            
                IEnumerable<ExperimentalPhaseLogDTO> resultsDTO = results.Select(e => new ExperimentalPhaseLogDTO(e));

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

        public void UpdateExperimentalPhaseLog(ExperimentalPhaseLogDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ExperimentalPhaseLogId");

                log.Debug(ExperimentalPhaseLogDTO.FormatExperimentalPhaseLogDTO(dto)); 

                R_ExperimentalPhaseLog t = ExperimentalPhaseLogDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateExperimentalPhaseLog(t);

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

    