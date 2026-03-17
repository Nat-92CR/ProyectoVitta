namespace VittaView
{
    partial class RegisterView
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            textPassword = new TextBox();
            textName = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cmbGoal = new ComboBox();
            cmbActivityLevel = new ComboBox();
            cmbDietType = new ComboBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 104);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 133);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 162);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 191);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 220);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Altura";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(277, 96);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(258, 23);
            txtUserName.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(277, 125);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(258, 23);
            textPassword.TabIndex = 6;
            // 
            // textName
            // 
            textName.Location = new Point(277, 154);
            textName.Name = "textName";
            textName.Size = new Size(258, 23);
            textName.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(277, 183);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(258, 23);
            txtWeight.TabIndex = 8;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(277, 212);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(258, 23);
            txtHeight.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 56);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 10;
            label6.Text = "Registro de Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 30);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 11;
            label7.Text = "VITTA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 273);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 12;
            label8.Text = "Objetivo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(125, 307);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 13;
            label9.Text = "Nivel de actividad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(125, 348);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 14;
            label10.Text = "Tipo de dieta:";
            // 
            // cmbGoal
            // 
            cmbGoal.FormattingEnabled = true;
            cmbGoal.Location = new Point(277, 265);
            cmbGoal.Name = "cmbGoal";
            cmbGoal.Size = new Size(258, 23);
            cmbGoal.TabIndex = 15;
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(277, 299);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(258, 23);
            cmbActivityLevel.TabIndex = 16;
            // 
            // cmbDietType
            // 
            cmbDietType.FormattingEnabled = true;
            cmbDietType.Location = new Point(277, 340);
            cmbDietType.Name = "cmbDietType";
            cmbDietType.Size = new Size(259, 23);
            cmbDietType.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(132, 408);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(196, 38);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(340, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 36);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 494);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(cmbDietType);
            Controls.Add(cmbActivityLevel);
            Controls.Add(cmbGoal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(textName);
            Controls.Add(textPassword);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterView";
            Text = "RegisterView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox textPassword;
        private TextBox textName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cmbGoal;
        private ComboBox cmbActivityLevel;
        private ComboBox cmbDietType;
        private Button btnRegister;
        private Button btnCancel;
    }
}