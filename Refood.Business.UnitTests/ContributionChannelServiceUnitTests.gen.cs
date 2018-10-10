
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
    public partial class ContributionChannelServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddContributionChannel_Success_Test()
        {
            // Arrange
            ContributionChannelDTO dto = SampleContributionChannelDTO(1);

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.AddContributionChannel(Moq.It.IsAny<R_ContributionChannel>())).Returns(1);

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            int id = contributionChannelService.AddContributionChannel(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.ContributionChannelId);
        }

        [TestMethod]
        public void DeleteContributionChannel_Success_Test()
        {
            // Arrange
            ContributionChannelDTO dto = SampleContributionChannelDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.DeleteContributionChannel(Moq.It.IsAny<R_ContributionChannel>())).Verifiable();

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            contributionChannelService.DeleteContributionChannel(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteContributionChannelById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.DeleteContributionChannel(Moq.It.IsAny<int>())).Verifiable();

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            contributionChannelService.DeleteContributionChannel(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetContributionChannel_Success_Test()
        {
            // Arrange
            int id = 1;
            R_ContributionChannel contributionChannel = SampleContributionChannel(id);

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.GetContributionChannel(Moq.It.IsAny<int>())).Returns(contributionChannel);

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            ContributionChannelDTO result = contributionChannelService.GetContributionChannel(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionChannelId);
        }

        [TestMethod]
        public void GetContributionChannels_Success_Test()
        {
            // Arrange
            R_ContributionChannel contributionChannel = SampleContributionChannel(1);
            
            IList<R_ContributionChannel> list = new List<R_ContributionChannel>();
            list.Add(contributionChannel);

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.GetContributionChannels()).Returns(list);

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            var resultList = contributionChannelService.GetContributionChannels();
            ContributionChannelDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionChannelId);
        }

        [TestMethod]
        public void GetContributionChannelsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionChannel> list = new List<R_ContributionChannel>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionChannel(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.GetContributionChannels(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            var resultList = contributionChannelService.GetContributionChannels(searchTerm, pageIndex, pageSize);
            ContributionChannelDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionChannelId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetContributionChannelListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_ContributionChannel> list = new List<R_ContributionChannel>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleContributionChannel(i));
            }

            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.GetContributionChannelListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            var resultList = contributionChannelService.GetContributionChannelListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            ContributionChannelDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ContributionChannelId);
        }

        [TestMethod]
        public void UpdateContributionChannel_Success_Test()
        {
            // Arrange
            ContributionChannelDTO dto = SampleContributionChannelDTO(1);
            
            // create mock for repository
            var mock = new Mock<IContributionChannelRepository>();
            mock.Setup(s => s.UpdateContributionChannel(Moq.It.IsAny<R_ContributionChannel>())).Verifiable();

            // service
            ContributionChannelService contributionChannelService = new ContributionChannelService();
            ContributionChannelService.Repository = mock.Object;

            // Act
            contributionChannelService.UpdateContributionChannel(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_ContributionChannel SampleContributionChannel(int id = 1)
        {
            R_ContributionChannel contributionChannel = new R_ContributionChannel();

            // int
            contributionChannel.ContributionChannelId = id;
            // string
            contributionChannel.Name = "NameTestValue";
            // string
            contributionChannel.Description = "DescriptionTestValue";
            // bool
            contributionChannel.Active = false;
            // bool
            contributionChannel.IsDeleted = false;
            // int?
            contributionChannel.CreateBy = 1;
            // System.DateTime?
            contributionChannel.CreateOn = new System.DateTime();
            // int?
            contributionChannel.UpdateBy = 1;
            // System.DateTime?
            contributionChannel.UpdateOn = new System.DateTime();
            
            return contributionChannel;
        }
        
        public static ContributionChannelDTO SampleContributionChannelDTO(int id = 1)
        {
            ContributionChannelDTO contributionChannel = new ContributionChannelDTO();

            // int
            contributionChannel.ContributionChannelId = id;
            // string
            contributionChannel.Name = "NameTestValue";
            // string
            contributionChannel.Description = "DescriptionTestValue";
            // bool
            contributionChannel.Active = false;
            // bool
            contributionChannel.IsDeleted = false;
            // int?
            contributionChannel.CreateBy = 1;
            // System.DateTime?
            contributionChannel.CreateOn = new System.DateTime();
            // int?
            contributionChannel.UpdateBy = 1;
            // System.DateTime?
            contributionChannel.UpdateOn = new System.DateTime();
            
            return contributionChannel;
        }
        
    }
}

    