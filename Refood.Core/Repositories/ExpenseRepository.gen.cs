
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class ExpenseRepository : IExpenseRepository
    {
        public int AddExpense(R_Expense t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteExpense(R_Expense t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteExpense(int expenseId)
        {
            var t = GetExpense(expenseId);
            DeleteExpense(t);
        }

        public R_Expense GetExpense(int expenseId)
        {
            //Requires.NotNegative("expenseId", expenseId);
            
            R_Expense t = R_Expense.SingleOrDefault(expenseId);

            return t;
        }

        public IEnumerable<R_Expense> GetExpenses()
        {
             
            IEnumerable<R_Expense> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Expense")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Expense.Query(sql);

            return results;
        }

        public IList<R_Expense> GetExpenses(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Expense> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Expense")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_Expense.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Expense> GetExpenseListAdvancedSearch(
            int? nucleoId 
            , string name 
            , string description 
            , int? responsiblePersonId 
            , int? executerPersonId 
            , int? documentId 
            , int? partnerId 
            , System.DateTime? invoiceDateFrom 
            , System.DateTime? invoiceDateTo 
            , double? amount 
        )
        {
            IEnumerable<R_Expense> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Expense")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (responsiblePersonId != null ? " and ResponsiblePersonId like '%" + responsiblePersonId + "%'" : "")
                    + (executerPersonId != null ? " and ExecuterPersonId like '%" + executerPersonId + "%'" : "")
                    + (documentId != null ? " and DocumentId like '%" + documentId + "%'" : "")
                    + (partnerId != null ? " and PartnerId like '%" + partnerId + "%'" : "")
                    + (invoiceDateFrom != null ? " and InvoiceDate >= '" + invoiceDateFrom.Value.ToShortDateString() + "'" : "")
                    + (invoiceDateTo != null ? " and InvoiceDate <= '" + invoiceDateTo.Value.ToShortDateString() + "'" : "")
                    + (amount != null ? " and Amount like '%" + amount + "%'" : "")
                 )
            ;

            results = R_Expense.Query(sql);

            return results;
        }

        public void UpdateExpense(R_Expense t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ExpenseId");

            t.Update();
        }

    }
}

        