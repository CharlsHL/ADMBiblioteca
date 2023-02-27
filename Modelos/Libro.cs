namespace Modelos
{
    public class Libro
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }


        public string Autor { get; set; }


        public Libro(int codigo, string nombre, string autor)
        {
            Codigo = codigo;
            Nombre = nombre;
            Autor = autor;
        }



    }
}
