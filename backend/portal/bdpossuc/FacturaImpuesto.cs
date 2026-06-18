using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class FacturaImpuesto
{
    public short IdUniOper { get; set; }

    public int IdFactura { get; set; }

    public short IdImpuesto { get; set; }

    public decimal TasaImpuesto { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Impuesto { get; set; }

    public virtual Factura Factura { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;
}
