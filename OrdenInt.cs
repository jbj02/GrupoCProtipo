namespace ProtipoCU2yCU4
{
    internal class OrdenInt
    {
        public string NumOrdenInt {  get; set; }
        public string NumOrdenExt { get; set; }
        public string TipoProducto { get; set; }
        public string Cantidad {  get; set; }
        public string Cliente { get; set; }
        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
        public string Estado {  get; set; }
        public string LPE { get; set; }

    //    // Constructor para inicializar el Numero de Orden Interna
    //    public OrdenInt()
    //    {
    //        NumOrdenInt = GenerarNumeroOrdenInt();
    //    }

    //    // Lista para almacenar los Números De Orden Interna generados previamente
    //    static List<string> numeroOrdenIntGenerados = new List<string>();

    //    // Método para generar el Npumero de Orden Interna
    //    static string GenerarNumeroOrdenInt()
    //    {
    //        // Crear una instancia de la clase Random
    //        Random random = new Random();

    //        // Generar un nuevo SKU hasta que sea único
    //        string NumOrdenInt;
    //        do
    //        {
    //            // Generar 3 letras aleatorias
    //            string letras = GenerarLetras(3);

    //            // Generar 3 dígitos aleatorios
    //            int numeros = GenerarNumeros(3);

    //            // Combinar letras y números para formar el SKU
    //            NumOrdenInt = letras + numeros.ToString("D3");
    //        } while (numeroOrdenIntGenerados.Contains(NumOrdenInt));

    //        // Agregar el SKU generado a la lista
    //        numeroOrdenIntGenerados.Add(NumOrdenInt);

    //        // Devolver el SKU generado
    //        return NumOrdenInt;
    //    }

    //    // Método para generar letras aleatorias
    //    static string GenerarLetras(int cantidad)
    //    {
    //        // Crear una instancia de la clase Random
    //        Random random = new Random();
    //        const string letrasPermitidas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //        char[] letrasGeneradas = new char[cantidad];

    //        for (int i = 0; i < cantidad; i++)
    //        {
    //            letrasGeneradas[i] = letrasPermitidas[random.Next(letrasPermitidas.Length)];
    //        }

    //        return new string(letrasGeneradas);
    //    }

    //    // Método para generar números aleatorios
    //    static int GenerarNumeros(int cantidad)
    //    {
    //        // Crear una instancia de la clase Random
    //        Random random = new Random();
    //        return random.Next((int)Math.Pow(10, cantidad));
    //    }
    }
}