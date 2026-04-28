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
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.Login("Nat", "123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_WhenPasswordIsIncorrect_ReturnsFalse()
        {
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.Login("Nat", "999");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_WhenUserNameIsEmpty_ReturnsFalse()
        {
            List<User> users = new List<User>();

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.Login("", "123");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_WhenUserIsInactive_ReturnsFalse()
        {
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino", false, false)
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.Login("Nat", "123");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Register_WhenUserDoesNotExist_AddsUserAndReturnsTrue()
        {
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

            bool result = userController.Register(newUser);

            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void Register_WhenUserAlreadyExists_ReturnsFalse()
        {
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
                "Perder grasa",
                "Ligero",
                "Vegetariana",
                30,
                "Femenino");

            bool result = userController.Register(duplicateUser);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetUserByUserName_WhenUserExists_ReturnsUser()
        {
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino")
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            User? result = userController.GetUserByUserName("Nat");

            Assert.IsNotNull(result);
            Assert.AreEqual("Natalia Tobal", result.Name);
        }

        [TestMethod]
        public void UpdateUser_WhenUserExists_UpdatesAndReturnsTrue()
        {
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
                "Moderado",
                "Estándar",
                33,
                "Femenino",
                true,
                false);

            bool result = userController.UpdateUser(updatedUser);

            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void UpdateUser_WhenUserDoesNotExist_ReturnsFalse()
        {
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

            bool result = userController.UpdateUser(updatedUser);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ResetPassword_WhenUserExists_UpdatesPasswordAndReturnsTrue()
        {
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

            bool result = userController.ResetPassword("Nat", "999");

            Assert.IsTrue(result);
            Assert.AreEqual("999", users[0].Password);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void ResetPassword_WhenUserDoesNotExist_ReturnsFalse()
        {
            List<User> users = new List<User>();

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.ResetPassword("Nat", "999");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeactivateUser_WhenUserExistsAndIsActive_ReturnsTrue()
        {
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino", true, false)
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<User>>()))
                .Returns(true);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.DeactivateUser("Nat");

            Assert.IsTrue(result);
            Assert.IsFalse(users[0].IsActive);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void DeactivateUser_WhenUserIsAdmin_ReturnsFalse()
        {
            List<User> users = new List<User>
            {
                new User("admin", "123", "Administrador", 70, 170, "Mantener", "Sedentario", "Estándar", 30, "No especificado", true, true)
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.DeactivateUser("admin");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ActivateUser_WhenUserExistsAndIsInactive_ReturnsTrue()
        {
            List<User> users = new List<User>
            {
                new User("Nat", "123", "Natalia Tobal", 60, 160, "Mantener", "Moderado", "Estándar", 33, "Femenino", false, false)
            };

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<User>>()))
                .Returns(true);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.ActivateUser("Nat");

            Assert.IsTrue(result);
            Assert.IsTrue(users[0].IsActive);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<User>>()), Times.Once);
        }

        [TestMethod]
        public void ActivateUser_WhenUserDoesNotExist_ReturnsFalse()
        {
            List<User> users = new List<User>();

            Mock<IDataHandler<User>> dataHandlerMock = new Mock<IDataHandler<User>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);

            UserController userController = new UserController(dataHandlerMock.Object);

            bool result = userController.ActivateUser("Nat");

            Assert.IsFalse(result);
        }
    }
}