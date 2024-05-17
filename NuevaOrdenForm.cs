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
    public partial class NuevaOrdenForm : Form
    {
        public NuevaOrdenForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevaOrdenForm_Load(object sender, EventArgs e)
        {

        }

        public void CargaDatos(OrdenExt ordenInternaACrear)
        {
            NumOrdenIntText.Text = GenerarNumeroOrdenInt();
            NumOrdExtText.Text = ordenInternaACrear.NumOrdenExt;
            TipoDeProducto.Text = ordenInternaACrear.TipoProducto;
            Cantidad.Text = ordenInternaACrear.Cantidad;
            Cliente.Text = ordenInternaACrear.Cliente;
            FechaCreacionDT.Value = ordenInternaACrear.FechaCreacion;
            FechaModificacionDT.Value = DateTime.Now;
        }

        // Lista para almacenar los Números De Orden Interna generados previamente
        static List<string> numeroOrdenIntGenerados = new List<string>();

        // Método para generar el Npumero de Orden Interna
        static string GenerarNumeroOrdenInt()
        {
            // Crear una instancia de la clase Random
            Random random = new Random();

            // Generar un nuevo N° de Orden Interna hasta que sea único
            string NumOrdenInt;
            do
            {
                // Generar 3 dígitos aleatorios
                int numeros = GenerarNumeros(8);
                NumOrdenInt = numeros.ToString("D8");
            } while (numeroOrdenIntGenerados.Contains(NumOrdenInt));

            // Agregar el N° de orden interna generado a la lista
            numeroOrdenIntGenerados.Add(NumOrdenInt);

            // Devolver el N° de orden interna generado
            return NumOrdenInt;
        }

        // Método para generar números aleatorios
        static int GenerarNumeros(int cantidad)
        {
            // Crear una instancia de la clase Random
            Random random = new Random();
            return random.Next((int)Math.Pow(10, cantidad));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
