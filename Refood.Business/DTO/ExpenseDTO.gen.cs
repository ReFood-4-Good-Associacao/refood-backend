
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using Refood.Core;

namespace Refood.Business.DTOs
{
    public partial class ExpenseDTO
    {
        public int ExpenseId { get; set; }
        public int? NucleoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public int? ExecuterPersonId { get; set; }
        public int? DocumentId { get; set; }
        public int? PartnerId { get; set; }
        public System.DateTime? InvoiceDate { get; set; }
        public double Amount { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreateBy { get; set; }
        public System.DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public System.DateTime? UpdateOn { get; set; }

        public ExpenseDTO()
        {
        
        }

        public ExpenseDTO(R_Expense expense)
        {
            ExpenseId = expense.ExpenseId;
            NucleoId = expense.NucleoId;
            Name = expense.Name;
            Description = expense.Description;
            ResponsiblePersonId = expense.ResponsiblePersonId;
            ExecuterPersonId = expense.ExecuterPersonId;
            DocumentId = expense.DocumentId;
            PartnerId = expense.PartnerId;
            InvoiceDate = expense.InvoiceDate;
            Amount = expense.Amount;
            IsDeleted = expense.IsDeleted;
            CreateBy = expense.CreateBy;
            CreateOn = expense.CreateOn;
            UpdateBy = expense.UpdateBy;
            UpdateOn = expense.UpdateOn;
        }

        public static R_Expense ConvertDTOtoEntity(ExpenseDTO dto)
        {
            R_Expense expense = new R_Expense();

            expense.ExpenseId = dto.ExpenseId;
            expense.NucleoId = dto.NucleoId;
            expense.Name = dto.Name;
            expense.Description = dto.Description;
            expense.ResponsiblePersonId = dto.ResponsiblePersonId;
            expense.ExecuterPersonId = dto.ExecuterPersonId;
            expense.DocumentId = dto.DocumentId;
            expense.PartnerId = dto.PartnerId;
            expense.InvoiceDate = dto.InvoiceDate;
            expense.Amount = dto.Amount;
            expense.IsDeleted = dto.IsDeleted;
            expense.CreateBy = dto.CreateBy;
            expense.CreateOn = dto.CreateOn;
            expense.UpdateBy = dto.UpdateBy;
            expense.UpdateOn = dto.UpdateOn;

            return expense;
        }

        // logging helper
        public static string FormatExpenseDTO(ExpenseDTO expenseDTO)
        {
            if(expenseDTO == null)
            {
                // null
                return "expenseDTO: null";
            }
            else
            {
                // output values
                return "expenseDTO: \n"
                    + "{ \n"
 
                    + "    ExpenseId: " +  "'" + expenseDTO.ExpenseId + "'"  + ", \n" 
                    + "    NucleoId: " + (expenseDTO.NucleoId != null ? "'" + expenseDTO.NucleoId + "'" : "null") + ", \n" 
                    + "    Name: " + (expenseDTO.Name != null ? "'" + expenseDTO.Name + "'" : "null") + ", \n" 
                    + "    Description: " + (expenseDTO.Description != null ? "'" + expenseDTO.Description + "'" : "null") + ", \n" 
                    + "    ResponsiblePersonId: " + (expenseDTO.ResponsiblePersonId != null ? "'" + expenseDTO.ResponsiblePersonId + "'" : "null") + ", \n" 
                    + "    ExecuterPersonId: " + (expenseDTO.ExecuterPersonId != null ? "'" + expenseDTO.ExecuterPersonId + "'" : "null") + ", \n" 
                    + "    DocumentId: " + (expenseDTO.DocumentId != null ? "'" + expenseDTO.DocumentId + "'" : "null") + ", \n" 
                    + "    PartnerId: " + (expenseDTO.PartnerId != null ? "'" + expenseDTO.PartnerId + "'" : "null") + ", \n" 
                    + "    InvoiceDate: " + (expenseDTO.InvoiceDate != null ? "'" + expenseDTO.InvoiceDate + "'" : "null") + ", \n" 
                    + "    Amount: " +  "'" + expenseDTO.Amount + "'"  + ", \n" 
                    + "    IsDeleted: " +  "'" + expenseDTO.IsDeleted + "'"  + ", \n" 
                    + "    CreateBy: " + (expenseDTO.CreateBy != null ? "'" + expenseDTO.CreateBy + "'" : "null") + ", \n" 
                    + "    CreateOn: " + (expenseDTO.CreateOn != null ? "'" + expenseDTO.CreateOn + "'" : "null") + ", \n" 
                    + "    UpdateBy: " + (expenseDTO.UpdateBy != null ? "'" + expenseDTO.UpdateBy + "'" : "null") + ", \n" 
                    + "    UpdateOn: " + (expenseDTO.UpdateOn != null ? "'" + expenseDTO.UpdateOn + "'" : "null") + " \n" 
                    + "} \n";
            }
        }
        

    }
}

    