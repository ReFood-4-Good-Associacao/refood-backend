
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
    public partial class EquipmentServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddEquipment_Success_Test()
        {
            // Arrange
            EquipmentDTO dto = SampleEquipmentDTO(1);

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.AddEquipment(Moq.It.IsAny<R_Equipment>())).Returns(1);

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            int id = equipmentService.AddEquipment(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.EquipmentId);
        }

        [TestMethod]
        public void DeleteEquipment_Success_Test()
        {
            // Arrange
            EquipmentDTO dto = SampleEquipmentDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.DeleteEquipment(Moq.It.IsAny<R_Equipment>())).Verifiable();

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            equipmentService.DeleteEquipment(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteEquipmentById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.DeleteEquipment(Moq.It.IsAny<int>())).Verifiable();

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            equipmentService.DeleteEquipment(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetEquipment_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Equipment equipment = SampleEquipment(id);

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.GetEquipment(Moq.It.IsAny<int>())).Returns(equipment);

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            EquipmentDTO result = equipmentService.GetEquipment(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EquipmentId);
        }

        [TestMethod]
        public void GetEquipments_Success_Test()
        {
            // Arrange
            R_Equipment equipment = SampleEquipment(1);
            
            IList<R_Equipment> list = new List<R_Equipment>();
            list.Add(equipment);

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.GetEquipments()).Returns(list);

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            var resultList = equipmentService.GetEquipments();
            EquipmentDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EquipmentId);
        }

        [TestMethod]
        public void GetEquipmentsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Equipment> list = new List<R_Equipment>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleEquipment(i));
            }

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.GetEquipments(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            var resultList = equipmentService.GetEquipments(searchTerm, pageIndex, pageSize);
            EquipmentDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EquipmentId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetEquipmentListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            string category = null; 
            int? photo = null; 
            double? quantityInStock = null; 
            double? minimumQuantityNeeded = null; 
            double? pricePerUnit = null; 
            string storageLocation = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Equipment> list = new List<R_Equipment>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleEquipment(i));
            }

            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.GetEquipmentListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<string>() // category 
                , Moq.It.IsAny<int?>() // photo 
                , Moq.It.IsAny<double?>() // quantityInStock 
                , Moq.It.IsAny<double?>() // minimumQuantityNeeded 
                , Moq.It.IsAny<double?>() // pricePerUnit 
                , Moq.It.IsAny<string>() // storageLocation 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            var resultList = equipmentService.GetEquipmentListAdvancedSearch(
                 name 
                , description 
                , category 
                , photo 
                , quantityInStock 
                , minimumQuantityNeeded 
                , pricePerUnit 
                , storageLocation 
                , active 
            );
            
            EquipmentDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EquipmentId);
        }

        [TestMethod]
        public void UpdateEquipment_Success_Test()
        {
            // Arrange
            EquipmentDTO dto = SampleEquipmentDTO(1);
            
            // create mock for repository
            var mock = new Mock<IEquipmentRepository>();
            mock.Setup(s => s.UpdateEquipment(Moq.It.IsAny<R_Equipment>())).Verifiable();

            // service
            EquipmentService equipmentService = new EquipmentService();
            EquipmentService.Repository = mock.Object;

            // Act
            equipmentService.UpdateEquipment(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Equipment SampleEquipment(int id = 1)
        {
            R_Equipment equipment = new R_Equipment();

            // int
            equipment.EquipmentId = id;
            // string
            equipment.Name = "NameTestValue";
            // string
            equipment.Description = "DescriptionTestValue";
            // string
            equipment.Category = "CategoryTestValue";
            // int?
            equipment.Photo = 1;
            // double?
            equipment.QuantityInStock = 1;
            // double?
            equipment.MinimumQuantityNeeded = 1;
            // double?
            equipment.PricePerUnit = 1;
            // string
            equipment.StorageLocation = "StorageLocationTestValue";
            // bool
            equipment.Active = false;
            // bool
            equipment.IsDeleted = false;
            // int?
            equipment.CreateBy = 1;
            // System.DateTime?
            equipment.CreateOn = new System.DateTime();
            // int?
            equipment.UpdateBy = 1;
            // System.DateTime?
            equipment.UpdateOn = new System.DateTime();
            
            return equipment;
        }
        
        public static EquipmentDTO SampleEquipmentDTO(int id = 1)
        {
            EquipmentDTO equipment = new EquipmentDTO();

            // int
            equipment.EquipmentId = id;
            // string
            equipment.Name = "NameTestValue";
            // string
            equipment.Description = "DescriptionTestValue";
            // string
            equipment.Category = "CategoryTestValue";
            // int?
            equipment.Photo = 1;
            // double?
            equipment.QuantityInStock = 1;
            // double?
            equipment.MinimumQuantityNeeded = 1;
            // double?
            equipment.PricePerUnit = 1;
            // string
            equipment.StorageLocation = "StorageLocationTestValue";
            // bool
            equipment.Active = false;
            // bool
            equipment.IsDeleted = false;
            // int?
            equipment.CreateBy = 1;
            // System.DateTime?
            equipment.CreateOn = new System.DateTime();
            // int?
            equipment.UpdateBy = 1;
            // System.DateTime?
            equipment.UpdateOn = new System.DateTime();
            
            return equipment;
        }
        
    }
}

    