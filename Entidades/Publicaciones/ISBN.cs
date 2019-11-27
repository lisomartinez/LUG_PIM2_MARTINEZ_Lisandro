using System;

namespace Entidades.Publicaciones
{
    public class ISBN : IComparable<ISBN>
    {
        private readonly string _numero;

        private ISBN(string numero)
        {
            _numero = numero;
        }

        public static ISBN Of(string numero) => new ISBN(numero);

        public int CompareTo(ISBN other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(_numero, other._numero, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{_numero}";
        }
    }
}