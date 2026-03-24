namespace VittaView
{
    using System;
    using System.Windows.Forms;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Vista encargada del registro de menús dentro del sistema.
    /// </summary>
    public partial class MenuRegisterView : Form
    {
        private readonly IMenuController? menuController;
        private readonly string currentUserName;

        /// <summary>
        /// Inicializa una nueva instancia de la clase MenuRegisterView.
        /// </summary>
        public MenuRegisterView()
        {
            this.InitializeComponent();
            this.currentUserName = string.Empty;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MenuRegisterView"/>.
        /// </summary>
        /// <param name="menuController">Controlador de menús.</param>
        /// <param name="currentUserName">Nombre del usuario actual.</param>
        public MenuRegisterView(IMenuController menuController, string currentUserName)
            : this()
        {
            this.menuController = menuController;
            this.currentUserName = currentUserName;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Guardar menú.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var breakfast = this.txtBreakfast.Text.Trim();
            var morningSnack = this.textMorning.Text.Trim();
            var lunch = this.txtLunch.Text.Trim();
            var afternoonSnack = this.txtAfternoonSnack.Text.Trim();
            var dinner = this.txtDinner.Text.Trim();

            if (this.menuController == null || string.IsNullOrWhiteSpace(this.currentUserName))
            {
                MessageBox.Show("No se pudo asociar el menú al usuario actual.");
                return;
            }

            if (string.IsNullOrWhiteSpace(breakfast) &&
                string.IsNullOrWhiteSpace(morningSnack) &&
                string.IsNullOrWhiteSpace(lunch) &&
                string.IsNullOrWhiteSpace(afternoonSnack) &&
                string.IsNullOrWhiteSpace(dinner))
            {
                MessageBox.Show("Debe registrar al menos un tiempo de comida.");
                return;
            }

            if (this.ContainsComma(breakfast) ||
                this.ContainsComma(morningSnack) ||
                this.ContainsComma(lunch) ||
                this.ContainsComma(afternoonSnack) ||
                this.ContainsComma(dinner))
            {
                MessageBox.Show("No se permiten comas en los tiempos de comida porque el sistema guarda la información en archivo CSV.");
                return;
            }

            var menu = new Menu(
                this.currentUserName,
                this.dtpMenuDate.Value.Date,
                breakfast,
                morningSnack,
                lunch,
                afternoonSnack,
                dinner);

            var result = this.menuController.RegisterMenu(menu);

            if (result)
            {
                MessageBox.Show("El menú se registró correctamente.");
                this.ClearFields();
            }
            else
            {
                MessageBox.Show("No fue posible registrar el menú. Verifique si ya existe un menú para esa fecha o si los datos son inválidos.");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Cancelar.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void ClearFields()
        {
            this.txtBreakfast.Clear();
            this.textMorning.Clear();
            this.txtLunch.Clear();
            this.txtAfternoonSnack.Clear();
            this.txtDinner.Clear();
            this.dtpMenuDate.Value = DateTime.Now;
            this.txtBreakfast.Focus();
        }

        /// <summary>
        /// Verifica si el texto contiene comas.
        /// </summary>
        private bool ContainsComma(string text)
        {
            return !string.IsNullOrEmpty(text) && text.Contains(",");
        }
    }
}