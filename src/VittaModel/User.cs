namespace VittaModel
{
    /// <summary>
    /// Modelo que representa al usuario del sistema y encapsula
    /// la información básica necesaria para los procesos de inicio de sesión y registro.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="User"/>
        /// utilizando el nombre de usuario y la contraseña proporcionados.
        /// </summary>
        /// <param name="userName">El nombre del usuario.</param>
        /// <param name="password">La contraseña.</param>
        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="User"/>
        /// utilizando un arreglo de datos que contiene la información del usuario.
        /// </summary>
        /// <param name="userData">Los datos del usuario.</param>
        public User(string[] userData)
        {
            this.UserName = userData[0];
            this.Password = userData[1];
        }

        /// <summary>
        /// Obtiene o establece el nombre del usuario.
        /// </summary>
        /// <value>
        /// El nombre del usuario.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario.
        /// </summary>
        /// <value>
        /// La contraseña del usuario.
        /// </value>
        public string Password { get; set; }
    }
}