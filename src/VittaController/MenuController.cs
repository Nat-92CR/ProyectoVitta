namespace VittaController
{
    using System;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Implementa las operaciones relacionadas con los menús del sistema.
    /// </summary>
    public class MenuController : IMenuController
    {
        private readonly List<Menu> menus;
        private readonly IDataHandler<Menu> dataHandler;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MenuController"/>.
        /// </summary>
        /// <param name="dataHandler">Manejador de datos de menús.</param>
        public MenuController(IDataHandler<Menu> dataHandler)
        {
            this.dataHandler = dataHandler;
            this.menus = this.dataHandler.LoadData();
        }

        /// <summary>
        /// Registra un nuevo menú en el sistema.
        /// </summary>
        /// <param name="menu">Menú a registrar.</param>
        /// <returns>True si se registra correctamente; de lo contrario, false.</returns>
        public bool RegisterMenu(Menu menu)
        {
            if (menu == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(menu.UserName))
            {
                return false;
            }

            if (menu.MenuDate == DateTime.MinValue)
            {
                return false;
            }

            if (this.AreAllMealTimesEmpty(menu))
            {
                return false;
            }

            if (this.ExistsMenuForUserAndDate(menu.UserName, menu.MenuDate))
            {
                return false;
            }

            this.menus.Add(menu);
            return this.dataHandler.SaveData(this.menus);
        }

        /// <summary>
        /// Obtiene la lista de menús registrados.
        /// </summary>
        /// <returns>Lista de menús.</returns>
        public List<Menu> GetMenus()
        {
            return new List<Menu>(this.menus);
        }

        /// <summary>
        /// Obtiene los menús registrados para un usuario específico.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <returns>Lista de menús del usuario.</returns>
        public List<Menu> GetMenusByUser(string userName)
        {
            var userMenus = new List<Menu>();

            foreach (var menu in this.menus)
            {
                if (menu.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                {
                    userMenus.Add(menu);
                }
            }

            return userMenus;
        }

        /// <summary>
        /// Obtiene un menú específico por usuario y fecha.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="menuDate">Fecha del menú.</param>
        /// <returns>Menú encontrado o null si no existe.</returns>
        public Menu GetMenuByUserAndDate(string userName, DateTime menuDate)
        {
            foreach (var menu in this.menus)
            {
                if (menu.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) &&
                    menu.MenuDate.Date == menuDate.Date)
                {
                    return menu;
                }
            }

            return null;
        }

        /// <summary>
        /// Verifica si ya existe un menú registrado para el mismo usuario y fecha.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="menuDate">Fecha del menú.</param>
        /// <returns>True si ya existe; de lo contrario, false.</returns>
        private bool ExistsMenuForUserAndDate(string userName, DateTime menuDate)
        {
            foreach (var menu in this.menus)
            {
                if (menu.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) &&
                    menu.MenuDate.Date == menuDate.Date)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si todos los tiempos de comida están vacíos.
        /// </summary>
        /// <param name="menu">Menú a validar.</param>
        /// <returns>True si todos los tiempos están vacíos; de lo contrario, false.</returns>
        private bool AreAllMealTimesEmpty(Menu menu)
        {
            return string.IsNullOrWhiteSpace(menu.Breakfast) &&
                   string.IsNullOrWhiteSpace(menu.MorningSnack) &&
                   string.IsNullOrWhiteSpace(menu.Lunch) &&
                   string.IsNullOrWhiteSpace(menu.AfternoonSnack) &&
                   string.IsNullOrWhiteSpace(menu.Dinner);
        }
    }
}