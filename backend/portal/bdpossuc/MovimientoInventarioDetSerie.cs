using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoInventarioDetSerie
{
    public short IdUniOper { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public int Sku { get; set; }

    public string Serie { get; set; } = null!;

    public virtual MovimientoInventarioDet MovimientoInventarioDet { get; set; } = null!;
}
