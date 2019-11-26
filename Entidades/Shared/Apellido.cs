using System;
using Tests;

namespace Entidades.Shared
{
    public class Apellido : IEquatable<Apellido>
    {
        private readonly string _texto;

        public Apellido(string texto)
        {
            if (!texto.EsNombreValido()) throw new ApellidoInvalidoException();
            _texto = texto;
        }

        public static Apellido Of(string apellido) => new Apellido(apellido);

        public bool Equals(Apellido other)
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
            return Equals((Apellido) obj);
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