
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
    public partial class ProjectServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddProject_Success_Test()
        {
            // Arrange
            ProjectDTO dto = SampleProjectDTO(1);

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.AddProject(Moq.It.IsAny<R_Project>())).Returns(1);

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            int id = projectService.AddProject(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ProjectId);
        }

        [TestMethod]
        public void DeleteProject_Success_Test()
        {
            // Arrange
            ProjectDTO dto = SampleProjectDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.DeleteProject(Moq.It.IsAny<R_Project>())).Verifiable();

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            projectService.DeleteProject(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteProjectById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.DeleteProject(Moq.It.IsAny<int>())).Verifiable();

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            projectService.DeleteProject(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetProject_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Project project = SampleProject(id);

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.GetProject(Moq.It.IsAny<int>())).Returns(project);

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            ProjectDTO result = projectService.GetProject(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectId);
        }

        [TestMethod]
        public void GetProjects_Success_Test()
        {
            // Arrange
            R_Project project = SampleProject(1);
            
            IList<R_Project> list = new List<R_Project>();
            list.Add(project);

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.GetProjects()).Returns(list);

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            var resultList = projectService.GetProjects();
            ProjectDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectId);
        }

        [TestMethod]
        public void GetProjectsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Project> list = new List<R_Project>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleProject(i));
            }

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.GetProjects(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            var resultList = projectService.GetProjects(searchTerm, pageIndex, pageSize);
            ProjectDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetProjectListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            string name = null; 
            string description = null; 
            string deadlineCall = null; 
            double? budget = null; 
            string funding = null; 
            System.DateTime? startDateFrom = null; 
            System.DateTime? startDateTo = null; 
            System.DateTime? endDateFrom = null; 
            System.DateTime? endDateTo = null; 
            string areaOfInterest = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Project> list = new List<R_Project>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleProject(i));
            }

            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.GetProjectListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<string>() // deadlineCall 
                , Moq.It.IsAny<double?>() // budget 
                , Moq.It.IsAny<string>() // funding 
                , Moq.It.IsAny<System.DateTime?>() // startDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // startDateTo 
                , Moq.It.IsAny<System.DateTime?>() // endDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // endDateTo 
                , Moq.It.IsAny<string>() // areaOfInterest 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            var resultList = projectService.GetProjectListAdvancedSearch(
                 nucleoId 
                , name 
                , description 
                , deadlineCall 
                , budget 
                , funding 
                , startDateFrom 
                , startDateTo 
                , endDateFrom 
                , endDateTo 
                , areaOfInterest 
                , active 
            );
            
            ProjectDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ProjectId);
        }

        [TestMethod]
        public void UpdateProject_Success_Test()
        {
            // Arrange
            ProjectDTO dto = SampleProjectDTO(1);
            
            // create mock for repository
            var mock = new Mock<IProjectRepository>();
            mock.Setup(s => s.UpdateProject(Moq.It.IsAny<R_Project>())).Verifiable();

            // service
            ProjectService projectService = new ProjectService();
            ProjectService.Repository = mock.Object;

            // Act
            projectService.UpdateProject(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Project SampleProject(int id = 1)
        {
            R_Project project = new R_Project();

            // int
            project.ProjectId = id;
            // int?
            project.NucleoId = 1;
            // string
            project.Name = "NameTestValue";
            // string
            project.Description = "DescriptionTestValue";
            // string
            project.DeadlineCall = "DeadlineCallTestValue";
            // double?
            project.Budget = 1;
            // string
            project.Funding = "FundingTestValue";
            // System.DateTime?
            project.StartDate = new System.DateTime();
            // System.DateTime?
            project.EndDate = new System.DateTime();
            // string
            project.AreaOfInterest = "AreaOfInterestTestValue";
            // bool
            project.Active = false;
            // bool
            project.IsDeleted = false;
            // int?
            project.CreateBy = 1;
            // System.DateTime?
            project.CreateOn = new System.DateTime();
            // int?
            project.UpdateBy = 1;
            // System.DateTime?
            project.UpdateOn = new System.DateTime();
            
            return project;
        }
        
        public static ProjectDTO SampleProjectDTO(int id = 1)
        {
            ProjectDTO project = new ProjectDTO();

            // int
            project.ProjectId = id;
            // int?
            project.NucleoId = 1;
            // string
            project.Name = "NameTestValue";
            // string
            project.Description = "DescriptionTestValue";
            // string
            project.DeadlineCall = "DeadlineCallTestValue";
            // double?
            project.Budget = 1;
            // string
            project.Funding = "FundingTestValue";
            // System.DateTime?
            project.StartDate = new System.DateTime();
            // System.DateTime?
            project.EndDate = new System.DateTime();
            // string
            project.AreaOfInterest = "AreaOfInterestTestValue";
            // bool
            project.Active = false;
            // bool
            project.IsDeleted = false;
            // int?
            project.CreateBy = 1;
            // System.DateTime?
            project.CreateOn = new System.DateTime();
            // int?
            project.UpdateBy = 1;
            // System.DateTime?
            project.UpdateOn = new System.DateTime();
            
            return project;
        }
        
    }
}

    