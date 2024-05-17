namespace GrupoCProtipoCU2yCU4
{
    partial class GenerarRemitoForm
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
            FechaModificacionDT = new DateTimePicker();
            FechaCreacionDT = new DateTimePicker();
            EstadoCB = new ComboBox();
            CancelarBoton = new Button();
            AceptarBoton = new Button();
            ClienteText = new TextBox();
            label8 = new Label();
            ListoParaEntregaCB = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            TipoDeProductoText = new TextBox();
            label4 = new Label();
            CantidadText = new TextBox();
            label3 = new Label();
            NumOrdExtText = new TextBox();
            label2 = new Label();
            NumOrdenIntText = new TextBox();
            label1 = new Label();
            FechaGeneracionRemiroDT = new DateTimePicker();
            label9 = new Label();
            DespachoCB = new ComboBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // FechaModificacionDT
            // 
            FechaModificacionDT.Enabled = false;
            FechaModificacionDT.Format = DateTimePickerFormat.Short;
            FechaModificacionDT.Location = new Point(12, 331);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(82, 23);
            FechaModificacionDT.TabIndex = 78;
            FechaModificacionDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(12, 281);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 77;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // EstadoCB
            // 
            EstadoCB.FormattingEnabled = true;
            EstadoCB.Items.AddRange(new object[] { "EnSeleccion", "Seleccionada", "Preparada", "Despachada" });
            EstadoCB.Location = new Point(12, 426);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(121, 23);
            EstadoCB.TabIndex = 76;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(214, 494);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(75, 23);
            CancelarBoton.TabIndex = 75;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(96, 494);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(75, 23);
            AceptarBoton.TabIndex = 74;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(12, 234);
            ClienteText.Name = "ClienteText";
            ClienteText.ReadOnly = true;
            ClienteText.Size = new Size(361, 23);
            ClienteText.TabIndex = 73;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 213);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 72;
            label8.Text = "Cliente";
            // 
            // ListoParaEntregaCB
            // 
            ListoParaEntregaCB.AutoSize = true;
            ListoParaEntregaCB.Location = new Point(12, 455);
            ListoParaEntregaCB.Name = "ListoParaEntregaCB";
            ListoParaEntregaCB.Size = new Size(120, 19);
            ListoParaEntregaCB.TabIndex = 71;
            ListoParaEntregaCB.Text = "Listo para Entrega";
            ListoParaEntregaCB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 405);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 70;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 313);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 69;
            label6.Text = "Fecha de Modificación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 68;
            label5.Text = "Fecha de Creación";
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(12, 134);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.ReadOnly = true;
            TipoDeProductoText.Size = new Size(361, 23);
            TipoDeProductoText.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 66;
            label4.Text = "Tipo de Producto";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(12, 184);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(361, 23);
            CantidadText.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 64;
            label3.Text = "Cantidad";
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(12, 84);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(361, 23);
            NumOrdExtText.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 62;
            label2.Text = "N° de Orden Externa";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(12, 34);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 60;
            label1.Text = "N° de Orden Interna";
            // 
            // FechaGeneracionRemiroDT
            // 
            FechaGeneracionRemiroDT.Enabled = false;
            FechaGeneracionRemiroDT.Format = DateTimePickerFormat.Short;
            FechaGeneracionRemiroDT.Location = new Point(12, 375);
            FechaGeneracionRemiroDT.Name = "FechaGeneracionRemiroDT";
            FechaGeneracionRemiroDT.Size = new Size(82, 23);
            FechaGeneracionRemiroDT.TabIndex = 80;
            FechaGeneracionRemiroDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 357);
            label9.Name = "label9";
            label9.Size = new Size(174, 15);
            label9.TabIndex = 79;
            label9.Text = "Fecha de Generación de Remito";
            // 
            // DespachoCB
            // 
            DespachoCB.FormattingEnabled = true;
            DespachoCB.Location = new Point(168, 426);
            DespachoCB.Name = "DespachoCB";
            DespachoCB.Size = new Size(121, 23);
            DespachoCB.TabIndex = 82;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(168, 405);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 81;
            label10.Text = "Despacho";
            // 
            // GenerarRemitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 552);
            Controls.Add(DespachoCB);
            Controls.Add(label10);
            Controls.Add(FechaGeneracionRemiroDT);
            Controls.Add(label9);
            Controls.Add(FechaModificacionDT);
            Controls.Add(FechaCreacionDT);
            Controls.Add(EstadoCB);
            Controls.Add(CancelarBoton);
            Controls.Add(AceptarBoton);
            Controls.Add(ClienteText);
            Controls.Add(label8);
            Controls.Add(ListoParaEntregaCB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TipoDeProductoText);
            Controls.Add(label4);
            Controls.Add(CantidadText);
            Controls.Add(label3);
            Controls.Add(NumOrdExtText);
            Controls.Add(label2);
            Controls.Add(NumOrdenIntText);
            Controls.Add(label1);
            Name = "GenerarRemitoForm";
            Text = "GenerarRemitoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker FechaModificacionDT;
        private DateTimePicker FechaCreacionDT;
        private ComboBox EstadoCB;
        private Button CancelarBoton;
        private Button AceptarBoton;
        private TextBox ClienteText;
        private Label label8;
        private CheckBox ListoParaEntregaCB;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TipoDeProductoText;
        private Label label4;
        private TextBox CantidadText;
        private Label label3;
        private TextBox NumOrdExtText;
        private Label label2;
        private TextBox NumOrdenIntText;
        private Label label1;
        private DateTimePicker FechaGeneracionRemiroDT;
        private Label label9;
        private ComboBox DespachoCB;
        private Label label10;
    }
}