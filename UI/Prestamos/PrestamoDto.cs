using System;
using System.ComponentModel;
using Entidades;
using Entidades.Prestamos;
using UI.Publicaciones;
using UI.Socios;

namespace UI.Prestamos
{
    public class PrestamoDto : IEquatable<PrestamoDto>
    {
        [Browsable(false)]
        public EntidadId Id { get; }
        public int Numero { get; }

        [Browsable(false)]
        public SocioDto Socio { get; }

        [System.ComponentModel.DisplayName("Socio")]
        public string SocioStr { get; }

        [Browsable(false)]
        public LibroDto Libro { get; }

        [System.ComponentModel.DisplayName("Libro")]

        public string LibroStr { get; }
        [System.ComponentModel.DisplayName("Fecha De Prestamo")]
        public DateTime FechaPrestamo { get; }
        [System.ComponentModel.DisplayName("Fecha De Devolución")]

        public DateTime FechaDevolucion { get; }

        private PrestamoDto(EntidadId id, int numero, SocioDto socio, LibroDto libro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            Id = id;
            Numero = numero;
            Socio = socio;
            SocioStr = socio.Nombre.ToString() + " " + socio.Apellido.ToString();
            Libro = libro;
            LibroStr = libro.Titulo.ToString();
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }

        public static PrestamoDto FromEntity(Prestamo prestamo) =>
            new PrestamoDto(
                id: prestamo.Id, 
                numero: prestamo.Numero.AsInt(), 
                socio: SocioDto.FromEntity(prestamo.Socio),
                libro: LibroDto.FromEntity(prestamo.Libro),
                fechaPrestamo: prestamo.FechaPrestamo.ToDateTime(),
                fechaDevolucion: prestamo.FechaDevolucion.ToDateTime());

        public Prestamo ToEntity() =>
            new Prestamo(
                id: Id,
                numero: NroPrestamo.Of(Numero), 
                socio: Socio.ToEntity(),
                libro: Libro.ToEntity(),
                fechaPrestamo: Fecha.Of(FechaPrestamo),
                fechaDevolucion: Fecha.Of(FechaDevolucion)
            );


        public bool Equals(PrestamoDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PrestamoDto) obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}