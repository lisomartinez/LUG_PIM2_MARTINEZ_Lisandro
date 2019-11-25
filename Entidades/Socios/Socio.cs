namespace Tests
{
    public class Socio
    {
        public NroSocio NroSocio { get; }
        public Nombre Nombre { get; }
        public Apellido Apellido { get; }

        public Socio(NroSocio nroSocio, Nombre nombre, Apellido apellido)
        {
            NroSocio = nroSocio;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}