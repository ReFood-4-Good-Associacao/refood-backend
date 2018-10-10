
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class RefoodUserDTO
    {
        public int RefoodUserId { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public RefoodUserDTO()
        {
        
        }

        public RefoodUserDTO(R_RefoodUser refoodUser)
        {
            RefoodUserId = refoodUser.RefoodUserId;
            Username = refoodUser.Username;
            Fullname = refoodUser.Fullname;
            Email = refoodUser.Email;
            Active = refoodUser.Active;
            IsDeleted = refoodUser.IsDeleted;
            CreateBy = refoodUser.CreateBy;
            CreateOn = refoodUser.CreateOn;
            UpdateBy = refoodUser.UpdateBy;
            UpdateOn = refoodUser.UpdateOn;
        }

        public static R_RefoodUser ConvertDTOtoEntity(RefoodUserDTO dto)
        {
            R_RefoodUser refoodUser = new R_RefoodUser();

            refoodUser.RefoodUserId = dto.RefoodUserId;
            refoodUser.Username = dto.Username;
            refoodUser.Fullname = dto.Fullname;
            refoodUser.Email = dto.Email;
            refoodUser.Active = dto.Active;
            refoodUser.IsDeleted = dto.IsDeleted;
            refoodUser.CreateBy = dto.CreateBy;
            refoodUser.CreateOn = dto.CreateOn;
            refoodUser.UpdateBy = dto.UpdateBy;
            refoodUser.UpdateOn = dto.UpdateOn;

            return refoodUser;
        }

        // logging helper
        public static string FormatRefoodUserDTO(RefoodUserDTO refoodUserDTO)
        {
            if(refoodUserDTO == null)
            {
                // null
                return "refoodUserDTO: null";
            }
            else
            {
                // output values
                return "refoodUserDTO: \n"
                    + "{ \n"
 
                    + "    RefoodUserId: " +  "'" + refoodUserDTO.RefoodUserId + "'"  + ", \n" 
                    + "    Username: " + (refoodUserDTO.Username != null ? "'" + refoodUserDTO.Username + "'" : "null") + ", \n" 
                    + "    Fullname: " + (refoodUserDTO.Fullname != null ? "'" + refoodUserDTO.Fullname + "'" : "null") + ", \n" 
                    + "    Email: " + (refoodUserDTO.Email != null ? "'" + refoodUserDTO.Email + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + refoodUserDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + refoodUserDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (refoodUserDTO.CreateBy != null ? "'" + refoodUserDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (refoodUserDTO.CreateOn != null ? "'" + refoodUserDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (refoodUserDTO.UpdateBy != null ? "'" + refoodUserDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (refoodUserDTO.UpdateOn != null ? "'" + refoodUserDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    