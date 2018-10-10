
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class PartnerDTO
    {
        public int PartnerId { get; set; }
        public int? NucleoId { get; set; }
        public string Name { get; set; }
        public bool EnterpriseContributor { get; set; }
        public bool PrivateContributor { get; set; }
        public int ContributionTypeId { get; set; }
        public int PartnershipTypeId { get; set; }
        public string ContactPerson { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Iban { get; set; }
        public string BicSwift { get; set; }
        public string FiscalNumber { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string PhotoUrl { get; set; }
        public int? AddressId { get; set; }
        public System.DateTime? PartnershipStartDate { get; set; }
        public System.DateTime? DurationCommitment { get; set; }
        public string RefoodAreaInteraction { get; set; }
        public string Reliability { get; set; }
        public string InteractionFrequency { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public PartnerDTO()
        {
        
        }

        public PartnerDTO(R_Partner partner)
        {
            PartnerId = partner.PartnerId;
            NucleoId = partner.NucleoId;
            Name = partner.Name;
            EnterpriseContributor = partner.EnterpriseContributor;
            PrivateContributor = partner.PrivateContributor;
            ContributionTypeId = partner.ContributionTypeId;
            PartnershipTypeId = partner.PartnershipTypeId;
            ContactPerson = partner.ContactPerson;
            Department = partner.Department;
            Phone = partner.Phone;
            Email = partner.Email;
            Iban = partner.Iban;
            BicSwift = partner.BicSwift;
            FiscalNumber = partner.FiscalNumber;
            Latitude = partner.Latitude;
            Longitude = partner.Longitude;
            PhotoUrl = partner.PhotoUrl;
            AddressId = partner.AddressId;
            PartnershipStartDate = partner.PartnershipStartDate;
            DurationCommitment = partner.DurationCommitment;
            RefoodAreaInteraction = partner.RefoodAreaInteraction;
            Reliability = partner.Reliability;
            InteractionFrequency = partner.InteractionFrequency;
            Active = partner.Active;
            IsDeleted = partner.IsDeleted;
            CreateBy = partner.CreateBy;
            CreateOn = partner.CreateOn;
            UpdateBy = partner.UpdateBy;
            UpdateOn = partner.UpdateOn;
        }

        public static R_Partner ConvertDTOtoEntity(PartnerDTO dto)
        {
            R_Partner partner = new R_Partner();

            partner.PartnerId = dto.PartnerId;
            partner.NucleoId = dto.NucleoId;
            partner.Name = dto.Name;
            partner.EnterpriseContributor = dto.EnterpriseContributor;
            partner.PrivateContributor = dto.PrivateContributor;
            partner.ContributionTypeId = dto.ContributionTypeId;
            partner.PartnershipTypeId = dto.PartnershipTypeId;
            partner.ContactPerson = dto.ContactPerson;
            partner.Department = dto.Department;
            partner.Phone = dto.Phone;
            partner.Email = dto.Email;
            partner.Iban = dto.Iban;
            partner.BicSwift = dto.BicSwift;
            partner.FiscalNumber = dto.FiscalNumber;
            partner.Latitude = dto.Latitude;
            partner.Longitude = dto.Longitude;
            partner.PhotoUrl = dto.PhotoUrl;
            partner.AddressId = dto.AddressId;
            partner.PartnershipStartDate = dto.PartnershipStartDate;
            partner.DurationCommitment = dto.DurationCommitment;
            partner.RefoodAreaInteraction = dto.RefoodAreaInteraction;
            partner.Reliability = dto.Reliability;
            partner.InteractionFrequency = dto.InteractionFrequency;
            partner.Active = dto.Active;
            partner.IsDeleted = dto.IsDeleted;
            partner.CreateBy = dto.CreateBy;
            partner.CreateOn = dto.CreateOn;
            partner.UpdateBy = dto.UpdateBy;
            partner.UpdateOn = dto.UpdateOn;

            return partner;
        }

        // logging helper
        public static string FormatPartnerDTO(PartnerDTO partnerDTO)
        {
            if(partnerDTO == null)
            {
                // null
                return "partnerDTO: null";
            }
            else
            {
                // output values
                return "partnerDTO: \n"
                    + "{ \n"
 
                    + "    PartnerId: " +  "'" + partnerDTO.PartnerId + "'"  + ", \n" 
                    + "    NucleoId: " + (partnerDTO.NucleoId != null ? "'" + partnerDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (partnerDTO.Name != null ? "'" + partnerDTO.Name + "'" : "null") + ", \n" 
                    + "    EnterpriseContributor: " +  "'" + partnerDTO.EnterpriseContributor + "'"  + ", \n" 
                    + "    PrivateContributor: " +  "'" + partnerDTO.PrivateContributor + "'"  + ", \n" 
                    + "    ContributionTypeId: " +  "'" + partnerDTO.ContributionTypeId + "'"  + ", \n" 
                    + "    PartnershipTypeId: " +  "'" + partnerDTO.PartnershipTypeId + "'"  + ", \n" 
                    + "    ContactPerson: " + (partnerDTO.ContactPerson != null ? "'" + partnerDTO.ContactPerson + "'" : "null") + ", \n" 
                    + "    Department: " + (partnerDTO.Department != null ? "'" + partnerDTO.Department + "'" : "null") + ", \n" 
                    + "    Phone: " + (partnerDTO.Phone != null ? "'" + partnerDTO.Phone + "'" : "null") + ", \n" 
                    + "    Email: " + (partnerDTO.Email != null ? "'" + partnerDTO.Email + "'" : "null") + ", \n" 
                    + "    Iban: " + (partnerDTO.Iban != null ? "'" + partnerDTO.Iban + "'" : "null") + ", \n" 
                    + "    BicSwift: " + (partnerDTO.BicSwift != null ? "'" + partnerDTO.BicSwift + "'" : "null") + ", \n" 
                    + "    FiscalNumber: " + (partnerDTO.FiscalNumber != null ? "'" + partnerDTO.FiscalNumber + "'" : "null") + ", \n" 
                    + "    Latitude: " + (partnerDTO.Latitude != null ? "'" + partnerDTO.Latitude + "'" : "null") + ", \n" 
                    + "    Longitude: " + (partnerDTO.Longitude != null ? "'" + partnerDTO.Longitude + "'" : "null") + ", \n" 
                    + "    PhotoUrl: " + (partnerDTO.PhotoUrl != null ? "'" + partnerDTO.PhotoUrl + "'" : "null") + ", \n" 
                    + "    AddressId: " + (partnerDTO.AddressId != null ? "'" + partnerDTO.AddressId + "'" : "null") + ", \n" 
                    + "    PartnershipStartDate: " + (partnerDTO.PartnershipStartDate != null ? "'" + partnerDTO.PartnershipStartDate + "'" : "null") + ", \n" 
                    + "    DurationCommitment: " + (partnerDTO.DurationCommitment != null ? "'" + partnerDTO.DurationCommitment + "'" : "null") + ", \n" 
                    + "    RefoodAreaInteraction: " + (partnerDTO.RefoodAreaInteraction != null ? "'" + partnerDTO.RefoodAreaInteraction + "'" : "null") + ", \n" 
                    + "    Reliability: " + (partnerDTO.Reliability != null ? "'" + partnerDTO.Reliability + "'" : "null") + ", \n" 
                    + "    InteractionFrequency: " + (partnerDTO.InteractionFrequency != null ? "'" + partnerDTO.InteractionFrequency + "'" : "null") + ", \n" 
                    + "    Active: " +  "'" + partnerDTO.Active + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + partnerDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (partnerDTO.CreateBy != null ? "'" + partnerDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (partnerDTO.CreateOn != null ? "'" + partnerDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (partnerDTO.UpdateBy != null ? "'" + partnerDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (partnerDTO.UpdateOn != null ? "'" + partnerDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    