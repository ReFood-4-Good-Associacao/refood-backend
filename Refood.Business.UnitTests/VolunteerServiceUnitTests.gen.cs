
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
    public partial class VolunteerServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddVolunteer_Success_Test()
        {
            // Arrange
            VolunteerDTO dto = SampleVolunteerDTO(1);

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.AddVolunteer(Moq.It.IsAny<R_Volunteer>())).Returns(1);

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            int id = volunteerService.AddVolunteer(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.VolunteerId);
        }

        [TestMethod]
        public void DeleteVolunteer_Success_Test()
        {
            // Arrange
            VolunteerDTO dto = SampleVolunteerDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.DeleteVolunteer(Moq.It.IsAny<R_Volunteer>())).Verifiable();

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            volunteerService.DeleteVolunteer(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteVolunteerById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.DeleteVolunteer(Moq.It.IsAny<int>())).Verifiable();

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            volunteerService.DeleteVolunteer(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetVolunteer_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Volunteer volunteer = SampleVolunteer(id);

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.GetVolunteer(Moq.It.IsAny<int>())).Returns(volunteer);

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            VolunteerDTO result = volunteerService.GetVolunteer(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VolunteerId);
        }

        [TestMethod]
        public void GetVolunteers_Success_Test()
        {
            // Arrange
            R_Volunteer volunteer = SampleVolunteer(1);
            
            IList<R_Volunteer> list = new List<R_Volunteer>();
            list.Add(volunteer);

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.GetVolunteers()).Returns(list);

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            var resultList = volunteerService.GetVolunteers();
            VolunteerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VolunteerId);
        }

        [TestMethod]
        public void GetVolunteersPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Volunteer> list = new List<R_Volunteer>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleVolunteer(i));
            }

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.GetVolunteers(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            var resultList = volunteerService.GetVolunteers(searchTerm, pageIndex, pageSize);
            VolunteerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VolunteerId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetVolunteerListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            int? gender = null; 
            System.DateTime? birthDateFrom = null; 
            System.DateTime? birthDateTo = null; 
            string occupation = null; 
            string employer = null; 
            string phone = null; 
            string email = null; 
            string identityCardNumber = null; 
            int? countryId = null; 
            string friendOrFamilyContact = null; 
            int? photo = null; 
            int? addressId = null; 
            bool? hasCar = null; 
            bool? hasDriverLicense = null; 
            bool? hasBike = null; 
            string vehicleMake = null; 
            string vehicleModel = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Volunteer> list = new List<R_Volunteer>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleVolunteer(i));
            }

            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.GetVolunteerListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<int?>() // gender 
                , Moq.It.IsAny<System.DateTime?>() // birthDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // birthDateTo 
                , Moq.It.IsAny<string>() // occupation 
                , Moq.It.IsAny<string>() // employer 
                , Moq.It.IsAny<string>() // phone 
                , Moq.It.IsAny<string>() // email 
                , Moq.It.IsAny<string>() // identityCardNumber 
                , Moq.It.IsAny<int?>() // countryId 
                , Moq.It.IsAny<string>() // friendOrFamilyContact 
                , Moq.It.IsAny<int?>() // photo 
                , Moq.It.IsAny<int?>() // addressId 
                , Moq.It.IsAny<bool?>() // hasCar 
                , Moq.It.IsAny<bool?>() // hasDriverLicense 
                , Moq.It.IsAny<bool?>() // hasBike 
                , Moq.It.IsAny<string>() // vehicleMake 
                , Moq.It.IsAny<string>() // vehicleModel 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            var resultList = volunteerService.GetVolunteerListAdvancedSearch(
                 name 
                , gender 
                , birthDateFrom 
                , birthDateTo 
                , occupation 
                , employer 
                , phone 
                , email 
                , identityCardNumber 
                , countryId 
                , friendOrFamilyContact 
                , photo 
                , addressId 
                , hasCar 
                , hasDriverLicense 
                , hasBike 
                , vehicleMake 
                , vehicleModel 
                , active 
            );
            
            VolunteerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.VolunteerId);
        }

        [TestMethod]
        public void UpdateVolunteer_Success_Test()
        {
            // Arrange
            VolunteerDTO dto = SampleVolunteerDTO(1);
            
            // create mock for repository
            var mock = new Mock<IVolunteerRepository>();
            mock.Setup(s => s.UpdateVolunteer(Moq.It.IsAny<R_Volunteer>())).Verifiable();

            // service
            VolunteerService volunteerService = new VolunteerService();
            VolunteerService.Repository = mock.Object;

            // Act
            volunteerService.UpdateVolunteer(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Volunteer SampleVolunteer(int id = 1)
        {
            R_Volunteer volunteer = new R_Volunteer();

            // int
            volunteer.VolunteerId = id;
            // string
            volunteer.Name = "NameTestValue";
            // int?
            volunteer.Gender = 1;
            // System.DateTime?
            volunteer.BirthDate = new System.DateTime();
            // string
            volunteer.Occupation = "OccupationTestValue";
            // string
            volunteer.Employer = "EmployerTestValue";
            // string
            volunteer.Phone = "PhoneTestValue";
            // string
            volunteer.Email = "EmailTestValue";
            // string
            volunteer.IdentityCardNumber = "IdentityCardNumberTestValue";
            // int?
            volunteer.CountryId = 1;
            // string
            volunteer.FriendOrFamilyContact = "FriendOrFamilyContactTestValue";
            // int?
            volunteer.Photo = 1;
            // int?
            volunteer.AddressId = 1;
            // bool
            volunteer.HasCar = false;
            // bool
            volunteer.HasDriverLicense = false;
            // bool
            volunteer.HasBike = false;
            // string
            volunteer.VehicleMake = "VehicleMakeTestValue";
            // string
            volunteer.VehicleModel = "VehicleModelTestValue";
            // bool
            volunteer.Active = false;
            // bool
            volunteer.IsDeleted = false;
            // int?
            volunteer.CreateBy = 1;
            // System.DateTime?
            volunteer.CreateOn = new System.DateTime();
            // int?
            volunteer.UpdateBy = 1;
            // System.DateTime?
            volunteer.UpdateOn = new System.DateTime();
            
            return volunteer;
        }
        
        public static VolunteerDTO SampleVolunteerDTO(int id = 1)
        {
            VolunteerDTO volunteer = new VolunteerDTO();

            // int
            volunteer.VolunteerId = id;
            // string
            volunteer.Name = "NameTestValue";
            // int?
            volunteer.Gender = 1;
            // System.DateTime?
            volunteer.BirthDate = new System.DateTime();
            // string
            volunteer.Occupation = "OccupationTestValue";
            // string
            volunteer.Employer = "EmployerTestValue";
            // string
            volunteer.Phone = "PhoneTestValue";
            // string
            volunteer.Email = "EmailTestValue";
            // string
            volunteer.IdentityCardNumber = "IdentityCardNumberTestValue";
            // int?
            volunteer.CountryId = 1;
            // string
            volunteer.FriendOrFamilyContact = "FriendOrFamilyContactTestValue";
            // int?
            volunteer.Photo = 1;
            // int?
            volunteer.AddressId = 1;
            // bool
            volunteer.HasCar = false;
            // bool
            volunteer.HasDriverLicense = false;
            // bool
            volunteer.HasBike = false;
            // string
            volunteer.VehicleMake = "VehicleMakeTestValue";
            // string
            volunteer.VehicleModel = "VehicleModelTestValue";
            // bool
            volunteer.Active = false;
            // bool
            volunteer.IsDeleted = false;
            // int?
            volunteer.CreateBy = 1;
            // System.DateTime?
            volunteer.CreateOn = new System.DateTime();
            // int?
            volunteer.UpdateBy = 1;
            // System.DateTime?
            volunteer.UpdateOn = new System.DateTime();
            
            return volunteer;
        }
        
    }
}

    