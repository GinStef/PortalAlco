using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class PedidoEntregaPago
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public decimal? MontoMn { get; set; }

    public byte? IdEstatus { get; set; }

    public int? IdUniOperPedidoEntrega { get; set; }

    public int? IdMovimientoPedidoEntrega { get; set; }

    public int? IdUniOperPedido { get; set; }

    public int? IdMovimientoPedido { get; set; }

    public short? IdTipomovCxc { get; set; }

    public int? FolioMovCxc { get; set; }

    public string UsuarioMovimiento { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public short? IdTipomovAnulaCxc { get; set; }

    public int? FolioMovAnulaCxc { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? IdSuperpago { get; set; }

    public int? IdCorte { get; set; }

    public int? IdCaja { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<PedidoEntregaPagoDet> PedidoEntregaPagoDets { get; set; } = new List<PedidoEntregaPagoDet>();
}
