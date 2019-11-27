using System;
using Entidades.Autores;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Tests;

namespace Servicios
{
    public class GuardarEntidadErrorException : Exception
    {
        public override string Message { get; }

        public GuardarEntidadErrorException(Socio entidad)
        {
            Message = $"Error al guardar el socio nro = {entidad.NroSocio}";
        }

        public GuardarEntidadErrorException(Libro entidad)
        {
            Message = $"Error al guardar el libro nro: {entidad.Numero}";
        }

        public GuardarEntidadErrorException(Prestamo entidad)
        {
            Message = $"Error al guardar el prestamo nro: {entidad.Numero}";
        }

        public GuardarEntidadErrorException(Autor entidad)
        {
            Message = $"Error al guardar el autor nro {entidad.Numero}";
        }
    }
}