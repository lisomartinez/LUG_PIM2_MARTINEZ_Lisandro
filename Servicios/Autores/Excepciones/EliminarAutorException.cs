using System;
using Entidades.Autores;

namespace Servicios.Autores
{
    public class EliminarAutorException : Exception
    {
        public override string Message { get; }

        public EliminarAutorException(Autor entidad)
        {
            Message = $"Ërror al eliminar el autor nro: {entidad.Numero}";
        }
    }
}