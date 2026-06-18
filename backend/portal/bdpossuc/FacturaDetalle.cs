using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class FacturaDetalle
{
    public short IdUniOper { get; set; }

    public int IdFactura { get; set; }

    public int IdOrden { get; set; }

    public int? Codigo { get; set; }

    public decimal Cantidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? UnidadMedida { get; set; }

    public short IdImpuesto { get; set; }

    public decimal PrecioSinIva { get; set; }

    public decimal Precio { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Total { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoSinIva { get; set; }

    public decimal CostoSubtotal { get; set; }

    public decimal CostoImpuesto { get; set; }

    public virtual Factura Factura { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;
}
