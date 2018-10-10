
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
    public partial class ParishServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddParish_Success_Test()
        {
            // Arrange
            ParishDTO dto = SampleParishDTO(1);

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.AddParish(Moq.It.IsAny<R_Parish>())).Returns(1);

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            int id = parishService.AddParish(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ParishId);
        }

        [TestMethod]
        public void DeleteParish_Success_Test()
        {
            // Arrange
            ParishDTO dto = SampleParishDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.DeleteParish(Moq.It.IsAny<R_Parish>())).Verifiable();

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            parishService.DeleteParish(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteParishById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.DeleteParish(Moq.It.IsAny<int>())).Verifiable();

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            parishService.DeleteParish(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetParish_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Parish parish = SampleParish(id);

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.GetParish(Moq.It.IsAny<int>())).Returns(parish);

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            ParishDTO result = parishService.GetParish(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ParishId);
        }

        [TestMethod]
        public void GetParishs_Success_Test()
        {
            // Arrange
            R_Parish parish = SampleParish(1);
            
            IList<R_Parish> list = new List<R_Parish>();
            list.Add(parish);

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.GetParishs()).Returns(list);

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            var resultList = parishService.GetParishs();
            ParishDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ParishId);
        }

        [TestMethod]
        public void GetParishsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Parish> list = new List<R_Parish>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleParish(i));
            }

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.GetParishs(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            var resultList = parishService.GetParishs(searchTerm, pageIndex, pageSize);
            ParishDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ParishId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetParishListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? countyId = null; 
            int? districtId = null; 
            int? countryId = null; 
            string name = null; 
            string code = null; 
            double? latitude = null; 
            double? longitude = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Parish> list = new List<R_Parish>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleParish(i));
            }

            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.GetParishListAdvancedSearch(
                 Moq.It.IsAny<int?>() // countyId 
                , Moq.It.IsAny<int?>() // districtId 
                , Moq.It.IsAny<int?>() // countryId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // code 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            var resultList = parishService.GetParishListAdvancedSearch(
                 countyId 
                , districtId 
                , countryId 
                , name 
                , code 
                , latitude 
                , longitude 
                , active 
            );
            
            ParishDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ParishId);
        }

        [TestMethod]
        public void UpdateParish_Success_Test()
        {
            // Arrange
            ParishDTO dto = SampleParishDTO(1);
            
            // create mock for repository
            var mock = new Mock<IParishRepository>();
            mock.Setup(s => s.UpdateParish(Moq.It.IsAny<R_Parish>())).Verifiable();

            // service
            ParishService parishService = new ParishService();
            ParishService.Repository = mock.Object;

            // Act
            parishService.UpdateParish(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Parish SampleParish(int id = 1)
        {
            R_Parish parish = new R_Parish();

            // int
            parish.ParishId = id;
            // int?
            parish.CountyId = 1;
            // int?
            parish.DistrictId = 1;
            // int?
            parish.CountryId = 1;
            // string
            parish.Name = "NameTestValue";
            // string
            parish.Code = "CodeTestValue";
            // double?
            parish.Latitude = 1;
            // double?
            parish.Longitude = 1;
            // bool
            parish.Active = false;
            // bool
            parish.IsDeleted = false;
            // int?
            parish.CreateBy = 1;
            // System.DateTime?
            parish.CreateOn = new System.DateTime();
            // int?
            parish.UpdateBy = 1;
            // System.DateTime?
            parish.UpdateOn = new System.DateTime();
            
            return parish;
        }
        
        public static ParishDTO SampleParishDTO(int id = 1)
        {
            ParishDTO parish = new ParishDTO();

            // int
            parish.ParishId = id;
            // int?
            parish.CountyId = 1;
            // int?
            parish.DistrictId = 1;
            // int?
            parish.CountryId = 1;
            // string
            parish.Name = "NameTestValue";
            // string
            parish.Code = "CodeTestValue";
            // double?
            parish.Latitude = 1;
            // double?
            parish.Longitude = 1;
            // bool
            parish.Active = false;
            // bool
            parish.IsDeleted = false;
            // int?
            parish.CreateBy = 1;
            // System.DateTime?
            parish.CreateOn = new System.DateTime();
            // int?
            parish.UpdateBy = 1;
            // System.DateTime?
            parish.UpdateOn = new System.DateTime();
            
            return parish;
        }
        
    }
}

    