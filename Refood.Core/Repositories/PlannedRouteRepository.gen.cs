
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class PlannedRouteRepository : IPlannedRouteRepository
    {
        public int AddPlannedRoute(R_PlannedRoute t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeletePlannedRoute(R_PlannedRoute t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeletePlannedRoute(int plannedRouteId)
        {
            var t = GetPlannedRoute(plannedRouteId);
            DeletePlannedRoute(t);
        }

        public R_PlannedRoute GetPlannedRoute(int plannedRouteId)
        {
            //Requires.NotNegative("plannedRouteId", plannedRouteId);
            
            R_PlannedRoute t = R_PlannedRoute.SingleOrDefault(plannedRouteId);

            return t;
        }

        public IEnumerable<R_PlannedRoute> GetPlannedRoutes()
        {
             
            IEnumerable<R_PlannedRoute> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_PlannedRoute")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_PlannedRoute.Query(sql);

            return results;
        }

        public IList<R_PlannedRoute> GetPlannedRoutes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_PlannedRoute> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_PlannedRoute")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "RouteDayOfTheWeek like '%" + searchTerm + "%'"
                )
            ;

            results = R_PlannedRoute.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_PlannedRoute> GetPlannedRouteListAdvancedSearch(
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
            IEnumerable<R_PlannedRoute> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_PlannedRoute")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (routeTypeId != null ? " and RouteTypeId like '%" + routeTypeId + "%'" : "")
                    + (transportTypeId != null ? " and TransportTypeId like '%" + transportTypeId + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (startHourFrom != null ? " and StartHour >= '" + startHourFrom.Value.ToShortDateString() + "'" : "")
                    + (startHourTo != null ? " and StartHour <= '" + startHourTo.Value.ToShortDateString() + "'" : "")
                    + (estimatedDuration != null ? " and EstimatedDuration like '%" + estimatedDuration + "%'" : "")
                    + (totalDistance != null ? " and TotalDistance like '%" + totalDistance + "%'" : "")
                    + (routeDayOfTheWeek != null ? " and RouteDayOfTheWeek like '%" + routeDayOfTheWeek + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_PlannedRoute.Query(sql);

            return results;
        }

        public void UpdatePlannedRoute(R_PlannedRoute t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "PlannedRouteId");

            t.Update();
        }

    }
}

        