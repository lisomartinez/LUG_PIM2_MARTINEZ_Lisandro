using Entidades.Shared;

namespace Entidades.Autores
{
    public class Autor : Entidad
    {
        public NroAutor Numero { get; }
        public Nombre Nombre { get; }
        public Apellido Apellido { get; }

        public Autor(EntidadId id, NroAutor numero, Nombre nombre, Apellido apellido) : base(id)
        {
            this.Numero = numero;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Autor(NroAutor numero, Nombre nombre, Apellido apellido) : base(EntidadId.Vacia)
        {
            this.Numero = numero;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}