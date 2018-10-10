
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
    public partial class DistrictViewModel
    {
        public DistrictViewModel() { }

        public DistrictViewModel(DistrictDTO t)
        {
            DistrictId = t.DistrictId;
            CountryId = t.CountryId;
            Name = t.Name;
            Code = t.Code;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public DistrictViewModel(DistrictDTO t, string editUrl)
        {
            DistrictId = t.DistrictId;
            CountryId = t.CountryId;
            Name = t.Name;
            Code = t.Code;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public DistrictDTO UpdateDTO(DistrictDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.DistrictId = this.DistrictId;
                dto.CountryId = this.CountryId;
                dto.Name = this.Name;
                dto.Code = this.Code;
                dto.Latitude = this.Latitude;
                dto.Longitude = this.Longitude;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("districtId")]
        public int DistrictId { get; set; }

        [JsonProperty("countryId")]
        public int? CountryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

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
        public static string FormatDistrictViewModel(DistrictViewModel districtViewModel)
        {
            if (districtViewModel == null)
            {
                // null
                return "districtViewModel: null";
            }
            else
            {
                // output values
                return "districtViewModel: \n"
                    + "{ \n"
 
                    + "    DistrictId: " +  "'" + districtViewModel.DistrictId + "'"  + ", \n" 
                    + "    CountryId: " + (districtViewModel.CountryId != null ? "'" + districtViewModel.CountryId + "'" : "null") + ", \n" 
                    + "    Name: " + (districtViewModel.Name != null ? "'" + districtViewModel.Name + "'" : "null") + ", \n" 
                    + "    Code: " + (districtViewModel.Code != null ? "'" + districtViewModel.Code + "'" : "null") + ", \n" 
                    + "    Latitude: " + (districtViewModel.Latitude != null ? "'" + districtViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (districtViewModel.Longitude != null ? "'" + districtViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + districtViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + districtViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (districtViewModel.CreateBy != null ? "'" + districtViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (districtViewModel.CreateOn != null ? "'" + districtViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (districtViewModel.UpdateBy != null ? "'" + districtViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (districtViewModel.UpdateOn != null ? "'" + districtViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    