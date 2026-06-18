using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoMovimientoCaja
{
    public int IdTipomovCaja { get; set; }

    public string NomTipomovCaja { get; set; } = null!;

    public string AbrevTipomovCaja { get; set; } = null!;

    public short IndEntradasalida { get; set; }

    public byte IndTipoCaja { get; set; }

    public bool IndManauto { get; set; }

    public short IdDocumento { get; set; }

    public int? IdTipomovCajaAnula { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public int? IdMovTraslado { get; set; }

    public virtual ICollection<TipoMovimientoCajaTipoPago> TipoMovimientoCajaTipoPagos { get; set; } = new List<TipoMovimientoCajaTipoPago>();
}
