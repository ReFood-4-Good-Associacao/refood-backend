
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
    public partial class ExpenseViewModel
    {
        public ExpenseViewModel() { }

        public ExpenseViewModel(ExpenseDTO t)
        {
            ExpenseId = t.ExpenseId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            ResponsiblePersonId = t.ResponsiblePersonId;
            ExecuterPersonId = t.ExecuterPersonId;
            DocumentId = t.DocumentId;
            PartnerId = t.PartnerId;
            InvoiceDate = t.InvoiceDate;
            Amount = t.Amount;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
        }

        public ExpenseViewModel(ExpenseDTO t, string editUrl)
        {
            ExpenseId = t.ExpenseId;
            NucleoId = t.NucleoId;
            Name = t.Name;
            Description = t.Description;
            ResponsiblePersonId = t.ResponsiblePersonId;
            ExecuterPersonId = t.ExecuterPersonId;
            DocumentId = t.DocumentId;
            PartnerId = t.PartnerId;
            InvoiceDate = t.InvoiceDate;
            Amount = t.Amount;
            IsDeleted = t.IsDeleted;
            CreateBy = t.CreateBy;
            CreateOn = t.CreateOn;
            UpdateBy = t.UpdateBy;
            UpdateOn = t.UpdateOn;
            EditUrl = editUrl;
        }

        public ExpenseDTO UpdateDTO(ExpenseDTO dto, int? updateBy)
        {
            if (dto != null)
            {
                dto.ExpenseId = this.ExpenseId;
                dto.NucleoId = this.NucleoId;
                dto.Name = this.Name;
                dto.Description = this.Description;
                dto.ResponsiblePersonId = this.ResponsiblePersonId;
                dto.ExecuterPersonId = this.ExecuterPersonId;
                dto.DocumentId = this.DocumentId;
                dto.PartnerId = this.PartnerId;
                dto.InvoiceDate = this.InvoiceDate;
                dto.Amount = this.Amount;
                dto.IsDeleted = this.IsDeleted;

                dto.UpdateBy = updateBy;
                dto.UpdateOn = System.DateTime.UtcNow;
            }

            return dto;
        }

        [JsonProperty("expenseId")]
        public int ExpenseId { get; set; }

        [JsonProperty("nucleoId")]
        public int? NucleoId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("responsiblePersonId")]
        public int? ResponsiblePersonId { get; set; }

        [JsonProperty("executerPersonId")]
        public int? ExecuterPersonId { get; set; }

        [JsonProperty("documentId")]
        public int? DocumentId { get; set; }

        [JsonProperty("partnerId")]
        public int? PartnerId { get; set; }

        [JsonProperty("invoiceDate")]
        public System.DateTime? InvoiceDate { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

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
        public static string FormatExpenseViewModel(ExpenseViewModel expenseViewModel)
        {
            if (expenseViewModel == null)
            {
                // null
                return "expenseViewModel: null";
            }
            else
            {
                // output values
                return "expenseViewModel: \n"
                    + "{ \n"
 
                    + "    ExpenseId: " +  "'" + expenseViewModel.ExpenseId + "'"  + ", \n" 
                    + "    NucleoId: " + (expenseViewModel.NucleoId != null ? "'" + expenseViewModel.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (expenseViewModel.Name != null ? "'" + expenseViewModel.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (expenseViewModel.Description != null ? "'" + expenseViewModel.Description + "'" : "null") + ", \n" 
                    + "    ResponsiblePersonId: " + (expenseViewModel.ResponsiblePersonId != null ? "'" + expenseViewModel.ResponsiblePersonId + "'" : "null") + ", \n" 
                    + "    ExecuterPersonId: " + (expenseViewModel.ExecuterPersonId != null ? "'" + expenseViewModel.ExecuterPersonId + "'" : "null") + ", \n" 
                    + "    DocumentId: " + (expenseViewModel.DocumentId != null ? "'" + expenseViewModel.DocumentId + "'" : "null") + ", \n" 
                    + "    PartnerId: " + (expenseViewModel.PartnerId != null ? "'" + expenseViewModel.PartnerId + "'" : "null") + ", \n" 
                    + "    InvoiceDate: " + (expenseViewModel.InvoiceDate != null ? "'" + expenseViewModel.InvoiceDate + "'" : "null") + ", \n" 
                    + "    Amount: " +  "'" + expenseViewModel.Amount + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + expenseViewModel.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (expenseViewModel.CreateBy != null ? "'" + expenseViewModel.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (expenseViewModel.CreateOn != null ? "'" + expenseViewModel.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (expenseViewModel.UpdateBy != null ? "'" + expenseViewModel.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (expenseViewModel.UpdateOn != null ? "'" + expenseViewModel.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}
    