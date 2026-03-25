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
        User GetUserByUserName(string username);

        /// <summary>
        /// Calcula las calorías de mantenimiento del usuario.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <returns>Calorías de mantenimiento.</returns>
        double CalculateMaintenanceCalories(User user);
    }
}