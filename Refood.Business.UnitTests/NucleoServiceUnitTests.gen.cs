
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
    public partial class NucleoServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddNucleo_Success_Test()
        {
            // Arrange
            NucleoDTO dto = SampleNucleoDTO(1);

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.AddNucleo(Moq.It.IsAny<R_Nucleo>())).Returns(1);

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            int id = nucleoService.AddNucleo(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.NucleoId);
        }

        [TestMethod]
        public void DeleteNucleo_Success_Test()
        {
            // Arrange
            NucleoDTO dto = SampleNucleoDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.DeleteNucleo(Moq.It.IsAny<R_Nucleo>())).Verifiable();

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            nucleoService.DeleteNucleo(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteNucleoById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.DeleteNucleo(Moq.It.IsAny<int>())).Verifiable();

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            nucleoService.DeleteNucleo(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetNucleo_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Nucleo nucleo = SampleNucleo(id);

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.GetNucleo(Moq.It.IsAny<int>())).Returns(nucleo);

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            NucleoDTO result = nucleoService.GetNucleo(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.NucleoId);
        }

        [TestMethod]
        public void GetNucleos_Success_Test()
        {
            // Arrange
            R_Nucleo nucleo = SampleNucleo(1);
            
            IList<R_Nucleo> list = new List<R_Nucleo>();
            list.Add(nucleo);

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.GetNucleos()).Returns(list);

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            var resultList = nucleoService.GetNucleos();
            NucleoDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.NucleoId);
        }

        [TestMethod]
        public void GetNucleosPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Nucleo> list = new List<R_Nucleo>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleNucleo(i));
            }

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.GetNucleos(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            var resultList = nucleoService.GetNucleos(searchTerm, pageIndex, pageSize);
            NucleoDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.NucleoId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetNucleoListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string personResponsible = null; 
            int? photo = null; 
            int? addressId = null; 
            System.DateTime? openingDateFrom = null; 
            System.DateTime? openingDateTo = null; 
            string primaryPhoneNumber = null; 
            string primaryEmail = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Nucleo> list = new List<R_Nucleo>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleNucleo(i));
            }

            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.GetNucleoListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // personResponsible 
                , Moq.It.IsAny<int?>() // photo 
                , Moq.It.IsAny<int?>() // addressId 
                , Moq.It.IsAny<System.DateTime?>() // openingDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // openingDateTo 
                , Moq.It.IsAny<string>() // primaryPhoneNumber 
                , Moq.It.IsAny<string>() // primaryEmail 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            var resultList = nucleoService.GetNucleoListAdvancedSearch(
                 name 
                , personResponsible 
                , photo 
                , addressId 
                , openingDateFrom 
                , openingDateTo 
                , primaryPhoneNumber 
                , primaryEmail 
                , active 
            );
            
            NucleoDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.NucleoId);
        }

        [TestMethod]
        public void UpdateNucleo_Success_Test()
        {
            // Arrange
            NucleoDTO dto = SampleNucleoDTO(1);
            
            // create mock for repository
            var mock = new Mock<INucleoRepository>();
            mock.Setup(s => s.UpdateNucleo(Moq.It.IsAny<R_Nucleo>())).Verifiable();

            // service
            NucleoService nucleoService = new NucleoService();
            NucleoService.Repository = mock.Object;

            // Act
            nucleoService.UpdateNucleo(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Nucleo SampleNucleo(int id = 1)
        {
            R_Nucleo nucleo = new R_Nucleo();

            // int
            nucleo.NucleoId = id;
            // string
            nucleo.Name = "NameTestValue";
            // string
            nucleo.PersonResponsible = "PersonResponsibleTestValue";
            // int?
            nucleo.Photo = 1;
            // int?
            nucleo.AddressId = 1;
            // System.DateTime?
            nucleo.OpeningDate = new System.DateTime();
            // string
            nucleo.PrimaryPhoneNumber = "PrimaryPhoneNumberTestValue";
            // string
            nucleo.PrimaryEmail = "PrimaryEmailTestValue";
            // bool
            nucleo.Active = false;
            // bool
            nucleo.IsDeleted = false;
            // int?
            nucleo.CreateBy = 1;
            // System.DateTime?
            nucleo.CreateOn = new System.DateTime();
            // int?
            nucleo.UpdateBy = 1;
            // System.DateTime?
            nucleo.UpdateOn = new System.DateTime();
            
            return nucleo;
        }
        
        public static NucleoDTO SampleNucleoDTO(int id = 1)
        {
            NucleoDTO nucleo = new NucleoDTO();

            // int
            nucleo.NucleoId = id;
            // string
            nucleo.Name = "NameTestValue";
            // string
            nucleo.PersonResponsible = "PersonResponsibleTestValue";
            // int?
            nucleo.Photo = 1;
            // int?
            nucleo.AddressId = 1;
            // System.DateTime?
            nucleo.OpeningDate = new System.DateTime();
            // string
            nucleo.PrimaryPhoneNumber = "PrimaryPhoneNumberTestValue";
            // string
            nucleo.PrimaryEmail = "PrimaryEmailTestValue";
            // bool
            nucleo.Active = false;
            // bool
            nucleo.IsDeleted = false;
            // int?
            nucleo.CreateBy = 1;
            // System.DateTime?
            nucleo.CreateOn = new System.DateTime();
            // int?
            nucleo.UpdateBy = 1;
            // System.DateTime?
            nucleo.UpdateOn = new System.DateTime();
            
            return nucleo;
        }
        
    }
}

    