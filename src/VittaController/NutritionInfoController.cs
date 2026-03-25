namespace VittaController
{
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Controlador encargado de calcular y entregar la información nutricional del usuario.
    /// </summary>
    public class NutritionInfoController : INutritionInfoController
    {
        private readonly LoginController loginController;

        /// <summary>
        /// Inicializa una nueva instancia de la clase NutritionInfoController.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        public NutritionInfoController(LoginController loginController)
        {
            this.loginController = loginController;
        }

        /// <summary>
        /// Obtiene un usuario por su nombre de usuario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>Usuario encontrado o null.</returns>
        public User GetUserByUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            return this.loginController.GetUserByUserName(username);
        }

        /// <summary>
        /// Calcula las calorías de mantenimiento con base en el peso y nivel de actividad.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <returns>Calorías de mantenimiento estimadas.</returns>
        public double CalculateMaintenanceCalories(User user)
        {
            if (user == null || user.Weight <= 0)
            {
                return 0;
            }

            double activityFactor = this.GetActivityFactor(user.ActivityLevel);
            return user.Weight * activityFactor;
        }

        /// <summary>
        /// Obtiene el factor de actividad según el nivel registrado por el usuario.
        /// </summary>
        /// <param name="activityLevel">Nivel de actividad.</param>
        /// <returns>Factor de cálculo.</returns>
        private double GetActivityFactor(string activityLevel)
        {
            if (activityLevel == "Sedentario")
            {
                return 30;
            }

            if (activityLevel == "Ligero")
            {
                return 35;
            }

            if (activityLevel == "Moderado")
            {
                return 40;
            }

            if (activityLevel == "Alto")
            {
                return 45;
            }

            return 30;
        }
    }
}