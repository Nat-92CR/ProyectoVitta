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
        public User? GetUserByUserName(string username)
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
        /// Calcula el índice de masa corporal del usuario.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <returns>Valor del IMC.</returns>
        public double CalculateBodyMassIndex(User user)
        {
            if (user == null || user.Weight <= 0 || user.Height <= 0)
            {
                return 0;
            }

            double heightInMeters = this.NormalizeHeightToMeters(user.Height);

            if (heightInMeters <= 0)
            {
                return 0;
            }

            return user.Weight / (heightInMeters * heightInMeters);
        }

        /// <summary>
        /// Obtiene la clasificación del IMC según el valor calculado.
        /// </summary>
        /// <param name="bodyMassIndex">Valor del IMC.</param>
        /// <returns>Clasificación del IMC.</returns>
        public string GetBodyMassIndexCategory(double bodyMassIndex)
        {
            if (bodyMassIndex <= 0)
            {
                return "No disponible";
            }

            if (bodyMassIndex < 18.5)
            {
                return "Bajo peso";
            }

            if (bodyMassIndex < 25)
            {
                return "Normal";
            }

            if (bodyMassIndex < 30)
            {
                return "Sobrepeso";
            }

            return "Obesidad";
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

        /// <summary>
        /// Convierte la altura a metros cuando sea necesario.
        /// </summary>
        /// <param name="height">Altura registrada.</param>
        /// <returns>Altura en metros.</returns>
        private double NormalizeHeightToMeters(double height)
        {
            if (height > 3)
            {
                return height / 100;
            }

            return height;
        }
    }
}