
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
    public partial class ContributionTypeServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddContributionType_Success_Test()
        {
            // Arrange
            ContributionTypeDTO dto = SampleContributionTypeDTO(1);

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.AddContributionType(Moq.It.IsAny<R_ContributionType>())).Returns(1);

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            int id = contributionTypeService.AddContributionType(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ContributionTypeId);
        }

        [TestMethod]
        public void DeleteContributionType_Success_Test()
        {
            // Arrange
            ContributionTypeDTO dto = SampleContributionTypeDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.DeleteContributionType(Moq.It.IsAny<R_ContributionType>())).Verifiable();

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            contributionTypeService.DeleteContributionType(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteContributionTypeById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.DeleteContributionType(Moq.It.IsAny<int>())).Verifiable();

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            contributionTypeService.DeleteContributionType(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetContributionType_Success_Test()
        {
            // Arrange
            int id = 1;
            R_ContributionType contributionType = SampleContributionType(id);

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.GetContributionType(Moq.It.IsAny<int>())).Returns(contributionType);

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            ContributionTypeDTO result = contributionTypeService.GetContributionType(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionTypeId);
        }

        [TestMethod]
        public void GetContributionTypes_Success_Test()
        {
            // Arrange
            R_ContributionType contributionType = SampleContributionType(1);
            
            IList<R_ContributionType> list = new List<R_ContributionType>();
            list.Add(contributionType);

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.GetContributionTypes()).Returns(list);

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            var resultList = contributionTypeService.GetContributionTypes();
            ContributionTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionTypeId);
        }

        [TestMethod]
        public void GetContributionTypesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionType> list = new List<R_ContributionType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionType(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.GetContributionTypes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            var resultList = contributionTypeService.GetContributionTypes(searchTerm, pageIndex, pageSize);
            ContributionTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionTypeId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetContributionTypeListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionType> list = new List<R_ContributionType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionType(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.GetContributionTypeListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            var resultList = contributionTypeService.GetContributionTypeListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            ContributionTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionTypeId);
        }

        [TestMethod]
        public void UpdateContributionType_Success_Test()
        {
            // Arrange
            ContributionTypeDTO dto = SampleContributionTypeDTO(1);
            
            // create mock for repository
            var mock = new Mock<IContributionTypeRepository>();
            mock.Setup(s => s.UpdateContributionType(Moq.It.IsAny<R_ContributionType>())).Verifiable();

            // service
            ContributionTypeService contributionTypeService = new ContributionTypeService();
            ContributionTypeService.Repository = mock.Object;

            // Act
            contributionTypeService.UpdateContributionType(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_ContributionType SampleContributionType(int id = 1)
        {
            R_ContributionType contributionType = new R_ContributionType();

            // int
            contributionType.ContributionTypeId = id;
            // string
            contributionType.Name = "NameTestValue";
            // string
            contributionType.Description = "DescriptionTestValue";
            // bool
            contributionType.Active = false;
            // bool
            contributionType.IsDeleted = false;
            // int?
            contributionType.CreateBy = 1;
            // System.DateTime?
            contributionType.CreateOn = new System.DateTime();
            // int?
            contributionType.UpdateBy = 1;
            // System.DateTime?
            contributionType.UpdateOn = new System.DateTime();
            
            return contributionType;
        }
        
        public static ContributionTypeDTO SampleContributionTypeDTO(int id = 1)
        {
            ContributionTypeDTO contributionType = new ContributionTypeDTO();

            // int
            contributionType.ContributionTypeId = id;
            // string
            contributionType.Name = "NameTestValue";
            // string
            contributionType.Description = "DescriptionTestValue";
            // bool
            contributionType.Active = false;
            // bool
            contributionType.IsDeleted = false;
            // int?
            contributionType.CreateBy = 1;
            // System.DateTime?
            contributionType.CreateOn = new System.DateTime();
            // int?
            contributionType.UpdateBy = 1;
            // System.DateTime?
            contributionType.UpdateOn = new System.DateTime();
            
            return contributionType;
        }
        
    }
}

    