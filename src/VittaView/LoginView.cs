namespace VittaView
{
    using System;
    using System.Windows.Forms;
    using VittaController;
    using VittaController.Abstractions;

    /// <summary>
    /// Vista para el inicio de sesión.
    /// </summary>
    public partial class LoginView : Form
    {
        private LoginController loginController;
        private IFoodController foodController;
        private IMenuController menuController;
        private string userName => this.txtUser.Text;
        private string password => this.txtPassword.Text;

        /// <summary>
        /// Inicializa una nueva instancia de la clase LoginView.
        /// </summary>
        /// <param name="loginController">El controlador de inicio de sesión.</param>
        /// <param name="foodController">El controlador de alimentos.</param>
        /// <param name="menuController">El controlador de menús.</param>
        public LoginView(LoginController loginController, IFoodController foodController, IMenuController menuController)
        {
            this.InitializeComponent();
            this.loginController = loginController;
            this.foodController = foodController;
            this.menuController = menuController;

            this.txtPassword.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = this.btnLogin;
            this.txtUser.Focus();
        }

        /// <summary>
        /// Ejecuta el proceso de inicio de sesión.
        /// </summary>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = this.loginController.Login(this.userName, this.password);

            if (result)
            {
                MessageBox.Show("¡Bienvenido a Vitta! Has iniciado sesión correctamente.");
                this.Hide();

                var principalForm = new DashboardView(this.loginController, this.foodController, this.menuController, this.userName);
                principalForm.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión en Vitta. Por favor, revisa tus credenciales e inténtalo de nuevo.");
            }
        }

        /// <summary>
        /// Abre la vista de registro de usuario.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerView = new RegisterView(this.loginController);
            registerView.ShowDialog();
        }
    }
}