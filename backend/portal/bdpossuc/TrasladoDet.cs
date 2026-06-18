using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TrasladoDet
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

    public decimal CantidadRecibida { get; set; }

    public decimal CantidadRecibidaBase { get; set; }

    public decimal CantidadFaltante { get; set; }

    public decimal CantidadFaltanteBase { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Traslado Traslado { get; set; } = null!;
}
