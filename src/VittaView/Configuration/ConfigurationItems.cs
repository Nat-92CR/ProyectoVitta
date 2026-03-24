namespace VittaView.Configuration
{
    /// <summary>
    /// Clase que contiene los elementos de configuración necesarios
    /// para el funcionamiento de la aplicación.
    /// </summary>
    public static class ConfigurationItems
    {
        /// <summary>
        /// Ruta del archivo de usuarios utilizada para cargar y guardar
        /// la información relacionada con el acceso al sistema.
        /// </summary>
        public static readonly string UserFilePath = @"C:\Users\natal\OneDrive\Escritorio\ProyectoVitta\users.csv";

        /// <summary>
        /// Ruta del archivo de alimentos utilizada para cargar y guardar
        /// la información relacionada con el módulo de alimentos.
        /// </summary>
        public static readonly string FoodFilePath = @"C:\Users\natal\OneDrive\Escritorio\ProyectoVitta\foods.csv";

        /// <summary>
        /// Ruta del archivo de menús utilizada para cargar y guardar
        /// la información relacionada con el módulo de menús.
        /// </summary>
        public static readonly string MenuFilePath = @"C:\Users\natal\OneDrive\Escritorio\ProyectoVitta\menus.csv";
    }
}