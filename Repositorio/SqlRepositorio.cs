﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using Tests;

namespace Repositorio
{
    public abstract class SqlRepositorio<T> : IRepositorio<T>
    {
        protected SqlAdaptador Adaptador { get; }

        protected SqlRepositorio(SqlAdaptador adaptador)
        {
            Adaptador = adaptador;
        }
        
        public abstract List<T> ObtenerTodos();
    }
}