using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VittaController;
using VittaController.Abstractions;
using VittaModel;

namespace VittaControllerTest
{
    [TestClass]
    public class NutritionInfoControllerTest
    {
        [TestMethod]
        public void GetUserByUserName_WhenUserNameIsEmpty_ReturnsNull()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            User? result = nutritionInfoController.GetUserByUserName("");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetUserByUserName_WhenUserExists_ReturnsUser()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();

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
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            User? result = nutritionInfoController.GetUserByUserName("Nat");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Nat", result.UserName);
        }

        [TestMethod]
        public void CalculateMaintenanceCalories_WhenActivityLevelIsSedentario_ReturnsExpectedValue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Sedentario",
                "Estándar",
                33,
                "Femenino");

            // Act
            double result = nutritionInfoController.CalculateMaintenanceCalories(user);

            // Assert
            Assert.AreEqual(1800, result, 0.01);
        }

        [TestMethod]
        public void CalculateMaintenanceCalories_WhenActivityLevelIsModerado_ReturnsExpectedValue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

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

            // Act
            double result = nutritionInfoController.CalculateMaintenanceCalories(user);

            // Assert
            Assert.AreEqual(2400, result, 0.01);
        }

        [TestMethod]
        public void CalculateMaintenanceCalories_WhenUserIsInvalid_ReturnsZero()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                0,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            // Act
            double result = nutritionInfoController.CalculateMaintenanceCalories(user);

            // Assert
            Assert.AreEqual(0, result, 0.01);
        }

        [TestMethod]
        public void CalculateBodyMassIndex_WhenHeightIsInCentimeters_ReturnsExpectedValue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

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

            // Act
            double result = nutritionInfoController.CalculateBodyMassIndex(user);

            // Assert
            Assert.AreEqual(23.4375, result, 0.0001);
        }

        [TestMethod]
        public void CalculateBodyMassIndex_WhenHeightIsInMeters_ReturnsExpectedValue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                1.60,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            // Act
            double result = nutritionInfoController.CalculateBodyMassIndex(user);

            // Assert
            Assert.AreEqual(23.4375, result, 0.0001);
        }

        [TestMethod]
        public void CalculateBodyMassIndex_WhenUserIsInvalid_ReturnsZero()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                0,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            // Act
            double result = nutritionInfoController.CalculateBodyMassIndex(user);

            // Assert
            Assert.AreEqual(0, result, 0.01);
        }

        [TestMethod]
        public void GetBodyMassIndexCategory_WhenValueIsZero_ReturnsNoDisponible()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            string result = nutritionInfoController.GetBodyMassIndexCategory(0);

            // Assert
            Assert.AreEqual("No disponible", result);
        }

        [TestMethod]
        public void GetBodyMassIndexCategory_WhenValueIsUnder18Point5_ReturnsBajoPeso()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            string result = nutritionInfoController.GetBodyMassIndexCategory(18);

            // Assert
            Assert.AreEqual("Bajo peso", result);
        }

        [TestMethod]
        public void GetBodyMassIndexCategory_WhenValueIsUnder25_ReturnsNormal()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            string result = nutritionInfoController.GetBodyMassIndexCategory(24);

            // Assert
            Assert.AreEqual("Normal", result);
        }

        [TestMethod]
        public void GetBodyMassIndexCategory_WhenValueIsUnder30_ReturnsSobrepeso()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            string result = nutritionInfoController.GetBodyMassIndexCategory(28);

            // Assert
            Assert.AreEqual("Sobrepeso", result);
        }

        [TestMethod]
        public void GetBodyMassIndexCategory_WhenValueIs30OrMore_ReturnsObesidad()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            // Act
            string result = nutritionInfoController.GetBodyMassIndexCategory(31);

            // Assert
            Assert.AreEqual("Obesidad", result);
        }

        [TestMethod]
        public void CalculateMacronutrients_WhenUserIsInvalid_ReturnsZeros()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                0,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            // Act
            nutritionInfoController.CalculateMacronutrients(
                user,
                out double proteinGrams,
                out double carbohydratesGrams,
                out double fatGrams);

            // Assert
            Assert.AreEqual(0, proteinGrams, 0.01);
            Assert.AreEqual(0, carbohydratesGrams, 0.01);
            Assert.AreEqual(0, fatGrams, 0.01);
        }

        [TestMethod]
        public void CalculateMacronutrients_WhenDietTypeIsStandard_ReturnsPositiveValues()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

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

            // Act
            nutritionInfoController.CalculateMacronutrients(
                user,
                out double proteinGrams,
                out double carbohydratesGrams,
                out double fatGrams);

            // Assert
            Assert.IsTrue(proteinGrams > 0);
            Assert.IsTrue(carbohydratesGrams > 0);
            Assert.IsTrue(fatGrams > 0);
        }

        [TestMethod]
        public void CalculateMacronutrients_WhenDietTypeIsKeto_ReturnsPositiveValues()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Keto",
                33,
                "Femenino");

            // Act
            nutritionInfoController.CalculateMacronutrients(
                user,
                out double proteinGrams,
                out double carbohydratesGrams,
                out double fatGrams);

            // Assert
            Assert.IsTrue(proteinGrams > 0);
            Assert.IsTrue(carbohydratesGrams > 0);
            Assert.IsTrue(fatGrams > 0);
        }

        [TestMethod]
        public void CalculateMacronutrients_WhenDietTypeIsVegetariana_ReturnsPositiveValues()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();
            LoginController loginController = new LoginController(userControllerMock.Object);
            NutritionInfoController nutritionInfoController = new NutritionInfoController(loginController);

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                60,
                160,
                "Mantener",
                "Moderado",
                "Vegetariana",
                33,
                "Femenino");

            // Act
            nutritionInfoController.CalculateMacronutrients(
                user,
                out double proteinGrams,
                out double carbohydratesGrams,
                out double fatGrams);

            // Assert
            Assert.IsTrue(proteinGrams > 0);
            Assert.IsTrue(carbohydratesGrams > 0);
            Assert.IsTrue(fatGrams > 0);
        }
    }
}