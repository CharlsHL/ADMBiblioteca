using ADMBiblioteca.Servicio;
using Modelos.Helpres;

namespace Modelos
{
    public class Socio
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public int EjemplaresRetirados { get; set; }

        public List<Ejemplar> Ejemplar { get; set; }


        public Categoria categoria { get; set; }

        public Socio(string nombre, string apellido, int dNI, int ejemplaresRetirados, Categoria categoria)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            EjemplaresRetirados = ejemplaresRetirados;
            Ejemplar = null;
            this.categoria = categoria;
        }

        public Dictionary<int, string> SetSocios()
        {
            Dictionary<int, string> socios = new Dictionary<int, string>();

            var Socios = GetSociosDB();

            foreach(var socio in Socios)
            {
                socios.Add(socio.DNI, socio.Nombre + " " + socio.Apellido );
            }


            return socios;
        }

        public List<Ejemplar> GetEjemplares(string dni)
        {
            DBContext contexto = new DBContext();

            var ejemplares = contexto.obtenerEjemplaresSocio(dni);


            return ejemplares;
        }


        public List<Socio> GetSociosDB()
        {
            DBContext contexto = new DBContext();

            var socios = contexto.obtenerSocios();

            return socios.ToList();

        }

        public string GetHistorialPrestamo(string DNI)
        {
            DBContext contexto = new DBContext();
            string historial = "";
            historial = contexto.obtenerHistorialSocio(DNI);

            return historial;
        }

        public string GetCuotaSocio(string DNI)
        {
            DBContext contexto = new DBContext();
            string historial = "";
            historial = contexto.obtenerCuotaSocio(DNI);

            return historial;
        }
    }
}
