
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IPlannedRouteService
    {
        int AddPlannedRoute(PlannedRouteDTO dto);

        void DeletePlannedRoute(int plannedRouteId);

        void DeletePlannedRoute(PlannedRouteDTO dto);

        PlannedRouteDTO GetPlannedRoute(int plannedRouteId);

        IEnumerable<PlannedRouteDTO> GetPlannedRoutes();

        IList<PlannedRouteDTO> GetPlannedRoutes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<PlannedRouteDTO> GetPlannedRouteListAdvancedSearch(
            string name 
            ,int? routeTypeId 
            ,int? transportTypeId 
            ,string description 
            ,System.DateTime? startHourFrom 
            ,System.DateTime? startHourTo 
            ,int? estimatedDuration 
            ,double? totalDistance 
            ,string routeDayOfTheWeek 
            ,bool? active 
        );

        void UpdatePlannedRoute(PlannedRouteDTO dto);

    }
}
    