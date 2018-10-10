
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
    public partial class DeliveryReportMessageServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddDeliveryReportMessage_Success_Test()
        {
            // Arrange
            DeliveryReportMessageDTO dto = SampleDeliveryReportMessageDTO(1);

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.AddDeliveryReportMessage(Moq.It.IsAny<R_DeliveryReportMessage>())).Returns(1);

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            int id = deliveryReportMessageService.AddDeliveryReportMessage(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.DeliveryReportMessageId);
        }

        [TestMethod]
        public void DeleteDeliveryReportMessage_Success_Test()
        {
            // Arrange
            DeliveryReportMessageDTO dto = SampleDeliveryReportMessageDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.DeleteDeliveryReportMessage(Moq.It.IsAny<R_DeliveryReportMessage>())).Verifiable();

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            deliveryReportMessageService.DeleteDeliveryReportMessage(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteDeliveryReportMessageById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.DeleteDeliveryReportMessage(Moq.It.IsAny<int>())).Verifiable();

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            deliveryReportMessageService.DeleteDeliveryReportMessage(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetDeliveryReportMessage_Success_Test()
        {
            // Arrange
            int id = 1;
            R_DeliveryReportMessage deliveryReportMessage = SampleDeliveryReportMessage(id);

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.GetDeliveryReportMessage(Moq.It.IsAny<int>())).Returns(deliveryReportMessage);

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            DeliveryReportMessageDTO result = deliveryReportMessageService.GetDeliveryReportMessage(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageId);
        }

        [TestMethod]
        public void GetDeliveryReportMessages_Success_Test()
        {
            // Arrange
            R_DeliveryReportMessage deliveryReportMessage = SampleDeliveryReportMessage(1);
            
            IList<R_DeliveryReportMessage> list = new List<R_DeliveryReportMessage>();
            list.Add(deliveryReportMessage);

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.GetDeliveryReportMessages()).Returns(list);

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportMessageService.GetDeliveryReportMessages();
            DeliveryReportMessageDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageId);
        }

        [TestMethod]
        public void GetDeliveryReportMessagesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_DeliveryReportMessage> list = new List<R_DeliveryReportMessage>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDeliveryReportMessage(i));
            }

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.GetDeliveryReportMessages(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportMessageService.GetDeliveryReportMessages(searchTerm, pageIndex, pageSize);
            DeliveryReportMessageDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetDeliveryReportMessageListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? deliveryReportMessageTypeId = null; 
            string message = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_DeliveryReportMessage> list = new List<R_DeliveryReportMessage>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDeliveryReportMessage(i));
            }

            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.GetDeliveryReportMessageListAdvancedSearch(
                 Moq.It.IsAny<int?>() // deliveryReportMessageTypeId 
                , Moq.It.IsAny<string>() // message 
            )).Returns(list);

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportMessageService.GetDeliveryReportMessageListAdvancedSearch(
                 deliveryReportMessageTypeId 
                , message 
            );
            
            DeliveryReportMessageDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportMessageId);
        }

        [TestMethod]
        public void UpdateDeliveryReportMessage_Success_Test()
        {
            // Arrange
            DeliveryReportMessageDTO dto = SampleDeliveryReportMessageDTO(1);
            
            // create mock for repository
            var mock = new Mock<IDeliveryReportMessageRepository>();
            mock.Setup(s => s.UpdateDeliveryReportMessage(Moq.It.IsAny<R_DeliveryReportMessage>())).Verifiable();

            // service
            DeliveryReportMessageService deliveryReportMessageService = new DeliveryReportMessageService();
            DeliveryReportMessageService.Repository = mock.Object;

            // Act
            deliveryReportMessageService.UpdateDeliveryReportMessage(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_DeliveryReportMessage SampleDeliveryReportMessage(int id = 1)
        {
            R_DeliveryReportMessage deliveryReportMessage = new R_DeliveryReportMessage();

            // int
            deliveryReportMessage.DeliveryReportMessageId = id;
            // int
            deliveryReportMessage.DeliveryReportMessageTypeId = 1;
            // string
            deliveryReportMessage.Message = "MessageTestValue";
            // bool
            deliveryReportMessage.IsDeleted = false;
            // int?
            deliveryReportMessage.CreateBy = 1;
            // System.DateTime?
            deliveryReportMessage.CreateOn = new System.DateTime();
            // int?
            deliveryReportMessage.UpdateBy = 1;
            // System.DateTime?
            deliveryReportMessage.UpdateOn = new System.DateTime();
            
            return deliveryReportMessage;
        }
        
        public static DeliveryReportMessageDTO SampleDeliveryReportMessageDTO(int id = 1)
        {
            DeliveryReportMessageDTO deliveryReportMessage = new DeliveryReportMessageDTO();

            // int
            deliveryReportMessage.DeliveryReportMessageId = id;
            // int
            deliveryReportMessage.DeliveryReportMessageTypeId = 1;
            // string
            deliveryReportMessage.Message = "MessageTestValue";
            // bool
            deliveryReportMessage.IsDeleted = false;
            // int?
            deliveryReportMessage.CreateBy = 1;
            // System.DateTime?
            deliveryReportMessage.CreateOn = new System.DateTime();
            // int?
            deliveryReportMessage.UpdateBy = 1;
            // System.DateTime?
            deliveryReportMessage.UpdateOn = new System.DateTime();
            
            return deliveryReportMessage;
        }
        
    }
}

    