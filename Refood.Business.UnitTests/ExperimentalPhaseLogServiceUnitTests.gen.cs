
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
    public partial class ExperimentalPhaseLogServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddExperimentalPhaseLog_Success_Test()
        {
            // Arrange
            ExperimentalPhaseLogDTO dto = SampleExperimentalPhaseLogDTO(1);

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.AddExperimentalPhaseLog(Moq.It.IsAny<R_ExperimentalPhaseLog>())).Returns(1);

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            int id = experimentalPhaseLogService.AddExperimentalPhaseLog(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ExperimentalPhaseLogId);
        }

        [TestMethod]
        public void DeleteExperimentalPhaseLog_Success_Test()
        {
            // Arrange
            ExperimentalPhaseLogDTO dto = SampleExperimentalPhaseLogDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.DeleteExperimentalPhaseLog(Moq.It.IsAny<R_ExperimentalPhaseLog>())).Verifiable();

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            experimentalPhaseLogService.DeleteExperimentalPhaseLog(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteExperimentalPhaseLogById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.DeleteExperimentalPhaseLog(Moq.It.IsAny<int>())).Verifiable();

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            experimentalPhaseLogService.DeleteExperimentalPhaseLog(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetExperimentalPhaseLog_Success_Test()
        {
            // Arrange
            int id = 1;
            R_ExperimentalPhaseLog experimentalPhaseLog = SampleExperimentalPhaseLog(id);

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.GetExperimentalPhaseLog(Moq.It.IsAny<int>())).Returns(experimentalPhaseLog);

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            ExperimentalPhaseLogDTO result = experimentalPhaseLogService.GetExperimentalPhaseLog(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExperimentalPhaseLogId);
        }

        [TestMethod]
        public void GetExperimentalPhaseLogs_Success_Test()
        {
            // Arrange
            R_ExperimentalPhaseLog experimentalPhaseLog = SampleExperimentalPhaseLog(1);
            
            IList<R_ExperimentalPhaseLog> list = new List<R_ExperimentalPhaseLog>();
            list.Add(experimentalPhaseLog);

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.GetExperimentalPhaseLogs()).Returns(list);

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            var resultList = experimentalPhaseLogService.GetExperimentalPhaseLogs();
            ExperimentalPhaseLogDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExperimentalPhaseLogId);
        }

        [TestMethod]
        public void GetExperimentalPhaseLogsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ExperimentalPhaseLog> list = new List<R_ExperimentalPhaseLog>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleExperimentalPhaseLog(i));
            }

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.GetExperimentalPhaseLogs(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            var resultList = experimentalPhaseLogService.GetExperimentalPhaseLogs(searchTerm, pageIndex, pageSize);
            ExperimentalPhaseLogDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExperimentalPhaseLogId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetExperimentalPhaseLogListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            System.DateTime? logDateFrom = null; 
            System.DateTime? logDateTo = null; 
            string task = null; 
            string activityDescription = null; 
            string managerName = null; 
            string volunteerName = null; 
            bool? volunteerConfirmation = null; 
            int? documentId = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ExperimentalPhaseLog> list = new List<R_ExperimentalPhaseLog>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleExperimentalPhaseLog(i));
            }

            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.GetExperimentalPhaseLogListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<System.DateTime?>() // logDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // logDateTo 
                , Moq.It.IsAny<string>() // task 
                , Moq.It.IsAny<string>() // activityDescription 
                , Moq.It.IsAny<string>() // managerName 
                , Moq.It.IsAny<string>() // volunteerName 
                , Moq.It.IsAny<bool?>() // volunteerConfirmation 
                , Moq.It.IsAny<int?>() // documentId 
            )).Returns(list);

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            var resultList = experimentalPhaseLogService.GetExperimentalPhaseLogListAdvancedSearch(
                 nucleoId 
                , logDateFrom 
                , logDateTo 
                , task 
                , activityDescription 
                , managerName 
                , volunteerName 
                , volunteerConfirmation 
                , documentId 
            );
            
            ExperimentalPhaseLogDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ExperimentalPhaseLogId);
        }

        [TestMethod]
        public void UpdateExperimentalPhaseLog_Success_Test()
        {
            // Arrange
            ExperimentalPhaseLogDTO dto = SampleExperimentalPhaseLogDTO(1);
            
            // create mock for repository
            var mock = new Mock<IExperimentalPhaseLogRepository>();
            mock.Setup(s => s.UpdateExperimentalPhaseLog(Moq.It.IsAny<R_ExperimentalPhaseLog>())).Verifiable();

            // service
            ExperimentalPhaseLogService experimentalPhaseLogService = new ExperimentalPhaseLogService();
            ExperimentalPhaseLogService.Repository = mock.Object;

            // Act
            experimentalPhaseLogService.UpdateExperimentalPhaseLog(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_ExperimentalPhaseLog SampleExperimentalPhaseLog(int id = 1)
        {
            R_ExperimentalPhaseLog experimentalPhaseLog = new R_ExperimentalPhaseLog();

            // int
            experimentalPhaseLog.ExperimentalPhaseLogId = id;
            // int?
            experimentalPhaseLog.NucleoId = 1;
            // System.DateTime
            experimentalPhaseLog.LogDate = new System.DateTime();
            // string
            experimentalPhaseLog.Task = "TaskTestValue";
            // string
            experimentalPhaseLog.ActivityDescription = "ActivityDescriptionTestValue";
            // string
            experimentalPhaseLog.ManagerName = "ManagerNameTestValue";
            // string
            experimentalPhaseLog.VolunteerName = "VolunteerNameTestValue";
            // bool
            experimentalPhaseLog.VolunteerConfirmation = false;
            // int?
            experimentalPhaseLog.DocumentId = 1;
            // bool
            experimentalPhaseLog.IsDeleted = false;
            // int?
            experimentalPhaseLog.CreateBy = 1;
            // System.DateTime?
            experimentalPhaseLog.CreateOn = new System.DateTime();
            // int?
            experimentalPhaseLog.UpdateBy = 1;
            // System.DateTime?
            experimentalPhaseLog.UpdateOn = new System.DateTime();
            
            return experimentalPhaseLog;
        }
        
        public static ExperimentalPhaseLogDTO SampleExperimentalPhaseLogDTO(int id = 1)
        {
            ExperimentalPhaseLogDTO experimentalPhaseLog = new ExperimentalPhaseLogDTO();

            // int
            experimentalPhaseLog.ExperimentalPhaseLogId = id;
            // int?
            experimentalPhaseLog.NucleoId = 1;
            // System.DateTime
            experimentalPhaseLog.LogDate = new System.DateTime();
            // string
            experimentalPhaseLog.Task = "TaskTestValue";
            // string
            experimentalPhaseLog.ActivityDescription = "ActivityDescriptionTestValue";
            // string
            experimentalPhaseLog.ManagerName = "ManagerNameTestValue";
            // string
            experimentalPhaseLog.VolunteerName = "VolunteerNameTestValue";
            // bool
            experimentalPhaseLog.VolunteerConfirmation = false;
            // int?
            experimentalPhaseLog.DocumentId = 1;
            // bool
            experimentalPhaseLog.IsDeleted = false;
            // int?
            experimentalPhaseLog.CreateBy = 1;
            // System.DateTime?
            experimentalPhaseLog.CreateOn = new System.DateTime();
            // int?
            experimentalPhaseLog.UpdateBy = 1;
            // System.DateTime?
            experimentalPhaseLog.UpdateOn = new System.DateTime();
            
            return experimentalPhaseLog;
        }
        
    }
}

    