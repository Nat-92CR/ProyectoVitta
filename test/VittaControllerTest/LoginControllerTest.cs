using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VittaController;
using VittaController.Abstractions;
using VittaModel;

namespace VittaControllerTest
{
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void Login_WhenCredentialsAreCorrect_ReturnsTrue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();

            userControllerMock
                .Setup(x => x.Login("Nat", "123"))
                .Returns(true);

            LoginController loginController = new LoginController(userControllerMock.Object);

            // Act
            bool result = loginController.Login("Nat", "123");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_WhenCredentialsAreIncorrect_ReturnsFalse()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();

            userControllerMock
                .Setup(x => x.Login("Nat", "999"))
                .Returns(false);

            LoginController loginController = new LoginController(userControllerMock.Object);

            // Act
            bool result = loginController.Login("Nat", "999");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Register_WhenUserIsValid_ReturnsTrue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();

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
                .Setup(x => x.Register(user))
                .Returns(true);

            LoginController loginController = new LoginController(userControllerMock.Object);

            // Act
            bool result = loginController.Register(user);

            // Assert
            Assert.IsTrue(result);
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

            // Act
            User? result = loginController.GetUserByUserName("Nat");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Nat", result.UserName);
        }

        [TestMethod]
        public void UpdateUser_WhenUserIsValid_ReturnsTrue()
        {
            // Arrange
            Mock<IUserController> userControllerMock = new Mock<IUserController>();

            User user = new User(
                "Nat",
                "123",
                "Natalia Tobal",
                61,
                160,
                "Mantener",
                "Moderado",
                "Estándar",
                33,
                "Femenino");

            userControllerMock
                .Setup(x => x.UpdateUser(user))
                .Returns(true);

            LoginController loginController = new LoginController(userControllerMock.Object);

            // Act
            bool result = loginController.UpdateUser(user);

            // Assert
            Assert.IsTrue(result);
        }
    }
}