using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using Entidades;
using Entidades.Socios;
using Tests;

namespace UI.Socios
{
    public class SocioDto : IEquatable<SocioDto>
    {

        [Browsable(false)]
        public EntidadId Id { get; }
        public int Nro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Activo { get; set; }

        private SocioDto(EntidadId id, int nro, string nombre, string apellido, bool activo)
        {
            Id = id;
            Nro = nro;
            Nombre = nombre;
            Apellido = apellido;
            Activo = activo;
        }

        public static SocioDto FromEntity(Socio socio) 
            => new SocioDto(
                id: socio.Id,
                nro: socio.NroSocio.AsInt(),
                nombre: socio.Nombre.ToString(),
                apellido: socio.Apellido.ToString(),
                activo: socio.Activo.ToBool()
                );

        public Socio ToEntity() =>
            new Socio(
                id: Id,
                nroSocio: NroSocio.Of(Nro),
                nombre: Entidades.Shared.Nombre.Of(Nombre),
                apellido: Entidades.Shared.Apellido.Of(Apellido),
                activo: Estado.Of(Activo));

        public bool Equals(SocioDto other)
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
            return Equals((SocioDto) obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}