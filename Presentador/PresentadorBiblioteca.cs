using ADMBiblioteca.Presentador.Vistas;
using ADMBiblioteca.Servicio;
using ADMBiblioteca.Servicio.Vista;
using Modelos;

namespace ADMBiblioteca.Presentador
{
    internal class PresentadorBiblioteca
    {

        private IVistaBiblioteca formularioBibilio;
        private Biblioteca bibliotecaModelo;
        private IContextoBD BibliotecaDB;

        public PresentadorBiblioteca(IVistaBiblioteca formularioBibilio)
        {
            this.formularioBibilio = formularioBibilio;

            this.BibliotecaDB = new DBContext();

            bibliotecaModelo = new Biblioteca("Nuevo Libro", "Calle falsa 123");

            this.BibliotecaDB.GenerarBiblioteca(); // esto genera la BD la primera vez

            formularioBibilio.VisualizarBibiliteca(bibliotecaModelo.nombre,bibliotecaModelo.direccion);
        }

        public Dictionary<string, string> CargarEjemplares(string socio)
        {
            Dictionary<string, string> DatosEjemplar = new Dictionary<string, string>();

            try
            {


                return DatosEjemplar;
            }
            catch (Exception)
            {
                return DatosEjemplar;
            }

        }

    }
}
    