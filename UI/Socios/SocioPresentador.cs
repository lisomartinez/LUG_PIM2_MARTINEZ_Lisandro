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
                MostrarMensaje(e);

            }

        }

        private void MostrarMensaje(Exception exception)
        {
            _vista.MostrarMensaje(exception.Message);
        }

        public void MostrarSocio()
        {
            try
            {
                var socio = _vista.Socio;
                _vista.NroSocio = socio.Nro;
                _vista.Nombre = socio.Nombre;
                _vista.Apellido = socio.Apellido;
                _vista.Activo = socio.Activo;
            }
            catch (Exception e)
            {
                MostrarMensaje(e);
            }

        }

        public void Eliminar()
        {
            try
            {
                _servicio.Eliminar(_vista.Socio.ToEntity());
                MostrarSocios();
                LimpiarDatosSocio();
            }
            catch (Exception e)
            {
                MostrarMensaje(e);
            }


        }

        private void LimpiarDatosSocio()
        {
            try
            {
                _vista.NroSocio = 0;
                _vista.Nombre = "";
                _vista.Apellido = "";
                _vista.Activo = false;
            }
            catch (Exception e)
            {
                MostrarMensaje(e);
            }


        }

        public void Modificar()
        {
            try
            {
                if (!_vista.DatosSocioControl.Valido) throw new DatosSocioInvalidosException(_vista.DatosSocioControl);

                var socio = _vista.Socio;
                socio.Nro = _vista.NroSocio;
                socio.Nombre = _vista.Nombre;
                socio.Apellido = _vista.Apellido;
                socio.Activo = _vista.Activo;
                var socioEntidad = socio.ToEntity();
                if (_servicio.VerificarDuplicados(socioEntidad)) throw new SocioDuplicadoException(socioEntidad);
                
                _servicio.Modificar(socioEntidad);
                MostrarSocios();
                
            }
            catch (Exception e)
            {
                MostrarMensaje(e);
            }


        }

        public void Guardar()
        {
            try
            {
                if (!_vista.DatosSocioControl.Valido) throw new DatosSocioInvalidosException(_vista.DatosSocioControl);

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
                if (_servicio.VerificarDuplicados(socio)) throw new SocioDuplicadoException(socio);

                _servicio.Guardar(socio);
                MostrarSocios();

            }
            catch (Exception e)
            {
                MostrarMensaje(e);
            }


        }
    }
}