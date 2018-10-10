
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class NucleoDTO
    {
        public int NucleoId { get; set; }
        public string Name { get; set; }
        public string PersonResponsible { get; set; }
        public int? Photo { get; set; }
        public int? AddressId { get; set; }
        public System.DateTime? OpeningDate { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string PrimaryEmail { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public NucleoDTO()
        {
        
        }

        public NucleoDTO(R_Nucleo nucleo)
        {
            NucleoId = nucleo.NucleoId;
            Name = nucleo.Name;
            PersonResponsible = nucleo.PersonResponsible;
            Photo = nucleo.Photo;
            AddressId = nucleo.AddressId;
            OpeningDate = nucleo.OpeningDate;
            PrimaryPhoneNumber = nucleo.PrimaryPhoneNumber;
            PrimaryEmail = nucleo.PrimaryEmail;
            Active = nucleo.Active;
            IsDeleted = nucleo.IsDeleted;
            CreateBy = nucleo.CreateBy;
            CreateOn = nucleo.CreateOn;
            UpdateBy = nucleo.UpdateBy;
            UpdateOn = nucleo.UpdateOn;
        }

        public static R_Nucleo ConvertDTOtoEntity(NucleoDTO dto)
        {
            R_Nucleo nucleo = new R_Nucleo();

            nucleo.NucleoId = dto.NucleoId;
            nucleo.Name = dto.Name;
            nucleo.PersonResponsible = dto.PersonResponsible;
            nucleo.Photo = dto.Photo;
            nucleo.AddressId = dto.AddressId;
            nucleo.OpeningDate = dto.OpeningDate;
            nucleo.PrimaryPhoneNumber = dto.PrimaryPhoneNumber;
            nucleo.PrimaryEmail = dto.PrimaryEmail;
            nucleo.Active = dto.Active;
            nucleo.IsDeleted = dto.IsDeleted;
            nucleo.CreateBy = dto.CreateBy;
            nucleo.CreateOn = dto.CreateOn;
            nucleo.UpdateBy = dto.UpdateBy;
            nucleo.UpdateOn = dto.UpdateOn;

            return nucleo;
        }

        // logging helper
        public static string FormatNucleoDTO(NucleoDTO nucleoDTO)
        {
            if(nucleoDTO == null)
            {
                // null
                return "nucleoDTO: null";
            }
            else
            {
                // output values
                return "nucleoDTO: \n"
                    + "{ \n"
 
                    + "    NucleoId: " +  "'" + nucleoDTO.NucleoId + "'"  + ", \n" 
                    + "    Name: " + (nucleoDTO.Name != null ? "'" + nucleoDTO.Name + "'" : "null") + ", \n" 
                    + "    PersonResponsible: " + (nucleoDTO.PersonResponsible != null ? "'" + nucleoDTO.PersonResponsible + "'" : "null") + ", \n" 
                    + "    Photo: " + (nucleoDTO.Photo != null ? "'" + nucleoDTO.Photo + "'" : "null") + ", \n" 
                    + "    AddressId: " + (nucleoDTO.AddressId != null ? "'" + nucleoDTO.AddressId + "'" : "null") + ", \n" 
                    + "    OpeningDate: " + (nucleoDTO.OpeningDate != null ? "'" + nucleoDTO.OpeningDate + "'" : "null") + ", \n" 
                    + "    PrimaryPhoneNumber: " + (nucleoDTO.PrimaryPhoneNumber != null ? "'" + nucleoDTO.PrimaryPhoneNumber + "'" : "null") + ", \n" 
                    + "    PrimaryEmail: " + (nucleoDTO.PrimaryEmail != null ? "'" + nucleoDTO.PrimaryEmail + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + nucleoDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + nucleoDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (nucleoDTO.CreateBy != null ? "'" + nucleoDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (nucleoDTO.CreateOn != null ? "'" + nucleoDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (nucleoDTO.UpdateBy != null ? "'" + nucleoDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (nucleoDTO.UpdateOn != null ? "'" + nucleoDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    