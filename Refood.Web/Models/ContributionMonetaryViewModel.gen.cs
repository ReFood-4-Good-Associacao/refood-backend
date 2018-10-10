
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
    public partial class ContributionMonetaryViewModel
    {
        public ContributionMonetaryViewModel() { }

        public ContributionMonetaryViewModel(ContributionMonetaryDTO t)
        {
            ContributionMonetaryId = t.ContributionMonetaryId;
            NucleoId = t.NucleoId;
            ResponsiblePersonId = t.ResponsiblePersonId;
            DocumentId = t.DocumentId;
            PartnerId = t.PartnerId;
            ContributionDate = t.ContributionDate;
            Amount = t.Amount;
            ContactPerson = t.ContactPerson;
            IbanOrigin = t.IbanOrigin;
            BicSwiftOrigin = t.BicSwiftOrigin;
            IbanDestination = t.IbanDestination;
            BicSwiftDestination = t.BicSwiftDestination;
            FiscalNumber = t.FiscalNumber;
            ContributionChannelId = t.ContributionChannelId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ContributionMonetaryViewModel(ContributionMonetaryDTO t, string editUrl)
        {
            ContributionMonetaryId = t.ContributionMonetaryId;
            NucleoId = t.NucleoId;
            ResponsiblePersonId = t.ResponsiblePersonId;
            DocumentId = t.DocumentId;
            PartnerId = t.PartnerId;
            ContributionDate = t.ContributionDate;
            Amount = t.Amount;
            ContactPerson = t.ContactPerson;
            IbanOrigin = t.IbanOrigin;
            BicSwiftOrigin = t.BicSwiftOrigin;
            IbanDestination = t.IbanDestination;
            BicSwiftDestination = t.BicSwiftDestination;
            FiscalNumber = t.FiscalNumber;
            ContributionChannelId = t.ContributionChannelId;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public ContributionMonetaryDTO UpdateDTO(ContributionMonetaryDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ContributionMonetaryId = this.ContributionMonetaryId;
                dto.NucleoId = this.NucleoId;
                dto.ResponsiblePersonId = this.ResponsiblePersonId;
                dto.DocumentId = this.DocumentId;
                dto.PartnerId = this.PartnerId;
                dto.ContributionDate = this.ContributionDate;
                dto.Amount = this.Amount;
                dto.ContactPerson = this.ContactPerson;
                dto.IbanOrigin = this.IbanOrigin;
                dto.BicSwiftOrigin = this.BicSwiftOrigin;
                dto.IbanDestination = this.IbanDestination;
                dto.BicSwiftDestination = this.BicSwiftDestination;
                dto.FiscalNumber = this.FiscalNumber;
                dto.ContributionChannelId = this.ContributionChannelId;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("contributionMonetaryId")]
        public int ContributionMonetaryId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("responsiblePersonId")]
        public int? ResponsiblePersonId { get; set; }

        [JsonProperty("documentId")]
        public int? DocumentId { get; set; }

        [JsonProperty("partnerId")]
        public int? PartnerId { get; set; }

        [JsonProperty("contributionDate")]
        public System.DateTime? ContributionDate { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("contactPerson")]
        public string ContactPerson { get; set; }

        [JsonProperty("ibanOrigin")]
        public string IbanOrigin { get; set; }

        [JsonProperty("bicSwiftOrigin")]
        public string BicSwiftOrigin { get; set; }

        [JsonProperty("ibanDestination")]
        public string IbanDestination { get; set; }

        [JsonProperty("bicSwiftDestination")]
        public string BicSwiftDestination { get; set; }

        [JsonProperty("fiscalNumber")]
        public string FiscalNumber { get; set; }

        [JsonProperty("contributionChannelId")]
        public int? ContributionChannelId { get; set; }

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
        public static string FormatContributionMonetaryViewModel(ContributionMonetaryViewModel contributionMonetaryViewModel)
        {
            if (contributionMonetaryViewModel == null)
            {
                // null
                return "contributionMonetaryViewModel: null";
            }
            else
            {
                // output values
                return "contributionMonetaryViewModel: \n"
                    + "{ \n"
 
                    + "    ContributionMonetaryId: " +  "'" + contributionMonetaryViewModel.ContributionMonetaryId + "'"  + ", \n" 
                    + "    NucleoId: " + (contributionMonetaryViewModel.NucleoId != null ? "'" + contributionMonetaryViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    ResponsiblePersonId: " + (contributionMonetaryViewModel.ResponsiblePersonId != null ? "'" + contributionMonetaryViewModel.ResponsiblePersonId + "'" : "null") + ", \n" 
                    + "    DocumentId: " + (contributionMonetaryViewModel.DocumentId != null ? "'" + contributionMonetaryViewModel.DocumentId + "'" : "null") + ", \n" 
                    + "    PartnerId: " + (contributionMonetaryViewModel.PartnerId != null ? "'" + contributionMonetaryViewModel.PartnerId + "'" : "null") + ", \n" 
                    + "    ContributionDate: " + (contributionMonetaryViewModel.ContributionDate != null ? "'" + contributionMonetaryViewModel.ContributionDate + "'" : "null") + ", \n" 
                    + "    Amount: " +  "'" + contributionMonetaryViewModel.Amount + "'"  + ", \n" 
                    + "    ContactPerson: " + (contributionMonetaryViewModel.ContactPerson != null ? "'" + contributionMonetaryViewModel.ContactPerson + "'" : "null") + ", \n" 
                    + "    IbanOrigin: " + (contributionMonetaryViewModel.IbanOrigin != null ? "'" + contributionMonetaryViewModel.IbanOrigin + "'" : "null") + ", \n" 
                    + "    BicSwiftOrigin: " + (contributionMonetaryViewModel.BicSwiftOrigin != null ? "'" + contributionMonetaryViewModel.BicSwiftOrigin + "'" : "null") + ", \n" 
                    + "    IbanDestination: " + (contributionMonetaryViewModel.IbanDestination != null ? "'" + contributionMonetaryViewModel.IbanDestination + "'" : "null") + ", \n" 
                    + "    BicSwiftDestination: " + (contributionMonetaryViewModel.BicSwiftDestination != null ? "'" + contributionMonetaryViewModel.BicSwiftDestination + "'" : "null") + ", \n" 
                    + "    FiscalNumber: " + (contributionMonetaryViewModel.FiscalNumber != null ? "'" + contributionMonetaryViewModel.FiscalNumber + "'" : "null") + ", \n" 
                    + "    ContributionChannelId: " + (contributionMonetaryViewModel.ContributionChannelId != null ? "'" + contributionMonetaryViewModel.ContributionChannelId + "'" : "null") + ", \n" 
                    + "    IsDeleted: " +  "'" + contributionMonetaryViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (contributionMonetaryViewModel.CreateBy != null ? "'" + contributionMonetaryViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (contributionMonetaryViewModel.CreateOn != null ? "'" + contributionMonetaryViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (contributionMonetaryViewModel.UpdateBy != null ? "'" + contributionMonetaryViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (contributionMonetaryViewModel.UpdateOn != null ? "'" + contributionMonetaryViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    