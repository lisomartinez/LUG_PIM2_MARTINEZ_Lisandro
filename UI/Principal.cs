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
using UI.Socios;

namespace UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SocioForm"] == null)
            {
                var socioForm = new SocioForm {MdiParent = this};
                socioForm.Show();
            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AutorForm"] == null)
            {
                var autorForm = new AutorForm {MdiParent = this};
                autorForm.Show();
            }
        }
    }
}
