
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IPlannedRouteRepository
    {
        int AddPlannedRoute(R_PlannedRoute t);

        void DeletePlannedRoute(R_PlannedRoute t);

        void DeletePlannedRoute(int plannedRouteId);

        R_PlannedRoute GetPlannedRoute(int plannedRouteId);

        IEnumerable<R_PlannedRoute> GetPlannedRoutes();

        IList<R_PlannedRoute> GetPlannedRoutes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_PlannedRoute> GetPlannedRouteListAdvancedSearch(
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
        );

        void UpdatePlannedRoute(R_PlannedRoute t);

    }
}

    