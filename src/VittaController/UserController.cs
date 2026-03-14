namespace VittaController
{
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Implementa las operaciones relacionadas con los usuarios del sistema,
    /// como el inicio de sesión y el registro, utilizando el modelo de usuario
    /// y el manejador de datos correspondiente.
    /// </summary>
    public class UserController : IUserController
    {
        private readonly List<User> users;
        private readonly IDataHandler<User> dataHandler;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserController"/>
        /// con el manejador de datos encargado de cargar y guardar la información de usuarios.
        /// </summary>
        /// <param name="dataHandler">El manejador de datos.</param>
        public UserController(IDataHandler<User> dataHandler)
        {
            this.dataHandler = dataHandler;
            this.users = dataHandler.LoadData();
        }

        /// <summary>
        /// Valida el inicio de sesión de un usuario utilizando el nombre de usuario
        /// y la contraseña proporcionados.
        /// </summary>
        /// <param name="username">El nombre de usuario.</param>
        /// <param name="password">La contraseña.</param>
        /// <returns>
        /// True si el inicio de sesión es exitoso; de lo contrario, false.
        /// </returns>
        public bool Login(string username, string password)
        {
            if (this.users != null && this.ExistsUser(username, password))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Registra un nuevo usuario en el sistema utilizando el nombre de usuario
        /// y la contraseña proporcionados.
        /// </summary>
        /// <param name="username">El nombre de usuario.</param>
        /// <param name="password">La contraseña.</param>
        /// <returns>
        /// True si el registro es exitoso; de lo contrario, false.
        /// </returns>
        public bool Register(string username, string password)
        {
            if (this.users != null)
            {
                if (this.ExistsUser(username, password))
                {
                    return false;
                }

                this.users.Add(new User(username, password));
                var result = this.dataHandler.SaveData(this.users);
                return result;
            }

            return false;
        }

        private bool ExistsUser(string username, string password)
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
    }
}