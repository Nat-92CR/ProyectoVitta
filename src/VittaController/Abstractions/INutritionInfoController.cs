namespace VittaController.Abstractions
{
    using VittaModel;

    /// <summary>
    /// Define las operaciones del módulo de información nutricional.
    /// </summary>
    public interface INutritionInfoController
    {
        /// <summary>
        /// Obtiene la información del usuario actual.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>Usuario encontrado o null.</returns>
        User? GetUserByUserName(string username);

        /// <summary>
        /// Calcula las calorías de mantenimiento del usuario.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <returns>Calorías de mantenimiento.</returns>
        double CalculateMaintenanceCalories(User user);

        /// <summary>
        /// Calcula el índice de masa corporal del usuario.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <returns>Valor del IMC.</returns>
        double CalculateBodyMassIndex(User user);

        /// <summary>
        /// Obtiene la clasificación del IMC según el valor calculado.
        /// </summary>
        /// <param name="bodyMassIndex">Valor del IMC.</param>
        /// <returns>Clasificación del IMC.</returns>
        string GetBodyMassIndexCategory(double bodyMassIndex);

        /// <summary>
        /// Calcula la distribución recomendada de macronutrientes.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <param name="proteinGrams">Proteínas recomendadas en gramos.</param>
        /// <param name="carbohydratesGrams">Carbohidratos recomendados en gramos.</param>
        /// <param name="fatGrams">Grasas recomendadas en gramos.</param>
        void CalculateMacronutrients(
            User user,
            out double proteinGrams,
            out double carbohydratesGrams,
            out double fatGrams);
    }
}