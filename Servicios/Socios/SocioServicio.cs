﻿using System;
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

        public List<Socio> ObtenerTodos()
        {
            try
            {
                return _repositorio.ObtenerTodos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Guardar(Socio entidad)
        {
            try
            {
                var guardado = _repositorio.Guardar(entidad);
                if (!guardado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Modificar(Socio entidad)
        {
            try
            {
                var modificado = _repositorio.Modificar(entidad);
                if (!modificado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public void Eliminar(Socio entidad)
        {
            try
            {
                var eliminado = _repositorio.Eliminar(entidad);
                if (!eliminado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}