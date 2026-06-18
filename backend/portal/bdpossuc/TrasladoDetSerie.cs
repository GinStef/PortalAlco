using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TrasladoDetSerie
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public int Sku { get; set; }

    public string Serie { get; set; } = null!;
}
