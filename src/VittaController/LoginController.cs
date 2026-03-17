namespace VittaController
{
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Controlador encargado de coordinar las operaciones de inicio de sesión y registro.
    /// </summary>
    public class LoginController
    {
        private readonly IUserController userController;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="LoginController"/>.
        /// </summary>
        /// <param name="userController">El controlador de usuarios.</param>
        public LoginController(IUserController userController)
        {
            this.userController = userController;
        }

        /// <summary>
        /// Ejecuta el proceso de inicio de sesión.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <returns>True si el inicio de sesión es exitoso; de lo contrario, false.</returns>
        public bool Login(string username, string password)
        {
            return this.userController.Login(username, password);
        }

        /// <summary>
        /// Ejecuta el proceso de registro de un usuario completo.
        /// </summary>
        /// <param name="user">Usuario a registrar.</param>
        /// <returns>True si el registro es exitoso; de lo contrario, false.</returns>
        public bool Register(User user)
        {
            return this.userController.Register(user);
        }
    }
}