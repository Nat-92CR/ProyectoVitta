namespace VittaController
{
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Implementa las operaciones relacionadas con los usuarios del sistema,
    /// como inicio de sesión, registro y actualización de perfil.
    /// </summary>
    public class UserController : IUserController
    {
        private readonly List<User> users;
        private readonly IDataHandler<User> dataHandler;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserController"/>.
        /// </summary>
        /// <param name="dataHandler">Manejador de datos de usuarios.</param>
        
        //CONSTRUCTOR UserController (Controlador de Usuarios)
        public UserController(IDataHandler<User> dataHandler)
        {
            this.dataHandler = dataHandler;
            this.users = this.dataHandler.LoadData();
        }

        /// <summary>
        /// Valida el inicio de sesión utilizando nombre de usuario y contraseña.
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

            return this.ExistsUserForLogin(username, password);
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
                string.IsNullOrWhiteSpace(user.DietType))
            {
                return false;
            }

            if (user.Weight <= 0 || user.Height <= 0)
            {
                return false;
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
        public User GetUserByUserName(string username)
        {
            foreach (var user in this.users)
            {
                if (user.UserName == username)
                {
                    return user;
                }
            }

            return null;
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
        /// Verifica si existe un usuario con nombre de usuario y contraseña válidos.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <returns>True si existe coincidencia; de lo contrario, false.</returns>
        private bool ExistsUserForLogin(string username, string password)
        {
            foreach (var user in this.users)
            {
                if (user.UserName == username && user.Password == password)
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