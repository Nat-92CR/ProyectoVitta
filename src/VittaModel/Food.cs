namespace VittaModel
{
    using System.Globalization;

    /// <summary>
    /// Modelo que representa un alimento del sistema.
    /// </summary>
    public class Food
    {
        /// <summary>
        /// Inicializa un alimento con todos sus datos.
        /// </summary>
        /// <param name="name">Nombre del alimento.</param>
        /// <param name="calories">Calorías del alimento.</param>
        /// <param name="protein">Proteínas del alimento.</param>
        /// <param name="carbohydrates">Carbohidratos del alimento.</param>
        /// <param name="fat">Grasas del alimento.</param>
        public Food(string name, double calories, double protein, double carbohydrates, double fat)
        {
            this.Name = name;
            this.Calories = calories;
            this.Protein = protein;
            this.Carbohydrates = carbohydrates;
            this.Fat = fat;
        }

        /// <summary>
        /// Inicializa un alimento a partir de los datos del archivo CSV.
        /// </summary>
        /// <param name="foodData">Arreglo con los datos del alimento.</param>
        public Food(string[] foodData)
        {
            this.Name = foodData[0];
            this.Calories = double.Parse(foodData[1], CultureInfo.InvariantCulture);
            this.Protein = double.Parse(foodData[2], CultureInfo.InvariantCulture);
            this.Carbohydrates = double.Parse(foodData[3], CultureInfo.InvariantCulture);
            this.Fat = double.Parse(foodData[4], CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Obtiene o establece el nombre del alimento.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece las calorías del alimento.
        /// </summary>
        public double Calories { get; set; }

        /// <summary>
        /// Obtiene o establece las proteínas del alimento.
        /// </summary>
        public double Protein { get; set; }

        /// <summary>
        /// Obtiene o establece los carbohidratos del alimento.
        /// </summary>
        public double Carbohydrates { get; set; }

        /// <summary>
        /// Obtiene o establece las grasas del alimento.
        /// </summary>
        public double Fat { get; set; }
    }
}