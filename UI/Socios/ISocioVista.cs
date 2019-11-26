using System.Collections.Generic;
using Tests;

namespace UI.Socios
{
    public interface ISocioVista
    {
        List<SocioDto> Socios { get; set; }
    }
}