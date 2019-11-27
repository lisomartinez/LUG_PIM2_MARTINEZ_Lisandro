using Entidades.Publicaciones;
using Tests;

namespace Entidades.Prestamos
{
    public class Prestamo : Entidad
    {
        public NroPrestamo Numero { get; }
        public Socio Socio { get; }
        public Libro Libro { get; }
        public Fecha FechaPrestamo { get; }
        public Fecha FechaDevolucion { get; }

        public Prestamo(EntidadId id, NroPrestamo numero, Socio socio, Libro libro, Fecha fechaPrestamo, Fecha fechaDevolucion) : base(id)
        {
            Numero = numero;
            Socio = socio;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }

        public Prestamo(NroPrestamo numero, Socio socio, Libro libro, Fecha fechaPrestamo, Fecha fechaDevolucion) : base(EntidadId.Vacia)
        {
            Numero = numero;
            Socio = socio;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
    }
}