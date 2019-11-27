using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Shared;

namespace UI
{
    public partial class NombreApellido : UserControl
    {

        public string Nombre
        {
            get => NombreCampoTexto.Texto;
            set => NombreCampoTexto.Texto = value;
        }

        public string Apellido
        {
            get => ApellidoCampoTexto.Texto;
            set => ApellidoCampoTexto.Texto = value;
        }

        public int NroSocio
        {
            get => NumeroCampoNumero.Numero;
            set => NumeroCampoNumero.Numero = value;
        }

        public bool Activo
        {
            get => ActivoCheckBox.Checked;
            set => ActivoCheckBox.Checked = value;
        }

        public NombreApellido()
        {
            InitializeComponent();
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreApellido_Load(object sender, EventArgs e)
        {

        }

        private void ApellidoCampoTexto_Load(object sender, EventArgs e)
        {

        }

        private void NumeroCampoNumero_Load(object sender, EventArgs e)
        {

        }

        private void NroSocioLabel_Click(object sender, EventArgs e)
        {

        }

        private void NombreCampoTexto_Load(object sender, EventArgs e)
        {

        }

        private void ApellidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
