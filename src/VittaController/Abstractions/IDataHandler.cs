namespace VittaController.Abstractions
{
    /// <summary>
    /// Interfaz que define el contrato para las operaciones de carga y guardado de datos del sistema.
    /// Se utiliza para desacoplar la lógica del proyecto de la forma en que los datos se almacenan o recuperan.
    /// </summary>
    /// <typeparam name="T">Tipo de elemento que se va a manejar.</typeparam>
    public interface IDataHandler<T>
    {
        /// <summary>
        /// Guarda la colección de datos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de elemento que se va a guardar.</typeparam>
        /// <param name="filePath">La ruta del archivo.</param>
        /// <param name="data">Los datos que se desean guardar.</param>
        /// <returns>True si el proceso de guardado se realiza correctamente; de lo contrario, false.</returns>
        public bool SaveData(List<T> data);

        /// <summary>
        /// Carga la colección de datos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de elemento que se va a cargar.</typeparam>
        /// <param name="filePath">La ruta del archivo.</param>
        /// <returns>La colección de datos cargada.</returns>
        public List<T> LoadData();
    }
}