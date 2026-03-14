namespace VittaController.Abstractions
{
    /// <summary>
    /// Interfaz que define el contrato de las operaciones principales relacionadas con los usuarios del sistema,
    /// específicamente el inicio de sesión y el registro.
    /// </summary>
    public interface IUserController
    {
        /// <summary>
        /// Valida el acceso de un usuario utilizando su nombre de usuario y contraseña.
        /// </summary>
        /// <param name="username">El nombre de usuario ingresado.</param>
        /// <param name="password">La contraseña ingresada.</param>
        /// <returns>True si las credenciales son válidas y el inicio de sesión es exitoso; de lo contrario, false.</returns>
        public bool Login(string username, string password);

        /// <summary>
        /// Registra un nuevo usuario en el sistema con el nombre de usuario y la contraseña especificados.
        /// </summary>
        /// <param name="username">El nombre de usuario que se desea registrar.</param>
        /// <param name="password">La contraseña asociada al nuevo usuario.</param>
        /// <returns>True si el registro se realiza correctamente; de lo contrario, false.</returns>
        public bool Register(string username, string password);
    }
}