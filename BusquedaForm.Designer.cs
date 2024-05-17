namespace ProtipoCU2yCU4
{
    partial class BusquedaForm
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
            NumeroOrdenInternaText = new TextBox();
            label1 = new Label();
            CancelarBoton = new Button();
            AceptarBoton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // NumeroOrdenInternaText
            // 
            NumeroOrdenInternaText.Location = new Point(187, 35);
            NumeroOrdenInternaText.Name = "NumeroOrdenInternaText";
            NumeroOrdenInternaText.Size = new Size(131, 23);
            NumeroOrdenInternaText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 1;
            label1.Text = "Número de Orden Interna";
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(243, 67);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(75, 23);
            CancelarBoton.TabIndex = 39;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(162, 67);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(75, 23);
            AceptarBoton.TabIndex = 38;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(38, 67);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 40;
            button1.Text = "Generar Remito";
            button1.UseVisualStyleBackColor = true;
            // 
            // BusquedaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 115);
            Controls.Add(button1);
            Controls.Add(CancelarBoton);
            Controls.Add(AceptarBoton);
            Controls.Add(label1);
            Controls.Add(NumeroOrdenInternaText);
            Name = "BusquedaForm";
            Text = "BusquedaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumeroOrdenInternaText;
        private Label label1;
        private Button CancelarBoton;
        private Button AceptarBoton;
        private Button button1;
    }
}