namespace GrupoCProtipoCU2yCU4
{
    partial class IniciarSistemaForm
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(147, 53);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(279, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(147, 105);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(279, 23);
            txtContraseña.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(132, 165);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 42);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(300, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 42);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // IniciarSistemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 290);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "IniciarSistemaForm";
            Text = "IniciarSistemaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}