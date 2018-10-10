
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class VehicleDTO
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public int? OwnerId { get; set; }
        public int? NucleoId { get; set; }
        public int VehicleTypeId { get; set; }
        public int EnergySourceId { get; set; }
        public int? AverageSpeed { get; set; }
        public int? HorsePower { get; set; }
        public double? FuelConsumption { get; set; }
        public double? FuelAutonomyDistance { get; set; }
        public int? RechargeTime { get; set; }
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public int? NumberSeats { get; set; }
        public int? CargoVolumeCapacity { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public VehicleDTO()
        {
        
        }

        public VehicleDTO(R_Vehicle vehicle)
        {
            VehicleId = vehicle.VehicleId;
            Make = vehicle.Make;
            Model = vehicle.Model;
            Owner = vehicle.Owner;
            OwnerId = vehicle.OwnerId;
            NucleoId = vehicle.NucleoId;
            VehicleTypeId = vehicle.VehicleTypeId;
            EnergySourceId = vehicle.EnergySourceId;
            AverageSpeed = vehicle.AverageSpeed;
            HorsePower = vehicle.HorsePower;
            FuelConsumption = vehicle.FuelConsumption;
            FuelAutonomyDistance = vehicle.FuelAutonomyDistance;
            RechargeTime = vehicle.RechargeTime;
            LicensePlate = vehicle.LicensePlate;
            Color = vehicle.Color;
            NumberSeats = vehicle.NumberSeats;
            CargoVolumeCapacity = vehicle.CargoVolumeCapacity;
            Active = vehicle.Active;
            IsDeleted = vehicle.IsDeleted;
            CreateBy = vehicle.CreateBy;
            CreateOn = vehicle.CreateOn;
            UpdateBy = vehicle.UpdateBy;
            UpdateOn = vehicle.UpdateOn;
        }

        public static R_Vehicle ConvertDTOtoEntity(VehicleDTO dto)
        {
            R_Vehicle vehicle = new R_Vehicle();

            vehicle.VehicleId = dto.VehicleId;
            vehicle.Make = dto.Make;
            vehicle.Model = dto.Model;
            vehicle.Owner = dto.Owner;
            vehicle.OwnerId = dto.OwnerId;
            vehicle.NucleoId = dto.NucleoId;
            vehicle.VehicleTypeId = dto.VehicleTypeId;
            vehicle.EnergySourceId = dto.EnergySourceId;
            vehicle.AverageSpeed = dto.AverageSpeed;
            vehicle.HorsePower = dto.HorsePower;
            vehicle.FuelConsumption = dto.FuelConsumption;
            vehicle.FuelAutonomyDistance = dto.FuelAutonomyDistance;
            vehicle.RechargeTime = dto.RechargeTime;
            vehicle.LicensePlate = dto.LicensePlate;
            vehicle.Color = dto.Color;
            vehicle.NumberSeats = dto.NumberSeats;
            vehicle.CargoVolumeCapacity = dto.CargoVolumeCapacity;
            vehicle.Active = dto.Active;
            vehicle.IsDeleted = dto.IsDeleted;
            vehicle.CreateBy = dto.CreateBy;
            vehicle.CreateOn = dto.CreateOn;
            vehicle.UpdateBy = dto.UpdateBy;
            vehicle.UpdateOn = dto.UpdateOn;

            return vehicle;
        }

        // logging helper
        public static string FormatVehicleDTO(VehicleDTO vehicleDTO)
        {
            if(vehicleDTO == null)
            {
                // null
                return "vehicleDTO: null";
            }
            else
            {
                // output values
                return "vehicleDTO: \n"
                    + "{ \n"
 
                    + "    VehicleId: " +  "'" + vehicleDTO.VehicleId + "'"  + ", \n" 
                    + "    Make: " + (vehicleDTO.Make != null ? "'" + vehicleDTO.Make + "'" : "null") + ", \n" 
                    + "    Model: " + (vehicleDTO.Model != null ? "'" + vehicleDTO.Model + "'" : "null") + ", \n" 
                    + "    Owner: " + (vehicleDTO.Owner != null ? "'" + vehicleDTO.Owner + "'" : "null") + ", \n" 
                    + "    OwnerId: " + (vehicleDTO.OwnerId != null ? "'" + vehicleDTO.OwnerId + "'" : "null") + ", \n" 
                    + "    NucleoId: " + (vehicleDTO.NucleoId != null ? "'" + vehicleDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    VehicleTypeId: " +  "'" + vehicleDTO.VehicleTypeId + "'"  + ", \n" 
                    + "    EnergySourceId: " +  "'" + vehicleDTO.EnergySourceId + "'"  + ", \n" 
                    + "    AverageSpeed: " + (vehicleDTO.AverageSpeed != null ? "'" + vehicleDTO.AverageSpeed + "'" : "null") + ", \n" 
                    + "    HorsePower: " + (vehicleDTO.HorsePower != null ? "'" + vehicleDTO.HorsePower + "'" : "null") + ", \n" 
                    + "    FuelConsumption: " + (vehicleDTO.FuelConsumption != null ? "'" + vehicleDTO.FuelConsumption + "'" : "null") + ", \n" 
                    + "    FuelAutonomyDistance: " + (vehicleDTO.FuelAutonomyDistance != null ? "'" + vehicleDTO.FuelAutonomyDistance + "'" : "null") + ", \n" 
                    + "    RechargeTime: " + (vehicleDTO.RechargeTime != null ? "'" + vehicleDTO.RechargeTime + "'" : "null") + ", \n" 
                    + "    LicensePlate: " + (vehicleDTO.LicensePlate != null ? "'" + vehicleDTO.LicensePlate + "'" : "null") + ", \n" 
                    + "    Color: " + (vehicleDTO.Color != null ? "'" + vehicleDTO.Color + "'" : "null") + ", \n" 
                    + "    NumberSeats: " + (vehicleDTO.NumberSeats != null ? "'" + vehicleDTO.NumberSeats + "'" : "null") + ", \n" 
                    + "    CargoVolumeCapacity: " + (vehicleDTO.CargoVolumeCapacity != null ? "'" + vehicleDTO.CargoVolumeCapacity + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + vehicleDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + vehicleDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (vehicleDTO.CreateBy != null ? "'" + vehicleDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (vehicleDTO.CreateOn != null ? "'" + vehicleDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (vehicleDTO.UpdateBy != null ? "'" + vehicleDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (vehicleDTO.UpdateOn != null ? "'" + vehicleDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    