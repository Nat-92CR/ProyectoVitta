namespace VittaView
{
    partial class FoodConsultView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearchFood = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            btnClose = new Button();
            dgvFoods = new DataGridView();
            btnDelete = new Button();
            lblEditName = new Label();
            lblEditCalories = new Label();
            lblEditProtein = new Label();
            lblEditCarbohydrates = new Label();
            lblEditFat = new Label();
            txtEditName = new TextBox();
            txtEditCalories = new TextBox();
            txtEditProtein = new TextBox();
            txtEditCarbohydrates = new TextBox();
            txtEditFat = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F);
            lblTitle.Location = new Point(97, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Consulta de alimentos";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(97, 135);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(118, 20);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Buscar alimento:";
            // 
            // txtSearchFood
            // 
            txtSearchFood.Location = new Point(256, 132);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(413, 27);
            txtSearchFood.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(97, 178);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(252, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(414, 178);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(255, 46);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Mostrar todos";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(127, 849);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(502, 46);
            btnClose.TabIndex = 5;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvFoods
            // 
            dgvFoods.AllowUserToAddRows = false;
            dgvFoods.AllowUserToDeleteRows = false;
            dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Location = new Point(97, 252);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(572, 197);
            dgvFoods.TabIndex = 6;
            dgvFoods.CellClick += dgvFoods_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(127, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(502, 46);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblEditName
            // 
            lblEditName.AutoSize = true;
            lblEditName.Location = new Point(97, 560);
            lblEditName.Name = "lblEditName";
            lblEditName.Size = new Size(67, 20);
            lblEditName.TabIndex = 8;
            lblEditName.Text = "Nombre:";
            // 
            // lblEditCalories
            // 
            lblEditCalories.AutoSize = true;
            lblEditCalories.Location = new Point(97, 602);
            lblEditCalories.Name = "lblEditCalories";
            lblEditCalories.Size = new Size(65, 20);
            lblEditCalories.TabIndex = 9;
            lblEditCalories.Text = "Calorías:";
            // 
            // lblEditProtein
            // 
            lblEditProtein.AutoSize = true;
            lblEditProtein.Location = new Point(97, 644);
            lblEditProtein.Name = "lblEditProtein";
            lblEditProtein.Size = new Size(73, 20);
            lblEditProtein.TabIndex = 10;
            lblEditProtein.Text = "Proteínas:";
            // 
            // lblEditCarbohydrates
            // 
            lblEditCarbohydrates.AutoSize = true;
            lblEditCarbohydrates.Location = new Point(97, 681);
            lblEditCarbohydrates.Name = "lblEditCarbohydrates";
            lblEditCarbohydrates.Size = new Size(103, 20);
            lblEditCarbohydrates.TabIndex = 11;
            lblEditCarbohydrates.Text = "Carbohidratos";
            // 
            // lblEditFat
            // 
            lblEditFat.AutoSize = true;
            lblEditFat.Location = new Point(97, 727);
            lblEditFat.Name = "lblEditFat";
            lblEditFat.Size = new Size(55, 20);
            lblEditFat.TabIndex = 12;
            lblEditFat.Text = "Grasas:";
            // 
            // txtEditName
            // 
            txtEditName.Location = new Point(256, 553);
            txtEditName.Name = "txtEditName";
            txtEditName.ReadOnly = true;
            txtEditName.Size = new Size(413, 27);
            txtEditName.TabIndex = 13;
            // 
            // txtEditCalories
            // 
            txtEditCalories.Location = new Point(256, 595);
            txtEditCalories.Name = "txtEditCalories";
            txtEditCalories.Size = new Size(413, 27);
            txtEditCalories.TabIndex = 14;
            // 
            // txtEditProtein
            // 
            txtEditProtein.Location = new Point(256, 637);
            txtEditProtein.Name = "txtEditProtein";
            txtEditProtein.Size = new Size(413, 27);
            txtEditProtein.TabIndex = 15;
            // 
            // txtEditCarbohydrates
            // 
            txtEditCarbohydrates.Location = new Point(256, 674);
            txtEditCarbohydrates.Name = "txtEditCarbohydrates";
            txtEditCarbohydrates.Size = new Size(413, 27);
            txtEditCarbohydrates.TabIndex = 16;
            // 
            // txtEditFat
            // 
            txtEditFat.Location = new Point(256, 720);
            txtEditFat.Name = "txtEditFat";
            txtEditFat.Size = new Size(413, 27);
            txtEditFat.TabIndex = 17;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(127, 785);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(502, 46);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Guardar Cambios";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FoodConsultView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 981);
            Controls.Add(btnEdit);
            Controls.Add(txtEditFat);
            Controls.Add(txtEditCarbohydrates);
            Controls.Add(txtEditProtein);
            Controls.Add(txtEditCalories);
            Controls.Add(txtEditName);
            Controls.Add(lblEditFat);
            Controls.Add(lblEditCarbohydrates);
            Controls.Add(lblEditProtein);
            Controls.Add(lblEditCalories);
            Controls.Add(lblEditName);
            Controls.Add(btnDelete);
            Controls.Add(dgvFoods);
            Controls.Add(btnClose);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchFood);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            Name = "FoodConsultView";
            Text = "FoodConsultView";
            Load += FoodConsultView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearchFood;
        private Button btnSearch;
        private Button btnShowAll;
        private Button btnClose;
        private DataGridView dgvFoods;
        private Button btnDelete;
        private Label lblEditName;
        private Label lblEditCalories;
        private Label lblEditProtein;
        private Label lblEditCarbohydrates;
        private Label lblEditFat;
        private TextBox txtEditName;
        private TextBox txtEditCalories;
        private TextBox txtEditProtein;
        private TextBox txtEditCarbohydrates;
        private TextBox txtEditFat;
        private Button btnEdit;
    }
}