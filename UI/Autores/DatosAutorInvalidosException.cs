using System;

namespace UI.Autores
{
    public class DatosAutorInvalidosException : Exception
    {
        public override string Message { get; }

        public DatosAutorInvalidosException(DatosAutor vistaDatosAutorControl)
        {
            Message = $"Los datos del autor son inválidos. {vistaDatosAutorControl}";
        }
    }
}