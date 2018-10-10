
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class PlannedRouteDTO
    {
        public int PlannedRouteId { get; set; }
        public string Name { get; set; }
        public int? RouteTypeId { get; set; }
        public int? TransportTypeId { get; set; }
        public string Description { get; set; }
        public System.DateTime? StartHour { get; set; }
        public int? EstimatedDuration { get; set; }
        public double? TotalDistance { get; set; }
        public string RouteDayOfTheWeek { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public PlannedRouteDTO()
        {
        
        }

        public PlannedRouteDTO(R_PlannedRoute plannedRoute)
        {
            PlannedRouteId = plannedRoute.PlannedRouteId;
            Name = plannedRoute.Name;
            RouteTypeId = plannedRoute.RouteTypeId;
            TransportTypeId = plannedRoute.TransportTypeId;
            Description = plannedRoute.Description;
            StartHour = plannedRoute.StartHour;
            EstimatedDuration = plannedRoute.EstimatedDuration;
            TotalDistance = plannedRoute.TotalDistance;
            RouteDayOfTheWeek = plannedRoute.RouteDayOfTheWeek;
            Active = plannedRoute.Active;
            IsDeleted = plannedRoute.IsDeleted;
            CreateBy = plannedRoute.CreateBy;
            CreateOn = plannedRoute.CreateOn;
            UpdateBy = plannedRoute.UpdateBy;
            UpdateOn = plannedRoute.UpdateOn;
        }

        public static R_PlannedRoute ConvertDTOtoEntity(PlannedRouteDTO dto)
        {
            R_PlannedRoute plannedRoute = new R_PlannedRoute();

            plannedRoute.PlannedRouteId = dto.PlannedRouteId;
            plannedRoute.Name = dto.Name;
            plannedRoute.RouteTypeId = dto.RouteTypeId;
            plannedRoute.TransportTypeId = dto.TransportTypeId;
            plannedRoute.Description = dto.Description;
            plannedRoute.StartHour = dto.StartHour;
            plannedRoute.EstimatedDuration = dto.EstimatedDuration;
            plannedRoute.TotalDistance = dto.TotalDistance;
            plannedRoute.RouteDayOfTheWeek = dto.RouteDayOfTheWeek;
            plannedRoute.Active = dto.Active;
            plannedRoute.IsDeleted = dto.IsDeleted;
            plannedRoute.CreateBy = dto.CreateBy;
            plannedRoute.CreateOn = dto.CreateOn;
            plannedRoute.UpdateBy = dto.UpdateBy;
            plannedRoute.UpdateOn = dto.UpdateOn;

            return plannedRoute;
        }

        // logging helper
        public static string FormatPlannedRouteDTO(PlannedRouteDTO plannedRouteDTO)
        {
            if(plannedRouteDTO == null)
            {
                // null
                return "plannedRouteDTO: null";
            }
            else
            {
                // output values
                return "plannedRouteDTO: \n"
                    + "{ \n"
 
                    + "    PlannedRouteId: " +  "'" + plannedRouteDTO.PlannedRouteId + "'"  + ", \n" 
                    + "    Name: " + (plannedRouteDTO.Name != null ? "'" + plannedRouteDTO.Name + "'" : "null") + ", \n" 
                    + "    RouteTypeId: " + (plannedRouteDTO.RouteTypeId != null ? "'" + plannedRouteDTO.RouteTypeId + "'" : "null") + ", \n" 
                    + "    TransportTypeId: " + (plannedRouteDTO.TransportTypeId != null ? "'" + plannedRouteDTO.TransportTypeId + "'" : "null") + ", \n" 
                    + "    Description: " + (plannedRouteDTO.Description != null ? "'" + plannedRouteDTO.Description + "'" : "null") + ", \n" 
                    + "    StartHour: " + (plannedRouteDTO.StartHour != null ? "'" + plannedRouteDTO.StartHour + "'" : "null") + ", \n" 
                    + "    EstimatedDuration: " + (plannedRouteDTO.EstimatedDuration != null ? "'" + plannedRouteDTO.EstimatedDuration + "'" : "null") + ", \n" 
                    + "    TotalDistance: " + (plannedRouteDTO.TotalDistance != null ? "'" + plannedRouteDTO.TotalDistance + "'" : "null") + ", \n" 
                    + "    RouteDayOfTheWeek: " + (plannedRouteDTO.RouteDayOfTheWeek != null ? "'" + plannedRouteDTO.RouteDayOfTheWeek + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + plannedRouteDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + plannedRouteDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (plannedRouteDTO.CreateBy != null ? "'" + plannedRouteDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (plannedRouteDTO.CreateOn != null ? "'" + plannedRouteDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (plannedRouteDTO.UpdateBy != null ? "'" + plannedRouteDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (plannedRouteDTO.UpdateOn != null ? "'" + plannedRouteDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    