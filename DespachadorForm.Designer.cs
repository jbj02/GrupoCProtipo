namespace GrupoCProtipoCU2yCU4
{
    partial class DespachadorForm
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
            CancelarBoton = new Button();
            BuscarBoton = new Button();
            ModificarBoton = new Button();
            ActualizarBoton2 = new Button();
            GenerarRemitoBoton = new Button();
            SuspendLayout();
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden_Ext2, N_Orden_Int, Tipo_Producto2, Cantidades2, Cliente2, Estado, Listo_Para_Entrega, Fecha_Creacion2, Fecha_Modificacion });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(45, 12);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(895, 170);
            OrdenInt_List.TabIndex = 3;
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
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(844, 188);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(95, 23);
            CancelarBoton.TabIndex = 11;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // BuscarBoton
            // 
            BuscarBoton.Location = new Point(493, 188);
            BuscarBoton.Name = "BuscarBoton";
            BuscarBoton.Size = new Size(95, 23);
            BuscarBoton.TabIndex = 10;
            BuscarBoton.Text = "Buscar";
            BuscarBoton.UseVisualStyleBackColor = true;
            // 
            // ModificarBoton
            // 
            ModificarBoton.Location = new Point(610, 188);
            ModificarBoton.Name = "ModificarBoton";
            ModificarBoton.Size = new Size(95, 23);
            ModificarBoton.TabIndex = 9;
            ModificarBoton.Text = "Modificar";
            ModificarBoton.UseVisualStyleBackColor = true;
            ModificarBoton.Click += ModificarBoton_Click;
            // 
            // ActualizarBoton2
            // 
            ActualizarBoton2.Location = new Point(727, 188);
            ActualizarBoton2.Name = "ActualizarBoton2";
            ActualizarBoton2.Size = new Size(95, 23);
            ActualizarBoton2.TabIndex = 8;
            ActualizarBoton2.Text = "Actualizar";
            ActualizarBoton2.UseVisualStyleBackColor = true;
            // 
            // GenerarRemitoBoton
            // 
            GenerarRemitoBoton.Location = new Point(379, 188);
            GenerarRemitoBoton.Name = "GenerarRemitoBoton";
            GenerarRemitoBoton.Size = new Size(95, 23);
            GenerarRemitoBoton.TabIndex = 12;
            GenerarRemitoBoton.Text = "Genera Remito";
            GenerarRemitoBoton.UseVisualStyleBackColor = true;
            GenerarRemitoBoton.Click += GenerarRemitoBoton_Click;
            // 
            // DespachadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 248);
            Controls.Add(GenerarRemitoBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(BuscarBoton);
            Controls.Add(ModificarBoton);
            Controls.Add(ActualizarBoton2);
            Controls.Add(OrdenInt_List);
            Name = "DespachadorForm";
            Text = "DespachadorForm";
            Load += DespachadorForm_Load;
            ResumeLayout(false);
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
        private Button CancelarBoton;
        private Button BuscarBoton;
        private Button ModificarBoton;
        private Button ActualizarBoton2;
        private Button GenerarRemitoBoton;
    }
}