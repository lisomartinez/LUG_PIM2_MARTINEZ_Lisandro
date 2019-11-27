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
            _vista.Autores = _servicio.ObtenerTodos().Select(AutorDto.FromEntity).ToList();
        }

        public void MostrarAutor()
        {
            var autor = _vista.Autor;
            _vista.Nro = autor.Numero;
            _vista.Nombre = autor.Nombre;
            _vista.Apellido = autor.Apellido;
        }

        public void Guardar()
        {
            var nro = _vista.Nro;
            var nombre = _vista.Nombre;
            var apellido = _vista.Apellido;
            var autor = new Autor(
                numero: NroAutor.Of(nro),
                nombre: Nombre.Of(nombre),
                apellido: Apellido.Of(apellido)
            );
            _servicio.Guardar(autor);
            MostrarAutores();
        }

        public void Modificar()
        {
            var autor = _vista.Autor;
            autor.Numero = _vista.Nro;
            autor.Nombre = _vista.Nombre;
            autor.Apellido = _vista.Apellido;
            _servicio.Modificar(autor.ToEntity());
            MostrarAutores();
        }

        public void Eliminar()
        {
            var autor = _vista.Autor;
            _servicio.Eliminar(autor.ToEntity());
            MostrarAutores();
            LimpiarDatosAutor();
        }

        private void LimpiarDatosAutor()
        {
            _vista.Nro = 0;
            _vista.Nombre = "";
            _vista.Apellido = "";
        }
    }
}