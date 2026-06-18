using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class VentaDetalleComp
{
    public short IdUniOper { get; set; }

    public int IdVenta { get; set; }

    public int Orden { get; set; }

    public int Sku { get; set; }

    public int SkuTransformado { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal PrecioVenta { get; set; }

    public decimal PrecioVentaSinIva { get; set; }

    public decimal PrecioCliente { get; set; }

    public decimal PrecioClienteSinIva { get; set; }

    public short IdImpuesto { get; set; }

    public short IdUnidadMedida { get; set; }

    public decimal? CantidadProd { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;
}
