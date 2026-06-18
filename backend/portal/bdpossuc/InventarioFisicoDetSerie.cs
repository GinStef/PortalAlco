using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class InventarioFisicoDetSerie
{
    public short IdUniOper { get; set; }

    public int FolioInventario { get; set; }

    public int Sku { get; set; }

    public string Serie { get; set; } = null!;

    public bool Tipo { get; set; }

    public virtual InventarioFisicoDet InventarioFisicoDet { get; set; } = null!;
}
