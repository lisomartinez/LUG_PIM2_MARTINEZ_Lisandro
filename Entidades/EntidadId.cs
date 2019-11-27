using System;
using System.Collections.Generic;

namespace Entidades
{
    public class EntidadId : IEquatable<EntidadId>, IComparable
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

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) throw new ArgumentException();
            if (obj is EntidadId e)
            {
                return numero.CompareTo(e.numero);
            }
            else
            {
                throw new ArgumentException();
            }
        }


        public override string ToString()
        {
            return $"{numero}";
        }

     
    }
}