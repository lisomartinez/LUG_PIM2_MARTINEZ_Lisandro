using System.Collections.Generic;

namespace UI.Autores
{
    public interface IAutorVista
    {
        List<AutorDto> Autores { get; set; }
        AutorDto Autor { get; set; }
        int Nro { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        DatosAutor DatosAutorControl { get; set; }
        void MostrarMensaje(string eMessage);
    }
}