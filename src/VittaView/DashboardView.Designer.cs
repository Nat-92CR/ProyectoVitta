namespace VittaView
{
    partial class DashboardView
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
        /// No modifique el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnProfile = new Button();
            btnOpenFoodRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(501, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a nuestro sistema";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(30, 117);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(191, 55);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Mi perfil";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnOpenFoodRegister
            // 
            btnOpenFoodRegister.Location = new Point(268, 117);
            btnOpenFoodRegister.Name = "btnOpenFoodRegister";
            btnOpenFoodRegister.Size = new Size(191, 55);
            btnOpenFoodRegister.TabIndex = 2;
            btnOpenFoodRegister.Text = "Registrar alimento";
            btnOpenFoodRegister.UseVisualStyleBackColor = true;
            btnOpenFoodRegister.Click += btnOpenFoodRegister_Click;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 655);
            Controls.Add(btnOpenFoodRegister);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Name = "DashboardView";
            Text = "DashboardView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
        private Button btnOpenFoodRegister;
    }
}