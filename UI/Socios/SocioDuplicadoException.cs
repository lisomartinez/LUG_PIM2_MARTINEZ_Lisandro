using System;
using Tests;

namespace UI.Socios
{
    public class SocioDuplicadoException : Exception
    {
        public override string Message { get; }

        public SocioDuplicadoException(Socio socioEntidad)
        {
            Message = $"Ya existe un socio con el número: {socioEntidad.NroSocio}";
        }
    }
}