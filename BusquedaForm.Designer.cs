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
            button2 = new Button();
            SuspendLayout();
            // 
            // NumeroOrdenInternaText
            // 
            NumeroOrdenInternaText.Location = new Point(267, 58);
            NumeroOrdenInternaText.Margin = new Padding(4, 5, 4, 5);
            NumeroOrdenInternaText.Name = "NumeroOrdenInternaText";
            NumeroOrdenInternaText.Size = new Size(185, 31);
            NumeroOrdenInternaText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 1;
            label1.Text = "Número de Orden Interna";
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(347, 112);
            CancelarBoton.Margin = new Padding(4, 5, 4, 5);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(107, 38);
            CancelarBoton.TabIndex = 39;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(231, 112);
            AceptarBoton.Margin = new Padding(4, 5, 4, 5);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(107, 38);
            AceptarBoton.TabIndex = 38;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(54, 112);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(169, 38);
            button1.TabIndex = 40;
            button1.Text = "Generar Remito";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(35, 23);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 41;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // BusquedaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 192);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CancelarBoton);
            Controls.Add(AceptarBoton);
            Controls.Add(label1);
            Controls.Add(NumeroOrdenInternaText);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button2;
    }
}