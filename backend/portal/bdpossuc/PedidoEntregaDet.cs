using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class PedidoEntregaDet
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public int Sku { get; set; }

    public int Orden { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal Precio { get; set; }

    public decimal CantidadBase { get; set; }

    public decimal CostoBase { get; set; }

    public decimal PrecioBase { get; set; }

    public short IdImpuesto { get; set; }

    public short IdUnidadMedida { get; set; }

    public byte IndOriginal { get; set; }

    public decimal CantidadPedido { get; set; }

    public decimal CantidadPedidoBase { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public string? Comentario { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public decimal SubtotalPartida { get; set; }

    public decimal TotalPartida { get; set; }

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual PedidoEntrega PedidoEntrega { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
