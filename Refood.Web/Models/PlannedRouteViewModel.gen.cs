
// ################################################################
//                      Code generated with T4
// ################################################################

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Refood.Business.DTOs;

namespace Refood.Web.Services.ViewModels
{

    [JsonObject(MemberSerialization.OptIn)]
    public partial class PlannedRouteViewModel
    {
        public PlannedRouteViewModel() { }

        public PlannedRouteViewModel(PlannedRouteDTO t)
        {
            PlannedRouteId = t.PlannedRouteId;
            Name = t.Name;
            RouteTypeId = t.RouteTypeId;
            TransportTypeId = t.TransportTypeId;
            Description = t.Description;
            StartHour = t.StartHour;
            EstimatedDuration = t.EstimatedDuration;
            TotalDistance = t.TotalDistance;
            RouteDayOfTheWeek = t.RouteDayOfTheWeek;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public PlannedRouteViewModel(PlannedRouteDTO t, string editUrl)
        {
            PlannedRouteId = t.PlannedRouteId;
            Name = t.Name;
            RouteTypeId = t.RouteTypeId;
            TransportTypeId = t.TransportTypeId;
            Description = t.Description;
            StartHour = t.StartHour;
            EstimatedDuration = t.EstimatedDuration;
            TotalDistance = t.TotalDistance;
            RouteDayOfTheWeek = t.RouteDayOfTheWeek;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public PlannedRouteDTO UpdateDTO(PlannedRouteDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.PlannedRouteId = this.PlannedRouteId;
                dto.Name = this.Name;
                dto.RouteTypeId = this.RouteTypeId;
                dto.TransportTypeId = this.TransportTypeId;
                dto.Description = this.Description;
                dto.StartHour = this.StartHour;
                dto.EstimatedDuration = this.EstimatedDuration;
                dto.TotalDistance = this.TotalDistance;
                dto.RouteDayOfTheWeek = this.RouteDayOfTheWeek;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("plannedRouteId")]
        public int PlannedRouteId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("routeTypeId")]
        public int? RouteTypeId { get; set; }

        [JsonProperty("transportTypeId")]
        public int? TransportTypeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startHour")]
        public System.DateTime? StartHour { get; set; }

        [JsonProperty("estimatedDuration")]
        public int? EstimatedDuration { get; set; }

        [JsonProperty("totalDistance")]
        public double? TotalDistance { get; set; }

        [JsonProperty("routeDayOfTheWeek")]
        public string RouteDayOfTheWeek { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("createBy")]
        public int? CreateBy { get; set; }

        [JsonProperty("createOn")]
        public System.DateTime? CreateOn { get; set; }

        [JsonProperty("updateBy")]
        public int? UpdateBy { get; set; }

        [JsonProperty("updateOn")]
        public System.DateTime? UpdateOn { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; }



        // logging helper
        public static string FormatPlannedRouteViewModel(PlannedRouteViewModel plannedRouteViewModel)
        {
            if (plannedRouteViewModel == null)
            {
                // null
                return "plannedRouteViewModel: null";
            }
            else
            {
                // output values
                return "plannedRouteViewModel: \n"
                    + "{ \n"
 
                    + "    PlannedRouteId: " +  "'" + plannedRouteViewModel.PlannedRouteId + "'"  + ", \n" 
                    + "    Name: " + (plannedRouteViewModel.Name != null ? "'" + plannedRouteViewModel.Name + "'" : "null") + ", \n" 
                    + "    RouteTypeId: " + (plannedRouteViewModel.RouteTypeId != null ? "'" + plannedRouteViewModel.RouteTypeId + "'" : "null") + ", \n" 
                    + "    TransportTypeId: " + (plannedRouteViewModel.TransportTypeId != null ? "'" + plannedRouteViewModel.TransportTypeId + "'" : "null") + ", \n" 
                    + "    Description: " + (plannedRouteViewModel.Description != null ? "'" + plannedRouteViewModel.Description + "'" : "null") + ", \n" 
                    + "    StartHour: " + (plannedRouteViewModel.StartHour != null ? "'" + plannedRouteViewModel.StartHour + "'" : "null") + ", \n" 
                    + "    EstimatedDuration: " + (plannedRouteViewModel.EstimatedDuration != null ? "'" + plannedRouteViewModel.EstimatedDuration + "'" : "null") + ", \n" 
                    + "    TotalDistance: " + (plannedRouteViewModel.TotalDistance != null ? "'" + plannedRouteViewModel.TotalDistance + "'" : "null") + ", \n" 
                    + "    RouteDayOfTheWeek: " + (plannedRouteViewModel.RouteDayOfTheWeek != null ? "'" + plannedRouteViewModel.RouteDayOfTheWeek + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + plannedRouteViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + plannedRouteViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (plannedRouteViewModel.CreateBy != null ? "'" + plannedRouteViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (plannedRouteViewModel.CreateOn != null ? "'" + plannedRouteViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (plannedRouteViewModel.UpdateBy != null ? "'" + plannedRouteViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (plannedRouteViewModel.UpdateOn != null ? "'" + plannedRouteViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    