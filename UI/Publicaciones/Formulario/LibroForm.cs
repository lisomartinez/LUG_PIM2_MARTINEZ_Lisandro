using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Autores;

namespace UI.Publicaciones
{
    public partial class LibroForm : Form, ILibroVista
    {
        private LibroPresentador _presentador;

        public LibroForm()
        {
            InitializeComponent();
            _presentador = new LibroPresentador(this);
            _presentador.MostrarLibros();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            _presentador.Guardar();
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

        public int Numero
        {
            get => DatosLibro.Numero;
            set => DatosLibro.Numero = value;
        }

        public string Titulo
        {
            get => DatosLibro.Titulo;
            set => DatosLibro.Titulo = value;
        }

        public string Editorial
        {
            get => DatosLibro.Editorial;
            set => DatosLibro.Editorial = value;
        }

        public DateTime Fecha
        {
            get => DatosLibro.Fecha;
            set => DatosLibro.Fecha = value;
        }

        public string Isbn { get; set; }
        public List<AutorDto> Autores
        {
            get => throw new NotImplementedException();
            set
            {
                AutoresLibroLB.DataSource = null;
                AutoresLibroLB.DataSource = value;
            }
        }

        public List<AutorDto> ListaAutores
        {
            get => throw new NotImplementedException();
            set
            {
                AutoresLB.DataSource = null;
                AutoresLB.DataSource = value;
            }
        }

        public AutorDto AutorSeleccionado
        {
            get => AutoresLB.SelectedItem as AutorDto;
            set => throw new NotImplementedException();
        }

        public AutorDto AutorLibroSeleccionado
        {
            get => AutoresLibroLB.SelectedItem as AutorDto;
            set => throw new NotImplementedException();
        }

        public DatosLibro DatosLibroControl
        {
            get => DatosLibro;
            set => throw new NotImplementedException();
        }

        private void LibrosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _presentador.MostrarLibro();
        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            _presentador.Modificar();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            _presentador.Eliminar();
        }

        private void AgregarAutorButton_Click(object sender, EventArgs e)
        {
            _presentador.AgregarAutorALibro();
        }

        private void EliminarAutorButton_Click(object sender, EventArgs e)
        {
            _presentador.EliminarAutorDeLibro();
        }

        private void LibroForm_Load(object sender, EventArgs e)
        {

        }
        public void MostrarMensaje(string exceptionMessage)
        {
            MessageBox.Show(exceptionMessage);
        }
    }
}
