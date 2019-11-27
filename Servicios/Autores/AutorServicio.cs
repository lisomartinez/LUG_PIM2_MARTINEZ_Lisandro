﻿using System;
using System.Collections.Generic;
using Entidades.Autores;
using Repositorio.Autores;

namespace Servicios.Autores
{
    public class AutorServicio : IServicio<Autor>
    {
        private IRepositorio<Autor> _repositorio;

        public AutorServicio(IRepositorio<Autor> repositorio)
        {
            _repositorio = repositorio;
        }

        public AutorServicio()
        {
            _repositorio = new AutorRepositorio();
        }

        public List<Autor> ObtenerTodos()
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

        public void Guardar(Autor entidad)
        {
            try
            {
                _repositorio.Guardar(entidad);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public void Modificar(Autor entidad)
        {
            try
            {
                _repositorio.Modificar(entidad);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Eliminar(Autor entidad)
        {
            try
            {
                _repositorio.Eliminar(entidad);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}