using System;

namespace UI.Publicaciones
{
    public class DatosLibroInvalidosException : Exception
    {
        public override string Message { get; }

        public DatosLibroInvalidosException(DatosLibro vistaDatosLibroControl)
        {
            Message = $"Datos del libro inválidos. {vistaDatosLibroControl}";
        }
    }
}