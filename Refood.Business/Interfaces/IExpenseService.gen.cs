
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IExpenseService
    {
        int AddExpense(ExpenseDTO dto);

        void DeleteExpense(int expenseId);

        void DeleteExpense(ExpenseDTO dto);

        ExpenseDTO GetExpense(int expenseId);

        IEnumerable<ExpenseDTO> GetExpenses();

        IList<ExpenseDTO> GetExpenses(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ExpenseDTO> GetExpenseListAdvancedSearch(
            int? nucleoId 
            ,string name 
            ,string description 
            ,int? responsiblePersonId 
            ,int? executerPersonId 
            ,int? documentId 
            ,int? partnerId 
            ,System.DateTime? invoiceDateFrom 
            ,System.DateTime? invoiceDateTo 
            ,double? amount 
        );

        void UpdateExpense(ExpenseDTO dto);

    }
}
    