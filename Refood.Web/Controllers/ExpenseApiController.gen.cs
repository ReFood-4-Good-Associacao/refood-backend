
// ################################################################
//                      Code generated with T4
// ################################################################

using Refood.Web.Services.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;

namespace Refood.Web.Services
{
    //[Authorize]
    [RoutePrefix("api/ExpenseApi")]
    public partial class ExpenseApiController : ApiController
    {
        private readonly IExpenseService _expenseService;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpenseApiController(IExpenseService expenseService)
        {
            this._expenseService = expenseService;
        }

        public ExpenseApiController() : this(new ExpenseService()) { }

        /// <summary>
        /// Delete Expense by id
        /// </summary>
        /// <param name="id">Expense id</param>
        /// <returns>true if the Expense is deleted successfully</returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                // delete
                log.Debug("_expenseService.DeleteExpense - expenseId: " + id + " "); 

                _expenseService.DeleteExpense(id);

                log.Debug("result: 'success'"); 

                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get Expense by id
        /// </summary>
        /// <param name="id">Expense id</param>
        /// <returns>Expense json view model</returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                // get
                log.Debug("_expenseService.GetExpense - expenseId: " + id + " "); 

                var expense = new ExpenseViewModel(_expenseService.GetExpense(id));

                log.Debug("_expenseService.GetExpense - " + ExpenseViewModel.FormatExpenseViewModel(expense)); 

                log.Debug("result: 'success'"); 

                //return Json(expense, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(expense), "application/json");
                //return expense;
                //return JsonConvert.SerializeObject(expense);
                return Ok(expense);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get list of Expenses
        /// </summary>
        /// <returns>json list of Expense view models</returns>
        public IHttpActionResult GetList()
        {
            try
            {
                // get list
                List<ExpenseViewModel> expenses;

                log.Debug("_expenseService.GetExpenses"); 

                // add edit url
                expenses = _expenseService.GetExpenses()
                        .Select(expense => new ExpenseViewModel(expense, GetEditUrl(expense.ExpenseId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (expenses != null ? expenses.Count().ToString() : "null")); 

                //return Json(expenses, JsonRequestBehavior.AllowGet);
                //return Content(JsonConvert.SerializeObject(expenses), "application/json");
                //return JsonConvert.SerializeObject(expenses);
                return Ok(expenses);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        /// <summary>
        /// Get paged list of Expenses
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Expenses</returns>
        public IHttpActionResult GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // get page
                List<ExpenseViewModel> expenses;

                if(pageIndex <= 0)
                {
                    pageIndex = 1;
                }

                log.Debug("_expenseService.GetExpenses - searchTerm: '" + (searchTerm != null ? searchTerm : "") + "', pageIndex: " + pageIndex + ", pageSize: " + pageSize); 

                // add edit url
                expenses = _expenseService.GetExpenses(searchTerm, pageIndex, pageSize)
                        .Select(expense => new ExpenseViewModel(expense, GetEditUrl(expense.ExpenseId)))
                        .ToList();

                log.Debug("result: 'success', count: " + (expenses != null ? expenses.Count().ToString() : "null")); 

                //return Json(expenses, JsonRequestBehavior.AllowGet);
                //return JsonConvert.SerializeObject(expenses);
                return Ok(expenses);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        public IHttpActionResult GetListAdvancedSearch(
            int id = 0 
            , int? nucleoId = null 
            , string name = null 
            , string description = null 
            , int? responsiblePersonId = null 
            , int? executerPersonId = null 
            , int? documentId = null 
            , int? partnerId = null 
            , System.DateTime? invoiceDateFrom = null 
            , System.DateTime? invoiceDateTo = null 
            , double? amount = null 
        )
        {
            try
            {
                // advanced search

                log.Debug("GetExpenseListAdvancedSearch"); 

                IEnumerable<ExpenseDTO> resultsDTO = _expenseService.GetExpenseListAdvancedSearch(
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
            
                // convert to view model list, and add edit url
                List<ExpenseViewModel> expenseList = resultsDTO.Select(expense => new ExpenseViewModel(expense, GetEditUrl(expense.ExpenseId))).ToList();

                log.Debug("result: 'success', count: " + (expenseList != null ? expenseList.Count().ToString() : "null")); 

                //return Content(JsonConvert.SerializeObject(expenseList), "application/json");
                //return JsonConvert.SerializeObject(expenseList);
                return Ok(expenseList);
            }
            catch(System.Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        
        protected string GetEditUrl(int id)
        {
            string editUrl = Url.Content("~/Expense/Edit/?tid=" + id);

            return editUrl;
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Expense, or creates a new Expense if the Id is 0
        /// </summary>
        /// <param name="viewModel">Expense data</param>
        /// <returns>Expense id</returns>
        public IHttpActionResult Upsert(ExpenseViewModel viewModel)
        {
            log.Debug("Upsert"); 

            if (viewModel.ExpenseId > 0)
            {
                var t = Update(viewModel);
                //return Json(true);
                //return JsonConvert.SerializeObject(t.ExpenseId);
                return Ok(t.ExpenseId);
            }
            else
            {
                var t = Create(viewModel);
                //return Json(t.ExpenseId);
                //return JsonConvert.SerializeObject(t.ExpenseId);
                return Ok(t.ExpenseId);
            }
        }

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Expense
        /// </summary>
        /// <param name="viewModels">Expense view models</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        public IHttpActionResult SaveList(ExpenseViewModel[] viewModels, int? id)
        {
            try
            {
                log.Debug("SaveList"); 

                if(viewModels != null)
                {
                    // save list
                    foreach(ExpenseViewModel viewModel in viewModels)
                    {
                        log.Debug(ExpenseViewModel.FormatExpenseViewModel(viewModel)); 

                        if (viewModel.ExpenseId > 0)
                        {
                            var t = Update(viewModel);
                        }
                        else
                        {
                            var t = Create(viewModel);
                        }

                    }
                }
                else
                {
                    log.Error("viewModels: null"); 
                }

                //return Json(true);
                //return JsonConvert.SerializeObject(true);
                return Ok(true);
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ExpenseDTO Create(ExpenseViewModel viewModel)
        {
            try
            {
                log.Debug(ExpenseViewModel.FormatExpenseViewModel(viewModel)); 

                ExpenseDTO expense = new ExpenseDTO();

                // copy values
                viewModel.UpdateDTO(expense, null); //RequestContext.Principal.Identity.GetUserId());
                
                // audit
                expense.CreateBy = null; //RequestContext.Principal.Identity.GetUserId();
                expense.CreateOn = DateTime.UtcNow;

                // add
                log.Debug("_expenseService.AddExpense - " + ExpenseDTO.FormatExpenseDTO(expense)); 

                int id = _expenseService.AddExpense(expense);

                expense.ExpenseId = id;

                log.Debug("result: 'success', id: " + id); 

                return expense;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

        private ExpenseDTO Update(ExpenseViewModel viewModel)
        {
            try
            {
                log.Debug(ExpenseViewModel.FormatExpenseViewModel(viewModel)); 

                // get
                log.Debug("_expenseService.GetExpense - expenseId: " + viewModel.ExpenseId + " "); 

                var existingExpense = _expenseService.GetExpense(viewModel.ExpenseId);

                log.Debug("_expenseService.GetExpense - " + ExpenseDTO.FormatExpenseDTO(existingExpense)); 

                if (existingExpense != null)
                {
                    // copy values
                    viewModel.UpdateDTO(existingExpense, null); //RequestContext.Principal.Identity.GetUserId());

                    // update
                    log.Debug("_expenseService.UpdateExpense - " + ExpenseDTO.FormatExpenseDTO(existingExpense)); 

                    _expenseService.UpdateExpense(existingExpense);

                    log.Debug("result: 'success'"); 
                }
                else
                {
                    log.Error("existingExpense: null, ExpenseId: " + viewModel.ExpenseId); 
                }

                return existingExpense;
            }
            catch(Exception e)
            {
                // error
                log.Error(e.ToString()); 

                throw;
            }
        }

    }
}

    