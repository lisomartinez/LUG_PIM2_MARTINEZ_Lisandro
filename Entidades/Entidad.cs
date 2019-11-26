using System;

namespace Entidades
{
    public abstract class Entidad : IEquatable<Entidad>
    {
        public EntidadId Id { get; }

        protected Entidad(EntidadId id)
        {
            Id = id;
        }

        public bool Equals(Entidad other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Entidad) obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}