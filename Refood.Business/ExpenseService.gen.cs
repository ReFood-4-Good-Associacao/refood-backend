
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Business
{
    public partial class ExpenseService :  IExpenseService
    {
        public static IExpenseRepository Repository;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpenseService()
        {
            if (Repository == null)
            {
                Repository = new ExpenseRepository();
            }
        }

        public int AddExpense(ExpenseDTO dto)
        {
            int id = 0;

            try
            {
                log.Debug(ExpenseDTO.FormatExpenseDTO(dto)); 

                R_Expense t = ExpenseDTO.ConvertDTOtoEntity(dto);

                // add
                id = Repository.AddExpense(t);
                dto.ExpenseId = id;

                log.Debug("result: 'success', id: " + id); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }

            return id;
        }

        public void DeleteExpense(ExpenseDTO dto)
        {
            try
            {
                log.Debug(ExpenseDTO.FormatExpenseDTO(dto)); 
            
                R_Expense t = ExpenseDTO.ConvertDTOtoEntity(dto);
            
                // delete
                Repository.DeleteExpense(t);
                dto.IsDeleted = t.IsDeleted;

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void DeleteExpense(int expenseId)
        {
            try
            {
                log.Debug("expenseId: " + expenseId + " "); 

                // delete
                Repository.DeleteExpense(expenseId);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public ExpenseDTO GetExpense(int expenseId)
        {
            try
            {
                //Requires.NotNegative("expenseId", expenseId);
                
                log.Debug("expenseId: " + expenseId + " "); 

                // get
                R_Expense t = Repository.GetExpense(expenseId);

                ExpenseDTO dto = new ExpenseDTO(t);

                log.Debug(ExpenseDTO.FormatExpenseDTO(dto)); 

                return dto;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ExpenseDTO> GetExpenses()
        {
            try
            {
                
                log.Debug("GetExpenses"); 

                // get
                IEnumerable<R_Expense> results = Repository.GetExpenses();

                IEnumerable<ExpenseDTO> resultsDTO = results.Select(e => new ExpenseDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IList<ExpenseDTO> GetExpenses(string searchTerm, int pageIndex, int pageSize)
        {
            try
            {
                
                log.Debug("searchTerm: " + searchTerm != null ? searchTerm : "null" + ", pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // get
                IList<R_Expense> results = Repository.GetExpenses(searchTerm, pageIndex, pageSize);
            
                IList<ExpenseDTO> resultsDTO = results.Select(e => new ExpenseDTO(e)).ToList();

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IEnumerable<ExpenseDTO> GetExpenseListAdvancedSearch(
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
            try
            {
                log.Debug("GetExpenseListAdvancedSearch"); 

                IEnumerable<R_Expense> results = Repository.GetExpenseListAdvancedSearch(
                     nucleoId 
                    , name 
                    , description 
                    , responsiblePersonId 
                    , executerPersonId 
                    , documentId 
                    , partnerId 
                    , invoiceDateFrom 
                    , invoiceDateTo 
                    , amount 
                );
            
                IEnumerable<ExpenseDTO> resultsDTO = results.Select(e => new ExpenseDTO(e));

                log.Debug("result: 'success', count: " + (resultsDTO != null ? resultsDTO.Count().ToString() : "null")); 

                return resultsDTO;
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public void UpdateExpense(ExpenseDTO dto)
        {
            try
            {
                //Requires.NotNull(t);
                //Requires.PropertyNotNegative(t, "ExpenseId");

                log.Debug(ExpenseDTO.FormatExpenseDTO(dto)); 

                R_Expense t = ExpenseDTO.ConvertDTOtoEntity(dto);

                // update
                Repository.UpdateExpense(t);

                log.Debug("result: 'success'"); 
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    