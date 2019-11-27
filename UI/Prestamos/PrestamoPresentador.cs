using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Servicios;
using Servicios.Prestamos;
using Servicios.Publicaciones;
using Tests;
using UI.Publicaciones;
using UI.Socios;

namespace UI.Prestamos
{
    public class PrestamoPresentador
    {
        private IPrestamoVista _vista;
        private IServicio<Prestamo> _prestamoServicio;
        private IServicio<Socio> _socioServicio;
        private IServicio<Libro> _libroServicio;


        public PrestamoPresentador(IPrestamoVista vista)
        {
            _vista = vista;
            _prestamoServicio = new PrestamoServicio();
            _socioServicio = new SocioServicio();
            _libroServicio = new LibroServicio();
        }

        public void MostrarPrestamos()
        {
            try
            {
                var prestamos = _prestamoServicio.ObtenerTodos();
                _vista.Prestamos = prestamos.Select(PrestamoDto.FromEntity).ToList();
                MostrarLibrosDisponibles(prestamos);
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

        private void MostrarLibrosDisponibles(List<Prestamo> prestamos)
        {
            var libroPrestados = prestamos.Select(p => p.Libro).ToHashSet();
            _vista.Libros = _libroServicio.ObtenerTodos()
                .Where(libro => !libroPrestados.Contains(libro))
                .Select(LibroDto.FromEntity)
                .ToList();
        }

        public void MostrarSocios()
        {
            try
            {
                _vista.Socios = _socioServicio.ObtenerTodos()
                    .Select(SocioDto.FromEntity)
                    .ToList();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }


        }

        public void MostrarLibros()
        {
            
        }

        public void PrestarLibro()
        {
            try
            {
                var numero = NroPrestamo.Of(_vista.Numero);
                var libro = _vista.Libro.ToEntity();
                var socio = _vista.Socio.ToEntity();
                var fechaPrestamo = Fecha.Of(DateTime.Today);
                var fechaDevolucion = Fecha.Of(_vista.FechaDevolucion);
                var prestamo = new Prestamo(numero, socio, libro, fechaPrestamo, fechaDevolucion);
                var duplicado = _prestamoServicio.VerificarDuplicados(prestamo);
                if (!duplicado)
                {
                    _prestamoServicio.Guardar(prestamo);
                }
                MostrarPrestamos();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void DevolverLibro()
        {
            try
            {
                var prestamo = _vista.Prestamo;
                _prestamoServicio.Eliminar(prestamo.ToEntity());
                MostrarPrestamos();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }
    }
}
