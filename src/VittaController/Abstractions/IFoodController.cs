namespace VittaController.Abstractions
{
    using VittaModel;

    /// <summary>
    /// Interfaz que define el contrato de las operaciones principales
    /// relacionadas con los alimentos del sistema.
    /// </summary>
    public interface IFoodController
    {
        /// <summary>
        /// Registra un nuevo alimento en el sistema.
        /// </summary>
        /// <param name="food">Alimento a registrar.</param>
        /// <returns>True si el registro se realiza correctamente; de lo contrario, false.</returns>
        bool RegisterFood(Food food);

        /// <summary>
        /// Obtiene la lista de alimentos registrados.
        /// </summary>
        /// <returns>Lista de alimentos.</returns>
        List<Food> GetFoods();

        /// <summary>
        /// Obtiene un alimento por su nombre.
        /// </summary>
        /// <param name="name">Nombre del alimento.</param>
        /// <returns>Alimento encontrado o null.</returns>
        Food GetFoodByName(string name);

        /// <summary>
        /// Busca alimentos por nombre o parte del nombre.
        /// </summary>
        /// <param name="name">Texto a buscar.</param>
        /// <returns>Lista de alimentos encontrados.</returns>
        List<Food> SearchFoodsByName(string name);

        /// <summary>
        /// Actualiza la información de un alimento.
        /// </summary>
        /// <param name="updatedFood">Alimento con los datos actualizados.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        bool UpdateFood(Food updatedFood);

        /// <summary>
        /// Elimina un alimento por su nombre.
        /// </summary>
        /// <param name="name">Nombre del alimento a eliminar.</param>
        /// <returns>True si se elimina correctamente; de lo contrario, false.</returns>
        bool DeleteFood(string name);
    }
}