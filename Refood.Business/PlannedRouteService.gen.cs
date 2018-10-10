
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
    public partial class PlannedRouteService :  IPlannedRouteService
    {
        public static IPlannedRouteRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlannedRouteService()
        {
            if (Repository == null)
            {
                Repository = new PlannedRouteRepository();
            }
        }

        public int AddPlannedRoute(PlannedRouteDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(PlannedRouteDTO.FormatPlannedRouteDTO(dto)); 

                R_PlannedRoute t = PlannedRouteDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddPlannedRoute(t);
                dto.PlannedRouteId = id;

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

        public void DeletePlannedRoute(PlannedRouteDTO dto)
        {
            try
            {
                log.Debug(PlannedRouteDTO.FormatPlannedRouteDTO(dto)); 
            
                R_PlannedRoute t = PlannedRouteDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeletePlannedRoute(t);
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

        public void DeletePlannedRoute(int plannedRouteId)
        {
            try
            {
                log.Debug("plannedRouteId: " + plannedRouteId + " "); 

                // delete
                Repository.DeletePlannedRoute(plannedRouteId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public PlannedRouteDTO GetPlannedRoute(int plannedRouteId)
        {
            try
            {
                //Requires.NotNegative("plannedRouteId", plannedRouteId);
                
                log.Debug("plannedRouteId: " + plannedRouteId + " "); 

                // get
                R_PlannedRoute t = Repository.GetPlannedRoute(plannedRouteId);

                PlannedRouteDTO dto = new PlannedRouteDTO(t);

                log.Debug(PlannedRouteDTO.FormatPlannedRouteDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<PlannedRouteDTO> GetPlannedRoutes()
        {
            try
            {
                
                log.Debug("GetPlannedRoutes"); 

                // get
                IEnumerable<R_PlannedRoute> results = Repository.GetPlannedRoutes();

                IEnumerable<PlannedRouteDTO> resultsDTO = results.Select(e => new PlannedRouteDTO(e));

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

        public IList<PlannedRouteDTO> GetPlannedRoutes(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_PlannedRoute> results = Repository.GetPlannedRoutes(searchTerm, pageIndex, pageSize);
            
                IList<PlannedRouteDTO> resultsDTO = results.Select(e => new PlannedRouteDTO(e)).ToList();

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

        public IEnumerable<PlannedRouteDTO> GetPlannedRouteListAdvancedSearch(
             string name 
            , int? routeTypeId 
            , int? transportTypeId 
            , string description 
            , System.DateTime? startHourFrom 
            , System.DateTime? startHourTo 
            , int? estimatedDuration 
            , double? totalDistance 
            , string routeDayOfTheWeek 
            , bool? active 
        )
        {
            try
            {
                log.Debug("GetPlannedRouteListAdvancedSearch"); 

                IEnumerable<R_PlannedRoute> results = Repository.GetPlannedRouteListAdvancedSearch(
                     name 
                    , routeTypeId 
                    , transportTypeId 
                    , description 
                    , startHourFrom 
                    , startHourTo 
                    , estimatedDuration 
                    , totalDistance 
                    , routeDayOfTheWeek 
                    , active 
                );
            
                IEnumerable<PlannedRouteDTO> resultsDTO = results.Select(e => new PlannedRouteDTO(e));

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

        public void UpdatePlannedRoute(PlannedRouteDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "PlannedRouteId");

                log.Debug(PlannedRouteDTO.FormatPlannedRouteDTO(dto)); 

                R_PlannedRoute t = PlannedRouteDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdatePlannedRoute(t);

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

    