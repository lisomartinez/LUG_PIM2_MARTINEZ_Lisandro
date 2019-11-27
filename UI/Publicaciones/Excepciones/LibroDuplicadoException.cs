using System;
using Entidades.Publicaciones;

namespace UI.Publicaciones
{
    public class LibroDuplicadoException : Exception
    {
        public override string Message { get; }

        public LibroDuplicadoException(Libro libro)
        {
            Message = $"Ël libro se encuentra duplicado. Libro Nro: {libro.Numero}";
        }
    }
}