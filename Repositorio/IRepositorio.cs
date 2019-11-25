using System.Collections.Generic;

namespace Servicios
{
    public interface IRepositorio<T>
    {
        List<T> ObtenerTodos();
    }
}