using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entidades;
using Entidades.Shared;
using Entidades.Socios;
using Tests;

namespace Repositorio.Socios
{
    public class SocioRepositorio : SqlRepositorio<Socio>
    {
        private static readonly string Todos = "ObtenerTodosSocio";
        private static readonly string GuardarSocio = "GuardarSocio";
        private static readonly string ModificarSocio = "ModificarSocio";
        private static readonly string EliminarSocio = "EliminarSocio";
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

        public override bool Guardar(Socio entidad) =>
            Adaptador.Escribir(GuardarSocio, crearParametrosGuardar(entidad));

        public override bool Modificar(Socio entidad) =>
            Adaptador.Escribir(ModificarSocio, crearParametrosModificar(entidad));

        private Dictionary<string, object> crearParametrosModificar(Socio entidad) =>
            new Dictionary<string, object>
            {
                {"socio_id", entidad.Id.AsInt() },
                {"nro_socio", entidad.NroSocio.AsInt()},
                {"nombre", entidad.Nombre.ToString()},
                {"apellido", entidad.Apellido.ToString()},
                {"activo", entidad.Activo.ToBool() }
            };
        
        public override bool Eliminar(Socio entidad) =>
            Adaptador.Escribir(EliminarSocio, crearParametrosEliminar(entidad));

        public override bool VerificarDuplicado(Socio entidad)
        {
            return false;
        }

        private Dictionary<string, object> crearParametrosEliminar(Socio entidad) =>
            new Dictionary<string, object>
            {
                {"socio_id", entidad.Id.AsInt() }
            };

        private Dictionary<string, object> crearParametrosGuardar(Socio entidad) =>
            new Dictionary<string, object>
            {
                {"nro_socio", entidad.NroSocio.AsInt()},
                {"nombre", entidad.Nombre.ToString()},
                {"apellido", entidad.Apellido.ToString()},
                {"activo", entidad.Activo.ToBool() }
            };


        private Socio SocioDesdeFila(DataRow fila)
        {
            int id = fila["socio_id"] as int? ?? 0;
            int nroSocio = fila["nro_socio"] as int? ?? 0;
            string nombre = fila["nombre"] as string;
            string apellido = fila["apellido"] as string;
            bool activo = fila["activo"] as bool? ?? true;
            return new Socio(
                id: EntidadId.Of(id),
                nroSocio: NroSocio.Of(nroSocio),
                nombre: Nombre.Of(nombre),
                apellido: Apellido.Of(apellido),
                activo: Estado.Of(activo)
            );
        }
    }
}