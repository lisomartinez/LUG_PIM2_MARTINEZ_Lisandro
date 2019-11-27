using System;
using System.Collections.Generic;

namespace Servicios
{
    public interface IRepositorio<T>
    {
        List<T> ObtenerTodos();
        bool Guardar(T entidad);
        bool Modificar(T entidad);
        bool Eliminar(T entidad);
        bool VerificarDuplicado(int numero);
    }
}