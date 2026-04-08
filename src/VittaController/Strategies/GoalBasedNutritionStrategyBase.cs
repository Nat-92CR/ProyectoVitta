namespace VittaController.Strategies
{
    using System;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Clase base para estrategias nutricionales que comparten
    /// lógica de distribución de macronutrientes según el objetivo del usuario.
    /// </summary>
    internal abstract class GoalBasedNutritionStrategyBase : INutritionStrategy
    {
        /// <summary>
        /// Obtiene los porcentajes de macronutrientes recomendados
        /// según el objetivo del usuario.
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
            if (user == null || string.IsNullOrWhiteSpace(user.Goal))
            {
                this.GetMaintainPercentages(
                    out proteinPercentage,
                    out carbohydratesPercentage,
                    out fatPercentage);
                return;
            }

            if (user.Goal.Equals("Perder grasa", StringComparison.OrdinalIgnoreCase))
            {
                this.GetLoseFatPercentages(
                    out proteinPercentage,
                    out carbohydratesPercentage,
                    out fatPercentage);
                return;
            }

            if (user.Goal.Equals("Ganar masa", StringComparison.OrdinalIgnoreCase))
            {
                this.GetGainMassPercentages(
                    out proteinPercentage,
                    out carbohydratesPercentage,
                    out fatPercentage);
                return;
            }

            this.GetMaintainPercentages(
                out proteinPercentage,
                out carbohydratesPercentage,
                out fatPercentage);
        }

        /// <summary>
        /// Obtiene los porcentajes de macronutrientes para mantener el peso.
        /// Cada estrategia concreta define este comportamiento.
        /// </summary>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        protected abstract void GetMaintainPercentages(
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage);

        /// <summary>
        /// Obtiene los porcentajes de macronutrientes para perder grasa.
        /// </summary>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        protected virtual void GetLoseFatPercentages(
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage)
        {
            proteinPercentage = 0.30;
            carbohydratesPercentage = 0.40;
            fatPercentage = 0.30;
        }

        /// <summary>
        /// Obtiene los porcentajes de macronutrientes para ganar masa.
        /// </summary>
        /// <param name="proteinPercentage">Porcentaje de proteínas.</param>
        /// <param name="carbohydratesPercentage">Porcentaje de carbohidratos.</param>
        /// <param name="fatPercentage">Porcentaje de grasas.</param>
        protected virtual void GetGainMassPercentages(
            out double proteinPercentage,
            out double carbohydratesPercentage,
            out double fatPercentage)
        {
            proteinPercentage = 0.25;
            carbohydratesPercentage = 0.55;
            fatPercentage = 0.20;
        }
    }
}