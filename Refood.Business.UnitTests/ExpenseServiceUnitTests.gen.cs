
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories;
using Refood.Core.Repositories.Interfaces;
using Refood.Business;
using Refood.Business.DTOs;
using Refood.Business.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Refood.Business.UnitTests
{
    [TestClass]
    public partial class ExpenseServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddExpense_Success_Test()
        {
            // Arrange
            ExpenseDTO dto = SampleExpenseDTO(1);

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.AddExpense(Moq.It.IsAny<R_Expense>())).Returns(1);

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            int id = expenseService.AddExpense(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ExpenseId);
        }

        [TestMethod]
        public void DeleteExpense_Success_Test()
        {
            // Arrange
            ExpenseDTO dto = SampleExpenseDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.DeleteExpense(Moq.It.IsAny<R_Expense>())).Verifiable();

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            expenseService.DeleteExpense(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteExpenseById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.DeleteExpense(Moq.It.IsAny<int>())).Verifiable();

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            expenseService.DeleteExpense(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetExpense_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Expense expense = SampleExpense(id);

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.GetExpense(Moq.It.IsAny<int>())).Returns(expense);

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            ExpenseDTO result = expenseService.GetExpense(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExpenseId);
        }

        [TestMethod]
        public void GetExpenses_Success_Test()
        {
            // Arrange
            R_Expense expense = SampleExpense(1);
            
            IList<R_Expense> list = new List<R_Expense>();
            list.Add(expense);

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.GetExpenses()).Returns(list);

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            var resultList = expenseService.GetExpenses();
            ExpenseDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExpenseId);
        }

        [TestMethod]
        public void GetExpensesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Expense> list = new List<R_Expense>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleExpense(i));
            }

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.GetExpenses(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            var resultList = expenseService.GetExpenses(searchTerm, pageIndex, pageSize);
            ExpenseDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExpenseId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetExpenseListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            string name = null; 
            string description = null; 
            int? responsiblePersonId = null; 
            int? executerPersonId = null; 
            int? documentId = null; 
            int? partnerId = null; 
            System.DateTime? invoiceDateFrom = null; 
            System.DateTime? invoiceDateTo = null; 
            double? amount = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Expense> list = new List<R_Expense>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleExpense(i));
            }

            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.GetExpenseListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<int?>() // responsiblePersonId 
                , Moq.It.IsAny<int?>() // executerPersonId 
                , Moq.It.IsAny<int?>() // documentId 
                , Moq.It.IsAny<int?>() // partnerId 
                , Moq.It.IsAny<System.DateTime?>() // invoiceDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // invoiceDateTo 
                , Moq.It.IsAny<double?>() // amount 
            )).Returns(list);

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            var resultList = expenseService.GetExpenseListAdvancedSearch(
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
            
            ExpenseDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExpenseId);
        }

        [TestMethod]
        public void UpdateExpense_Success_Test()
        {
            // Arrange
            ExpenseDTO dto = SampleExpenseDTO(1);
            
            // create mock for repository
            var mock = new Mock<IExpenseRepository>();
            mock.Setup(s => s.UpdateExpense(Moq.It.IsAny<R_Expense>())).Verifiable();

            // service
            ExpenseService expenseService = new ExpenseService();
            ExpenseService.Repository = mock.Object;

            // Act
            expenseService.UpdateExpense(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Expense SampleExpense(int id = 1)
        {
            R_Expense expense = new R_Expense();

            // int
            expense.ExpenseId = id;
            // int?
            expense.NucleoId = 1;
            // string
            expense.Name = "NameTestValue";
            // string
            expense.Description = "DescriptionTestValue";
            // int?
            expense.ResponsiblePersonId = 1;
            // int?
            expense.ExecuterPersonId = 1;
            // int?
            expense.DocumentId = 1;
            // int?
            expense.PartnerId = 1;
            // System.DateTime?
            expense.InvoiceDate = new System.DateTime();
            // double
            expense.Amount = 1;
            // bool
            expense.IsDeleted = false;
            // int?
            expense.CreateBy = 1;
            // System.DateTime?
            expense.CreateOn = new System.DateTime();
            // int?
            expense.UpdateBy = 1;
            // System.DateTime?
            expense.UpdateOn = new System.DateTime();
            
            return expense;
        }
        
        public static ExpenseDTO SampleExpenseDTO(int id = 1)
        {
            ExpenseDTO expense = new ExpenseDTO();

            // int
            expense.ExpenseId = id;
            // int?
            expense.NucleoId = 1;
            // string
            expense.Name = "NameTestValue";
            // string
            expense.Description = "DescriptionTestValue";
            // int?
            expense.ResponsiblePersonId = 1;
            // int?
            expense.ExecuterPersonId = 1;
            // int?
            expense.DocumentId = 1;
            // int?
            expense.PartnerId = 1;
            // System.DateTime?
            expense.InvoiceDate = new System.DateTime();
            // double
            expense.Amount = 1;
            // bool
            expense.IsDeleted = false;
            // int?
            expense.CreateBy = 1;
            // System.DateTime?
            expense.CreateOn = new System.DateTime();
            // int?
            expense.UpdateBy = 1;
            // System.DateTime?
            expense.UpdateOn = new System.DateTime();
            
            return expense;
        }
        
    }
}

    