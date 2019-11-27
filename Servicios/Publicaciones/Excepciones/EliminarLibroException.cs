using System;
using Entidades.Publicaciones;

namespace Servicios.Publicaciones
{
    public class EliminarLibroException : Exception
    {
        public override string Message { get; }

        public EliminarLibroException(Libro entidad)
        {
            Message = $"El libro se encuentra en prestamo. Devuelvalo antes de borrarlo.";
        }
    }
}