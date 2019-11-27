using System;

namespace Entidades.Publicaciones
{
    public class Editorial : IEquatable<Editorial>
    {
        private readonly string _nombre;

        private Editorial(string nombre)
        {
            _nombre = nombre;
        }

        public static Editorial Of(string nombre) => new Editorial(nombre);

        public bool Equals(Editorial other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_nombre, other._nombre);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Editorial) obj);
        }

        public override int GetHashCode()
        {
            return (_nombre != null ? _nombre.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"{_nombre}";
        }
    }
}