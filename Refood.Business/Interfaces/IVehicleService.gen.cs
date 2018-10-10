
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IVehicleService
    {
        int AddVehicle(VehicleDTO dto);

        void DeleteVehicle(int vehicleId);

        void DeleteVehicle(VehicleDTO dto);

        VehicleDTO GetVehicle(int vehicleId);

        IEnumerable<VehicleDTO> GetVehicles();

        IList<VehicleDTO> GetVehicles(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<VehicleDTO> GetVehicleListAdvancedSearch(
            string make 
            ,string model 
            ,string owner 
            ,int? ownerId 
            ,int? nucleoId 
            ,int? vehicleTypeId 
            ,int? energySourceId 
            ,int? averageSpeed 
            ,int? horsePower 
            ,double? fuelConsumption 
            ,double? fuelAutonomyDistance 
            ,int? rechargeTime 
            ,string licensePlate 
            ,string color 
            ,int? numberSeats 
            ,int? cargoVolumeCapacity 
            ,bool? active 
        );

        void UpdateVehicle(VehicleDTO dto);

    }
}
    