using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CodigoArticulo
{
    public string IdCodigoBarras { get; set; } = null!;

    public int Sku { get; set; }

    public bool Principal { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Articulo SkuNavigation { get; set; } = null!;
}
