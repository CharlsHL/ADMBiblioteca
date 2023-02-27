using Modelos;

namespace Presnetador.Vistas
{
    interface  IVistaSocio
    {

        void VisualizarSocios(Dictionary<int,string> socios);

        void CargarDatosSocioSeleccionado(string datos);

    }
}
