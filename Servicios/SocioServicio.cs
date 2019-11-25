using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace Servicios
{
    public class SocioServicio : IServicio<Socio>
    {
        private IRepositorio<Socio> _repositorio;
        public List<Socio> ObtenerTodos() => _repositorio.ObtenerTodos();
    }
}
