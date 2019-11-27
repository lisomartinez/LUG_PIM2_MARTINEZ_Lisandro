using System;

namespace Entidades
{
    public class EntidadId : IEquatable<EntidadId>
    {
        private int numero;

        public EntidadId(int numero)
        {
            this.numero = numero;
        }

        public static EntidadId Vacia => new EntidadId(0);

        public static EntidadId Of(int numero) => new EntidadId(numero);
        public int AsInt() => numero;


        public bool Equals(EntidadId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return numero == other.numero;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EntidadId) obj);
        }

        public override int GetHashCode()
        {
            return numero;
        }

        public override string ToString()
        {
            return $"{numero}";
        }
    }
}