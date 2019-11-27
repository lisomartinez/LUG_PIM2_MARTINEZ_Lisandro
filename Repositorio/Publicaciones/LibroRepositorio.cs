using System;
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
        public static readonly string DuplicadoLibro = "DuplicadoLibro";


        public LibroRepositorio(SqlAdaptador adaptador) : base(adaptador)
        {
        }

        public LibroRepositorio() : base(SqlAdaptador.Instance)
        {

        }

        public override List<Libro> ObtenerTodos()
        {
            var libros = Adaptador.Leer(ObtenerTodosLibro)
                .AsEnumerable()
                .Select(CrearLibroDesdeFila)
                .ToList();
            libros.ForEach(l => l.Autores = ObtenerEntidades(l));
            return libros;
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

        public override bool Guardar(Libro entidad)
        {
            var guardado = Adaptador.Escribir(GuardarLibro, crearParametrosGuardar(entidad));
            
            if (guardado) 
                entidad.Autores.ForEach(a => Agregar(entidad, a));
            
            return guardado;
        }

        private Dictionary<string, object> crearParametrosGuardar(Libro entidad) =>
            new Dictionary<string, object>
            {
                { "nro_libro", entidad.Numero.AsInt() },
                { "titulo", entidad.Titulo.ToString() },
                { "isbn", entidad.Isbn.ToString() },
                { "editorial", entidad.Editorial.ToString() },
                { "fecha", entidad.Fecha.ToDateTime() }
            };

        public override bool Modificar(Libro entidad)
        {
            var modificado = Adaptador.Escribir(ModificarLibro, crearParametrosModificar(entidad));

            if (modificado)
            {
                ActualizarAutoresDeLibro(entidad);
            }

            return modificado;
        }

        private void ActualizarAutoresDeLibro(Libro entidad)
        {
            var autoresExistentes = ObtenerEntidades(entidad).ToHashSet();
            List<Autor> paraAgregar = new List<Autor>();
            foreach (var autor in entidad.Autores)
            {
                var existe = autoresExistentes.Contains(autor);
                if (!existe)
                {
                    Agregar(entidad, autor);
                }
                else
                {
                    autoresExistentes.Remove(autor);
                }
                    
            }
            autoresExistentes.ToList().ForEach(a => Eliminar(entidad, a));
        }

        private Dictionary<string, object> crearParametrosModificar(Libro entidad) =>
            new Dictionary<string, object>
            {
                { "libro_id", entidad.Id.AsInt() },
                { "nro_libro", entidad.Numero.AsInt() },
                { "titulo", entidad.Titulo.ToString() },
                { "isbn", entidad.Isbn.ToString() },
                { "editorial", entidad.Editorial.ToString() },
                { "fecha", entidad.Fecha.ToDateTime() }
            };

        public override bool Eliminar(Libro entidad) =>
            Adaptador.Escribir(EliminarLibro, crearParametrosEliminar(entidad));

        public override bool VerificarDuplicado(Libro entidad)
        {
            var table = Adaptador.Leer(DuplicadoLibro, crearParametrosDuplicado(entidad));
            var existe = table.Rows[0]["existe"] as int? ?? 0;
            return existe != 0;
        }

        private Dictionary<string, object> crearParametrosDuplicado(Libro entidad) =>
            new Dictionary<string, object>
            {
                {"nro_libro", entidad.Numero.AsInt() }
            };


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
        
        public void Eliminar(Libro agregado, Autor entidad) =>
            Adaptador.Escribir(EliminarAutorLibro, crearParametrosAutor(agregado, entidad));

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