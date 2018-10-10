
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class DistrictDTO
    {
        public int DistrictId { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public DistrictDTO()
        {
        
        }

        public DistrictDTO(R_District district)
        {
            DistrictId = district.DistrictId;
            CountryId = district.CountryId;
            Name = district.Name;
            Code = district.Code;
            Latitude = district.Latitude;
            Longitude = district.Longitude;
            Active = district.Active;
            IsDeleted = district.IsDeleted;
            CreateBy = district.CreateBy;
            CreateOn = district.CreateOn;
            UpdateBy = district.UpdateBy;
            UpdateOn = district.UpdateOn;
        }

        public static R_District ConvertDTOtoEntity(DistrictDTO dto)
        {
            R_District district = new R_District();

            district.DistrictId = dto.DistrictId;
            district.CountryId = dto.CountryId;
            district.Name = dto.Name;
            district.Code = dto.Code;
            district.Latitude = dto.Latitude;
            district.Longitude = dto.Longitude;
            district.Active = dto.Active;
            district.IsDeleted = dto.IsDeleted;
            district.CreateBy = dto.CreateBy;
            district.CreateOn = dto.CreateOn;
            district.UpdateBy = dto.UpdateBy;
            district.UpdateOn = dto.UpdateOn;

            return district;
        }

        // logging helper
        public static string FormatDistrictDTO(DistrictDTO districtDTO)
        {
            if(districtDTO == null)
            {
                // null
                return "districtDTO: null";
            }
            else
            {
                // output values
                return "districtDTO: \n"
                    + "{ \n"
 
                    + "    DistrictId: " +  "'" + districtDTO.DistrictId + "'"  + ", \n" 
                    + "    CountryId: " + (districtDTO.CountryId != null ? "'" + districtDTO.CountryId + "'" : "null") + ", \n" 
                    + "    Name: " + (districtDTO.Name != null ? "'" + districtDTO.Name + "'" : "null") + ", \n" 
                    + "    Code: " + (districtDTO.Code != null ? "'" + districtDTO.Code + "'" : "null") + ", \n" 
                    + "    Latitude: " + (districtDTO.Latitude != null ? "'" + districtDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (districtDTO.Longitude != null ? "'" + districtDTO.Longitude + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + districtDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + districtDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (districtDTO.CreateBy != null ? "'" + districtDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (districtDTO.CreateOn != null ? "'" + districtDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (districtDTO.UpdateBy != null ? "'" + districtDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (districtDTO.UpdateOn != null ? "'" + districtDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    