
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
    public partial class SupplierServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddSupplier_Success_Test()
        {
            // Arrange
            SupplierDTO dto = SampleSupplierDTO(1);

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.AddSupplier(Moq.It.IsAny<R_Supplier>())).Returns(1);

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            int id = supplierService.AddSupplier(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.SupplierId);
        }

        [TestMethod]
        public void DeleteSupplier_Success_Test()
        {
            // Arrange
            SupplierDTO dto = SampleSupplierDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.DeleteSupplier(Moq.It.IsAny<R_Supplier>())).Verifiable();

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            supplierService.DeleteSupplier(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteSupplierById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.DeleteSupplier(Moq.It.IsAny<int>())).Verifiable();

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            supplierService.DeleteSupplier(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetSupplier_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Supplier supplier = SampleSupplier(id);

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.GetSupplier(Moq.It.IsAny<int>())).Returns(supplier);

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            SupplierDTO result = supplierService.GetSupplier(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierId);
        }

        [TestMethod]
        public void GetSuppliers_Success_Test()
        {
            // Arrange
            R_Supplier supplier = SampleSupplier(1);
            
            IList<R_Supplier> list = new List<R_Supplier>();
            list.Add(supplier);

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.GetSuppliers()).Returns(list);

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            var resultList = supplierService.GetSuppliers();
            SupplierDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierId);
        }

        [TestMethod]
        public void GetSuppliersPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Supplier> list = new List<R_Supplier>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleSupplier(i));
            }

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.GetSuppliers(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            var resultList = supplierService.GetSuppliers(searchTerm, pageIndex, pageSize);
            SupplierDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetSupplierListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            int? supplierTypeId = null; 
            string phone = null; 
            string email = null; 
            double? latitude = null; 
            double? longitude = null; 
            string description = null; 
            string website = null; 
            int? addressId = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Supplier> list = new List<R_Supplier>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleSupplier(i));
            }

            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.GetSupplierListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<int?>() // supplierTypeId 
                , Moq.It.IsAny<string>() // phone 
                , Moq.It.IsAny<string>() // email 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<string>() // website 
                , Moq.It.IsAny<int?>() // addressId 
            )).Returns(list);

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            var resultList = supplierService.GetSupplierListAdvancedSearch(
                 name 
                , supplierTypeId 
                , phone 
                , email 
                , latitude 
                , longitude 
                , description 
                , website 
                , addressId 
            );
            
            SupplierDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierId);
        }

        [TestMethod]
        public void UpdateSupplier_Success_Test()
        {
            // Arrange
            SupplierDTO dto = SampleSupplierDTO(1);
            
            // create mock for repository
            var mock = new Mock<ISupplierRepository>();
            mock.Setup(s => s.UpdateSupplier(Moq.It.IsAny<R_Supplier>())).Verifiable();

            // service
            SupplierService supplierService = new SupplierService();
            SupplierService.Repository = mock.Object;

            // Act
            supplierService.UpdateSupplier(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Supplier SampleSupplier(int id = 1)
        {
            R_Supplier supplier = new R_Supplier();

            // int
            supplier.SupplierId = id;
            // string
            supplier.Name = "NameTestValue";
            // int
            supplier.SupplierTypeId = 1;
            // string
            supplier.Phone = "PhoneTestValue";
            // string
            supplier.Email = "EmailTestValue";
            // double?
            supplier.Latitude = 1;
            // double?
            supplier.Longitude = 1;
            // string
            supplier.Description = "DescriptionTestValue";
            // string
            supplier.Website = "WebsiteTestValue";
            // int?
            supplier.AddressId = 1;
            // bool
            supplier.IsDeleted = false;
            // int?
            supplier.CreateBy = 1;
            // System.DateTime?
            supplier.CreateOn = new System.DateTime();
            // int?
            supplier.UpdateBy = 1;
            // System.DateTime?
            supplier.UpdateOn = new System.DateTime();
            
            return supplier;
        }
        
        public static SupplierDTO SampleSupplierDTO(int id = 1)
        {
            SupplierDTO supplier = new SupplierDTO();

            // int
            supplier.SupplierId = id;
            // string
            supplier.Name = "NameTestValue";
            // int
            supplier.SupplierTypeId = 1;
            // string
            supplier.Phone = "PhoneTestValue";
            // string
            supplier.Email = "EmailTestValue";
            // double?
            supplier.Latitude = 1;
            // double?
            supplier.Longitude = 1;
            // string
            supplier.Description = "DescriptionTestValue";
            // string
            supplier.Website = "WebsiteTestValue";
            // int?
            supplier.AddressId = 1;
            // bool
            supplier.IsDeleted = false;
            // int?
            supplier.CreateBy = 1;
            // System.DateTime?
            supplier.CreateOn = new System.DateTime();
            // int?
            supplier.UpdateBy = 1;
            // System.DateTime?
            supplier.UpdateOn = new System.DateTime();
            
            return supplier;
        }
        
    }
}

    