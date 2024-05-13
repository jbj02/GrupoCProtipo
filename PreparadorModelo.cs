namespace ProtipoCU2yCU4
{
    internal class PreparadorModelo
    {
        public List<OrdenExt> OrdenesExternas { get; set; }

        public List<OrdenInt> OrdenesInternas { get; set; }
        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public PreparadorModelo()
        {
            OrdenesExternas = new List<OrdenExt>()
            {
                new OrdenExt
                {
                    NumOrdenExt = "25462357",
                    TipoProducto = "Producto A",
                    Cantidad = "2",
                    Cliente = "Mercado Libre",
                    FechaCreacion = new DateTime(2024,5,15)
                },
                new OrdenExt
                {
                    NumOrdenExt = "98765432",
                    TipoProducto = "Producto B",
                    Cantidad = "5",
                    Cliente = "Amazon",
                    FechaCreacion = new DateTime(2024, 5, 16)
                },
                new OrdenExt
                {
                    NumOrdenExt = "12345678",
                    TipoProducto = "Producto C",
                    Cantidad = "3",
                    Cliente = "Walmart",
                    FechaCreacion = new DateTime(2024, 5, 17)
                }
            };

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
                    Estado = "SELECCIONADA",
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
                    Estado = "SELECCIONADA",
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
                    FechaModificacion = new DateTime(2024,5,18),
                    Estado = "SELECCIONADA",
                    LPE = "NO"
                }
            };
        }
    }
}