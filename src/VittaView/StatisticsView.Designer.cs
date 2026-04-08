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
            lblSelectedDate = new Label();
            txtSelectedDate = new TextBox();
            pnlDaily = new Panel();
            lblDailySection = new Label();
            lblConsumedColumnTitle = new Label();
            lblGoalColumnTitle = new Label();
            lblDifferenceColumnTitle = new Label();
            lblConsumedCalories = new Label();
            txtConsumedCalories = new TextBox();
            lblCalorieGoal = new Label();
            txtCalorieGoal = new TextBox();
            lblRemainingCalories = new Label();
            txtRemainingCalories = new TextBox();
            lblConsumedProtein = new Label();
            txtConsumedProtein = new TextBox();
            lblProteinGoal = new Label();
            txtProteinGoal = new TextBox();
            lblRemainingProtein = new Label();
            txtRemainingProtein = new TextBox();
            lblConsumedCarbohydrates = new Label();
            txtConsumedCarbohydrates = new TextBox();
            lblCarbohydratesGoal = new Label();
            txtCarbohydratesGoal = new TextBox();
            lblRemainingCarbohydrates = new Label();
            txtRemainingCarbohydrates = new TextBox();
            lblConsumedFat = new Label();
            txtConsumedFat = new TextBox();
            lblFatGoal = new Label();
            txtFatGoal = new TextBox();
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
            btnConsultRange = new Button();
            lblRangeTotalsTitle = new Label();
            lblRangeIndicatorsTitle = new Label();
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
            txtDaysMeetingGoal = new TextBox();
            lblPeriodSummaryTitle = new Label();
            txtPeriodSummary = new TextBox();
            btnClose = new Button();
            btnConsult = new Button();
            dtpSelectedDate = new DateTimePicker();
            lblDateSelector = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            pnlHeader.SuspendLayout();
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
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Location = new Point(0, 0);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(0, 20);
            lblSelectedDate.TabIndex = 6;
            lblSelectedDate.Visible = false;
            // 
            // txtSelectedDate
            // 
            txtSelectedDate.Location = new Point(-500, -500);
            txtSelectedDate.Name = "txtSelectedDate";
            txtSelectedDate.Size = new Size(10, 27);
            txtSelectedDate.TabIndex = 7;
            txtSelectedDate.Visible = false;
            // 
            // pnlDaily
            // 
            pnlDaily.BackColor = Color.White;
            pnlDaily.BorderStyle = BorderStyle.FixedSingle;
            pnlDaily.Controls.Add(lblDailySection);
            pnlDaily.Controls.Add(lblUserName);
            pnlDaily.Controls.Add(lblConsumedColumnTitle);
            pnlDaily.Controls.Add(txtUserName);
            pnlDaily.Controls.Add(lblGoalColumnTitle);
            pnlDaily.Controls.Add(lblDateSelector);
            pnlDaily.Controls.Add(lblDifferenceColumnTitle);
            pnlDaily.Controls.Add(dtpSelectedDate);
            pnlDaily.Controls.Add(lblConsumedCalories);
            pnlDaily.Controls.Add(btnConsult);
            pnlDaily.Controls.Add(txtConsumedCalories);
            pnlDaily.Controls.Add(lblCalorieGoal);
            pnlDaily.Controls.Add(txtCalorieGoal);
            pnlDaily.Controls.Add(lblRemainingCalories);
            pnlDaily.Controls.Add(txtRemainingCalories);
            pnlDaily.Controls.Add(lblConsumedProtein);
            pnlDaily.Controls.Add(txtConsumedProtein);
            pnlDaily.Controls.Add(lblProteinGoal);
            pnlDaily.Controls.Add(txtProteinGoal);
            pnlDaily.Controls.Add(lblRemainingProtein);
            pnlDaily.Controls.Add(txtRemainingProtein);
            pnlDaily.Controls.Add(lblConsumedCarbohydrates);
            pnlDaily.Controls.Add(txtConsumedCarbohydrates);
            pnlDaily.Controls.Add(lblCarbohydratesGoal);
            pnlDaily.Controls.Add(txtCarbohydratesGoal);
            pnlDaily.Controls.Add(lblRemainingCarbohydrates);
            pnlDaily.Controls.Add(txtRemainingCarbohydrates);
            pnlDaily.Controls.Add(lblConsumedFat);
            pnlDaily.Controls.Add(txtConsumedFat);
            pnlDaily.Controls.Add(lblFatGoal);
            pnlDaily.Controls.Add(txtFatGoal);
            pnlDaily.Controls.Add(lblRemainingFat);
            pnlDaily.Controls.Add(txtRemainingFat);
            pnlDaily.Controls.Add(lblDailySummaryTitle);
            pnlDaily.Controls.Add(txtDailySummary);
            pnlDaily.Location = new Point(42, 232);
            pnlDaily.Name = "pnlDaily";
            pnlDaily.Size = new Size(1195, 387);
            pnlDaily.TabIndex = 4;
            // 
            // lblDailySection
            // 
            lblDailySection.AutoSize = true;
            lblDailySection.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailySection.ForeColor = Color.FromArgb(46, 125, 50);
            lblDailySection.Location = new Point(498, 15);
            lblDailySection.Name = "lblDailySection";
            lblDailySection.Size = new Size(186, 32);
            lblDailySection.TabIndex = 0;
            lblDailySection.Text = "Consulta diaria";
            // 
            // lblConsumedColumnTitle
            // 
            lblConsumedColumnTitle.AutoSize = true;
            lblConsumedColumnTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedColumnTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblConsumedColumnTitle.Location = new Point(252, 139);
            lblConsumedColumnTitle.Name = "lblConsumedColumnTitle";
            lblConsumedColumnTitle.Size = new Size(84, 23);
            lblConsumedColumnTitle.TabIndex = 1;
            lblConsumedColumnTitle.Text = "Consumo";
            // 
            // lblGoalColumnTitle
            // 
            lblGoalColumnTitle.AutoSize = true;
            lblGoalColumnTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoalColumnTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblGoalColumnTitle.Location = new Point(427, 139);
            lblGoalColumnTitle.Name = "lblGoalColumnTitle";
            lblGoalColumnTitle.Size = new Size(51, 23);
            lblGoalColumnTitle.TabIndex = 2;
            lblGoalColumnTitle.Text = "Meta";
            // 
            // lblDifferenceColumnTitle
            // 
            lblDifferenceColumnTitle.AutoSize = true;
            lblDifferenceColumnTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifferenceColumnTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblDifferenceColumnTitle.Location = new Point(592, 139);
            lblDifferenceColumnTitle.Name = "lblDifferenceColumnTitle";
            lblDifferenceColumnTitle.Size = new Size(92, 23);
            lblDifferenceColumnTitle.TabIndex = 3;
            lblDifferenceColumnTitle.Text = "Diferencia";
            // 
            // lblConsumedCalories
            // 
            lblConsumedCalories.AutoSize = true;
            lblConsumedCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedCalories.Location = new Point(47, 174);
            lblConsumedCalories.Name = "lblConsumedCalories";
            lblConsumedCalories.Size = new Size(73, 23);
            lblConsumedCalories.TabIndex = 4;
            lblConsumedCalories.Text = "Calorías";
            // 
            // txtConsumedCalories
            // 
            txtConsumedCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedCalories.Location = new Point(252, 171);
            txtConsumedCalories.Name = "txtConsumedCalories";
            txtConsumedCalories.ReadOnly = true;
            txtConsumedCalories.Size = new Size(100, 30);
            txtConsumedCalories.TabIndex = 5;
            // 
            // lblCalorieGoal
            // 
            lblCalorieGoal.AutoSize = true;
            lblCalorieGoal.Location = new Point(0, 0);
            lblCalorieGoal.Name = "lblCalorieGoal";
            lblCalorieGoal.Size = new Size(0, 20);
            lblCalorieGoal.TabIndex = 6;
            lblCalorieGoal.Visible = false;
            // 
            // txtCalorieGoal
            // 
            txtCalorieGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalorieGoal.Location = new Point(427, 171);
            txtCalorieGoal.Name = "txtCalorieGoal";
            txtCalorieGoal.ReadOnly = true;
            txtCalorieGoal.Size = new Size(100, 30);
            txtCalorieGoal.TabIndex = 7;
            // 
            // lblRemainingCalories
            // 
            lblRemainingCalories.AutoSize = true;
            lblRemainingCalories.Location = new Point(0, 0);
            lblRemainingCalories.Name = "lblRemainingCalories";
            lblRemainingCalories.Size = new Size(0, 20);
            lblRemainingCalories.TabIndex = 8;
            lblRemainingCalories.Visible = false;
            // 
            // txtRemainingCalories
            // 
            txtRemainingCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingCalories.Location = new Point(592, 171);
            txtRemainingCalories.Name = "txtRemainingCalories";
            txtRemainingCalories.ReadOnly = true;
            txtRemainingCalories.Size = new Size(100, 30);
            txtRemainingCalories.TabIndex = 9;
            // 
            // lblConsumedProtein
            // 
            lblConsumedProtein.AutoSize = true;
            lblConsumedProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedProtein.Location = new Point(47, 220);
            lblConsumedProtein.Name = "lblConsumedProtein";
            lblConsumedProtein.Size = new Size(84, 23);
            lblConsumedProtein.TabIndex = 10;
            lblConsumedProtein.Text = "Proteínas";
            // 
            // txtConsumedProtein
            // 
            txtConsumedProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedProtein.Location = new Point(252, 217);
            txtConsumedProtein.Name = "txtConsumedProtein";
            txtConsumedProtein.ReadOnly = true;
            txtConsumedProtein.Size = new Size(100, 30);
            txtConsumedProtein.TabIndex = 11;
            // 
            // lblProteinGoal
            // 
            lblProteinGoal.AutoSize = true;
            lblProteinGoal.Location = new Point(0, 0);
            lblProteinGoal.Name = "lblProteinGoal";
            lblProteinGoal.Size = new Size(0, 20);
            lblProteinGoal.TabIndex = 12;
            lblProteinGoal.Visible = false;
            // 
            // txtProteinGoal
            // 
            txtProteinGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProteinGoal.Location = new Point(427, 217);
            txtProteinGoal.Name = "txtProteinGoal";
            txtProteinGoal.ReadOnly = true;
            txtProteinGoal.Size = new Size(100, 30);
            txtProteinGoal.TabIndex = 13;
            // 
            // lblRemainingProtein
            // 
            lblRemainingProtein.AutoSize = true;
            lblRemainingProtein.Location = new Point(0, 0);
            lblRemainingProtein.Name = "lblRemainingProtein";
            lblRemainingProtein.Size = new Size(0, 20);
            lblRemainingProtein.TabIndex = 14;
            lblRemainingProtein.Visible = false;
            // 
            // txtRemainingProtein
            // 
            txtRemainingProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingProtein.Location = new Point(592, 217);
            txtRemainingProtein.Name = "txtRemainingProtein";
            txtRemainingProtein.ReadOnly = true;
            txtRemainingProtein.Size = new Size(100, 30);
            txtRemainingProtein.TabIndex = 15;
            // 
            // lblConsumedCarbohydrates
            // 
            lblConsumedCarbohydrates.AutoSize = true;
            lblConsumedCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedCarbohydrates.Location = new Point(47, 267);
            lblConsumedCarbohydrates.Name = "lblConsumedCarbohydrates";
            lblConsumedCarbohydrates.Size = new Size(124, 23);
            lblConsumedCarbohydrates.TabIndex = 16;
            lblConsumedCarbohydrates.Text = "Carbohidratos";
            // 
            // txtConsumedCarbohydrates
            // 
            txtConsumedCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedCarbohydrates.Location = new Point(252, 264);
            txtConsumedCarbohydrates.Name = "txtConsumedCarbohydrates";
            txtConsumedCarbohydrates.ReadOnly = true;
            txtConsumedCarbohydrates.Size = new Size(100, 30);
            txtConsumedCarbohydrates.TabIndex = 17;
            // 
            // lblCarbohydratesGoal
            // 
            lblCarbohydratesGoal.AutoSize = true;
            lblCarbohydratesGoal.Location = new Point(0, 0);
            lblCarbohydratesGoal.Name = "lblCarbohydratesGoal";
            lblCarbohydratesGoal.Size = new Size(0, 20);
            lblCarbohydratesGoal.TabIndex = 18;
            lblCarbohydratesGoal.Visible = false;
            // 
            // txtCarbohydratesGoal
            // 
            txtCarbohydratesGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarbohydratesGoal.Location = new Point(427, 264);
            txtCarbohydratesGoal.Name = "txtCarbohydratesGoal";
            txtCarbohydratesGoal.ReadOnly = true;
            txtCarbohydratesGoal.Size = new Size(100, 30);
            txtCarbohydratesGoal.TabIndex = 19;
            // 
            // lblRemainingCarbohydrates
            // 
            lblRemainingCarbohydrates.AutoSize = true;
            lblRemainingCarbohydrates.Location = new Point(0, 0);
            lblRemainingCarbohydrates.Name = "lblRemainingCarbohydrates";
            lblRemainingCarbohydrates.Size = new Size(0, 20);
            lblRemainingCarbohydrates.TabIndex = 20;
            lblRemainingCarbohydrates.Visible = false;
            // 
            // txtRemainingCarbohydrates
            // 
            txtRemainingCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingCarbohydrates.Location = new Point(592, 264);
            txtRemainingCarbohydrates.Name = "txtRemainingCarbohydrates";
            txtRemainingCarbohydrates.ReadOnly = true;
            txtRemainingCarbohydrates.Size = new Size(100, 30);
            txtRemainingCarbohydrates.TabIndex = 21;
            // 
            // lblConsumedFat
            // 
            lblConsumedFat.AutoSize = true;
            lblConsumedFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblConsumedFat.Location = new Point(47, 314);
            lblConsumedFat.Name = "lblConsumedFat";
            lblConsumedFat.Size = new Size(61, 23);
            lblConsumedFat.TabIndex = 22;
            lblConsumedFat.Text = "Grasas";
            // 
            // txtConsumedFat
            // 
            txtConsumedFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsumedFat.Location = new Point(252, 311);
            txtConsumedFat.Name = "txtConsumedFat";
            txtConsumedFat.ReadOnly = true;
            txtConsumedFat.Size = new Size(100, 30);
            txtConsumedFat.TabIndex = 23;
            // 
            // lblFatGoal
            // 
            lblFatGoal.AutoSize = true;
            lblFatGoal.Location = new Point(0, 0);
            lblFatGoal.Name = "lblFatGoal";
            lblFatGoal.Size = new Size(0, 20);
            lblFatGoal.TabIndex = 24;
            lblFatGoal.Visible = false;
            // 
            // txtFatGoal
            // 
            txtFatGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFatGoal.Location = new Point(427, 311);
            txtFatGoal.Name = "txtFatGoal";
            txtFatGoal.ReadOnly = true;
            txtFatGoal.Size = new Size(100, 30);
            txtFatGoal.TabIndex = 25;
            // 
            // lblRemainingFat
            // 
            lblRemainingFat.AutoSize = true;
            lblRemainingFat.Location = new Point(0, 0);
            lblRemainingFat.Name = "lblRemainingFat";
            lblRemainingFat.Size = new Size(0, 20);
            lblRemainingFat.TabIndex = 26;
            lblRemainingFat.Visible = false;
            // 
            // txtRemainingFat
            // 
            txtRemainingFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingFat.Location = new Point(592, 311);
            txtRemainingFat.Name = "txtRemainingFat";
            txtRemainingFat.ReadOnly = true;
            txtRemainingFat.Size = new Size(100, 30);
            txtRemainingFat.TabIndex = 27;
            // 
            // lblDailySummaryTitle
            // 
            lblDailySummaryTitle.AutoSize = true;
            lblDailySummaryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailySummaryTitle.ForeColor = Color.FromArgb(66, 66, 66);
            lblDailySummaryTitle.Location = new Point(853, 139);
            lblDailySummaryTitle.Name = "lblDailySummaryTitle";
            lblDailySummaryTitle.Size = new Size(175, 23);
            lblDailySummaryTitle.TabIndex = 28;
            lblDailySummaryTitle.Text = "Interpretación diaria";
            // 
            // txtDailySummary
            // 
            txtDailySummary.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailySummary.Location = new Point(765, 171);
            txtDailySummary.Multiline = true;
            txtDailySummary.Name = "txtDailySummary";
            txtDailySummary.ReadOnly = true;
            txtDailySummary.ScrollBars = ScrollBars.Vertical;
            txtDailySummary.Size = new Size(382, 170);
            txtDailySummary.TabIndex = 29;
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
            pnlRange.Controls.Add(btnConsultRange);
            pnlRange.Controls.Add(lblRangeTotalsTitle);
            pnlRange.Controls.Add(lblRangeIndicatorsTitle);
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
            pnlRange.Controls.Add(txtDaysMeetingGoal);
            pnlRange.Controls.Add(lblPeriodSummaryTitle);
            pnlRange.Controls.Add(txtPeriodSummary);
            pnlRange.Location = new Point(42, 639);
            pnlRange.Name = "pnlRange";
            pnlRange.Size = new Size(1195, 392);
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
            lblStartDate.Location = new Point(64, 78);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(107, 23);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Fecha inicial";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(210, 69);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 30);
            dtpStartDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.FromArgb(66, 66, 66);
            lblEndDate.Location = new Point(449, 78);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(96, 23);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "Fecha final";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(635, 71);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(189, 30);
            dtpEndDate.TabIndex = 4;
            // 
            // btnConsultRange
            // 
            btnConsultRange.BackColor = Color.FromArgb(46, 125, 50);
            btnConsultRange.FlatStyle = FlatStyle.Flat;
            btnConsultRange.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultRange.ForeColor = Color.White;
            btnConsultRange.Location = new Point(924, 63);
            btnConsultRange.Name = "btnConsultRange";
            btnConsultRange.Size = new Size(165, 36);
            btnConsultRange.TabIndex = 5;
            btnConsultRange.Text = "Consultar";
            btnConsultRange.UseVisualStyleBackColor = false;
            btnConsultRange.Click += btnConsult_Click;
            // 
            // lblRangeTotalsTitle
            // 
            lblRangeTotalsTitle.AutoSize = true;
            lblRangeTotalsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeTotalsTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblRangeTotalsTitle.Location = new Point(128, 160);
            lblRangeTotalsTitle.Name = "lblRangeTotalsTitle";
            lblRangeTotalsTitle.Size = new Size(163, 23);
            lblRangeTotalsTitle.TabIndex = 6;
            lblRangeTotalsTitle.Text = "Totales del período";
            // 
            // lblRangeIndicatorsTitle
            // 
            lblRangeIndicatorsTitle.AutoSize = true;
            lblRangeIndicatorsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeIndicatorsTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblRangeIndicatorsTitle.Location = new Point(449, 157);
            lblRangeIndicatorsTitle.Name = "lblRangeIndicatorsTitle";
            lblRangeIndicatorsTitle.Size = new Size(200, 23);
            lblRangeIndicatorsTitle.TabIndex = 7;
            lblRangeIndicatorsTitle.Text = "Indicadores del período";
            // 
            // lblRangeCalories
            // 
            lblRangeCalories.AutoSize = true;
            lblRangeCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeCalories.Location = new Point(42, 195);
            lblRangeCalories.Name = "lblRangeCalories";
            lblRangeCalories.Size = new Size(212, 23);
            lblRangeCalories.TabIndex = 8;
            lblRangeCalories.Text = "Total calorías del período";
            // 
            // txtRangeCalories
            // 
            txtRangeCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeCalories.Location = new Point(306, 192);
            txtRangeCalories.Name = "txtRangeCalories";
            txtRangeCalories.ReadOnly = true;
            txtRangeCalories.Size = new Size(86, 30);
            txtRangeCalories.TabIndex = 9;
            // 
            // lblRangeProtein
            // 
            lblRangeProtein.AutoSize = true;
            lblRangeProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeProtein.Location = new Point(42, 240);
            lblRangeProtein.Name = "lblRangeProtein";
            lblRangeProtein.Size = new Size(227, 23);
            lblRangeProtein.TabIndex = 10;
            lblRangeProtein.Text = "Total proteínas del período";
            // 
            // txtRangeProtein
            // 
            txtRangeProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeProtein.Location = new Point(306, 237);
            txtRangeProtein.Name = "txtRangeProtein";
            txtRangeProtein.ReadOnly = true;
            txtRangeProtein.Size = new Size(86, 30);
            txtRangeProtein.TabIndex = 11;
            // 
            // lblRangeCarbohydrates
            // 
            lblRangeCarbohydrates.AutoSize = true;
            lblRangeCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeCarbohydrates.Location = new Point(42, 288);
            lblRangeCarbohydrates.Name = "lblRangeCarbohydrates";
            lblRangeCarbohydrates.Size = new Size(263, 23);
            lblRangeCarbohydrates.TabIndex = 12;
            lblRangeCarbohydrates.Text = "Total carbohidratos del período";
            // 
            // txtRangeCarbohydrates
            // 
            txtRangeCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeCarbohydrates.Location = new Point(306, 285);
            txtRangeCarbohydrates.Name = "txtRangeCarbohydrates";
            txtRangeCarbohydrates.ReadOnly = true;
            txtRangeCarbohydrates.Size = new Size(86, 30);
            txtRangeCarbohydrates.TabIndex = 13;
            // 
            // lblRangeFat
            // 
            lblRangeFat.AutoSize = true;
            lblRangeFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRangeFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblRangeFat.Location = new Point(42, 337);
            lblRangeFat.Name = "lblRangeFat";
            lblRangeFat.Size = new Size(202, 23);
            lblRangeFat.TabIndex = 14;
            lblRangeFat.Text = "Total grasas del período";
            // 
            // txtRangeFat
            // 
            txtRangeFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRangeFat.Location = new Point(306, 334);
            txtRangeFat.Name = "txtRangeFat";
            txtRangeFat.ReadOnly = true;
            txtRangeFat.Size = new Size(86, 30);
            txtRangeFat.TabIndex = 15;
            // 
            // lblTotalDaysInRange
            // 
            lblTotalDaysInRange.AutoSize = true;
            lblTotalDaysInRange.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDaysInRange.ForeColor = Color.FromArgb(66, 66, 66);
            lblTotalDaysInRange.Location = new Point(404, 192);
            lblTotalDaysInRange.Name = "lblTotalDaysInRange";
            lblTotalDaysInRange.Size = new Size(185, 23);
            lblTotalDaysInRange.TabIndex = 16;
            lblTotalDaysInRange.Text = "Días totales del rango";
            // 
            // txtTotalDaysInRange
            // 
            txtTotalDaysInRange.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalDaysInRange.Location = new Point(663, 189);
            txtTotalDaysInRange.Name = "txtTotalDaysInRange";
            txtTotalDaysInRange.ReadOnly = true;
            txtTotalDaysInRange.Size = new Size(77, 30);
            txtTotalDaysInRange.TabIndex = 17;
            // 
            // lblRegisteredDays
            // 
            lblRegisteredDays.AutoSize = true;
            lblRegisteredDays.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisteredDays.ForeColor = Color.FromArgb(66, 66, 66);
            lblRegisteredDays.Location = new Point(404, 237);
            lblRegisteredDays.Name = "lblRegisteredDays";
            lblRegisteredDays.Size = new Size(215, 23);
            lblRegisteredDays.TabIndex = 18;
            lblRegisteredDays.Text = "Días con menú registrado";
            // 
            // txtRegisteredDays
            // 
            txtRegisteredDays.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegisteredDays.Location = new Point(663, 234);
            txtRegisteredDays.Name = "txtRegisteredDays";
            txtRegisteredDays.ReadOnly = true;
            txtRegisteredDays.Size = new Size(77, 30);
            txtRegisteredDays.TabIndex = 19;
            // 
            // lblDaysMeetingGoal
            // 
            lblDaysMeetingGoal.AutoSize = true;
            lblDaysMeetingGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaysMeetingGoal.ForeColor = Color.FromArgb(66, 66, 66);
            lblDaysMeetingGoal.Location = new Point(404, 285);
            lblDaysMeetingGoal.Name = "lblDaysMeetingGoal";
            lblDaysMeetingGoal.Size = new Size(240, 23);
            lblDaysMeetingGoal.TabIndex = 20;
            lblDaysMeetingGoal.Text = "Días que cumplieron la meta";
            // 
            // txtDaysMeetingGoal
            // 
            txtDaysMeetingGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDaysMeetingGoal.Location = new Point(663, 282);
            txtDaysMeetingGoal.Name = "txtDaysMeetingGoal";
            txtDaysMeetingGoal.ReadOnly = true;
            txtDaysMeetingGoal.Size = new Size(77, 30);
            txtDaysMeetingGoal.TabIndex = 21;
            // 
            // lblPeriodSummaryTitle
            // 
            lblPeriodSummaryTitle.AutoSize = true;
            lblPeriodSummaryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeriodSummaryTitle.ForeColor = Color.FromArgb(66, 66, 66);
            lblPeriodSummaryTitle.Location = new Point(834, 121);
            lblPeriodSummaryTitle.Name = "lblPeriodSummaryTitle";
            lblPeriodSummaryTitle.Size = new Size(192, 23);
            lblPeriodSummaryTitle.TabIndex = 22;
            lblPeriodSummaryTitle.Text = "Interpretación período";
            // 
            // txtPeriodSummary
            // 
            txtPeriodSummary.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeriodSummary.Location = new Point(758, 153);
            txtPeriodSummary.Multiline = true;
            txtPeriodSummary.Name = "txtPeriodSummary";
            txtPeriodSummary.ReadOnly = true;
            txtPeriodSummary.ScrollBars = ScrollBars.Vertical;
            txtPeriodSummary.Size = new Size(382, 211);
            txtPeriodSummary.TabIndex = 23;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(46, 125, 50);
            btnClose.Location = new Point(950, 1048);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(287, 44);
            btnClose.TabIndex = 6;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnConsult
            // 
            btnConsult.BackColor = Color.FromArgb(46, 125, 50);
            btnConsult.FlatStyle = FlatStyle.Flat;
            btnConsult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsult.ForeColor = Color.White;
            btnConsult.Location = new Point(924, 72);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(165, 36);
            btnConsult.TabIndex = 5;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += btnConsult_Click;
            // 
            // dtpSelectedDate
            // 
            dtpSelectedDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSelectedDate.Format = DateTimePickerFormat.Short;
            dtpSelectedDate.Location = new Point(635, 79);
            dtpSelectedDate.Name = "dtpSelectedDate";
            dtpSelectedDate.Size = new Size(189, 30);
            dtpSelectedDate.TabIndex = 4;
            // 
            // lblDateSelector
            // 
            lblDateSelector.AutoSize = true;
            lblDateSelector.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateSelector.ForeColor = Color.FromArgb(66, 66, 66);
            lblDateSelector.Location = new Point(459, 87);
            lblDateSelector.Name = "lblDateSelector";
            lblDateSelector.Size = new Size(147, 23);
            lblDateSelector.TabIndex = 3;
            lblDateSelector.Text = "Fecha a consultar";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(207, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(153, 30);
            txtUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(66, 66, 66);
            lblUserName.Location = new Point(114, 85);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(70, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // StatisticsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1280, 1117);
            Controls.Add(btnClose);
            Controls.Add(pnlRange);
            Controls.Add(pnlDaily);
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
        private Label lblSelectedDate;
        private TextBox txtSelectedDate;
        private Panel pnlDaily;
        private Label lblDailySection;
        private Label lblConsumedColumnTitle;
        private Label lblGoalColumnTitle;
        private Label lblDifferenceColumnTitle;
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
        private Button btnConsultRange;
        private Label lblRangeTotalsTitle;
        private Label lblRangeIndicatorsTitle;
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
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblDateSelector;
        private DateTimePicker dtpSelectedDate;
        private Button btnConsult;
    }
}