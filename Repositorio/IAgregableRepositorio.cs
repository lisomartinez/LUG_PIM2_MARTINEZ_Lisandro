using System.Collections.Generic;
using Servicios;

namespace Repositorio
{
    public interface IAgregableRepositorio<in TK, TV> { 
        void Agregar(TK agregado, TV entidad);
        void Eliminar(TK agregado, TV entidad);
        List<TV> ObtenerEntidades(TK agregado);
    }
}