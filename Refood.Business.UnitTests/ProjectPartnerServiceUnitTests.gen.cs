
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
    public partial class ProjectPartnerServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddProjectPartner_Success_Test()
        {
            // Arrange
            ProjectPartnerDTO dto = SampleProjectPartnerDTO(1);

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.AddProjectPartner(Moq.It.IsAny<R_ProjectPartner>())).Returns(1);

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            int id = projectPartnerService.AddProjectPartner(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ProjectPartnerId);
        }

        [TestMethod]
        public void DeleteProjectPartner_Success_Test()
        {
            // Arrange
            ProjectPartnerDTO dto = SampleProjectPartnerDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.DeleteProjectPartner(Moq.It.IsAny<R_ProjectPartner>())).Verifiable();

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            projectPartnerService.DeleteProjectPartner(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteProjectPartnerById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.DeleteProjectPartner(Moq.It.IsAny<int>())).Verifiable();

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            projectPartnerService.DeleteProjectPartner(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetProjectPartner_Success_Test()
        {
            // Arrange
            int id = 1;
            R_ProjectPartner projectPartner = SampleProjectPartner(id);

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.GetProjectPartner(Moq.It.IsAny<int>())).Returns(projectPartner);

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            ProjectPartnerDTO result = projectPartnerService.GetProjectPartner(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectPartnerId);
        }

        [TestMethod]
        public void GetProjectPartners_Success_Test()
        {
            // Arrange
            R_ProjectPartner projectPartner = SampleProjectPartner(1);
            
            IList<R_ProjectPartner> list = new List<R_ProjectPartner>();
            list.Add(projectPartner);

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.GetProjectPartners()).Returns(list);

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            var resultList = projectPartnerService.GetProjectPartners();
            ProjectPartnerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectPartnerId);
        }

        [TestMethod]
        public void GetProjectPartnersPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ProjectPartner> list = new List<R_ProjectPartner>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleProjectPartner(i));
            }

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.GetProjectPartners(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            var resultList = projectPartnerService.GetProjectPartners(searchTerm, pageIndex, pageSize);
            ProjectPartnerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectPartnerId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetProjectPartnerListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? projectId = null; 
            int? partnerId = null; 
            double? grantValue = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ProjectPartner> list = new List<R_ProjectPartner>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleProjectPartner(i));
            }

            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.GetProjectPartnerListAdvancedSearch(
                 Moq.It.IsAny<int?>() // projectId 
                , Moq.It.IsAny<int?>() // partnerId 
                , Moq.It.IsAny<double?>() // grantValue 
            )).Returns(list);

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            var resultList = projectPartnerService.GetProjectPartnerListAdvancedSearch(
                 projectId 
                , partnerId 
                , grantValue 
            );
            
            ProjectPartnerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectPartnerId);
        }

        [TestMethod]
        public void UpdateProjectPartner_Success_Test()
        {
            // Arrange
            ProjectPartnerDTO dto = SampleProjectPartnerDTO(1);
            
            // create mock for repository
            var mock = new Mock<IProjectPartnerRepository>();
            mock.Setup(s => s.UpdateProjectPartner(Moq.It.IsAny<R_ProjectPartner>())).Verifiable();

            // service
            ProjectPartnerService projectPartnerService = new ProjectPartnerService();
            ProjectPartnerService.Repository = mock.Object;

            // Act
            projectPartnerService.UpdateProjectPartner(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_ProjectPartner SampleProjectPartner(int id = 1)
        {
            R_ProjectPartner projectPartner = new R_ProjectPartner();

            // int
            projectPartner.ProjectPartnerId = id;
            // int
            projectPartner.ProjectId = 1;
            // int
            projectPartner.PartnerId = 1;
            // double?
            projectPartner.GrantValue = 1;
            // bool
            projectPartner.IsDeleted = false;
            // int?
            projectPartner.CreateBy = 1;
            // System.DateTime?
            projectPartner.CreateOn = new System.DateTime();
            // int?
            projectPartner.UpdateBy = 1;
            // System.DateTime?
            projectPartner.UpdateOn = new System.DateTime();
            
            return projectPartner;
        }
        
        public static ProjectPartnerDTO SampleProjectPartnerDTO(int id = 1)
        {
            ProjectPartnerDTO projectPartner = new ProjectPartnerDTO();

            // int
            projectPartner.ProjectPartnerId = id;
            // int
            projectPartner.ProjectId = 1;
            // int
            projectPartner.PartnerId = 1;
            // double?
            projectPartner.GrantValue = 1;
            // bool
            projectPartner.IsDeleted = false;
            // int?
            projectPartner.CreateBy = 1;
            // System.DateTime?
            projectPartner.CreateOn = new System.DateTime();
            // int?
            projectPartner.UpdateBy = 1;
            // System.DateTime?
            projectPartner.UpdateOn = new System.DateTime();
            
            return projectPartner;
        }
        
    }
}

    