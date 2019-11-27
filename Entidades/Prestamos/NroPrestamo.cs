using System;

namespace Entidades.Prestamos
{
    public class NroPrestamo : IEquatable<NroPrestamo>
    {
        private readonly int _nro;

        private NroPrestamo(int nro)
        {
            _nro = nro;
        }

        public static NroPrestamo Of(int nro) => new NroPrestamo(nro);

        public int AsInt() => _nro;

        public bool Equals(NroPrestamo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _nro == other._nro;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((NroPrestamo) obj);
        }

        public override int GetHashCode()
        {
            return _nro;
        }

        public override string ToString()
        {
            return $"{_nro}";
        }
    }
}