using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatCodigoPostal
{
    public int IdCodigoPostal { get; set; }

    public string CveCodigoPostal { get; set; } = null!;

    public string? CveEstado { get; set; }

    public string? CveMunicipio { get; set; }

    public string? CveLocalidad { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
