using System;

namespace Entidades.Publicaciones
{
    public class NroPublicacion : IComparable<NroPublicacion>
    {
        private readonly int _numero;

        private NroPublicacion(int numero)
        {
            if (numero < 1) throw new NroPublicacionException(numero);
            _numero = numero;
        }

        public static NroPublicacion Of(int numero) => new NroPublicacion(numero);

        public int AsInt() => _numero;

        public int CompareTo(NroPublicacion other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return _numero.CompareTo(other._numero);
        }

        public override string ToString()
        {
            return $"{_numero}";
        }
    }

    internal class NroPublicacionException : Exception
    {
        public NroPublicacionException(int numero)
        {
            throw new NotImplementedException();
        }
    }
}