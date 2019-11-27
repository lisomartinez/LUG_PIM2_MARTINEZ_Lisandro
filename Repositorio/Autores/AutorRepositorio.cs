using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entidades;
using Entidades.Autores;
using Entidades.Shared;

namespace Repositorio.Autores
{
    public class AutorRepositorio : SqlRepositorio<Autor>
    {
        private static readonly string ObtenerTodosAutor = "ObtenerTodosAutor";
        private static readonly string GuardarAutor= "GuardarAutor";
        private static readonly string ModificarAutor= "ModificarAutor";
        private static readonly string EliminarAutor= "EliminarAutor";
        private static readonly string DuplicadoAutor = "DuplicadoAutor";

        public AutorRepositorio() : base(SqlAdaptador.Instance)
        {
        }

        public override List<Autor> ObtenerTodos() =>
            Adaptador.Leer(ObtenerTodosAutor)
                .AsEnumerable()
                .Select(CrearAutorDesdeFila)
                .ToList();

        private Autor CrearAutorDesdeFila(DataRow fila)
        {
            var id = fila["autor_id"] as int? ?? 0;
            var numero = fila["nro_autor"] as int? ?? 0;
            var nombre = fila["nombre"] as string;
            var apellido = fila["apellido"] as string;
            return new Autor(
                    id: EntidadId.Of(id),
                    numero: NroAutor.Of(numero), 
                    nombre: Nombre.Of(nombre),
                    apellido: Apellido.Of(apellido) 
                );
        }


        public override bool Guardar(Autor entidad) =>
            Adaptador.Escribir(GuardarAutor, crearParametroGuardar(entidad));

        private Dictionary<string, object> crearParametroGuardar(Autor entidad) =>
            new Dictionary<string, object>
            {
                { "nro_autor", entidad.Numero },
                { "nombre", entidad.Nombre },
                { "apellido", entidad.Apellido }
            };

        public override bool Modificar(Autor entidad) =>
            Adaptador.Escribir(ModificarAutor, crearParametrosModificar(entidad));

        private Dictionary<string, object> crearParametrosModificar(Autor entidad) =>
            new Dictionary<string, object>
            {
                { "autor_id", entidad.Id.AsInt() },
                { "nro_autor", entidad.Numero },
                { "nombre", entidad.Nombre },
                { "apellido", entidad.Apellido }
            };

        public override bool Eliminar(Autor entidad) =>
            Adaptador.Escribir(EliminarAutor, crearParametrosEliminar(entidad));

        public override bool VerificarDuplicado(Autor entidad)
        {
            var table = Adaptador.Leer(DuplicadoAutor, crearParametrosDuplicado(entidad));
            var existe = table.Rows[0]["existe"] as int? ?? 0;
            return existe != 0;
        }

        private Dictionary<string, object> crearParametrosDuplicado(Autor entidad) =>
            new Dictionary<string, object>
            {
                {"nro_autor", entidad.Numero.AsInt() }
            };


        private Dictionary<string, object> crearParametrosEliminar(Autor entidad) =>
            new Dictionary<string, object>
            {
                { "autor_id", entidad.Id.AsInt() }
            };
    }
}