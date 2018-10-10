
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
    public partial class PlannedRouteServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddPlannedRoute_Success_Test()
        {
            // Arrange
            PlannedRouteDTO dto = SamplePlannedRouteDTO(1);

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.AddPlannedRoute(Moq.It.IsAny<R_PlannedRoute>())).Returns(1);

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            int id = plannedRouteService.AddPlannedRoute(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.PlannedRouteId);
        }

        [TestMethod]
        public void DeletePlannedRoute_Success_Test()
        {
            // Arrange
            PlannedRouteDTO dto = SamplePlannedRouteDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.DeletePlannedRoute(Moq.It.IsAny<R_PlannedRoute>())).Verifiable();

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            plannedRouteService.DeletePlannedRoute(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeletePlannedRouteById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.DeletePlannedRoute(Moq.It.IsAny<int>())).Verifiable();

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            plannedRouteService.DeletePlannedRoute(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetPlannedRoute_Success_Test()
        {
            // Arrange
            int id = 1;
            R_PlannedRoute plannedRoute = SamplePlannedRoute(id);

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.GetPlannedRoute(Moq.It.IsAny<int>())).Returns(plannedRoute);

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            PlannedRouteDTO result = plannedRouteService.GetPlannedRoute(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PlannedRouteId);
        }

        [TestMethod]
        public void GetPlannedRoutes_Success_Test()
        {
            // Arrange
            R_PlannedRoute plannedRoute = SamplePlannedRoute(1);
            
            IList<R_PlannedRoute> list = new List<R_PlannedRoute>();
            list.Add(plannedRoute);

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.GetPlannedRoutes()).Returns(list);

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            var resultList = plannedRouteService.GetPlannedRoutes();
            PlannedRouteDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PlannedRouteId);
        }

        [TestMethod]
        public void GetPlannedRoutesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_PlannedRoute> list = new List<R_PlannedRoute>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SamplePlannedRoute(i));
            }

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.GetPlannedRoutes(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            var resultList = plannedRouteService.GetPlannedRoutes(searchTerm, pageIndex, pageSize);
            PlannedRouteDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PlannedRouteId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetPlannedRouteListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            int? routeTypeId = null; 
            int? transportTypeId = null; 
            string description = null; 
            System.DateTime? startHourFrom = null; 
            System.DateTime? startHourTo = null; 
            int? estimatedDuration = null; 
            double? totalDistance = null; 
            string routeDayOfTheWeek = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_PlannedRoute> list = new List<R_PlannedRoute>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SamplePlannedRoute(i));
            }

            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.GetPlannedRouteListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<int?>() // routeTypeId 
                , Moq.It.IsAny<int?>() // transportTypeId 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<System.DateTime?>() // startHourFrom 
                , Moq.It.IsAny<System.DateTime?>() // startHourTo 
                , Moq.It.IsAny<int?>() // estimatedDuration 
                , Moq.It.IsAny<double?>() // totalDistance 
                , Moq.It.IsAny<string>() // routeDayOfTheWeek 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            var resultList = plannedRouteService.GetPlannedRouteListAdvancedSearch(
                 name 
                , routeTypeId 
                , transportTypeId 
                , description 
                , startHourFrom 
                , startHourTo 
                , estimatedDuration 
                , totalDistance 
                , routeDayOfTheWeek 
                , active 
            );
            
            PlannedRouteDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PlannedRouteId);
        }

        [TestMethod]
        public void UpdatePlannedRoute_Success_Test()
        {
            // Arrange
            PlannedRouteDTO dto = SamplePlannedRouteDTO(1);
            
            // create mock for repository
            var mock = new Mock<IPlannedRouteRepository>();
            mock.Setup(s => s.UpdatePlannedRoute(Moq.It.IsAny<R_PlannedRoute>())).Verifiable();

            // service
            PlannedRouteService plannedRouteService = new PlannedRouteService();
            PlannedRouteService.Repository = mock.Object;

            // Act
            plannedRouteService.UpdatePlannedRoute(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_PlannedRoute SamplePlannedRoute(int id = 1)
        {
            R_PlannedRoute plannedRoute = new R_PlannedRoute();

            // int
            plannedRoute.PlannedRouteId = id;
            // string
            plannedRoute.Name = "NameTestValue";
            // int?
            plannedRoute.RouteTypeId = 1;
            // int?
            plannedRoute.TransportTypeId = 1;
            // string
            plannedRoute.Description = "DescriptionTestValue";
            // System.DateTime?
            plannedRoute.StartHour = new System.DateTime();
            // int?
            plannedRoute.EstimatedDuration = 1;
            // double?
            plannedRoute.TotalDistance = 1;
            // string
            plannedRoute.RouteDayOfTheWeek = "RouteDayOfTheWeekTestValue";
            // bool
            plannedRoute.Active = false;
            // bool
            plannedRoute.IsDeleted = false;
            // int?
            plannedRoute.CreateBy = 1;
            // System.DateTime?
            plannedRoute.CreateOn = new System.DateTime();
            // int?
            plannedRoute.UpdateBy = 1;
            // System.DateTime?
            plannedRoute.UpdateOn = new System.DateTime();
            
            return plannedRoute;
        }
        
        public static PlannedRouteDTO SamplePlannedRouteDTO(int id = 1)
        {
            PlannedRouteDTO plannedRoute = new PlannedRouteDTO();

            // int
            plannedRoute.PlannedRouteId = id;
            // string
            plannedRoute.Name = "NameTestValue";
            // int?
            plannedRoute.RouteTypeId = 1;
            // int?
            plannedRoute.TransportTypeId = 1;
            // string
            plannedRoute.Description = "DescriptionTestValue";
            // System.DateTime?
            plannedRoute.StartHour = new System.DateTime();
            // int?
            plannedRoute.EstimatedDuration = 1;
            // double?
            plannedRoute.TotalDistance = 1;
            // string
            plannedRoute.RouteDayOfTheWeek = "RouteDayOfTheWeekTestValue";
            // bool
            plannedRoute.Active = false;
            // bool
            plannedRoute.IsDeleted = false;
            // int?
            plannedRoute.CreateBy = 1;
            // System.DateTime?
            plannedRoute.CreateOn = new System.DateTime();
            // int?
            plannedRoute.UpdateBy = 1;
            // System.DateTime?
            plannedRoute.UpdateOn = new System.DateTime();
            
            return plannedRoute;
        }
        
    }
}

    