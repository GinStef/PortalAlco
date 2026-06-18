using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoMovimientoCajaTipoPago
{
    public int IdTipomovCaja { get; set; }

    public byte IdTipoForma { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual TipoFormaPago IdTipoFormaNavigation { get; set; } = null!;

    public virtual TipoMovimientoCaja IdTipomovCajaNavigation { get; set; } = null!;
}
