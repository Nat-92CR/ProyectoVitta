namespace VittaController
{
    using System;
    using System.Collections.Generic;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Implementa las operaciones relacionadas con los usuarios del sistema,
    /// como inicio de sesión, registro, actualización de perfil y mantenimiento administrativo.
    /// </summary>
    public class UserController : IUserController
    {
        private readonly List<User> users;
        private readonly IDataHandler<User> dataHandler;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserController"/>.
        /// </summary>
        /// <param name="dataHandler">Manejador de datos de usuarios.</param>
        public UserController(IDataHandler<User> dataHandler)
        {
            this.dataHandler = dataHandler;
            this.users = this.dataHandler.LoadData();
        }

        /// <summary>
        /// Valida el inicio de sesión utilizando nombre de usuario y contraseña.
        /// Solo permite el acceso a usuarios activos.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <returns>True si las credenciales son correctas; de lo contrario, false.</returns>
        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return this.ExistsUserForLogin(username.Trim(), password.Trim());
        }

        /// <summary>
        /// Registra un nuevo usuario completo en el sistema.
        /// </summary>
        /// <param name="user">Usuario a registrar.</param>
        /// <returns>True si se registra correctamente; de lo contrario, false.</returns>
        public bool Register(User user)
        {
            if (user == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.UserName) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(user.Name) ||
                string.IsNullOrWhiteSpace(user.Goal) ||
                string.IsNullOrWhiteSpace(user.ActivityLevel) ||
                string.IsNullOrWhiteSpace(user.DietType) ||
                string.IsNullOrWhiteSpace(user.Sex))
            {
                return false;
            }

            if (user.Weight <= 0 || user.Height <= 0 || user.Age <= 0)
            {
                return false;
            }

            user.UserName = user.UserName.Trim();
            user.Password = user.Password.Trim();
            user.Name = user.Name.Trim();
            user.IsActive = true;

            if (string.Equals(user.UserName, "admin", StringComparison.OrdinalIgnoreCase))
            {
                user.IsAdmin = true;
            }

            if (this.ExistsUserName(user.UserName))
            {
                return false;
            }

            this.users.Add(user);
            return this.dataHandler.SaveData(this.users);
        }

        /// <summary>
        /// Obtiene un usuario por nombre de usuario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>El usuario encontrado o null si no existe.</returns>
        public User? GetUserByUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            string normalizedUserName = username.Trim();

            foreach (var user in this.users)
            {
                if (user.UserName == normalizedUserName)
                {
                    return user;
                }
            }

            return null;
        }

        /// <summary>
        /// Obtiene la lista completa de usuarios.
        /// </summary>
        /// <returns>Lista de usuarios del sistema.</returns>
        public List<User> GetUsers()
        {
            return new List<User>(this.users);
        }

        /// <summary>
        /// Actualiza los datos de un usuario existente.
        /// </summary>
        /// <param name="updatedUser">Usuario con datos actualizados.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        public bool UpdateUser(User updatedUser)
        {
            if (updatedUser == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(updatedUser.UserName) ||
                string.IsNullOrWhiteSpace(updatedUser.Password) ||
                string.IsNullOrWhiteSpace(updatedUser.Name) ||
                string.IsNullOrWhiteSpace(updatedUser.Goal) ||
                string.IsNullOrWhiteSpace(updatedUser.ActivityLevel) ||
                string.IsNullOrWhiteSpace(updatedUser.DietType) ||
                string.IsNullOrWhiteSpace(updatedUser.Sex))
            {
                return false;
            }

            if (updatedUser.Weight <= 0 || updatedUser.Height <= 0 || updatedUser.Age <= 0)
            {
                return false;
            }

            updatedUser.UserName = updatedUser.UserName.Trim();
            updatedUser.Password = updatedUser.Password.Trim();
            updatedUser.Name = updatedUser.Name.Trim();

            for (int i = 0; i < this.users.Count; i++)
            {
                if (this.users[i].UserName == updatedUser.UserName)
                {
                    this.users[i] = updatedUser;
                    return this.dataHandler.SaveData(this.users);
                }
            }

            return false;
        }

        /// <summary>
        /// Restablece la contraseña de un usuario existente.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <param name="newPassword">Nueva contraseña.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        public bool ResetPassword(string userName, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(newPassword))
            {
                return false;
            }

            string normalizedUserName = userName.Trim();
            string normalizedPassword = newPassword.Trim();

            for (int i = 0; i < this.users.Count; i++)
            {
                if (this.users[i].UserName == normalizedUserName)
                {
                    this.users[i].Password = normalizedPassword;
                    return this.dataHandler.SaveData(this.users);
                }
            }

            return false;
        }

        /// <summary>
        /// Desactiva un usuario existente.
        /// No permite desactivar administradores.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <returns>True si se desactiva correctamente; de lo contrario, false.</returns>
        public bool DeactivateUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            string normalizedUserName = userName.Trim();

            for (int i = 0; i < this.users.Count; i++)
            {
                if (this.users[i].UserName == normalizedUserName)
                {
                    if (this.users[i].IsAdmin)
                    {
                        return false;
                    }

                    if (!this.users[i].IsActive)
                    {
                        return false;
                    }

                    this.users[i].IsActive = false;
                    return this.dataHandler.SaveData(this.users);
                }
            }

            return false;
        }

        /// <summary>
        /// Activa un usuario existente.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <returns>True si se activa correctamente; de lo contrario, false.</returns>
        public bool ActivateUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            string normalizedUserName = userName.Trim();

            for (int i = 0; i < this.users.Count; i++)
            {
                if (this.users[i].UserName == normalizedUserName)
                {
                    if (this.users[i].IsActive)
                    {
                        return false;
                    }

                    this.users[i].IsActive = true;
                    return this.dataHandler.SaveData(this.users);
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si existe un usuario con nombre de usuario y contraseña válidos.
        /// Solo permite usuarios activos.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <returns>True si existe coincidencia; de lo contrario, false.</returns>
        private bool ExistsUserForLogin(string username, string password)
        {
            foreach (var user in this.users)
            {
                if (user.UserName == username && user.Password == password && user.IsActive)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe un nombre de usuario registrado.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>True si ya existe; de lo contrario, false.</returns>
        private bool ExistsUserName(string username)
        {
            foreach (var user in this.users)
            {
                if (user.UserName == username)
                {
                    return true;
                }
            }

            return false;
        }
    }
}