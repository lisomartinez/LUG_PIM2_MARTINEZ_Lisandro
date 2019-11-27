using System.Collections.Generic;
using Entidades.Autores;
using Entidades.Prestamos;

namespace Entidades.Publicaciones
{
    public class Libro : Entidad
    {
        public NroPublicacion Numero { get; }
        public List<Autor> Autores { get; set; }
        public Fecha Fecha { get; }
        public Titulo Titulo { get; }
        public ISBN Isbn { get; }
        public Editorial Editorial { get; }

        public Libro(EntidadId id, NroPublicacion numero, List<Autor> autores, Fecha fecha, Titulo titulo, ISBN isbn, Editorial editorial) : base(id)
        {
            Numero = numero;
            Autores = autores;
            Fecha = fecha;
            Titulo = titulo;
            Isbn = isbn;
            Editorial = editorial;
        }

        public Libro(NroPublicacion numero, List<Autor> autores, Fecha fecha, Titulo titulo, ISBN isbn, Editorial editorial) : base(EntidadId.Vacia)
        {
            Numero = numero;
            Autores = autores;
            Fecha = fecha;
            Titulo = titulo;
            Isbn = isbn;
            Editorial = editorial;
        }
    }
}