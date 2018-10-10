
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
    public partial class PartnershipTypeServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddPartnershipType_Success_Test()
        {
            // Arrange
            PartnershipTypeDTO dto = SamplePartnershipTypeDTO(1);

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.AddPartnershipType(Moq.It.IsAny<R_PartnershipType>())).Returns(1);

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            int id = partnershipTypeService.AddPartnershipType(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.PartnershipTypeId);
        }

        [TestMethod]
        public void DeletePartnershipType_Success_Test()
        {
            // Arrange
            PartnershipTypeDTO dto = SamplePartnershipTypeDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.DeletePartnershipType(Moq.It.IsAny<R_PartnershipType>())).Verifiable();

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            partnershipTypeService.DeletePartnershipType(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeletePartnershipTypeById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.DeletePartnershipType(Moq.It.IsAny<int>())).Verifiable();

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            partnershipTypeService.DeletePartnershipType(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetPartnershipType_Success_Test()
        {
            // Arrange
            int id = 1;
            R_PartnershipType partnershipType = SamplePartnershipType(id);

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.GetPartnershipType(Moq.It.IsAny<int>())).Returns(partnershipType);

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            PartnershipTypeDTO result = partnershipTypeService.GetPartnershipType(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnershipTypeId);
        }

        [TestMethod]
        public void GetPartnershipTypes_Success_Test()
        {
            // Arrange
            R_PartnershipType partnershipType = SamplePartnershipType(1);
            
            IList<R_PartnershipType> list = new List<R_PartnershipType>();
            list.Add(partnershipType);

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.GetPartnershipTypes()).Returns(list);

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            var resultList = partnershipTypeService.GetPartnershipTypes();
            PartnershipTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnershipTypeId);
        }

        [TestMethod]
        public void GetPartnershipTypesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_PartnershipType> list = new List<R_PartnershipType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SamplePartnershipType(i));
            }

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.GetPartnershipTypes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            var resultList = partnershipTypeService.GetPartnershipTypes(searchTerm, pageIndex, pageSize);
            PartnershipTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnershipTypeId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetPartnershipTypeListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            string activityType = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_PartnershipType> list = new List<R_PartnershipType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SamplePartnershipType(i));
            }

            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.GetPartnershipTypeListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<string>() // activityType 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            var resultList = partnershipTypeService.GetPartnershipTypeListAdvancedSearch(
                 name 
                , description 
                , activityType 
                , active 
            );
            
            PartnershipTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnershipTypeId);
        }

        [TestMethod]
        public void UpdatePartnershipType_Success_Test()
        {
            // Arrange
            PartnershipTypeDTO dto = SamplePartnershipTypeDTO(1);
            
            // create mock for repository
            var mock = new Mock<IPartnershipTypeRepository>();
            mock.Setup(s => s.UpdatePartnershipType(Moq.It.IsAny<R_PartnershipType>())).Verifiable();

            // service
            PartnershipTypeService partnershipTypeService = new PartnershipTypeService();
            PartnershipTypeService.Repository = mock.Object;

            // Act
            partnershipTypeService.UpdatePartnershipType(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_PartnershipType SamplePartnershipType(int id = 1)
        {
            R_PartnershipType partnershipType = new R_PartnershipType();

            // int
            partnershipType.PartnershipTypeId = id;
            // string
            partnershipType.Name = "NameTestValue";
            // string
            partnershipType.Description = "DescriptionTestValue";
            // string
            partnershipType.ActivityType = "ActivityTypeTestValue";
            // bool
            partnershipType.Active = false;
            // bool
            partnershipType.IsDeleted = false;
            // int?
            partnershipType.CreateBy = 1;
            // System.DateTime?
            partnershipType.CreateOn = new System.DateTime();
            // int?
            partnershipType.UpdateBy = 1;
            // System.DateTime?
            partnershipType.UpdateOn = new System.DateTime();
            
            return partnershipType;
        }
        
        public static PartnershipTypeDTO SamplePartnershipTypeDTO(int id = 1)
        {
            PartnershipTypeDTO partnershipType = new PartnershipTypeDTO();

            // int
            partnershipType.PartnershipTypeId = id;
            // string
            partnershipType.Name = "NameTestValue";
            // string
            partnershipType.Description = "DescriptionTestValue";
            // string
            partnershipType.ActivityType = "ActivityTypeTestValue";
            // bool
            partnershipType.Active = false;
            // bool
            partnershipType.IsDeleted = false;
            // int?
            partnershipType.CreateBy = 1;
            // System.DateTime?
            partnershipType.CreateOn = new System.DateTime();
            // int?
            partnershipType.UpdateBy = 1;
            // System.DateTime?
            partnershipType.UpdateOn = new System.DateTime();
            
            return partnershipType;
        }
        
    }
}

    