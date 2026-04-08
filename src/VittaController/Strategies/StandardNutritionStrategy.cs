namespace VittaController.Strategies
{
    /// <summary>
    /// Estrategia estándar para calcular los porcentajes de macronutrientes
    /// según el objetivo del usuario.
    /// </summary>
    internal class StandardNutritionStrategy : GoalBasedNutritionStrategyBase
    {
        /// <summary>
        /// Obtiene los porcentajes de macronutrientes para mantener el peso
        /// dentro de una dieta estándar.
        /// </summary>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        protected override void GetMaintainPercentages(
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage)
        {
            proteinPercentage = 0.25;
            carbohydratesPercentage = 0.50;
            fatPercentage = 0.25;
        }
    }
}