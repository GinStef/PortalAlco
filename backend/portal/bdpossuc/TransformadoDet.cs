using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TransformadoDet
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

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual Transformado Transformado { get; set; } = null!;

    public virtual ICollection<TransformadoDetComp> TransformadoDetComps { get; set; } = new List<TransformadoDetComp>();

    public virtual ICollection<TransformadoDetSerie> TransformadoDetSeries { get; set; } = new List<TransformadoDetSerie>();
}
