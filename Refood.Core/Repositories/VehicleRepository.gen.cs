
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
    public partial class VehicleRepository : IVehicleRepository
    {
        public int AddVehicle(R_Vehicle t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteVehicle(R_Vehicle t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteVehicle(int vehicleId)
        {
            var t = GetVehicle(vehicleId);
            DeleteVehicle(t);
        }

        public R_Vehicle GetVehicle(int vehicleId)
        {
            //Requires.NotNegative("vehicleId", vehicleId);
            
            R_Vehicle t = R_Vehicle.SingleOrDefault(vehicleId);

            return t;
        }

        public IEnumerable<R_Vehicle> GetVehicles()
        {
             
            IEnumerable<R_Vehicle> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Vehicle")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Vehicle.Query(sql);

            return results;
        }

        public IList<R_Vehicle> GetVehicles(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Vehicle> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Vehicle")
                .Where("IsDeleted = 0")
                .Where(
                    "Make like '%" + searchTerm + "%'"
                     + " or " + "Model like '%" + searchTerm + "%'"
                     + " or " + "Owner like '%" + searchTerm + "%'"
                     + " or " + "LicensePlate like '%" + searchTerm + "%'"
                     + " or " + "Color like '%" + searchTerm + "%'"
                )
            ;

            results = R_Vehicle.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Vehicle> GetVehicleListAdvancedSearch(
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
        )
        {
            IEnumerable<R_Vehicle> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Vehicle")
                .Where("IsDeleted = 0" 
                    + (make != null ? " and Make like '%" + make + "%'" : "")
                    + (model != null ? " and Model like '%" + model + "%'" : "")
                    + (owner != null ? " and Owner like '%" + owner + "%'" : "")
                    + (ownerId != null ? " and OwnerId like '%" + ownerId + "%'" : "")
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (vehicleTypeId != null ? " and VehicleTypeId = " + vehicleTypeId : "")
                    + (energySourceId != null ? " and EnergySourceId = " + energySourceId : "")
                    + (averageSpeed != null ? " and AverageSpeed like '%" + averageSpeed + "%'" : "")
                    + (horsePower != null ? " and HorsePower like '%" + horsePower + "%'" : "")
                    + (fuelConsumption != null ? " and FuelConsumption like '%" + fuelConsumption + "%'" : "")
                    + (fuelAutonomyDistance != null ? " and FuelAutonomyDistance like '%" + fuelAutonomyDistance + "%'" : "")
                    + (rechargeTime != null ? " and RechargeTime like '%" + rechargeTime + "%'" : "")
                    + (licensePlate != null ? " and LicensePlate like '%" + licensePlate + "%'" : "")
                    + (color != null ? " and Color like '%" + color + "%'" : "")
                    + (numberSeats != null ? " and NumberSeats like '%" + numberSeats + "%'" : "")
                    + (cargoVolumeCapacity != null ? " and CargoVolumeCapacity like '%" + cargoVolumeCapacity + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Vehicle.Query(sql);

            return results;
        }

        public void UpdateVehicle(R_Vehicle t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "VehicleId");

            t.Update();
        }

    }
}

        