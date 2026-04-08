using System;
using System.IO;

namespace VittaView.Configuration
{
    /// <summary>
    /// Clase que contiene los elementos de configuración necesarios
    /// para el funcionamiento de la aplicación.
    /// </summary>
    public static class ConfigurationItems
    {
        /// <summary>
        /// Ruta base desde la cual se ejecuta la aplicación.
        /// </summary>
        private static readonly string BasePath = AppContext.BaseDirectory;

        /// <summary>
        /// Ruta del archivo de usuarios utilizada para cargar y guardar
        /// la información relacionada con el acceso al sistema.
        /// </summary>
        public static readonly string UserFilePath = Path.Combine(BasePath, "data", "users.csv");

        /// <summary>
        /// Ruta del archivo de alimentos utilizada para cargar y guardar
        /// la información relacionada con el módulo de alimentos.
        /// </summary>
        public static readonly string FoodFilePath = Path.Combine(BasePath, "data", "foods.csv");

        /// <summary>
        /// Ruta del archivo de menús utilizada para cargar y guardar
        /// la información relacionada con el módulo de menús.
        /// </summary>
        public static readonly string MenuFilePath = Path.Combine(BasePath, "data", "menus.csv");
    }
}