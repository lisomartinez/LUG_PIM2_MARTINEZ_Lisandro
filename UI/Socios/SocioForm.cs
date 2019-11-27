using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tests;

namespace UI.Socios
{
    public partial class SocioForm : Form, ISocioVista
    {
        private SocioPresentador _presentador;

        public SocioForm()
        {
            InitializeComponent();
            _presentador = new SocioPresentador(this);
            _presentador.MostrarSocios();
        }

        private void SocioForm_Load(object sender, EventArgs e)
        {

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

        public int NroSocio
        {
            get => DatosSocio.NroSocio;
            set => DatosSocio.NroSocio = value;
        }

        public string Nombre
        {
            get => DatosSocio.Nombre;
            set => DatosSocio.Nombre = value;
        }

        public string Apellido
        {
            get => DatosSocio.Apellido;
            set => DatosSocio.Apellido = value;
        }

        public bool Activo
        {
            get => DatosSocio.Activo;
            set => DatosSocio.Activo = value;
        }

        public SocioDto Socio
        {
            get => SociosDGV.SelectedRows[0].DataBoundItem as SocioDto;
            set => throw new NotImplementedException();
        }

        private void nombreApellido1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombreApellido1_Load_1(object sender, EventArgs e)
        {

        }

        private void SociosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _presentador.MostrarSocio();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            _presentador.Eliminar();
        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            _presentador.Modificar();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            _presentador.Guardar();
        }
    }
}
