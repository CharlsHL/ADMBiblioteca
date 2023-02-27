namespace Modelos
{
    public class Biblioteca
    {
        public string nombre { get; set; }
        public string direccion { get; set; }

        public Biblioteca(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}