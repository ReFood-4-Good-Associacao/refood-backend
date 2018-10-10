
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ParishDTO
    {
        public int ParishId { get; set; }
        public int? CountyId { get; set; }
        public int? DistrictId { get; set; }
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

        public ParishDTO()
        {
        
        }

        public ParishDTO(R_Parish parish)
        {
            ParishId = parish.ParishId;
            CountyId = parish.CountyId;
            DistrictId = parish.DistrictId;
            CountryId = parish.CountryId;
            Name = parish.Name;
            Code = parish.Code;
            Latitude = parish.Latitude;
            Longitude = parish.Longitude;
            Active = parish.Active;
            IsDeleted = parish.IsDeleted;
            CreateBy = parish.CreateBy;
            CreateOn = parish.CreateOn;
            UpdateBy = parish.UpdateBy;
            UpdateOn = parish.UpdateOn;
        }

        public static R_Parish ConvertDTOtoEntity(ParishDTO dto)
        {
            R_Parish parish = new R_Parish();

            parish.ParishId = dto.ParishId;
            parish.CountyId = dto.CountyId;
            parish.DistrictId = dto.DistrictId;
            parish.CountryId = dto.CountryId;
            parish.Name = dto.Name;
            parish.Code = dto.Code;
            parish.Latitude = dto.Latitude;
            parish.Longitude = dto.Longitude;
            parish.Active = dto.Active;
            parish.IsDeleted = dto.IsDeleted;
            parish.CreateBy = dto.CreateBy;
            parish.CreateOn = dto.CreateOn;
            parish.UpdateBy = dto.UpdateBy;
            parish.UpdateOn = dto.UpdateOn;

            return parish;
        }

        // logging helper
        public static string FormatParishDTO(ParishDTO parishDTO)
        {
            if(parishDTO == null)
            {
                // null
                return "parishDTO: null";
            }
            else
            {
                // output values
                return "parishDTO: \n"
                    + "{ \n"
 
                    + "    ParishId: " +  "'" + parishDTO.ParishId + "'"  + ", \n" 
                    + "    CountyId: " + (parishDTO.CountyId != null ? "'" + parishDTO.CountyId + "'" : "null") + ", \n" 
                    + "    DistrictId: " + (parishDTO.DistrictId != null ? "'" + parishDTO.DistrictId + "'" : "null") + ", \n" 
                    + "    CountryId: " + (parishDTO.CountryId != null ? "'" + parishDTO.CountryId + "'" : "null") + ", \n" 
                    + "    Name: " + (parishDTO.Name != null ? "'" + parishDTO.Name + "'" : "null") + ", \n" 
                    + "    Code: " + (parishDTO.Code != null ? "'" + parishDTO.Code + "'" : "null") + ", \n" 
                    + "    Latitude: " + (parishDTO.Latitude != null ? "'" + parishDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (parishDTO.Longitude != null ? "'" + parishDTO.Longitude + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + parishDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + parishDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (parishDTO.CreateBy != null ? "'" + parishDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (parishDTO.CreateOn != null ? "'" + parishDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (parishDTO.UpdateBy != null ? "'" + parishDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (parishDTO.UpdateOn != null ? "'" + parishDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    