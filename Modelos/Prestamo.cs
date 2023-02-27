using ADMBiblioteca.Modelos.Helpres;

namespace Modelos
{
    public class Prestamo
    {
        public Socio Socio { get; set; }
        public Ejemplar Ejemplar { get; set; }  
        public DateTime FechaPrestamo { get; set; }

        public EstadoPrestamo Estado { get; set; }

        public Prestamo(DateTime fechaPrestamo)
        {
            FechaPrestamo = fechaPrestamo;
        }
    }
}
