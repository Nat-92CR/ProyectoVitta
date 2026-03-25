namespace VittaView
{
    partial class NutritionInfoView
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
            lblTitle = new Label();
            lblUserName = new Label();
            lblWeight = new Label();
            lblHeight = new Label();
            lblGoal = new Label();
            lblActivityLevel = new Label();
            lblDietType = new Label();
            lblMaintenanceCalories = new Label();
            txtUserName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtGoal = new TextBox();
            txtActivityLevel = new TextBox();
            txtDietType = new TextBox();
            txtMaintenanceCalories = new TextBox();
            btnRefresh = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(229, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(342, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Información nutricional";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(131, 109);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(56, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(131, 149);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(41, 20);
            lblWeight.TabIndex = 2;
            lblWeight.Text = "Peso";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(131, 189);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(48, 20);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Altura";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(131, 229);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(62, 20);
            lblGoal.TabIndex = 4;
            lblGoal.Text = "Objetivo";
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Location = new Point(131, 269);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(121, 20);
            lblActivityLevel.TabIndex = 5;
            lblActivityLevel.Text = "Nivel de actividad";
            // 
            // lblDietType
            // 
            lblDietType.AutoSize = true;
            lblDietType.Location = new Point(131, 309);
            lblDietType.Name = "lblDietType";
            lblDietType.Size = new Size(92, 20);
            lblDietType.TabIndex = 6;
            lblDietType.Text = "Tipo de dieta";
            // 
            // lblMaintenanceCalories
            // 
            lblMaintenanceCalories.AutoSize = true;
            lblMaintenanceCalories.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMaintenanceCalories.Location = new Point(131, 369);
            lblMaintenanceCalories.Name = "lblMaintenanceCalories";
            lblMaintenanceCalories.Size = new Size(237, 25);
            lblMaintenanceCalories.TabIndex = 7;
            lblMaintenanceCalories.Text = "Calorías de mantenimiento";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(390, 106);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(248, 27);
            txtUserName.TabIndex = 8;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(390, 146);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(248, 27);
            txtWeight.TabIndex = 9;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(390, 186);
            txtHeight.Name = "txtHeight";
            txtHeight.ReadOnly = true;
            txtHeight.Size = new Size(248, 27);
            txtHeight.TabIndex = 10;
            // 
            // txtGoal
            // 
            txtGoal.Location = new Point(390, 226);
            txtGoal.Name = "txtGoal";
            txtGoal.ReadOnly = true;
            txtGoal.Size = new Size(248, 27);
            txtGoal.TabIndex = 11;
            // 
            // txtActivityLevel
            // 
            txtActivityLevel.Location = new Point(390, 266);
            txtActivityLevel.Name = "txtActivityLevel";
            txtActivityLevel.ReadOnly = true;
            txtActivityLevel.Size = new Size(248, 27);
            txtActivityLevel.TabIndex = 12;
            // 
            // txtDietType
            // 
            txtDietType.Location = new Point(390, 306);
            txtDietType.Name = "txtDietType";
            txtDietType.ReadOnly = true;
            txtDietType.Size = new Size(248, 27);
            txtDietType.TabIndex = 13;
            // 
            // txtMaintenanceCalories
            // 
            txtMaintenanceCalories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMaintenanceCalories.Location = new Point(390, 363);
            txtMaintenanceCalories.Name = "txtMaintenanceCalories";
            txtMaintenanceCalories.ReadOnly = true;
            txtMaintenanceCalories.Size = new Size(248, 34);
            txtMaintenanceCalories.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(247, 435);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 43);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Actualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(418, 435);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 43);
            btnClose.TabIndex = 16;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // NutritionInfoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(txtMaintenanceCalories);
            Controls.Add(txtDietType);
            Controls.Add(txtActivityLevel);
            Controls.Add(txtGoal);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(txtUserName);
            Controls.Add(lblMaintenanceCalories);
            Controls.Add(lblDietType);
            Controls.Add(lblActivityLevel);
            Controls.Add(lblGoal);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblUserName);
            Controls.Add(lblTitle);
            Name = "NutritionInfoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutritionInfoView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUserName;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblGoal;
        private Label lblActivityLevel;
        private Label lblDietType;
        private Label lblMaintenanceCalories;
        private TextBox txtUserName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtGoal;
        private TextBox txtActivityLevel;
        private TextBox txtDietType;
        private TextBox txtMaintenanceCalories;
        private Button btnRefresh;
        private Button btnClose;
    }
}