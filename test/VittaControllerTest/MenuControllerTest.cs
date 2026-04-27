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
    public class MenuControllerTest
    {
        [TestMethod]
        public void RegisterMenu_WhenMenuIsValid_ReturnsTrue()
        {
            // Arrange
            List<Menu> menus = new List<Menu>();

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<Menu>>()))
                .Returns(true);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu newMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Arroz x1",
                "",
                "Pollo x1",
                "",
                "Sopa x1");

            // Act
            bool result = menuController.RegisterMenu(newMenu);

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<Menu>>()), Times.Once);
        }

        [TestMethod]
        public void RegisterMenu_WhenUserNameIsEmpty_ReturnsFalse()
        {
            // Arrange
            List<Menu> menus = new List<Menu>();

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu newMenu = new Menu(
                "",
                new DateTime(2026, 4, 27),
                "Arroz x1",
                "",
                "",
                "",
                "");

            // Act
            bool result = menuController.RegisterMenu(newMenu);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RegisterMenu_WhenAllMealTimesAreEmpty_ReturnsFalse()
        {
            // Arrange
            List<Menu> menus = new List<Menu>();

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu newMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "",
                "",
                "",
                "",
                "");

            // Act
            bool result = menuController.RegisterMenu(newMenu);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RegisterMenu_WhenMenuAlreadyExistsForSameUserAndDate_ReturnsFalse()
        {
            // Arrange
            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 27), "Arroz x1", "", "Pollo x1", "", "")
            };

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu duplicateMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Pan x1",
                "",
                "",
                "",
                "");

            // Act
            bool result = menuController.RegisterMenu(duplicateMenu);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetMenusByUser_WhenMenusExist_ReturnsUserMenus()
        {
            // Arrange
            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 27), "Arroz x1", "", "", "", ""),
                new Menu("Nat", new DateTime(2026, 4, 28), "Pan x1", "", "", "", ""),
                new Menu("Karen", new DateTime(2026, 4, 27), "Fruta x1", "", "", "", "")
            };

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            // Act
            List<Menu> result = menuController.GetMenusByUser("Nat");

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void GetMenuByUserAndDate_WhenMenuExists_ReturnsMenu()
        {
            // Arrange
            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 27), "Arroz x1", "", "", "", "")
            };

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            // Act
            Menu? result = menuController.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 27));

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Nat", result.UserName);
        }

        [TestMethod]
        public void GetMenuByUserAndDate_WhenMenuDoesNotExist_ReturnsNull()
        {
            // Arrange
            List<Menu> menus = new List<Menu>();

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            // Act
            Menu? result = menuController.GetMenuByUserAndDate("Nat", new DateTime(2026, 4, 27));

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateMenu_WhenMenuExistsAndDataIsValid_ReturnsTrue()
        {
            // Arrange
            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 27), "Arroz x1", "", "Pollo x1", "", "")
            };

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<Menu>>()))
                .Returns(true);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu updatedMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Arroz x2",
                "",
                "Pollo x1",
                "",
                "Sopa x1");

            // Act
            bool result = menuController.UpdateMenu("Nat", new DateTime(2026, 4, 27), updatedMenu);

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<Menu>>()), Times.Once);
        }

        [TestMethod]
        public void UpdateMenu_WhenMenuDoesNotExist_ReturnsFalse()
        {
            // Arrange
            List<Menu> menus = new List<Menu>();

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu updatedMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 27),
                "Arroz x2",
                "",
                "",
                "",
                "");

            // Act
            bool result = menuController.UpdateMenu("Nat", new DateTime(2026, 4, 27), updatedMenu);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UpdateMenu_WhenNewDateAlreadyExistsForSameUser_ReturnsFalse()
        {
            // Arrange
            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 27), "Arroz x1", "", "", "", ""),
                new Menu("Nat", new DateTime(2026, 4, 28), "Pan x1", "", "", "", "")
            };

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            Menu updatedMenu = new Menu(
                "Nat",
                new DateTime(2026, 4, 28),
                "Arroz x2",
                "",
                "",
                "",
                "");

            // Act
            bool result = menuController.UpdateMenu("Nat", new DateTime(2026, 4, 27), updatedMenu);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeleteMenu_WhenMenuExists_ReturnsTrue()
        {
            // Arrange
            List<Menu> menus = new List<Menu>
            {
                new Menu("Nat", new DateTime(2026, 4, 27), "Arroz x1", "", "", "", "")
            };

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);
            dataHandlerMock
                .Setup(x => x.SaveData(It.IsAny<List<Menu>>()))
                .Returns(true);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            // Act
            bool result = menuController.DeleteMenu("Nat", new DateTime(2026, 4, 27));

            // Assert
            Assert.IsTrue(result);
            dataHandlerMock.Verify(x => x.SaveData(It.IsAny<List<Menu>>()), Times.Once);
        }

        [TestMethod]
        public void DeleteMenu_WhenMenuDoesNotExist_ReturnsFalse()
        {
            // Arrange
            List<Menu> menus = new List<Menu>();

            Mock<IDataHandler<Menu>> dataHandlerMock = new Mock<IDataHandler<Menu>>();
            dataHandlerMock.Setup(x => x.LoadData()).Returns(menus);

            MenuController menuController = new MenuController(dataHandlerMock.Object);

            // Act
            bool result = menuController.DeleteMenu("Nat", new DateTime(2026, 4, 27));

            // Assert
            Assert.IsFalse(result);
        }
    }
}