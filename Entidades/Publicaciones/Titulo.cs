using System;

namespace Entidades.Publicaciones
{
    public class Titulo : IComparable<Titulo>
    {
        private readonly string _nombre;

        private Titulo(string nombre)
        {
            _nombre = nombre;
        }

        public static Titulo Of(string nombre) => new Titulo(nombre);

        public int CompareTo(Titulo other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(_nombre, other._nombre, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{_nombre}";
        }
    }
}