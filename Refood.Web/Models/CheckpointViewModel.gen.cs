
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
    public partial class CheckpointViewModel
    {
        public CheckpointViewModel() { }

        public CheckpointViewModel(CheckpointDTO t)
        {
            CheckpointId = t.CheckpointId;
            Name = t.Name;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            AddressId = t.AddressId;
            EstimatedTimeArrival = t.EstimatedTimeArrival;
            MinimumTime = t.MinimumTime;
            MaximumTime = t.MaximumTime;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public CheckpointViewModel(CheckpointDTO t, string editUrl)
        {
            CheckpointId = t.CheckpointId;
            Name = t.Name;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            AddressId = t.AddressId;
            EstimatedTimeArrival = t.EstimatedTimeArrival;
            MinimumTime = t.MinimumTime;
            MaximumTime = t.MaximumTime;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public CheckpointDTO UpdateDTO(CheckpointDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.CheckpointId = this.CheckpointId;
                dto.Name = this.Name;
                dto.Latitude = this.Latitude;
                dto.Longitude = this.Longitude;
                dto.AddressId = this.AddressId;
                dto.EstimatedTimeArrival = this.EstimatedTimeArrival;
                dto.MinimumTime = this.MinimumTime;
                dto.MaximumTime = this.MaximumTime;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("checkpointId")]
        public int CheckpointId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("addressId")]
        public int? AddressId { get; set; }

        [JsonProperty("estimatedTimeArrival")]
        public int EstimatedTimeArrival { get; set; }

        [JsonProperty("minimumTime")]
        public System.DateTime? MinimumTime { get; set; }

        [JsonProperty("maximumTime")]
        public System.DateTime? MaximumTime { get; set; }

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
        public static string FormatCheckpointViewModel(CheckpointViewModel checkpointViewModel)
        {
            if (checkpointViewModel == null)
            {
                // null
                return "checkpointViewModel: null";
            }
            else
            {
                // output values
                return "checkpointViewModel: \n"
                    + "{ \n"
 
                    + "    CheckpointId: " +  "'" + checkpointViewModel.CheckpointId + "'"  + ", \n" 
                    + "    Name: " + (checkpointViewModel.Name != null ? "'" + checkpointViewModel.Name + "'" : "null") + ", \n" 
                    + "    Latitude: " + (checkpointViewModel.Latitude != null ? "'" + checkpointViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (checkpointViewModel.Longitude != null ? "'" + checkpointViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    AddressId: " + (checkpointViewModel.AddressId != null ? "'" + checkpointViewModel.AddressId + "'" : "null") + ", \n" 
                    + "    EstimatedTimeArrival: " +  "'" + checkpointViewModel.EstimatedTimeArrival + "'"  + ", \n" 
                    + "    MinimumTime: " + (checkpointViewModel.MinimumTime != null ? "'" + checkpointViewModel.MinimumTime + "'" : "null") + ", \n" 
                    + "    MaximumTime: " + (checkpointViewModel.MaximumTime != null ? "'" + checkpointViewModel.MaximumTime + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + checkpointViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + checkpointViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (checkpointViewModel.CreateBy != null ? "'" + checkpointViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (checkpointViewModel.CreateOn != null ? "'" + checkpointViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (checkpointViewModel.UpdateBy != null ? "'" + checkpointViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (checkpointViewModel.UpdateOn != null ? "'" + checkpointViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    