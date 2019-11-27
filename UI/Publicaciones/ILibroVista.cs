using System;
using System.Collections.Generic;
using UI.Autores;

namespace UI.Publicaciones
{
    public interface ILibroVista
    {
        List<LibroDto> Libros { get; set; }
        LibroDto Libro { get; set; }
        int Numero { get; set; }
        string Titulo { get; set; }
        string Editorial { get; set; }
        DateTime Fecha { get; set; }
        string Isbn { get; set; }
        List<AutorDto> Autores { get; set; }
        List<AutorDto> ListaAutores { get; set; }
        AutorDto AutorSeleccionado { get; set; }
        AutorDto AutorLibroSeleccionado { get; set; }
        void MostrarMensaje(string eMessage);
    }
}