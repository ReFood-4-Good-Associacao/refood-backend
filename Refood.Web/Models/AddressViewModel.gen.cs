
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
    public partial class AddressViewModel
    {
        public AddressViewModel() { }

        public AddressViewModel(AddressDTO t)
        {
            AddressId = t.AddressId;
            Name = t.Name;
            AddressFirstLine = t.AddressFirstLine;
            AddressSecondLine = t.AddressSecondLine;
            CountryId = t.CountryId;
            DistrictId = t.DistrictId;
            CountyId = t.CountyId;
            ParishId = t.ParishId;
            ZipCode = t.ZipCode;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public AddressViewModel(AddressDTO t, string editUrl)
        {
            AddressId = t.AddressId;
            Name = t.Name;
            AddressFirstLine = t.AddressFirstLine;
            AddressSecondLine = t.AddressSecondLine;
            CountryId = t.CountryId;
            DistrictId = t.DistrictId;
            CountyId = t.CountyId;
            ParishId = t.ParishId;
            ZipCode = t.ZipCode;
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

        public AddressDTO UpdateDTO(AddressDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.AddressId = this.AddressId;
                dto.Name = this.Name;
                dto.AddressFirstLine = this.AddressFirstLine;
                dto.AddressSecondLine = this.AddressSecondLine;
                dto.CountryId = this.CountryId;
                dto.DistrictId = this.DistrictId;
                dto.CountyId = this.CountyId;
                dto.ParishId = this.ParishId;
                dto.ZipCode = this.ZipCode;
                dto.Latitude = this.Latitude;
                dto.Longitude = this.Longitude;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("addressId")]
        public int AddressId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addressFirstLine")]
        public string AddressFirstLine { get; set; }

        [JsonProperty("addressSecondLine")]
        public string AddressSecondLine { get; set; }

        [JsonProperty("countryId")]
        public int? CountryId { get; set; }

        [JsonProperty("districtId")]
        public int? DistrictId { get; set; }

        [JsonProperty("countyId")]
        public int? CountyId { get; set; }

        [JsonProperty("parishId")]
        public int? ParishId { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

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
        public static string FormatAddressViewModel(AddressViewModel addressViewModel)
        {
            if (addressViewModel == null)
            {
                // null
                return "addressViewModel: null";
            }
            else
            {
                // output values
                return "addressViewModel: \n"
                    + "{ \n"
 
                    + "    AddressId: " +  "'" + addressViewModel.AddressId + "'"  + ", \n" 
                    + "    Name: " + (addressViewModel.Name != null ? "'" + addressViewModel.Name + "'" : "null") + ", \n" 
                    + "    AddressFirstLine: " + (addressViewModel.AddressFirstLine != null ? "'" + addressViewModel.AddressFirstLine + "'" : "null") + ", \n" 
                    + "    AddressSecondLine: " + (addressViewModel.AddressSecondLine != null ? "'" + addressViewModel.AddressSecondLine + "'" : "null") + ", \n" 
                    + "    CountryId: " + (addressViewModel.CountryId != null ? "'" + addressViewModel.CountryId + "'" : "null") + ", \n" 
                    + "    DistrictId: " + (addressViewModel.DistrictId != null ? "'" + addressViewModel.DistrictId + "'" : "null") + ", \n" 
                    + "    CountyId: " + (addressViewModel.CountyId != null ? "'" + addressViewModel.CountyId + "'" : "null") + ", \n" 
                    + "    ParishId: " + (addressViewModel.ParishId != null ? "'" + addressViewModel.ParishId + "'" : "null") + ", \n" 
                    + "    ZipCode: " + (addressViewModel.ZipCode != null ? "'" + addressViewModel.ZipCode + "'" : "null") + ", \n" 
                    + "    Latitude: " + (addressViewModel.Latitude != null ? "'" + addressViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (addressViewModel.Longitude != null ? "'" + addressViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + addressViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + addressViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (addressViewModel.CreateBy != null ? "'" + addressViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (addressViewModel.CreateOn != null ? "'" + addressViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (addressViewModel.UpdateBy != null ? "'" + addressViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (addressViewModel.UpdateOn != null ? "'" + addressViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    