using System;
using System.Linq;
using Entidades.Shared;
using Entidades.Socios;
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

        public void MostrarSocio()
        {
            var socio = _vista.Socio;
            _vista.NroSocio = socio.Nro;
            _vista.Nombre = socio.Nombre;
            _vista.Apellido = socio.Apellido;
            _vista.Activo = socio.Activo;
        }

        public void Eliminar()
        {
            _servicio.Eliminar(_vista.Socio.ToEntity());
            MostrarSocios();
            LimpiarDatosSocio();
        }

        private void LimpiarDatosSocio()
        {
            _vista.NroSocio = 0;
            _vista.Nombre = "";
            _vista.Apellido = "";
            _vista.Activo = false;
        }

        public void Modificar()
        {
            var socio = _vista.Socio;
            socio.Nro = _vista.NroSocio;
            socio.Nombre = _vista.Nombre;
            socio.Apellido = _vista.Apellido;
            socio.Activo = _vista.Activo;
            _servicio.Modificar(socio.ToEntity());
            MostrarSocios();
        }

        public void Guardar()
        {
            var nro = NroSocio.Of(_vista.NroSocio);
            var nombre = Nombre.Of(_vista.Nombre);
            var apellido = Apellido.Of(_vista.Apellido);
            var activo = Estado.Of(_vista.Activo);
            var socio = new Socio(
                 nroSocio: nro,
                 nombre: nombre,
                 apellido: apellido,
                 activo: activo
                );
            _servicio.Guardar(socio);
        }
    }
}