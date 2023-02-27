namespace ADMBiblioteca
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombreBiblioteca = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbDireccionCarga = new System.Windows.Forms.Label();
            this.panelSocio = new System.Windows.Forms.Panel();
            this.llbHistorialPrestamo = new System.Windows.Forms.LinkLabel();
            this.btDevolucion = new System.Windows.Forms.Button();
            this.lstLibrosPrestadosASocio = new System.Windows.Forms.ListBox();
            this.lbEjemplaresRetirados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLibros = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbDNISocio = new System.Windows.Forms.Label();
            this.lbApellidoSocio = new System.Windows.Forms.Label();
            this.lbNombreSocio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPrestar = new System.Windows.Forms.Button();
            this.lstLibrosAprestar = new System.Windows.Forms.ListBox();
            this.lbNombreBiblitecaLD = new System.Windows.Forms.Label();
            this.cmbSocios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTXThistorial = new System.Windows.Forms.Label();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.lbHistorialCompleto = new System.Windows.Forms.Label();
            this.panelSocio.SuspendLayout();
            this.panelHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombreBiblioteca
            // 
            this.lbNombreBiblioteca.AutoSize = true;
            this.lbNombreBiblioteca.Location = new System.Drawing.Point(12, 24);
            this.lbNombreBiblioteca.Name = "lbNombreBiblioteca";
            this.lbNombreBiblioteca.Size = new System.Drawing.Size(115, 15);
            this.lbNombreBiblioteca.TabIndex = 0;
            this.lbNombreBiblioteca.Text = "Nombre biblioteca : ";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(249, 24);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(66, 15);
            this.lbDireccion.TabIndex = 1;
            this.lbDireccion.Text = "Direccion : ";
            // 
            // lbDireccionCarga
            // 
            this.lbDireccionCarga.AutoSize = true;
            this.lbDireccionCarga.Location = new System.Drawing.Point(321, 24);
            this.lbDireccionCarga.Name = "lbDireccionCarga";
            this.lbDireccionCarga.Size = new System.Drawing.Size(54, 15);
            this.lbDireccionCarga.TabIndex = 2;
            this.lbDireccionCarga.Text = "Calle 123";
            // 
            // panelSocio
            // 
            this.panelSocio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSocio.Controls.Add(this.llbHistorialPrestamo);
            this.panelSocio.Controls.Add(this.btDevolucion);
            this.panelSocio.Controls.Add(this.lstLibrosPrestadosASocio);
            this.panelSocio.Controls.Add(this.lbEjemplaresRetirados);
            this.panelSocio.Controls.Add(this.label5);
            this.panelSocio.Controls.Add(this.lbLibros);
            this.panelSocio.Controls.Add(this.lbCategoria);
            this.panelSocio.Controls.Add(this.lbDNISocio);
            this.panelSocio.Controls.Add(this.lbApellidoSocio);
            this.panelSocio.Controls.Add(this.lbNombreSocio);
            this.panelSocio.Controls.Add(this.label4);
            this.panelSocio.Controls.Add(this.label3);
            this.panelSocio.Controls.Add(this.label2);
            this.panelSocio.Controls.Add(this.label1);
            this.panelSocio.Location = new System.Drawing.Point(190, 107);
            this.panelSocio.Name = "panelSocio";
            this.panelSocio.Size = new System.Drawing.Size(514, 212);
            this.panelSocio.TabIndex = 5;
            // 
            // llbHistorialPrestamo
            // 
            this.llbHistorialPrestamo.AutoSize = true;
            this.llbHistorialPrestamo.Enabled = false;
            this.llbHistorialPrestamo.Location = new System.Drawing.Point(3, 153);
            this.llbHistorialPrestamo.Name = "llbHistorialPrestamo";
            this.llbHistorialPrestamo.Size = new System.Drawing.Size(112, 15);
            this.llbHistorialPrestamo.TabIndex = 12;
            this.llbHistorialPrestamo.TabStop = true;
            this.llbHistorialPrestamo.Text = "Historial prestamos ";
            this.llbHistorialPrestamo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbHistorialPrestamo_LinkClicked);
            // 
            // btDevolucion
            // 
            this.btDevolucion.Location = new System.Drawing.Point(261, 156);
            this.btDevolucion.Name = "btDevolucion";
            this.btDevolucion.Size = new System.Drawing.Size(186, 34);
            this.btDevolucion.TabIndex = 11;
            this.btDevolucion.Text = "Devolver libro";
            this.btDevolucion.UseVisualStyleBackColor = true;
            this.btDevolucion.Click += new System.EventHandler(this.btDevolucion_Click);
            // 
            // lstLibrosPrestadosASocio
            // 
            this.lstLibrosPrestadosASocio.FormattingEnabled = true;
            this.lstLibrosPrestadosASocio.ItemHeight = 15;
            this.lstLibrosPrestadosASocio.Location = new System.Drawing.Point(261, 71);
            this.lstLibrosPrestadosASocio.Name = "lstLibrosPrestadosASocio";
            this.lstLibrosPrestadosASocio.Size = new System.Drawing.Size(186, 79);
            this.lstLibrosPrestadosASocio.TabIndex = 10;
            this.lstLibrosPrestadosASocio.SelectedIndexChanged += new System.EventHandler(this.lstLibrosPrestadosASocio_SelectedIndexChanged);
            // 
            // lbEjemplaresRetirados
            // 
            this.lbEjemplaresRetirados.AutoSize = true;
            this.lbEjemplaresRetirados.Location = new System.Drawing.Point(389, 17);
            this.lbEjemplaresRetirados.Name = "lbEjemplaresRetirados";
            this.lbEjemplaresRetirados.Size = new System.Drawing.Size(10, 15);
            this.lbEjemplaresRetirados.TabIndex = 10;
            this.lbEjemplaresRetirados.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ejemplares retirados  :";
            // 
            // lbLibros
            // 
            this.lbLibros.AutoSize = true;
            this.lbLibros.Location = new System.Drawing.Point(261, 47);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(105, 15);
            this.lbLibros.TabIndex = 7;
            this.lbLibros.Text = "Libros prestados  : ";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(76, 114);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(0, 15);
            this.lbCategoria.TabIndex = 8;
            // 
            // lbDNISocio
            // 
            this.lbDNISocio.AutoSize = true;
            this.lbDNISocio.Location = new System.Drawing.Point(45, 80);
            this.lbDNISocio.Name = "lbDNISocio";
            this.lbDNISocio.Size = new System.Drawing.Size(0, 15);
            this.lbDNISocio.TabIndex = 7;
            // 
            // lbApellidoSocio
            // 
            this.lbApellidoSocio.AutoSize = true;
            this.lbApellidoSocio.Location = new System.Drawing.Point(69, 48);
            this.lbApellidoSocio.Name = "lbApellidoSocio";
            this.lbApellidoSocio.Size = new System.Drawing.Size(0, 15);
            this.lbApellidoSocio.TabIndex = 6;
            // 
            // lbNombreSocio
            // 
            this.lbNombreSocio.AutoSize = true;
            this.lbNombreSocio.Location = new System.Drawing.Point(69, 18);
            this.lbNombreSocio.Name = "lbNombreSocio";
            this.lbNombreSocio.Size = new System.Drawing.Size(0, 15);
            this.lbNombreSocio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre  :";
            // 
            // btPrestar
            // 
            this.btPrestar.Location = new System.Drawing.Point(12, 296);
            this.btPrestar.Name = "btPrestar";
            this.btPrestar.Size = new System.Drawing.Size(162, 23);
            this.btPrestar.TabIndex = 8;
            this.btPrestar.Text = "Prestar libro";
            this.btPrestar.UseVisualStyleBackColor = true;
            this.btPrestar.Click += new System.EventHandler(this.btPrestar_Click);
            // 
            // lstLibrosAprestar
            // 
            this.lstLibrosAprestar.FormattingEnabled = true;
            this.lstLibrosAprestar.ItemHeight = 15;
            this.lstLibrosAprestar.Location = new System.Drawing.Point(12, 166);
            this.lstLibrosAprestar.Name = "lstLibrosAprestar";
            this.lstLibrosAprestar.Size = new System.Drawing.Size(162, 124);
            this.lstLibrosAprestar.TabIndex = 11;
            this.lstLibrosAprestar.SelectedIndexChanged += new System.EventHandler(this.lstLibrosAprestar_SelectedIndexChanged);
            // 
            // lbNombreBiblitecaLD
            // 
            this.lbNombreBiblitecaLD.AutoSize = true;
            this.lbNombreBiblitecaLD.Location = new System.Drawing.Point(124, 24);
            this.lbNombreBiblitecaLD.Name = "lbNombreBiblitecaLD";
            this.lbNombreBiblitecaLD.Size = new System.Drawing.Size(28, 15);
            this.lbNombreBiblitecaLD.TabIndex = 12;
            this.lbNombreBiblitecaLD.Text = ".......";
            // 
            // cmbSocios
            // 
            this.cmbSocios.FormattingEnabled = true;
            this.cmbSocios.Location = new System.Drawing.Point(12, 107);
            this.cmbSocios.Name = "cmbSocios";
            this.cmbSocios.Size = new System.Drawing.Size(162, 23);
            this.cmbSocios.TabIndex = 13;
            this.cmbSocios.SelectedIndexChanged += new System.EventHandler(this.cmbSocios_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seleccione socio : ";
            // 
            // lbTXThistorial
            // 
            this.lbTXThistorial.AutoSize = true;
            this.lbTXThistorial.Location = new System.Drawing.Point(8, 11);
            this.lbTXThistorial.Name = "lbTXThistorial";
            this.lbTXThistorial.Size = new System.Drawing.Size(107, 15);
            this.lbTXThistorial.TabIndex = 16;
            this.lbTXThistorial.Text = "Historial prestamo:";
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelHistorial.Controls.Add(this.lbHistorialCompleto);
            this.panelHistorial.Controls.Add(this.lbTXThistorial);
            this.panelHistorial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHistorial.Location = new System.Drawing.Point(0, 439);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(818, 100);
            this.panelHistorial.TabIndex = 17;
            this.panelHistorial.Visible = false;
            // 
            // lbHistorialCompleto
            // 
            this.lbHistorialCompleto.AutoSize = true;
            this.lbHistorialCompleto.Location = new System.Drawing.Point(20, 41);
            this.lbHistorialCompleto.Name = "lbHistorialCompleto";
            this.lbHistorialCompleto.Size = new System.Drawing.Size(0, 15);
            this.lbHistorialCompleto.TabIndex = 17;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 539);
            this.Controls.Add(this.panelHistorial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSocios);
            this.Controls.Add(this.lbNombreBiblitecaLD);
            this.Controls.Add(this.lstLibrosAprestar);
            this.Controls.Add(this.btPrestar);
            this.Controls.Add(this.panelSocio);
            this.Controls.Add(this.lbDireccionCarga);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombreBiblioteca);
            this.Name = "Inicio";
            this.Text = "Biblioteca 1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panelSocio.ResumeLayout(false);
            this.panelSocio.PerformLayout();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNombreBiblioteca;
        private Label lbDireccion;
        private Label lbDireccionCarga;
        private Panel panelSocio;
        private Label label3;
        private Label label1;
        private Label lbCategoria;
        private Label lbDNISocio;
        private Label lbNombreSocio;
        private Label label4;
        private Label lbEjemplaresRetirados;
        private Label label5;
        private Label lbLibros;
        private Button btPrestar;
        private ListBox lstSocios;
        private ListBox lstLibrosPrestadosASocio;
        private ListBox lstLibrosAprestar;
        private Label lbNombreBiblitecaLD;
        private Label lbApellidoSocio;
        private Label label2;
        private ComboBox cmbSocios;
        private Button btDevolucion;
        private LinkLabel llbHistorialPrestamo;
        private Label label6;
        private Label lbTXThistorial;
        private Panel panelHistorial;
        private Label lbHistorialCompleto;
    }
}