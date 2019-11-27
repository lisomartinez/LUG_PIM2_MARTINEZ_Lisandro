using System;

namespace Repositorio
{
    public class LecturaSqlException : Exception
    {
        public override string Message { get; }
        public LecturaSqlException(string eMessage) =>
            Message = $"Error al leer: {eMessage}";
    }
}