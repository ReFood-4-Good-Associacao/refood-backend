
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
    public partial class WeekDayServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddWeekDay_Success_Test()
        {
            // Arrange
            WeekDayDTO dto = SampleWeekDayDTO(1);

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.AddWeekDay(Moq.It.IsAny<R_WeekDay>())).Returns(1);

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            int id = weekDayService.AddWeekDay(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.WeekDayId);
        }

        [TestMethod]
        public void DeleteWeekDay_Success_Test()
        {
            // Arrange
            WeekDayDTO dto = SampleWeekDayDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.DeleteWeekDay(Moq.It.IsAny<R_WeekDay>())).Verifiable();

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            weekDayService.DeleteWeekDay(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteWeekDayById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.DeleteWeekDay(Moq.It.IsAny<int>())).Verifiable();

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            weekDayService.DeleteWeekDay(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetWeekDay_Success_Test()
        {
            // Arrange
            int id = 1;
            R_WeekDay weekDay = SampleWeekDay(id);

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.GetWeekDay(Moq.It.IsAny<int>())).Returns(weekDay);

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            WeekDayDTO result = weekDayService.GetWeekDay(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.WeekDayId);
        }

        [TestMethod]
        public void GetWeekDays_Success_Test()
        {
            // Arrange
            R_WeekDay weekDay = SampleWeekDay(1);
            
            IList<R_WeekDay> list = new List<R_WeekDay>();
            list.Add(weekDay);

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.GetWeekDays()).Returns(list);

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            var resultList = weekDayService.GetWeekDays();
            WeekDayDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.WeekDayId);
        }

        [TestMethod]
        public void GetWeekDaysPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_WeekDay> list = new List<R_WeekDay>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleWeekDay(i));
            }

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.GetWeekDays(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            var resultList = weekDayService.GetWeekDays(searchTerm, pageIndex, pageSize);
            WeekDayDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.WeekDayId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetWeekDayListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            string name = null; 
            string description = null; 
            int? responsiblePersonId = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_WeekDay> list = new List<R_WeekDay>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleWeekDay(i));
            }

            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.GetWeekDayListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<int?>() // responsiblePersonId 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            var resultList = weekDayService.GetWeekDayListAdvancedSearch(
                 nucleoId 
                , name 
                , description 
                , responsiblePersonId 
                , active 
            );
            
            WeekDayDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.WeekDayId);
        }

        [TestMethod]
        public void UpdateWeekDay_Success_Test()
        {
            // Arrange
            WeekDayDTO dto = SampleWeekDayDTO(1);
            
            // create mock for repository
            var mock = new Mock<IWeekDayRepository>();
            mock.Setup(s => s.UpdateWeekDay(Moq.It.IsAny<R_WeekDay>())).Verifiable();

            // service
            WeekDayService weekDayService = new WeekDayService();
            WeekDayService.Repository = mock.Object;

            // Act
            weekDayService.UpdateWeekDay(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_WeekDay SampleWeekDay(int id = 1)
        {
            R_WeekDay weekDay = new R_WeekDay();

            // int
            weekDay.WeekDayId = id;
            // int?
            weekDay.NucleoId = 1;
            // string
            weekDay.Name = "NameTestValue";
            // string
            weekDay.Description = "DescriptionTestValue";
            // int?
            weekDay.ResponsiblePersonId = 1;
            // bool
            weekDay.Active = false;
            // bool
            weekDay.IsDeleted = false;
            // int?
            weekDay.CreateBy = 1;
            // System.DateTime?
            weekDay.CreateOn = new System.DateTime();
            // int?
            weekDay.UpdateBy = 1;
            // System.DateTime?
            weekDay.UpdateOn = new System.DateTime();
            
            return weekDay;
        }
        
        public static WeekDayDTO SampleWeekDayDTO(int id = 1)
        {
            WeekDayDTO weekDay = new WeekDayDTO();

            // int
            weekDay.WeekDayId = id;
            // int?
            weekDay.NucleoId = 1;
            // string
            weekDay.Name = "NameTestValue";
            // string
            weekDay.Description = "DescriptionTestValue";
            // int?
            weekDay.ResponsiblePersonId = 1;
            // bool
            weekDay.Active = false;
            // bool
            weekDay.IsDeleted = false;
            // int?
            weekDay.CreateBy = 1;
            // System.DateTime?
            weekDay.CreateOn = new System.DateTime();
            // int?
            weekDay.UpdateBy = 1;
            // System.DateTime?
            weekDay.UpdateOn = new System.DateTime();
            
            return weekDay;
        }
        
    }
}

    