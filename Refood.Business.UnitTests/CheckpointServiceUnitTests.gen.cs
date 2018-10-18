
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
    public partial class CheckpointServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddCheckpoint_Success_Test()
        {
            // Arrange
            CheckpointDTO dto = SampleCheckpointDTO(1);

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.AddCheckpoint(Moq.It.IsAny<R_Checkpoint>())).Returns(1);

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            int id = checkpointService.AddCheckpoint(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.CheckpointId);
        }

        [TestMethod]
        public void DeleteCheckpoint_Success_Test()
        {
            // Arrange
            CheckpointDTO dto = SampleCheckpointDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.DeleteCheckpoint(Moq.It.IsAny<R_Checkpoint>())).Verifiable();

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            checkpointService.DeleteCheckpoint(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteCheckpointById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.DeleteCheckpoint(Moq.It.IsAny<int>())).Verifiable();

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            checkpointService.DeleteCheckpoint(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetCheckpoint_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Checkpoint checkpoint = SampleCheckpoint(id);

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.GetCheckpoint(Moq.It.IsAny<int>())).Returns(checkpoint);

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            CheckpointDTO result = checkpointService.GetCheckpoint(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CheckpointId);
        }

        [TestMethod]
        public void GetCheckpoints_Success_Test()
        {
            // Arrange
            R_Checkpoint checkpoint = SampleCheckpoint(1);
            
            IList<R_Checkpoint> list = new List<R_Checkpoint>();
            list.Add(checkpoint);

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.GetCheckpoints()).Returns(list);

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            var resultList = checkpointService.GetCheckpoints();
            CheckpointDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CheckpointId);
        }

        [TestMethod]
        public void GetCheckpointsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Checkpoint> list = new List<R_Checkpoint>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleCheckpoint(i));
            }

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.GetCheckpoints(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            var resultList = checkpointService.GetCheckpoints(searchTerm, pageIndex, pageSize);
            CheckpointDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CheckpointId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetCheckpointListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? plannedRouteId = null; 
            string name = null; 
            int? orderNumber = null; 
            double? latitude = null; 
            double? longitude = null; 
            int? addressId = null; 
            int? estimatedTimeArrival = null; 
            System.DateTime? minimumTimeFrom = null; 
            System.DateTime? minimumTimeTo = null; 
            System.DateTime? maximumTimeFrom = null; 
            System.DateTime? maximumTimeTo = null; 
            int? nucleoId = null; 
            int? supplierId = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Checkpoint> list = new List<R_Checkpoint>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleCheckpoint(i));
            }

            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.GetCheckpointListAdvancedSearch(
                 Moq.It.IsAny<int?>() // plannedRouteId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<int?>() // orderNumber 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<int?>() // addressId 
                , Moq.It.IsAny<int?>() // estimatedTimeArrival 
                , Moq.It.IsAny<System.DateTime?>() // minimumTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // minimumTimeTo 
                , Moq.It.IsAny<System.DateTime?>() // maximumTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // maximumTimeTo 
                , Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<int?>() // supplierId 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            var resultList = checkpointService.GetCheckpointListAdvancedSearch(
                 plannedRouteId 
                , name 
                , orderNumber 
                , latitude 
                , longitude 
                , addressId 
                , estimatedTimeArrival 
                , minimumTimeFrom 
                , minimumTimeTo 
                , maximumTimeFrom 
                , maximumTimeTo 
                , nucleoId 
                , supplierId 
                , active 
            );
            
            CheckpointDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CheckpointId);
        }

        [TestMethod]
        public void UpdateCheckpoint_Success_Test()
        {
            // Arrange
            CheckpointDTO dto = SampleCheckpointDTO(1);
            
            // create mock for repository
            var mock = new Mock<ICheckpointRepository>();
            mock.Setup(s => s.UpdateCheckpoint(Moq.It.IsAny<R_Checkpoint>())).Verifiable();

            // service
            CheckpointService checkpointService = new CheckpointService();
            CheckpointService.Repository = mock.Object;

            // Act
            checkpointService.UpdateCheckpoint(dto);

            // Assert
            Assert.IsNotNull(dto);
        }

        [TestMethod]
        public void GetCheckpointListByPlannedRouteId_Success_Test()
        {
            // Arrange


            // Act


            // Assert


            Assert.Fail();
        }



        // example data

        public static R_Checkpoint SampleCheckpoint(int id = 1)
        {
            R_Checkpoint checkpoint = new R_Checkpoint();

            // int
            checkpoint.CheckpointId = id;
            // int
            checkpoint.PlannedRouteId = 1;
            // string
            checkpoint.Name = "NameTestValue";
            // int
            checkpoint.OrderNumber = 1;
            // double?
            checkpoint.Latitude = 1;
            // double?
            checkpoint.Longitude = 1;
            // int?
            checkpoint.AddressId = 1;
            // int
            checkpoint.EstimatedTimeArrival = 1;
            // System.DateTime?
            checkpoint.MinimumTime = new System.DateTime();
            // System.DateTime?
            checkpoint.MaximumTime = new System.DateTime();
            // int?
            checkpoint.NucleoId = 1;
            // int?
            checkpoint.SupplierId = 1;
            // bool
            checkpoint.Active = false;
            // bool
            checkpoint.IsDeleted = false;
            // int?
            checkpoint.CreateBy = 1;
            // System.DateTime?
            checkpoint.CreateOn = new System.DateTime();
            // int?
            checkpoint.UpdateBy = 1;
            // System.DateTime?
            checkpoint.UpdateOn = new System.DateTime();
            
            return checkpoint;
        }
        
        public static CheckpointDTO SampleCheckpointDTO(int id = 1)
        {
            CheckpointDTO checkpoint = new CheckpointDTO();

            // int
            checkpoint.CheckpointId = id;
            // int
            checkpoint.PlannedRouteId = 1;
            // string
            checkpoint.Name = "NameTestValue";
            // int
            checkpoint.OrderNumber = 1;
            // double?
            checkpoint.Latitude = 1;
            // double?
            checkpoint.Longitude = 1;
            // int?
            checkpoint.AddressId = 1;
            // int
            checkpoint.EstimatedTimeArrival = 1;
            // System.DateTime?
            checkpoint.MinimumTime = new System.DateTime();
            // System.DateTime?
            checkpoint.MaximumTime = new System.DateTime();
            // int?
            checkpoint.NucleoId = 1;
            // int?
            checkpoint.SupplierId = 1;
            // bool
            checkpoint.Active = false;
            // bool
            checkpoint.IsDeleted = false;
            // int?
            checkpoint.CreateBy = 1;
            // System.DateTime?
            checkpoint.CreateOn = new System.DateTime();
            // int?
            checkpoint.UpdateBy = 1;
            // System.DateTime?
            checkpoint.UpdateOn = new System.DateTime();
            
            return checkpoint;
        }
        
    }
}

    