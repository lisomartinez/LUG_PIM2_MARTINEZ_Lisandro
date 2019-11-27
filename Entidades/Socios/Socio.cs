using System.Data.Odbc;
using Entidades;
using Entidades.Shared;
using Entidades.Socios;

namespace Tests
{
    public class Socio : Entidad
    {
        private EntidadId id;

        public NroSocio NroSocio { get; }
        public Nombre Nombre { get; }
        public Apellido Apellido { get; }

        public Estado Activo { get; }

        public Socio(NroSocio nroSocio, Nombre nombre, Apellido apellido, Estado activo) :base(EntidadId.Vacia)
        {
            NroSocio = nroSocio;
            Nombre = nombre;
            Apellido = apellido;
            Activo = activo;
        }

        public Socio(EntidadId id, NroSocio nroSocio, Nombre nombre, Apellido apellido, Estado activo) : base(id)
        {
            NroSocio = nroSocio;
            Nombre = nombre;
            Apellido = apellido;
            Activo = activo;
        }

    }
}