namespace VittaModel
{
    using System.Globalization;

    /// <summary>
    /// Modelo que representa a un usuario del sistema.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Inicializa un usuario con todos sus datos.
        /// </summary>
        /// <param name="userName">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <param name="name">Nombre completo.</param>
        /// <param name="weight">Peso.</param>
        /// <param name="height">Altura.</param>
        /// <param name="goal">Objetivo.</param>
        /// <param name="activityLevel">Nivel de actividad.</param>
        /// <param name="dietType">Tipo de dieta.</param>
        public User(string userName, string password, string name, double weight, double height, string goal, string activityLevel, string dietType)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Goal = goal;
            this.ActivityLevel = activityLevel;
            this.DietType = dietType;
        }

        /// <summary>
        /// Inicializa un usuario a partir de los datos del archivo CSV.
        /// </summary>
        /// <param name="userData">Arreglo con los datos del usuario.</param>
        public User(string[] userData)
        {
            this.UserName = userData[0];
            this.Password = userData[1];
            this.Name = userData[2];
            this.Weight = double.Parse(userData[3], CultureInfo.InvariantCulture);
            this.Height = double.Parse(userData[4], CultureInfo.InvariantCulture);
            this.Goal = userData[5];
            this.ActivityLevel = userData[6];
            this.DietType = userData[7];
        }

        /// <summary>
        /// Obtiene o establece el nombre de usuario.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece el peso.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Obtiene o establece la altura.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Obtiene o establece el objetivo.
        /// </summary>
        public string Goal { get; set; }

        /// <summary>
        /// Obtiene o establece el nivel de actividad.
        /// </summary>
        public string ActivityLevel { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de dieta.
        /// </summary>
        public string DietType { get; set; }
    }
}