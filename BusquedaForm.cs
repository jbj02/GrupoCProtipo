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
        public BusquedaForm()
        {
            InitializeComponent();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
