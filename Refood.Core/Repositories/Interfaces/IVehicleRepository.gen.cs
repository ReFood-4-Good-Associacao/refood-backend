
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IVehicleRepository
    {
        int AddVehicle(R_Vehicle t);

        void DeleteVehicle(R_Vehicle t);

        void DeleteVehicle(int vehicleId);

        R_Vehicle GetVehicle(int vehicleId);

        IEnumerable<R_Vehicle> GetVehicles();

        IList<R_Vehicle> GetVehicles(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Vehicle> GetVehicleListAdvancedSearch(
            string make 
            , string model 
            , string owner 
            , int? ownerId 
            , int? nucleoId 
            , int? vehicleTypeId 
            , int? energySourceId 
            , int? averageSpeed 
            , int? horsePower 
            , double? fuelConsumption 
            , double? fuelAutonomyDistance 
            , int? rechargeTime 
            , string licensePlate 
            , string color 
            , int? numberSeats 
            , int? cargoVolumeCapacity 
            , bool? active 
        );

        void UpdateVehicle(R_Vehicle t);

    }
}

    