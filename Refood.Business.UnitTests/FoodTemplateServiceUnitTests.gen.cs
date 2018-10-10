
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
    public partial class FoodTemplateServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddFoodTemplate_Success_Test()
        {
            // Arrange
            FoodTemplateDTO dto = SampleFoodTemplateDTO(1);

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.AddFoodTemplate(Moq.It.IsAny<R_FoodTemplate>())).Returns(1);

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            int id = foodTemplateService.AddFoodTemplate(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.FoodTemplateId);
        }

        [TestMethod]
        public void DeleteFoodTemplate_Success_Test()
        {
            // Arrange
            FoodTemplateDTO dto = SampleFoodTemplateDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.DeleteFoodTemplate(Moq.It.IsAny<R_FoodTemplate>())).Verifiable();

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            foodTemplateService.DeleteFoodTemplate(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteFoodTemplateById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.DeleteFoodTemplate(Moq.It.IsAny<int>())).Verifiable();

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            foodTemplateService.DeleteFoodTemplate(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetFoodTemplate_Success_Test()
        {
            // Arrange
            int id = 1;
            R_FoodTemplate foodTemplate = SampleFoodTemplate(id);

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.GetFoodTemplate(Moq.It.IsAny<int>())).Returns(foodTemplate);

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            FoodTemplateDTO result = foodTemplateService.GetFoodTemplate(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodTemplateId);
        }

        [TestMethod]
        public void GetFoodTemplates_Success_Test()
        {
            // Arrange
            R_FoodTemplate foodTemplate = SampleFoodTemplate(1);
            
            IList<R_FoodTemplate> list = new List<R_FoodTemplate>();
            list.Add(foodTemplate);

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.GetFoodTemplates()).Returns(list);

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            var resultList = foodTemplateService.GetFoodTemplates();
            FoodTemplateDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodTemplateId);
        }

        [TestMethod]
        public void GetFoodTemplatesPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_FoodTemplate> list = new List<R_FoodTemplate>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleFoodTemplate(i));
            }

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.GetFoodTemplates(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            var resultList = foodTemplateService.GetFoodTemplates(searchTerm, pageIndex, pageSize);
            FoodTemplateDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodTemplateId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetFoodTemplateListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            string description = null; 
            string foodCategory = null; 
            int? calories = null; 
            System.DateTime? averageExpirationTimeFrom = null; 
            System.DateTime? averageExpirationTimeTo = null; 
            bool? liquid = null; 
            bool? needsRefrigeration = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_FoodTemplate> list = new List<R_FoodTemplate>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleFoodTemplate(i));
            }

            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.GetFoodTemplateListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<string>() // description 
                , Moq.It.IsAny<string>() // foodCategory 
                , Moq.It.IsAny<int?>() // calories 
                , Moq.It.IsAny<System.DateTime?>() // averageExpirationTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // averageExpirationTimeTo 
                , Moq.It.IsAny<bool?>() // liquid 
                , Moq.It.IsAny<bool?>() // needsRefrigeration 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            var resultList = foodTemplateService.GetFoodTemplateListAdvancedSearch(
                 name 
                , description 
                , foodCategory 
                , calories 
                , averageExpirationTimeFrom 
                , averageExpirationTimeTo 
                , liquid 
                , needsRefrigeration 
                , active 
            );
            
            FoodTemplateDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodTemplateId);
        }

        [TestMethod]
        public void UpdateFoodTemplate_Success_Test()
        {
            // Arrange
            FoodTemplateDTO dto = SampleFoodTemplateDTO(1);
            
            // create mock for repository
            var mock = new Mock<IFoodTemplateRepository>();
            mock.Setup(s => s.UpdateFoodTemplate(Moq.It.IsAny<R_FoodTemplate>())).Verifiable();

            // service
            FoodTemplateService foodTemplateService = new FoodTemplateService();
            FoodTemplateService.Repository = mock.Object;

            // Act
            foodTemplateService.UpdateFoodTemplate(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_FoodTemplate SampleFoodTemplate(int id = 1)
        {
            R_FoodTemplate foodTemplate = new R_FoodTemplate();

            // int
            foodTemplate.FoodTemplateId = id;
            // string
            foodTemplate.Name = "NameTestValue";
            // string
            foodTemplate.Description = "DescriptionTestValue";
            // string
            foodTemplate.FoodCategory = "FoodCategoryTestValue";
            // int?
            foodTemplate.Calories = 1;
            // System.DateTime?
            foodTemplate.AverageExpirationTime = new System.DateTime();
            // bool
            foodTemplate.Liquid = false;
            // bool
            foodTemplate.NeedsRefrigeration = false;
            // bool
            foodTemplate.Active = false;
            // bool
            foodTemplate.IsDeleted = false;
            // int?
            foodTemplate.CreateBy = 1;
            // System.DateTime?
            foodTemplate.CreateOn = new System.DateTime();
            // int?
            foodTemplate.UpdateBy = 1;
            // System.DateTime?
            foodTemplate.UpdateOn = new System.DateTime();
            
            return foodTemplate;
        }
        
        public static FoodTemplateDTO SampleFoodTemplateDTO(int id = 1)
        {
            FoodTemplateDTO foodTemplate = new FoodTemplateDTO();

            // int
            foodTemplate.FoodTemplateId = id;
            // string
            foodTemplate.Name = "NameTestValue";
            // string
            foodTemplate.Description = "DescriptionTestValue";
            // string
            foodTemplate.FoodCategory = "FoodCategoryTestValue";
            // int?
            foodTemplate.Calories = 1;
            // System.DateTime?
            foodTemplate.AverageExpirationTime = new System.DateTime();
            // bool
            foodTemplate.Liquid = false;
            // bool
            foodTemplate.NeedsRefrigeration = false;
            // bool
            foodTemplate.Active = false;
            // bool
            foodTemplate.IsDeleted = false;
            // int?
            foodTemplate.CreateBy = 1;
            // System.DateTime?
            foodTemplate.CreateOn = new System.DateTime();
            // int?
            foodTemplate.UpdateBy = 1;
            // System.DateTime?
            foodTemplate.UpdateOn = new System.DateTime();
            
            return foodTemplate;
        }
        
    }
}

    