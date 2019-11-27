using System;
using UI.Prestamos.Controles;

namespace UI.Prestamos
{
    public class DatosPrestamoInvalidosException : Exception
    {
        public override string Message { get; }

        public DatosPrestamoInvalidosException(DatosPrestamo vistaDatosPrestamoControl)
        {
            Message = $"Datos del préstamo inválidos: {vistaDatosPrestamoControl}";
        }
    }
}