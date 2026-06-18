using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloConsolidar
{
    public int Sku { get; set; }

    public int SkuConsolidar { get; set; }

    public bool IndDefault { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Articulo SkuConsolidarNavigation { get; set; } = null!;

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
