using Entidades;
using Tests;

namespace UI.Socios
{
    public class SocioDto
    {
        public EntidadId Id { get; }
        public int Nro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private SocioDto(EntidadId id, int nro, string nombre, string apellido)
        {
            Id = id;
            Nro = nro;
            Nombre = nombre;
            Apellido = apellido;
        }

        public static SocioDto FromEntity(Socio socio) 
            => new SocioDto(
                id: socio.Id,
                nro: socio.NroSocio.AsInt(),
                nombre: socio.Nombre.ToString(),
                apellido: socio.Apellido.ToString());

        public Socio ToEntity() =>
            new Socio(
                id: Id,
                nroSocio: NroSocio.Of(Nro),
                nombre: Entidades.Shared.Nombre.Of(Nombre),
                apellido: Entidades.Shared.Apellido.Of(Apellido));
        
    }
}