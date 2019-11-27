using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Autores
{
    public partial class AutorForm : Form, IAutorVista
    {
        private AutorPresentador _presentador;
        public AutorForm()
        {
            InitializeComponent();
            _presentador = new AutorPresentador(this);
            _presentador.MostrarAutores();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _presentador.MostrarAutor();
        }

        public List<AutorDto> Autores
        {
            get => throw new NotImplementedException();
            set
            {
                AutoresDGV.DataSource = null;
                AutoresDGV.DataSource = value;
            }
        }

        public AutorDto Autor
        {
            get => AutoresDGV.SelectedRows[0].DataBoundItem as AutorDto;
            set => throw new NotImplementedException();
        }

        public int Nro
        {
            get => DatosAutor.NroAutor;
            set => DatosAutor.NroAutor = value;
        }

        public string Nombre
        {
            get => DatosAutor.Nombre;
            set => DatosAutor.Nombre = value;
        }

        public string Apellido
        {
            get => DatosAutor.Apellido;
            set => DatosAutor.Apellido = value;
        }

        public DatosAutor DatosAutorControl
        {
            get => DatosAutor;
            set => throw new NotImplementedException();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            _presentador.Guardar();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            _presentador.Modificar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            _presentador.Eliminar();
        }

        private void AutorForm_Load(object sender, EventArgs e)
        {

        }

        public void MostrarMensaje(string exceptionMessage)
        {
            MessageBox.Show(exceptionMessage);
        }
    }
}
