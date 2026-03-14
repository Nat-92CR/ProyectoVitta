namespace VittaController
{
    using VittaController.Abstractions;

    /// <summary>
    /// Controlador encargado de coordinar las operaciones de inicio de sesión y registro,
    /// delegando la lógica correspondiente al controlador de usuarios del sistema.
    /// </summary>
    public class LoginController
    {
        private readonly IUserController userController;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="LoginController"/>
        /// con la dependencia encargada de las operaciones de usuario.
        /// </summary>
        /// <param name="userController">El controlador de usuarios.</param>
        public LoginController(IUserController userController)
        {
            this.userController = userController;
        }

        /// <summary>
        /// Ejecuta el proceso de inicio de sesión utilizando el nombre de usuario
        /// y la contraseña proporcionados.
        /// </summary>
        /// <param name="username">El nombre de usuario.</param>
        /// <param name="password">La contraseña.</param>
        /// <returns>True si el inicio de sesión es exitoso; de lo contrario, false.</returns>
        public bool Login(string username, string password)
        {
            return this.userController.Login(username, password);
        }

        /// <summary>
        /// Ejecuta el proceso de registro de un nuevo usuario con las credenciales proporcionadas.
        /// </summary>
        /// <param name="username">El nombre de usuario.</param>
        /// <param name="password">La contraseña.</param>
        /// <returns>True si el registro es exitoso; de lo contrario, false.</returns>
        public bool Register(string username, string password)
        {
            return this.userController.Register(username, password);
        }
    }
}