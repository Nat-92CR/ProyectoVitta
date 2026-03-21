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
            btnSearch.Size = new Size(165, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(303, 178);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(165, 46);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Mostrar todos";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(504, 178);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(165, 46);
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
            dgvFoods.Location = new Point(97, 243);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(572, 172);
            dgvFoods.TabIndex = 6;
            // 
            // FoodConsultView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}