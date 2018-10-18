
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
    public partial class CheckpointService :  ICheckpointService
    {
        public static ICheckpointRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CheckpointService()
        {
            if (Repository == null)
            {
                Repository = new CheckpointRepository();
            }
        }

        public int AddCheckpoint(CheckpointDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(CheckpointDTO.FormatCheckpointDTO(dto)); 

                R_Checkpoint t = CheckpointDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddCheckpoint(t);
                dto.CheckpointId = id;

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

        public void DeleteCheckpoint(CheckpointDTO dto)
        {
            try
            {
                log.Debug(CheckpointDTO.FormatCheckpointDTO(dto)); 
            
                R_Checkpoint t = CheckpointDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteCheckpoint(t);
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

        public void DeleteCheckpoint(int checkpointId)
        {
            try
            {
                log.Debug("checkpointId: " + checkpointId + " "); 

                // delete
                Repository.DeleteCheckpoint(checkpointId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public CheckpointDTO GetCheckpoint(int checkpointId)
        {
            try
            {
                //Requires.NotNegative("checkpointId", checkpointId);
                
                log.Debug("checkpointId: " + checkpointId + " "); 

                // get
                R_Checkpoint t = Repository.GetCheckpoint(checkpointId);

                CheckpointDTO dto = new CheckpointDTO(t);

                log.Debug(CheckpointDTO.FormatCheckpointDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<CheckpointDTO> GetCheckpoints()
        {
            try
            {
                
                log.Debug("GetCheckpoints"); 

                // get
                IEnumerable<R_Checkpoint> results = Repository.GetCheckpoints();

                IEnumerable<CheckpointDTO> resultsDTO = results.Select(e => new CheckpointDTO(e));

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

        public IList<CheckpointDTO> GetCheckpoints(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Checkpoint> results = Repository.GetCheckpoints(searchTerm, pageIndex, pageSize);
            
                IList<CheckpointDTO> resultsDTO = results.Select(e => new CheckpointDTO(e)).ToList();

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

        public IEnumerable<CheckpointDTO> GetCheckpointListAdvancedSearch(
             int? plannedRouteId 
            , string name 
            , int? orderNumber 
            , double? latitude 
            , double? longitude 
            , int? addressId 
            , int? estimatedTimeArrival 
            , System.DateTime? minimumTimeFrom 
            , System.DateTime? minimumTimeTo 
            , System.DateTime? maximumTimeFrom 
            , System.DateTime? maximumTimeTo 
            , int? nucleoId 
            , int? supplierId 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetCheckpointListAdvancedSearch"); 

                IEnumerable<R_Checkpoint> results = Repository.GetCheckpointListAdvancedSearch(
                     plannedRouteId 
                    , name 
                    , orderNumber 
                    , latitude 
                    , longitude 
                    , addressId 
                    , estimatedTimeArrival 
                    , minimumTimeFrom 
                    , minimumTimeTo 
                    , maximumTimeFrom 
                    , maximumTimeTo 
                    , nucleoId 
                    , supplierId 
                    , active 
                );
            
                IEnumerable<CheckpointDTO> resultsDTO = results.Select(e => new CheckpointDTO(e));

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

        public void UpdateCheckpoint(CheckpointDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "CheckpointId");

                log.Debug(CheckpointDTO.FormatCheckpointDTO(dto)); 

                R_Checkpoint t = CheckpointDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateCheckpoint(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<CheckpointDTO> GetCheckpointListByPlannedRouteId(int checkpointId)
        {
            try
            {
                
                log.Debug("PlannedRouteId: " + checkpointId + " "); 

                // get list by PlannedRoute id
                IEnumerable<R_Checkpoint> results = Repository.GetCheckpointListByPlannedRouteId(checkpointId);
            
                IEnumerable<CheckpointDTO> resultsDTO = results.Select(e => new CheckpointDTO(e));

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

    }
}

    