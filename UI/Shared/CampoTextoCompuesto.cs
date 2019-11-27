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
    public partial class CampoTextoCompuesto : UserControl
    {
        private static readonly Regex TextoValido = new Regex("^([a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]+)(\\s+([a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*))*$");


        public string Texto
        {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }
        public CampoTextoCompuesto()
        {
            InitializeComponent();
        }
        public bool Valido() => TextoValido.IsMatch(TextBox.Text);

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
    }
}
