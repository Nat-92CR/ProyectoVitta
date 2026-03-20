namespace VittaController
{
    using VittaController.Abstractions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using VittaModel;

    /// <summary>
    /// Clase encargada de gestionar la carga y el guardado de datos mediante archivos,
    /// siguiendo el contrato definido para el manejo de datos del sistema.
    /// </summary>
    public class FileHandler<T> : IDataHandler<T>
    {
        private readonly string filePath;

        /// <summary>
        /// Inicializa una nueva instancia de la clase FileHandler.
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
        /// <returns>La colección de datos cargada desde el archivo.</returns>

        /// METODO LoadData(): lee y guarda el CSV
        public List<T> LoadData()
        {
            if (string.IsNullOrEmpty(this.filePath) || !File.Exists(this.filePath))
            {
                throw new FileNotFoundException($"The file '{this.filePath}' was not found.");
            }

            var data = new List<T>();
            var lines = File.ReadAllLines(this.filePath);

            for (var i = 1; i < lines.Length; i++)
            {
                var lineElements = lines[i].Split(',');
                var element = Activator.CreateInstance(typeof(T), new object[] { lineElements });
                data.Add((T)element);
            }

            return data;
        }

        /// <summary>
        /// Guarda la colección de datos recibida en el archivo correspondiente.
        /// </summary>
        /// <param name="data">Los datos que se desean guardar.</param>
        /// <returns>True si los datos se guardan correctamente; de lo contrario, false.</returns>
        ///Cuando se registra o actualiza un usuario, esta clase vuelve a escribir todo el CSV.
        public bool SaveData(List<T> data)
        {
            if (string.IsNullOrEmpty(this.filePath) || data == null)
            {
                return false;
            }

            var lines = new List<string>();
            lines.Add("UserName,Password,Name,Weight,Height,Goal,ActivityLevel,DietType");

            foreach (var item in data)
            {
                var user = item as User;

                if (user != null)
                {
                    var line = user.UserName + "," +
                               user.Password + "," +
                               user.Name + "," +
                               user.Weight + "," +
                               user.Height + "," +
                               user.Goal + "," +
                               user.ActivityLevel + "," +
                               user.DietType;

                    lines.Add(line);
                }
            }

            File.WriteAllLines(this.filePath, lines);
            return true;
        }
    }
}