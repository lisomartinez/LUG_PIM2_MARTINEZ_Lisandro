using System;
using System.Collections.Generic;
using UI.Publicaciones;
using UI.Socios;

namespace UI.Prestamos
{
    public interface IPrestamoVista
    {
        List<PrestamoDto> Prestamos { get; set; }
        List<SocioDto> Socios { get; set; }
        List<LibroDto> Libros { get; set; }
        LibroDto Libro { get; set; }
        SocioDto Socio { get; set; }
        DateTime FechaDevolucion { get; set; }
        int Numero { get; set; }
        PrestamoDto Prestamo { get; set; }
        void MostrarMensaje(string eMessage);
    }
}