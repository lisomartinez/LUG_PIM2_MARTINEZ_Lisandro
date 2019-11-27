using System;
using Entidades.Prestamos;

namespace UI.Prestamos
{
    public class PrestamoDuplicadoException : Exception
    {
        public override string Message { get; }

        public PrestamoDuplicadoException(Prestamo prestamo)
        {
            Message = $"Ël prestamo se enecuentra duplicado. Prestamo Nro: {prestamo.Numero}";
        }
    }
}