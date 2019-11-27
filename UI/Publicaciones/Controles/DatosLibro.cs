using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Publicaciones;

namespace UI.Publicaciones
{
    public partial class DatosLibro : UserControl
    {
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append(NroCampoNumero.Valido() ? "" : "\nNumero: Debe ser mayor que cero");
            st.Append(TituloCampo.Valido() ? "" : "\nTitulo: Solo palabras");
            st.Append(EditorialCampo.Valido() ? "" : "\nEditorial: Solo palabras");
            st.Append(IsbnCampo.Valido() ? "" : "\nISBN: 13 Digitos en forma XXX-XXXXXXX-XXX");
            st.Append(FechaValida() ? "" : "\nFecha de publicacion: No puede ser en el futuro.");
            return st.ToString();
        }

        public DatosLibro()
        {
            InitializeComponent();
        }

        public int Numero
        {
            get => NumeroCampo.Numero;
            set => NumeroCampo.Numero = value;
        }

        public string Titulo
        {
            get => TituloCampo.Texto;
            set => TituloCampo.Texto = value;
        }

        public string Editorial
        {
            get => EditorialCampo.Texto;
            set => EditorialCampo.Texto = value;
        }

        public DateTime Fecha
        {
            get => FechaDTP.Value;
            set => FechaDTP.Value = value;
        }

        public string ISBN
        {
            get => IsbnCampo.Texto;
            set => IsbnCampo.Texto = value;
        }

        public bool Valido => NumeroCampo.Valido() && TituloCampo.Valido() && EditorialCampo.Valido() && IsbnCampo.Valido() && FechaValida();

        private bool FechaValida()
        {
            return FechaDTP.Value <= DateTime.Today.Date;
        }

        private void DatosLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
