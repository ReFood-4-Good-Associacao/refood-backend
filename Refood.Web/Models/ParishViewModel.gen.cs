
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
    public partial class ParishViewModel
    {
        public ParishViewModel() { }

        public ParishViewModel(ParishDTO t)
        {
            ParishId = t.ParishId;
            CountyId = t.CountyId;
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

        public ParishViewModel(ParishDTO t, string editUrl)
        {
            ParishId = t.ParishId;
            CountyId = t.CountyId;
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

        public ParishDTO UpdateDTO(ParishDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ParishId = this.ParishId;
                dto.CountyId = this.CountyId;
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

        [JsonProperty("parishId")]
        public int ParishId { get; set; }

        [JsonProperty("countyId")]
        public int? CountyId { get; set; }

        [JsonProperty("districtId")]
        public int? DistrictId { get; set; }

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
        public static string FormatParishViewModel(ParishViewModel parishViewModel)
        {
            if (parishViewModel == null)
            {
                // null
                return "parishViewModel: null";
            }
            else
            {
                // output values
                return "parishViewModel: \n"
                    + "{ \n"
 
                    + "    ParishId: " +  "'" + parishViewModel.ParishId + "'"  + ", \n" 
                    + "    CountyId: " + (parishViewModel.CountyId != null ? "'" + parishViewModel.CountyId + "'" : "null") + ", \n" 
                    + "    DistrictId: " + (parishViewModel.DistrictId != null ? "'" + parishViewModel.DistrictId + "'" : "null") + ", \n" 
                    + "    CountryId: " + (parishViewModel.CountryId != null ? "'" + parishViewModel.CountryId + "'" : "null") + ", \n" 
                    + "    Name: " + (parishViewModel.Name != null ? "'" + parishViewModel.Name + "'" : "null") + ", \n" 
                    + "    Code: " + (parishViewModel.Code != null ? "'" + parishViewModel.Code + "'" : "null") + ", \n" 
                    + "    Latitude: " + (parishViewModel.Latitude != null ? "'" + parishViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (parishViewModel.Longitude != null ? "'" + parishViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + parishViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + parishViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (parishViewModel.CreateBy != null ? "'" + parishViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (parishViewModel.CreateOn != null ? "'" + parishViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (parishViewModel.UpdateBy != null ? "'" + parishViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (parishViewModel.UpdateOn != null ? "'" + parishViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    