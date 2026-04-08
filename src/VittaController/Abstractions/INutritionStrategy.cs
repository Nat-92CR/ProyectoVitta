namespace VittaController.Abstractions
{
    using VittaModel;

    /// <summary>
    /// Define el contrato para calcular porcentajes de macronutrientes
    /// según la estrategia nutricional aplicada.
    /// </summary>
    public interface INutritionStrategy
    {
        /// <summary>
        /// Obtiene los porcentajes de proteínas, carbohidratos y grasas
        /// recomendados para el usuario.
        /// </summary>
        /// <param name="user">Usuario a evaluar.</param>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        void GetMacronutrientPercentages(
            User user,
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage);
    }
}