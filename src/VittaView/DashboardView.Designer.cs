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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(405, 41);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a nuestro sistema";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(821, 37);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(167, 41);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Mi perfil";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 491);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardView";
            Text = "DashboardView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
    }
}