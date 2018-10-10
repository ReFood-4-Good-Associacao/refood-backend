
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
    public partial class RefoodUserViewModel
    {
        public RefoodUserViewModel() { }

        public RefoodUserViewModel(RefoodUserDTO t)
        {
            RefoodUserId = t.RefoodUserId;
            Username = t.Username;
            Fullname = t.Fullname;
            Email = t.Email;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public RefoodUserViewModel(RefoodUserDTO t, string editUrl)
        {
            RefoodUserId = t.RefoodUserId;
            Username = t.Username;
            Fullname = t.Fullname;
            Email = t.Email;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public RefoodUserDTO UpdateDTO(RefoodUserDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.RefoodUserId = this.RefoodUserId;
                dto.Username = this.Username;
                dto.Fullname = this.Fullname;
                dto.Email = this.Email;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("refoodUserId")]
        public int RefoodUserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

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
        public static string FormatRefoodUserViewModel(RefoodUserViewModel refoodUserViewModel)
        {
            if (refoodUserViewModel == null)
            {
                // null
                return "refoodUserViewModel: null";
            }
            else
            {
                // output values
                return "refoodUserViewModel: \n"
                    + "{ \n"
 
                    + "    RefoodUserId: " +  "'" + refoodUserViewModel.RefoodUserId + "'"  + ", \n" 
                    + "    Username: " + (refoodUserViewModel.Username != null ? "'" + refoodUserViewModel.Username + "'" : "null") + ", \n" 
                    + "    Fullname: " + (refoodUserViewModel.Fullname != null ? "'" + refoodUserViewModel.Fullname + "'" : "null") + ", \n" 
                    + "    Email: " + (refoodUserViewModel.Email != null ? "'" + refoodUserViewModel.Email + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + refoodUserViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + refoodUserViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (refoodUserViewModel.CreateBy != null ? "'" + refoodUserViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (refoodUserViewModel.CreateOn != null ? "'" + refoodUserViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (refoodUserViewModel.UpdateBy != null ? "'" + refoodUserViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (refoodUserViewModel.UpdateOn != null ? "'" + refoodUserViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    