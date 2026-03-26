using VittaController;
using VittaModel;

namespace VittaView
{
    public partial class RegisterView : Form
    {
        private readonly LoginController loginController;

        /// <summary>
        /// Inicializa una nueva instancia del formulario de registro.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        public RegisterView(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.LoadComboBoxes();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = this.btnRegister;
            this.txtUserName.Focus();
        }

        /// <summary>
        /// Carga las opciones de los ComboBox.
        /// </summary>
        private void LoadComboBoxes()
        {
            this.cmbGoal.Items.Add("Mantener");
            this.cmbGoal.Items.Add("Perder grasa");
            this.cmbGoal.Items.Add("Ganar masa");

            this.cmbActivityLevel.Items.Add("Sedentario");
            this.cmbActivityLevel.Items.Add("Ligero");
            this.cmbActivityLevel.Items.Add("Moderado");
            this.cmbActivityLevel.Items.Add("Alto");

            this.cmbDietType.Items.Add("Estándar");
            this.cmbDietType.Items.Add("Keto");
            this.cmbDietType.Items.Add("Vegetariana");

            this.cmbSex.Items.Add("Femenino");
            this.cmbSex.Items.Add("Masculino");
            this.cmbSex.Items.Add("No especificado");

            this.cmbGoal.SelectedIndex = -1;
            this.cmbActivityLevel.SelectedIndex = -1;
            this.cmbDietType.SelectedIndex = -1;
            this.cmbSex.SelectedIndex = -1;
        }

        /// <summary>
        /// Valida los campos del formulario.
        /// </summary>
        /// <returns>True si todos los datos son válidos.</returns>
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(this.txtUserName.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario.");
                this.txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña.");
                this.txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                this.txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                MessageBox.Show("Debe ingresar el peso.");
                this.txtWeight.Focus();
                return false;
            }

            if (!double.TryParse(this.txtWeight.Text.Trim(), out double weight) || weight <= 0)
            {
                MessageBox.Show("El peso debe ser un número mayor que 0.");
                this.txtWeight.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtHeight.Text))
            {
                MessageBox.Show("Debe ingresar la altura.");
                this.txtHeight.Focus();
                return false;
            }

            if (!double.TryParse(this.txtHeight.Text.Trim(), out double height) || height <= 0)
            {
                MessageBox.Show("La altura debe ser un número mayor que 0.");
                this.txtHeight.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtAge.Text))
            {
                MessageBox.Show("Debe ingresar la edad.");
                this.txtAge.Focus();
                return false;
            }

            if (!int.TryParse(this.txtAge.Text.Trim(), out int age) || age <= 0)
            {
                MessageBox.Show("La edad debe ser un número entero mayor que 0.");
                this.txtAge.Focus();
                return false;
            }

            if (this.cmbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el sexo.");
                this.cmbSex.Focus();
                return false;
            }

            if (this.cmbGoal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un objetivo.");
                this.cmbGoal.Focus();
                return false;
            }

            if (this.cmbActivityLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un nivel de actividad.");
                this.cmbActivityLevel.Focus();
                return false;
            }

            if (this.cmbDietType.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de dieta.");
                this.cmbDietType.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Registra un nuevo usuario.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFields())
            {
                return;
            }

            var userName = this.txtUserName.Text.Trim();
            var password = this.txtPassword.Text.Trim();
            var name = this.txtName.Text.Trim();
            var weight = double.Parse(this.txtWeight.Text.Trim());
            var height = double.Parse(this.txtHeight.Text.Trim());
            var age = int.Parse(this.txtAge.Text.Trim());
            var sex = this.cmbSex.SelectedItem.ToString();
            var goal = this.cmbGoal.SelectedItem.ToString();
            var activityLevel = this.cmbActivityLevel.SelectedItem.ToString();
            var dietType = this.cmbDietType.SelectedItem.ToString();

            var user = new User(userName, password, name, weight, height, goal, activityLevel, dietType, age, sex);

            var result = this.loginController.Register(user);

            if (result)
            {
                MessageBox.Show("Usuario registrado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario. Verifique si el nombre de usuario ya existe.");
            }
        }

        /// <summary>
        /// Cierra la ventana de registro.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
