namespace VittaView
{
    partial class DashboardView
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
            label1 = new Label();
            lblSubtitle = new Label();
            pnlModules = new Panel();
            lblModulesTitle = new Label();
            btnProfile = new Button();
            btnOpenFoodRegister = new Button();
            btnOpenFoodConsult = new Button();
            btnOpenMenuRegister = new Button();
            btnOpenNutritionInfo = new Button();
            btnOpenStatistics = new Button();
            pnlInfo = new Panel();
            lblInfoTitle = new Label();
            lblInfoText = new Label();
            btnLogout = new Button();
            pnlHeader.SuspendLayout();
            pnlModules.SuspendLayout();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 60);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 33, 33);
            label1.Location = new Point(260, 85);
            label1.Name = "label1";
            label1.Size = new Size(577, 54);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a nuestro sistema";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(175, 149);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(792, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Desde aquí puedes acceder a los módulos principales de Vitta para gestionar tu información.";
            // 
            // pnlModules
            // 
            pnlModules.BackColor = Color.White;
            pnlModules.BorderStyle = BorderStyle.FixedSingle;
            pnlModules.Controls.Add(lblModulesTitle);
            pnlModules.Controls.Add(btnProfile);
            pnlModules.Controls.Add(btnOpenFoodRegister);
            pnlModules.Controls.Add(btnOpenFoodConsult);
            pnlModules.Controls.Add(btnOpenMenuRegister);
            pnlModules.Controls.Add(btnOpenNutritionInfo);
            pnlModules.Controls.Add(btnOpenStatistics);
            pnlModules.Location = new Point(95, 205);
            pnlModules.Name = "pnlModules";
            pnlModules.Size = new Size(910, 270);
            pnlModules.TabIndex = 3;
            // 
            // lblModulesTitle
            // 
            lblModulesTitle.AutoSize = true;
            lblModulesTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModulesTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblModulesTitle.Location = new Point(331, 22);
            lblModulesTitle.Name = "lblModulesTitle";
            lblModulesTitle.Size = new Size(250, 32);
            lblModulesTitle.TabIndex = 0;
            lblModulesTitle.Text = "Módulos del sistema";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.White;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.FromArgb(46, 125, 50);
            btnProfile.Location = new Point(56, 84);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(240, 55);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Mi perfil";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnOpenFoodRegister
            // 
            btnOpenFoodRegister.BackColor = Color.White;
            btnOpenFoodRegister.FlatStyle = FlatStyle.Flat;
            btnOpenFoodRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFoodRegister.ForeColor = Color.FromArgb(46, 125, 50);
            btnOpenFoodRegister.Location = new Point(335, 84);
            btnOpenFoodRegister.Name = "btnOpenFoodRegister";
            btnOpenFoodRegister.Size = new Size(240, 55);
            btnOpenFoodRegister.TabIndex = 2;
            btnOpenFoodRegister.Text = "Registrar alimento";
            btnOpenFoodRegister.UseVisualStyleBackColor = false;
            btnOpenFoodRegister.Click += btnOpenFoodRegister_Click;
            // 
            // btnOpenFoodConsult
            // 
            btnOpenFoodConsult.BackColor = Color.White;
            btnOpenFoodConsult.FlatStyle = FlatStyle.Flat;
            btnOpenFoodConsult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFoodConsult.ForeColor = Color.FromArgb(46, 125, 50);
            btnOpenFoodConsult.Location = new Point(614, 84);
            btnOpenFoodConsult.Name = "btnOpenFoodConsult";
            btnOpenFoodConsult.Size = new Size(240, 55);
            btnOpenFoodConsult.TabIndex = 3;
            btnOpenFoodConsult.Text = "Consultar alimentos";
            btnOpenFoodConsult.UseVisualStyleBackColor = false;
            btnOpenFoodConsult.Click += btnOpenFoodConsult_Click;
            // 
            // btnOpenMenuRegister
            // 
            btnOpenMenuRegister.BackColor = Color.White;
            btnOpenMenuRegister.FlatStyle = FlatStyle.Flat;
            btnOpenMenuRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenMenuRegister.ForeColor = Color.FromArgb(46, 125, 50);
            btnOpenMenuRegister.Location = new Point(56, 167);
            btnOpenMenuRegister.Name = "btnOpenMenuRegister";
            btnOpenMenuRegister.Size = new Size(240, 55);
            btnOpenMenuRegister.TabIndex = 4;
            btnOpenMenuRegister.Text = "Registrar menú";
            btnOpenMenuRegister.UseVisualStyleBackColor = false;
            btnOpenMenuRegister.Click += btnOpenMenuRegister_Click;
            // 
            // btnOpenNutritionInfo
            // 
            btnOpenNutritionInfo.BackColor = Color.White;
            btnOpenNutritionInfo.FlatStyle = FlatStyle.Flat;
            btnOpenNutritionInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenNutritionInfo.ForeColor = Color.FromArgb(46, 125, 50);
            btnOpenNutritionInfo.Location = new Point(335, 167);
            btnOpenNutritionInfo.Name = "btnOpenNutritionInfo";
            btnOpenNutritionInfo.Size = new Size(240, 55);
            btnOpenNutritionInfo.TabIndex = 5;
            btnOpenNutritionInfo.Text = "Información nutricional";
            btnOpenNutritionInfo.UseVisualStyleBackColor = false;
            btnOpenNutritionInfo.Click += btnOpenNutritionInfo_Click;
            // 
            // btnOpenStatistics
            // 
            btnOpenStatistics.BackColor = Color.FromArgb(46, 125, 50);
            btnOpenStatistics.FlatStyle = FlatStyle.Flat;
            btnOpenStatistics.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenStatistics.ForeColor = Color.White;
            btnOpenStatistics.Location = new Point(614, 167);
            btnOpenStatistics.Name = "btnOpenStatistics";
            btnOpenStatistics.Size = new Size(240, 55);
            btnOpenStatistics.TabIndex = 6;
            btnOpenStatistics.Text = "Estadísticas nutricionales";
            btnOpenStatistics.UseVisualStyleBackColor = false;
            btnOpenStatistics.Click += btnOpenStatistics_Click;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.White;
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(btnLogout);
            pnlInfo.Controls.Add(lblInfoTitle);
            pnlInfo.Controls.Add(lblInfoText);
            pnlInfo.Location = new Point(95, 503);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(910, 126);
            pnlInfo.TabIndex = 4;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblInfoTitle.Location = new Point(56, 15);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(199, 28);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "¿Qué puedes hacer?";
            // 
            // lblInfoText
            // 
            lblInfoText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoText.ForeColor = Color.FromArgb(66, 66, 66);
            lblInfoText.Location = new Point(56, 55);
            lblInfoText.Name = "lblInfoText";
            lblInfoText.Size = new Size(519, 52);
            lblInfoText.TabIndex = 1;
            lblInfoText.Text = "Puedes consultar tu perfil, registrar alimentos, crear menús, revisar información nutricional y analizar tus estadísticas de consumo de forma más clara y ordenada.";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(46, 125, 50);
            btnLogout.Location = new Point(614, 46);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1100, 670);
            Controls.Add(pnlInfo);
            Controls.Add(pnlModules);
            Controls.Add(lblSubtitle);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardView";
            Text = "Vitta - Panel principal";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlModules.ResumeLayout(false);
            pnlModules.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label label1;
        private Label lblSubtitle;
        private Panel pnlModules;
        private Label lblModulesTitle;
        private Button btnProfile;
        private Button btnOpenFoodRegister;
        private Button btnOpenFoodConsult;
        private Button btnOpenMenuRegister;
        private Button btnOpenNutritionInfo;
        private Button btnOpenStatistics;
        private Panel pnlInfo;
        private Label lblInfoTitle;
        private Label lblInfoText;
        private Button btnLogout;
    }
}