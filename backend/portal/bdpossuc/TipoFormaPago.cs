using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoFormaPago
{
    public byte IdTipoForma { get; set; }

    public string NomTipoForma { get; set; } = null!;

    public bool IndUnico { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public byte? IndEfvoDoc { get; set; }

    public virtual ICollection<TipoMovimientoCajaTipoPago> TipoMovimientoCajaTipoPagos { get; set; } = new List<TipoMovimientoCajaTipoPago>();
}
