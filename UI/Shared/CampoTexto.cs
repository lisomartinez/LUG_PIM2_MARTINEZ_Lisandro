using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UI.Shared
{
   
    public partial class CampoTexto : UserControl
    {
        private static readonly Regex TextoValido = new Regex("^[a-zA-Z]{1,100}$");

        public string Texto
        {
            get => TextBox.Text;
            set => TextBox.Text = value;
        } 

        public CampoTexto()
        {
            InitializeComponent();
        }

        private void Texto_Validating(object sender, CancelEventArgs e)
        {
        }

        public bool Valido() => TextoValido.IsMatch(TextBox.Text);

        private void Texto_Validated(object sender, EventArgs e)
        {

        }

        private void Texto_TextChanged(object sender, EventArgs e)
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
    }
}
