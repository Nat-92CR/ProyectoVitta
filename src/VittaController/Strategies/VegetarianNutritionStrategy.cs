namespace VittaController.Strategies
{
    /// <summary>
    /// Estrategia para la dieta vegetariana.
    /// </summary>
    internal class VegetarianNutritionStrategy : GoalBasedNutritionStrategyBase
    {
        /// <summary>
        /// Obtiene los porcentajes de macronutrientes para mantener el peso
        /// dentro de una dieta vegetariana.
        /// </summary>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        protected override void GetMaintainPercentages(
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage)
        {
            proteinPercentage = 0.20;
            carbohydratesPercentage = 0.55;
            fatPercentage = 0.25;
        }
    }
}