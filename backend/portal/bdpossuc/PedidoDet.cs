using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class PedidoDet
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

    public short IdUnidadMedida { get; set; }

    public short IdImpuesto { get; set; }

    public decimal TotalPartida { get; set; }

    public string? Comentario { get; set; }

    public string CveEstatus { get; set; } = null!;

    public decimal CantidadEntregada { get; set; }

    public decimal CantidadEntregadaBase { get; set; }

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual Pedido Pedido { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
