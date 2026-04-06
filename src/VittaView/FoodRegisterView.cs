namespace VittaView
{
    using System.Globalization;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Vista encargada del registro de alimentos dentro del sistema.
    /// </summary>
    public partial class FoodRegisterView : Form
    {
        private readonly IFoodController foodController;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FoodRegisterView"/>.
        /// </summary>
        /// <param name="foodController">Controlador de alimentos.</param>
        public FoodRegisterView(IFoodController foodController)
        {
            this.InitializeComponent();
            this.foodController = foodController;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = this.btnSave;
            this.txtName.Focus();
        }

        /// <summary>
        /// Obtiene el nombre del alimento ingresado en la vista.
        /// </summary>
        private string FoodName => this.txtName.Text.Trim();

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Guardar.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.FoodName))
            {
                MessageBox.Show("Debe ingresar el nombre del alimento.");
                this.txtName.Focus();
                return;
            }

            if (!double.TryParse(this.txtCalories.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double calories) ||
                !double.TryParse(this.txtProtein.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double protein) ||
                !double.TryParse(this.txtCarbohydrates.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double carbohydrates) ||
                !double.TryParse(this.txtFat.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double fat))
            {
                MessageBox.Show("Las calorías, proteínas, carbohidratos y grasas deben ser valores numéricos válidos.");
                return;
            }

            if (calories < 0 || protein < 0 || carbohydrates < 0 || fat < 0)
            {
                MessageBox.Show("Los valores nutricionales no pueden ser negativos.");
                return;
            }

            var food = new Food(this.FoodName, calories, protein, carbohydrates, fat);
            var result = this.foodController.RegisterFood(food);

            if (result)
            {
                MessageBox.Show("El alimento se registró correctamente.");
                this.ClearFields();
            }
            else
            {
                MessageBox.Show("No fue posible registrar el alimento. Verifique si ya existe o si los datos son inválidos.");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Cancelar.
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void ClearFields()
        {
            this.txtName.Clear();
            this.txtCalories.Clear();
            this.txtProtein.Clear();
            this.txtCarbohydrates.Clear();
            this.txtFat.Clear();
            this.txtName.Focus();
        }
    }
}