using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatFormaPago
{
    public short IdFormaPagoSat { get; set; }

    public string ClaveFormaPagoSat { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? FechaIniVigencia { get; set; }

    public DateTime? FechaFinVigencia { get; set; }

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public bool? Reqcuenta { get; set; }
}
