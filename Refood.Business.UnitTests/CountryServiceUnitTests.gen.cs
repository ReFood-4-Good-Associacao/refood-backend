
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
    public partial class CountryServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddCountry_Success_Test()
        {
            // Arrange
            CountryDTO dto = SampleCountryDTO(1);

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.AddCountry(Moq.It.IsAny<R_Country>())).Returns(1);

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            int id = countryService.AddCountry(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.CountryId);
        }

        [TestMethod]
        public void DeleteCountry_Success_Test()
        {
            // Arrange
            CountryDTO dto = SampleCountryDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.DeleteCountry(Moq.It.IsAny<R_Country>())).Verifiable();

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            countryService.DeleteCountry(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteCountryById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.DeleteCountry(Moq.It.IsAny<int>())).Verifiable();

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            countryService.DeleteCountry(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetCountry_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Country country = SampleCountry(id);

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.GetCountry(Moq.It.IsAny<int>())).Returns(country);

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            CountryDTO result = countryService.GetCountry(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CountryId);
        }

        [TestMethod]
        public void GetCountrys_Success_Test()
        {
            // Arrange
            R_Country country = SampleCountry(1);
            
            IList<R_Country> list = new List<R_Country>();
            list.Add(country);

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.GetCountrys()).Returns(list);

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            var resultList = countryService.GetCountrys();
            CountryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CountryId);
        }

        [TestMethod]
        public void GetCountrysPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Country> list = new List<R_Country>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleCountry(i));
            }

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.GetCountrys(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            var resultList = countryService.GetCountrys(searchTerm, pageIndex, pageSize);
            CountryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CountryId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetCountryListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string englishName = null; 
            string isoCode = null; 
            string capitalCity = null; 
            double? latitude = null; 
            double? longitude = null; 
            double? phonePrefix = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Country> list = new List<R_Country>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleCountry(i));
            }

            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.GetCountryListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // englishName 
                , Moq.It.IsAny<string>() // isoCode 
                , Moq.It.IsAny<string>() // capitalCity 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<double?>() // phonePrefix 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            var resultList = countryService.GetCountryListAdvancedSearch(
                 name 
                , englishName 
                , isoCode 
                , capitalCity 
                , latitude 
                , longitude 
                , phonePrefix 
                , active 
            );
            
            CountryDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.CountryId);
        }

        [TestMethod]
        public void UpdateCountry_Success_Test()
        {
            // Arrange
            CountryDTO dto = SampleCountryDTO(1);
            
            // create mock for repository
            var mock = new Mock<ICountryRepository>();
            mock.Setup(s => s.UpdateCountry(Moq.It.IsAny<R_Country>())).Verifiable();

            // service
            CountryService countryService = new CountryService();
            CountryService.Repository = mock.Object;

            // Act
            countryService.UpdateCountry(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Country SampleCountry(int id = 1)
        {
            R_Country country = new R_Country();

            // int
            country.CountryId = id;
            // string
            country.Name = "NameTestValue";
            // string
            country.EnglishName = "EnglishNameTestValue";
            // string
            country.IsoCode = "IsoCodeTestValue";
            // string
            country.CapitalCity = "CapitalCityTestValue";
            // double?
            country.Latitude = 1;
            // double?
            country.Longitude = 1;
            // double?
            country.PhonePrefix = 1;
            // bool
            country.Active = false;
            // bool
            country.IsDeleted = false;
            // int?
            country.CreateBy = 1;
            // System.DateTime?
            country.CreateOn = new System.DateTime();
            // int?
            country.UpdateBy = 1;
            // System.DateTime?
            country.UpdateOn = new System.DateTime();
            
            return country;
        }
        
        public static CountryDTO SampleCountryDTO(int id = 1)
        {
            CountryDTO country = new CountryDTO();

            // int
            country.CountryId = id;
            // string
            country.Name = "NameTestValue";
            // string
            country.EnglishName = "EnglishNameTestValue";
            // string
            country.IsoCode = "IsoCodeTestValue";
            // string
            country.CapitalCity = "CapitalCityTestValue";
            // double?
            country.Latitude = 1;
            // double?
            country.Longitude = 1;
            // double?
            country.PhonePrefix = 1;
            // bool
            country.Active = false;
            // bool
            country.IsDeleted = false;
            // int?
            country.CreateBy = 1;
            // System.DateTime?
            country.CreateOn = new System.DateTime();
            // int?
            country.UpdateBy = 1;
            // System.DateTime?
            country.UpdateOn = new System.DateTime();
            
            return country;
        }
        
    }
}

    