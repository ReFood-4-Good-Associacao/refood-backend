
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
    public partial class TaskTypeServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddTaskType_Success_Test()
        {
            // Arrange
            TaskTypeDTO dto = SampleTaskTypeDTO(1);

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.AddTaskType(Moq.It.IsAny<R_TaskType>())).Returns(1);

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            int id = taskTypeService.AddTaskType(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.TaskTypeId);
        }

        [TestMethod]
        public void DeleteTaskType_Success_Test()
        {
            // Arrange
            TaskTypeDTO dto = SampleTaskTypeDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.DeleteTaskType(Moq.It.IsAny<R_TaskType>())).Verifiable();

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            taskTypeService.DeleteTaskType(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteTaskTypeById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.DeleteTaskType(Moq.It.IsAny<int>())).Verifiable();

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            taskTypeService.DeleteTaskType(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetTaskType_Success_Test()
        {
            // Arrange
            int id = 1;
            R_TaskType taskType = SampleTaskType(id);

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.GetTaskType(Moq.It.IsAny<int>())).Returns(taskType);

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            TaskTypeDTO result = taskTypeService.GetTaskType(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskTypeId);
        }

        [TestMethod]
        public void GetTaskTypes_Success_Test()
        {
            // Arrange
            R_TaskType taskType = SampleTaskType(1);
            
            IList<R_TaskType> list = new List<R_TaskType>();
            list.Add(taskType);

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.GetTaskTypes()).Returns(list);

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            var resultList = taskTypeService.GetTaskTypes();
            TaskTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskTypeId);
        }

        [TestMethod]
        public void GetTaskTypesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_TaskType> list = new List<R_TaskType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTaskType(i));
            }

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.GetTaskTypes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            var resultList = taskTypeService.GetTaskTypes(searchTerm, pageIndex, pageSize);
            TaskTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskTypeId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetTaskTypeListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_TaskType> list = new List<R_TaskType>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTaskType(i));
            }

            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.GetTaskTypeListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            var resultList = taskTypeService.GetTaskTypeListAdvancedSearch(
                 name 
                , description 
                , active 
            );
            
            TaskTypeDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskTypeId);
        }

        [TestMethod]
        public void UpdateTaskType_Success_Test()
        {
            // Arrange
            TaskTypeDTO dto = SampleTaskTypeDTO(1);
            
            // create mock for repository
            var mock = new Mock<ITaskTypeRepository>();
            mock.Setup(s => s.UpdateTaskType(Moq.It.IsAny<R_TaskType>())).Verifiable();

            // service
            TaskTypeService taskTypeService = new TaskTypeService();
            TaskTypeService.Repository = mock.Object;

            // Act
            taskTypeService.UpdateTaskType(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_TaskType SampleTaskType(int id = 1)
        {
            R_TaskType taskType = new R_TaskType();

            // int
            taskType.TaskTypeId = id;
            // string
            taskType.Name = "NameTestValue";
            // string
            taskType.Description = "DescriptionTestValue";
            // bool
            taskType.Active = false;
            // bool
            taskType.IsDeleted = false;
            // int?
            taskType.CreateBy = 1;
            // System.DateTime?
            taskType.CreateOn = new System.DateTime();
            // int?
            taskType.UpdateBy = 1;
            // System.DateTime?
            taskType.UpdateOn = new System.DateTime();
            
            return taskType;
        }
        
        public static TaskTypeDTO SampleTaskTypeDTO(int id = 1)
        {
            TaskTypeDTO taskType = new TaskTypeDTO();

            // int
            taskType.TaskTypeId = id;
            // string
            taskType.Name = "NameTestValue";
            // string
            taskType.Description = "DescriptionTestValue";
            // bool
            taskType.Active = false;
            // bool
            taskType.IsDeleted = false;
            // int?
            taskType.CreateBy = 1;
            // System.DateTime?
            taskType.CreateOn = new System.DateTime();
            // int?
            taskType.UpdateBy = 1;
            // System.DateTime?
            taskType.UpdateOn = new System.DateTime();
            
            return taskType;
        }
        
    }
}

    