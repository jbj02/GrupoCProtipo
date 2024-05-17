namespace ProtipoCU2yCU4
{
    partial class NuevaOrdenForm
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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
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
            FechaModificacionDT = new DateTimePicker();
            FechaCreacionDT = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 496);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(236, 496);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 424);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 55;
            // 
            // Cliente
            // 
            Cliente.Location = new Point(35, 274);
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Size = new Size(361, 23);
            Cliente.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 253);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 53;
            label8.Text = "Cliente";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(35, 453);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 52;
            checkBox1.Text = "Listo para Entrega";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 403);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 51;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 353);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 49;
            label6.Text = "Fecha de Modificación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 303);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 47;
            label5.Text = "Fecha de Creación";
            // 
            // TipoDeProducto
            // 
            TipoDeProducto.Location = new Point(35, 174);
            TipoDeProducto.Name = "TipoDeProducto";
            TipoDeProducto.Size = new Size(361, 23);
            TipoDeProducto.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 153);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 45;
            label4.Text = "Tipo de Producto";
            // 
            // Cantidad
            // 
            Cantidad.Location = new Point(35, 224);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(361, 23);
            Cantidad.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 203);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 43;
            label3.Text = "Cantidad";
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(35, 124);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(361, 23);
            NumOrdExtText.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 103);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 41;
            label2.Text = "N° de Orden Externa";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(35, 74);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 39;
            label1.Text = "N° de Orden Interna";
            label1.Click += label1_Click;
            // 
            // FechaModificacionDT
            // 
            FechaModificacionDT.Enabled = false;
            FechaModificacionDT.Format = DateTimePickerFormat.Short;
            FechaModificacionDT.Location = new Point(35, 371);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(82, 23);
            FechaModificacionDT.TabIndex = 56;
            FechaModificacionDT.Value = new DateTime(2024, 5, 17, 0, 0, 0, 0);
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(35, 321);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 57;
            FechaCreacionDT.Value = new DateTime(2024, 5, 17, 0, 0, 0, 0);
            // 
            // NuevaOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 566);
            Controls.Add(FechaCreacionDT);
            Controls.Add(FechaModificacionDT);
            Controls.Add(comboBox1);
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
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NuevaOrdenForm";
            Text = "NuevaOrdenForm";
            Load += NuevaOrdenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
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
        private DateTimePicker FechaModificacionDT;
        private DateTimePicker FechaCreacionDT;
    }
}