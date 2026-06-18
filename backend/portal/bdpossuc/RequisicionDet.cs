using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class RequisicionDet
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

    public string CveEstatus { get; set; } = null!;

    public decimal CantidadSurtida { get; set; }

    public decimal CantidadSurtidaBase { get; set; }

    public decimal Existencia { get; set; }

    public decimal ExistenciaBase { get; set; }

    public short IdImpuesto { get; set; }

    public decimal CantidadLiberada { get; set; }

    public decimal CantidadLiberadaBase { get; set; }

    public string? Comentario { get; set; }

    public decimal? Stock { get; set; }

    public decimal? Sugerido { get; set; }

    public decimal? SugeridoBase { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual Requisicion Requisicion { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
