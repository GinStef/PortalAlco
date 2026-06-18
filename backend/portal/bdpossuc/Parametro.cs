using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Parametro
{
    public byte IdParametro { get; set; }

    public string NombreParametro { get; set; } = null!;

    public string ValorParametro { get; set; } = null!;

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }
}
