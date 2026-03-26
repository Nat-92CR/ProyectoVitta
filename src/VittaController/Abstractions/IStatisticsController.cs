namespace VittaController.Abstractions
{
    using System;
    using System.Collections.Generic;
    using VittaModel;

    /// <summary>
    /// Define las operaciones del módulo de estadísticas nutricionales.
    /// </summary>
    public interface IStatisticsController
    {
        /// <summary>
        /// Obtiene un usuario por su nombre de usuario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>Usuario encontrado o null.</returns>
        User? GetUserByUserName(string username);

        /// <summary>
        /// Obtiene los menús de un usuario dentro de un rango de fechas.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Lista de menús encontrados.</returns>
        List<Menu> GetMenusByDateRange(string userName, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Calcula el consumo nutricional total de un día específico.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="selectedDate">Fecha a consultar.</param>
        /// <param name="totalCalories">Calorías consumidas.</param>
        /// <param name="totalProtein">Proteínas consumidas.</param>
        /// <param name="totalCarbohydrates">Carbohidratos consumidos.</param>
        /// <param name="totalFat">Grasas consumidas.</param>
        void CalculateDailyConsumption(
            string userName,
            DateTime selectedDate,
            out double totalCalories,
            out double totalProtein,
            out double totalCarbohydrates,
            out double totalFat);

        /// <summary>
        /// Calcula el consumo nutricional total de un período.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <param name="totalCalories">Calorías consumidas en el período.</param>
        /// <param name="totalProtein">Proteínas consumidas en el período.</param>
        /// <param name="totalCarbohydrates">Carbohidratos consumidos en el período.</param>
        /// <param name="totalFat">Grasas consumidas en el período.</param>
        void CalculateConsumptionByDateRange(
            string userName,
            DateTime startDate,
            DateTime endDate,
            out double totalCalories,
            out double totalProtein,
            out double totalCarbohydrates,
            out double totalFat);

        /// <summary>
        /// Calcula la meta diaria de calorías del usuario.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <returns>Meta diaria de calorías.</returns>
        double CalculateDailyCalorieGoal(string userName);

        /// <summary>
        /// Calcula la meta diaria de macronutrientes del usuario.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="proteinGoal">Meta de proteínas.</param>
        /// <param name="carbohydratesGoal">Meta de carbohidratos.</param>
        /// <param name="fatGoal">Meta de grasas.</param>
        void CalculateDailyMacronutrientGoal(
            string userName,
            out double proteinGoal,
            out double carbohydratesGoal,
            out double fatGoal);

        /// <summary>
        /// Calcula cuántas calorías faltan o sobran respecto a la meta diaria.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="selectedDate">Fecha a consultar.</param>
        /// <returns>Diferencia entre meta y consumo.</returns>
        double CalculateRemainingCalories(string userName, DateTime selectedDate);

        /// <summary>
        /// Calcula cuánto falta o sobra en cada macronutriente respecto a la meta diaria.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="selectedDate">Fecha a consultar.</param>
        /// <param name="remainingProtein">Diferencia de proteínas.</param>
        /// <param name="remainingCarbohydrates">Diferencia de carbohidratos.</param>
        /// <param name="remainingFat">Diferencia de grasas.</param>
        void CalculateRemainingMacronutrients(
            string userName,
            DateTime selectedDate,
            out double remainingProtein,
            out double remainingCarbohydrates,
            out double remainingFat);

        /// <summary>
        /// Cuenta cuántos días del período cumplieron o superaron la meta calórica.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Cantidad de días que cumplieron la meta.</returns>
        int CountDaysMeetingCalorieGoal(string userName, DateTime startDate, DateTime endDate);
    }
}