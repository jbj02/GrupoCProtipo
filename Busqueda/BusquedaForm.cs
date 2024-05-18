using GrupoCProtipo.Busqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtipoCU2yCU4
{
    public partial class BusquedaForm : Form
    {
        BusquedaModelo modelo;


        public BusquedaForm()
        {
            InitializeComponent();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BusquedaForm_Load(object sender, EventArgs e)
        {
            modelo = new BusquedaModelo();
        }
    }
}
