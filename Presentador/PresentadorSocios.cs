using ADMBiblioteca.Servicio.Vista;
using Modelos;
using Modelos.Helpres;
using Presnetador.Vistas;
using System.Text.RegularExpressions;

namespace Presnetador
{
    class PresentadorSocios
    {
        private IVistaSocio formularioBibilio;
        private Socio socioModelo;
        private Ejemplar ejemplarModelo;

        public PresentadorSocios(IVistaSocio formularioBibilio)
        {
            this.formularioBibilio = formularioBibilio;
            socioModelo = new Socio("", "", 0, 0, Categoria.comun);
            ejemplarModelo = new Ejemplar(100, "", "", 100, "");

            formularioBibilio.VisualizarSocios(socioModelo.SetSocios());
        }


        public Dictionary<string, string> CargarDatosSocioSeleccionado(string socio)
        {
            Dictionary<string, string> DatosSocio = new Dictionary<string, string>();

            try
            {

                var socios = socioModelo.GetSociosDB();
                var seleccionado = socios.Find(x => x.DNI == Convert.ToInt32(DevolverClave(socio)));


                DatosSocio.Add("Apellido", seleccionado.Apellido);
                DatosSocio.Add("Nombre", seleccionado.Nombre);
                DatosSocio.Add("DNI", seleccionado.DNI.ToString());
                DatosSocio.Add("Categoria", seleccionado.categoria.ToString());
                DatosSocio.Add("EjemplaresRetirados", seleccionado.EjemplaresRetirados.ToString());
                DatosSocio.Add("Ejemplar", "Hola");
                DatosSocio.Add("Ejemplar1", "zzz");
                DatosSocio.Add("Ejemplar2", "aaa");


                return DatosSocio;
            }
            catch (Exception)
            {
                return DatosSocio;
            }

        }

        public Dictionary<string, string> CargarDatosEjemplaresSocioSeleccionado(string socio)
        {
            Dictionary<string, string> DatosEjemplar = new Dictionary<string, string>();

            try
            {
                var Ejemplares = socioModelo.GetEjemplares(DevolverClave(socio));

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

        public Dictionary<string, string> DevolverEjemplar(string socio, string ejemplar)
        {
            Dictionary<string, string> DatosEjemplar = new Dictionary<string, string>();

            try
            {

                var Ejemplares = ejemplarModelo.DevolverEjemplaresByIdLibro(DevolverClave(socio), DevolverClave(ejemplar));

                foreach (var ejemp in Ejemplares)
                {
                    DatosEjemplar.Add(ejemp.NumeroEdicion.ToString(),ejemp.Nombre);
                }


                return DatosEjemplar;
            }
            catch (Exception)
            {
                return DatosEjemplar;
            }

        }


        public Dictionary<string, string> PrestarEjemplar(string ejemplar, string socio)
        {
            Dictionary<string, string> DatosEjemplar = new Dictionary<string, string>();

            try
            {

                var Ejemplares = ejemplarModelo.PrestarEjemplar(DevolverClave(socio), DevolverClave(ejemplar));

                foreach (var ejemp in Ejemplares)
                {
                    DatosEjemplar.Add(ejemp.NumeroEdicion.ToString(), ejemp.Nombre);
                }


                return DatosEjemplar;
            }
            catch (Exception)
            {
                return DatosEjemplar;
            }

        }

        public string CargarHistorialPrestamos(string socio)
        {
            String Historial = "";

            try
            {
                Historial = socioModelo.GetHistorialPrestamo(DevolverClave(socio));


                return Historial;
            }
            catch (Exception)
            {
                return Historial;
            }

        }

        public string DevolverClave(string clave)
        {
            Match m = Regex.Match(clave, "(\\d+)");
            string num = string.Empty;
            if (m.Success)
            {
                num = m.Value;
            }

            return num;
        }

        public string DevolverCuota(string socio)
        {
            
            return socioModelo.GetCuotaSocio(DevolverClave(socio));

        }
    }
}
