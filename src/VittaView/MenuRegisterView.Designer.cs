namespace VittaView
{
    partial class MenuRegisterView
    {
        /// <summary>
        /// Variable requerida por el diseñador.
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
        /// Método requerido para compatibilidad con el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlMenuData = new Panel();
            lblMenuDataTitle = new Label();
            lblDate = new Label();
            dtpMenuDate = new DateTimePicker();
            lblBreakfast = new Label();
            txtBreakfast = new TextBox();
            lblMorningSnack = new Label();
            textMorning = new TextBox();
            lblLunch = new Label();
            txtLunch = new TextBox();
            lblAfternoonSnack = new Label();
            txtAfternoonSnack = new TextBox();
            lblDinner = new Label();
            txtDinner = new TextBox();
            pnlMenuManagement = new Panel();
            lblManagementTitle = new Label();
            lblExistingMenus = new Label();
            cmbExistingMenus = new ComboBox();
            btnLoadMenu = new Button();
            lblAvailableFood = new Label();
            cmbAvailableFoods = new ComboBox();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            lblMealTime = new Label();
            cmbMealTime = new ComboBox();
            btnAddFoodToMenu = new Button();
            btnRemoveFoodFromMenu = new Button();
            pnlNutrition = new Panel();
            lblNutritionTitle = new Label();
            lblTotalCalories = new Label();
            txtTotalCalories = new TextBox();
            lblTotalProtein = new Label();
            txtTotalProtein = new TextBox();
            lblTotalCarbohydrates = new Label();
            txtTotalCarbohydrates = new TextBox();
            lblTotalFat = new Label();
            txtTotalFat = new TextBox();
            btnSave = new Button();
            btnUpdateMenu = new Button();
            btnDeleteMenu = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlMenuData.SuspendLayout();
            pnlMenuManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlNutrition.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1180, 60);
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
            lblTitle.Location = new Point(398, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Registro de menú";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(226, 145);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(765, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Crea, actualiza y organiza menús diarios con alimentos del sistema y resumen nutricional.";
            // 
            // pnlMenuData
            // 
            pnlMenuData.BackColor = Color.White;
            pnlMenuData.BorderStyle = BorderStyle.FixedSingle;
            pnlMenuData.Controls.Add(lblMenuDataTitle);
            pnlMenuData.Controls.Add(lblDate);
            pnlMenuData.Controls.Add(dtpMenuDate);
            pnlMenuData.Controls.Add(lblBreakfast);
            pnlMenuData.Controls.Add(txtBreakfast);
            pnlMenuData.Controls.Add(lblMorningSnack);
            pnlMenuData.Controls.Add(textMorning);
            pnlMenuData.Controls.Add(lblLunch);
            pnlMenuData.Controls.Add(txtLunch);
            pnlMenuData.Controls.Add(lblAfternoonSnack);
            pnlMenuData.Controls.Add(txtAfternoonSnack);
            pnlMenuData.Controls.Add(lblDinner);
            pnlMenuData.Controls.Add(txtDinner);
            pnlMenuData.Location = new Point(36, 190);
            pnlMenuData.Name = "pnlMenuData";
            pnlMenuData.Size = new Size(540, 558);
            pnlMenuData.TabIndex = 3;
            // 
            // lblMenuDataTitle
            // 
            lblMenuDataTitle.AutoSize = true;
            lblMenuDataTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuDataTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblMenuDataTitle.Location = new Point(189, 18);
            lblMenuDataTitle.Name = "lblMenuDataTitle";
            lblMenuDataTitle.Size = new Size(156, 32);
            lblMenuDataTitle.TabIndex = 0;
            lblMenuDataTitle.Text = "Menú actual";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(66, 66, 66);
            lblDate.Location = new Point(24, 74);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(55, 23);
            lblDate.TabIndex = 1;
            lblDate.Text = "Fecha";
            // 
            // dtpMenuDate
            // 
            dtpMenuDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMenuDate.Location = new Point(155, 71);
            dtpMenuDate.Name = "dtpMenuDate";
            dtpMenuDate.Size = new Size(350, 30);
            dtpMenuDate.TabIndex = 2;
            dtpMenuDate.ValueChanged += dtpMenuDate_ValueChanged;
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreakfast.ForeColor = Color.FromArgb(66, 66, 66);
            lblBreakfast.Location = new Point(24, 164);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(87, 23);
            lblBreakfast.TabIndex = 3;
            lblBreakfast.Text = "Desayuno";
            // 
            // txtBreakfast
            // 
            txtBreakfast.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBreakfast.Location = new Point(154, 120);
            txtBreakfast.Multiline = true;
            txtBreakfast.Name = "txtBreakfast";
            txtBreakfast.ReadOnly = true;
            txtBreakfast.ScrollBars = ScrollBars.Vertical;
            txtBreakfast.Size = new Size(350, 67);
            txtBreakfast.TabIndex = 4;
            txtBreakfast.TabStop = false;
            txtBreakfast.WordWrap = false;
            // 
            // lblMorningSnack
            // 
            lblMorningSnack.AutoSize = true;
            lblMorningSnack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMorningSnack.ForeColor = Color.FromArgb(66, 66, 66);
            lblMorningSnack.Location = new Point(24, 248);
            lblMorningSnack.Name = "lblMorningSnack";
            lblMorningSnack.Size = new Size(73, 23);
            lblMorningSnack.TabIndex = 5;
            lblMorningSnack.Text = "Mañana";
            // 
            // textMorning
            // 
            textMorning.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMorning.Location = new Point(154, 207);
            textMorning.Multiline = true;
            textMorning.Name = "textMorning";
            textMorning.ReadOnly = true;
            textMorning.ScrollBars = ScrollBars.Vertical;
            textMorning.Size = new Size(350, 64);
            textMorning.TabIndex = 6;
            textMorning.TabStop = false;
            textMorning.WordWrap = false;
            // 
            // lblLunch
            // 
            lblLunch.AutoSize = true;
            lblLunch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLunch.ForeColor = Color.FromArgb(66, 66, 66);
            lblLunch.Location = new Point(24, 328);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(87, 23);
            lblLunch.TabIndex = 7;
            lblLunch.Text = "Almuerzo";
            // 
            // txtLunch
            // 
            txtLunch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLunch.Location = new Point(155, 287);
            txtLunch.Multiline = true;
            txtLunch.Name = "txtLunch";
            txtLunch.ReadOnly = true;
            txtLunch.ScrollBars = ScrollBars.Vertical;
            txtLunch.Size = new Size(350, 64);
            txtLunch.TabIndex = 8;
            txtLunch.TabStop = false;
            txtLunch.WordWrap = false;
            // 
            // lblAfternoonSnack
            // 
            lblAfternoonSnack.AutoSize = true;
            lblAfternoonSnack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfternoonSnack.ForeColor = Color.FromArgb(66, 66, 66);
            lblAfternoonSnack.Location = new Point(24, 413);
            lblAfternoonSnack.Name = "lblAfternoonSnack";
            lblAfternoonSnack.Size = new Size(55, 23);
            lblAfternoonSnack.TabIndex = 9;
            lblAfternoonSnack.Text = "Tarde";
            // 
            // txtAfternoonSnack
            // 
            txtAfternoonSnack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAfternoonSnack.Location = new Point(154, 374);
            txtAfternoonSnack.Multiline = true;
            txtAfternoonSnack.Name = "txtAfternoonSnack";
            txtAfternoonSnack.ReadOnly = true;
            txtAfternoonSnack.ScrollBars = ScrollBars.Vertical;
            txtAfternoonSnack.Size = new Size(350, 62);
            txtAfternoonSnack.TabIndex = 10;
            txtAfternoonSnack.TabStop = false;
            txtAfternoonSnack.WordWrap = false;
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDinner.ForeColor = Color.FromArgb(66, 66, 66);
            lblDinner.Location = new Point(24, 500);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(49, 23);
            lblDinner.TabIndex = 11;
            lblDinner.Text = "Cena";
            // 
            // txtDinner
            // 
            txtDinner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDinner.Location = new Point(155, 461);
            txtDinner.Multiline = true;
            txtDinner.Name = "txtDinner";
            txtDinner.ReadOnly = true;
            txtDinner.ScrollBars = ScrollBars.Vertical;
            txtDinner.Size = new Size(350, 62);
            txtDinner.TabIndex = 12;
            txtDinner.TabStop = false;
            txtDinner.WordWrap = false;
            // 
            // pnlMenuManagement
            // 
            pnlMenuManagement.BackColor = Color.White;
            pnlMenuManagement.BorderStyle = BorderStyle.FixedSingle;
            pnlMenuManagement.Controls.Add(lblManagementTitle);
            pnlMenuManagement.Controls.Add(lblExistingMenus);
            pnlMenuManagement.Controls.Add(cmbExistingMenus);
            pnlMenuManagement.Controls.Add(btnLoadMenu);
            pnlMenuManagement.Controls.Add(lblAvailableFood);
            pnlMenuManagement.Controls.Add(cmbAvailableFoods);
            pnlMenuManagement.Controls.Add(lblQuantity);
            pnlMenuManagement.Controls.Add(nudQuantity);
            pnlMenuManagement.Controls.Add(lblMealTime);
            pnlMenuManagement.Controls.Add(cmbMealTime);
            pnlMenuManagement.Controls.Add(btnAddFoodToMenu);
            pnlMenuManagement.Controls.Add(btnRemoveFoodFromMenu);
            pnlMenuManagement.Location = new Point(604, 190);
            pnlMenuManagement.Name = "pnlMenuManagement";
            pnlMenuManagement.Size = new Size(540, 360);
            pnlMenuManagement.TabIndex = 4;
            // 
            // lblManagementTitle
            // 
            lblManagementTitle.AutoSize = true;
            lblManagementTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagementTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblManagementTitle.Location = new Point(156, 18);
            lblManagementTitle.Name = "lblManagementTitle";
            lblManagementTitle.Size = new Size(215, 32);
            lblManagementTitle.TabIndex = 0;
            lblManagementTitle.Text = "Gestión del menú";
            // 
            // lblExistingMenus
            // 
            lblExistingMenus.AutoSize = true;
            lblExistingMenus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistingMenus.ForeColor = Color.FromArgb(66, 66, 66);
            lblExistingMenus.Location = new Point(24, 77);
            lblExistingMenus.Name = "lblExistingMenus";
            lblExistingMenus.Size = new Size(146, 23);
            lblExistingMenus.TabIndex = 1;
            lblExistingMenus.Text = "Menús existentes";
            // 
            // cmbExistingMenus
            // 
            cmbExistingMenus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExistingMenus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbExistingMenus.FormattingEnabled = true;
            cmbExistingMenus.Location = new Point(24, 103);
            cmbExistingMenus.Name = "cmbExistingMenus";
            cmbExistingMenus.Size = new Size(302, 31);
            cmbExistingMenus.TabIndex = 2;
            // 
            // btnLoadMenu
            // 
            btnLoadMenu.BackColor = Color.White;
            btnLoadMenu.FlatStyle = FlatStyle.Flat;
            btnLoadMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadMenu.ForeColor = Color.FromArgb(46, 125, 50);
            btnLoadMenu.Location = new Point(349, 100);
            btnLoadMenu.Name = "btnLoadMenu";
            btnLoadMenu.Size = new Size(157, 38);
            btnLoadMenu.TabIndex = 3;
            btnLoadMenu.Text = "Cargar";
            btnLoadMenu.UseVisualStyleBackColor = false;
            btnLoadMenu.Click += btnLoadMenu_Click;
            // 
            // lblAvailableFood
            // 
            lblAvailableFood.AutoSize = true;
            lblAvailableFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableFood.ForeColor = Color.FromArgb(66, 66, 66);
            lblAvailableFood.Location = new Point(24, 164);
            lblAvailableFood.Name = "lblAvailableFood";
            lblAvailableFood.Size = new Size(84, 23);
            lblAvailableFood.TabIndex = 4;
            lblAvailableFood.Text = "Alimento";
            // 
            // cmbAvailableFoods
            // 
            cmbAvailableFoods.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailableFoods.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAvailableFoods.FormattingEnabled = true;
            cmbAvailableFoods.Location = new Point(24, 190);
            cmbAvailableFoods.Name = "cmbAvailableFoods";
            cmbAvailableFoods.Size = new Size(482, 31);
            cmbAvailableFoods.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.FromArgb(66, 66, 66);
            lblQuantity.Location = new Point(24, 238);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(83, 23);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Cantidad";
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(24, 264);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 30);
            nudQuantity.TabIndex = 7;
            // 
            // lblMealTime
            // 
            lblMealTime.AutoSize = true;
            lblMealTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMealTime.ForeColor = Color.FromArgb(66, 66, 66);
            lblMealTime.Location = new Point(180, 238);
            lblMealTime.Name = "lblMealTime";
            lblMealTime.Size = new Size(160, 23);
            lblMealTime.TabIndex = 8;
            lblMealTime.Text = "Tiempo de comida";
            // 
            // cmbMealTime
            // 
            cmbMealTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMealTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMealTime.FormattingEnabled = true;
            cmbMealTime.Location = new Point(180, 264);
            cmbMealTime.Name = "cmbMealTime";
            cmbMealTime.Size = new Size(326, 31);
            cmbMealTime.TabIndex = 9;
            // 
            // btnAddFoodToMenu
            // 
            btnAddFoodToMenu.BackColor = Color.FromArgb(46, 125, 50);
            btnAddFoodToMenu.FlatStyle = FlatStyle.Flat;
            btnAddFoodToMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFoodToMenu.ForeColor = Color.White;
            btnAddFoodToMenu.Location = new Point(24, 309);
            btnAddFoodToMenu.Name = "btnAddFoodToMenu";
            btnAddFoodToMenu.Size = new Size(220, 42);
            btnAddFoodToMenu.TabIndex = 10;
            btnAddFoodToMenu.Text = "Agregar alimento";
            btnAddFoodToMenu.UseVisualStyleBackColor = false;
            btnAddFoodToMenu.Click += btnAddFoodToMenu_Click;
            // 
            // btnRemoveFoodFromMenu
            // 
            btnRemoveFoodFromMenu.BackColor = Color.White;
            btnRemoveFoodFromMenu.FlatStyle = FlatStyle.Flat;
            btnRemoveFoodFromMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveFoodFromMenu.ForeColor = Color.FromArgb(198, 40, 40);
            btnRemoveFoodFromMenu.Location = new Point(286, 309);
            btnRemoveFoodFromMenu.Name = "btnRemoveFoodFromMenu";
            btnRemoveFoodFromMenu.Size = new Size(220, 42);
            btnRemoveFoodFromMenu.TabIndex = 11;
            btnRemoveFoodFromMenu.Text = "Quitar alimento";
            btnRemoveFoodFromMenu.UseVisualStyleBackColor = false;
            btnRemoveFoodFromMenu.Click += btnRemoveFoodFromMenu_Click;
            // 
            // pnlNutrition
            // 
            pnlNutrition.BackColor = Color.White;
            pnlNutrition.BorderStyle = BorderStyle.FixedSingle;
            pnlNutrition.Controls.Add(lblNutritionTitle);
            pnlNutrition.Controls.Add(lblTotalCalories);
            pnlNutrition.Controls.Add(txtTotalCalories);
            pnlNutrition.Controls.Add(lblTotalProtein);
            pnlNutrition.Controls.Add(txtTotalProtein);
            pnlNutrition.Controls.Add(lblTotalCarbohydrates);
            pnlNutrition.Controls.Add(txtTotalCarbohydrates);
            pnlNutrition.Controls.Add(lblTotalFat);
            pnlNutrition.Controls.Add(txtTotalFat);
            pnlNutrition.Location = new Point(604, 568);
            pnlNutrition.Name = "pnlNutrition";
            pnlNutrition.Size = new Size(540, 180);
            pnlNutrition.TabIndex = 5;
            // 
            // lblNutritionTitle
            // 
            lblNutritionTitle.AutoSize = true;
            lblNutritionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNutritionTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblNutritionTitle.Location = new Point(144, 15);
            lblNutritionTitle.Name = "lblNutritionTitle";
            lblNutritionTitle.Size = new Size(250, 32);
            lblNutritionTitle.TabIndex = 0;
            lblNutritionTitle.Text = "Resumen nutricional";
            // 
            // lblTotalCalories
            // 
            lblTotalCalories.AutoSize = true;
            lblTotalCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblTotalCalories.Location = new Point(24, 75);
            lblTotalCalories.Name = "lblTotalCalories";
            lblTotalCalories.Size = new Size(73, 23);
            lblTotalCalories.TabIndex = 1;
            lblTotalCalories.Text = "Calorías";
            // 
            // txtTotalCalories
            // 
            txtTotalCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalCalories.Location = new Point(140, 72);
            txtTotalCalories.Name = "txtTotalCalories";
            txtTotalCalories.ReadOnly = true;
            txtTotalCalories.Size = new Size(110, 30);
            txtTotalCalories.TabIndex = 2;
            // 
            // lblTotalProtein
            // 
            lblTotalProtein.AutoSize = true;
            lblTotalProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblTotalProtein.Location = new Point(296, 75);
            lblTotalProtein.Name = "lblTotalProtein";
            lblTotalProtein.Size = new Size(84, 23);
            lblTotalProtein.TabIndex = 3;
            lblTotalProtein.Text = "Proteínas";
            // 
            // txtTotalProtein
            // 
            txtTotalProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalProtein.Location = new Point(396, 72);
            txtTotalProtein.Name = "txtTotalProtein";
            txtTotalProtein.ReadOnly = true;
            txtTotalProtein.Size = new Size(110, 30);
            txtTotalProtein.TabIndex = 4;
            // 
            // lblTotalCarbohydrates
            // 
            lblTotalCarbohydrates.AutoSize = true;
            lblTotalCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblTotalCarbohydrates.Location = new Point(24, 118);
            lblTotalCarbohydrates.Name = "lblTotalCarbohydrates";
            lblTotalCarbohydrates.Size = new Size(124, 23);
            lblTotalCarbohydrates.TabIndex = 5;
            lblTotalCarbohydrates.Text = "Carbohidratos";
            // 
            // txtTotalCarbohydrates
            // 
            txtTotalCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalCarbohydrates.Location = new Point(154, 115);
            txtTotalCarbohydrates.Name = "txtTotalCarbohydrates";
            txtTotalCarbohydrates.ReadOnly = true;
            txtTotalCarbohydrates.Size = new Size(96, 30);
            txtTotalCarbohydrates.TabIndex = 6;
            // 
            // lblTotalFat
            // 
            lblTotalFat.AutoSize = true;
            lblTotalFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblTotalFat.Location = new Point(296, 118);
            lblTotalFat.Name = "lblTotalFat";
            lblTotalFat.Size = new Size(61, 23);
            lblTotalFat.TabIndex = 7;
            lblTotalFat.Text = "Grasas";
            // 
            // txtTotalFat
            // 
            txtTotalFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalFat.Location = new Point(396, 115);
            txtTotalFat.Name = "txtTotalFat";
            txtTotalFat.ReadOnly = true;
            txtTotalFat.Size = new Size(110, 30);
            txtTotalFat.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(36, 766);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(261, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar menú";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnUpdateMenu
            // 
            btnUpdateMenu.BackColor = Color.White;
            btnUpdateMenu.FlatStyle = FlatStyle.Flat;
            btnUpdateMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateMenu.ForeColor = Color.FromArgb(46, 125, 50);
            btnUpdateMenu.Location = new Point(315, 766);
            btnUpdateMenu.Name = "btnUpdateMenu";
            btnUpdateMenu.Size = new Size(261, 44);
            btnUpdateMenu.TabIndex = 7;
            btnUpdateMenu.Text = "Actualizar menú";
            btnUpdateMenu.UseVisualStyleBackColor = false;
            btnUpdateMenu.Click += btnUpdateMenu_Click;
            // 
            // btnDeleteMenu
            // 
            btnDeleteMenu.BackColor = Color.White;
            btnDeleteMenu.FlatStyle = FlatStyle.Flat;
            btnDeleteMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteMenu.ForeColor = Color.FromArgb(198, 40, 40);
            btnDeleteMenu.Location = new Point(604, 766);
            btnDeleteMenu.Name = "btnDeleteMenu";
            btnDeleteMenu.Size = new Size(261, 44);
            btnDeleteMenu.TabIndex = 8;
            btnDeleteMenu.Text = "Eliminar menú";
            btnDeleteMenu.UseVisualStyleBackColor = false;
            btnDeleteMenu.Click += btnDeleteMenu_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(46, 125, 50);
            btnCancel.Location = new Point(883, 766);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(261, 44);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // MenuRegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1180, 835);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteMenu);
            Controls.Add(btnUpdateMenu);
            Controls.Add(btnSave);
            Controls.Add(pnlNutrition);
            Controls.Add(pnlMenuManagement);
            Controls.Add(pnlMenuData);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuRegisterView";
            Text = "Vitta - Registro de menú";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenuData.ResumeLayout(false);
            pnlMenuData.PerformLayout();
            pnlMenuManagement.ResumeLayout(false);
            pnlMenuManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlNutrition.ResumeLayout(false);
            pnlNutrition.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlMenuData;
        private System.Windows.Forms.Label lblMenuDataTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpMenuDate;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.TextBox txtBreakfast;
        private System.Windows.Forms.Label lblMorningSnack;
        private System.Windows.Forms.TextBox textMorning;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.Label lblAfternoonSnack;
        private System.Windows.Forms.TextBox txtAfternoonSnack;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Panel pnlMenuManagement;
        private System.Windows.Forms.Label lblManagementTitle;
        private System.Windows.Forms.Label lblExistingMenus;
        private System.Windows.Forms.ComboBox cmbExistingMenus;
        private System.Windows.Forms.Button btnLoadMenu;
        private System.Windows.Forms.Label lblAvailableFood;
        private System.Windows.Forms.ComboBox cmbAvailableFoods;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblMealTime;
        private System.Windows.Forms.ComboBox cmbMealTime;
        private System.Windows.Forms.Button btnAddFoodToMenu;
        private System.Windows.Forms.Button btnRemoveFoodFromMenu;
        private System.Windows.Forms.Panel pnlNutrition;
        private System.Windows.Forms.Label lblNutritionTitle;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.Label lblTotalProtein;
        private System.Windows.Forms.TextBox txtTotalProtein;
        private System.Windows.Forms.Label lblTotalCarbohydrates;
        private System.Windows.Forms.TextBox txtTotalCarbohydrates;
        private System.Windows.Forms.Label lblTotalFat;
        private System.Windows.Forms.TextBox txtTotalFat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdateMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnCancel;
    }
}