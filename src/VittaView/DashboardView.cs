namespace VittaView
{
    using System;
    using System.Windows.Forms;
    using VittaController;
    using VittaController.Abstractions;

    /// <summary>
    /// Vista principal del panel de la aplicación Vitta.
    /// </summary>
    public partial class DashboardView : Form
    {
        private readonly LoginController? loginController;
        private readonly IFoodController? foodController;
        private readonly IMenuController? menuController;
        private readonly string currentUserName;

        /// <summary>
        /// Inicializa una nueva instancia de la clase DashboardView.
        /// </summary>
        public DashboardView()
        {
            InitializeComponent();
            this.currentUserName = string.Empty;
        }

        /// <summary>
        /// Inicializa una nueva instancia del dashboard con el usuario actual.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        /// <param name="currentUserName">Nombre de usuario actual.</param>
        public DashboardView(LoginController loginController, string currentUserName)
            : this()
        {
            this.loginController = loginController;
            this.currentUserName = currentUserName;
        }

        /// <summary>
        /// Inicializa una nueva instancia del dashboard con el usuario actual
        /// y el controlador del módulo de alimentos.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        /// <param name="foodController">Controlador de alimentos.</param>
        /// <param name="currentUserName">Nombre de usuario actual.</param>
        public DashboardView(LoginController loginController, IFoodController foodController, string currentUserName)
            : this(loginController, currentUserName)
        {
            this.foodController = foodController;
        }

        /// <summary>
        /// Inicializa una nueva instancia del dashboard con el usuario actual,
        /// el controlador del módulo de alimentos y el controlador del módulo de menús.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        /// <param name="foodController">Controlador de alimentos.</param>
        /// <param name="menuController">Controlador de menús.</param>
        /// <param name="currentUserName">Nombre de usuario actual.</param>
        public DashboardView(LoginController loginController, IFoodController foodController, IMenuController menuController, string currentUserName)
            : this(loginController, foodController, currentUserName)
        {
            this.menuController = menuController;
        }

        /// <summary>
        /// Abre la vista de perfil del usuario actual.
        /// </summary>
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (this.loginController != null && !string.IsNullOrEmpty(this.currentUserName))
            {
                var profileView = new ProfileView(this.loginController, this.currentUserName);
                profileView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo abrir el perfil del usuario.");
            }
        }

        /// <summary>
        /// Abre la vista de registro de alimentos.
        /// </summary>
        private void btnOpenFoodRegister_Click(object sender, EventArgs e)
        {
            if (this.foodController != null)
            {
                var foodRegisterView = new FoodRegisterView(this.foodController);
                foodRegisterView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo abrir el módulo de alimentos.");
            }
        }

        /// <summary>
        /// Abre la vista de consulta de alimentos.
        /// </summary>
        private void btnOpenFoodConsult_Click(object sender, EventArgs e)
        {
            if (this.foodController != null)
            {
                var foodConsultView = new FoodConsultView(this.foodController);
                foodConsultView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo abrir la consulta de alimentos.");
            }
        }

        /// <summary>
        /// Abre la vista de registro de menús.
        /// </summary>
        private void btnOpenMenuRegister_Click(object sender, EventArgs e)
        {
            if (this.menuController != null && this.foodController != null && !string.IsNullOrWhiteSpace(this.currentUserName))
            {
                var menuRegisterView = new MenuRegisterView(this.menuController, this.foodController, this.currentUserName);
                menuRegisterView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo abrir el módulo de menús.");
            }
        }

        /// <summary>
        /// Abre la vista de información nutricional.
        /// </summary>
        private void btnOpenNutritionInfo_Click(object sender, EventArgs e)
        {
            if (this.loginController != null && !string.IsNullOrWhiteSpace(this.currentUserName))
            {
                INutritionInfoController nutritionInfoController = new NutritionInfoController(this.loginController);
                var nutritionInfoView = new NutritionInfoView(nutritionInfoController, this.currentUserName);
                nutritionInfoView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo abrir el módulo de información nutricional.");
            }
        }
    }
}