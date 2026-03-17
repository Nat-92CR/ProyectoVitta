namespace VittaView
{
    using VittaController;

    /// <summary>
    /// Vista principal del panel de la aplicación Vitta.
    /// </summary>
    public partial class DashboardView : Form
    {
        private readonly LoginController? loginController;
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
    }
}