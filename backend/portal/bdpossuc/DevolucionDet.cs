using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class DevolucionDet
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

    public virtual Devolucion Devolucion { get; set; } = null!;

    public virtual ICollection<DevolucionDetSerie> DevolucionDetSeries { get; set; } = new List<DevolucionDetSerie>();

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;
}
