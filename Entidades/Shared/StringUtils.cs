using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class StringUtils
    {
        private static readonly Regex NombreValido = new Regex("^[a-zA-Z]{2,100}$");
        private static readonly Regex NombreCompuestoValido = new Regex("^([a-zA-Z]+)(\\s+([a-zA-Z]*))*$");

        public static bool EsNombreValido(this string str) => NombreValido.IsMatch(str);
        public static bool EsNombreCompuestoValido(this string str) => (NombreCompuestoValido.IsMatch(str) && str.Length <= 100);
    }
}