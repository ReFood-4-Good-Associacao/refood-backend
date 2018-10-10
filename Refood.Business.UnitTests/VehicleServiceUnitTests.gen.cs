
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
    public partial class VehicleServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddVehicle_Success_Test()
        {
            // Arrange
            VehicleDTO dto = SampleVehicleDTO(1);

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.AddVehicle(Moq.It.IsAny<R_Vehicle>())).Returns(1);

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            int id = vehicleService.AddVehicle(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.VehicleId);
        }

        [TestMethod]
        public void DeleteVehicle_Success_Test()
        {
            // Arrange
            VehicleDTO dto = SampleVehicleDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.DeleteVehicle(Moq.It.IsAny<R_Vehicle>())).Verifiable();

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            vehicleService.DeleteVehicle(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteVehicleById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.DeleteVehicle(Moq.It.IsAny<int>())).Verifiable();

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            vehicleService.DeleteVehicle(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetVehicle_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Vehicle vehicle = SampleVehicle(id);

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.GetVehicle(Moq.It.IsAny<int>())).Returns(vehicle);

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            VehicleDTO result = vehicleService.GetVehicle(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleId);
        }

        [TestMethod]
        public void GetVehicles_Success_Test()
        {
            // Arrange
            R_Vehicle vehicle = SampleVehicle(1);
            
            IList<R_Vehicle> list = new List<R_Vehicle>();
            list.Add(vehicle);

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.GetVehicles()).Returns(list);

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            var resultList = vehicleService.GetVehicles();
            VehicleDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleId);
        }

        [TestMethod]
        public void GetVehiclesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Vehicle> list = new List<R_Vehicle>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleVehicle(i));
            }

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.GetVehicles(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            var resultList = vehicleService.GetVehicles(searchTerm, pageIndex, pageSize);
            VehicleDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetVehicleListAdvancedSearch_Success_Test()
        {
            // Arrange
            string make = null; 
            string model = null; 
            string owner = null; 
            int? ownerId = null; 
            int? nucleoId = null; 
            int? vehicleTypeId = null; 
            int? energySourceId = null; 
            int? averageSpeed = null; 
            int? horsePower = null; 
            double? fuelConsumption = null; 
            double? fuelAutonomyDistance = null; 
            int? rechargeTime = null; 
            string licensePlate = null; 
            string color = null; 
            int? numberSeats = null; 
            int? cargoVolumeCapacity = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Vehicle> list = new List<R_Vehicle>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleVehicle(i));
            }

            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.GetVehicleListAdvancedSearch(
                 Moq.It.IsAny<string>() // make 
                , Moq.It.IsAny<string>() // model 
                , Moq.It.IsAny<string>() // owner 
                , Moq.It.IsAny<int?>() // ownerId 
                , Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<int?>() // vehicleTypeId 
                , Moq.It.IsAny<int?>() // energySourceId 
                , Moq.It.IsAny<int?>() // averageSpeed 
                , Moq.It.IsAny<int?>() // horsePower 
                , Moq.It.IsAny<double?>() // fuelConsumption 
                , Moq.It.IsAny<double?>() // fuelAutonomyDistance 
                , Moq.It.IsAny<int?>() // rechargeTime 
                , Moq.It.IsAny<string>() // licensePlate 
                , Moq.It.IsAny<string>() // color 
                , Moq.It.IsAny<int?>() // numberSeats 
                , Moq.It.IsAny<int?>() // cargoVolumeCapacity 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            var resultList = vehicleService.GetVehicleListAdvancedSearch(
                 make 
                , model 
                , owner 
                , ownerId 
                , nucleoId 
                , vehicleTypeId 
                , energySourceId 
                , averageSpeed 
                , horsePower 
                , fuelConsumption 
                , fuelAutonomyDistance 
                , rechargeTime 
                , licensePlate 
                , color 
                , numberSeats 
                , cargoVolumeCapacity 
                , active 
            );
            
            VehicleDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VehicleId);
        }

        [TestMethod]
        public void UpdateVehicle_Success_Test()
        {
            // Arrange
            VehicleDTO dto = SampleVehicleDTO(1);
            
            // create mock for repository
            var mock = new Mock<IVehicleRepository>();
            mock.Setup(s => s.UpdateVehicle(Moq.It.IsAny<R_Vehicle>())).Verifiable();

            // service
            VehicleService vehicleService = new VehicleService();
            VehicleService.Repository = mock.Object;

            // Act
            vehicleService.UpdateVehicle(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Vehicle SampleVehicle(int id = 1)
        {
            R_Vehicle vehicle = new R_Vehicle();

            // int
            vehicle.VehicleId = id;
            // string
            vehicle.Make = "MakeTestValue";
            // string
            vehicle.Model = "ModelTestValue";
            // string
            vehicle.Owner = "OwnerTestValue";
            // int?
            vehicle.OwnerId = 1;
            // int?
            vehicle.NucleoId = 1;
            // int
            vehicle.VehicleTypeId = 1;
            // int
            vehicle.EnergySourceId = 1;
            // int?
            vehicle.AverageSpeed = 1;
            // int?
            vehicle.HorsePower = 1;
            // double?
            vehicle.FuelConsumption = 1;
            // double?
            vehicle.FuelAutonomyDistance = 1;
            // int?
            vehicle.RechargeTime = 1;
            // string
            vehicle.LicensePlate = "LicensePlateTestValue";
            // string
            vehicle.Color = "ColorTestValue";
            // int?
            vehicle.NumberSeats = 1;
            // int?
            vehicle.CargoVolumeCapacity = 1;
            // bool
            vehicle.Active = false;
            // bool
            vehicle.IsDeleted = false;
            // int?
            vehicle.CreateBy = 1;
            // System.DateTime?
            vehicle.CreateOn = new System.DateTime();
            // int?
            vehicle.UpdateBy = 1;
            // System.DateTime?
            vehicle.UpdateOn = new System.DateTime();
            
            return vehicle;
        }
        
        public static VehicleDTO SampleVehicleDTO(int id = 1)
        {
            VehicleDTO vehicle = new VehicleDTO();

            // int
            vehicle.VehicleId = id;
            // string
            vehicle.Make = "MakeTestValue";
            // string
            vehicle.Model = "ModelTestValue";
            // string
            vehicle.Owner = "OwnerTestValue";
            // int?
            vehicle.OwnerId = 1;
            // int?
            vehicle.NucleoId = 1;
            // int
            vehicle.VehicleTypeId = 1;
            // int
            vehicle.EnergySourceId = 1;
            // int?
            vehicle.AverageSpeed = 1;
            // int?
            vehicle.HorsePower = 1;
            // double?
            vehicle.FuelConsumption = 1;
            // double?
            vehicle.FuelAutonomyDistance = 1;
            // int?
            vehicle.RechargeTime = 1;
            // string
            vehicle.LicensePlate = "LicensePlateTestValue";
            // string
            vehicle.Color = "ColorTestValue";
            // int?
            vehicle.NumberSeats = 1;
            // int?
            vehicle.CargoVolumeCapacity = 1;
            // bool
            vehicle.Active = false;
            // bool
            vehicle.IsDeleted = false;
            // int?
            vehicle.CreateBy = 1;
            // System.DateTime?
            vehicle.CreateOn = new System.DateTime();
            // int?
            vehicle.UpdateBy = 1;
            // System.DateTime?
            vehicle.UpdateOn = new System.DateTime();
            
            return vehicle;
        }
        
    }
}

    