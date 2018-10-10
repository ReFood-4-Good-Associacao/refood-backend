
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ContributionMonetaryDTO
    {
        public int ContributionMonetaryId { get; set; }
        public int? NucleoId { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public int? DocumentId { get; set; }
        public int? PartnerId { get; set; }
        public System.DateTime? ContributionDate { get; set; }
        public double Amount { get; set; }
        public string ContactPerson { get; set; }
        public string IbanOrigin { get; set; }
        public string BicSwiftOrigin { get; set; }
        public string IbanDestination { get; set; }
        public string BicSwiftDestination { get; set; }
        public string FiscalNumber { get; set; }
        public int? ContributionChannelId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ContributionMonetaryDTO()
        {
        
        }

        public ContributionMonetaryDTO(R_ContributionMonetary contributionMonetary)
        {
            ContributionMonetaryId = contributionMonetary.ContributionMonetaryId;
            NucleoId = contributionMonetary.NucleoId;
            ResponsiblePersonId = contributionMonetary.ResponsiblePersonId;
            DocumentId = contributionMonetary.DocumentId;
            PartnerId = contributionMonetary.PartnerId;
            ContributionDate = contributionMonetary.ContributionDate;
            Amount = contributionMonetary.Amount;
            ContactPerson = contributionMonetary.ContactPerson;
            IbanOrigin = contributionMonetary.IbanOrigin;
            BicSwiftOrigin = contributionMonetary.BicSwiftOrigin;
            IbanDestination = contributionMonetary.IbanDestination;
            BicSwiftDestination = contributionMonetary.BicSwiftDestination;
            FiscalNumber = contributionMonetary.FiscalNumber;
            ContributionChannelId = contributionMonetary.ContributionChannelId;
            IsDeleted = contributionMonetary.IsDeleted;
            CreateBy = contributionMonetary.CreateBy;
            CreateOn = contributionMonetary.CreateOn;
            UpdateBy = contributionMonetary.UpdateBy;
            UpdateOn = contributionMonetary.UpdateOn;
        }

        public static R_ContributionMonetary ConvertDTOtoEntity(ContributionMonetaryDTO dto)
        {
            R_ContributionMonetary contributionMonetary = new R_ContributionMonetary();

            contributionMonetary.ContributionMonetaryId = dto.ContributionMonetaryId;
            contributionMonetary.NucleoId = dto.NucleoId;
            contributionMonetary.ResponsiblePersonId = dto.ResponsiblePersonId;
            contributionMonetary.DocumentId = dto.DocumentId;
            contributionMonetary.PartnerId = dto.PartnerId;
            contributionMonetary.ContributionDate = dto.ContributionDate;
            contributionMonetary.Amount = dto.Amount;
            contributionMonetary.ContactPerson = dto.ContactPerson;
            contributionMonetary.IbanOrigin = dto.IbanOrigin;
            contributionMonetary.BicSwiftOrigin = dto.BicSwiftOrigin;
            contributionMonetary.IbanDestination = dto.IbanDestination;
            contributionMonetary.BicSwiftDestination = dto.BicSwiftDestination;
            contributionMonetary.FiscalNumber = dto.FiscalNumber;
            contributionMonetary.ContributionChannelId = dto.ContributionChannelId;
            contributionMonetary.IsDeleted = dto.IsDeleted;
            contributionMonetary.CreateBy = dto.CreateBy;
            contributionMonetary.CreateOn = dto.CreateOn;
            contributionMonetary.UpdateBy = dto.UpdateBy;
            contributionMonetary.UpdateOn = dto.UpdateOn;

            return contributionMonetary;
        }

        // logging helper
        public static string FormatContributionMonetaryDTO(ContributionMonetaryDTO contributionMonetaryDTO)
        {
            if(contributionMonetaryDTO == null)
            {
                // null
                return "contributionMonetaryDTO: null";
            }
            else
            {
                // output values
                return "contributionMonetaryDTO: \n"
                    + "{ \n"
 
                    + "    ContributionMonetaryId: " +  "'" + contributionMonetaryDTO.ContributionMonetaryId + "'"  + ", \n" 
                    + "    NucleoId: " + (contributionMonetaryDTO.NucleoId != null ? "'" + contributionMonetaryDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    ResponsiblePersonId: " + (contributionMonetaryDTO.ResponsiblePersonId != null ? "'" + contributionMonetaryDTO.ResponsiblePersonId + "'" : "null") + ", \n" 
                    + "    DocumentId: " + (contributionMonetaryDTO.DocumentId != null ? "'" + contributionMonetaryDTO.DocumentId + "'" : "null") + ", \n" 
                    + "    PartnerId: " + (contributionMonetaryDTO.PartnerId != null ? "'" + contributionMonetaryDTO.PartnerId + "'" : "null") + ", \n" 
                    + "    ContributionDate: " + (contributionMonetaryDTO.ContributionDate != null ? "'" + contributionMonetaryDTO.ContributionDate + "'" : "null") + ", \n" 
                    + "    Amount: " +  "'" + contributionMonetaryDTO.Amount + "'"  + ", \n" 
                    + "    ContactPerson: " + (contributionMonetaryDTO.ContactPerson != null ? "'" + contributionMonetaryDTO.ContactPerson + "'" : "null") + ", \n" 
                    + "    IbanOrigin: " + (contributionMonetaryDTO.IbanOrigin != null ? "'" + contributionMonetaryDTO.IbanOrigin + "'" : "null") + ", \n" 
                    + "    BicSwiftOrigin: " + (contributionMonetaryDTO.BicSwiftOrigin != null ? "'" + contributionMonetaryDTO.BicSwiftOrigin + "'" : "null") + ", \n" 
                    + "    IbanDestination: " + (contributionMonetaryDTO.IbanDestination != null ? "'" + contributionMonetaryDTO.IbanDestination + "'" : "null") + ", \n" 
                    + "    BicSwiftDestination: " + (contributionMonetaryDTO.BicSwiftDestination != null ? "'" + contributionMonetaryDTO.BicSwiftDestination + "'" : "null") + ", \n" 
                    + "    FiscalNumber: " + (contributionMonetaryDTO.FiscalNumber != null ? "'" + contributionMonetaryDTO.FiscalNumber + "'" : "null") + ", \n" 
                    + "    ContributionChannelId: " + (contributionMonetaryDTO.ContributionChannelId != null ? "'" + contributionMonetaryDTO.ContributionChannelId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionMonetaryDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionMonetaryDTO.CreateBy != null ? "'" + contributionMonetaryDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionMonetaryDTO.CreateOn != null ? "'" + contributionMonetaryDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionMonetaryDTO.UpdateBy != null ? "'" + contributionMonetaryDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionMonetaryDTO.UpdateOn != null ? "'" + contributionMonetaryDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    