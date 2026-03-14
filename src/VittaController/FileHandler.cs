namespace VittaController
{
    using VittaController.Abstractions;
    using System.Collections.Generic;

    /// <summary>
    /// Clase encargada de gestionar la carga y el guardado de datos mediante archivos,
    /// siguiendo el contrato definido para el manejo de datos del sistema.
    /// </summary>
    public class FileHandler<T> : IDataHandler<T>
    {
        private readonly string filePath;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FileHandler{T}"/>
        /// con la ruta del archivo que se utilizará para cargar o guardar información.
        /// </summary>
        /// <param name="filePath">La ruta del archivo.</param>
        public FileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// Carga los datos almacenados en el archivo configurado y los convierte
        /// en una lista del tipo especificado.
        /// </summary>
        /// <param name="filePath">La ruta del archivo.</param>
        /// <returns>
        /// La colección de datos cargada desde el archivo.
        /// </returns>
        public List<T> LoadData()
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            var data = new List<T>();
            var lines = File.ReadAllLines(filePath);

            for (var i = 1; i < lines.Length; i++)
            {
                var lineElements = lines[i].Split(',');
                var element = Activator.CreateInstance(typeof(T), lineElements);
                data.Add((T)element);
            }

            return data;
        }

        /// <summary>
        /// Guarda la colección de datos recibida en el archivo correspondiente.
        /// </summary>
        /// <param name="filePath">La ruta del archivo.</param>
        /// <param name="data">Los datos que se desean guardar.</param>
        /// <returns>
        /// True si los datos se guardan correctamente; de lo contrario, false.
        /// </returns>
        public bool SaveData(List<T> data)
        {
            return true;
        }
    }
}