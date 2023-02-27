using Modelos;

namespace ADMBiblioteca.Servicio.Vista
{
    interface IContextoBD
    {
        void GenerarBiblioteca();

        List<Socio> obtenerSocios();
    }
}
