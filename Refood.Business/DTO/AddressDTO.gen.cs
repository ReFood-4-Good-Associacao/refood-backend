
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class AddressDTO
    {
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string AddressFirstLine { get; set; }
        public string AddressSecondLine { get; set; }
        public int? CountryId { get; set; }
        public int? DistrictId { get; set; }
        public int? CountyId { get; set; }
        public int? ParishId { get; set; }
        public string ZipCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public AddressDTO()
        {
        
        }

        public AddressDTO(R_Address address)
        {
            AddressId = address.AddressId;
            Name = address.Name;
            AddressFirstLine = address.AddressFirstLine;
            AddressSecondLine = address.AddressSecondLine;
            CountryId = address.CountryId;
            DistrictId = address.DistrictId;
            CountyId = address.CountyId;
            ParishId = address.ParishId;
            ZipCode = address.ZipCode;
            Latitude = address.Latitude;
            Longitude = address.Longitude;
            Active = address.Active;
            IsDeleted = address.IsDeleted;
            CreateBy = address.CreateBy;
            CreateOn = address.CreateOn;
            UpdateBy = address.UpdateBy;
            UpdateOn = address.UpdateOn;
        }

        public static R_Address ConvertDTOtoEntity(AddressDTO dto)
        {
            R_Address address = new R_Address();

            address.AddressId = dto.AddressId;
            address.Name = dto.Name;
            address.AddressFirstLine = dto.AddressFirstLine;
            address.AddressSecondLine = dto.AddressSecondLine;
            address.CountryId = dto.CountryId;
            address.DistrictId = dto.DistrictId;
            address.CountyId = dto.CountyId;
            address.ParishId = dto.ParishId;
            address.ZipCode = dto.ZipCode;
            address.Latitude = dto.Latitude;
            address.Longitude = dto.Longitude;
            address.Active = dto.Active;
            address.IsDeleted = dto.IsDeleted;
            address.CreateBy = dto.CreateBy;
            address.CreateOn = dto.CreateOn;
            address.UpdateBy = dto.UpdateBy;
            address.UpdateOn = dto.UpdateOn;

            return address;
        }

        // logging helper
        public static string FormatAddressDTO(AddressDTO addressDTO)
        {
            if(addressDTO == null)
            {
                // null
                return "addressDTO: null";
            }
            else
            {
                // output values
                return "addressDTO: \n"
                    + "{ \n"
 
                    + "    AddressId: " +  "'" + addressDTO.AddressId + "'"  + ", \n" 
                    + "    Name: " + (addressDTO.Name != null ? "'" + addressDTO.Name + "'" : "null") + ", \n" 
                    + "    AddressFirstLine: " + (addressDTO.AddressFirstLine != null ? "'" + addressDTO.AddressFirstLine + "'" : "null") + ", \n" 
                    + "    AddressSecondLine: " + (addressDTO.AddressSecondLine != null ? "'" + addressDTO.AddressSecondLine + "'" : "null") + ", \n" 
                    + "    CountryId: " + (addressDTO.CountryId != null ? "'" + addressDTO.CountryId + "'" : "null") + ", \n" 
                    + "    DistrictId: " + (addressDTO.DistrictId != null ? "'" + addressDTO.DistrictId + "'" : "null") + ", \n" 
                    + "    CountyId: " + (addressDTO.CountyId != null ? "'" + addressDTO.CountyId + "'" : "null") + ", \n" 
                    + "    ParishId: " + (addressDTO.ParishId != null ? "'" + addressDTO.ParishId + "'" : "null") + ", \n" 
                    + "    ZipCode: " + (addressDTO.ZipCode != null ? "'" + addressDTO.ZipCode + "'" : "null") + ", \n" 
                    + "    Latitude: " + (addressDTO.Latitude != null ? "'" + addressDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (addressDTO.Longitude != null ? "'" + addressDTO.Longitude + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + addressDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + addressDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (addressDTO.CreateBy != null ? "'" + addressDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (addressDTO.CreateOn != null ? "'" + addressDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (addressDTO.UpdateBy != null ? "'" + addressDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (addressDTO.UpdateOn != null ? "'" + addressDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    