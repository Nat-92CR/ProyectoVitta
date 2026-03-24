namespace VittaController.Abstractions
{
    using System;
    using System.Collections.Generic;
    using VittaModel;

    /// <summary>
    /// Interfaz que define el contrato de las operaciones principales
    /// relacionadas con los menús del sistema.
    /// </summary>
    public interface IMenuController
    {
        /// <summary>
        /// Registra un nuevo menú en el sistema.
        /// </summary>
        /// <param name="menu">Menú a registrar.</param>
        /// <returns>True si el registro se realiza correctamente; de lo contrario, false.</returns>
        bool RegisterMenu(Menu menu);

        /// <summary>
        /// Obtiene la lista de menús registrados.
        /// </summary>
        /// <returns>Lista de menús.</returns>
        List<Menu> GetMenus();

        /// <summary>
        /// Obtiene los menús registrados para un usuario específico.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <returns>Lista de menús del usuario.</returns>
        List<Menu> GetMenusByUser(string userName);

        /// <summary>
        /// Obtiene un menú específico por usuario y fecha.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="menuDate">Fecha del menú.</param>
        /// <returns>Menú encontrado o null si no existe.</returns>
        Menu GetMenuByUserAndDate(string userName, DateTime menuDate);

        /// <summary>
        /// Actualiza un menú existente del usuario.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="originalMenuDate">Fecha original del menú a modificar.</param>
        /// <param name="updatedMenu">Menú actualizado.</param>
        /// <returns>True si se actualiza correctamente; de lo contrario, false.</returns>
        bool UpdateMenu(string userName, DateTime originalMenuDate, Menu updatedMenu);

        /// <summary>
        /// Elimina un menú existente del usuario.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="menuDate">Fecha del menú a eliminar.</param>
        /// <returns>True si se elimina correctamente; de lo contrario, false.</returns>
        bool DeleteMenu(string userName, DateTime menuDate);
    }
}