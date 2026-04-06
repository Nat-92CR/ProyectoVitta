namespace VittaView
{
    partial class FoodConsultView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlSearchCard = new Panel();
            lblSearchCardTitle = new Label();
            lblSearch = new Label();
            txtSearchFood = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgvFoods = new DataGridView();
            btnDelete = new Button();
            pnlEditCard = new Panel();
            lblEditCardTitle = new Label();
            lblEditName = new Label();
            txtEditName = new TextBox();
            lblEditCalories = new Label();
            txtEditCalories = new TextBox();
            lblEditProtein = new Label();
            txtEditProtein = new TextBox();
            lblEditCarbohydrates = new Label();
            txtEditCarbohydrates = new TextBox();
            lblEditFat = new Label();
            txtEditFat = new TextBox();
            btnEdit = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlSearchCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            pnlEditCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(983, 60);
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
            lblTitle.Location = new Point(258, 78);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Consulta de alimentos";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(155, 140);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(640, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Busca, visualiza, elimina y actualiza los alimentos registrados en el sistema.";
            // 
            // pnlSearchCard
            // 
            pnlSearchCard.BackColor = Color.White;
            pnlSearchCard.BorderStyle = BorderStyle.FixedSingle;
            pnlSearchCard.Controls.Add(lblSearchCardTitle);
            pnlSearchCard.Controls.Add(lblSearch);
            pnlSearchCard.Controls.Add(txtSearchFood);
            pnlSearchCard.Controls.Add(btnSearch);
            pnlSearchCard.Controls.Add(btnShowAll);
            pnlSearchCard.Controls.Add(dgvFoods);
            pnlSearchCard.Controls.Add(btnDelete);
            pnlSearchCard.Location = new Point(55, 185);
            pnlSearchCard.Name = "pnlSearchCard";
            pnlSearchCard.Size = new Size(870, 387);
            pnlSearchCard.TabIndex = 3;
            // 
            // lblSearchCardTitle
            // 
            lblSearchCardTitle.AutoSize = true;
            lblSearchCardTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchCardTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblSearchCardTitle.Location = new Point(315, 18);
            lblSearchCardTitle.Name = "lblSearchCardTitle";
            lblSearchCardTitle.Size = new Size(230, 32);
            lblSearchCardTitle.TabIndex = 0;
            lblSearchCardTitle.Text = "Búsqueda y listado";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(66, 66, 66);
            lblSearch.Location = new Point(48, 70);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(138, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Buscar alimento";
            // 
            // txtSearchFood
            // 
            txtSearchFood.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchFood.Location = new Point(48, 96);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(470, 30);
            txtSearchFood.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(46, 125, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(540, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.White;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.FromArgb(46, 125, 50);
            btnShowAll.Location = new Point(680, 93);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(140, 36);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Mostrar todos";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvFoods
            // 
            dgvFoods.AllowUserToAddRows = false;
            dgvFoods.AllowUserToDeleteRows = false;
            dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoods.BackgroundColor = Color.White;
            dgvFoods.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFoods.ColumnHeadersHeight = 36;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFoods.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFoods.EnableHeadersVisualStyles = false;
            dgvFoods.GridColor = Color.Gainsboro;
            dgvFoods.Location = new Point(48, 145);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowHeadersVisible = false;
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.RowTemplate.Height = 32;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(772, 180);
            dgvFoods.TabIndex = 5;
            dgvFoods.CellClick += dgvFoods_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Firebrick;
            btnDelete.Location = new Point(328, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 36);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlEditCard
            // 
            pnlEditCard.BackColor = Color.White;
            pnlEditCard.BorderStyle = BorderStyle.FixedSingle;
            pnlEditCard.Controls.Add(lblEditCardTitle);
            pnlEditCard.Controls.Add(lblEditName);
            pnlEditCard.Controls.Add(txtEditName);
            pnlEditCard.Controls.Add(lblEditCalories);
            pnlEditCard.Controls.Add(txtEditCalories);
            pnlEditCard.Controls.Add(lblEditProtein);
            pnlEditCard.Controls.Add(txtEditProtein);
            pnlEditCard.Controls.Add(lblEditCarbohydrates);
            pnlEditCard.Controls.Add(txtEditCarbohydrates);
            pnlEditCard.Controls.Add(lblEditFat);
            pnlEditCard.Controls.Add(txtEditFat);
            pnlEditCard.Controls.Add(btnEdit);
            pnlEditCard.Controls.Add(btnClose);
            pnlEditCard.Location = new Point(55, 600);
            pnlEditCard.Name = "pnlEditCard";
            pnlEditCard.Size = new Size(870, 283);
            pnlEditCard.TabIndex = 4;
            // 
            // lblEditCardTitle
            // 
            lblEditCardTitle.AutoSize = true;
            lblEditCardTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditCardTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditCardTitle.Location = new Point(334, 18);
            lblEditCardTitle.Name = "lblEditCardTitle";
            lblEditCardTitle.Size = new Size(189, 32);
            lblEditCardTitle.TabIndex = 0;
            lblEditCardTitle.Text = "Editar alimento";
            // 
            // lblEditName
            // 
            lblEditName.AutoSize = true;
            lblEditName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditName.ForeColor = Color.FromArgb(66, 66, 66);
            lblEditName.Location = new Point(48, 68);
            lblEditName.Name = "lblEditName";
            lblEditName.Size = new Size(76, 23);
            lblEditName.TabIndex = 1;
            lblEditName.Text = "Nombre";
            // 
            // txtEditName
            // 
            txtEditName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditName.Location = new Point(48, 94);
            txtEditName.Name = "txtEditName";
            txtEditName.ReadOnly = true;
            txtEditName.Size = new Size(360, 30);
            txtEditName.TabIndex = 2;
            // 
            // lblEditCalories
            // 
            lblEditCalories.AutoSize = true;
            lblEditCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblEditCalories.Location = new Point(462, 68);
            lblEditCalories.Name = "lblEditCalories";
            lblEditCalories.Size = new Size(73, 23);
            lblEditCalories.TabIndex = 3;
            lblEditCalories.Text = "Calorías";
            // 
            // txtEditCalories
            // 
            txtEditCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditCalories.Location = new Point(462, 94);
            txtEditCalories.Name = "txtEditCalories";
            txtEditCalories.Size = new Size(340, 30);
            txtEditCalories.TabIndex = 4;
            // 
            // lblEditProtein
            // 
            lblEditProtein.AutoSize = true;
            lblEditProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblEditProtein.Location = new Point(48, 136);
            lblEditProtein.Name = "lblEditProtein";
            lblEditProtein.Size = new Size(77, 23);
            lblEditProtein.TabIndex = 5;
            lblEditProtein.Text = "Proteína";
            // 
            // txtEditProtein
            // 
            txtEditProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditProtein.Location = new Point(48, 162);
            txtEditProtein.Name = "txtEditProtein";
            txtEditProtein.Size = new Size(220, 30);
            txtEditProtein.TabIndex = 6;
            // 
            // lblEditCarbohydrates
            // 
            lblEditCarbohydrates.AutoSize = true;
            lblEditCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblEditCarbohydrates.Location = new Point(315, 136);
            lblEditCarbohydrates.Name = "lblEditCarbohydrates";
            lblEditCarbohydrates.Size = new Size(124, 23);
            lblEditCarbohydrates.TabIndex = 7;
            lblEditCarbohydrates.Text = "Carbohidratos";
            // 
            // txtEditCarbohydrates
            // 
            txtEditCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditCarbohydrates.Location = new Point(315, 162);
            txtEditCarbohydrates.Name = "txtEditCarbohydrates";
            txtEditCarbohydrates.Size = new Size(220, 30);
            txtEditCarbohydrates.TabIndex = 8;
            // 
            // lblEditFat
            // 
            lblEditFat.AutoSize = true;
            lblEditFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblEditFat.Location = new Point(582, 136);
            lblEditFat.Name = "lblEditFat";
            lblEditFat.Size = new Size(61, 23);
            lblEditFat.TabIndex = 9;
            lblEditFat.Text = "Grasas";
            // 
            // txtEditFat
            // 
            txtEditFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditFat.Location = new Point(582, 162);
            txtEditFat.Name = "txtEditFat";
            txtEditFat.Size = new Size(220, 30);
            txtEditFat.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(46, 125, 50);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(287, 204);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 38);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Guardar cambios";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(46, 125, 50);
            btnClose.Location = new Point(466, 204);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(155, 38);
            btnClose.TabIndex = 12;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FoodConsultView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(983, 917);
            Controls.Add(pnlEditCard);
            Controls.Add(pnlSearchCard);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FoodConsultView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vitta - Consulta de alimentos";
            Load += FoodConsultView_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearchCard.ResumeLayout(false);
            pnlSearchCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            pnlEditCard.ResumeLayout(false);
            pnlEditCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlSearchCard;
        private Label lblSearchCardTitle;
        private Label lblSearch;
        private TextBox txtSearchFood;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dgvFoods;
        private Button btnDelete;
        private Panel pnlEditCard;
        private Label lblEditCardTitle;
        private Label lblEditName;
        private TextBox txtEditName;
        private Label lblEditCalories;
        private TextBox txtEditCalories;
        private Label lblEditProtein;
        private TextBox txtEditProtein;
        private Label lblEditCarbohydrates;
        private TextBox txtEditCarbohydrates;
        private Label lblEditFat;
        private TextBox txtEditFat;
        private Button btnEdit;
        private Button btnClose;
    }
}