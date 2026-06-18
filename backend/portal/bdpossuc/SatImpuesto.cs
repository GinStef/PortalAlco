using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatImpuesto
{
    public short IdImpuestoSat { get; set; }

    public string ClaveImpuestoSat { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public short? Retencion { get; set; }

    public short? Traslado { get; set; }

    public string? LocalFederal { get; set; }

    public string? EntidadAplica { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
