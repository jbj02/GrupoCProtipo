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
    public partial class ModificarForm : Form
    {
        public ModificarForm()
        {
            InitializeComponent();
        }

        public void CargaDatos(OrdenInt ordenInternaAModificar)
        {
            NumOrdenIntText.Text = ordenInternaAModificar.NumOrdenInt;
            NumOrdExtText.Text = ordenInternaAModificar.NumOrdenExt;
            TipoDeProducto.Text = ordenInternaAModificar.TipoProducto;
            Cantidad.Text = ordenInternaAModificar.Cantidad;
            Cliente.Text = ordenInternaAModificar.Cliente;
            FechaCreacionDT.Value = ordenInternaAModificar.FechaCreacion;
            FechaModificacionDT.Value = DateTime.Now;
            EstadoCB.SelectedIndex = 1;
        }

        private void ModificarForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
