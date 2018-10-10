
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
    public partial class DeliveryReportServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddDeliveryReport_Success_Test()
        {
            // Arrange
            DeliveryReportDTO dto = SampleDeliveryReportDTO(1);

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.AddDeliveryReport(Moq.It.IsAny<R_DeliveryReport>())).Returns(1);

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            int id = deliveryReportService.AddDeliveryReport(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.DeliveryReportId);
        }

        [TestMethod]
        public void DeleteDeliveryReport_Success_Test()
        {
            // Arrange
            DeliveryReportDTO dto = SampleDeliveryReportDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.DeleteDeliveryReport(Moq.It.IsAny<R_DeliveryReport>())).Verifiable();

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            deliveryReportService.DeleteDeliveryReport(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteDeliveryReportById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.DeleteDeliveryReport(Moq.It.IsAny<int>())).Verifiable();

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            deliveryReportService.DeleteDeliveryReport(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetDeliveryReport_Success_Test()
        {
            // Arrange
            int id = 1;
            R_DeliveryReport deliveryReport = SampleDeliveryReport(id);

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.GetDeliveryReport(Moq.It.IsAny<int>())).Returns(deliveryReport);

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            DeliveryReportDTO result = deliveryReportService.GetDeliveryReport(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportId);
        }

        [TestMethod]
        public void GetDeliveryReports_Success_Test()
        {
            // Arrange
            R_DeliveryReport deliveryReport = SampleDeliveryReport(1);
            
            IList<R_DeliveryReport> list = new List<R_DeliveryReport>();
            list.Add(deliveryReport);

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.GetDeliveryReports()).Returns(list);

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportService.GetDeliveryReports();
            DeliveryReportDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportId);
        }

        [TestMethod]
        public void GetDeliveryReportsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_DeliveryReport> list = new List<R_DeliveryReport>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDeliveryReport(i));
            }

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.GetDeliveryReports(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportService.GetDeliveryReports(searchTerm, pageIndex, pageSize);
            DeliveryReportDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetDeliveryReportListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            System.DateTime? reportDateFrom = null; 
            System.DateTime? reportDateTo = null; 
            string weekDay = null; 
            bool? submitted = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_DeliveryReport> list = new List<R_DeliveryReport>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleDeliveryReport(i));
            }

            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.GetDeliveryReportListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<System.DateTime?>() // reportDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // reportDateTo 
                , Moq.It.IsAny<string>() // weekDay 
                , Moq.It.IsAny<bool?>() // submitted 
            )).Returns(list);

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            var resultList = deliveryReportService.GetDeliveryReportListAdvancedSearch(
                 name 
                , description 
                , reportDateFrom 
                , reportDateTo 
                , weekDay 
                , submitted 
            );
            
            DeliveryReportDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeliveryReportId);
        }

        [TestMethod]
        public void UpdateDeliveryReport_Success_Test()
        {
            // Arrange
            DeliveryReportDTO dto = SampleDeliveryReportDTO(1);
            
            // create mock for repository
            var mock = new Mock<IDeliveryReportRepository>();
            mock.Setup(s => s.UpdateDeliveryReport(Moq.It.IsAny<R_DeliveryReport>())).Verifiable();

            // service
            DeliveryReportService deliveryReportService = new DeliveryReportService();
            DeliveryReportService.Repository = mock.Object;

            // Act
            deliveryReportService.UpdateDeliveryReport(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_DeliveryReport SampleDeliveryReport(int id = 1)
        {
            R_DeliveryReport deliveryReport = new R_DeliveryReport();

            // int
            deliveryReport.DeliveryReportId = id;
            // string
            deliveryReport.Name = "NameTestValue";
            // string
            deliveryReport.Description = "DescriptionTestValue";
            // System.DateTime?
            deliveryReport.ReportDate = new System.DateTime();
            // string
            deliveryReport.WeekDay = "WeekDayTestValue";
            // bool
            deliveryReport.Submitted = false;
            // bool
            deliveryReport.IsDeleted = false;
            // int?
            deliveryReport.CreateBy = 1;
            // System.DateTime?
            deliveryReport.CreateOn = new System.DateTime();
            // int?
            deliveryReport.UpdateBy = 1;
            // System.DateTime?
            deliveryReport.UpdateOn = new System.DateTime();
            
            return deliveryReport;
        }
        
        public static DeliveryReportDTO SampleDeliveryReportDTO(int id = 1)
        {
            DeliveryReportDTO deliveryReport = new DeliveryReportDTO();

            // int
            deliveryReport.DeliveryReportId = id;
            // string
            deliveryReport.Name = "NameTestValue";
            // string
            deliveryReport.Description = "DescriptionTestValue";
            // System.DateTime?
            deliveryReport.ReportDate = new System.DateTime();
            // string
            deliveryReport.WeekDay = "WeekDayTestValue";
            // bool
            deliveryReport.Submitted = false;
            // bool
            deliveryReport.IsDeleted = false;
            // int?
            deliveryReport.CreateBy = 1;
            // System.DateTime?
            deliveryReport.CreateOn = new System.DateTime();
            // int?
            deliveryReport.UpdateBy = 1;
            // System.DateTime?
            deliveryReport.UpdateOn = new System.DateTime();
            
            return deliveryReport;
        }
        
    }
}

    