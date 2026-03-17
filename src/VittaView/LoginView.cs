namespace VittaView
{
    using VittaController;

    /// <summary>
    /// Vista para el inicio de sesión.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginView : Form
    {
        private LoginController loginController;
        private string userName => this.txtUser.Text;
        private string password => this.txtPassword.Text;


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="LoginView"/>.
        /// </summary>
        /// <param name="loginController">El controlador de inicio de sesión.</param>
        public LoginView(LoginController loginController)
        {
            this.InitializeComponent();
            this.loginController = loginController;
            this.txtPassword.UseSystemPasswordChar = true; //oculta la contraseña ***
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = this.loginController.Login(this.userName, this.password);

            if (result)
            {
                MessageBox.Show("¡Bienvenido a Vitta! Has iniciado sesión correctamente.");
                this.Hide();

                var principalForm = new DashboardView(this.loginController, userName);
                principalForm.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión en Vitta. Por favor, revisa tus credenciales e inténtalo de nuevo.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerView = new RegisterView(this.loginController);
            registerView.ShowDialog();
        }
    }
}