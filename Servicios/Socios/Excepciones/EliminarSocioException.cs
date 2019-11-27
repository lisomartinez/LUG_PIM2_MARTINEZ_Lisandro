using System;
using Entidades.Publicaciones;
using Tests;

namespace Servicios
{
    public class EliminarSocioException : Exception
    {
        public override string Message { get; }

        public EliminarSocioException(Socio entidad)
        {
            Message = $"El socio tiene prestamos pendientes. Eliminelos antes de continuar. Socio Nro: {entidad.NroSocio}";
        }

    }
}