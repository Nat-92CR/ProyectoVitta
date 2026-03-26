using VittaController;
using VittaModel;

namespace VittaView
{
    public partial class RegisterView : Form
    {
        private readonly LoginController loginController;

        /// <summary>
        /// Constructor Añadir comentario 
        /// </summary>
        /// <param name="loginController"></param>

        public RegisterView(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.LoadComboBoxes(); //Llamo el metodo loadComboBoxes
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtUserName.Focus();
        }

        //METODO LOADCOMBOBOXES

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

            this.cmbGoal.SelectedIndex = -1;
            this.cmbActivityLevel.SelectedIndex = -1;
            this.cmbDietType.SelectedIndex = -1;
        }

        //METODO VALIDACIONES
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


        //BOTONES 

        //método del botón Registrar
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
            var goal = this.cmbGoal.SelectedItem.ToString();
            var activityLevel = this.cmbActivityLevel.SelectedItem.ToString();
            var dietType = this.cmbDietType.SelectedItem.ToString();

            var user = new User(userName, password, name, weight, height, goal, activityLevel, dietType);

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

        //método del botón Cancelar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}