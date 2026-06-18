using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatUsoComprobantesCfdi
{
    public int IdUsoComp { get; set; }

    public string CveUsoComp { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaIniVig { get; set; }

    public DateTime? FechaFinVig { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
