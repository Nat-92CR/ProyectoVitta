using VittaController;
using VittaController.Abstractions;
using VittaModel;
using VittaView.Configuration;

namespace VittaView
{
    internal static class Program
    {
        /// <summary>
        /// Punto principal de entrada de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var loginController = LoadServices();
            var foodController = LoadFoodServices();

            Application.Run(new LoginView(loginController, foodController));
        }

        private static LoginController LoadServices()
        {
            var fileHandler = new FileHandler<User>(ConfigurationItems.UserFilePath);
            var userController = new UserController(fileHandler);
            var loginController = new LoginController(userController);
            return loginController;
        }

        private static IFoodController LoadFoodServices()
        {
            var fileHandler = new FileHandler<Food>(ConfigurationItems.FoodFilePath);
            var foodController = new FoodController(fileHandler);
            return foodController;
        }
    }
}