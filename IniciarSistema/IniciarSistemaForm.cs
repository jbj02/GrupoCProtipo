using GrupoCProtipo.IniciarSistema;
using ProtipoCU2yCU4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProtipoCU2yCU4
{
    public partial class IniciarSistemaForm : Form
    {
        IniciarSistemaModelo modelo = new();
        public IniciarSistemaForm()
        {
            InitializeComponent();
        }

        private void IniciarSistemaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContraseña.Text;

            FormOpen(usuario, clave);
        }
        private void FormOpen(string usuario, string clave)
        {
            Credenciales credencial = new Credenciales
            {
                Usuario = usuario,
                Clave = BuscarClave(usuario),
                Acceso = BuscarUsuario(usuario)
            };
            string password = credencial.Clave;
            if (credencial.Acceso == null)
            {
                MessageBox.Show("El usuario o contraseña son incorrectos", "Error");
            }
            else if (password != clave)
            {
                MessageBox.Show("El usuario o contraseña son incorrectos", "Error");
            }
            else
            {
                string acceso = credencial.Acceso;
                if (acceso == "Preparador")
                {
                    PreparadorForm prepform = new PreparadorForm();
                    prepform.ShowDialog();
                }
                else if (acceso == "Despachador")
                {
                    DespachadorForm despform = new DespachadorForm();
                    despform.ShowDialog();
                }
                else if (acceso == "Estibador")
                {
                    EstibadorForm estiform = new EstibadorForm();
                    estiform.ShowDialog();
                }
            }

        }
        public string BuscarClave(string usuario)
        {
            var persona = modelo.CredencialesUsuarios.Find(c => c.Usuario == usuario);
            if (persona == null)
            {
                return "";
            }
            return persona.Clave;
        }
        public string BuscarUsuario(string usuario)
        {
            var persona = modelo.CredencialesUsuarios.Find(c => c.Usuario == usuario);
            if (persona == null)
            {
                return "";
            }
            return persona.Acceso;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == false)
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
