
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
    public partial class TeamServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddTeam_Success_Test()
        {
            // Arrange
            TeamDTO dto = SampleTeamDTO(1);

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.AddTeam(Moq.It.IsAny<R_Team>())).Returns(1);

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            int id = teamService.AddTeam(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.TeamId);
        }

        [TestMethod]
        public void DeleteTeam_Success_Test()
        {
            // Arrange
            TeamDTO dto = SampleTeamDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.DeleteTeam(Moq.It.IsAny<R_Team>())).Verifiable();

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            teamService.DeleteTeam(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteTeamById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.DeleteTeam(Moq.It.IsAny<int>())).Verifiable();

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            teamService.DeleteTeam(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetTeam_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Team team = SampleTeam(id);

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.GetTeam(Moq.It.IsAny<int>())).Returns(team);

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            TeamDTO result = teamService.GetTeam(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TeamId);
        }

        [TestMethod]
        public void GetTeams_Success_Test()
        {
            // Arrange
            R_Team team = SampleTeam(1);
            
            IList<R_Team> list = new List<R_Team>();
            list.Add(team);

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.GetTeams()).Returns(list);

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            var resultList = teamService.GetTeams();
            TeamDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TeamId);
        }

        [TestMethod]
        public void GetTeamsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Team> list = new List<R_Team>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTeam(i));
            }

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.GetTeams(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            var resultList = teamService.GetTeams(searchTerm, pageIndex, pageSize);
            TeamDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TeamId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetTeamListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Team> list = new List<R_Team>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTeam(i));
            }

            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.GetTeamListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            var resultList = teamService.GetTeamListAdvancedSearch(
                 nucleoId 
                , name 
                , description 
                , active 
            );
            
            TeamDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TeamId);
        }

        [TestMethod]
        public void UpdateTeam_Success_Test()
        {
            // Arrange
            TeamDTO dto = SampleTeamDTO(1);
            
            // create mock for repository
            var mock = new Mock<ITeamRepository>();
            mock.Setup(s => s.UpdateTeam(Moq.It.IsAny<R_Team>())).Verifiable();

            // service
            TeamService teamService = new TeamService();
            TeamService.Repository = mock.Object;

            // Act
            teamService.UpdateTeam(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Team SampleTeam(int id = 1)
        {
            R_Team team = new R_Team();

            // int
            team.TeamId = id;
            // int?
            team.NucleoId = 1;
            // string
            team.Name = "NameTestValue";
            // string
            team.Description = "DescriptionTestValue";
            // bool
            team.Active = false;
            // bool
            team.IsDeleted = false;
            // int?
            team.CreateBy = 1;
            // System.DateTime?
            team.CreateOn = new System.DateTime();
            // int?
            team.UpdateBy = 1;
            // System.DateTime?
            team.UpdateOn = new System.DateTime();
            
            return team;
        }
        
        public static TeamDTO SampleTeamDTO(int id = 1)
        {
            TeamDTO team = new TeamDTO();

            // int
            team.TeamId = id;
            // int?
            team.NucleoId = 1;
            // string
            team.Name = "NameTestValue";
            // string
            team.Description = "DescriptionTestValue";
            // bool
            team.Active = false;
            // bool
            team.IsDeleted = false;
            // int?
            team.CreateBy = 1;
            // System.DateTime?
            team.CreateOn = new System.DateTime();
            // int?
            team.UpdateBy = 1;
            // System.DateTime?
            team.UpdateOn = new System.DateTime();
            
            return team;
        }
        
    }
}

    