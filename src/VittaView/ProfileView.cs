namespace VittaView
{
    using VittaController;
    using VittaModel;

    /// <summary>
    /// Formulario para editar la información del perfil del usuario.
    /// </summary>
    public partial class ProfileView : Form
    {
        private readonly LoginController loginController;
        private readonly string currentUserName;

        /// <summary>
        /// Inicializa una nueva instancia de la vista de perfil.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        /// <param name="currentUserName">Nombre de usuario actual.</param>
        public ProfileView(LoginController loginController, string currentUserName)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.currentUserName = currentUserName;
            this.LoadComboBoxes();
            this.LoadUserData();
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
        }



        
        /// <summary>
        /// Carga los datos actuales del usuario en los controles del formulario.
        /// </summary>
        private void LoadUserData()
        {
            User user = this.loginController.GetUserByUserName(this.currentUserName);

            if (user != null)
            {
                this.txtUserName.Text = user.UserName;
                this.textPassword.Text = user.Password;
                this.textName.Text = user.Name;
                this.txtWeight.Text = user.Weight.ToString();
                this.txtHeight.Text = user.Height.ToString();
                this.cmbGoal.SelectedItem = user.Goal;
                this.cmbActivityLevel.SelectedItem = user.ActivityLevel;
                this.cmbDietType.SelectedItem = user.DietType;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del usuario.");
                this.Close();
            }
        }

        //EVENTOS DE LOS BOTONES CANCELAR Y GUARDAR
        /// <summary>
        /// Cierra la ventana de perfil sin guardar cambios.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ejecuta el guardado de cambios del perfil.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            double weight;
            double height;

            if (string.IsNullOrWhiteSpace(this.textPassword.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña.");
                this.textPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.textName.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                this.textName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                MessageBox.Show("Debe ingresar el peso.");
                this.txtWeight.Focus();
                return;
            }

            if (!double.TryParse(this.txtWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("El peso debe ser un número mayor que 0.");
                this.txtWeight.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHeight.Text))
            {
                MessageBox.Show("Debe ingresar la altura.");
                this.txtHeight.Focus();
                return;
            }

            if (!double.TryParse(this.txtHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("La altura debe ser un número mayor que 0.");
                this.txtHeight.Focus();
                return;
            }

            if (this.cmbGoal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un objetivo.");
                this.cmbGoal.Focus();
                return;
            }

            if (this.cmbActivityLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un nivel de actividad.");
                this.cmbActivityLevel.Focus();
                return;
            }

            if (this.cmbDietType.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de dieta.");
                this.cmbDietType.Focus();
                return;
            }

            var updatedUser = new User(
                this.txtUserName.Text.Trim(),
                this.textPassword.Text.Trim(),
                this.textName.Text.Trim(),
                weight,
                height,
                this.cmbGoal.SelectedItem.ToString(),
                this.cmbActivityLevel.SelectedItem.ToString(),
                this.cmbDietType.SelectedItem.ToString());

            var result = this.loginController.UpdateUser(updatedUser);

            if (result)
            {
                MessageBox.Show("Perfil actualizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el perfil.");
            }
        }
    }
    
}