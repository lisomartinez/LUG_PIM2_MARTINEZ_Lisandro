using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entidades;
using Entidades.Shared;
using Tests;

namespace Repositorio.Socios
{
    public class SocioRepositorio : SqlRepositorio<Socio>
    {
        private static string Todos = "ObtenerTodosSocio";
        public SocioRepositorio(SqlAdaptador adaptador) : base(adaptador)
        {
        }

        public SocioRepositorio() : base(SqlAdaptador.Instance)
        {
        }

        public override List<Socio> ObtenerTodos() =>
            Adaptador.Leer(Todos)
                .AsEnumerable()
                .Select(SocioDesdeFila)
                .ToList();

        private Socio SocioDesdeFila(DataRow fila)
        {
            int id = fila["socio_id"] as int? ?? 0;
            int nroSocio = fila["nro_socio"] as int? ?? 0;
            string nombre = fila["nombre"] as string;
            string apellido = fila["apellido"] as string;
            return new Socio(
                id: EntidadId.Of(id),
                nroSocio: NroSocio.Of(nroSocio),
                nombre: Nombre.Of(nombre),
                apellido: Apellido.Of(apellido)
            );
        }
    }
}