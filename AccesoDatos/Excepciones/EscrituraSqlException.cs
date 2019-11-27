using System;

namespace Repositorio
{
    public class EscrituraSqlException : Exception
    {
        public override string Message { get; }

        public EscrituraSqlException(string eMessage) => 
            Message = $"Error al escribir: {eMessage}";
    }
}