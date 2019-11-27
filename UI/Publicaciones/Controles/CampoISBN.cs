using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Publicaciones
{
    public partial class CampoISBN : UserControl
    {
        private static readonly Regex TextoValido = new Regex("^\\d{3}-\\d{7}-\\d{3}$");

        public string Texto
        {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }

        public CampoISBN()
        {
            InitializeComponent();
        }

        private void CampoISBN_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextoValido.IsMatch(TextBox.Text))
            {
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
            }
            else
            {
                TextBox.BackColor = Color.Crimson;
                TextBox.ForeColor = Color.White;
            }
        }

        public bool Valido() => TextoValido.IsMatch(TextBox.Text);
    }
}
