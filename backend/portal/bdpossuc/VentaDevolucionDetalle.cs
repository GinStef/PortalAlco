using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class VentaDevolucionDetalle
{
    public short IdUniOper { get; set; }

    public int IdDevolucion { get; set; }

    public int Sku { get; set; }

    public int Orden { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal PrecioNeto { get; set; }

    public decimal PrecioNetoSinIva { get; set; }

    public short IdImpuesto { get; set; }

    public short IdUnidadMedida { get; set; }

    public decimal CantidadBase { get; set; }

    public decimal CostoBase { get; set; }

    public decimal CostoBaseConIva { get; set; }

    public decimal PrecioNetoBase { get; set; }

    public decimal PrecioNetoBaseSinIva { get; set; }

    public virtual ArticuloEmpaque ArticuloEmpaque { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual VentaDevolucion VentaDevolucion { get; set; } = null!;
}
