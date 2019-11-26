using System;
using System.Linq;
using Servicios;
using Tests;

namespace UI.Socios
{
    public class SocioPresentador
    {
        private ISocioVista _vista;
        private IServicio<Socio> _servicio;

        public SocioPresentador(ISocioVista vista)
        {
            _vista = vista;
            _servicio = new SocioServicio();
        }

        public void MostrarSocios()
        {
            try
            {
                _vista.Socios = _servicio.ObtenerTodos()
                    .Select(SocioDto.FromEntity)
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}