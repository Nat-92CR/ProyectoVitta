using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using VittaController;
using VittaController.Abstractions;
using VittaModel;

namespace VittaControllerTest
{
    [TestClass]
    public class StatisticsControllerTest
    {
        [TestMethod]
        public void GetUserByUserName_WhenUserNameIsEmpty_ReturnsNull()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            User? result = statisticsController.GetUserByUserName("");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetUserByUserName_WhenUserExists_ReturnsUser()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            User expectedUser = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns(expectedUser);

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            User? result = statisticsController.GetUserByUserName("Nat");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Nat", result.UserName);
        }

        [TestMethod]
        public void GetMenusByDateRange_WhenUserNameIsEmpty_ReturnsEmptyList()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            List<Menu> result = statisticsController.GetMenusByDateRange(
                "",
                new DateTime(2026, 4, 1),
                new DateTime(2026, 4, 30));

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetMenusByDateRange_WhenMenusExistInRange_ReturnsFilteredMenus()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 10), "Arroz x1", "", "", "", ""),
                new Menu("Nat", new DateTime(2026, 4, 15), "Pollo x1", "", "", "", ""),
                new Menu("Nat", new DateTime(2026, 5, 1), "Pan x1", "", "", "", "")
            };

            menuControllerMock
                .Setup(x => x.GetMenusByUser("Nat"))
                .Returns(menus);

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            List<Menu> result = statisticsController.GetMenusByDateRange(
                "Nat",
                new DateTime(2026, 4, 1),
                new DateTime(2026, 4, 30));

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void CalculateDailyConsumption_WhenUserNameIsEmpty_ReturnsZeros()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            statisticsController.CalculateDailyConsumption(
                "",
                new DateTime(2026, 4, 27),
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            // Assert
            Assert.AreEqual(0, totalCalories, 0.01);
            Assert.AreEqual(0, totalProtein, 0.01);
            Assert.AreEqual(0, totalCarbohydrates, 0.01);
            Assert.AreEqual(0, totalFat, 0.01);
        }

        [TestMethod]
        public void CalculateDailyConsumption_WhenMenuDoesNotExist_ReturnsZeros()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            menuControllerMock
                .Setup(x => x.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 27)))
                .Returns((Menu?)null);

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            statisticsController.CalculateDailyConsumption(
                "Nat",
                new DateTime(2026, 4, 27),
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            // Assert
            Assert.AreEqual(0, totalCalories, 0.01);
            Assert.AreEqual(0, totalProtein, 0.01);
            Assert.AreEqual(0, totalCarbohydrates, 0.01);
            Assert.AreEqual(0, totalFat, 0.01);
        }

        [TestMethod]
        public void CalculateDailyConsumption_WhenMenuExists_ReturnsAccumulatedNutrition()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            Menu dailyMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Arroz x2 | Pollo x1",
                "",
                "",
                "",
                "");

            menuControllerMock
                .Setup(x => x.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 27)))
                .Returns(dailyMenu);

            foodControllerMock
                .Setup(x => x.GetFoodByName("Arroz"))
                .Returns(new Food("Arroz", 200, 4, 45, 1));

            foodControllerMock
                .Setup(x => x.GetFoodByName("Pollo"))
                .Returns(new Food("Pollo", 250, 30, 0, 5));

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            statisticsController.CalculateDailyConsumption(
                "Nat",
                new DateTime(2026, 4, 27),
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            // Assert
            Assert.AreEqual(650, totalCalories, 0.01);
            Assert.AreEqual(38, totalProtein, 0.01);
            Assert.AreEqual(90, totalCarbohydrates, 0.01);
            Assert.AreEqual(7, totalFat, 0.01);
        }

        [TestMethod]
        public void CalculateDailyCalorieGoal_WhenUserDoesNotExist_ReturnsZero()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns((User?)null);

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            double result = statisticsController.CalculateDailyCalorieGoal("Nat");

            // Assert
            Assert.AreEqual(0, result, 0.01);
        }

        [TestMethod]
        public void CalculateDailyCalorieGoal_WhenUserExists_ReturnsMaintenanceCalories()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns(user);

            nutritionInfoControllerMock
                .Setup(x => x.CalculateMaintenanceCalories(user))
                .Returns(2400);

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            double result = statisticsController.CalculateDailyCalorieGoal("Nat");

            // Assert
            Assert.AreEqual(2400, result, 0.01);
        }

        [TestMethod]
        public void CalculateConsumptionByDateRange_WhenMenusExist_ReturnsAccumulatedNutrition()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 10), "Arroz x1", "", "", "", ""),
                new Menu("Nat", new DateTime(2026, 4, 11), "Pollo x1", "", "", "", "")
            };

            menuControllerMock
                .Setup(x => x.GetMenusByUser("Nat"))
                .Returns(menus);

            foodControllerMock
                .Setup(x => x.GetFoodByName("Arroz"))
                .Returns(new Food("Arroz", 200, 4, 45, 1));

            foodControllerMock
                .Setup(x => x.GetFoodByName("Pollo"))
                .Returns(new Food("Pollo", 250, 30, 0, 5));

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            statisticsController.CalculateConsumptionByDateRange(
                "Nat",
                new DateTime(2026, 4, 1),
                new DateTime(2026, 4, 30),
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            // Assert
            Assert.AreEqual(450, totalCalories, 0.01);
            Assert.AreEqual(34, totalProtein, 0.01);
            Assert.AreEqual(45, totalCarbohydrates, 0.01);
            Assert.AreEqual(6, totalFat, 0.01);
        }

        [TestMethod]
        public void CountDaysMeetingCalorieGoal_WhenSomeDaysMeetGoal_ReturnsExpectedCount()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 10), "Arroz x10", "", "", "", ""),
                new Menu("Nat", new DateTime(2026, 4, 11), "Pollo x1", "", "", "", "")
            };

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns(user);

            nutritionInfoControllerMock
                .Setup(x => x.CalculateMaintenanceCalories(user))
                .Returns(1000);

            menuControllerMock
                .Setup(x => x.GetMenusByUser("Nat"))
                .Returns(menus);

            menuControllerMock
                .Setup(x => x.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 10)))
                .Returns(menus[0]);

            menuControllerMock
                .Setup(x => x.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 11)))
                .Returns(menus[1]);

            foodControllerMock
                .Setup(x => x.GetFoodByName("Arroz"))
                .Returns(new Food("Arroz", 200, 4, 45, 1));

            foodControllerMock
                .Setup(x => x.GetFoodByName("Pollo"))
                .Returns(new Food("Pollo", 250, 30, 0, 5));

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            int result = statisticsController.CountDaysMeetingCalorieGoal(
                "Nat",
                new DateTime(2026, 4, 1),
                new DateTime(2026, 4, 30));

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateDailyMacronutrientGoal_WhenUserExists_ReturnsExpectedGoals()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns(user);

            nutritionInfoControllerMock
                .Setup(x => x.CalculateMacronutrients(
                    user,
                    out It.Ref<double>.IsAny,
                    out It.Ref<double>.IsAny,
                    out It.Ref<double>.IsAny))
                .Callback(new CalculateMacronutrientsDelegate((User u, out double p, out double c, out double f) =>
                {
                    p = 120;
                    c = 250;
                    f = 60;
                }));

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            statisticsController.CalculateDailyMacronutrientGoal(
                "Nat",
                out double proteinGoal,
                out double carbohydratesGoal,
                out double fatGoal);

            // Assert
            Assert.AreEqual(120, proteinGoal, 0.01);
            Assert.AreEqual(250, carbohydratesGoal, 0.01);
            Assert.AreEqual(60, fatGoal, 0.01);
        }

        [TestMethod]
        public void CalculateRemainingCalories_WhenGoalIsGreaterThanConsumption_ReturnsExpectedDifference()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            Menu dailyMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Arroz x2",
                "",
                "",
                "",
                "");

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns(user);

            nutritionInfoControllerMock
                .Setup(x => x.CalculateMaintenanceCalories(user))
                .Returns(1000);

            menuControllerMock
                .Setup(x => x.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 27)))
                .Returns(dailyMenu);

            foodControllerMock
                .Setup(x => x.GetFoodByName("Arroz"))
                .Returns(new Food("Arroz", 200, 4, 45, 1));

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            double result = statisticsController.CalculateRemainingCalories(
                "Nat",
                new DateTime(2026, 4, 27));

            // Assert
            Assert.AreEqual(600, result, 0.01);
        }

        [TestMethod]
        public void CalculateRemainingMacronutrients_WhenGoalsExist_ReturnsExpectedDifferences()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            Mock<IFoodController> foodControllerMock = new Mock<IFoodController>();
            Mock<IMenuController> menuControllerMock = new Mock<IMenuController>();
            Mock<INutritionInfoController> nutritionInfoControllerMock = new Mock<INutritionInfoController>();

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            Menu dailyMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Arroz x2 | Pollo x1",
                "",
                "",
                "",
                "");

            userControllerMock
                .Setup(x => x.GetUserByUserName("Nat"))
                .Returns(user);

            nutritionInfoControllerMock
                .Setup(x => x.CalculateMacronutrients(
                    user,
                    out It.Ref<double>.IsAny,
                    out It.Ref<double>.IsAny,
                    out It.Ref<double>.IsAny))
                .Callback(new CalculateMacronutrientsDelegate((User u, out double p, out double c, out double f) =>
                {
                    p = 100;
                    c = 150;
                    f = 20;
                }));

            menuControllerMock
                .Setup(x => x.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 27)))
                .Returns(dailyMenu);

            foodControllerMock
                .Setup(x => x.GetFoodByName("Arroz"))
                .Returns(new Food("Arroz", 200, 4, 45, 1));

            foodControllerMock
                .Setup(x => x.GetFoodByName("Pollo"))
                .Returns(new Food("Pollo", 250, 30, 0, 5));

            LoginController loginController = new LoginController(userControllerMock.Object);

            StatisticsController statisticsController = new StatisticsController(
                loginController,
                foodControllerMock.Object,
                menuControllerMock.Object,
                nutritionInfoControllerMock.Object);

            // Act
            statisticsController.CalculateRemainingMacronutrients(
                "Nat",
                new DateTime(2026, 4, 27),
                out double remainingProtein,
                out double remainingCarbohydrates,
                out double remainingFat);

            // Assert
            Assert.AreEqual(62, remainingProtein, 0.01);
            Assert.AreEqual(60, remainingCarbohydrates, 0.01);
            Assert.AreEqual(13, remainingFat, 0.01);
        }

        private delegate void CalculateMacronutrientsDelegate(
            User user,
            out double proteinGrams,
            out double carbohydratesGrams,
            out double fatGrams);
    }
}