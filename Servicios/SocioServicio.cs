using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Socios;
using Tests;

namespace Servicios
{
    public class SocioServicio : IServicio<Socio>
    {
        private IRepositorio<Socio> _repositorio;

        public SocioServicio(IRepositorio<Socio> repositorio)
        {
            _repositorio = repositorio;
        }

        public SocioServicio()
        {
            _repositorio = new SocioRepositorio();
        }

        public List<Socio> ObtenerTodos() => _repositorio.ObtenerTodos();
    }
}
