using System;

namespace Tests
{
    public class NroSocio : IEquatable<NroSocio>
    {
        private readonly int _nro;

        public NroSocio(int nro)
        {
            if (nro < 1) throw new NroSocioInvalidoException();
            _nro = nro;
        }

        public static NroSocio Of(int nro) => new NroSocio(nro);

        public bool Equals(NroSocio other)
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
            return Equals((NroSocio) obj);
        }

        public override int GetHashCode()
        {
            return _nro;
        }

        public override string ToString()
        {
            return $"Nro: {_nro}";
        }
    }
}