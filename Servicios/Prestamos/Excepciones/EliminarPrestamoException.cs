using System;
using Entidades.Prestamos;

namespace Servicios.Prestamos
{
    public class EliminarPrestamoException : Exception
    {
        public override string Message { get; }

        public EliminarPrestamoException(Prestamo entidad)
        {
            Message = $"Error al eliminar el prestamo nro: {entidad.Numero}";
        }
    }
}