
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
    public partial class ContributionMonetaryServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddContributionMonetary_Success_Test()
        {
            // Arrange
            ContributionMonetaryDTO dto = SampleContributionMonetaryDTO(1);

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.AddContributionMonetary(Moq.It.IsAny<R_ContributionMonetary>())).Returns(1);

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            int id = contributionMonetaryService.AddContributionMonetary(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ContributionMonetaryId);
        }

        [TestMethod]
        public void DeleteContributionMonetary_Success_Test()
        {
            // Arrange
            ContributionMonetaryDTO dto = SampleContributionMonetaryDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.DeleteContributionMonetary(Moq.It.IsAny<R_ContributionMonetary>())).Verifiable();

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            contributionMonetaryService.DeleteContributionMonetary(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteContributionMonetaryById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.DeleteContributionMonetary(Moq.It.IsAny<int>())).Verifiable();

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            contributionMonetaryService.DeleteContributionMonetary(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetContributionMonetary_Success_Test()
        {
            // Arrange
            int id = 1;
            R_ContributionMonetary contributionMonetary = SampleContributionMonetary(id);

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.GetContributionMonetary(Moq.It.IsAny<int>())).Returns(contributionMonetary);

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            ContributionMonetaryDTO result = contributionMonetaryService.GetContributionMonetary(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryId);
        }

        [TestMethod]
        public void GetContributionMonetarys_Success_Test()
        {
            // Arrange
            R_ContributionMonetary contributionMonetary = SampleContributionMonetary(1);
            
            IList<R_ContributionMonetary> list = new List<R_ContributionMonetary>();
            list.Add(contributionMonetary);

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.GetContributionMonetarys()).Returns(list);

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            var resultList = contributionMonetaryService.GetContributionMonetarys();
            ContributionMonetaryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryId);
        }

        [TestMethod]
        public void GetContributionMonetarysPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionMonetary> list = new List<R_ContributionMonetary>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionMonetary(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.GetContributionMonetarys(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            var resultList = contributionMonetaryService.GetContributionMonetarys(searchTerm, pageIndex, pageSize);
            ContributionMonetaryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetContributionMonetaryListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            int? responsiblePersonId = null; 
            int? documentId = null; 
            int? partnerId = null; 
            System.DateTime? contributionDateFrom = null; 
            System.DateTime? contributionDateTo = null; 
            double? amount = null; 
            string contactPerson = null; 
            string ibanOrigin = null; 
            string bicSwiftOrigin = null; 
            string ibanDestination = null; 
            string bicSwiftDestination = null; 
            string fiscalNumber = null; 
            int? contributionChannelId = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionMonetary> list = new List<R_ContributionMonetary>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionMonetary(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.GetContributionMonetaryListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<int?>() // responsiblePersonId 
                , Moq.It.IsAny<int?>() // documentId 
                , Moq.It.IsAny<int?>() // partnerId 
                , Moq.It.IsAny<System.DateTime?>() // contributionDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // contributionDateTo 
                , Moq.It.IsAny<double?>() // amount 
                , Moq.It.IsAny<string>() // contactPerson 
                , Moq.It.IsAny<string>() // ibanOrigin 
                , Moq.It.IsAny<string>() // bicSwiftOrigin 
                , Moq.It.IsAny<string>() // ibanDestination 
                , Moq.It.IsAny<string>() // bicSwiftDestination 
                , Moq.It.IsAny<string>() // fiscalNumber 
                , Moq.It.IsAny<int?>() // contributionChannelId 
            )).Returns(list);

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            var resultList = contributionMonetaryService.GetContributionMonetaryListAdvancedSearch(
                 nucleoId 
                , responsiblePersonId 
                , documentId 
                , partnerId 
                , contributionDateFrom 
                , contributionDateTo 
                , amount 
                , contactPerson 
                , ibanOrigin 
                , bicSwiftOrigin 
                , ibanDestination 
                , bicSwiftDestination 
                , fiscalNumber 
                , contributionChannelId 
            );
            
            ContributionMonetaryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryId);
        }

        [TestMethod]
        public void UpdateContributionMonetary_Success_Test()
        {
            // Arrange
            ContributionMonetaryDTO dto = SampleContributionMonetaryDTO(1);
            
            // create mock for repository
            var mock = new Mock<IContributionMonetaryRepository>();
            mock.Setup(s => s.UpdateContributionMonetary(Moq.It.IsAny<R_ContributionMonetary>())).Verifiable();

            // service
            ContributionMonetaryService contributionMonetaryService = new ContributionMonetaryService();
            ContributionMonetaryService.Repository = mock.Object;

            // Act
            contributionMonetaryService.UpdateContributionMonetary(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_ContributionMonetary SampleContributionMonetary(int id = 1)
        {
            R_ContributionMonetary contributionMonetary = new R_ContributionMonetary();

            // int
            contributionMonetary.ContributionMonetaryId = id;
            // int?
            contributionMonetary.NucleoId = 1;
            // int?
            contributionMonetary.ResponsiblePersonId = 1;
            // int?
            contributionMonetary.DocumentId = 1;
            // int?
            contributionMonetary.PartnerId = 1;
            // System.DateTime?
            contributionMonetary.ContributionDate = new System.DateTime();
            // double
            contributionMonetary.Amount = 1;
            // string
            contributionMonetary.ContactPerson = "ContactPersonTestValue";
            // string
            contributionMonetary.IbanOrigin = "IbanOriginTestValue";
            // string
            contributionMonetary.BicSwiftOrigin = "BicSwiftOriginTestValue";
            // string
            contributionMonetary.IbanDestination = "IbanDestinationTestValue";
            // string
            contributionMonetary.BicSwiftDestination = "BicSwiftDestinationTestValue";
            // string
            contributionMonetary.FiscalNumber = "FiscalNumberTestValue";
            // int?
            contributionMonetary.ContributionChannelId = 1;
            // bool
            contributionMonetary.IsDeleted = false;
            // int?
            contributionMonetary.CreateBy = 1;
            // System.DateTime?
            contributionMonetary.CreateOn = new System.DateTime();
            // int?
            contributionMonetary.UpdateBy = 1;
            // System.DateTime?
            contributionMonetary.UpdateOn = new System.DateTime();
            
            return contributionMonetary;
        }
        
        public static ContributionMonetaryDTO SampleContributionMonetaryDTO(int id = 1)
        {
            ContributionMonetaryDTO contributionMonetary = new ContributionMonetaryDTO();

            // int
            contributionMonetary.ContributionMonetaryId = id;
            // int?
            contributionMonetary.NucleoId = 1;
            // int?
            contributionMonetary.ResponsiblePersonId = 1;
            // int?
            contributionMonetary.DocumentId = 1;
            // int?
            contributionMonetary.PartnerId = 1;
            // System.DateTime?
            contributionMonetary.ContributionDate = new System.DateTime();
            // double
            contributionMonetary.Amount = 1;
            // string
            contributionMonetary.ContactPerson = "ContactPersonTestValue";
            // string
            contributionMonetary.IbanOrigin = "IbanOriginTestValue";
            // string
            contributionMonetary.BicSwiftOrigin = "BicSwiftOriginTestValue";
            // string
            contributionMonetary.IbanDestination = "IbanDestinationTestValue";
            // string
            contributionMonetary.BicSwiftDestination = "BicSwiftDestinationTestValue";
            // string
            contributionMonetary.FiscalNumber = "FiscalNumberTestValue";
            // int?
            contributionMonetary.ContributionChannelId = 1;
            // bool
            contributionMonetary.IsDeleted = false;
            // int?
            contributionMonetary.CreateBy = 1;
            // System.DateTime?
            contributionMonetary.CreateOn = new System.DateTime();
            // int?
            contributionMonetary.UpdateBy = 1;
            // System.DateTime?
            contributionMonetary.UpdateOn = new System.DateTime();
            
            return contributionMonetary;
        }
        
    }
}

    