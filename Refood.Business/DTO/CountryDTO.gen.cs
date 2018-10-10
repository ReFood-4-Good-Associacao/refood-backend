
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class CountryDTO
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string IsoCode { get; set; }
        public string CapitalCity { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? PhonePrefix { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public CountryDTO()
        {
        
        }

        public CountryDTO(R_Country country)
        {
            CountryId = country.CountryId;
            Name = country.Name;
            EnglishName = country.EnglishName;
            IsoCode = country.IsoCode;
            CapitalCity = country.CapitalCity;
            Latitude = country.Latitude;
            Longitude = country.Longitude;
            PhonePrefix = country.PhonePrefix;
            Active = country.Active;
            IsDeleted = country.IsDeleted;
            CreateBy = country.CreateBy;
            CreateOn = country.CreateOn;
            UpdateBy = country.UpdateBy;
            UpdateOn = country.UpdateOn;
        }

        public static R_Country ConvertDTOtoEntity(CountryDTO dto)
        {
            R_Country country = new R_Country();

            country.CountryId = dto.CountryId;
            country.Name = dto.Name;
            country.EnglishName = dto.EnglishName;
            country.IsoCode = dto.IsoCode;
            country.CapitalCity = dto.CapitalCity;
            country.Latitude = dto.Latitude;
            country.Longitude = dto.Longitude;
            country.PhonePrefix = dto.PhonePrefix;
            country.Active = dto.Active;
            country.IsDeleted = dto.IsDeleted;
            country.CreateBy = dto.CreateBy;
            country.CreateOn = dto.CreateOn;
            country.UpdateBy = dto.UpdateBy;
            country.UpdateOn = dto.UpdateOn;

            return country;
        }

        // logging helper
        public static string FormatCountryDTO(CountryDTO countryDTO)
        {
            if(countryDTO == null)
            {
                // null
                return "countryDTO: null";
            }
            else
            {
                // output values
                return "countryDTO: \n"
                    + "{ \n"
 
                    + "    CountryId: " +  "'" + countryDTO.CountryId + "'"  + ", \n" 
                    + "    Name: " + (countryDTO.Name != null ? "'" + countryDTO.Name + "'" : "null") + ", \n" 
                    + "    EnglishName: " + (countryDTO.EnglishName != null ? "'" + countryDTO.EnglishName + "'" : "null") + ", \n" 
                    + "    IsoCode: " + (countryDTO.IsoCode != null ? "'" + countryDTO.IsoCode + "'" : "null") + ", \n" 
                    + "    CapitalCity: " + (countryDTO.CapitalCity != null ? "'" + countryDTO.CapitalCity + "'" : "null") + ", \n" 
                    + "    Latitude: " + (countryDTO.Latitude != null ? "'" + countryDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (countryDTO.Longitude != null ? "'" + countryDTO.Longitude + "'" : "null") + ", \n" 
                    + "    PhonePrefix: " + (countryDTO.PhonePrefix != null ? "'" + countryDTO.PhonePrefix + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + countryDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + countryDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (countryDTO.CreateBy != null ? "'" + countryDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (countryDTO.CreateOn != null ? "'" + countryDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (countryDTO.UpdateBy != null ? "'" + countryDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (countryDTO.UpdateOn != null ? "'" + countryDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    