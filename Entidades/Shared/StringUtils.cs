using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class StringUtils
    {
        private static readonly Regex NombreValido = new Regex("^[a-zA-Z]{2,100}$");

        public static bool EsNombreValido(this string str) => NombreValido.IsMatch(str);
    }
}