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
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlUserData = new Panel();
            lblUserDataTitle = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblGoal = new Label();
            txtGoal = new TextBox();
            lblActivityLevel = new Label();
            txtActivityLevel = new TextBox();
            lblDietType = new Label();
            txtDietType = new TextBox();
            pnlNutritionResults = new Panel();
            lblNutritionResultsTitle = new Label();
            lblMaintenanceCalories = new Label();
            txtMaintenanceCalories = new TextBox();
            lblBodyMassIndex = new Label();
            txtBodyMassIndex = new TextBox();
            lblBodyMassIndexCategory = new Label();
            txtBodyMassIndexCategory = new TextBox();
            lblProteinGrams = new Label();
            txtProteinGrams = new TextBox();
            lblCarbohydratesGrams = new Label();
            txtCarbohydratesGrams = new TextBox();
            lblFatGrams = new Label();
            txtFatGrams = new TextBox();
            btnRefresh = new Button();
            btnClose = new Button();
            pnlHelp = new Panel();
            lblHelpTitle = new Label();
            lblHelpText = new Label();
            pnlHeader.SuspendLayout();
            pnlUserData.SuspendLayout();
            pnlNutritionResults.SuspendLayout();
            pnlHelp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1040, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(32, 10);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(84, 41);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Vitta";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(283, 84);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Información nutricional";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(191, 148);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(648, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Consulta los datos del usuario, sus calorías sugeridas y el resumen de macronutrientes.";
            // 
            // pnlUserData
            // 
            pnlUserData.BackColor = Color.White;
            pnlUserData.BorderStyle = BorderStyle.FixedSingle;
            pnlUserData.Controls.Add(lblUserDataTitle);
            pnlUserData.Controls.Add(lblUserName);
            pnlUserData.Controls.Add(txtUserName);
            pnlUserData.Controls.Add(lblWeight);
            pnlUserData.Controls.Add(txtWeight);
            pnlUserData.Controls.Add(lblHeight);
            pnlUserData.Controls.Add(txtHeight);
            pnlUserData.Controls.Add(lblGoal);
            pnlUserData.Controls.Add(txtGoal);
            pnlUserData.Controls.Add(lblActivityLevel);
            pnlUserData.Controls.Add(txtActivityLevel);
            pnlUserData.Controls.Add(lblDietType);
            pnlUserData.Controls.Add(txtDietType);
            pnlUserData.Location = new Point(48, 198);
            pnlUserData.Name = "pnlUserData";
            pnlUserData.Size = new Size(440, 352);
            pnlUserData.TabIndex = 3;
            // 
            // lblUserDataTitle
            // 
            lblUserDataTitle.AutoSize = true;
            lblUserDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserDataTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblUserDataTitle.Location = new Point(129, 20);
            lblUserDataTitle.Name = "lblUserDataTitle";
            lblUserDataTitle.Size = new Size(194, 32);
            lblUserDataTitle.TabIndex = 0;
            lblUserDataTitle.Text = "Datos del usuario";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(66, 66, 66);
            lblUserName.Location = new Point(32, 84);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(210, 81);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(190, 30);
            txtUserName.TabIndex = 2;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.ForeColor = Color.FromArgb(66, 66, 66);
            lblWeight.Location = new Point(32, 126);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 23);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Peso";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWeight.Location = new Point(210, 123);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(190, 30);
            txtWeight.TabIndex = 4;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeight.ForeColor = Color.FromArgb(66, 66, 66);
            lblHeight.Location = new Point(32, 168);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(60, 23);
            lblHeight.TabIndex = 5;
            lblHeight.Text = "Altura";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(210, 165);
            txtHeight.Name = "txtHeight";
            txtHeight.ReadOnly = true;
            txtHeight.Size = new Size(190, 30);
            txtHeight.TabIndex = 6;
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblGoal.Location = new Point(32, 210);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(79, 23);
            lblGoal.TabIndex = 7;
            lblGoal.Text = "Objetivo";
            // 
            // txtGoal
            // 
            txtGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGoal.Location = new Point(210, 207);
            txtGoal.Name = "txtGoal";
            txtGoal.ReadOnly = true;
            txtGoal.Size = new Size(190, 30);
            txtGoal.TabIndex = 8;
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActivityLevel.ForeColor = Color.FromArgb(66, 66, 66);
            lblActivityLevel.Location = new Point(32, 252);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(155, 23);
            lblActivityLevel.TabIndex = 9;
            lblActivityLevel.Text = "Nivel de actividad";
            // 
            // txtActivityLevel
            // 
            txtActivityLevel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActivityLevel.Location = new Point(210, 249);
            txtActivityLevel.Name = "txtActivityLevel";
            txtActivityLevel.ReadOnly = true;
            txtActivityLevel.Size = new Size(190, 30);
            txtActivityLevel.TabIndex = 10;
            // 
            // lblDietType
            // 
            lblDietType.AutoSize = true;
            lblDietType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDietType.ForeColor = Color.FromArgb(66, 66, 66);
            lblDietType.Location = new Point(32, 294);
            lblDietType.Name = "lblDietType";
            lblDietType.Size = new Size(117, 23);
            lblDietType.TabIndex = 11;
            lblDietType.Text = "Tipo de dieta";
            // 
            // txtDietType
            // 
            txtDietType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDietType.Location = new Point(210, 291);
            txtDietType.Name = "txtDietType";
            txtDietType.ReadOnly = true;
            txtDietType.Size = new Size(190, 30);
            txtDietType.TabIndex = 12;
            // 
            // pnlNutritionResults
            // 
            pnlNutritionResults.BackColor = Color.White;
            pnlNutritionResults.BorderStyle = BorderStyle.FixedSingle;
            pnlNutritionResults.Controls.Add(lblNutritionResultsTitle);
            pnlNutritionResults.Controls.Add(lblMaintenanceCalories);
            pnlNutritionResults.Controls.Add(txtMaintenanceCalories);
            pnlNutritionResults.Controls.Add(lblBodyMassIndex);
            pnlNutritionResults.Controls.Add(txtBodyMassIndex);
            pnlNutritionResults.Controls.Add(lblBodyMassIndexCategory);
            pnlNutritionResults.Controls.Add(txtBodyMassIndexCategory);
            pnlNutritionResults.Controls.Add(lblProteinGrams);
            pnlNutritionResults.Controls.Add(txtProteinGrams);
            pnlNutritionResults.Controls.Add(lblCarbohydratesGrams);
            pnlNutritionResults.Controls.Add(txtCarbohydratesGrams);
            pnlNutritionResults.Controls.Add(lblFatGrams);
            pnlNutritionResults.Controls.Add(txtFatGrams);
            pnlNutritionResults.Location = new Point(536, 198);
            pnlNutritionResults.Name = "pnlNutritionResults";
            pnlNutritionResults.Size = new Size(456, 352);
            pnlNutritionResults.TabIndex = 4;
            // 
            // lblNutritionResultsTitle
            // 
            lblNutritionResultsTitle.AutoSize = true;
            lblNutritionResultsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNutritionResultsTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblNutritionResultsTitle.Location = new Point(95, 20);
            lblNutritionResultsTitle.Name = "lblNutritionResultsTitle";
            lblNutritionResultsTitle.Size = new Size(266, 32);
            lblNutritionResultsTitle.TabIndex = 0;
            lblNutritionResultsTitle.Text = "Resultados nutricionales";
            // 
            // lblMaintenanceCalories
            // 
            lblMaintenanceCalories.AutoSize = true;
            lblMaintenanceCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintenanceCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblMaintenanceCalories.Location = new Point(28, 84);
            lblMaintenanceCalories.Name = "lblMaintenanceCalories";
            lblMaintenanceCalories.Size = new Size(223, 23);
            lblMaintenanceCalories.TabIndex = 1;
            lblMaintenanceCalories.Text = "Calorías de mantenimiento";
            // 
            // txtMaintenanceCalories
            // 
            txtMaintenanceCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaintenanceCalories.Location = new Point(281, 81);
            txtMaintenanceCalories.Name = "txtMaintenanceCalories";
            txtMaintenanceCalories.ReadOnly = true;
            txtMaintenanceCalories.Size = new Size(140, 30);
            txtMaintenanceCalories.TabIndex = 2;
            // 
            // lblBodyMassIndex
            // 
            lblBodyMassIndex.AutoSize = true;
            lblBodyMassIndex.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBodyMassIndex.ForeColor = Color.FromArgb(66, 66, 66);
            lblBodyMassIndex.Location = new Point(28, 126);
            lblBodyMassIndex.Name = "lblBodyMassIndex";
            lblBodyMassIndex.Size = new Size(44, 23);
            lblBodyMassIndex.TabIndex = 3;
            lblBodyMassIndex.Text = "IMC";
            // 
            // txtBodyMassIndex
            // 
            txtBodyMassIndex.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBodyMassIndex.Location = new Point(281, 123);
            txtBodyMassIndex.Name = "txtBodyMassIndex";
            txtBodyMassIndex.ReadOnly = true;
            txtBodyMassIndex.Size = new Size(140, 30);
            txtBodyMassIndex.TabIndex = 4;
            // 
            // lblBodyMassIndexCategory
            // 
            lblBodyMassIndexCategory.AutoSize = true;
            lblBodyMassIndexCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBodyMassIndexCategory.ForeColor = Color.FromArgb(66, 66, 66);
            lblBodyMassIndexCategory.Location = new Point(28, 168);
            lblBodyMassIndexCategory.Name = "lblBodyMassIndexCategory";
            lblBodyMassIndexCategory.Size = new Size(135, 23);
            lblBodyMassIndexCategory.TabIndex = 5;
            lblBodyMassIndexCategory.Text = "Clasificación IMC";
            // 
            // txtBodyMassIndexCategory
            // 
            txtBodyMassIndexCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBodyMassIndexCategory.Location = new Point(281, 165);
            txtBodyMassIndexCategory.Name = "txtBodyMassIndexCategory";
            txtBodyMassIndexCategory.ReadOnly = true;
            txtBodyMassIndexCategory.Size = new Size(140, 30);
            txtBodyMassIndexCategory.TabIndex = 6;
            // 
            // lblProteinGrams
            // 
            lblProteinGrams.AutoSize = true;
            lblProteinGrams.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProteinGrams.ForeColor = Color.FromArgb(66, 66, 66);
            lblProteinGrams.Location = new Point(28, 210);
            lblProteinGrams.Name = "lblProteinGrams";
            lblProteinGrams.Size = new Size(182, 23);
            lblProteinGrams.TabIndex = 7;
            lblProteinGrams.Text = "Proteínas sugeridas (g)";
            // 
            // txtProteinGrams
            // 
            txtProteinGrams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProteinGrams.Location = new Point(281, 207);
            txtProteinGrams.Name = "txtProteinGrams";
            txtProteinGrams.ReadOnly = true;
            txtProteinGrams.Size = new Size(140, 30);
            txtProteinGrams.TabIndex = 8;
            // 
            // lblCarbohydratesGrams
            // 
            lblCarbohydratesGrams.AutoSize = true;
            lblCarbohydratesGrams.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarbohydratesGrams.ForeColor = Color.FromArgb(66, 66, 66);
            lblCarbohydratesGrams.Location = new Point(28, 252);
            lblCarbohydratesGrams.Name = "lblCarbohydratesGrams";
            lblCarbohydratesGrams.Size = new Size(232, 23);
            lblCarbohydratesGrams.TabIndex = 9;
            lblCarbohydratesGrams.Text = "Carbohidratos sugeridos (g)";
            // 
            // txtCarbohydratesGrams
            // 
            txtCarbohydratesGrams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarbohydratesGrams.Location = new Point(281, 249);
            txtCarbohydratesGrams.Name = "txtCarbohydratesGrams";
            txtCarbohydratesGrams.ReadOnly = true;
            txtCarbohydratesGrams.Size = new Size(140, 30);
            txtCarbohydratesGrams.TabIndex = 10;
            // 
            // lblFatGrams
            // 
            lblFatGrams.AutoSize = true;
            lblFatGrams.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFatGrams.ForeColor = Color.FromArgb(66, 66, 66);
            lblFatGrams.Location = new Point(28, 294);
            lblFatGrams.Name = "lblFatGrams";
            lblFatGrams.Size = new Size(153, 23);
            lblFatGrams.TabIndex = 11;
            lblFatGrams.Text = "Grasas sugeridas (g)";
            // 
            // txtFatGrams
            // 
            txtFatGrams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFatGrams.Location = new Point(281, 291);
            txtFatGrams.Name = "txtFatGrams";
            txtFatGrams.ReadOnly = true;
            txtFatGrams.Size = new Size(140, 30);
            txtFatGrams.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(46, 125, 50);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(292, 582);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(180, 44);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Actualizar";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(46, 125, 50);
            btnClose.Location = new Point(556, 582);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 44);
            btnClose.TabIndex = 6;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlHelp
            // 
            pnlHelp.BackColor = Color.White;
            pnlHelp.BorderStyle = BorderStyle.FixedSingle;
            pnlHelp.Controls.Add(lblHelpTitle);
            pnlHelp.Controls.Add(lblHelpText);
            pnlHelp.Location = new Point(48, 654);
            pnlHelp.Name = "pnlHelp";
            pnlHelp.Size = new Size(944, 94);
            pnlHelp.TabIndex = 7;
            // 
            // lblHelpTitle
            // 
            lblHelpTitle.AutoSize = true;
            lblHelpTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHelpTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblHelpTitle.Location = new Point(28, 18);
            lblHelpTitle.Name = "lblHelpTitle";
            lblHelpTitle.Size = new Size(167, 28);
            lblHelpTitle.TabIndex = 0;
            lblHelpTitle.Text = "¿Qué significa?";
            // 
            // lblHelpText
            // 
            lblHelpText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelpText.ForeColor = Color.FromArgb(66, 66, 66);
            lblHelpText.Location = new Point(28, 50);
            lblHelpText.Name = "lblHelpText";
            lblHelpText.Size = new Size(881, 23);
            lblHelpText.TabIndex = 1;
            lblHelpText.Text = "Aquí puedes revisar los datos base del usuario y los cálculos nutricionales estimados según su perfil.";
            // 
            // NutritionInfoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1040, 780);
            Controls.Add(pnlHelp);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(pnlNutritionResults);
            Controls.Add(pnlUserData);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NutritionInfoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vitta - Información nutricional";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlUserData.ResumeLayout(false);
            pnlUserData.PerformLayout();
            pnlNutritionResults.ResumeLayout(false);
            pnlNutritionResults.PerformLayout();
            pnlHelp.ResumeLayout(false);
            pnlHelp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlUserData;
        private Label lblUserDataTitle;
        private Label lblUserName;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblGoal;
        private Label lblActivityLevel;
        private Label lblDietType;
        private TextBox txtUserName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtGoal;
        private TextBox txtActivityLevel;
        private TextBox txtDietType;
        private Panel pnlNutritionResults;
        private Label lblNutritionResultsTitle;
        private Label lblMaintenanceCalories;
        private Label lblBodyMassIndex;
        private Label lblBodyMassIndexCategory;
        private Label lblProteinGrams;
        private Label lblCarbohydratesGrams;
        private Label lblFatGrams;
        private TextBox txtMaintenanceCalories;
        private TextBox txtBodyMassIndex;
        private TextBox txtBodyMassIndexCategory;
        private TextBox txtProteinGrams;
        private TextBox txtCarbohydratesGrams;
        private TextBox txtFatGrams;
        private Button btnRefresh;
        private Button btnClose;
        private Panel pnlHelp;
        private Label lblHelpTitle;
        private Label lblHelpText;
    }
}