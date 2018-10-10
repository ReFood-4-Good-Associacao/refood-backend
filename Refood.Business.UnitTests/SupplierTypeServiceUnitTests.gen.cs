
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
    public partial class SupplierTypeServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddSupplierType_Success_Test()
        {
            // Arrange
            SupplierTypeDTO dto = SampleSupplierTypeDTO(1);

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.AddSupplierType(Moq.It.IsAny<R_SupplierType>())).Returns(1);

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            int id = supplierTypeService.AddSupplierType(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.SupplierTypeId);
        }

        [TestMethod]
        public void DeleteSupplierType_Success_Test()
        {
            // Arrange
            SupplierTypeDTO dto = SampleSupplierTypeDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.DeleteSupplierType(Moq.It.IsAny<R_SupplierType>())).Verifiable();

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            supplierTypeService.DeleteSupplierType(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteSupplierTypeById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.DeleteSupplierType(Moq.It.IsAny<int>())).Verifiable();

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            supplierTypeService.DeleteSupplierType(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetSupplierType_Success_Test()
        {
            // Arrange
            int id = 1;
            R_SupplierType supplierType = SampleSupplierType(id);

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.GetSupplierType(Moq.It.IsAny<int>())).Returns(supplierType);

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            SupplierTypeDTO result = supplierTypeService.GetSupplierType(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierTypeId);
        }

        [TestMethod]
        public void GetSupplierTypes_Success_Test()
        {
            // Arrange
            R_SupplierType supplierType = SampleSupplierType(1);
            
            IList<R_SupplierType> list = new List<R_SupplierType>();
            list.Add(supplierType);

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.GetSupplierTypes()).Returns(list);

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            var resultList = supplierTypeService.GetSupplierTypes();
            SupplierTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierTypeId);
        }

        [TestMethod]
        public void GetSupplierTypesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_SupplierType> list = new List<R_SupplierType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleSupplierType(i));
            }

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.GetSupplierTypes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            var resultList = supplierTypeService.GetSupplierTypes(searchTerm, pageIndex, pageSize);
            SupplierTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierTypeId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetSupplierTypeListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_SupplierType> list = new List<R_SupplierType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleSupplierType(i));
            }

            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.GetSupplierTypeListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            var resultList = supplierTypeService.GetSupplierTypeListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            SupplierTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.SupplierTypeId);
        }

        [TestMethod]
        public void UpdateSupplierType_Success_Test()
        {
            // Arrange
            SupplierTypeDTO dto = SampleSupplierTypeDTO(1);
            
            // create mock for repository
            var mock = new Mock<ISupplierTypeRepository>();
            mock.Setup(s => s.UpdateSupplierType(Moq.It.IsAny<R_SupplierType>())).Verifiable();

            // service
            SupplierTypeService supplierTypeService = new SupplierTypeService();
            SupplierTypeService.Repository = mock.Object;

            // Act
            supplierTypeService.UpdateSupplierType(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_SupplierType SampleSupplierType(int id = 1)
        {
            R_SupplierType supplierType = new R_SupplierType();

            // int
            supplierType.SupplierTypeId = id;
            // string
            supplierType.Name = "NameTestValue";
            // string
            supplierType.Description = "DescriptionTestValue";
            // bool
            supplierType.Active = false;
            // bool
            supplierType.IsDeleted = false;
            // int?
            supplierType.CreateBy = 1;
            // System.DateTime?
            supplierType.CreateOn = new System.DateTime();
            // int?
            supplierType.UpdateBy = 1;
            // System.DateTime?
            supplierType.UpdateOn = new System.DateTime();
            
            return supplierType;
        }
        
        public static SupplierTypeDTO SampleSupplierTypeDTO(int id = 1)
        {
            SupplierTypeDTO supplierType = new SupplierTypeDTO();

            // int
            supplierType.SupplierTypeId = id;
            // string
            supplierType.Name = "NameTestValue";
            // string
            supplierType.Description = "DescriptionTestValue";
            // bool
            supplierType.Active = false;
            // bool
            supplierType.IsDeleted = false;
            // int?
            supplierType.CreateBy = 1;
            // System.DateTime?
            supplierType.CreateOn = new System.DateTime();
            // int?
            supplierType.UpdateBy = 1;
            // System.DateTime?
            supplierType.UpdateOn = new System.DateTime();
            
            return supplierType;
        }
        
    }
}

    