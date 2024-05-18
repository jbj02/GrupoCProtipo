namespace ProtipoCU2yCU4
{
    partial class PreparadorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrdenExt_List = new ListView();
            Num_Orden_Ext = new ColumnHeader();
            Tipo_Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Fecha_Creacion = new ColumnHeader();
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
            Nueva_OrdenBoton = new Button();
            ActualizarBoton2 = new Button();
            ModificarBoton = new Button();
            BuscarBoton = new Button();
            CancelarBoton = new Button();
            ActualizarBoton1 = new Button();
            SuspendLayout();
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Num_Orden_Ext, Tipo_Producto, Cantidad, Cliente, Prioridad, Fecha_Creacion });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(116, 12);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(667, 170);
            OrdenExt_List.TabIndex = 1;
            OrdenExt_List.UseCompatibleStateImageBehavior = false;
            OrdenExt_List.View = View.Details;
            // 
            // Num_Orden_Ext
            // 
            Num_Orden_Ext.Text = "N° Orden Ext";
            Num_Orden_Ext.Width = 120;
            // 
            // Tipo_Producto
            // 
            Tipo_Producto.Text = "Tipo Producto";
            Tipo_Producto.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 120;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            // 
            // Fecha_Creacion
            // 
            Fecha_Creacion.Text = "Fecha de Creación";
            Fecha_Creacion.Width = 120;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden_Ext2, N_Orden_Int, Tipo_Producto2, Cantidades2, Cliente2, Estado, Listo_Para_Entrega, Fecha_Creacion2, Fecha_Modificacion });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(14, 243);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(895, 170);
            OrdenInt_List.TabIndex = 2;
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
            // Nueva_OrdenBoton
            // 
            Nueva_OrdenBoton.Location = new Point(625, 188);
            Nueva_OrdenBoton.Name = "Nueva_OrdenBoton";
            Nueva_OrdenBoton.Size = new Size(95, 23);
            Nueva_OrdenBoton.TabIndex = 3;
            Nueva_OrdenBoton.Text = "Nueva Orden";
            Nueva_OrdenBoton.UseVisualStyleBackColor = true;
            Nueva_OrdenBoton.Click += Nueva_OrdenBoton_Click;
            // 
            // ActualizarBoton2
            // 
            ActualizarBoton2.Location = new Point(618, 415);
            ActualizarBoton2.Name = "ActualizarBoton2";
            ActualizarBoton2.Size = new Size(95, 23);
            ActualizarBoton2.TabIndex = 4;
            ActualizarBoton2.Text = "Actualizar";
            ActualizarBoton2.UseVisualStyleBackColor = true;
            // 
            // ModificarBoton
            // 
            ModificarBoton.Location = new Point(501, 415);
            ModificarBoton.Name = "ModificarBoton";
            ModificarBoton.Size = new Size(95, 23);
            ModificarBoton.TabIndex = 5;
            ModificarBoton.Text = "Modificar";
            ModificarBoton.UseVisualStyleBackColor = true;
            ModificarBoton.Click += ModificarBoton_Click;
            // 
            // BuscarBoton
            // 
            BuscarBoton.Location = new Point(384, 415);
            BuscarBoton.Name = "BuscarBoton";
            BuscarBoton.Size = new Size(95, 23);
            BuscarBoton.TabIndex = 6;
            BuscarBoton.Text = "Buscar";
            BuscarBoton.UseVisualStyleBackColor = true;
            BuscarBoton.Click += BuscarBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(735, 415);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(95, 23);
            CancelarBoton.TabIndex = 7;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // ActualizarBoton1
            // 
            ActualizarBoton1.Location = new Point(524, 188);
            ActualizarBoton1.Name = "ActualizarBoton1";
            ActualizarBoton1.Size = new Size(95, 23);
            ActualizarBoton1.TabIndex = 8;
            ActualizarBoton1.Text = "Actualizar";
            ActualizarBoton1.UseVisualStyleBackColor = true;
            // 
            // PreparadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 450);
            Controls.Add(ActualizarBoton1);
            Controls.Add(CancelarBoton);
            Controls.Add(BuscarBoton);
            Controls.Add(ModificarBoton);
            Controls.Add(ActualizarBoton2);
            Controls.Add(Nueva_OrdenBoton);
            Controls.Add(OrdenInt_List);
            Controls.Add(OrdenExt_List);
            Name = "PreparadorForm";
            Text = "PreparadorForm";
            Load += PreparadorForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView OrdenExt_List;
        private ColumnHeader Num_Orden_Ext;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Cliente;
        private ColumnHeader Fecha_Creacion;
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
        private Button Nueva_OrdenBoton;
        private Button ActualizarBoton2;
        private Button ModificarBoton;
        private Button BuscarBoton;
        private Button CancelarBoton;
        private Button ActualizarBoton1;
        private ColumnHeader Prioridad;
    }
}
