using ADMBiblioteca.Presentador;
using ADMBiblioteca.Presentador.Vistas;
using ADMBiblioteca.Servicio.Vista;
using Presnetador;
using Presnetador.Vistas;

namespace ADMBiblioteca
{
    public partial class Inicio : Form,IVistaSocio,IVistaBiblioteca,IVistaEjemplares
    {
        private PresentadorSocios presentadorSocios;
        private PresentadorBiblioteca presentadorBiblioteca;
        private PresentadorEjemplares presentadorEjemplares;

        String DatosSocio = "";
        String DatoEjemplarPrestado = "";
        String DatosEjemplarAprestar = "";

        public Inicio()
        {
            InitializeComponent();
            this.presentadorSocios = new PresentadorSocios(this);
            this.presentadorBiblioteca = new PresentadorBiblioteca(this);
            this.presentadorEjemplares = new PresentadorEjemplares(this);
            CargarDatosEjemplares();

        }

        public void VisualizarBibiliteca(string nombre,string direccion)
        {
            lbNombreBiblitecaLD.Text = nombre;
            lbDireccion.Text = direccion;

        }


        public void CargarDatosEjemplares()
        {
            var ejemplares = this.presentadorEjemplares.CargarDatosEjemplares();

            
            foreach (var ejemplar in ejemplares)
            {
                lstLibrosAprestar.Items.Add(ejemplar);
            }


        }

        public void VisualizarSocios(Dictionary<int,string>Socios)
        {

            foreach(var socio in Socios)
            {
                cmbSocios.Items.Add(socio);
            }

        }

        public void CargarDatosSocioSeleccionado(string datos)
        {
            lstLibrosPrestadosASocio.Items.Clear();
            var socio= this.presentadorSocios.CargarDatosSocioSeleccionado(datos);
            var ejemplaresSocio = this.presentadorSocios.CargarDatosEjemplaresSocioSeleccionado(datos);

            lbApellidoSocio.Text = socio["Apellido"];
            lbNombreSocio.Text = socio["Nombre"];
            lbDNISocio.Text = socio["DNI"];
            lbCategoria.Text = socio["Categoria"];
            lbEjemplaresRetirados.Text = socio["EjemplaresRetirados"];

            foreach(var ejemplar in ejemplaresSocio)
            {
                lstLibrosPrestadosASocio.Items.Add(ejemplar);   
            }


        }


        private void cmbSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            llbHistorialPrestamo.Enabled = true;
            DatosSocio = cmbSocios.Text;
            CargarDatosSocioSeleccionado(DatosSocio);
        }

        private void btDevolucion_Click(object sender, EventArgs e)
        {
            if(DatoEjemplarPrestado != "" && DatosSocio != "")
            {
                var ejemplaresSocio = this.presentadorSocios.DevolverEjemplar(DatoEjemplarPrestado, DatosSocio);
                lstLibrosPrestadosASocio.Items.Clear();
                foreach (var ejemplar in ejemplaresSocio)
                {
                    lstLibrosPrestadosASocio.Items.Add(ejemplaresSocio);
                }
            }

        }

        private void lstLibrosPrestadosASocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDevolucion.Enabled = true;
            DatoEjemplarPrestado = sender.ToString();

        }

        private void llbHistorialPrestamo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelHistorial.Visible = true;
            lbHistorialCompleto.Text = "";
            lbHistorialCompleto.Text = this.presentadorSocios.CargarHistorialPrestamos(DatosSocio);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btDevolucion.Enabled = false;
            btPrestar.Enabled = false;
        }

        private void lstLibrosAprestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DatosSocio != "")
            {
                btPrestar.Enabled = true;
                DatosEjemplarAprestar = sender.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un socio al cual se le prestara el libro");
            }

        }

        private void btPrestar_Click(object sender, EventArgs e)
        {
            var ejemplaresSocio = this.presentadorSocios.PrestarEjemplar(DatosEjemplarAprestar, DatosSocio);
            lstLibrosPrestadosASocio.Items.Clear();
            foreach (var ejemplar in ejemplaresSocio)
            {
                lstLibrosPrestadosASocio.Items.Add(ejemplaresSocio);
            }
        }
    }
}