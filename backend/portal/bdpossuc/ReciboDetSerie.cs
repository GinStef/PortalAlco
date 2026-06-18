using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ReciboDetSerie
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public int Sku { get; set; }

    public string Serie { get; set; } = null!;

    public virtual ReciboDet ReciboDet { get; set; } = null!;
}
