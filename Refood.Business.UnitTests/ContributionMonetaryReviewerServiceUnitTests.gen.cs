
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
    public partial class ContributionMonetaryReviewerServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddContributionMonetaryReviewer_Success_Test()
        {
            // Arrange
            ContributionMonetaryReviewerDTO dto = SampleContributionMonetaryReviewerDTO(1);

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.AddContributionMonetaryReviewer(Moq.It.IsAny<R_ContributionMonetaryReviewer>())).Returns(1);

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            int id = contributionMonetaryReviewerService.AddContributionMonetaryReviewer(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ContributionMonetaryReviewerId);
        }

        [TestMethod]
        public void DeleteContributionMonetaryReviewer_Success_Test()
        {
            // Arrange
            ContributionMonetaryReviewerDTO dto = SampleContributionMonetaryReviewerDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.DeleteContributionMonetaryReviewer(Moq.It.IsAny<R_ContributionMonetaryReviewer>())).Verifiable();

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            contributionMonetaryReviewerService.DeleteContributionMonetaryReviewer(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteContributionMonetaryReviewerById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.DeleteContributionMonetaryReviewer(Moq.It.IsAny<int>())).Verifiable();

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            contributionMonetaryReviewerService.DeleteContributionMonetaryReviewer(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetContributionMonetaryReviewer_Success_Test()
        {
            // Arrange
            int id = 1;
            R_ContributionMonetaryReviewer contributionMonetaryReviewer = SampleContributionMonetaryReviewer(id);

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.GetContributionMonetaryReviewer(Moq.It.IsAny<int>())).Returns(contributionMonetaryReviewer);

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            ContributionMonetaryReviewerDTO result = contributionMonetaryReviewerService.GetContributionMonetaryReviewer(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryReviewerId);
        }

        [TestMethod]
        public void GetContributionMonetaryReviewers_Success_Test()
        {
            // Arrange
            R_ContributionMonetaryReviewer contributionMonetaryReviewer = SampleContributionMonetaryReviewer(1);
            
            IList<R_ContributionMonetaryReviewer> list = new List<R_ContributionMonetaryReviewer>();
            list.Add(contributionMonetaryReviewer);

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.GetContributionMonetaryReviewers()).Returns(list);

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            var resultList = contributionMonetaryReviewerService.GetContributionMonetaryReviewers();
            ContributionMonetaryReviewerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryReviewerId);
        }

        [TestMethod]
        public void GetContributionMonetaryReviewersPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionMonetaryReviewer> list = new List<R_ContributionMonetaryReviewer>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionMonetaryReviewer(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.GetContributionMonetaryReviewers(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            var resultList = contributionMonetaryReviewerService.GetContributionMonetaryReviewers(searchTerm, pageIndex, pageSize);
            ContributionMonetaryReviewerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryReviewerId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetContributionMonetaryReviewerListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? volunteerId = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionMonetaryReviewer> list = new List<R_ContributionMonetaryReviewer>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionMonetaryReviewer(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.GetContributionMonetaryReviewerListAdvancedSearch(
                 Moq.It.IsAny<int?>() // volunteerId 
            )).Returns(list);

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            var resultList = contributionMonetaryReviewerService.GetContributionMonetaryReviewerListAdvancedSearch(
                 volunteerId 
            );
            
            ContributionMonetaryReviewerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionMonetaryReviewerId);
        }

        [TestMethod]
        public void UpdateContributionMonetaryReviewer_Success_Test()
        {
            // Arrange
            ContributionMonetaryReviewerDTO dto = SampleContributionMonetaryReviewerDTO(1);
            
            // create mock for repository
            var mock = new Mock<IContributionMonetaryReviewerRepository>();
            mock.Setup(s => s.UpdateContributionMonetaryReviewer(Moq.It.IsAny<R_ContributionMonetaryReviewer>())).Verifiable();

            // service
            ContributionMonetaryReviewerService contributionMonetaryReviewerService = new ContributionMonetaryReviewerService();
            ContributionMonetaryReviewerService.Repository = mock.Object;

            // Act
            contributionMonetaryReviewerService.UpdateContributionMonetaryReviewer(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_ContributionMonetaryReviewer SampleContributionMonetaryReviewer(int id = 1)
        {
            R_ContributionMonetaryReviewer contributionMonetaryReviewer = new R_ContributionMonetaryReviewer();

            // int
            contributionMonetaryReviewer.ContributionMonetaryReviewerId = id;
            // int?
            contributionMonetaryReviewer.VolunteerId = 1;
            // bool
            contributionMonetaryReviewer.IsDeleted = false;
            // int?
            contributionMonetaryReviewer.CreateBy = 1;
            // System.DateTime?
            contributionMonetaryReviewer.CreateOn = new System.DateTime();
            // int?
            contributionMonetaryReviewer.UpdateBy = 1;
            // System.DateTime?
            contributionMonetaryReviewer.UpdateOn = new System.DateTime();
            
            return contributionMonetaryReviewer;
        }
        
        public static ContributionMonetaryReviewerDTO SampleContributionMonetaryReviewerDTO(int id = 1)
        {
            ContributionMonetaryReviewerDTO contributionMonetaryReviewer = new ContributionMonetaryReviewerDTO();

            // int
            contributionMonetaryReviewer.ContributionMonetaryReviewerId = id;
            // int?
            contributionMonetaryReviewer.VolunteerId = 1;
            // bool
            contributionMonetaryReviewer.IsDeleted = false;
            // int?
            contributionMonetaryReviewer.CreateBy = 1;
            // System.DateTime?
            contributionMonetaryReviewer.CreateOn = new System.DateTime();
            // int?
            contributionMonetaryReviewer.UpdateBy = 1;
            // System.DateTime?
            contributionMonetaryReviewer.UpdateOn = new System.DateTime();
            
            return contributionMonetaryReviewer;
        }
        
    }
}

    