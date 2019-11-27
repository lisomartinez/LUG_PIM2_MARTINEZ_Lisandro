﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entidades;
using Entidades.Autores;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Entidades.Shared;

namespace Repositorio.Publicaciones
{
    public class LibroRepositorio : SqlRepositorio<Libro>, IAgregableRepositorio<Libro, Autor>
    {
        public static readonly string ObtenerTodosLibro = "ObtenerTodosLibro";
        public static readonly string GuardarLibro = "GuardarLibro";
        public static readonly string ModificarLibro = "ModificarLibro";
        public static readonly string EliminarLibro = "EliminarLibro";
        public static readonly string AgregarAutorLibro = "AgregarAutorLibro";
        public static readonly string EliminarAutorLibro = "EliminarAutorLibro";
        public static readonly string ObtenerAutoresLibro = "ObtenerAutoresLibro";


        public LibroRepositorio(SqlAdaptador adaptador) : base(adaptador)
        {
        }

        public LibroRepositorio() : base(SqlAdaptador.Instance)
        {

        }

        public override List<Libro> ObtenerTodos() =>
            Adaptador.Leer(ObtenerTodosLibro)
                .AsEnumerable()
                .Select(CrearLibroDesdeFila)
                .ToList();

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

        public override bool Guardar(Libro entidad) =>
            Adaptador.Escribir(GuardarLibro, crearParametrosGuardar(entidad));

        private Dictionary<string, object> crearParametrosGuardar(Libro entidad) =>
            new Dictionary<string, object>
            {
                { "nro_libro", entidad.Numero.AsInt() },
                { "titulo", entidad.Titulo.ToString() },
                { "isbn", entidad.Isbn.ToString() },
                { "editorial", entidad.Editorial.ToString() },
                { "fecha", entidad.Fecha }
            };

        public override bool Modificar(Libro entidad) =>
            Adaptador.Escribir(ModificarLibro, crearParametrosModificar(entidad));

        private Dictionary<string, object> crearParametrosModificar(Libro entidad) =>
            new Dictionary<string, object>
            {
                { "libro_id", entidad.Id.AsInt() },
                { "nro_libro", entidad.Numero.AsInt() },
                { "titulo", entidad.Titulo.ToString() },
                { "isbn", entidad.Isbn.ToString() },
                { "editorial", entidad.Editorial.ToString() },
                { "fecha", entidad.Fecha }
            };

        public override bool Eliminar(Libro entidad) =>
            Adaptador.Escribir(EliminarLibro, crearParametrosEliminar(entidad));

        public override bool VerificarDuplicado(int numero)
        {
            return false;
        }

        private Dictionary<string, object> crearParametrosEliminar(Libro entidad) =>
            new Dictionary<string, object>
            {
                { "libro_id", entidad.Id.AsInt() }
            };

        public void Agregar(Libro agregado, Autor entidad)
        {
            Adaptador.Escribir(AgregarAutorLibro, crearParametrosAutor(agregado, entidad));
        }

        private Dictionary<string, object> crearParametrosAutor(Libro agregado, Autor entidad) =>
            new Dictionary<string, object>
            {
                { "libro_id", agregado.Id.AsInt() },
                { "autor_id", entidad.Id.AsInt() }
            };
        
        public void Eliminar(Libro agregado, Autor entidad)
        {
            Adaptador.Escribir(EliminarAutorLibro, crearParametrosAutor(agregado, entidad));
        }

        public List<Autor> ObtenerEntidades(Libro agregado) =>
            Adaptador.Leer(ObtenerAutoresLibro, crearParametrosAutores(agregado))
                .AsEnumerable()
                .Select(CrearAutorDesdeFila)
                .ToList();

        private Dictionary<string, object> crearParametrosAutores(Libro agregado) =>
            new Dictionary<string, object>
            {
                { "libro_id", agregado.Id.AsInt() }
            };

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

    }
}