
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
    public partial class CountryViewModel
    {
        public CountryViewModel() { }

        public CountryViewModel(CountryDTO t)
        {
            CountryId = t.CountryId;
            Name = t.Name;
            EnglishName = t.EnglishName;
            IsoCode = t.IsoCode;
            CapitalCity = t.CapitalCity;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            PhonePrefix = t.PhonePrefix;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public CountryViewModel(CountryDTO t, string editUrl)
        {
            CountryId = t.CountryId;
            Name = t.Name;
            EnglishName = t.EnglishName;
            IsoCode = t.IsoCode;
            CapitalCity = t.CapitalCity;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            PhonePrefix = t.PhonePrefix;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public CountryDTO UpdateDTO(CountryDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.CountryId = this.CountryId;
                dto.Name = this.Name;
                dto.EnglishName = this.EnglishName;
                dto.IsoCode = this.IsoCode;
                dto.CapitalCity = this.CapitalCity;
                dto.Latitude = this.Latitude;
                dto.Longitude = this.Longitude;
                dto.PhonePrefix = this.PhonePrefix;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("countryId")]
        public int CountryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }

        [JsonProperty("capitalCity")]
        public string CapitalCity { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("phonePrefix")]
        public double? PhonePrefix { get; set; }

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
        public static string FormatCountryViewModel(CountryViewModel countryViewModel)
        {
            if (countryViewModel == null)
            {
                // null
                return "countryViewModel: null";
            }
            else
            {
                // output values
                return "countryViewModel: \n"
                    + "{ \n"
 
                    + "    CountryId: " +  "'" + countryViewModel.CountryId + "'"  + ", \n" 
                    + "    Name: " + (countryViewModel.Name != null ? "'" + countryViewModel.Name + "'" : "null") + ", \n" 
                    + "    EnglishName: " + (countryViewModel.EnglishName != null ? "'" + countryViewModel.EnglishName + "'" : "null") + ", \n" 
                    + "    IsoCode: " + (countryViewModel.IsoCode != null ? "'" + countryViewModel.IsoCode + "'" : "null") + ", \n" 
                    + "    CapitalCity: " + (countryViewModel.CapitalCity != null ? "'" + countryViewModel.CapitalCity + "'" : "null") + ", \n" 
                    + "    Latitude: " + (countryViewModel.Latitude != null ? "'" + countryViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (countryViewModel.Longitude != null ? "'" + countryViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    PhonePrefix: " + (countryViewModel.PhonePrefix != null ? "'" + countryViewModel.PhonePrefix + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + countryViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + countryViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (countryViewModel.CreateBy != null ? "'" + countryViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (countryViewModel.CreateOn != null ? "'" + countryViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (countryViewModel.UpdateBy != null ? "'" + countryViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (countryViewModel.UpdateOn != null ? "'" + countryViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    