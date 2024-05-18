using System;
using GrupoCProtipo.Preparador;

namespace ProtipoCU2yCU4
{
    public partial class PreparadorForm : Form
    {
        PreparadorModelo modelo = new();
        public PreparadorForm()
        {
            InitializeComponent();
        }

        private void PreparadorForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenExt();
            CargarListaOrdenInt();
        }

        private void Nueva_OrdenBoton_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenExt_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            var ordenSeleccionada = (OrdenExt)OrdenExt_List.SelectedItems[0].Tag;

            // Crear una instancia de OrdenExt para OrdenInternaPorCrear
            modelo.OrdenInternaPorCrear = new OrdenExt
            {
                // Cargamos los datos de la tabla en los atributos del objeto
                NumOrdenExt = ordenSeleccionada.NumOrdenExt,
                TipoProducto = ordenSeleccionada.TipoProducto,
                Cantidad = ordenSeleccionada.Cantidad,
                Cliente = ordenSeleccionada.Cliente,
                Prioridad = ordenSeleccionada.Prioridad,
                FechaCreacion = ordenSeleccionada.FechaCreacion
            };

            // Abre el Formulario NuevaOrdenForm y pasa los datos
            NuevaOrdenForm nuevaOrdenForm = new NuevaOrdenForm();
            nuevaOrdenForm.CargaDatos(modelo.OrdenInternaPorCrear);
            nuevaOrdenForm.ShowDialog();
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

        private void CargarListaOrdenExt()
        {
            OrdenExt_List.Items.Clear();

            foreach (var ordenExterna in modelo.OrdenesExternas)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenExterna.NumOrdenExt;
                fila.SubItems.Add(ordenExterna.TipoProducto); // Siguiente columna...
                fila.SubItems.Add(ordenExterna.Cantidad);
                fila.SubItems.Add(ordenExterna.Cliente);
                fila.SubItems.Add(ordenExterna.Prioridad);
                fila.SubItems.Add(ordenExterna.FechaCreacion.ToString("dd/MM/yyyy"));
                fila.Tag = ordenExterna; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                OrdenExt_List.Items.Add(fila);
            }
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

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            // Abre el Formulario BuscarForm
            BusquedaForm busquedaForm = new();
            busquedaForm.ShowDialog();
        }
    }
}
