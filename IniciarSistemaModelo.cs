using GrupoCProtipo;

namespace GrupoCProtipoCU2yCU4
{
    internal class IniciarSistemaModelo
    {
        public List<Credenciales> CredencialesUsuarios {  get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public IniciarSistemaModelo()
        {
            CredencialesUsuarios = new List<Credenciales>()
            {
                new Credenciales
                {
                    Usuario = "TiagYacobo",
                    Clave = "Madrid912",
                    Acceso = "Despachador"
                },
                new Credenciales
                {
                    Usuario = "RominaGuzman",
                    Clave = "DibuMilo!!!", 
                    Acceso = "Despachador"
                }, 
                new Credenciales
                {
                    Usuario = "EstebanJusticia",
                    Clave = "Belgrano260611",
                    Acceso = "Preparador"
                },
                new Credenciales
                {
                    Usuario = "SantiagoValentini",
                    Clave = "Peugeot208",
                    Acceso = "Estibador"
                }
            };
        }
    }
}