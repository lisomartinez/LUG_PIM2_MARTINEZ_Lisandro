using System;

namespace Entidades.Socios
{
    public class Estado : IEquatable<Estado>
    {
        private readonly bool _activo;

        private Estado(bool activo)
        {
            _activo = activo;
        }
        public static Estado Of(bool activo) => new Estado(activo);

        public bool Equals(Estado other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _activo == other._activo;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Estado) obj);
        }

        public override int GetHashCode()
        {
            return _activo.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_activo}";
        }

        public bool ToBool()
        {
            return _activo;
        }
    }
}