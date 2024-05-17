using ProtipoCU2yCU4;

namespace GrupoCProtipoCU2yCU4
{
    internal class EstibadorModelo
    {
        public List<OrdenInt> OrdenesInternas { get; set; }
        public OrdenInt OrdenInternaPorModificar { get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public EstibadorModelo()
        {
            OrdenesInternas = new List<OrdenInt>()
            {
                new OrdenInt
                {
                    NumOrdenInt = "65839573",
                    NumOrdenExt = "25462357",
                    TipoProducto = "Producto A",
                    Cantidad = "2",
                    Cliente = "Mercado Libre",
                    FechaCreacion = new DateTime(2024,5,15),
                    FechaModificacion = new DateTime(2024,5,16),
                    LPE = "NO"
                },
                new OrdenInt
                {
                    NumOrdenInt = "74949275",
                    NumOrdenExt = "98765432",
                    TipoProducto = "Producto B",
                    Cantidad = "5",
                    Cliente = "Amazon",
                    FechaCreacion = new DateTime(2024, 5, 16),
                    FechaModificacion = new DateTime(2024,5,17),
                    LPE = "NO"
                },
                new OrdenInt
                {
                    NumOrdenInt = "67594852",
                    NumOrdenExt = "12345678",
                    TipoProducto = "Producto C",
                    Cantidad = "3",
                    Cliente = "Walmart",
                    FechaCreacion = new DateTime(2024, 5, 17),
                    FechaModificacion = new DateTime(2024, 5, 17),
                    LPE = "NO"
                }
            };
        }        
    }
}