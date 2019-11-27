using System;
using Entidades.Autores;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Tests;

namespace Servicios
{
    public class ModificarEntidadErrorException : Exception
    {
        public override string Message { get; }

        public ModificarEntidadErrorException(Socio entidad)
        {
            Message = $"Error al modificar el socio nro {entidad.NroSocio}";
        }

        public ModificarEntidadErrorException(Libro entidad)
        {
            Message = $"Error al modificar el libro nro {entidad.Numero}";
        }

        public ModificarEntidadErrorException(Prestamo entidad)
        {
            Message = $"Error al modificar el prestamo nro: {entidad.Numero}";
        }

        public ModificarEntidadErrorException(Autor entidad)
        {
            Message = $"Error al modificar el autor nro: {entidad.Numero}";
        }
    }
}