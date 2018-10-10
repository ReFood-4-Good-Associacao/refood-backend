
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
    public partial class NucleoViewModel
    {
        public NucleoViewModel() { }

        public NucleoViewModel(NucleoDTO t)
        {
            NucleoId = t.NucleoId;
            Name = t.Name;
            PersonResponsible = t.PersonResponsible;
            Photo = t.Photo;
            AddressId = t.AddressId;
            OpeningDate = t.OpeningDate;
            PrimaryPhoneNumber = t.PrimaryPhoneNumber;
            PrimaryEmail = t.PrimaryEmail;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public NucleoViewModel(NucleoDTO t, string editUrl)
        {
            NucleoId = t.NucleoId;
            Name = t.Name;
            PersonResponsible = t.PersonResponsible;
            Photo = t.Photo;
            AddressId = t.AddressId;
            OpeningDate = t.OpeningDate;
            PrimaryPhoneNumber = t.PrimaryPhoneNumber;
            PrimaryEmail = t.PrimaryEmail;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public NucleoDTO UpdateDTO(NucleoDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.PersonResponsible = this.PersonResponsible;
                dto.Photo = this.Photo;
                dto.AddressId = this.AddressId;
                dto.OpeningDate = this.OpeningDate;
                dto.PrimaryPhoneNumber = this.PrimaryPhoneNumber;
                dto.PrimaryEmail = this.PrimaryEmail;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("nucleoId")]
        public int NucleoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("personResponsible")]
        public string PersonResponsible { get; set; }

        [JsonProperty("photo")]
        public int? Photo { get; set; }

        [JsonProperty("addressId")]
        public int? AddressId { get; set; }

        [JsonProperty("openingDate")]
        public System.DateTime? OpeningDate { get; set; }

        [JsonProperty("primaryPhoneNumber")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("primaryEmail")]
        public string PrimaryEmail { get; set; }

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
        public static string FormatNucleoViewModel(NucleoViewModel nucleoViewModel)
        {
            if (nucleoViewModel == null)
            {
                // null
                return "nucleoViewModel: null";
            }
            else
            {
                // output values
                return "nucleoViewModel: \n"
                    + "{ \n"
 
                    + "    NucleoId: " +  "'" + nucleoViewModel.NucleoId + "'"  + ", \n" 
                    + "    Name: " + (nucleoViewModel.Name != null ? "'" + nucleoViewModel.Name + "'" : "null") + ", \n" 
                    + "    PersonResponsible: " + (nucleoViewModel.PersonResponsible != null ? "'" + nucleoViewModel.PersonResponsible + "'" : "null") + ", \n" 
                    + "    Photo: " + (nucleoViewModel.Photo != null ? "'" + nucleoViewModel.Photo + "'" : "null") + ", \n" 
                    + "    AddressId: " + (nucleoViewModel.AddressId != null ? "'" + nucleoViewModel.AddressId + "'" : "null") + ", \n" 
                    + "    OpeningDate: " + (nucleoViewModel.OpeningDate != null ? "'" + nucleoViewModel.OpeningDate + "'" : "null") + ", \n" 
                    + "    PrimaryPhoneNumber: " + (nucleoViewModel.PrimaryPhoneNumber != null ? "'" + nucleoViewModel.PrimaryPhoneNumber + "'" : "null") + ", \n" 
                    + "    PrimaryEmail: " + (nucleoViewModel.PrimaryEmail != null ? "'" + nucleoViewModel.PrimaryEmail + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + nucleoViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + nucleoViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (nucleoViewModel.CreateBy != null ? "'" + nucleoViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (nucleoViewModel.CreateOn != null ? "'" + nucleoViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (nucleoViewModel.UpdateBy != null ? "'" + nucleoViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (nucleoViewModel.UpdateOn != null ? "'" + nucleoViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    