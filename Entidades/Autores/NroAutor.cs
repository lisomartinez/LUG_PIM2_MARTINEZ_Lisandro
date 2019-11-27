using System;

namespace Entidades.Autores
{
    public class NroAutor : IEquatable<NroAutor>
    {
        private int _numero;

        private NroAutor(int numero)
        {
            if (numero < 1) throw new NroAutorInvalidoException();
            _numero = numero;
        }

        public static NroAutor Of(int numero) => new NroAutor(numero);

        public int AsInt()
        {
            return _numero;
        }

        public bool Equals(NroAutor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _numero == other._numero;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((NroAutor) obj);
        }

        public override int GetHashCode()
        {
            return _numero;
        }

        public override string ToString()
        {
            return $"{_numero}";
        }
    }
}