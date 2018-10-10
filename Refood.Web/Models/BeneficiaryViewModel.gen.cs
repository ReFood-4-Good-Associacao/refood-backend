
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
    public partial class BeneficiaryViewModel
    {
        public BeneficiaryViewModel() { }

        public BeneficiaryViewModel(BeneficiaryDTO t)
        {
            BeneficiaryId = t.BeneficiaryId;
            Name = t.Name;
            Number = t.Number;
            AddressId = t.AddressId;
            NumberOfAdults = t.NumberOfAdults;
            NumberOfChildren = t.NumberOfChildren;
            NumberOfTupperware = t.NumberOfTupperware;
            NumberOfSoups = t.NumberOfSoups;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public BeneficiaryViewModel(BeneficiaryDTO t, string editUrl)
        {
            BeneficiaryId = t.BeneficiaryId;
            Name = t.Name;
            Number = t.Number;
            AddressId = t.AddressId;
            NumberOfAdults = t.NumberOfAdults;
            NumberOfChildren = t.NumberOfChildren;
            NumberOfTupperware = t.NumberOfTupperware;
            NumberOfSoups = t.NumberOfSoups;
            Description = t.Description;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public BeneficiaryDTO UpdateDTO(BeneficiaryDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.BeneficiaryId = this.BeneficiaryId;
                dto.Name = this.Name;
                dto.Number = this.Number;
                dto.AddressId = this.AddressId;
                dto.NumberOfAdults = this.NumberOfAdults;
                dto.NumberOfChildren = this.NumberOfChildren;
                dto.NumberOfTupperware = this.NumberOfTupperware;
                dto.NumberOfSoups = this.NumberOfSoups;
                dto.Description = this.Description;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("beneficiaryId")]
        public int BeneficiaryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("addressId")]
        public int? AddressId { get; set; }

        [JsonProperty("numberOfAdults")]
        public int? NumberOfAdults { get; set; }

        [JsonProperty("numberOfChildren")]
        public int? NumberOfChildren { get; set; }

        [JsonProperty("numberOfTupperware")]
        public int? NumberOfTupperware { get; set; }

        [JsonProperty("numberOfSoups")]
        public int? NumberOfSoups { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

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
        public static string FormatBeneficiaryViewModel(BeneficiaryViewModel beneficiaryViewModel)
        {
            if (beneficiaryViewModel == null)
            {
                // null
                return "beneficiaryViewModel: null";
            }
            else
            {
                // output values
                return "beneficiaryViewModel: \n"
                    + "{ \n"
 
                    + "    BeneficiaryId: " +  "'" + beneficiaryViewModel.BeneficiaryId + "'"  + ", \n" 
                    + "    Name: " + (beneficiaryViewModel.Name != null ? "'" + beneficiaryViewModel.Name + "'" : "null") + ", \n" 
                    + "    Number: " + (beneficiaryViewModel.Number != null ? "'" + beneficiaryViewModel.Number + "'" : "null") + ", \n" 
                    + "    AddressId: " + (beneficiaryViewModel.AddressId != null ? "'" + beneficiaryViewModel.AddressId + "'" : "null") + ", \n" 
                    + "    NumberOfAdults: " + (beneficiaryViewModel.NumberOfAdults != null ? "'" + beneficiaryViewModel.NumberOfAdults + "'" : "null") + ", \n" 
                    + "    NumberOfChildren: " + (beneficiaryViewModel.NumberOfChildren != null ? "'" + beneficiaryViewModel.NumberOfChildren + "'" : "null") + ", \n" 
                    + "    NumberOfTupperware: " + (beneficiaryViewModel.NumberOfTupperware != null ? "'" + beneficiaryViewModel.NumberOfTupperware + "'" : "null") + ", \n" 
                    + "    NumberOfSoups: " + (beneficiaryViewModel.NumberOfSoups != null ? "'" + beneficiaryViewModel.NumberOfSoups + "'" : "null") + ", \n" 
                    + "    Description: " + (beneficiaryViewModel.Description != null ? "'" + beneficiaryViewModel.Description + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + beneficiaryViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + beneficiaryViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (beneficiaryViewModel.CreateBy != null ? "'" + beneficiaryViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (beneficiaryViewModel.CreateOn != null ? "'" + beneficiaryViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (beneficiaryViewModel.UpdateBy != null ? "'" + beneficiaryViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (beneficiaryViewModel.UpdateOn != null ? "'" + beneficiaryViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    