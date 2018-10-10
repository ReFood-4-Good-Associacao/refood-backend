
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
    public partial class BeneficiaryServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddBeneficiary_Success_Test()
        {
            // Arrange
            BeneficiaryDTO dto = SampleBeneficiaryDTO(1);

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.AddBeneficiary(Moq.It.IsAny<R_Beneficiary>())).Returns(1);

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            int id = beneficiaryService.AddBeneficiary(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.BeneficiaryId);
        }

        [TestMethod]
        public void DeleteBeneficiary_Success_Test()
        {
            // Arrange
            BeneficiaryDTO dto = SampleBeneficiaryDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.DeleteBeneficiary(Moq.It.IsAny<R_Beneficiary>())).Verifiable();

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            beneficiaryService.DeleteBeneficiary(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteBeneficiaryById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.DeleteBeneficiary(Moq.It.IsAny<int>())).Verifiable();

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            beneficiaryService.DeleteBeneficiary(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetBeneficiary_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Beneficiary beneficiary = SampleBeneficiary(id);

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.GetBeneficiary(Moq.It.IsAny<int>())).Returns(beneficiary);

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            BeneficiaryDTO result = beneficiaryService.GetBeneficiary(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BeneficiaryId);
        }

        [TestMethod]
        public void GetBeneficiarys_Success_Test()
        {
            // Arrange
            R_Beneficiary beneficiary = SampleBeneficiary(1);
            
            IList<R_Beneficiary> list = new List<R_Beneficiary>();
            list.Add(beneficiary);

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.GetBeneficiarys()).Returns(list);

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            var resultList = beneficiaryService.GetBeneficiarys();
            BeneficiaryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BeneficiaryId);
        }

        [TestMethod]
        public void GetBeneficiarysPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Beneficiary> list = new List<R_Beneficiary>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleBeneficiary(i));
            }

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.GetBeneficiarys(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            var resultList = beneficiaryService.GetBeneficiarys(searchTerm, pageIndex, pageSize);
            BeneficiaryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BeneficiaryId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetBeneficiaryListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            int? number = null; 
            int? addressId = null; 
            int? numberOfAdults = null; 
            int? numberOfChildren = null; 
            int? numberOfTupperware = null; 
            int? numberOfSoups = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Beneficiary> list = new List<R_Beneficiary>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleBeneficiary(i));
            }

            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.GetBeneficiaryListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<int?>() // number 
                , Moq.It.IsAny<int?>() // addressId 
                , Moq.It.IsAny<int?>() // numberOfAdults 
                , Moq.It.IsAny<int?>() // numberOfChildren 
                , Moq.It.IsAny<int?>() // numberOfTupperware 
                , Moq.It.IsAny<int?>() // numberOfSoups 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            var resultList = beneficiaryService.GetBeneficiaryListAdvancedSearch(
                 name 
                , number 
                , addressId 
                , numberOfAdults 
                , numberOfChildren 
                , numberOfTupperware 
                , numberOfSoups 
                , description 
                , active 
            );
            
            BeneficiaryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BeneficiaryId);
        }

        [TestMethod]
        public void UpdateBeneficiary_Success_Test()
        {
            // Arrange
            BeneficiaryDTO dto = SampleBeneficiaryDTO(1);
            
            // create mock for repository
            var mock = new Mock<IBeneficiaryRepository>();
            mock.Setup(s => s.UpdateBeneficiary(Moq.It.IsAny<R_Beneficiary>())).Verifiable();

            // service
            BeneficiaryService beneficiaryService = new BeneficiaryService();
            BeneficiaryService.Repository = mock.Object;

            // Act
            beneficiaryService.UpdateBeneficiary(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Beneficiary SampleBeneficiary(int id = 1)
        {
            R_Beneficiary beneficiary = new R_Beneficiary();

            // int
            beneficiary.BeneficiaryId = id;
            // string
            beneficiary.Name = "NameTestValue";
            // int?
            beneficiary.Number = 1;
            // int?
            beneficiary.AddressId = 1;
            // int?
            beneficiary.NumberOfAdults = 1;
            // int?
            beneficiary.NumberOfChildren = 1;
            // int?
            beneficiary.NumberOfTupperware = 1;
            // int?
            beneficiary.NumberOfSoups = 1;
            // string
            beneficiary.Description = "DescriptionTestValue";
            // bool
            beneficiary.Active = false;
            // bool
            beneficiary.IsDeleted = false;
            // int?
            beneficiary.CreateBy = 1;
            // System.DateTime?
            beneficiary.CreateOn = new System.DateTime();
            // int?
            beneficiary.UpdateBy = 1;
            // System.DateTime?
            beneficiary.UpdateOn = new System.DateTime();
            
            return beneficiary;
        }
        
        public static BeneficiaryDTO SampleBeneficiaryDTO(int id = 1)
        {
            BeneficiaryDTO beneficiary = new BeneficiaryDTO();

            // int
            beneficiary.BeneficiaryId = id;
            // string
            beneficiary.Name = "NameTestValue";
            // int?
            beneficiary.Number = 1;
            // int?
            beneficiary.AddressId = 1;
            // int?
            beneficiary.NumberOfAdults = 1;
            // int?
            beneficiary.NumberOfChildren = 1;
            // int?
            beneficiary.NumberOfTupperware = 1;
            // int?
            beneficiary.NumberOfSoups = 1;
            // string
            beneficiary.Description = "DescriptionTestValue";
            // bool
            beneficiary.Active = false;
            // bool
            beneficiary.IsDeleted = false;
            // int?
            beneficiary.CreateBy = 1;
            // System.DateTime?
            beneficiary.CreateOn = new System.DateTime();
            // int?
            beneficiary.UpdateBy = 1;
            // System.DateTime?
            beneficiary.UpdateOn = new System.DateTime();
            
            return beneficiary;
        }
        
    }
}

    