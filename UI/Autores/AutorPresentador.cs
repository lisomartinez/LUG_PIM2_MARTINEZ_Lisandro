using System;
using System.Linq;
using Entidades.Autores;
using Entidades.Shared;
using Servicios;
using Servicios.Autores;

namespace UI.Autores
{
    public class AutorPresentador
    {
        private IAutorVista _vista;
        private IServicio<Autor> _servicio;

        public AutorPresentador(IAutorVista vista, IServicio<Autor> servicio)
        {
            _vista = vista;
            _servicio = servicio;
        }

        public AutorPresentador(IAutorVista vista)
        {
            _vista = vista;
            _servicio = new AutorServicio();
        }

        public void MostrarAutores()
        {
            try
            {
                _vista.Autores = _servicio.ObtenerTodos().Select(AutorDto.FromEntity).ToList();

            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void MostrarAutor()
        {
            try
            {
                var autor = _vista.Autor;
                _vista.Nro = autor.Numero;
                _vista.Nombre = autor.Nombre;
                _vista.Apellido = autor.Apellido;
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void Guardar()
        {
            try
            {
                if (!_vista.DatosAutorControl.Valido) throw new DatosAutorInvalidosException(_vista.DatosAutorControl);
                var nro = _vista.Nro;
                var nombre = _vista.Nombre;
                var apellido = _vista.Apellido;
                var autor = new Autor(
                    numero: NroAutor.Of(nro),
                    nombre: Nombre.Of(nombre),
                    apellido: Apellido.Of(apellido)
                );
                if (_servicio.VerificarDuplicados(autor)) throw new AutorDuplicadoException(autor);
                _servicio.Guardar(autor);
                MostrarAutores();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void Modificar()
        {
            try
            {
                if (!_vista.DatosAutorControl.Valido) throw new DatosAutorInvalidosException(_vista.DatosAutorControl);
                var autor = _vista.Autor;
                autor.Numero = _vista.Nro;
                autor.Nombre = _vista.Nombre;
                autor.Apellido = _vista.Apellido;

                if(_servicio.VerificarDuplicados(autor.ToEntity())) throw new AutorDuplicadoException(autor.ToEntity());
                _servicio.Modificar(autor.ToEntity());
                MostrarAutores();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        public void Eliminar()
        {
            try
            {
                var autor = _vista.Autor;
                _servicio.Eliminar(autor.ToEntity());
                MostrarAutores();
                LimpiarDatosAutor();
            }
            catch (Exception e)
            {
                MostrarMensaje(e.Message);
            }

        }

        private void MostrarMensaje(string eMessage)
        {
            _vista.MostrarMensaje(eMessage);
        }

        private void LimpiarDatosAutor()
        {
            _vista.Nro = 0;
            _vista.Nombre = "";
            _vista.Apellido = "";
        }
    }
}