using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class StringUtils
    {
        private static readonly Regex NombreValido = new Regex("^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]{2,100}$");
        private static readonly Regex ISBNValido = new Regex("^\\d{3}-\\d{7}-\\d{3}$");
        private static readonly Regex NombreCompuestoValido = new Regex("^([a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]+)(\\s+([a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*))*$");

        public static bool EsNombreValido(this string str) => NombreValido.IsMatch(str);
        public static bool EsNombreCompuestoValido(this string str) => (NombreCompuestoValido.IsMatch(str) && str.Length <= 100);
        public static bool EsISBNValido(this string str) => str.Length == 15 && ISBNValido.IsMatch(str);
    }
}