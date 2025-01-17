﻿using System;
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

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append(NumeroCampoNumero.Valido() ? "" : "\nNro. socio: Debe ser mayor que cero");
            st.Append(NombreCampoTexto.Valido() ? "" : st.Length != 0 ? "\nNombre: Deber ser una sola palabra" : "Nombre: Deber ser una sola palabra");
            st.Append(ApellidoCampoTexto.Valido() ? "" : st.Length != 0 ? "\nApellido: Deber ser una sola palabra" : "Apellido: Deber ser una sola palabra");
            return st.ToString();
        }
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
