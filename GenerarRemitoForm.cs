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
    public partial class GenerarRemitoForm : Form
    {
        public GenerarRemitoForm()
        {
            InitializeComponent();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargaDatos(OrdenInt datosOrdenInterna)
        {
            NumOrdenIntText.Text = datosOrdenInterna.NumOrdenInt;
            NumOrdExtText.Text = datosOrdenInterna.NumOrdenExt;
            TipoDeProductoText.Text = datosOrdenInterna.TipoProducto;
            CantidadText.Text = datosOrdenInterna.Cantidad;
            ClienteText.Text = datosOrdenInterna.Cliente;
            FechaCreacionDT.Value = datosOrdenInterna.FechaCreacion;
            FechaModificacionDT.Value = DateTime.Now;
            EstadoCB.SelectedIndex = 1;
        }
    }
}
