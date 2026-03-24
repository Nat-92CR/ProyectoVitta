namespace VittaModel
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Modelo que representa un menú del sistema.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Inicializa un menú con todos sus datos.
        /// </summary>
        /// <param name="userName">Nombre de usuario asociado al menú.</param>
        /// <param name="menuDate">Fecha del menú.</param>
        /// <param name="breakfast">Desayuno.</param>
        /// <param name="morningSnack">Merienda de la mañana.</param>
        /// <param name="lunch">Almuerzo.</param>
        /// <param name="afternoonSnack">Merienda de la tarde.</param>
        /// <param name="dinner">Cena.</param>
        public Menu(string userName, DateTime menuDate, string breakfast, string morningSnack, string lunch, string afternoonSnack, string dinner)
        {
            this.UserName = userName;
            this.MenuDate = menuDate;
            this.Breakfast = breakfast;
            this.MorningSnack = morningSnack;
            this.Lunch = lunch;
            this.AfternoonSnack = afternoonSnack;
            this.Dinner = dinner;
        }

        /// <summary>
        /// Inicializa un menú a partir de los datos del archivo CSV.
        /// </summary>
        /// <param name="menuData">Arreglo con los datos del menú.</param>
        public Menu(string[] menuData)
        {
            this.UserName = menuData[0];
            this.MenuDate = DateTime.ParseExact(menuData[1], "yyyy-MM-dd", CultureInfo.InvariantCulture);
            this.Breakfast = menuData[2];
            this.MorningSnack = menuData[3];
            this.Lunch = menuData[4];
            this.AfternoonSnack = menuData[5];
            this.Dinner = menuData[6];
        }

        /// <summary>
        /// Obtiene o establece el nombre de usuario asociado al menú.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha del menú.
        /// </summary>
        public DateTime MenuDate { get; set; }

        /// <summary>
        /// Obtiene o establece el desayuno.
        /// </summary>
        public string Breakfast { get; set; }

        /// <summary>
        /// Obtiene o establece la merienda de la mañana.
        /// </summary>
        public string MorningSnack { get; set; }

        /// <summary>
        /// Obtiene o establece el almuerzo.
        /// </summary>
        public string Lunch { get; set; }

        /// <summary>
        /// Obtiene o establece la merienda de la tarde.
        /// </summary>
        public string AfternoonSnack { get; set; }

        /// <summary>
        /// Obtiene o establece la cena.
        /// </summary>
        public string Dinner { get; set; }
    }
}