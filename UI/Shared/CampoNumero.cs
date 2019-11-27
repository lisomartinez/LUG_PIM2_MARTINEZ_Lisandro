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

namespace UI.Shared
{
    public partial class CampoNumero : UserControl
    {
        private static readonly Regex TextoValido = new Regex("^([1-9]{1}[0-9]*)$");
        private bool _valido = false;

        public int Numero
        {
            get => _valido ? Int32.Parse(TextBox.Text) : 0;
            set => TextBox.Text = value == 0 ? "" : value.ToString();
        }


        public CampoNumero()
        {
            InitializeComponent();
            TextBox.Text = "";
            TextBox.BackColor = Color.White;
            TextBox.ForeColor = Color.Black;
        }

        internal bool Valido() => _valido;

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextoValido.IsMatch(TextBox.Text))
            {
                _valido = true;
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
            }
            else
            {
                _valido = false;
                TextBox.BackColor = Color.Crimson;
                TextBox.ForeColor = Color.White;
            }
        }
    }
}
