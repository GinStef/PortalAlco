using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class FacturaDocumento
{
    public short IdUniOper { get; set; }

    public int IdFactura { get; set; }

    public byte IdTipoDoc { get; set; }

    public int IdUniOperDoc { get; set; }

    public int IdDocumento { get; set; }

    public virtual Factura Factura { get; set; } = null!;
}
