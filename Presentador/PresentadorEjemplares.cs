using ADMBiblioteca.Presentador.Vistas;
using Modelos;
using Presnetador.Vistas;

namespace ADMBiblioteca.Presentador
{
    class PresentadorEjemplares
    {

        private IVistaEjemplares formularioBibilio;
        private Ejemplar ejemplarModelo;

        public PresentadorEjemplares(IVistaEjemplares formularioBibilio)
        {
            ejemplarModelo = new Ejemplar(100, "", "", 100, "");

        }

        public Dictionary<string, string> CargarDatosEjemplares()
        {
            Dictionary<string, string> DatosEjemplar = new Dictionary<string, string>();

            try
            {

                var Ejemplares = ejemplarModelo.GetEjemplares();

                foreach (var ejemplar in Ejemplares)
                {
                    DatosEjemplar.Add(ejemplar.Codigo.ToString(), ejemplar.Nombre);
                }


                return DatosEjemplar;
            }
            catch (Exception)
            {
                return DatosEjemplar;
            }

        }

    }
}
