using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TrasladoReciboDet
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

    public decimal CantidadTraslado { get; set; }

    public decimal CantidadTrasladoBase { get; set; }

    public decimal CantidadFaltante { get; set; }

    public decimal CantidadFaltanteBase { get; set; }

    public byte IndAfectaInv { get; set; }

    public short? IdMotivo { get; set; }

    public short? IdTipomov { get; set; }

    public int? FolioMov { get; set; }

    public string? Comentario { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public decimal CantidadTotal { get; set; }

    public decimal CantidadTotalBase { get; set; }

    public int? IdMovimientoMotivo { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual TrasladoRecibo TrasladoRecibo { get; set; } = null!;
}
