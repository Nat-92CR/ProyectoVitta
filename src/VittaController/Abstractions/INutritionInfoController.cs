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
    }
}