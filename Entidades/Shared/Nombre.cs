using System;
using Tests;

namespace Entidades.Shared
{
    public class Nombre : IEquatable<Nombre>
    {
        private readonly string _texto;

        public Nombre(string texto)
        {
            if (!texto.EsNombreValido()) throw new NombreInvalidoException();
            _texto = texto;
        }

        public static Nombre Of(string nombre) => new Nombre(nombre);

        public bool Equals(Nombre other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_texto, other._texto);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Nombre) obj);
        }

        public override int GetHashCode()
        {
            return (_texto != null ? _texto.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"{_texto}";
        }
    }
}