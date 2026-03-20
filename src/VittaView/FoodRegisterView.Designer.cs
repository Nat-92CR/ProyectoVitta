namespace VittaView
{
    partial class FoodRegisterView
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
            label1 = new Label();
            label2 = new Label();
            lblCalories = new Label();
            lblProtein = new Label();
            lblCarbohydrates = new Label();
            lblFat = new Label();
            txtName = new TextBox();
            txtCalories = new TextBox();
            txtProtein = new TextBox();
            txtCarbohydrates = new TextBox();
            txtFat = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(199, 24);
            label1.Name = "label1";
            label1.Size = new Size(344, 46);
            label1.TabIndex = 0;
            label1.Text = "Registro de alimentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 117);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(199, 159);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(62, 20);
            lblCalories.TabIndex = 2;
            lblCalories.Text = "Calorías";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(199, 206);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(64, 20);
            lblProtein.TabIndex = 3;
            lblProtein.Text = "Proteína";
            // 
            // lblCarbohydrates
            // 
            lblCarbohydrates.AutoSize = true;
            lblCarbohydrates.Location = new Point(199, 247);
            lblCarbohydrates.Name = "lblCarbohydrates";
            lblCarbohydrates.Size = new Size(103, 20);
            lblCarbohydrates.TabIndex = 4;
            lblCarbohydrates.Text = "Carbohidratos";
            // 
            // lblFat
            // 
            lblFat.AutoSize = true;
            lblFat.Location = new Point(200, 291);
            lblFat.Name = "lblFat";
            lblFat.Size = new Size(52, 20);
            lblFat.TabIndex = 5;
            lblFat.Text = "Grasas";
            // 
            // txtName
            // 
            txtName.Location = new Point(353, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 6;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(353, 152);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(207, 27);
            txtCalories.TabIndex = 7;
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(353, 199);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(207, 27);
            txtProtein.TabIndex = 8;
            // 
            // txtCarbohydrates
            // 
            txtCarbohydrates.Location = new Point(353, 240);
            txtCarbohydrates.Name = "txtCarbohydrates";
            txtCarbohydrates.Size = new Size(207, 27);
            txtCarbohydrates.TabIndex = 9;
            // 
            // txtFat
            // 
            txtFat.Location = new Point(353, 284);
            txtFat.Name = "txtFat";
            txtFat.Size = new Size(207, 27);
            txtFat.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(199, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 59);
            btnSave.TabIndex = 11;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(394, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 59);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FoodRegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFat);
            Controls.Add(txtCarbohydrates);
            Controls.Add(txtProtein);
            Controls.Add(txtCalories);
            Controls.Add(txtName);
            Controls.Add(lblFat);
            Controls.Add(lblCarbohydrates);
            Controls.Add(lblProtein);
            Controls.Add(lblCalories);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FoodRegisterView";
            Text = "FoodRegisterView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblCalories;
        private Label lblProtein;
        private Label lblCarbohydrates;
        private Label lblFat;
        private TextBox txtName;
        private TextBox txtCalories;
        private TextBox txtProtein;
        private TextBox txtCarbohydrates;
        private TextBox txtFat;
        private Button btnSave;
        private Button btnCancel;
    }
}