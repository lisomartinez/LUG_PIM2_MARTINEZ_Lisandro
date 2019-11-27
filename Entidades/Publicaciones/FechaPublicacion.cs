using System;

namespace Entidades.Publicaciones
{
    public class FechaPublicacion : IEquatable<FechaPublicacion>
    {
        private readonly DateTime _fecha;

        private FechaPublicacion(DateTime fecha)
        {
            _fecha = fecha;
        }

        public static FechaPublicacion Of(DateTime fecha) => new FechaPublicacion(fecha);

        public bool Equals(FechaPublicacion other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _fecha.Equals(other._fecha);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FechaPublicacion) obj);
        }

        public override int GetHashCode()
        {
            return _fecha.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_fecha}";
        }
    }
}