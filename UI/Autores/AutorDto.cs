using System.ComponentModel;
using Entidades;
using Entidades.Autores;

namespace UI.Autores
{
    public class AutorDto
    {
        [Browsable(false)]
        public EntidadId Id { get; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private AutorDto(EntidadId id, int numero, string nombre, string apellido)
        {
            Id = id;
            Numero = numero;
            Nombre = nombre;
            Apellido = apellido;
        }

        public static AutorDto FromEntity(Autor autor) => new AutorDto(autor.Id, autor.Numero.AsInt(), autor.Nombre.ToString(), autor.Apellido.ToString());
        public Autor ToEntity() =>
            new Autor(Id, NroAutor.Of(Numero),  Entidades.Shared.Nombre.Of(Nombre), Entidades.Shared.Apellido.Of(Apellido));

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}