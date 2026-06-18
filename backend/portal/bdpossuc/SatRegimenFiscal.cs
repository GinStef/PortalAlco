using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatRegimenFiscal
{
    public short IdRegimenFiscalSat { get; set; }

    public string CveRegimenFiscal { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public short? Fisica { get; set; }

    public short? Moral { get; set; }

    public DateTime? FechaIniVig { get; set; }

    public DateTime? FechaFinVig { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
