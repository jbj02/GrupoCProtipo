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
            Nueva_Orden = new Button();
            Actualizar = new Button();
            Modificar = new Button();
            Buscar = new Button();
            Cancelar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Num_Orden_Ext, Tipo_Producto, Cantidad, Cliente, Fecha_Creacion });
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(116, 12);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(604, 170);
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
            // Fecha_Creacion
            // 
            Fecha_Creacion.Text = "Fecha de Creación";
            Fecha_Creacion.Width = 120;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden_Ext2, N_Orden_Int, Tipo_Producto2, Cantidades2, Cliente2, Estado, Listo_Para_Entrega, Fecha_Creacion2, Fecha_Modificacion });
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
            // Nueva_Orden
            // 
            Nueva_Orden.Location = new Point(625, 188);
            Nueva_Orden.Name = "Nueva_Orden";
            Nueva_Orden.Size = new Size(95, 23);
            Nueva_Orden.TabIndex = 3;
            Nueva_Orden.Text = "Nueva Orden";
            Nueva_Orden.UseVisualStyleBackColor = true;
            Nueva_Orden.Click += Nueva_Orden_Click;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(618, 415);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(95, 23);
            Actualizar.TabIndex = 4;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            Modificar.Location = new Point(501, 415);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(95, 23);
            Modificar.TabIndex = 5;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(384, 415);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(95, 23);
            Buscar.TabIndex = 6;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(735, 415);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(95, 23);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(524, 188);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 8;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // PreparadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 450);
            Controls.Add(button1);
            Controls.Add(Cancelar);
            Controls.Add(Buscar);
            Controls.Add(Modificar);
            Controls.Add(Actualizar);
            Controls.Add(Nueva_Orden);
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
        private Button Nueva_Orden;
        private Button Actualizar;
        private Button Modificar;
        private Button Buscar;
        private Button Cancelar;
        private Button button1;
    }
}
