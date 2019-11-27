using System;

namespace UI.Socios
{
    public class DatosSocioInvalidosException : Exception
    {
        public override string Message { get; }

        public DatosSocioInvalidosException(DatosSocio vistaDatosSocio)
        {
            Message = $"Verifique los datos del socio: {vistaDatosSocio}";
        }
    }
}