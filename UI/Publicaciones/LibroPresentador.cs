using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Entidades.Autores;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Servicios;
using Servicios.Autores;
using Servicios.Publicaciones;
using UI.Autores;

namespace UI.Publicaciones
{
    public class LibroPresentador
    {
        private ILibroVista _vista;
        private IServicio<Libro> _libroServicio;
        private IServicio<Autor> _autoresServicio;

        public LibroPresentador(ILibroVista vista)
        {
            _vista = vista;
            _libroServicio = new LibroServicio();
            _autoresServicio = new AutorServicio();
        }

        public void MostrarLibros()
        {
            try
            {
                _vista.Libros = _libroServicio.ObtenerTodos().Select(LibroDto.FromEntity).ToList();
                _vista.ListaAutores = _autoresServicio.ObtenerTodos().Select(AutorDto.FromEntity).ToList();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);

            }
        }

        private void MostrarMensaje(string eMessage)
        {
            _vista.MostrarMensaje(eMessage);
        }

        public void MostrarLibro()
        {
            try
            {
                var libro = _vista.Libro;
                _vista.Numero = libro.Nro;
                _vista.Titulo = libro.Titulo;
                _vista.Editorial = libro.Editorial;
                _vista.Fecha = libro.Fecha;
                _vista.Isbn = libro.Isbn;
                _vista.Autores = libro.Autores;
                MostrarAutoresNoSeleccionados(libro.Autores.Select(a => a.Id).ToHashSet());
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);

            }
        }

        private void MostrarAutoresNoSeleccionados(HashSet<EntidadId> libroAutores)
        {
            _vista.ListaAutores = _autoresServicio.ObtenerTodos()
                .Select(AutorDto.FromEntity)
                .Where(a => !libroAutores.Contains(a.Id)).ToList();

        }

        public void Guardar()
        {
            try
            {
                var nro = _vista.Numero;
                var titulo = _vista.Titulo;
                var editorial = _vista.Editorial;
                var fecha = _vista.Fecha;
                var isbn = _vista.Isbn;
                var autores = _vista.Autores;
                var libro = new Libro(
                    numero: NroPublicacion.Of(nro),
                    titulo: Titulo.Of(titulo),
                    editorial: Editorial.Of(editorial),
                    fecha: Fecha.Of(fecha),
                    isbn: ISBN.Of(isbn),
                    autores: autores.Select(a => a.ToEntity()).ToList()
                );
                _libroServicio.Guardar(libro);
                MostrarLibros();
                LimpiarDatos();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);

            }
        }

        private void LimpiarDatos()
        {
            try
            {
                _vista.Numero = 0;
                _vista.Titulo = "";
                _vista.Editorial = "";
                _vista.Fecha = DateTime.Today;
                _vista.Isbn = "";
                _vista.Autores = new List<AutorDto>();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void Modificar()
        {
            try
            {
                var libro = _vista.Libro;
                libro.Nro = _vista.Numero;
                libro.Titulo = _vista.Titulo;
                libro.Editorial = _vista.Editorial;
                libro.Fecha = _vista.Fecha;
                libro.Isbn = _vista.Isbn;
                libro.Autores = _vista.Autores;
                _libroServicio.Modificar(libro.ToEntity());
                MostrarLibros();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);

            }
        }

        public void Eliminar()
        {
            try
            {
                var libro = _vista.Libro;
                _libroServicio.Eliminar(libro.ToEntity());
                MostrarLibros();
                LimpiarDatos();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);

            }
        }

        public void AgregarAutorALibro()
        {
            try
            {
                var libro = _vista.Libro;
                var autorSeleccionado = _vista.AutorSeleccionado;
                libro.Autores.Add(autorSeleccionado);
                _libroServicio.Modificar(libro.ToEntity());
                MostrarLibro();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void EliminarAutorDeLibro()
        {
            try
            {
                var libro = _vista.Libro;
                var autorSeleccionado = _vista.AutorLibroSeleccionado;
                libro.Autores.Remove(autorSeleccionado);
                _libroServicio.Modificar(libro.ToEntity());
                MostrarLibro();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }
    }
}