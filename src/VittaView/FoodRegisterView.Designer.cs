namespace VittaView
{
    partial class FoodRegisterView
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
            lblMainTitle = new Label();
            lblSubtitle = new Label();
            pnlFoodCard = new Panel();
            lblCardTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblCalories = new Label();
            txtCalories = new TextBox();
            lblProtein = new Label();
            txtProtein = new TextBox();
            lblCarbohydrates = new Label();
            txtCarbohydrates = new TextBox();
            lblFat = new Label();
            txtFat = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlFoodCard.SuspendLayout();
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
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblMainTitle.Location = new Point(275, 83);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(411, 54);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Registro de alimentos";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(97, 97, 97);
            lblSubtitle.Location = new Point(184, 148);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(592, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Ingresa la información nutricional del alimento que deseas registrar.";
            // 
            // pnlFoodCard
            // 
            pnlFoodCard.BackColor = Color.White;
            pnlFoodCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFoodCard.Controls.Add(lblCardTitle);
            pnlFoodCard.Controls.Add(lblName);
            pnlFoodCard.Controls.Add(txtName);
            pnlFoodCard.Controls.Add(lblCalories);
            pnlFoodCard.Controls.Add(txtCalories);
            pnlFoodCard.Controls.Add(lblProtein);
            pnlFoodCard.Controls.Add(txtProtein);
            pnlFoodCard.Controls.Add(lblCarbohydrates);
            pnlFoodCard.Controls.Add(txtCarbohydrates);
            pnlFoodCard.Controls.Add(lblFat);
            pnlFoodCard.Controls.Add(txtFat);
            pnlFoodCard.Controls.Add(btnSave);
            pnlFoodCard.Controls.Add(btnCancel);
            pnlFoodCard.Location = new Point(131, 204);
            pnlFoodCard.Name = "pnlFoodCard";
            pnlFoodCard.Size = new Size(700, 430);
            pnlFoodCard.TabIndex = 3;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblCardTitle.Location = new Point(230, 22);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(233, 32);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Datos del alimento";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(66, 66, 66);
            lblName.Location = new Point(76, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(76, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(550, 30);
            txtName.TabIndex = 2;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalories.ForeColor = Color.FromArgb(66, 66, 66);
            lblCalories.Location = new Point(76, 167);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(77, 23);
            lblCalories.TabIndex = 3;
            lblCalories.Text = "Calorías";
            // 
            // txtCalories
            // 
            txtCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalories.Location = new Point(76, 193);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(240, 30);
            txtCalories.TabIndex = 4;
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProtein.ForeColor = Color.FromArgb(66, 66, 66);
            lblProtein.Location = new Point(386, 167);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(79, 23);
            lblProtein.TabIndex = 5;
            lblProtein.Text = "Proteína";
            // 
            // txtProtein
            // 
            txtProtein.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProtein.Location = new Point(386, 193);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(240, 30);
            txtProtein.TabIndex = 6;
            // 
            // lblCarbohydrates
            // 
            lblCarbohydrates.AutoSize = true;
            lblCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarbohydrates.ForeColor = Color.FromArgb(66, 66, 66);
            lblCarbohydrates.Location = new Point(76, 242);
            lblCarbohydrates.Name = "lblCarbohydrates";
            lblCarbohydrates.Size = new Size(119, 23);
            lblCarbohydrates.TabIndex = 7;
            lblCarbohydrates.Text = "Carbohidratos";
            // 
            // txtCarbohydrates
            // 
            txtCarbohydrates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarbohydrates.Location = new Point(76, 268);
            txtCarbohydrates.Name = "txtCarbohydrates";
            txtCarbohydrates.Size = new Size(240, 30);
            txtCarbohydrates.TabIndex = 8;
            // 
            // lblFat
            // 
            lblFat.AutoSize = true;
            lblFat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFat.ForeColor = Color.FromArgb(66, 66, 66);
            lblFat.Location = new Point(386, 242);
            lblFat.Name = "lblFat";
            lblFat.Size = new Size(64, 23);
            lblFat.TabIndex = 9;
            lblFat.Text = "Grasas";
            // 
            // txtFat
            // 
            txtFat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFat.Location = new Point(386, 268);
            txtFat.Name = "txtFat";
            txtFat.Size = new Size(240, 30);
            txtFat.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(181, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 42);
            btnSave.TabIndex = 11;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(46, 125, 50);
            btnCancel.Location = new Point(362, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FoodRegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(983, 754);
            Controls.Add(pnlFoodCard);
            Controls.Add(lblSubtitle);
            Controls.Add(lblMainTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FoodRegisterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vitta - Registro de alimentos";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFoodCard.ResumeLayout(false);
            pnlFoodCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblMainTitle;
        private Label lblSubtitle;
        private Panel pnlFoodCard;
        private Label lblCardTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblCalories;
        private TextBox txtCalories;
        private Label lblProtein;
        private TextBox txtProtein;
        private Label lblCarbohydrates;
        private TextBox txtCarbohydrates;
        private Label lblFat;
        private TextBox txtFat;
        private Button btnSave;
        private Button btnCancel;
    }
}