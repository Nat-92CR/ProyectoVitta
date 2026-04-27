using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VittaController;
using VittaController.Abstractions;
using VittaModel;
using System.Collections.Generic;

namespace VittaControllerTest
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void Login_WhenUserExistsAndPasswordMatches_ReturnsTrue()
        {
            // Arrange
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            // Act
            bool result = userController.Login("Nat", "123");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_WhenPasswordIsIncorrect_ReturnsFalse()
        {
            // Arrange
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            // Act
            bool result = userController.Login("Nat", "999");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_WhenUserNameIsEmpty_ReturnsFalse()
        {
            // Arrange
            List<User> users = new List<User>();

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            // Act
            bool result = userController.Login("", "123");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Register_WhenUserDoesNotExist_AddsUserAndReturnsTrue()
        {
            // Arrange
            List<User> users = new List<User>();

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<User>>()))
                .Returns(true);

            UserController userController = new UserController(dataHandlerMock.Object);

            User newUser = new User(
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
            bool result = userController.Register(newUser);

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void Register_WhenUserAlreadyExists_ReturnsFalse()
        {
            // Arrange
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            User duplicateUser = new User(
                "Nat",
                "999",
                "Otra Natalia",
                62,
                161,
                "Perder peso",
                "Ligero",
                "Vegetariana",
                30,
                "Femenino");

            // Act
            bool result = userController.Register(duplicateUser);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetUserByUserName_WhenUserExists_ReturnsUser()
        {
            // Arrange
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            // Act
            User? result = userController.GetUserByUserName("Nat");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Natalia Tobal", result.Name);
        }

        [TestMethod]
        public void UpdateUser_WhenUserExists_UpdatesAndReturnsTrue()
        {
            // Arrange
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<User>>()))
                .Returns(true);

            UserController userController = new UserController(dataHandlerMock.Object);

            User updatedUser = new User(
                "Nat",
                "123",
                "Natalia Tobal Actualizada",
                61,
                160,
                "Mantener",
                "Activo",
                "Alta en proteína",
                33,
                "Femenino");

            // Act
            bool result = userController.UpdateUser(updatedUser);

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void UpdateUser_WhenUserDoesNotExist_ReturnsFalse()
        {
            // Arrange
            List<User> users = new List<User>();

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            User updatedUser = new User(
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
            bool result = userController.UpdateUser(updatedUser);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
