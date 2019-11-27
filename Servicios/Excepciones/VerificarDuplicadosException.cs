using System;
using Entidades.Autores;
using Entidades.Prestamos;
using Entidades.Publicaciones;
using Tests;

namespace Servicios
{
    public class VerificarDuplicadosException : Exception
    {
        public override string Message { get; }

        public VerificarDuplicadosException(Socio entidad)
        {
            Message = $"Error al verificar la duplicidad del socio nro: {entidad.NroSocio}";
        }

        public VerificarDuplicadosException(Libro entidad)
        {
            Message = $"Ërror al verificar la duplicidad del libro nro: {entidad.Numero}";
        }

        public VerificarDuplicadosException(Autor entidad)
        {
            Message = $"Error al verificar la duplicidad del autor nro: {entidad.Numero}";
        }

        public VerificarDuplicadosException(Prestamo entidad)
        {
            Message = $"Error al verificar la duplicidad del prestamo nro: {entidad.Numero}";
        }
    }
}