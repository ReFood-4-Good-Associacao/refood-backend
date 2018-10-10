
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
    public partial class TutorialServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddTutorial_Success_Test()
        {
            // Arrange
            TutorialDTO dto = SampleTutorialDTO(1);

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.AddTutorial(Moq.It.IsAny<R_Tutorial>())).Returns(1);

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            int id = tutorialService.AddTutorial(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.TutorialId);
        }

        [TestMethod]
        public void DeleteTutorial_Success_Test()
        {
            // Arrange
            TutorialDTO dto = SampleTutorialDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.DeleteTutorial(Moq.It.IsAny<R_Tutorial>())).Verifiable();

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            tutorialService.DeleteTutorial(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteTutorialById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.DeleteTutorial(Moq.It.IsAny<int>())).Verifiable();

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            tutorialService.DeleteTutorial(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetTutorial_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Tutorial tutorial = SampleTutorial(id);

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.GetTutorial(Moq.It.IsAny<int>())).Returns(tutorial);

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            TutorialDTO result = tutorialService.GetTutorial(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TutorialId);
        }

        [TestMethod]
        public void GetTutorials_Success_Test()
        {
            // Arrange
            R_Tutorial tutorial = SampleTutorial(1);
            
            IList<R_Tutorial> list = new List<R_Tutorial>();
            list.Add(tutorial);

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.GetTutorials()).Returns(list);

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            var resultList = tutorialService.GetTutorials();
            TutorialDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TutorialId);
        }

        [TestMethod]
        public void GetTutorialsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Tutorial> list = new List<R_Tutorial>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTutorial(i));
            }

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.GetTutorials(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            var resultList = tutorialService.GetTutorials(searchTerm, pageIndex, pageSize);
            TutorialDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TutorialId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetTutorialListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            string location = null; 
            bool? isOnlineTutorial = null; 
            string language = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Tutorial> list = new List<R_Tutorial>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTutorial(i));
            }

            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.GetTutorialListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<string>() // location 
                , Moq.It.IsAny<bool?>() // isOnlineTutorial 
                , Moq.It.IsAny<string>() // language 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            var resultList = tutorialService.GetTutorialListAdvancedSearch(
                 name 
                , description 
                , location 
                , isOnlineTutorial 
                , language 
                , active 
            );
            
            TutorialDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TutorialId);
        }

        [TestMethod]
        public void UpdateTutorial_Success_Test()
        {
            // Arrange
            TutorialDTO dto = SampleTutorialDTO(1);
            
            // create mock for repository
            var mock = new Mock<ITutorialRepository>();
            mock.Setup(s => s.UpdateTutorial(Moq.It.IsAny<R_Tutorial>())).Verifiable();

            // service
            TutorialService tutorialService = new TutorialService();
            TutorialService.Repository = mock.Object;

            // Act
            tutorialService.UpdateTutorial(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Tutorial SampleTutorial(int id = 1)
        {
            R_Tutorial tutorial = new R_Tutorial();

            // int
            tutorial.TutorialId = id;
            // string
            tutorial.Name = "NameTestValue";
            // string
            tutorial.Description = "DescriptionTestValue";
            // string
            tutorial.Location = "LocationTestValue";
            // bool
            tutorial.IsOnlineTutorial = false;
            // string
            tutorial.Language = "LanguageTestValue";
            // bool
            tutorial.Active = false;
            // bool
            tutorial.IsDeleted = false;
            // int?
            tutorial.CreateBy = 1;
            // System.DateTime?
            tutorial.CreateOn = new System.DateTime();
            // int?
            tutorial.UpdateBy = 1;
            // System.DateTime?
            tutorial.UpdateOn = new System.DateTime();
            
            return tutorial;
        }
        
        public static TutorialDTO SampleTutorialDTO(int id = 1)
        {
            TutorialDTO tutorial = new TutorialDTO();

            // int
            tutorial.TutorialId = id;
            // string
            tutorial.Name = "NameTestValue";
            // string
            tutorial.Description = "DescriptionTestValue";
            // string
            tutorial.Location = "LocationTestValue";
            // bool
            tutorial.IsOnlineTutorial = false;
            // string
            tutorial.Language = "LanguageTestValue";
            // bool
            tutorial.Active = false;
            // bool
            tutorial.IsDeleted = false;
            // int?
            tutorial.CreateBy = 1;
            // System.DateTime?
            tutorial.CreateOn = new System.DateTime();
            // int?
            tutorial.UpdateBy = 1;
            // System.DateTime?
            tutorial.UpdateOn = new System.DateTime();
            
            return tutorial;
        }
        
    }
}

    