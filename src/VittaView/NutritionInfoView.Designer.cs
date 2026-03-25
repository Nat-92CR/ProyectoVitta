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
            lblBodyMassIndex = new Label();
            lblBodyMassIndexCategory = new Label();
            lblProteinGrams = new Label();
            lblCarbohydratesGrams = new Label();
            lblFatGrams = new Label();
            txtUserName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtGoal = new TextBox();
            txtActivityLevel = new TextBox();
            txtDietType = new TextBox();
            txtMaintenanceCalories = new TextBox();
            txtBodyMassIndex = new TextBox();
            txtBodyMassIndexCategory = new TextBox();
            txtProteinGrams = new TextBox();
            txtCarbohydratesGrams = new TextBox();
            txtFatGrams = new TextBox();
            btnRefresh = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(198, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(342, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Información nutricional";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(74, 92);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(56, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(74, 132);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(41, 20);
            lblWeight.TabIndex = 2;
            lblWeight.Text = "Peso";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(74, 172);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(48, 20);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Altura";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Location = new Point(74, 212);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(62, 20);
            lblGoal.TabIndex = 4;
            lblGoal.Text = "Objetivo";
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Location = new Point(74, 252);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(121, 20);
            lblActivityLevel.TabIndex = 5;
            lblActivityLevel.Text = "Nivel de actividad";
            // 
            // lblDietType
            // 
            lblDietType.AutoSize = true;
            lblDietType.Location = new Point(74, 292);
            lblDietType.Name = "lblDietType";
            lblDietType.Size = new Size(92, 20);
            lblDietType.TabIndex = 6;
            lblDietType.Text = "Tipo de dieta";
            // 
            // lblMaintenanceCalories
            // 
            lblMaintenanceCalories.AutoSize = true;
            lblMaintenanceCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaintenanceCalories.Location = new Point(74, 342);
            lblMaintenanceCalories.Name = "lblMaintenanceCalories";
            lblMaintenanceCalories.Size = new Size(223, 23);
            lblMaintenanceCalories.TabIndex = 7;
            lblMaintenanceCalories.Text = "Calorías de mantenimiento";
            // 
            // lblBodyMassIndex
            // 
            lblBodyMassIndex.AutoSize = true;
            lblBodyMassIndex.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBodyMassIndex.Location = new Point(74, 382);
            lblBodyMassIndex.Name = "lblBodyMassIndex";
            lblBodyMassIndex.Size = new Size(44, 23);
            lblBodyMassIndex.TabIndex = 8;
            lblBodyMassIndex.Text = "IMC";
            // 
            // lblBodyMassIndexCategory
            // 
            lblBodyMassIndexCategory.AutoSize = true;
            lblBodyMassIndexCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBodyMassIndexCategory.Location = new Point(74, 422);
            lblBodyMassIndexCategory.Name = "lblBodyMassIndexCategory";
            lblBodyMassIndexCategory.Size = new Size(135, 23);
            lblBodyMassIndexCategory.TabIndex = 9;
            lblBodyMassIndexCategory.Text = "Clasificación IMC";
            // 
            // lblProteinGrams
            // 
            lblProteinGrams.AutoSize = true;
            lblProteinGrams.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProteinGrams.Location = new Point(74, 462);
            lblProteinGrams.Name = "lblProteinGrams";
            lblProteinGrams.Size = new Size(182, 23);
            lblProteinGrams.TabIndex = 10;
            lblProteinGrams.Text = "Proteínas sugeridas (g)";
            // 
            // lblCarbohydratesGrams
            // 
            lblCarbohydratesGrams.AutoSize = true;
            lblCarbohydratesGrams.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCarbohydratesGrams.Location = new Point(74, 502);
            lblCarbohydratesGrams.Name = "lblCarbohydratesGrams";
            lblCarbohydratesGrams.Size = new Size(232, 23);
            lblCarbohydratesGrams.TabIndex = 11;
            lblCarbohydratesGrams.Text = "Carbohidratos sugeridos (g)";
            // 
            // lblFatGrams
            // 
            lblFatGrams.AutoSize = true;
            lblFatGrams.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFatGrams.Location = new Point(74, 542);
            lblFatGrams.Name = "lblFatGrams";
            lblFatGrams.Size = new Size(153, 23);
            lblFatGrams.TabIndex = 12;
            lblFatGrams.Text = "Grasas sugeridas (g)";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(366, 89);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(255, 27);
            txtUserName.TabIndex = 13;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(366, 129);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(255, 27);
            txtWeight.TabIndex = 14;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(366, 169);
            txtHeight.Name = "txtHeight";
            txtHeight.ReadOnly = true;
            txtHeight.Size = new Size(255, 27);
            txtHeight.TabIndex = 15;
            // 
            // txtGoal
            // 
            txtGoal.Location = new Point(366, 209);
            txtGoal.Name = "txtGoal";
            txtGoal.ReadOnly = true;
            txtGoal.Size = new Size(255, 27);
            txtGoal.TabIndex = 16;
            // 
            // txtActivityLevel
            // 
            txtActivityLevel.Location = new Point(366, 249);
            txtActivityLevel.Name = "txtActivityLevel";
            txtActivityLevel.ReadOnly = true;
            txtActivityLevel.Size = new Size(255, 27);
            txtActivityLevel.TabIndex = 17;
            // 
            // txtDietType
            // 
            txtDietType.Location = new Point(366, 289);
            txtDietType.Name = "txtDietType";
            txtDietType.ReadOnly = true;
            txtDietType.Size = new Size(255, 27);
            txtDietType.TabIndex = 18;
            // 
            // txtMaintenanceCalories
            // 
            txtMaintenanceCalories.Location = new Point(366, 339);
            txtMaintenanceCalories.Name = "txtMaintenanceCalories";
            txtMaintenanceCalories.ReadOnly = true;
            txtMaintenanceCalories.Size = new Size(255, 27);
            txtMaintenanceCalories.TabIndex = 19;
            // 
            // txtBodyMassIndex
            // 
            txtBodyMassIndex.Location = new Point(366, 379);
            txtBodyMassIndex.Name = "txtBodyMassIndex";
            txtBodyMassIndex.ReadOnly = true;
            txtBodyMassIndex.Size = new Size(255, 27);
            txtBodyMassIndex.TabIndex = 20;
            // 
            // txtBodyMassIndexCategory
            // 
            txtBodyMassIndexCategory.Location = new Point(366, 419);
            txtBodyMassIndexCategory.Name = "txtBodyMassIndexCategory";
            txtBodyMassIndexCategory.ReadOnly = true;
            txtBodyMassIndexCategory.Size = new Size(255, 27);
            txtBodyMassIndexCategory.TabIndex = 21;
            // 
            // txtProteinGrams
            // 
            txtProteinGrams.Location = new Point(366, 459);
            txtProteinGrams.Name = "txtProteinGrams";
            txtProteinGrams.ReadOnly = true;
            txtProteinGrams.Size = new Size(255, 27);
            txtProteinGrams.TabIndex = 22;
            // 
            // txtCarbohydratesGrams
            // 
            txtCarbohydratesGrams.Location = new Point(366, 499);
            txtCarbohydratesGrams.Name = "txtCarbohydratesGrams";
            txtCarbohydratesGrams.ReadOnly = true;
            txtCarbohydratesGrams.Size = new Size(255, 27);
            txtCarbohydratesGrams.TabIndex = 23;
            // 
            // txtFatGrams
            // 
            txtFatGrams.Location = new Point(366, 539);
            txtFatGrams.Name = "txtFatGrams";
            txtFatGrams.ReadOnly = true;
            txtFatGrams.Size = new Size(255, 27);
            txtFatGrams.TabIndex = 24;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(195, 596);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(149, 42);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Actualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(381, 596);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 42);
            btnClose.TabIndex = 26;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // NutritionInfoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 668);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(txtFatGrams);
            Controls.Add(txtCarbohydratesGrams);
            Controls.Add(txtProteinGrams);
            Controls.Add(txtBodyMassIndexCategory);
            Controls.Add(txtBodyMassIndex);
            Controls.Add(txtMaintenanceCalories);
            Controls.Add(txtDietType);
            Controls.Add(txtActivityLevel);
            Controls.Add(txtGoal);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(txtUserName);
            Controls.Add(lblFatGrams);
            Controls.Add(lblCarbohydratesGrams);
            Controls.Add(lblProteinGrams);
            Controls.Add(lblBodyMassIndexCategory);
            Controls.Add(lblBodyMassIndex);
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
            Text = "Información nutricional";
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
        private Label lblBodyMassIndex;
        private Label lblBodyMassIndexCategory;
        private Label lblProteinGrams;
        private Label lblCarbohydratesGrams;
        private Label lblFatGrams;
        private TextBox txtUserName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtGoal;
        private TextBox txtActivityLevel;
        private TextBox txtDietType;
        private TextBox txtMaintenanceCalories;
        private TextBox txtBodyMassIndex;
        private TextBox txtBodyMassIndexCategory;
        private TextBox txtProteinGrams;
        private TextBox txtCarbohydratesGrams;
        private TextBox txtFatGrams;
        private Button btnRefresh;
        private Button btnClose;
    }
}