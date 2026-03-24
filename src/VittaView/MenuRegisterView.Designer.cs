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
        /// No modifique el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDate = new Label();
            lblBreakfast = new Label();
            lblMorningSnack = new Label();
            lblLunch = new Label();
            lblAfternoonSnack = new Label();
            lblDinner = new Label();
            dtpMenuDate = new DateTimePicker();
            txtBreakfast = new TextBox();
            textMorning = new TextBox();
            txtLunch = new TextBox();
            txtAfternoonSnack = new TextBox();
            txtDinner = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblExistingMenus = new Label();
            cmbExistingMenus = new ComboBox();
            btnLoadMenu = new Button();
            btnUpdateMenu = new Button();
            btnDeleteMenu = new Button();
            lblAvailableFood = new Label();
            cmbAvailableFoods = new ComboBox();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            lblMealTime = new Label();
            cmbMealTime = new ComboBox();
            btnAddFoodToMenu = new Button();
            lblPreview = new Label();
            lstMenuPreview = new ListBox();
            lblNutritionTitle = new Label();
            lblTotalCalories = new Label();
            txtTotalCalories = new TextBox();
            lblTotalProtein = new Label();
            txtTotalProtein = new TextBox();
            lblTotalCarbohydrates = new Label();
            txtTotalCarbohydrates = new TextBox();
            lblTotalFat = new Label();
            txtTotalFat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registro de menú";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 85);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Fecha:";
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.Location = new Point(30, 145);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(77, 20);
            lblBreakfast.TabIndex = 2;
            lblBreakfast.Text = "Desayuno:";
            // 
            // lblMorningSnack
            // 
            lblMorningSnack.AutoSize = true;
            lblMorningSnack.Location = new Point(30, 193);
            lblMorningSnack.Name = "lblMorningSnack";
            lblMorningSnack.Size = new Size(132, 20);
            lblMorningSnack.TabIndex = 3;
            lblMorningSnack.Text = "Merienda mañana:";
            // 
            // lblLunch
            // 
            lblLunch.AutoSize = true;
            lblLunch.Location = new Point(30, 241);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(76, 20);
            lblLunch.TabIndex = 4;
            lblLunch.Text = "Almuerzo:";
            // 
            // lblAfternoonSnack
            // 
            lblAfternoonSnack.AutoSize = true;
            lblAfternoonSnack.Location = new Point(30, 289);
            lblAfternoonSnack.Name = "lblAfternoonSnack";
            lblAfternoonSnack.Size = new Size(114, 20);
            lblAfternoonSnack.TabIndex = 5;
            lblAfternoonSnack.Text = "Merienda tarde:";
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Location = new Point(30, 337);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(45, 20);
            lblDinner.TabIndex = 6;
            lblDinner.Text = "Cena:";
            // 
            // dtpMenuDate
            // 
            dtpMenuDate.Location = new Point(180, 82);
            dtpMenuDate.Name = "dtpMenuDate";
            dtpMenuDate.Size = new Size(280, 27);
            dtpMenuDate.TabIndex = 7;
            // 
            // txtBreakfast
            // 
            txtBreakfast.Location = new Point(180, 142);
            txtBreakfast.Name = "txtBreakfast";
            txtBreakfast.Size = new Size(300, 27);
            txtBreakfast.TabIndex = 8;
            // 
            // textMorning
            // 
            textMorning.Location = new Point(180, 190);
            textMorning.Name = "textMorning";
            textMorning.Size = new Size(300, 27);
            textMorning.TabIndex = 9;
            // 
            // txtLunch
            // 
            txtLunch.Location = new Point(180, 238);
            txtLunch.Name = "txtLunch";
            txtLunch.Size = new Size(300, 27);
            txtLunch.TabIndex = 10;
            // 
            // txtAfternoonSnack
            // 
            txtAfternoonSnack.Location = new Point(180, 286);
            txtAfternoonSnack.Name = "txtAfternoonSnack";
            txtAfternoonSnack.Size = new Size(300, 27);
            txtAfternoonSnack.TabIndex = 11;
            // 
            // txtDinner
            // 
            txtDinner.Location = new Point(180, 334);
            txtDinner.Name = "txtDinner";
            txtDinner.Size = new Size(300, 27);
            txtDinner.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 403);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 50);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar Menú";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(750, 403);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 50);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblExistingMenus
            // 
            lblExistingMenus.AutoSize = true;
            lblExistingMenus.Location = new Point(545, 28);
            lblExistingMenus.Name = "lblExistingMenus";
            lblExistingMenus.Size = new Size(124, 20);
            lblExistingMenus.TabIndex = 18;
            lblExistingMenus.Text = "Menús existentes:";
            // 
            // cmbExistingMenus
            // 
            cmbExistingMenus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExistingMenus.FormattingEnabled = true;
            cmbExistingMenus.Location = new Point(545, 51);
            cmbExistingMenus.Name = "cmbExistingMenus";
            cmbExistingMenus.Size = new Size(220, 28);
            cmbExistingMenus.TabIndex = 19;
            // 
            // btnLoadMenu
            // 
            btnLoadMenu.Location = new Point(785, 48);
            btnLoadMenu.Name = "btnLoadMenu";
            btnLoadMenu.Size = new Size(135, 34);
            btnLoadMenu.TabIndex = 20;
            btnLoadMenu.Text = "Cargar menú";
            btnLoadMenu.UseVisualStyleBackColor = true;
            btnLoadMenu.Click += btnLoadMenu_Click;
            // 
            // btnUpdateMenu
            // 
            btnUpdateMenu.Location = new Point(281, 403);
            btnUpdateMenu.Name = "btnUpdateMenu";
            btnUpdateMenu.Size = new Size(170, 50);
            btnUpdateMenu.TabIndex = 14;
            btnUpdateMenu.Text = "Actualizar menú";
            btnUpdateMenu.UseVisualStyleBackColor = true;
            btnUpdateMenu.Click += btnUpdateMenu_Click;
            // 
            // btnDeleteMenu
            // 
            btnDeleteMenu.Location = new Point(522, 403);
            btnDeleteMenu.Name = "btnDeleteMenu";
            btnDeleteMenu.Size = new Size(170, 50);
            btnDeleteMenu.TabIndex = 15;
            btnDeleteMenu.Text = "Eliminar menú";
            btnDeleteMenu.UseVisualStyleBackColor = true;
            btnDeleteMenu.Click += btnDeleteMenu_Click;
            // 
            // lblAvailableFood
            // 
            lblAvailableFood.AutoSize = true;
            lblAvailableFood.Location = new Point(545, 115);
            lblAvailableFood.Name = "lblAvailableFood";
            lblAvailableFood.Size = new Size(147, 20);
            lblAvailableFood.TabIndex = 21;
            lblAvailableFood.Text = "Alimento disponible:";
            // 
            // cmbAvailableFoods
            // 
            cmbAvailableFoods.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailableFoods.FormattingEnabled = true;
            cmbAvailableFoods.Location = new Point(545, 138);
            cmbAvailableFoods.Name = "cmbAvailableFoods";
            cmbAvailableFoods.Size = new Size(250, 28);
            cmbAvailableFoods.TabIndex = 22;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(545, 182);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 23;
            lblQuantity.Text = "Cantidad:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(545, 205);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 27);
            nudQuantity.TabIndex = 24;
            // 
            // lblMealTime
            // 
            lblMealTime.AutoSize = true;
            lblMealTime.Location = new Point(545, 248);
            lblMealTime.Name = "lblMealTime";
            lblMealTime.Size = new Size(138, 20);
            lblMealTime.TabIndex = 25;
            lblMealTime.Text = "Tiempo de comida:";
            // 
            // cmbMealTime
            // 
            cmbMealTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMealTime.FormattingEnabled = true;
            cmbMealTime.Location = new Point(545, 271);
            cmbMealTime.Name = "cmbMealTime";
            cmbMealTime.Size = new Size(250, 28);
            cmbMealTime.TabIndex = 26;
            // 
            // btnAddFoodToMenu
            // 
            btnAddFoodToMenu.Location = new Point(545, 319);
            btnAddFoodToMenu.Name = "btnAddFoodToMenu";
            btnAddFoodToMenu.Size = new Size(250, 40);
            btnAddFoodToMenu.TabIndex = 27;
            btnAddFoodToMenu.Text = "Agregar alimento al menú";
            btnAddFoodToMenu.UseVisualStyleBackColor = true;
            btnAddFoodToMenu.Click += btnAddFoodToMenu_Click;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Location = new Point(36, 520);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(126, 20);
            lblPreview.TabIndex = 28;
            lblPreview.Text = "Resumen en vista:";
            // 
            // lstMenuPreview
            // 
            lstMenuPreview.FormattingEnabled = true;
            lstMenuPreview.Location = new Point(36, 553);
            lstMenuPreview.Name = "lstMenuPreview";
            lstMenuPreview.Size = new Size(375, 104);
            lstMenuPreview.TabIndex = 29;
            // 
            // lblNutritionTitle
            // 
            lblNutritionTitle.AutoSize = true;
            lblNutritionTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNutritionTitle.Location = new Point(522, 520);
            lblNutritionTitle.Name = "lblNutritionTitle";
            lblNutritionTitle.Size = new Size(173, 23);
            lblNutritionTitle.TabIndex = 30;
            lblNutritionTitle.Text = "Resumen nutricional";
            // 
            // lblTotalCalories
            // 
            lblTotalCalories.AutoSize = true;
            lblTotalCalories.Location = new Point(522, 555);
            lblTotalCalories.Name = "lblTotalCalories";
            lblTotalCalories.Size = new Size(65, 20);
            lblTotalCalories.TabIndex = 31;
            lblTotalCalories.Text = "Calorías:";
            // 
            // txtTotalCalories
            // 
            txtTotalCalories.Location = new Point(627, 552);
            txtTotalCalories.Name = "txtTotalCalories";
            txtTotalCalories.Size = new Size(100, 27);
            txtTotalCalories.TabIndex = 32;
            // 
            // lblTotalProtein
            // 
            lblTotalProtein.AutoSize = true;
            lblTotalProtein.Location = new Point(747, 555);
            lblTotalProtein.Name = "lblTotalProtein";
            lblTotalProtein.Size = new Size(73, 20);
            lblTotalProtein.TabIndex = 33;
            lblTotalProtein.Text = "Proteínas:";
            // 
            // txtTotalProtein
            // 
            txtTotalProtein.Location = new Point(822, 552);
            txtTotalProtein.Name = "txtTotalProtein";
            txtTotalProtein.Size = new Size(100, 27);
            txtTotalProtein.TabIndex = 34;
            // 
            // lblTotalCarbohydrates
            // 
            lblTotalCarbohydrates.AutoSize = true;
            lblTotalCarbohydrates.Location = new Point(522, 590);
            lblTotalCarbohydrates.Name = "lblTotalCarbohydrates";
            lblTotalCarbohydrates.Size = new Size(106, 20);
            lblTotalCarbohydrates.TabIndex = 35;
            lblTotalCarbohydrates.Text = "Carbohidratos:";
            // 
            // txtTotalCarbohydrates
            // 
            txtTotalCarbohydrates.Location = new Point(627, 587);
            txtTotalCarbohydrates.Name = "txtTotalCarbohydrates";
            txtTotalCarbohydrates.Size = new Size(100, 27);
            txtTotalCarbohydrates.TabIndex = 36;
            // 
            // lblTotalFat
            // 
            lblTotalFat.AutoSize = true;
            lblTotalFat.Location = new Point(747, 590);
            lblTotalFat.Name = "lblTotalFat";
            lblTotalFat.Size = new Size(55, 20);
            lblTotalFat.TabIndex = 37;
            lblTotalFat.Text = "Grasas:";
            // 
            // txtTotalFat
            // 
            txtTotalFat.Location = new Point(822, 587);
            txtTotalFat.Name = "txtTotalFat";
            txtTotalFat.Size = new Size(100, 27);
            txtTotalFat.TabIndex = 38;
            // 
            // MenuRegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 700);
            Controls.Add(txtTotalFat);
            Controls.Add(lblTotalFat);
            Controls.Add(txtTotalCarbohydrates);
            Controls.Add(lblTotalCarbohydrates);
            Controls.Add(txtTotalProtein);
            Controls.Add(lblTotalProtein);
            Controls.Add(txtTotalCalories);
            Controls.Add(lblTotalCalories);
            Controls.Add(lblNutritionTitle);
            Controls.Add(lstMenuPreview);
            Controls.Add(lblPreview);
            Controls.Add(btnAddFoodToMenu);
            Controls.Add(cmbMealTime);
            Controls.Add(lblMealTime);
            Controls.Add(nudQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbAvailableFoods);
            Controls.Add(lblAvailableFood);
            Controls.Add(btnDeleteMenu);
            Controls.Add(btnUpdateMenu);
            Controls.Add(btnLoadMenu);
            Controls.Add(cmbExistingMenus);
            Controls.Add(lblExistingMenus);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDinner);
            Controls.Add(txtAfternoonSnack);
            Controls.Add(txtLunch);
            Controls.Add(textMorning);
            Controls.Add(txtBreakfast);
            Controls.Add(dtpMenuDate);
            Controls.Add(lblDinner);
            Controls.Add(lblAfternoonSnack);
            Controls.Add(lblLunch);
            Controls.Add(lblMorningSnack);
            Controls.Add(lblBreakfast);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Name = "MenuRegisterView";
            Text = "MenuRegisterView";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDate;
        private Label lblBreakfast;
        private Label lblMorningSnack;
        private Label lblLunch;
        private Label lblAfternoonSnack;
        private Label lblDinner;
        private DateTimePicker dtpMenuDate;
        private TextBox txtBreakfast;
        private TextBox textMorning;
        private TextBox txtLunch;
        private TextBox txtAfternoonSnack;
        private TextBox txtDinner;
        private Button btnSave;
        private Button btnCancel;
        private Label lblExistingMenus;
        private ComboBox cmbExistingMenus;
        private Button btnLoadMenu;
        private Button btnUpdateMenu;
        private Button btnDeleteMenu;
        private Label lblAvailableFood;
        private ComboBox cmbAvailableFoods;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Label lblMealTime;
        private ComboBox cmbMealTime;
        private Button btnAddFoodToMenu;
        private Label lblPreview;
        private ListBox lstMenuPreview;
        private Label lblNutritionTitle;
        private Label lblTotalCalories;
        private TextBox txtTotalCalories;
        private Label lblTotalProtein;
        private TextBox txtTotalProtein;
        private Label lblTotalCarbohydrates;
        private TextBox txtTotalCarbohydrates;
        private Label lblTotalFat;
        private TextBox txtTotalFat;
    }
}