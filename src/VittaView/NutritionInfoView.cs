namespace VittaView
{
    using System.Globalization;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Vista encargada de mostrar la información nutricional del usuario.
    /// </summary>
    public partial class NutritionInfoView : Form
    {
        private readonly INutritionInfoController nutritionInfoController;
        private readonly string currentUserName;

        /// <summary>
        /// Inicializa una nueva instancia de la clase NutritionInfoView.
        /// </summary>
        /// <param name="nutritionInfoController">Controlador de información nutricional.</param>
        /// <param name="currentUserName">Nombre del usuario actual.</param>
        public NutritionInfoView(INutritionInfoController nutritionInfoController, string currentUserName)
        {
            this.InitializeComponent();
            this.nutritionInfoController = nutritionInfoController;
            this.currentUserName = currentUserName;
            this.LoadNutritionInformation();
        }

        /// <summary>
        /// Carga la información del usuario y calcula las calorías de mantenimiento.
        /// </summary>
        private void LoadNutritionInformation()
        {
            User user = this.nutritionInfoController.GetUserByUserName(this.currentUserName);

            if (user == null)
            {
                MessageBox.Show("No se pudo cargar la información del usuario.");
                this.Close();
                return;
            }

            this.txtUserName.Text = user.UserName;
            this.txtWeight.Text = user.Weight.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtHeight.Text = user.Height.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtGoal.Text = user.Goal;
            this.txtActivityLevel.Text = user.ActivityLevel;
            this.txtDietType.Text = user.DietType;

            double maintenanceCalories = this.nutritionInfoController.CalculateMaintenanceCalories(user);
            this.txtMaintenanceCalories.Text = maintenanceCalories.ToString("0.##", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Recarga la información nutricional del usuario.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadNutritionInformation();
        }

        /// <summary>
        /// Cierra la vista de información nutricional.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}