
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
    public partial class DeliveryReportMessageTypeServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddDeliveryReportMessageType_Success_Test()
        {
            // Arrange
            DeliveryReportMessageTypeDTO dto = SampleDeliveryReportMessageTypeDTO(1);

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.AddDeliveryReportMessageType(Moq.It.IsAny<R_DeliveryReportMessageType>())).Returns(1);

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            int id = deliveryReportMessageTypeService.AddDeliveryReportMessageType(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.DeliveryReportMessageTypeId);
        }

        [TestMethod]
        public void DeleteDeliveryReportMessageType_Success_Test()
        {
            // Arrange
            DeliveryReportMessageTypeDTO dto = SampleDeliveryReportMessageTypeDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.DeleteDeliveryReportMessageType(Moq.It.IsAny<R_DeliveryReportMessageType>())).Verifiable();

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            deliveryReportMessageTypeService.DeleteDeliveryReportMessageType(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteDeliveryReportMessageTypeById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.DeleteDeliveryReportMessageType(Moq.It.IsAny<int>())).Verifiable();

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            deliveryReportMessageTypeService.DeleteDeliveryReportMessageType(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetDeliveryReportMessageType_Success_Test()
        {
            // Arrange
            int id = 1;
            R_DeliveryReportMessageType deliveryReportMessageType = SampleDeliveryReportMessageType(id);

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.GetDeliveryReportMessageType(Moq.It.IsAny<int>())).Returns(deliveryReportMessageType);

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            DeliveryReportMessageTypeDTO result = deliveryReportMessageTypeService.GetDeliveryReportMessageType(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageTypeId);
        }

        [TestMethod]
        public void GetDeliveryReportMessageTypes_Success_Test()
        {
            // Arrange
            R_DeliveryReportMessageType deliveryReportMessageType = SampleDeliveryReportMessageType(1);
            
            IList<R_DeliveryReportMessageType> list = new List<R_DeliveryReportMessageType>();
            list.Add(deliveryReportMessageType);

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.GetDeliveryReportMessageTypes()).Returns(list);

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportMessageTypeService.GetDeliveryReportMessageTypes();
            DeliveryReportMessageTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageTypeId);
        }

        [TestMethod]
        public void GetDeliveryReportMessageTypesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_DeliveryReportMessageType> list = new List<R_DeliveryReportMessageType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDeliveryReportMessageType(i));
            }

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.GetDeliveryReportMessageTypes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportMessageTypeService.GetDeliveryReportMessageTypes(searchTerm, pageIndex, pageSize);
            DeliveryReportMessageTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageTypeId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetDeliveryReportMessageTypeListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_DeliveryReportMessageType> list = new List<R_DeliveryReportMessageType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDeliveryReportMessageType(i));
            }

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.GetDeliveryReportMessageTypeListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportMessageTypeService.GetDeliveryReportMessageTypeListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            DeliveryReportMessageTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageTypeId);
        }

        [TestMethod]
        public void UpdateDeliveryReportMessageType_Success_Test()
        {
            // Arrange
            DeliveryReportMessageTypeDTO dto = SampleDeliveryReportMessageTypeDTO(1);
            
            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageTypeRepository>();
            mock.Setup(s => s.UpdateDeliveryReportMessageType(Moq.It.IsAny<R_DeliveryReportMessageType>())).Verifiable();

            // service
            DeliveryReportMessageTypeService deliveryReportMessageTypeService = new DeliveryReportMessageTypeService();
            DeliveryReportMessageTypeService.Repository = mock.Object;

            // Act
            deliveryReportMessageTypeService.UpdateDeliveryReportMessageType(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_DeliveryReportMessageType SampleDeliveryReportMessageType(int id = 1)
        {
            R_DeliveryReportMessageType deliveryReportMessageType = new R_DeliveryReportMessageType();

            // int
            deliveryReportMessageType.DeliveryReportMessageTypeId = id;
            // string
            deliveryReportMessageType.Name = "NameTestValue";
            // string
            deliveryReportMessageType.Description = "DescriptionTestValue";
            // bool
            deliveryReportMessageType.Active = false;
            // bool
            deliveryReportMessageType.IsDeleted = false;
            // int?
            deliveryReportMessageType.CreateBy = 1;
            // System.DateTime?
            deliveryReportMessageType.CreateOn = new System.DateTime();
            // int?
            deliveryReportMessageType.UpdateBy = 1;
            // System.DateTime?
            deliveryReportMessageType.UpdateOn = new System.DateTime();
            
            return deliveryReportMessageType;
        }
        
        public static DeliveryReportMessageTypeDTO SampleDeliveryReportMessageTypeDTO(int id = 1)
        {
            DeliveryReportMessageTypeDTO deliveryReportMessageType = new DeliveryReportMessageTypeDTO();

            // int
            deliveryReportMessageType.DeliveryReportMessageTypeId = id;
            // string
            deliveryReportMessageType.Name = "NameTestValue";
            // string
            deliveryReportMessageType.Description = "DescriptionTestValue";
            // bool
            deliveryReportMessageType.Active = false;
            // bool
            deliveryReportMessageType.IsDeleted = false;
            // int?
            deliveryReportMessageType.CreateBy = 1;
            // System.DateTime?
            deliveryReportMessageType.CreateOn = new System.DateTime();
            // int?
            deliveryReportMessageType.UpdateBy = 1;
            // System.DateTime?
            deliveryReportMessageType.UpdateOn = new System.DateTime();
            
            return deliveryReportMessageType;
        }
        
    }
}

    