
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
    public partial class VehicleTypeViewModel
    {
        public VehicleTypeViewModel() { }

        public VehicleTypeViewModel(VehicleTypeDTO t)
        {
            VehicleTypeId = t.VehicleTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public VehicleTypeViewModel(VehicleTypeDTO t, string editUrl)
        {
            VehicleTypeId = t.VehicleTypeId;
            Name = t.Name;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public VehicleTypeDTO UpdateDTO(VehicleTypeDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.VehicleTypeId = this.VehicleTypeId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("vehicleTypeId")]
        public int VehicleTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

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
        public static string FormatVehicleTypeViewModel(VehicleTypeViewModel vehicleTypeViewModel)
        {
            if (vehicleTypeViewModel == null)
            {
                // null
                return "vehicleTypeViewModel: null";
            }
            else
            {
                // output values
                return "vehicleTypeViewModel: \n"
                    + "{ \n"
 
                    + "    VehicleTypeId: " +  "'" + vehicleTypeViewModel.VehicleTypeId + "'"  + ", \n" 
                    + "    Name: " + (vehicleTypeViewModel.Name != null ? "'" + vehicleTypeViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (vehicleTypeViewModel.Description != null ? "'" + vehicleTypeViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + vehicleTypeViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + vehicleTypeViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (vehicleTypeViewModel.CreateBy != null ? "'" + vehicleTypeViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (vehicleTypeViewModel.CreateOn != null ? "'" + vehicleTypeViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (vehicleTypeViewModel.UpdateBy != null ? "'" + vehicleTypeViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (vehicleTypeViewModel.UpdateOn != null ? "'" + vehicleTypeViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    