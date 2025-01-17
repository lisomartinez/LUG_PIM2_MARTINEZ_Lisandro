﻿using System;
using System.Collections.Generic;
using Entidades.Publicaciones;
using Repositorio.Publicaciones;

namespace Servicios.Publicaciones
{
    public class LibroServicio : IServicio<Libro>
    {
        private IRepositorio<Libro> _repositorio;

        public LibroServicio(IRepositorio<Libro> repositorio)
        {
            _repositorio = repositorio;
        }

        public LibroServicio()
        {
            _repositorio = new LibroRepositorio();
        }

        public List<Libro> ObtenerTodos()
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

        public void Guardar(Libro entidad)
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

        public void Modificar(Libro entidad)
        {
            try
            {
                var guardado = _repositorio.Modificar(entidad);
                if (!guardado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                throw new ModificarEntidadErrorException(entidad);
            }
        }

        public void Eliminar(Libro entidad)
        {
            try
            {
                var guardado = _repositorio.Eliminar(entidad);
                if (!guardado) throw new ArgumentException();
            }
            catch (Exception e)
            {
                
                throw new EliminarLibroException(entidad);
            }
        }

        public bool VerificarDuplicados(Libro entidad)
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