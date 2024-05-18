namespace ProtipoCU2yCU4
{
    partial class ModificarForm
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
            OrdenInt_List = new ListView();
            N_Orden_Ext2 = new ColumnHeader();
            N_Orden_Int = new ColumnHeader();
            Tipo_Producto2 = new ColumnHeader();
            Cantidades2 = new ColumnHeader();
            Cliente2 = new ColumnHeader();
            Estado = new ColumnHeader();
            Listo_Para_Entrega = new ColumnHeader();
            Fecha_Creacion2 = new ColumnHeader();
            Fecha_Modificacion = new ColumnHeader();
            FechaModificacionDT = new DateTimePicker();
            FechaCreacionDT = new DateTimePicker();
            EstadoCB = new ComboBox();
            CancelarBoton = new Button();
            AceptarBoton = new Button();
            ClienteText = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
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
            SuspendLayout();
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden_Ext2, N_Orden_Int, Tipo_Producto2, Cantidades2, Cliente2, Estado, Listo_Para_Entrega, Fecha_Creacion2, Fecha_Modificacion });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(27, 29);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(552, 441);
            OrdenInt_List.TabIndex = 60;
            OrdenInt_List.UseCompatibleStateImageBehavior = false;
            OrdenInt_List.View = View.Details;
            // 
            // N_Orden_Ext2
            // 
            N_Orden_Ext2.Text = "N° Orden Ext";
            N_Orden_Ext2.Width = 90;
            // 
            // N_Orden_Int
            // 
            N_Orden_Int.Text = "N° Orden Int";
            N_Orden_Int.Width = 90;
            // 
            // Tipo_Producto2
            // 
            Tipo_Producto2.Text = "Tipo Producto";
            Tipo_Producto2.Width = 90;
            // 
            // Cantidades2
            // 
            Cantidades2.Text = "Cantidades";
            Cantidades2.Width = 80;
            // 
            // Cliente2
            // 
            Cliente2.Text = "Cliente";
            Cliente2.Width = 120;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // Listo_Para_Entrega
            // 
            Listo_Para_Entrega.Text = "LPE";
            Listo_Para_Entrega.Width = 40;
            // 
            // Fecha_Creacion2
            // 
            Fecha_Creacion2.Text = "Fecha de Creación";
            Fecha_Creacion2.Width = 140;
            // 
            // Fecha_Modificacion
            // 
            Fecha_Modificacion.Text = "Fecha de Modificación";
            Fecha_Modificacion.Width = 140;
            // 
            // FechaModificacionDT
            // 
            FechaModificacionDT.Enabled = false;
            FechaModificacionDT.Format = DateTimePickerFormat.Short;
            FechaModificacionDT.Location = new Point(599, 338);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(82, 23);
            FechaModificacionDT.TabIndex = 79;
            FechaModificacionDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(599, 288);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 78;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // EstadoCB
            // 
            EstadoCB.FormattingEnabled = true;
            EstadoCB.Items.AddRange(new object[] { "EnSeleccion", "Seleccionada", "Preparada", "Despachada" });
            EstadoCB.Location = new Point(599, 391);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(121, 23);
            EstadoCB.TabIndex = 77;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(801, 459);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(75, 23);
            CancelarBoton.TabIndex = 76;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(683, 459);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(75, 23);
            AceptarBoton.TabIndex = 75;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(599, 241);
            ClienteText.Name = "ClienteText";
            ClienteText.ReadOnly = true;
            ClienteText.Size = new Size(361, 23);
            ClienteText.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(599, 220);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 73;
            label8.Text = "Cliente";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(599, 420);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 72;
            checkBox1.Text = "Listo para Entrega";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(599, 370);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 71;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(599, 320);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 70;
            label6.Text = "Fecha de Modificación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(599, 270);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 69;
            label5.Text = "Fecha de Creación";
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(599, 141);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.ReadOnly = true;
            TipoDeProductoText.Size = new Size(361, 23);
            TipoDeProductoText.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(599, 120);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 67;
            label4.Text = "Tipo de Producto";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(599, 191);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(361, 23);
            CantidadText.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(599, 170);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 65;
            label3.Text = "Cantidad";
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(599, 91);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(361, 23);
            NumOrdExtText.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(599, 70);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 63;
            label2.Text = "N° de Orden Externa";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(599, 41);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 20);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 61;
            label1.Text = "N° de Orden Interna";
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 543);
            Controls.Add(FechaModificacionDT);
            Controls.Add(FechaCreacionDT);
            Controls.Add(EstadoCB);
            Controls.Add(CancelarBoton);
            Controls.Add(AceptarBoton);
            Controls.Add(ClienteText);
            Controls.Add(label8);
            Controls.Add(checkBox1);
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
            Controls.Add(OrdenInt_List);
            Name = "ModificarForm";
            Text = "ModificarForm";
            Load += ModificarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenInt_List;
        private ColumnHeader N_Orden_Ext2;
        private ColumnHeader N_Orden_Int;
        private ColumnHeader Tipo_Producto2;
        private ColumnHeader Cantidades2;
        private ColumnHeader Cliente2;
        private ColumnHeader Estado;
        private ColumnHeader Listo_Para_Entrega;
        private ColumnHeader Fecha_Creacion2;
        private ColumnHeader Fecha_Modificacion;
        private DateTimePicker FechaModificacionDT;
        private DateTimePicker FechaCreacionDT;
        private ComboBox EstadoCB;
        private Button CancelarBoton;
        private Button AceptarBoton;
        private TextBox ClienteText;
        private Label label8;
        private CheckBox checkBox1;
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
    }
}