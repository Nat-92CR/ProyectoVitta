namespace VittaController
{
    using System;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Implementa las operaciones relacionadas con los alimentos del sistema,
    /// como registro, consulta, actualización y eliminación.
    /// </summary>
    public class FoodController : IFoodController
    {
        private readonly List<Food> foods;
        private readonly IDataHandler<Food> dataHandler;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FoodController"/>.
        /// </summary>
        /// <param name="dataHandler">Manejador de datos de alimentos.</param>
        public FoodController(IDataHandler<Food> dataHandler)
        {
            this.dataHandler = dataHandler;
            this.foods = this.dataHandler.LoadData();
        }

        /// <summary>
        /// Registra un nuevo alimento en el sistema.
        /// </summary>
        /// <param name="food">Alimento a registrar.</param>
        /// <returns>True si se registra correctamente; de lo contrario, false.</returns>
        public bool RegisterFood(Food food)
        {
            if (food == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(food.Name))
            {
                return false;
            }

            if (food.Calories < 0 || food.Protein < 0 || food.Carbohydrates < 0 || food.Fat < 0)
            {
                return false;
            }

            if (this.ExistsFoodName(food.Name))
            {
                return false;
            }

            this.foods.Add(food);
            return this.dataHandler.SaveData(this.foods);
        }

        /// <summary>
        /// Obtiene la lista de alimentos registrados.
        /// </summary>
        /// <returns>Lista de alimentos.</returns>
        public List<Food> GetFoods()
        {
            return new List<Food>(this.foods);
        }

        /// <summary>
        /// Obtiene un alimento por su nombre.
        /// </summary>
        /// <param name="name">Nombre del alimento.</param>
        /// <returns>Alimento encontrado o null si no existe.</returns>
        public Food GetFoodByName(string name)
        {
            foreach (var food in this.foods)
            {
                if (food.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return food;
                }
            }

            return null;
        }

        /// <summary>
        /// Busca alimentos por nombre o parte del nombre.
        /// </summary>
        /// <param name="name">Texto a buscar.</param>
        /// <returns>Lista de alimentos encontrados.</returns>
        public List<Food> SearchFoodsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Food>(this.foods);
            }

            var foundFoods = new List<Food>();

            foreach (var food in this.foods)
            {
                if (food.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundFoods.Add(food);
                }
            }

            return foundFoods;
        }

        /// <summary>
        /// Actualiza la información de un alimento existente.
        /// </summary>
        /// <param name="updatedFood">Alimento con datos actualizados.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        public bool UpdateFood(Food updatedFood)
        {
            if (updatedFood == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(updatedFood.Name))
            {
                return false;
            }

            if (updatedFood.Calories < 0 || updatedFood.Protein < 0 || updatedFood.Carbohydrates < 0 || updatedFood.Fat < 0)
            {
                return false;
            }

            for (int i = 0; i < this.foods.Count; i++)
            {
                if (this.foods[i].Name.Equals(updatedFood.Name, StringComparison.OrdinalIgnoreCase))
                {
                    this.foods[i] = updatedFood;
                    return this.dataHandler.SaveData(this.foods);
                }
            }

            return false;
        }

        /// <summary>
        /// Elimina un alimento por su nombre.
        /// </summary>
        /// <param name="name">Nombre del alimento a eliminar.</param>
        /// <returns>True si se elimina correctamente; de lo contrario, false.</returns>
        public bool DeleteFood(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            for (int i = 0; i < this.foods.Count; i++)
            {
                if (this.foods[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    this.foods.RemoveAt(i);
                    return this.dataHandler.SaveData(this.foods);
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe un alimento registrado con el mismo nombre.
        /// </summary>
        /// <param name="name">Nombre del alimento.</param>
        /// <returns>True si ya existe; de lo contrario, false.</returns>
        private bool ExistsFoodName(string name)
        {
            foreach (var food in this.foods)
            {
                if (food.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}