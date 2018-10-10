
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
    public partial class EnergySourceServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddEnergySource_Success_Test()
        {
            // Arrange
            EnergySourceDTO dto = SampleEnergySourceDTO(1);

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.AddEnergySource(Moq.It.IsAny<R_EnergySource>())).Returns(1);

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            int id = energySourceService.AddEnergySource(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.EnergySourceId);
        }

        [TestMethod]
        public void DeleteEnergySource_Success_Test()
        {
            // Arrange
            EnergySourceDTO dto = SampleEnergySourceDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.DeleteEnergySource(Moq.It.IsAny<R_EnergySource>())).Verifiable();

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            energySourceService.DeleteEnergySource(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteEnergySourceById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.DeleteEnergySource(Moq.It.IsAny<int>())).Verifiable();

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            energySourceService.DeleteEnergySource(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetEnergySource_Success_Test()
        {
            // Arrange
            int id = 1;
            R_EnergySource energySource = SampleEnergySource(id);

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.GetEnergySource(Moq.It.IsAny<int>())).Returns(energySource);

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            EnergySourceDTO result = energySourceService.GetEnergySource(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EnergySourceId);
        }

        [TestMethod]
        public void GetEnergySources_Success_Test()
        {
            // Arrange
            R_EnergySource energySource = SampleEnergySource(1);
            
            IList<R_EnergySource> list = new List<R_EnergySource>();
            list.Add(energySource);

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.GetEnergySources()).Returns(list);

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            var resultList = energySourceService.GetEnergySources();
            EnergySourceDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EnergySourceId);
        }

        [TestMethod]
        public void GetEnergySourcesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_EnergySource> list = new List<R_EnergySource>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleEnergySource(i));
            }

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.GetEnergySources(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            var resultList = energySourceService.GetEnergySources(searchTerm, pageIndex, pageSize);
            EnergySourceDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EnergySourceId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetEnergySourceListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_EnergySource> list = new List<R_EnergySource>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleEnergySource(i));
            }

            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.GetEnergySourceListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            var resultList = energySourceService.GetEnergySourceListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            EnergySourceDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.EnergySourceId);
        }

        [TestMethod]
        public void UpdateEnergySource_Success_Test()
        {
            // Arrange
            EnergySourceDTO dto = SampleEnergySourceDTO(1);
            
            // create mock for repository
            var mock = new Mock<IEnergySourceRepository>();
            mock.Setup(s => s.UpdateEnergySource(Moq.It.IsAny<R_EnergySource>())).Verifiable();

            // service
            EnergySourceService energySourceService = new EnergySourceService();
            EnergySourceService.Repository = mock.Object;

            // Act
            energySourceService.UpdateEnergySource(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_EnergySource SampleEnergySource(int id = 1)
        {
            R_EnergySource energySource = new R_EnergySource();

            // int
            energySource.EnergySourceId = id;
            // string
            energySource.Name = "NameTestValue";
            // string
            energySource.Description = "DescriptionTestValue";
            // bool
            energySource.Active = false;
            // bool
            energySource.IsDeleted = false;
            // int?
            energySource.CreateBy = 1;
            // System.DateTime?
            energySource.CreateOn = new System.DateTime();
            // int?
            energySource.UpdateBy = 1;
            // System.DateTime?
            energySource.UpdateOn = new System.DateTime();
            
            return energySource;
        }
        
        public static EnergySourceDTO SampleEnergySourceDTO(int id = 1)
        {
            EnergySourceDTO energySource = new EnergySourceDTO();

            // int
            energySource.EnergySourceId = id;
            // string
            energySource.Name = "NameTestValue";
            // string
            energySource.Description = "DescriptionTestValue";
            // bool
            energySource.Active = false;
            // bool
            energySource.IsDeleted = false;
            // int?
            energySource.CreateBy = 1;
            // System.DateTime?
            energySource.CreateOn = new System.DateTime();
            // int?
            energySource.UpdateBy = 1;
            // System.DateTime?
            energySource.UpdateOn = new System.DateTime();
            
            return energySource;
        }
        
    }
}

    