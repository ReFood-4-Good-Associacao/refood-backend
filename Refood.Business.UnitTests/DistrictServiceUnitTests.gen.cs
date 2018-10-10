
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
    public partial class DistrictServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddDistrict_Success_Test()
        {
            // Arrange
            DistrictDTO dto = SampleDistrictDTO(1);

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.AddDistrict(Moq.It.IsAny<R_District>())).Returns(1);

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            int id = districtService.AddDistrict(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.DistrictId);
        }

        [TestMethod]
        public void DeleteDistrict_Success_Test()
        {
            // Arrange
            DistrictDTO dto = SampleDistrictDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.DeleteDistrict(Moq.It.IsAny<R_District>())).Verifiable();

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            districtService.DeleteDistrict(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteDistrictById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.DeleteDistrict(Moq.It.IsAny<int>())).Verifiable();

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            districtService.DeleteDistrict(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetDistrict_Success_Test()
        {
            // Arrange
            int id = 1;
            R_District district = SampleDistrict(id);

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.GetDistrict(Moq.It.IsAny<int>())).Returns(district);

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            DistrictDTO result = districtService.GetDistrict(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DistrictId);
        }

        [TestMethod]
        public void GetDistricts_Success_Test()
        {
            // Arrange
            R_District district = SampleDistrict(1);
            
            IList<R_District> list = new List<R_District>();
            list.Add(district);

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.GetDistricts()).Returns(list);

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            var resultList = districtService.GetDistricts();
            DistrictDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DistrictId);
        }

        [TestMethod]
        public void GetDistrictsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_District> list = new List<R_District>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDistrict(i));
            }

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.GetDistricts(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            var resultList = districtService.GetDistricts(searchTerm, pageIndex, pageSize);
            DistrictDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DistrictId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetDistrictListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? countryId = null; 
            string name = null; 
            string code = null; 
            double? latitude = null; 
            double? longitude = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_District> list = new List<R_District>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDistrict(i));
            }

            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.GetDistrictListAdvancedSearch(
                 Moq.It.IsAny<int?>() // countryId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // code 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            var resultList = districtService.GetDistrictListAdvancedSearch(
                 countryId 
                , name 
                , code 
                , latitude 
                , longitude 
                , active 
            );
            
            DistrictDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DistrictId);
        }

        [TestMethod]
        public void UpdateDistrict_Success_Test()
        {
            // Arrange
            DistrictDTO dto = SampleDistrictDTO(1);
            
            // create mock for repository
            var mock = new Mock<IDistrictRepository>();
            mock.Setup(s => s.UpdateDistrict(Moq.It.IsAny<R_District>())).Verifiable();

            // service
            DistrictService districtService = new DistrictService();
            DistrictService.Repository = mock.Object;

            // Act
            districtService.UpdateDistrict(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_District SampleDistrict(int id = 1)
        {
            R_District district = new R_District();

            // int
            district.DistrictId = id;
            // int?
            district.CountryId = 1;
            // string
            district.Name = "NameTestValue";
            // string
            district.Code = "CodeTestValue";
            // double?
            district.Latitude = 1;
            // double?
            district.Longitude = 1;
            // bool
            district.Active = false;
            // bool
            district.IsDeleted = false;
            // int?
            district.CreateBy = 1;
            // System.DateTime?
            district.CreateOn = new System.DateTime();
            // int?
            district.UpdateBy = 1;
            // System.DateTime?
            district.UpdateOn = new System.DateTime();
            
            return district;
        }
        
        public static DistrictDTO SampleDistrictDTO(int id = 1)
        {
            DistrictDTO district = new DistrictDTO();

            // int
            district.DistrictId = id;
            // int?
            district.CountryId = 1;
            // string
            district.Name = "NameTestValue";
            // string
            district.Code = "CodeTestValue";
            // double?
            district.Latitude = 1;
            // double?
            district.Longitude = 1;
            // bool
            district.Active = false;
            // bool
            district.IsDeleted = false;
            // int?
            district.CreateBy = 1;
            // System.DateTime?
            district.CreateOn = new System.DateTime();
            // int?
            district.UpdateBy = 1;
            // System.DateTime?
            district.UpdateOn = new System.DateTime();
            
            return district;
        }
        
    }
}

    