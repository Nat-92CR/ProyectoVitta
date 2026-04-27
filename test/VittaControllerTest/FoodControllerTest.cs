using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using VittaController;
using VittaController.Abstractions;
using VittaModel;

namespace VittaControllerTest
{
    [TestClass]
    public class FoodControllerTest
    {
        [TestMethod]
        public void RegisterFood_WhenFoodIsValid_ReturnsTrue()
        {
            // Arrange
            List<Food> foods = new List<Food>();

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<Food>>()))
                .Returns(true);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            Food newFood = new Food("Arroz", 200, 4, 45, 1);

            // Act
            bool result = foodController.RegisterFood(newFood);

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<Food>>()), Times.Once);
        }

        [TestMethod]
        public void RegisterFood_WhenFoodNameIsEmpty_ReturnsFalse()
        {
            // Arrange
            List<Food> foods = new List<Food>();

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            Food newFood = new Food("", 200, 4, 45, 1);

            // Act
            bool result = foodController.RegisterFood(newFood);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RegisterFood_WhenFoodAlreadyExists_ReturnsFalse()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            Food duplicateFood = new Food("Arroz", 180, 3, 40, 1);

            // Act
            bool result = foodController.RegisterFood(duplicateFood);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetFoods_WhenFoodsExist_ReturnsFoodList()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1),
                new Food("Pollo", 250, 30, 0, 5)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            List<Food> result = foodController.GetFoods();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void GetFoodByName_WhenFoodExists_ReturnsFood()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            Food? result = foodController.GetFoodByName("Arroz");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Arroz", result.Name);
        }

        [TestMethod]
        public void GetFoodByName_WhenFoodDoesNotExist_ReturnsNull()
        {
            // Arrange
            List<Food> foods = new List<Food>();

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            Food? result = foodController.GetFoodByName("Arroz");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SearchFoodsByName_WhenTextMatches_ReturnsMatchingFoods()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1),
                new Food("Arroz integral", 210, 5, 43, 2),
                new Food("Pollo", 250, 30, 0, 5)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            List<Food> result = foodController.SearchFoodsByName("Arroz");

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void SearchFoodsByName_WhenTextIsEmpty_ReturnsAllFoods()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1),
                new Food("Pollo", 250, 30, 0, 5)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            List<Food> result = foodController.SearchFoodsByName("");

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void UpdateFood_WhenFoodExists_ReturnsTrue()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<Food>>()))
                .Returns(true);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            Food updatedFood = new Food("Arroz", 180, 3, 40, 1);

            // Act
            bool result = foodController.UpdateFood(updatedFood);

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<Food>>()), Times.Once);
        }

        [TestMethod]
        public void UpdateFood_WhenFoodDoesNotExist_ReturnsFalse()
        {
            // Arrange
            List<Food> foods = new List<Food>();

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            Food updatedFood = new Food("Arroz", 180, 3, 40, 1);

            // Act
            bool result = foodController.UpdateFood(updatedFood);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeleteFood_WhenFoodExists_ReturnsTrue()
        {
            // Arrange
            List<Food> foods = new List<Food>
            {
                new Food("Arroz", 200, 4, 45, 1)
            };

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<Food>>()))
                .Returns(true);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            bool result = foodController.DeleteFood("Arroz");

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<Food>>()), Times.Once);
        }

        [TestMethod]
        public void DeleteFood_WhenFoodDoesNotExist_ReturnsFalse()
        {
            // Arrange
            List<Food> foods = new List<Food>();

            Mock<IDataHandler<Food>> dataHandlerMock = new Mock<IDataHandler<Food>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(foods);

            FoodController foodController = new FoodController(dataHandlerMock.Object);

            // Act
            bool result = foodController.DeleteFood("Arroz");

            // Assert
            Assert.IsFalse(result);
        }
    }
}