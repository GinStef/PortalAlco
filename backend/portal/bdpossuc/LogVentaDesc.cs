using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogVentaDesc
{
    public short IdUniOper { get; set; }

    public int IdLog { get; set; }

    public int Sku { get; set; }

    public int IdUsuario { get; set; }

    public decimal Descuento { get; set; }

    public virtual LogVentum LogVentum { get; set; } = null!;
}
