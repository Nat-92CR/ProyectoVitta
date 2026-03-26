namespace VittaView
{
    partial class RegisterView
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para la compatibilidad con el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblMainTitle = new Label();
            lblSubtitle = new Label();
            pnlRegisterCard = new Panel();
            lblCardTitle = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblSex = new Label();
            cmbSex = new ComboBox();
            lblGoal = new Label();
            cmbGoal = new ComboBox();
            lblActivityLevel = new Label();
            cmbActivityLevel = new ComboBox();
            lblDietType = new Label();
            cmbDietType = new ComboBox();
            btnRegister = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlRegisterCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(983, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(32, 10);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(87, 41);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Vitta";
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblMainTitle.Location = new Point(284, 83);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(393, 54);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Registro de Usuario";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(149, 148);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(706, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Crea tu cuenta para registrar alimentos, menús y consultar tu progreso nutricional.";
            // 
            // pnlRegisterCard
            // 
            pnlRegisterCard.BackColor = Color.White;
            pnlRegisterCard.BorderStyle = BorderStyle.FixedSingle;
            pnlRegisterCard.Controls.Add(lblCardTitle);
            pnlRegisterCard.Controls.Add(lblUserName);
            pnlRegisterCard.Controls.Add(txtUserName);
            pnlRegisterCard.Controls.Add(lblPassword);
            pnlRegisterCard.Controls.Add(txtPassword);
            pnlRegisterCard.Controls.Add(lblName);
            pnlRegisterCard.Controls.Add(txtName);
            pnlRegisterCard.Controls.Add(lblWeight);
            pnlRegisterCard.Controls.Add(txtWeight);
            pnlRegisterCard.Controls.Add(lblHeight);
            pnlRegisterCard.Controls.Add(txtHeight);
            pnlRegisterCard.Controls.Add(lblAge);
            pnlRegisterCard.Controls.Add(txtAge);
            pnlRegisterCard.Controls.Add(lblSex);
            pnlRegisterCard.Controls.Add(cmbSex);
            pnlRegisterCard.Controls.Add(lblGoal);
            pnlRegisterCard.Controls.Add(cmbGoal);
            pnlRegisterCard.Controls.Add(lblActivityLevel);
            pnlRegisterCard.Controls.Add(cmbActivityLevel);
            pnlRegisterCard.Controls.Add(lblDietType);
            pnlRegisterCard.Controls.Add(cmbDietType);
            pnlRegisterCard.Controls.Add(btnRegister);
            pnlRegisterCard.Controls.Add(btnCancel);
            pnlRegisterCard.Location = new Point(89, 196);
            pnlRegisterCard.Name = "pnlRegisterCard";
            pnlRegisterCard.Size = new Size(800, 528);
            pnlRegisterCard.TabIndex = 3;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblCardTitle.Location = new Point(290, 20);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(215, 32);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Datos del usuario";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(66, 66, 66);
            lblUserName.Location = new Point(48, 82);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(48, 108);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(300, 30);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(66, 66, 66);
            lblPassword.Location = new Point(450, 82);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(450, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 30);
            txtPassword.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(66, 66, 66);
            lblName.Location = new Point(48, 157);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 5;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(48, 183);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 30);
            txtName.TabIndex = 6;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.ForeColor = Color.FromArgb(66, 66, 66);
            lblWeight.Location = new Point(450, 157);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 23);
            lblWeight.TabIndex = 7;
            lblWeight.Text = "Peso";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWeight.Location = new Point(450, 183);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(300, 30);
            txtWeight.TabIndex = 8;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeight.ForeColor = Color.FromArgb(66, 66, 66);
            lblHeight.Location = new Point(48, 232);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(60, 23);
            lblHeight.TabIndex = 9;
            lblHeight.Text = "Altura";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(48, 258);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(300, 30);
            txtHeight.TabIndex = 10;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.FromArgb(66, 66, 66);
            lblAge.Location = new Point(450, 232);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(50, 23);
            lblAge.TabIndex = 11;
            lblAge.Text = "Edad";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(450, 258);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(300, 30);
            txtAge.TabIndex = 12;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.ForeColor = Color.FromArgb(66, 66, 66);
            lblSex.Location = new Point(48, 307);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(48, 23);
            lblSex.TabIndex = 13;
            lblSex.Text = "Sexo";
            // 
            // cmbSex
            // 
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(48, 333);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(300, 31);
            cmbSex.TabIndex = 14;
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblGoal.Location = new Point(450, 307);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(79, 23);
            lblGoal.TabIndex = 15;
            lblGoal.Text = "Objetivo";
            // 
            // cmbGoal
            // 
            cmbGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGoal.FormattingEnabled = true;
            cmbGoal.Location = new Point(450, 333);
            cmbGoal.Name = "cmbGoal";
            cmbGoal.Size = new Size(300, 31);
            cmbGoal.TabIndex = 16;
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActivityLevel.ForeColor = Color.FromArgb(66, 66, 66);
            lblActivityLevel.Location = new Point(48, 382);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(155, 23);
            lblActivityLevel.TabIndex = 17;
            lblActivityLevel.Text = "Nivel de actividad";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivityLevel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(48, 408);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(300, 31);
            cmbActivityLevel.TabIndex = 18;
            // 
            // lblDietType
            // 
            lblDietType.AutoSize = true;
            lblDietType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDietType.ForeColor = Color.FromArgb(66, 66, 66);
            lblDietType.Location = new Point(450, 382);
            lblDietType.Name = "lblDietType";
            lblDietType.Size = new Size(117, 23);
            lblDietType.TabIndex = 19;
            lblDietType.Text = "Tipo de dieta";
            // 
            // cmbDietType
            // 
            cmbDietType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDietType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDietType.FormattingEnabled = true;
            cmbDietType.Location = new Point(450, 408);
            cmbDietType.Name = "cmbDietType";
            cmbDietType.Size = new Size(300, 31);
            cmbDietType.TabIndex = 20;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(46, 125, 50);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(236, 460);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 42);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(46, 125, 50);
            btnCancel.Location = new Point(412, 460);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 42);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(983, 754);
            Controls.Add(pnlRegisterCard);
            Controls.Add(lblSubtitle);
            Controls.Add(lblMainTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterView";
            Text = "Vitta - Registro de usuario";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRegisterCard.ResumeLayout(false);
            pnlRegisterCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblMainTitle;
        private Label lblSubtitle;
        private Panel pnlRegisterCard;
        private Label lblCardTitle;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblName;
        private TextBox txtName;
        private Label lblWeight;
        private TextBox txtWeight;
        private Label lblHeight;
        private TextBox txtHeight;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblSex;
        private ComboBox cmbSex;
        private Label lblGoal;
        private ComboBox cmbGoal;
        private Label lblActivityLevel;
        private ComboBox cmbActivityLevel;
        private Label lblDietType;
        private ComboBox cmbDietType;
        private Button btnRegister;
        private Button btnCancel;
    }
}