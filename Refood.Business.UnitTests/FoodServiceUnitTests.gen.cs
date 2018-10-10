
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
    public partial class FoodServiceUnitTests
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void AddFood_Success_Test()
        {
            // Arrange
            FoodDTO dto = SampleFoodDTO(1);

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.AddFood(Moq.It.IsAny<R_Food>())).Returns(1);

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            int id = foodService.AddFood(dto);

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual(1, dto.FoodId);
        }

        [TestMethod]
        public void DeleteFood_Success_Test()
        {
            // Arrange
            FoodDTO dto = SampleFoodDTO(1);
            dto.IsDeleted = false;

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.DeleteFood(Moq.It.IsAny<R_Food>())).Verifiable();

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            foodService.DeleteFood(dto);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeleteFoodById_Success_Test()
        {
            // Arrange
            int id = 1;

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.DeleteFood(Moq.It.IsAny<int>())).Verifiable();

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            foodService.DeleteFood(id);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetFood_Success_Test()
        {
            // Arrange
            int id = 1;
            R_Food food = SampleFood(id);

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.GetFood(Moq.It.IsAny<int>())).Returns(food);

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            FoodDTO result = foodService.GetFood(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodId);
        }

        [TestMethod]
        public void GetFoods_Success_Test()
        {
            // Arrange
            R_Food food = SampleFood(1);
            
            IList<R_Food> list = new List<R_Food>();
            list.Add(food);

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.GetFoods()).Returns(list);

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            var resultList = foodService.GetFoods();
            FoodDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodId);
        }

        [TestMethod]
        public void GetFoodsPaged_Success_Test()
        {
            // Arrange
            string searchTerm = "";
            int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Food> list = new List<R_Food>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleFood(i));
            }

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.GetFoods(Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>())).Returns(list);

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            var resultList = foodService.GetFoods(searchTerm, pageIndex, pageSize);
            FoodDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodId);
            Assert.AreEqual(10, resultList.Count);
        }

        [TestMethod]
        public void GetFoodListAdvancedSearch_Success_Test()
        {
            // Arrange
            string name = null; 
            double? quantity = null; 
            int? foodTemplateId = null; 
            string specificObservations = null; 
            string location = null; 
            int? progress = null; 
            bool? expired = null; 
            bool? liquid = null; 
            int? rating = null; 
            string feedbackFromBeneficiary = null; 
            int? deliveredBy = null; 
            int? deliveredTo = null; 
            System.DateTime? orderDateTimeFrom = null; 
            System.DateTime? orderDateTimeTo = null; 
            System.DateTime? cookedDateTimeFrom = null; 
            System.DateTime? cookedDateTimeTo = null; 
            System.DateTime? pickupDateTimeFrom = null; 
            System.DateTime? pickupDateTimeTo = null; 
            System.DateTime? storageDateTimeFrom = null; 
            System.DateTime? storageDateTimeTo = null; 
            System.DateTime? deliveryDateTimeFrom = null; 
            System.DateTime? deliveryDateTimeTo = null; 
            bool? active = null; 

            //int pageIndex = 0;
            int pageSize = 10;
            
            // list
            IList<R_Food> list = new List<R_Food>();
            for(int i = 1; i <= pageSize; i++)
            {
                list.Add(SampleFood(i));
            }

            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.GetFoodListAdvancedSearch(
                 Moq.It.IsAny<string>() // name 
                , Moq.It.IsAny<double?>() // quantity 
                , Moq.It.IsAny<int?>() // foodTemplateId 
                , Moq.It.IsAny<string>() // specificObservations 
                , Moq.It.IsAny<string>() // location 
                , Moq.It.IsAny<int?>() // progress 
                , Moq.It.IsAny<bool?>() // expired 
                , Moq.It.IsAny<bool?>() // liquid 
                , Moq.It.IsAny<int?>() // rating 
                , Moq.It.IsAny<string>() // feedbackFromBeneficiary 
                , Moq.It.IsAny<int?>() // deliveredBy 
                , Moq.It.IsAny<int?>() // deliveredTo 
                , Moq.It.IsAny<System.DateTime?>() // orderDateTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // orderDateTimeTo 
                , Moq.It.IsAny<System.DateTime?>() // cookedDateTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // cookedDateTimeTo 
                , Moq.It.IsAny<System.DateTime?>() // pickupDateTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // pickupDateTimeTo 
                , Moq.It.IsAny<System.DateTime?>() // storageDateTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // storageDateTimeTo 
                , Moq.It.IsAny<System.DateTime?>() // deliveryDateTimeFrom 
                , Moq.It.IsAny<System.DateTime?>() // deliveryDateTimeTo 
                , Moq.It.IsAny<bool?>() // active 
            )).Returns(list);

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            var resultList = foodService.GetFoodListAdvancedSearch(
                 name 
                , quantity 
                , foodTemplateId 
                , specificObservations 
                , location 
                , progress 
                , expired 
                , liquid 
                , rating 
                , feedbackFromBeneficiary 
                , deliveredBy 
                , deliveredTo 
                , orderDateTimeFrom 
                , orderDateTimeTo 
                , cookedDateTimeFrom 
                , cookedDateTimeTo 
                , pickupDateTimeFrom 
                , pickupDateTimeTo 
                , storageDateTimeFrom 
                , storageDateTimeTo 
                , deliveryDateTimeFrom 
                , deliveryDateTimeTo 
                , active 
            );
            
            FoodDTO result = resultList.FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FoodId);
        }

        [TestMethod]
        public void UpdateFood_Success_Test()
        {
            // Arrange
            FoodDTO dto = SampleFoodDTO(1);
            
            // create mock for repository
            var mock = new Mock<IFoodRepository>();
            mock.Setup(s => s.UpdateFood(Moq.It.IsAny<R_Food>())).Verifiable();

            // service
            FoodService foodService = new FoodService();
            FoodService.Repository = mock.Object;

            // Act
            foodService.UpdateFood(dto);

            // Assert
            Assert.IsNotNull(dto);
        }



        // example data

        public static R_Food SampleFood(int id = 1)
        {
            R_Food food = new R_Food();

            // int
            food.FoodId = id;
            // string
            food.Name = "NameTestValue";
            // double?
            food.Quantity = 1;
            // int?
            food.FoodTemplateId = 1;
            // string
            food.SpecificObservations = "SpecificObservationsTestValue";
            // string
            food.Location = "LocationTestValue";
            // int?
            food.Progress = 1;
            // bool
            food.Expired = false;
            // bool
            food.Liquid = false;
            // int?
            food.Rating = 1;
            // string
            food.FeedbackFromBeneficiary = "FeedbackFromBeneficiaryTestValue";
            // int?
            food.DeliveredBy = 1;
            // int?
            food.DeliveredTo = 1;
            // System.DateTime?
            food.OrderDateTime = new System.DateTime();
            // System.DateTime?
            food.CookedDateTime = new System.DateTime();
            // System.DateTime?
            food.PickupDateTime = new System.DateTime();
            // System.DateTime?
            food.StorageDateTime = new System.DateTime();
            // System.DateTime?
            food.DeliveryDateTime = new System.DateTime();
            // bool
            food.Active = false;
            // bool
            food.IsDeleted = false;
            // int?
            food.CreateBy = 1;
            // System.DateTime?
            food.CreateOn = new System.DateTime();
            // int?
            food.UpdateBy = 1;
            // System.DateTime?
            food.UpdateOn = new System.DateTime();
            
            return food;
        }
        
        public static FoodDTO SampleFoodDTO(int id = 1)
        {
            FoodDTO food = new FoodDTO();

            // int
            food.FoodId = id;
            // string
            food.Name = "NameTestValue";
            // double?
            food.Quantity = 1;
            // int?
            food.FoodTemplateId = 1;
            // string
            food.SpecificObservations = "SpecificObservationsTestValue";
            // string
            food.Location = "LocationTestValue";
            // int?
            food.Progress = 1;
            // bool
            food.Expired = false;
            // bool
            food.Liquid = false;
            // int?
            food.Rating = 1;
            // string
            food.FeedbackFromBeneficiary = "FeedbackFromBeneficiaryTestValue";
            // int?
            food.DeliveredBy = 1;
            // int?
            food.DeliveredTo = 1;
            // System.DateTime?
            food.OrderDateTime = new System.DateTime();
            // System.DateTime?
            food.CookedDateTime = new System.DateTime();
            // System.DateTime?
            food.PickupDateTime = new System.DateTime();
            // System.DateTime?
            food.StorageDateTime = new System.DateTime();
            // System.DateTime?
            food.DeliveryDateTime = new System.DateTime();
            // bool
            food.Active = false;
            // bool
            food.IsDeleted = false;
            // int?
            food.CreateBy = 1;
            // System.DateTime?
            food.CreateOn = new System.DateTime();
            // int?
            food.UpdateBy = 1;
            // System.DateTime?
            food.UpdateOn = new System.DateTime();
            
            return food;
        }
        
    }
}

    