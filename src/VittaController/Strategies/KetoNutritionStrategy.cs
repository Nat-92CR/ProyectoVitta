namespace VittaController.Strategies
{
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Estrategia para la dieta keto.
    /// </summary>
    internal class KetoNutritionStrategy : INutritionStrategy
    {
        /// <summary>
        /// Obtiene los porcentajes de macronutrientes para una dieta keto.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        public void GetMacronutrientPercentages(
            User user,
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage)
        {
            proteinPercentage = 0.30;
            carbohydratesPercentage = 0.10;
            fatPercentage = 0.60;
        }
    }
}