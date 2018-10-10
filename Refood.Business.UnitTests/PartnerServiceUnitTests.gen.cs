
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
    public partial class PartnerServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddPartner_Success_Test()
        {
            // Arrange
            PartnerDTO dto = SamplePartnerDTO(1);

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.AddPartner(Moq.It.IsAny<R_Partner>())).Returns(1);

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            int id = partnerService.AddPartner(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.PartnerId);
        }

        [TestMethod]
        public void DeletePartner_Success_Test()
        {
            // Arrange
            PartnerDTO dto = SamplePartnerDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.DeletePartner(Moq.It.IsAny<R_Partner>())).Verifiable();

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            partnerService.DeletePartner(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeletePartnerById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.DeletePartner(Moq.It.IsAny<int>())).Verifiable();

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            partnerService.DeletePartner(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetPartner_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Partner partner = SamplePartner(id);

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.GetPartner(Moq.It.IsAny<int>())).Returns(partner);

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            PartnerDTO result = partnerService.GetPartner(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnerId);
        }

        [TestMethod]
        public void GetPartners_Success_Test()
        {
            // Arrange
            R_Partner partner = SamplePartner(1);
            
            IList<R_Partner> list = new List<R_Partner>();
            list.Add(partner);

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.GetPartners()).Returns(list);

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            var resultList = partnerService.GetPartners();
            PartnerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnerId);
        }

        [TestMethod]
        public void GetPartnersPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Partner> list = new List<R_Partner>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SamplePartner(i));
            }

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.GetPartners(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            var resultList = partnerService.GetPartners(searchTerm, pageIndex, pageSize);
            PartnerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnerId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetPartnerListAdvancedSearch_Success_Test()
        {
            // Arrange
            int? nucleoId = null; 
            string name = null; 
            bool? enterpriseContributor = null; 
            bool? privateContributor = null; 
            int? contributionTypeId = null; 
            int? partnershipTypeId = null; 
            string contactPerson = null; 
            string department = null; 
            string phone = null; 
            string email = null; 
            string iban = null; 
            string bicSwift = null; 
            string fiscalNumber = null; 
            double? latitude = null; 
            double? longitude = null; 
            string photoUrl = null; 
            int? addressId = null; 
            System.DateTime? partnershipStartDateFrom = null; 
            System.DateTime? partnershipStartDateTo = null; 
            System.DateTime? durationCommitmentFrom = null; 
            System.DateTime? durationCommitmentTo = null; 
            string refoodAreaInteraction = null; 
            string reliability = null; 
            string interactionFrequency = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Partner> list = new List<R_Partner>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SamplePartner(i));
            }

            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.GetPartnerListAdvancedSearch(
                 Moq.It.IsAny<int?>() // nucleoId 
                , Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<bool?>() // enterpriseContributor 
                , Moq.It.IsAny<bool?>() // privateContributor 
                , Moq.It.IsAny<int?>() // contributionTypeId 
                , Moq.It.IsAny<int?>() // partnershipTypeId 
                , Moq.It.IsAny<string>() // contactPerson 
                , Moq.It.IsAny<string>() // department 
                , Moq.It.IsAny<string>() // phone 
                , Moq.It.IsAny<string>() // email 
                , Moq.It.IsAny<string>() // iban 
                , Moq.It.IsAny<string>() // bicSwift 
                , Moq.It.IsAny<string>() // fiscalNumber 
                , Moq.It.IsAny<double?>() // latitude 
                , Moq.It.IsAny<double?>() // longitude 
                , Moq.It.IsAny<string>() // photoUrl 
                , Moq.It.IsAny<int?>() // addressId 
                , Moq.It.IsAny<System.DateTime?>() // partnershipStartDateFrom 
                , Moq.It.IsAny<System.DateTime?>() // partnershipStartDateTo 
                , Moq.It.IsAny<System.DateTime?>() // durationCommitmentFrom 
                , Moq.It.IsAny<System.DateTime?>() // durationCommitmentTo 
                , Moq.It.IsAny<string>() // refoodAreaInteraction 
                , Moq.It.IsAny<string>() // reliability 
                , Moq.It.IsAny<string>() // interactionFrequency 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            var resultList = partnerService.GetPartnerListAdvancedSearch(
                 nucleoId 
                , name 
                , enterpriseContributor 
                , privateContributor 
                , contributionTypeId 
                , partnershipTypeId 
                , contactPerson 
                , department 
                , phone 
                , email 
                , iban 
                , bicSwift 
                , fiscalNumber 
                , latitude 
                , longitude 
                , photoUrl 
                , addressId 
                , partnershipStartDateFrom 
                , partnershipStartDateTo 
                , durationCommitmentFrom 
                , durationCommitmentTo 
                , refoodAreaInteraction 
                , reliability 
                , interactionFrequency 
                , active 
            );
            
            PartnerDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PartnerId);
        }

        [TestMethod]
        public void UpdatePartner_Success_Test()
        {
            // Arrange
            PartnerDTO dto = SamplePartnerDTO(1);
            
            // create mock for repository
            var mock = new Mock<IPartnerRepository>();
            mock.Setup(s => s.UpdatePartner(Moq.It.IsAny<R_Partner>())).Verifiable();

            // service
            PartnerService partnerService = new PartnerService();
            PartnerService.Repository = mock.Object;

            // Act
            partnerService.UpdatePartner(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Partner SamplePartner(int id = 1)
        {
            R_Partner partner = new R_Partner();

            // int
            partner.PartnerId = id;
            // int?
            partner.NucleoId = 1;
            // string
            partner.Name = "NameTestValue";
            // bool
            partner.EnterpriseContributor = false;
            // bool
            partner.PrivateContributor = false;
            // int
            partner.ContributionTypeId = 1;
            // int
            partner.PartnershipTypeId = 1;
            // string
            partner.ContactPerson = "ContactPersonTestValue";
            // string
            partner.Department = "DepartmentTestValue";
            // string
            partner.Phone = "PhoneTestValue";
            // string
            partner.Email = "EmailTestValue";
            // string
            partner.Iban = "IbanTestValue";
            // string
            partner.BicSwift = "BicSwiftTestValue";
            // string
            partner.FiscalNumber = "FiscalNumberTestValue";
            // double?
            partner.Latitude = 1;
            // double?
            partner.Longitude = 1;
            // string
            partner.PhotoUrl = "PhotoUrlTestValue";
            // int?
            partner.AddressId = 1;
            // System.DateTime?
            partner.PartnershipStartDate = new System.DateTime();
            // System.DateTime?
            partner.DurationCommitment = new System.DateTime();
            // string
            partner.RefoodAreaInteraction = "RefoodAreaInteractionTestValue";
            // string
            partner.Reliability = "ReliabilityTestValue";
            // string
            partner.InteractionFrequency = "InteractionFrequencyTestValue";
            // bool
            partner.Active = false;
            // bool
            partner.IsDeleted = false;
            // int?
            partner.CreateBy = 1;
            // System.DateTime?
            partner.CreateOn = new System.DateTime();
            // int?
            partner.UpdateBy = 1;
            // System.DateTime?
            partner.UpdateOn = new System.DateTime();
            
            return partner;
        }
        
        public static PartnerDTO SamplePartnerDTO(int id = 1)
        {
            PartnerDTO partner = new PartnerDTO();

            // int
            partner.PartnerId = id;
            // int?
            partner.NucleoId = 1;
            // string
            partner.Name = "NameTestValue";
            // bool
            partner.EnterpriseContributor = false;
            // bool
            partner.PrivateContributor = false;
            // int
            partner.ContributionTypeId = 1;
            // int
            partner.PartnershipTypeId = 1;
            // string
            partner.ContactPerson = "ContactPersonTestValue";
            // string
            partner.Department = "DepartmentTestValue";
            // string
            partner.Phone = "PhoneTestValue";
            // string
            partner.Email = "EmailTestValue";
            // string
            partner.Iban = "IbanTestValue";
            // string
            partner.BicSwift = "BicSwiftTestValue";
            // string
            partner.FiscalNumber = "FiscalNumberTestValue";
            // double?
            partner.Latitude = 1;
            // double?
            partner.Longitude = 1;
            // string
            partner.PhotoUrl = "PhotoUrlTestValue";
            // int?
            partner.AddressId = 1;
            // System.DateTime?
            partner.PartnershipStartDate = new System.DateTime();
            // System.DateTime?
            partner.DurationCommitment = new System.DateTime();
            // string
            partner.RefoodAreaInteraction = "RefoodAreaInteractionTestValue";
            // string
            partner.Reliability = "ReliabilityTestValue";
            // string
            partner.InteractionFrequency = "InteractionFrequencyTestValue";
            // bool
            partner.Active = false;
            // bool
            partner.IsDeleted = false;
            // int?
            partner.CreateBy = 1;
            // System.DateTime?
            partner.CreateOn = new System.DateTime();
            // int?
            partner.UpdateBy = 1;
            // System.DateTime?
            partner.UpdateOn = new System.DateTime();
            
            return partner;
        }
        
    }
}

    