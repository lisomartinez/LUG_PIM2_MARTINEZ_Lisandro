using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Prestamos;
using Repositorio;

namespace Servicios.Prestamos
{
    public class PrestamoServicio : IServicio<Prestamo>
    {
        private IRepositorio<Prestamo> _repositorio;

        public PrestamoServicio(IRepositorio<Prestamo> repositorio)
        {
            _repositorio = repositorio;
        }

        public PrestamoServicio()
        {
            _repositorio = new PrestamoRepositorio();
        }

        public List<Prestamo> ObtenerTodos()
        {
            try
            {
                return _repositorio.ObtenerTodos();
            }
            catch (Exception e)
            { 
                throw new ObtenerTodosErrorException();
            }
        }

        public void Guardar(Prestamo entidad)
        {
            try
            {
                var guardado = _repositorio.Guardar(entidad);
                if (!guardado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                throw new GuardarEntidadErrorException(entidad);
            }
        }

        public void Modificar(Prestamo entidad)
        {
            try
            {
                var modificado = _repositorio.Modificar(entidad);
                if (!modificado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                throw new ModificarEntidadErrorException(entidad);
            }
        }

        public void Eliminar(Prestamo entidad)
        {
            try
            {
                var eliminado = _repositorio.Eliminar(entidad);
                if (!eliminado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                throw new EliminarPrestamoException(entidad);
            }
        }

        public bool VerificarDuplicados(Prestamo entidad)
        {
            try
            {
                return _repositorio.VerificarDuplicado(entidad);
            }
            catch (Exception e)
            { 
                throw new VerificarDuplicadosException(entidad);
            }
            
        }
    }
}
