namespace VittaView
{
    partial class MenuRegisterView
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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(200, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registro de menú";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(200, 106);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Fecha:";
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.Location = new Point(194, 167);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(77, 20);
            lblBreakfast.TabIndex = 2;
            lblBreakfast.Text = "Desayuno:";
            // 
            // lblMorningSnack
            // 
            lblMorningSnack.AutoSize = true;
            lblMorningSnack.Location = new Point(194, 201);
            lblMorningSnack.Name = "lblMorningSnack";
            lblMorningSnack.Size = new Size(132, 20);
            lblMorningSnack.TabIndex = 3;
            lblMorningSnack.Text = "Merienda mañana:";
            // 
            // lblLunch
            // 
            lblLunch.AutoSize = true;
            lblLunch.Location = new Point(194, 237);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(76, 20);
            lblLunch.TabIndex = 4;
            lblLunch.Text = "Almuerzo:";
            // 
            // lblAfternoonSnack
            // 
            lblAfternoonSnack.AutoSize = true;
            lblAfternoonSnack.Location = new Point(194, 276);
            lblAfternoonSnack.Name = "lblAfternoonSnack";
            lblAfternoonSnack.Size = new Size(114, 20);
            lblAfternoonSnack.TabIndex = 5;
            lblAfternoonSnack.Text = "Merienda tarde:";
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Location = new Point(194, 315);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(45, 20);
            lblDinner.TabIndex = 6;
            lblDinner.Text = "Cena:";
            // 
            // dtpMenuDate
            // 
            dtpMenuDate.Location = new Point(388, 99);
            dtpMenuDate.Name = "dtpMenuDate";
            dtpMenuDate.Size = new Size(212, 27);
            dtpMenuDate.TabIndex = 7;
            // 
            // txtBreakfast
            // 
            txtBreakfast.Location = new Point(388, 160);
            txtBreakfast.Name = "txtBreakfast";
            txtBreakfast.Size = new Size(212, 27);
            txtBreakfast.TabIndex = 9;
            // 
            // textMorning
            // 
            textMorning.Location = new Point(388, 193);
            textMorning.Name = "textMorning";
            textMorning.Size = new Size(212, 27);
            textMorning.TabIndex = 10;
            // 
            // txtLunch
            // 
            txtLunch.Location = new Point(388, 230);
            txtLunch.Name = "txtLunch";
            txtLunch.Size = new Size(212, 27);
            txtLunch.TabIndex = 11;
            // 
            // txtAfternoonSnack
            // 
            txtAfternoonSnack.Location = new Point(388, 269);
            txtAfternoonSnack.Name = "txtAfternoonSnack";
            txtAfternoonSnack.Size = new Size(212, 27);
            txtAfternoonSnack.TabIndex = 12;
            // 
            // txtDinner
            // 
            txtDinner.Location = new Point(388, 308);
            txtDinner.Name = "txtDinner";
            txtDinner.Size = new Size(212, 27);
            txtDinner.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 52);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar Menú";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(409, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 52);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // MenuRegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}