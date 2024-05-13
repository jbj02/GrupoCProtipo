using System;

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

        private void Nueva_Orden_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenExt_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden externa de la fila seleccionada
            var OrdenInternaACrear = (OrdenInt)OrdenExt_List.SelectedItems[0].Tag; // Como Tag hace referencia muy generica a un objeto hay que especificar su tipo se le dice "Castear"
            // Cargamos los datos ingresados
            Num_Orden_Ext.Text = OrdenInternaACrear.NumOrdenExt;
            Tipo_Producto.Text = OrdenInternaACrear.TipoProducto;
            Cantidad.Text = OrdenInternaACrear.Cantidad;
            Cliente.Text = OrdenInternaACrear.Cliente;
            Fecha_Creacion.Text = OrdenInternaACrear.FechaCreacion.ToString("dd/MM/yyyy");
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
                fila.Text = ordenInterna.NumOrdenInt;
                fila.SubItems.Add(ordenInterna.NumOrdenExt);
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
    }
}
