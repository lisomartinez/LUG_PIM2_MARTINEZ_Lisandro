using System;

namespace Servicios
{
    public class ObtenerTodosErrorException : Exception
    {
        public override string Message => "Error al obtener todas las entidades. Verifique la conexión a la BD";
    }
}