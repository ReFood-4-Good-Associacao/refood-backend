
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
    public partial class PartnerViewModel
    {
        public PartnerViewModel() { }

        public PartnerViewModel(PartnerDTO t)
        {
            PartnerId = t.PartnerId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            EnterpriseContributor = t.EnterpriseContributor;
            PrivateContributor = t.PrivateContributor;
            ContributionTypeId = t.ContributionTypeId;
            PartnershipTypeId = t.PartnershipTypeId;
            ContactPerson = t.ContactPerson;
            Department = t.Department;
            Phone = t.Phone;
            Email = t.Email;
            Iban = t.Iban;
            BicSwift = t.BicSwift;
            FiscalNumber = t.FiscalNumber;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            PhotoUrl = t.PhotoUrl;
            AddressId = t.AddressId;
            PartnershipStartDate = t.PartnershipStartDate;
            DurationCommitment = t.DurationCommitment;
            RefoodAreaInteraction = t.RefoodAreaInteraction;
            Reliability = t.Reliability;
            InteractionFrequency = t.InteractionFrequency;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public PartnerViewModel(PartnerDTO t, string editUrl)
        {
            PartnerId = t.PartnerId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            EnterpriseContributor = t.EnterpriseContributor;
            PrivateContributor = t.PrivateContributor;
            ContributionTypeId = t.ContributionTypeId;
            PartnershipTypeId = t.PartnershipTypeId;
            ContactPerson = t.ContactPerson;
            Department = t.Department;
            Phone = t.Phone;
            Email = t.Email;
            Iban = t.Iban;
            BicSwift = t.BicSwift;
            FiscalNumber = t.FiscalNumber;
            Latitude = t.Latitude;
            Longitude = t.Longitude;
            PhotoUrl = t.PhotoUrl;
            AddressId = t.AddressId;
            PartnershipStartDate = t.PartnershipStartDate;
            DurationCommitment = t.DurationCommitment;
            RefoodAreaInteraction = t.RefoodAreaInteraction;
            Reliability = t.Reliability;
            InteractionFrequency = t.InteractionFrequency;
            Active = t.Active;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public PartnerDTO UpdateDTO(PartnerDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.PartnerId = this.PartnerId;
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.EnterpriseContributor = this.EnterpriseContributor;
                dto.PrivateContributor = this.PrivateContributor;
                dto.ContributionTypeId = this.ContributionTypeId;
                dto.PartnershipTypeId = this.PartnershipTypeId;
                dto.ContactPerson = this.ContactPerson;
                dto.Department = this.Department;
                dto.Phone = this.Phone;
                dto.Email = this.Email;
                dto.Iban = this.Iban;
                dto.BicSwift = this.BicSwift;
                dto.FiscalNumber = this.FiscalNumber;
                dto.Latitude = this.Latitude;
                dto.Longitude = this.Longitude;
                dto.PhotoUrl = this.PhotoUrl;
                dto.AddressId = this.AddressId;
                dto.PartnershipStartDate = this.PartnershipStartDate;
                dto.DurationCommitment = this.DurationCommitment;
                dto.RefoodAreaInteraction = this.RefoodAreaInteraction;
                dto.Reliability = this.Reliability;
                dto.InteractionFrequency = this.InteractionFrequency;
                dto.Active = this.Active;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("partnerId")]
        public int PartnerId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enterpriseContributor")]
        public bool EnterpriseContributor { get; set; }

        [JsonProperty("privateContributor")]
        public bool PrivateContributor { get; set; }

        [JsonProperty("contributionTypeId")]
        public int ContributionTypeId { get; set; }

        [JsonProperty("partnershipTypeId")]
        public int PartnershipTypeId { get; set; }

        [JsonProperty("contactPerson")]
        public string ContactPerson { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bicSwift")]
        public string BicSwift { get; set; }

        [JsonProperty("fiscalNumber")]
        public string FiscalNumber { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }

        [JsonProperty("addressId")]
        public int? AddressId { get; set; }

        [JsonProperty("partnershipStartDate")]
        public System.DateTime? PartnershipStartDate { get; set; }

        [JsonProperty("durationCommitment")]
        public System.DateTime? DurationCommitment { get; set; }

        [JsonProperty("refoodAreaInteraction")]
        public string RefoodAreaInteraction { get; set; }

        [JsonProperty("reliability")]
        public string Reliability { get; set; }

        [JsonProperty("interactionFrequency")]
        public string InteractionFrequency { get; set; }

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
        public static string FormatPartnerViewModel(PartnerViewModel partnerViewModel)
        {
            if (partnerViewModel == null)
            {
                // null
                return "partnerViewModel: null";
            }
            else
            {
                // output values
                return "partnerViewModel: \n"
                    + "{ \n"
 
                    + "    PartnerId: " +  "'" + partnerViewModel.PartnerId + "'"  + ", \n" 
                    + "    NucleoId: " + (partnerViewModel.NucleoId != null ? "'" + partnerViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (partnerViewModel.Name != null ? "'" + partnerViewModel.Name + "'" : "null") + ", \n" 
                    + "    EnterpriseContributor: " +  "'" + partnerViewModel.EnterpriseContributor + "'"  + ", \n" 
                    + "    PrivateContributor: " +  "'" + partnerViewModel.PrivateContributor + "'"  + ", \n" 
                    + "    ContributionTypeId: " +  "'" + partnerViewModel.ContributionTypeId + "'"  + ", \n" 
                    + "    PartnershipTypeId: " +  "'" + partnerViewModel.PartnershipTypeId + "'"  + ", \n" 
                    + "    ContactPerson: " + (partnerViewModel.ContactPerson != null ? "'" + partnerViewModel.ContactPerson + "'" : "null") + ", \n" 
                    + "    Department: " + (partnerViewModel.Department != null ? "'" + partnerViewModel.Department + "'" : "null") + ", \n" 
                    + "    Phone: " + (partnerViewModel.Phone != null ? "'" + partnerViewModel.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (partnerViewModel.Email != null ? "'" + partnerViewModel.Email + "'" : "null") + ", \n" 
                    + "    Iban: " + (partnerViewModel.Iban != null ? "'" + partnerViewModel.Iban + "'" : "null") + ", \n" 
                    + "    BicSwift: " + (partnerViewModel.BicSwift != null ? "'" + partnerViewModel.BicSwift + "'" : "null") + ", \n" 
                    + "    FiscalNumber: " + (partnerViewModel.FiscalNumber != null ? "'" + partnerViewModel.FiscalNumber + "'" : "null") + ", \n" 
                    + "    Latitude: " + (partnerViewModel.Latitude != null ? "'" + partnerViewModel.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (partnerViewModel.Longitude != null ? "'" + partnerViewModel.Longitude + "'" : "null") + ", \n" 
                    + "    PhotoUrl: " + (partnerViewModel.PhotoUrl != null ? "'" + partnerViewModel.PhotoUrl + "'" : "null") + ", \n" 
                    + "    AddressId: " + (partnerViewModel.AddressId != null ? "'" + partnerViewModel.AddressId + "'" : "null") + ", \n" 
                    + "    PartnershipStartDate: " + (partnerViewModel.PartnershipStartDate != null ? "'" + partnerViewModel.PartnershipStartDate + "'" : "null") + ", \n" 
                    + "    DurationCommitment: " + (partnerViewModel.DurationCommitment != null ? "'" + partnerViewModel.DurationCommitment + "'" : "null") + ", \n" 
                    + "    RefoodAreaInteraction: " + (partnerViewModel.RefoodAreaInteraction != null ? "'" + partnerViewModel.RefoodAreaInteraction + "'" : "null") + ", \n" 
                    + "    Reliability: " + (partnerViewModel.Reliability != null ? "'" + partnerViewModel.Reliability + "'" : "null") + ", \n" 
                    + "    InteractionFrequency: " + (partnerViewModel.InteractionFrequency != null ? "'" + partnerViewModel.InteractionFrequency + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + partnerViewModel.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + partnerViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (partnerViewModel.CreateBy != null ? "'" + partnerViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (partnerViewModel.CreateOn != null ? "'" + partnerViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (partnerViewModel.UpdateBy != null ? "'" + partnerViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (partnerViewModel.UpdateOn != null ? "'" + partnerViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    