using System.Collections.Generic;

namespace Servicios
{
    public interface IServicio<T>
    {
        List<T> ObtenerTodos();
    }
}