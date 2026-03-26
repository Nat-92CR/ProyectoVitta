namespace VittaView
{
    partial class ProfileView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            lblName = new Label();
            lblWeight = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblSex = new Label();
            lblGoal = new Label();
            lblActivityLevel = new Label();
            lblDietType = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtUserName = new TextBox();
            textPassword = new TextBox();
            textName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            cmbSex = new ComboBox();
            cmbGoal = new ComboBox();
            cmbActivityLevel = new ComboBox();
            cmbDietType = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(332, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(135, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Editar perfil";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(88, 95);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(53, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(88, 131);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(88, 167);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nombre:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(88, 203);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(35, 15);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Peso:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(88, 239);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 5;
            lblHeight.Text = "Altura:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(88, 275);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 15);
            lblAge.TabIndex = 6;
            lblAge.Text = "Edad:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(88, 311);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(34, 15);
            lblSex.TabIndex = 7;
            lblSex.Text = "Sexo:";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(88, 347);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(55, 15);
            lblGoal.TabIndex = 8;
            lblGoal.Text = "Objetivo:";
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Location = new Point(88, 383);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(98, 15);
            lblActivityLevel.TabIndex = 9;
            lblActivityLevel.Text = "Nivel de actividad:";
            // 
            // lblDietType
            // 
            lblDietType.AutoSize = true;
            lblDietType.Location = new Point(88, 419);
            lblDietType.Name = "lblDietType";
            lblDietType.Size = new Size(79, 15);
            lblDietType.TabIndex = 10;
            lblDietType.Text = "Tipo de dieta:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(225, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 42);
            btnSave.TabIndex = 21;
            btnSave.Text = "Guardar cambios";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 469);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 42);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(225, 92);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(344, 23);
            txtUserName.TabIndex = 11;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(225, 128);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(344, 23);
            textPassword.TabIndex = 12;
            textPassword.UseSystemPasswordChar = true;
            // 
            // textName
            // 
            textName.Location = new Point(225, 164);
            textName.Name = "textName";
            textName.Size = new Size(344, 23);
            textName.TabIndex = 13;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(225, 200);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(344, 23);
            txtWeight.TabIndex = 14;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(225, 236);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(344, 23);
            txtHeight.TabIndex = 15;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(225, 272);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(344, 23);
            txtAge.TabIndex = 16;
            // 
            // cmbSex
            // 
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(225, 308);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(344, 23);
            cmbSex.TabIndex = 17;
            // 
            // cmbGoal
            // 
            cmbGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoal.FormattingEnabled = true;
            cmbGoal.Location = new Point(225, 344);
            cmbGoal.Name = "cmbGoal";
            cmbGoal.Size = new Size(344, 23);
            cmbGoal.TabIndex = 18;
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(225, 380);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(344, 23);
            cmbActivityLevel.TabIndex = 19;
            // 
            // cmbDietType
            // 
            cmbDietType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDietType.FormattingEnabled = true;
            cmbDietType.Location = new Point(225, 416);
            cmbDietType.Name = "cmbDietType";
            cmbDietType.Size = new Size(344, 23);
            cmbDietType.TabIndex = 20;
            // 
            // ProfileView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(cmbDietType);
            Controls.Add(cmbActivityLevel);
            Controls.Add(cmbGoal);
            Controls.Add(cmbSex);
            Controls.Add(txtAge);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(textName);
            Controls.Add(textPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblDietType);
            Controls.Add(lblActivityLevel);
            Controls.Add(lblGoal);
            Controls.Add(lblSex);
            Controls.Add(lblAge);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblTitle);
            Name = "ProfileView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblName;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblAge;
        private Label lblSex;
        private Label lblGoal;
        private Label lblActivityLevel;
        private Label lblDietType;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtUserName;
        private TextBox textPassword;
        private TextBox textName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtAge;
        private ComboBox cmbSex;
        private ComboBox cmbGoal;
        private ComboBox cmbActivityLevel;
        private ComboBox cmbDietType;
    }
}
