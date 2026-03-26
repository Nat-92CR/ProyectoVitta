namespace VittaView
{
    partial class LoginView
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
            lblSubtitle = new Label();
            pnlLoginCard = new Panel();
            lblCardTitle = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblFeatures = new Label();
            pnlHeader.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 83);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(27, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(97, 46);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Vitta";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(146, 103);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(616, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Inicia sesión para gestionar alimentos, menús e información nutricional.";
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.White;
            pnlLoginCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginCard.Controls.Add(lblCardTitle);
            pnlLoginCard.Controls.Add(lblUser);
            pnlLoginCard.Controls.Add(txtUser);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(btnRegister);
            pnlLoginCard.Location = new Point(190, 168);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(523, 288);
            pnlLoginCard.TabIndex = 3;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblCardTitle.Location = new Point(171, 22);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(194, 32);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Inicio de Sesión";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(66, 66, 66);
            lblUser.Location = new Point(62, 84);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuario";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(62, 110);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(402, 30);
            txtUser.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(66, 66, 66);
            lblPassword.Location = new Point(62, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(62, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(402, 30);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(62, 213);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(46, 125, 50);
            btnRegister.Location = new Point(274, 213);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(190, 42);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblFeatures
            // 
            lblFeatures.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeatures.ForeColor = Color.FromArgb(66, 66, 66);
            lblFeatures.Location = new Point(187, 474);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Size = new Size(526, 73);
            lblFeatures.TabIndex = 4;
            lblFeatures.Text = "Con Vitta puedes registrar alimentos, crear menús diarios, consultar información nutricional y revisar estadísticas de consumo.";
            lblFeatures.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(900, 620);
            Controls.Add(lblFeatures);
            Controls.Add(pnlLoginCard);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginView";
            Text = "Vitta - Inicio de sesión";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblSubtitle;
        private Panel pnlLoginCard;
        private Label lblCardTitle;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblFeatures;
    }
}