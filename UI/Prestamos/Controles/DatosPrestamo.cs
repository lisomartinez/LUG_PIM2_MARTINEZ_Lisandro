using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Prestamos.Controles
{
    public partial class DatosPrestamo : UserControl
    {
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append(NumeroCampoNumero.Valido() ? "" : "\nNumero: Debe ser mayor que cero.");
            st.Append(FechaValida() ? "" : "\nFecha De Publicacion: La fecha debe estar en el futuro.");
            return st.ToString();
        }

        public int Numero
        {
            get => NumeroCampoNumero.Numero;
            set => NumeroCampoNumero.Numero = value;
        }

        public DateTime FechaPublicacion
        {
            get => FechaDevolucionDTP.Value;
            set => FechaDevolucionDTP.Value = value;
        }

        public bool Valido => NumeroCampoNumero.Valido() && FechaValida();

        private bool FechaValida() => FechaDevolucionDTP.Value.Date > DateTime.Today.Date;

        public DatosPrestamo()
        {
            InitializeComponent();
        }

        private void DatosPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
