namespace VittaController
{
    using System;
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
        /// Calcula la distribución recomendada de macronutrientes.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <param name="proteinGrams">Proteínas recomendadas en gramos.</param>
        /// <param name="carbohydratesGrams">Carbohidratos recomendados en gramos.</param>
        /// <param name="fatGrams">Grasas recomendadas en gramos.</param>
        public void CalculateMacronutrients(
            User user,
            out double proteinGrams,
            out double carbohydratesGrams,
            out double fatGrams)
        {
            proteinGrams = 0;
            carbohydratesGrams = 0;
            fatGrams = 0;

            if (user == null || user.Weight <= 0)
            {
                return;
            }

            double maintenanceCalories = this.CalculateMaintenanceCalories(user);

            if (maintenanceCalories <= 0)
            {
                return;
            }

            this.GetMacronutrientPercentages(
                user,
                out double proteinPercentage,
                out double carbohydratesPercentage,
                out double fatPercentage);

            proteinGrams = (maintenanceCalories * proteinPercentage) / 4;
            carbohydratesGrams = (maintenanceCalories * carbohydratesPercentage) / 4;
            fatGrams = (maintenanceCalories * fatPercentage) / 9;
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
        /// Obtiene los porcentajes recomendados de macronutrientes según objetivo y tipo de dieta.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        private void GetMacronutrientPercentages(
            User user,
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage)
        {
            proteinPercentage = 0.25;
            carbohydratesPercentage = 0.50;
            fatPercentage = 0.25;

            if (user.Goal.Equals("Perder grasa", StringComparison.OrdinalIgnoreCase))
            {
                proteinPercentage = 0.30;
                carbohydratesPercentage = 0.40;
                fatPercentage = 0.30;
            }
            else if (user.Goal.Equals("Ganar masa", StringComparison.OrdinalIgnoreCase))
            {
                proteinPercentage = 0.25;
                carbohydratesPercentage = 0.55;
                fatPercentage = 0.20;
            }

            if (user.DietType.Equals("Keto", StringComparison.OrdinalIgnoreCase))
            {
                proteinPercentage = 0.30;
                carbohydratesPercentage = 0.10;
                fatPercentage = 0.60;
            }
            else if (user.DietType.Equals("Vegetariana", StringComparison.OrdinalIgnoreCase) &&
                     user.Goal.Equals("Mantener", StringComparison.OrdinalIgnoreCase))
            {
                proteinPercentage = 0.20;
                carbohydratesPercentage = 0.55;
                fatPercentage = 0.25;
            }
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