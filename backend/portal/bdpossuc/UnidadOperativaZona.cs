using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UnidadOperativaZona
{
    public short IdZona { get; set; }

    public string NomZona { get; set; } = null!;

    public string AbrevZona { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }
}
