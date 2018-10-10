
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
    public partial class VehicleTypeServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddVehicleType_Success_Test()
        {
            // Arrange
            VehicleTypeDTO dto = SampleVehicleTypeDTO(1);

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.AddVehicleType(Moq.It.IsAny<R_VehicleType>())).Returns(1);

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            int id = vehicleTypeService.AddVehicleType(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.VehicleTypeId);
        }

        [TestMethod]
        public void DeleteVehicleType_Success_Test()
        {
            // Arrange
            VehicleTypeDTO dto = SampleVehicleTypeDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.DeleteVehicleType(Moq.It.IsAny<R_VehicleType>())).Verifiable();

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            vehicleTypeService.DeleteVehicleType(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteVehicleTypeById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.DeleteVehicleType(Moq.It.IsAny<int>())).Verifiable();

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            vehicleTypeService.DeleteVehicleType(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetVehicleType_Success_Test()
        {
            // Arrange
            int id = 1;
            R_VehicleType vehicleType = SampleVehicleType(id);

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.GetVehicleType(Moq.It.IsAny<int>())).Returns(vehicleType);

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            VehicleTypeDTO result = vehicleTypeService.GetVehicleType(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleTypeId);
        }

        [TestMethod]
        public void GetVehicleTypes_Success_Test()
        {
            // Arrange
            R_VehicleType vehicleType = SampleVehicleType(1);
            
            IList<R_VehicleType> list = new List<R_VehicleType>();
            list.Add(vehicleType);

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.GetVehicleTypes()).Returns(list);

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            var resultList = vehicleTypeService.GetVehicleTypes();
            VehicleTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleTypeId);
        }

        [TestMethod]
        public void GetVehicleTypesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_VehicleType> list = new List<R_VehicleType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleVehicleType(i));
            }

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.GetVehicleTypes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            var resultList = vehicleTypeService.GetVehicleTypes(searchTerm, pageIndex, pageSize);
            VehicleTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleTypeId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetVehicleTypeListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_VehicleType> list = new List<R_VehicleType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleVehicleType(i));
            }

            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.GetVehicleTypeListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            var resultList = vehicleTypeService.GetVehicleTypeListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            VehicleTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleTypeId);
        }

        [TestMethod]
        public void UpdateVehicleType_Success_Test()
        {
            // Arrange
            VehicleTypeDTO dto = SampleVehicleTypeDTO(1);
            
            // create mock for repository
            var mock = new Mock<IVehicleTypeRepository>();
            mock.Setup(s => s.UpdateVehicleType(Moq.It.IsAny<R_VehicleType>())).Verifiable();

            // service
            VehicleTypeService vehicleTypeService = new VehicleTypeService();
            VehicleTypeService.Repository = mock.Object;

            // Act
            vehicleTypeService.UpdateVehicleType(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_VehicleType SampleVehicleType(int id = 1)
        {
            R_VehicleType vehicleType = new R_VehicleType();

            // int
            vehicleType.VehicleTypeId = id;
            // string
            vehicleType.Name = "NameTestValue";
            // string
            vehicleType.Description = "DescriptionTestValue";
            // bool
            vehicleType.Active = false;
            // bool
            vehicleType.IsDeleted = false;
            // int?
            vehicleType.CreateBy = 1;
            // System.DateTime?
            vehicleType.CreateOn = new System.DateTime();
            // int?
            vehicleType.UpdateBy = 1;
            // System.DateTime?
            vehicleType.UpdateOn = new System.DateTime();
            
            return vehicleType;
        }
        
        public static VehicleTypeDTO SampleVehicleTypeDTO(int id = 1)
        {
            VehicleTypeDTO vehicleType = new VehicleTypeDTO();

            // int
            vehicleType.VehicleTypeId = id;
            // string
            vehicleType.Name = "NameTestValue";
            // string
            vehicleType.Description = "DescriptionTestValue";
            // bool
            vehicleType.Active = false;
            // bool
            vehicleType.IsDeleted = false;
            // int?
            vehicleType.CreateBy = 1;
            // System.DateTime?
            vehicleType.CreateOn = new System.DateTime();
            // int?
            vehicleType.UpdateBy = 1;
            // System.DateTime?
            vehicleType.UpdateOn = new System.DateTime();
            
            return vehicleType;
        }
        
    }
}

    