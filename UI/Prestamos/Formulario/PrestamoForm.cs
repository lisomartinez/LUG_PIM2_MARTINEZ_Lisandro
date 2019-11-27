using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Prestamos.Controles;
using UI.Publicaciones;
using UI.Socios;

namespace UI.Prestamos
{
    public partial class PrestamoForm : Form, IPrestamoVista
    {
        private PrestamoPresentador _presentador;
        public PrestamoForm()
        {
            InitializeComponent();
            _presentador = new PrestamoPresentador(this);
            _presentador.MostrarPrestamos();
            _presentador.MostrarSocios();
        }

        private void PrestamoForm_Load(object sender, EventArgs e)
        {

        }

        public List<PrestamoDto> Prestamos
        {
            get => throw new NotImplementedException();
            set
            {
                PrestamosDGV.DataSource = null;
                PrestamosDGV.DataSource = value;
            }
        }

        public List<SocioDto> Socios
        {
            get => throw new NotImplementedException();
            set
            {
                SociosDGV.DataSource = null;
                SociosDGV.DataSource = value;
            }
        }

        public List<LibroDto> Libros
        {
            get => throw new NotImplementedException();
            set
            {
                LibrosDGV.DataSource = null;
                LibrosDGV.DataSource = value;
            }
        }

        public LibroDto Libro
        {
            get => LibrosDGV.SelectedRows[0].DataBoundItem as LibroDto;
            set => throw new NotImplementedException();
        }

        public SocioDto Socio
        {
            get => SociosDGV.SelectedRows[0].DataBoundItem as SocioDto;
            set => throw new NotImplementedException();
        }

        public DateTime FechaDevolucion
        {
            get => DatosPrestamo.FechaPublicacion;
            set => DatosPrestamo.FechaPublicacion = value;
        }

        public int Numero
        {
            get => DatosPrestamo.Numero;
            set => DatosPrestamo.Numero = value;
        }

        public PrestamoDto Prestamo
        {
            get => PrestamosDGV.SelectedRows[0].DataBoundItem as PrestamoDto;
            set => throw new NotImplementedException();
        }

        public DatosPrestamo DatosPrestamoControl
        {
            get => DatosPrestamo;
            set => throw new NotImplementedException();
        }

        private void PrestarBTN_Click(object sender, EventArgs e)
        {
            _presentador.PrestarLibro();
        }

        private void DevolverBTN_Click(object sender, EventArgs e)
        {
            _presentador.DevolverLibro();
        }

        public void MostrarMensaje(string exceptionMessage)
        {
            MessageBox.Show(exceptionMessage);
        }
    }
}
