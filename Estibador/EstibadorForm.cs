using GrupoCProtipo.Estibador;
using ProtipoCU2yCU4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProtipoCU2yCU4
{
    public partial class EstibadorForm : Form
    {
        EstibadorModelo modelo = new();
        public EstibadorForm()
        {
            InitializeComponent();
        }

        private void EstibadorForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenInt();
        }

        private void CargarListaOrdenInt()
        {
            OrdenInt_List.Items.Clear();

            foreach (var ordenInterna in modelo.OrdenesInternas)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenInterna.NumOrdenExt;
                fila.SubItems.Add(ordenInterna.NumOrdenInt);
                fila.SubItems.Add(ordenInterna.TipoProducto);
                fila.SubItems.Add(ordenInterna.Cantidad);
                fila.SubItems.Add(ordenInterna.Cliente);
                fila.SubItems.Add(ordenInterna.Estado);
                fila.SubItems.Add(ordenInterna.LPE);
                fila.SubItems.Add(ordenInterna.FechaCreacion.ToString("dd/MM/yyyy"));
                fila.SubItems.Add(ordenInterna.FechaModificacion.ToString("dd/MM/yyyy"));
                fila.Tag = ordenInterna; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                OrdenInt_List.Items.Add(fila);
            }
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarBoton_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenInt_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            var ordenSeleccionada = (OrdenInt)OrdenInt_List.SelectedItems[0].Tag;

            // Crear una instancia de OrdenExt para OrdenInternaPorCrear
            modelo.OrdenInternaPorModificar = new OrdenInt
            {
                // Cargamos los datos de la tabla en los atributos del objeto
                NumOrdenInt = ordenSeleccionada.NumOrdenInt,
                NumOrdenExt = ordenSeleccionada.NumOrdenExt,
                TipoProducto = ordenSeleccionada.TipoProducto,
                Cantidad = ordenSeleccionada.Cantidad,
                Cliente = ordenSeleccionada.Cliente,
                FechaCreacion = ordenSeleccionada.FechaCreacion,
                FechaModificacion = ordenSeleccionada.FechaModificacion,
                Estado = ordenSeleccionada.Estado
            };

            // Abre el Formulario ModificarForm y pasa los datos
            ModificarForm modificarOrdenForm = new ModificarForm();
            modificarOrdenForm.CargaDatos(modelo.OrdenInternaPorModificar);
            modificarOrdenForm.ShowDialog();
        }
    }
}
