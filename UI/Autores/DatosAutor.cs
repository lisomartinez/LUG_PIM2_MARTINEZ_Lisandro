using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Autores
{
    public partial class DatosAutor : UserControl
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

        public int NroAutor
        {
            get => NumeroCampoNumero.Numero;
            set => NumeroCampoNumero.Numero = value;
        }

        public bool Valido => NumeroCampoNumero.Valido() && ApellidoCampoTexto.Valido() && NombreCampoTexto.Valido();

        public DatosAutor()
        {
            InitializeComponent();
        }

        private void NumeroCampoNumero_Load(object sender, EventArgs e)
        {

        }

        private void DatosAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
