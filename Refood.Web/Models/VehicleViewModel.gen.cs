
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
    public partial class VehicleViewModel
    {
        public VehicleViewModel() { }

        public VehicleViewModel(VehicleDTO t)
        {
            VehicleId = t.VehicleId;
            Make = t.Make;
            Model = t.Model;
            Owner = t.Owner;
            OwnerId = t.OwnerId;
            NucleoId = t.NucleoId;
            VehicleTypeId = t.VehicleTypeId;
            EnergySourceId = t.EnergySourceId;
            AverageSpeed = t.AverageSpeed;
            HorsePower = t.HorsePower;
            FuelConsumption = t.FuelConsumption;
            FuelAutonomyDistance = t.FuelAutonomyDistance;
            RechargeTime = t.RechargeTime;
            LicensePlate = t.LicensePlate;
            Color = t.Color;
            NumberSeats = t.NumberSeats;
            CargoVolumeCapacity = t.CargoVolumeCapacity;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public VehicleViewModel(VehicleDTO t, string editUrl)
        {
            VehicleId = t.VehicleId;
            Make = t.Make;
            Model = t.Model;
            Owner = t.Owner;
            OwnerId = t.OwnerId;
            NucleoId = t.NucleoId;
            VehicleTypeId = t.VehicleTypeId;
            EnergySourceId = t.EnergySourceId;
            AverageSpeed = t.AverageSpeed;
            HorsePower = t.HorsePower;
            FuelConsumption = t.FuelConsumption;
            FuelAutonomyDistance = t.FuelAutonomyDistance;
            RechargeTime = t.RechargeTime;
            LicensePlate = t.LicensePlate;
            Color = t.Color;
            NumberSeats = t.NumberSeats;
            CargoVolumeCapacity = t.CargoVolumeCapacity;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public VehicleDTO UpdateDTO(VehicleDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.VehicleId = this.VehicleId;
                dto.Make = this.Make;
                dto.Model = this.Model;
                dto.Owner = this.Owner;
                dto.OwnerId = this.OwnerId;
                dto.NucleoId = this.NucleoId;
                dto.VehicleTypeId = this.VehicleTypeId;
                dto.EnergySourceId = this.EnergySourceId;
                dto.AverageSpeed = this.AverageSpeed;
                dto.HorsePower = this.HorsePower;
                dto.FuelConsumption = this.FuelConsumption;
                dto.FuelAutonomyDistance = this.FuelAutonomyDistance;
                dto.RechargeTime = this.RechargeTime;
                dto.LicensePlate = this.LicensePlate;
                dto.Color = this.Color;
                dto.NumberSeats = this.NumberSeats;
                dto.CargoVolumeCapacity = this.CargoVolumeCapacity;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("vehicleId")]
        public int VehicleId { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("ownerId")]
        public int? OwnerId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("vehicleTypeId")]
        public int VehicleTypeId { get; set; }

        [JsonProperty("energySourceId")]
        public int EnergySourceId { get; set; }

        [JsonProperty("averageSpeed")]
        public int? AverageSpeed { get; set; }

        [JsonProperty("horsePower")]
        public int? HorsePower { get; set; }

        [JsonProperty("fuelConsumption")]
        public double? FuelConsumption { get; set; }

        [JsonProperty("fuelAutonomyDistance")]
        public double? FuelAutonomyDistance { get; set; }

        [JsonProperty("rechargeTime")]
        public int? RechargeTime { get; set; }

        [JsonProperty("licensePlate")]
        public string LicensePlate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("numberSeats")]
        public int? NumberSeats { get; set; }

        [JsonProperty("cargoVolumeCapacity")]
        public int? CargoVolumeCapacity { get; set; }

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
        public static string FormatVehicleViewModel(VehicleViewModel vehicleViewModel)
        {
            if (vehicleViewModel == null)
            {
                // null
                return "vehicleViewModel: null";
            }
            else
            {
                // output values
                return "vehicleViewModel: \n"
                    + "{ \n"
 
                    + "    VehicleId: " +  "'" + vehicleViewModel.VehicleId + "'"  + ", \n" 
                    + "    Make: " + (vehicleViewModel.Make != null ? "'" + vehicleViewModel.Make + "'" : "null") + ", \n" 
                    + "    Model: " + (vehicleViewModel.Model != null ? "'" + vehicleViewModel.Model + "'" : "null") + ", \n" 
                    + "    Owner: " + (vehicleViewModel.Owner != null ? "'" + vehicleViewModel.Owner + "'" : "null") + ", \n" 
                    + "    OwnerId: " + (vehicleViewModel.OwnerId != null ? "'" + vehicleViewModel.OwnerId + "'" : "null") + ", \n" 
                    + "    NucleoId: " + (vehicleViewModel.NucleoId != null ? "'" + vehicleViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    VehicleTypeId: " +  "'" + vehicleViewModel.VehicleTypeId + "'"  + ", \n" 
                    + "    EnergySourceId: " +  "'" + vehicleViewModel.EnergySourceId + "'"  + ", \n" 
                    + "    AverageSpeed: " + (vehicleViewModel.AverageSpeed != null ? "'" + vehicleViewModel.AverageSpeed + "'" : "null") + ", \n" 
                    + "    HorsePower: " + (vehicleViewModel.HorsePower != null ? "'" + vehicleViewModel.HorsePower + "'" : "null") + ", \n" 
                    + "    FuelConsumption: " + (vehicleViewModel.FuelConsumption != null ? "'" + vehicleViewModel.FuelConsumption + "'" : "null") + ", \n" 
                    + "    FuelAutonomyDistance: " + (vehicleViewModel.FuelAutonomyDistance != null ? "'" + vehicleViewModel.FuelAutonomyDistance + "'" : "null") + ", \n" 
                    + "    RechargeTime: " + (vehicleViewModel.RechargeTime != null ? "'" + vehicleViewModel.RechargeTime + "'" : "null") + ", \n" 
                    + "    LicensePlate: " + (vehicleViewModel.LicensePlate != null ? "'" + vehicleViewModel.LicensePlate + "'" : "null") + ", \n" 
                    + "    Color: " + (vehicleViewModel.Color != null ? "'" + vehicleViewModel.Color + "'" : "null") + ", \n" 
                    + "    NumberSeats: " + (vehicleViewModel.NumberSeats != null ? "'" + vehicleViewModel.NumberSeats + "'" : "null") + ", \n" 
                    + "    CargoVolumeCapacity: " + (vehicleViewModel.CargoVolumeCapacity != null ? "'" + vehicleViewModel.CargoVolumeCapacity + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + vehicleViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + vehicleViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (vehicleViewModel.CreateBy != null ? "'" + vehicleViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (vehicleViewModel.CreateOn != null ? "'" + vehicleViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (vehicleViewModel.UpdateBy != null ? "'" + vehicleViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (vehicleViewModel.UpdateOn != null ? "'" + vehicleViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    