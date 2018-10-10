
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
    public partial class AddressServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddAddress_Success_Test()
        {
            // Arrange
            AddressDTO dto = SampleAddressDTO(1);

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.AddAddress(Moq.It.IsAny<R_Address>())).Returns(1);

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            int id = addressService.AddAddress(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.AddressId);
        }

        [TestMethod]
        public void DeleteAddress_Success_Test()
        {
            // Arrange
            AddressDTO dto = SampleAddressDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.DeleteAddress(Moq.It.IsAny<R_Address>())).Verifiable();

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            addressService.DeleteAddress(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteAddressById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.DeleteAddress(Moq.It.IsAny<int>())).Verifiable();

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            addressService.DeleteAddress(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetAddress_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Address address = SampleAddress(id);

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.GetAddress(Moq.It.IsAny<int>())).Returns(address);

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            AddressDTO result = addressService.GetAddress(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.AddressId);
        }

        [TestMethod]
        public void GetAddresss_Success_Test()
        {
            // Arrange
            R_Address address = SampleAddress(1);
            
            IList<R_Address> list = new List<R_Address>();
            list.Add(address);

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.GetAddresss()).Returns(list);

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            var resultList = addressService.GetAddresss();
            AddressDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.AddressId);
        }

        [TestMethod]
        public void GetAddresssPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Address> list = new List<R_Address>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleAddress(i));
            }

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.GetAddresss(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            var resultList = addressService.GetAddresss(searchTerm, pageIndex, pageSize);
            AddressDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.AddressId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetAddressListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string addressFirstLine = null; 
            string addressSecondLine = null; 
            int? countryId = null; 
            int? districtId = null; 
            int? countyId = null; 
            int? parishId = null; 
            string zipCode = null; 
            double? latitude = null; 
            double? longitude = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Address> list = new List<R_Address>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleAddress(i));
            }

            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.GetAddressListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // addressFirstLine 
                , Moq.It.IsAny<string>() // addressSecondLine 
                , Moq.It.IsAny<int?>() // countryId 
                , Moq.It.IsAny<int?>() // districtId 
                , Moq.It.IsAny<int?>() // countyId 
                , Moq.It.IsAny<int?>() // parishId 
                , Moq.It.IsAny<string>() // zipCode 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            var resultList = addressService.GetAddressListAdvancedSearch(
                 name 
                , addressFirstLine 
                , addressSecondLine 
                , countryId 
                , districtId 
                , countyId 
                , parishId 
                , zipCode 
                , latitude 
                , longitude 
                , active 
            );
            
            AddressDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.AddressId);
        }

        [TestMethod]
        public void UpdateAddress_Success_Test()
        {
            // Arrange
            AddressDTO dto = SampleAddressDTO(1);
            
            // create mock for repository
            var mock = new Mock<IAddressRepository>();
            mock.Setup(s => s.UpdateAddress(Moq.It.IsAny<R_Address>())).Verifiable();

            // service
            AddressService addressService = new AddressService();
            AddressService.Repository = mock.Object;

            // Act
            addressService.UpdateAddress(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Address SampleAddress(int id = 1)
        {
            R_Address address = new R_Address();

            // int
            address.AddressId = id;
            // string
            address.Name = "NameTestValue";
            // string
            address.AddressFirstLine = "AddressFirstLineTestValue";
            // string
            address.AddressSecondLine = "AddressSecondLineTestValue";
            // int?
            address.CountryId = 1;
            // int?
            address.DistrictId = 1;
            // int?
            address.CountyId = 1;
            // int?
            address.ParishId = 1;
            // string
            address.ZipCode = "ZipCodeTestValue";
            // double?
            address.Latitude = 1;
            // double?
            address.Longitude = 1;
            // bool
            address.Active = false;
            // bool
            address.IsDeleted = false;
            // int?
            address.CreateBy = 1;
            // System.DateTime?
            address.CreateOn = new System.DateTime();
            // int?
            address.UpdateBy = 1;
            // System.DateTime?
            address.UpdateOn = new System.DateTime();
            
            return address;
        }
        
        public static AddressDTO SampleAddressDTO(int id = 1)
        {
            AddressDTO address = new AddressDTO();

            // int
            address.AddressId = id;
            // string
            address.Name = "NameTestValue";
            // string
            address.AddressFirstLine = "AddressFirstLineTestValue";
            // string
            address.AddressSecondLine = "AddressSecondLineTestValue";
            // int?
            address.CountryId = 1;
            // int?
            address.DistrictId = 1;
            // int?
            address.CountyId = 1;
            // int?
            address.ParishId = 1;
            // string
            address.ZipCode = "ZipCodeTestValue";
            // double?
            address.Latitude = 1;
            // double?
            address.Longitude = 1;
            // bool
            address.Active = false;
            // bool
            address.IsDeleted = false;
            // int?
            address.CreateBy = 1;
            // System.DateTime?
            address.CreateOn = new System.DateTime();
            // int?
            address.UpdateBy = 1;
            // System.DateTime?
            address.UpdateOn = new System.DateTime();
            
            return address;
        }
        
    }
}

    