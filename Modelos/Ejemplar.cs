using ADMBiblioteca.Servicio;

namespace Modelos
{
    public class Ejemplar : Libro
    {
        public int NumeroEdicion { get; set; }
        public string Ubicacion { get; set; }


        public Ejemplar(int codigo, string nombre, string autor,int numeroEdicion,string ubicacion) : base(codigo, nombre, autor)
        {
            this.NumeroEdicion = numeroEdicion;
            this.Ubicacion = ubicacion;

        }

        public List<Ejemplar> GetEjemplares()
        {
            DBContext contexto = new DBContext();

            var ejemplares = contexto.GetEjemplarares();


            return ejemplares;
        }

        public List<Ejemplar> DevolverEjemplaresByIdLibro(string socio, string ejemplar)
        {
            DBContext contexto = new DBContext();

            var ejemplares = contexto.DevolverEjemplar(socio,ejemplar);


            return ejemplares;
        }

        public List<Ejemplar> PrestarEjemplar(string socio, string ejemplar)
        {
            DBContext contexto = new DBContext();

            var ejemplares = contexto.PrestarrEjemplar(socio, ejemplar);


            return ejemplares;
        }
    }
}
