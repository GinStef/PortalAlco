using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CambioCostoOrigen
{
    public byte IdOrigen { get; set; }

    public string NombreOrigen { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;
}
