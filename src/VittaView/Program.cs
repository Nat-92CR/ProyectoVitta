using VittaController;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var loginController = LoadServices();
            Application.Run(new LoginView(loginController));
        }

        private static LoginController LoadServices()
        {
            var fileHandler = new FileHandler<User>(ConfigurationItems.UserFilePath);
            var userController = new UserController(fileHandler);
            var loginController = new LoginController(userController);
            return loginController;
        }
    }
}