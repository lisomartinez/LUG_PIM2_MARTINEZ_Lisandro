using System.Collections.Generic;

namespace Servicios
{
    public interface IServicio<T>
    {
        List<T> ObtenerTodos();
        void Guardar(T entidad);
        void Modificar(T entidad);
        void Eliminar(T entidad);
        bool VerificarDuplicados(T entidad);
    }
}