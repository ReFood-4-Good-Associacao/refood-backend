
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
    public partial class TaskServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddTask_Success_Test()
        {
            // Arrange
            TaskDTO dto = SampleTaskDTO(1);

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.AddTask(Moq.It.IsAny<R_Task>())).Returns(1);

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            int id = taskService.AddTask(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.TaskId);
        }

        [TestMethod]
        public void DeleteTask_Success_Test()
        {
            // Arrange
            TaskDTO dto = SampleTaskDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.DeleteTask(Moq.It.IsAny<R_Task>())).Verifiable();

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            taskService.DeleteTask(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteTaskById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.DeleteTask(Moq.It.IsAny<int>())).Verifiable();

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            taskService.DeleteTask(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetTask_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Task task = SampleTask(id);

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.GetTask(Moq.It.IsAny<int>())).Returns(task);

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            TaskDTO result = taskService.GetTask(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskId);
        }

        [TestMethod]
        public void GetTasks_Success_Test()
        {
            // Arrange
            R_Task task = SampleTask(1);
            
            IList<R_Task> list = new List<R_Task>();
            list.Add(task);

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.GetTasks()).Returns(list);

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            var resultList = taskService.GetTasks();
            TaskDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskId);
        }

        [TestMethod]
        public void GetTasksPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Task> list = new List<R_Task>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTask(i));
            }

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.GetTasks(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            var resultList = taskService.GetTasks(searchTerm, pageIndex, pageSize);
            TaskDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetTaskListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            int? taskTypeId = null; 
            System.DateTime? taskDateFrom = null; 
            System.DateTime? taskDateTo = null; 
            int? weekDay = null; 
            System.DateTime? startTimeFrom = null; 
            System.DateTime? startTimeTo = null; 
            System.DateTime? endTimeFrom = null; 
            System.DateTime? endTimeTo = null; 
            int? estimatedDuration = null; 
            string description = null; 
            bool? requiresCar = null; 
            int? teamLeaderId = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Task> list = new List<R_Task>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleTask(i));
            }

            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.GetTaskListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<int?>() // taskTypeId 
                , Moq.It.IsAny<System.DateTime?>() // taskDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // taskDateTo 
                , Moq.It.IsAny<int?>() // weekDay 
                , Moq.It.IsAny<System.DateTime?>() // startTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // startTimeTo 
                , Moq.It.IsAny<System.DateTime?>() // endTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // endTimeTo 
                , Moq.It.IsAny<int?>() // estimatedDuration 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<bool?>() // requiresCar 
                , Moq.It.IsAny<int?>() // teamLeaderId 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            var resultList = taskService.GetTaskListAdvancedSearch(
                 name 
                , taskTypeId 
                , taskDateFrom 
                , taskDateTo 
                , weekDay 
                , startTimeFrom 
                , startTimeTo 
                , endTimeFrom 
                , endTimeTo 
                , estimatedDuration 
                , description 
                , requiresCar 
                , teamLeaderId 
                , active 
            );
            
            TaskDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TaskId);
        }

        [TestMethod]
        public void UpdateTask_Success_Test()
        {
            // Arrange
            TaskDTO dto = SampleTaskDTO(1);
            
            // create mock for repository
            var mock = new Mock<ITaskRepository>();
            mock.Setup(s => s.UpdateTask(Moq.It.IsAny<R_Task>())).Verifiable();

            // service
            TaskService taskService = new TaskService();
            TaskService.Repository = mock.Object;

            // Act
            taskService.UpdateTask(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Task SampleTask(int id = 1)
        {
            R_Task task = new R_Task();

            // int
            task.TaskId = id;
            // string
            task.Name = "NameTestValue";
            // int?
            task.TaskTypeId = 1;
            // System.DateTime?
            task.TaskDate = new System.DateTime();
            // int?
            task.WeekDay = 1;
            // System.DateTime?
            task.StartTime = new System.DateTime();
            // System.DateTime?
            task.EndTime = new System.DateTime();
            // int?
            task.EstimatedDuration = 1;
            // string
            task.Description = "DescriptionTestValue";
            // bool?
            task.RequiresCar = false;
            // int?
            task.TeamLeaderId = 1;
            // bool
            task.Active = false;
            // bool
            task.IsDeleted = false;
            // int?
            task.CreateBy = 1;
            // System.DateTime?
            task.CreateOn = new System.DateTime();
            // int?
            task.UpdateBy = 1;
            // System.DateTime?
            task.UpdateOn = new System.DateTime();
            
            return task;
        }
        
        public static TaskDTO SampleTaskDTO(int id = 1)
        {
            TaskDTO task = new TaskDTO();

            // int
            task.TaskId = id;
            // string
            task.Name = "NameTestValue";
            // int?
            task.TaskTypeId = 1;
            // System.DateTime?
            task.TaskDate = new System.DateTime();
            // int?
            task.WeekDay = 1;
            // System.DateTime?
            task.StartTime = new System.DateTime();
            // System.DateTime?
            task.EndTime = new System.DateTime();
            // int?
            task.EstimatedDuration = 1;
            // string
            task.Description = "DescriptionTestValue";
            // bool?
            task.RequiresCar = false;
            // int?
            task.TeamLeaderId = 1;
            // bool
            task.Active = false;
            // bool
            task.IsDeleted = false;
            // int?
            task.CreateBy = 1;
            // System.DateTime?
            task.CreateOn = new System.DateTime();
            // int?
            task.UpdateBy = 1;
            // System.DateTime?
            task.UpdateOn = new System.DateTime();
            
            return task;
        }
        
    }
}

    