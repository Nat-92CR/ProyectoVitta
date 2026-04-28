namespace VittaController.Abstractions
{
    using System.Collections.Generic;
    using VittaModel;

    /// <summary>
    /// Interfaz que define el contrato de las operaciones principales relacionadas con los usuarios del sistema,
    /// específicamente el inicio de sesión, el registro y la actualización del perfil.
    /// </summary>
    public interface IUserController
    {
        /// <summary>
        /// Valida el acceso de un usuario utilizando su nombre de usuario y contraseña.
        /// </summary>
        /// <param name="username">El nombre de usuario ingresado.</param>
        /// <param name="password">La contraseña ingresada.</param>
        /// <returns>True si las credenciales son válidas y el inicio de sesión es exitoso; de lo contrario, false.</returns>
        bool Login(string username, string password);

        /// <summary>
        /// Registra un nuevo usuario en el sistema.
        /// </summary>
        /// <param name="user">Usuario a registrar.</param>
        /// <returns>True si el registro se realiza correctamente; de lo contrario, false.</returns>
        bool Register(User user);

        /// <summary>
        /// Obtiene un usuario por su nombre de usuario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>Usuario encontrado o null si no existe.</returns>
        User? GetUserByUserName(string username);

        /// <summary>
        /// Obtiene la lista completa de usuarios del sistema.
        /// </summary>
        /// <returns>Lista de usuarios registrados.</returns>
        List<User> GetUsers();

        /// <summary>
        /// Actualiza la información de un usuario existente.
        /// </summary>
        /// <param name="updatedUser">Usuario con datos actualizados.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        bool UpdateUser(User updatedUser);

        /// <summary>
        /// Restablece la contraseña de un usuario existente.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <param name="newPassword">Nueva contraseña.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        bool ResetPassword(string userName, string newPassword);

        /// <summary>
        /// Desactiva un usuario existente.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <returns>True si se desactiva correctamente; de lo contrario, false.</returns>
        bool DeactivateUser(string userName);

        /// <summary>
        /// Activa un usuario existente.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <returns>True si se activa correctamente; de lo contrario, false.</returns>
        bool ActivateUser(string userName);
    }
}