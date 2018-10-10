
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
    public partial class RefoodUserServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddRefoodUser_Success_Test()
        {
            // Arrange
            RefoodUserDTO dto = SampleRefoodUserDTO(1);

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.AddRefoodUser(Moq.It.IsAny<R_RefoodUser>())).Returns(1);

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            int id = refoodUserService.AddRefoodUser(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.RefoodUserId);
        }

        [TestMethod]
        public void DeleteRefoodUser_Success_Test()
        {
            // Arrange
            RefoodUserDTO dto = SampleRefoodUserDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.DeleteRefoodUser(Moq.It.IsAny<R_RefoodUser>())).Verifiable();

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            refoodUserService.DeleteRefoodUser(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteRefoodUserById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.DeleteRefoodUser(Moq.It.IsAny<int>())).Verifiable();

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            refoodUserService.DeleteRefoodUser(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetRefoodUser_Success_Test()
        {
            // Arrange
            int id = 1;
            R_RefoodUser refoodUser = SampleRefoodUser(id);

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.GetRefoodUser(Moq.It.IsAny<int>())).Returns(refoodUser);

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            RefoodUserDTO result = refoodUserService.GetRefoodUser(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.RefoodUserId);
        }

        [TestMethod]
        public void GetRefoodUsers_Success_Test()
        {
            // Arrange
            R_RefoodUser refoodUser = SampleRefoodUser(1);
            
            IList<R_RefoodUser> list = new List<R_RefoodUser>();
            list.Add(refoodUser);

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.GetRefoodUsers()).Returns(list);

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            var resultList = refoodUserService.GetRefoodUsers();
            RefoodUserDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.RefoodUserId);
        }

        [TestMethod]
        public void GetRefoodUsersPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_RefoodUser> list = new List<R_RefoodUser>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleRefoodUser(i));
            }

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.GetRefoodUsers(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            var resultList = refoodUserService.GetRefoodUsers(searchTerm, pageIndex, pageSize);
            RefoodUserDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.RefoodUserId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetRefoodUserListAdvancedSearch_Success_Test()
        {
            // Arrange
            string username = null; 
            string fullname = null; 
            string email = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_RefoodUser> list = new List<R_RefoodUser>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleRefoodUser(i));
            }

            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.GetRefoodUserListAdvancedSearch(
                 Moq.It.IsAny<string>() // username 
                , Moq.It.IsAny<string>() // fullname 
                , Moq.It.IsAny<string>() // email 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            var resultList = refoodUserService.GetRefoodUserListAdvancedSearch(
                 username 
                , fullname 
                , email 
                , active 
            );
            
            RefoodUserDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.RefoodUserId);
        }

        [TestMethod]
        public void UpdateRefoodUser_Success_Test()
        {
            // Arrange
            RefoodUserDTO dto = SampleRefoodUserDTO(1);
            
            // create mock for repository
            var mock = new Mock<IRefoodUserRepository>();
            mock.Setup(s => s.UpdateRefoodUser(Moq.It.IsAny<R_RefoodUser>())).Verifiable();

            // service
            RefoodUserService refoodUserService = new RefoodUserService();
            RefoodUserService.Repository = mock.Object;

            // Act
            refoodUserService.UpdateRefoodUser(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_RefoodUser SampleRefoodUser(int id = 1)
        {
            R_RefoodUser refoodUser = new R_RefoodUser();

            // int
            refoodUser.RefoodUserId = id;
            // string
            refoodUser.Username = "UsernameTestValue";
            // string
            refoodUser.Fullname = "FullnameTestValue";
            // string
            refoodUser.Email = "EmailTestValue";
            // bool
            refoodUser.Active = false;
            // bool
            refoodUser.IsDeleted = false;
            // int?
            refoodUser.CreateBy = 1;
            // System.DateTime?
            refoodUser.CreateOn = new System.DateTime();
            // int?
            refoodUser.UpdateBy = 1;
            // System.DateTime?
            refoodUser.UpdateOn = new System.DateTime();
            
            return refoodUser;
        }
        
        public static RefoodUserDTO SampleRefoodUserDTO(int id = 1)
        {
            RefoodUserDTO refoodUser = new RefoodUserDTO();

            // int
            refoodUser.RefoodUserId = id;
            // string
            refoodUser.Username = "UsernameTestValue";
            // string
            refoodUser.Fullname = "FullnameTestValue";
            // string
            refoodUser.Email = "EmailTestValue";
            // bool
            refoodUser.Active = false;
            // bool
            refoodUser.IsDeleted = false;
            // int?
            refoodUser.CreateBy = 1;
            // System.DateTime?
            refoodUser.CreateOn = new System.DateTime();
            // int?
            refoodUser.UpdateBy = 1;
            // System.DateTime?
            refoodUser.UpdateOn = new System.DateTime();
            
            return refoodUser;
        }
        
    }
}

    