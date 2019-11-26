using Entidades;
using Entidades.Shared;

namespace Tests
{
    public class Socio : Entidad
    {
        public NroSocio NroSocio { get; }
        public Nombre Nombre { get; }
        public Apellido Apellido { get; }

        public Socio(NroSocio nroSocio, Nombre nombre, Apellido apellido) :base(EntidadId.Vacia)
        {
            NroSocio = nroSocio;
            Nombre = nombre;
            Apellido = apellido;
        }

        public Socio(EntidadId id, NroSocio nroSocio, Nombre nombre, Apellido apellido) : base(id)
        {
            NroSocio = nroSocio;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}