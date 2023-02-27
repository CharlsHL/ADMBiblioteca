using ADMBiblioteca.Servicio.Vista;
using Modelos;
using Modelos.Helpres;
using System.Data;
using System.Data.SqlClient;

namespace ADMBiblioteca.Servicio
{
    public class DBContext : IContextoBD
    {
        SqlConnection conexionBD = new SqlConnection(@"Server=UNKNOWS\SQLEXPRESS01;database=Biblioteca;integrated security = true");

        string historial = "";
        public void GenerarBiblioteca()
        {

            try
            {

                SqlCommand command = new SqlCommand("SELECT * FROM socio;", conexionBD);
                conexionBD.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();

                    //Socios
                    string stringCommand = "INSERT INTO socio (Nombre,Apellido,DNI,Categoria,EjemplaresRetirados)" +
                                            "VALUES ('Carlos','Benit',12334,1,1)";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO socio (Nombre,Apellido,DNI,Categoria,EjemplaresRetirados)" +
                                                                "VALUES ('Juan','Perez',3312,2,1)";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    //Libros
                    stringCommand = "INSERT INTO Libro (Nombre,Autor)"+"VALUES ('Relato de un naufrago','G.Garcia Maquez')";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO Libro (Nombre,Autor)" +"VALUES ('Borra del cafe','xxx')";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();


                    //Ejemplares
                    stringCommand = "INSERT INTO Ejemplar(Edicion,Ubicacion,IdLibro)" + "VALUES ('12','Z1',1)";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO Ejemplar (Edicion,Ubicacion,IdLibro)" + "VALUES ('13','Z2',2)";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    //Prestamos

                    stringCommand = "INSERT INTO Prestamo (IdSocio,FechaPrestamo,IdEjemplar,Estado)" + "VALUES ('2','2023-10-06 15:24:16.000',2,1)";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO Prestamo (IdSocio,FechaPrestamo,IdEjemplar,Estado)" + "VALUES ('3','2023-10-06 15:24:16.000',1,1)";
                    command = new SqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionBD.Close();
        }

   

        public List<Socio> obtenerSocios()
        {
            List<Socio> socios = new List<Socio> ();


            try
            {

                SqlCommand command = new SqlCommand("SELECT * FROM socio;", conexionBD);
                conexionBD.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    socios.Add(ConvertirEnSocio(reader));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return socios;
        }



        public string obtenerHistorialSocio( string DNI)
        {
            int id = 0;
            String HistorialSocio = "";
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM socio where socio.DNI = " + DNI + ";", conexionBD);
                conexionBD.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    break;
                }
                conexionBD.Close();

                command = new SqlCommand("select libro.Nombre ,Libro.autor, Ejemplar.edicion,Prestamo.FechaPrestamo,Prestamo.estado from prestamo inner join ejemplar on Ejemplar.Id = prestamo.IdEjemplar inner join socio on " + id + " = Prestamo.IdSocio inner join Libro on Libro.Id = Ejemplar.IdLibro order by Prestamo.FechaPrestamo desc", conexionBD);
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    HistorialSocio = GenerarHistorial(reader);
                }
                conexionBD.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return HistorialSocio;

        }


        private static Socio ConvertirEnSocio(IDataReader reader)
        {

            Categoria categoriaSocio = Categoria.comun;
            switch (Convert.ToInt32(reader["Categoria"]))
            {
                case 0:
                    categoriaSocio = Categoria.comun;
                    break;
                case 1:
                    categoriaSocio = Categoria.VIP;
                    break;

            }


            Socio socio = new Socio(Convert.ToString(reader["Nombre"]),
                                    Convert.ToString(reader["Apellido"]),
                                    Convert.ToInt32(reader["DNI"]),
                                    Convert.ToInt32(reader["EjemplaresRetirados"]),
                                    categoriaSocio);
          
            return socio;
        }

        public List<Ejemplar> obtenerEjemplaresSocio(string DNI)
        {
            List<Ejemplar> ejemplars = new List<Ejemplar>();
            int id = 0; 

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM socio where socio.DNI = " + DNI +";", conexionBD);
                conexionBD.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    break;
                }
                conexionBD.Close();

                command = new SqlCommand(
                    "select libro.id, libro.Nombre ,Libro.autor, Ejemplar.edicion,ejemplar.ubicacion from prestamo inner join ejemplar on Ejemplar.Id = prestamo.IdEjemplar inner join socio on " + id+" = Prestamo.IdSocio inner join Libro on Libro.Id = Ejemplar.IdLibro and prestamo.estado = 1", conexionBD);
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ejemplars.Add(ConvertirEnEjemplares(reader));
                }
                conexionBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ejemplars;
        }

        public List<Ejemplar> GetEjemplarares()
        {
            List<Ejemplar> ejemplars = new List<Ejemplar>();

            try
            {
                SqlCommand  command = new SqlCommand("select  *from Libro inner join Ejemplar on libro.Id = Ejemplar.IdLibro", conexionBD);
                conexionBD.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ejemplars.Add(ConvertirEnEjemplares(reader));
                }
                conexionBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ejemplars;
        }


        private static Ejemplar ConvertirEnEjemplares(IDataReader reader)
        {


            Ejemplar ejemplar = new Ejemplar(
                                    Convert.ToInt32(reader["Id"]),
                                    Convert.ToString(reader["Nombre"]),
                                    Convert.ToString(reader["Autor"]),
                                    Convert.ToInt32(reader["Edicion"]),
                                    Convert.ToString(reader["Ubicacion"]));

            return ejemplar;
        }

        private  String GenerarHistorial(IDataReader reader)
        {
            String estado = "";
            if(Convert.ToInt32(reader["estado"]) == 0)
            {
                estado = "Devuelto";
            }
            else
            {
                estado = "Aun no devuelto";
            }

            historial +="Libro prestado : "+ Convert.ToString(reader["Nombre"]) + "  del autor  " + Convert.ToString(reader["Autor"]) + "  Fecha prestamo : " + Convert.ToDateTime(reader["FechaPrestamo"]) + "  Estado de este ejemplar : " + estado +Environment.NewLine;

            return historial;
        }

        public List<Ejemplar> DevolverEjemplar(string ejemplar,string DNI)
        {
            List<Ejemplar> ejemplars = new List<Ejemplar>();
            int idSocio = 0;
            int socioDni = 0;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM socio where socio.DNI = " + DNI + ";", conexionBD);
                conexionBD.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idSocio = Convert.ToInt32(reader["Id"]);
                    socioDni = Convert.ToInt32(reader["DNI"]);
                    break;
                }
                conexionBD.Close();

                command = new SqlCommand("update Prestamo set estado = 0 where IdSocio = "+ idSocio + " and IdEjemplar = "+ ejemplar , conexionBD);
                conexionBD.Open();
                reader = command.ExecuteReader();


                conexionBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return obtenerEjemplaresSocio(socioDni.ToString());
        }


        public List<Ejemplar> PrestarrEjemplar(string DNI, string ejemplar)
        {
            List<Ejemplar> ejemplars = new List<Ejemplar>();
            int idSocio = 0;
            int socioDni = 0;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM socio where socio.DNI = " + DNI + ";", conexionBD);
                conexionBD.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idSocio = Convert.ToInt32(reader["Id"]);
                    socioDni = Convert.ToInt32(reader["DNI"]);
                    break;
                }
                conexionBD.Close();
                command = new SqlCommand("INSERT INTO Prestamo (IdSocio,FechaPrestamo,IdEjemplar,Estado)" + "VALUES ("+idSocio + ",'"+DateTime.Now.ToString()+"',"+ejemplar+",1)", conexionBD);
                conexionBD.Open();
                reader = command.ExecuteReader();


                conexionBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return obtenerEjemplaresSocio(socioDni.ToString());
        }
    }
}
