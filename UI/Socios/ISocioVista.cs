using System.Collections.Generic;
using Tests;

namespace UI.Socios
{
    public interface ISocioVista
    {
        List<SocioDto> Socios { get; set; }
        int NroSocio { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        bool Activo { get; set; }
        SocioDto Socio { get; set; }
        DatosSocio DatosSocioControl { get; set; }
        void MostrarMensaje(string exceptionMessage);
    }
}