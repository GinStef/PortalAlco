using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoInventarioDet
{
    public short IdUniOper { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public int Sku { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal Precio { get; set; }

    public decimal CantidadBase { get; set; }

    public decimal CostoBase { get; set; }

    public decimal PrecioBase { get; set; }

    public short IdImpuesto { get; set; }

    public short IdUnidadMedida { get; set; }

    public decimal InvAnterior { get; set; }

    public decimal InvAnteriorBase { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual MovimientoInventario MovimientoInventario { get; set; } = null!;

    public virtual ICollection<MovimientoInventarioDetSerie> MovimientoInventarioDetSeries { get; set; } = new List<MovimientoInventarioDetSerie>();
}
