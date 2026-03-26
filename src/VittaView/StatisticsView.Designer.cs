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
            lblTitle = new Label();
            lblUserName = new Label();
            lblDateSelector = new Label();
            txtUserName = new TextBox();
            dtpSelectedDate = new DateTimePicker();
            btnConsult = new Button();
            lblSelectedDate = new Label();
            txtSelectedDate = new TextBox();
            lblDailySection = new Label();
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
            txtDaysMeetingGoal = new TextBox();
            lblSummary = new Label();
            txtSummary = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(333, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(370, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Estadísticas nutricionales";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(32, 86);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(59, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario";
            // 
            // lblDateSelector
            // 
            lblDateSelector.AutoSize = true;
            lblDateSelector.Location = new Point(296, 86);
            lblDateSelector.Name = "lblDateSelector";
            lblDateSelector.Size = new Size(123, 20);
            lblDateSelector.TabIndex = 2;
            lblDateSelector.Text = "Fecha a consultar";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(106, 83);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(154, 27);
            txtUserName.TabIndex = 3;
            // 
            // dtpSelectedDate
            // 
            dtpSelectedDate.Format = DateTimePickerFormat.Short;
            dtpSelectedDate.Location = new Point(442, 83);
            dtpSelectedDate.Name = "dtpSelectedDate";
            dtpSelectedDate.Size = new Size(151, 27);
            dtpSelectedDate.TabIndex = 4;
            // 
            // btnConsult
            // 
            btnConsult.Location = new Point(617, 82);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(128, 29);
            btnConsult.TabIndex = 5;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = true;
            btnConsult.Click += btnConsult_Click;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Location = new Point(779, 86);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(108, 20);
            lblSelectedDate.TabIndex = 6;
            lblSelectedDate.Text = "Fecha aplicada";
            // 
            // txtSelectedDate
            // 
            txtSelectedDate.Location = new Point(909, 83);
            txtSelectedDate.Name = "txtSelectedDate";
            txtSelectedDate.ReadOnly = true;
            txtSelectedDate.Size = new Size(136, 27);
            txtSelectedDate.TabIndex = 7;
            // 
            // lblDailySection
            // 
            lblDailySection.AutoSize = true;
            lblDailySection.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDailySection.Location = new Point(32, 141);
            lblDailySection.Name = "lblDailySection";
            lblDailySection.Size = new Size(145, 25);
            lblDailySection.TabIndex = 8;
            lblDailySection.Text = "Consulta diaria";
            // 
            // lblConsumedCalories
            // 
            lblConsumedCalories.AutoSize = true;
            lblConsumedCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConsumedCalories.Location = new Point(32, 187);
            lblConsumedCalories.Name = "lblConsumedCalories";
            lblConsumedCalories.Size = new Size(171, 23);
            lblConsumedCalories.TabIndex = 9;
            lblConsumedCalories.Text = "Calorías consumidas";
            // 
            // txtConsumedCalories
            // 
            txtConsumedCalories.Location = new Point(250, 184);
            txtConsumedCalories.Name = "txtConsumedCalories";
            txtConsumedCalories.ReadOnly = true;
            txtConsumedCalories.Size = new Size(182, 27);
            txtConsumedCalories.TabIndex = 10;
            // 
            // lblCalorieGoal
            // 
            lblCalorieGoal.AutoSize = true;
            lblCalorieGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCalorieGoal.Location = new Point(32, 225);
            lblCalorieGoal.Name = "lblCalorieGoal";
            lblCalorieGoal.Size = new Size(141, 23);
            lblCalorieGoal.TabIndex = 11;
            lblCalorieGoal.Text = "Meta de calorías";
            // 
            // txtCalorieGoal
            // 
            txtCalorieGoal.Location = new Point(250, 222);
            txtCalorieGoal.Name = "txtCalorieGoal";
            txtCalorieGoal.ReadOnly = true;
            txtCalorieGoal.Size = new Size(182, 27);
            txtCalorieGoal.TabIndex = 12;
            // 
            // lblRemainingCalories
            // 
            lblRemainingCalories.AutoSize = true;
            lblRemainingCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRemainingCalories.Location = new Point(32, 263);
            lblRemainingCalories.Name = "lblRemainingCalories";
            lblRemainingCalories.Size = new Size(157, 23);
            lblRemainingCalories.TabIndex = 13;
            lblRemainingCalories.Text = "Diferencia calorías";
            // 
            // txtRemainingCalories
            // 
            txtRemainingCalories.Location = new Point(250, 260);
            txtRemainingCalories.Name = "txtRemainingCalories";
            txtRemainingCalories.ReadOnly = true;
            txtRemainingCalories.Size = new Size(182, 27);
            txtRemainingCalories.TabIndex = 14;
            // 
            // lblConsumedProtein
            // 
            lblConsumedProtein.AutoSize = true;
            lblConsumedProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConsumedProtein.Location = new Point(32, 313);
            lblConsumedProtein.Name = "lblConsumedProtein";
            lblConsumedProtein.Size = new Size(182, 23);
            lblConsumedProtein.TabIndex = 15;
            lblConsumedProtein.Text = "Proteínas consumidas";
            // 
            // txtConsumedProtein
            // 
            txtConsumedProtein.Location = new Point(250, 310);
            txtConsumedProtein.Name = "txtConsumedProtein";
            txtConsumedProtein.ReadOnly = true;
            txtConsumedProtein.Size = new Size(182, 27);
            txtConsumedProtein.TabIndex = 16;
            // 
            // lblProteinGoal
            // 
            lblProteinGoal.AutoSize = true;
            lblProteinGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProteinGoal.Location = new Point(32, 351);
            lblProteinGoal.Name = "lblProteinGoal";
            lblProteinGoal.Size = new Size(156, 23);
            lblProteinGoal.TabIndex = 17;
            lblProteinGoal.Text = "Meta de proteínas";
            // 
            // txtProteinGoal
            // 
            txtProteinGoal.Location = new Point(250, 348);
            txtProteinGoal.Name = "txtProteinGoal";
            txtProteinGoal.ReadOnly = true;
            txtProteinGoal.Size = new Size(182, 27);
            txtProteinGoal.TabIndex = 18;
            // 
            // lblRemainingProtein
            // 
            lblRemainingProtein.AutoSize = true;
            lblRemainingProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRemainingProtein.Location = new Point(32, 389);
            lblRemainingProtein.Name = "lblRemainingProtein";
            lblRemainingProtein.Size = new Size(172, 23);
            lblRemainingProtein.TabIndex = 19;
            lblRemainingProtein.Text = "Diferencia proteínas";
            // 
            // txtRemainingProtein
            // 
            txtRemainingProtein.Location = new Point(250, 386);
            txtRemainingProtein.Name = "txtRemainingProtein";
            txtRemainingProtein.ReadOnly = true;
            txtRemainingProtein.Size = new Size(182, 27);
            txtRemainingProtein.TabIndex = 20;
            // 
            // lblConsumedCarbohydrates
            // 
            lblConsumedCarbohydrates.AutoSize = true;
            lblConsumedCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConsumedCarbohydrates.Location = new Point(573, 187);
            lblConsumedCarbohydrates.Name = "lblConsumedCarbohydrates";
            lblConsumedCarbohydrates.Size = new Size(223, 23);
            lblConsumedCarbohydrates.TabIndex = 21;
            lblConsumedCarbohydrates.Text = "Carbohidratos consumidos";
            // 
            // txtConsumedCarbohydrates
            // 
            txtConsumedCarbohydrates.Location = new Point(863, 184);
            txtConsumedCarbohydrates.Name = "txtConsumedCarbohydrates";
            txtConsumedCarbohydrates.ReadOnly = true;
            txtConsumedCarbohydrates.Size = new Size(182, 27);
            txtConsumedCarbohydrates.TabIndex = 22;
            // 
            // lblCarbohydratesGoal
            // 
            lblCarbohydratesGoal.AutoSize = true;
            lblCarbohydratesGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCarbohydratesGoal.Location = new Point(573, 225);
            lblCarbohydratesGoal.Name = "lblCarbohydratesGoal";
            lblCarbohydratesGoal.Size = new Size(192, 23);
            lblCarbohydratesGoal.TabIndex = 23;
            lblCarbohydratesGoal.Text = "Meta de carbohidratos";
            // 
            // txtCarbohydratesGoal
            // 
            txtCarbohydratesGoal.Location = new Point(863, 222);
            txtCarbohydratesGoal.Name = "txtCarbohydratesGoal";
            txtCarbohydratesGoal.ReadOnly = true;
            txtCarbohydratesGoal.Size = new Size(182, 27);
            txtCarbohydratesGoal.TabIndex = 24;
            // 
            // lblRemainingCarbohydrates
            // 
            lblRemainingCarbohydrates.AutoSize = true;
            lblRemainingCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRemainingCarbohydrates.Location = new Point(573, 263);
            lblRemainingCarbohydrates.Name = "lblRemainingCarbohydrates";
            lblRemainingCarbohydrates.Size = new Size(208, 23);
            lblRemainingCarbohydrates.TabIndex = 25;
            lblRemainingCarbohydrates.Text = "Diferencia carbohidratos";
            // 
            // txtRemainingCarbohydrates
            // 
            txtRemainingCarbohydrates.Location = new Point(863, 260);
            txtRemainingCarbohydrates.Name = "txtRemainingCarbohydrates";
            txtRemainingCarbohydrates.ReadOnly = true;
            txtRemainingCarbohydrates.Size = new Size(182, 27);
            txtRemainingCarbohydrates.TabIndex = 26;
            // 
            // lblConsumedFat
            // 
            lblConsumedFat.AutoSize = true;
            lblConsumedFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConsumedFat.Location = new Point(573, 313);
            lblConsumedFat.Name = "lblConsumedFat";
            lblConsumedFat.Size = new Size(159, 23);
            lblConsumedFat.TabIndex = 27;
            lblConsumedFat.Text = "Grasas consumidas";
            // 
            // txtConsumedFat
            // 
            txtConsumedFat.Location = new Point(863, 310);
            txtConsumedFat.Name = "txtConsumedFat";
            txtConsumedFat.ReadOnly = true;
            txtConsumedFat.Size = new Size(182, 27);
            txtConsumedFat.TabIndex = 28;
            // 
            // lblFatGoal
            // 
            lblFatGoal.AutoSize = true;
            lblFatGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFatGoal.Location = new Point(573, 351);
            lblFatGoal.Name = "lblFatGoal";
            lblFatGoal.Size = new Size(131, 23);
            lblFatGoal.TabIndex = 29;
            lblFatGoal.Text = "Meta de grasas";
            // 
            // txtFatGoal
            // 
            txtFatGoal.Location = new Point(863, 348);
            txtFatGoal.Name = "txtFatGoal";
            txtFatGoal.ReadOnly = true;
            txtFatGoal.Size = new Size(182, 27);
            txtFatGoal.TabIndex = 30;
            // 
            // lblRemainingFat
            // 
            lblRemainingFat.AutoSize = true;
            lblRemainingFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRemainingFat.Location = new Point(573, 389);
            lblRemainingFat.Name = "lblRemainingFat";
            lblRemainingFat.Size = new Size(147, 23);
            lblRemainingFat.TabIndex = 31;
            lblRemainingFat.Text = "Diferencia grasas";
            // 
            // txtRemainingFat
            // 
            txtRemainingFat.Location = new Point(863, 386);
            txtRemainingFat.Name = "txtRemainingFat";
            txtRemainingFat.ReadOnly = true;
            txtRemainingFat.Size = new Size(182, 27);
            txtRemainingFat.TabIndex = 32;
            // 
            // lblRangeSection
            // 
            lblRangeSection.AutoSize = true;
            lblRangeSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRangeSection.Location = new Point(32, 452);
            lblRangeSection.Name = "lblRangeSection";
            lblRangeSection.Size = new Size(273, 25);
            lblRangeSection.TabIndex = 33;
            lblRangeSection.Text = "Consulta por rango de fechas";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(32, 495);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(90, 20);
            lblStartDate.TabIndex = 34;
            lblStartDate.Text = "Fecha inicial";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(140, 492);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 27);
            dtpStartDate.TabIndex = 35;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(332, 495);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(80, 20);
            lblEndDate.TabIndex = 36;
            lblEndDate.Text = "Fecha final";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(425, 492);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 27);
            dtpEndDate.TabIndex = 37;
            // 
            // lblRangeCalories
            // 
            lblRangeCalories.AutoSize = true;
            lblRangeCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRangeCalories.Location = new Point(32, 547);
            lblRangeCalories.Name = "lblRangeCalories";
            lblRangeCalories.Size = new Size(212, 23);
            lblRangeCalories.TabIndex = 38;
            lblRangeCalories.Text = "Total calorías del período";
            // 
            // txtRangeCalories
            // 
            txtRangeCalories.Location = new Point(250, 544);
            txtRangeCalories.Name = "txtRangeCalories";
            txtRangeCalories.ReadOnly = true;
            txtRangeCalories.Size = new Size(182, 27);
            txtRangeCalories.TabIndex = 39;
            // 
            // lblRangeProtein
            // 
            lblRangeProtein.AutoSize = true;
            lblRangeProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRangeProtein.Location = new Point(32, 585);
            lblRangeProtein.Name = "lblRangeProtein";
            lblRangeProtein.Size = new Size(227, 23);
            lblRangeProtein.TabIndex = 40;
            lblRangeProtein.Text = "Total proteínas del período";
            // 
            // txtRangeProtein
            // 
            txtRangeProtein.Location = new Point(250, 582);
            txtRangeProtein.Name = "txtRangeProtein";
            txtRangeProtein.ReadOnly = true;
            txtRangeProtein.Size = new Size(182, 27);
            txtRangeProtein.TabIndex = 41;
            // 
            // lblRangeCarbohydrates
            // 
            lblRangeCarbohydrates.AutoSize = true;
            lblRangeCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRangeCarbohydrates.Location = new Point(573, 547);
            lblRangeCarbohydrates.Name = "lblRangeCarbohydrates";
            lblRangeCarbohydrates.Size = new Size(263, 23);
            lblRangeCarbohydrates.TabIndex = 42;
            lblRangeCarbohydrates.Text = "Total carbohidratos del período";
            // 
            // txtRangeCarbohydrates
            // 
            txtRangeCarbohydrates.Location = new Point(863, 544);
            txtRangeCarbohydrates.Name = "txtRangeCarbohydrates";
            txtRangeCarbohydrates.ReadOnly = true;
            txtRangeCarbohydrates.Size = new Size(182, 27);
            txtRangeCarbohydrates.TabIndex = 43;
            // 
            // lblRangeFat
            // 
            lblRangeFat.AutoSize = true;
            lblRangeFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRangeFat.Location = new Point(573, 585);
            lblRangeFat.Name = "lblRangeFat";
            lblRangeFat.Size = new Size(202, 23);
            lblRangeFat.TabIndex = 44;
            lblRangeFat.Text = "Total grasas del período";
            // 
            // txtRangeFat
            // 
            txtRangeFat.Location = new Point(863, 582);
            txtRangeFat.Name = "txtRangeFat";
            txtRangeFat.ReadOnly = true;
            txtRangeFat.Size = new Size(182, 27);
            txtRangeFat.TabIndex = 45;
            // 
            // lblTotalDaysInRange
            // 
            lblTotalDaysInRange.AutoSize = true;
            lblTotalDaysInRange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalDaysInRange.Location = new Point(32, 623);
            lblTotalDaysInRange.Name = "lblTotalDaysInRange";
            lblTotalDaysInRange.Size = new Size(185, 23);
            lblTotalDaysInRange.TabIndex = 46;
            lblTotalDaysInRange.Text = "Días totales del rango";
            // 
            // txtTotalDaysInRange
            // 
            txtTotalDaysInRange.Location = new Point(250, 620);
            txtTotalDaysInRange.Name = "txtTotalDaysInRange";
            txtTotalDaysInRange.ReadOnly = true;
            txtTotalDaysInRange.Size = new Size(182, 27);
            txtTotalDaysInRange.TabIndex = 47;
            // 
            // lblRegisteredDays
            // 
            lblRegisteredDays.AutoSize = true;
            lblRegisteredDays.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRegisteredDays.Location = new Point(573, 623);
            lblRegisteredDays.Name = "lblRegisteredDays";
            lblRegisteredDays.Size = new Size(215, 23);
            lblRegisteredDays.TabIndex = 48;
            lblRegisteredDays.Text = "Días con menú registrado";
            // 
            // txtRegisteredDays
            // 
            txtRegisteredDays.Location = new Point(863, 620);
            txtRegisteredDays.Name = "txtRegisteredDays";
            txtRegisteredDays.ReadOnly = true;
            txtRegisteredDays.Size = new Size(182, 27);
            txtRegisteredDays.TabIndex = 49;
            // 
            // lblDaysMeetingGoal
            // 
            lblDaysMeetingGoal.AutoSize = true;
            lblDaysMeetingGoal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDaysMeetingGoal.Location = new Point(573, 661);
            lblDaysMeetingGoal.Name = "lblDaysMeetingGoal";
            lblDaysMeetingGoal.Size = new Size(240, 23);
            lblDaysMeetingGoal.TabIndex = 50;
            lblDaysMeetingGoal.Text = "Días que cumplieron la meta";
            // 
            // txtDaysMeetingGoal
            // 
            txtDaysMeetingGoal.Location = new Point(863, 658);
            txtDaysMeetingGoal.Name = "txtDaysMeetingGoal";
            txtDaysMeetingGoal.ReadOnly = true;
            txtDaysMeetingGoal.Size = new Size(182, 27);
            txtDaysMeetingGoal.TabIndex = 51;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.Location = new Point(32, 718);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(189, 23);
            lblSummary.TabIndex = 52;
            lblSummary.Text = "Resumen del progreso";
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(32, 753);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(1013, 284);
            txtSummary.TabIndex = 53;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(905, 1059);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 34);
            btnClose.TabIndex = 54;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // StatisticsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 1195);
            Controls.Add(btnClose);
            Controls.Add(txtSummary);
            Controls.Add(lblSummary);
            Controls.Add(txtDaysMeetingGoal);
            Controls.Add(lblDaysMeetingGoal);
            Controls.Add(txtRegisteredDays);
            Controls.Add(lblRegisteredDays);
            Controls.Add(txtTotalDaysInRange);
            Controls.Add(lblTotalDaysInRange);
            Controls.Add(txtRangeFat);
            Controls.Add(lblRangeFat);
            Controls.Add(txtRangeCarbohydrates);
            Controls.Add(lblRangeCarbohydrates);
            Controls.Add(txtRangeProtein);
            Controls.Add(lblRangeProtein);
            Controls.Add(txtRangeCalories);
            Controls.Add(lblRangeCalories);
            Controls.Add(dtpEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblRangeSection);
            Controls.Add(txtRemainingFat);
            Controls.Add(lblRemainingFat);
            Controls.Add(txtFatGoal);
            Controls.Add(lblFatGoal);
            Controls.Add(txtConsumedFat);
            Controls.Add(lblConsumedFat);
            Controls.Add(txtRemainingCarbohydrates);
            Controls.Add(lblRemainingCarbohydrates);
            Controls.Add(txtCarbohydratesGoal);
            Controls.Add(lblCarbohydratesGoal);
            Controls.Add(txtConsumedCarbohydrates);
            Controls.Add(lblConsumedCarbohydrates);
            Controls.Add(txtRemainingProtein);
            Controls.Add(lblRemainingProtein);
            Controls.Add(txtProteinGoal);
            Controls.Add(lblProteinGoal);
            Controls.Add(txtConsumedProtein);
            Controls.Add(lblConsumedProtein);
            Controls.Add(txtRemainingCalories);
            Controls.Add(lblRemainingCalories);
            Controls.Add(txtCalorieGoal);
            Controls.Add(lblCalorieGoal);
            Controls.Add(txtConsumedCalories);
            Controls.Add(lblConsumedCalories);
            Controls.Add(lblDailySection);
            Controls.Add(txtSelectedDate);
            Controls.Add(lblSelectedDate);
            Controls.Add(btnConsult);
            Controls.Add(dtpSelectedDate);
            Controls.Add(txtUserName);
            Controls.Add(lblDateSelector);
            Controls.Add(lblUserName);
            Controls.Add(lblTitle);
            Name = "StatisticsView";
            Text = "StatisticsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUserName;
        private Label lblDateSelector;
        private TextBox txtUserName;
        private DateTimePicker dtpSelectedDate;
        private Button btnConsult;
        private Label lblSelectedDate;
        private TextBox txtSelectedDate;
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
        private Label lblSummary;
        private TextBox txtSummary;
        private Button btnClose;
    }
}