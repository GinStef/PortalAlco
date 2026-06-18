using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class PedidoEntregaPagoDet
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short? Orden { get; set; }

    public byte IdFormaPago { get; set; }

    public decimal? Monto { get; set; }

    public decimal? MontoMn { get; set; }

    public short IdTipomovCxc { get; set; }

    public int FolioMovCxc { get; set; }

    public virtual FormaPago IdFormaPagoNavigation { get; set; } = null!;

    public virtual PedidoEntregaPago PedidoEntregaPago { get; set; } = null!;
}
