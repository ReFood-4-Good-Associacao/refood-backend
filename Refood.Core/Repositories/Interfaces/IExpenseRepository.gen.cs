
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IExpenseRepository
    {
        int AddExpense(R_Expense t);

        void DeleteExpense(R_Expense t);

        void DeleteExpense(int expenseId);

        R_Expense GetExpense(int expenseId);

        IEnumerable<R_Expense> GetExpenses();

        IList<R_Expense> GetExpenses(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Expense> GetExpenseListAdvancedSearch(
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
        );

        void UpdateExpense(R_Expense t);

    }
}

    