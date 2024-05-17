namespace ProtipoCU2yCU4
{
    partial class ConfirmacionForm
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
            CancelarBoton = new Button();
            AceptarBoton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 80);
            label1.Name = "label1";
            label1.Size = new Size(243, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Estás seguro que deseas modificar la orden?";
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(224, 135);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(75, 23);
            CancelarBoton.TabIndex = 20;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(106, 135);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(75, 23);
            AceptarBoton.TabIndex = 19;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            // 
            // ConfirmacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 209);
            Controls.Add(CancelarBoton);
            Controls.Add(AceptarBoton);
            Controls.Add(label1);
            Name = "ConfirmacionForm";
            Text = "ConfirmacionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CancelarBoton;
        private Button AceptarBoton;
    }
}