using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class PedidoEntrega
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short IdUniOperPedido { get; set; }

    public int IdMovimientoPedido { get; set; }

    public DateTime FechaRealEntrega { get; set; }

    public byte IdEstatus { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public string CveEstatusPago { get; set; } = null!;

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string UsuarioMovimiento { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public decimal TotalPagado { get; set; }

    public byte IdEstatusRelacion { get; set; }

    public string CveEstatusFiscal { get; set; } = null!;

    public int? IdCorte { get; set; }

    public int? IdCaja { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<PedidoEntregaDet> PedidoEntregaDets { get; set; } = new List<PedidoEntregaDet>();
}
