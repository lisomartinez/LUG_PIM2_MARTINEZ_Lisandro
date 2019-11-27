using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entidades;
using Entidades.Autores;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Entidades.Shared;
using Entidades.Socios;
using Tests;

namespace Repositorio
{
    public class PrestamoRepositorio : SqlRepositorio<Prestamo>
    {
        private static readonly string ObtenerTodosPrestamo = "ObtenerTodosPrestamo";
        private static readonly string GuardarPrestamo = "GuardarPrestamo";
        private static readonly string ModificarPrestamo = "ModificarPrestamo";
        private static readonly string EliminarPrestamo = "EliminarPrestamo";

        public PrestamoRepositorio(SqlAdaptador adaptador) : base(adaptador)
        {
        }
        public PrestamoRepositorio() : base(SqlAdaptador.Instance)
        {
        }

        public override List<Prestamo> ObtenerTodos() =>
            Adaptador.Leer(ObtenerTodosPrestamo)
                .AsEnumerable()
                .Select(CrearPrestamoDesdeFila)
                .ToList();

        private Prestamo CrearPrestamoDesdeFila(DataRow fila)
        {
            var id = fila["prestamo_id"] as int? ?? 0;
            var nro = fila["nro_prestamo"] as int? ?? 0;
            var fechaPrestamo = fila["fecha_prestamo"] as DateTime? ?? default;
            var fechaDevolucion = fila["fecha_devolucion"] as DateTime? ?? default;
            var socio = SocioDesdeFila(fila);
            var libro = CrearLibroDesdeFila(fila);
            return new Prestamo(
                id: EntidadId.Of(id),
                numero: NroPrestamo.Of(nro),
                socio: socio,
                libro: libro,
                fechaPrestamo: Fecha.Of(fechaPrestamo),
                fechaDevolucion: Fecha.Of(fechaDevolucion)
            );

        }

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

        private Libro CrearLibroDesdeFila(DataRow fila)
        {
            var id = fila["libro_id"] as int? ?? 0;
            var nro = fila["nro_libro"] as int? ?? 0;
            var titulo = fila["titulo"] as string;
            var isbn = fila["isbn"] as string;
            var editorial = fila["editorial"] as string;
            var fecha = fila["fecha"] as DateTime? ?? default;

            return new Libro(
                id: EntidadId.Of(id),
                numero: NroPublicacion.Of(nro),
                autores: new List<Autor>(),
                fecha: Fecha.Of(fecha),
                titulo: Titulo.Of(titulo),
                isbn: ISBN.Of(isbn),
                editorial: Editorial.Of(editorial)
            );
        }

        public override bool Guardar(Prestamo entidad) =>
            Adaptador.Escribir(GuardarPrestamo, crearParametrosGuardar(entidad));

        private Dictionary<string, object> crearParametrosGuardar(Prestamo entidad) =>
            new Dictionary<string, object>
            {
                { "nro_prestamo", entidad.Numero.AsInt() },
                { "fecha_prestamo", entidad.FechaPrestamo.ToDateTime() },
                { "fecha_devolucion", entidad.FechaDevolucion.ToDateTime() },
                { "socio_id", entidad.Socio.Id.AsInt() },
                { "libro_id", entidad.Libro.Id.AsInt() }
            };

        public override bool Modificar(Prestamo entidad) =>
            Adaptador.Escribir(ModificarPrestamo, crearParametrosModificar(entidad));

        private Dictionary<string, object> crearParametrosModificar(Prestamo entidad) =>
            new Dictionary<string, object>
            {
                { "prestamo_id", entidad.Id.AsInt() },
                { "nro_prestamo", entidad.Numero.AsInt() },
                { "fecha_prestamo", entidad.FechaPrestamo.ToDateTime() },
                { "fecha_devolucion", entidad.FechaDevolucion.ToDateTime() },
                { "socio_id", entidad.Socio.Id.AsInt() },
                { "libro_id", entidad.Libro.Id.AsInt() }
            };

        public override bool Eliminar(Prestamo entidad) =>
            Adaptador.Escribir(EliminarPrestamo, crearParametrosEliminar(entidad));

        public override bool VerificarDuplicado(Prestamo entidad)
        {
            return false;
        }

        private Dictionary<string, object> crearParametrosEliminar(Prestamo entidad) =>
            new Dictionary<string, object>
            {
                { "prestamo_id", entidad.Id.AsInt() }
            };

    }
}