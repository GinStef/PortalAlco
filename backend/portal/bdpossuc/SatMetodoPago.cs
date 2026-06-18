using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatMetodoPago
{
    public int IdMetodoPagoSat { get; set; }

    public string CveMetodoPago { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? FechaIniVig { get; set; }

    public DateTime? FechaFinVig { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
