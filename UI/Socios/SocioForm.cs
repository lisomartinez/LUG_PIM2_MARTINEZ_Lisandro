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
    }
}
