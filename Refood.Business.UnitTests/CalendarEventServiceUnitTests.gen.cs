
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
    public partial class CalendarEventServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddCalendarEvent_Success_Test()
        {
            // Arrange
            CalendarEventDTO dto = SampleCalendarEventDTO(1);

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.AddCalendarEvent(Moq.It.IsAny<R_CalendarEvent>())).Returns(1);

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            int id = calendarEventService.AddCalendarEvent(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.CalendarEventId);
        }

        [TestMethod]
        public void DeleteCalendarEvent_Success_Test()
        {
            // Arrange
            CalendarEventDTO dto = SampleCalendarEventDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.DeleteCalendarEvent(Moq.It.IsAny<R_CalendarEvent>())).Verifiable();

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            calendarEventService.DeleteCalendarEvent(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteCalendarEventById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.DeleteCalendarEvent(Moq.It.IsAny<int>())).Verifiable();

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            calendarEventService.DeleteCalendarEvent(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetCalendarEvent_Success_Test()
        {
            // Arrange
            int id = 1;
            R_CalendarEvent calendarEvent = SampleCalendarEvent(id);

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.GetCalendarEvent(Moq.It.IsAny<int>())).Returns(calendarEvent);

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            CalendarEventDTO result = calendarEventService.GetCalendarEvent(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CalendarEventId);
        }

        [TestMethod]
        public void GetCalendarEvents_Success_Test()
        {
            // Arrange
            R_CalendarEvent calendarEvent = SampleCalendarEvent(1);
            
            IList<R_CalendarEvent> list = new List<R_CalendarEvent>();
            list.Add(calendarEvent);

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.GetCalendarEvents()).Returns(list);

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            var resultList = calendarEventService.GetCalendarEvents();
            CalendarEventDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CalendarEventId);
        }

        [TestMethod]
        public void GetCalendarEventsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_CalendarEvent> list = new List<R_CalendarEvent>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleCalendarEvent(i));
            }

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.GetCalendarEvents(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            var resultList = calendarEventService.GetCalendarEvents(searchTerm, pageIndex, pageSize);
            CalendarEventDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CalendarEventId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetCalendarEventListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            string name = null; 
            string description = null; 
            System.DateTime? startDateFrom = null; 
            System.DateTime? startDateTo = null; 
            System.DateTime? endDateFrom = null; 
            System.DateTime? endDateTo = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_CalendarEvent> list = new List<R_CalendarEvent>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleCalendarEvent(i));
            }

            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.GetCalendarEventListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<System.DateTime?>() // startDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // startDateTo 
                , Moq.It.IsAny<System.DateTime?>() // endDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // endDateTo 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            var resultList = calendarEventService.GetCalendarEventListAdvancedSearch(
                 nucleoId 
                , name 
                , description 
                , startDateFrom 
                , startDateTo 
                , endDateFrom 
                , endDateTo 
                , active 
            );
            
            CalendarEventDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CalendarEventId);
        }

        [TestMethod]
        public void UpdateCalendarEvent_Success_Test()
        {
            // Arrange
            CalendarEventDTO dto = SampleCalendarEventDTO(1);
            
            // create mock for repository
            var mock = new Mock<ICalendarEventRepository>();
            mock.Setup(s => s.UpdateCalendarEvent(Moq.It.IsAny<R_CalendarEvent>())).Verifiable();

            // service
            CalendarEventService calendarEventService = new CalendarEventService();
            CalendarEventService.Repository = mock.Object;

            // Act
            calendarEventService.UpdateCalendarEvent(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_CalendarEvent SampleCalendarEvent(int id = 1)
        {
            R_CalendarEvent calendarEvent = new R_CalendarEvent();

            // int
            calendarEvent.CalendarEventId = id;
            // int?
            calendarEvent.NucleoId = 1;
            // string
            calendarEvent.Name = "NameTestValue";
            // string
            calendarEvent.Description = "DescriptionTestValue";
            // System.DateTime
            calendarEvent.StartDate = new System.DateTime();
            // System.DateTime
            calendarEvent.EndDate = new System.DateTime();
            // bool
            calendarEvent.Active = false;
            // bool
            calendarEvent.IsDeleted = false;
            // int?
            calendarEvent.CreateBy = 1;
            // System.DateTime?
            calendarEvent.CreateOn = new System.DateTime();
            // int?
            calendarEvent.UpdateBy = 1;
            // System.DateTime?
            calendarEvent.UpdateOn = new System.DateTime();
            
            return calendarEvent;
        }
        
        public static CalendarEventDTO SampleCalendarEventDTO(int id = 1)
        {
            CalendarEventDTO calendarEvent = new CalendarEventDTO();

            // int
            calendarEvent.CalendarEventId = id;
            // int?
            calendarEvent.NucleoId = 1;
            // string
            calendarEvent.Name = "NameTestValue";
            // string
            calendarEvent.Description = "DescriptionTestValue";
            // System.DateTime
            calendarEvent.StartDate = new System.DateTime();
            // System.DateTime
            calendarEvent.EndDate = new System.DateTime();
            // bool
            calendarEvent.Active = false;
            // bool
            calendarEvent.IsDeleted = false;
            // int?
            calendarEvent.CreateBy = 1;
            // System.DateTime?
            calendarEvent.CreateOn = new System.DateTime();
            // int?
            calendarEvent.UpdateBy = 1;
            // System.DateTime?
            calendarEvent.UpdateOn = new System.DateTime();
            
            return calendarEvent;
        }
        
    }
}

    