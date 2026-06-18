using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class InventarioSerie
{
    public short IdUniOper { get; set; }

    public int Sku { get; set; }

    public string Serie { get; set; } = null!;

    public bool IndExistencia { get; set; }

    public bool IndApartado { get; set; }

    public bool IndVigente { get; set; }

    public virtual Inventario Inventario { get; set; } = null!;
}
