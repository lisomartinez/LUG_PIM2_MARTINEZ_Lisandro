using System;

namespace Entidades.Prestamos
{
    public class Fecha : IEquatable<Fecha>
    {
        private readonly DateTime _fecha;

        private Fecha(DateTime fecha)
        {
            _fecha = fecha;
        }

        public static Fecha Of(DateTime fecha) => new Fecha(fecha);

        public bool Equals(Fecha other)
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
            return Equals((Fecha) obj);
        }

        public override int GetHashCode()
        {
            return _fecha.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_fecha}";
        }

        public DateTime ToDateTime()
        {
            return _fecha;
        }
    }

    internal class FechaDeDevolucionException : Exception
    {
        public FechaDeDevolucionException(DateTime fecha)
        {
            

        }
    }
}