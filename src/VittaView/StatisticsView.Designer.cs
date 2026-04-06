namespace VittaView
{
    partial class StatisticsView
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
            pnlFilters = new Panel();
            lblFilterTitle = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblDateSelector = new Label();
            dtpSelectedDate = new DateTimePicker();
            btnConsult = new Button();
            lblSelectedDate = new Label();
            txtSelectedDate = new TextBox();
            pnlDaily = new Panel();
            lblDailySection = new Label();
            lblConsumedCalories = new Label();
            txtConsumedCalories = new TextBox();
            lblCalorieGoal = new Label();
            txtCalorieGoal = new TextBox();
            lblRemainingCalories = new Label();
            txtRemainingCalories = new TextBox();
            txtRemainingProtein = new TextBox();
            lblConsumedProtein = new Label();
            txtFatGoal = new TextBox();
            txtConsumedProtein = new TextBox();
            txtConsumedFat = new TextBox();
            txtRemainingCarbohydrates = new TextBox();
            lblProteinGoal = new Label();
            txtCarbohydratesGoal = new TextBox();
            txtProteinGoal = new TextBox();
            txtConsumedCarbohydrates = new TextBox();
            lblRemainingProtein = new Label();
            lblConsumedCarbohydrates = new Label();
            lblCarbohydratesGoal = new Label();
            lblRemainingCarbohydrates = new Label();
            lblConsumedFat = new Label();
            lblFatGoal = new Label();
            lblRemainingFat = new Label();
            txtRemainingFat = new TextBox();
            lblDailySummaryTitle = new Label();
            txtDailySummary = new TextBox();
            pnlRange = new Panel();
            lblRangeSection = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblRangeCalories = new Label();
            txtRangeCalories = new TextBox();
            lblRangeProtein = new Label();
            txtRangeProtein = new TextBox();
            lblRangeCarbohydrates = new Label();
            txtRangeCarbohydrates = new TextBox();
            lblRangeFat = new Label();
            txtRangeFat = new TextBox();
            lblTotalDaysInRange = new Label();
            txtTotalDaysInRange = new TextBox();
            lblRegisteredDays = new Label();
            txtRegisteredDays = new TextBox();
            lblDaysMeetingGoal = new Label();
            lblPeriodSummaryTitle = new Label();
            txtPeriodSummary = new TextBox();
            txtDaysMeetingGoal = new TextBox();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlDaily.SuspendLayout();
            pnlRange.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 60);
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(366, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(501, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Estadísticas Nutricionales";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(231, 147);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(865, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Consulta el progreso diario y por período para comparar consumo, metas y cumplimiento nutricional.";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(lblFilterTitle);
            pnlFilters.Controls.Add(lblUserName);
            pnlFilters.Controls.Add(txtUserName);
            pnlFilters.Controls.Add(lblDateSelector);
            pnlFilters.Controls.Add(dtpSelectedDate);
            pnlFilters.Controls.Add(btnConsult);
            pnlFilters.Controls.Add(lblSelectedDate);
            pnlFilters.Controls.Add(txtSelectedDate);
            pnlFilters.Location = new Point(42, 194);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1195, 118);
            pnlFilters.TabIndex = 3;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblFilterTitle.Location = new Point(457, 14);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(311, 32);
            lblFilterTitle.TabIndex = 0;
            lblFilterTitle.Text = "Consulta del usuario y día";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(66, 66, 66);
            lblUserName.Location = new Point(28, 73);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(104, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(170, 30);
            txtUserName.TabIndex = 2;
            // 
            // lblDateSelector
            // 
            lblDateSelector.AutoSize = true;
            lblDateSelector.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateSelector.ForeColor = Color.FromArgb(66, 66, 66);
            lblDateSelector.Location = new Point(320, 73);
            lblDateSelector.Name = "lblDateSelector";
            lblDateSelector.Size = new Size(147, 23);
            lblDateSelector.TabIndex = 3;
            lblDateSelector.Text = "Fecha a consultar";
            // 
            // dtpSelectedDate
            // 
            dtpSelectedDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSelectedDate.Format = DateTimePickerFormat.Short;
            dtpSelectedDate.Location = new Point(467, 70);
            dtpSelectedDate.Name = "dtpSelectedDate";
            dtpSelectedDate.Size = new Size(150, 30);
            dtpSelectedDate.TabIndex = 4;
            // 
            // btnConsult
            // 
            btnConsult.BackColor = Color.FromArgb(46, 125, 50);
            btnConsult.FlatStyle = FlatStyle.Flat;
            btnConsult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsult.ForeColor = Color.White;
            btnConsult.Location = new Point(650, 67);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(150, 36);
            btnConsult.TabIndex = 5;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += btnConsult_Click;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedDate.ForeColor = Color.FromArgb(66, 66, 66);
            lblSelectedDate.Location = new Point(845, 73);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(127, 23);
            lblSelectedDate.TabIndex = 6;
            lblSelectedDate.Text = "Fecha aplicada";
            // 
            // txtSelectedDate
            // 
            txtSelectedDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSelectedDate.Location = new Point(977, 70);
            txtSelectedDate.Name = "txtSelectedDate";
            txtSelectedDate.ReadOnly = true;
            txtSelectedDate.Size = new Size(160, 30);
            txtSelectedDate.TabIndex = 7;
            // 
            // pnlDaily
            // 
            pnlDaily.BackColor = Color.White;
            pnlDaily.BorderStyle = BorderStyle.FixedSingle;
            pnlDaily.Controls.Add(lblDailySection);
            pnlDaily.Controls.Add(lblConsumedCalories);
            pnlDaily.Controls.Add(txtConsumedCalories);
            pnlDaily.Controls.Add(lblCalorieGoal);
            pnlDaily.Controls.Add(txtCalorieGoal);
            pnlDaily.Controls.Add(lblRemainingCalories);
            pnlDaily.Controls.Add(txtRemainingCalories);
            pnlDaily.Controls.Add(txtRemainingProtein);
            pnlDaily.Controls.Add(lblConsumedProtein);
            pnlDaily.Controls.Add(txtFatGoal);
            pnlDaily.Controls.Add(txtConsumedProtein);
            pnlDaily.Controls.Add(txtConsumedFat);
            pnlDaily.Controls.Add(txtRemainingCarbohydrates);
            pnlDaily.Controls.Add(lblProteinGoal);
            pnlDaily.Controls.Add(txtCarbohydratesGoal);
            pnlDaily.Controls.Add(txtProteinGoal);
            pnlDaily.Controls.Add(txtConsumedCarbohydrates);
            pnlDaily.Controls.Add(lblRemainingProtein);
            pnlDaily.Controls.Add(lblConsumedCarbohydrates);
            pnlDaily.Controls.Add(lblCarbohydratesGoal);
            pnlDaily.Controls.Add(lblRemainingCarbohydrates);
            pnlDaily.Controls.Add(lblConsumedFat);
            pnlDaily.Controls.Add(lblFatGoal);
            pnlDaily.Controls.Add(lblRemainingFat);
            pnlDaily.Controls.Add(txtRemainingFat);
            pnlDaily.Controls.Add(lblDailySummaryTitle);
            pnlDaily.Controls.Add(txtDailySummary);
            pnlDaily.Location = new Point(42, 332);
            pnlDaily.Name = "pnlDaily";
            pnlDaily.Size = new Size(1195, 330);
            pnlDaily.TabIndex = 4;
            // 
            // lblDailySection
            // 
            lblDailySection.AutoSize = true;
            lblDailySection.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailySection.ForeColor = Color.FromArgb(46, 125, 50);
            lblDailySection.Location = new Point(504, 15);
            lblDailySection.Name = "lblDailySection";
            lblDailySection.Size = new Size(186, 32);
            lblDailySection.TabIndex = 0;
            lblDailySection.Text = "Consulta diaria";
            // 
            // lblConsumedCalories
            // 
            lblConsumedCalories.AutoSize = true;
            lblConsumedCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedCalories.Location = new Point(28, 73);
            lblConsumedCalories.Name = "lblConsumedCalories";
            lblConsumedCalories.Size = new Size(171, 23);
            lblConsumedCalories.TabIndex = 1;
            lblConsumedCalories.Text = "Calorías consumidas";
            // 
            // txtConsumedCalories
            // 
            txtConsumedCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedCalories.Location = new Point(270, 66);
            txtConsumedCalories.Name = "txtConsumedCalories";
            txtConsumedCalories.ReadOnly = true;
            txtConsumedCalories.Size = new Size(77, 30);
            txtConsumedCalories.TabIndex = 2;
            // 
            // lblCalorieGoal
            // 
            lblCalorieGoal.AutoSize = true;
            lblCalorieGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalorieGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblCalorieGoal.Location = new Point(28, 113);
            lblCalorieGoal.Name = "lblCalorieGoal";
            lblCalorieGoal.Size = new Size(141, 23);
            lblCalorieGoal.TabIndex = 3;
            lblCalorieGoal.Text = "Meta de calorías";
            // 
            // txtCalorieGoal
            // 
            txtCalorieGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalorieGoal.Location = new Point(270, 106);
            txtCalorieGoal.Name = "txtCalorieGoal";
            txtCalorieGoal.ReadOnly = true;
            txtCalorieGoal.Size = new Size(77, 30);
            txtCalorieGoal.TabIndex = 4;
            // 
            // lblRemainingCalories
            // 
            lblRemainingCalories.AutoSize = true;
            lblRemainingCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblRemainingCalories.Location = new Point(28, 153);
            lblRemainingCalories.Name = "lblRemainingCalories";
            lblRemainingCalories.Size = new Size(157, 23);
            lblRemainingCalories.TabIndex = 5;
            lblRemainingCalories.Text = "Diferencia calorías";
            // 
            // txtRemainingCalories
            // 
            txtRemainingCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingCalories.Location = new Point(270, 146);
            txtRemainingCalories.Name = "txtRemainingCalories";
            txtRemainingCalories.ReadOnly = true;
            txtRemainingCalories.Size = new Size(77, 30);
            txtRemainingCalories.TabIndex = 6;
            // 
            // txtRemainingProtein
            // 
            txtRemainingProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingProtein.Location = new Point(650, 59);
            txtRemainingProtein.Name = "txtRemainingProtein";
            txtRemainingProtein.ReadOnly = true;
            txtRemainingProtein.Size = new Size(77, 30);
            txtRemainingProtein.TabIndex = 12;
            // 
            // lblConsumedProtein
            // 
            lblConsumedProtein.AutoSize = true;
            lblConsumedProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedProtein.Location = new Point(28, 201);
            lblConsumedProtein.Name = "lblConsumedProtein";
            lblConsumedProtein.Size = new Size(182, 23);
            lblConsumedProtein.TabIndex = 7;
            lblConsumedProtein.Text = "Proteínas consumidas";
            // 
            // txtFatGoal
            // 
            txtFatGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFatGoal.Location = new Point(650, 259);
            txtFatGoal.Name = "txtFatGoal";
            txtFatGoal.ReadOnly = true;
            txtFatGoal.Size = new Size(77, 30);
            txtFatGoal.TabIndex = 22;
            // 
            // txtConsumedProtein
            // 
            txtConsumedProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedProtein.Location = new Point(270, 194);
            txtConsumedProtein.Name = "txtConsumedProtein";
            txtConsumedProtein.ReadOnly = true;
            txtConsumedProtein.Size = new Size(77, 30);
            txtConsumedProtein.TabIndex = 8;
            // 
            // txtConsumedFat
            // 
            txtConsumedFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedFat.Location = new Point(650, 219);
            txtConsumedFat.Name = "txtConsumedFat";
            txtConsumedFat.ReadOnly = true;
            txtConsumedFat.Size = new Size(77, 30);
            txtConsumedFat.TabIndex = 20;
            // 
            // txtRemainingCarbohydrates
            // 
            txtRemainingCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingCarbohydrates.Location = new Point(650, 179);
            txtRemainingCarbohydrates.Name = "txtRemainingCarbohydrates";
            txtRemainingCarbohydrates.ReadOnly = true;
            txtRemainingCarbohydrates.Size = new Size(77, 30);
            txtRemainingCarbohydrates.TabIndex = 18;
            // 
            // lblProteinGoal
            // 
            lblProteinGoal.AutoSize = true;
            lblProteinGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProteinGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblProteinGoal.Location = new Point(28, 241);
            lblProteinGoal.Name = "lblProteinGoal";
            lblProteinGoal.Size = new Size(156, 23);
            lblProteinGoal.TabIndex = 9;
            lblProteinGoal.Text = "Meta de proteínas";
            // 
            // txtCarbohydratesGoal
            // 
            txtCarbohydratesGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarbohydratesGoal.Location = new Point(650, 139);
            txtCarbohydratesGoal.Name = "txtCarbohydratesGoal";
            txtCarbohydratesGoal.ReadOnly = true;
            txtCarbohydratesGoal.Size = new Size(77, 30);
            txtCarbohydratesGoal.TabIndex = 16;
            // 
            // txtProteinGoal
            // 
            txtProteinGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProteinGoal.Location = new Point(270, 234);
            txtProteinGoal.Name = "txtProteinGoal";
            txtProteinGoal.ReadOnly = true;
            txtProteinGoal.Size = new Size(77, 30);
            txtProteinGoal.TabIndex = 10;
            // 
            // txtConsumedCarbohydrates
            // 
            txtConsumedCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedCarbohydrates.Location = new Point(650, 99);
            txtConsumedCarbohydrates.Name = "txtConsumedCarbohydrates";
            txtConsumedCarbohydrates.ReadOnly = true;
            txtConsumedCarbohydrates.Size = new Size(77, 30);
            txtConsumedCarbohydrates.TabIndex = 14;
            // 
            // lblRemainingProtein
            // 
            lblRemainingProtein.AutoSize = true;
            lblRemainingProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblRemainingProtein.Location = new Point(376, 69);
            lblRemainingProtein.Name = "lblRemainingProtein";
            lblRemainingProtein.Size = new Size(172, 23);
            lblRemainingProtein.TabIndex = 11;
            lblRemainingProtein.Text = "Diferencia proteínas";
            // 
            // lblConsumedCarbohydrates
            // 
            lblConsumedCarbohydrates.AutoSize = true;
            lblConsumedCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedCarbohydrates.Location = new Point(376, 109);
            lblConsumedCarbohydrates.Name = "lblConsumedCarbohydrates";
            lblConsumedCarbohydrates.Size = new Size(223, 23);
            lblConsumedCarbohydrates.TabIndex = 13;
            lblConsumedCarbohydrates.Text = "Carbohidratos consumidos";
            // 
            // lblCarbohydratesGoal
            // 
            lblCarbohydratesGoal.AutoSize = true;
            lblCarbohydratesGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarbohydratesGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblCarbohydratesGoal.Location = new Point(376, 149);
            lblCarbohydratesGoal.Name = "lblCarbohydratesGoal";
            lblCarbohydratesGoal.Size = new Size(192, 23);
            lblCarbohydratesGoal.TabIndex = 15;
            lblCarbohydratesGoal.Text = "Meta de carbohidratos";
            // 
            // lblRemainingCarbohydrates
            // 
            lblRemainingCarbohydrates.AutoSize = true;
            lblRemainingCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblRemainingCarbohydrates.Location = new Point(376, 197);
            lblRemainingCarbohydrates.Name = "lblRemainingCarbohydrates";
            lblRemainingCarbohydrates.Size = new Size(208, 23);
            lblRemainingCarbohydrates.TabIndex = 17;
            lblRemainingCarbohydrates.Text = "Diferencia carbohidratos";
            // 
            // lblConsumedFat
            // 
            lblConsumedFat.AutoSize = true;
            lblConsumedFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedFat.Location = new Point(376, 239);
            lblConsumedFat.Name = "lblConsumedFat";
            lblConsumedFat.Size = new Size(159, 23);
            lblConsumedFat.TabIndex = 19;
            lblConsumedFat.Text = "Grasas consumidas";
            // 
            // lblFatGoal
            // 
            lblFatGoal.AutoSize = true;
            lblFatGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFatGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblFatGoal.Location = new Point(376, 277);
            lblFatGoal.Name = "lblFatGoal";
            lblFatGoal.Size = new Size(131, 23);
            lblFatGoal.TabIndex = 21;
            lblFatGoal.Text = "Meta de grasas";
            // 
            // lblRemainingFat
            // 
            lblRemainingFat.AutoSize = true;
            lblRemainingFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblRemainingFat.Location = new Point(28, 281);
            lblRemainingFat.Name = "lblRemainingFat";
            lblRemainingFat.Size = new Size(147, 23);
            lblRemainingFat.TabIndex = 23;
            lblRemainingFat.Text = "Diferencia grasas";
            lblRemainingFat.Visible = false;
            // 
            // txtRemainingFat
            // 
            txtRemainingFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingFat.Location = new Point(270, 274);
            txtRemainingFat.Name = "txtRemainingFat";
            txtRemainingFat.ReadOnly = true;
            txtRemainingFat.Size = new Size(77, 30);
            txtRemainingFat.TabIndex = 24;
            txtRemainingFat.Visible = false;
            // 
            // lblDailySummaryTitle
            // 
            lblDailySummaryTitle.AutoSize = true;
            lblDailySummaryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailySummaryTitle.ForeColor = Color.FromArgb(66, 66, 66);
            lblDailySummaryTitle.Location = new Point(903, 24);
            lblDailySummaryTitle.Name = "lblDailySummaryTitle";
            lblDailySummaryTitle.Size = new Size(134, 23);
            lblDailySummaryTitle.TabIndex = 25;
            lblDailySummaryTitle.Text = "Resumen diario";
            // 
            // txtDailySummary
            // 
            txtDailySummary.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailySummary.Location = new Point(758, 66);
            txtDailySummary.Multiline = true;
            txtDailySummary.Name = "txtDailySummary";
            txtDailySummary.ReadOnly = true;
            txtDailySummary.ScrollBars = ScrollBars.Vertical;
            txtDailySummary.Size = new Size(411, 238);
            txtDailySummary.TabIndex = 26;
            // 
            // pnlRange
            // 
            pnlRange.BackColor = Color.White;
            pnlRange.BorderStyle = BorderStyle.FixedSingle;
            pnlRange.Controls.Add(lblRangeSection);
            pnlRange.Controls.Add(lblStartDate);
            pnlRange.Controls.Add(dtpStartDate);
            pnlRange.Controls.Add(lblEndDate);
            pnlRange.Controls.Add(dtpEndDate);
            pnlRange.Controls.Add(lblRangeCalories);
            pnlRange.Controls.Add(txtRangeCalories);
            pnlRange.Controls.Add(lblRangeProtein);
            pnlRange.Controls.Add(txtRangeProtein);
            pnlRange.Controls.Add(lblRangeCarbohydrates);
            pnlRange.Controls.Add(txtRangeCarbohydrates);
            pnlRange.Controls.Add(lblRangeFat);
            pnlRange.Controls.Add(txtRangeFat);
            pnlRange.Controls.Add(lblTotalDaysInRange);
            pnlRange.Controls.Add(txtTotalDaysInRange);
            pnlRange.Controls.Add(lblRegisteredDays);
            pnlRange.Controls.Add(txtRegisteredDays);
            pnlRange.Controls.Add(lblDaysMeetingGoal);
            pnlRange.Controls.Add(lblPeriodSummaryTitle);
            pnlRange.Controls.Add(txtPeriodSummary);
            pnlRange.Controls.Add(txtDaysMeetingGoal);
            pnlRange.Location = new Point(42, 711);
            pnlRange.Name = "pnlRange";
            pnlRange.Size = new Size(1195, 400);
            pnlRange.TabIndex = 5;
            // 
            // lblRangeSection
            // 
            lblRangeSection.AutoSize = true;
            lblRangeSection.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeSection.ForeColor = Color.FromArgb(46, 125, 50);
            lblRangeSection.Location = new Point(422, 15);
            lblRangeSection.Name = "lblRangeSection";
            lblRangeSection.Size = new Size(350, 32);
            lblRangeSection.TabIndex = 0;
            lblRangeSection.Text = "Consulta por rango de fechas";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.FromArgb(66, 66, 66);
            lblStartDate.Location = new Point(28, 72);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(107, 23);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Fecha inicial";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(141, 69);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 30);
            dtpStartDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.FromArgb(66, 66, 66);
            lblEndDate.Location = new Point(305, 72);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(96, 23);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "Fecha final";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(407, 69);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(191, 30);
            dtpEndDate.TabIndex = 4;
            // 
            // lblRangeCalories
            // 
            lblRangeCalories.AutoSize = true;
            lblRangeCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeCalories.Location = new Point(28, 122);
            lblRangeCalories.Name = "lblRangeCalories";
            lblRangeCalories.Size = new Size(212, 23);
            lblRangeCalories.TabIndex = 5;
            lblRangeCalories.Text = "Total calorías del período";
            // 
            // txtRangeCalories
            // 
            txtRangeCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeCalories.Location = new Point(270, 119);
            txtRangeCalories.Name = "txtRangeCalories";
            txtRangeCalories.ReadOnly = true;
            txtRangeCalories.Size = new Size(77, 30);
            txtRangeCalories.TabIndex = 6;
            // 
            // lblRangeProtein
            // 
            lblRangeProtein.AutoSize = true;
            lblRangeProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeProtein.Location = new Point(28, 162);
            lblRangeProtein.Name = "lblRangeProtein";
            lblRangeProtein.Size = new Size(227, 23);
            lblRangeProtein.TabIndex = 7;
            lblRangeProtein.Text = "Total proteínas del período";
            // 
            // txtRangeProtein
            // 
            txtRangeProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeProtein.Location = new Point(270, 159);
            txtRangeProtein.Name = "txtRangeProtein";
            txtRangeProtein.ReadOnly = true;
            txtRangeProtein.Size = new Size(77, 30);
            txtRangeProtein.TabIndex = 8;
            // 
            // lblRangeCarbohydrates
            // 
            lblRangeCarbohydrates.AutoSize = true;
            lblRangeCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeCarbohydrates.Location = new Point(28, 202);
            lblRangeCarbohydrates.Name = "lblRangeCarbohydrates";
            lblRangeCarbohydrates.Size = new Size(263, 23);
            lblRangeCarbohydrates.TabIndex = 9;
            lblRangeCarbohydrates.Text = "Total carbohidratos del período";
            // 
            // txtRangeCarbohydrates
            // 
            txtRangeCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeCarbohydrates.Location = new Point(297, 199);
            txtRangeCarbohydrates.Name = "txtRangeCarbohydrates";
            txtRangeCarbohydrates.ReadOnly = true;
            txtRangeCarbohydrates.Size = new Size(50, 30);
            txtRangeCarbohydrates.TabIndex = 10;
            // 
            // lblRangeFat
            // 
            lblRangeFat.AutoSize = true;
            lblRangeFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeFat.Location = new Point(28, 242);
            lblRangeFat.Name = "lblRangeFat";
            lblRangeFat.Size = new Size(202, 23);
            lblRangeFat.TabIndex = 11;
            lblRangeFat.Text = "Total grasas del período";
            // 
            // txtRangeFat
            // 
            txtRangeFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeFat.Location = new Point(270, 239);
            txtRangeFat.Name = "txtRangeFat";
            txtRangeFat.ReadOnly = true;
            txtRangeFat.Size = new Size(77, 30);
            txtRangeFat.TabIndex = 12;
            // 
            // lblTotalDaysInRange
            // 
            lblTotalDaysInRange.AutoSize = true;
            lblTotalDaysInRange.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDaysInRange.ForeColor = Color.FromArgb(66, 66, 66);
            lblTotalDaysInRange.Location = new Point(391, 122);
            lblTotalDaysInRange.Name = "lblTotalDaysInRange";
            lblTotalDaysInRange.Size = new Size(185, 23);
            lblTotalDaysInRange.TabIndex = 13;
            lblTotalDaysInRange.Text = "Días totales del rango";
            // 
            // txtTotalDaysInRange
            // 
            txtTotalDaysInRange.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalDaysInRange.Location = new Point(650, 115);
            txtTotalDaysInRange.Name = "txtTotalDaysInRange";
            txtTotalDaysInRange.ReadOnly = true;
            txtTotalDaysInRange.Size = new Size(77, 30);
            txtTotalDaysInRange.TabIndex = 14;
            // 
            // lblRegisteredDays
            // 
            lblRegisteredDays.AutoSize = true;
            lblRegisteredDays.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisteredDays.ForeColor = Color.FromArgb(66, 66, 66);
            lblRegisteredDays.Location = new Point(391, 159);
            lblRegisteredDays.Name = "lblRegisteredDays";
            lblRegisteredDays.Size = new Size(215, 23);
            lblRegisteredDays.TabIndex = 15;
            lblRegisteredDays.Text = "Días con menú registrado";
            // 
            // txtRegisteredDays
            // 
            txtRegisteredDays.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegisteredDays.Location = new Point(650, 155);
            txtRegisteredDays.Name = "txtRegisteredDays";
            txtRegisteredDays.ReadOnly = true;
            txtRegisteredDays.Size = new Size(77, 30);
            txtRegisteredDays.TabIndex = 16;
            // 
            // lblDaysMeetingGoal
            // 
            lblDaysMeetingGoal.AutoSize = true;
            lblDaysMeetingGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaysMeetingGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblDaysMeetingGoal.Location = new Point(391, 199);
            lblDaysMeetingGoal.Name = "lblDaysMeetingGoal";
            lblDaysMeetingGoal.Size = new Size(240, 23);
            lblDaysMeetingGoal.TabIndex = 17;
            lblDaysMeetingGoal.Text = "Días que cumplieron la meta";
            // 
            // lblPeriodSummaryTitle
            // 
            lblPeriodSummaryTitle.AutoSize = true;
            lblPeriodSummaryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeriodSummaryTitle.ForeColor = Color.FromArgb(66, 66, 66);
            lblPeriodSummaryTitle.Location = new Point(903, 22);
            lblPeriodSummaryTitle.Name = "lblPeriodSummaryTitle";
            lblPeriodSummaryTitle.Size = new Size(150, 23);
            lblPeriodSummaryTitle.TabIndex = 19;
            lblPeriodSummaryTitle.Text = "Resumen período";
            // 
            // txtPeriodSummary
            // 
            txtPeriodSummary.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeriodSummary.Location = new Point(758, 69);
            txtPeriodSummary.Multiline = true;
            txtPeriodSummary.Name = "txtPeriodSummary";
            txtPeriodSummary.ReadOnly = true;
            txtPeriodSummary.ScrollBars = ScrollBars.Vertical;
            txtPeriodSummary.Size = new Size(404, 299);
            txtPeriodSummary.TabIndex = 20;
            // 
            // txtDaysMeetingGoal
            // 
            txtDaysMeetingGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDaysMeetingGoal.Location = new Point(650, 195);
            txtDaysMeetingGoal.Name = "txtDaysMeetingGoal";
            txtDaysMeetingGoal.ReadOnly = true;
            txtDaysMeetingGoal.Size = new Size(77, 30);
            txtDaysMeetingGoal.TabIndex = 18;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(46, 125, 50);
            btnClose.Location = new Point(1025, 1135);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 44);
            btnClose.TabIndex = 6;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // StatisticsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1280, 1191);
            Controls.Add(btnClose);
            Controls.Add(pnlRange);
            Controls.Add(pnlDaily);
            Controls.Add(pnlFilters);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StatisticsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vitta - Estadísticas nutricionales";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlDaily.ResumeLayout(false);
            pnlDaily.PerformLayout();
            pnlRange.ResumeLayout(false);
            pnlRange.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlFilters;
        private Label lblFilterTitle;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblDateSelector;
        private DateTimePicker dtpSelectedDate;
        private Button btnConsult;
        private Label lblSelectedDate;
        private TextBox txtSelectedDate;
        private Panel pnlDaily;
        private Label lblDailySection;
        private Label lblConsumedCalories;
        private TextBox txtConsumedCalories;
        private Label lblCalorieGoal;
        private TextBox txtCalorieGoal;
        private Label lblRemainingCalories;
        private TextBox txtRemainingCalories;
        private Label lblConsumedProtein;
        private TextBox txtConsumedProtein;
        private Label lblProteinGoal;
        private TextBox txtProteinGoal;
        private Label lblRemainingProtein;
        private TextBox txtRemainingProtein;
        private Label lblConsumedCarbohydrates;
        private TextBox txtConsumedCarbohydrates;
        private Label lblCarbohydratesGoal;
        private TextBox txtCarbohydratesGoal;
        private Label lblRemainingCarbohydrates;
        private TextBox txtRemainingCarbohydrates;
        private Label lblConsumedFat;
        private TextBox txtConsumedFat;
        private Label lblFatGoal;
        private TextBox txtFatGoal;
        private Label lblRemainingFat;
        private TextBox txtRemainingFat;
        private Label lblDailySummaryTitle;
        private TextBox txtDailySummary;
        private Panel pnlRange;
        private Label lblRangeSection;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblRangeCalories;
        private TextBox txtRangeCalories;
        private Label lblRangeProtein;
        private TextBox txtRangeProtein;
        private Label lblRangeCarbohydrates;
        private TextBox txtRangeCarbohydrates;
        private Label lblRangeFat;
        private TextBox txtRangeFat;
        private Label lblTotalDaysInRange;
        private TextBox txtTotalDaysInRange;
        private Label lblRegisteredDays;
        private TextBox txtRegisteredDays;
        private Label lblDaysMeetingGoal;
        private TextBox txtDaysMeetingGoal;
        private Label lblPeriodSummaryTitle;
        private TextBox txtPeriodSummary;
        private Button btnClose;
    }
}