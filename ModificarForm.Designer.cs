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
            button2 = new Button();
            button1 = new Button();
            Cliente = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            TipoDeProducto = new TextBox();
            label4 = new Label();
            Cantidad = new TextBox();
            label3 = new Label();
            NumOrdExtText = new TextBox();
            label2 = new Label();
            NumOrdenIntText = new TextBox();
            label1 = new Label();
            EstadoCB = new ComboBox();
            FechaCreacionDT = new DateTimePicker();
            FechaModificacionDT = new DateTimePicker();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(227, 469);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 37;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(109, 469);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            Cliente.Location = new Point(25, 251);
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Size = new Size(361, 23);
            Cliente.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 230);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 34;
            label8.Text = "Cliente";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 430);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Listo para Entrega";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 380);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 31;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 330);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 29;
            label6.Text = "Fecha de Modificación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 280);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 27;
            label5.Text = "Fecha de Creación";
            // 
            // TipoDeProducto
            // 
            TipoDeProducto.Location = new Point(25, 151);
            TipoDeProducto.Name = "TipoDeProducto";
            TipoDeProducto.ReadOnly = true;
            TipoDeProducto.Size = new Size(361, 23);
            TipoDeProducto.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 130);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 25;
            label4.Text = "Tipo de Producto";
            // 
            // Cantidad
            // 
            Cantidad.Location = new Point(25, 201);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(361, 23);
            Cantidad.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 180);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 23;
            label3.Text = "Cantidad";
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(25, 101);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(361, 23);
            NumOrdExtText.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 21;
            label2.Text = "N° de Orden Externa";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(25, 51);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 19;
            label1.Text = "N° de Orden Interna";
            // 
            // EstadoCB
            // 
            EstadoCB.FormattingEnabled = true;
            EstadoCB.Items.AddRange(new object[] { "EnSeleccion", "Seleccionada", "Preparada", "Despachada" });
            EstadoCB.Location = new Point(25, 401);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(121, 23);
            EstadoCB.TabIndex = 38;
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(25, 298);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 58;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // FechaModificacionDT
            // 
            FechaModificacionDT.Enabled = false;
            FechaModificacionDT.Format = DateTimePickerFormat.Short;
            FechaModificacionDT.Location = new Point(25, 348);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(82, 23);
            FechaModificacionDT.TabIndex = 59;
            FechaModificacionDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 543);
            Controls.Add(FechaModificacionDT);
            Controls.Add(FechaCreacionDT);
            Controls.Add(EstadoCB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Cliente);
            Controls.Add(label8);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TipoDeProducto);
            Controls.Add(label4);
            Controls.Add(Cantidad);
            Controls.Add(label3);
            Controls.Add(NumOrdExtText);
            Controls.Add(label2);
            Controls.Add(NumOrdenIntText);
            Controls.Add(label1);
            Name = "ModificarForm";
            Text = "ModificarForm";
            Load += ModificarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox Cliente;
        private Label label8;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TipoDeProducto;
        private Label label4;
        private TextBox Cantidad;
        private Label label3;
        private TextBox NumOrdExtText;
        private Label label2;
        private TextBox NumOrdenIntText;
        private Label label1;
        private ComboBox EstadoCB;
        private DateTimePicker FechaCreacionDT;
        private DateTimePicker FechaModificacionDT;
    }
}